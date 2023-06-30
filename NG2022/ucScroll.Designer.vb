<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucScroll
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucScroll))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbscroll = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdbordercolor = New System.Windows.Forms.Button()
        Me.cmdcolor = New System.Windows.Forms.Button()
        Me.cmdstripcolor = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScrollTemplate = New System.Windows.Forms.TextBox()
        Me.chkCapitalise = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmdhidegbscrollandclock = New System.Windows.Forms.Button()
        Me.picscrollbullet = New System.Windows.Forms.PictureBox()
        Me.cmdselectallforscroll = New System.Windows.Forms.Button()
        Me.cmddeselectallforscroll = New System.Windows.Forms.Button()
        Me.txtdelemeterforscroll = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.cmdpausescroll = New System.Windows.Forms.Button()
        Me.cmdplayscroll = New System.Windows.Forms.Button()
        Me.cmdstopscroll = New System.Windows.Forms.Button()
        Me.cmddeletetsscroll = New System.Windows.Forms.Button()
        Me.cmduptsscroll = New System.Windows.Forms.Button()
        Me.cmddowntsscroll = New System.Windows.Forms.Button()
        Me.cmdinserttsscroll = New System.Windows.Forms.Button()
        Me.dgvscroll = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nspeedscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmblayerscroll = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gbscroll.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picscrollbullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nspeedscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbscroll
        '
        Me.gbscroll.BackColor = System.Drawing.Color.Bisque
        Me.gbscroll.Controls.Add(Me.Label6)
        Me.gbscroll.Controls.Add(Me.Label5)
        Me.gbscroll.Controls.Add(Me.Label4)
        Me.gbscroll.Controls.Add(Me.cmdbordercolor)
        Me.gbscroll.Controls.Add(Me.cmdcolor)
        Me.gbscroll.Controls.Add(Me.cmdstripcolor)
        Me.gbscroll.Controls.Add(Me.MenuStrip1)
        Me.gbscroll.Controls.Add(Me.Label2)
        Me.gbscroll.Controls.Add(Me.txtScrollTemplate)
        Me.gbscroll.Controls.Add(Me.chkCapitalise)
        Me.gbscroll.Controls.Add(Me.Label29)
        Me.gbscroll.Controls.Add(Me.cmdhidegbscrollandclock)
        Me.gbscroll.Controls.Add(Me.picscrollbullet)
        Me.gbscroll.Controls.Add(Me.cmdselectallforscroll)
        Me.gbscroll.Controls.Add(Me.cmddeselectallforscroll)
        Me.gbscroll.Controls.Add(Me.txtdelemeterforscroll)
        Me.gbscroll.Controls.Add(Me.Label114)
        Me.gbscroll.Controls.Add(Me.cmdpausescroll)
        Me.gbscroll.Controls.Add(Me.cmdplayscroll)
        Me.gbscroll.Controls.Add(Me.cmdstopscroll)
        Me.gbscroll.Controls.Add(Me.cmddeletetsscroll)
        Me.gbscroll.Controls.Add(Me.cmduptsscroll)
        Me.gbscroll.Controls.Add(Me.cmddowntsscroll)
        Me.gbscroll.Controls.Add(Me.cmdinserttsscroll)
        Me.gbscroll.Controls.Add(Me.dgvscroll)
        Me.gbscroll.Controls.Add(Me.nspeedscroll)
        Me.gbscroll.Controls.Add(Me.Label20)
        Me.gbscroll.Controls.Add(Me.cmblayerscroll)
        Me.gbscroll.Controls.Add(Me.Label21)
        Me.gbscroll.Location = New System.Drawing.Point(4, 3)
        Me.gbscroll.Name = "gbscroll"
        Me.gbscroll.Size = New System.Drawing.Size(1106, 460)
        Me.gbscroll.TabIndex = 534
        Me.gbscroll.TabStop = False
        Me.gbscroll.Text = "Scroll And Clock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(597, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 1180
        Me.Label6.Text = "Strip Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(597, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 1179
        Me.Label5.Text = "Font Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(807, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 1178
        Me.Label4.Text = "Font Edge Color"
        '
        'cmdbordercolor
        '
        Me.cmdbordercolor.BackColor = System.Drawing.Color.Black
        Me.cmdbordercolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbordercolor.ForeColor = System.Drawing.Color.Black
        Me.cmdbordercolor.Location = New System.Drawing.Point(800, 41)
        Me.cmdbordercolor.Name = "cmdbordercolor"
        Me.cmdbordercolor.Size = New System.Drawing.Size(95, 29)
        Me.cmdbordercolor.TabIndex = 1177
        Me.cmdbordercolor.UseVisualStyleBackColor = False
        '
        'cmdcolor
        '
        Me.cmdcolor.BackColor = System.Drawing.Color.White
        Me.cmdcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcolor.ForeColor = System.Drawing.Color.Black
        Me.cmdcolor.Location = New System.Drawing.Point(659, 41)
        Me.cmdcolor.Name = "cmdcolor"
        Me.cmdcolor.Size = New System.Drawing.Size(130, 29)
        Me.cmdcolor.TabIndex = 1176
        Me.cmdcolor.Text = "Font Color"
        Me.cmdcolor.UseVisualStyleBackColor = False
        '
        'cmdstripcolor
        '
        Me.cmdstripcolor.BackColor = System.Drawing.Color.White
        Me.cmdstripcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstripcolor.ForeColor = System.Drawing.Color.Black
        Me.cmdstripcolor.Location = New System.Drawing.Point(659, 14)
        Me.cmdstripcolor.Name = "cmdstripcolor"
        Me.cmdstripcolor.Size = New System.Drawing.Size(130, 27)
        Me.cmdstripcolor.TabIndex = 1175
        Me.cmdstripcolor.Text = "Strip color"
        Me.cmdstripcolor.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 42)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 1170
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.InsertToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1169
        Me.Label2.Text = "Template"
        '
        'txtScrollTemplate
        '
        Me.txtScrollTemplate.Location = New System.Drawing.Point(63, 19)
        Me.txtScrollTemplate.Name = "txtScrollTemplate"
        Me.txtScrollTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txtScrollTemplate.TabIndex = 1168
        Me.txtScrollTemplate.Text = "CMP/scroll/scroll"
        '
        'chkCapitalise
        '
        Me.chkCapitalise.AutoSize = True
        Me.chkCapitalise.Location = New System.Drawing.Point(9, 78)
        Me.chkCapitalise.Name = "chkCapitalise"
        Me.chkCapitalise.Size = New System.Drawing.Size(71, 17)
        Me.chkCapitalise.TabIndex = 1167
        Me.chkCapitalise.Text = "Capitalise"
        Me.chkCapitalise.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(99, 49)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 1166
        Me.Label29.Text = "Bullet"
        '
        'cmdhidegbscrollandclock
        '
        Me.cmdhidegbscrollandclock.Image = CType(resources.GetObject("cmdhidegbscrollandclock.Image"), System.Drawing.Image)
        Me.cmdhidegbscrollandclock.Location = New System.Drawing.Point(1057, 8)
        Me.cmdhidegbscrollandclock.Name = "cmdhidegbscrollandclock"
        Me.cmdhidegbscrollandclock.Size = New System.Drawing.Size(28, 27)
        Me.cmdhidegbscrollandclock.TabIndex = 712
        Me.cmdhidegbscrollandclock.UseVisualStyleBackColor = True
        '
        'picscrollbullet
        '
        Me.picscrollbullet.ImageLocation = "C:\Casparcg\mydata\html\dd.png"
        Me.picscrollbullet.InitialImage = CType(resources.GetObject("picscrollbullet.InitialImage"), System.Drawing.Image)
        Me.picscrollbullet.Location = New System.Drawing.Point(139, 42)
        Me.picscrollbullet.Name = "picscrollbullet"
        Me.picscrollbullet.Size = New System.Drawing.Size(32, 26)
        Me.picscrollbullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picscrollbullet.TabIndex = 1165
        Me.picscrollbullet.TabStop = False
        '
        'cmdselectallforscroll
        '
        Me.cmdselectallforscroll.Location = New System.Drawing.Point(1005, 49)
        Me.cmdselectallforscroll.Name = "cmdselectallforscroll"
        Me.cmdselectallforscroll.Size = New System.Drawing.Size(76, 23)
        Me.cmdselectallforscroll.TabIndex = 513
        Me.cmdselectallforscroll.Text = "Select All"
        Me.cmdselectallforscroll.UseVisualStyleBackColor = True
        '
        'cmddeselectallforscroll
        '
        Me.cmddeselectallforscroll.Location = New System.Drawing.Point(1005, 76)
        Me.cmddeselectallforscroll.Name = "cmddeselectallforscroll"
        Me.cmddeselectallforscroll.Size = New System.Drawing.Size(79, 23)
        Me.cmddeselectallforscroll.TabIndex = 512
        Me.cmddeselectallforscroll.Text = "Deselect All"
        Me.cmddeselectallforscroll.UseVisualStyleBackColor = True
        '
        'txtdelemeterforscroll
        '
        Me.txtdelemeterforscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelemeterforscroll.Location = New System.Drawing.Point(302, 45)
        Me.txtdelemeterforscroll.Name = "txtdelemeterforscroll"
        Me.txtdelemeterforscroll.Size = New System.Drawing.Size(69, 26)
        Me.txtdelemeterforscroll.TabIndex = 511
        Me.txtdelemeterforscroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(175, 47)
        Me.Label114.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(122, 13)
        Me.Label114.TabIndex = 510
        Me.Label114.Text = "Delimeter between items"
        '
        'cmdpausescroll
        '
        Me.cmdpausescroll.BackColor = System.Drawing.Color.Yellow
        Me.cmdpausescroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpausescroll.Location = New System.Drawing.Point(804, 72)
        Me.cmdpausescroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdpausescroll.Name = "cmdpausescroll"
        Me.cmdpausescroll.Size = New System.Drawing.Size(128, 30)
        Me.cmdpausescroll.TabIndex = 508
        Me.cmdpausescroll.Text = "Pause/Resume"
        Me.cmdpausescroll.UseVisualStyleBackColor = False
        '
        'cmdplayscroll
        '
        Me.cmdplayscroll.BackColor = System.Drawing.Color.Green
        Me.cmdplayscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayscroll.ForeColor = System.Drawing.Color.White
        Me.cmdplayscroll.Location = New System.Drawing.Point(752, 72)
        Me.cmdplayscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayscroll.Name = "cmdplayscroll"
        Me.cmdplayscroll.Size = New System.Drawing.Size(48, 30)
        Me.cmdplayscroll.TabIndex = 498
        Me.cmdplayscroll.Text = "Play"
        Me.cmdplayscroll.UseVisualStyleBackColor = False
        '
        'cmdstopscroll
        '
        Me.cmdstopscroll.BackColor = System.Drawing.Color.Red
        Me.cmdstopscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopscroll.ForeColor = System.Drawing.Color.White
        Me.cmdstopscroll.Location = New System.Drawing.Point(940, 72)
        Me.cmdstopscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopscroll.Name = "cmdstopscroll"
        Me.cmdstopscroll.Size = New System.Drawing.Size(58, 30)
        Me.cmdstopscroll.TabIndex = 499
        Me.cmdstopscroll.Text = "Stop"
        Me.cmdstopscroll.UseVisualStyleBackColor = False
        '
        'cmddeletetsscroll
        '
        Me.cmddeletetsscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeletetsscroll.Location = New System.Drawing.Point(198, 75)
        Me.cmddeletetsscroll.Name = "cmddeletetsscroll"
        Me.cmddeletetsscroll.Size = New System.Drawing.Size(33, 22)
        Me.cmddeletetsscroll.TabIndex = 496
        Me.cmddeletetsscroll.UseVisualStyleBackColor = True
        '
        'cmduptsscroll
        '
        Me.cmduptsscroll.Image = CType(resources.GetObject("cmduptsscroll.Image"), System.Drawing.Image)
        Me.cmduptsscroll.Location = New System.Drawing.Point(84, 75)
        Me.cmduptsscroll.Name = "cmduptsscroll"
        Me.cmduptsscroll.Size = New System.Drawing.Size(28, 23)
        Me.cmduptsscroll.TabIndex = 494
        Me.cmduptsscroll.UseVisualStyleBackColor = True
        '
        'cmddowntsscroll
        '
        Me.cmddowntsscroll.Image = CType(resources.GetObject("cmddowntsscroll.Image"), System.Drawing.Image)
        Me.cmddowntsscroll.Location = New System.Drawing.Point(115, 75)
        Me.cmddowntsscroll.Name = "cmddowntsscroll"
        Me.cmddowntsscroll.Size = New System.Drawing.Size(36, 23)
        Me.cmddowntsscroll.TabIndex = 495
        Me.cmddowntsscroll.UseVisualStyleBackColor = True
        '
        'cmdinserttsscroll
        '
        Me.cmdinserttsscroll.Image = CType(resources.GetObject("cmdinserttsscroll.Image"), System.Drawing.Image)
        Me.cmdinserttsscroll.Location = New System.Drawing.Point(152, 75)
        Me.cmdinserttsscroll.Name = "cmdinserttsscroll"
        Me.cmdinserttsscroll.Size = New System.Drawing.Size(41, 23)
        Me.cmdinserttsscroll.TabIndex = 493
        Me.cmdinserttsscroll.UseVisualStyleBackColor = True
        '
        'dgvscroll
        '
        Me.dgvscroll.AllowDrop = True
        Me.dgvscroll.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvscroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvscroll.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvscroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvscroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn2})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvscroll.Location = New System.Drawing.Point(4, 106)
        Me.dgvscroll.MultiSelect = False
        Me.dgvscroll.Name = "dgvscroll"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvscroll.RowHeadersWidth = 60
        Me.dgvscroll.RowTemplate.Height = 30
        Me.dgvscroll.Size = New System.Drawing.Size(1094, 347)
        Me.dgvscroll.TabIndex = 492
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Scroll"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 540
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 1000
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.FalseValue = "0"
        Me.DataGridViewCheckBoxColumn2.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.TrueValue = "1"
        Me.DataGridViewCheckBoxColumn2.Width = 30
        '
        'nspeedscroll
        '
        Me.nspeedscroll.DecimalPlaces = 1
        Me.nspeedscroll.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nspeedscroll.Location = New System.Drawing.Point(693, 78)
        Me.nspeedscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nspeedscroll.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nspeedscroll.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nspeedscroll.Name = "nspeedscroll"
        Me.nspeedscroll.Size = New System.Drawing.Size(46, 20)
        Me.nspeedscroll.TabIndex = 452
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(652, 81)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 451
        Me.Label20.Text = "speed"
        '
        'cmblayerscroll
        '
        Me.cmblayerscroll.FormattingEnabled = True
        Me.cmblayerscroll.Items.AddRange(New Object() {"51", "52", "53", "54", "55"})
        Me.cmblayerscroll.Location = New System.Drawing.Point(550, 23)
        Me.cmblayerscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayerscroll.Name = "cmblayerscroll"
        Me.cmblayerscroll.Size = New System.Drawing.Size(40, 21)
        Me.cmblayerscroll.TabIndex = 450
        Me.cmblayerscroll.Text = "51"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(434, 25)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 13)
        Me.Label21.TabIndex = 449
        Me.Label21.Text = "video layer-flash layer"
        '
        'ucScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbscroll)
        Me.Name = "ucScroll"
        Me.Size = New System.Drawing.Size(1119, 470)
        Me.gbscroll.ResumeLayout(False)
        Me.gbscroll.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picscrollbullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nspeedscroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbscroll As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdbordercolor As Button
    Friend WithEvents cmdcolor As Button
    Friend WithEvents cmdstripcolor As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txtScrollTemplate As TextBox
    Friend WithEvents chkCapitalise As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cmdhidegbscrollandclock As Button
    Friend WithEvents picscrollbullet As PictureBox
    Friend WithEvents cmdselectallforscroll As Button
    Friend WithEvents cmddeselectallforscroll As Button
    Friend WithEvents txtdelemeterforscroll As TextBox
    Friend WithEvents Label114 As Label
    Friend WithEvents cmdpausescroll As Button
    Friend WithEvents cmdplayscroll As Button
    Friend WithEvents cmdstopscroll As Button
    Friend WithEvents cmddeletetsscroll As Button
    Friend WithEvents cmduptsscroll As Button
    Friend WithEvents cmddowntsscroll As Button
    Friend WithEvents cmdinserttsscroll As Button
    Friend WithEvents dgvscroll As DataGridView
    Friend WithEvents nspeedscroll As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents cmblayerscroll As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
End Class
