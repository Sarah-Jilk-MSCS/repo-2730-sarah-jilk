' Name:         Retirement Form   
' Purpose:      Calculates yearly retirement contributions
' Programmer:   Sarah Jilk on 10/05/2016

Option Strict On
Option Explicit On
Option Infer Off


Public Class frmRetirement
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declare variables
        Dim decGross As Decimal
        Dim decEECont As Decimal
        Dim decERCont As Decimal
        Dim decEEContTot As Decimal
        Dim decERContTot As Decimal
        Dim decTotal As Decimal

        'translate text to decimal
        Decimal.TryParse(txtGross.Text, decGross)
        Decimal.TryParse(txtEmployeeCont.Text, decEECont)
        Decimal.TryParse(txtEmployerCont.Text, decERCont)

        'Calulate 
        decEEContTot = decEECont * 52 * decGross
        decERContTot = decERCont * 52 * decGross
        decTotal = decEEContTot + decERContTot

        'Convert to sting and display
        lblEmployeeTotal.Text = decEEContTot.ToString("c2")
        lblEmployerTotal.Text = decERContTot.ToString("c2")
        lblTotal.Text = decTotal.ToString("c2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear form
        txtEmployeeCont.Text = String.Empty
        txtEmployerCont.Text = String.Empty
        txtGross.Text = String.Empty
        lblEmployeeTotal.Text = String.Empty
        lblEmployerTotal.Text = String.Empty
        lblTotal.Text = String.Empty

        'set focus
        txtGross.Focus()

        'set defaults
        txtGross.Text = "1000"
        txtEmployerCont.Text = "0.07"
        txtEmployeeCont.Text = "0.05"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class