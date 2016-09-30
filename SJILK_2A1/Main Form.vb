' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Sarah Jilk on 09/29/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales

        Const strPROMPT As String = "Salesclerk's name: "
        Const strTITLE As String = "Name Entry"
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTax_Rate As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        'assign name to variable
        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        'calculate total number of items sold
        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)
        intTotalItems = intDonuts + intMuffins

        'calculate the subtotal
        decSubtotal = intTotalItems * decITEM_PRICE

        'calculate sales tax
        decSalesTax = decSubtotal * decTax_Rate

        'calculate total sales
        decTotalSales = decSubtotal + decSalesTax

        'Display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("c2")

        'display tax and clerks name
        lblMsg.Text = "The sales tax was " & decSalesTax.ToString("C2") & "." &
            ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        'clear the total items, sales, and message

        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
    End Sub
End Class