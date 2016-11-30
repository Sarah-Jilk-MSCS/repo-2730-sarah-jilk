' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Sarah Jilk on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Const dblTaxRate As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("Do Loop:")
        Integer.TryParse(txtNumber.Text, number)
        'Do Loop

        Do Until count = 9
            count = count + 1
            product = number * count

            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString & " = " & product.ToString()
            'add strOutput to Listbox
            lstMultTable.Items.Add(strOutput)
        Loop



    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For Loop:")
        Integer.TryParse(txtNumber.Text, number)
        'For Loop
        For count = 1 To 9 Step 1
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString & " = " & product.ToString()
            'add strOutput to Listbox
            lstMultTable.Items.Add(strOutput)
        Next count

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load listbox with data
        For dblPrices As Double = 1 To 4 Step 1
            lstPrices.Items.Add(dblPrices.ToString("n2"))
        Next dblPrices

        Dim dblPreTaxTotal As Double
        Dim strSelectedItem As String
        Dim index As Integer
        Dim dblSelectedPrice As Double

        For index = 0 To (lstPrices.Items.Count - 1) Step 1
            lstPrices.SelectedIndex = index
            strSelectedItem = lstPrices.ToString()
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal

        Next index

        lblPretax.Text = dblPreTaxTotal.ToString("n2")



    End Sub
End Class
