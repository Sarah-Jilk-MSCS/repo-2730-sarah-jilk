' Name:         Cranston Berries Applications   
' Purpose:      Calculates projected increase in sales
' Programmer:   Sarah Jilk on 09/06/2016

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblBlue.Text = Format(Val(txtBlue.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
        lblRasp.Text = Format(Val(txtRasp.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
        lblStraw.Text = Format(Val(txtStraw.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
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
End Class
