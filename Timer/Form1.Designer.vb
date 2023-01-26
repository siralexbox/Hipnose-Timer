<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TimerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCountdown = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonHourUp = New System.Windows.Forms.Button()
        Me.ButtonMinUp = New System.Windows.Forms.Button()
        Me.ButtonSecUp = New System.Windows.Forms.Button()
        Me.ButtonHourDown = New System.Windows.Forms.Button()
        Me.ButtonMinDown = New System.Windows.Forms.Button()
        Me.ButtonSecDown = New System.Windows.Forms.Button()
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.LabelSetTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LabelPastTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelShowEnd = New System.Windows.Forms.Label()
        Me.LabelShowDate = New System.Windows.Forms.Label()
        Me.LabelCurentTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TimerTimeOfDay = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCountUp = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.CheckBoxSenMsg = New System.Windows.Forms.CheckBox()
        Me.ButtonShowTimer = New System.Windows.Forms.Button()
        Me.ButtonShowClock = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxMsg = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.ButtonJog1SecUp = New System.Windows.Forms.Button()
        Me.ButtonJog1SecDown = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButtonJog1MinUp = New System.Windows.Forms.Button()
        Me.ButtonJog5MinUp = New System.Windows.Forms.Button()
        Me.ButtonJog1MinDown = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonJog5MinDown = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CountdownColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoountdownFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBelow0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CurrentTimeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClockColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClockFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialogBackground = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogCountdown = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogMsg = New System.Windows.Forms.ColorDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FontDialogCountdown = New System.Windows.Forms.FontDialog()
        Me.FontDialogMsg = New System.Windows.Forms.FontDialog()
        Me.ColorDialogClock = New System.Windows.Forms.ColorDialog()
        Me.FontDialogClock = New System.Windows.Forms.FontDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxStart = New System.Windows.Forms.CheckBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TimerCountNegative = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerCountdown
        '
        Me.TimerCountdown.Interval = 1000
        '
        'LabelCountdown
        '
        Me.LabelCountdown.AutoSize = True
        Me.LabelCountdown.BackColor = System.Drawing.Color.Transparent
        Me.LabelCountdown.Font = New System.Drawing.Font("Microsoft Tai Le", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountdown.ForeColor = System.Drawing.Color.Green
        Me.LabelCountdown.Location = New System.Drawing.Point(-10, 30)
        Me.LabelCountdown.Name = "LabelCountdown"
        Me.LabelCountdown.Size = New System.Drawing.Size(363, 101)
        Me.LabelCountdown.TabIndex = 0
        Me.LabelCountdown.Text = "00:00:00"
        Me.LabelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(17, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.TabStop = False
        Me.Button2.Text = "00:01:00"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(143, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 47)
        Me.Button3.TabIndex = 3
        Me.Button3.TabStop = False
        Me.Button3.Text = "00:10:00"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(270, 226)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 47)
        Me.Button6.TabIndex = 6
        Me.Button6.TabStop = False
        Me.Button6.Text = "00:15:00"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Location = New System.Drawing.Point(17, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(370, 170)
        Me.Panel1.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.ButtonHourUp)
        Me.Panel9.Controls.Add(Me.ButtonMinUp)
        Me.Panel9.Controls.Add(Me.ButtonSecUp)
        Me.Panel9.Controls.Add(Me.ButtonHourDown)
        Me.Panel9.Controls.Add(Me.ButtonMinDown)
        Me.Panel9.Controls.Add(Me.ButtonSecDown)
        Me.Panel9.Controls.Add(Me.LabelHour)
        Me.Panel9.Controls.Add(Me.LabelSetTime)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(2, 2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(364, 164)
        Me.Panel9.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(124, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Ctrl + Click to set"
        '
        'ButtonHourUp
        '
        Me.ButtonHourUp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHourUp.BackgroundImage = Global.Timer.My.Resources.Resources.up_white
        Me.ButtonHourUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonHourUp.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonHourUp.FlatAppearance.BorderSize = 0
        Me.ButtonHourUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHourUp.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHourUp.Location = New System.Drawing.Point(86, 21)
        Me.ButtonHourUp.Name = "ButtonHourUp"
        Me.ButtonHourUp.Size = New System.Drawing.Size(32, 32)
        Me.ButtonHourUp.TabIndex = 32
        Me.ButtonHourUp.UseVisualStyleBackColor = False
        '
        'ButtonMinUp
        '
        Me.ButtonMinUp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMinUp.BackgroundImage = Global.Timer.My.Resources.Resources.up_white
        Me.ButtonMinUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonMinUp.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonMinUp.FlatAppearance.BorderSize = 0
        Me.ButtonMinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinUp.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinUp.Location = New System.Drawing.Point(175, 21)
        Me.ButtonMinUp.Name = "ButtonMinUp"
        Me.ButtonMinUp.Size = New System.Drawing.Size(32, 32)
        Me.ButtonMinUp.TabIndex = 31
        Me.ButtonMinUp.UseVisualStyleBackColor = False
        '
        'ButtonSecUp
        '
        Me.ButtonSecUp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSecUp.BackgroundImage = Global.Timer.My.Resources.Resources.up_white
        Me.ButtonSecUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSecUp.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonSecUp.FlatAppearance.BorderSize = 0
        Me.ButtonSecUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSecUp.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSecUp.Location = New System.Drawing.Point(267, 21)
        Me.ButtonSecUp.Name = "ButtonSecUp"
        Me.ButtonSecUp.Size = New System.Drawing.Size(32, 32)
        Me.ButtonSecUp.TabIndex = 30
        Me.ButtonSecUp.UseVisualStyleBackColor = False
        '
        'ButtonHourDown
        '
        Me.ButtonHourDown.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHourDown.BackgroundImage = Global.Timer.My.Resources.Resources.down_white
        Me.ButtonHourDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonHourDown.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonHourDown.FlatAppearance.BorderSize = 0
        Me.ButtonHourDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHourDown.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHourDown.Location = New System.Drawing.Point(85, 105)
        Me.ButtonHourDown.Name = "ButtonHourDown"
        Me.ButtonHourDown.Size = New System.Drawing.Size(32, 32)
        Me.ButtonHourDown.TabIndex = 29
        Me.ButtonHourDown.UseVisualStyleBackColor = False
        '
        'ButtonMinDown
        '
        Me.ButtonMinDown.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMinDown.BackgroundImage = Global.Timer.My.Resources.Resources.down_white
        Me.ButtonMinDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonMinDown.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonMinDown.FlatAppearance.BorderSize = 0
        Me.ButtonMinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinDown.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinDown.Location = New System.Drawing.Point(175, 105)
        Me.ButtonMinDown.Name = "ButtonMinDown"
        Me.ButtonMinDown.Size = New System.Drawing.Size(32, 32)
        Me.ButtonMinDown.TabIndex = 27
        Me.ButtonMinDown.UseVisualStyleBackColor = False
        '
        'ButtonSecDown
        '
        Me.ButtonSecDown.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSecDown.BackgroundImage = Global.Timer.My.Resources.Resources.down_white
        Me.ButtonSecDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSecDown.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonSecDown.FlatAppearance.BorderSize = 0
        Me.ButtonSecDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSecDown.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSecDown.Location = New System.Drawing.Point(267, 105)
        Me.ButtonSecDown.Name = "ButtonSecDown"
        Me.ButtonSecDown.Size = New System.Drawing.Size(32, 32)
        Me.ButtonSecDown.TabIndex = 19
        Me.ButtonSecDown.UseVisualStyleBackColor = False
        '
        'LabelHour
        '
        Me.LabelHour.AutoSize = True
        Me.LabelHour.BackColor = System.Drawing.Color.Transparent
        Me.LabelHour.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHour.ForeColor = System.Drawing.Color.White
        Me.LabelHour.Location = New System.Drawing.Point(-1, 49)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(0, 76)
        Me.LabelHour.TabIndex = 26
        '
        'LabelSetTime
        '
        Me.LabelSetTime.AutoSize = True
        Me.LabelSetTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelSetTime.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSetTime.ForeColor = System.Drawing.Color.White
        Me.LabelSetTime.Location = New System.Drawing.Point(47, 46)
        Me.LabelSetTime.Name = "LabelSetTime"
        Me.LabelSetTime.Size = New System.Drawing.Size(274, 76)
        Me.LabelSetTime.TabIndex = 20
        Me.LabelSetTime.Text = "00:00:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = " Set Duration "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Location = New System.Drawing.Point(407, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(370, 170)
        Me.Panel2.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.Panel8.Controls.Add(Me.LabelPastTime)
        Me.Panel8.Controls.Add(Me.LabelCountdown)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(2, 2)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(364, 164)
        Me.Panel8.TabIndex = 18
        '
        'LabelPastTime
        '
        Me.LabelPastTime.AutoSize = True
        Me.LabelPastTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelPastTime.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPastTime.ForeColor = System.Drawing.Color.White
        Me.LabelPastTime.Location = New System.Drawing.Point(107, 119)
        Me.LabelPastTime.Name = "LabelPastTime"
        Me.LabelPastTime.Size = New System.Drawing.Size(135, 39)
        Me.LabelPastTime.TabIndex = 18
        Me.LabelPastTime.Text = "00:00:00"
        Me.LabelPastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(420, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = " Time Remaining "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.LabelShowEnd)
        Me.Panel3.Controls.Add(Me.LabelShowDate)
        Me.Panel3.Controls.Add(Me.LabelCurentTime)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 164)
        Me.Panel3.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(69, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 26)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Show end at"
        '
        'LabelShowEnd
        '
        Me.LabelShowEnd.AutoSize = True
        Me.LabelShowEnd.BackColor = System.Drawing.Color.Transparent
        Me.LabelShowEnd.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShowEnd.ForeColor = System.Drawing.Color.White
        Me.LabelShowEnd.Location = New System.Drawing.Point(204, 123)
        Me.LabelShowEnd.Name = "LabelShowEnd"
        Me.LabelShowEnd.Size = New System.Drawing.Size(65, 26)
        Me.LabelShowEnd.TabIndex = 3
        Me.LabelShowEnd.Text = "00:00"
        '
        'LabelShowDate
        '
        Me.LabelShowDate.AutoSize = True
        Me.LabelShowDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelShowDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShowDate.ForeColor = System.Drawing.Color.White
        Me.LabelShowDate.Location = New System.Drawing.Point(85, 12)
        Me.LabelShowDate.Name = "LabelShowDate"
        Me.LabelShowDate.Size = New System.Drawing.Size(111, 26)
        Me.LabelShowDate.TabIndex = 2
        Me.LabelShowDate.Text = "Show date"
        '
        'LabelCurentTime
        '
        Me.LabelCurentTime.AutoSize = True
        Me.LabelCurentTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelCurentTime.Font = New System.Drawing.Font("Microsoft Tai Le", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurentTime.ForeColor = System.Drawing.Color.White
        Me.LabelCurentTime.Location = New System.Drawing.Point(-9, 28)
        Me.LabelCurentTime.Name = "LabelCurentTime"
        Me.LabelCurentTime.Size = New System.Drawing.Size(363, 101)
        Me.LabelCurentTime.TabIndex = 1
        Me.LabelCurentTime.Text = "00:00:00"
        Me.LabelCurentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(808, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = " Current Time "
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(270, 278)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 47)
        Me.Button7.TabIndex = 12
        Me.Button7.TabStop = False
        Me.Button7.Text = "00:30:00"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(143, 278)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 47)
        Me.Button8.TabIndex = 11
        Me.Button8.TabStop = False
        Me.Button8.Text = "00:25:00"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Black
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(17, 278)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 47)
        Me.Button9.TabIndex = 10
        Me.Button9.TabStop = False
        Me.Button9.Text = "00:20:00"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Black
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(270, 329)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(117, 47)
        Me.Button10.TabIndex = 15
        Me.Button10.TabStop = False
        Me.Button10.Text = "00:45:00"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Black
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(143, 329)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(117, 47)
        Me.Button11.TabIndex = 14
        Me.Button11.TabStop = False
        Me.Button11.Text = "00:40:00"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Black
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(17, 329)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(117, 47)
        Me.Button12.TabIndex = 13
        Me.Button12.TabStop = False
        Me.Button12.Text = "00:35:00"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'TimerTimeOfDay
        '
        Me.TimerTimeOfDay.Interval = 1000
        '
        'TimerCountUp
        '
        Me.TimerCountUp.Interval = 1000
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Location = New System.Drawing.Point(795, 226)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel5.Size = New System.Drawing.Size(370, 150)
        Me.Panel5.TabIndex = 19
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel10.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.Panel10.Controls.Add(Me.CheckBoxSenMsg)
        Me.Panel10.Controls.Add(Me.ButtonShowTimer)
        Me.Panel10.Controls.Add(Me.ButtonShowClock)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(2, 2)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(364, 144)
        Me.Panel10.TabIndex = 18
        '
        'CheckBoxSenMsg
        '
        Me.CheckBoxSenMsg.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxSenMsg.BackColor = System.Drawing.Color.Black
        Me.CheckBoxSenMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBoxSenMsg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxSenMsg.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSenMsg.ForeColor = System.Drawing.Color.White
        Me.CheckBoxSenMsg.Location = New System.Drawing.Point(14, 26)
        Me.CheckBoxSenMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSenMsg.Name = "CheckBoxSenMsg"
        Me.CheckBoxSenMsg.Size = New System.Drawing.Size(235, 106)
        Me.CheckBoxSenMsg.TabIndex = 20
        Me.CheckBoxSenMsg.TabStop = False
        Me.CheckBoxSenMsg.Text = "Send message"
        Me.CheckBoxSenMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxSenMsg.UseVisualStyleBackColor = False
        '
        'ButtonShowTimer
        '
        Me.ButtonShowTimer.BackColor = System.Drawing.Color.Black
        Me.ButtonShowTimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonShowTimer.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowTimer.ForeColor = System.Drawing.Color.Red
        Me.ButtonShowTimer.Location = New System.Drawing.Point(262, 26)
        Me.ButtonShowTimer.Name = "ButtonShowTimer"
        Me.ButtonShowTimer.Size = New System.Drawing.Size(87, 50)
        Me.ButtonShowTimer.TabIndex = 18
        Me.ButtonShowTimer.TabStop = False
        Me.ButtonShowTimer.Text = "Timer"
        Me.ButtonShowTimer.UseVisualStyleBackColor = False
        '
        'ButtonShowClock
        '
        Me.ButtonShowClock.BackColor = System.Drawing.Color.Black
        Me.ButtonShowClock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonShowClock.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowClock.ForeColor = System.Drawing.Color.White
        Me.ButtonShowClock.Location = New System.Drawing.Point(262, 82)
        Me.ButtonShowClock.Name = "ButtonShowClock"
        Me.ButtonShowClock.Size = New System.Drawing.Size(87, 50)
        Me.ButtonShowClock.TabIndex = 19
        Me.ButtonShowClock.TabStop = False
        Me.ButtonShowClock.Text = "Clock"
        Me.ButtonShowClock.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(809, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = " Output "
        '
        'TextBoxMsg
        '
        Me.TextBoxMsg.BackColor = System.Drawing.Color.Black
        Me.TextBoxMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxMsg.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMsg.ForeColor = System.Drawing.Color.White
        Me.TextBoxMsg.Location = New System.Drawing.Point(17, 25)
        Me.TextBoxMsg.Name = "TextBoxMsg"
        Me.TextBoxMsg.Size = New System.Drawing.Size(720, 42)
        Me.TextBoxMsg.TabIndex = 20
        Me.TextBoxMsg.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(407, 391)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel4.Size = New System.Drawing.Size(758, 93)
        Me.Panel4.TabIndex = 18
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.Panel6.Controls.Add(Me.TextBoxMsg)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(752, 87)
        Me.Panel6.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(422, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = " Message "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Location = New System.Drawing.Point(795, 48)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(370, 170)
        Me.Panel7.TabIndex = 18
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel14.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.Panel14.Controls.Add(Me.ButtonJog1SecUp)
        Me.Panel14.Controls.Add(Me.ButtonJog1SecDown)
        Me.Panel14.Controls.Add(Me.Label10)
        Me.Panel14.Controls.Add(Me.Label14)
        Me.Panel14.Controls.Add(Me.ButtonJog1MinUp)
        Me.Panel14.Controls.Add(Me.ButtonJog5MinUp)
        Me.Panel14.Controls.Add(Me.ButtonJog1MinDown)
        Me.Panel14.Controls.Add(Me.Label12)
        Me.Panel14.Controls.Add(Me.Label1)
        Me.Panel14.Controls.Add(Me.Label6)
        Me.Panel14.Controls.Add(Me.ButtonJog5MinDown)
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(2, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(364, 87)
        Me.Panel14.TabIndex = 21
        '
        'ButtonJog1SecUp
        '
        Me.ButtonJog1SecUp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJog1SecUp.BackgroundImage = Global.Timer.My.Resources.Resources.up_white
        Me.ButtonJog1SecUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonJog1SecUp.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonJog1SecUp.FlatAppearance.BorderSize = 0
        Me.ButtonJog1SecUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJog1SecUp.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJog1SecUp.Location = New System.Drawing.Point(321, 11)
        Me.ButtonJog1SecUp.Name = "ButtonJog1SecUp"
        Me.ButtonJog1SecUp.Size = New System.Drawing.Size(32, 32)
        Me.ButtonJog1SecUp.TabIndex = 40
        Me.ButtonJog1SecUp.UseVisualStyleBackColor = False
        '
        'ButtonJog1SecDown
        '
        Me.ButtonJog1SecDown.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJog1SecDown.BackgroundImage = Global.Timer.My.Resources.Resources.down_white
        Me.ButtonJog1SecDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonJog1SecDown.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonJog1SecDown.FlatAppearance.BorderSize = 0
        Me.ButtonJog1SecDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJog1SecDown.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJog1SecDown.Location = New System.Drawing.Point(321, 45)
        Me.ButtonJog1SecDown.Name = "ButtonJog1SecDown"
        Me.ButtonJog1SecDown.Size = New System.Drawing.Size(32, 32)
        Me.ButtonJog1SecDown.TabIndex = 39
        Me.ButtonJog1SecDown.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(250, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 35)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Sec"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(286, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 35)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "1"
        '
        'ButtonJog1MinUp
        '
        Me.ButtonJog1MinUp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJog1MinUp.BackgroundImage = Global.Timer.My.Resources.Resources.up_white
        Me.ButtonJog1MinUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonJog1MinUp.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonJog1MinUp.FlatAppearance.BorderSize = 0
        Me.ButtonJog1MinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJog1MinUp.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJog1MinUp.Location = New System.Drawing.Point(205, 13)
        Me.ButtonJog1MinUp.Name = "ButtonJog1MinUp"
        Me.ButtonJog1MinUp.Size = New System.Drawing.Size(32, 32)
        Me.ButtonJog1MinUp.TabIndex = 36
        Me.ButtonJog1MinUp.UseVisualStyleBackColor = False
        '
        'ButtonJog5MinUp
        '
        Me.ButtonJog5MinUp.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJog5MinUp.BackgroundImage = Global.Timer.My.Resources.Resources.up_white
        Me.ButtonJog5MinUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonJog5MinUp.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonJog5MinUp.FlatAppearance.BorderSize = 0
        Me.ButtonJog5MinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJog5MinUp.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJog5MinUp.Location = New System.Drawing.Point(87, 10)
        Me.ButtonJog5MinUp.Name = "ButtonJog5MinUp"
        Me.ButtonJog5MinUp.Size = New System.Drawing.Size(32, 32)
        Me.ButtonJog5MinUp.TabIndex = 33
        Me.ButtonJog5MinUp.UseVisualStyleBackColor = False
        '
        'ButtonJog1MinDown
        '
        Me.ButtonJog1MinDown.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJog1MinDown.BackgroundImage = Global.Timer.My.Resources.Resources.down_white
        Me.ButtonJog1MinDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonJog1MinDown.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonJog1MinDown.FlatAppearance.BorderSize = 0
        Me.ButtonJog1MinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJog1MinDown.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJog1MinDown.Location = New System.Drawing.Point(205, 47)
        Me.ButtonJog1MinDown.Name = "ButtonJog1MinDown"
        Me.ButtonJog1MinDown.Size = New System.Drawing.Size(32, 32)
        Me.ButtonJog1MinDown.TabIndex = 35
        Me.ButtonJog1MinDown.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(134, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 35)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Min"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 35)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 35)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Min"
        '
        'ButtonJog5MinDown
        '
        Me.ButtonJog5MinDown.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJog5MinDown.BackgroundImage = Global.Timer.My.Resources.Resources.down_white
        Me.ButtonJog5MinDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonJog5MinDown.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonJog5MinDown.FlatAppearance.BorderSize = 0
        Me.ButtonJog5MinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJog5MinDown.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJog5MinDown.Location = New System.Drawing.Point(86, 46)
        Me.ButtonJog5MinDown.Name = "ButtonJog5MinDown"
        Me.ButtonJog5MinDown.Size = New System.Drawing.Size(32, 32)
        Me.ButtonJog5MinDown.TabIndex = 30
        Me.ButtonJog5MinDown.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 35)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "5"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Location = New System.Drawing.Point(17, 391)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel12.Size = New System.Drawing.Size(370, 93)
        Me.Panel12.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(33, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 25)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Jog"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 28)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.SettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem, Me.ToolStripSeparator1, Me.CountdownColorToolStripMenuItem, Me.CoountdownFontToolStripMenuItem, Me.GoBelow0ToolStripMenuItem, Me.ChangeColorsToolStripMenuItem, Me.ToolStripSeparator2, Me.CurrentTimeColorToolStripMenuItem, Me.MessageFontToolStripMenuItem, Me.ToolStripSeparator3, Me.ClockColorToolStripMenuItem, Me.ClockFontToolStripMenuItem, Me.ToolStripSeparator4})
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SettingsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.BackgroundColorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BackgroundColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.BackgroundColorToolStripMenuItem.Text = "Background color"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'CountdownColorToolStripMenuItem
        '
        Me.CountdownColorToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CountdownColorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CountdownColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CountdownColorToolStripMenuItem.Name = "CountdownColorToolStripMenuItem"
        Me.CountdownColorToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.CountdownColorToolStripMenuItem.Text = "Countdown color"
        '
        'CoountdownFontToolStripMenuItem
        '
        Me.CoountdownFontToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CoountdownFontToolStripMenuItem.Name = "CoountdownFontToolStripMenuItem"
        Me.CoountdownFontToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.CoountdownFontToolStripMenuItem.Text = "Countdown Font"
        '
        'GoBelow0ToolStripMenuItem
        '
        Me.GoBelow0ToolStripMenuItem.Checked = True
        Me.GoBelow0ToolStripMenuItem.CheckOnClick = True
        Me.GoBelow0ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GoBelow0ToolStripMenuItem.Name = "GoBelow0ToolStripMenuItem"
        Me.GoBelow0ToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.GoBelow0ToolStripMenuItem.Text = "Go below 0"
        '
        'ChangeColorsToolStripMenuItem
        '
        Me.ChangeColorsToolStripMenuItem.Checked = True
        Me.ChangeColorsToolStripMenuItem.CheckOnClick = True
        Me.ChangeColorsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChangeColorsToolStripMenuItem.Name = "ChangeColorsToolStripMenuItem"
        Me.ChangeColorsToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ChangeColorsToolStripMenuItem.Text = "Change colors "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(206, 6)
        '
        'CurrentTimeColorToolStripMenuItem
        '
        Me.CurrentTimeColorToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CurrentTimeColorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CurrentTimeColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CurrentTimeColorToolStripMenuItem.Name = "CurrentTimeColorToolStripMenuItem"
        Me.CurrentTimeColorToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.CurrentTimeColorToolStripMenuItem.Text = "Message Color"
        '
        'MessageFontToolStripMenuItem
        '
        Me.MessageFontToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MessageFontToolStripMenuItem.Name = "MessageFontToolStripMenuItem"
        Me.MessageFontToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.MessageFontToolStripMenuItem.Text = "Message Font"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(206, 6)
        '
        'ClockColorToolStripMenuItem
        '
        Me.ClockColorToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ClockColorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClockColorToolStripMenuItem.Name = "ClockColorToolStripMenuItem"
        Me.ClockColorToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ClockColorToolStripMenuItem.Text = "Clock Color"
        '
        'ClockFontToolStripMenuItem
        '
        Me.ClockFontToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ClockFontToolStripMenuItem.Name = "ClockFontToolStripMenuItem"
        Me.ClockFontToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ClockFontToolStripMenuItem.Text = "Clock Font"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(206, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(604, 514)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(376, 43)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Audiovisual | Produção"
        '
        'FontDialogCountdown
        '
        Me.FontDialogCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 199.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontDialogCountdown.ShowApply = True
        '
        'FontDialogMsg
        '
        Me.FontDialogMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontDialogMsg.ShowApply = True
        '
        'FontDialogClock
        '
        Me.FontDialogClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 199.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontDialogClock.ShowApply = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(240, 502)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(370, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'CheckBoxStart
        '
        Me.CheckBoxStart.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxStart.BackColor = System.Drawing.Color.Black
        Me.CheckBoxStart.BackgroundImage = Global.Timer.My.Resources.Resources.play_button_green_2
        Me.CheckBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBoxStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxStart.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxStart.ForeColor = System.Drawing.Color.Green
        Me.CheckBoxStart.Location = New System.Drawing.Point(407, 226)
        Me.CheckBoxStart.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxStart.Name = "CheckBoxStart"
        Me.CheckBoxStart.Size = New System.Drawing.Size(165, 150)
        Me.CheckBoxStart.TabIndex = 17
        Me.CheckBoxStart.TabStop = False
        Me.CheckBoxStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxStart.UseVisualStyleBackColor = False
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Black
        Me.ButtonReset.BackgroundImage = Global.Timer.My.Resources.Resources.reset_button_green
        Me.ButtonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReset.FlatAppearance.BorderSize = 0
        Me.ButtonReset.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.ForeColor = System.Drawing.Color.Green
        Me.ButtonReset.Location = New System.Drawing.Point(612, 226)
        Me.ButtonReset.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(165, 150)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.TabStop = False
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'TimerCountNegative
        '
        Me.TimerCountNegative.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Timer.My.Resources.Resources.back_hipnose
        Me.ClientSize = New System.Drawing.Size(1182, 560)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBoxStart)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 607)
        Me.MinimumSize = New System.Drawing.Size(1200, 607)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hipnose Timer v1.2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerCountdown As System.Windows.Forms.Timer
    Friend WithEvents LabelCountdown As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelCurentTime As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimerTimeOfDay As System.Windows.Forms.Timer
    Friend WithEvents LabelPastTime As System.Windows.Forms.Label
    Friend WithEvents TimerCountUp As System.Windows.Forms.Timer
    Friend WithEvents CheckBoxStart As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSecDown As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelSetTime As System.Windows.Forms.Label
    Friend WithEvents LabelHour As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ButtonShowClock As System.Windows.Forms.Button
    Friend WithEvents ButtonShowTimer As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMsg As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxSenMsg As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonHourDown As System.Windows.Forms.Button
    Friend WithEvents ButtonMinDown As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents ButtonJog1MinDown As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonJog5MinDown As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonHourUp As System.Windows.Forms.Button
    Friend WithEvents ButtonMinUp As System.Windows.Forms.Button
    Friend WithEvents ButtonSecUp As System.Windows.Forms.Button
    Friend WithEvents ButtonJog5MinUp As System.Windows.Forms.Button
    Friend WithEvents ButtonJog1MinUp As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelShowDate As System.Windows.Forms.Label
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountdownColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentTimeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialogBackground As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialogCountdown As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialogMsg As System.Windows.Forms.ColorDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CoountdownFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialogCountdown As FontDialog
    Friend WithEvents FontDialogMsg As FontDialog
    Friend WithEvents MessageFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ClockColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClockFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialogClock As ColorDialog
    Friend WithEvents FontDialogClock As FontDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonJog1SecUp As Button
    Friend WithEvents ButtonJog1SecDown As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TimerCountNegative As Windows.Forms.Timer
    Friend WithEvents LabelShowEnd As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GoBelow0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ChangeColorsToolStripMenuItem As ToolStripMenuItem
End Class
