<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCasparcgWindow
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
        Me.gbcasparcgwindow = New System.Windows.Forms.GroupBox()
        Me.cmbcasparcgwindowtitle = New System.Windows.Forms.ComboBox()
        Me.lblplaying = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmdoutcasparcgwindow = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrpreview = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmraudio = New System.Windows.Forms.Timer(Me.components)
        Me.gbcasparcgwindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbcasparcgwindow
        '
        Me.gbcasparcgwindow.BackColor = System.Drawing.Color.SkyBlue
        Me.gbcasparcgwindow.Controls.Add(Me.cmbcasparcgwindowtitle)
        Me.gbcasparcgwindow.Controls.Add(Me.lblplaying)
        Me.gbcasparcgwindow.Controls.Add(Me.Label27)
        Me.gbcasparcgwindow.Controls.Add(Me.cmdoutcasparcgwindow)
        Me.gbcasparcgwindow.Controls.Add(Me.cmdshowcasparcgwindow)
        Me.gbcasparcgwindow.Controls.Add(Me.Panel1)
        Me.gbcasparcgwindow.Location = New System.Drawing.Point(1, 1)
        Me.gbcasparcgwindow.Name = "gbcasparcgwindow"
        Me.gbcasparcgwindow.Size = New System.Drawing.Size(748, 490)
        Me.gbcasparcgwindow.TabIndex = 432
        Me.gbcasparcgwindow.TabStop = False
        Me.gbcasparcgwindow.Text = "Casparcg Window"
        '
        'cmbcasparcgwindowtitle
        '
        Me.cmbcasparcgwindowtitle.FormattingEnabled = True
        Me.cmbcasparcgwindowtitle.Location = New System.Drawing.Point(6, 11)
        Me.cmbcasparcgwindowtitle.Name = "cmbcasparcgwindowtitle"
        Me.cmbcasparcgwindowtitle.Size = New System.Drawing.Size(176, 21)
        Me.cmbcasparcgwindowtitle.TabIndex = 727
        Me.cmbcasparcgwindowtitle.Text = "Screen consumer [1|1080i5000]"
        '
        'lblplaying
        '
        Me.lblplaying.Location = New System.Drawing.Point(0, -1)
        Me.lblplaying.Name = "lblplaying"
        Me.lblplaying.Size = New System.Drawing.Size(100, 23)
        Me.lblplaying.TabIndex = 1183
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(0, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 23)
        Me.Label27.TabIndex = 1184
        '
        'cmdoutcasparcgwindow
        '
        Me.cmdoutcasparcgwindow.Location = New System.Drawing.Point(219, 8)
        Me.cmdoutcasparcgwindow.Name = "cmdoutcasparcgwindow"
        Me.cmdoutcasparcgwindow.Size = New System.Drawing.Size(44, 23)
        Me.cmdoutcasparcgwindow.TabIndex = 327
        Me.cmdoutcasparcgwindow.Text = "OUT"
        Me.cmdoutcasparcgwindow.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindow
        '
        Me.cmdshowcasparcgwindow.Location = New System.Drawing.Point(188, 8)
        Me.cmdshowcasparcgwindow.Name = "cmdshowcasparcgwindow"
        Me.cmdshowcasparcgwindow.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindow.TabIndex = 155
        Me.cmdshowcasparcgwindow.Text = "IN"
        Me.cmdshowcasparcgwindow.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(8, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 450)
        Me.Panel1.TabIndex = 156
        '
        'tmrpreview
        '
        Me.tmrpreview.Interval = 1000
        '
        'tmraudio
        '
        Me.tmraudio.Enabled = True
        '
        'ucCasparcgWindow
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbcasparcgwindow)
        Me.Name = "ucCasparcgWindow"
        Me.Size = New System.Drawing.Size(753, 493)
        Me.gbcasparcgwindow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbcasparcgwindow As System.Windows.Forms.GroupBox
    Friend WithEvents cmbcasparcgwindowtitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblplaying As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label

    Friend WithEvents cmdoutcasparcgwindow As System.Windows.Forms.Button
    Friend WithEvents cmdshowcasparcgwindow As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tmrpreview As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tmraudio As Timer
End Class
