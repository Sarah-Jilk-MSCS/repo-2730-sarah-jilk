' Name: Ex 3D Array, subscript loops
' Purpose: Display days in each month
' Programmer: Sarah Jilk on 12/6/16

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intSelectedMonth As Integer
        Dim intSelectedDays As Integer
        If Integer.TryParse(txtMonth.Text, intSelectedMonth) AndAlso intSelectedMonth >= 1 AndAlso intSelectedMonth <= 12 Then
            intSelectedDays = intDays(intSelectedMonth - 1)
        Else MessageBox.Show("Enter a number 1-12", "Invalid Month", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lblDays.Text = intSelectedDays.ToString()
        txtMonth.Focus()
        txtMonth.SelectAll()


    End Sub

    Private intSold() As Integer = {250, 225, 193, 260}

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intLastSub As Integer = intSold.GetUpperBound(0)
        Dim dblHighest As Double = intSold(0)
        Dim dblTotal As Double

        For intSub As Integer = 0 To intLastSub
            dblTotal += intSold(intSub)
        Next intSub
        dblTotal = dblTotal / (intLastSub + 1)

        lblAvg.Text = dblTotal.ToString()

        For intSub As Integer = 0 To intLastSub
            If intSold(intSub) < dblTotal Then
                lblLessAvg.Text &= intSold(intSub).ToString & " , "
            End If
        Next intSub

        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click

        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim dblHighest As Double = intSold(0)
        Dim dblTotal As Double
        Dim dblTotAvg As Double

        For Each intSub As Integer In intSold
            dblTotal += intSub
        Next intSub
        dblTotAvg = dblTotal / intSold.Length

        lblAvg.Text = dblTotAvg.ToString()

        For Each intSub As Integer In intSold
            If intSub < dblTotAvg Then
                lblLessAvg.Text &= intSub.ToString & " , "
            End If
        Next intSub

        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If


    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        lblAvg.Text = String.Empty
        lblLessAvg.Text = String.Empty

        Dim intHighSub As Integer = intSold.Length - 1
        Dim intSub As Integer
        Dim dblTotal As Double

        Do While intSub <= intHighSub
            dblTotal += intSold(intSub)
            intSub += 1
        Loop
        dblTotal = dblTotal / intSold.Length
        lblAvg.Text = dblTotal.ToString()
        intSub = 0

        Do While intSub <= intHighSub
            If intSold(intSub) < dblTotal Then
                lblLessAvg.Text &= intSold(intSub).ToString & " , "
                intSub += 1
            Else intSub += 1
            End If
        Loop

        If lblLessAvg.Text.EndsWith(", ") Then
            lblLessAvg.Text = lblLessAvg.Text.Substring(0, lblLessAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        ' updates each array value and displays the updated values in lstRetail
        Dim strResponse As String
        Dim dblMarkup As Double
        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()

        strResponse = InputBox("Markup Rate",
                     "Enter Markup Rate", "50")
        If Double.TryParse(strResponse, dblMarkup) Then
            Double.TryParse(strResponse, dblMarkup)
            For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
                dblWholesale(intSub) = dblWholesale(intSub) * (1 + (dblMarkup / 100))
                lstRetail.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
            Next intSub
        Else
            MessageBox.Show("Enter a valid MarkUp", "Invalid Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fill lstWholesale with array values

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub
End Class
