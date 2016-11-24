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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnLoopUntil = New System.Windows.Forms.Button()
        Me.btnLoopWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSumDo = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.btnFor)
        Me.GroupBox1.Controls.Add(Me.btnLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnLoopWhile)
        Me.GroupBox1.Controls.Add(Me.btnDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnDoWhile)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 263)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P347 #13 Loop Even"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(6, 28)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(124, 204)
        Me.lblEven.TabIndex = 6
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(136, 174)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(132, 25)
        Me.btnFor.TabIndex = 5
        Me.btnFor.Text = "Pre: For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnLoopUntil
        '
        Me.btnLoopUntil.Location = New System.Drawing.Point(136, 143)
        Me.btnLoopUntil.Name = "btnLoopUntil"
        Me.btnLoopUntil.Size = New System.Drawing.Size(132, 25)
        Me.btnLoopUntil.TabIndex = 4
        Me.btnLoopUntil.Text = "Post: Loop Until"
        Me.btnLoopUntil.UseVisualStyleBackColor = True
        '
        'btnLoopWhile
        '
        Me.btnLoopWhile.Location = New System.Drawing.Point(136, 112)
        Me.btnLoopWhile.Name = "btnLoopWhile"
        Me.btnLoopWhile.Size = New System.Drawing.Size(132, 25)
        Me.btnLoopWhile.TabIndex = 3
        Me.btnLoopWhile.Text = "Post: Loop While"
        Me.btnLoopWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(136, 81)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(132, 25)
        Me.btnDoUntil.TabIndex = 2
        Me.btnDoUntil.Text = "Pre: Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(136, 50)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(132, 25)
        Me.btnDoWhile.TabIndex = 1
        Me.btnDoWhile.Text = "Pre: Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnSumDo)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 263)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332_348 #22"
        '
        'txtList
        '
        Me.txtList.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtList.AllowDrop = True
        Me.txtList.Location = New System.Drawing.Point(19, 28)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(123, 204)
        Me.txtList.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Count:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Average:"
        '
        'lblCount
        '
        Me.lblCount.AllowDrop = True
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(230, 53)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(52, 56)
        Me.lblCount.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(163, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Sum, For Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Sum, Loop Until"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSumDo
        '
        Me.btnSumDo.Location = New System.Drawing.Point(163, 117)
        Me.btnSumDo.Name = "btnSumDo"
        Me.btnSumDo.Size = New System.Drawing.Size(119, 32)
        Me.btnSumDo.TabIndex = 1
        Me.btnSumDo.Text = "Sum Do While"
        Me.btnSumDo.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.AllowDrop = True
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(163, 53)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(52, 56)
        Me.lblAvg.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 364)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "SJILK_3A1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFor As Button
    Friend WithEvents btnLoopUntil As Button
    Friend WithEvents btnLoopWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSumDo As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents txtList As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
