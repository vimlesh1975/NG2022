Public Class ucPhoto1
    Private Sub cmdPlayTally1_Click(sender As Object, e As EventArgs) Handles cmdPlayTally1.Click
        playTemplate()
    End Sub
    Sub playTemplate()
        On Error Resume Next
        collectData()
        showtemplate("ng2022/template/Election/Photo1/Photo1", CasparCGDataCollection.ToAMCPEscapedXml, cmblayergames.Text)
    End Sub

    Sub collectData()
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgSymbole", dgv1.CurrentRow.Cells(0).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgParty", dgv1.CurrentRow.Cells(2).Value)
        CasparCGDataCollection.SetData("ccgPhoto", dgv1.CurrentRow.Cells(3).Value.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgConstituency", dgv1.CurrentRow.Cells(5).Value)

        CasparCGDataCollection.SetData("ccgName", dgv1.CurrentRow.Cells(6).Value)
        CasparCGDataCollection.SetData("ccgNews", dgv1.CurrentRow.Cells(7).Value)

    End Sub
    Private Sub cmdstopcg2_Click(sender As Object, e As EventArgs) Handles cmdstopcg2.Click
        stopTemplate()
    End Sub

    Sub stopTemplate()
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

        dgv1.Rows.Add(5)

        Dim i = 0
        dgv1.Rows(0).Cells(0).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\bjp.jpg"
        dgv1.Rows(1).Cells(0).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\cong.jpg"
        dgv1.Rows(2).Cells(0).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\aap.jpg"
        dgv1.Rows(3).Cells(0).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\oth.jpg"
        dgv1.Rows(4).Cells(0).Value = "C:\casparcg\NG2022\data\election\election_image\symbol\aitc.jpg"

        dgv1.Rows(0).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\bjp.jpg")
        dgv1.Rows(1).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\cong.jpg")
        dgv1.Rows(2).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\aap.jpg")
        dgv1.Rows(3).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\oth.jpg")
        dgv1.Rows(4).Cells(1).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\symbol\aitc.jpg")

        i = 2
        dgv1.Rows(0).Cells(i).Value = "NDA"
        dgv1.Rows(1).Cells(i).Value = "INDI"
        dgv1.Rows(2).Cells(i).Value = "AAP"
        dgv1.Rows(3).Cells(i).Value = "OTH"
        dgv1.Rows(4).Cells(i).Value = "AITC"

        i = 3
        dgv1.Rows(0).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\new_photo\A  NARAYANASWAMY.jpg"
        dgv1.Rows(1).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\new_photo\Chmpai Soren.jpg"
        dgv1.Rows(2).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\new_photo\CHUNNILAL SAHU.jpg"
        dgv1.Rows(3).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\new_photo\CN Annadurai.jpg"
        dgv1.Rows(4).Cells(i).Value = "C:\casparcg\NG2022\data\election\election_image\new_photo\Chinta Sambamurthy.jpg"

        i = 4
        dgv1.Rows(0).Cells(i).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\new_photo\A  NARAYANASWAMY.jpg")
        dgv1.Rows(1).Cells(i).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\new_photo\Chmpai Soren.jpg")
        dgv1.Rows(2).Cells(i).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\new_photo\CHUNNILAL SAHU.jpg")
        dgv1.Rows(3).Cells(i).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\new_photo\CN Annadurai.jpg")
        dgv1.Rows(4).Cells(i).Value = Image.FromFile("C:\casparcg\NG2022\data\election\election_image\new_photo\Chinta Sambamurthy.jpg")

        i = 5
        dgv1.Rows(0).Cells(i).Value = "Patna City"
        dgv1.Rows(1).Cells(i).Value = "Mumbai North"
        dgv1.Rows(2).Cells(i).Value = "Bhiwandi"
        dgv1.Rows(3).Cells(i).Value = "Chennai Central"
        dgv1.Rows(4).Cells(i).Value = "Haiderabad West"

        i = 6
        dgv1.Rows(0).Cells(i).Value = "A  NARAYANASWAMY"
        dgv1.Rows(1).Cells(i).Value = "Chmpai Soren"
        dgv1.Rows(2).Cells(i).Value = "CHUNNILAL SAHU"
        dgv1.Rows(3).Cells(i).Value = "CN Annadurai"
        dgv1.Rows(4).Cells(i).Value = "Chinta Sambamurthy"
        i = 7
        dgv1.Rows(0).Cells(i).Value = "Won by 2000"
        dgv1.Rows(1).Cells(i).Value = "Lagging from vimlesh Kumar by 15000"
        dgv1.Rows(2).Cells(i).Value = "Won"
        dgv1.Rows(3).Cells(i).Value = "Lost by Ramaswami by 30000"
        dgv1.Rows(4).Cells(i).Value = "Leading By 4000"





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
                dgv1.Rows(e.RowIndex).Cells(2).Value = aa.SafeFileName.Split(".")(0)
            End If
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 4 Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\election\election_image\new_photo\"
            If aa.ShowDialog = DialogResult.OK Then
                dgv1.Rows(e.RowIndex).Cells(3).Value = aa.FileName
                dgv1.Rows(e.RowIndex).Cells(4).Value = Image.FromFile(aa.FileName)
                dgv1.Rows(e.RowIndex).Cells(6).Value = aa.SafeFileName.Split(".")(0)
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
        jj = dgv1.CurrentRow.Index
    End Sub
    Dim jj = 0
    Private Sub tmrAllThree_Tick(sender As Object, e As EventArgs) Handles tmrAllThree.Tick
        On Error Resume Next

        dgv1.CurrentCell = dgv1.Rows(jj).Cells(0)
        'stopTemplate()
        'Threading.Thread.Sleep(1000)

        playTemplate()
        jj = jj + 1
        If jj > dgv1.RowCount - 2 Then
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

    Private Sub cmdDeleteRow_Click(sender As Object, e As EventArgs) Handles cmdDeleteRow.Click
        On Error Resume Next

        dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index)

    End Sub
End Class
