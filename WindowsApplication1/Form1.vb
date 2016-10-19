' Name:         Money Conversion
' Purpose:      Displays conversions from US dollar to 
'               Euro, Pound, Rand
' Programmer:   Sarah Jilk on 10/17/2016

Public Class Form1
    Private Sub btnConvET_Click(sender As Object, e As EventArgs) Handles btnConvET.Click
        '        Displays conversions from US dollar to 
        '               Euro, Pound, Rand

        Const dblEuroRate As Double = 0.9
        Const dblPoundRate As Double = 0.79
        Const dblRandRate As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtDollar.Text = String.Empty Then
            MessageBox.Show("Please enter a value for American Dollar", "Conversion Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtDollar.Text, dblAmDollar)
            'Calulcate:

            dblEuro = dblAmDollar * dblEuroRate
            dblPound = dblAmDollar * dblPoundRate
            dblRand = dblAmDollar * dblRandRate
            ' display calculations

            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")
        End If
    End Sub

    Private Sub txtDollar_Enter(sender As Object, e As EventArgs) Handles txtDollar.Enter
        'selects text
        txtDollar.SelectAll()
    End Sub

    Private Sub btnConvNE_Click(sender As Object, e As EventArgs) Handles btnConvNE.Click
        '        Displays conversions from US dollar to 
        '               Euro, Pound, Rand

        Const dblEuroRate As Double = 0.9
        Const dblPoundRate As Double = 0.79
        Const dblRandRate As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtDollar.Text <> String.Empty Then
            Double.TryParse(txtDollar.Text, dblAmDollar)
            'Calulcate:

            dblEuro = dblAmDollar * dblEuroRate
            dblPound = dblAmDollar * dblPoundRate
            dblRand = dblAmDollar * dblRandRate
            ' display calculations

            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")

        Else
            MessageBox.Show("Please enter a value for American Dollar", "Conversion Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click
        Const dblShipping As Double = 15
        Dim dblPounds As Double
        Dim dblPrice As Double
        Dim dblTotal As Double

        'Clear values
        lblTotalTea.Text = String.Empty

        Double.TryParse(txtLBSTea.Text, dblPounds)
        Double.TryParse(txtPriceTea.Text, dblPrice)

        dblTotal = dblPounds * dblPrice

        If MessageBox.Show("Charge customer shipping?", "Tea Time", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            dblTotal = dblTotal + dblShipping
            lblTotalTea.Text = dblTotal.ToString("c2")
        Else
            lblTotalTea.Text = dblTotal.ToString("c2")
        End If

    End Sub

    Private Sub btnCalcElect_Click(sender As Object, e As EventArgs) Handles btnCalcElect.Click
        Const dblUnit As Double = 0.13
        Dim dblPrev As Double
        Dim dblCurr As Double
        Dim dblElectTot As Double

        'Clear label
        lblTotalTea.Text = String.Empty

        Double.TryParse(txtPrev.Text, dblPrev)
        Double.TryParse(txtCurr.Text, dblCurr)

        If dblCurr < dblPrev OrElse txtCurr.Text = String.Empty OrElse txtPrev.Text = String.Empty Then
            MessageBox.Show("Current reading must be greater than previous reading.", "Triple County Electric",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            dblElectTot = (dblCurr - dblPrev) * dblUnit

            lblTotalBill.Text = dblElectTot.ToString("c2")
        End If

    End Sub

    Private Sub btnCALCDIV_Click(sender As Object, e As EventArgs) Handles btnCALCDIV.Click
        Dim dblFirst As Double
        Dim dblSecond As Double
        Dim dblQuotient As Double

        'Clear label
        lblQuotient.Text = String.Empty

        Double.TryParse(txtFIRST.Text, dblFirst)
        Double.TryParse(txtSecond.Text, dblSecond)

        If txtFIRST.Text = "0" OrElse txtSecond.Text = "0" Then
            MessageBox.Show("Cannot divide by 0", "Division Calculater",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dblFirst < dblSecond Then
                Dim dblTemp As Double
                dblTemp = dblFirst
                dblFirst = dblSecond
                dblSecond = dblTemp

                dblQuotient = dblFirst / dblSecond

                lblQuotient.Text = dblQuotient.ToString("n2")
            Else
                dblQuotient = dblFirst / dblSecond

                lblQuotient.Text = dblQuotient.ToString("n2")

            End If

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
