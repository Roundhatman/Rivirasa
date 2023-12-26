Imports System.Threading
Imports OpenHardwareMonitor
Imports Core
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMain

    Private currentKeys As String = vbNullString

    Private curveOrder As String = "Linear"
    Private DataX, DataY As New List(Of Single)
    Private XPerCM, YPerCM, XPerDV, YPerDV As Single

    Private driveList As New List(Of IO.DriveInfo)
    Private defaultAPIKey As String = "1c4026c02346bb0da2c7e0cb9fb5d680"
    Private panelHeight As UInt16 = 768
    Private panelWidth As UInt16 = 950
    Private tMins As Byte = 0

    Public thisComputer As New Hardware.Computer()
    Private thisBattery As PowerStatus = SystemInformation.PowerStatus
    Private oldPowerStatus As String = vbNullString
    Private newPowerStatus As String = vbNullString

    Private defaultPosision As New Point(My.Computer.Screen.WorkingArea.Width - 20, 0)
    Private popupPosision As New Point(My.Computer.Screen.WorkingArea.Width - panelWidth, 0)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtConsole.AppendText(welcomeString)
        tbxTabPool.SelectedTab = tbxSystem

        ' Startup settings
        Me.Location = popupPosision
        Me.Opacity = 0.95
        Me.Height = panelHeight
        thisComputer.Open()
        thisComputer.CPUEnabled = True
        thisComputer.HDDEnabled = True

        ' Load UI Files
        wbTimeTable0.Navigate(uiTimeTable0)
        wbTimeTable1.Navigate(uiTimeTable1)
        wbCourseFiles.Navigate(uiCourseFiles)
        wbCalendar.Navigate(uiCalendar)

        ' Initialize Hard Drives
        For Each d As IO.DriveInfo In My.Computer.FileSystem.Drives
            Application.DoEvents()
            If d.DriveType = IO.DriveType.Fixed Then driveList.Add(d)
        Next
        lblDT1.Text = driveList.Item(0).Name & " " & driveList.Item(0).DriveFormat
        lblDT2.Text = driveList.Item(1).Name & " " & driveList.Item(1).DriveFormat
        lblDT3.Text = driveList.Item(2).Name & " " & driveList.Item(2).DriveFormat

        ' Update System Info
        lblCPU.Text = ">> " & GetCPUInfo()
        lblRam.Text = ">> " & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024, 2) & " GB of Physical Memory"
        lblVRam.Text = ">> " & Math.Round(My.Computer.Info.TotalVirtualMemory / 1024 / 1024 / 1024, 2) & " GB of Virtual Memory"

        ' Update Weather Info
        UpdateWeather()
        tmrUpdate.Enabled = True
        tmrWeather.Enabled = True
        Thread.Sleep(200)
        oldPowerStatus = PowerLineStatus.GetName(thisBattery.PowerLineStatus.GetType, thisBattery.PowerLineStatus)
        tmrUpdate_Tick(Me, EventArgs.Empty)

        ' Process Control
        WhatsApp.ImageName = "WhatsApp"
        WhatsApp.AuthString = "EchoRomio"
        lblAuth.Text = "x"
        WhatsApp.Auth = False
        lblProcName.Text = WhatsApp.ImageName

        PowerShell.ImageName = "powershell"
        PowerShell.PeekMemoryMegaBytes = 100

    End Sub

    Private Sub lblPanelControl_Click(sender As Object, e As EventArgs) Handles lblPanelControl.Click

        tmrUpdate.Enabled = False
        tmrWeather.Enabled = False

        If Me.Location = defaultPosision Then

            ' Shift Window Left
            While Me.Location.X > popupPosision.X
                Thread.Sleep(1)
                Application.DoEvents()
                Me.Location = New Point(Me.Location.X - 30, 0)
                Me.Opacity = Me.Opacity + 0.005
            End While
            Me.Location = popupPosision
            tmrUpdate.Enabled = True
            tmrWeather.Enabled = True

        ElseIf Me.Location = popupPosision Then

            ' Shift Window Right
            While Me.Location.X < defaultPosision.X
                Thread.Sleep(1)
                Application.DoEvents()
                Me.Location = New Point(Me.Location.X + 30, 0)
                Me.Opacity = Me.Opacity - 0.005
            End While
            Me.Location = defaultPosision

        End If

    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick

        ' Update Performance Info
        cpbRam.Bar1.Value = 100 - (My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory) * 100
        cpbVRam.Bar1.Value = 100 - (My.Computer.Info.AvailableVirtualMemory / My.Computer.Info.TotalVirtualMemory) * 100

        ' Update Power Info
        With thisBattery
            newPowerStatus = PowerLineStatus.GetName(.PowerLineStatus.GetType, .PowerLineStatus)
            cpbBattery.Bar1.Value = .BatteryLifePercent * 100
            lblTimeToCharge.Text = "Time to full charge : " & Convert.ToInt32(.BatteryFullLifetime / 60) & " min"
            lblTimeToDischarge.Text = "Estimated run time  : " & Convert.ToInt32(.BatteryLifeRemaining / 60) & " min"
            lblBatStatus.Text = "Battery status      : " & BatteryChargeStatus.GetName(.BatteryChargeStatus.GetType, .BatteryChargeStatus) & ", AC Power " & newPowerStatus
            If oldPowerStatus <> newPowerStatus Then
                Beep()
                txtConsole.AppendText(Format(DateTime.UtcNow.AddHours(5.5), "hh:mm tt ") & "AC Power " & newPowerStatus & vbNewLine)
            End If
            oldPowerStatus = newPowerStatus
        End With

        ' Update Hard Disk Info
        lblFree1.Text = Math.Round(driveList.Item(0).TotalFreeSpace / 1024 / 1024 / 1024, 2) & " GB Free"
        lblFree2.Text = Math.Round(driveList.Item(1).TotalFreeSpace / 1024 / 1024 / 1024, 2) & " GB Free"
        lblFree3.Text = Math.Round(driveList.Item(2).TotalFreeSpace / 1024 / 1024 / 1024, 2) & " GB Free"
        cpbDrive1.Bar1.Value = 100 - driveList.Item(0).TotalFreeSpace / driveList.Item(0).TotalSize * 100
        cpbDrive2.Bar1.Value = 100 - driveList.Item(1).TotalFreeSpace / driveList.Item(1).TotalSize * 100
        cpbDrive3.Bar1.Value = 100 - driveList.Item(2).TotalFreeSpace / driveList.Item(2).TotalSize * 100

        ' Update OpenHardware
        Dim thisProcessor = thisComputer.Hardware.Where(Function(h) h.HardwareType = Hardware.HardwareType.CPU).FirstOrDefault
        Dim thisHDD = thisComputer.Hardware.Where(Function(h) h.HardwareType = Hardware.HardwareType.HDD).FirstOrDefault
        Dim thisSSD = thisComputer.Hardware.Where(Function(h) h.HardwareType = Hardware.HardwareType.HDD).Last

        thisProcessor.Update()
        thisHDD.Update()
        thisSSD.Update()

        Dim ssdTempSensor = thisSSD.Sensors.Where(Function(s) s.SensorType = Hardware.SensorType.Temperature).Last
        Dim hddTempSensor = thisHDD.Sensors.Where(Function(s) s.SensorType = Hardware.SensorType.Temperature).Last
        Dim cpuTempSensor = thisProcessor.Sensors.Where(Function(s) s.SensorType = Hardware.SensorType.Temperature).Last
        Dim cpuUtilSensor = thisProcessor.Sensors.Where(Function(s) s.SensorType = Hardware.SensorType.Load).Last

        lblTempCPU.Text = "Temp : " & cpuTempSensor.Value & " °C"
        lblTempHDD.Text = "Temp : " & hddTempSensor.Value & " °C"
        lblTempSSD.Text = "Temp : " & ssdTempSensor.Value & " °C"
        lblTempCPUMax.Text = "Max  : " & cpuTempSensor.Max & " °C"
        lblTempHDDMax.Text = "Max  : " & hddTempSensor.Max & " °C"
        lblTempSSDMax.Text = "Max  : " & ssdTempSensor.Max & " °C"

        cpbTempSSD.Bar1.Value = ssdTempSensor.Value / ssdTempSensor.Max * 100
        cpbTempHDD.Bar1.Value = hddTempSensor.Value / hddTempSensor.Max * 100
        cpbTempCPU.Bar1.Value = cpuTempSensor.Value / cpuTempSensor.Max * 100
        cpbProcessor.Bar1.Value = cpuUtilSensor.Value

    End Sub

    Private Sub tmrWeather_Tick(sender As Object, e As EventArgs) Handles tmrWeather.Tick

        UpdateWeather()

    End Sub

    Public Sub UpdateWeather()
        On Error GoTo ErrHandler
        Dim fi As New ForecastInfo

        fi = Forecast.GetWeatherInfo("Panadura", defaultAPIKey)
        lblName1.Text = "Loc. 1 : " & fi.CityName
        lblWeather1.Text = "Weather: " & WeatherCondition.GetName(GetType(WeatherCondition), fi.Weather)
        lblWind1.Text = "Wind   : " & fi.WindSpeed & " kmph bearing " & fi.WindDirection & "°"
        lblTemp1.Text = "Temp.  : " & fi.Temperature & " feels " & fi.FeelsLike & " °C"


        fi = Forecast.GetWeatherInfo("Nugegoda", defaultAPIKey)
        lblName2.Text = "Loc. 2 : " & fi.CityName
        lblWeather2.Text = "Weather: " & WeatherCondition.GetName(GetType(WeatherCondition), fi.Weather)
        lblWind2.Text = "Wind   : " & fi.WindSpeed & " kmph bearing " & fi.WindDirection & "°"
        lblTemp2.Text = "Temp.  : " & fi.Temperature & " feels " & fi.FeelsLike & " °C"

        fi = Forecast.GetWeatherInfo("Yerevan", defaultAPIKey)
        lblName3.Text = "Loc. 3 : " & fi.CityName
        lblWeather3.Text = "Weather: " & WeatherCondition.GetName(GetType(WeatherCondition), fi.Weather)
        lblWind3.Text = "Wind   : " & fi.WindSpeed & " kmph bearing " & fi.WindDirection & "°"
        lblTemp3.Text = "Temp.  : " & fi.Temperature & " feels " & fi.FeelsLike & " °C"

        lblLastUpdate.Text = "Last update on " & Format(DateTime.UtcNow.AddHours(5.5), "hh:mm:ss tt")

ErrHandler:
        If Not Err.Number = 0 Then
            txtConsole.AppendText(Err.Description & vbNewLine)
            Resume Next
        End If
    End Sub

    Private Sub lblLastUpdate_Click(sender As Object, e As EventArgs) Handles lblLastUpdate.Click
        UpdateWeather()
    End Sub

    Private Sub cpbDrive1_DoubleClick(sender As Object, e As EventArgs) Handles cpbDrive1.DoubleClick
        Shell("explorer.exe " & driveList.Item(0).Name, AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtXList.Clear()
        txtYList.Clear()
        txtXPoints.Clear()
        txtYPoints.Clear()
        chtGraph.Series.Item(0).Points.Clear()
        chtGraph.Series.Item(1).Points.Clear()
        DataX.Clear()
        DataY.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Using d As New SaveFileDialog

            d.Filter = "Comma Seperated Values (*.csv) | *.csv"
            d.ShowDialog()
            If d.FileName = vbNullString Then Exit Sub

            Using writer As New IO.StreamWriter(d.FileName)
                For i As UInt16 = 0 To DataX.Count - 1
                    Application.DoEvents()
                    writer.WriteLine(DataX.Item(i) & "," & DataY.Item(i))
                Next
            End Using

            MsgBox("Data saved into " & d.FileName, vbInformation)

        End Using

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim fileContent As String = vbNullString

        Using d As New OpenFileDialog
            d.Filter = "Comma Seperated Values (*.csv) | *.csv"
            d.ShowDialog()
            If d.FileName = vbNullString Then Exit Sub

            Using reader As New IO.StreamReader(d.FileName)
                fileContent = reader.ReadToEnd
            End Using

            btnClear_Click(Me, EventArgs.Empty)
            For Each line In fileContent.Split(vbNewLine)
                Application.DoEvents()
                If Not (line = vbNewLine Or line = vbCr Or line = vbLf) Then
                    txtXList.AppendText(line.Split(",")(0) & vbNewLine)
                    txtYList.AppendText(line.Split(",")(1) & vbNewLine)
                End If

            Next
            txtXList.Text = txtXList.Text.Remove(txtXList.TextLength - 2, 2)
            txtYList.Text = txtYList.Text.Remove(txtYList.TextLength - 2, 2)

        End Using

    End Sub

    Private Sub lblEnd_Click(sender As Object, e As EventArgs) Handles lblEnd.Click
        End
    End Sub

    Private Sub cpbDrive2_DoubleClick(sender As Object, e As EventArgs) Handles cpbDrive2.DoubleClick
        Shell("explorer.exe " & driveList.Item(1).Name, AppWinStyle.NormalFocus)
    End Sub

    Private Sub cpbDrive3_DoubleClick(sender As Object, e As EventArgs) Handles cpbDrive3.DoubleClick
        Shell("explorer.exe " & driveList.Item(2).Name, AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        wbCourseFiles.GoBack()
    End Sub

    Private Function GetCPUInfo() As String
        Dim thisProcessor = thisComputer.Hardware.Where(Function(h) h.HardwareType = Hardware.HardwareType.CPU).FirstOrDefault
        thisProcessor.Update()
        Return thisProcessor.Name
    End Function

    Private Sub tmrProcCtrl_Tick(sender As Object, e As EventArgs) Handles tmrProcCtrl.Tick

        Dim thisProcess As Process = Process.GetProcessesByName(WhatsApp.ImageName).FirstOrDefault

        If Not thisProcess Is Nothing Then
            If Not WhatsApp.Auth Then
                thisProcess.Kill()
                lblStat.Text = "Process is terminated PID: 0x" & Hex(thisProcess.Id)
                txtConsole.AppendText("WA: (" & TimeString & ") Process is terminated PID: 0x" & Hex(thisProcess.Id) & vbNewLine)
            Else
                lblStat.Text = "Process is running PID: 0x" & Hex(thisProcess.Id)
            End If

        Else
            lblStat.Text = "Process is not running."

        End If

        Dim thisProcessList() As Process = Process.GetProcessesByName(PowerShell.ImageName)

        If Not thisProcessList.Length = 0 Then
            For Each p In thisProcessList
                If p.WorkingSet64 > (PowerShell.PeekMemoryMegaBytes * 1024 * 1024) Then
                    p.Kill()
                    txtConsole.AppendText("PS: (" & TimeString & ") Process is terminated PID: 0x" & Hex(p.Id) & " due to high memory usage (" & (p.WorkingSet64 / 1024 / 1024) & " kB)")
                End If
            Next
        End If

    End Sub

    Private Sub btnAuth_Click(sender As Object, e As EventArgs) Handles btnAuth.Click
        If txtAuth.Text = WhatsApp.AuthString Then
            If Not WhatsApp.Auth Then
                lblAuth.Text = "✓"
                WhatsApp.Auth = True
                txtConsole.AppendText("WhatsApp ✓" & vbNewLine)
            Else
                lblAuth.Text = "x"
                WhatsApp.Auth = False
                txtAuth.Text = vbNullString
                txtConsole.AppendText("WhatsApp x" & vbNewLine)
            End If
        Else
            MsgBox("Access Denied", MsgBoxStyle.Critical)
            txtConsole.AppendText("Authentication Failed" & vbNewLine)
        End If
    End Sub

    Private Sub btnPlot_Click(sender As Object, e As EventArgs) Handles btnPlot.Click

        ' Maximum & Minimum values
        Dim MaxX = Convert.ToSingle(txtEVal.Text.Split(",")(0))
        Dim MaxY = Convert.ToSingle(txtEVal.Text.Split(",")(1))
        Dim MinX = Convert.ToSingle(txtSVal.Text.Split(",")(0))
        Dim MinY = Convert.ToSingle(txtSVal.Text.Split(",")(1))

        For Each line As String In txtXList.Lines
            Application.DoEvents()
            If Not line = vbNullString Then DataX.Add(Convert.ToSingle(line))
        Next
        For Each line As String In txtYList.Lines
            Application.DoEvents()
            If Not line = vbNullString Then DataY.Add(Convert.ToSingle(line))
        Next

        ' Check input errors
        If DataX.Count > DataY.Count Then
            MsgBox("Incomplete Y data set !", MsgBoxStyle.Critical, "Data error")
            Exit Sub
        ElseIf DataX.Count < DataY.Count Then
            MsgBox("Incomplete X data set !", MsgBoxStyle.Critical, "Data error")
            Exit Sub
        End If

        ' Graph Calculations
        XPerCM = (MaxX - MinX) / Convert.ToSingle(txtMaxX.Text)
        YPerCM = (MaxY - MinY) / Convert.ToSingle(txtMaxY.Text)
        XPerDV = (MaxX - MinX) / Convert.ToSingle(txtMaxX.Text) / Convert.ToSingle(txtDiv.Text)
        YPerDV = (MaxY - MinY) / Convert.ToSingle(txtMaxY.Text) / Convert.ToSingle(txtDiv.Text)
        For i As UInt16 = 0 To DataX.Count - 1
            Application.DoEvents()
            txtXPoints.Text = txtXPoints.Text & ((DataX(i) - MinX) / XPerDV).ToString & vbNewLine
            txtYPoints.Text = txtYPoints.Text & ((DataY(i) - MinY) / YPerDV).ToString & vbNewLine
        Next

        ' Calculation Results
        lblXRange.Text = "X = " & Math.Round(XPerCM, 2, MidpointRounding.AwayFromZero).ToString & " u per 1cm, " & Math.Round(XPerDV, 2, MidpointRounding.AwayFromZero).ToString & " u per div."
        lblYRange.Text = "Y = " & Math.Round(YPerCM, 2, MidpointRounding.AwayFromZero).ToString & " u per 1cm, " & Math.Round(YPerDV, 2, MidpointRounding.AwayFromZero).ToString & " u per div."
        lblG.Text = "G = (" & (DataX.Sum / DataX.Count).ToString & ", " & (DataY.Sum / DataX.Count).ToString & ")"
        lblGrad.Text = "m = " & ((DataY(DataY.Count - 1) - DataY(0)) / (DataX(DataX.Count - 1) - DataX(0))).ToString
        If DataX.IndexOf(0.0) >= 0 Then
            lblInter.Text = "c = " & DataY.Item(DataX.IndexOf(0.0))
        Else
            Dim intercept As Double = (DataY.Sum / DataX.Count) - ((DataY(DataY.Count - 1) - DataY(0)) / (DataX(DataX.Count - 1) - DataX(0))) * (DataX.Sum / DataX.Count)
            lblInter.Text = "c = " & intercept.ToString
        End If

        ' Plot Graph
        With chtGraph.ChartAreas.FirstOrDefault
            .AxisX.Minimum = MinX
            .AxisX.Maximum = MaxX
            .AxisY.Minimum = MinY
            .AxisY.Maximum = MaxY
        End With
        For i As UInt16 = 0 To DataX.Count - 1
            Application.DoEvents()
            chtGraph.Series.Item(0).Points.AddXY(DataX.Item(i), DataY.Item(i))
        Next

        ' Regression
        Dim parameters As String = curveOrder + ",1" + ",false" + ",false"
        chtGraph.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, parameters, chtGraph.Series.Item(0), chtGraph.Series.Item(1))

    End Sub

    Private Sub txtConsole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsole.KeyPress

        txtConsole.AppendText(e.KeyChar)

        If Not e.KeyChar = Chr(13) Then
            currentKeys = currentKeys & e.KeyChar
        Else
            txtConsole.AppendText(vbNewLine)
            Select Case currentKeys.ToLower
                Case "end"
                    lblEnd_Click(Me, EventArgs.Empty)
                Case "todo"
                    fExecute("WINWORD", Chr(34) & uiCalendar & Chr(34))
                Case "time0"
                    fExecute("WINWORD", Chr(34) & uiTimeTable0 & Chr(34))
                Case "time1"
                    fExecute("WINWORD", Chr(34) & uiTimeTable1 & Chr(34))
                Case "lms"
                    fExecute("explorer", "https:\\lms.fas.sjp.ac.lk\")
                Case "pes"
                    fExecute("explorer", "https:\\pes.science.sjp.ac.lk\")
                Case Else
                    txtConsole.AppendText("Invalid command " & currentKeys & vbNewLine)
            End Select
            currentKeys = vbNullString
        End If

        txtConsole.ScrollToCaret()
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        ' Update Time
        lblClock.Text = Format(DateTime.UtcNow, "hh:mm:ss tt")
        lblDate.Text = Format(DateTime.UtcNow, "yyyy-MM-dd")
        lblTime1.Text = "Time   : " & Format(DateTime.UtcNow.AddHours(5.5), "hh:mm:ss tt")
        lblTime2.Text = "Time   : " & Format(DateTime.UtcNow.AddHours(5.5), "hh:mm:ss tt")
        lblTime3.Text = "Time   : " & Format(DateTime.UtcNow.AddHours(4), "hh:mm:ss tt")
    End Sub

    Public Function fExecute(ModuleName As String, Optional Arguments As String = vbNullString) As IntPtr
        Dim pr As New Process

        pr.StartInfo.Arguments = Arguments
        pr.StartInfo.FileName = ModuleName
        pr.Start()

        Return pr.Id

    End Function

End Class
