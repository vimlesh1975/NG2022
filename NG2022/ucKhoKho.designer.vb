﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucKhoKho
    Inherits System.Windows.Forms.UserControl
    'Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucKhoKho))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSubHeader = New System.Windows.Forms.ComboBox()
        Me.cmbHeader = New System.Windows.Forms.ComboBox()
        Me.cmdeventid = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbgames = New System.Windows.Forms.ComboBox()
        Me.cmdstopgym = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmblayergames = New System.Windows.Forms.ComboBox()
        Me.tmrtimeonform = New System.Windows.Forms.Timer(Me.components)
        Me.tmrtimeupdateontemplate = New System.Windows.Forms.Timer(Me.components)
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.Ball = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmdmatchstatics = New System.Windows.Forms.Button()
        Me.cmdgroupresul2tball = New System.Windows.Forms.Button()
        Me.cmdgoalsummarywithtime = New System.Windows.Forms.Button()
        Me.cmdgrouptosemifinalball = New System.Windows.Forms.Button()
        Me.cmdgroupresultball = New System.Windows.Forms.Button()
        Me.gbsetscoreball = New System.Windows.Forms.GroupBox()
        Me.cmdscoreresetball = New System.Windows.Forms.Button()
        Me.cmdshowsetscoreball = New System.Windows.Forms.Button()
        Me.dgvsetscoreball = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbgoalsummary = New System.Windows.Forms.ComboBox()
        Me.cmdgoalSummary = New System.Windows.Forms.Button()
        Me.cmdtteamridt2ball = New System.Windows.Forms.Button()
        Me.cmdtteamridt1ball = New System.Windows.Forms.Button()
        Me.cmdplayeridt2ball = New System.Windows.Forms.Button()
        Me.cmdplayeridt1ball = New System.Windows.Forms.Button()
        Me.lblfilenamet2ball = New System.Windows.Forms.Label()
        Me.lblfilenamet1ball = New System.Windows.Forms.Label()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.cmduprowt2ball = New System.Windows.Forms.Button()
        Me.cmdremoverowt2ball = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.cmdnewt2ball = New System.Windows.Forms.ToolStripButton()
        Me.cmdopent2ball = New System.Windows.Forms.ToolStripButton()
        Me.cmdsavet2ball = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmddownrowt2ball = New System.Windows.Forms.Button()
        Me.cmdaddrowt2ball = New System.Windows.Forms.Button()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.cmduprowt1ball = New System.Windows.Forms.Button()
        Me.cmdremoverowt1ball = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdnewt1ball = New System.Windows.Forms.ToolStripButton()
        Me.cmdopent1ball = New System.Windows.Forms.ToolStripButton()
        Me.cmdsavet1ball = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmddownrowt1ball = New System.Windows.Forms.Button()
        Me.cmdaddrowt1ball = New System.Windows.Forms.Button()
        Me.cmdvsball = New System.Windows.Forms.Button()
        Me.dgvt2ball = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cmdt2gball = New System.Windows.Forms.Button()
        Me.cmdt2rball = New System.Windows.Forms.Button()
        Me.cmdt2yball = New System.Windows.Forms.Button()
        Me.cmdt2lineupball = New System.Windows.Forms.Button()
        Me.cmdt1gball = New System.Windows.Forms.Button()
        Me.cmdt1rball = New System.Windows.Forms.Button()
        Me.txtt2ball = New System.Windows.Forms.TextBox()
        Me.cmdt1yball = New System.Windows.Forms.Button()
        Me.txtt1ball = New System.Windows.Forms.TextBox()
        Me.cmdt1lineupball = New System.Windows.Forms.Button()
        Me.dgvt1ball = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.cmdteam2outball = New System.Windows.Forms.Button()
        Me.cmdteam1outball = New System.Windows.Forms.Button()
        Me.txtt2outball = New System.Windows.Forms.TextBox()
        Me.txtt2inball = New System.Windows.Forms.TextBox()
        Me.cmdt2inoutball = New System.Windows.Forms.Button()
        Me.txtt1outball = New System.Windows.Forms.TextBox()
        Me.txtt1inball = New System.Windows.Forms.TextBox()
        Me.cmdteam1inball = New System.Windows.Forms.Button()
        Me.cmdteam2inball = New System.Windows.Forms.Button()
        Me.cmdt1inoutball = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.cmdscoreupdateball = New System.Windows.Forms.Button()
        Me.chkRunner = New System.Windows.Forms.CheckBox()
        Me.cmdscoreclockrunner = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdadjustsecball = New System.Windows.Forms.Button()
        Me.cmbputsecondball = New System.Windows.Forms.ComboBox()
        Me.cmbputminuteball = New System.Windows.Forms.ComboBox()
        Me.cmdadjustminball = New System.Windows.Forms.Button()
        Me.cmbinfoball = New System.Windows.Forms.ComboBox()
        Me.cmdscorewithinfo = New System.Windows.Forms.Button()
        Me.cmdscorewithclock = New System.Windows.Forms.Button()
        Me.cmdadd1t2ball = New System.Windows.Forms.Button()
        Me.cmdadd1t1ball = New System.Windows.Forms.Button()
        Me.cmdt2colorball = New System.Windows.Forms.Button()
        Me.cmdt1colorball = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cmbhalfball = New System.Windows.Forms.ComboBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.rdodowncounterball = New System.Windows.Forms.RadioButton()
        Me.rdoupcounterball = New System.Windows.Forms.RadioButton()
        Me.pict2logoball = New System.Windows.Forms.PictureBox()
        Me.pict1logoball = New System.Windows.Forms.PictureBox()
        Me.txtt2gball = New System.Windows.Forms.TextBox()
        Me.txtt1gball = New System.Windows.Forms.TextBox()
        Me.cmdresetclockball = New System.Windows.Forms.Button()
        Me.txtsecball = New System.Windows.Forms.TextBox()
        Me.txtminball = New System.Windows.Forms.TextBox()
        Me.cmdstartclockball = New System.Windows.Forms.Button()
        Me.cmdpauseclockball = New System.Windows.Forms.Button()
        Me.cmdscoreball = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.osd2 = New System.Windows.Forms.SaveFileDialog()
        Me.eventlogo = New System.Windows.Forms.PictureBox()
        Me.gamelogo = New System.Windows.Forms.PictureBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.Ball.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.gbsetscoreball.SuspendLayout()
        CType(Me.dgvsetscoreball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvt2ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvt1ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.pict2logoball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict1logoball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.eventlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox3.Controls.Add(Me.cmbSubHeader)
        Me.GroupBox3.Controls.Add(Me.cmbHeader)
        Me.GroupBox3.Controls.Add(Me.cmdeventid)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 62)
        Me.GroupBox3.TabIndex = 1250
        Me.GroupBox3.TabStop = False
        '
        'cmbSubHeader
        '
        Me.cmbSubHeader.FormattingEnabled = True
        Me.cmbSubHeader.Items.AddRange(New Object() {"Aquatics Diving", "Aquatics Marathon Swimming", "Aquatics Swimming", "Aquatics Synchrosed Swimming", "Aquatics Water Polo", "Archery", "Athletics", "Athletics - Marathon & Race Walks", "Badminton", "Basketball", "Beach Volleyball", "Boxing", "Canoe Slalom", "Canoe Sprint", "Cycling BMX", "Cycling Mountain Bike", "Cycling Road Race & Time Trial", "Cycling Track", "Equestrian", "Fencing", "Football", "Gymnastics Artistic", "Gymnastics Rhythmic", "Gymnastics Trampoline", "Handball", "Hockey", "Judo", "Modern Pentathlon", "Rowing", "Sailing", "Shooting", "Table Tennis", "Taekwondo", "Tennis", "Triathlon", "Volleyball", "Weightlifting", "Wrestling", "", "", "AR Archery", "Men’s Individual", "Men’s Team", "Women’s Individual", "Women’s Team", "", "AT Athletics", "Men’s 100m", "Men’s 200m", "Men’s 400m", "Men’s 800m", "Men’s 1500m", "Men’s 5000m", "Men’s 10000m", "Men’s 110m Hurdles", "Men’s 400m Hurdles", "Men’s 3000m Steeplechase", "Men’s 4x100m Relay", "Men’s 4x400m Relay", "Men’s High Jump", "Men’s Pole Vault", "Men’s Long Jump", "Men’s Triple Jump", "Men’s Shot Put", "Men’s Discus", "Men’s Hammer", "Men’s Javelin", "", "Decathlon", "Men’s Marathon", "Men’s 20km Race Walk", "Men’s 50km Race Walk", "Women’s 100m", "Women’s 200m", "Women’s 400m", "Women’s 800m", "Women’s 1500m", "Women’s 5000m", "Women’s 10000m", "Women’s 100m Hurdles", "Women’s 400m Hurdles", "Women’s 3000m Steeplechase", "Women’s 4x100m Relay", "Women’s 4x400m Relay", "Women’s High Jump", "Women’s Pole Vault", "Women’s Long Jump", "Women’s Triple Jump", "Women’s Shot Put", "Women’s Discus", "Women’s Hammer", "Women’s Javelin", "", "Heptathlon", "Women’s Marathon", "Women’s 20km Race Walk", "BD Badminton", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "BK Basketball ", "Men’s Basketball ", "Women’s Basketball", "BV Beach Volleyball ", "Men’s Beach Volleyball ", "Women’s Beach Volleyball", "", "BX Boxing", "Men’s Light Fly 49kg", "Men’s Fly 52kg", "Men’s Bantam 56kg", "Men’s Light 60kg", "Men’s Light Welter 64kg", "Men’s Welter 69kg", "Men’s Middle 75kg", "Men’s Light Heavy 81kg", "Men’s Heavy 91kg", "Men’s Super Heavy +91kg", "Women’s Fly 51kg", "Women’s Light 60kg", "Women’s Middle 75kg", "", "CB BMX ", "Men’s BMX ", "Women’s BMX", "", "CF Canoe Sprint", "Men’s Kayak Single 200m", "Men’s Kayak Double 200m", "Men’s Kayak Single 1000m", "Men’s Kayak Double 1000m", "Men’s Kayak Four 1000m", "Men’s Canoe Single 200m", "Men’s Canoe Single 1000m", "Men’s Canoe Double 1000m", "Women’s Kayak Single 200m", "Women’s Kayak Single 500m", "Women’s Kayak Double 500m", "Women’s Kayak Four 500m", "", "CM Mountain Bike ", "Men’s Mountain Bike ", "Women’s Mountain Bike", "", "CR Cycling Road", "Men’s Road Race", "Men’s Individual Time Trial", "Women’s Road Race", "Women’s Individual Time Trial", "", "CS Canoe Slalom", "Men’s Canoe Single", "Men’s Canoe Double", "Men’s Kayak", "Women’s Kayak", "", "CT Cycling Track", "Men’s Keirin", "Men’s Omnium", "Men’s Sprint", "Men’s Team Pursuit", "Men’s Team Sprint", "Women’s Keirin", "Women’s Omnium", "Women’s Sprint", "Women’s Team Pursuit", "Women’s Team Sprint", "", "DV Diving", "Men’s 3m Springboard", "Men’s 10m Platform", "Women’s 3m Springboard", "Women’s 10m Platform", "Men’s Synchronised 3m Springboard", "Men’s Synchronised 10m Platform", "Women’s Synchronised 3m Springboard", "Women’s Synchronised 10m Platform", "", "EQ Equestrian", "Individual Dressage", "Individual Eventing", "Individual Jumping", "Team Dressage", "Team Eventing", "Team Jumping", "FB Football Men’s Football Women’s Football", "", "FE Fencing", "Men’s Individual Epee", "Men’s Individual Foil", "Men’s Individual Sabre", "Men’s Team Foil", "Men’s Team Sabre", "Women’s Individual Epee", "Women’s Individual Foil", "Women’s Individual Sabre", "Women’s Team Foil", "Women’s Team Epee", "", "GA Artistic Gymnastics", "Men’s Qualification", "Men’s Team Final", "Men’s All-Around Final", "Men’s Floor Exercise Final", "Men’s Vault Final", "Men’s Parallel Bars Final", "Men’s Horizontal Bar Final", "Men’s Rings Final", "Men’s Pommel Horse Final", "Women’s Qualification", "Women’s Team Final", "Women’s All-Around Final", "Women’s Floor Exercise Final", "Women’s Vault Final", "Women’s Uneven Bars Final", "Women’s Beam Final", "", "GR Rhythmic Gymnastics ", "Individual All-Around", "Group All-Around", "", "GT ", "Men’s Trampoline ", "Women’s Trampoline", "", "HB Handball ", "Men’s Handball ", "Women’s Handball", "", "HO Hockey ", "Men’s Hockey ", "Women’s Hockey", "", "JU Judo", "Men’s -60kg", "Men’s -66kg", "Men’s -73kg", "Men’s -81kg", "Men’s -90kg", "Men’s -100kg", "Men’s +100kg", "Women’s -48kg", "Women’s -52kg", "Women’s -57kg", "Women’s -63kg", "Women’s -70kg", "Women’s -78kg", "Women’s +78kg", "", "MP Modern Pentathlon", "Men’s Modern Pentathlon ", "Women’s Modern Pentathlon", "", "RO Rowing", "Men’s Single Sculls", "Men’s Double Sculls", "Lightweight Men’s Double Sculls", "Men’s Quadruple Sculls", "Men’s Pair", "Men’s Four", "Lightweight Men’s Four", "Men’s Eight", "Women’s Single Sculls", "Women’s Double Sculls", "Lightweight Women’s Double Sculls", "Women’s Quadruple Sculls", "Women’s Pair", "Women’s Eight", "", "SA Sailing", "Men’s Finn", "Men’s Laser", "Men’s 470", "Men’s Star", "Men’s 49er", "Men’s RS:X Windsurfer", "Women’s 470", "Women’s Laser Radial", "Women’s RS:X Windsurfer", "Women’s Elliott 6m", "", "SH Shooting", "Men’s 50m Rifle 3 Positions", "Men’s 50m Rifle Prone", "Men’s 10m Air Rifle", "Men’s 50m Pistol", "Men’s 25m Rapid Fire Pistol", "Men’s 10m Air Pistol", "Men’s Trap", "Men’s Double Trap", "Men’s Skeet", "Women’s 50m Rifle 3 Positions", "Women’s 10m Air Rifle", "Women’s 25m Pistol", "Women’s 10m Air Pistol", "Women’s Trap", "Women’s Skeet", "", "SW Swimming", "Men’s 50m Freestyle", "Men’s 100m Freestyle", "Men’s 200m Freestyle", "Men’s 400m Freestyle", "Men’s 1500m Freestyle", "Men’s 100m Butterfly", "Men’s 200m Butterfly", "Men’s 100m Breaststroke", "Men’s 200m Breaststroke", "Men’s 100m Backstroke", "Men’s 200m Backstroke", "Men’s 200m Individual Medley", "Men’s 400m Individual Medley", "Men’s 4x100m Freestyle Relay", "Men’s 4x200m Freestyle Relay", "Men’s 4x100m Medley Relay", "Men’s Marathon 10km", "Women’s 50m Freestyle", "Women’s 100m Freestyle", "Women’s 200m Freestyle", "Women’s 400m Freestyle", "Women’s 800m Freestyle", "Women’s 100m Butterfly", "Women’s 200m Butterfly", "Women’s 100m Breaststroke", "Women’s 200m Breaststroke", "Women’s 100m Backstroke", "Women’s 200m Backstroke", "Women’s 200m Individual Medley", "Women’s 400m Individual Medley", "Women’s 4x100m Freestyle Relay", "Women’s 4x200m Freestyle Relay", "Women’s 4x100m Medley Relay", "Women’s Marathon 10km", "SY Synchronised Swimming Duets Teams", "", "TE Tennis", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "TK Taekwondo", "Men’s -58kg", "Men’s -68kg", "Men’s -80kg", "Men’s +80kg", "Women’s -49kg", "Women’s -57kg", "Women’s -67kg", "Women’s +67kg", "TR Triathlon Men’s ", "Triathlon Women’s Triathlon", "", "TT Table Tennis", "Men’s Singles", "Men’s Team", "Women’s Singles", "Women’s Team", "", "", "", "VO Volleyball ", "Men’s Volleyball ", "Women’s Volleyball", "", "WL Weightlifting", "Men’s 56kg", "Men’s 62kg", "Men’s 69kg", "Men’s 77kg", "Men’s 85kg", "Men’s 94kg", "Men’s 105kg", "Men’s +105kg", "Women’s 48kg", "Women’s 53kg", "Women’s 58kg", "Women’s 63kg", "Women’s 69kg", "Women’s 75kg", "Women’s +75kg", "WP Water Polo ", "Men’s Water Polo ", "Women’s Water Polo", "", "WR Wrestling", "Men’s Freestyle 55kg", "Men’s Freestyle 60kg", "Men’s Freestyle 66kg", "Men’s Freestyle 74kg", "Men’s Freestyle 84kg", "Men’s Freestyle 96kg", "Men’s Freestyle 120kg", "Men’s Greco-Roman 55kg", "Men’s Greco-Roman 60kg", "Men’s Greco-Roman 66kg", "Men’s Greco-Roman 74kg", "Men’s Greco-Roman 84kg", "Men’s Greco-Roman 96kg", "Men’s Greco-Roman 120kg", "", "", "", "Round 1", "Round 2", "Round 3", "Round 4", "Round 5", "Leage Match", "Preliminary Match", "Pre Quarter Final", "Quarter Final", "Semi Final", "Final", "", "Table 1 - Round 3 (Morning Session)", "Table 1 - Round 3 (After noon Session)", "Table 1 - Round 1", "Table 1 - Round 1 (First Session)", "Table 1 - Round 2", "", "Men's Singles", "Women's Singles", "Men's Doubles", "Women's Doubles", "Team Event", "", "Junior Girls Team", "Junior Boys Team", "Cadet Girls Team", "Cadet Boys Team", "", "Junior Girls", "Junior Boys", "Cadet Girls", "Cadet Boys", "", "Junior Mixed Doubles", "Junior Boys Doubles", "Junior Girls Doubles", "Qualifying  - RD1", "Position 9-13", "", "Stage 1 Round 1"})
        Me.cmbSubHeader.Location = New System.Drawing.Point(78, 35)
        Me.cmbSubHeader.Name = "cmbSubHeader"
        Me.cmbSubHeader.Size = New System.Drawing.Size(221, 21)
        Me.cmbSubHeader.TabIndex = 1201
        Me.cmbSubHeader.Text = "Bronze Medal Match"
        '
        'cmbHeader
        '
        Me.cmbHeader.FormattingEnabled = True
        Me.cmbHeader.Items.AddRange(New Object() {"Aquatics Diving", "Aquatics Marathon Swimming", "Aquatics Swimming", "Aquatics Synchrosed Swimming", "Aquatics Water Polo", "Archery", "Athletics", "Athletics - Marathon & Race Walks", "Badminton", "Basketball", "Beach Volleyball", "Boxing", "Kickboxing", "Canoe Slalom", "Canoe Sprint", "Cycling BMX", "Cycling Mountain Bike", "Cycling Road Race & Time Trial", "Cycling Track", "Equestrian", "Fencing", "Football", "Gymnastics Artistic", "Gymnastics Rhythmic", "Gymnastics Trampoline", "Handball", "Hockey", "Judo", "Modern Pentathlon", "Rowing", "Sailing", "Shooting", "Table Tennis", "Taekwondo", "Tennis", "Triathlon", "Volleyball", "Weightlifting", "Wrestling", "", "", "AR Archery", "Men’s Individual", "Men’s Team", "Women’s Individual", "Women’s Team", "", "AT Athletics", "Men’s 100m", "Men’s 200m", "Men’s 400m", "Men’s 800m", "Men’s 1500m", "Men’s 5000m", "Men’s 10000m", "Men’s 110m Hurdles", "Men’s 400m Hurdles", "Men’s 3000m Steeplechase", "Men’s 4x100m Relay", "Men’s 4x400m Relay", "Men’s High Jump", "Men’s Pole Vault", "Men’s Long Jump", "Men’s Triple Jump", "Men’s Shot Put", "Men’s Discus", "Men’s Hammer", "Men’s Javelin", "", "Decathlon", "Men’s Marathon", "Men’s 20km Race Walk", "Men’s 50km Race Walk", "Women’s 100m", "Women’s 200m", "Women’s 400m", "Women’s 800m", "Women’s 1500m", "Women’s 5000m", "Women’s 10000m", "Women’s 100m Hurdles", "Women’s 400m Hurdles", "Women’s 3000m Steeplechase", "Women’s 4x100m Relay", "Women’s 4x400m Relay", "Women’s High Jump", "Women’s Pole Vault", "Women’s Long Jump", "Women’s Triple Jump", "Women’s Shot Put", "Women’s Discus", "Women’s Hammer", "Women’s Javelin", "", "Heptathlon", "Women’s Marathon", "Women’s 20km Race Walk", "BD Badminton", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "BK Basketball ", "Men’s Basketball ", "Women’s Basketball", "BV Beach Volleyball ", "Men’s Beach Volleyball ", "Women’s Beach Volleyball", "", "BX Boxing", "Men’s Light Fly 49kg", "Men’s Fly 52kg", "Men’s Bantam 56kg", "Men’s Light 60kg", "Men’s Light Welter 64kg", "Men’s Welter 69kg", "Men’s Middle 75kg", "Men’s Light Heavy 81kg", "Men’s Heavy 91kg", "Men’s Super Heavy +91kg", "Women’s Fly 51kg", "Women’s Light 60kg", "Women’s Middle 75kg", "", "CB BMX ", "Men’s BMX ", "Women’s BMX", "", "CF Canoe Sprint", "Men’s Kayak Single 200m", "Men’s Kayak Double 200m", "Men’s Kayak Single 1000m", "Men’s Kayak Double 1000m", "Men’s Kayak Four 1000m", "Men’s Canoe Single 200m", "Men’s Canoe Single 1000m", "Men’s Canoe Double 1000m", "Women’s Kayak Single 200m", "Women’s Kayak Single 500m", "Women’s Kayak Double 500m", "Women’s Kayak Four 500m", "", "CM Mountain Bike ", "Men’s Mountain Bike ", "Women’s Mountain Bike", "", "CR Cycling Road", "Men’s Road Race", "Men’s Individual Time Trial", "Women’s Road Race", "Women’s Individual Time Trial", "", "CS Canoe Slalom", "Men’s Canoe Single", "Men’s Canoe Double", "Men’s Kayak", "Women’s Kayak", "", "CT Cycling Track", "Men’s Keirin", "Men’s Omnium", "Men’s Sprint", "Men’s Team Pursuit", "Men’s Team Sprint", "Women’s Keirin", "Women’s Omnium", "Women’s Sprint", "Women’s Team Pursuit", "Women’s Team Sprint", "", "DV Diving", "Men’s 3m Springboard", "Men’s 10m Platform", "Women’s 3m Springboard", "Women’s 10m Platform", "Men’s Synchronised 3m Springboard", "Men’s Synchronised 10m Platform", "Women’s Synchronised 3m Springboard", "Women’s Synchronised 10m Platform", "", "EQ Equestrian", "Individual Dressage", "Individual Eventing", "Individual Jumping", "Team Dressage", "Team Eventing", "Team Jumping", "FB Football Men’s Football Women’s Football", "", "FE Fencing", "Men’s Individual Epee", "Men’s Individual Foil", "Men’s Individual Sabre", "Men’s Team Foil", "Men’s Team Sabre", "Women’s Individual Epee", "Women’s Individual Foil", "Women’s Individual Sabre", "Women’s Team Foil", "Women’s Team Epee", "", "GA Artistic Gymnastics", "Men’s Qualification", "Men’s Team Final", "Men’s All-Around Final", "Men’s Floor Exercise Final", "Men’s Vault Final", "Men’s Parallel Bars Final", "Men’s Horizontal Bar Final", "Men’s Rings Final", "Men’s Pommel Horse Final", "Women’s Qualification", "Women’s Team Final", "Women’s All-Around Final", "Women’s Floor Exercise Final", "Women’s Vault Final", "Women’s Uneven Bars Final", "Women’s Beam Final", "", "GR Rhythmic Gymnastics ", "Individual All-Around", "Group All-Around", "", "GT ", "Men’s Trampoline ", "Women’s Trampoline", "", "HB Handball ", "Men’s Handball ", "Women’s Handball", "", "HO Hockey ", "Men’s Hockey ", "Women’s Hockey", "", "JU Judo", "Men’s -60kg", "Men’s -66kg", "Men’s -73kg", "Men’s -81kg", "Men’s -90kg", "Men’s -100kg", "Men’s +100kg", "Women’s -48kg", "Women’s -52kg", "Women’s -57kg", "Women’s -63kg", "Women’s -70kg", "Women’s -78kg", "Women’s +78kg", "", "MP Modern Pentathlon", "Men’s Modern Pentathlon ", "Women’s Modern Pentathlon", "", "RO Rowing", "Men’s Single Sculls", "Men’s Double Sculls", "Lightweight Men’s Double Sculls", "Men’s Quadruple Sculls", "Men’s Pair", "Men’s Four", "Lightweight Men’s Four", "Men’s Eight", "Women’s Single Sculls", "Women’s Double Sculls", "Lightweight Women’s Double Sculls", "Women’s Quadruple Sculls", "Women’s Pair", "Women’s Eight", "", "SA Sailing", "Men’s Finn", "Men’s Laser", "Men’s 470", "Men’s Star", "Men’s 49er", "Men’s RS:X Windsurfer", "Women’s 470", "Women’s Laser Radial", "Women’s RS:X Windsurfer", "Women’s Elliott 6m", "", "SH Shooting", "Men’s 50m Rifle 3 Positions", "Men’s 50m Rifle Prone", "Men’s 10m Air Rifle", "Men’s 50m Pistol", "Men’s 25m Rapid Fire Pistol", "Men’s 10m Air Pistol", "Men’s Trap", "Men’s Double Trap", "Men’s Skeet", "Women’s 50m Rifle 3 Positions", "Women’s 10m Air Rifle", "Women’s 25m Pistol", "Women’s 10m Air Pistol", "Women’s Trap", "Women’s Skeet", "", "SW Swimming", "Men’s 50m Freestyle", "Men’s 100m Freestyle", "Men’s 200m Freestyle", "Men’s 400m Freestyle", "Men’s 1500m Freestyle", "Men’s 100m Butterfly", "Men’s 200m Butterfly", "Men’s 100m Breaststroke", "Men’s 200m Breaststroke", "Men’s 100m Backstroke", "Men’s 200m Backstroke", "Men’s 200m Individual Medley", "Men’s 400m Individual Medley", "Men’s 4x100m Freestyle Relay", "Men’s 4x200m Freestyle Relay", "Men’s 4x100m Medley Relay", "Men’s Marathon 10km", "Women’s 50m Freestyle", "Women’s 100m Freestyle", "Women’s 200m Freestyle", "Women’s 400m Freestyle", "Women’s 800m Freestyle", "Women’s 100m Butterfly", "Women’s 200m Butterfly", "Women’s 100m Breaststroke", "Women’s 200m Breaststroke", "Women’s 100m Backstroke", "Women’s 200m Backstroke", "Women’s 200m Individual Medley", "Women’s 400m Individual Medley", "Women’s 4x100m Freestyle Relay", "Women’s 4x200m Freestyle Relay", "Women’s 4x100m Medley Relay", "Women’s Marathon 10km", "SY Synchronised Swimming Duets Teams", "", "TE Tennis", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "TK Taekwondo", "Men’s -58kg", "Men’s -68kg", "Men’s -80kg", "Men’s +80kg", "Women’s -49kg", "Women’s -57kg", "Women’s -67kg", "Women’s +67kg", "TR Triathlon Men’s ", "Triathlon Women’s Triathlon", "", "TT Table Tennis", "Men’s Singles", "Men’s Team", "Women’s Singles", "Women’s Team", "", "", "", "VO Volleyball ", "Men’s Volleyball ", "Women’s Volleyball", "", "WL Weightlifting", "Men’s 56kg", "Men’s 62kg", "Men’s 69kg", "Men’s 77kg", "Men’s 85kg", "Men’s 94kg", "Men’s 105kg", "Men’s +105kg", "Women’s 48kg", "Women’s 53kg", "Women’s 58kg", "Women’s 63kg", "Women’s 69kg", "Women’s 75kg", "Women’s +75kg", "WP Water Polo ", "Men’s Water Polo ", "Women’s Water Polo", "", "WR Wrestling", "Men’s Freestyle 55kg", "Men’s Freestyle 60kg", "Men’s Freestyle 66kg", "Men’s Freestyle 74kg", "Men’s Freestyle 84kg", "Men’s Freestyle 96kg", "Men’s Freestyle 120kg", "Men’s Greco-Roman 55kg", "Men’s Greco-Roman 60kg", "Men’s Greco-Roman 66kg", "Men’s Greco-Roman 74kg", "Men’s Greco-Roman 84kg", "Men’s Greco-Roman 96kg", "Men’s Greco-Roman 120kg", "", "", "", "Table Tennis", "Reliance 20th Asian Junior Table Tennis", "", "Table 1 - Round 3 (Morning Session)", "Table 1 - Round 3 (After noon Session)", "Table 1 - Round 1", "Table 1 - Round 1 (First Session)", "Table 1 - Round 2", "", "Men's Singles", "Women's Singles", "Men's Doubles", "Women's Doubles", "Team Event", "", "", "Round 1", "Round 2", "Round 3", "Round 4", "Round 5", "Leage Match", "Preliminary Match", "Pre Quarter Final", "Quarter Final", "Semi Final", "Final", "", "Mixed Doubles", "", "Junior Girls Team", "Junior Boys Team", "Cadet Girls Team", "Cadet Boys Team", "", "Junior Girls", "Junior Boys", "Cadet Girls", "Cadet Boys", "", "Junior Mixed Doubles", "Junior Boys Doubles", "Junior Girls Doubles", "Qualifying  - RD1", "Position 9-13", "", "Stage 1 Round 1"})
        Me.cmbHeader.Location = New System.Drawing.Point(78, 11)
        Me.cmbHeader.Name = "cmbHeader"
        Me.cmbHeader.Size = New System.Drawing.Size(221, 21)
        Me.cmbHeader.TabIndex = 1200
        Me.cmbHeader.Text = "Men's Khokho"
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
        'cmbgames
        '
        Me.cmbgames.FormattingEnabled = True
        Me.cmbgames.Items.AddRange(New Object() {"Aquatics", "Archery", "Atheletics", "Badminton", "Basketball", "Black", "Boxing", "Cycling", "Diving", "Football", "Gymnastics - Artistic", "Gymnastics - Rhythmic", "Gymnastics - Trampoline", "Handball", "Hockey", "Judo", "Kabaddi", "Kayaking", "Khokho", "Shooting", "Squash", "Swimming", "TableTennis", "Taekwondo", "Tennis", "Triathlon", "Volleyball", "Weight lift", "Wrestling", "Wushu"})
        Me.cmbgames.Location = New System.Drawing.Point(770, 12)
        Me.cmbgames.Name = "cmbgames"
        Me.cmbgames.Size = New System.Drawing.Size(114, 21)
        Me.cmbgames.Sorted = True
        Me.cmbgames.TabIndex = 1252
        Me.cmbgames.Text = "Khokho"
        '
        'cmdstopgym
        '
        Me.cmdstopgym.BackColor = System.Drawing.Color.Red
        Me.cmdstopgym.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdstopgym.Location = New System.Drawing.Point(517, 59)
        Me.cmdstopgym.Name = "cmdstopgym"
        Me.cmdstopgym.Size = New System.Drawing.Size(580, 62)
        Me.cmdstopgym.TabIndex = 585
        Me.cmdstopgym.Text = "Stop"
        Me.cmdstopgym.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(221, 13)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 1172
        Me.Label30.Text = "v-f layer"
        '
        'cmblayergames
        '
        Me.cmblayergames.FormattingEnabled = True
        Me.cmblayergames.Items.AddRange(New Object() {"96", "97", "98", "99", "100"})
        Me.cmblayergames.Location = New System.Drawing.Point(264, 12)
        Me.cmblayergames.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayergames.Name = "cmblayergames"
        Me.cmblayergames.Size = New System.Drawing.Size(40, 21)
        Me.cmblayergames.TabIndex = 1171
        Me.cmblayergames.Text = "96"
        '
        'tmrtimeonform
        '
        Me.tmrtimeonform.Interval = 1000
        '
        'tmrtimeupdateontemplate
        '
        Me.tmrtimeupdateontemplate.Interval = 1000
        '
        'Ball
        '
        Me.Ball.Controls.Add(Me.GroupBox7)
        Me.Ball.Controls.Add(Me.gbsetscoreball)
        Me.Ball.Controls.Add(Me.cmbgoalsummary)
        Me.Ball.Controls.Add(Me.cmdgoalSummary)
        Me.Ball.Controls.Add(Me.cmdtteamridt2ball)
        Me.Ball.Controls.Add(Me.cmdtteamridt1ball)
        Me.Ball.Controls.Add(Me.cmdplayeridt2ball)
        Me.Ball.Controls.Add(Me.cmdplayeridt1ball)
        Me.Ball.Controls.Add(Me.lblfilenamet2ball)
        Me.Ball.Controls.Add(Me.lblfilenamet1ball)
        Me.Ball.Controls.Add(Me.GroupBox22)
        Me.Ball.Controls.Add(Me.GroupBox21)
        Me.Ball.Controls.Add(Me.GroupBox16)
        Me.Ball.Location = New System.Drawing.Point(4, 22)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(1104, 600)
        Me.Ball.TabIndex = 4
        Me.Ball.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox7.Controls.Add(Me.cmdmatchstatics)
        Me.GroupBox7.Controls.Add(Me.cmdgroupresul2tball)
        Me.GroupBox7.Controls.Add(Me.cmdgoalsummarywithtime)
        Me.GroupBox7.Controls.Add(Me.cmdgrouptosemifinalball)
        Me.GroupBox7.Controls.Add(Me.cmdgroupresultball)
        Me.GroupBox7.Location = New System.Drawing.Point(785, 282)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(136, 167)
        Me.GroupBox7.TabIndex = 1227
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Static Templates"
        '
        'cmdmatchstatics
        '
        Me.cmdmatchstatics.Location = New System.Drawing.Point(10, 84)
        Me.cmdmatchstatics.Name = "cmdmatchstatics"
        Me.cmdmatchstatics.Size = New System.Drawing.Size(91, 30)
        Me.cmdmatchstatics.TabIndex = 1225
        Me.cmdmatchstatics.Text = "Match Statics"
        Me.cmdmatchstatics.UseVisualStyleBackColor = True
        '
        'cmdgroupresul2tball
        '
        Me.cmdgroupresul2tball.Location = New System.Drawing.Point(6, 36)
        Me.cmdgroupresul2tball.Name = "cmdgroupresul2tball"
        Me.cmdgroupresul2tball.Size = New System.Drawing.Size(92, 24)
        Me.cmdgroupresul2tball.TabIndex = 1224
        Me.cmdgroupresul2tball.Text = "Group Result2"
        Me.cmdgroupresul2tball.UseVisualStyleBackColor = True
        '
        'cmdgoalsummarywithtime
        '
        Me.cmdgoalsummarywithtime.Location = New System.Drawing.Point(10, 114)
        Me.cmdgoalsummarywithtime.Name = "cmdgoalsummarywithtime"
        Me.cmdgoalsummarywithtime.Size = New System.Drawing.Size(75, 47)
        Me.cmdgoalsummarywithtime.TabIndex = 1226
        Me.cmdgoalsummarywithtime.Text = "Goal Summary With Time"
        Me.cmdgoalsummarywithtime.UseVisualStyleBackColor = True
        '
        'cmdgrouptosemifinalball
        '
        Me.cmdgrouptosemifinalball.Location = New System.Drawing.Point(6, 59)
        Me.cmdgrouptosemifinalball.Name = "cmdgrouptosemifinalball"
        Me.cmdgrouptosemifinalball.Size = New System.Drawing.Size(119, 27)
        Me.cmdgrouptosemifinalball.TabIndex = 1223
        Me.cmdgrouptosemifinalball.Text = "Group to Semi Final"
        Me.cmdgrouptosemifinalball.UseVisualStyleBackColor = True
        '
        'cmdgroupresultball
        '
        Me.cmdgroupresultball.Location = New System.Drawing.Point(6, 14)
        Me.cmdgroupresultball.Name = "cmdgroupresultball"
        Me.cmdgroupresultball.Size = New System.Drawing.Size(92, 23)
        Me.cmdgroupresultball.TabIndex = 607
        Me.cmdgroupresultball.Text = "Group Result1"
        Me.cmdgroupresultball.UseVisualStyleBackColor = True
        '
        'gbsetscoreball
        '
        Me.gbsetscoreball.BackColor = System.Drawing.Color.Aquamarine
        Me.gbsetscoreball.Controls.Add(Me.cmdscoreresetball)
        Me.gbsetscoreball.Controls.Add(Me.cmdshowsetscoreball)
        Me.gbsetscoreball.Controls.Add(Me.dgvsetscoreball)
        Me.gbsetscoreball.Location = New System.Drawing.Point(446, 347)
        Me.gbsetscoreball.Name = "gbsetscoreball"
        Me.gbsetscoreball.Size = New System.Drawing.Size(324, 132)
        Me.gbsetscoreball.TabIndex = 1221
        Me.gbsetscoreball.TabStop = False
        Me.gbsetscoreball.Text = "SetScore"
        '
        'cmdscoreresetball
        '
        Me.cmdscoreresetball.Location = New System.Drawing.Point(265, 74)
        Me.cmdscoreresetball.Name = "cmdscoreresetball"
        Me.cmdscoreresetball.Size = New System.Drawing.Size(47, 52)
        Me.cmdscoreresetball.TabIndex = 1136
        Me.cmdscoreresetball.Text = "Score Reset"
        Me.cmdscoreresetball.UseVisualStyleBackColor = True
        '
        'cmdshowsetscoreball
        '
        Me.cmdshowsetscoreball.Location = New System.Drawing.Point(265, 14)
        Me.cmdshowsetscoreball.Name = "cmdshowsetscoreball"
        Me.cmdshowsetscoreball.Size = New System.Drawing.Size(47, 54)
        Me.cmdshowsetscoreball.TabIndex = 662
        Me.cmdshowsetscoreball.Text = "Show"
        Me.cmdshowsetscoreball.UseVisualStyleBackColor = True
        '
        'dgvsetscoreball
        '
        Me.dgvsetscoreball.AllowUserToAddRows = False
        Me.dgvsetscoreball.AllowUserToResizeColumns = False
        Me.dgvsetscoreball.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsetscoreball.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvsetscoreball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsetscoreball.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn34})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsetscoreball.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvsetscoreball.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvsetscoreball.Location = New System.Drawing.Point(8, 14)
        Me.dgvsetscoreball.Name = "dgvsetscoreball"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsetscoreball.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvsetscoreball.Size = New System.Drawing.Size(251, 112)
        Me.dgvsetscoreball.TabIndex = 661
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "1st"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn28.Width = 30
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "2nd"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn29.Width = 30
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "3rd"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn30.Width = 30
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "4th"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn31.Width = 30
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "ET"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn32.Width = 30
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 30
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn34.Width = 50
        '
        'cmbgoalsummary
        '
        Me.cmbgoalsummary.FormattingEnabled = True
        Me.cmbgoalsummary.Items.AddRange(New Object() {"Round 1", "Round 2", "Round 3", "Round 4", "", "1st half", "2nd half", "3rd half", "4th half", "Full Time", "Half Time"})
        Me.cmbgoalsummary.Location = New System.Drawing.Point(443, 564)
        Me.cmbgoalsummary.Name = "cmbgoalsummary"
        Me.cmbgoalsummary.Size = New System.Drawing.Size(122, 21)
        Me.cmbgoalsummary.TabIndex = 1220
        Me.cmbgoalsummary.Text = "Round 1"
        '
        'cmdgoalSummary
        '
        Me.cmdgoalSummary.Location = New System.Drawing.Point(571, 560)
        Me.cmdgoalSummary.Name = "cmdgoalSummary"
        Me.cmdgoalSummary.Size = New System.Drawing.Size(104, 29)
        Me.cmdgoalSummary.TabIndex = 1218
        Me.cmdgoalSummary.Text = "Goal Summary"
        Me.cmdgoalSummary.UseVisualStyleBackColor = True
        '
        'cmdtteamridt2ball
        '
        Me.cmdtteamridt2ball.Location = New System.Drawing.Point(513, 519)
        Me.cmdtteamridt2ball.Name = "cmdtteamridt2ball"
        Me.cmdtteamridt2ball.Size = New System.Drawing.Size(70, 33)
        Me.cmdtteamridt2ball.TabIndex = 1207
        Me.cmdtteamridt2ball.Text = "Team ID 2"
        Me.cmdtteamridt2ball.UseVisualStyleBackColor = True
        '
        'cmdtteamridt1ball
        '
        Me.cmdtteamridt1ball.Location = New System.Drawing.Point(440, 518)
        Me.cmdtteamridt1ball.Name = "cmdtteamridt1ball"
        Me.cmdtteamridt1ball.Size = New System.Drawing.Size(70, 33)
        Me.cmdtteamridt1ball.TabIndex = 1206
        Me.cmdtteamridt1ball.Text = "Team ID 1"
        Me.cmdtteamridt1ball.UseVisualStyleBackColor = True
        '
        'cmdplayeridt2ball
        '
        Me.cmdplayeridt2ball.Location = New System.Drawing.Point(513, 482)
        Me.cmdplayeridt2ball.Name = "cmdplayeridt2ball"
        Me.cmdplayeridt2ball.Size = New System.Drawing.Size(70, 33)
        Me.cmdplayeridt2ball.TabIndex = 1205
        Me.cmdplayeridt2ball.Text = "Player ID 2"
        Me.cmdplayeridt2ball.UseVisualStyleBackColor = True
        '
        'cmdplayeridt1ball
        '
        Me.cmdplayeridt1ball.Location = New System.Drawing.Point(440, 482)
        Me.cmdplayeridt1ball.Name = "cmdplayeridt1ball"
        Me.cmdplayeridt1ball.Size = New System.Drawing.Size(70, 33)
        Me.cmdplayeridt1ball.TabIndex = 1204
        Me.cmdplayeridt1ball.Text = "Player ID 1"
        Me.cmdplayeridt1ball.UseVisualStyleBackColor = True
        '
        'lblfilenamet2ball
        '
        Me.lblfilenamet2ball.AutoSize = True
        Me.lblfilenamet2ball.Location = New System.Drawing.Point(444, 27)
        Me.lblfilenamet2ball.Name = "lblfilenamet2ball"
        Me.lblfilenamet2ball.Size = New System.Drawing.Size(81, 13)
        Me.lblfilenamet2ball.TabIndex = 1204
        Me.lblfilenamet2ball.Text = "lblfilenamet2ball"
        '
        'lblfilenamet1ball
        '
        Me.lblfilenamet1ball.AutoSize = True
        Me.lblfilenamet1ball.Location = New System.Drawing.Point(443, 9)
        Me.lblfilenamet1ball.Name = "lblfilenamet1ball"
        Me.lblfilenamet1ball.Size = New System.Drawing.Size(81, 13)
        Me.lblfilenamet1ball.TabIndex = 1203
        Me.lblfilenamet1ball.Text = "lblfilenamet1ball"
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.GroupBox24)
        Me.GroupBox22.Controls.Add(Me.GroupBox23)
        Me.GroupBox22.Controls.Add(Me.cmdvsball)
        Me.GroupBox22.Controls.Add(Me.dgvt2ball)
        Me.GroupBox22.Controls.Add(Me.Label40)
        Me.GroupBox22.Controls.Add(Me.Label39)
        Me.GroupBox22.Controls.Add(Me.cmdt2gball)
        Me.GroupBox22.Controls.Add(Me.cmdt2rball)
        Me.GroupBox22.Controls.Add(Me.cmdt2yball)
        Me.GroupBox22.Controls.Add(Me.cmdt2lineupball)
        Me.GroupBox22.Controls.Add(Me.cmdt1gball)
        Me.GroupBox22.Controls.Add(Me.cmdt1rball)
        Me.GroupBox22.Controls.Add(Me.txtt2ball)
        Me.GroupBox22.Controls.Add(Me.cmdt1yball)
        Me.GroupBox22.Controls.Add(Me.txtt1ball)
        Me.GroupBox22.Controls.Add(Me.cmdt1lineupball)
        Me.GroupBox22.Controls.Add(Me.dgvt1ball)
        Me.GroupBox22.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(427, 592)
        Me.GroupBox22.TabIndex = 630
        Me.GroupBox22.TabStop = False
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.cmduprowt2ball)
        Me.GroupBox24.Controls.Add(Me.cmdremoverowt2ball)
        Me.GroupBox24.Controls.Add(Me.ToolStrip2)
        Me.GroupBox24.Controls.Add(Me.cmddownrowt2ball)
        Me.GroupBox24.Controls.Add(Me.cmdaddrowt2ball)
        Me.GroupBox24.Location = New System.Drawing.Point(229, 13)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(185, 25)
        Me.GroupBox24.TabIndex = 1204
        Me.GroupBox24.TabStop = False
        '
        'cmduprowt2ball
        '
        Me.cmduprowt2ball.Image = CType(resources.GetObject("cmduprowt2ball.Image"), System.Drawing.Image)
        Me.cmduprowt2ball.Location = New System.Drawing.Point(85, 6)
        Me.cmduprowt2ball.Name = "cmduprowt2ball"
        Me.cmduprowt2ball.Size = New System.Drawing.Size(22, 18)
        Me.cmduprowt2ball.TabIndex = 1201
        Me.cmduprowt2ball.UseVisualStyleBackColor = True
        '
        'cmdremoverowt2ball
        '
        Me.cmdremoverowt2ball.BackgroundImage = CType(resources.GetObject("cmdremoverowt2ball.BackgroundImage"), System.Drawing.Image)
        Me.cmdremoverowt2ball.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.cmdremoverowt2ball.Location = New System.Drawing.Point(157, 6)
        Me.cmdremoverowt2ball.Name = "cmdremoverowt2ball"
        Me.cmdremoverowt2ball.Size = New System.Drawing.Size(22, 18)
        Me.cmdremoverowt2ball.TabIndex = 1200
        Me.cmdremoverowt2ball.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdnewt2ball, Me.cmdopent2ball, Me.cmdsavet2ball, Me.ToolStripSeparator5, Me.ToolStripSeparator6})
        Me.ToolStrip2.Location = New System.Drawing.Point(2, 4)
        Me.ToolStrip2.MaximumSize = New System.Drawing.Size(200, 200)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(93, 25)
        Me.ToolStrip2.TabIndex = 1199
        Me.ToolStrip2.Text = "ToolStrip3"
        '
        'cmdnewt2ball
        '
        Me.cmdnewt2ball.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdnewt2ball.Image = CType(resources.GetObject("cmdnewt2ball.Image"), System.Drawing.Image)
        Me.cmdnewt2ball.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdnewt2ball.Name = "cmdnewt2ball"
        Me.cmdnewt2ball.Size = New System.Drawing.Size(23, 22)
        Me.cmdnewt2ball.Text = "&New"
        '
        'cmdopent2ball
        '
        Me.cmdopent2ball.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdopent2ball.Image = CType(resources.GetObject("cmdopent2ball.Image"), System.Drawing.Image)
        Me.cmdopent2ball.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdopent2ball.Name = "cmdopent2ball"
        Me.cmdopent2ball.Size = New System.Drawing.Size(23, 22)
        Me.cmdopent2ball.Text = "&Open"
        '
        'cmdsavet2ball
        '
        Me.cmdsavet2ball.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsavet2ball.Image = CType(resources.GetObject("cmdsavet2ball.Image"), System.Drawing.Image)
        Me.cmdsavet2ball.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsavet2ball.Name = "cmdsavet2ball"
        Me.cmdsavet2ball.Size = New System.Drawing.Size(23, 22)
        Me.cmdsavet2ball.Text = "&Save"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'cmddownrowt2ball
        '
        Me.cmddownrowt2ball.Image = CType(resources.GetObject("cmddownrowt2ball.Image"), System.Drawing.Image)
        Me.cmddownrowt2ball.Location = New System.Drawing.Point(107, 6)
        Me.cmddownrowt2ball.Name = "cmddownrowt2ball"
        Me.cmddownrowt2ball.Size = New System.Drawing.Size(22, 18)
        Me.cmddownrowt2ball.TabIndex = 1198
        Me.cmddownrowt2ball.UseVisualStyleBackColor = True
        '
        'cmdaddrowt2ball
        '
        Me.cmdaddrowt2ball.Image = CType(resources.GetObject("cmdaddrowt2ball.Image"), System.Drawing.Image)
        Me.cmdaddrowt2ball.Location = New System.Drawing.Point(130, 6)
        Me.cmdaddrowt2ball.Name = "cmdaddrowt2ball"
        Me.cmdaddrowt2ball.Size = New System.Drawing.Size(22, 18)
        Me.cmdaddrowt2ball.TabIndex = 1197
        Me.cmdaddrowt2ball.UseVisualStyleBackColor = True
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.cmduprowt1ball)
        Me.GroupBox23.Controls.Add(Me.cmdremoverowt1ball)
        Me.GroupBox23.Controls.Add(Me.ToolStrip1)
        Me.GroupBox23.Controls.Add(Me.cmddownrowt1ball)
        Me.GroupBox23.Controls.Add(Me.cmdaddrowt1ball)
        Me.GroupBox23.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(189, 24)
        Me.GroupBox23.TabIndex = 1203
        Me.GroupBox23.TabStop = False
        '
        'cmduprowt1ball
        '
        Me.cmduprowt1ball.Image = CType(resources.GetObject("cmduprowt1ball.Image"), System.Drawing.Image)
        Me.cmduprowt1ball.Location = New System.Drawing.Point(88, 8)
        Me.cmduprowt1ball.Name = "cmduprowt1ball"
        Me.cmduprowt1ball.Size = New System.Drawing.Size(22, 18)
        Me.cmduprowt1ball.TabIndex = 1201
        Me.cmduprowt1ball.UseVisualStyleBackColor = True
        '
        'cmdremoverowt1ball
        '
        Me.cmdremoverowt1ball.BackgroundImage = CType(resources.GetObject("cmdremoverowt1ball.BackgroundImage"), System.Drawing.Image)
        Me.cmdremoverowt1ball.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.cmdremoverowt1ball.Location = New System.Drawing.Point(160, 8)
        Me.cmdremoverowt1ball.Name = "cmdremoverowt1ball"
        Me.cmdremoverowt1ball.Size = New System.Drawing.Size(22, 18)
        Me.cmdremoverowt1ball.TabIndex = 1200
        Me.cmdremoverowt1ball.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdnewt1ball, Me.cmdopent1ball, Me.cmdsavet1ball, Me.ToolStripSeparator3, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 6)
        Me.ToolStrip1.MaximumSize = New System.Drawing.Size(200, 200)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(93, 25)
        Me.ToolStrip1.TabIndex = 1199
        Me.ToolStrip1.Text = "ToolStrip3"
        '
        'cmdnewt1ball
        '
        Me.cmdnewt1ball.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdnewt1ball.Image = CType(resources.GetObject("cmdnewt1ball.Image"), System.Drawing.Image)
        Me.cmdnewt1ball.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdnewt1ball.Name = "cmdnewt1ball"
        Me.cmdnewt1ball.Size = New System.Drawing.Size(23, 22)
        Me.cmdnewt1ball.Text = "&New"
        '
        'cmdopent1ball
        '
        Me.cmdopent1ball.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdopent1ball.Image = CType(resources.GetObject("cmdopent1ball.Image"), System.Drawing.Image)
        Me.cmdopent1ball.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdopent1ball.Name = "cmdopent1ball"
        Me.cmdopent1ball.Size = New System.Drawing.Size(23, 22)
        Me.cmdopent1ball.Text = "&Open"
        '
        'cmdsavet1ball
        '
        Me.cmdsavet1ball.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsavet1ball.Image = CType(resources.GetObject("cmdsavet1ball.Image"), System.Drawing.Image)
        Me.cmdsavet1ball.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsavet1ball.Name = "cmdsavet1ball"
        Me.cmdsavet1ball.Size = New System.Drawing.Size(23, 22)
        Me.cmdsavet1ball.Text = "&Save"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'cmddownrowt1ball
        '
        Me.cmddownrowt1ball.Image = CType(resources.GetObject("cmddownrowt1ball.Image"), System.Drawing.Image)
        Me.cmddownrowt1ball.Location = New System.Drawing.Point(110, 8)
        Me.cmddownrowt1ball.Name = "cmddownrowt1ball"
        Me.cmddownrowt1ball.Size = New System.Drawing.Size(22, 18)
        Me.cmddownrowt1ball.TabIndex = 1198
        Me.cmddownrowt1ball.UseVisualStyleBackColor = True
        '
        'cmdaddrowt1ball
        '
        Me.cmdaddrowt1ball.Image = CType(resources.GetObject("cmdaddrowt1ball.Image"), System.Drawing.Image)
        Me.cmdaddrowt1ball.Location = New System.Drawing.Point(133, 8)
        Me.cmdaddrowt1ball.Name = "cmdaddrowt1ball"
        Me.cmdaddrowt1ball.Size = New System.Drawing.Size(22, 18)
        Me.cmdaddrowt1ball.TabIndex = 1197
        Me.cmdaddrowt1ball.UseVisualStyleBackColor = True
        '
        'cmdvsball
        '
        Me.cmdvsball.Location = New System.Drawing.Point(193, 42)
        Me.cmdvsball.Name = "cmdvsball"
        Me.cmdvsball.Size = New System.Drawing.Size(43, 23)
        Me.cmdvsball.TabIndex = 631
        Me.cmdvsball.Text = "V/S"
        Me.cmdvsball.UseVisualStyleBackColor = True
        '
        'dgvt2ball
        '
        Me.dgvt2ball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt2ball.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26})
        Me.dgvt2ball.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvt2ball.Location = New System.Drawing.Point(242, 66)
        Me.dgvt2ball.Name = "dgvt2ball"
        Me.dgvt2ball.RowTemplate.Height = 18
        Me.dgvt2ball.Size = New System.Drawing.Size(172, 467)
        Me.dgvt2ball.TabIndex = 628
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 120
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(183, 303)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 20)
        Me.Label40.TabIndex = 627
        Me.Label40.Text = "Coach"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(184, 249)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(51, 20)
        Me.Label39.TabIndex = 626
        Me.Label39.Text = "Extra"
        '
        'cmdt2gball
        '
        Me.cmdt2gball.BackColor = System.Drawing.Color.Green
        Me.cmdt2gball.Location = New System.Drawing.Point(362, 562)
        Me.cmdt2gball.Name = "cmdt2gball"
        Me.cmdt2gball.Size = New System.Drawing.Size(52, 25)
        Me.cmdt2gball.TabIndex = 599
        Me.cmdt2gball.Text = "Goal"
        Me.cmdt2gball.UseVisualStyleBackColor = False
        '
        'cmdt2rball
        '
        Me.cmdt2rball.BackColor = System.Drawing.Color.Red
        Me.cmdt2rball.Location = New System.Drawing.Point(303, 562)
        Me.cmdt2rball.Name = "cmdt2rball"
        Me.cmdt2rball.Size = New System.Drawing.Size(60, 25)
        Me.cmdt2rball.TabIndex = 598
        Me.cmdt2rball.Text = "Red"
        Me.cmdt2rball.UseVisualStyleBackColor = False
        '
        'cmdt2yball
        '
        Me.cmdt2yball.BackColor = System.Drawing.Color.Yellow
        Me.cmdt2yball.Location = New System.Drawing.Point(245, 562)
        Me.cmdt2yball.Name = "cmdt2yball"
        Me.cmdt2yball.Size = New System.Drawing.Size(58, 25)
        Me.cmdt2yball.TabIndex = 597
        Me.cmdt2yball.Text = "Yellow"
        Me.cmdt2yball.UseVisualStyleBackColor = False
        '
        'cmdt2lineupball
        '
        Me.cmdt2lineupball.Location = New System.Drawing.Point(242, 534)
        Me.cmdt2lineupball.Name = "cmdt2lineupball"
        Me.cmdt2lineupball.Size = New System.Drawing.Size(172, 28)
        Me.cmdt2lineupball.TabIndex = 594
        Me.cmdt2lineupball.Text = "Team2 Linup"
        Me.cmdt2lineupball.UseVisualStyleBackColor = True
        '
        'cmdt1gball
        '
        Me.cmdt1gball.BackColor = System.Drawing.Color.Green
        Me.cmdt1gball.Location = New System.Drawing.Point(134, 562)
        Me.cmdt1gball.Name = "cmdt1gball"
        Me.cmdt1gball.Size = New System.Drawing.Size(52, 25)
        Me.cmdt1gball.TabIndex = 593
        Me.cmdt1gball.Text = "Goal"
        Me.cmdt1gball.UseVisualStyleBackColor = False
        '
        'cmdt1rball
        '
        Me.cmdt1rball.BackColor = System.Drawing.Color.Red
        Me.cmdt1rball.Location = New System.Drawing.Point(74, 562)
        Me.cmdt1rball.Name = "cmdt1rball"
        Me.cmdt1rball.Size = New System.Drawing.Size(60, 25)
        Me.cmdt1rball.TabIndex = 592
        Me.cmdt1rball.Text = "Red"
        Me.cmdt1rball.UseVisualStyleBackColor = False
        '
        'txtt2ball
        '
        Me.txtt2ball.Location = New System.Drawing.Point(245, 44)
        Me.txtt2ball.Name = "txtt2ball"
        Me.txtt2ball.Size = New System.Drawing.Size(169, 20)
        Me.txtt2ball.TabIndex = 616
        Me.txtt2ball.Text = "Asam"
        '
        'cmdt1yball
        '
        Me.cmdt1yball.BackColor = System.Drawing.Color.Yellow
        Me.cmdt1yball.Location = New System.Drawing.Point(15, 561)
        Me.cmdt1yball.Name = "cmdt1yball"
        Me.cmdt1yball.Size = New System.Drawing.Size(58, 25)
        Me.cmdt1yball.TabIndex = 591
        Me.cmdt1yball.Text = "Yellow"
        Me.cmdt1yball.UseVisualStyleBackColor = False
        '
        'txtt1ball
        '
        Me.txtt1ball.Location = New System.Drawing.Point(11, 42)
        Me.txtt1ball.Name = "txtt1ball"
        Me.txtt1ball.Size = New System.Drawing.Size(172, 20)
        Me.txtt1ball.TabIndex = 614
        Me.txtt1ball.Text = "Andman  Nicobar"
        '
        'cmdt1lineupball
        '
        Me.cmdt1lineupball.Location = New System.Drawing.Point(11, 534)
        Me.cmdt1lineupball.Name = "cmdt1lineupball"
        Me.cmdt1lineupball.Size = New System.Drawing.Size(172, 28)
        Me.cmdt1lineupball.TabIndex = 589
        Me.cmdt1lineupball.Text = "Team1 Linup"
        Me.cmdt1lineupball.UseVisualStyleBackColor = True
        '
        'dgvt1ball
        '
        Me.dgvt1ball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvt1ball.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27})
        Me.dgvt1ball.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvt1ball.Location = New System.Drawing.Point(11, 65)
        Me.dgvt1ball.Name = "dgvt1ball"
        Me.dgvt1ball.RowTemplate.Height = 18
        Me.dgvt1ball.Size = New System.Drawing.Size(172, 468)
        Me.dgvt1ball.TabIndex = 587
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 120
        '
        'GroupBox21
        '
        Me.GroupBox21.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox21.Controls.Add(Me.cmdteam2outball)
        Me.GroupBox21.Controls.Add(Me.cmdteam1outball)
        Me.GroupBox21.Controls.Add(Me.txtt2outball)
        Me.GroupBox21.Controls.Add(Me.txtt2inball)
        Me.GroupBox21.Controls.Add(Me.cmdt2inoutball)
        Me.GroupBox21.Controls.Add(Me.txtt1outball)
        Me.GroupBox21.Controls.Add(Me.txtt1inball)
        Me.GroupBox21.Controls.Add(Me.cmdteam1inball)
        Me.GroupBox21.Controls.Add(Me.cmdteam2inball)
        Me.GroupBox21.Controls.Add(Me.cmdt1inoutball)
        Me.GroupBox21.Location = New System.Drawing.Point(447, 226)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(247, 111)
        Me.GroupBox21.TabIndex = 629
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Player IN/OUT"
        '
        'cmdteam2outball
        '
        Me.cmdteam2outball.Location = New System.Drawing.Point(150, 61)
        Me.cmdteam2outball.Name = "cmdteam2outball"
        Me.cmdteam2outball.Size = New System.Drawing.Size(40, 22)
        Me.cmdteam2outball.TabIndex = 606
        Me.cmdteam2outball.Text = "OUT"
        Me.cmdteam2outball.UseVisualStyleBackColor = True
        '
        'cmdteam1outball
        '
        Me.cmdteam1outball.Location = New System.Drawing.Point(152, 11)
        Me.cmdteam1outball.Name = "cmdteam1outball"
        Me.cmdteam1outball.Size = New System.Drawing.Size(40, 22)
        Me.cmdteam1outball.TabIndex = 605
        Me.cmdteam1outball.Text = "OUT"
        Me.cmdteam1outball.UseVisualStyleBackColor = True
        '
        'txtt2outball
        '
        Me.txtt2outball.Location = New System.Drawing.Point(3, 63)
        Me.txtt2outball.Name = "txtt2outball"
        Me.txtt2outball.Size = New System.Drawing.Size(145, 20)
        Me.txtt2outball.TabIndex = 602
        Me.txtt2outball.Text = "39 Jagat Sharma"
        '
        'txtt2inball
        '
        Me.txtt2inball.Location = New System.Drawing.Point(3, 86)
        Me.txtt2inball.Name = "txtt2inball"
        Me.txtt2inball.Size = New System.Drawing.Size(145, 20)
        Me.txtt2inball.TabIndex = 601
        Me.txtt2inball.Text = "36 Abhishek Chatterjee"
        '
        'cmdt2inoutball
        '
        Me.cmdt2inoutball.Location = New System.Drawing.Point(191, 59)
        Me.cmdt2inoutball.Name = "cmdt2inoutball"
        Me.cmdt2inoutball.Size = New System.Drawing.Size(52, 48)
        Me.cmdt2inoutball.TabIndex = 600
        Me.cmdt2inoutball.Text = "Team 2"
        Me.cmdt2inoutball.UseVisualStyleBackColor = True
        '
        'txtt1outball
        '
        Me.txtt1outball.Location = New System.Drawing.Point(4, 13)
        Me.txtt1outball.Name = "txtt1outball"
        Me.txtt1outball.Size = New System.Drawing.Size(145, 20)
        Me.txtt1outball.TabIndex = 596
        Me.txtt1outball.Text = "26 Manoj Thapa"
        '
        'txtt1inball
        '
        Me.txtt1inball.Location = New System.Drawing.Point(3, 35)
        Me.txtt1inball.Name = "txtt1inball"
        Me.txtt1inball.Size = New System.Drawing.Size(145, 20)
        Me.txtt1inball.TabIndex = 595
        Me.txtt1inball.Text = "18 Vatsal Reshamwala"
        '
        'cmdteam1inball
        '
        Me.cmdteam1inball.Location = New System.Drawing.Point(152, 33)
        Me.cmdteam1inball.Name = "cmdteam1inball"
        Me.cmdteam1inball.Size = New System.Drawing.Size(40, 22)
        Me.cmdteam1inball.TabIndex = 603
        Me.cmdteam1inball.Text = "IN"
        Me.cmdteam1inball.UseVisualStyleBackColor = True
        '
        'cmdteam2inball
        '
        Me.cmdteam2inball.Location = New System.Drawing.Point(150, 85)
        Me.cmdteam2inball.Name = "cmdteam2inball"
        Me.cmdteam2inball.Size = New System.Drawing.Size(40, 22)
        Me.cmdteam2inball.TabIndex = 604
        Me.cmdteam2inball.Text = "IN"
        Me.cmdteam2inball.UseVisualStyleBackColor = True
        '
        'cmdt1inoutball
        '
        Me.cmdt1inoutball.Location = New System.Drawing.Point(191, 11)
        Me.cmdt1inoutball.Name = "cmdt1inoutball"
        Me.cmdt1inoutball.Size = New System.Drawing.Size(52, 48)
        Me.cmdt1inoutball.TabIndex = 590
        Me.cmdt1inoutball.Text = "Team 1"
        Me.cmdt1inoutball.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox16.Controls.Add(Me.cmdscoreupdateball)
        Me.GroupBox16.Controls.Add(Me.chkRunner)
        Me.GroupBox16.Controls.Add(Me.cmdscoreclockrunner)
        Me.GroupBox16.Controls.Add(Me.Button1)
        Me.GroupBox16.Controls.Add(Me.cmdadjustsecball)
        Me.GroupBox16.Controls.Add(Me.cmbputsecondball)
        Me.GroupBox16.Controls.Add(Me.cmbputminuteball)
        Me.GroupBox16.Controls.Add(Me.cmdadjustminball)
        Me.GroupBox16.Controls.Add(Me.cmbinfoball)
        Me.GroupBox16.Controls.Add(Me.cmdscorewithinfo)
        Me.GroupBox16.Controls.Add(Me.cmdscorewithclock)
        Me.GroupBox16.Controls.Add(Me.cmdadd1t2ball)
        Me.GroupBox16.Controls.Add(Me.cmdadd1t1ball)
        Me.GroupBox16.Controls.Add(Me.cmdt2colorball)
        Me.GroupBox16.Controls.Add(Me.cmdt1colorball)
        Me.GroupBox16.Controls.Add(Me.Label45)
        Me.GroupBox16.Controls.Add(Me.cmbhalfball)
        Me.GroupBox16.Controls.Add(Me.GroupBox15)
        Me.GroupBox16.Controls.Add(Me.pict2logoball)
        Me.GroupBox16.Controls.Add(Me.pict1logoball)
        Me.GroupBox16.Controls.Add(Me.txtt2gball)
        Me.GroupBox16.Controls.Add(Me.txtt1gball)
        Me.GroupBox16.Controls.Add(Me.cmdresetclockball)
        Me.GroupBox16.Controls.Add(Me.txtsecball)
        Me.GroupBox16.Controls.Add(Me.txtminball)
        Me.GroupBox16.Controls.Add(Me.cmdstartclockball)
        Me.GroupBox16.Controls.Add(Me.cmdpauseclockball)
        Me.GroupBox16.Controls.Add(Me.cmdscoreball)
        Me.GroupBox16.Location = New System.Drawing.Point(447, 46)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(640, 174)
        Me.GroupBox16.TabIndex = 625
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Score"
        '
        'cmdscoreupdateball
        '
        Me.cmdscoreupdateball.Location = New System.Drawing.Point(183, 86)
        Me.cmdscoreupdateball.Name = "cmdscoreupdateball"
        Me.cmdscoreupdateball.Size = New System.Drawing.Size(186, 22)
        Me.cmdscoreupdateball.TabIndex = 1234
        Me.cmdscoreupdateball.Text = "Score Update"
        Me.cmdscoreupdateball.UseVisualStyleBackColor = True
        '
        'chkRunner
        '
        Me.chkRunner.AutoSize = True
        Me.chkRunner.Location = New System.Drawing.Point(174, 42)
        Me.chkRunner.Name = "chkRunner"
        Me.chkRunner.Size = New System.Drawing.Size(61, 17)
        Me.chkRunner.TabIndex = 1233
        Me.chkRunner.Text = "Runner"
        Me.chkRunner.UseVisualStyleBackColor = True
        '
        'cmdscoreclockrunner
        '
        Me.cmdscoreclockrunner.Location = New System.Drawing.Point(439, 20)
        Me.cmdscoreclockrunner.Name = "cmdscoreclockrunner"
        Me.cmdscoreclockrunner.Size = New System.Drawing.Size(52, 63)
        Me.cmdscoreclockrunner.TabIndex = 1232
        Me.cmdscoreclockrunner.Text = "Score clock Runner"
        Me.cmdscoreclockrunner.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 63)
        Me.Button1.TabIndex = 1231
        Me.Button1.Text = "Score clock Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdadjustsecball
        '
        Me.cmdadjustsecball.Location = New System.Drawing.Point(238, 123)
        Me.cmdadjustsecball.Name = "cmdadjustsecball"
        Me.cmdadjustsecball.Size = New System.Drawing.Size(36, 24)
        Me.cmdadjustsecball.TabIndex = 1224
        Me.cmdadjustsecball.Text = "Set"
        Me.cmdadjustsecball.UseVisualStyleBackColor = True
        '
        'cmbputsecondball
        '
        Me.cmbputsecondball.FormattingEnabled = True
        Me.cmbputsecondball.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cmbputsecondball.Location = New System.Drawing.Point(238, 149)
        Me.cmbputsecondball.Name = "cmbputsecondball"
        Me.cmbputsecondball.Size = New System.Drawing.Size(40, 21)
        Me.cmbputsecondball.TabIndex = 1223
        Me.cmbputsecondball.Text = "00"
        '
        'cmbputminuteball
        '
        Me.cmbputminuteball.FormattingEnabled = True
        Me.cmbputminuteball.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cmbputminuteball.Location = New System.Drawing.Point(189, 148)
        Me.cmbputminuteball.Name = "cmbputminuteball"
        Me.cmbputminuteball.Size = New System.Drawing.Size(43, 21)
        Me.cmbputminuteball.TabIndex = 1222
        Me.cmbputminuteball.Text = "25"
        '
        'cmdadjustminball
        '
        Me.cmdadjustminball.Location = New System.Drawing.Point(188, 123)
        Me.cmdadjustminball.Name = "cmdadjustminball"
        Me.cmdadjustminball.Size = New System.Drawing.Size(36, 24)
        Me.cmdadjustminball.TabIndex = 1221
        Me.cmdadjustminball.Text = "Set"
        Me.cmdadjustminball.UseVisualStyleBackColor = True
        '
        'cmbinfoball
        '
        Me.cmbinfoball.FormattingEnabled = True
        Me.cmbinfoball.Items.AddRange(New Object() {"Penalty", "Time Out", "Highlights", "Expedite", "Deuce", "Advantage", "Double Hit", "Game Point", "Match Point", "Winner", "Advantage", "", "Advantage Server ", "Ad-In", "Advantage Receiver", "Ad-Out", "Tie-Break", "New ball", "Double Faults", "Break Point", "2nd Break Point", "Set Point", "3Rd Gold Medal point", "1 Challenge Remaining", "", "Round 1", "Round 2", "Round 3", "Round 4"})
        Me.cmbinfoball.Location = New System.Drawing.Point(36, 108)
        Me.cmbinfoball.Name = "cmbinfoball"
        Me.cmbinfoball.Size = New System.Drawing.Size(93, 21)
        Me.cmbinfoball.TabIndex = 1220
        Me.cmbinfoball.Text = "Round 1"
        '
        'cmdscorewithinfo
        '
        Me.cmdscorewithinfo.Location = New System.Drawing.Point(338, 20)
        Me.cmdscorewithinfo.Name = "cmdscorewithinfo"
        Me.cmdscorewithinfo.Size = New System.Drawing.Size(45, 63)
        Me.cmdscorewithinfo.TabIndex = 1219
        Me.cmdscorewithinfo.Text = "Score+Info"
        Me.cmdscorewithinfo.UseVisualStyleBackColor = True
        '
        'cmdscorewithclock
        '
        Me.cmdscorewithclock.Location = New System.Drawing.Point(290, 20)
        Me.cmdscorewithclock.Name = "cmdscorewithclock"
        Me.cmdscorewithclock.Size = New System.Drawing.Size(48, 63)
        Me.cmdscorewithclock.TabIndex = 1218
        Me.cmdscorewithclock.Text = "Score+Clock"
        Me.cmdscorewithclock.UseVisualStyleBackColor = True
        '
        'cmdadd1t2ball
        '
        Me.cmdadd1t2ball.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdadd1t2ball.Location = New System.Drawing.Point(127, 61)
        Me.cmdadd1t2ball.Name = "cmdadd1t2ball"
        Me.cmdadd1t2ball.Size = New System.Drawing.Size(47, 22)
        Me.cmdadd1t2ball.TabIndex = 1216
        Me.cmdadd1t2ball.Text = "+1"
        Me.cmdadd1t2ball.UseVisualStyleBackColor = True
        '
        'cmdadd1t1ball
        '
        Me.cmdadd1t1ball.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdadd1t1ball.Location = New System.Drawing.Point(126, 40)
        Me.cmdadd1t1ball.Name = "cmdadd1t1ball"
        Me.cmdadd1t1ball.Size = New System.Drawing.Size(48, 21)
        Me.cmdadd1t1ball.TabIndex = 607
        Me.cmdadd1t1ball.Text = "+1"
        Me.cmdadd1t1ball.UseVisualStyleBackColor = True
        '
        'cmdt2colorball
        '
        Me.cmdt2colorball.BackColor = System.Drawing.Color.Blue
        Me.cmdt2colorball.Location = New System.Drawing.Point(91, 63)
        Me.cmdt2colorball.Name = "cmdt2colorball"
        Me.cmdt2colorball.Size = New System.Drawing.Size(30, 18)
        Me.cmdt2colorball.TabIndex = 1214
        Me.cmdt2colorball.UseVisualStyleBackColor = False
        '
        'cmdt1colorball
        '
        Me.cmdt1colorball.BackColor = System.Drawing.Color.Red
        Me.cmdt1colorball.Location = New System.Drawing.Point(90, 43)
        Me.cmdt1colorball.Name = "cmdt1colorball"
        Me.cmdt1colorball.Size = New System.Drawing.Size(30, 18)
        Me.cmdt1colorball.TabIndex = 1213
        Me.cmdt1colorball.UseVisualStyleBackColor = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(9, 113)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(25, 13)
        Me.Label45.TabIndex = 1208
        Me.Label45.Text = "Info"
        '
        'cmbhalfball
        '
        Me.cmbhalfball.FormattingEnabled = True
        Me.cmbhalfball.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "Ext", "1st(1)", "1st(2)", "2nd(1)", "2nd(1)"})
        Me.cmbhalfball.Location = New System.Drawing.Point(88, 86)
        Me.cmbhalfball.Name = "cmbhalfball"
        Me.cmbhalfball.Size = New System.Drawing.Size(60, 21)
        Me.cmbhalfball.TabIndex = 626
        Me.cmbhalfball.Text = "1st(1)"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.rdodowncounterball)
        Me.GroupBox15.Controls.Add(Me.rdoupcounterball)
        Me.GroupBox15.Location = New System.Drawing.Point(7, 134)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(114, 33)
        Me.GroupBox15.TabIndex = 624
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = " "
        '
        'rdodowncounterball
        '
        Me.rdodowncounterball.AutoSize = True
        Me.rdodowncounterball.Checked = True
        Me.rdodowncounterball.Location = New System.Drawing.Point(53, 10)
        Me.rdodowncounterball.Name = "rdodowncounterball"
        Me.rdodowncounterball.Size = New System.Drawing.Size(53, 17)
        Me.rdodowncounterball.TabIndex = 1
        Me.rdodowncounterball.TabStop = True
        Me.rdodowncounterball.Text = "Down"
        Me.rdodowncounterball.UseVisualStyleBackColor = True
        '
        'rdoupcounterball
        '
        Me.rdoupcounterball.AutoSize = True
        Me.rdoupcounterball.Location = New System.Drawing.Point(6, 10)
        Me.rdoupcounterball.Name = "rdoupcounterball"
        Me.rdoupcounterball.Size = New System.Drawing.Size(39, 17)
        Me.rdoupcounterball.TabIndex = 0
        Me.rdoupcounterball.Text = "Up"
        Me.rdoupcounterball.UseVisualStyleBackColor = True
        '
        'pict2logoball
        '
        Me.pict2logoball.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pict2logoball.ImageLocation = "C:\casparcg/ng2022/data\country\Assam.png"
        Me.pict2logoball.Location = New System.Drawing.Point(3, 64)
        Me.pict2logoball.Name = "pict2logoball"
        Me.pict2logoball.Size = New System.Drawing.Size(38, 22)
        Me.pict2logoball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict2logoball.TabIndex = 619
        Me.pict2logoball.TabStop = False
        '
        'pict1logoball
        '
        Me.pict1logoball.BackColor = System.Drawing.SystemColors.Control
        Me.pict1logoball.ImageLocation = "C:\casparcg/ng2022/data\country\Andaman Nicobar.png"
        Me.pict1logoball.Location = New System.Drawing.Point(3, 42)
        Me.pict1logoball.Name = "pict1logoball"
        Me.pict1logoball.Size = New System.Drawing.Size(38, 20)
        Me.pict1logoball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict1logoball.TabIndex = 618
        Me.pict1logoball.TabStop = False
        '
        'txtt2gball
        '
        Me.txtt2gball.Location = New System.Drawing.Point(48, 64)
        Me.txtt2gball.Name = "txtt2gball"
        Me.txtt2gball.Size = New System.Drawing.Size(38, 20)
        Me.txtt2gball.TabIndex = 617
        Me.txtt2gball.Text = "12"
        '
        'txtt1gball
        '
        Me.txtt1gball.Location = New System.Drawing.Point(48, 43)
        Me.txtt1gball.Name = "txtt1gball"
        Me.txtt1gball.Size = New System.Drawing.Size(38, 20)
        Me.txtt1gball.TabIndex = 615
        Me.txtt1gball.Text = "15"
        '
        'cmdresetclockball
        '
        Me.cmdresetclockball.Location = New System.Drawing.Point(103, 14)
        Me.cmdresetclockball.Name = "cmdresetclockball"
        Me.cmdresetclockball.Size = New System.Drawing.Size(47, 23)
        Me.cmdresetclockball.TabIndex = 611
        Me.cmdresetclockball.Text = "Reset"
        Me.cmdresetclockball.UseVisualStyleBackColor = True
        '
        'txtsecball
        '
        Me.txtsecball.Location = New System.Drawing.Point(48, 87)
        Me.txtsecball.Name = "txtsecball"
        Me.txtsecball.Size = New System.Drawing.Size(38, 20)
        Me.txtsecball.TabIndex = 610
        Me.txtsecball.Text = "00"
        '
        'txtminball
        '
        Me.txtminball.Location = New System.Drawing.Point(3, 87)
        Me.txtminball.Name = "txtminball"
        Me.txtminball.Size = New System.Drawing.Size(39, 20)
        Me.txtminball.TabIndex = 609
        Me.txtminball.Text = "09"
        '
        'cmdstartclockball
        '
        Me.cmdstartclockball.Location = New System.Drawing.Point(3, 14)
        Me.cmdstartclockball.Name = "cmdstartclockball"
        Me.cmdstartclockball.Size = New System.Drawing.Size(39, 23)
        Me.cmdstartclockball.TabIndex = 607
        Me.cmdstartclockball.Text = "Start"
        Me.cmdstartclockball.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdstartclockball.UseVisualStyleBackColor = True
        '
        'cmdpauseclockball
        '
        Me.cmdpauseclockball.Location = New System.Drawing.Point(48, 14)
        Me.cmdpauseclockball.Name = "cmdpauseclockball"
        Me.cmdpauseclockball.Size = New System.Drawing.Size(49, 23)
        Me.cmdpauseclockball.TabIndex = 606
        Me.cmdpauseclockball.Text = "Pause"
        Me.cmdpauseclockball.UseVisualStyleBackColor = True
        '
        'cmdscoreball
        '
        Me.cmdscoreball.Location = New System.Drawing.Point(241, 42)
        Me.cmdscoreball.Name = "cmdscoreball"
        Me.cmdscoreball.Size = New System.Drawing.Size(45, 40)
        Me.cmdscoreball.TabIndex = 605
        Me.cmdscoreball.Text = "Only Score"
        Me.cmdscoreball.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Ball)
        Me.TabControl1.Location = New System.Drawing.Point(6, 123)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1112, 626)
        Me.TabControl1.TabIndex = 0
        '
        'eventlogo
        '
        Me.eventlogo.BackColor = System.Drawing.SystemColors.Highlight
        Me.eventlogo.ImageLocation = "C:/casparcg/ng2022/data/event logo/ammu_logo.png"
        Me.eventlogo.Location = New System.Drawing.Point(836, 38)
        Me.eventlogo.Name = "eventlogo"
        Me.eventlogo.Size = New System.Drawing.Size(24, 17)
        Me.eventlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eventlogo.TabIndex = 1168
        Me.eventlogo.TabStop = False
        '
        'gamelogo
        '
        Me.gamelogo.BackColor = System.Drawing.SystemColors.Highlight
        Me.gamelogo.ImageLocation = "C:/casparcg/ng2022/data/games logo/kh.png"
        Me.gamelogo.Location = New System.Drawing.Point(804, 36)
        Me.gamelogo.Name = "gamelogo"
        Me.gamelogo.Size = New System.Drawing.Size(22, 19)
        Me.gamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gamelogo.TabIndex = 1166
        Me.gamelogo.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox8.Controls.Add(Me.TabControl1)
        Me.GroupBox8.Controls.Add(Me.cmdstopgym)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.cmblayergames)
        Me.GroupBox8.Controls.Add(Me.GroupBox3)
        Me.GroupBox8.Controls.Add(Me.cmbgames)
        Me.GroupBox8.Controls.Add(Me.eventlogo)
        Me.GroupBox8.Controls.Add(Me.gamelogo)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1125, 754)
        Me.GroupBox8.TabIndex = 1312
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Khokho"
        '
        'ucKhoKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.GroupBox8)
        Me.Name = "ucKhoKho"
        Me.Size = New System.Drawing.Size(1137, 776)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Ball.ResumeLayout(False)
        Me.Ball.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.gbsetscoreball.ResumeLayout(False)
        CType(Me.dgvsetscoreball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvt2ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvt1ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.pict2logoball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict1logoball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.eventlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents eventlogo As System.Windows.Forms.PictureBox
    Friend WithEvents gamelogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmblayergames As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdstopgym As System.Windows.Forms.Button
    Friend WithEvents cmdeventid As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbgames As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubHeader As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHeader As System.Windows.Forms.ComboBox
    Friend WithEvents tmrtimeonform As System.Windows.Forms.Timer
    Friend WithEvents tmrtimeupdateontemplate As System.Windows.Forms.Timer
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Ball As System.Windows.Forms.TabPage
    Friend WithEvents gbsetscoreball As System.Windows.Forms.GroupBox
    Friend WithEvents cmdscoreresetball As System.Windows.Forms.Button
    Friend WithEvents cmdshowsetscoreball As System.Windows.Forms.Button
    Friend WithEvents dgvsetscoreball As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbgoalsummary As System.Windows.Forms.ComboBox
    Friend WithEvents cmdgoalSummary As System.Windows.Forms.Button
    Friend WithEvents cmdtteamridt2ball As System.Windows.Forms.Button
    Friend WithEvents cmdtteamridt1ball As System.Windows.Forms.Button
    Friend WithEvents cmdplayeridt2ball As System.Windows.Forms.Button
    Friend WithEvents cmdplayeridt1ball As System.Windows.Forms.Button
    Friend WithEvents lblfilenamet2ball As System.Windows.Forms.Label
    Friend WithEvents lblfilenamet1ball As System.Windows.Forms.Label
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdvsball As System.Windows.Forms.Button
    Friend WithEvents dgvt2ball As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmdt2gball As System.Windows.Forms.Button
    Friend WithEvents cmdt2rball As System.Windows.Forms.Button
    Friend WithEvents cmdt2yball As System.Windows.Forms.Button
    Friend WithEvents cmdt2lineupball As System.Windows.Forms.Button
    Friend WithEvents cmdt1gball As System.Windows.Forms.Button
    Friend WithEvents cmdt1rball As System.Windows.Forms.Button
    Friend WithEvents txtt2ball As System.Windows.Forms.TextBox
    Friend WithEvents cmdt1yball As System.Windows.Forms.Button
    Friend WithEvents txtt1ball As System.Windows.Forms.TextBox
    Friend WithEvents cmdt1lineupball As System.Windows.Forms.Button
    Friend WithEvents dgvt1ball As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdteam2outball As System.Windows.Forms.Button
    Friend WithEvents cmdteam1outball As System.Windows.Forms.Button
    Friend WithEvents txtt2outball As System.Windows.Forms.TextBox
    Friend WithEvents txtt2inball As System.Windows.Forms.TextBox
    Friend WithEvents cmdt2inoutball As System.Windows.Forms.Button
    Friend WithEvents txtt1outball As System.Windows.Forms.TextBox
    Friend WithEvents txtt1inball As System.Windows.Forms.TextBox
    Friend WithEvents cmdteam1inball As System.Windows.Forms.Button
    Friend WithEvents cmdteam2inball As System.Windows.Forms.Button
    Friend WithEvents cmdt1inoutball As System.Windows.Forms.Button
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdadjustsecball As System.Windows.Forms.Button
    Friend WithEvents cmbputsecondball As System.Windows.Forms.ComboBox
    Friend WithEvents cmbputminuteball As System.Windows.Forms.ComboBox
    Friend WithEvents cmdadjustminball As System.Windows.Forms.Button
    Friend WithEvents cmbinfoball As System.Windows.Forms.ComboBox
    Friend WithEvents cmdscorewithinfo As System.Windows.Forms.Button
    Friend WithEvents cmdscorewithclock As System.Windows.Forms.Button
    Friend WithEvents cmdadd1t2ball As System.Windows.Forms.Button
    Friend WithEvents cmdadd1t1ball As System.Windows.Forms.Button
    Friend WithEvents cmdt2colorball As System.Windows.Forms.Button
    Friend WithEvents cmdt1colorball As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cmbhalfball As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents rdodowncounterball As System.Windows.Forms.RadioButton
    Friend WithEvents rdoupcounterball As System.Windows.Forms.RadioButton
    Friend WithEvents pict2logoball As System.Windows.Forms.PictureBox
    Friend WithEvents pict1logoball As System.Windows.Forms.PictureBox
    Friend WithEvents txtt2gball As System.Windows.Forms.TextBox
    Friend WithEvents txtt1gball As System.Windows.Forms.TextBox
    Friend WithEvents cmdresetclockball As System.Windows.Forms.Button
    Friend WithEvents txtsecball As System.Windows.Forms.TextBox
    Friend WithEvents txtminball As System.Windows.Forms.TextBox
    Friend WithEvents cmdstartclockball As System.Windows.Forms.Button
    Friend WithEvents cmdpauseclockball As System.Windows.Forms.Button
    Friend WithEvents cmdscoreball As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdgrouptosemifinalball As System.Windows.Forms.Button
    Friend WithEvents cmdgroupresultball As System.Windows.Forms.Button
    Friend WithEvents cmdgroupresul2tball As System.Windows.Forms.Button
    Friend WithEvents cmdmatchstatics As System.Windows.Forms.Button
    Friend WithEvents cmdgoalsummarywithtime As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents osd2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents cmduprowt1ball As Button
    Friend WithEvents cmdremoverowt1ball As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdnewt1ball As ToolStripButton
    Friend WithEvents cmdopent1ball As ToolStripButton
    Friend WithEvents cmdsavet1ball As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents cmddownrowt1ball As Button
    Friend WithEvents cmdaddrowt1ball As Button
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents cmduprowt2ball As Button
    Friend WithEvents cmdremoverowt2ball As Button
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents cmdnewt2ball As ToolStripButton
    Friend WithEvents cmdopent2ball As ToolStripButton
    Friend WithEvents cmdsavet2ball As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents cmddownrowt2ball As Button
    Friend WithEvents cmdaddrowt2ball As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdscoreclockrunner As Button
    Friend WithEvents chkRunner As CheckBox
    Friend WithEvents cmdscoreupdateball As Button
End Class
