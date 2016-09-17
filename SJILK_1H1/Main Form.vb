' Name:         Photo Workshop Payroll Calulator    
' Purpose:      Calculates taxes and net pay per entered hours and pay rate
' Programmer:   Sarah Jilk on 09/17/2016

Option Explicit On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear fields

        lblGross.Text = String.Empty
        lblFICA.Text = String.Empty
        lblFed.Text = String.Empty
        lblNet.Text = String.Empty
        lblState.Text = String.Empty
        txtHours.Text = String.Empty
        txtName.Text = String.Empty
        txtPay.Text = String.Empty

        ' set to 0.00
        txtHours.Text = "0.00"
        txtPay.Text = "0.00"

        ' Set focus to employee name
        txtName.Focus()


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate Gross:
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPay.Text), "fixed")
        ' Calculate FEd:
        lblFed.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        'Calculate FICA:
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "Fixed")
        'Calculate State:
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        'Calculate Net:
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFed.Text) - Val(lblFICA.Text) - Val(lblState.Text), "fixed")
    End Sub
End Class
