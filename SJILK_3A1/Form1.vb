Public Class frmMain
    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 21
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
        lblEven.Text = "Posttest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop While i <= 20

    End Sub

    Private Sub btnLoopUntil_Click(sender As Object, e As EventArgs) Handles btnLoopUntil.Click
        lblEven.Text = "Posttest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop Until i > 21
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        lblEven.Text = "For Loop" & ControlChars.NewLine
        Dim i As Integer
        For i = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i
    End Sub

    Private Sub btnSumDo_Click(sender As Object, e As EventArgs) Handles btnSumDo.Click
        'Clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPrompt As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount
        strNum = InputBox(strPrompt, strTitle, "0")

        Do While strNum <> String.Empty

            'convert input to a number
            Int32.TryParse(strNum, intNum)

            'display the input in the text box
            txtList.Text = txtList.Text &
            intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPrompt, strTitle, "0")

            '***end loop here
        Loop

        lblCount.Text = intCount.ToString
        'verify the count is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("n2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPrompt As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount
        strNum = InputBox(strPrompt, strTitle, "0")

        Do

            'convert input to a number
            Int32.TryParse(strNum, intNum)

            'display the input in the text box
            txtList.Text = txtList.Text &
            intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPrompt, strTitle, "0")

            '***end loop here
        Loop Until strNum = String.Empty

        lblCount.Text = intCount.ToString
        'verify the count is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("n2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPrompt As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTitle As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intQuant As Integer


        intQuant = InputBox("Enter quantity of numbers.", "Quantity")

        For intQuant = 1 To intQuant
            'get first sales amount
            strNum = InputBox(strPrompt, strTitle, "0")

            'convert input to a number
            Int32.TryParse(strNum, intNum)

            'display the input in the text box
            txtList.Text = txtList.Text &
            intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            '***end loop here
        Next intQuant

        lblCount.Text = intCount.ToString
        'verify the count is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("n2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
