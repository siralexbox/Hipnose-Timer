<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.LabelMsg = New System.Windows.Forms.Label()
        Me.TimerMsg = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelTimer
        '
        Me.LabelTimer.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimer.ForeColor = System.Drawing.Color.Green
        Me.LabelTimer.Location = New System.Drawing.Point(78, 82)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(145, 47)
        Me.LabelTimer.TabIndex = 0
        Me.LabelTimer.Text = "Timer"
        Me.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClock
        '
        Me.LabelClock.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClock.ForeColor = System.Drawing.Color.White
        Me.LabelClock.Location = New System.Drawing.Point(418, 82)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(146, 51)
        Me.LabelClock.TabIndex = 2
        Me.LabelClock.Text = "Hour"
        Me.LabelClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMsg
        '
        Me.LabelMsg.AutoSize = True
        Me.LabelMsg.BackColor = System.Drawing.Color.Transparent
        Me.LabelMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMsg.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMsg.ForeColor = System.Drawing.Color.Red
        Me.LabelMsg.Location = New System.Drawing.Point(204, 160)
        Me.LabelMsg.Name = "LabelMsg"
        Me.LabelMsg.Size = New System.Drawing.Size(218, 62)
        Me.LabelMsg.TabIndex = 3
        Me.LabelMsg.Text = "Message"
        Me.LabelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerMsg
        '
        Me.TimerMsg.Interval = 250
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(645, 253)
        Me.Controls.Add(Me.LabelMsg)
        Me.Controls.Add(Me.LabelClock)
        Me.Controls.Add(Me.LabelTimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Remote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTimer As System.Windows.Forms.Label
    Friend WithEvents LabelClock As System.Windows.Forms.Label
    Friend WithEvents LabelMsg As System.Windows.Forms.Label
    Friend WithEvents TimerMsg As System.Windows.Forms.Timer
End Class
