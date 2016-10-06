<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblEmployerTotal = New System.Windows.Forms.Label()
        Me.lblEmployeeTotal = New System.Windows.Forms.Label()
        Me.txtEmployeeCont = New System.Windows.Forms.TextBox()
        Me.txtEmployerCont = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Weekly Gross Pay"
        '
        'txtGross
        '
        Me.txtGross.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(290, 27)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(110, 30)
        Me.txtGross.TabIndex = 0
        Me.txtGross.Text = "1000"
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "&Employee Contribution (decimal)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "E&mployer Contribution (decimal)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Employee Contribution Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employer Contribution Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Yearly Retirement Contribution"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(290, 247)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(110, 30)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployerTotal
        '
        Me.lblEmployerTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployerTotal.Location = New System.Drawing.Point(290, 203)
        Me.lblEmployerTotal.Name = "lblEmployerTotal"
        Me.lblEmployerTotal.Size = New System.Drawing.Size(110, 30)
        Me.lblEmployerTotal.TabIndex = 13
        Me.lblEmployerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeTotal
        '
        Me.lblEmployeeTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeTotal.Location = New System.Drawing.Point(290, 155)
        Me.lblEmployeeTotal.Name = "lblEmployeeTotal"
        Me.lblEmployeeTotal.Size = New System.Drawing.Size(110, 30)
        Me.lblEmployeeTotal.TabIndex = 12
        Me.lblEmployeeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeCont
        '
        Me.txtEmployeeCont.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeCont.Location = New System.Drawing.Point(290, 71)
        Me.txtEmployeeCont.Name = "txtEmployeeCont"
        Me.txtEmployeeCont.Size = New System.Drawing.Size(110, 30)
        Me.txtEmployeeCont.TabIndex = 1
        Me.txtEmployeeCont.Text = "0.05"
        Me.txtEmployeeCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerCont
        '
        Me.txtEmployerCont.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployerCont.Location = New System.Drawing.Point(290, 115)
        Me.txtEmployerCont.Name = "txtEmployerCont"
        Me.txtEmployerCont.Size = New System.Drawing.Size(110, 30)
        Me.txtEmployerCont.TabIndex = 2
        Me.txtEmployerCont.Text = "0.07"
        Me.txtEmployerCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 306)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 38)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(155, 306)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtEmployerCont)
        Me.Controls.Add(Me.txtEmployeeCont)
        Me.Controls.Add(Me.lblEmployeeTotal)
        Me.Controls.Add(Me.lblEmployerTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirement_Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGross As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblEmployerTotal As Label
    Friend WithEvents lblEmployeeTotal As Label
    Friend WithEvents txtEmployeeCont As TextBox
    Friend WithEvents txtEmployerCont As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
