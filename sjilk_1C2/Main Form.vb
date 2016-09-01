Public Class frmMain
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        frmStarWars.Show()
        tmrExit.Enabled = False
        'Me.Close()
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        frmToucan.Show()
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Close()
    End Sub
End Class
