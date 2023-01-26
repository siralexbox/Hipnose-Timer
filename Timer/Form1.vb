Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Runtime.CompilerServices
Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.ComponentModel

Public Class Form1

    Dim time As String
    Dim timeDown As String
    Dim timeUp As String
    Dim digit As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerTimeOfDay.Start()
        Form2.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        Form2.Show()
        Control.CheckForIllegalCrossThreadCalls = False
        multi_server()
    End Sub
    Private Sub multi_server()
        Dim thread As System.Threading.Thread
        thread = New System.Threading.Thread(AddressOf Hosting_Port)
        thread.Start()
    End Sub
    Private Sub Hosting_Port()
        Dim TcpListener As New TcpListener(IPAddress.Parse("127.0.0.1"), 1234)
        TcpListener.Start()
        Try
            Dim tcpClient As TcpClient = TcpListener.AcceptTcpClient()
            Dim networkStream As NetworkStream = tcpClient.GetStream()

            Dim bytes(tcpClient.ReceiveBufferSize) As Byte
            networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
            Dim clientdata As String = Encoding.ASCII.GetString(bytes)
            Me.LabelCountdown.Text = clientdata
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub TimerCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCountdown.Tick
        TimerCountdown.Interval = 1000
        Try
            timeDown = FormatDateTime(DateAdd(DateInterval.Second, -1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
            Me.LabelCountdown.Text = timeDown
            Form2.LabelTimer.Text = timeDown

            Dim hour As Integer = timeDown.Substring(0, 2)
            Dim min As Integer = timeDown.Substring(3, 2)
            Dim timeNow As Double = Now.TimeOfDay.TotalSeconds
            Dim timeDownsec = hour * 60 * 60 + min * 60
            Dim showEndsec As Integer = timeDownsec + timeNow
            Dim secToHhSsMm As New TimeSpan(TimeSpan.TicksPerSecond * showEndsec)
            Dim ShowEndStr As String = secToHhSsMm.Hours.ToString("00") & ":" & secToHhSsMm.Minutes.ToString("00")
            Me.LabelShowEnd.Text = ShowEndStr
            If ChangeColorsToolStripMenuItem.Checked = True Then
                If LabelCountdown.Text = "00:03:00" Then
                    LabelCountdown.ForeColor = Color.Orange
                    Form2.LabelTimer.ForeColor = Color.Orange
                ElseIf LabelCountdown.Text = "00:01:00" Then
                    LabelCountdown.ForeColor = Color.Red
                    Form2.LabelTimer.ForeColor = Color.Red
                End If
            End If
            If GoBelow0ToolStripMenuItem.Checked = False Then
                If timeDown = "00:00:00" Or timeDown = "23:59:59" Then
                    Me.LabelCountdown.Text = "00:00:00"
                    Me.LabelPastTime.Text = "00:00:00"
                    Form2.LabelTimer.Text = "00:00:00"
                    TimerCountdown.Stop()
                    TimerCountUp.Stop()
                    CheckBoxStart.Checked = False
                End If
            ElseIf GoBelow0ToolStripMenuItem.Checked = True Then
                If timeDown = "00:00:00" Then
                    TimerCountdown.Stop()
                    TimerCountUp.Stop()
                    TimerCountNegative.Start()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TimerCountUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCountUp.Tick
        TimerCountdown.Interval = 1000
        Try
            timeUp = FormatDateTime(DateAdd(DateInterval.Second, +1, DateTime.Parse(LabelPastTime.Text)), DateFormat.LongTime)
            Me.LabelPastTime.Text = timeUp
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TimerTimeOfDay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeOfDay.Tick
        Me.LabelCurentTime.Text = TimeOfDay.ToString("HH:mm:ss")
        Form2.LabelClock.Text = TimeOfDay.ToString("HH:mm:ss")
        Me.LabelShowDate.Text = String.Format("{0:dd MMMM yyyy}", Now)

    End Sub

    Private Sub CheckBoxStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStart.CheckedChanged
        If sender.Checked = True And LabelCountdown.Text <> "00:00:00" Then
            TimerCountdown.Start()
            TimerCountUp.Start()
            sender.BackgroundImage = My.Resources.pause_button_green_2
        Else
            TimerCountdown.Stop()
            TimerCountUp.Stop()
            sender.backgroundimage = My.Resources.play_button_green_2
        End If
    End Sub

    Sub TimerSetText()
        Me.LabelCountdown.Text = time
        Me.LabelPastTime.Text = "00:00:00"
        Form2.LabelTimer.Text = time
    End Sub

    Sub TimerStop()
        TimerCountdown.Stop()
        TimerCountUp.Stop()
    End Sub

    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click
        TimerCountdown.Stop()
        TimerCountUp.Stop()
        TimerCountNegative.Stop()
        CheckBoxStart.Checked = False
        LabelCountdown.ForeColor = Color.Green
        Form2.LabelTimer.ForeColor = Color.Green
        LabelCountdown.Text = "00:00:00"
        LabelPastTime.Text = "00:00:00"
        Form2.LabelTimer.Text = "00:00:00"
        LabelShowEnd.Text = "00:00"
        CheckBoxStart.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        CheckBoxStart.Checked = False
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub ButtonShowTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowTimer.Click
        Form2.LabelTimer.Visible = True
        Form2.LabelClock.Visible = False
        ButtonShowTimer.ForeColor = Color.Red
        ButtonShowClock.ForeColor = Color.White
    End Sub

    Private Sub ButtonShowClock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowClock.Click
        Form2.LabelTimer.Visible = False
        Form2.LabelClock.Visible = True
        ButtonShowTimer.ForeColor = Color.White
        ButtonShowClock.ForeColor = Color.Red
    End Sub

    Private Sub CheckBoxSenMsg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSenMsg.CheckedChanged
        If sender.Checked = True Then
            Form2.LabelMsg.Text = TextBoxMsg.Text
            Form2.LabelMsg.Show()
            sender.text = "Clear Message"
            sender.forecolor = Color.Red
        Else
            Form2.LabelMsg.Hide()
            sender.forecolor = Color.White
            sender.text = "Send Message"
        End If
    End Sub

    Private Sub ButtonSecDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSecDown.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Second, -1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonMinDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinDown.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Minute, -1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonHourDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHourDown.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Hour, -1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog1MinDown.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, -1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
        Form2.LabelTimer.Text = LabelCountdown.Text
    End Sub

    Private Sub Button1MinUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog1MinUp.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, +1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
        Form2.LabelTimer.Text = LabelCountdown.Text
    End Sub

    Private Sub ButtonJog5MinUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog5MinUp.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, +5, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
        Form2.LabelTimer.Text = LabelCountdown.Text
    End Sub

    Private Sub ButtonJog5MinDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog5MinDown.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, -5, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
        Form2.LabelTimer.Text = LabelCountdown.Text
    End Sub
    Private Sub ButtonJog1SecUp_Click(sender As Object, e As EventArgs) Handles ButtonJog1SecUp.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Second, +1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
        Form2.LabelTimer.Text = LabelCountdown.Text
    End Sub

    Private Sub ButtonJog1SecDown_Click(sender As Object, e As EventArgs) Handles ButtonJog1SecDown.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Second, -1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
        Form2.LabelTimer.Text = LabelCountdown.Text
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub ButtonSecUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSecUp.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Second, +1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonMinUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinUp.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Minute, +1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonHourUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHourUp.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Hour, +1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        If ColorDialogBackground.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.BackColor = ColorDialogBackground.Color
            My.Settings.Form2_BackColorColor = ColorDialogBackground.Color
        End If
    End Sub
    Private Sub CountdownColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountdownColorToolStripMenuItem.Click
        If ColorDialogCountdown.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.LabelTimer.ForeColor = ColorDialogCountdown.Color
            My.Settings.Form2_LabelTimerColor = ColorDialogCountdown.Color
        End If
    End Sub
    Private Sub CoountdownFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoountdownFontToolStripMenuItem.Click
        If FontDialogCountdown.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.LabelTimer.Font = FontDialogCountdown.Font
            My.Settings.Form2_LabelTimerFont = FontDialogCountdown.Font
        End If
    End Sub
    Private Sub FontDialogCountdownApply(sender As Object, e As EventArgs) Handles FontDialogCountdown.Apply
        Form2.LabelTimer.Font = FontDialogCountdown.Font
    End Sub
    Private Sub CurrentTimeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentTimeColorToolStripMenuItem.Click
        If ColorDialogMsg.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.LabelMsg.ForeColor = ColorDialogMsg.Color
            My.Settings.Form2_LabelMsgColor = ColorDialogMsg.Color
        End If
    End Sub
    Private Sub MessageFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageFontToolStripMenuItem.Click
        If FontDialogMsg.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.LabelMsg.Font = FontDialogMsg.Font
            My.Settings.Form2_LabelMsgFont = FontDialogMsg.Font
        End If
    End Sub
    Private Sub FontDialogMsgApply(sender As Object, e As EventArgs) Handles FontDialogMsg.Apply
        Form2.LabelMsg.Font = FontDialogMsg.Font
    End Sub
    Private Sub ClockColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockColorToolStripMenuItem.Click
        If ColorDialogClock.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.LabelClock.ForeColor = ColorDialogClock.Color
            My.Settings.Form2_LabelClockColor = ColorDialogClock.Color
        End If
    End Sub
    Private Sub ClockFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockFontToolStripMenuItem.Click
        If FontDialogClock.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form2.LabelClock.Font = FontDialogClock.Font
            My.Settings.Form2_LabelClockFont = FontDialogClock.Font
        End If
    End Sub
    Private Sub FontDialogClockApply(sender As Object, e As EventArgs) Handles FontDialogClock.Apply
        Form2.LabelClock.Font = FontDialogClock.Font
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub TimerCountNegative_Tick(sender As Object, e As EventArgs) Handles TimerCountNegative.Tick
        TimerCountdown.Interval = 1000
        Try
            timeDown = FormatDateTime(DateAdd(DateInterval.Second, +1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
            Me.LabelCountdown.Text = timeDown
            Form2.LabelTimer.Text = timeDown
            Me.LabelCountdown.ForeColor = Color.Red
            Form2.LabelTimer.ForeColor = Color.Red
            CheckBoxStart.Checked = True
            CheckBoxStart.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxGoNegative_CheckedChanged(sender As Object, e As EventArgs)
        If sender.Checked = True Then
            sender.ForeColor = Color.Red
        Else
            sender.ForeColor = Color.White
        End If
    End Sub


End Class
