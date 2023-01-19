Public Class Form1

    Dim time As String
    Dim timeDown As String
    Dim timeUp As String
    Dim digit As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerTimeOfDay.Start()
        Form2.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
        Form2.Show()
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
            If timeDown = "00:00:00" Or timeDown = "23:59:59" Then
                Me.LabelCountdown.Text = "00:00:00"
                Me.LabelPastTime.Text = "00:00:00"
                Form2.LabelTimer.Text = "00:00:00"
                TimerCountdown.Stop()
                TimerCountUp.Stop()
                CheckBoxStart.Checked = False
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
        Me.LabelClock.Text = TimeOfDay.ToString("HH:mm:ss")
        Form2.LabelClock.Text = TimeOfDay.ToString("HH:mm:ss")
        Me.LabelShowDate.Text = String.Format("{0:dd MMMM yyyy}", Now)

    End Sub

    Private Sub CheckBoxStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStart.CheckedChanged
        If sender.Checked = True Then
            TimerCountdown.Start()
            TimerCountUp.Start()
            sender.BackgroundImageLayout = ImageLayout.Stretch
            sender.BackgroundImage = My.Resources.pause_button_green_2
        Else
            TimerCountdown.Stop()
            TimerCountUp.Stop()
            sender.BackgroundImageLayout = ImageLayout.Zoom
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
        CheckBoxStart.Checked = False
        LabelCountdown.Text = "00:00:00"
        LabelPastTime.Text = "00:00:00"
        Form2.LabelTimer.Text = "00:00:00"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
        time = sender.text
        Call TimerStop()
        Call TimerSetText()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            sender.Text = LabelSetTime.Text
        End If
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
            TextBoxMsg.Text = ""
            sender.forecolor = Color.White
            sender.text = "Send Message"
            TextBoxMsg.Text = ""
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog1MinDown.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, -1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
    End Sub

    Private Sub Button1MinUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1MinUp.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, +1, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonJog5MinUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog5MinUp.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, +5, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonJog5MinDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJog5MinDown.Click
        LabelCountdown.Text = FormatDateTime(DateAdd(DateInterval.Minute, -5, DateTime.Parse(LabelCountdown.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonSecUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSecUp.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Second, +1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonMinUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinUp.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Minute, +1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub ButtonHourUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHourUp.Click
        LabelSetTime.Text = FormatDateTime(DateAdd(DateInterval.Hour, +1, DateTime.Parse(LabelSetTime.Text)), DateFormat.LongTime)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        Me.ColorDialogBackground.ShowDialog()
        If ColorDialogBackground.ShowDialog = DialogResult.OK Then
            Form2.BackColor = ColorDialogBackground.Color
            My.Settings.Form2_BackColor = ColorDialogBackground.Color
        End If
    End Sub

    Private Sub CountdownColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountdownColorToolStripMenuItem.Click
        Me.ColorDialogCountdown.ShowDialog()
        If ColorDialogCountdown.ShowDialog = DialogResult.OK Then
            Form2.LabelTimer.ForeColor = ColorDialogCountdown.Color
            My.Settings.Form2_LabelTimer = ColorDialogCountdown.Color
        End If

    End Sub

    Private Sub CurrentTimeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentTimeColorToolStripMenuItem.Click
        Me.ColorDialogMsg.ShowDialog()
        If ColorDialogMsg.ShowDialog = DialogResult.OK Then
            Form2.LabelMsg.ForeColor = ColorDialogMsg.Color
            My.Settings.Form2_LabelMsg = ColorDialogMsg.Color
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form4.Show()
    End Sub

End Class
