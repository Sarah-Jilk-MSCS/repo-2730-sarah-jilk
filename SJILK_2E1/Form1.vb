'Name:       SJILK 2E1
'Programmer: Sarah Jilk on 10/19/2016


Public Class frmCommission
    Private Sub btnSavannahAnd_Click(sender As Object, e As EventArgs) Handles btnSavannahAnd.Click
        Dim dblShipping As Double
        Dim dblOrder As Double
        Dim strCC As String
        'clear
        lblShipping.Text = String.Empty
        'convert
        Double.TryParse(txtOrder.Text, dblOrder)
        strCC = txtCC.Text.ToUpper
        'calculate and display
        If dblOrder >= 100 AndAlso strCC = "Y" Then
            dblShipping = 0
            lblShipping.Text = dblShipping.ToString("c2")
        Else
            dblShipping = 9
            lblShipping.Text = dblShipping.ToString("c2")
        End If


    End Sub

    Private Sub btnSavannahOr_Click(sender As Object, e As EventArgs) Handles btnSavannahOr.Click
        Dim dblShipping As Double
        Dim dblOrder As Double
        Dim strCC As String
        'clear
        lblShipping.Text = String.Empty
        'convert    
        Double.TryParse(txtOrder.Text, dblOrder)
        strCC = txtCC.Text.ToUpper
        'calculate and display
        If dblOrder < 100 OrElse strCC <> "Y" Then

            dblShipping = 9
            lblShipping.Text = dblShipping.ToString("c2")

        Else
            dblShipping = 0
            lblShipping.Text = dblShipping.ToString("c2")

        End If

    End Sub

    Private Sub btnCommAnd_Click(sender As Object, e As EventArgs) Handles btnCommAnd.Click

        Const dblComm1 As Double = 0.15
        Const dblComm2 As Double = 0.12
        Dim strID As String
        Dim dblSales As Double
        Dim dblComm As Double
        'clear label
        lblComm.Text = String.Empty
        'convert
        Double.TryParse(txtSales.Text, dblSales)
        strID = txtID.Text.ToUpper
        'calculate and display
        If (strID <> "A1" AndAlso strID <> "B2" AndAlso strID <> "C3") OrElse dblSales < 25000 Then
            dblComm = dblSales * dblComm2
            lblComm.Text = dblComm.ToString("c2")
        Else
            dblComm = dblSales * dblComm1
            lblComm.Text = dblComm.ToString("c2")
        End If

    End Sub

    Private Sub btnCommOr_Click(sender As Object, e As EventArgs) Handles btnCommOr.Click

        Const dblComm1 As Double = 0.15
        Const dblComm2 As Double = 0.12
        Dim strID As String
        Dim dblSales As Double
        Dim dblComm As Double
        'clear label
        lblComm.Text = String.Empty
        'convert
        Double.TryParse(txtSales.Text, dblSales)
        strID = txtID.Text.ToUpper
        'calculate and display
        If (strID = "A1" OrElse strID = "B2" OrElse strID = "C3") AndAlso dblSales >= 25000 Then
            dblComm = dblSales * dblComm1
            lblComm.Text = dblComm.ToString("c2")
        Else
            dblComm = dblSales * dblComm2
            lblComm.Text = dblComm.ToString("c2")
        End If
    End Sub
End Class
