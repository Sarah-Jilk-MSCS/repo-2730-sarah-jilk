' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Sarah Jilk on 10/16/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class chkParking
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged,
        radQueen.CheckedChanged, radKing.CheckedChanged,
        radStandard.CheckedChanged, radAtrium.CheckedChanged,
        chkParkingFee.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblParking.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display total room charge,
        ' tax, total resort fee, and total due

        Const intMAX_PER_ROOM As Integer = 6
        Const dblDaily_Room_Chg_Queen_Stand As Double = 225.5
        Const dblDaily_Room_Chg_Queen_Atrium As Double = 275
        Const dblDaily_Room_Chg_King_Stand As Double = 245.5
        Const dblDaily_Room_Chg_King_Atrium As Double = 325
        Const dblDaily_Room_Parking_Fee As Double = 8.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String = "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuest As Integer
        Dim dblRoomsRequired As Double
        Dim dblParkingFee As Double
        Dim dblDailyRoomCharge As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFees As Double
        Dim dblTotalDue As Double

        ' Store input in variables
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        ' Calculate total number of guests
        intNumGuest = intAdults + intChildren

        ' Calculate number of rooms required
        dblRoomsRequired = intNumGuest / intMAX_PER_ROOM

        'determine whether number of reserved rooms is adequate
        'and then either display a message or calculate and 
        'display the charges
        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Treeline Resort", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'calculate charges
            If radQueen.Checked Then
                If radStandard.Checked Then
                    dblDailyRoomCharge = dblDaily_Room_Chg_Queen_Stand
                Else
                    dblDailyRoomCharge = dblDaily_Room_Chg_Queen_Atrium
                End If
            Else
                If radStandard.Checked Then
                    dblDailyRoomCharge = dblDaily_Room_Chg_King_Stand
                Else
                    dblDailyRoomCharge = dblDaily_Room_Chg_King_Atrium
                End If
            End If
            dblTotalRoomChg = intRoomsReserved * intNights * dblDailyRoomCharge
            dblTax = dblTotalRoomChg * dblTAX_RATE
            dblTotalResortFees = intRoomsReserved * intNights * dblDAILY_RESORT_FEE
            If chkParkingFee.Checked Then
                dblParkingFee = intNights * dblDaily_Room_Parking_Fee
            End If
            dblTotalDue = dblTotalRoomChg + dblTax + dblTotalResortFees + dblParkingFee

            'diplay charges
            lblRoomChg.Text = dblTotalRoomChg.ToString("n2")
            lblTax.Text = dblTax.ToString("n2")
            lblResortFee.Text = dblTotalResortFees.ToString("n2")
            lblParking.Text = dblParkingFee.ToString("n2")
            lblTotalDue.Text = dblTotalDue.ToString("c2")
        End If
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                           ) Handles txtRooms.KeyPress, txtNights.KeyPress,
                           txtAdults.KeyPress, txtChildren.KeyPress
        ' Allows the text box to accept only numbers and the backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If

    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        'select contents when text box receives focus

        txtRooms.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        'select content when text box receives focus

        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        'select content when text box receives focus

        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        'select content when text box receives focus

        txtChildren.SelectAll()
    End Sub
End Class
