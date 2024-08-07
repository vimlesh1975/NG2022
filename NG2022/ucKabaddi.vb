﻿Public Class ucKabaddi
    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        defautdataforball()
        initialisesetscoreball()

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Kabaddi"

        cmbhalfball.DataSource = New BindingSource(halfText, "")
        cmbhalfball.Text = "1st"
        cmbinfoball.DataSource = New BindingSource(infoball, "")
        cmbinfoball.Text = "Round 1"


        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "Men's Kabaddi"
        cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "Bronze Medal Match"


    End Sub
    Private Sub initialisesetscoreball()
        dgvsetscoreball.Rows.Add(3)
        For isetscorett = 0 To 2
            If isetscorett = 0 Then
                For jsetscorett = 0 To 5
                    dgvsetscoreball.Rows(isetscorett).Cells(jsetscorett).Value = dgvsetscoreball.Columns(jsetscorett).HeaderText
                Next
            Else
                For jsetscorett = 0 To 5
                    dgvsetscoreball.Rows(isetscorett).Cells(jsetscorett).Value = isetscorett & jsetscorett
                Next
            End If
        Next
    End Sub

    Private Sub gamelogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:/casparcg/ng2022/data/games logo/", sender)
    End Sub

    Private Sub eventlogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:/casparcg/ng2022/data/event logo/", sender)
    End Sub
    Private Sub cmdstopgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopgym.Click
        'On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation2(Int(cmblayergames.Text))
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        'Threading.Thread.Sleep(1000)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(Int(cmblayergames.Text))

        On Error Resume Next
        If frmNG2022.chkanimation.Checked Then
            frmNG2022.animation2(Int(cmblayergames.Text))
        End If
        If frmNG2022.chkanimation.Checked = False Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " outAnimation()")
        Else
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        End If

        If frmNG2022.chkanimation.Checked Then
            Threading.Thread.Sleep(1000)
            frmNG2022.animationtoscreen(Int(cmblayergames.Text))
        End If

        tmrtimeupdateontemplate.Enabled = False


    End Sub


    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/kabaddi/event_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub dgvwinner_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        'dummy code don't delete
    End Sub


    Private Sub cmdaddoutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 1 " & "embedded_audio")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 1 " & "embedded_audio")

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 2 " & "key_only") ' for key
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 2 " & "key_only") ' for key
    End Sub

    Private Sub cmdremoveoutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 2") ' for key
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 2") ' for key
    End Sub
    Private Sub cmdhd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode 1080i5000")
    End Sub
    Private Sub cmdsd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode PAL")
    End Sub
    Private Sub cmdsqueezeforsafesd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .1 0 .8 1 50 easeoutexpo")
    End Sub

    Private Sub cmdfillnormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0 0 1 1 50 easeoutexpo")
    End Sub

    Private Sub pict1logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict1logoball.Click
        On Error Resume Next
        txtt1ball.Text = openimage("C:\casparcg\ng2022\data\country\", sender)
    End Sub
    Private Sub cmdadjustminball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadjustminball.Click
        On Error Resume Next
        txtminball.Text = cmbputminuteball.Text
    End Sub
    Private Sub cmdadjustsecball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadjustsecball.Click
        On Error Resume Next
        txtsecball.Text = cmbputsecondball.Text
    End Sub
    'Function openimage(ByVal defaultdirectory As String, ByVal picname As PictureBox)
    '    On Error Resume Next
    '    Dim picofd As New OpenFileDialog
    '    picofd.InitialDirectory = defaultdirectory
    '    If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
    '        picname.ImageLocation = picofd.FileName
    '    End If
    '    Return (Split(picofd.SafeFileName, ".")(0)).Replace("\", "/")
    'End Function
    Private Sub pict2logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict2logoball.Click
        On Error Resume Next
        txtt2ball.Text = openimage("C:\casparcg\ng2022\data\country\", sender)
    End Sub

    Private Sub cmdstartclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartclockball.Click
        tmrtimeonform.Enabled = True
        aa = Val(Now.Second.ToString) 'new code
    End Sub
    Dim aa As Integer 'new code
    Private Sub cmdresetclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetclockball.Click
        txtminball.Text = "00"
        txtsecball.Text = "00"
    End Sub
    Private Sub cmdpauseclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpauseclockball.Click
        tmrtimeonform.Enabled = False
    End Sub
    Private Sub tmrtimeonform_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrtimeonform.Tick
        On Error Resume Next
        Dim bb = Val(Now.Second.ToString)

        Dim dif As Integer = (bb - aa)
        aa = bb
        If dif < 0 Then dif = dif + 60

        If rdodowncounterball.Checked = True Then
            txtsecball.Text = Format(Val(txtsecball.Text - dif), "00")
            If Val(txtsecball.Text) < 0 Then
                txtsecball.Text = 59
                txtminball.Text = Format(txtminball.Text - 1, "00")
            End If
            If Val(txtminball.Text) < 0 Then
                txtsecball.Text = "00"
                txtminball.Text = "00"
            End If
        End If
        If rdoupcounterball.Checked = True Then
            txtsecball.Text = Format(Val(txtsecball.Text + dif), "00")
            If txtsecball.Text > 59 Then
                txtsecball.Text = "00"
                txtminball.Text = Format(txtminball.Text + 1, "00")
            End If
        End If
    End Sub

    Private Sub tmrtimeupdateontemplate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrtimeupdateontemplate.Tick
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdstopscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If frmNG2022.chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(2000)
        If frmNG2022.chkanimation.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
        End If
        tmrtimeupdateontemplate.Enabled = False
    End Sub

    Private Sub defautdataforball()
        On Error Resume Next
        With dgvt1ball
            .Rows.Add(22)
            .Rows(0).Cells(0).Value = "21 K Bharadwaja"
            .Rows(1).Cells(0).Value = "52 N Sri Sai"
            .Rows(2).Cells(0).Value = "73 A K Prajapati"
            .Rows(3).Cells(0).Value = "34 Deepesh Sahu"
            .Rows(4).Cells(0).Value = "18 Vatsal Reshamwala"
            .Rows(5).Cells(0).Value = "22 Devanshu Soni"
            .Rows(6).Cells(0).Value = "23 Honey Mehra"
            .Rows(7).Cells(0).Value = "24 Mayank Jain"
            .Rows(8).Cells(0).Value = "25 Baleshwar Nayak"
            .Rows(9).Cells(0).Value = "26 Manoj Thapa"
            .Rows(10).Cells(0).Value = "27 Rahul Chitrasen"

            .Rows(11).Cells(0).Value = "28 Vidwath Sundaraju"
            .Rows(12).Cells(0).Value = "Coach-M. Shinoj"

            .Rows(15).Cells(0).Value = "Raider"

            '.Rows(13).Cells(0).Value = "06 Bhaskar Das"
            '.Rows(14).Cells(0).Value = "13 Anuj Rathi"
            '.Rows(15).Cells(0).Value = "15 Bapi Roy"
            '.Rows(16).Cells(0).Value = "20 Yogeshwar Singh"
            '.Rows(17).Cells(0).Value = "22 Devanshu Soni"
            '.Rows(18).Cells(0).Value = "34 Rajeev R"
            '.Rows(19).Cells(0).Value = "31 Sarath G.L."
            '.Rows(20).Cells(0).Value = "32 Sarath Gopal"
            '.Rows(21).Cells(0).Value = "33 Jithu V. S,"
            '.Rows(22).Cells(0).Value = "Coach-Madhvan Nair"

        End With
        With dgvt2ball
            .Rows.Add(22)
            .Rows(0).Cells(0).Value = "36 Abhishek Chatterjee"
            .Rows(1).Cells(0).Value = "37 Ashutosh Verma"
            .Rows(2).Cells(0).Value = "38 Bharat Batham"
            .Rows(3).Cells(0).Value = "39 Jagat Sharma"
            .Rows(4).Cells(0).Value = "40 Narendra Mahawar"
            .Rows(5).Cells(0).Value = "41 Rohit Jadhav"
            .Rows(6).Cells(0).Value = "42 Sunder Verma"
            .Rows(7).Cells(0).Value = "43 Akash Dongre"
            .Rows(8).Cells(0).Value = "44 Anish Joshi"
            .Rows(9).Cells(0).Value = "45 Narsimha Chavhan"
            .Rows(10).Cells(0).Value = "46 Prithviraj Phadnis"
            .Rows(11).Cells(0).Value = "47 Sagar Sawant"
            .Rows(12).Cells(0).Value = "Coach-Vijay Ingle"

            .Rows(15).Cells(0).Value = "Raider"

            '.Rows(13).Cells(0).Value = "06 Vimesh Kumar"
            '.Rows(14).Cells(0).Value = "49 Vinayak Auti"
            '.Rows(15).Cells(0).Value = "50 B Tulshidas Sharma"
            '.Rows(16).Cells(0).Value = "51 Ch Meiraba Meitei"
            '.Rows(17).Cells(0).Value = "52 K Roopakanta Sharma"
            '.Rows(18).Cells(0).Value = "53 Rajeev Gopinathan"
            '.Rows(19).Cells(0).Value = "54 M Chandrashekhar"
            '.Rows(20).Cells(0).Value = "55 Peter Rose"
            '.Rows(21).Cells(0).Value = "56 V B Hadap"
            '.Rows(22).Cells(0).Value = "Coach-Ramakrishna Panigrahi"

        End With

    End Sub
    Private Sub cmdt1lineupball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1lineupball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 22
            CasparCGDataCollection.SetData("ccgf" & i, dgvt1ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgheader", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Starting Lineup")
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)



    End Sub



    Private Sub cmdt2lineupball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2lineupball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 22
            CasparCGDataCollection.SetData("ccgf" & i, dgvt2ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgheader", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Starting Lineup")
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    'Sub showtemplatescore(ByVal templatename As String, ByVal datacollection As String)
    '    On Error Resume Next
    '    If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(Int(cmblayergames.Text))
    '    Threading.Thread.Sleep(250)
    '    CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, datacollection)
    '    Threading.Thread.Sleep(1300)
    '    If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(Int(cmblayergames.Text))
    'End Sub
    Private counter As Integer
    Private Sub dgvt2ball_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvt2ball.CellDoubleClick
        On Error Resume Next
        If counter = 0 Then
            txtt2inball.Text = sender.CurrentRow.Cells(0).Value
            counter = counter + 1
        Else
            txtt2outball.Text = sender.CurrentRow.Cells(0).Value
            counter = 0
        End If
    End Sub
    Private Sub dgvt1ball_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvt1ball.CellDoubleClick
        On Error Resume Next
        If counter = 0 Then
            txtt1inball.Text = sender.CurrentRow.Cells(0).Value
            counter = counter + 1
        Else
            txtt1outball.Text = sender.CurrentRow.Cells(0).Value
            counter = 0
        End If
    End Sub

    Private Sub cmdt1yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1yball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2yball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt1rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/goal", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdt2rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/goal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt1inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1inball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt1outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/in_out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt2inball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/in_out", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdteam2inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt2inball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdteam1inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt1inball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdteam2outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt2outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/out", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdteam1outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt1outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdvsball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdremoverowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt1ball.Click
        deletesg(dgvt1ball)
    End Sub

    Private Sub cmdnewt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt2ball.Click
        newdatasg(dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdopent2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent2ball.Click
        On Error Resume Next
        opendatasg("C: \casparcg\ng2022\data\kabaddi\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub
    Private Sub cmdsavet2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet2ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\ng2022\data\kabaddi\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)
    End Sub

    Private Sub cmduprowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduprowt2ball.Click
        upsg(dgvt2ball)
    End Sub

    Private Sub cmdremoverowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt2ball.Click
        deletesg(dgvt2ball)
    End Sub

    Private Sub cmdaddrowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrowt2ball.Click
        insertsg(dgvt2ball)
    End Sub

    Private Sub cmddownrowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddownrowt2ball.Click
        downsg(dgvt2ball)
    End Sub
    Private Sub cmdplayeridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt2ball.Click

        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtteamridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdtteamridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdt1colorball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1colorball.Click
        On Error Resume Next
        Dim cdb As New ColorDialog
        If cdb.ShowDialog = DialogResult.OK Then
            sender.backcolor = cdb.Color
        End If
    End Sub
    Private Sub cmdt2colorball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2colorball.Click
        On Error Resume Next
        Dim cdb As New ColorDialog
        If cdb.ShowDialog = DialogResult.OK Then
            sender.backcolor = cdb.Color
        End If
    End Sub
    Private Sub cmdadd1t2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd1t2ball.Click
        On Error Resume Next
        txtt2gball.Text += 1
        If TeamStatus2.Value < 7 Then TeamStatus2.Value += 1
        TeamStatus1.Value -= 1
        If TeamStatus1.Value = 0 Then
            TeamStatus1.Value = 7
            txtt2gball.Text += 2
        End If
        If chkAutoUpdate.Checked Then
            cmdPenaltyUpdate.PerformClick()
        End If
    End Sub
    Private Sub cmdadd1t1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd1t1ball.Click
        On Error Resume Next
        txtt1gball.Text += 1
        If TeamStatus1.Value < 7 Then TeamStatus1.Value += 1
        TeamStatus2.Value -= 1

        If TeamStatus2.Value = 0 Then
            TeamStatus2.Value = 7
            txtt1gball.Text += 2
        End If
        If chkAutoUpdate.Checked Then
            cmdPenaltyUpdate.PerformClick()
        End If
    End Sub


    Private Sub cmdgoalSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgoalSummary.Click


        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", cmbgoalsummary.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt1gball.Text & "-" & txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/Goal_Summary", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("xccgteam1color", ColorTranslator.ToHtml(cmdt1colorball.BackColor))
        CasparCGDataCollection.SetData("xccgteam2color", ColorTranslator.ToHtml(cmdt2colorball.BackColor))

        showtemplate("ng2022/template/kabaddi/score", CasparCGDataCollection.ToAMCPEscapedXml)

        tmrtimeupdateontemplate.Enabled = False
    End Sub
    Private Sub cmdscorewithclock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithclock.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("xccgteam1color", ColorTranslator.ToHtml(cmdt1colorball.BackColor))
        CasparCGDataCollection.SetData("xccgteam2color", ColorTranslator.ToHtml(cmdt2colorball.BackColor))
        CasparCGDataCollection.SetData("showccgccgTimeStrip", "1")

        showtemplate("ng2022/template/kabaddi/score", CasparCGDataCollection.ToAMCPEscapedXml)

        tmrtimeupdateontemplate.Enabled = True
    End Sub

    Private Sub cmdscorewithinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithinfo.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccginfo", cmbinfoball.Text)

        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))


        CasparCGDataCollection.SetData("xccgteam1color", ColorTranslator.ToHtml(cmdt1colorball.BackColor))
        CasparCGDataCollection.SetData("xccgteam2color", ColorTranslator.ToHtml(cmdt2colorball.BackColor))
        CasparCGDataCollection.SetData("showinfo", "1")

        showtemplate("ng2022/template/kabaddi/score", CasparCGDataCollection.ToAMCPEscapedXml)

        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")

        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('xccgteam1color'," & "'" & ColorTranslator.ToHtml(cmdt1colorball.BackColor) & "')" & """")
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('xccgteam2color'," & "'" & ColorTranslator.ToHtml(cmdt2colorball.BackColor) & "')" & """")

        tmrtimeupdateontemplate.Enabled = False

    End Sub


    Private Sub cmdscoreresetball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreresetball.Click
        On Error Resume Next
        For iscore = 1 To 2
            For jscore = 0 To 6
                dgvsetscoreball.Rows(iscore).Cells(jscore).Value = ""
            Next
        Next
    End Sub

    Private Sub cmdshowsetscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowsetscoreball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For isetscore = 1 To 6
            CasparCGDataCollection.SetData("ccgf" & isetscore, dgvsetscoreball.Rows(0).Cells(isetscore - 1).Value)
        Next
        For isetscore = 1 To 2
            For jsetscore = 1 To 6
                CasparCGDataCollection.SetData("ccgf" & isetscore & jsetscore, dgvsetscoreball.Rows(isetscore).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("ccgh1", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgh2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("ccgt1", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgt2", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/set7", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Sub capitalisetext(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            sender.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
    Private Sub txtshortnamet1tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub

    Private Sub txtshortnamet2tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub
    Private Sub txtfullnamet2tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub


    Private Sub txtfullnamet1tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub
    Private Sub cmdscoreboxing_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        If frmNG2022.chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccginfo", cmbinfoball.Text)

        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/kabaddi/score", CasparCGDataCollection.ToAMCPEscapedXml)

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(Color.Blue) & "')" & """")

        tmrtimeupdateontemplate.Enabled = False
    End Sub

    Private Sub cmdversusboxing_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/versusBoxing", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub





    Private Sub cmdscorewithclockboxing_Click(sender As Object, e As EventArgs)
        On Error Resume Next

        If frmNG2022.chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)


        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/score_boxing", CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showClockAndhalf('1')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(Color.Blue) & "')" & """")

        tmrtimeupdateontemplate.Enabled = True
    End Sub

    Private Sub cmdsetscoreboxing_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For isetscore = 1 To 6
            CasparCGDataCollection.SetData("ccgf" & isetscore, dgvsetscoreball.Rows(0).Cells(isetscore - 1).Value)
        Next
        For isetscore = 1 To 2
            For jsetscore = 1 To 6
                CasparCGDataCollection.SetData("ccgf" & isetscore & jsetscore, dgvsetscoreball.Rows(isetscore).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("ccgh1", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgh2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("ccgt1", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgt2", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/set7Boxing", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdroundscoreboxing_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", cmbgoalsummary.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt1gball.Text & "-" & txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/kabaddi/Goal_SummaryBoxing", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Sub makedatatypeforsorting(dgv1 As DataGridView, dgv2 As DataGridView)
        dgv1.Columns(5).ValueType = GetType(Integer)
        dgv2.Columns(5).ValueType = GetType(Integer)
    End Sub
    Private Sub dgvtrack_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Private Sub dgvtrackresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Sub sortresult(sourcegrid As DataGridView, targetgrid As DataGridView, columntosort As Integer)
        On Error Resume Next

        Dim targetRows = New List(Of DataGridViewRow)
        For Each sourceRow As DataGridViewRow In sourcegrid.Rows
            If (Not sourceRow.IsNewRow) Then
                Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
                For Each cell As DataGridViewCell In sourceRow.Cells
                    If cell.Value = vbNullString And cell.ColumnIndex = columntosort Then
                        targetRow.Cells(cell.ColumnIndex).Value = Int(8)
                    Else
                        targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                    End If
                Next
                targetRows.Add(targetRow)
            End If
        Next
        targetgrid.Columns.Clear()
        For Each column As DataGridViewColumn In sourcegrid.Columns
            targetgrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next
        targetgrid.Rows.AddRange(targetRows.ToArray())
        targetgrid.Sort(targetgrid.Columns(columntosort), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub cmdtimerresumetrack_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("resume", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub
    Private Sub dgvFE_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub
    Private Sub dgvFEresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Private Sub cmbgames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgames.SelectedIndexChanged
        If cmbgames.Text = "Aquatics" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\AQ" & ".png"
        If cmbgames.Text = "Archery" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\AR" & ".png"
        If cmbgames.Text = "Atheletics" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\AT" & ".png"
        If cmbgames.Text = "Badminton" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\BD" & ".png"
        If cmbgames.Text = "Basketball" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\BK" & ".png"
        If cmbgames.Text = "Black" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\BLK" & ".png"
        If cmbgames.Text = "Boxing" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\BX" & ".png"
        If cmbgames.Text = "Cycling" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\CY" & ".png"
        If cmbgames.Text = "Diving" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\DIV" & ".png"
        If cmbgames.Text = "Football" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\FB" & ".png"
        If cmbgames.Text = "Gymnastics - Artistic" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\Gymnastics - Artistic" & ".png"
        If cmbgames.Text = "Gymnastics - Rhythmic" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\Gymnastics - Rhythmic" & ".png"
        If cmbgames.Text = "Gymnastics - Trampoline" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\Gymnastics - Trampoline" & ".png"
        If cmbgames.Text = "Handball" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\HB" & ".png"
        If cmbgames.Text = "Hockey" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\HO" & ".png"
        If cmbgames.Text = "Judo" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\HO" & ".png"
        If cmbgames.Text = "Kabaddi" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\KB" & ".png"
        If cmbgames.Text = "Kayaking" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\KK" & ".png"
        If cmbgames.Text = "Shooting" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\SH" & ".png"
        If cmbgames.Text = "Squash" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\SQ" & ".png"
        If cmbgames.Text = "Swimming" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\SW" & ".png"
        If cmbgames.Text = "TableTennis" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\TT" & ".png"
        If cmbgames.Text = "Taekwondo" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\TK" & ".png"
        If cmbgames.Text = "Tennis" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\TE" & ".png"
        If cmbgames.Text = "Triathlon" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\TRI" & ".png"
        If cmbgames.Text = "Volleyball" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\VB" & ".png"
        If cmbgames.Text = "Weight lift" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\WL" & ".png"
        If cmbgames.Text = "Wrestling" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\WR" & ".png"
        If cmbgames.Text = "Wushu" Then gamelogo.ImageLocation = "C:\casparcg\ng2022\data\games logo\WU" & ".png"

    End Sub

    Sub sortresult1(sourcegrid As DataGridView, targetgrid As DataGridView, columntosort As Integer)
        On Error Resume Next
        Dim aa As Integer = 0
        With targetgrid
            .Rows.Clear()
            For ii = 0 To sourcegrid.RowCount - 1
                If (sourcegrid.Rows(ii).Cells(columntosort).Value) <> vbNullString Then
                    .Rows.Add()
                    For jj = 0 To sourcegrid.ColumnCount - 1
                        .Rows(aa).Cells(jj).Value = sourcegrid.Rows(ii).Cells(jj).Value
                    Next
                    aa = aa + 1
                End If
            Next
            For bb = 0 To .RowCount - 1
                .Rows(bb).Cells(columntosort).Value = CType(.Rows(bb).Cells(columntosort).Value, Double)
            Next

            If sourcegrid.Name = "dgvFE" And columntosort = 4 Then
                .Sort(.Columns(columntosort), System.ComponentModel.ListSortDirection.Descending)
            Else
                .Sort(.Columns(columntosort), System.ComponentModel.ListSortDirection.Ascending)
            End If

        End With
    End Sub


    Private Sub cmdgrouptosemifinalball_Click(sender As Object, e As EventArgs) Handles cmdgrouptosemifinalball.Click
        showtemplate("ng2022/template/kabaddi/grouptosemifinal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresultball_Click(sender As Object, e As EventArgs) Handles cmdgroupresultball.Click
        On Error Resume Next
        showtemplate("ng2022/template/kabaddi/groupresult1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresul2tball_Click(sender As Object, e As EventArgs) Handles cmdgroupresul2tball.Click
        On Error Resume Next
        showtemplate("ng2022/template/kabaddi/groupresult2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdmatchstatics_Click(sender As Object, e As EventArgs) Handles cmdmatchstatics.Click
        On Error Resume Next
        showtemplate("ng2022/template/kabaddi/MatchStatics", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgoalsummarywithtime_Click(sender As Object, e As EventArgs) Handles cmdgoalsummarywithtime.Click
        showtemplate("ng2022/template/kabaddi/goalsummarywithtime", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdpenaltyball_Click(sender As Object, e As EventArgs) Handles cmdpenaltyball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)



        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))


        CasparCGDataCollection.SetData("xccgteam1color", ColorTranslator.ToHtml(cmdt1colorball.BackColor))
        CasparCGDataCollection.SetData("xccgteam2color", ColorTranslator.ToHtml(cmdt2colorball.BackColor))

        CasparCGDataCollection.SetData("showPenalty", "1")
        CasparCGDataCollection.SetData("showinfo", "1")
        CasparCGDataCollection.SetData("showccgccgTimeStrip", "1")
        CasparCGDataCollection.SetData("showccgstatusStrip", "1")

        For iii = 1 To TeamStatus1.Value
            CasparCGDataCollection.SetData("ccgpenaltycircle" & iii, ColorTranslator.ToHtml(Color.LightGreen))

        Next
        For iii = TeamStatus1.Value + 1 To 7
            CasparCGDataCollection.SetData("ccgpenaltycircle" & iii, ColorTranslator.ToHtml(Color.Red))

        Next
        For iii = 1 To TeamStatus2.Value
            CasparCGDataCollection.SetData("ccgpenaltycircle" & iii + 7, ColorTranslator.ToHtml(Color.LightGreen))

        Next
        For iii = TeamStatus2.Value + 1 To 7
            CasparCGDataCollection.SetData("ccgpenaltycircle" & iii + 7, ColorTranslator.ToHtml(Color.Red))

        Next

        showtemplate("ng2022/template/kabaddi/score", CasparCGDataCollection.ToAMCPEscapedXml)

        tmrtimeupdateontemplate.Enabled = True
    End Sub
    Private Sub cmdPenaltyUpdate_Click(sender As Object, e As EventArgs) Handles cmdPenaltyUpdate.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)


        For iii = 1 To TeamStatus1.Value
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setCircleColor('ccgpenaltycircle" & iii & "'," & "'" & ColorTranslator.ToHtml(Color.LightGreen) & "')" & """")
        Next
        For iii = TeamStatus1.Value + 1 To 7
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setCircleColor('ccgpenaltycircle" & iii & "'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        Next
        For iii = 1 To TeamStatus2.Value
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 7 & "'," & "'" & ColorTranslator.ToHtml(Color.LightGreen) & "')" & """")
        Next
        For iii = TeamStatus2.Value + 1 To 7
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 7 & "'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        Next

        If frmNG2022.chkSendToHtml.Checked Then
            changeString("ccgf2", txtt1gball.Text)
            changeString("ccgf3", txtt2gball.Text)
        End If

    End Sub

    Private Sub cmdremoverowt1ball_Click_1(sender As Object, e As EventArgs) Handles cmdremoverowt1ball.Click
        deletesg(dgvt1ball)
    End Sub

    Private Sub cmdaddrowt1ball_Click_1(sender As Object, e As EventArgs) Handles cmdaddrowt1ball.Click

    End Sub

    Private Sub cmduprowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduprowt1ball.Click
        On Error Resume Next
        upsg(dgvt1ball)
    End Sub

    Private Sub cmddownrowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddownrowt1ball.Click
        On Error Resume Next
        downsg(dgvt1ball)
    End Sub
    Private Sub cmdaddrowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrowt1ball.Click
        insertsg(dgvt1ball)
    End Sub
    Private Sub cmdsavet1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet1ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\ng2022\data\kabaddi\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdnewt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt1ball.Click
        On Error Resume Next
        newdatasg(dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdopent1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent1ball.Click
        On Error Resume Next
        opendatasg("C:\casparcg\ng2022\data\kabaddi\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)

    End Sub



    Private Sub cmdStart30sectimer_Click(sender As Object, e As EventArgs)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 2 & " starttimer()")

    End Sub

    Private Sub cmdStop30secondTimer_Click(sender As Object, e As EventArgs)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 2 & " pausetimer()")

    End Sub

    Private Sub Stoptimer30sec_Click(sender As Object, e As EventArgs) Handles Stoptimer30sec.Click
        CasparCGDataCollection.Clear()

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('0')" & """")
        CasparCGDataCollection.SetData("ccgextra", "")
        CasparCGDataCollection.SetData("ccginfo", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " pausetimer()")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('0')" & """")
        CasparCGDataCollection.SetData("ccgextra2", "")
        CasparCGDataCollection.SetData("ccginfo2", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " pausetimer()")

    End Sub

    Private Sub cmdRaider1_Click(sender As Object, e As EventArgs) Handles cmdRaider1.Click
        On Error Resume Next
        Stoptimer30sec.PerformClick()
        CasparCGDataCollection.Clear()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")
        CasparCGDataCollection.SetData("ccgextra", RaidTime.Text)
        CasparCGDataCollection.SetData("ccginfo", dgvt1ball.CurrentCell.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer()")

    End Sub

    Private Sub cmdRaider2_Click(sender As Object, e As EventArgs) Handles cmdRaider2.Click
        On Error Resume Next
        Stoptimer30sec.PerformClick()
        CasparCGDataCollection.Clear()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('1')" & """")
        CasparCGDataCollection.SetData("ccgextra2", RaidTime.Text)
        CasparCGDataCollection.SetData("ccginfo2", dgvt2ball.CurrentCell.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer2()")

    End Sub
    Private Sub cmd30cueSecondTimer_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", RaidTime.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 2, Int(cmblayergames.Text) + 2, "ng2022/template/kabaddi/30sectimer1", True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdcue30SecondTimer2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", RaidTime.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 2, Int(cmblayergames.Text) + 2, "ng2022/template/kabaddi/30sectimer2", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub Ball_Click(sender As Object, e As EventArgs) Handles Ball.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)
        CasparCGDataCollection.SetData("ccginfo", cmbinfoball.Text)


        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("xccgteam1color", ColorTranslator.ToHtml(cmdt1colorball.BackColor))
        CasparCGDataCollection.SetData("xccgteam2color", ColorTranslator.ToHtml(cmdt2colorball.BackColor))
        CasparCGDataCollection.SetData("showinfo", "1")
        CasparCGDataCollection.SetData("showccgccgTimeStrip", "1")
        CasparCGDataCollection.SetData("showClockAndhalf", "1")


        showtemplate("ng2022/template/kabaddi/score", CasparCGDataCollection.ToAMCPEscapedXml)


        tmrtimeupdateontemplate.Enabled = True
    End Sub

    Private Sub cmdOut_Click(sender As Object, e As EventArgs) Handles cmdOut.Click
        On Error Resume Next
        TeamStatus1.Value -= 1
        If TeamStatus2.Value < 7 Then TeamStatus2.Value += 1
        txtt2gball.Text += 1
        If TeamStatus1.Value = 0 Then
            TeamStatus1.Value = 7
            txtt2gball.Text += 2
        End If
        If chkAutoUpdate.Checked Then
            cmdPenaltyUpdate.PerformClick()
        End If
    End Sub

    Private Sub cmdBonus_Click(sender As Object, e As EventArgs) Handles cmdBonus.Click
        On Error Resume Next
        txtt1gball.Text += 1
        If chkAutoUpdate.Checked Then
            cmdPenaltyUpdate.PerformClick()
        End If
    End Sub

    Private Sub cmdLono_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        txtt2gball.Text += 2
        TeamStatus1.Value = 7
    End Sub

    Private Sub cmdOut2_Click(sender As Object, e As EventArgs) Handles cmdOut2.Click
        On Error Resume Next
        TeamStatus2.Value -= 1
        If TeamStatus1.Value < 7 Then TeamStatus1.Value += 1
        txtt1gball.Text += 1
        If TeamStatus2.Value = 0 Then
            TeamStatus2.Value = 7
            txtt1gball.Text += 2
        End If
        If chkAutoUpdate.Checked Then
            cmdPenaltyUpdate.PerformClick()
        End If
    End Sub

    Private Sub cmdBonus2_Click(sender As Object, e As EventArgs) Handles cmdBonus2.Click
        On Error Resume Next
        txtt2gball.Text += 1
        If chkAutoUpdate.Checked Then
            cmdPenaltyUpdate.PerformClick()
        End If
    End Sub

    Private Sub cmdLono2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        txtt1gball.Text += 2
        TeamStatus2.Value = 7
    End Sub

    Private Sub cmdSaveas1_Click(sender As Object, e As EventArgs) Handles cmdSaveas1.Click
        On Error Resume Next
        saveasdatasg("C:\casparcg\ng2022\data\kabaddi\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdSaveas2_Click(sender As Object, e As EventArgs) Handles cmdSaveas2.Click
        On Error Resume Next
        saveasdatasg("C:\casparcg\ng2022\data\kabaddi\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
