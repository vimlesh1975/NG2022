Imports System.Threading
Imports Microsoft.VisualBasic.FileIO

Public Class ucCanoeSlalom
    Private Sub ucRowing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defauttrackdata()

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Kayaking"

        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "World Canoe Slalom Cup 2023"
        cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "Men's Canoe Single - Final"
    End Sub
    Sub defauttrackdata()
        DataGridViewComboBoxColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        DataGridViewComboBoxColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch

        With dgvtrack
            .Rows.Add(10)

            .Rows(0).Cells(0).Value = 1
            .Rows(0).Cells(1).Value = "IND"
            .Rows(0).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/india.png")
            .Rows(0).Cells(3).Value = "MOHAMAD ALGARNI"
            .Rows(0).Cells(4).Value = 87.2
            .Rows(0).Cells(6).Value = "C:/casparcg/NG2022/data/flag/india.png"
            .Rows(0).Cells(7).Value = 2
            .Rows(0).Cells(8).Value = 50


            .Rows(1).Cells(0).Value = 2
            .Rows(1).Cells(1).Value = "AFG"
            .Rows(1).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Afghanistan.png")
            .Rows(1).Cells(3).Value = "SANDEEP KARAN SINGH"
            .Rows(1).Cells(4).Value = 77.33
            .Rows(1).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Afghanistan.png"
            .Rows(1).Cells(7).Value = 3
            .Rows(1).Cells(8).Value = 100

            .Rows(2).Cells(0).Value = 3
            .Rows(2).Cells(1).Value = "PAK"
            .Rows(2).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Pakistan.png")
            .Rows(2).Cells(3).Value = "EMAD HAMED NOUR"
            .Rows(2).Cells(4).Value = 97.1
            .Rows(2).Cells(5).Value = 2
            .Rows(2).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Pakistan.png"
            .Rows(2).Cells(7).Value = 7
            .Rows(2).Cells(8).Value = 50

            .Rows(3).Cells(0).Value = 4
            .Rows(3).Cells(1).Value = "NEP"
            .Rows(3).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Nepal.png")
            .Rows(3).Cells(3).Value = "RASHEED RAMZI"
            .Rows(3).Cells(4).Value = 107.11
            .Rows(3).Cells(5).Value = 3
            .Rows(3).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Nepal.png"
            .Rows(3).Cells(7).Value = 3
            .Rows(3).Cells(8).Value = 0


            .Rows(4).Cells(0).Value = 5
            .Rows(4).Cells(1).Value = "SRI"
            .Rows(4).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Sri-Lanka.png")
            .Rows(4).Cells(3).Value = "HAMZA DRIOUCH"
            .Rows(4).Cells(4).Value = 105.32
            .Rows(4).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Sri-Lanka.png"
            .Rows(4).Cells(7).Value = 0
            .Rows(4).Cells(8).Value = 100

            .Rows(5).Cells(0).Value = 6
            .Rows(5).Cells(1).Value = "BHU"
            .Rows(5).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Bhutan.png")
            .Rows(5).Cells(3).Value = "RAM PRASAD SAHANI"
            .Rows(5).Cells(4).Value = 96.35
            .Rows(5).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Bhutan.png"
            .Rows(5).Cells(7).Value = 3
            .Rows(5).Cells(8).Value = 150

            .Rows(6).Cells(0).Value = 7
            .Rows(6).Cells(1).Value = "MDV"
            .Rows(6).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Maldives.png")
            .Rows(6).Cells(3).Value = "ABDULLAH OBAID"
            .Rows(6).Cells(4).Value = 106.18
            .Rows(6).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Maldives.png"
            .Rows(6).Cells(7).Value = 2
            .Rows(6).Cells(8).Value = 50


            .Rows(7).Cells(0).Value = 8
            .Rows(7).Cells(1).Value = "BAN"
            .Rows(7).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Bangladesh.png")
            .Rows(7).Cells(3).Value = "VIMLESH KUMAR"
            .Rows(7).Cells(4).Value = 85.06
            .Rows(7).Cells(5).Value = 1
            .Rows(7).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Bangladesh.png"
            .Rows(7).Cells(7).Value = 4
            .Rows(7).Cells(8).Value = 150

            .Rows(8).Cells(0).Value = 9
            .Rows(8).Cells(1).Value = "ITA"
            .Rows(8).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Italy.png")
            .Rows(8).Cells(3).Value = "PREM LAL GUPTA"
            .Rows(8).Cells(4).Value = 84.45
            .Rows(8).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Italy.png"
            .Rows(8).Cells(7).Value = 5
            .Rows(8).Cells(8).Value = 200


            .Rows(9).Cells(0).Value = 10
            .Rows(9).Cells(1).Value = "AUS"
            .Rows(9).Cells(2).Value = Image.FromFile("C:/casparcg/NG2022/data/flag/Australia.png")
            .Rows(9).Cells(3).Value = "NITIN V SUMANTH"
            .Rows(9).Cells(4).Value = 108.48
            .Rows(9).Cells(6).Value = "C:/casparcg/NG2022/data/flag/Australia.png"
            .Rows(9).Cells(7).Value = 4
            .Rows(9).Cells(8).Value = 250

            For i = 0 To .RowCount - 2
                .Rows(i).Cells(9).Value = Val(.Rows(i).Cells(4).Value) + Val(.Rows(i).Cells(7).Value) + Val(.Rows(i).Cells(8).Value)
            Next


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
                CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(9).Value, Double), "000.00"))

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/canoeslalom/result", CasparCGDataCollection.ToAMCPEscapedXml)
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
                CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(9).Value, Double), "000.00"))


            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/canoeslalom/topthree", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub
    Private Sub newtrack_Click(sender As Object, e As EventArgs) Handles newtrack.Click
        On Error Resume Next
        newdatasg(dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
        dgvtrackresult.Rows.Clear()
    End Sub

    Private Sub opentrack_Click(sender As Object, e As EventArgs) Handles opentrack.Click

        opendatasg("C:\casparcg\ng2022\data\canoeslalom\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
        maketrack6thcolumninteger(dgvtrack)
        dgvtrackresult.Rows.Clear()
    End Sub

    Private Sub savetrack_Click(sender As Object, e As EventArgs) Handles savetrack.Click
        savedatasg("C:\casparcg\ng2022\data\canoeslalom\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
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
        'CasparCGDataCollection.SetData("ccgf1", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf2", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(6).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/canoeslalom/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub



    Private Sub cmdtimertrack_Click(sender As Object, e As EventArgs) Handles cmdtimertrack.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("uptimer1", Format(Val(txttimerminutetrac.Text) * 60 + txttimersecondtrack.Text, "000") + "." + "000")
        CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "ng2022/template/canoeslalom/timer", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "startTimer(" & (txttimerminutetrac.Text) * 60000 + (txttimersecondtrack.Text) * 1000 & ")" & """")
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "pause()" & """")


    End Sub

    Private Sub cmdtimerpausetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerpausetrack.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "pause()" & """")
        dgvtrack.CurrentRow.Cells(4).Value = Val(txttimerminutetrac.Text) * 60 + Val(txttimersecondtrack.Text)
        'cmdfillresulttrack.PerformClick()
        'updatecmdIntermediatResult.PerformClick()
        tmrtimeonform.Enabled = False
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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 3, Int(cmblayergames.Text) + 3, "ng2022/template/canoeslalom/laps", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtimerremovetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerremovetrack.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1)
        tmrtimeonform.Enabled = False
    End Sub

    Private Sub cmdindivisualresulttrack_Click(sender As Object, e As EventArgs) Handles cmdindivisualresulttrack.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            CasparCGDataCollection.SetData("ccg_code" & 0, .CurrentRow.Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & 0, .CurrentRow.Cells(6).Value.Replace("\", "/"))

            CasparCGDataCollection.SetData("ccgf" & 0, .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("ccg_t" & 0, Format(CType(.CurrentRow.Cells(4).Value, Double), "000.00"))
            CasparCGDataCollection.SetData("ccg_h" & 0, .CurrentRow.Cells(7).Value)
            CasparCGDataCollection.SetData("ccg_m" & 0, .CurrentRow.Cells(8).Value)
            CasparCGDataCollection.SetData("ccg_r" & 0, Format(CType(.CurrentRow.Cells(9).Value, Double), "000.00"))

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/canoeslalom/indivisulascore", CasparCGDataCollection.ToAMCPEscapedXml)
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
            showtemplate("ng2022/template/canoeslalom/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
        End With

    End Sub

    Private Sub cmdstopgym_Click(sender As Object, e As EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If frmNG2022.chkanimation.Checked Then frmNG2022.animation2(Int(cmblayergames.Text))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(1000)
        If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(Int(cmblayergames.Text))

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
                dgvtrack.CurrentRow.Cells(6).Value = aa.FileName
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
        saveasdatasg("C:\casparcg\ng2022\data\canoeslalom", dgvtrack, cmbHeader, cmbSubHeader, lblfilenamet1track)

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
            CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(9).Value, Double), "000.00"))

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/canoeslalom/winner", CasparCGDataCollection.ToAMCPEscapedXml)

        End With
    End Sub



    Private Sub cmdRemoveLanGraphics_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 2, Int(cmblayergames.Text) + 2)
        Threading.Thread.Sleep(2000)
        CasparDevice.SendString("mixer 1-" + Int(cmblayergames.Text) + 2 + " clear")

    End Sub



    Private Sub cmdRecords_Click(sender As Object, e As EventArgs) Handles cmdRecords.Click
        showtemplate("ng2022/template/canoeslalom/records", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdSignal_Click(sender As Object, e As EventArgs)
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/canoeslalom/signal", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imgred').getElementsByTagName('image')[0].style.opacity=1" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imggreen').getElementsByTagName('image')[0].style.opacity=0" & """")

        cmdtimertrack.PerformClick()
    End Sub

    Private Sub cmdGreenSignal_Click(sender As Object, e As EventArgs)
        CasparCGDataCollection.Clear()
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/canoeslalom/signal", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imgred').getElementsByTagName('image')[0].style.opacity=0" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "document.getElementById('xccg_imggreen').getElementsByTagName('image')[0].style.opacity=1" & """")
        cmdtimerresumetrack.PerformClick()
    End Sub



    Private Sub cmdIntermediatResult_Click(sender As Object, e As EventArgs) Handles cmdIntermediatResult.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        With dgvtrackresult

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, i + 1)
                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)

                If i <> 0 Then
                    CasparCGDataCollection.SetData("ccg_r" & i, "+" & (Format(CType(.Rows(i).Cells(9).Value, Double) - CType(.Rows(0).Cells(9).Value, Double), "000.00")))

                Else
                    CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(9).Value, Double), "000.00"))

                End If

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/canoeslalom/IntermediatResult", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
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
                    CasparCGDataCollection.SetData("ccg_r" & i, "+" & (Format(CType(.Rows(i).Cells(4).Value, Double) - CType(.Rows(0).Cells(4).Value, Double), "000.00")))

                Else
                    CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(4).Value, Double), "000.00"))

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
            dgvtrack.Rows(ii).Cells(7).Value = 0
            dgvtrack.Rows(ii).Cells(8).Value = 0
            dgvtrack.Rows(ii).Cells(9).Value = 0
        Next

    End Sub

    Private Sub cmdIntermediatResultwithsubHeader_Click(sender As Object, e As EventArgs) Handles cmdIntermediatResultwithsubHeader.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        With dgvtrackresult
            CasparCGDataCollection.SetData("ccg_subHeader", txtStanding.Text)

            For i = 0 To .RowCount - 2
                CasparCGDataCollection.SetData("ccg_ln" & i, i + 1)

                CasparCGDataCollection.SetData("ccg_code" & i, .Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("ccgloader" & i, .Rows(i).Cells(6).Value.Replace("\", "/"))

                CasparCGDataCollection.SetData("ccgf" & i, .Rows(i).Cells(3).Value)

                If i <> 0 Then
                    CasparCGDataCollection.SetData("ccg_r" & i, "+" & (Format(CType(.Rows(i).Cells(9).Value, Double) - CType(.Rows(0).Cells(9).Value, Double), "000.00")))

                Else
                    CasparCGDataCollection.SetData("ccg_r" & i, Format(CType(.Rows(i).Cells(9).Value, Double), "000.00"))

                End If

            Next

            CasparCGDataCollection.SetData("ccgloader55", gamelogo.ImageLocation.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgloader56", eventlogo.ImageLocation.Replace("\", "/"))
            showtemplate("ng2022/template/canoeslalom/intermediatResultwithHeading", CasparCGDataCollection.ToAMCPEscapedXml)
        End With
    End Sub

    Private Sub cmdfalseStart_Click(sender As Object, e As EventArgs) Handles cmdfalseStart.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccg_start", txtFalseStart.Text)

        CasparCGDataCollection.SetData("ccgf0", dgvtrack.CurrentRow.Cells(3).Value)
        'CasparCGDataCollection.SetData("ccgf1", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf2", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(6).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/canoeslalom/falseStart", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayerId2_Click(sender As Object, e As EventArgs) Handles cmdplayerId2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvtrack.CurrentRow.Cells(3).Value)
        'CasparCGDataCollection.SetData("ccgf1", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf2", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(6).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/canoeslalom/player_id2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdCourseDescription_Click(sender As Object, e As EventArgs) Handles cmdCourseDescription.Click
        showtemplate("ng2022/template/canoeslalom/CourseDescription", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Sub calculateTotal()
        With dgvtrack
            For i = 0 To .RowCount - 2
                .Rows(i).Cells(9).Value = Val(.Rows(i).Cells(4).Value) + Val(.Rows(i).Cells(7).Value) + Val(.Rows(i).Cells(8).Value)
            Next
        End With
    End Sub

    Private Sub dgvtrack_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrack.CellValueChanged
        If e.ColumnIndex = 4 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
            calculateTotal()
        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub cmblayergames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblayergames.SelectedIndexChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
