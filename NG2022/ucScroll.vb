Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Threading

Public Class ucScroll


    Sub UpdateData()
        On Error Resume Next
        Dim aa = "messages=["
        With dgvscroll
            For i = 0 To .RowCount - 2
                If .Rows(i).Cells(1).Value = 1 And .Rows(i).Cells(0).Value <> "" Then
                    If (i = .RowCount - 2) Then
                        'If (chkCapitalise.Checked ,.Rows(i).Cells(0).Value.ToUpper , .Rows(i).Cells(0).Value)
                        aa = aa + "'" + If(chkCapitalise.Checked, .Rows(i).Cells(0).Value.ToUpper, .Rows(i).Cells(0).Value) + txtdelemeterforscroll.Text + "']"
                    Else
                        aa = aa + "'" + If(chkCapitalise.Checked, .Rows(i).Cells(0).Value.ToUpper, .Rows(i).Cells(0).Value) + txtdelemeterforscroll.Text + "',"
                    End If
                End If
            Next
            If .Rows(.RowCount - 2).Cells(1).Value = False Then
                Dim result As String = aa.Substring(0, aa.Length - 1)
                aa = result + "]"
            End If
        End With

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & aa & """")

    End Sub
    Private Sub cmdplayscroll_Click(sender As Object, e As EventArgs) Handles cmdplayscroll.Click

        'showtemplate("ng2022/template/news/scroll/1920_1080", CasparCGDataCollection.ToAMCPEscapedXml)
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), txtScrollTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        UpdateData()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "_speed=" & nspeedscroll.Value & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "_gap=" & txtGap.Text & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "_ltr=" & If(chkltr.Checked, "true", "false") & """")
        'Thread.Sleep(100)

        If chkChangeColor.Checked Then
            Dim fontColor = "document.getElementById('scroll').getElementsByTagName('text')[0].style.fill=" + "'#" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.ForeColor.R, cmdstripcolor.ForeColor.G, cmdstripcolor.ForeColor.B) + "'"
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & fontColor & """")

            Dim stripColor = "document.getElementById('scroll_strip').getElementsByTagName('rect')[0].style.fill=" + "'#" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.BackColor.R, cmdstripcolor.BackColor.G, cmdstripcolor.BackColor.B) + "'"
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & stripColor & """")

        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "window.start()" & """")


    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
    Private Sub ucScroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisescrolldata()

    End Sub
    Sub initialisescrolldata()

        On Error Resume Next

        Using sr As StreamReader = New StreamReader("c:\casparcg\ng2022\data\news\scroll\all.txt")

            dgvscroll.Rows.Clear()

            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvscroll.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvscroll.Rows(g).Cells(0).Value = xyz(0)
                dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                g = g + 1
            Loop
            sr.Close()
        End Using
        Me.dgvscroll.Columns(0).HeaderText = "c:\casparcg\mydata\scroll\all.txt"

        'With dgvscroll
        '    .Rows.Clear()
        '    .Rows.Add(5)

        '    For i = 0 To 4
        '        .Rows(i).Cells(0).Value = "vimelsh Kumar Tanti" + i.ToString
        '        .Rows(i).Cells(1).Value = True
        '    Next
        'End With
    End Sub

    Private Sub cmdstripcolor_Click(sender As Object, e As EventArgs) Handles cmdstripcolor.Click
        On Error Resume Next
        If chkChangeColor.Checked Then
            Dim cd1 As New ColorDialog

            If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                cmdstripcolor.BackColor = cd1.Color
                cmdcolor.BackColor = cd1.Color
                CasparCGDataCollection.Clear() 'cgData.Clear()
                CasparCGDataCollection.SetData("stripcolor", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.BackColor.R, cmdstripcolor.BackColor.G, cmdstripcolor.BackColor.B))
                Dim stripColor = "document.getElementById('scroll_strip').getElementsByTagName('rect')[0].style.fill=" + "'#" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.BackColor.R, cmdstripcolor.BackColor.G, cmdstripcolor.BackColor.B) + "'"
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & stripColor & """")
            End If
        End If

    End Sub

    Private Sub cmdcolor_Click(sender As Object, e As EventArgs) Handles cmdcolor.Click
        On Error Resume Next
        If chkChangeColor.Checked Then
            Dim cd1 As New ColorDialog

            If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                cmdstripcolor.ForeColor = cd1.Color
                cmdcolor.ForeColor = cd1.Color
                CasparCGDataCollection.Clear() 'cgData.Clear()
                'CasparCGDataCollection.SetData("stripcolor", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.BackColor.R, cmdstripcolor.BackColor.G, cmdstripcolor.BackColor.B))
                Dim fontColor = "document.getElementById('scroll').getElementsByTagName('text')[0].style.fill=" + "'#" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.ForeColor.R, cmdstripcolor.ForeColor.G, cmdstripcolor.ForeColor.B) + "'"
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & fontColor & """")
            End If
        End If


    End Sub

    Private Sub nspeedscroll_ValueChanged(sender As Object, e As EventArgs) Handles nspeedscroll.ValueChanged
        On Error Resume Next

        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "_speed=" & nspeedscroll.Value & """")

    End Sub

    Private Sub cmdUpdateData_Click(sender As Object, e As EventArgs) Handles cmdUpdateData.Click
        UpdateData()
    End Sub

    Private Sub cmdstopscroll_Click(sender As Object, e As EventArgs) Handles cmdstopscroll.Click
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "window.stop()" & """")

    End Sub

    Private Sub chkCapitalise_CheckedChanged(sender As Object, e As EventArgs) Handles chkCapitalise.CheckedChanged
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & "capitalizeArray()" & """")
        UpdateData()
    End Sub

    Private Sub cmdselectallforscroll_Click(sender As Object, e As EventArgs) Handles cmdselectallforscroll.Click
        On Error Resume Next
        Dim iscrollselectall As Integer
        For iscrollselectall = 0 To dgvscroll.RowCount - 1
            dgvscroll.Rows(iscrollselectall).Cells(1).Value = 1
        Next
    End Sub

    Private Sub cmddeselectallforscroll_Click(sender As Object, e As EventArgs) Handles cmddeselectallforscroll.Click
        On Error Resume Next
        Dim iscrolldeselectall As Integer
        For iscrolldeselectall = 0 To dgvscroll.RowCount - 1
            dgvscroll.Rows(iscrolldeselectall).Cells(1).Value = 0
        Next
    End Sub

    Private Sub cmduptsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduptsscroll.Click
        clipmoveupscroll()
    End Sub
    Sub clipmoveupscroll()
        On Error Resume Next
        If Me.dgvscroll.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvscroll.CurrentRow
            Me.dgvscroll.Rows.Remove(myRow)
            Me.dgvscroll.Rows.Insert(curRow - 1, myRow)
            dgvscroll.CurrentCell = dgvscroll.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub cmddowntsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddowntsscroll.Click
        On Error Resume Next
        clipmovedownscroll()
    End Sub
    Sub clipmovedownscroll()
        On Error Resume Next
        If Me.dgvscroll.CurrentCell.RowIndex <> dgvscroll.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvscroll.CurrentRow
            Me.dgvscroll.Rows.Remove(myRow)
            Me.dgvscroll.Rows.Insert(curRow + 1, myRow)
            dgvscroll.CurrentCell = dgvscroll.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub cmdinserttsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinserttsscroll.Click
        On Error Resume Next
        clipinsertscroll()
    End Sub
    Sub clipinsertscroll()
        On Error Resume Next
        dgvscroll.Rows.Insert(dgvscroll.CurrentRow.Index)
        dgvscroll.Rows(dgvscroll.CurrentRow.Index - 1).Cells(3).Value = 1
    End Sub

    Private Sub cmddeletetsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeletetsscroll.Click
        On Error Resume Next
        deleteclipscroll()
    End Sub
    Sub deleteclipscroll()
        On Error Resume Next
        dgvscroll.Rows.RemoveAt(dgvscroll.CurrentRow.Index)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deleteclipscroll()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        copyscroll()
    End Sub
    Sub copyscroll()
        tempRow = Me.dgvscroll.CurrentRow
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        insertcopiedscroll()
    End Sub
    Sub insertcopiedscroll()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
        dgvscroll.Rows.Insert(dgvscroll.CurrentRow.Index)
        dgvscroll.CurrentCell = dgvscroll.Rows(curRow).Cells(0)
        Me.dgvscroll.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvscroll.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvscroll()
    End Sub
    Sub newdgvscroll()
        On Error Resume Next
        dgvscroll.Rows.Clear()
        dgvscroll.Rows.Add(7)
        Me.dgvscroll.Columns(0).HeaderText = "new playlist"
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfilescroll()
    End Sub
    Sub openfilescroll()
        On Error Resume Next

        ofd2.InitialDirectory = "c:\casparcg\ng2022\data\news\scroll\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                dgvscroll.Rows.Clear()

                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvscroll.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvscroll.Rows(g).Cells(0).Value = Replace(xyz(0), Chr(2), " ") 'xyz(0)
                    dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvscroll.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefilescroll()
    End Sub
    Sub savefilescroll()
        On Error Resume Next

        Using sw As StreamWriter = New StreamWriter(dgvscroll.Columns(0).HeaderText)
            If dgvscroll.Rows.Count = 0 Then
                sw.Write("")
            Else

                Dim f As Integer = 0
                Do Until f = dgvscroll.Rows.Count
                    If dgvscroll.Rows(f).Cells(1).Value = False Then dgvscroll.Rows(f).Cells(1).Value = "0"
                    'sw.WriteLine(Replace(dgvscroll.Rows(f).Cells(0).Value, Chr(2), " ") & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                    sw.WriteLine(Replace(Replace(dgvscroll.Rows(f).Cells(0).Value, Chr(2), " "), vbNewLine, "") & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
        'Me.dgvscroll.Columns(0).HeaderText = osd2.FileName
        'End If
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        On Error Resume Next
        saveasfilescroll()
    End Sub
    Sub saveasfilescroll()
        On Error Resume Next
        osd2.InitialDirectory = "c:\casparcg\ng2022\data\news\scroll\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvscroll.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvscroll.Rows.Count
                        If dgvscroll.Rows(f).Cells(1).Value = False Then dgvscroll.Rows(f).Cells(1).Value = "0"
                        'sw.WriteLine(dgvscroll.Rows(f).Cells(0).Value & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                        sw.WriteLine(Replace(Replace(dgvscroll.Rows(f).Cells(0).Value, Chr(2), " "), vbNewLine, "") & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvscroll.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub
    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        insertfilescroll()
    End Sub
    Sub insertfilescroll()
        On Error Resume Next

        ofd2.InitialDirectory = "c:\casparcg\ng2022\data\news\scroll\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                'dgvscroll.Rows.Clear()

                Dim g As Integer = dgvscroll.CurrentRow.Index
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvscroll.Rows.Insert(g)
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvscroll.Rows(g).Cells(0).Value = Replace(xyz(0), Chr(2), " ")
                    dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            'Me.dgvscroll.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Private Sub cmdStopImmediate_Click(sender As Object, e As EventArgs) Handles cmdStopImmediate.Click
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Remove(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text))

    End Sub
End Class
