Public Class ucGymnastic
    Private Sub ucGymnastic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gymnasticsdefaultdata()

        cmbgames.DataSource = New BindingSource(gameName, "")
        cmbgames.Text = "Gymnastic"

        cmbHeader.DataSource = New BindingSource(headerText, "")
        cmbHeader.Text = "World Gymnastic Cup 2023"
        cmbSubHeader.DataSource = New BindingSource(subHeader, "")
        cmbSubHeader.Text = "Men's Artistic Vault - Final"

    End Sub

    Sub gymnasticsdefaultdata()
        On Error Resume Next


        dgvGymnastics.Rows.Add(12)

        dgvGymnastics.Rows(0).Cells(0).Value = 1
        dgvGymnastics.Rows(0).Cells(1).Value = "MOHAMAD ALGARNI"
        dgvGymnastics.Rows(0).Cells(2).Value = "A_N"
        dgvGymnastics.Rows(0).Cells(3).Value = 54.91

        dgvGymnastics.Rows(1).Cells(0).Value = 2
        dgvGymnastics.Rows(1).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvGymnastics.Rows(1).Cells(2).Value = "ARP"
        dgvGymnastics.Rows(1).Cells(3).Value = 32.41

        dgvGymnastics.Rows(2).Cells(0).Value = 3
        dgvGymnastics.Rows(2).Cells(1).Value = "EMAD HAMED NOUR"
        dgvGymnastics.Rows(2).Cells(2).Value = "BIH"
        dgvGymnastics.Rows(2).Cells(3).Value = 51.25

        dgvGymnastics.Rows(3).Cells(0).Value = 4
        dgvGymnastics.Rows(3).Cells(1).Value = "RASHEED RAMZI"
        dgvGymnastics.Rows(3).Cells(2).Value = "CHA"
        dgvGymnastics.Rows(3).Cells(3).Value = 12.25

        dgvGymnastics.Rows(4).Cells(0).Value = 5
        dgvGymnastics.Rows(4).Cells(1).Value = "HAMZA DRIOUCH"
        dgvGymnastics.Rows(4).Cells(2).Value = "DEL"
        dgvGymnastics.Rows(4).Cells(3).Value = 52.58

        dgvGymnastics.Rows(5).Cells(0).Value = 6
        dgvGymnastics.Rows(5).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvGymnastics.Rows(5).Cells(2).Value = "DNH"
        dgvGymnastics.Rows(5).Cells(3).Value = 54.25

        dgvGymnastics.Rows(6).Cells(0).Value = 7
        dgvGymnastics.Rows(6).Cells(1).Value = "ABDULLAH OBAID"
        dgvGymnastics.Rows(6).Cells(2).Value = "GOA"
        dgvGymnastics.Rows(6).Cells(3).Value = 56.25

        dgvGymnastics.Rows(7).Cells(0).Value = 8
        dgvGymnastics.Rows(7).Cells(1).Value = "AMASSRI WESAM"
        dgvGymnastics.Rows(7).Cells(2).Value = "GUJ"
        dgvGymnastics.Rows(7).Cells(3).Value = 52.14

        dgvGymnastics.Rows(8).Cells(0).Value = 9
        dgvGymnastics.Rows(8).Cells(1).Value = "SAJAD MORADI"
        dgvGymnastics.Rows(8).Cells(2).Value = "KER"
        dgvGymnastics.Rows(8).Cells(3).Value = 32.36

        dgvGymnastics.Rows(9).Cells(0).Value = 10
        dgvGymnastics.Rows(9).Cells(1).Value = "PRANJAL GOGOI"
        dgvGymnastics.Rows(9).Cells(2).Value = "MAH"
        dgvGymnastics.Rows(9).Cells(3).Value = 31.45

        dgvGymnastics.Rows(10).Cells(0).Value = 11
        dgvGymnastics.Rows(10).Cells(1).Value = "MOHAMMAD ALAZEMI"
        dgvGymnastics.Rows(10).Cells(2).Value = "MGA"
        dgvGymnastics.Rows(10).Cells(3).Value = 47.18

        dgvGymnastics.Rows(11).Cells(0).Value = 12
        dgvGymnastics.Rows(11).Cells(1).Value = "YUKI AKIMOTO"
        dgvGymnastics.Rows(11).Cells(2).Value = "ORI"
        dgvGymnastics.Rows(11).Cells(3).Value = 41.42

        For i = 0 To dgvGymnastics.RowCount - 2
            For j = 3 To dgvGymnastics.ColumnCount - 1
                dgvGymnastics.Rows(i).Cells(j).Value = Format(i * j, "00.00")
            Next
        Next

    End Sub

    Private Sub cmdgymnasticsstsrtlist1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgymnasticsstsrtlist1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                If chkwithnumbergym.Checked Then
                    CasparCGDataCollection.SetData("sn" & i + 1, dgvGymnastics.Rows(i).Cells(0).Value)
                End If
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
            End If
            CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        showtemplate("ng2022/template/Gymnastics/startlist1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdgymnasticsstsrtlist2_Click(sender As Object, e As EventArgs) Handles cmdgymnasticsstsrtlist2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 8 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                If chkwithnumbergym.Checked Then
                    CasparCGDataCollection.SetData("sn" & i - 7, dgvGymnastics.Rows(i).Cells(0).Value)
                End If
                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvGymnastics.Rows(i).Cells(1).Value)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        showtemplate("ng2022/template/Gymnastics/startlist1", CasparCGDataCollection.ToAMCPEscapedXml)
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
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
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

    Private Sub cmdteamlist_Click(sender As Object, e As EventArgs) Handles cmdteamlist.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("subheader", cmbSubHeader.Text)
        For i = 0 To 5
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Rows(i).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/teamlist", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridgym_Click(sender As Object, e As EventArgs) Handles cmdplayeridgym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/Gymnastics/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        showtemplate("ng2022/template/Gymnastics/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdcleardatagym_Click(sender As Object, e As EventArgs) Handles cmdcleardatagym.Click
        On Error Resume Next
        For i = 0 To dgvGymnastics.RowCount - 1
            For j = 3 To dgvGymnastics.ColumnCount - 1
                dgvGymnastics.Rows(i).Cells(j).Value = ""
            Next

        Next
    End Sub

    Private Sub cmdplayergamepointgym_Click(sender As Object, e As EventArgs) Handles cmdplayergamepointgym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.Columns(CType(cmbplayergamepointgym.Text, Integer)).HeaderText)
        CasparCGDataCollection.SetData("f4", dgvGymnastics.CurrentRow.Cells(CType(cmbplayergamepointgym.Text, Integer)).Value)
        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/player_any_score", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdchangecolumnnamegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchangecolumnnamegym.Click
        On Error Resume Next
        dgvGymnastics.Columns(CType(cmbchangecolumnnamegym.Text, Integer)).HeaderText = txtchangecolumnnamegym.Text
    End Sub

    Private Sub cmdresult1gym_Click(sender As Object, e As EventArgs) Handles cmdresult1gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(CType(cmbstandingsgym.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 1)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        showtemplate("ng2022/template/Gymnastics/result1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdresult2gym_Click(sender As Object, e As EventArgs) Handles cmdresult2gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 8 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i - 7, i + 1)
                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i - 7, dgvGymnastics.Rows(i).Cells(CType(cmbstandingsgym.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i - 7, 1)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        showtemplate("ng2022/template/Gymnastics/result1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdtop3standingsgym_Click(sender As Object, e As EventArgs) Handles cmdtop3standingsgym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                'CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(CType(cmbstandingsgym.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 1)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/Gymnastics/top_three", True, CasparCGDataCollection.ToAMCPEscapedXml)
        showtemplate("ng2022/template/Gymnastics/top_three", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdVaultStandings1_Click(sender As Object, e As EventArgs) Handles cmdVaultStandings1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)

                CasparCGDataCollection.SetData("vault1" & i + 1, dgvGymnastics.Rows(i).Cells(20).Value)
                CasparCGDataCollection.SetData("vault2" & i + 1, dgvGymnastics.Rows(i).Cells(21).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(22).Value)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/vault_standings", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdVaultStandings2_Click(sender As Object, e As EventArgs) Handles cmdVaultStandings2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 8 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i - 7, i + 1)
                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvGymnastics.Rows(i).Cells(1).Value)

                CasparCGDataCollection.SetData("vault1" & i - 7, dgvGymnastics.Rows(i).Cells(20).Value)
                CasparCGDataCollection.SetData("vault2" & i - 7, dgvGymnastics.Rows(i).Cells(21).Value)
                CasparCGDataCollection.SetData("value" & i - 7, dgvGymnastics.Rows(i).Cells(22).Value)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/vault_standings", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayerscorecardgym_Click(sender As Object, e As EventArgs) Handles cmdplayerscorecardgym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        If rdoArtisticsgym.Checked Then
            CasparCGDataCollection.SetData("f1", dgvGymnastics.Columns(23).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(23).Value & "   " & dgvGymnastics.Columns(25).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(25).Value & "   " & dgvGymnastics.Columns(26).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(26).Value)
            CasparCGDataCollection.SetData("f2", dgvGymnastics.Columns(27).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(27).Value)
            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Index + 1)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        Else
            For i = 23 To 27
                CasparCGDataCollection.SetData("f" & i - 22, dgvGymnastics.Columns(i).HeaderText)
                CasparCGDataCollection.SetData("f" & i - 17, dgvGymnastics.CurrentRow.Cells(i).Value)
            Next

            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f15", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        If rdoArtisticsgym.Checked Then
            showtemplate("ng2022/template/Gymnastics/PlayerScorecard", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            showtemplate("ng2022/template/Gymnastics/PlayerScorecard2", CasparCGDataCollection.ToAMCPEscapedXml)
        End If
    End Sub

    Private Sub cmdplayerscorecard2ndvaultgym_Click(sender As Object, e As EventArgs) Handles cmdplayerscorecard2ndvaultgym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        If rdoArtisticsgym.Checked Then
            CasparCGDataCollection.SetData("f1", dgvGymnastics.Columns(23).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(23).Value & "   " & dgvGymnastics.Columns(25).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(25).Value & "   " & dgvGymnastics.Columns(26).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(26).Value)
            CasparCGDataCollection.SetData("f2", dgvGymnastics.Columns(27).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(27).Value)
            CasparCGDataCollection.SetData("f4", dgvGymnastics.Columns(20).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(20).Value)
            If rdoaveragevaultgym.Checked Then
                CasparCGDataCollection.SetData("f5", "Total" & " " & (Val(dgvGymnastics.CurrentRow.Cells(27).Value) + Val(dgvGymnastics.CurrentRow.Cells(20).Value)) / 2)
            Else
                CasparCGDataCollection.SetData("f5", "Total" & " " & (Val(dgvGymnastics.CurrentRow.Cells(27).Value) + Val(dgvGymnastics.CurrentRow.Cells(20).Value)))

            End If


            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Index + 1)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        Else
            For i = 23 To 27
                CasparCGDataCollection.SetData("f" & i - 22, dgvGymnastics.Columns(i).HeaderText)
                CasparCGDataCollection.SetData("f" & i - 17, dgvGymnastics.CurrentRow.Cells(i).Value)
            Next

            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f15", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        If rdoArtisticsgym.Checked Then
            showtemplate("ng2022/template/Gymnastics/PlayerScorecard2ndvault", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            'CasparDevice.Channels(g_int_ChannelNumber-1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "ng2022/template/Gymnastics/PlayerScorecard2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End If
    End Sub

    Private Sub cmdteamlistwithgamenamegym_Click(sender As Object, e As EventArgs) Handles cmdteamlistwithgamenamegym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                'CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(28).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 0)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        showtemplate("ng2022/template/Gymnastics/Officials", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdofficialsgym_Click(sender As Object, e As EventArgs) Handles cmdofficialsgym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                'CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(29).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 0)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        showtemplate("ng2022/template/Gymnastics/Officials", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub Build1gym_Click(sender As Object, e As EventArgs) Handles Build1gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        For i = 1 To 7
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Columns(i + 2).HeaderText)
            CasparCGDataCollection.SetData("f" & i + 7, dgvGymnastics.CurrentRow.Cells(i + 2).Value)
        Next

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f15", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/build1", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayerscore1gym_Click(sender As Object, e As EventArgs) Handles cmdplayerscore1gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.CurrentRow.Cells(9).Value)
        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/player_score", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub Build2gym_Click(sender As Object, e As EventArgs) Handles Build2gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        For i = 1 To 5
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Columns(i + 9).HeaderText)
            CasparCGDataCollection.SetData("f" & i + 5, dgvGymnastics.CurrentRow.Cells(i + 9).Value)
        Next
        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f15", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/build2", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayerscore2gym_Click(sender As Object, e As EventArgs) Handles cmdplayerscore2gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.CurrentRow.Cells(14).Value)
        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/player_score", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub Build3gym_Click(sender As Object, e As EventArgs) Handles Build3gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        For i = 1 To 5
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Columns(i + 14).HeaderText)
            CasparCGDataCollection.SetData("f" & i + 5, dgvGymnastics.CurrentRow.Cells(i + 14).Value)
        Next
        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f15", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/build3", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayerscore3gym_Click(sender As Object, e As EventArgs) Handles cmdplayerscore3gym.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.CurrentRow.Cells(19).Value)

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("ng2022/template/Gymnastics/player_score", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub newgym_Click(sender As Object, e As EventArgs) Handles newgym.Click
        On Error Resume Next
        newdatasg(dgvGymnastics, cmbHeader, cmbSubHeader, lblfilenamegym)
    End Sub

    Private Sub opengym_Click(sender As Object, e As EventArgs) Handles opengym.Click
        On Error Resume Next
        opendatasg("C:\casparcg\ng2022\data\gymnastics\", dgvGymnastics, cmbHeader, cmbSubHeader, lblfilenamegym)
    End Sub

    Private Sub savegym_Click(sender As Object, e As EventArgs) Handles savegym.Click
        On Error Resume Next
        savedatasg("C:\casparcg\ng2022\data\gymnastics\", dgvGymnastics, cmbHeader, cmbSubHeader, lblfilenamegym)
    End Sub

    Private Sub cmdrowupzym_Click(sender As Object, e As EventArgs) Handles cmdrowupzym.Click
        On Error Resume Next
        upsg(dgvGymnastics)
    End Sub

    Private Sub cmdrowdowngym_Click(sender As Object, e As EventArgs) Handles cmdrowdowngym.Click
        downsg(dgvGymnastics)

    End Sub

    Private Sub cmdrowinsertgym_Click(sender As Object, e As EventArgs) Handles cmdrowinsertgym.Click
        insertsg(dgvGymnastics)
    End Sub

    Private Sub cmdrowdeletegym_Click(sender As Object, e As EventArgs) Handles cmdrowdeletegym.Click
        deletesg(dgvGymnastics)

    End Sub

    Private Sub dgvGymnastics_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGymnastics.CellValueChanged
        On Error Resume Next
        dgvGymnastics.Rows(e.RowIndex).Cells(9).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(3).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(4).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(5).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(6).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(7).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(8).Value), "00.00")

        dgvGymnastics.Rows(e.RowIndex).Cells(14).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(10).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(11).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(12).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(13).Value), "00.00")
        If rdoaveragevaultgym.Checked Then
            dgvGymnastics.Rows(e.RowIndex).Cells(22).Value = Format((Val(dgvGymnastics.Rows(e.RowIndex).Cells(20).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(21).Value)) / 2, "00.00")

        Else
            dgvGymnastics.Rows(e.RowIndex).Cells(22).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(20).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(21).Value), "00.00")

        End If

        If rdoArtisticsgym.Checked Then
            dgvGymnastics.Rows(e.RowIndex).Cells(27).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(23).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(25).Value) - Val(dgvGymnastics.Rows(e.RowIndex).Cells(26).Value), "00.00")

        Else
            dgvGymnastics.Rows(e.RowIndex).Cells(27).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(23).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(24).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(25).Value) - Val(dgvGymnastics.Rows(e.RowIndex).Cells(26).Value), "00.00")

        End If


    End Sub
    Private Sub dgvGymnastics_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvGymnastics.DataError
        'dummy dont delete
    End Sub
    Private Sub dgvGymnastics_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvGymnastics.DefaultValuesNeeded

        e.Row.Cells(2).Value = "BLK"
    End Sub

    Private Sub rdoArtisticsgym_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoArtisticsgym.CheckedChanged, rdoRhythmicgym.CheckedChanged
        On Error Resume Next
        For i = 0 To dgvGymnastics.RowCount - 1
            If rdoArtisticsgym.Checked Then
                dgvGymnastics.Rows(i).Cells(27).Value = Format(Val(dgvGymnastics.Rows(i).Cells(23).Value) + Val(dgvGymnastics.Rows(i).Cells(25).Value) - Val(dgvGymnastics.Rows(i).Cells(26).Value), "00.000")

            Else
                dgvGymnastics.Rows(i).Cells(27).Value = Format(Val(dgvGymnastics.Rows(i).Cells(23).Value) + Val(dgvGymnastics.Rows(i).Cells(24).Value) + Val(dgvGymnastics.Rows(i).Cells(25).Value) - Val(dgvGymnastics.Rows(i).Cells(26).Value), "00.000")

            End If
        Next
    End Sub
End Class
