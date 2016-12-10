'Name:          sjilk3e1
'Purpose:       P:523 #15 & #16
'Programmer:    Sarah Jillk 12/10/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750, 900,
        150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
        cboValue.SelectedIndex = 0
        cboRange.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommissions()
        lblCommValues.Text = String.Empty

        ' fill lstWholesale with array values

        For intSub As Integer = 0 To intCommission.GetUpperBound(0)
            lblCommValues.Text &= (intCommission(intSub).ToString() & ", ")
        Next intSub
        If lblCommValues.Text.EndsWith(", ") Then
            lblCommValues.Text = lblCommValues.Text.Substring(0, lblCommValues.Text.Length - 2)
        End If
    End Sub

    Private Sub cboValue_TextChanged(sender As Object, e As EventArgs) Handles cboValue.TextChanged

        Dim intSelection As Integer
        If Integer.TryParse(cboValue.Text, intSelection) AndAlso intSelection >= 1 AndAlso intSelection <= 1000 Then

            lblCount.Text = CountValue(intSelection).ToString()

        Else MessageBox.Show("Enter a value 1-1000", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function CountValue(intSearchValue As Integer) As Integer

        Dim intCount As Integer = 0
        For Each intComm As Integer In intCommission
            If intSearchValue = intComm Then
                intCount = intCount + 1
            End If
        Next intComm

        Return intCount
    End Function

    Private Sub cboRange_TextChanged(sender As Object, e As EventArgs) Handles cboRange.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboRange.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboRange.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboRange.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboRange.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).Tostring

            End If
        End If
    End Sub

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intCountRange As Integer = 0
        For Each intComm As Integer In intCommission
            If intSearchMin <= intComm AndAlso intSearchMax >= intComm Then
                intCountRange = intCountRange + 1
            End If
        Next intComm

        Return intCountRange
    End Function
End Class
