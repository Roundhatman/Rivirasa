Module GlobalMemorySpace

    Public Structure Task
        Dim Name As String
        Dim Marks As Byte
        Dim Status As Byte
    End Structure

    Public Structure ProcCtrl
        Dim ImageName As String
        Dim AuthString As String
        Dim PeekMemoryMegaBytes As UInt16
        Dim Auth As Boolean
    End Structure

    Public Tasks As New List(Of Task)
    Public WhatsApp As New ProcCtrl
    Public PowerShell As New ProcCtrl

    Public uiCalendar As String = Application.StartupPath & "\ui\uiCalendar.mht"
    Public uiResource As String = "C:\Users\Lakmila Swarnajith\OneDrive\Documents\Money.xlsx"
    Public uiTimeTable0 As String = Application.StartupPath & "\ui\uiTimeTable0.mht"
    Public uiTimeTable1 As String = Application.StartupPath & "\ui\uiTimeTable1.mht"
    Public uiCourseFiles As String = "D:\Academic\"
    Public taskFile As String = Application.StartupPath & "\Today.csv"

    Public BatteryStatus As String
    Public BatteryChemistry As String
    Public BatteryTimeToFullCharge As UInt32
    Public BatteryEstimatedRunTime As UInt32
    Public BatteryEstimatedChargeRemaining As Byte

    Public welcomeString As String = "🌞 卐 රිවිරැස  卐 🌝 v3.0 by L.Swarnajith under Sρәτsgruρρα on 2022/APR" & vbNewLine &
                                     "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" & vbNewLine

End Module
