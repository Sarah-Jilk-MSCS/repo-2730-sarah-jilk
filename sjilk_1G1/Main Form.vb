' Name:         Score Averages
' Purpose:      Calculates the average of three test scores
' Programmer:   Sarah Jilk on 09/17/2016

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear screen for next calculation

        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
        lblAverageScore.Text = String.Empty

        ' Set focus to Score 1
        txtScore1.Focus()

        ' Set Scores back to zero
        txtScore1.Text = "0"
        txtScore2.Text = "0"
        txtScore3.Text = "0"

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates
        lblAverageScore.Text = Format(((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3), "fixed")
    End Sub
End Class
