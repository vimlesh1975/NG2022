<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTally1
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
        Me.components = New System.ComponentModel.Container()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdPlayTally1 = New System.Windows.Forms.Button()
        Me.cmdstopcg2 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmblayergames = New System.Windows.Forms.ComboBox()
        Me.cmdTally1Update = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdoTotal = New System.Windows.Forms.RadioButton()
        Me.rdoWon = New System.Windows.Forms.RadioButton()
        Me.rdoLead = New System.Windows.Forms.RadioButton()
        Me.chkallthree = New System.Windows.Forms.CheckBox()
        Me.tmrAllThree = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column6})
        Me.dgv1.Location = New System.Drawing.Point(17, 24)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 50
        Me.dgv1.Size = New System.Drawing.Size(357, 561)
        Me.dgv1.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Image"
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Won"
        Me.Column4.Name = "Column4"
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Lead"
        Me.Column3.Name = "Column3"
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'cmdPlayTally1
        '
        Me.cmdPlayTally1.Location = New System.Drawing.Point(380, 97)
        Me.cmdPlayTally1.Name = "cmdPlayTally1"
        Me.cmdPlayTally1.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlayTally1.TabIndex = 1
        Me.cmdPlayTally1.Text = "Play"
        Me.cmdPlayTally1.UseVisualStyleBackColor = True
        '
        'cmdstopcg2
        '
        Me.cmdstopcg2.BackColor = System.Drawing.Color.Crimson
        Me.cmdstopcg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopcg2.ForeColor = System.Drawing.Color.White
        Me.cmdstopcg2.Location = New System.Drawing.Point(389, 126)
        Me.cmdstopcg2.Name = "cmdstopcg2"
        Me.cmdstopcg2.Size = New System.Drawing.Size(56, 70)
        Me.cmdstopcg2.TabIndex = 1261
        Me.cmdstopcg2.Text = "Stop"
        Me.cmdstopcg2.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(393, 24)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 1263
        Me.Label30.Text = "v-f layer"
        '
        'cmblayergames
        '
        Me.cmblayergames.FormattingEnabled = True
        Me.cmblayergames.Items.AddRange(New Object() {"96", "97", "98", "99", "100"})
        Me.cmblayergames.Location = New System.Drawing.Point(450, 24)
        Me.cmblayergames.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayergames.Name = "cmblayergames"
        Me.cmblayergames.Size = New System.Drawing.Size(40, 21)
        Me.cmblayergames.TabIndex = 1262
        Me.cmblayergames.Text = "96"
        '
        'cmdTally1Update
        '
        Me.cmdTally1Update.Location = New System.Drawing.Point(380, 202)
        Me.cmdTally1Update.Name = "cmdTally1Update"
        Me.cmdTally1Update.Size = New System.Drawing.Size(75, 23)
        Me.cmdTally1Update.TabIndex = 1264
        Me.cmdTally1Update.Text = "Update"
        Me.cmdTally1Update.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox5.Controls.Add(Me.rdoTotal)
        Me.GroupBox5.Controls.Add(Me.rdoWon)
        Me.GroupBox5.Controls.Add(Me.rdoLead)
        Me.GroupBox5.Location = New System.Drawing.Point(380, 51)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 40)
        Me.GroupBox5.TabIndex = 1265
        Me.GroupBox5.TabStop = False
        '
        'rdoTotal
        '
        Me.rdoTotal.AutoSize = True
        Me.rdoTotal.Location = New System.Drawing.Point(129, 19)
        Me.rdoTotal.Name = "rdoTotal"
        Me.rdoTotal.Size = New System.Drawing.Size(49, 17)
        Me.rdoTotal.TabIndex = 1221
        Me.rdoTotal.Text = "Total"
        Me.rdoTotal.UseVisualStyleBackColor = True
        '
        'rdoWon
        '
        Me.rdoWon.AutoSize = True
        Me.rdoWon.Checked = True
        Me.rdoWon.Location = New System.Drawing.Point(9, 19)
        Me.rdoWon.Name = "rdoWon"
        Me.rdoWon.Size = New System.Drawing.Size(48, 17)
        Me.rdoWon.TabIndex = 1220
        Me.rdoWon.TabStop = True
        Me.rdoWon.Text = "Won"
        Me.rdoWon.UseVisualStyleBackColor = True
        '
        'rdoLead
        '
        Me.rdoLead.AutoSize = True
        Me.rdoLead.Location = New System.Drawing.Point(70, 19)
        Me.rdoLead.Name = "rdoLead"
        Me.rdoLead.Size = New System.Drawing.Size(49, 17)
        Me.rdoLead.TabIndex = 1219
        Me.rdoLead.Text = "Lead"
        Me.rdoLead.UseVisualStyleBackColor = True
        '
        'chkallthree
        '
        Me.chkallthree.AutoSize = True
        Me.chkallthree.Location = New System.Drawing.Point(380, 231)
        Me.chkallthree.Name = "chkallthree"
        Me.chkallthree.Size = New System.Drawing.Size(68, 17)
        Me.chkallthree.TabIndex = 1266
        Me.chkallthree.Text = "All Three"
        Me.chkallthree.UseVisualStyleBackColor = True
        '
        'tmrAllThree
        '
        Me.tmrAllThree.Interval = 4000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1267
        Me.Label1.Text = "Timer Interval"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox1.Location = New System.Drawing.Point(477, 267)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(40, 21)
        Me.ComboBox1.TabIndex = 1268
        Me.ComboBox1.Text = "4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1269
        Me.Label2.Text = "Tally1"
        '
        'ucTally1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkallthree)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.cmdTally1Update)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmblayergames)
        Me.Controls.Add(Me.cmdstopcg2)
        Me.Controls.Add(Me.cmdPlayTally1)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "ucTally1"
        Me.Size = New System.Drawing.Size(578, 599)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents cmdPlayTally1 As Button
    Friend WithEvents cmdstopcg2 As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents cmblayergames As ComboBox
    Friend WithEvents cmdTally1Update As Button
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdoTotal As RadioButton
    Friend WithEvents rdoWon As RadioButton
    Friend WithEvents rdoLead As RadioButton
    Friend WithEvents chkallthree As CheckBox
    Friend WithEvents tmrAllThree As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
End Class
