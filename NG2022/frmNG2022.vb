Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class frmNG2022
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        Me.WindowState = FormWindowState.Maximized

        Control.CheckForIllegalCrossThreadCalls = False
        AddHandler CasparDevice.ConnectionStatusChanged, AddressOf connectionhandler

        CasparDevice.Connect(cmbhost.Text, txtport.Text)
        UcCasparcgWindow1.SetProcessParent("casparcg")
    End Sub
    Sub connectionhandler()
        'On Error Resume Next
        If CasparDevice.IsConnected = True Then
            cmdconnect.BackColor = Color.Green
            cmdconnect.Text = "Connected"
            ToolTip1.SetToolTip(cmdconnect, "Click to DisConnect")
            cmbhost.Enabled = False
        Else
            cmdconnect.BackColor = Color.Red
            cmdconnect.Text = "DisConnected"
            ToolTip1.SetToolTip(cmdconnect, "Click to Connect")
            cmbhost.Enabled = True
        End If
    End Sub
    Private Sub cmdconnect_Click_1(sender As Object, e As EventArgs) Handles cmdconnect.Click
        On Error Resume Next
        connecttocasparcg()
    End Sub
    Sub connecttocasparcg()
        On Error Resume Next
        CasparDevice.Settings.Hostname = Trim(cmbhost.Text)
        CasparDevice.Settings.Port = txtport.Text  '
        If CasparDevice.IsConnected = False Then
            CasparDevice.Connect()
        Else
            CasparDevice.Disconnect()
        End If
    End Sub

    Private Sub cmbchannel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbchannel.SelectedIndexChanged, cmbhost.LostFocus
        'DUMMY CODE
        'On Error Resume Next
        ' Modifychannelname()
    End Sub
    Private Sub cmbchannel_TextChanged(sender As Object, e As EventArgs) Handles cmbchannel.TextChanged
        'DUMMY CODE
        On Error Resume Next
        Modifychannelname()
    End Sub
    Sub Modifychannelname()
        On Error Resume Next
        If Me.Text <> "" Then
            Me.Text = ChannelName & "                              " & cmbhost.Text & "       Channel " & cmbchannel.Text
            g_int_ChannelNumber = Int(cmbchannel.Text)
        End If
    End Sub
    Private Sub frmNG2022_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UcCasparcgWindow1.outcasparcgwindown()
    End Sub
    Private Sub cmdstopall_Click(sender As Object, e As EventArgs) Handles cmdstopall.Click
        On Error Resume Next
        stopall()
    End Sub
    Sub stopall()
        On Error Resume Next
        CasparDevice.SendString("clear " & cmbchannel.Text)
        CasparDevice.SendString("mixer " & cmbchannel.Text & " clear")
    End Sub

    Private Sub cmdremoveoutput_Click(sender As Object, e As EventArgs) Handles cmdremoveoutput.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 2") ' for key
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 2") ' for key

    End Sub

    Private Sub cmdaddoutput_Click(sender As Object, e As EventArgs) Handles cmdaddoutput.Click
        On Error Resume Next

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 1 " & "embedded_audio")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 1 " & "embedded_audio")

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 2 " & "key_only") ' for key
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 2 " & "key_only") ' for key

    End Sub

    Private Sub cmdsd_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode PAL")

    End Sub

    Private Sub cmdhd_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode 1080i5000")

    End Sub

    Private Sub cmdsqueezeforsafesd_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .1 0 .8 1 50 easeoutexpo")

    End Sub

    Private Sub cmdfillnormal_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0 0 1 1 50 easeoutexpo")

    End Sub

    Private Sub cmdAddScreen_Click(sender As Object, e As EventArgs) Handles cmdAddScreen.Click
        On Error Resume Next
        CasparDevice.SendString("add " & g_int_ChannelNumber & " Screen 1 1080i5000")

    End Sub

    Private Sub cmdRemoveScreen_Click(sender As Object, e As EventArgs) Handles cmdRemoveScreen.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " Screen 1")

    End Sub
    Sub animation1(videolayer)
        Dim x, y As Decimal
        If rdoLeftIN.Checked Then
            x = -1.1
            y = 0
        ElseIf rdoRightIN.Checked Then
            x = 1
            y = 0
        ElseIf rdoUpIN.Checked Then
            x = 0
            y = -1
        ElseIf rdoDownIN.Checked Then
            x = 0
            y = 1
        ElseIf rdoSqueezeIn.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill 0.5 0 0 1 10 easeoutexpo")
            Exit Sub
        ElseIf rdoFedIN.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " opacity 0 50 easeoutexpo")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill " & x & " " & y & " 1 1 25 easeoutexpo")
50:
    End Sub
    Sub animationtoscreen(videolayer)
        If rdoFedIN.Checked Or rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " opacity 1 50 easeoutexpo")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill 0 0 1 1 25 " & "easeoutexpo")
50:
    End Sub
    Sub animation2(videolayer)
        Dim x, y As Decimal
        If rdoleftOut.Checked Then
            x = -1
            y = 0
        ElseIf rdoRightOut.Checked Then
            x = 1
            y = 0
        ElseIf rdoUpOut.Checked Then
            x = 0
            y = -1
        ElseIf rdoDownOut.Checked Then
            x = 0
            y = 1
        ElseIf rdoSqueezeOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill 0.5 0 0 1 50 easeoutexpo")
            Exit Sub
        ElseIf rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " opacity 0 50 easeoutexpo")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
50:
    End Sub

    Private Sub cmdAddNdi_Click(sender As Object, e As EventArgs) Handles cmdAddNdi.Click
        CasparDevice.SendString("add " & g_int_ChannelNumber & " ndi")
    End Sub

    Private Sub cmdRemoveNdi_Click(sender As Object, e As EventArgs) Handles cmdRemoveNdi.Click
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " ndi")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        callScript({"document.getElementById('ccgf0').getElementsByTagName('text')[0].getElementsByTagName('tspan')[0].innerHTML = 'vimlesh'"})
        Dim cc As New ucKabaddi
        changeImage("ccgloader1", "C:/casparcg/ng2022/data/country/GOA.png")

        Dim aa = "rect"
        Dim bb = "blue"
        callScript({"setColorRect('" & aa + "','" & bb + "')"})
    End Sub

End Class
