﻿Imports System.Threading
Imports Microsoft.VisualBasic.FileIO

Public Class ucTrack
    Private Sub ucRowing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defauttrackdata()
        defautdataforball()

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Rowing"

        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "World Rowing Cup 2023"
        cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "Men's Single Sculls"
    End Sub
    Sub defauttrackdata()
        DataGridViewComboBoxColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        DataGridViewComboBoxColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch

        With dgvtrack
            .Rows.Add(8)

            .Rows(0).Cells(0).Value = 1
            .Rows(0).Cells(1).Value = "IND"
            .Rows(0).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/india.png")
            .Rows(0).Cells(3).Value = "MOHAMAD ALGARNI"
            .Rows(0).Cells(4).Value = 7.2
            .Rows(0).Cells(6).Value = "C:/casparcg/NG2022/data/flag/india.png"

            .Rows(1).Cells(0).Value = 2
            .Rows(1).Cells(1).Value = "AFG"
            .Rows(1).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Afghanistan.png")
            .Rows(1).Cells(3).Value = "SANDEEP KARAN SINGH"
            .Rows(1).Cells(4).Value = 7.33
            .Rows(1).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Afghanistan.png"

            .Rows(2).Cells(0).Value = 3
            .Rows(2).Cells(1).Value = "PAK"
            .Rows(2).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Pakistan.png")
            .Rows(2).Cells(3).Value = "EMAD HAMED NOUR"
            .Rows(2).Cells(4).Value = 7.1
            .Rows(2).Cells(5).Value = 2
            .Rows(2).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Pakistan.png"

            .Rows(3).Cells(0).Value = 4
            .Rows(3).Cells(1).Value = "NEP"
            .Rows(3).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Nepal.png")
            .Rows(3).Cells(3).Value = "RASHEED RAMZI"
            .Rows(3).Cells(4).Value = 7.11
            .Rows(3).Cells(5).Value = 3
            .Rows(3).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Nepal.png"


            .Rows(4).Cells(0).Value = 5
            .Rows(4).Cells(1).Value = "SRI"
            .Rows(4).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Sri-Lanka.png")
            .Rows(4).Cells(3).Value = "HAMZA DRIOUCH"
            .Rows(4).Cells(4).Value = 7.32
            .Rows(4).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Sri-Lanka.png"


            .Rows(5).Cells(0).Value = 6
            .Rows(5).Cells(1).Value = "BHU"
            .Rows(5).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Bhutan.png")
            .Rows(5).Cells(3).Value = "RAM PRASAD SAHANI"
            .Rows(5).Cells(4).Value = 7.35
            .Rows(5).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Bhutan.png"


            .Rows(6).Cells(0).Value = 7
            .Rows(6).Cells(1).Value = "MDV"
            .Rows(6).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Maldives.png")
            .Rows(6).Cells(3).Value = "ABDULLAH OBAID"
            .Rows(6).Cells(4).Value = 7.18
            .Rows(6).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Maldives.png"



            .Rows(7).Cells(0).Value = 8
            .Rows(7).Cells(1).Value = "BAN"
            .Rows(7).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Bangladesh.png")
            .Rows(7).Cells(3).Value = "VIMLESH KUMAR"
            .Rows(7).Cells(4).Value = 7.06
            .Rows(7).Cells(5).Value = 1
            .Rows(7).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Bangladesh.png"


        End With
    End Sub

    Private Sub dgvtrack_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvtrack.DataError
        'dummy code dont delete
    End Sub

    Private Sub dgvtrackresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvtrackresult.DataError
        'dummy code dont delete
    End Sub

    Private Sub cmdfillresulttrack_Click(sender As Object, e As EventArgs) Handles cmdfillresulttrack.Click
        On Error Resume Next

        'sortresult(dgvtrack, dgvtrackresult, 5)

        sortresult1(dgvtrack, dgvtrackresult, 5)
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
            .Sort(.Columns(columntosort), System.ComponentModel.ListSortDirection.Ascending)
        End With
    End Sub
    'Sub sortresult(sourcegrid As DataGridView, targetgrid As DataGridView, columntosort As Integer)
    '    On Error Resume Next

    '    Dim targetRows = New List(Of DataGridViewRow)
    '    For Each sourceRow As DataGridViewRow In sourcegrid.Rows
    '        If (Not sourceRow.IsNewRow) Then
    '            Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
    '            For Each cell As DataGridViewCell In sourceRow.Cells
    '                If cell.Value = vbNullString And cell.ColumnIndex = columntosort Then
    '                    targetRow.Cells(cell.ColumnIndex).Value = Int(8)
    '                Else
    '                    targetRow.Cells(cell.ColumnIndex).Value = cell.Value
    '                End If
    '            Next
    '            targetRows.Add(targetRow)
    '        End If
    '    Next
    '    targetgrid.Columns.Clear()
    '    For Each column As DataGridViewColumn In sourcegrid.Columns
    '        targetgrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
    '    Next
    '    targetgrid.Rows.AddRange(targetRows.ToArray())
    '    targetgrid.Sort(targetgrid.Columns(columntosort), System.ComponentModel.ListSortDirection.Ascending)

    'End Sub

    Private Sub cmdresulttrack_Click(sender As Object, e As EventArgs) Handles cmdresulttrack.Click
        result(dgvtrackresult)
    End Sub
    Sub result(dgv As DataGridView)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgv

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Result- " & cmbSubHeader.Text)

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, i + 1)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "00.00").Replace(".", ":"))

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/result", CasparCGDataCollection.ToAMCPEscapedXml)
        End With

    End Sub
    Private Sub cmdtopthreetrack_Click(sender As Object, e As EventArgs) Handles cmdtopthreetrack.Click
        topthree(dgvtrackresult)
    End Sub
    Sub topthree(dgv As DataGridView)

        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgv

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Top Three- " & cmbSubHeader.Text)

            For i = 0 To 2
                CasparCGDataCollection.SetData("ccg_ln" & i, i + 1)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "00.00").Replace(".", ":"))


            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/topthree", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub
    Private Sub newtrack_Click(sender As Object, e As EventArgs) Handles newtrack.Click
        On Error Resume Next
        newdatasg(dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
        dgvtrackresult.Rows.Clear()
    End Sub

    Private Sub opentrack_Click(sender As Object, e As EventArgs) Handles opentrack.Click

        opendatasg("C:\casparcg\ng2022\data\track\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
        maketrack6thcolumninteger(dgvtrack)
        dgvtrackresult.Rows.Clear()
    End Sub

    Private Sub savetrack_Click(sender As Object, e As EventArgs) Handles savetrack.Click
        savedatasg("C:\casparcg\ng2022\data\track\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
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
    Sub maketrack6thcolumninteger(dgv As DataGridView)
        On Error Resume Next
        With dgv
            For ii = 0 To dgvtrack.RowCount - 1
                .Rows(ii).Cells(5).Value = CType(.Rows(ii).Cells(5).Value, Integer)
            Next
        End With
    End Sub

    Private Sub cmdPlyerIdtrack_Click(sender As Object, e As EventArgs) Handles cmdPlyerIdtrack.Click

        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvtrack.CurrentRow.Cells(3).Value)
        CasparCGDataCollection.SetData("ccgf1", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf2", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(6).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/Track/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub



    Private Sub cmdtimertrack_Click(sender As Object, e As EventArgs) Handles cmdtimertrack.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("uptimer1", txttimerminutetrac.Text + ":" + txttimersecondtrack.Text + "." + "000")
        CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "ng2022/template/Track/timer", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "startTimer(" & (txttimerminutetrac.Text) * 60000 + (txttimersecondtrack.Text) * 1000 & ")" & """")
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "pause()" & """")


    End Sub

    Dim pauseCount = 0
    Private Sub cmdtimerpausetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerpausetrack.Click
        On Error Resume Next
        'CasparCGDataCollection.Clear()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "pause()" & """")
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

        dgvtrack.CurrentRow.Cells(4).Value = txttimerminutetrac.Text + "." + Format(Val(txttimersecondtrack.Text), "00")
        pauseCount += 1
        dgvtrack.CurrentRow.Cells(5).Value = pauseCount
        cmdfillresulttrack.PerformClick()
        updatecmdIntermediatResult.PerformClick()
        'Thread.Sleep(2000)
        'txttimersecondtrack.Text = Val(txttimersecondtrack) + 2
        If pauseCount < 8 Then
            cmdtimerresumetrack.PerformClick()
        End If
    End Sub


    Private Sub ntimeropactitytrack_ValueChanged(sender As Object, e As EventArgs) Handles ntimeropactitytrack.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " opacity " & ntimeropactitytrack.Value)
    End Sub

    Private Sub cmdtimerresumetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerresumetrack.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "startTimer()" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "startTimer(" & (txttimerminutetrac.Text) * 60000 + (txttimersecondtrack.Text) * 1000 & ")" & """")

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)
        tmrtimeonform.Enabled = True
    End Sub

    Private Sub cmdlaptrack_Click(sender As Object, e As EventArgs) Handles cmdlaptrack.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccg_laps", cmblaptrack.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 3, Int(cmblayergames.Text) + 3, "ng2022/template/Track/laps", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtimerremovetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerremovetrack.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1)
        Threading.Thread.Sleep(2000)
        tmrtimeonform.Enabled = False
        pauseCount = 0
    End Sub

    Private Sub cmdindivisualresulttrack_Click(sender As Object, e As EventArgs) Handles cmdindivisualresulttrack.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", cmbSubHeader.Text)

            CasparCGDataCollection.SetData("ccg_ln" & 0, .CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("ccg_code" & 0, .CurrentRow.Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & 0, .CurrentRow.Cells(6).Value.Replace("\", "/"))

            CasparCGDataCollection.SetData("ccgf" & 0, .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("ccg_r" & 0, Format(CType(.CurrentRow.Cells(4).Value, Double), "00.00").Replace(".", ":"))

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/indivisulascore", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub

    Private Sub cmdstartlisttrack_Click(sender As Object, e As EventArgs) Handles cmdstartlisttrack.Click
        startlist(dgvtrack)
    End Sub
    Sub startlist(dgv As DataGridView)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgv

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", "Starting Lineup- " + cmbSubHeader.Text)

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)
            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
        End With

    End Sub

    Private Sub cmdstopgym_Click(sender As Object, e As EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
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

        'tmrtimeupdateontemplate.Enabled = False

    End Sub

    Private Sub cmdeventid_Click(sender As Object, e As EventArgs) Handles cmdeventid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/netball/event_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdsortbyvaluetrack_Click(sender As Object, e As EventArgs) Handles cmdsortbyvaluetrack.Click
        sortresult1(dgvtrack, dgvtrackresult, 4)
    End Sub

    Private Sub cmbgames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgames.SelectedIndexChanged
        gamelogo.ImageLocation = getgamelogoImageLocation(cmbgames.Text)

    End Sub

    Private Sub dgvtrack_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrack.CellContentClick
        If e.ColumnIndex = 2 Then

            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\flag\"
            If aa.ShowDialog = DialogResult.OK Then
                dgvtrack.CurrentCell.Value = Image.FromFile(aa.FileName)
                dgvtrack.CurrentRow.Cells(3).Value = aa.FileName
            End If
        End If
    End Sub

    Private Sub dgvtrackresult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrackresult.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\flag\"
            If aa.ShowDialog = DialogResult.OK Then
                dgvtrackresult.CurrentCell.Value = Image.FromFile(aa.FileName)
                dgvtrackresult.CurrentRow.Cells(6).Value = aa.FileName

            End If
        End If
    End Sub

    Private Sub cmdSaveas1_Click(sender As Object, e As EventArgs) Handles cmdSaveas1.Click
        saveasdatasg("C:\casparcg\ng2022\data\track", dgvtrack, cmbHeader, cmbSubHeader, lblfilenamet1track)

    End Sub

    Private Sub cmdWinner_Click(sender As Object, e As EventArgs) Handles cmdWinner.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            CasparCGDataCollection.SetData("ccgsubheader", txtWinner.Text + "-" + cmbSubHeader.Text)

            Dim i = 0
            CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

            CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)
            CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "00.00").Replace(".", ":"))

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/indivisulascore", CasparCGDataCollection.ToAMCPEscapedXml)

        End With
    End Sub

    Private Sub cmdLanGraphics_Click(sender As Object, e As EventArgs) Handles cmdLanGraphics.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrack
            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))
                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)
            Next
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 2, Int(cmblayergames.Text) + 2, "ng2022/template/track/langraphics", True, CasparCGDataCollection.ToAMCPEscapedXml)
            ' CasparDevice.SendString("mixer 1-98 perspective 0.60 0.25 1.15 0.50 0.80 0.95 -5.30 0.35")
            perspectivemixer()
            nfill()
        End With
    End Sub

    Private Sub cmdRemoveLanGraphics_Click(sender As Object, e As EventArgs) Handles cmdRemoveLanGraphics.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 2, Int(cmblayergames.Text) + 2)
        Threading.Thread.Sleep(2000)
        CasparDevice.SendString("mixer 1-" + Int(cmblayergames.Text) + 2 + " clear")

    End Sub
    Sub perspectivemixer() Handles nperspectivetlx.ValueChanged, nperspectivetly.ValueChanged, nperspectivetrx.ValueChanged, nperspectivetry.ValueChanged, nperspectivebrx.ValueChanged, nperspectivebry.ValueChanged, nperspectiveblx.ValueChanged, nperspectivebly.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 2 & " perspective " & Replace(nperspectivetlx.Value, ",", ".") & " " & Replace(nperspectivetly.Value, ",", ".") & " " & Replace(nperspectivetrx.Value, ",", ".") & " " & Replace(nperspectivetry.Value, ",", ".") & " " & Replace(nperspectivebrx.Value, ",", ".") & " " & Replace(nperspectivebry.Value, ",", ".") & " " & Replace(nperspectiveblx.Value, ",", ".") & " " & Replace(nperspectivebly.Value, ",", "."))

    End Sub
    Sub resetperpectivemixer()
        On Error Resume Next
        nperspectivetlx.Value = 0
        nperspectivetly.Value = 0

        nperspectivetrx.Value = 1
        nperspectivetry.Value = 0

        nperspectivebrx.Value = 1
        nperspectivebry.Value = 1

        nperspectiveblx.Value = 0
        nperspectivebly.Value = 1
    End Sub
    Private Sub cmdresetperspectivemixer_Click(sender As Object, e As EventArgs) Handles cmdresetperspectivemixer.Click
        On Error Resume Next
        resetperpectivemixer()
    End Sub

    Private Sub cmdRestoreValues_Click(sender As Object, e As EventArgs) Handles cmdRestoreValues.Click
        On Error Resume Next
        nperspectivetlx.Value = 0.25
        nperspectivetly.Value = 0

        nperspectivetrx.Value = 0.7
        nperspectivetry.Value = 0

        nperspectivebrx.Value = 1
        nperspectivebry.Value = 1

        nperspectiveblx.Value = 0
        nperspectivebly.Value = 1
    End Sub

    Private Sub cmdRecords_Click(sender As Object, e As EventArgs) Handles cmdRecords.Click
        showtemplate("ng2022/template/Track/records", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdSignal_Click(sender As Object, e As EventArgs) Handles cmdSignal.Click
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/Track/signal", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imgred').getElementsByTagName('image')[0].style.opacity=1" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imggreen').getElementsByTagName('image')[0].style.opacity=0" & """")

        cmdtimertrack.PerformClick()
    End Sub

    Private Sub cmdGreenSignal_Click(sender As Object, e As EventArgs) Handles cmdGreenSignal.Click
        CasparCGDataCollection.Clear()
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/Track/signal", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imgred').getElementsByTagName('image')[0].style.opacity=0" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imggreen').getElementsByTagName('image')[0].style.opacity=1" & """")
        cmdtimerresumetrack.PerformClick()
    End Sub

    Private Sub cmdLeader_Click(sender As Object, e As EventArgs) Handles cmdLeader.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            'CasparCGDataCollection.SetData("ccgheader", cmbHeader.Text)
            'CasparCGDataCollection.SetData("ccgsubheader", "Winner-" + cmbSubHeader.Text)

            Dim i = 0
            CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)
            CasparCGDataCollection.SetData("ccgLeader", txtLeader.Text)



            CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/leader", CasparCGDataCollection.ToAMCPEscapedXml)

        End With
    End Sub

    Private Sub cmdIntermediatResult_Click(sender As Object, e As EventArgs) Handles cmdIntermediatResult.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)

                If i <> 0 Then
                    CasparCGDataCollection.SetData("ccg_r" & i, "+" & (Format(CType(.Rows(i).Cells(4).Value, Double) - CType(.Rows(0).Cells(4).Value, Double), "00.00")).Replace(".", ":"))

                Else
                    CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "00.00").Replace(".", ":"))

                End If

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/IntermediatResult", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub

    Private Sub cmdfill_Click(sender As Object, e As EventArgs) Handles cmdfill.Click
        On Error Resume Next
        mixerfillreset()
    End Sub
    Sub mixerfillreset()
        On Error Resume Next
        nfillx.Value = 0
        nfilly.Value = 0
        nfillwidth.Value = 1
        nfillheight.Value = 1
    End Sub

    Private Sub nfill() Handles nfillx.ValueChanged, nfilly.ValueChanged, nfillwidth.ValueChanged, nfillheight.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 2 & " fill " & Replace(nfillx.Value, ",", ".") & " " & Replace(nfilly.Value, ",", ".") & " " & Replace(nfillwidth.Value, ",", ".") & " " & Replace(nfillheight.Value, ",", "."))

    End Sub

    Private Sub cmdRestoreValuesfill_Click(sender As Object, e As EventArgs) Handles cmdRestoreValuesfill.Click
        On Error Resume Next
        nfillx.Value = -0.09
        nfilly.Value = 0.3
        nfillwidth.Value = 1.43
        nfillheight.Value = 0.55
    End Sub
    Private Sub defautdataforball()
        On Error Resume Next

        With dgvt1ball

            .Rows.Add(8)
            .Rows(0).Cells(0).Value = "21 K Bharadwaja"
            .Rows(1).Cells(0).Value = "52 N Sri Sai"
            .Rows(2).Cells(0).Value = "73 A K Prajapati"
            .Rows(3).Cells(0).Value = "34 Deepesh Sahu"
            .Rows(4).Cells(0).Value = "18 Vatsal Reshamwala"
            .Rows(5).Cells(0).Value = "22 Devanshu Soni"
            .Rows(6).Cells(0).Value = "23 Honey Mehra"
            .Rows(7).Cells(0).Value = "24 Mayank Jain"

        End With
    End Sub

    Private Sub cmdt1lineupball_Click(sender As Object, e As EventArgs) Handles cmdt1lineupball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 7
            CasparCGDataCollection.SetData("ccgf" & i, dgvt1ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgheader", dgvtrack.CurrentRow.Cells(3).Value)
        CasparCGDataCollection.SetData("ccgsubheader", "Team List")
        CasparCGDataCollection.SetData("ccg_ln0", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccg_code0", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(6).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/track/teamlineup2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmduprowt1ball_Click(sender As Object, e As EventArgs) Handles cmduprowt1ball.Click
        On Error Resume Next
        upsg(dgvt1ball)
    End Sub

    Private Sub cmddownrowt1ball_Click(sender As Object, e As EventArgs) Handles cmddownrowt1ball.Click
        On Error Resume Next
        downsg(dgvt1ball)
    End Sub

    Private Sub cmdremoverowt1ball_Click_1(sender As Object, e As EventArgs) Handles cmdremoverowt1ball.Click
        deletesg(dgvt1ball)
    End Sub

    Private Sub cmdaddrowt1ball_Click_1(sender As Object, e As EventArgs) Handles cmdaddrowt1ball.Click
        insertsg(dgvt1ball)
    End Sub

    Private Sub cmdnewt1ball_Click_1(sender As Object, e As EventArgs) Handles cmdnewt1ball.Click
        On Error Resume Next
        newdatasg(dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdopent1ball_Click_1(sender As Object, e As EventArgs) Handles cmdopent1ball.Click
        On Error Resume Next
        opendatasg("C:\casparcg\ng2022\data\track\teamlist", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)

    End Sub

    Private Sub cmdsavet1ball_Click_1(sender As Object, e As EventArgs) Handles cmdsavet1ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\ng2022\data\track\teamlist", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub gamelogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:\casparcg\ng2022\data\games logo\", sender)
    End Sub

    Private Sub eventlogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:/casparcg/ng2022/data/event logo/", sender)
    End Sub

    Private Sub cmdRemoveLap_Click(sender As Object, e As EventArgs) Handles cmdRemoveLap.Click
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 3, Int(cmblayergames.Text) + 3)
    End Sub


    Private Sub tmrtimeonform_Tick(sender As Object, e As EventArgs) Handles tmrtimeonform.Tick
        'On Error Resume Next
        'Dim bb = Val(Now.Second.ToString)

        'Dim dif As Integer = (bb - aa)
        'aa = bb
        'If dif < 0 Then dif = dif + 60


        'txttimersecondtrack.Text = Format(Val(txttimersecondtrack.Text + dif), "00")
        'If txttimersecondtrack.Text > 59 Then
        '    txttimersecondtrack.Text = "00"
        '    txttimerminutetrac.Text = Format(txttimerminutetrac.Text + 1, "00")
        'End If
        Dim elapsedTime As Integer = (Val(txttimerminutetrac.Text)) * 60 + Val(txttimersecondtrack.Text)

        elapsedTime += 1
        txttimerminutetrac.Text = (elapsedTime \ 60).ToString()
        txttimersecondtrack.Text = (elapsedTime Mod 60).ToString()
    End Sub

    Private Sub updatecmdIntermediatResult_Click(sender As Object, e As EventArgs) Handles updatecmdIntermediatResult.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, .Rows(i).Cells(0).Value)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)

                If i <> 0 Then
                    CasparCGDataCollection.SetData("ccg_r" & i, "+" & (Format(CType(.Rows(i).Cells(4).Value, Double) - CType(.Rows(0).Cells(4).Value, Double), "00.00")).Replace(".", ":"))

                Else
                    CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "00.00").Replace(".", ":"))

                End If

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))

            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

        End With
    End Sub

    Private Sub cmdClearValue_Click(sender As Object, e As EventArgs) Handles cmdClearValue.Click
        For ii = 0 To dgvtrack.RowCount - 1
            dgvtrack.Rows(ii).Cells(4).Value = ""
            dgvtrack.Rows(ii).Cells(5).Value = ""
        Next

    End Sub

    Private Sub cmdIntermediatResultwithsubHeader_Click(sender As Object, e As EventArgs) Handles cmdIntermediatResultwithsubHeader.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        With dgvtrackresult
            CasparCGDataCollection.SetData("ccg_subHeader", txtStanding.Text)

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, .Rows(i).Cells(0).Value)

                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)

                If i <> 0 Then
                    CasparCGDataCollection.SetData("ccg_r" & i, "+" & (Format(CType(.Rows(i).Cells(4).Value, Double) - CType(.Rows(0).Cells(4).Value, Double), "00.00")).Replace(".", ":"))

                Else
                    CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "00.00").Replace(".", ":"))

                End If

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/track/intermediatResultwithHeading", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub

    Private Sub cmdfalseStart_Click(sender As Object, e As EventArgs) Handles cmdfalseStart.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccg_start", txtFalseStart.Text)

        CasparCGDataCollection.SetData("ccgf0", dgvtrack.CurrentRow.Cells(3).Value)
        CasparCGDataCollection.SetData("ccgf1", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf2", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(6).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/Track/falseStart", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
End Class
