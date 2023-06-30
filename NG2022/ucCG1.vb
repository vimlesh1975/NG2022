Imports System.IO

Public Class ucCG1

    Private Sub cmdwelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdwelcome.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf1", w1.Text)
        CasparCGDataCollection.SetData("ccgf2", w2.Text)
        CasparCGDataCollection.SetData("ccgf3", w3.Text)

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/welcome", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmDvenueid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDvenueid1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtvenueid1.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/venue_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdrefree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefree.Click
        On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(cmblayergames.Text)

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtrefreename.Text)
        CasparCGDataCollection.SetData("ccgf1", txtrefreedegination.Text)

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/official_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdcomentator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcomentator.Click
        On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(cmblayergames.Text)
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf1", txtcommentatordesignation.Text)
        CasparCGDataCollection.SetData("ccgf2", txtcommentatorname1.Text)
        CasparCGDataCollection.SetData("ccgf3", txtcommentatorname2.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/commentators", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/commentators", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdMedalPresentorId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedalPresentorId.Click
        On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(cmblayergames.Text)

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtofficialname.Text)
        CasparCGDataCollection.SetData("ccgf1", txtofficialdesignation.Text)

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/official_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdp1.Click
        On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(cmblayergames.Text)
        Threading.Thread.Sleep(250)
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf1", p1.Text)
        CasparCGDataCollection.SetData("ccgf2", p2.Text)
        CasparCGDataCollection.SetData("ccgf3", p3.Text)

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/welcome", CasparCGDataCollection.ToAMCPEscapedXml)


    End Sub





    Private Sub cmdeventshedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub piceventcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = "C:\casparcg\mydata\games2\games logo\"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            eventlogo.ImageLocation = picofd.FileName
        End If
    End Sub

    Private Sub cmdleftotopcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleftotopcg.Click
        On Error Resume Next
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(cmblayergames.Text)
        'Threading.Thread.Sleep(250)

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmblefttopcg.Text)

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/lefttop", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/lefttop", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdonelinercg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdonelinercg.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtonelinercg.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        'If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(cmblayergames.Text)
        'Threading.Thread.Sleep(250)

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/cg/oneliner", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'Threading.Thread.Sleep(1300)
        'If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(cmblayergames.Text)
        showtemplate("ng2022/template/cg/oneliner", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Sub winnerdefaultdat()
        On Error Resume Next

        With dgvwinner
            .Rows.Add(8)

            .Rows(0).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Chandigarh.png")
            .Rows(0).Cells(1).Value = "Chandigarh"
            .Rows(0).Cells(2).Value = "C:\casparcg\ng2022\data\country\Chandigarh.png"

            .Rows(1).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\GOA.png")
            .Rows(1).Cells(1).Value = "GOA"
            .Rows(1).Cells(2).Value = "C:\casparcg\ng2022\data\country\GOA.png"

            .Rows(2).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Karnataka.png")
            .Rows(2).Cells(1).Value = "Karnataka"
            .Rows(2).Cells(2).Value = "C:\casparcg\ng2022\data\country\Karnataka.png"

            .Rows(3).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Himachal Pradesh.png")
            .Rows(3).Cells(1).Value = "Himachal Pradesh"
            .Rows(3).Cells(2).Value = "C:\casparcg\ng2022\data\country\Himachal Pradesh.png"

            .Rows(4).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Jammu Kashmir.png")
            .Rows(4).Cells(1).Value = "Jammu Kashmir"
            .Rows(4).Cells(2).Value = "C:\casparcg\ng2022\data\country\Jammu Kashmir.png"

            .Rows(5).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Jharkhand.png")
            .Rows(5).Cells(1).Value = "Jharkhand"
            .Rows(5).Cells(2).Value = "C:\casparcg\ng2022\data\country\Jharkhand.png"



            .Rows(6).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Maharashtra.png")
            .Rows(6).Cells(1).Value = "Maharashtra"
            .Rows(6).Cells(2).Value = "C:\casparcg\ng2022\data\country\Maharashtra.png"

            .Rows(7).Cells(0).Value = Image.FromFile("C:\casparcg\ng2022\data\country\Madhya Pradesh.png")
            .Rows(7).Cells(1).Value = "Madhya Pradesh"
            .Rows(7).Cells(2).Value = "C:\casparcg\ng2022\data\country\Madhya Pradesh.png"
        End With
    End Sub

    Private Sub ucCG1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winnerdefaultdat()
        cmbheadercg.DataSource = New BindingSource(headerText, "")
        cmbheadercg.Text = "World Rowing Cup 2023"
        cmbsubheadercg.DataSource = New BindingSource(subHeader, "")
        cmbsubheadercg.Text = "Men's Single Sculls"
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

    Private Sub cmdeventidcg_Click(sender As Object, e As EventArgs) Handles cmdeventidcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/event_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub



    Private Sub cmdplayeridcg_Click(sender As Object, e As EventArgs) Handles cmdplayeridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.CurrentRow.Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdgoldcg_Click(sender As Object, e As EventArgs) Handles cmdgoldcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.Rows(0).Cells(1).Value)
        CasparCGDataCollection.SetData("ccgmedal", "GOLD")
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.Rows(0).Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/gold", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdvictoryidcg_Click(sender As Object, e As EventArgs) Handles cmdvictoryidcg.Click

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgf1", "Victory Ceremony")
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/victory_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdbronzecg_Click(sender As Object, e As EventArgs) Handles cmdbronzecg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.Rows(2).Cells(1).Value)
        CasparCGDataCollection.SetData("ccgmedal", "BRONZE")
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.Rows(2).Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/gold", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdbronze2cg_Click(sender As Object, e As EventArgs) Handles cmdbronze2cg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.Rows(2).Cells(1).Value)
        CasparCGDataCollection.SetData("ccgmedal", "BRONZE")
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.Rows(2).Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/gold", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdmedalallcg_Click(sender As Object, e As EventArgs) Handles cmdmedalallcg.Click
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        For imedalall = 0 To 2
            CasparCGDataCollection.SetData("ccgf" & imedalall, dgvwinner.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(2).Value.Replace("\", "/"))
        Next
        showtemplate("ng2022/template/cg/Medal All Three", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdwinneridcg_Click(sender As Object, e As EventArgs) Handles cmdwinneridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("ccgsubheader", "Winner-" & cmbsubheadercg.Text)
        Else
            CasparCGDataCollection.SetData("ccgsubheader", "Winners-" & cmbsubheadercg.Text)
        End If
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.Rows(0).Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.Rows(0).Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/winner", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdrunnerupridcg_Click(sender As Object, e As EventArgs) Handles cmdrunnerupridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("ccgsubheader", "Runner Up-" & cmbsubheadercg.Text)
        Else
            CasparCGDataCollection.SetData("ccgsubheader", "Runners Up-" & cmbsubheadercg.Text)
        End If
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.Rows(1).Cells(1).Value)
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.Rows(1).Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/winner", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdRoadToSemiFinal_Click(sender As Object, e As EventArgs) Handles cmdRoadToSemiFinal.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Road To SemiFinal- " & cmbsubheadercg.Text)
        For i = 0 To 7
            CasparCGDataCollection.SetData("ccgloader" & i + 1, dgvwinner.Rows(i).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf" & i, dgvwinner.Rows(i).Cells(1).Value)
        Next

        If rdo0.Checked Then
            CasparCGDataCollection.SetData("ccgloader9", dgvwinner.Rows(0).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf8", dgvwinner.Rows(0).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader9", dgvwinner.Rows(1).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf8", dgvwinner.Rows(1).Cells(1).Value)
        End If

        If rdo2.Checked Then
            CasparCGDataCollection.SetData("ccgloader10", dgvwinner.Rows(2).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf9", dgvwinner.Rows(2).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader10", dgvwinner.Rows(3).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf9", dgvwinner.Rows(3).Cells(1).Value)
        End If

        If rdo4.Checked Then
            CasparCGDataCollection.SetData("ccgloader11", dgvwinner.Rows(4).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf10", dgvwinner.Rows(4).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader11", dgvwinner.Rows(5).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf10", dgvwinner.Rows(5).Cells(1).Value)
        End If

        If rdo6.Checked Then
            CasparCGDataCollection.SetData("ccgloader12", dgvwinner.Rows(6).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf11", dgvwinner.Rows(6).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader12", dgvwinner.Rows(7).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf11", dgvwinner.Rows(7).Cells(1).Value)
        End If
        CasparCGDataCollection.SetData("ccgloader51", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader52", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/RoadToSemiFinal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdroadtofinal_Click(sender As Object, e As EventArgs) Handles cmdroadtofinal.Click
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Road To Final- " & cmbsubheadercg.Text)
        For i = 0 To 7
            CasparCGDataCollection.SetData("ccgloader" & i + 1, dgvwinner.Rows(i).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf" & i, dgvwinner.Rows(i).Cells(1).Value)
        Next

        If rdo0.Checked Then
            CasparCGDataCollection.SetData("ccgloader9", dgvwinner.Rows(0).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf8", dgvwinner.Rows(0).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader9", dgvwinner.Rows(1).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf8", dgvwinner.Rows(1).Cells(1).Value)
        End If

        If rdo2.Checked Then
            CasparCGDataCollection.SetData("ccgloader10", dgvwinner.Rows(2).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf9", dgvwinner.Rows(2).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader10", dgvwinner.Rows(3).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf9", dgvwinner.Rows(3).Cells(1).Value)
        End If

        If rdo4.Checked Then
            CasparCGDataCollection.SetData("ccgloader11", dgvwinner.Rows(4).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf10", dgvwinner.Rows(4).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader11", dgvwinner.Rows(5).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf10", dgvwinner.Rows(5).Cells(1).Value)
        End If

        If rdo6.Checked Then
            CasparCGDataCollection.SetData("ccgloader12", dgvwinner.Rows(6).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf11", dgvwinner.Rows(6).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("ccgloader12", dgvwinner.Rows(7).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf11", dgvwinner.Rows(7).Cells(1).Value)
        End If
        CasparCGDataCollection.SetData("ccgloader51", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader52", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/RoadToFinal", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmd2refereescg_Click(sender As Object, e As EventArgs) Handles cmd2refereescg.Click
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        For imedalall = 0 To 1
            CasparCGDataCollection.SetData("ccgf" & imedalall, dgvwinner.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(2).Value.Replace("\", "/"))
        Next
        showtemplate("ng2022/template/cg/officailNames", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupcg_Click(sender As Object, e As EventArgs) Handles cmdgroupcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 7
            CasparCGDataCollection.SetData("ccgloader" & i + 1, dgvwinner.Rows(i).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf" & i, dgvwinner.Rows(i).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("ccgloader51", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader52", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/group", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdsilvercg_Click(sender As Object, e As EventArgs) Handles cmdsilvercg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgf0", dgvwinner.Rows(1).Cells(1).Value)
        CasparCGDataCollection.SetData("ccgmedal", "SILVER")
        CasparCGDataCollection.SetData("ccgloader1", dgvwinner.Rows(1).Cells(2).Value.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/gold", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdmedalallbronze2cg_Click(sender As Object, e As EventArgs) Handles cmdmedalallbronze2cg.Click
        On Error Resume Next
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        For imedalall = 0 To 3
            CasparCGDataCollection.SetData("ccgf" & imedalall, dgvwinner.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("ccgloader" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(2).Value.Replace("\", "/"))
        Next
        showtemplate("ng2022/template/cg/Medal All Three2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdw1_Click_1(sender As Object, e As EventArgs) Handles cmdw1.Click
        On Error Resume Next
        showtemplate("ng2022/template/cg/Opening", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdeventshedule_Click_1(sender As Object, e As EventArgs) Handles cmdeventshedule.Click
        On Error Resume Next
        showtemplate("ng2022/template/cg/event_shedule1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdeventshedule2_Click(sender As Object, e As EventArgs) Handles cmdeventshedule2.Click
        On Error Resume Next
        showtemplate("ng2022/template/cg/event_shedule2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub eventlogo_Click(sender As Object, e As EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:\casparcg\ng2022\data\event logo\", sender)
    End Sub

    Private Sub gamelogo_Click(sender As Object, e As EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:\casparcg\ng2022\data\games logo\", sender)
    End Sub

    Private Sub cmdupcg_Click(sender As Object, e As EventArgs) Handles cmdupcg.Click
        On Error Resume Next
        upsg(dgvwinner)
    End Sub

    Private Sub cmddowncg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddowncg.Click
        On Error Resume Next
        downsg(dgvwinner)
    End Sub

    Private Sub cmdinsercg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinsercg.Click
        On Error Resume Next
        insertsg(dgvwinner)
    End Sub

    Private Sub cmddeleteg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeleteg.Click
        On Error Resume Next
        deletesg(dgvwinner)
    End Sub

    Private Sub tsnewcg_Click(sender As Object, e As EventArgs) Handles tsnewcg.Click
        On Error Resume Next
        newdatasg(dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
    End Sub
    Private Sub dgvwinner_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvwinner.DataError
        'dummy code don't delete
    End Sub

    Private Sub tsopencg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsopencg.Click
        On Error Resume Next
        'opendatasg("C:\casparcg\ng2022\data\cg\", dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "C:\casparcg\ng2022\data\cg\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvwinner.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                cmbheadercg.Text = Split(li, ",")(0)
                cmbsubheadercg.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgvwinner.ColumnCount - 1
                    dgvwinner.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()
                    dgvwinner.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    For k = 0 To dgvwinner.ColumnCount - 1

                        If k = 0 Then
                            dgvwinner.Rows(g).Cells(k).Value = System.Drawing.Image.FromFile(xyz(k))

                        Else
                            dgvwinner.Rows(g).Cells(k).Value = xyz(k)
                        End If

                    Next
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilenamecg.Text = ofd2.FileName
        End If
    End Sub

    Private Sub tssavecg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssavecg.Click
        On Error Resume Next
        'savedatasg("C:\casparcg\ng2022\data\cg\", dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "C:\casparcg\ng2022\data\cg\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvwinner.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(cmbheadercg.Text & "," & cmbsubheadercg.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvwinner.ColumnCount - 1
                        header1 = header1 & dgvwinner.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvwinner.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvwinner.ColumnCount - 1
                            If k = 0 Then
                                str = str & dgvwinner.Rows(f).Cells(2).Value & ","
                            Else
                                str = str & dgvwinner.Rows(f).Cells(k).Value & ","
                            End If

                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilenamecg.Text = osd2.FileName
        End If
    End Sub
    Private Sub dgvwinner_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvwinner.CellDoubleClick
        On Error Resume Next
        If e.ColumnIndex = 0 Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\NG2022\data\flag\"
            If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
                With dgvwinner
                    .Rows(e.RowIndex).Cells(0).Value = System.Drawing.Image.FromFile(aa.FileName)
                    .Rows(e.RowIndex).Cells(1).Value = UCase(Split(aa.SafeFileName, ".")(0))
                    .Rows(e.RowIndex).Cells(2).Value = aa.FileName
                End With
                aa.Dispose()
            End If
        End If
    End Sub
    Private Sub dgvwinner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvwinner.CellContentClick

    End Sub

    Private Sub cmdHeatsToQuaterFinals_Click(sender As Object, e As EventArgs) Handles cmdHeatsToQuaterFinals.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgheader", cmbheadercg.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Heats To QuaterFinals- " & cmbsubheadercg.Text)
        For i = 0 To 7
            CasparCGDataCollection.SetData("ccgloader" & i + 1, dgvwinner.Rows(i).Cells(2).Value.Replace("\", "/"))
            CasparCGDataCollection.SetData("ccgf" & i, dgvwinner.Rows(i).Cells(1).Value)
        Next

        CasparCGDataCollection.SetData("ccgloader51", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader52", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("ng2022/template/cg/HeatsToQuaterFinals", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
End Class
