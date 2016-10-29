Public Class frm1
    Private Sub btnCalcIf_Click(sender As Object, e As EventArgs) Handles btnCalcIf.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommission = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommission = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso
                dblSales < 30000.0 Then
            dblCommission = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommission = 3120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotal = dblCommission + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btbCalcNestIf_Click(sender As Object, e As EventArgs) Handles btbCalcNestIf.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommission = 0.0
        Else
            If dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
                dblCommission = dblSales * 0.1
            Else
                If dblSales >= 6000.0 AndAlso
                    dblSales < 30000.0 Then
                    dblCommission = 120.0 + (dblSales - 6000.0) * 0.13
                Else
                    If dblSales >= 30000.0 Then
                        dblCommission = 3120.0 + (dblSales - 30000.0) * 0.14
                    End If
                End If
            End If
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotal = dblCommission + dblAdditional

        lblCommission.Text = dblCommission.ToString("c2")
        lblAdditional.Text = dblAdditional.ToString("c2")
        lblTotal.Text = dblTotal.ToString("c2")

        txtSales.Focus()
    End Sub

    Private Sub btnCalcIfElse_Click(sender As Object, e As EventArgs) Handles btnCalcIfElse.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommission = 0.0
        ElseIf dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommission = dblSales * 0.1
        ElseIf dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommission = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf dblSales >= 30000.0 Then
            dblCommission = 3120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotal = dblCommission + dblAdditional

        lblCommission.Text = dblCommission.ToString("c2")
        lblAdditional.Text = dblAdditional.ToString("c2")
        lblTotal.Text = dblTotal.ToString("c2")

        txtSales.Focus()
    End Sub

    Private Sub btnCalcSelect_Click(sender As Object, e As EventArgs) Handles btnCalcSelect.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        Select Case dblSales
            Case < 1.0
                dblCommission = 0.0
            Case 1 To 5999.99
                dblCommission = dblSales * 0.1
            Case 6000.0 To 29999.99
                dblCommission = 120.0 + (dblSales - 6000.0) * 0.13
            Case >= 30000.0
                dblCommission = 3120.0 + (dblSales - 30000.0) * 0.14
        End Select


        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotal = dblCommission + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If

        txtSales.Focus()
    End Sub
End Class
