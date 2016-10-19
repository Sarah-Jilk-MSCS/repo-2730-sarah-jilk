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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDollar = New System.Windows.Forms.TextBox()
        Me.btnConvNE = New System.Windows.Forms.Button()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.btnConvET = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalTea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcTea = New System.Windows.Forms.Button()
        Me.txtPriceTea = New System.Windows.Forms.TextBox()
        Me.txtLBSTea = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalBill = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalcElect = New System.Windows.Forms.Button()
        Me.txtCurr = New System.Windows.Forms.TextBox()
        Me.txtPrev = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFIRST = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnCALCDIV = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDollar)
        Me.GroupBox1.Controls.Add(Me.btnConvNE)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.btnConvET)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "#1 - Currency Converter"
        '
        'txtDollar
        '
        Me.txtDollar.Location = New System.Drawing.Point(21, 58)
        Me.txtDollar.Name = "txtDollar"
        Me.txtDollar.Size = New System.Drawing.Size(100, 22)
        Me.txtDollar.TabIndex = 0
        '
        'btnConvNE
        '
        Me.btnConvNE.Location = New System.Drawing.Point(127, 74)
        Me.btnConvNE.Name = "btnConvNE"
        Me.btnConvNE.Size = New System.Drawing.Size(85, 35)
        Me.btnConvNE.TabIndex = 9
        Me.btnConvNE.Text = "Convert <>"
        Me.btnConvNE.UseVisualStyleBackColor = True
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(430, 57)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(100, 23)
        Me.lblRand.TabIndex = 4
        '
        'btnConvET
        '
        Me.btnConvET.Location = New System.Drawing.Point(127, 21)
        Me.btnConvET.Name = "btnConvET"
        Me.btnConvET.Size = New System.Drawing.Size(85, 35)
        Me.btnConvET.TabIndex = 1
        Me.btnConvET.Text = "Convert ="
        Me.btnConvET.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(460, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "&Rand:"
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(324, 57)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(100, 23)
        Me.lblPound.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Pound:"
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(218, 57)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(100, 23)
        Me.lblEuro.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Euro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "&Dollar:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalTea)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnCalcTea)
        Me.GroupBox2.Controls.Add(Me.txtPriceTea)
        Me.GroupBox2.Controls.Add(Me.txtLBSTea)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "#3 - Tea Time Company"
        '
        'lblTotalTea
        '
        Me.lblTotalTea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalTea.Location = New System.Drawing.Point(415, 50)
        Me.lblTotalTea.Name = "lblTotalTea"
        Me.lblTotalTea.Size = New System.Drawing.Size(100, 22)
        Me.lblTotalTea.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Due:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price/lbs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pounds"
        '
        'btnCalcTea
        '
        Me.btnCalcTea.Location = New System.Drawing.Point(297, 41)
        Me.btnCalcTea.Name = "btnCalcTea"
        Me.btnCalcTea.Size = New System.Drawing.Size(88, 36)
        Me.btnCalcTea.TabIndex = 2
        Me.btnCalcTea.Text = "Calculate"
        Me.btnCalcTea.UseVisualStyleBackColor = True
        '
        'txtPriceTea
        '
        Me.txtPriceTea.Location = New System.Drawing.Point(161, 48)
        Me.txtPriceTea.Name = "txtPriceTea"
        Me.txtPriceTea.Size = New System.Drawing.Size(100, 22)
        Me.txtPriceTea.TabIndex = 1
        '
        'txtLBSTea
        '
        Me.txtLBSTea.Location = New System.Drawing.Point(25, 48)
        Me.txtLBSTea.Name = "txtLBSTea"
        Me.txtLBSTea.Size = New System.Drawing.Size(100, 22)
        Me.txtLBSTea.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalBill)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnCalcElect)
        Me.GroupBox3.Controls.Add(Me.txtCurr)
        Me.GroupBox3.Controls.Add(Me.txtPrev)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 113)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "#4 Triple County Electric"
        '
        'lblTotalBill
        '
        Me.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBill.Location = New System.Drawing.Point(411, 69)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(100, 22)
        Me.lblTotalBill.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(418, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Monthly Bill:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Current Read:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Previous Read:"
        '
        'btnCalcElect
        '
        Me.btnCalcElect.Location = New System.Drawing.Point(293, 55)
        Me.btnCalcElect.Name = "btnCalcElect"
        Me.btnCalcElect.Size = New System.Drawing.Size(88, 36)
        Me.btnCalcElect.TabIndex = 2
        Me.btnCalcElect.Text = "Calculate"
        Me.btnCalcElect.UseVisualStyleBackColor = True
        '
        'txtCurr
        '
        Me.txtCurr.Location = New System.Drawing.Point(157, 67)
        Me.txtCurr.Name = "txtCurr"
        Me.txtCurr.Size = New System.Drawing.Size(100, 22)
        Me.txtCurr.TabIndex = 1
        '
        'txtPrev
        '
        Me.txtPrev.Location = New System.Drawing.Point(21, 67)
        Me.txtPrev.Name = "txtPrev"
        Me.txtPrev.Size = New System.Drawing.Size(100, 22)
        Me.txtPrev.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblQuotient)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btnCALCDIV)
        Me.GroupBox4.Controls.Add(Me.txtSecond)
        Me.GroupBox4.Controls.Add(Me.txtFIRST)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 377)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(540, 108)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "#5 - Division Calculater"
        '
        'txtFIRST
        '
        Me.txtFIRST.Location = New System.Drawing.Point(20, 59)
        Me.txtFIRST.Name = "txtFIRST"
        Me.txtFIRST.Size = New System.Drawing.Size(100, 22)
        Me.txtFIRST.TabIndex = 0
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(156, 59)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 22)
        Me.txtSecond.TabIndex = 1
        '
        'btnCALCDIV
        '
        Me.btnCALCDIV.Location = New System.Drawing.Point(292, 50)
        Me.btnCALCDIV.Name = "btnCALCDIV"
        Me.btnCALCDIV.Size = New System.Drawing.Size(88, 36)
        Me.btnCALCDIV.TabIndex = 2
        Me.btnCALCDIV.Text = "Calculate"
        Me.btnCALCDIV.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "First #:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(160, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Second #:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(421, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Quotient:"
        '
        'lblQuotient
        '
        Me.lblQuotient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotient.Location = New System.Drawing.Point(410, 59)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(100, 22)
        Me.lblQuotient.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(256, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 531)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDollar As TextBox
    Friend WithEvents lblRand As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvNE As Button
    Friend WithEvents btnConvET As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalTea As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcTea As Button
    Friend WithEvents txtPriceTea As TextBox
    Friend WithEvents txtLBSTea As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalcElect As Button
    Friend WithEvents txtCurr As TextBox
    Friend WithEvents txtPrev As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblQuotient As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCALCDIV As Button
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents txtFIRST As TextBox
    Friend WithEvents btnExit As Button
End Class
