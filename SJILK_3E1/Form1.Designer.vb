<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblCommValues = New System.Windows.Forms.Label()
        Me.cboValue = New System.Windows.Forms.ComboBox()
        Me.cboRange = New System.Windows.Forms.ComboBox()
        Me.lblRangeCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Commission Values:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search for value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search for Range:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Count:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Count:"
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(341, 126)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 23)
        Me.lblCount.TabIndex = 5
        '
        'lblCommValues
        '
        Me.lblCommValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommValues.Location = New System.Drawing.Point(152, 9)
        Me.lblCommValues.Name = "lblCommValues"
        Me.lblCommValues.Size = New System.Drawing.Size(232, 87)
        Me.lblCommValues.TabIndex = 7
        '
        'cboValue
        '
        Me.cboValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboValue.FormattingEnabled = True
        Me.cboValue.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboValue.Location = New System.Drawing.Point(152, 124)
        Me.cboValue.Name = "cboValue"
        Me.cboValue.Size = New System.Drawing.Size(121, 105)
        Me.cboValue.TabIndex = 8
        '
        'cboRange
        '
        Me.cboRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboRange.FormattingEnabled = True
        Me.cboRange.Items.AddRange(New Object() {"    0 - 200", "100 - 300", "700 - 800"})
        Me.cboRange.Location = New System.Drawing.Point(152, 232)
        Me.cboRange.Name = "cboRange"
        Me.cboRange.Size = New System.Drawing.Size(121, 105)
        Me.cboRange.TabIndex = 9
        '
        'lblRangeCount
        '
        Me.lblRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeCount.Location = New System.Drawing.Point(341, 232)
        Me.lblRangeCount.Name = "lblRangeCount"
        Me.lblRangeCount.Size = New System.Drawing.Size(100, 23)
        Me.lblRangeCount.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 347)
        Me.Controls.Add(Me.lblRangeCount)
        Me.Controls.Add(Me.cboRange)
        Me.Controls.Add(Me.cboValue)
        Me.Controls.Add(Me.lblCommValues)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SJILK_3E1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblCommValues As Label
    Friend WithEvents cboValue As ComboBox
    Friend WithEvents cboRange As ComboBox
    Friend WithEvents lblRangeCount As Label
End Class
