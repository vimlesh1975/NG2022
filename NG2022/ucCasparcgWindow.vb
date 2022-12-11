Public Class ucCasparcgWindow
    'This is the API that does all the hard work
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    End Function
    'This is the API used to maximize the window
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Dim parentedProcess As Process
    Private Sub cmdoutcasparcgwindow_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindow.Click
        outcasparcgwindown()
    End Sub
    Public Sub outcasparcgwindown()
        On Error Resume Next
        'This is important! If you have a child process on your form, it will terminate along with your form if you do not set its parent to Nothing
        If parentedProcess IsNot Nothing Then
            SetParent(parentedProcess.MainWindowHandle, Nothing)
        End If
    End Sub
    Public Sub SetProcessParent(ByVal processName As String)
        On Error Resume Next

        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer
        If (processes.Length = 0) And (frmNG2022.BackColor = Color.Red) Then
            MessageBox.Show("Casparcg is not running")
        Else
            If parentedProcess IsNot Nothing Then
                SetParent(parentedProcess.MainWindowHandle, Nothing)
            End If
            For iprocess = 0 To processes.GetUpperBound(0)
                If processes(iprocess).MainWindowTitle = cmbcasparcgwindowtitle.Text Then Exit For
            Next
        End If
        parentedProcess = processes(iprocess)
        If parentedProcess IsNot Nothing Then
            SetParent(parentedProcess.MainWindowHandle, Me.Panel1.Handle)
            SendMessage(parentedProcess.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        End If

    End Sub
    Private Sub cmdshowcasparcgwindow_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindow.Click
        On Error Resume Next
        SetProcessParent("casparcg")
    End Sub
    Private Sub ucCasparcgWindow_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ucCasparcgWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcasparcgwindowtitle.DataSource = New BindingSource(screenConsumres, "")
        cmbcasparcgwindowtitle.Text = "Screen consumer [1|1080i5000]"
    End Sub
    Private Sub gbcasparcgwindow_DoubleClick(sender As Object, e As EventArgs) Handles gbcasparcgwindow.DoubleClick
        'Changebackcolor(sender)
    End Sub

End Class
