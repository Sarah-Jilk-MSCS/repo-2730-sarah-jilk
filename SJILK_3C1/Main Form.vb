' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Sarah Jilk on 12/04/16

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged,
        radSubInches.CheckedChanged, radFuncCentimeters.CheckedChanged,
        radFuncInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = GetCentiFunc(dblMeasurement, dblResult)
        ElseIf radFuncInches.Checked Then
            dblResult = GetInchFunc(dblMeasurement, dblResult)
        End If

        lblResult.Text = dblResult.ToString("n2")

    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeasurement As Double, ByRef dblRes As Double)
        dblRes = dblMeasurement * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeasurement As Double, ByRef dblRes As Double)
        dblRes = dblMeasurement / 2.54
    End Sub

    Private Function GetCentiFunc(ByVal dblMeasurement As Double, ByRef dblRes As Double) As Double
        dblRes = dblMeasurement * 2.54
        Return dblRes
    End Function

    Private Function GetInchFunc(ByVal dblMeasurement As Double, ByRef dblRes As Double) As Double
        dblRes = dblMeasurement / 2.54
        Return dblRes
    End Function


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.Items.Add("Earth")
        cboPlanets.SelectedItem = "Earth"
    End Sub


    Private Sub txtearthweight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub WeightInputChanged(sender As Object, e As EventArgs) _
       Handles txtEarthWeight.TextChanged, rdoPlanetFunc.CheckedChanged, rdoPlanetSub.CheckedChanged, cboPlanets.SelectedIndexChanged


        Dim intEarthWeight As Integer = 0
        Dim dblWeightResult As Double = 0.0
        Dim dblGravity As Double = 0.0
        ' Dim strPlanet As String


        Integer.TryParse(txtEarthWeight.Text, intEarthWeight)


        If rdoPlanetSub.Checked Then
            calcWeightSub(intEarthWeight, cboPlanets.Text, dblGravity)
        ElseIf rdoPlanetFunc.Checked Then
            dblGravity = GetWeightFunc(intEarthWeight, cboPlanets.Text)
        End If

        lblWeight.Text = dblGravity.ToString("n2")

    End Sub


    Private Sub calcWeightSub(ByVal intEarthWeight As Integer, ByVal strPlanet As String, ByRef dblGravity As Double)

        Select Case strPlanet
            Case Is = "Earth"
                dblGravity = intEarthWeight * 1.0
            Case Is = "Mercury", "Mars"
                dblGravity = intEarthWeight * 0.38
            Case Is = "Venus"
                dblGravity = intEarthWeight * 0.91
            Case Is = "Jupiter"
                dblGravity = intEarthWeight * 2.34
            Case Is = "Saturn"
                dblGravity = intEarthWeight * 1.06
            Case Is = "Uranus"
                dblGravity = intEarthWeight * 0.92
            Case Is = "Neptune"
                dblGravity = intEarthWeight * 1.14
            Case Is = "Pluto"
                dblGravity = intEarthWeight * 0.06
        End Select
    End Sub

    Private Function GetWeightFunc(ByVal intEarthWeight As Integer, ByVal strplanet As String) As Double

        Dim dblGravity As Double

        Select Case strplanet
            Case Is = "Earth"
                dblGravity = intEarthWeight * 1.0
            Case Is = "Mercury", "Mars"
                dblGravity = intEarthWeight * 0.38
            Case Is = "Venus"
                dblGravity = intEarthWeight * 0.91
            Case Is = "Jupiter"
                dblGravity = intEarthWeight * 2.34
            Case Is = "Saturn"
                dblGravity = intEarthWeight * 1.06
            Case Is = "Uranus"
                dblGravity = intEarthWeight * 0.92
            Case Is = "Neptune"
                dblGravity = intEarthWeight * 1.14
            Case Is = "Pluto"
                dblGravity = intEarthWeight * 0.06
        End Select

        Return dblGravity

    End Function


End Class
