<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCG2
    Inherits System.Windows.Forms.UserControl
    'Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCG2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbcg2 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmblayergames = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdNextStepCG2 = New System.Windows.Forms.Button()
        Me.txtTemplateDirectoryCg2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eventlogoforcg2 = New System.Windows.Forms.PictureBox()
        Me.Label262 = New System.Windows.Forms.Label()
        Me.lblfilenamecg2 = New System.Windows.Forms.Label()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.cmduprowcg2 = New System.Windows.Forms.Button()
        Me.cmdremoverowcg2 = New System.Windows.Forms.Button()
        Me.cmddownrowcg2 = New System.Windows.Forms.Button()
        Me.cmdaddrowcg2 = New System.Windows.Forms.Button()
        Me.cmdsaveasnewfilecg2 = New System.Windows.Forms.Button()
        Me.Label208 = New System.Windows.Forms.Label()
        Me.Label209 = New System.Windows.Forms.Label()
        Me.gamelogoforcg2 = New System.Windows.Forms.PictureBox()
        Me.cmdstopcg2 = New System.Windows.Forms.Button()
        Me.cmd3linercentercg2 = New System.Windows.Forms.Button()
        Me.cmd10linercg2 = New System.Windows.Forms.Button()
        Me.cmd9linercg2 = New System.Windows.Forms.Button()
        Me.cmd8linercg2 = New System.Windows.Forms.Button()
        Me.cmd7linercg2 = New System.Windows.Forms.Button()
        Me.cmd6linercg2 = New System.Windows.Forms.Button()
        Me.cmd5linercg2 = New System.Windows.Forms.Button()
        Me.cmd4linercg2 = New System.Windows.Forms.Button()
        Me.cmdthreelinercg2 = New System.Windows.Forms.Button()
        Me.cmdtwolinercg2 = New System.Windows.Forms.Button()
        Me.cmdonelinercg2 = New System.Windows.Forms.Button()
        Me.cmdrefreshdatacg2 = New System.Windows.Forms.Button()
        Me.dgvinfocg2 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Line_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.osd2 = New System.Windows.Forms.SaveFileDialog()
        Me.gbcg2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.eventlogoforcg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox23.SuspendLayout()
        CType(Me.gamelogoforcg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinfocg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbcg2
        '
        Me.gbcg2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbcg2.Controls.Add(Me.Label30)
        Me.gbcg2.Controls.Add(Me.cmblayergames)
        Me.gbcg2.Controls.Add(Me.MenuStrip1)
        Me.gbcg2.Controls.Add(Me.cmdNextStepCG2)
        Me.gbcg2.Controls.Add(Me.txtTemplateDirectoryCg2)
        Me.gbcg2.Controls.Add(Me.Label1)
        Me.gbcg2.Controls.Add(Me.eventlogoforcg2)
        Me.gbcg2.Controls.Add(Me.Label262)
        Me.gbcg2.Controls.Add(Me.lblfilenamecg2)
        Me.gbcg2.Controls.Add(Me.GroupBox23)
        Me.gbcg2.Controls.Add(Me.cmdsaveasnewfilecg2)
        Me.gbcg2.Controls.Add(Me.Label208)
        Me.gbcg2.Controls.Add(Me.Label209)
        Me.gbcg2.Controls.Add(Me.gamelogoforcg2)
        Me.gbcg2.Controls.Add(Me.cmdstopcg2)
        Me.gbcg2.Controls.Add(Me.cmd3linercentercg2)
        Me.gbcg2.Controls.Add(Me.cmd10linercg2)
        Me.gbcg2.Controls.Add(Me.cmd9linercg2)
        Me.gbcg2.Controls.Add(Me.cmd8linercg2)
        Me.gbcg2.Controls.Add(Me.cmd7linercg2)
        Me.gbcg2.Controls.Add(Me.cmd6linercg2)
        Me.gbcg2.Controls.Add(Me.cmd5linercg2)
        Me.gbcg2.Controls.Add(Me.cmd4linercg2)
        Me.gbcg2.Controls.Add(Me.cmdthreelinercg2)
        Me.gbcg2.Controls.Add(Me.cmdtwolinercg2)
        Me.gbcg2.Controls.Add(Me.cmdonelinercg2)
        Me.gbcg2.Controls.Add(Me.cmdrefreshdatacg2)
        Me.gbcg2.Controls.Add(Me.dgvinfocg2)
        Me.gbcg2.Location = New System.Drawing.Point(3, 3)
        Me.gbcg2.Name = "gbcg2"
        Me.gbcg2.Size = New System.Drawing.Size(783, 710)
        Me.gbcg2.TabIndex = 679
        Me.gbcg2.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(23, 28)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 1214
        Me.Label30.Text = "v-f layer"
        '
        'cmblayergames
        '
        Me.cmblayergames.FormattingEnabled = True
        Me.cmblayergames.Items.AddRange(New Object() {"96", "97", "98", "99", "100"})
        Me.cmblayergames.Location = New System.Drawing.Point(66, 27)
        Me.cmblayergames.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayergames.Name = "cmblayergames"
        Me.cmblayergames.Size = New System.Drawing.Size(40, 21)
        Me.cmblayergames.TabIndex = 1213
        Me.cmblayergames.Text = "96"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(14, 124)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 1212
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'cmdNextStepCG2
        '
        Me.cmdNextStepCG2.BackColor = System.Drawing.Color.Yellow
        Me.cmdNextStepCG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextStepCG2.Location = New System.Drawing.Point(663, 151)
        Me.cmdNextStepCG2.Name = "cmdNextStepCG2"
        Me.cmdNextStepCG2.Size = New System.Drawing.Size(46, 550)
        Me.cmdNextStepCG2.TabIndex = 1208
        Me.cmdNextStepCG2.Text = "Next Step"
        Me.ToolTip1.SetToolTip(Me.cmdNextStepCG2, "Resumes Animation on Timeline")
        Me.cmdNextStepCG2.UseVisualStyleBackColor = False
        '
        'txtTemplateDirectoryCg2
        '
        Me.txtTemplateDirectoryCg2.Location = New System.Drawing.Point(13, 100)
        Me.txtTemplateDirectoryCg2.Name = "txtTemplateDirectoryCg2"
        Me.txtTemplateDirectoryCg2.Size = New System.Drawing.Size(284, 20)
        Me.txtTemplateDirectoryCg2.TabIndex = 1207
        Me.txtTemplateDirectoryCg2.Text = "ng2022/template/cg2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1206
        Me.Label1.Text = "Template Directory"
        '
        'eventlogoforcg2
        '
        Me.eventlogoforcg2.BackColor = System.Drawing.SystemColors.Highlight
        Me.eventlogoforcg2.ImageLocation = "C:/casparcg/ng2022/data/event logo/iba2.png"
        Me.eventlogoforcg2.Location = New System.Drawing.Point(207, 27)
        Me.eventlogoforcg2.Name = "eventlogoforcg2"
        Me.eventlogoforcg2.Size = New System.Drawing.Size(52, 38)
        Me.eventlogoforcg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eventlogoforcg2.TabIndex = 1164
        Me.eventlogoforcg2.TabStop = False
        '
        'Label262
        '
        Me.Label262.AutoSize = True
        Me.Label262.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label262.Location = New System.Drawing.Point(6, 71)
        Me.Label262.Name = "Label262"
        Me.Label262.Size = New System.Drawing.Size(63, 13)
        Me.Label262.TabIndex = 1205
        Me.Label262.Text = "File Name"
        '
        'lblfilenamecg2
        '
        Me.lblfilenamecg2.AutoSize = True
        Me.lblfilenamecg2.Location = New System.Drawing.Point(68, 71)
        Me.lblfilenamecg2.Name = "lblfilenamecg2"
        Me.lblfilenamecg2.Size = New System.Drawing.Size(196, 13)
        Me.lblfilenamecg2.TabIndex = 1204
        Me.lblfilenamecg2.Text = "C:\casparcg\NG2022\data\cg2\info.txt"
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.cmduprowcg2)
        Me.GroupBox23.Controls.Add(Me.cmdremoverowcg2)
        Me.GroupBox23.Controls.Add(Me.cmddownrowcg2)
        Me.GroupBox23.Controls.Add(Me.cmdaddrowcg2)
        Me.GroupBox23.Location = New System.Drawing.Point(88, 151)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(113, 31)
        Me.GroupBox23.TabIndex = 1203
        Me.GroupBox23.TabStop = False
        '
        'cmduprowcg2
        '
        Me.cmduprowcg2.Image = CType(resources.GetObject("cmduprowcg2.Image"), System.Drawing.Image)
        Me.cmduprowcg2.Location = New System.Drawing.Point(7, 7)
        Me.cmduprowcg2.Name = "cmduprowcg2"
        Me.cmduprowcg2.Size = New System.Drawing.Size(22, 18)
        Me.cmduprowcg2.TabIndex = 1201
        Me.cmduprowcg2.UseVisualStyleBackColor = True
        '
        'cmdremoverowcg2
        '
        Me.cmdremoverowcg2.BackgroundImage = CType(resources.GetObject("cmdremoverowcg2.BackgroundImage"), System.Drawing.Image)
        Me.cmdremoverowcg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdremoverowcg2.Location = New System.Drawing.Point(79, 7)
        Me.cmdremoverowcg2.Name = "cmdremoverowcg2"
        Me.cmdremoverowcg2.Size = New System.Drawing.Size(22, 18)
        Me.cmdremoverowcg2.TabIndex = 1200
        Me.cmdremoverowcg2.UseVisualStyleBackColor = True
        '
        'cmddownrowcg2
        '
        Me.cmddownrowcg2.Image = CType(resources.GetObject("cmddownrowcg2.Image"), System.Drawing.Image)
        Me.cmddownrowcg2.Location = New System.Drawing.Point(29, 7)
        Me.cmddownrowcg2.Name = "cmddownrowcg2"
        Me.cmddownrowcg2.Size = New System.Drawing.Size(22, 18)
        Me.cmddownrowcg2.TabIndex = 1198
        Me.cmddownrowcg2.UseVisualStyleBackColor = True
        '
        'cmdaddrowcg2
        '
        Me.cmdaddrowcg2.Image = CType(resources.GetObject("cmdaddrowcg2.Image"), System.Drawing.Image)
        Me.cmdaddrowcg2.Location = New System.Drawing.Point(52, 7)
        Me.cmdaddrowcg2.Name = "cmdaddrowcg2"
        Me.cmdaddrowcg2.Size = New System.Drawing.Size(22, 18)
        Me.cmdaddrowcg2.TabIndex = 1197
        Me.cmdaddrowcg2.UseVisualStyleBackColor = True
        '
        'cmdsaveasnewfilecg2
        '
        Me.cmdsaveasnewfilecg2.Location = New System.Drawing.Point(207, 139)
        Me.cmdsaveasnewfilecg2.Name = "cmdsaveasnewfilecg2"
        Me.cmdsaveasnewfilecg2.Size = New System.Drawing.Size(64, 49)
        Me.cmdsaveasnewfilecg2.TabIndex = 1199
        Me.cmdsaveasnewfilecg2.Text = "Save as new Text File"
        Me.cmdsaveasnewfilecg2.UseVisualStyleBackColor = True
        '
        'Label208
        '
        Me.Label208.AutoSize = True
        Me.Label208.Location = New System.Drawing.Point(206, 11)
        Me.Label208.Name = "Label208"
        Me.Label208.Size = New System.Drawing.Size(58, 13)
        Me.Label208.TabIndex = 1165
        Me.Label208.Text = "Event logo"
        '
        'Label209
        '
        Me.Label209.AutoSize = True
        Me.Label209.Location = New System.Drawing.Point(142, 11)
        Me.Label209.Name = "Label209"
        Me.Label209.Size = New System.Drawing.Size(58, 13)
        Me.Label209.TabIndex = 1163
        Me.Label209.Text = "Game logo"
        '
        'gamelogoforcg2
        '
        Me.gamelogoforcg2.BackColor = System.Drawing.SystemColors.Highlight
        Me.gamelogoforcg2.ImageLocation = "C:/casparcg/ng2022/data/games logo/bx.png"
        Me.gamelogoforcg2.Location = New System.Drawing.Point(149, 29)
        Me.gamelogoforcg2.Name = "gamelogoforcg2"
        Me.gamelogoforcg2.Size = New System.Drawing.Size(52, 38)
        Me.gamelogoforcg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gamelogoforcg2.TabIndex = 1162
        Me.gamelogoforcg2.TabStop = False
        '
        'cmdstopcg2
        '
        Me.cmdstopcg2.BackColor = System.Drawing.Color.Crimson
        Me.cmdstopcg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopcg2.ForeColor = System.Drawing.Color.White
        Me.cmdstopcg2.Location = New System.Drawing.Point(715, 153)
        Me.cmdstopcg2.Name = "cmdstopcg2"
        Me.cmdstopcg2.Size = New System.Drawing.Size(56, 547)
        Me.cmdstopcg2.TabIndex = 599
        Me.cmdstopcg2.Text = "Stop"
        Me.cmdstopcg2.UseVisualStyleBackColor = False
        '
        'cmd3linercentercg2
        '
        Me.cmd3linercentercg2.BackColor = System.Drawing.Color.Green
        Me.cmd3linercentercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3linercentercg2.ForeColor = System.Drawing.Color.White
        Me.cmd3linercentercg2.Location = New System.Drawing.Point(552, 154)
        Me.cmd3linercentercg2.Name = "cmd3linercentercg2"
        Me.cmd3linercentercg2.Size = New System.Drawing.Size(105, 28)
        Me.cmd3linercentercg2.TabIndex = 598
        Me.cmd3linercentercg2.Text = "3 Liner Center"
        Me.cmd3linercentercg2.UseVisualStyleBackColor = False
        '
        'cmd10linercg2
        '
        Me.cmd10linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd10linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd10linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd10linercg2.Location = New System.Drawing.Point(551, 407)
        Me.cmd10linercg2.Name = "cmd10linercg2"
        Me.cmd10linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd10linercg2.TabIndex = 593
        Me.cmd10linercg2.Text = "10 Liner"
        Me.cmd10linercg2.UseVisualStyleBackColor = False
        '
        'cmd9linercg2
        '
        Me.cmd9linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd9linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd9linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd9linercg2.Location = New System.Drawing.Point(551, 381)
        Me.cmd9linercg2.Name = "cmd9linercg2"
        Me.cmd9linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd9linercg2.TabIndex = 592
        Me.cmd9linercg2.Text = "9 Liner"
        Me.cmd9linercg2.UseVisualStyleBackColor = False
        '
        'cmd8linercg2
        '
        Me.cmd8linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd8linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd8linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd8linercg2.Location = New System.Drawing.Point(551, 354)
        Me.cmd8linercg2.Name = "cmd8linercg2"
        Me.cmd8linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd8linercg2.TabIndex = 591
        Me.cmd8linercg2.Text = "8 Liner"
        Me.cmd8linercg2.UseVisualStyleBackColor = False
        '
        'cmd7linercg2
        '
        Me.cmd7linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd7linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd7linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd7linercg2.Location = New System.Drawing.Point(551, 329)
        Me.cmd7linercg2.Name = "cmd7linercg2"
        Me.cmd7linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd7linercg2.TabIndex = 590
        Me.cmd7linercg2.Text = "7 Liner"
        Me.cmd7linercg2.UseVisualStyleBackColor = False
        '
        'cmd6linercg2
        '
        Me.cmd6linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd6linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd6linercg2.Location = New System.Drawing.Point(551, 305)
        Me.cmd6linercg2.Name = "cmd6linercg2"
        Me.cmd6linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd6linercg2.TabIndex = 589
        Me.cmd6linercg2.Text = "6 Liner"
        Me.cmd6linercg2.UseVisualStyleBackColor = False
        '
        'cmd5linercg2
        '
        Me.cmd5linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd5linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd5linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd5linercg2.Location = New System.Drawing.Point(551, 281)
        Me.cmd5linercg2.Name = "cmd5linercg2"
        Me.cmd5linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd5linercg2.TabIndex = 588
        Me.cmd5linercg2.Text = "5 Liner"
        Me.cmd5linercg2.UseVisualStyleBackColor = False
        '
        'cmd4linercg2
        '
        Me.cmd4linercg2.BackColor = System.Drawing.Color.Green
        Me.cmd4linercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4linercg2.ForeColor = System.Drawing.Color.White
        Me.cmd4linercg2.Location = New System.Drawing.Point(551, 256)
        Me.cmd4linercg2.Name = "cmd4linercg2"
        Me.cmd4linercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmd4linercg2.TabIndex = 587
        Me.cmd4linercg2.Text = "4 Liner"
        Me.cmd4linercg2.UseVisualStyleBackColor = False
        '
        'cmdthreelinercg2
        '
        Me.cmdthreelinercg2.BackColor = System.Drawing.Color.Green
        Me.cmdthreelinercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdthreelinercg2.ForeColor = System.Drawing.Color.White
        Me.cmdthreelinercg2.Location = New System.Drawing.Point(551, 232)
        Me.cmdthreelinercg2.Name = "cmdthreelinercg2"
        Me.cmdthreelinercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmdthreelinercg2.TabIndex = 584
        Me.cmdthreelinercg2.Text = "3 Liner"
        Me.cmdthreelinercg2.UseVisualStyleBackColor = False
        '
        'cmdtwolinercg2
        '
        Me.cmdtwolinercg2.BackColor = System.Drawing.Color.Green
        Me.cmdtwolinercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtwolinercg2.ForeColor = System.Drawing.Color.White
        Me.cmdtwolinercg2.Location = New System.Drawing.Point(551, 208)
        Me.cmdtwolinercg2.Name = "cmdtwolinercg2"
        Me.cmdtwolinercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmdtwolinercg2.TabIndex = 583
        Me.cmdtwolinercg2.Text = "2 Liner"
        Me.cmdtwolinercg2.UseVisualStyleBackColor = False
        '
        'cmdonelinercg2
        '
        Me.cmdonelinercg2.BackColor = System.Drawing.Color.Green
        Me.cmdonelinercg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdonelinercg2.ForeColor = System.Drawing.Color.White
        Me.cmdonelinercg2.Location = New System.Drawing.Point(551, 185)
        Me.cmdonelinercg2.Name = "cmdonelinercg2"
        Me.cmdonelinercg2.Size = New System.Drawing.Size(88, 24)
        Me.cmdonelinercg2.TabIndex = 582
        Me.cmdonelinercg2.Text = "1 Liner"
        Me.cmdonelinercg2.UseVisualStyleBackColor = False
        '
        'cmdrefreshdatacg2
        '
        Me.cmdrefreshdatacg2.Location = New System.Drawing.Point(280, 147)
        Me.cmdrefreshdatacg2.Name = "cmdrefreshdatacg2"
        Me.cmdrefreshdatacg2.Size = New System.Drawing.Size(80, 35)
        Me.cmdrefreshdatacg2.TabIndex = 581
        Me.cmdrefreshdatacg2.Text = "Refresh Data from text file"
        Me.cmdrefreshdatacg2.UseVisualStyleBackColor = True
        '
        'dgvinfocg2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinfocg2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvinfocg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinfocg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Line_no})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinfocg2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvinfocg2.Location = New System.Drawing.Point(7, 188)
        Me.dgvinfocg2.Name = "dgvinfocg2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinfocg2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvinfocg2.Size = New System.Drawing.Size(541, 513)
        Me.dgvinfocg2.TabIndex = 558
        '
        'Column5
        '
        Me.Column5.HeaderText = "Info"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 400
        '
        'Line_no
        '
        Me.Line_no.HeaderText = "Line"
        Me.Line_no.Name = "Line_no"
        Me.Line_no.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Info"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 400
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 30
        '
        'ucCG2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbcg2)
        Me.Name = "ucCG2"
        Me.Size = New System.Drawing.Size(1208, 921)
        Me.gbcg2.ResumeLayout(False)
        Me.gbcg2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.eventlogoforcg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox23.ResumeLayout(False)
        CType(Me.gamelogoforcg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinfocg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbcg2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label262 As System.Windows.Forms.Label
    Friend WithEvents lblfilenamecg2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents cmduprowcg2 As System.Windows.Forms.Button
    Friend WithEvents cmdremoverowcg2 As System.Windows.Forms.Button
    Friend WithEvents cmddownrowcg2 As System.Windows.Forms.Button
    Friend WithEvents cmdaddrowcg2 As System.Windows.Forms.Button
    Friend WithEvents cmdsaveasnewfilecg2 As System.Windows.Forms.Button
    Friend WithEvents Label208 As System.Windows.Forms.Label
    Friend WithEvents eventlogoforcg2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label209 As System.Windows.Forms.Label
    Friend WithEvents gamelogoforcg2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdstopcg2 As System.Windows.Forms.Button
    Friend WithEvents cmd3linercentercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd10linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd9linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd8linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd7linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd6linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd5linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmd4linercg2 As System.Windows.Forms.Button
    Friend WithEvents cmdthreelinercg2 As System.Windows.Forms.Button
    Friend WithEvents cmdtwolinercg2 As System.Windows.Forms.Button
    Friend WithEvents cmdonelinercg2 As System.Windows.Forms.Button
    Friend WithEvents cmdrefreshdatacg2 As System.Windows.Forms.Button
    Friend WithEvents dgvinfocg2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Line_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTemplateDirectoryCg2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdNextStepCG2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label30 As Label
    Friend WithEvents cmblayergames As ComboBox
    Friend WithEvents osd2 As SaveFileDialog
End Class
