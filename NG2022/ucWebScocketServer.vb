Partial Public Class ucWebScocketServer
    Inherits ucNGBase
    Private webSocketServer As New WebSocketServer()

    ' Start the server when button is clicked
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        webSocketServer.StartWebSocketServer()
        CheckServerStatus()
    End Sub

    ' Stop the server when button is clicked
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        webSocketServer.StopWebSocketServer()
        CheckServerStatus()
    End Sub

    ' Check the current status of the WebSocket server
    Private Sub CheckServerStatus()
        If webSocketServer.IsRunning Then
            lblStatus.Text = "Server is running"
        Else
            lblStatus.Text = "Server is stopped"
        End If
    End Sub

    Private Sub ucWebScocketServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webSocketServer.StartWebSocketServer()
        CheckServerStatus()
    End Sub
End Class


