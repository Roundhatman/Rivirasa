<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblPanelControl = New System.Windows.Forms.Label()
        Me.tbxTabPool = New Dotnetrix.Controls.TabControlEX()
        Me.tbxSystem = New Dotnetrix.Controls.TabPageEX()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTempCPU = New System.Windows.Forms.Label()
        Me.lblTempHDD = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTempSSD = New System.Windows.Forms.Label()
        Me.lblTempCPUMax = New System.Windows.Forms.Label()
        Me.lblTempHDDMax = New System.Windows.Forms.Label()
        Me.lblTempSSDMax = New System.Windows.Forms.Label()
        Me.cpbTempCPU = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.cpbTempHDD = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.cpbTempSSD = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblWind3 = New System.Windows.Forms.Label()
        Me.lblWind2 = New System.Windows.Forms.Label()
        Me.lblWind1 = New System.Windows.Forms.Label()
        Me.lblTemp3 = New System.Windows.Forms.Label()
        Me.lblTemp2 = New System.Windows.Forms.Label()
        Me.lblTemp1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWeather3 = New System.Windows.Forms.Label()
        Me.lblTime3 = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.lblWeather2 = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblWeather1 = New System.Windows.Forms.Label()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFree3 = New System.Windows.Forms.Label()
        Me.lblDT3 = New System.Windows.Forms.Label()
        Me.lblFree2 = New System.Windows.Forms.Label()
        Me.lblDT2 = New System.Windows.Forms.Label()
        Me.lblFree1 = New System.Windows.Forms.Label()
        Me.lblDT1 = New System.Windows.Forms.Label()
        Me.cpbDrive3 = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.cpbDrive2 = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.cpbDrive1 = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTimeToDischarge = New System.Windows.Forms.Label()
        Me.lblTimeToCharge = New System.Windows.Forms.Label()
        Me.lblBatStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cpbBattery = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVRam = New System.Windows.Forms.Label()
        Me.lblRam = New System.Windows.Forms.Label()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cpbProcessor = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cpbVRam = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cpbRam = New CircularProgressBar.CircularProgress.CircularProgressBar()
        Me.tbxTimeTable1 = New Dotnetrix.Controls.TabPageEX()
        Me.wbTimeTable1 = New System.Windows.Forms.WebBrowser()
        Me.tbxCourseFiles = New Dotnetrix.Controls.TabPageEX()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.wbCourseFiles = New System.Windows.Forms.WebBrowser()
        Me.tbxTools = New Dotnetrix.Controls.TabPageEX()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtAuth = New System.Windows.Forms.TextBox()
        Me.btnAuth = New System.Windows.Forms.Button()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.lblProcName = New System.Windows.Forms.Label()
        Me.lblAuth = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbxCalendar = New Dotnetrix.Controls.TabPageEX()
        Me.wbCalendar = New System.Windows.Forms.WebBrowser()
        Me.tbxTimeTable0 = New Dotnetrix.Controls.TabPageEX()
        Me.wbTimeTable0 = New System.Windows.Forms.WebBrowser()
        Me.tbxGraphPlotter = New Dotnetrix.Controls.TabPageEX()
        Me.lblInter = New System.Windows.Forms.Label()
        Me.chtGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnPlot = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtYPoints = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtXPoints = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblYRange = New System.Windows.Forms.Label()
        Me.lblXRange = New System.Windows.Forms.Label()
        Me.lblGrad = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.txtEVal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSVal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDiv = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMaxY = New System.Windows.Forms.TextBox()
        Me.txtMaxX = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtYList = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtXList = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tmrWeather = New System.Windows.Forms.Timer(Me.components)
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrProcCtrl = New System.Windows.Forms.Timer(Me.components)
        Me.tbxTabPool.SuspendLayout()
        Me.tbxSystem.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbxTimeTable1.SuspendLayout()
        Me.tbxCourseFiles.SuspendLayout()
        Me.tbxTools.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tbxCalendar.SuspendLayout()
        Me.tbxTimeTable0.SuspendLayout()
        Me.tbxGraphPlotter.SuspendLayout()
        CType(Me.chtGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 5000
        '
        'lblPanelControl
        '
        Me.lblPanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPanelControl.Location = New System.Drawing.Point(0, -1)
        Me.lblPanelControl.Name = "lblPanelControl"
        Me.lblPanelControl.Size = New System.Drawing.Size(20, 768)
        Me.lblPanelControl.TabIndex = 2
        Me.lblPanelControl.Text = "🌞 卐 රිවිරැස  卐 🌝"
        '
        'tbxTabPool
        '
        Me.tbxTabPool.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab
        Me.tbxTabPool.Controls.Add(Me.tbxSystem)
        Me.tbxTabPool.Controls.Add(Me.tbxCalendar)
        Me.tbxTabPool.Controls.Add(Me.tbxTimeTable0)
        Me.tbxTabPool.Controls.Add(Me.tbxTimeTable1)
        Me.tbxTabPool.Controls.Add(Me.tbxCourseFiles)
        Me.tbxTabPool.Controls.Add(Me.tbxTools)
        Me.tbxTabPool.Controls.Add(Me.tbxGraphPlotter)
        Me.tbxTabPool.Location = New System.Drawing.Point(24, 2)
        Me.tbxTabPool.Name = "tbxTabPool"
        Me.tbxTabPool.SelectedIndex = 0
        Me.tbxTabPool.Size = New System.Drawing.Size(922, 765)
        Me.tbxTabPool.TabIndex = 12
        Me.tbxTabPool.UseVisualStyles = False
        '
        'tbxSystem
        '
        Me.tbxSystem.Controls.Add(Me.GroupBox6)
        Me.tbxSystem.Controls.Add(Me.GroupBox5)
        Me.tbxSystem.Controls.Add(Me.GroupBox4)
        Me.tbxSystem.Controls.Add(Me.GroupBox3)
        Me.tbxSystem.Controls.Add(Me.GroupBox2)
        Me.tbxSystem.Controls.Add(Me.GroupBox1)
        Me.tbxSystem.Location = New System.Drawing.Point(4, 25)
        Me.tbxSystem.Name = "tbxSystem"
        Me.tbxSystem.Size = New System.Drawing.Size(914, 736)
        Me.tbxSystem.TabIndex = 0
        Me.tbxSystem.Text = "System"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtConsole)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 428)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(907, 305)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConsole.Font = New System.Drawing.Font("Fira Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.txtConsole.Location = New System.Drawing.Point(6, 20)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtConsole.Size = New System.Drawing.Size(896, 279)
        Me.txtConsole.TabIndex = 19
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 17)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "Console"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTempCPU)
        Me.GroupBox5.Controls.Add(Me.lblTempHDD)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.lblTempSSD)
        Me.GroupBox5.Controls.Add(Me.lblTempCPUMax)
        Me.GroupBox5.Controls.Add(Me.lblTempHDDMax)
        Me.GroupBox5.Controls.Add(Me.lblTempSSDMax)
        Me.GroupBox5.Controls.Add(Me.cpbTempCPU)
        Me.GroupBox5.Controls.Add(Me.cpbTempHDD)
        Me.GroupBox5.Controls.Add(Me.cpbTempSSD)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(345, 231)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(336, 191)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'lblTempCPU
        '
        Me.lblTempCPU.AutoSize = True
        Me.lblTempCPU.Location = New System.Drawing.Point(233, 147)
        Me.lblTempCPU.Name = "lblTempCPU"
        Me.lblTempCPU.Size = New System.Drawing.Size(85, 17)
        Me.lblTempCPU.TabIndex = 16
        Me.lblTempCPU.Text = "Temperature"
        '
        'lblTempHDD
        '
        Me.lblTempHDD.AutoSize = True
        Me.lblTempHDD.Location = New System.Drawing.Point(125, 147)
        Me.lblTempHDD.Name = "lblTempHDD"
        Me.lblTempHDD.Size = New System.Drawing.Size(85, 17)
        Me.lblTempHDD.TabIndex = 17
        Me.lblTempHDD.Text = "Temperature"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(258, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "CPU"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(153, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 17)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "HDD"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "SSD"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempSSD
        '
        Me.lblTempSSD.AutoSize = True
        Me.lblTempSSD.Location = New System.Drawing.Point(15, 147)
        Me.lblTempSSD.Name = "lblTempSSD"
        Me.lblTempSSD.Size = New System.Drawing.Size(85, 17)
        Me.lblTempSSD.TabIndex = 15
        Me.lblTempSSD.Text = "Temperature"
        '
        'lblTempCPUMax
        '
        Me.lblTempCPUMax.AutoSize = True
        Me.lblTempCPUMax.Location = New System.Drawing.Point(233, 164)
        Me.lblTempCPUMax.Name = "lblTempCPUMax"
        Me.lblTempCPUMax.Size = New System.Drawing.Size(85, 17)
        Me.lblTempCPUMax.TabIndex = 30
        Me.lblTempCPUMax.Text = "Temperature"
        Me.lblTempCPUMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempHDDMax
        '
        Me.lblTempHDDMax.AutoSize = True
        Me.lblTempHDDMax.Location = New System.Drawing.Point(125, 164)
        Me.lblTempHDDMax.Name = "lblTempHDDMax"
        Me.lblTempHDDMax.Size = New System.Drawing.Size(85, 17)
        Me.lblTempHDDMax.TabIndex = 27
        Me.lblTempHDDMax.Text = "Temperature"
        Me.lblTempHDDMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempSSDMax
        '
        Me.lblTempSSDMax.AutoSize = True
        Me.lblTempSSDMax.Location = New System.Drawing.Point(15, 164)
        Me.lblTempSSDMax.Name = "lblTempSSDMax"
        Me.lblTempSSDMax.Size = New System.Drawing.Size(85, 17)
        Me.lblTempSSDMax.TabIndex = 24
        Me.lblTempSSDMax.Text = "Temperature"
        Me.lblTempSSDMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cpbTempCPU
        '
        Me.cpbTempCPU.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempCPU.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbTempCPU.Bar1.Enabled = True
        Me.cpbTempCPU.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbTempCPU.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempCPU.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempCPU.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbTempCPU.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempCPU.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempCPU.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempCPU.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbTempCPU.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempCPU.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempCPU.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempCPU.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbTempCPU.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempCPU.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempCPU.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempCPU.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbTempCPU.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempCPU.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempCPU.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbTempCPU.Image = Nothing
        Me.cpbTempCPU.Location = New System.Drawing.Point(221, 44)
        Me.cpbTempCPU.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbTempCPU.Name = "cpbTempCPU"
        Me.cpbTempCPU.Size = New System.Drawing.Size(100, 100)
        Me.cpbTempCPU.TabIndex = 22
        Me.cpbTempCPU.TextShadowColor = System.Drawing.Color.White
        '
        'cpbTempHDD
        '
        Me.cpbTempHDD.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempHDD.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbTempHDD.Bar1.Enabled = True
        Me.cpbTempHDD.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbTempHDD.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempHDD.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempHDD.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbTempHDD.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempHDD.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempHDD.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempHDD.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbTempHDD.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempHDD.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempHDD.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempHDD.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbTempHDD.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempHDD.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempHDD.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempHDD.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbTempHDD.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempHDD.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempHDD.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbTempHDD.Image = Nothing
        Me.cpbTempHDD.Location = New System.Drawing.Point(115, 44)
        Me.cpbTempHDD.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbTempHDD.Name = "cpbTempHDD"
        Me.cpbTempHDD.Size = New System.Drawing.Size(100, 100)
        Me.cpbTempHDD.TabIndex = 20
        Me.cpbTempHDD.TextShadowColor = System.Drawing.Color.White
        '
        'cpbTempSSD
        '
        Me.cpbTempSSD.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempSSD.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbTempSSD.Bar1.Enabled = True
        Me.cpbTempSSD.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbTempSSD.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempSSD.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempSSD.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbTempSSD.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempSSD.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempSSD.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempSSD.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbTempSSD.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempSSD.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempSSD.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempSSD.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbTempSSD.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempSSD.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempSSD.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbTempSSD.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbTempSSD.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbTempSSD.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbTempSSD.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbTempSSD.Image = Nothing
        Me.cpbTempSSD.Location = New System.Drawing.Point(9, 44)
        Me.cpbTempSSD.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbTempSSD.Name = "cpbTempSSD"
        Me.cpbTempSSD.Size = New System.Drawing.Size(100, 100)
        Me.cpbTempSSD.TabIndex = 18
        Me.cpbTempSSD.TextShadowColor = System.Drawing.Color.White
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 17)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Temperature"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblLastUpdate)
        Me.GroupBox4.Controls.Add(Me.lblWind3)
        Me.GroupBox4.Controls.Add(Me.lblWind2)
        Me.GroupBox4.Controls.Add(Me.lblWind1)
        Me.GroupBox4.Controls.Add(Me.lblTemp3)
        Me.GroupBox4.Controls.Add(Me.lblTemp2)
        Me.GroupBox4.Controls.Add(Me.lblTemp1)
        Me.GroupBox4.Controls.Add(Me.lblDate)
        Me.GroupBox4.Controls.Add(Me.lblWeather3)
        Me.GroupBox4.Controls.Add(Me.lblTime3)
        Me.GroupBox4.Controls.Add(Me.lblClock)
        Me.GroupBox4.Controls.Add(Me.lblName3)
        Me.GroupBox4.Controls.Add(Me.lblWeather2)
        Me.GroupBox4.Controls.Add(Me.lblTime2)
        Me.GroupBox4.Controls.Add(Me.lblName2)
        Me.GroupBox4.Controls.Add(Me.lblWeather1)
        Me.GroupBox4.Controls.Add(Me.lblTime1)
        Me.GroupBox4.Controls.Add(Me.lblName1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(687, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(223, 419)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Location = New System.Drawing.Point(6, 393)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(50, 17)
        Me.lblLastUpdate.TabIndex = 28
        Me.lblLastUpdate.Text = "Update"
        '
        'lblWind3
        '
        Me.lblWind3.AutoSize = True
        Me.lblWind3.Location = New System.Drawing.Point(6, 360)
        Me.lblWind3.Name = "lblWind3"
        Me.lblWind3.Size = New System.Drawing.Size(36, 17)
        Me.lblWind3.TabIndex = 27
        Me.lblWind3.Text = "Wind"
        '
        'lblWind2
        '
        Me.lblWind2.AutoSize = True
        Me.lblWind2.Location = New System.Drawing.Point(6, 260)
        Me.lblWind2.Name = "lblWind2"
        Me.lblWind2.Size = New System.Drawing.Size(36, 17)
        Me.lblWind2.TabIndex = 26
        Me.lblWind2.Text = "Wind"
        '
        'lblWind1
        '
        Me.lblWind1.AutoSize = True
        Me.lblWind1.Location = New System.Drawing.Point(6, 158)
        Me.lblWind1.Name = "lblWind1"
        Me.lblWind1.Size = New System.Drawing.Size(36, 17)
        Me.lblWind1.TabIndex = 25
        Me.lblWind1.Text = "Wind"
        '
        'lblTemp3
        '
        Me.lblTemp3.AutoSize = True
        Me.lblTemp3.Location = New System.Drawing.Point(6, 343)
        Me.lblTemp3.Name = "lblTemp3"
        Me.lblTemp3.Size = New System.Drawing.Size(85, 17)
        Me.lblTemp3.TabIndex = 24
        Me.lblTemp3.Text = "Temperature"
        '
        'lblTemp2
        '
        Me.lblTemp2.AutoSize = True
        Me.lblTemp2.Location = New System.Drawing.Point(6, 243)
        Me.lblTemp2.Name = "lblTemp2"
        Me.lblTemp2.Size = New System.Drawing.Size(85, 17)
        Me.lblTemp2.TabIndex = 23
        Me.lblTemp2.Text = "Temperature"
        '
        'lblTemp1
        '
        Me.lblTemp1.AutoSize = True
        Me.lblTemp1.Location = New System.Drawing.Point(6, 141)
        Me.lblTemp1.Name = "lblTemp1"
        Me.lblTemp1.Size = New System.Drawing.Size(85, 17)
        Me.lblTemp1.TabIndex = 22
        Me.lblTemp1.Text = "Temperature"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Fira Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(124, 52)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(90, 21)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "2022-04-11"
        '
        'lblWeather3
        '
        Me.lblWeather3.AutoSize = True
        Me.lblWeather3.Location = New System.Drawing.Point(6, 326)
        Me.lblWeather3.Name = "lblWeather3"
        Me.lblWeather3.Size = New System.Drawing.Size(57, 17)
        Me.lblWeather3.TabIndex = 21
        Me.lblWeather3.Text = "Weather"
        '
        'lblTime3
        '
        Me.lblTime3.AutoSize = True
        Me.lblTime3.Location = New System.Drawing.Point(6, 309)
        Me.lblTime3.Name = "lblTime3"
        Me.lblTime3.Size = New System.Drawing.Size(36, 17)
        Me.lblTime3.TabIndex = 20
        Me.lblTime3.Text = "Time"
        '
        'lblClock
        '
        Me.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClock.Font = New System.Drawing.Font("Fira Code", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(9, 18)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(209, 62)
        Me.lblClock.TabIndex = 5
        Me.lblClock.Text = "00:00:00 PM"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.Location = New System.Drawing.Point(6, 292)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(78, 17)
        Me.lblName3.TabIndex = 19
        Me.lblName3.Text = "Location 3"
        '
        'lblWeather2
        '
        Me.lblWeather2.AutoSize = True
        Me.lblWeather2.Location = New System.Drawing.Point(6, 227)
        Me.lblWeather2.Name = "lblWeather2"
        Me.lblWeather2.Size = New System.Drawing.Size(57, 17)
        Me.lblWeather2.TabIndex = 18
        Me.lblWeather2.Text = "Weather"
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Location = New System.Drawing.Point(6, 210)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(36, 17)
        Me.lblTime2.TabIndex = 17
        Me.lblTime2.Text = "Time"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Location = New System.Drawing.Point(6, 193)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(78, 17)
        Me.lblName2.TabIndex = 16
        Me.lblName2.Text = "Location 2"
        '
        'lblWeather1
        '
        Me.lblWeather1.AutoSize = True
        Me.lblWeather1.Location = New System.Drawing.Point(6, 124)
        Me.lblWeather1.Name = "lblWeather1"
        Me.lblWeather1.Size = New System.Drawing.Size(57, 17)
        Me.lblWeather1.TabIndex = 15
        Me.lblWeather1.Text = "Weather"
        '
        'lblTime1
        '
        Me.lblTime1.AutoSize = True
        Me.lblTime1.Location = New System.Drawing.Point(6, 107)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(36, 17)
        Me.lblTime1.TabIndex = 12
        Me.lblTime1.Text = "Time"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Location = New System.Drawing.Point(6, 90)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(78, 17)
        Me.lblName1.TabIndex = 11
        Me.lblName1.Text = "Location 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Weather"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblFree3)
        Me.GroupBox3.Controls.Add(Me.lblDT3)
        Me.GroupBox3.Controls.Add(Me.lblFree2)
        Me.GroupBox3.Controls.Add(Me.lblDT2)
        Me.GroupBox3.Controls.Add(Me.lblFree1)
        Me.GroupBox3.Controls.Add(Me.lblDT1)
        Me.GroupBox3.Controls.Add(Me.cpbDrive3)
        Me.GroupBox3.Controls.Add(Me.cpbDrive2)
        Me.GroupBox3.Controls.Add(Me.cpbDrive1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 191)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(258, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 17)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "HDD"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(154, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 17)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "HDD"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "SSD"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFree3
        '
        Me.lblFree3.AutoSize = True
        Me.lblFree3.Location = New System.Drawing.Point(233, 164)
        Me.lblFree3.Name = "lblFree3"
        Me.lblFree3.Size = New System.Drawing.Size(85, 17)
        Me.lblFree3.TabIndex = 30
        Me.lblFree3.Text = "Local Disks"
        Me.lblFree3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDT3
        '
        Me.lblDT3.AutoSize = True
        Me.lblDT3.Location = New System.Drawing.Point(233, 147)
        Me.lblDT3.Name = "lblDT3"
        Me.lblDT3.Size = New System.Drawing.Size(85, 17)
        Me.lblDT3.TabIndex = 29
        Me.lblDT3.Text = "Local Disks"
        Me.lblDT3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFree2
        '
        Me.lblFree2.AutoSize = True
        Me.lblFree2.Location = New System.Drawing.Point(125, 164)
        Me.lblFree2.Name = "lblFree2"
        Me.lblFree2.Size = New System.Drawing.Size(85, 17)
        Me.lblFree2.TabIndex = 27
        Me.lblFree2.Text = "Local Disks"
        Me.lblFree2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDT2
        '
        Me.lblDT2.AutoSize = True
        Me.lblDT2.Location = New System.Drawing.Point(125, 147)
        Me.lblDT2.Name = "lblDT2"
        Me.lblDT2.Size = New System.Drawing.Size(85, 17)
        Me.lblDT2.TabIndex = 26
        Me.lblDT2.Text = "Local Disks"
        Me.lblDT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFree1
        '
        Me.lblFree1.AutoSize = True
        Me.lblFree1.Location = New System.Drawing.Point(15, 164)
        Me.lblFree1.Name = "lblFree1"
        Me.lblFree1.Size = New System.Drawing.Size(85, 17)
        Me.lblFree1.TabIndex = 24
        Me.lblFree1.Text = "Local Disks"
        Me.lblFree1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDT1
        '
        Me.lblDT1.AutoSize = True
        Me.lblDT1.Location = New System.Drawing.Point(15, 147)
        Me.lblDT1.Name = "lblDT1"
        Me.lblDT1.Size = New System.Drawing.Size(85, 17)
        Me.lblDT1.TabIndex = 23
        Me.lblDT1.Text = "Local Disks"
        Me.lblDT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cpbDrive3
        '
        Me.cpbDrive3.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive3.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive3.Bar1.Enabled = True
        Me.cpbDrive3.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbDrive3.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive3.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive3.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive3.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive3.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive3.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive3.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive3.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive3.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive3.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive3.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive3.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive3.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive3.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive3.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive3.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive3.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive3.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbDrive3.Image = Nothing
        Me.cpbDrive3.Location = New System.Drawing.Point(221, 44)
        Me.cpbDrive3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbDrive3.Name = "cpbDrive3"
        Me.cpbDrive3.Size = New System.Drawing.Size(100, 100)
        Me.cpbDrive3.TabIndex = 22
        Me.cpbDrive3.TextShadowColor = System.Drawing.Color.White
        '
        'cpbDrive2
        '
        Me.cpbDrive2.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive2.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive2.Bar1.Enabled = True
        Me.cpbDrive2.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbDrive2.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive2.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive2.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive2.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive2.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive2.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive2.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive2.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive2.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive2.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive2.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive2.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive2.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive2.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive2.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive2.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive2.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive2.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbDrive2.Image = Nothing
        Me.cpbDrive2.Location = New System.Drawing.Point(115, 44)
        Me.cpbDrive2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbDrive2.Name = "cpbDrive2"
        Me.cpbDrive2.Size = New System.Drawing.Size(100, 100)
        Me.cpbDrive2.TabIndex = 20
        Me.cpbDrive2.TextShadowColor = System.Drawing.Color.White
        '
        'cpbDrive1
        '
        Me.cpbDrive1.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive1.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive1.Bar1.Enabled = True
        Me.cpbDrive1.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbDrive1.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive1.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive1.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive1.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive1.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive1.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive1.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive1.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive1.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive1.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive1.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive1.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive1.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive1.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbDrive1.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbDrive1.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbDrive1.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbDrive1.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbDrive1.Image = Nothing
        Me.cpbDrive1.Location = New System.Drawing.Point(9, 44)
        Me.cpbDrive1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbDrive1.Name = "cpbDrive1"
        Me.cpbDrive1.Size = New System.Drawing.Size(100, 100)
        Me.cpbDrive1.TabIndex = 18
        Me.cpbDrive1.TextShadowColor = System.Drawing.Color.White
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Local Disks"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTimeToDischarge)
        Me.GroupBox2.Controls.Add(Me.lblTimeToCharge)
        Me.GroupBox2.Controls.Add(Me.lblBatStatus)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cpbBattery)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(345, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 222)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblTimeToDischarge
        '
        Me.lblTimeToDischarge.AutoSize = True
        Me.lblTimeToDischarge.Location = New System.Drawing.Point(6, 180)
        Me.lblTimeToDischarge.Name = "lblTimeToDischarge"
        Me.lblTimeToDischarge.Size = New System.Drawing.Size(36, 17)
        Me.lblTimeToDischarge.TabIndex = 14
        Me.lblTimeToDischarge.Text = "Time"
        '
        'lblTimeToCharge
        '
        Me.lblTimeToCharge.AutoSize = True
        Me.lblTimeToCharge.Location = New System.Drawing.Point(6, 163)
        Me.lblTimeToCharge.Name = "lblTimeToCharge"
        Me.lblTimeToCharge.Size = New System.Drawing.Size(36, 17)
        Me.lblTimeToCharge.TabIndex = 13
        Me.lblTimeToCharge.Text = "Time"
        '
        'lblBatStatus
        '
        Me.lblBatStatus.AutoSize = True
        Me.lblBatStatus.Location = New System.Drawing.Point(6, 146)
        Me.lblBatStatus.Name = "lblBatStatus"
        Me.lblBatStatus.Size = New System.Drawing.Size(50, 17)
        Me.lblBatStatus.TabIndex = 12
        Me.lblBatStatus.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Battery"
        '
        'cpbBattery
        '
        Me.cpbBattery.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbBattery.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbBattery.Bar1.Enabled = True
        Me.cpbBattery.Bar1.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbBattery.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbBattery.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbBattery.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbBattery.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbBattery.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbBattery.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbBattery.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbBattery.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbBattery.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbBattery.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbBattery.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbBattery.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbBattery.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbBattery.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbBattery.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbBattery.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbBattery.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbBattery.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbBattery.Image = Nothing
        Me.cpbBattery.Location = New System.Drawing.Point(115, 38)
        Me.cpbBattery.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbBattery.Name = "cpbBattery"
        Me.cpbBattery.Size = New System.Drawing.Size(100, 100)
        Me.cpbBattery.TabIndex = 9
        Me.cpbBattery.TextShadowColor = System.Drawing.Color.White
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Power Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVRam)
        Me.GroupBox1.Controls.Add(Me.lblRam)
        Me.GroupBox1.Controls.Add(Me.lblCPU)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cpbProcessor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cpbVRam)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cpbRam)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 222)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Performance"
        '
        'lblVRam
        '
        Me.lblVRam.AutoSize = True
        Me.lblVRam.Location = New System.Drawing.Point(6, 180)
        Me.lblVRam.Name = "lblVRam"
        Me.lblVRam.Size = New System.Drawing.Size(36, 17)
        Me.lblVRam.TabIndex = 14
        Me.lblVRam.Text = "VRAM"
        '
        'lblRam
        '
        Me.lblRam.AutoSize = True
        Me.lblRam.Location = New System.Drawing.Point(6, 163)
        Me.lblRam.Name = "lblRam"
        Me.lblRam.Size = New System.Drawing.Size(29, 17)
        Me.lblRam.TabIndex = 13
        Me.lblRam.Text = "RAM"
        '
        'lblCPU
        '
        Me.lblCPU.AutoSize = True
        Me.lblCPU.Location = New System.Drawing.Point(6, 146)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(29, 17)
        Me.lblCPU.TabIndex = 12
        Me.lblCPU.Text = "CPU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Performance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CPU"
        '
        'cpbProcessor
        '
        Me.cpbProcessor.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbProcessor.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbProcessor.Bar1.Enabled = True
        Me.cpbProcessor.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbProcessor.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbProcessor.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbProcessor.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbProcessor.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbProcessor.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbProcessor.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbProcessor.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbProcessor.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbProcessor.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbProcessor.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbProcessor.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbProcessor.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbProcessor.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbProcessor.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbProcessor.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbProcessor.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbProcessor.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbProcessor.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbProcessor.Image = Nothing
        Me.cpbProcessor.Location = New System.Drawing.Point(221, 38)
        Me.cpbProcessor.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbProcessor.Name = "cpbProcessor"
        Me.cpbProcessor.Size = New System.Drawing.Size(100, 100)
        Me.cpbProcessor.TabIndex = 5
        Me.cpbProcessor.TextShadowColor = System.Drawing.Color.White
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "VRAM"
        '
        'cpbVRam
        '
        Me.cpbVRam.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbVRam.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbVRam.Bar1.Enabled = True
        Me.cpbVRam.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbVRam.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbVRam.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbVRam.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbVRam.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbVRam.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbVRam.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbVRam.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbVRam.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbVRam.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbVRam.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbVRam.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbVRam.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbVRam.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbVRam.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbVRam.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbVRam.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbVRam.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbVRam.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbVRam.Image = Nothing
        Me.cpbVRam.Location = New System.Drawing.Point(115, 38)
        Me.cpbVRam.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbVRam.Name = "cpbVRam"
        Me.cpbVRam.Size = New System.Drawing.Size(100, 100)
        Me.cpbVRam.TabIndex = 3
        Me.cpbVRam.TextShadowColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RAM"
        '
        'cpbRam
        '
        Me.cpbRam.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbRam.Bar1.BorderColor = System.Drawing.Color.Black
        Me.cpbRam.Bar1.Enabled = True
        Me.cpbRam.Bar1.FinishColor = System.Drawing.Color.Crimson
        Me.cpbRam.Bar1.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbRam.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbRam.Bar2.BorderColor = System.Drawing.Color.Black
        Me.cpbRam.Bar2.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbRam.Bar2.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbRam.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbRam.Bar3.BorderColor = System.Drawing.Color.Black
        Me.cpbRam.Bar3.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbRam.Bar3.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbRam.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbRam.Bar4.BorderColor = System.Drawing.Color.Black
        Me.cpbRam.Bar4.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbRam.Bar4.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbRam.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen
        Me.cpbRam.Bar5.BorderColor = System.Drawing.Color.Black
        Me.cpbRam.Bar5.FinishColor = System.Drawing.Color.LightGreen
        Me.cpbRam.Bar5.InactiveColor = System.Drawing.Color.LightGray
        Me.cpbRam.Font = New System.Drawing.Font("Fira Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpbRam.Image = Nothing
        Me.cpbRam.Location = New System.Drawing.Point(9, 38)
        Me.cpbRam.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cpbRam.Name = "cpbRam"
        Me.cpbRam.Size = New System.Drawing.Size(100, 100)
        Me.cpbRam.TabIndex = 1
        Me.cpbRam.TextShadowColor = System.Drawing.Color.White
        '
        'tbxTimeTable1
        '
        Me.tbxTimeTable1.Controls.Add(Me.wbTimeTable1)
        Me.tbxTimeTable1.Location = New System.Drawing.Point(4, 25)
        Me.tbxTimeTable1.Name = "tbxTimeTable1"
        Me.tbxTimeTable1.Size = New System.Drawing.Size(914, 736)
        Me.tbxTimeTable1.TabIndex = 8
        Me.tbxTimeTable1.Text = "Time Table 1"
        '
        'wbTimeTable1
        '
        Me.wbTimeTable1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbTimeTable1.Location = New System.Drawing.Point(0, 0)
        Me.wbTimeTable1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbTimeTable1.Name = "wbTimeTable1"
        Me.wbTimeTable1.Size = New System.Drawing.Size(914, 736)
        Me.wbTimeTable1.TabIndex = 1
        '
        'tbxCourseFiles
        '
        Me.tbxCourseFiles.Controls.Add(Me.btnBack)
        Me.tbxCourseFiles.Controls.Add(Me.wbCourseFiles)
        Me.tbxCourseFiles.Location = New System.Drawing.Point(4, 25)
        Me.tbxCourseFiles.Name = "tbxCourseFiles"
        Me.tbxCourseFiles.Size = New System.Drawing.Size(914, 736)
        Me.tbxCourseFiles.TabIndex = 3
        Me.tbxCourseFiles.Text = "Course Files"
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(867, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(43, 43)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "<<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'wbCourseFiles
        '
        Me.wbCourseFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbCourseFiles.Location = New System.Drawing.Point(0, 0)
        Me.wbCourseFiles.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCourseFiles.Name = "wbCourseFiles"
        Me.wbCourseFiles.Size = New System.Drawing.Size(914, 736)
        Me.wbCourseFiles.TabIndex = 0
        '
        'tbxTools
        '
        Me.tbxTools.Controls.Add(Me.GroupBox7)
        Me.tbxTools.Controls.Add(Me.GroupBox9)
        Me.tbxTools.Controls.Add(Me.GroupBox8)
        Me.tbxTools.Location = New System.Drawing.Point(4, 25)
        Me.tbxTools.Name = "tbxTools"
        Me.tbxTools.Size = New System.Drawing.Size(914, 736)
        Me.tbxTools.TabIndex = 4
        Me.tbxTools.Text = "Tools"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Location = New System.Drawing.Point(4, 263)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(906, 466)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "S"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 17)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Empty Space"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Location = New System.Drawing.Point(439, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(471, 254)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Ta"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(85, 17)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Empty Space"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtAuth)
        Me.GroupBox8.Controls.Add(Me.btnAuth)
        Me.GroupBox8.Controls.Add(Me.lblStat)
        Me.GroupBox8.Controls.Add(Me.lblProcName)
        Me.GroupBox8.Controls.Add(Me.lblAuth)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(429, 254)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Ta"
        '
        'txtAuth
        '
        Me.txtAuth.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuth.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtAuth.Location = New System.Drawing.Point(10, 96)
        Me.txtAuth.Name = "txtAuth"
        Me.txtAuth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAuth.Size = New System.Drawing.Size(258, 22)
        Me.txtAuth.TabIndex = 17
        '
        'btnAuth
        '
        Me.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuth.Location = New System.Drawing.Point(274, 93)
        Me.btnAuth.Name = "btnAuth"
        Me.btnAuth.Size = New System.Drawing.Size(117, 26)
        Me.btnAuth.TabIndex = 16
        Me.btnAuth.Text = "Auth"
        Me.btnAuth.UseVisualStyleBackColor = True
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Location = New System.Drawing.Point(133, 56)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(92, 17)
        Me.lblStat.TabIndex = 15
        Me.lblStat.Text = "Initializing"
        '
        'lblProcName
        '
        Me.lblProcName.AutoSize = True
        Me.lblProcName.Location = New System.Drawing.Point(133, 18)
        Me.lblProcName.Name = "lblProcName"
        Me.lblProcName.Size = New System.Drawing.Size(92, 17)
        Me.lblProcName.TabIndex = 14
        Me.lblProcName.Text = "Initializing"
        '
        'lblAuth
        '
        Me.lblAuth.AutoSize = True
        Me.lblAuth.Location = New System.Drawing.Point(133, 37)
        Me.lblAuth.Name = "lblAuth"
        Me.lblAuth.Size = New System.Drawing.Size(92, 17)
        Me.lblAuth.TabIndex = 13
        Me.lblAuth.Text = "Initializing"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 17)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Status         :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 17)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Authentication :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 17)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Process Name   :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Process Control"
        '
        'tbxCalendar
        '
        Me.tbxCalendar.Controls.Add(Me.wbCalendar)
        Me.tbxCalendar.Location = New System.Drawing.Point(4, 25)
        Me.tbxCalendar.Name = "tbxCalendar"
        Me.tbxCalendar.Size = New System.Drawing.Size(914, 736)
        Me.tbxCalendar.TabIndex = 5
        Me.tbxCalendar.Text = "Calendar"
        '
        'wbCalendar
        '
        Me.wbCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbCalendar.Location = New System.Drawing.Point(0, 0)
        Me.wbCalendar.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCalendar.Name = "wbCalendar"
        Me.wbCalendar.Size = New System.Drawing.Size(914, 736)
        Me.wbCalendar.TabIndex = 0
        '
        'tbxTimeTable0
        '
        Me.tbxTimeTable0.Controls.Add(Me.wbTimeTable0)
        Me.tbxTimeTable0.Location = New System.Drawing.Point(4, 25)
        Me.tbxTimeTable0.Name = "tbxTimeTable0"
        Me.tbxTimeTable0.Size = New System.Drawing.Size(914, 736)
        Me.tbxTimeTable0.TabIndex = 7
        Me.tbxTimeTable0.Text = "Time Table 0"
        '
        'wbTimeTable0
        '
        Me.wbTimeTable0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbTimeTable0.Location = New System.Drawing.Point(0, 0)
        Me.wbTimeTable0.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbTimeTable0.Name = "wbTimeTable0"
        Me.wbTimeTable0.Size = New System.Drawing.Size(914, 736)
        Me.wbTimeTable0.TabIndex = 0
        '
        'tbxGraphPlotter
        '
        Me.tbxGraphPlotter.Controls.Add(Me.lblInter)
        Me.tbxGraphPlotter.Controls.Add(Me.chtGraph)
        Me.tbxGraphPlotter.Controls.Add(Me.btnPlot)
        Me.tbxGraphPlotter.Controls.Add(Me.btnClear)
        Me.tbxGraphPlotter.Controls.Add(Me.btnLoad)
        Me.tbxGraphPlotter.Controls.Add(Me.btnSave)
        Me.tbxGraphPlotter.Controls.Add(Me.txtYPoints)
        Me.tbxGraphPlotter.Controls.Add(Me.Label23)
        Me.tbxGraphPlotter.Controls.Add(Me.txtXPoints)
        Me.tbxGraphPlotter.Controls.Add(Me.Label24)
        Me.tbxGraphPlotter.Controls.Add(Me.lblYRange)
        Me.tbxGraphPlotter.Controls.Add(Me.lblXRange)
        Me.tbxGraphPlotter.Controls.Add(Me.lblGrad)
        Me.tbxGraphPlotter.Controls.Add(Me.lblG)
        Me.tbxGraphPlotter.Controls.Add(Me.txtEVal)
        Me.tbxGraphPlotter.Controls.Add(Me.Label15)
        Me.tbxGraphPlotter.Controls.Add(Me.txtSVal)
        Me.tbxGraphPlotter.Controls.Add(Me.Label16)
        Me.tbxGraphPlotter.Controls.Add(Me.txtDiv)
        Me.tbxGraphPlotter.Controls.Add(Me.Label17)
        Me.tbxGraphPlotter.Controls.Add(Me.txtMaxY)
        Me.tbxGraphPlotter.Controls.Add(Me.txtMaxX)
        Me.tbxGraphPlotter.Controls.Add(Me.Label18)
        Me.tbxGraphPlotter.Controls.Add(Me.Label22)
        Me.tbxGraphPlotter.Controls.Add(Me.txtYList)
        Me.tbxGraphPlotter.Controls.Add(Me.Label14)
        Me.tbxGraphPlotter.Controls.Add(Me.txtXList)
        Me.tbxGraphPlotter.Controls.Add(Me.Label13)
        Me.tbxGraphPlotter.Location = New System.Drawing.Point(4, 25)
        Me.tbxGraphPlotter.Name = "tbxGraphPlotter"
        Me.tbxGraphPlotter.Size = New System.Drawing.Size(914, 736)
        Me.tbxGraphPlotter.TabIndex = 6
        Me.tbxGraphPlotter.Text = "Graph Plotter"
        '
        'lblInter
        '
        Me.lblInter.AutoSize = True
        Me.lblInter.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblInter.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInter.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblInter.Location = New System.Drawing.Point(3, 702)
        Me.lblInter.Name = "lblInter"
        Me.lblInter.Size = New System.Drawing.Size(121, 19)
        Me.lblInter.TabIndex = 59
        Me.lblInter.Text = "0000000000000000"
        '
        'chtGraph
        '
        Me.chtGraph.BackColor = System.Drawing.Color.DarkSlateGray
        Me.chtGraph.BorderlineColor = System.Drawing.Color.DarkGray
        Me.chtGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chtGraph.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.chtGraph.BorderSkin.BorderColor = System.Drawing.Color.White
        Me.chtGraph.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chtGraph.BorderSkin.BorderWidth = 5
        ChartArea1.BackColor = System.Drawing.Color.DarkSlateGray
        ChartArea1.Name = "ChartArea1"
        Me.chtGraph.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtGraph.Legends.Add(Legend1)
        Me.chtGraph.Location = New System.Drawing.Point(307, 3)
        Me.chtGraph.Name = "chtGraph"
        Series1.BorderColor = System.Drawing.Color.PowderBlue
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.PaleVioletRed
        Series1.Legend = "Legend1"
        Series1.Name = "Actual"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Khaki
        Series2.Legend = "Legend1"
        Series2.Name = "Regression"
        Me.chtGraph.Series.Add(Series1)
        Me.chtGraph.Series.Add(Series2)
        Me.chtGraph.Size = New System.Drawing.Size(604, 726)
        Me.chtGraph.TabIndex = 58
        Me.chtGraph.Text = "Chart1"
        '
        'btnPlot
        '
        Me.btnPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlot.Location = New System.Drawing.Point(7, 368)
        Me.btnPlot.Name = "btnPlot"
        Me.btnPlot.Size = New System.Drawing.Size(69, 23)
        Me.btnPlot.TabIndex = 57
        Me.btnPlot.Text = "Plot"
        Me.btnPlot.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(82, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 23)
        Me.btnClear.TabIndex = 56
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Location = New System.Drawing.Point(157, 368)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(69, 23)
        Me.btnLoad.TabIndex = 55
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(232, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 23)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtYPoints
        '
        Me.txtYPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtYPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYPoints.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtYPoints.Location = New System.Drawing.Point(154, 428)
        Me.txtYPoints.Multiline = True
        Me.txtYPoints.Name = "txtYPoints"
        Me.txtYPoints.ReadOnly = True
        Me.txtYPoints.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtYPoints.Size = New System.Drawing.Size(147, 191)
        Me.txtYPoints.TabIndex = 52
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(157, 408)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 17)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Y Point List"
        '
        'txtXPoints
        '
        Me.txtXPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtXPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtXPoints.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtXPoints.Location = New System.Drawing.Point(4, 428)
        Me.txtXPoints.Multiline = True
        Me.txtXPoints.Name = "txtXPoints"
        Me.txtXPoints.ReadOnly = True
        Me.txtXPoints.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXPoints.Size = New System.Drawing.Size(147, 191)
        Me.txtXPoints.TabIndex = 50
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 408)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 17)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "X Point List"
        '
        'lblYRange
        '
        Me.lblYRange.AutoSize = True
        Me.lblYRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblYRange.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRange.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblYRange.Location = New System.Drawing.Point(3, 645)
        Me.lblYRange.Name = "lblYRange"
        Me.lblYRange.Size = New System.Drawing.Size(121, 19)
        Me.lblYRange.TabIndex = 46
        Me.lblYRange.Text = "0000000000000000"
        '
        'lblXRange
        '
        Me.lblXRange.AutoSize = True
        Me.lblXRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblXRange.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXRange.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblXRange.Location = New System.Drawing.Point(3, 626)
        Me.lblXRange.Name = "lblXRange"
        Me.lblXRange.Size = New System.Drawing.Size(121, 19)
        Me.lblXRange.TabIndex = 45
        Me.lblXRange.Text = "0000000000000000"
        '
        'lblGrad
        '
        Me.lblGrad.AutoSize = True
        Me.lblGrad.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblGrad.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrad.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblGrad.Location = New System.Drawing.Point(3, 683)
        Me.lblGrad.Name = "lblGrad"
        Me.lblGrad.Size = New System.Drawing.Size(121, 19)
        Me.lblGrad.TabIndex = 48
        Me.lblGrad.Text = "0000000000000000"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblG.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblG.Location = New System.Drawing.Point(3, 664)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(121, 19)
        Me.lblG.TabIndex = 47
        Me.lblG.Text = "0000000000000000"
        '
        'txtEVal
        '
        Me.txtEVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtEVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEVal.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEVal.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtEVal.Location = New System.Drawing.Point(172, 340)
        Me.txtEVal.Name = "txtEVal"
        Me.txtEVal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtEVal.Size = New System.Drawing.Size(129, 23)
        Me.txtEVal.TabIndex = 44
        Me.txtEVal.Text = "180, 250"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label15.Location = New System.Drawing.Point(3, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Ending values (X, Y)"
        '
        'txtSVal
        '
        Me.txtSVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtSVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSVal.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSVal.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtSVal.Location = New System.Drawing.Point(172, 311)
        Me.txtSVal.Name = "txtSVal"
        Me.txtSVal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtSVal.Size = New System.Drawing.Size(129, 23)
        Me.txtSVal.TabIndex = 42
        Me.txtSVal.Text = "0, 0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label16.Location = New System.Drawing.Point(3, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 19)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Starting values (X, Y)"
        '
        'txtDiv
        '
        Me.txtDiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiv.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiv.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtDiv.Location = New System.Drawing.Point(172, 283)
        Me.txtDiv.Name = "txtDiv"
        Me.txtDiv.Size = New System.Drawing.Size(129, 23)
        Me.txtDiv.TabIndex = 40
        Me.txtDiv.Text = "10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label17.Location = New System.Drawing.Point(3, 285)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 19)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Divisions per 1cm"
        '
        'txtMaxY
        '
        Me.txtMaxY.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtMaxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaxY.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxY.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtMaxY.Location = New System.Drawing.Point(172, 255)
        Me.txtMaxY.Name = "txtMaxY"
        Me.txtMaxY.Size = New System.Drawing.Size(129, 23)
        Me.txtMaxY.TabIndex = 38
        Me.txtMaxY.Text = "25"
        '
        'txtMaxX
        '
        Me.txtMaxX.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtMaxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaxX.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxX.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtMaxX.Location = New System.Drawing.Point(172, 227)
        Me.txtMaxX.Name = "txtMaxX"
        Me.txtMaxX.Size = New System.Drawing.Size(129, 23)
        Me.txtMaxX.TabIndex = 37
        Me.txtMaxX.Text = "18"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label18.Location = New System.Drawing.Point(3, 257)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 19)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Max Y length (cm)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Fira Code", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label22.Location = New System.Drawing.Point(3, 229)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 19)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Max X length (cm)"
        '
        'txtYList
        '
        Me.txtYList.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtYList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYList.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtYList.Location = New System.Drawing.Point(154, 30)
        Me.txtYList.Multiline = True
        Me.txtYList.Name = "txtYList"
        Me.txtYList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtYList.Size = New System.Drawing.Size(147, 191)
        Me.txtYList.TabIndex = 4
        Me.txtYList.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "36" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "49" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "64" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "81"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(154, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Y Value List"
        '
        'txtXList
        '
        Me.txtXList.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtXList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtXList.ForeColor = System.Drawing.Color.PowderBlue
        Me.txtXList.Location = New System.Drawing.Point(4, 29)
        Me.txtXList.Multiline = True
        Me.txtXList.Name = "txtXList"
        Me.txtXList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXList.Size = New System.Drawing.Size(147, 191)
        Me.txtXList.TabIndex = 2
        Me.txtXList.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "X Value List"
        '
        'tmrWeather
        '
        Me.tmrWeather.Enabled = True
        Me.tmrWeather.Interval = 600000
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.Color.IndianRed
        Me.lblEnd.Location = New System.Drawing.Point(925, 2)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(20, 21)
        Me.lblEnd.TabIndex = 13
        Me.lblEnd.Text = "X"
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'tmrProcCtrl
        '
        Me.tmrProcCtrl.Enabled = True
        Me.tmrProcCtrl.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 749)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.tbxTabPool)
        Me.Controls.Add(Me.lblPanelControl)
        Me.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Opacity = 0.93R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "🌞 卐 රිවිරැස  卐 🌝"
        Me.tbxTabPool.ResumeLayout(False)
        Me.tbxSystem.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbxTimeTable1.ResumeLayout(False)
        Me.tbxCourseFiles.ResumeLayout(False)
        Me.tbxTools.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tbxCalendar.ResumeLayout(False)
        Me.tbxTimeTable0.ResumeLayout(False)
        Me.tbxGraphPlotter.ResumeLayout(False)
        Me.tbxGraphPlotter.PerformLayout()
        CType(Me.chtGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents lblPanelControl As Label
    Friend WithEvents tbxTabPool As Dotnetrix.Controls.TabControlEX
    Friend WithEvents tbxSystem As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tbxCourseFiles As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tbxTools As Dotnetrix.Controls.TabPageEX
    Friend WithEvents tbxCalendar As Dotnetrix.Controls.TabPageEX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cpbRam As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents cpbProcessor As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents cpbVRam As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cpbBattery As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents lblTimeToDischarge As Label
    Friend WithEvents lblTimeToCharge As Label
    Friend WithEvents lblBatStatus As Label
    Friend WithEvents lblVRam As Label
    Friend WithEvents lblRam As Label
    Friend WithEvents lblCPU As Label
    Friend WithEvents lblTempSSD As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cpbDrive3 As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents cpbDrive2 As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents cpbDrive1 As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents lblFree3 As Label
    Friend WithEvents lblDT3 As Label
    Friend WithEvents lblFree2 As Label
    Friend WithEvents lblDT2 As Label
    Friend WithEvents lblFree1 As Label
    Friend WithEvents lblDT1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTime1 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents lblWeather1 As Label
    Friend WithEvents lblWeather3 As Label
    Friend WithEvents lblTime3 As Label
    Friend WithEvents lblName3 As Label
    Friend WithEvents lblWeather2 As Label
    Friend WithEvents lblTime2 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblTemp3 As Label
    Friend WithEvents lblTemp2 As Label
    Friend WithEvents lblTemp1 As Label
    Friend WithEvents tmrWeather As Timer
    Friend WithEvents lblWind1 As Label
    Friend WithEvents lblWind3 As Label
    Friend WithEvents lblWind2 As Label
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents lblTempHDD As Label
    Friend WithEvents lblTempCPU As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTempCPUMax As Label
    Friend WithEvents lblTempHDDMax As Label
    Friend WithEvents lblTempSSDMax As Label
    Friend WithEvents cpbTempCPU As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents cpbTempHDD As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents cpbTempSSD As CircularProgressBar.CircularProgress.CircularProgressBar
    Friend WithEvents Label19 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents wbCourseFiles As WebBrowser
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents tbxGraphPlotter As Dotnetrix.Controls.TabPageEX
    Friend WithEvents txtYList As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtXList As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEVal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSVal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDiv As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMaxY As TextBox
    Friend WithEvents txtMaxX As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblYRange As Label
    Friend WithEvents lblXRange As Label
    Friend WithEvents lblGrad As Label
    Friend WithEvents lblG As Label
    Friend WithEvents txtYPoints As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtXPoints As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnPlot As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents chtGraph As DataVisualization.Charting.Chart
    Friend WithEvents lblInter As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtConsole As TextBox
    Friend WithEvents tmrTime As Timer
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tbxTimeTable0 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents wbTimeTable0 As WebBrowser
    Friend WithEvents wbCalendar As WebBrowser
    Friend WithEvents tbxTimeTable1 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents wbTimeTable1 As WebBrowser
    Friend WithEvents txtAuth As TextBox
    Friend WithEvents btnAuth As Button
    Friend WithEvents lblStat As Label
    Friend WithEvents lblProcName As Label
    Friend WithEvents lblAuth As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents tmrProcCtrl As Timer
End Class
