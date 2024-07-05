<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucElection
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Photo1 = New System.Windows.Forms.TabPage()
        Me.UcPhoto11 = New NG2022.ucPhoto1()
        Me.Tally1 = New System.Windows.Forms.TabPage()
        Me.UcTally11 = New NG2022.ucTally1()
        Me.TabControl1.SuspendLayout()
        Me.Photo1.SuspendLayout()
        Me.Tally1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Photo1)
        Me.TabControl1.Controls.Add(Me.Tally1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1277, 813)
        Me.TabControl1.TabIndex = 0
        '
        'Photo1
        '
        Me.Photo1.Controls.Add(Me.UcPhoto11)
        Me.Photo1.Location = New System.Drawing.Point(4, 22)
        Me.Photo1.Name = "Photo1"
        Me.Photo1.Padding = New System.Windows.Forms.Padding(3)
        Me.Photo1.Size = New System.Drawing.Size(1269, 787)
        Me.Photo1.TabIndex = 1
        Me.Photo1.Text = "Photo1"
        Me.Photo1.UseVisualStyleBackColor = True
        '
        'UcPhoto11
        '
        Me.UcPhoto11.Location = New System.Drawing.Point(3, 6)
        Me.UcPhoto11.Name = "UcPhoto11"
        Me.UcPhoto11.Size = New System.Drawing.Size(1227, 737)
        Me.UcPhoto11.TabIndex = 0
        '
        'Tally1
        '
        Me.Tally1.Controls.Add(Me.UcTally11)
        Me.Tally1.Location = New System.Drawing.Point(4, 22)
        Me.Tally1.Name = "Tally1"
        Me.Tally1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tally1.Size = New System.Drawing.Size(1269, 787)
        Me.Tally1.TabIndex = 0
        Me.Tally1.Text = "Tally1"
        Me.Tally1.UseVisualStyleBackColor = True
        '
        'UcTally11
        '
        Me.UcTally11.Location = New System.Drawing.Point(6, 6)
        Me.UcTally11.Name = "UcTally11"
        Me.UcTally11.Size = New System.Drawing.Size(578, 599)
        Me.UcTally11.TabIndex = 0
        '
        'ucElection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ucElection"
        Me.Size = New System.Drawing.Size(1283, 830)
        Me.TabControl1.ResumeLayout(False)
        Me.Photo1.ResumeLayout(False)
        Me.Tally1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tally1 As TabPage
    Friend WithEvents Photo1 As TabPage
    Friend WithEvents UcTally11 As ucTally1
    Friend WithEvents UcPhoto11 As ucPhoto1
End Class
