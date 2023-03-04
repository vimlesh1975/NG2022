Imports System.IO

Public Class ucBoxing
    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        initialiseJudgesName()



        cmbhalfball.DataSource = New BindingSource(halfText, "")
        cmbhalfball.Text = "R1/3"
        cmbinfoball.DataSource = New BindingSource(infoball, "")
        cmbinfoball.Text = "W70"

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Boxing"

        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "Women's Boxing"
        cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "Bronze Medal Match"


    End Sub
    Private Sub initialiseJudgesName()
        DataGridViewComboBoxColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        'datagri.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch

        With dgvtrack
            .Rows.Add(5)
            Dim img0 = "C:/casparcg/NG2022/data/flag/india.png"
            .Rows(0).Cells(0).Value = "IND"
            .Rows(0).Cells(1).Value = Image.FromFile(img0)
            .Rows(0).Cells(2).Value = "MOHAMAD ALGARNI"
            .Rows(0).Cells(3).Value = img0

            Dim img1 = "C:/casparcg/NG2022/data/flag/pakistan.png"
            .Rows(1).Cells(0).Value = "PAK"
            .Rows(1).Cells(1).Value = Image.FromFile(img1)
            .Rows(1).Cells(2).Value = "EMAD HAMED NOUR"
            .Rows(1).Cells(3).Value = img1

            Dim img2 = "C:/casparcg/NG2022/data/flag/Afghanistan.png"
            .Rows(2).Cells(0).Value = "AFG"
            .Rows(2).Cells(1).Value = Image.FromFile(img2)
            .Rows(2).Cells(2).Value = "SANDEEP KARAN SINGH"
            .Rows(2).Cells(3).Value = img2

            Dim img3 = "C:/casparcg/NG2022/data/flag/Nepal.png"
            .Rows(3).Cells(0).Value = "NEP"
            .Rows(3).Cells(1).Value = Image.FromFile(img3)
            .Rows(3).Cells(2).Value = "RASHEED RAMZI"
            .Rows(3).Cells(3).Value = img3

            Dim img4 = "C:/casparcg/NG2022/data/flag/Sri-Lanka.png"
            .Rows(4).Cells(0).Value = "SRI"
            .Rows(4).Cells(1).Value = Image.FromFile(img4)
            .Rows(4).Cells(2).Value = "HAMZA DRIOUCH"
            .Rows(4).Cells(3).Value = img4

            For i = 0 To 4
                For j = 4 To 11
                    .Rows(i).Cells(j).Value = i * j
                Next
            Next
        End With
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
        If frmNG2022.chkanimation.Checked Then frmNG2022.animation2(Int(cmblayergames.Text))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(1000)
        If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(Int(cmblayergames.Text))
        tmrtimeupdateontemplate.Enabled = False

    End Sub


    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/boxing/event_id", CasparCGDataCollection.ToAMCPEscapedXml)

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

    Private Sub cmdSetBoth_Click(sender As Object, e As EventArgs) Handles cmdSetBoth.Click
        On Error Resume Next
        txtminball.Text = cmbputminuteball.Text
        txtsecball.Text = cmbputsecondball.Text

    End Sub
    Private Sub cmdadjustminball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadjustminball.Click
        On Error Resume Next
        txtminball.Text = cmbputminuteball.Text

    End Sub
    Private Sub cmdadjustsecball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadjustsecball.Click
        On Error Resume Next
        txtsecball.Text = cmbputsecondball.Text
    End Sub


    Private Sub cmdstartclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartclockball.Click
        tmrtimeonform.Enabled = True
        aa = Val(Now.Second.ToString) 'new code
    End Sub
    Dim aa As Integer 'new code
    Private Sub cmdresetclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetclockball.Click
        txtminball.Text = "3"
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
                txtminball.Text = Format(txtminball.Text - 1, "0")
            End If
            If Val(txtminball.Text) < 0 Then
                txtsecball.Text = "00"
                txtminball.Text = "0"
            End If
        End If
        If rdoupcounterball.Checked = True Then
            txtsecball.Text = Format(Val(txtsecball.Text + dif), "00")
            If txtsecball.Text > 59 Then
                txtsecball.Text = "00"
                txtminball.Text = Format(txtminball.Text + 1, "0")
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






    Private counter As Integer


    Private Sub cmdplayeridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtPlayer1.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/boxing/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt2ball.Click

        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtPlayer2.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/boxing/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

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
        showtemplate("ng2022/template/boxing/grouptosemifinal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresultball_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showtemplate("ng2022/template/boxing/groupresult1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresul2tball_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showtemplate("ng2022/template/boxing/groupresult2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdmatchstatics_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showtemplate("ng2022/template/boxing/MatchStatics", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgoalsummarywithtime_Click(sender As Object, e As EventArgs)
        showtemplate("ng2022/template/boxing/goalsummarywithtime", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdStart30sectimer_Click(sender As Object, e As EventArgs)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 2 & " starttimer()")

    End Sub

    Private Sub cmdStop30secondTimer_Click(sender As Object, e As EventArgs)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 2 & " pausetimer()")

    End Sub

    Private Sub Stoptimer30sec_Click(sender As Object, e As EventArgs)
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

    Private Sub cmdJudges_Click(sender As Object, e As EventArgs) Handles cmdJudges.Click
        startlist(dgvtrack)
    End Sub
    Sub startlist(dgv As DataGridView)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgv

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Judges")

            For i = 0 To .RowCount - 2
                'CasparCGDataCollection.SetData("ccg_ln" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(3).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(2).Value)
            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/boxing/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
        End With

    End Sub

    Private Sub dgvtrack_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrack.CellContentClick
        If e.ColumnIndex = 1 Then

            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\flag\"
            If aa.ShowDialog = DialogResult.OK Then
                dgvtrack.CurrentCell.Value = Image.FromFile(aa.FileName)
                dgvtrack.CurrentRow.Cells(3).Value = aa.FileName
            End If
        End If
    End Sub


    Private Sub cmdscorewithclock_Click(sender As Object, e As EventArgs) Handles cmdscorewithclock.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtPlayer1.Text)
        CasparCGDataCollection.SetData("ccgf1", txtPlayer2.Text)
        CasparCGDataCollection.SetData("ccgf4", cmbhalfball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbinfoball.Text)


        CasparCGDataCollection.SetData("ccgtime", txtminball.Text + ":" + txtsecball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/boxing/score", CasparCGDataCollection.ToAMCPEscapedXml)

        tmrtimeupdateontemplate.Enabled = True
    End Sub

    Private Sub newtrack_Click(sender As Object, e As EventArgs) Handles newtrack.Click
        On Error Resume Next
        newdatasg(dgvtrack, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub opentrack_Click(sender As Object, e As EventArgs) Handles opentrack.Click
        opendataboxing("C:\casparcg\ng2022\data\boxing\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenamet1ball)

    End Sub
    Sub opendataboxing(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = initialdirectory
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvname.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                headername.Text = Split(li, ",")(0)
                subheadername.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgvname.ColumnCount - 1
                    dgvname.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()

                    Dim xyz As Array = Split(li, ",")
                    If (xyz(0) <> "") Then dgvname.Rows.Add()

                    For k = 0 To dgvname.ColumnCount - 1
                        If xyz(k) <> "" Then
                            If dgvname.Name = "dgvtrack" Then
                                If k = 1 Then
                                    dgvname.Rows(g).Cells(k).Value = Image.FromFile(xyz(k))
                                Else
                                    dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                                End If
                            Else
                                dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                            End If
                        End If
                    Next
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilename.Text = ofd2.FileName
        End If
    End Sub
    Private Sub savetrack_Click(sender As Object, e As EventArgs) Handles savetrack.Click
        On Error Resume Next
        savedataboxing("C:\casparcg\ng2022\data\boxing\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Sub savedataboxing(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next

        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = initialdirectory
        'osd2.FileName = "001_" & ucRccBall.cmbHeader.Text & "_" & ucSG2016.cmbSubHeader.Text

        If File.Exists(lblfilename.Text) = True Then
            osd2.FileName = lblfilename.Text
            GoTo 20
        End If
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
20:
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvname.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(headername.Text & "," & subheadername.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvname.ColumnCount - 1
                        header1 = header1 & dgvname.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvname.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvname.ColumnCount - 1
                            If dgvname.Name = "dgvtrack" Then
                                If k = 1 Then
                                    str = str & dgvname.Rows(f).Cells(3).Value & ","
                                Else
                                    str = str & dgvname.Rows(f).Cells(k).Value & ","
                                End If
                            Else
                                str = str & dgvname.Rows(f).Cells(k).Value & ","

                            End If

                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilename.Text = osd2.FileName
        End If
    End Sub

    Private Sub uprowtrack_Click(sender As Object, e As EventArgs) Handles uprowtrack.Click
        upsg(dgvtrack)

    End Sub

    Private Sub downrowtrack_Click(sender As Object, e As EventArgs) Handles downrowtrack.Click
        downsg(dgvtrack)
    End Sub

    Private Sub addrowtrack_Click(sender As Object, e As EventArgs) Handles addrowtrack.Click
        insertsg(dgvtrack)
    End Sub

    Private Sub deleterowtrack_Click(sender As Object, e As EventArgs) Handles deleterowtrack.Click
        deletesg(dgvtrack)
    End Sub

    Private Sub cmdscoreresetball_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdshowsetscoreball_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdRound1_Click(sender As Object, e As EventArgs) Handles cmdRound1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrack

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Judges")

            CasparCGDataCollection.SetData("ccgf0", txtPlayer1.Text)
            CasparCGDataCollection.SetData("ccgf1", txtPlayer2.Text)

            CasparCGDataCollection.SetData("ccgsn1", txtCounty1.Text)
            CasparCGDataCollection.SetData("ccgsn2", txtCounty2.Text)


            CasparCGDataCollection.SetData("ccgloader55", pict1logoball.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", pict2logoball.ImageLocation.Replace("\", "/"))

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(3).Value.Replace("\", "/"))
                CasparCGDataCollection.SetData("ccgloader" & 5 + i, .Rows(i).Cells(3).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & 5 + i, .Rows(i).Cells(0).Value)

                CasparCGDataCollection.SetData("ccgr1pl1j" & i + 1, .Rows(i).Cells(4).Value)
                CasparCGDataCollection.SetData("ccgr1pl2j" & i + 1, .Rows(i).Cells(8).Value)

            Next

            showtemplate("ng2022/template/boxing/round1", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub

    Private Sub cmdRound2_Click(sender As Object, e As EventArgs) Handles cmdRound2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrack

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Judges")

            CasparCGDataCollection.SetData("ccgf0", txtPlayer1.Text)
            CasparCGDataCollection.SetData("ccgf1", txtPlayer2.Text)

            CasparCGDataCollection.SetData("ccgsn1", txtCounty1.Text)
            CasparCGDataCollection.SetData("ccgsn2", txtCounty2.Text)


            CasparCGDataCollection.SetData("ccgloader55", pict1logoball.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", pict2logoball.ImageLocation.Replace("\", "/"))

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(3).Value.Replace("\", "/"))
                CasparCGDataCollection.SetData("ccgloader" & 5 + i, .Rows(i).Cells(3).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & 5 + i, .Rows(i).Cells(0).Value)

                CasparCGDataCollection.SetData("ccgr1pl1j" & i + 1, .Rows(i).Cells(5).Value)
                CasparCGDataCollection.SetData("ccgr1pl2j" & i + 1, .Rows(i).Cells(9).Value)

                CasparCGDataCollection.SetData("ccgt1pl1j" & i + 1, .Rows(i).Cells(7).Value)
                CasparCGDataCollection.SetData("ccgt1pl2j" & i + 1, .Rows(i).Cells(11).Value)

            Next

            showtemplate("ng2022/template/boxing/round2", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrack

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Judges")

            CasparCGDataCollection.SetData("ccgf0", txtPlayer1.Text)
            CasparCGDataCollection.SetData("ccgf1", txtPlayer2.Text)

            CasparCGDataCollection.SetData("ccgsn1", txtCounty1.Text)
            CasparCGDataCollection.SetData("ccgsn2", txtCounty2.Text)

            CasparCGDataCollection.SetData("ccgloader55", pict1logoball.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", pict2logoball.ImageLocation.Replace("\", "/"))

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(3).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & 5 + i, .Rows(i).Cells(0).Value)

                CasparCGDataCollection.SetData("ccgr1pl1j" & i + 1, .Rows(i).Cells(7).Value & "-" & .Rows(i).Cells(11).Value)
            Next
        End With

        showtemplate("ng2022/template/boxing/final", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdvsball_Click(sender As Object, e As EventArgs) Handles cmdvsball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgf2", txtPlayer1.Text)
        CasparCGDataCollection.SetData("ccgf3", txtPlayer2.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/boxing/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
End Class
