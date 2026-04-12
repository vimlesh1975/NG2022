<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucvlcpreview
    Inherits ucNGBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucvlcpreview))
        Me.cmdremovepreview = New System.Windows.Forms.Button()
        Me.cmdpreviewkey = New System.Windows.Forms.Button()
        Me.cmbippreview = New System.Windows.Forms.ComboBox()
        Me.cmdpreview = New System.Windows.Forms.Button()
        Me.txtoptionspreview = New System.Windows.Forms.TextBox()
        Me.vlcpreview = New Vlc.DotNet.Forms.VlcControl()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdremovepreview
        '
        Me.cmdremovepreview.Location = New System.Drawing.Point(186, 49)
        Me.cmdremovepreview.Name = "cmdremovepreview"
        Me.cmdremovepreview.Size = New System.Drawing.Size(108, 22)
        Me.cmdremovepreview.TabIndex = 1175
        Me.cmdremovepreview.Text = "Remove Preview"
        Me.cmdremovepreview.UseVisualStyleBackColor = True
        '
        'cmdpreviewkey
        '
        Me.cmdpreviewkey.Location = New System.Drawing.Point(106, 49)
        Me.cmdpreviewkey.Name = "cmdpreviewkey"
        Me.cmdpreviewkey.Size = New System.Drawing.Size(74, 22)
        Me.cmdpreviewkey.TabIndex = 1177
        Me.cmdpreviewkey.Text = "Preview Key"
        Me.cmdpreviewkey.UseVisualStyleBackColor = True
        '
        'cmbippreview
        '
        Me.cmbippreview.FormattingEnabled = True
        Me.cmbippreview.Items.AddRange(New Object() {"224.0.0.1:5004", "127.0.0.1:5004", "192.168.1.1:5004", "192.168.1.2:5004", "192.168.1.3:5004"})
        Me.cmbippreview.Location = New System.Drawing.Point(33, 16)
        Me.cmbippreview.Name = "cmbippreview"
        Me.cmbippreview.Size = New System.Drawing.Size(99, 21)
        Me.cmbippreview.TabIndex = 1178
        Me.cmbippreview.Text = "224.0.0.1:5004"
        '
        'cmdpreview
        '
        Me.cmdpreview.Location = New System.Drawing.Point(26, 48)
        Me.cmdpreview.Name = "cmdpreview"
        Me.cmdpreview.Size = New System.Drawing.Size(80, 22)
        Me.cmdpreview.TabIndex = 1174
        Me.cmdpreview.Text = "Preview Fill"
        Me.cmdpreview.UseVisualStyleBackColor = True
        '
        'txtoptionspreview
        '
        Me.txtoptionspreview.Location = New System.Drawing.Point(138, 10)
        Me.txtoptionspreview.Multiline = True
        Me.txtoptionspreview.Name = "txtoptionspreview"
        Me.txtoptionspreview.Size = New System.Drawing.Size(275, 36)
        Me.txtoptionspreview.TabIndex = 1176
        Me.txtoptionspreview.Text = "-vcodec libx264 -tune zerolatency -preset ultrafast -crf 25 -format mpegts scale=" &
    "240:180"
        '
        'vlcpreview
        '
        Me.vlcpreview.BackColor = System.Drawing.Color.Black
        Me.vlcpreview.Location = New System.Drawing.Point(57, 113)
        Me.vlcpreview.Name = "vlcpreview"
        Me.vlcpreview.Size = New System.Drawing.Size(338, 132)
        Me.vlcpreview.Spu = -1
        Me.vlcpreview.TabIndex = 1179
        Me.vlcpreview.Text = "VlcControl1"
        Me.vlcpreview.VlcLibDirectory = CType(resources.GetObject("vlcpreview.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlcpreview.VlcMediaplayerOptions = Nothing
        '
        'ucvlcpreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.vlcpreview)
        Me.Controls.Add(Me.cmdremovepreview)
        Me.Controls.Add(Me.cmdpreviewkey)
        Me.Controls.Add(Me.cmbippreview)
        Me.Controls.Add(Me.cmdpreview)
        Me.Controls.Add(Me.txtoptionspreview)
        Me.Name = "ucvlcpreview"
        Me.Size = New System.Drawing.Size(477, 310)
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdremovepreview As Button
    Friend WithEvents cmdpreviewkey As Button
    Friend WithEvents cmbippreview As ComboBox
    Friend WithEvents cmdpreview As Button
    Friend WithEvents txtoptionspreview As TextBox
    Friend WithEvents vlcpreview As Vlc.DotNet.Forms.VlcControl
End Class

