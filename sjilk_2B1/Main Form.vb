' Name:         Cranston Berries Applications   
' Purpose:      Calculates projected increase in sales
' Programmer:   Sarah Jilk on 10/05/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim decIncrease As Decimal
        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRasp As Decimal
        Dim decTotalStraw As Decimal
        Dim decTotalBlue As Decimal
        Dim decTotalRasp As Decimal

        'Translate text to decimal
        Decimal.TryParse(txtProjIncrease.Text, decIncrease)
        Decimal.TryParse(txtStraw.Text, decStraw)
        Decimal.TryParse(txtRasp.Text, decRasp)
        Decimal.TryParse(txtBlue.Text, decBlue)

        'Calculate total decimals
        decTotalStraw = (decIncrease * decStraw) + decStraw
        decTotalRasp = (decIncrease * decRasp) + decRasp
        decTotalBlue = (decIncrease * decBlue) + decBlue

        'Convert back to string and display totals
        lblBlue.Text = decTotalBlue.ToString("c2")
        lblRasp.Text = decTotalRasp.ToString("c2")
        lblStraw.Text = decTotalStraw.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear values
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        lblStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        txtStraw.Text = String.Empty
        ' set focus to projected increase box
        txtProjIncrease.Focus()
        ' set projected increase back to 0.05
        txtProjIncrease.Text = "0.05"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRetirementForm_Click(sender As Object, e As EventArgs) Handles btnRetirementForm.Click
        frmRetirement.Show()
    End Sub
End Class
