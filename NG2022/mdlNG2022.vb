Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Module mdlNG2022
    Public client As New WebClient()

    Public CasparCGDataCollection As New Svt.Caspar.CasparCGDataCollection
    Public WithEvents CasparDevice As New Svt.Caspar.CasparDevice
    Public g_int_ChannelNumber = 1
    Public ChannelName As String
    'Declaring some constants to use with the SendMessage API
    Public Const WM_SYSCOMMAND As Integer = 274
    Public Const SC_MAXIMIZE As Integer = 61488

    Public screenConsumres = (New Object() {
    "Screen consumer [1|PAL]",
     "Screen consumer [2|PAL]",
     "Screen consumer [3|PAL]",
     "Screen consumer [4|PAL]",
     "Screen consumer [1|1080i5000]",
     "Screen consumer [2|1080i5000]",
     "Screen consumer [3|1080i5000]",
     "Screen consumer [4|1080i5000]",
     "Screen consumer [1|NTSC]",
     "Screen consumer [2|NTSC]",
     "Screen consumer [600|PAL]",
     "Screen consumer [600|1080i5000]",
     "Screen consumer [1|1080i5994]",
     "Screen consumer [1|1080i6000]",
     "Screen consumer [1|1080p2398]",
     "Screen consumer [1|1080p2400]",
     "Screen consumer [1|1080p2500]",
     "Screen consumer [1|1080p2997]",
     "Screen consumer [1|1080p3000]",
     "Screen consumer [1|1080p5000]",
     "Screen consumer [1|1080p5994]",
     "Screen consumer [1|1080p6000]",
     "Screen consumer [1|1556p2398]",
     "Screen consumer [1|1556p2400]",
     "Screen consumer [1|1556p2500]",
     "Screen consumer [1|2160p2398]",
     "Screen consumer [1|2160p2400]",
     "Screen consumer [1|2160p2500]",
     "Screen consumer [1| 2160p2997]",
     "Screen consumer [1|2160p3000]",
     "Screen consumer [1|576p2500]",
     "Screen consumer [1|720p2398]",
     "Screen consumer [1|720p2400]",
     "Screen consumer [1|720p2500]",
     "Screen consumer [1|720p2997]",
     "Screen consumer [1|720p3000]",
     "Screen consumer [1|720p5000]",
     "Screen consumer [1|720p5994]",
     "Screen consumer [1|720p6000]",
     "Screen consumer [1|dci2160p2398]",
     "Screen consumer [1|dci2160p2400]",
     "Screen consumer [1|dci2160p2500]",
     "Screen consumer [1|dci1080p2398]",
     "Screen consumer [1|dci1080p2400]",
     "Screen consumer [1|dci1080p2500]"
    })

    Public halfText = (New Object() {
        "R1/3",
        "R2/3",
        "R3/3",
   "1st",
   "2nd",
   "3rd",
   "4th",
   "Ext",
    "Q1",
    "Q2",
    "Q3",
    "Q4"
    })
    Public headerText = New Object() {
     "Aquatics Diving", "Aquatics Marathon Swimming", "Aquatics Synchrosed Swimming", "Aquatics Water Polo", "Athletics - Marathon & Race Walks", "Athletics", "Aquatics Swimming", "Archery", "Badminton", "Beach Volleyball", "Basketball", "Rowing", "Canoe Slalom", "Kickboxing", "Canoe Sprint", "Cycling Mountain Bike", "Cycling BMX", "Boxing", "Cycling Road Race & Time Trial", "Cycling Track", "Equestrian", "Gymnastics Artistic", "Gymnastics Rhythmic", "Gymnastics Trampoline", "Fencing", "Football", "Judo", "Handball", "Modern Pentathlon", "Sailing", "Shooting", "Table Tennis", "Taekwondo", "Rowing", "Triathlon", "Tennis", "Volleyball", "Wrestling", "Weightlifting", "", "Hockey", "AR Archery", "Men’s Individual", "Women’s Individual", "", "", "Men’s Team", "Men’s 100m", "AT Athletics", "Women’s Team", "Men’s 800m", "Men’s 200m", "Men’s 400m", "Men’s 5000m", "Men’s 10000m", "Men’s 1500m", "Men’s 400m Hurdles", "Men’s 3000m Steeplechase", "Men’s 110m Hurdles", "Men’s High Jump", "Men’s 4x400m Relay", "Men’s Long Jump", "Men’s 4x100m Relay", "Men’s Triple Jump", "Men’s Pole Vault", "Men’s Discus", "Men’s Hammer", "Men’s Javelin", "", "Decathlon", "Men’s Shot Put", "Men’s 20km Race Walk", "Men’s 50km Race Walk", "Women’s 200m", "Men’s Marathon", "Women’s 400m", "Women’s 800m", "Women’s 1500m", "Women’s 10000m", "Women’s 100m", "Women’s 5000m", "Women’s 100m Hurdles", "Women’s 3000m Steeplechase", "Women’s 400m Hurdles", "Women’s 4x100m Relay", "Women’s High Jump", "Women’s Pole Vault", "Women’s Triple Jump", "Women’s 4x400m Relay", "Women’s Shot Put", "Women’s Long Jump", "Women’s Discus", "Women’s Javelin", "Women’s Hammer", "Women’s Marathon", "Heptathlon", "BD Badminton", "Women’s 20km Race Walk", "Men’s Singles", "", "Men’s Doubles", "Women’s Singles", "Mixed Doubles", "Women’s Doubles", "", "BK Basketball ", "Women’s Basketball", "BV Beach Volleyball ", "Men’s Beach Volleyball ", "Men’s Basketball ", "Women’s Beach Volleyball", "", "Men’s Light Fly 49kg", "BX Boxing", "Men’s Fly 52kg", "Men’s Bantam 56kg", "Men’s Welter 69kg", "Men’s Light Welter 64kg", "Men’s Light Heavy 81kg", "Men’s Middle 75kg", "Men’s Super Heavy +91kg", "Women’s Fly 51kg", "Men’s Heavy 91kg", "Women’s Light 60kg", "Women’s Middle 75kg", "", "Men’s Light 60kg", "CB BMX ", "Men’s BMX ", "Women’s BMX", "", "CF Canoe Sprint", "Men’s Kayak Double 200m", "Men’s Kayak Single 200m", "Men’s Kayak Double 1000m", "Men’s Canoe Single 200m", "Men’s Kayak Single 1000m", "Men’s Kayak Four 1000m", "Men’s Canoe Single 1000m", "Men’s Canoe Double 1000m", "Women’s Kayak Single 200m", "Women’s Kayak Single 500m", "", "Women’s Kayak Double 500m", "Men’s Mountain Bike ", "CM Mountain Bike ", "Women’s Kayak Four 500m", "Women’s Mountain Bike", "Men’s Road Race", "CR Cycling Road", "Men’s Individual Time Trial", "", "Women’s Road Race", "Women’s Individual Time Trial", "", "CS Canoe Slalom", "Men’s Canoe Single", "Women’s Kayak", "Men’s Kayak", "Men’s Canoe Double", "CT Cycling Track", "Men’s Keirin", "", "Men’s Omnium", "Men’s Team Pursuit", "Men’s Team Sprint", "Women’s Keirin", "Men’s Sprint", "Women’s Omnium", "Women’s Team Pursuit", "Women’s Team Sprint", "", "DV Diving", "Women’s Sprint", "Men’s 10m Platform", "Women’s 3m Springboard", "Men’s Synchronised 3m Springboard", "Men’s 3m Springboard", "Men’s Synchronised 10m Platform", "Women’s 10m Platform", "Women’s Synchronised 3m Springboard", "EQ Equestrian", "Women’s Synchronised 10m Platform", "Individual Eventing", "Individual Dressage", "Individual Jumping", "Team Dressage", "Team Eventing", "FB Football Men’s Football Women’s Football", "", "Team Jumping", "FE Fencing", "", "Men’s Individual Epee", "Men’s Individual Sabre", "Men’s Team Sabre", "Women’s Individual Epee", "Women’s Individual Foil", "Men’s Individual Foil", "Men’s Team Foil", "Women’s Individual Sabre", "Women’s Team Foil", "Women’s Team Epee", "GA Artistic Gymnastics", "Men’s Qualification", "", "Men’s Team Final", "Men’s All-Around Final", "Men’s Floor Exercise Final", "Men’s Parallel Bars Final", "Men’s Horizontal Bar Final", "Men’s Vault Final", "Men’s Pommel Horse Final", "Women’s Qualification", "Women’s All-Around Final", "Women’s Floor Exercise Final", "Women’s Team Final", "Women’s Vault Final", "Women’s Uneven Bars Final", "Women’s Beam Final", "GR Rhythmic Gymnastics ", "Individual All-Around", "Men’s Rings Final", "Group All-Around", "", "Men’s Trampoline ", "Women’s Trampoline", "", "HB Handball ", "Men’s Handball ", "Women’s Handball", "", "HO Hockey ", "Men’s Hockey ", "Women’s Hockey", "", "", "JU Judo", "Men’s -60kg", "Men’s -66kg", "GT ", "Men’s -81kg", "Men’s -100kg", "Men’s -90kg", "Men’s +100kg", "Women’s -48kg", "Women’s -52kg", "Men’s -73kg", "Women’s -63kg", "Women’s -70kg", "Women’s -78kg", "Women’s -57kg", "Women’s +78kg", "MP Modern Pentathlon", "Men’s Modern Pentathlon ", "Women’s Modern Pentathlon", "RO Rowing", "", "Men’s Double Sculls", "", "Men’s Single Sculls", "Men’s Quadruple Sculls", "Men’s Four", "Lightweight Men’s Double Sculls", "Lightweight Men’s Four", "Men’s Pair", "Men’s Eight", "Women’s Single Sculls", "Lightweight Women’s Double Sculls", "Women’s Pair", "Women’s Quadruple Sculls", "Women’s Double Sculls", "Women’s Eight", "SA Sailing", "Men’s Finn", "Men’s Laser", "Men’s 470", "", "Men’s 49er", "Men’s RS:X Windsurfer", "Women’s 470", "Women’s Laser Radial", "Women’s RS:X Windsurfer", "Women’s Elliott 6m", "SH Shooting", "Men’s Star", "Men’s 50m Rifle 3 Positions", "Men’s 50m Rifle Prone", "Men’s 50m Pistol", "Men’s 10m Air Rifle", "Men’s 10m Air Pistol", "Men’s 25m Rapid Fire Pistol", "Men’s Double Trap", "", "Men’s Trap", "Women’s 50m Rifle 3 Positions", "Women’s 25m Pistol", "Women’s 10m Air Rifle", "Women’s 10m Air Pistol", "Men’s Skeet", "Women’s Skeet", "SW Swimming", "Women’s Trap", "Men’s 50m Freestyle", "Men’s 100m Freestyle", "Men’s 400m Freestyle", "Men’s 200m Freestyle", "Men’s 1500m Freestyle", "", "Men’s 100m Butterfly", "Men’s 100m Breaststroke", "Men’s 200m Butterfly", "Men’s 200m Breaststroke", "Men’s 200m Individual Medley", "Men’s 100m Backstroke", "Men’s 400m Individual Medley", "Men’s 4x200m Freestyle Relay", "Men’s 4x100m Medley Relay", "Men’s 4x100m Freestyle Relay", "Women’s 50m Freestyle", "Men’s Marathon 10km", "Men’s 200m Backstroke", "Women’s 400m Freestyle", "Women’s 100m Freestyle", "Women’s 800m Freestyle", "Women’s 200m Freestyle", "Women’s 200m Butterfly", "Women’s 100m Breaststroke", "Women’s 100m Butterfly", "Women’s 200m Breaststroke", "Women’s 200m Individual Medley", "Women’s 200m Backstroke", "Women’s 400m Individual Medley", "Women’s 4x200m Freestyle Relay", "Women’s 4x100m Medley Relay", "Women’s 100m Backstroke", "Women’s 4x100m Freestyle Relay", "SY Synchronised Swimming Duets Teams", "", "TE Tennis", "Women’s Marathon 10km", "Women’s Singles", "Men’s Singles", "Women’s Doubles", "", "Mixed Doubles", "Men’s Doubles", "Men’s -58kg", "Men’s -80kg", "Men’s -68kg", "Men’s +80kg", "Women’s -49kg", "Women’s -67kg", "Women’s -57kg", "Women’s +67kg", "TR Triathlon Men’s ", "Triathlon Women’s Triathlon", "TT Table Tennis", "", "Men’s Singles", "TK Taekwondo", "Women’s Singles", "", "Men’s Team", "Women’s Team", "VO Volleyball ", "", "", "Men’s Volleyball ", "", "WL Weightlifting", "Women’s Volleyball", "Men’s 69kg", "Men’s 56kg", "Men’s 77kg", "Men’s 62kg", "Men’s 94kg", "Men’s 105kg", "Men’s +105kg", "Women’s 53kg", "Men’s 85kg", "Women’s 48kg", "Women’s 69kg", "Women’s 75kg", "Women’s 58kg", "Women’s +75kg", "WP Water Polo ", "Men’s Water Polo ", "Women’s Water Polo", "WR Wrestling", "Women’s 63kg", "Men’s Freestyle 55kg", "Men’s Freestyle 66kg", "Men’s Freestyle 60kg", "Men’s Freestyle 74kg", "Men’s Freestyle 84kg", "Men’s Freestyle 96kg", "", "Men’s Freestyle 120kg", "Men’s Greco-Roman 55kg", "Men’s Greco-Roman 74kg", "Men’s Greco-Roman 66kg", "Men’s Greco-Roman 96kg", "Men’s Greco-Roman 84kg", "Men’s Greco-Roman 120kg", "", "Men’s Greco-Roman 60kg", "", "Table Tennis", "Reliance 20th Asian Junior Table Tennis", "Table 1 - Round 3 (Morning Session)", "Table 1 - Round 3 (After noon Session)", "Table 1 - Round 1", "", "Table 1 - Round 1 (First Session)", "Table 1 - Round 2", "", "Men's Singles", "", "Women's Singles", "Team Event", "Men's Doubles", "Women's Doubles", "Round 1", "", "Round 2", "", "Round 3", "Leage Match", "Round 4", "Preliminary Match", "Round 5", "Pre Quarter Final", "Final", "Quarter Final", "Mixed Doubles", "Semi Final", "", "Junior Girls Team", "Cadet Girls Team", "Cadet Boys Team", "", "Junior Boys Team", "Junior Girls", "Cadet Girls", "Junior Boys", "", "Cadet Boys", "Junior Mixed Doubles", "", "Junior Boys Doubles", "Position 9-13", "Junior Girls Doubles", "Qualifying  - RD1", "Stage 1 Round 1", ""
    }
    Public gameName = New Object() {
 "Aquatics", "Archery", "Badminton", "Atheletics", "Black", "Boxing", "Cycling", "Basketball", "Gymnastics - Artistic", "Football", "Gymnastics - Rhythmic", "Gymnastics - Trampoline", "Handball", "Diving", "Judo", "Kabaddi", "NetBall", "Shooting", "Canoeing", "Kayaking", "Rowing", "Squash", "TableTennis", "Swimming", "Hockey", "Taekwondo", "Triathlon", "Volleyball", "Weight lift", "Wrestling", "Wushu", "Tennis", ""
    }
    Public infoball = New Object() {
       "W80", "W70", "M80", "M70", "Time Out", "Penalty", "Expedite", "Advantage", "Highlights", "Double Hit", "Game Point", "Match Point", "Deuce", "Winner", "Advantage", "Advantage Server ", "Ad-In", "Advantage Receiver", "", "Ad-Out", "Double Faults", "Break Point", "2nd Break Point", "New ball", "Set Point", "3Rd Gold Medal point", "1 Challenge Remaining", "Round 1", "Tie-Break", "Round 2", "Round 3", "", "Round 4"
    }
    Public subHeader = New Object() {
"Aquatics Marathon Swimming", "Aquatics Diving", "Aquatics Swimming", "Aquatics Synchrosed Swimming", "Aquatics Water Polo", "Archery", "Badminton", "Athletics - Marathon & Race Walks", "Basketball", "Beach Volleyball", "Canoe Slalom", "Cycling BMX", "Canoe Sprint", "Cycling Road Race & Time Trial", "Cycling Mountain Bike", "Cycling Track", "Equestrian", "Fencing", "Gymnastics Artistic", "Athletics", "Gymnastics Trampoline", "Football", "Gymnastics Rhythmic", "Hockey", "Handball", "Modern Pentathlon", "Boxing", "Sailing", "Table Tennis", "Rowing", "Shooting", "Taekwondo", "Triathlon", "Volleyball", "Judo", "Weightlifting", "Wrestling", "AR Archery", "", "Men’s Individual", "", "Men’s Team", "Women’s Team", "", "Tennis", "Women’s Individual", "AT Athletics", "Men’s 200m", "Men’s 100m", "Men’s 800m", "Men’s 400m", "Men’s 1500m", "Men’s 10000m", "Men’s 110m Hurdles", "Men’s 3000m Steeplechase", "Men’s 400m Hurdles", "Men’s 5000m", "Men’s 4x400m Relay", "Men’s 4x100m Relay", "Men’s High Jump", "Men’s Pole Vault", "Men’s Long Jump", "Men’s Triple Jump", "Men’s Discus", "Men’s Shot Put", "Men’s Javelin", "Decathlon", "Men’s Hammer", "Men’s 20km Race Walk", "Women’s 100m", "Men’s Marathon", "Men’s 50km Race Walk", "Women’s 400m", "Women’s 800m", "Women’s 200m", "Women’s 1500m", "", "Women’s 5000m", "Women’s 100m Hurdles", "Women’s 10000m", "Women’s 3000m Steeplechase", "Women’s High Jump", "Women’s 400m Hurdles", "Women’s 4x100m Relay", "Women’s 4x400m Relay", "Women’s Long Jump", "Women’s Pole Vault", "Women’s Discus", "Women’s Triple Jump", "Women’s Shot Put", "Women’s Javelin", "Women’s Hammer", "", "Women’s Marathon", "Women’s 20km Race Walk", "Men’s Singles", "Heptathlon", "BD Badminton", "Men’s Doubles", "Women’s Singles", "", "Mixed Doubles", "Women’s Doubles", "Men’s Basketball ", "Women’s Basketball", "Men’s Beach Volleyball ", "BK Basketball ", "BV Beach Volleyball ", "", "Women’s Beach Volleyball", "Men’s Light Fly 49kg", "Men’s Fly 52kg", "BX Boxing", "Men’s Bantam 56kg", "Men’s Light Welter 64kg", "Men’s Welter 69kg", "Men’s Light 60kg", "Men’s Middle 75kg", "Men’s Light Heavy 81kg", "Men’s Heavy 91kg", "Men’s Super Heavy +91kg", "Women’s Fly 51kg", "Women’s Middle 75kg", "", "Women’s Light 60kg", "Men’s BMX ", "Women’s BMX", "CB BMX ", "Men’s Kayak Single 200m", "", "CF Canoe Sprint", "Men’s Kayak Double 200m", "Men’s Kayak Single 1000m", "Men’s Kayak Double 1000m", "Men’s Kayak Four 1000m", "Men’s Canoe Double 1000m", "Women’s Kayak Single 200m", "Men’s Canoe Single 1000m", "Women’s Kayak Single 500m", "Women’s Kayak Four 500m", "Women’s Kayak Double 500m", "", "CM Mountain Bike ", "Men’s Canoe Single 200m", "", "Men’s Mountain Bike ", "Women’s Mountain Bike", "CR Cycling Road", "Men’s Road Race", "Women’s Road Race", "Women’s Individual Time Trial", "", "Men’s Individual Time Trial", "Men’s Canoe Single", "Men’s Kayak", "CS Canoe Slalom", "Men’s Canoe Double", "", "CT Cycling Track", "Men’s Keirin", "Women’s Kayak", "Men’s Team Pursuit", "Men’s Sprint", "Men’s Omnium", "Women’s Keirin", "Women’s Omnium", "Men’s Team Sprint", "Women’s Team Pursuit", "", "Women’s Team Sprint", "Men’s 3m Springboard", "Women’s Sprint", "DV Diving", "Men’s 10m Platform", "Women’s 3m Springboard", "Men’s Synchronised 3m Springboard", "Men’s Synchronised 10m Platform", "Women’s Synchronised 10m Platform", "Women’s Synchronised 3m Springboard", "", "Women’s 10m Platform", "Individual Dressage", "Individual Jumping", "Individual Eventing", "Team Dressage", "FB Football Men’s Football Women’s Football", "Team Jumping", "EQ Equestrian", "Team Eventing", "", "Men’s Individual Epee", "FE Fencing", "Men’s Team Foil", "Men’s Individual Foil", "Women’s Individual Epee", "Men’s Individual Sabre", "Men’s Team Sabre", "Women’s Individual Sabre", "Women’s Team Epee", "Women’s Individual Foil", "Men’s Qualification", "Women’s Team Foil", "GA Artistic Gymnastics", "Men’s Team Final", "Men’s All-Around Final", "Men’s Floor Exercise Final", "", "Men’s Vault Final", "Men’s Parallel Bars Final", "Men’s Horizontal Bar Final", "Men’s Pommel Horse Final", "Men’s Rings Final", "Women’s Qualification", "Women’s All-Around Final", "Women’s Floor Exercise Final", "Women’s Uneven Bars Final", "", "Women’s Team Final", "Women’s Vault Final", "GR Rhythmic Gymnastics ", "Women’s Beam Final", "", "Individual All-Around", "Men’s Trampoline ", "Group All-Around", "Women’s Trampoline", "GT ", "Men’s Handball ", "HB Handball ", "Women’s Handball", "", "HO Hockey ", "Men’s Hockey ", "", "", "JU Judo", "Women’s Hockey", "Men’s -73kg", "Men’s -81kg", "Men’s -100kg", "Men’s -66kg", "Men’s -60kg", "Men’s -90kg", "Women’s -48kg", "Women’s -57kg", "Women’s -52kg", "Men’s +100kg", "Women’s -63kg", "Women’s +78kg", "Women’s -78kg", "", "Women’s -70kg", "MP Modern Pentathlon", "Men’s Modern Pentathlon ", "Women’s Modern Pentathlon", "Lightweight Men’s Double Sculls", "RO Rowing", "Men’s Single Sculls", "", "Men’s Quadruple Sculls", "Men’s Four", "Men’s Double Sculls", "Men’s Pair", "Lightweight Men’s Four", "Lightweight Women’s Double Sculls", "Men’s Eight", "Women’s Single Sculls", "Women’s Quadruple Sculls", "Women’s Eight", "Women’s Double Sculls", "", "SA Sailing", "Women’s Pair", "Men’s 470", "Men’s Finn", "Men’s Laser", "Men’s RS:X Windsurfer", "Women’s 470", "Men’s Star", "Women’s Laser Radial", "Women’s RS:X Windsurfer", "", "Women’s Elliott 6m", "Men’s 50m Rifle Prone", "Men’s 49er", "SH Shooting", "Men’s 50m Rifle 3 Positions", "Men’s 25m Rapid Fire Pistol", "Men’s 50m Pistol", "Men’s 10m Air Pistol", "Men’s 10m Air Rifle", "Men’s Skeet", "Men’s Double Trap", "Women’s 10m Air Rifle", "Women’s 50m Rifle 3 Positions", "Men’s Trap", "Women’s 10m Air Pistol", "Women’s Skeet", "Women’s Trap", "Women’s 25m Pistol", "Men’s 50m Freestyle", "SW Swimming", "Men’s 100m Freestyle", "", "Men’s 400m Freestyle", "Men’s 1500m Freestyle", "Men’s 100m Butterfly", "Men’s 200m Butterfly", "Men’s 100m Breaststroke", "Men’s 200m Backstroke", "Men’s 200m Breaststroke", "Men’s 200m Individual Medley", "Men’s 400m Individual Medley", "Men’s 200m Freestyle", "Men’s 100m Backstroke", "Men’s 4x100m Freestyle Relay", "Men’s 4x200m Freestyle Relay", "Men’s 4x100m Medley Relay", "Women’s 100m Freestyle", "Men’s Marathon 10km", "Women’s 400m Freestyle", "Women’s 800m Freestyle", "Women’s 200m Freestyle", "Women’s 100m Butterfly", "Women’s 50m Freestyle", "Women’s 200m Butterfly", "Women’s 200m Breaststroke", "Women’s 200m Backstroke", "Women’s 100m Breaststroke", "Women’s 200m Individual Medley", "Women’s 4x200m Freestyle Relay", "Women’s 4x100m Medley Relay", "Women’s 4x100m Freestyle Relay", "Women’s Marathon 10km", "Women’s 100m Backstroke", "Women’s 400m Individual Medley", "SY Synchronised Swimming Duets Teams", "Men’s Singles", "Women’s Singles", "TE Tennis", "Men’s Doubles", "Mixed Doubles", "Women’s Doubles", "", "", "Men’s -58kg", "Men’s -80kg", "TK Taekwondo", "Men’s -68kg", "Women’s -49kg", "Women’s -67kg", "Women’s -57kg", "TR Triathlon Men’s ", "Men’s +80kg", "Women’s +67kg", "Triathlon Women’s Triathlon", "TT Table Tennis", "Women’s Singles", "", "Men’s Team", "Men’s Singles", "", "Women’s Team", "Men’s Volleyball ", "", "", "VO Volleyball ", "Women’s Volleyball", "WL Weightlifting", "", "Men’s 56kg", "Men’s 85kg", "Men’s 62kg", "Men’s 69kg", "Men’s 105kg", "Men’s 77kg", "Women’s 48kg", "Men’s +105kg", "Women’s 58kg", "Women’s 53kg", "Women’s 63kg", "Women’s 69kg", "WP Water Polo ", "Women’s 75kg", "Men’s 94kg", "Women’s +75kg", "Women’s Water Polo", "WR Wrestling", "Men’s Water Polo ", "Men’s Freestyle 55kg", "Men’s Freestyle 66kg", "", "Men’s Freestyle 60kg", "Men’s Freestyle 74kg", "Men’s Freestyle 120kg", "Men’s Greco-Roman 55kg", "Men’s Freestyle 96kg", "Men’s Greco-Roman 60kg", "Men’s Freestyle 84kg", "Men’s Greco-Roman 84kg", "Men’s Greco-Roman 96kg", "Men’s Greco-Roman 74kg", "Men’s Greco-Roman 120kg", "", "Men’s Greco-Roman 66kg", "", "Round 1", "Round 3", "", "Round 2", "Leage Match", "Round 5", "Pre Quarter Final", "Quarter Final", "Preliminary Match", "Round 4", "Semi Final", "", "Table 1 - Round 3 (Morning Session)", "Final", "Table 1 - Round 1", "Table 1 - Round 3 (After noon Session)", "Table 1 - Round 1 (First Session)", "Women's Singles", "Table 1 - Round 2", "", "Men's Doubles", "Women's Doubles", "", "Team Event", "Cadet Girls Team", "Junior Girls Team", "Men's Singles", "Junior Boys Team", "", "Junior Girls", "Cadet Boys Team", "", "Cadet Girls", "Junior Boys Doubles", "Cadet Boys", "Junior Boys", "Qualifying  - RD1", "Junior Mixed Doubles", "Junior Girls Doubles", "Position 9-13", "", "Stage 1 Round 1"
    }

    Public Function getgamelogoImageLocation(gametxt As String) As String
        Dim gamelogoImageLocation As String = ""
        If gametxt = "Aquatics" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\AQ" & ".png"
        If gametxt = "Archery" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\AR" & ".png"
        If gametxt = "Atheletics" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\AT" & ".png"
        If gametxt = "Badminton" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\BD" & ".png"
        If gametxt = "Basketball" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\BK" & ".png"
        If gametxt = "Black" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\BLK" & ".png"
        If gametxt = "Boxing" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\BX" & ".png"
        If gametxt = "Cycling" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\CY" & ".png"
        If gametxt = "Diving" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\DIV" & ".png"
        If gametxt = "Football" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\FB" & ".png"
        If gametxt = "Gymnastics - Artistic" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\Gymnastics - Artistic" & ".png"
        If gametxt = "Gymnastics - Rhythmic" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\Gymnastics - Rhythmic" & ".png"
        If gametxt = "Gymnastics - Trampoline" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\Gymnastics - Trampoline" & ".png"
        If gametxt = "Handball" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\HB" & ".png"
        If gametxt = "Hockey" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\HO" & ".png"
        If gametxt = "NetBall" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\nb" & ".png"
        If gametxt = "Judo" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\HO" & ".png"
        If gametxt = "Kabaddi" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\KB" & ".png"
        If gametxt = "Canoeing" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\CK" & ".png"
        If gametxt = "Kayaking" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\KK" & ".png"
        If gametxt = "Rowing" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\RW" & ".png"
        If gametxt = "Squash" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\SQ" & ".png"
        If gametxt = "Swimming" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\SW" & ".png"
        If gametxt = "TableTennis" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\TT" & ".png"
        If gametxt = "Taekwondo" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\TK" & ".png"
        If gametxt = "Tennis" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\TE" & ".png"
        If gametxt = "Triathlon" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\TRI" & ".png"
        If gametxt = "Volleyball" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\VB" & ".png"
        If gametxt = "Weight lift" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\WL" & ".png"
        If gametxt = "Wrestling" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\WR" & ".png"
        If gametxt = "Wushu" Then gamelogoImageLocation = "C:\casparcg\ng2022\data\games logo\WU" & ".png"
        Return gamelogoImageLocation

    End Function
    Function openimage(ByVal defaultdirectory As String, ByVal picname As PictureBox)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = defaultdirectory.Replace("/", "\")
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picname.ImageLocation = picofd.FileName
        End If
        Return Split(picofd.SafeFileName, ".")(0)
    End Function
    Sub showtemplate(ByVal templatename As String, ByVal datacollection As String, Optional layergames As Integer = 96)
        On Error Resume Next

        If frmNG2022.chkSendToHtml.Checked Then
            loadHtml("C:/casparcg/" + templatename + ".html", datacollection)
            For i = 0 To CasparCGDataCollection.DataPairs.Count - 1
                If CasparCGDataCollection.DataPairs.Item(i).Value.Contains(":/") Then
                    changeImage(CasparCGDataCollection.DataPairs.Item(i).Name, CasparCGDataCollection.DataPairs.Item(i).Value)
                End If
            Next
        End If

        If frmNG2022.chkanimation.Checked Then frmNG2022.animation1(layergames)
        Threading.Thread.Sleep(250)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(layergames), layergames, templatename, True, datacollection)
        Threading.Thread.Sleep(1300)
        If frmNG2022.chkanimation.Checked Then frmNG2022.animationtoscreen(layergames)

    End Sub

    Sub opendatasg(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = initialdirectory
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvname.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                headername.Text = Split(li, ",")(0)
                subheadername.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgvname.ColumnCount - 1
                    dgvname.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()

                    Dim xyz As Array = Split(li, ",")
                    If (xyz(0) <> "") Then dgvname.Rows.Add()

                    For k = 0 To dgvname.ColumnCount - 1
                        If xyz(k) <> "" Then
                            If dgvname.Name = "dgvtrack" Then
                                If k = 2 Then
                                    dgvname.Rows(g).Cells(k).Value = Image.FromFile(xyz(k))
                                Else
                                    dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                                End If
                            Else
                                dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                            End If
                        End If
                    Next
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilename.Text = ofd2.FileName
        End If
    End Sub
    Sub newdatasg(ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        dgvname.Rows.Clear()
        'headername.Text = ""
        subheadername.Text = ""
        lblfilename.Text = "New"


        With dgvname
            .Rows.Add(8)
            For ii = 0 To 7
                .Rows(ii).Cells(0).Value = ii + 1
                .Rows(ii).Cells(2).Value = "BLK"
            Next
        End With
    End Sub
    Sub insertsg(ByVal dgv As DataGridView)
        On Error Resume Next
        With dgv
            .Rows.Insert(.CurrentRow.Index)
        End With
    End Sub

    Sub downsg(ByVal dgv As DataGridView)
        On Error Resume Next
        If dgv.CurrentCell.RowIndex <> dgv.Rows.Count - 2 Then
            Dim curRow As Integer = dgv.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = dgv.CurrentRow
            dgv.Rows.Remove(myRow)
            dgv.Rows.Insert(curRow + 1, myRow)
            dgv.CurrentCell = dgv.Rows(curRow + 1).Cells(0)
        End If
    End Sub
    Sub upsg(ByVal dgv As DataGridView)
        On Error Resume Next
        If dgv.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = dgv.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = dgv.CurrentRow
            dgv.Rows.Remove(myRow)
            dgv.Rows.Insert(curRow - 1, myRow)
            dgv.CurrentCell = dgv.Rows(curRow - 1).Cells(0)
        End If
    End Sub
    Sub deletesg(ByVal dgv As DataGridView)
        On Error Resume Next
        With dgv
            .Rows.RemoveAt(.CurrentRow.Index)
        End With
    End Sub
    Sub saveasdatasg(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next

        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = initialdirectory

        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
20:
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvname.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(headername.Text & "," & subheadername.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvname.ColumnCount - 1
                        header1 = header1 & dgvname.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvname.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvname.ColumnCount - 1

                            If dgvname.Name = "dgvtrack" Then
                                If k = 2 Then
                                    str = str & dgvname.Rows(f).Cells(6).Value & ","
                                Else
                                    str = str & dgvname.Rows(f).Cells(k).Value & ","
                                End If
                            Else
                                str = str & dgvname.Rows(f).Cells(k).Value & ","

                            End If
                            ' str = str & dgvname.Rows(f).Cells(k).Value & ","

                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilename.Text = osd2.FileName
        End If
    End Sub

    Sub savedatasg(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next

        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = initialdirectory
        'osd2.FileName = "001_" & ucRccBall.cmbHeader.Text & "_" & ucSG2016.cmbSubHeader.Text

        If File.Exists(lblfilename.Text) = True Then
            osd2.FileName = lblfilename.Text
            GoTo 20
        End If
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
20:
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvname.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(headername.Text & "," & subheadername.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvname.ColumnCount - 1
                        header1 = header1 & dgvname.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvname.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvname.ColumnCount - 1
                            If dgvname.Name = "dgvtrack" Then
                                If k = 2 Then
                                    str = str & dgvname.Rows(f).Cells(6).Value & ","
                                Else
                                    str = str & dgvname.Rows(f).Cells(k).Value & ","
                                End If
                            Else
                                str = str & dgvname.Rows(f).Cells(k).Value & ","

                            End If

                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilename.Text = osd2.FileName
        End If
    End Sub

    Public Sub loadHtml(template, allData)
        On Error Resume Next
        Dim postData As String = "layerNumber=" & 96 & "&pageName=" & template & "&data=" & allData & "&clientId=" & frmNG2022.txtClientID.Text
        Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
        Dim url As String = "http://localhost:9000/loadHtml"
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
        client.UploadData(url, data)
    End Sub

    Public Sub UpdateHTML(allData)
        On Error Resume Next
        Dim postData As String = "layerNumber=" & 96 & "&data=" & JsonConvert.SerializeObject(allData) & "&clientId=" & frmNG2022.txtClientID.Text
        Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
        Dim url As String = "http://localhost:9000/updateHtml"
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
        client.UploadData(url, data)
    End Sub

    Public Sub callScript(allData)
        On Error Resume Next
        Dim postData As String = "layerNumber=" & 96 & "&data=" & JsonConvert.SerializeObject(allData) & "&clientId=" & frmNG2022.txtClientID.Text
        Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
        Dim url As String = "http://localhost:9000/callScript"
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
        client.UploadData(url, data)
    End Sub

    Public Sub changeImage(id, image)
        Dim bytes = File.ReadAllBytes(image)
        Dim b64String = Convert.ToBase64String(bytes)
        Dim dataUrl = "data:image/png;base64," + b64String
        callScript({"document.getElementById('" & id & "').getElementsByTagName('image')[0].setAttribute('xlink:href', '" & dataUrl.Replace("+", "%2b") & "')"})
    End Sub
    Public Sub changeString(id, val)
        callScript({"document.getElementById('" & id & "').getElementsByTagName('text')[0].getElementsByTagName('tspan')[0].innerHTML = '" & val & "'"})
    End Sub
    Class rccData
        Public key As String
        Public value As String
        Public type As String
    End Class

End Module
