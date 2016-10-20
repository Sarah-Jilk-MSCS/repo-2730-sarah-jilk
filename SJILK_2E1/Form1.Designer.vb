<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommission
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
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSavannahOr = New System.Windows.Forms.Button()
        Me.btnSavannahAnd = New System.Windows.Forms.Button()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCommAnd = New System.Windows.Forms.Button()
        Me.btnCommOr = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSavannahOr)
        Me.GroupBox1.Controls.Add(Me.btnSavannahAnd)
        Me.GroupBox1.Controls.Add(Me.txtCC)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "#14 Savannah's Web Site"
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipping.Location = New System.Drawing.Point(265, 60)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(100, 23)
        Me.lblShipping.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Shipping Charge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Savannah CC?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Order Amount:"
        '
        'btnSavannahOr
        '
        Me.btnSavannahOr.Location = New System.Drawing.Point(401, 74)
        Me.btnSavannahOr.Name = "btnSavannahOr"
        Me.btnSavannahOr.Size = New System.Drawing.Size(117, 31)
        Me.btnSavannahOr.TabIndex = 3
        Me.btnSavannahOr.Text = "Calculate(or)"
        Me.btnSavannahOr.UseVisualStyleBackColor = True
        '
        'btnSavannahAnd
        '
        Me.btnSavannahAnd.Location = New System.Drawing.Point(401, 21)
        Me.btnSavannahAnd.Name = "btnSavannahAnd"
        Me.btnSavannahAnd.Size = New System.Drawing.Size(117, 31)
        Me.btnSavannahAnd.TabIndex = 2
        Me.btnSavannahAnd.Text = "Calculate(And)"
        Me.btnSavannahAnd.UseVisualStyleBackColor = True
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(145, 61)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(41, 22)
        Me.txtCC.TabIndex = 1
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(11, 61)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(94, 22)
        Me.txtOrder.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblComm)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.btnCommOr)
        Me.GroupBox2.Controls.Add(Me.btnCommAnd)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 140)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "#18 Commission Calculator A1, B2, C3 = %15"
        '
        'btnCommAnd
        '
        Me.btnCommAnd.Location = New System.Drawing.Point(397, 34)
        Me.btnCommAnd.Name = "btnCommAnd"
        Me.btnCommAnd.Size = New System.Drawing.Size(116, 33)
        Me.btnCommAnd.TabIndex = 0
        Me.btnCommAnd.Text = "Calculate(and)"
        Me.btnCommAnd.UseVisualStyleBackColor = True
        '
        'btnCommOr
        '
        Me.btnCommOr.Location = New System.Drawing.Point(397, 85)
        Me.btnCommOr.Name = "btnCommOr"
        Me.btnCommOr.Size = New System.Drawing.Size(116, 33)
        Me.btnCommOr.TabIndex = 1
        Me.btnCommOr.Text = "Calculate(or)"
        Me.btnCommOr.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(29, 70)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(41, 22)
        Me.txtID.TabIndex = 2
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(123, 70)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(97, 22)
        Me.txtSales.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Commission:"
        '
        'lblComm
        '
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComm.Location = New System.Drawing.Point(249, 70)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(97, 22)
        Me.lblComm.TabIndex = 7
        '
        'frmCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCommission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SJILK 2E1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblShipping As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSavannahOr As Button
    Friend WithEvents btnSavannahAnd As Button
    Friend WithEvents txtCC As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblComm As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCommOr As Button
    Friend WithEvents btnCommAnd As Button
End Class
