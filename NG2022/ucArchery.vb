Public Class ucArchery
    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        defautdataforball()
        initialisesetscoreball()



        cmbhalfball.DataSource = New BindingSource(halfText, "")
        cmbhalfball.Text = "Set 1"
        cmbinfoball.DataSource = New BindingSource(infoball, "")
        cmbinfoball.Text = "88 K M / H"

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Archery"

        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "Men's Indivisual"
        cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "Bronze Medal Match"


        ' Add event handlers for all controls whose name starts with "arr"
        For Each ctrl As Control In GroupBox16.Controls.OfType(Of Control)().Where(Function(c) c.Name.StartsWith("arr"))
            AddHandler ctrl.Click, AddressOf ArrControls_Click
        Next


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
        On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then
        '    frmNG2022.animation2(Int(cmblayergames.Text))
        'End If
        'If frmNG2022.chkanimation.Checked = False Then
        '    CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " outEfeect()")
        'Else
        '    CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        'End If

        'If frmNG2022.chkanimation.Checked Then
        '    Threading.Thread.Sleep(1000)
        '    frmNG2022.animationtoscreen(Int(cmblayergames.Text))
        'End If

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


    End Sub


    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/archery/event_id", CasparCGDataCollection.ToAMCPEscapedXml)

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
        txtt1ball.Text = openimage("C:\casparcg\ng2022\data\flag\", sender)
        txtCounty1.Text = (txtt1ball.Text).Substring(0, 3).ToUpper()
    End Sub


    Private Sub pict2logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict2logoball.Click
        On Error Resume Next
        txtt2ball.Text = openimage("C:\casparcg\ng2022\data\flag\", sender)
        txtCounty2.Text = (txtt2ball.Text).Substring(0, 3).ToUpper()

    End Sub

    Dim aa As Integer 'new code


    Private Sub cmdstopscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If frmNG2022.chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(2000)
        If frmNG2022.chkanimation.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
        End If
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
            .Rows(12).Cells(0).Value = "06 Bhaskar Das"
            .Rows(13).Cells(0).Value = "Coach-M. Shinoj"

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
            .Rows(12).Cells(0).Value = "06 Vimlesh Kumar"
            .Rows(13).Cells(0).Value = "Coach-Vijay Ingle"
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
        showtemplate("ng2022/template/archery/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("ng2022/template/archery/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)

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


    Private Sub cmdt1yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt1rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/goal", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdt2rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/goal", CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("ng2022/template/archery/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdremoverowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt1ball.Click
        deletesg(dgvt1ball)
    End Sub

    Private Sub cmdnewt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt2ball.Click
        newdatasg(dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdopent2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent2ball.Click
        On Error Resume Next
        opendatasg("C: \casparcg\ng2022\data\netball", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub
    Private Sub cmdsavet2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet2ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\ng2022\data\netball", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)
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
        showtemplate("ng2022/template/archery/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt2ball.Click

        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtteamridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdtteamridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/archery/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdt1colorball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim cdb As New ColorDialog
        If cdb.ShowDialog = DialogResult.OK Then
            sender.backcolor = cdb.Color
        End If
    End Sub
    Private Sub cmdt2colorball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim cdb As New ColorDialog
        If cdb.ShowDialog = DialogResult.OK Then
            sender.backcolor = cdb.Color
        End If
    End Sub




    Private Sub cmdscorewithclock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithclock.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtCounty1.Text)
        CasparCGDataCollection.SetData("ccgf1", txtCounty2.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("ccg_sp1", sp1.Text)

        CasparCGDataCollection.SetData("ccg_arr11", arr11.Text)
        CasparCGDataCollection.SetData("ccg_arr12", arr12.Text)
        CasparCGDataCollection.SetData("ccg_arr13", arr13.Text)
        CasparCGDataCollection.SetData("ccg_arr14", arr14.Text)


        CasparCGDataCollection.SetData("ccg_sp2", sp2.Text)

        CasparCGDataCollection.SetData("ccg_arr21", arr21.Text)
        CasparCGDataCollection.SetData("ccg_arr22", arr22.Text)
        CasparCGDataCollection.SetData("ccg_arr23", arr23.Text)
        CasparCGDataCollection.SetData("ccg_arr24", arr24.Text)

        CasparCGDataCollection.SetData("ccg_arr15", arr15.Text)
        CasparCGDataCollection.SetData("ccg_arr16", arr16.Text)
        CasparCGDataCollection.SetData("ccg_arr25", arr25.Text)
        CasparCGDataCollection.SetData("ccg_arr26", arr26.Text)



        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))



        'CasparCGDataCollection.SetData("showccgccgTimeStrip", 1)
        'CasparCGDataCollection.SetData("showClockAndhalf", 1)

        CasparCGDataCollection.SetData("ccgextra", RaidTime.Text)
        CasparCGDataCollection.SetData("ccgextra2", RaidTime2.Text)


        showtemplate("ng2022/template/archery/score", CasparCGDataCollection.ToAMCPEscapedXml)

        If chkShowService.Checked Then
            If rdoServiceT1.Checked Then
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('1')" & """")
            End If
        End If

        If cmbShowArrow.Text = 2 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show2()" & """")
        ElseIf cmbShowArrow.Text = 3 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show3()" & """")

        ElseIf cmbShowArrow.Text = 4 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show4()" & """")

        ElseIf cmbShowArrow.Text = 5 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show5()" & """")
        ElseIf cmbShowArrow.Text = 6 Then
            'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show6()" & """")
        End If

    End Sub

    Private Sub cmdscorewithinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccginfo", cmbinfoball.Text)

        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/archery/score", CasparCGDataCollection.ToAMCPEscapedXml)

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")



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
        showtemplate("ng2022/template/archery/set7", CasparCGDataCollection.ToAMCPEscapedXml)

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

        showtemplate("ng2022/template/archery/score", CasparCGDataCollection.ToAMCPEscapedXml)

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(Color.Blue) & "')" & """")

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
        showtemplate("ng2022/template/archery/versusBoxing", CasparCGDataCollection.ToAMCPEscapedXml)
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
        gamelogo.ImageLocation = getgamelogoImageLocation(cmbgames.Text)
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


    Private Sub cmdgrouptosemifinalball_Click(sender As Object, e As EventArgs)
        showtemplate("ng2022/template/archery/grouptosemifinal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresultball_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showtemplate("ng2022/template/archery/groupresult1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresul2tball_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showtemplate("ng2022/template/archery/groupresult2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdmatchstatics_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showtemplate("ng2022/template/archery/MatchStatics", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgoalsummarywithtime_Click(sender As Object, e As EventArgs)
        showtemplate("ng2022/template/archery/goalsummarywithtime", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdPenaltyUpdate_Click(sender As Object, e As EventArgs) Handles cmdPenaltyUpdate.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtCounty1.Text)
        CasparCGDataCollection.SetData("ccgf1", txtCounty2.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)


        CasparCGDataCollection.SetData("ccg_sp1", sp1.Text)
        CasparCGDataCollection.SetData("ccg_sp2", sp2.Text)


        CasparCGDataCollection.SetData("ccg_arr11", arr11.Text)
        CasparCGDataCollection.SetData("ccg_arr12", arr12.Text)
        CasparCGDataCollection.SetData("ccg_arr21", arr21.Text)
        CasparCGDataCollection.SetData("ccg_arr22", arr22.Text)


        If cmbShowArrow.Text = 3 Then
            CasparCGDataCollection.SetData("ccg_arr13", arr13.Text)
            CasparCGDataCollection.SetData("ccg_arr23", arr23.Text)
        End If

        If cmbShowArrow.Text = 4 Then
            CasparCGDataCollection.SetData("ccg_arr14", arr14.Text)
            CasparCGDataCollection.SetData("ccg_arr24", arr24.Text)
        End If


        If cmbShowArrow.Text = 5 Then
            CasparCGDataCollection.SetData("ccg_arr15", arr15.Text)
            CasparCGDataCollection.SetData("ccg_arr25", arr25.Text)
        End If

        If cmbShowArrow.Text = 6 Then
            CasparCGDataCollection.SetData("ccg_arr16", arr16.Text)
            CasparCGDataCollection.SetData("ccg_arr26", arr26.Text)
        End If

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

        If chkShowService.Checked Then
            If rdoServiceT1.Checked Then
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('0')" & """")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('0')" & """")
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('1')" & """")
            End If
        End If

    End Sub

    Private Sub cmdremoverowt1ball_Click_1(sender As Object, e As EventArgs) Handles cmdremoverowt1ball.Click
        deletesg(dgvt1ball)
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
        savedatasg("C:\casparcg\ng2022\data\netball", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdnewt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt1ball.Click
        On Error Resume Next
        newdatasg(dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdopent1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent1ball.Click
        On Error Resume Next
        opendatasg("C:\casparcg\ng2022\data\netball", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)

    End Sub



    Private Sub cmdSaveas1_Click(sender As Object, e As EventArgs) Handles cmdSaveas1.Click
        On Error Resume Next
        saveasdatasg("C:\casparcg\ng2022\data\netball", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdSaveas2_Click(sender As Object, e As EventArgs) Handles cmdSaveas2.Click
        On Error Resume Next
        saveasdatasg("C:\casparcg\ng2022\data\netball", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub
    Private Sub cmdpauseshotball_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdResumeShotClock_Click(sender As Object, e As EventArgs)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer()")

    End Sub

    Private Sub chkShowService_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowService.CheckedChanged
        If chkShowService.Checked Then
            If rdoServiceT1.Checked Then
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('1')" & """")
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('0')" & """")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('1')" & """")
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('0')" & """")

            End If
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo('0')" & """")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showinfo2('0')" & """")
        End If
    End Sub

    Private Sub cmdt2Position_Click(sender As Object, e As EventArgs)
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
        showtemplate("ng2022/template/archery/PlayerPosition", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1Position_Click(sender As Object, e As EventArgs)
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
        showtemplate("ng2022/template/archery/PlayerPosition", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub Ball_Click(sender As Object, e As EventArgs) Handles Ball.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cmdRaider1_Click(sender As Object, e As EventArgs) Handles cmdRaider1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgextra", RaidTime.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer()")

    End Sub

    Private Sub cmdpauseshotball_Click_1(sender As Object, e As EventArgs) Handles cmdpauseshotball.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " pausetimer()")
    End Sub

    Private Sub cmdResumeShotClock_Click_1(sender As Object, e As EventArgs) Handles cmdResumeShotClock.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer()")

    End Sub

    Private Sub Stoptimer30sec_Click_1(sender As Object, e As EventArgs) Handles Stoptimer30sec.Click
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgextra", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " pausetimer()")

    End Sub
    Private Sub cmdRaider2_Click(sender As Object, e As EventArgs) Handles cmdRaider2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgextra2", RaidTime2.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer2()")
    End Sub

    Private Sub cmdpauseshotball2_Click(sender As Object, e As EventArgs) Handles cmdpauseshotball2.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " pausetimer2()")
    End Sub

    Private Sub cmdResumeShotClock2_Click(sender As Object, e As EventArgs) Handles cmdResumeShotClock2.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " starttimer2()")

    End Sub

    Private Sub Stoptimer30sec2_Click(sender As Object, e As EventArgs) Handles Stoptimer30sec2.Click
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgextra2", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " pausetimer2()")

    End Sub

    Private Sub GroupBox16_Enter(sender As Object, e As EventArgs) Handles GroupBox16.Enter

    End Sub

    Private Sub cmdShowinfo_click(sender As Object, e As EventArgs) Handles cmdShowinfo.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf5", cmbinfoball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
    End Sub

    Private Sub cmdRemoveinfo_Click(sender As Object, e As EventArgs) Handles cmdRemoveinfo.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
    End Sub


    Private clickedTextBox As TextBox = Nothing

    Private Sub ArrControls_Click(sender As Object, e As EventArgs)
        clickedTextBox = CType(sender, Control)

        For Each ctrl As Control In GroupBox16.Controls
            If ctrl.Name.StartsWith("arr") Then
                ctrl.BackColor = Color.White
                ctrl.ForeColor = Color.Black
            End If
        Next

        clickedTextBox.BackColor = Color.Red
        clickedTextBox.ForeColor = Color.White
    End Sub

    Private Sub cmd10_Click(sender As Object, e As EventArgs) Handles cmd10.Click, cmd9.Click, cmd8.Click, cmd7.Click
        On Error Resume Next
        If clickedTextBox IsNot Nothing Then
            clickedTextBox.Text = sender.Text
        End If

    End Sub

    Private Sub arr23_TextChanged(sender As Object, e As EventArgs) Handles arr23.TextChanged

    End Sub

    Private Sub cmbShowArrow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShowArrow.SelectedIndexChanged
        If cmbShowArrow.Text = 2 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showAll()" & """")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show2()" & """")
        ElseIf cmbShowArrow.Text = 3 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showAll()" & """")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show3()" & """")
        ElseIf cmbShowArrow.Text = 4 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showAll()" & """")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show4()" & """")
        ElseIf cmbShowArrow.Text = 5 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showAll()" & """")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "show5()" & """")
        ElseIf cmbShowArrow.Text = 6 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "showAll()" & """")
        End If
    End Sub
End Class
