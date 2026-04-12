Partial Public Class ucPreview
    Inherits ucNGBase
    Dim isplaying As Boolean = False

    Private Sub cmdpreviewkey_Click(sender As Object, e As EventArgs) Handles cmdpreviewkey.Click
        On Error Resume Next
        'If ServerVersion > 2.1 Then
        '    SendCasparCommand("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -filter:v alphaextract")
        'Else
        '    SendCasparCommand("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -vf alphaextract")
        'End If
        SendCasparCommand("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -filter:v alphaextract")

        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub

    Private Sub cmdpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreview.Click
        On Error Resume Next
        SendCasparCommand("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        'Threading.Thread.Sleep(2000)
        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub

    Private Sub cmdremovepreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremovepreview.Click
        On Error Resume Next
        SendCasparCommand("remove " & g_int_ChannelNumber & " stream " & "udp://" & cmbippreview.Text)
        vlcpreview.VlcMediaPlayer.Stop()
        isplaying = False
    End Sub

End Class


