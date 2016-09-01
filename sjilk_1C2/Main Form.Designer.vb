<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(99, 32)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(306, 51)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "Summer Carnival"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.ForeColor = System.Drawing.Color.Red
        Me.lblComment.Location = New System.Drawing.Point(60, 291)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(420, 38)
        Me.lblComment.TabIndex = 2
        Me.lblComment.Text = "Come join the fun at Valley Park!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sjilk_1C2.My.Resources.Resources.Carnival
        Me.PictureBox1.Location = New System.Drawing.Point(117, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'tmrExit
        '
        Me.tmrExit.Enabled = True
        Me.tmrExit.Interval = 3000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 6000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 9000
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(457, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMain As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrExit As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
