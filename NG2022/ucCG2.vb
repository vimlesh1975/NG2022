﻿Imports System.IO
Public Class ucCG2
    Private Sub cmd10linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd10linercg2.Click
        cg2dataandtemplate(10)
    End Sub
    Private Sub cmd9linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9linercg2.Click
        cg2dataandtemplate(9)
    End Sub
    Private Sub cmd8linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8linercg2.Click
        cg2dataandtemplate(8)
    End Sub
    Private Sub cmd7linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7linercg2.Click
        cg2dataandtemplate(7)
    End Sub
    Private Sub cmd6linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6linercg2.Click
        cg2dataandtemplate(6)
    End Sub
    Private Sub cmd5linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5linercg2.Click
        cg2dataandtemplate(5)
    End Sub
    Private Sub cmd4linercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4linercg2.Click
        cg2dataandtemplate(4)
    End Sub
    Private Sub cmdthreelinercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdthreelinercg2.Click
        cg2dataandtemplate(3)
    End Sub
    Sub cg2dataandtemplate(ByVal cg2 As Integer)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For jcg2 = 0 To (cg2 - 1)
            CasparCGDataCollection.SetData("ccgf" & jcg2, dgvinfocg2.Rows(i + jcg2).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgloader5", gamelogoforcg2.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogoforcg2.ImageLocation.Replace("\", "/"))
        showtemplate(txtTemplateDirectoryCg2.Text & "/" & cg2 & "line", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdtwolinercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtwolinercg2.Click
        cg2dataandtemplate(2)
    End Sub
    Private Sub cmdonelinercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdonelinercg2.Click
        cg2dataandtemplate(1)
    End Sub
    Private Sub cmdrefreshdatacg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefreshdatacg2.Click
        refreshdatacg2()
    End Sub
    Sub refreshdatacg2()
        On Error Resume Next
        Using sr As StreamReader = New StreamReader(lblfilenamecg2.Text)
            dgvinfocg2.Rows.Clear()
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvinfocg2.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvinfocg2.Rows(g).Cells(0).Value = xyz(0)
                g = g + 1
            Loop
            sr.Close()
        End Using
    End Sub

    Private Sub cmd3linercentercg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3linercentercg2.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For jcg2 = 0 To 2
            CasparCGDataCollection.SetData("ccgf" & jcg2, dgvinfocg2.Rows(i + jcg2).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgloader5", gamelogoforcg2.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogoforcg2.ImageLocation.Replace("\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), txtTemplateDirectoryCg2.Text & "/" & "3linecenter", True, CasparCGDataCollection.ToAMCPEscapedXml)

        showtemplate(txtTemplateDirectoryCg2.Text & "/" & "3linecenter", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdstopcg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopcg2.Click
        'On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation2(cmblayergames.Text)
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        'Threading.Thread.Sleep(1000)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)

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

    Private Sub dgvinfocg2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvinfocg2.CellClick
        On Error Resume Next
        For ddd = 0 To dgvinfocg2.RowCount - 1
            dgvinfocg2.Rows(ddd).Cells(1).Value = ""
        Next

        For ddd = 1 To 20
            dgvinfocg2.Rows(dgvinfocg2.CurrentRow.Index + ddd - 1).Cells(1).Value = ddd
        Next
    End Sub

    Private Sub cmdhidecg2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub eventlogoforcg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogoforcg2.Click
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = "c:\casparcg\ng2022\data\event logo\"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            eventlogoforcg2.ImageLocation = picofd.FileName
        End If
    End Sub

    Private Sub gamelogoforcg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamelogoforcg2.Click
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = "c:\casparcg\ng2022\data\Games logo\"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            gamelogoforcg2.ImageLocation = picofd.FileName
        End If
    End Sub

    Private Sub cmdsaveasnewfilecg2_Click(sender As Object, e As EventArgs) Handles cmdsaveasnewfilecg2.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\ng2022\data\cg2\"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvinfocg2.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvinfocg2.Rows.Count
                        sw.WriteLine(dgvinfocg2.Rows(f).Cells(0).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilenamecg2.Text = osd2.FileName
        End If
    End Sub
    Private Sub cmdnewcg2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        dgvinfocg2.Rows.Clear()

        lblfilenamecg2.Text = "New"
    End Sub
    Private Sub cmdopencg2_Click(sender As Object, e As EventArgs)
        Dim bb As New OpenFileDialog
        bb.InitialDirectory = "c:\casparcg\ng2022\data\cg2\"
        If bb.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblfilenamecg2.Text = bb.FileName
            refreshdatacg2()
            bb.Dispose()
        End If
    End Sub
    Private Sub cmdsavecg2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\ng2022\data\cg2\"

        Using sw As StreamWriter = New StreamWriter(lblfilenamecg2.Text)
            If dgvinfocg2.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgvinfocg2.Rows.Count
                    sw.WriteLine(dgvinfocg2.Rows(f).Cells(0).Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
    End Sub
    Private Sub cmduprowcg2_Click(sender As Object, e As EventArgs) Handles cmduprowcg2.Click
        upsg(dgvinfocg2)
    End Sub
    Private Sub cmddownrowcg2_Click(sender As Object, e As EventArgs) Handles cmddownrowcg2.Click
        downsg(dgvinfocg2)
    End Sub
    Private Sub cmdaddrowcg2_Click(sender As Object, e As EventArgs) Handles cmdaddrowcg2.Click
        insertsg(dgvinfocg2)
    End Sub
    Private Sub cmdremoverowcg2_Click(sender As Object, e As EventArgs) Handles cmdremoverowcg2.Click
        deletesg(dgvinfocg2)
    End Sub
    Private Sub cmdvenueidcg2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next
        If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(Int(cmblayergames.Text))
        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        CasparCGDataCollection.SetData("ccgf" & i - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i).Cells(0).Value)

        CasparCGDataCollection.SetData("ccgloader5", gamelogoforcg2.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogoforcg2.ImageLocation.Replace("\", "/"))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), txtTemplateDirectoryCg2.Text & "/" & "venue_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
    End Sub



    Private Sub ucCG2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshdatacg2()
    End Sub

    Private Sub cmdNextStepCG2_Click(sender As Object, e As EventArgs) Handles cmdNextStepCG2.Click
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Next(Int(cmblayergames.Text), Int(cmblayergames.Text))
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        'MakeMenuDropDownWhenParrented(sender)
    End Sub
    Private Sub gbcg2_Enter(sender As Object, e As EventArgs) Handles gbcg2.Enter

    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        dgvinfocg2.Rows.Clear()

        lblfilenamecg2.Text = "New"
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim bb As New OpenFileDialog
        bb.InitialDirectory = "c:\casparcg\ng2022\data\cg2\"
        If bb.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblfilenamecg2.Text = bb.FileName
            refreshdatacg2()
            bb.Dispose()
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\ng2022\data\cg2\"
        osd2.FileName = ""
        Using sw As StreamWriter = New StreamWriter(lblfilenamecg2.Text)
            If dgvinfocg2.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgvinfocg2.Rows.Count
                    sw.WriteLine(dgvinfocg2.Rows(f).Cells(0).Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
    End Sub
End Class
