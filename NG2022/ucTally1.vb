Public Class ucTally1
    Private Sub cmdPlayTally1_Click(sender As Object, e As EventArgs) Handles cmdPlayTally1.Click
        playTemplate()
    End Sub
    Sub playTemplate()
        On Error Resume Next
        collectData()
        showtemplate("ng2022/template/Election/Tally1/Tally1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Sub collectData()
        On Error Resume Next

        CasparCGDataCollection.Clear()

        For i = 0 To 4
            CasparCGDataCollection.SetData("ccgp" & i + 1 & "i", dgv1.Rows(i).Cells(0).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgp" & i + 1 & "n", dgv1.Rows(i).Cells(2).Value)
            If rdoWon.Checked Then
                CasparCGDataCollection.SetData("ccgp" & i + 1 & "s", dgv1.Rows(i).Cells(3).Value)
            ElseIf rdoLead.Checked Then
                CasparCGDataCollection.SetData("ccgp" & i + 1 & "s", dgv1.Rows(i).Cells(4).Value)
            ElseIf rdoTotal.Checked Then
                CasparCGDataCollection.SetData("ccgp" & i + 1 & "s", dgv1.Rows(i).Cells(5).Value)
            End If
        Next
        If rdoWon.Checked Then
            CasparCGDataCollection.SetData("ccgp5n", "WON")

        ElseIf rdoLead.Checked Then
            CasparCGDataCollection.SetData("ccgp5n", "LEAD")

        ElseIf rdoTotal.Checked Then
            CasparCGDataCollection.SetData("ccgp5n", "Total")
        End If

    End Sub
    Private Sub cmdstopcg2_Click(sender As Object, e As EventArgs) Handles cmdstopcg2.Click
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

    Private Sub ucTally1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        dgv1.Rows.Add(7)
        Dim i = 0
        dgv1.Rows(0).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\bjp.jpg"
        dgv1.Rows(1).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\cong.jpg"
        dgv1.Rows(2).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\aap.jpg"
        dgv1.Rows(3).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\oth.jpg"

        dgv1.Rows(0).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\bjp.jpg")
        dgv1.Rows(1).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\cong.jpg")
        dgv1.Rows(2).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\aap.jpg")
        dgv1.Rows(3).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\oth.jpg")

        dgv1.Rows(0).Cells(2).Value = "NDA"
        dgv1.Rows(1).Cells(2).Value = "INDI"
        dgv1.Rows(2).Cells(2).Value = "AAP"
        dgv1.Rows(3).Cells(2).Value = "OTH"
        dgv1.Rows(4).Cells(2).Value = "Won"

        For i = 0 To 4
            dgv1.Rows(i).Cells(3).Value = 10 + i
            dgv1.Rows(i).Cells(4).Value = 15 + i
            dgv1.Rows(i).Cells(5).Value = 20 + i
        Next

        For i = 3 To 5
            dgv1.Rows(4).Cells(i).Value = 200 + 2 * i & "/545"
        Next


    End Sub

    Private Sub cmdTally1Update_Click(sender As Object, e As EventArgs) Handles cmdTally1Update.Click
        UpdateTemplate()
    End Sub

    Sub UpdateTemplate()
        On Error Resume Next
        collectData()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\election\election_image\symbol"
            If aa.ShowDialog = DialogResult.OK Then
                dgv1.Rows(e.RowIndex).Cells(0).Value = aa.FileName
                dgv1.Rows(e.RowIndex).Cells(1).Value = Image.FromFile(aa.FileName)
            End If
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub chkallthree_CheckedChanged(sender As Object, e As EventArgs) Handles chkallthree.CheckedChanged
        If chkallthree.Checked Then
            tmrAllThree.Enabled = True
        Else
            tmrAllThree.Enabled = False
        End If
    End Sub
    Dim jj = 0
    Private Sub tmrAllThree_Tick(sender As Object, e As EventArgs) Handles tmrAllThree.Tick
        If jj = 0 Then
            rdoWon.Checked = True
        ElseIf jj = 1 Then
            rdoLead.Checked = True
        ElseIf jj = 2 Then
            rdoTotal.Checked = True
        End If
        'UpdateTemplate()
        playTemplate()
        jj = jj + 1
        If jj > 2 Then
            jj = 0
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        Dim selectedInterval As Integer
        If Integer.TryParse(ComboBox1.SelectedItem.ToString(), selectedInterval) Then
            tmrAllThree.Interval = selectedInterval * 1000
        End If
    End Sub


End Class
