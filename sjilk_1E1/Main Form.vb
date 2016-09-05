' Name:         Tax Assessment Project
' Purpose:      Calculates property tax based on user entered property assessment.
' Programmer:   Sarah Jilk on 09/05/2016


Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate Property tax as $1.50 for every $100
        lblTax.Text = ((Val(txtAssesssed.Text) / 100) * 1.5)
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form for next calculation
        lblTax.Text = String.Empty
        txtAssesssed.Text = String.Empty
        ' Focus to Assessed
        txtAssesssed.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
