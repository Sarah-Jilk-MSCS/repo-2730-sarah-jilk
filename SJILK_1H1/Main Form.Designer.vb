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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFed = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(26, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(139, 23)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "&Employee Name:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(233, 23)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(59, 23)
        Me.lblHours.TabIndex = 12
        Me.lblHours.Text = "&Hours:"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Location = New System.Drawing.Point(318, 23)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(79, 23)
        Me.lblPay.TabIndex = 13
        Me.lblPay.Text = "&Pay Rate:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(30, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 30)
        Me.txtName.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(237, 49)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(67, 30)
        Me.txtHours.TabIndex = 1
        Me.txtHours.Text = "0.00"
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(322, 49)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(84, 30)
        Me.txtPay.TabIndex = 2
        Me.txtPay.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Gross Pay:"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(293, 106)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(91, 32)
        Me.lblGross.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Federal Withholding Tax (FWT):"
        '
        'lblFed
        '
        Me.lblFed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFed.Location = New System.Drawing.Point(293, 160)
        Me.lblFed.Name = "lblFed"
        Me.lblFed.Size = New System.Drawing.Size(91, 32)
        Me.lblFed.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Social Security Tax (FICA):"
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICA.Location = New System.Drawing.Point(293, 214)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(91, 32)
        Me.lblFICA.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "State Income Tax:"
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Location = New System.Drawing.Point(293, 268)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(91, 32)
        Me.lblState.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 319)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Net Pay:"
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(293, 322)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(91, 32)
        Me.lblNet.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(25, 389)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 34)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(175, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 34)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(325, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 34)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 437)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblFed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sjilk1H1_Photo Workshop Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFed As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblState As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
