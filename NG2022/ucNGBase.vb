Public Class ucNGBase
    Inherits System.Windows.Forms.UserControl

    Protected IsReady As Boolean = False

    ''' <summary>
    ''' Common logic to mark the control as ready after loading.
    ''' </summary>
    Protected Sub SetReady()
        IsReady = True
    End Sub

    ''' <summary>
    ''' Centralized DataError handler for DataGridViews.
    ''' </summary>
    Protected Sub Default_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        ' Dummy code to prevent crash on data errors
    End Sub

    ''' <summary>
    ''' Shared logic to add CasparCG outputs.
    ''' </summary>
    Public Sub AddCasparOutputs()
        If Not IsCasparConnected() Then Exit Sub

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 1 " & "embedded_audio")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 1 " & "embedded_audio")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 2 " & "key_only")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 2 " & "key_only")
    End Sub

    ''' <summary>
    ''' Shared logic to remove CasparCG outputs.
    ''' </summary>
    Public Sub RemoveCasparOutputs()
        If Not IsCasparConnected() Then Exit Sub

        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 2")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 2")
    End Sub

    ''' <summary>
    ''' Unified HD mode switch.
    ''' </summary>
    Public Sub SetHDMode()
        If Not IsCasparConnected() Then Exit Sub
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode 1080i5000")
    End Sub

    ''' <summary>
    ''' Unified SD mode switch.
    ''' </summary>
    Public Sub SetSDMode()
        If Not IsCasparConnected() Then Exit Sub
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode PAL")
    End Sub

End Class
