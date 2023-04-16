Imports System.IO

Public Class ucShooting
    Private Sub ucGymnastic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        defauttrackdata()

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Shooting"

        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "World Shooting Cup 2023"
        'cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "25m Rapid Fire Pistol Men - Final"

    End Sub

    Private Sub dgvtrack_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrack.CellClick
        If e.ColumnIndex >= 5 AndAlso e.ColumnIndex <= 9 AndAlso TypeOf dgvtrack.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
            Dim cell As DataGridViewCheckBoxCell = CType(dgvtrack.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            cell.Value = Not cell.Value ' toggle the value of the checkbox
            dgvtrack.EndEdit() ' commit the changes made to the checkbox cell
            'dgvtrack.CommitEdit(DataGridViewDataErrorContexts.Commit) ' commit the changes made to the checkbox cell
            Dim total As Integer = 0
            For i As Integer = 5 To 9
                If dgvtrack.Rows(e.RowIndex).Cells(i).Value = True Then
                    total += 1
                End If
            Next
            dgvtrack.Rows(e.RowIndex).Cells(10).Value = total


        End If

        btnDummy.PerformClick()

        With dgvtrack
            For i = 0 To .RowCount - 2
                .Rows(i).Cells(12).Value = Val(.Rows(i).Cells(10).Value) + Val(.Rows(i).Cells(11).Value)
            Next
        End With


    End Sub


    Sub defauttrackdata()
        DataGridViewComboBoxColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch

        With dgvtrack
            .Rows.Add(10)
            Dim img As String
            Dim i As Integer

            img = "C:/casparcg/NG2022/data/flag/india.png"
            i = 0
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "IND"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "MOHAMAD ALGARNI"
            .Rows(i).Cells(11).Value = i + 15


            img = "C:/casparcg/NG2022/data/flag/Afghanistan.png"
            i = 1
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "AFG"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "SANDEEP KARAN SINGH"
            .Rows(i).Cells(11).Value = i + 15


            img = "C:/casparcg/NG2022/data/flag/Pakistan.png"
            i = 2

            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "PAK"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "EMAD HAMED NOUR"
            .Rows(i).Cells(11).Value = i + 15

            img = "C:/casparcg/NG2022/data/flag/Nepal.png"
            i = 3

            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "NEP"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "RASHEED RAMZI"
            .Rows(i).Cells(11).Value = i + 15

            img = "C:/casparcg/NG2022/data/flag/Bhutan.png"
            i = 4
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "BHU"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "RAM PRASAD SAHANI"
            .Rows(i).Cells(11).Value = i + 15


            img = "C:/casparcg/NG2022/data/flag/Bolivia.png"
            i = 5
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "AUS"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "Viraj Vimlesh Prasad"
            .Rows(i).Cells(11).Value = i + 15

            img = "C:/casparcg/NG2022/data/flag/Maldives.png"
            i = 6
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "MDV"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "ABDULLAH OBAID"
            .Rows(i).Cells(11).Value = i + 15


            img = "C:/casparcg/NG2022/data/flag/Bangladesh.png"
            i = 7
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "BAN"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "VIMLESH KUMAR"
            .Rows(i).Cells(11).Value = i + 15

            img = "C:/casparcg/NG2022/data/flag/Italy.png"
            i = 8
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "ITA"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "PREM LAL GUPTA"
            .Rows(i).Cells(11).Value = i + 15

            img = "C:/casparcg/NG2022/data/flag/Australia.png"
            i = 9
            .Rows(i).Cells(0).Value = i + 1
            .Rows(i).Cells(1).Value = "AUS"
            .Rows(i).Cells(2).Value = Image.FromFile(img)
            .Rows(i).Cells(3).Value = img
            .Rows(i).Cells(4).Value = "NITIN V SUMANTH"
            .Rows(i).Cells(11).Value = i + 15

            For i = 0 To .RowCount - 2
                .Rows(i).Cells(10).Value = 0
                .Rows(i).Cells(12).Value = Val(.Rows(i).Cells(10).Value) + Val(.Rows(i).Cells(11).Value)
            Next


        End With
    End Sub

    Private Sub dgvtrack_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvtrack.DataError
        'dummy code dont delete
    End Sub

    Private Sub cmdstopgym_Click(sender As Object, e As EventArgs) Handles cmdstopgym.Click

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

    Private Sub cmdeventid_Click(sender As Object, e As EventArgs) Handles cmdeventid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/Gymnastics/event_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub gamelogo_Click(sender As Object, e As EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:\casparcg\ng2022\data\games logo\", sender)
    End Sub

    Private Sub eventlogo_Click(sender As Object, e As EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:/casparcg/ng2022/data/event logo/", sender)
    End Sub

    Private Sub cmbgames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgames.SelectedIndexChanged
        gamelogo.ImageLocation = getgamelogoImageLocation(cmbgames.Text)
    End Sub








    Private Sub dgvGymnastics_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        'dummy dont delete
    End Sub
    Private Sub dgvGymnastics_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)

        e.Row.Cells(2).Value = "BLK"
    End Sub

    Private Sub cmdSeries1_Click(sender As Object, e As EventArgs) Handles cmdSeries1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvtrack.CurrentRow.Cells(4).Value)
        CasparCGDataCollection.SetData("ccgf1", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf2", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(3).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/shooting/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub Score_Click(sender As Object, e As EventArgs) Handles Score.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccg_csn", dgvtrack.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccg_sn", dgvtrack.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgf0", dgvtrack.CurrentRow.Cells(4).Value)
        CasparCGDataCollection.SetData("ccg_total", dgvtrack.CurrentRow.Cells(12).Value)

        CasparCGDataCollection.SetData("ccg_series", cmbSeries.Text)
        CasparCGDataCollection.SetData("ccgloader1", dgvtrack.CurrentRow.Cells(3).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("ng2022/template/shooting/ScoreRapidFire", CasparCGDataCollection.ToAMCPEscapedXml)

        For i = 5 To 9
            Dim colorValue As String = If(dgvtrack.CurrentRow.Cells(i).Value = True, "Green", "Red")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setCircleColor('circle" & i - 4 & "','" & colorValue & "')" & """")
        Next

    End Sub
    Private Sub dgvtrack_SelectionChanged(sender As Object, e As EventArgs) Handles dgvtrack.SelectionChanged
        For Each row As DataGridViewRow In dgvtrack.Rows
            row.DefaultCellStyle.BackColor = Color.White
        Next
        If dgvtrack.CurrentRow IsNot Nothing Then
            dgvtrack.CurrentRow.DefaultCellStyle.BackColor = Color.Orange
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) & " " & """" & "setCircleColor('circle" & "1" & "','red')" & """")
    End Sub

    Private Sub dgvtrack_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrack.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\flag\"
            If aa.ShowDialog = DialogResult.OK Then
                With dgvtrack
                    .CurrentCell.Value = Image.FromFile(aa.FileName)
                    .CurrentRow.Cells(3).Value = aa.FileName
                    .CurrentRow.Cells(1).Value = Path.GetFileNameWithoutExtension(aa.FileName).Substring(0, 3).ToUpper()
                    .CurrentRow.Cells(4).Value = Path.GetFileNameWithoutExtension(aa.FileName).ToUpper()
                End With
            End If
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

    Private Sub newtrack_Click(sender As Object, e As EventArgs) Handles newtrack.Click
        On Error Resume Next
        newdatasg(dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)

    End Sub

    Private Sub savetrack_Click(sender As Object, e As EventArgs) Handles savetrack.Click
        savedatShooting("C:\casparcg\ng2022\data\shooting\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
    End Sub

    Sub savedatShooting(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
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
                            If k > 4 And k < 10 Then
                                str = str & If(dgvtrack.Rows(f).Cells(k).Value = True, "1", "0") & ","
                            Else
                                If k = 2 Then
                                    str = str & dgvname.Rows(f).Cells(3).Value & ","
                                Else
                                    str = str & dgvname.Rows(f).Cells(k).Value & ","
                                End If
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

    Private Sub opentrack_Click(sender As Object, e As EventArgs) Handles opentrack.Click
        opendataShooting("C:\casparcg\ng2022\data\shooting\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
    End Sub
    Sub opendataShooting(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
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
                            If k = 2 Then
                                dgvname.Rows(g).Cells(k).Value = Image.FromFile(xyz(k))
                            Else
                                If k > 4 And k < 10 Then
                                    dgvname.Rows(g).Cells(k).Value = If(xyz(k) = 1, True, False)
                                Else
                                    dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                                End If
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

End Class
