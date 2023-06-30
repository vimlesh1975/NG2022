Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Class ucScroll


    Private Sub cmdplayscroll_Click(sender As Object, e As EventArgs) Handles cmdplayscroll.Click

        'showtemplate("ng2022/template/news/scroll/1920_1080", CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), "ng2022/template/news/scroll/1920_1080", True, CasparCGDataCollection.ToAMCPEscapedXml)
        Dim aa = "messages=["
        With dgvscroll
            For i = 0 To 3
                If .Rows(i).Cells(1).Value = True Then
                    If (i = 3) Then
                        aa = aa + "'" + .Rows(i).Cells(0).Value + "']"
                    Else
                        aa = aa + "'" + .Rows(i).Cells(0).Value + "',"
                    End If
                End If
            Next
        End With

        'Dim aa = "messages=['vimlesh Kumar Tanti', 'suresh Prasad Bihari']"

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayerscroll.Text) & " " & """" & aa & """")


    End Sub

    Private Sub ucScroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisescrolldata()

    End Sub
    Sub initialisescrolldata()

        On Error Resume Next

        'Using sr As StreamReader = New StreamReader("c:\casparcg\mydata\scroll\04.08.17.txt")

        '    dgvscroll.Rows.Clear()

        '    Dim g As Integer = 0
        '    Dim li As String
        '    Do Until sr.EndOfStream = True
        '        li = sr.ReadLine()
        '        dgvscroll.Rows.Add()
        '        Dim xyz As Array = Split(li, Chr(2))
        '        dgvscroll.Rows(g).Cells(0).Value = xyz(0)
        '        dgvscroll.Rows(g).Cells(1).Value = xyz(1)
        '        g = g + 1
        '    Loop
        '    sr.Close()
        'End Using
        'Me.dgvscroll.Columns(0).HeaderText = "c:\casparcg\mydata\scroll\04.08.17.txt"

        With dgvscroll
            .Rows.Clear()
            .Rows.Add(5)

            For i = 0 To 5
                .Rows(i).Cells(0).Value = "vimelsh Kumar Tanti" + i
                .Rows(i).Cells(1).Value = True
            Next
        End With
    End Sub
End Class
