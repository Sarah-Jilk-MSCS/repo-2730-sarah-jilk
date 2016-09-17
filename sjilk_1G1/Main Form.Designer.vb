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
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Location = New System.Drawing.Point(32, 45)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(115, 25)
        Me.lblScore1.TabIndex = 6
        Me.lblScore1.Text = "Test Score &1:"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Location = New System.Drawing.Point(32, 92)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(115, 25)
        Me.lblScore2.TabIndex = 7
        Me.lblScore2.Text = "Test Score &2:"
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Location = New System.Drawing.Point(32, 142)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(115, 25)
        Me.lblScore3.TabIndex = 8
        Me.lblScore3.Text = "Test Score &3:"
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(129, 42)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(99, 31)
        Me.txtScore1.TabIndex = 0
        Me.txtScore1.Text = "0"
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(128, 86)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 31)
        Me.txtScore2.TabIndex = 1
        Me.txtScore2.Text = "0"
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(129, 136)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 31)
        Me.txtScore3.TabIndex = 2
        Me.txtScore3.Text = "0"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(295, 37)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(99, 33)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(295, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 33)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 134)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(75, 215)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(142, 25)
        Me.lblAverage.TabIndex = 9
        Me.lblAverage.Text = "&Average Score: "
        '
        'lblAverageScore
        '
        Me.lblAverageScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageScore.Location = New System.Drawing.Point(251, 214)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(100, 31)
        Me.lblAverageScore.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 276)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Score Averages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblAverageScore As Label
End Class
