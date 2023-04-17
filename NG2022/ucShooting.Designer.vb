<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucShooting
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucShooting))
        Me.cmdcleardatagym = New System.Windows.Forms.Button()
        Me.lblfilenametrack = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdstopgym = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmblayergames = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSubHeader = New System.Windows.Forms.ComboBox()
        Me.cmbHeader = New System.Windows.Forms.ComboBox()
        Me.cmdeventid = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eventlogo = New System.Windows.Forms.PictureBox()
        Me.gamelogo = New System.Windows.Forms.PictureBox()
        Me.cmbgames = New System.Windows.Forms.ComboBox()
        Me.dgvtrack = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.imglocation1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column41 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Heats = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Misses = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDummy = New System.Windows.Forms.Button()
        Me.cmdSeries1 = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Button()
        Me.cmbSeries = New System.Windows.Forms.ComboBox()
        Me.gbtstrack = New System.Windows.Forms.GroupBox()
        Me.uprowtrack = New System.Windows.Forms.Button()
        Me.deleterowtrack = New System.Windows.Forms.Button()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.newtrack = New System.Windows.Forms.ToolStripButton()
        Me.opentrack = New System.Windows.Forms.ToolStripButton()
        Me.savetrack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.downrowtrack = New System.Windows.Forms.Button()
        Me.addrowtrack = New System.Windows.Forms.Button()
        Me.cmdstartlisttrack = New System.Windows.Forms.Button()
        Me.cmdStanding = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.eventlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtrack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbtstrack.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdcleardatagym
        '
        Me.cmdcleardatagym.Location = New System.Drawing.Point(20, 133)
        Me.cmdcleardatagym.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdcleardatagym.Name = "cmdcleardatagym"
        Me.cmdcleardatagym.Size = New System.Drawing.Size(72, 23)
        Me.cmdcleardatagym.TabIndex = 1276
        Me.cmdcleardatagym.Text = "Clear Data"
        Me.cmdcleardatagym.UseVisualStyleBackColor = True
        '
        'lblfilenametrack
        '
        Me.lblfilenametrack.AutoSize = True
        Me.lblfilenametrack.Location = New System.Drawing.Point(18, 107)
        Me.lblfilenametrack.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lblfilenametrack.Name = "lblfilenametrack"
        Me.lblfilenametrack.Size = New System.Drawing.Size(57, 13)
        Me.lblfilenametrack.TabIndex = 1270
        Me.lblfilenametrack.Text = "Default file"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 1269
        Me.Label3.Text = "File Name"
        '
        'cmdstopgym
        '
        Me.cmdstopgym.BackColor = System.Drawing.Color.Red
        Me.cmdstopgym.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdstopgym.Location = New System.Drawing.Point(390, 14)
        Me.cmdstopgym.Name = "cmdstopgym"
        Me.cmdstopgym.Size = New System.Drawing.Size(325, 62)
        Me.cmdstopgym.TabIndex = 1324
        Me.cmdstopgym.Text = "Stop"
        Me.cmdstopgym.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(715, 42)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 1328
        Me.Label30.Text = "v-f layer"
        '
        'cmblayergames
        '
        Me.cmblayergames.FormattingEnabled = True
        Me.cmblayergames.Items.AddRange(New Object() {"96", "97", "98", "99", "100"})
        Me.cmblayergames.Location = New System.Drawing.Point(765, 41)
        Me.cmblayergames.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayergames.Name = "cmblayergames"
        Me.cmblayergames.Size = New System.Drawing.Size(40, 21)
        Me.cmblayergames.TabIndex = 1327
        Me.cmblayergames.Text = "96"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox3.Controls.Add(Me.cmbSubHeader)
        Me.GroupBox3.Controls.Add(Me.cmbHeader)
        Me.GroupBox3.Controls.Add(Me.cmdeventid)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 62)
        Me.GroupBox3.TabIndex = 1329
        Me.GroupBox3.TabStop = False
        '
        'cmbSubHeader
        '
        Me.cmbSubHeader.FormattingEnabled = True
        Me.cmbSubHeader.Items.AddRange(New Object() {"Men’s 50m Rifle 3 Positions", "Men’s 50m Rifle Prone", "Men’s 10m Air Rifle", "Men’s 50m Pistol", "Men’s 25m Rapid Fire Pistol", "Men’s 10m Air Pistol", "Men’s Trap", "Men’s Double Trap", "Men’s Skeet", "Women’s 50m Rifle 3 Positions", "Women’s 10m Air Rifle", "Women’s 25m Pistol", "Women’s 10m Air Pistol", "Women’s Trap", "Women’s Skeet "})
        Me.cmbSubHeader.Location = New System.Drawing.Point(78, 35)
        Me.cmbSubHeader.Name = "cmbSubHeader"
        Me.cmbSubHeader.Size = New System.Drawing.Size(221, 21)
        Me.cmbSubHeader.TabIndex = 1201
        Me.cmbSubHeader.Text = "Bronze Medal Match"
        '
        'cmbHeader
        '
        Me.cmbHeader.FormattingEnabled = True
        Me.cmbHeader.Location = New System.Drawing.Point(78, 11)
        Me.cmbHeader.Name = "cmbHeader"
        Me.cmbHeader.Size = New System.Drawing.Size(221, 21)
        Me.cmbHeader.TabIndex = 1200
        Me.cmbHeader.Text = "Men's BasketBall"
        '
        'cmdeventid
        '
        Me.cmdeventid.BackColor = System.Drawing.Color.Green
        Me.cmdeventid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdeventid.ForeColor = System.Drawing.Color.White
        Me.cmdeventid.Location = New System.Drawing.Point(305, 12)
        Me.cmdeventid.Name = "cmdeventid"
        Me.cmdeventid.Size = New System.Drawing.Size(62, 45)
        Me.cmdeventid.TabIndex = 1199
        Me.cmdeventid.Text = "Event Id"
        Me.cmdeventid.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 1174
        Me.Label17.Text = "Sub Header"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1173
        Me.Label1.Text = "MAin Header"
        '
        'eventlogo
        '
        Me.eventlogo.BackColor = System.Drawing.SystemColors.Highlight
        Me.eventlogo.ImageLocation = "C:/casparcg/ng2022/data/event logo/ng2015.png"
        Me.eventlogo.Location = New System.Drawing.Point(861, 45)
        Me.eventlogo.Name = "eventlogo"
        Me.eventlogo.Size = New System.Drawing.Size(24, 17)
        Me.eventlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eventlogo.TabIndex = 1326
        Me.eventlogo.TabStop = False
        '
        'gamelogo
        '
        Me.gamelogo.BackColor = System.Drawing.SystemColors.Highlight
        Me.gamelogo.ImageLocation = "C:/casparcg/ng2022/data/games logo/Gymnastics - Artistic.png"
        Me.gamelogo.Location = New System.Drawing.Point(829, 43)
        Me.gamelogo.Name = "gamelogo"
        Me.gamelogo.Size = New System.Drawing.Size(22, 19)
        Me.gamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gamelogo.TabIndex = 1325
        Me.gamelogo.TabStop = False
        '
        'cmbgames
        '
        Me.cmbgames.FormattingEnabled = True
        Me.cmbgames.Location = New System.Drawing.Point(743, 14)
        Me.cmbgames.Name = "cmbgames"
        Me.cmbgames.Size = New System.Drawing.Size(172, 21)
        Me.cmbgames.TabIndex = 1330
        Me.cmbgames.Text = "Gymnastics - Artistic"
        '
        'dgvtrack
        '
        Me.dgvtrack.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.dgvtrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtrack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn48, Me.Column2, Me.DataGridViewComboBoxColumn2, Me.imglocation1, Me.DataGridViewTextBoxColumn49, Me.Column41, Me.Column1, Me.Heats, Me.Misses, Me.Column5, Me.Column3, Me.Column6, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvtrack.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvtrack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvtrack.Location = New System.Drawing.Point(24, 214)
        Me.dgvtrack.Name = "dgvtrack"
        Me.dgvtrack.RowTemplate.Height = 30
        Me.dgvtrack.Size = New System.Drawing.Size(670, 364)
        Me.dgvtrack.TabIndex = 1332
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.Frozen = True
        Me.DataGridViewTextBoxColumn48.HeaderText = "Track no."
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn48.Width = 40
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Code"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column2.Width = 40
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.Frozen = True
        Me.DataGridViewComboBoxColumn2.HeaderText = "Country"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewComboBoxColumn2.Width = 70
        '
        'imglocation1
        '
        Me.imglocation1.Frozen = True
        Me.imglocation1.HeaderText = "imglocation1"
        Me.imglocation1.MinimumWidth = 2
        Me.imglocation1.Name = "imglocation1"
        Me.imglocation1.Width = 2
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.Frozen = True
        Me.DataGridViewTextBoxColumn49.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn49.Width = 150
        '
        'Column41
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = False
        Me.Column41.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column41.Frozen = True
        Me.Column41.HeaderText = "s1"
        Me.Column41.Name = "Column41"
        Me.Column41.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column41.Width = 40
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = False
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "s2"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column1.Width = 40
        '
        'Heats
        '
        Me.Heats.Frozen = True
        Me.Heats.HeaderText = "s3"
        Me.Heats.Name = "Heats"
        Me.Heats.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Heats.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Heats.Width = 40
        '
        'Misses
        '
        Me.Misses.Frozen = True
        Me.Misses.HeaderText = "s4"
        Me.Misses.Name = "Misses"
        Me.Misses.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Misses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Misses.Width = 40
        '
        'Column5
        '
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "s5"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 40
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "score"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 40
        '
        'Column6
        '
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Pre"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 40
        '
        'Column4
        '
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 40
        '
        'btnDummy
        '
        Me.btnDummy.Location = New System.Drawing.Point(921, 14)
        Me.btnDummy.Name = "btnDummy"
        Me.btnDummy.Size = New System.Drawing.Size(25, 21)
        Me.btnDummy.TabIndex = 1334
        Me.btnDummy.Text = "btnDummy"
        Me.btnDummy.UseVisualStyleBackColor = True
        '
        'cmdSeries1
        '
        Me.cmdSeries1.Location = New System.Drawing.Point(448, 180)
        Me.cmdSeries1.Name = "cmdSeries1"
        Me.cmdSeries1.Size = New System.Drawing.Size(75, 23)
        Me.cmdSeries1.TabIndex = 1335
        Me.cmdSeries1.Text = "Player ID"
        Me.cmdSeries1.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.Score.Location = New System.Drawing.Point(559, 180)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(75, 23)
        Me.Score.TabIndex = 1336
        Me.Score.Text = "Score"
        Me.Score.UseVisualStyleBackColor = True
        '
        'cmbSeries
        '
        Me.cmbSeries.FormattingEnabled = True
        Me.cmbSeries.Items.AddRange(New Object() {"Series 1", "Series 2", "Series 3", "Series 4", "Series 5", "Series 6", "Series 7", "Series 8", "Series 9", "Series 10"})
        Me.cmbSeries.Location = New System.Drawing.Point(346, 180)
        Me.cmbSeries.Name = "cmbSeries"
        Me.cmbSeries.Size = New System.Drawing.Size(96, 21)
        Me.cmbSeries.TabIndex = 1337
        Me.cmbSeries.Text = "Series 3"
        '
        'gbtstrack
        '
        Me.gbtstrack.Controls.Add(Me.uprowtrack)
        Me.gbtstrack.Controls.Add(Me.deleterowtrack)
        Me.gbtstrack.Controls.Add(Me.ToolStrip4)
        Me.gbtstrack.Controls.Add(Me.downrowtrack)
        Me.gbtstrack.Controls.Add(Me.addrowtrack)
        Me.gbtstrack.Location = New System.Drawing.Point(24, 170)
        Me.gbtstrack.Name = "gbtstrack"
        Me.gbtstrack.Size = New System.Drawing.Size(189, 33)
        Me.gbtstrack.TabIndex = 1339
        Me.gbtstrack.TabStop = False
        '
        'uprowtrack
        '
        Me.uprowtrack.Image = CType(resources.GetObject("uprowtrack.Image"), System.Drawing.Image)
        Me.uprowtrack.Location = New System.Drawing.Point(88, 8)
        Me.uprowtrack.Name = "uprowtrack"
        Me.uprowtrack.Size = New System.Drawing.Size(22, 18)
        Me.uprowtrack.TabIndex = 1201
        Me.uprowtrack.UseVisualStyleBackColor = True
        '
        'deleterowtrack
        '
        Me.deleterowtrack.BackgroundImage = CType(resources.GetObject("deleterowtrack.BackgroundImage"), System.Drawing.Image)
        Me.deleterowtrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleterowtrack.Location = New System.Drawing.Point(160, 8)
        Me.deleterowtrack.Name = "deleterowtrack"
        Me.deleterowtrack.Size = New System.Drawing.Size(22, 18)
        Me.deleterowtrack.TabIndex = 1200
        Me.deleterowtrack.UseVisualStyleBackColor = True
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtrack, Me.opentrack, Me.savetrack, Me.ToolStripSeparator8, Me.ToolStripSeparator9})
        Me.ToolStrip4.Location = New System.Drawing.Point(5, 6)
        Me.ToolStrip4.MaximumSize = New System.Drawing.Size(200, 200)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(93, 25)
        Me.ToolStrip4.TabIndex = 1199
        Me.ToolStrip4.Text = "ToolStrip3"
        '
        'newtrack
        '
        Me.newtrack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtrack.Image = CType(resources.GetObject("newtrack.Image"), System.Drawing.Image)
        Me.newtrack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtrack.Name = "newtrack"
        Me.newtrack.Size = New System.Drawing.Size(23, 22)
        Me.newtrack.Text = "&New"
        '
        'opentrack
        '
        Me.opentrack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.opentrack.Image = CType(resources.GetObject("opentrack.Image"), System.Drawing.Image)
        Me.opentrack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.opentrack.Name = "opentrack"
        Me.opentrack.Size = New System.Drawing.Size(23, 22)
        Me.opentrack.Text = "&Open"
        '
        'savetrack
        '
        Me.savetrack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savetrack.Image = CType(resources.GetObject("savetrack.Image"), System.Drawing.Image)
        Me.savetrack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.savetrack.Name = "savetrack"
        Me.savetrack.Size = New System.Drawing.Size(23, 22)
        Me.savetrack.Text = "&Save"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'downrowtrack
        '
        Me.downrowtrack.Image = CType(resources.GetObject("downrowtrack.Image"), System.Drawing.Image)
        Me.downrowtrack.Location = New System.Drawing.Point(110, 8)
        Me.downrowtrack.Name = "downrowtrack"
        Me.downrowtrack.Size = New System.Drawing.Size(22, 18)
        Me.downrowtrack.TabIndex = 1198
        Me.downrowtrack.UseVisualStyleBackColor = True
        '
        'addrowtrack
        '
        Me.addrowtrack.Image = CType(resources.GetObject("addrowtrack.Image"), System.Drawing.Image)
        Me.addrowtrack.Location = New System.Drawing.Point(133, 8)
        Me.addrowtrack.Name = "addrowtrack"
        Me.addrowtrack.Size = New System.Drawing.Size(22, 18)
        Me.addrowtrack.TabIndex = 1197
        Me.addrowtrack.UseVisualStyleBackColor = True
        '
        'cmdstartlisttrack
        '
        Me.cmdstartlisttrack.Location = New System.Drawing.Point(640, 180)
        Me.cmdstartlisttrack.Name = "cmdstartlisttrack"
        Me.cmdstartlisttrack.Size = New System.Drawing.Size(75, 23)
        Me.cmdstartlisttrack.TabIndex = 1340
        Me.cmdstartlisttrack.Text = "Satrt List"
        Me.cmdstartlisttrack.UseVisualStyleBackColor = True
        '
        'cmdStanding
        '
        Me.cmdStanding.Location = New System.Drawing.Point(223, 178)
        Me.cmdStanding.Name = "cmdStanding"
        Me.cmdStanding.Size = New System.Drawing.Size(117, 23)
        Me.cmdStanding.TabIndex = 1341
        Me.cmdStanding.Text = "Satanding After"
        Me.cmdStanding.UseVisualStyleBackColor = True
        '
        'ucShooting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.cmdStanding)
        Me.Controls.Add(Me.cmdstartlisttrack)
        Me.Controls.Add(Me.gbtstrack)
        Me.Controls.Add(Me.cmbSeries)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.cmdSeries1)
        Me.Controls.Add(Me.btnDummy)
        Me.Controls.Add(Me.dgvtrack)
        Me.Controls.Add(Me.cmbgames)
        Me.Controls.Add(Me.cmdstopgym)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmblayergames)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.eventlogo)
        Me.Controls.Add(Me.gamelogo)
        Me.Controls.Add(Me.cmdcleardatagym)
        Me.Controls.Add(Me.lblfilenametrack)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ucShooting"
        Me.Size = New System.Drawing.Size(1543, 905)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.eventlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtrack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbtstrack.ResumeLayout(False)
        Me.gbtstrack.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdcleardatagym As Button
    Friend WithEvents lblfilenametrack As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdstopgym As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents cmblayergames As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbSubHeader As ComboBox
    Friend WithEvents cmbHeader As ComboBox
    Friend WithEvents cmdeventid As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents eventlogo As PictureBox
    Friend WithEvents gamelogo As PictureBox
    Friend WithEvents cmbgames As ComboBox
    Friend WithEvents dgvtrack As DataGridView
    Friend WithEvents btnDummy As Button
    Friend WithEvents cmdSeries1 As Button
    Friend WithEvents Score As Button
    Friend WithEvents cmbSeries As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewImageColumn
    Friend WithEvents imglocation1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents Column41 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Heats As DataGridViewCheckBoxColumn
    Friend WithEvents Misses As DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents gbtstrack As GroupBox
    Friend WithEvents uprowtrack As Button
    Friend WithEvents deleterowtrack As Button
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents newtrack As ToolStripButton
    Friend WithEvents opentrack As ToolStripButton
    Friend WithEvents savetrack As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents downrowtrack As Button
    Friend WithEvents addrowtrack As Button
    Friend WithEvents cmdstartlisttrack As Button
    Friend WithEvents cmdStanding As Button
End Class
