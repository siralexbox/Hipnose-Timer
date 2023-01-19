Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = My.Settings.Form2_BackColor
        Me.LabelTimer.ForeColor = My.Settings.Form2_LabelTimer
        Me.LabelMsg.ForeColor = My.Settings.Form2_LabelMsg
        Dim textSize = Me.Height \ 4

        Me.LabelTimer.Text = "00:00:00"
        Me.LabelTimer.Dock = DockStyle.Fill
        Me.LabelTimer.Font = New Font("Microsoft Tai Le", textSize, FontStyle.Bold)
        'Me.LabelTimer.ForeColor = Color.Green

        Me.LabelClock.Visible = False
        Me.LabelClock.Dock = DockStyle.Fill
        Me.LabelClock.Font = New Font("Microsoft Tai Le", textSize, FontStyle.Bold)
        'Me.LabelClock.ForeColor = Color.White

        Timer1.Start()
        Me.LabelMsg.Visible = False
        Me.LabelMsg.Dock = DockStyle.None
        Me.LabelMsg.Font = New Font("Microsoft Tai Le", 60, FontStyle.Bold)
        'Me.LabelMsg.ForeColor = Color.Red

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.LabelMsg.Location = New Point(LabelMsg.Parent.Width \ 2 - LabelMsg.Width \ 2, LabelMsg.Parent.Height - LabelMsg.Parent.Height \ 3)
    End Sub
End Class