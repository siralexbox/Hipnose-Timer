Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = My.Settings.Form2_BackColorColor

        Me.LabelTimer.ForeColor = My.Settings.Form2_LabelTimerColor
        Me.LabelTimer.Font = My.Settings.Form2_LabelTimerFont
        Me.LabelTimer.Text = "00:00:00"
        Me.LabelTimer.Dock = DockStyle.Fill

        Me.LabelClock.ForeColor = My.Settings.Form2_LabelClockColor
        Me.LabelClock.Font = My.Settings.Form2_LabelClockFont
        Me.LabelClock.Visible = False
        Me.LabelClock.Dock = DockStyle.Fill

        Me.TimerMsg.Start()
        Me.LabelMsg.ForeColor = My.Settings.Form2_LabelMsgColor
        Me.LabelMsg.Font = My.Settings.Form2_LabelMsgFont
        Me.LabelMsg.Visible = False
        Me.LabelMsg.Dock = DockStyle.None

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMsg.Tick
        Me.LabelMsg.Location = New Point(LabelMsg.Parent.Width \ 2 - LabelMsg.Width \ 2, LabelMsg.Parent.Height - LabelMsg.Parent.Height \ 3)
    End Sub
End Class