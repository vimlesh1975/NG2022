Imports System.Net
Imports System.Net.WebSockets
Imports System.Text
Imports System.Threading

Public Class WebSocketServer
    Private serverThread As Thread
    Private listener As HttpListener
    Private _isRunning As Boolean = False

    ' List to store all connected WebSocket clients
    Private connectedClients As New List(Of WebSocket)()

    Dim responseText As String = "Hello from VB.NET WebSocket Server!"
    Dim responseBytes As Byte() = Encoding.UTF8.GetBytes(responseText)

    ' Property to check the running status of the server
    Public ReadOnly Property IsRunning As Boolean
        Get
            Return _isRunning
        End Get
    End Property

    ' Start the WebSocket server
    Public Sub StartWebSocketServer()
        If Not _isRunning Then
            _isRunning = True
            serverThread = New Thread(AddressOf StartServer)
            serverThread.IsBackground = True
            serverThread.Start()
            ' MessageBox.Show("WebSocket server started.")
        Else
            ' MessageBox.Show("Server is already running.")
        End If
    End Sub

    ' Stop the WebSocket server
    Public Async Sub StopWebSocketServer()
        If _isRunning Then
            _isRunning = False

            ' Prevent new connections
            If listener IsNot Nothing AndAlso listener.IsListening Then
                listener.Stop()
            End If

            ' Gracefully close all connected WebSocket clients
            For Each clientSocket In connectedClients.ToList() ' Use ToList() to avoid modifying the list while iterating
                If clientSocket.State = WebSocketState.Open Then
                    Try
                        ' Close the WebSocket connection
                        Await clientSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Server shutting down", CancellationToken.None)
                    Catch ex As Exception
                        Console.WriteLine("Error closing client connection: " & ex.Message)
                    End Try
                End If
            Next

            ' Clear the connected clients list
            connectedClients.Clear()

            ' Stop the server thread
            serverThread?.Abort()
            Console.WriteLine("WebSocket server stopped.")
        Else
            'MessageBox.Show("Server is not running.")
        End If
    End Sub

    ' WebSocket server logic
    Private Sub StartServer()
        listener = New HttpListener()
        listener.Prefixes.Add("http://localhost:11111/ws/")
        listener.Start()

        While _isRunning
            Try
                Dim context As HttpListenerContext = listener.GetContext()
                If context.Request.IsWebSocketRequest Then
                    HandleWebSocketRequest(context)
                Else
                    context.Response.StatusCode = 400
                    context.Response.Close()
                End If
            Catch ex As HttpListenerException
                If _isRunning Then
                    MessageBox.Show("Error: " & ex.Message)
                End If
            End Try
        End While

        listener.Close()
    End Sub

    ' Handle incoming WebSocket request
    Private Async Sub HandleWebSocketRequest(context As HttpListenerContext)
        Dim webSocketContext As HttpListenerWebSocketContext = Await context.AcceptWebSocketAsync(subProtocol:=Nothing)
        Dim webSocket As WebSocket = webSocketContext.WebSocket

        ' Add the client WebSocket to the connected clients list
        connectedClients.Add(webSocket)
        Console.WriteLine("Client connected. Total clients: " & connectedClients.Count)

        ' Start handling the client's communication asynchronously
        Await HandleClientCommunication(webSocket)
    End Sub


    Private Async Function HandleClientCommunication(clientSocket As WebSocket) As Task
        Dim buffer(1024) As Byte
        Dim shouldCloseSocket As Boolean = False ' Variable to track if we need to close the socket

        Try
            While clientSocket.State = WebSocketState.Open
                ' Receive a message from the client
                Dim result As WebSocketReceiveResult = Await clientSocket.ReceiveAsync(New ArraySegment(Of Byte)(buffer), CancellationToken.None)
                Dim receivedText As String = Encoding.UTF8.GetString(buffer, 0, result.Count)

                ' Handle the received message
                Console.WriteLine("Message received from client: " & receivedText)
                CasparDevice.SendString(receivedText)

                ' Prepare a response to the client
                Dim responseText As String = "Hello from VB.NET WebSocket Server!"
                Dim responseBytes As Byte() = Encoding.UTF8.GetBytes(responseText)

                ' Send the response back to the client
                Await clientSocket.SendAsync(New ArraySegment(Of Byte)(responseBytes), WebSocketMessageType.Text, True, CancellationToken.None)
            End While
        Catch ex As WebSocketException
            Console.WriteLine("WebSocket error: " & ex.Message)
        Catch ex As Exception
            Console.WriteLine("Error handling client: " & ex.Message)
        Finally
            ' Perform client clean-up here, no Await inside Finally
            If connectedClients.Contains(clientSocket) Then
                connectedClients.Remove(clientSocket)
            End If

            ' Set flag to close the socket after Finally block
            If clientSocket.State = WebSocketState.Open Then
                shouldCloseSocket = True
            End If

            Console.WriteLine("Client disconnected. Total clients: " & connectedClients.Count)
        End Try

        ' Close the WebSocket connection outside Finally to avoid Await in the Finally block
        If shouldCloseSocket Then
            Try
                Await clientSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None)
            Catch closeEx As Exception
                Console.WriteLine("Error closing WebSocket: " & closeEx.Message)
            End Try
        End If
    End Function


End Class
