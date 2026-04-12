''' <summary>
''' Central configuration for NG2022.
''' All hardcoded paths are defined here so they can be changed in one place.
''' </summary>
Public Module AppSettings

    ''' <summary>Root CasparCG data directory.</summary>
    Public ReadOnly Property CasparRoot As String
        Get
            Return "C:\casparcg\"
        End Get
    End Property

    ' ── Derived paths ────────────────────────────────────────────────────────
    Public ReadOnly Property FlagPath As String
        Get
            Return CasparRoot & "NG2022\data\flag\"
        End Get
    End Property

    Public ReadOnly Property GamesLogoPath As String
        Get
            Return CasparRoot & "ng2022\data\games logo\"
        End Get
    End Property

    Public ReadOnly Property EventLogoPath As String
        Get
            Return CasparRoot & "ng2022\data\event logo\"
        End Get
    End Property

    Public ReadOnly Property CountryPath As String
        Get
            Return CasparRoot & "ng2022\data\country\"
        End Get
    End Property

    Public ReadOnly Property DataPath As String
        Get
            Return CasparRoot & "ng2022\data\"
        End Get
    End Property

    ' ── Sport-specific data directories ──────────────────────────────────────
    Public ReadOnly Property ShootingDataPath As String
        Get
            Return DataPath & "shooting\"
        End Get
    End Property

    Public ReadOnly Property BoxingDataPath As String
        Get
            Return DataPath & "boxing\"
        End Get
    End Property

    Public ReadOnly Property BasketBallDataPath As String
        Get
            Return DataPath & "BasketBall\"
        End Get
    End Property

    Public ReadOnly Property NetBallDataPath As String
        Get
            Return DataPath & "netball\"
        End Get
    End Property

    Public ReadOnly Property ArcheryDataPath As String
        Get
            Return DataPath & "archery\"
        End Get
    End Property

    Public ReadOnly Property GymnasticDataPath As String
        Get
            Return DataPath & "gymnastics\"
        End Get
    End Property

    Public ReadOnly Property KabaddiDataPath As String
        Get
            Return DataPath & "kabaddi\"
        End Get
    End Property

    Public ReadOnly Property KhoKhoDataPath As String
        Get
            Return DataPath & "khokho\"
        End Get
    End Property

    Public ReadOnly Property TrackDataPath As String
        Get
            Return DataPath & "track\"
        End Get
    End Property

    Public ReadOnly Property CanoeDataPath As String
        Get
            Return DataPath & "canoe\"
        End Get
    End Property

End Module
