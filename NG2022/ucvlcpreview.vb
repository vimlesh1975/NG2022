Partial Public Class ucvlcpreview
    Inherits ucNGBase
    Public chnumber As Integer = 1
    Dim isplaying As Boolean = False
    Private Sub cmdpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreview.Click
        On Error Resume Next
        SendCasparCommand("ADD " & chnumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        'Threading.Thread.Sleep(2000)
        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub

    Private Sub cmdpreviewkey_Click(sender As Object, e As EventArgs) Handles cmdpreviewkey.Click
        On Error Resume Next
        'If ServerVersion > 2.1 Then
        '    SendCasparCommand("ADD " & chnumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -filter:v alphaextract")

        'Else
        '    SendCasparCommand("ADD " & chnumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -vf alphaextract")

        'End If
        SendCasparCommand("ADD " & chnumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -vf alphaextract")


        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True


    End Sub


    Private Sub cmdremovepreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremovepreview.Click
        On Error Resume Next
        SendCasparCommand("remove " & chnumber & " stream " & "udp://" & cmbippreview.Text)
        vlcpreview.VlcMediaPlayer.Stop()
        isplaying = False
    End Sub
End Class


