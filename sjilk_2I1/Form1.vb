'SJILK_2I1
'Sarah Jilk on 11/12/2016

Option Strict On
Option Infer Off
Option Explicit On


Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#3 Insert
        Dim strWord As String = txt3remove.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl3Remove.Text = strWord

        '#4 Substring
        Dim strItem As String = txt4Substring.Text
        Dim strColor As String
        strColor = strItem.Substring(2, 4)
        lbl4Substring.Text = strColor

        '#5a Length
        Dim strMSG As String = txt5ALength.Text.Trim
        Dim intCharCount As Integer
        intCharCount = strMSG.Length
        lbl5ASize.Text = intCharCount.ToString

        '#5b Trim
        Dim strState As String = txt5BTrim.Text.Trim
        lbl5BTrim.Text = strState

        '5c Remove/Insert
        Dim str5cWord As String = txt5CRemove.Text
        str5cWord = str5cWord.Remove(1, 1)
        str5cWord = str5cWord.Insert(1, "rit")
        lbl5CRemove.Text = str5cWord

        '5d Insert
        Dim str5dWord As String = txt5DInsert.Text
        str5dWord = str5dWord.Insert(0, "Mon")
        lbl5DInsert.Text = str5dWord

        '5e Pad
        Dim strPay As String = txt5EPad.Text.Trim
        strPay = strPay.PadLeft(10, "*"c)
        lbl5EPad.Text = strPay

        '6 Remove
        Dim str6Amount As String = txt6Remove.Text
        str6Amount = str6Amount.Remove(1, 1)
        str6Amount = str6Amount.Remove(4, 1)
        lbl6Remove.Text = str6Amount

        '7 Contains
        Dim str7Address As String = txt7Contains.Text
        Dim blnIsContained As Boolean
        str7Address = str7Address.Trim.ToUpper
        blnIsContained = str7Address.Contains("JEFFERSON ST")
        If blnIsContained = True Then
            lbl7Contains.Text = "Jeff St Found"
        Else lbl7Contains.Text = "Jeff St NOT Found"
        End If

        '#12 Len/Remove
        Dim str12Rate As String = txt12Len.Text.Trim
        Dim dbl12Taxrate As Double
        Dim int12Rate As Integer
        Dim dbl12Tax As Double
        If str12Rate.Contains(" %") Then
            int12Rate = str12Rate.IndexOf("%")
            str12Rate = str12Rate.Remove(int12Rate, 1)
        End If
        dbl12Taxrate = Double.Parse(str12Rate)
        dbl12Tax = 1000.0 * dbl12Taxrate * 0.01
        lbl12Len.Text = dbl12Tax.ToString




        '#13 Like
        Dim str13Zip As String = txt13Like.Text
        If str13Zip Like "605##" Then
            lbl13Like.Text = "Shipping: $25.00"
        ElseIf str13Zip Like "606##" Then
            lbl13Like.Text = "Shipping: $30.00 "
        Else lbl13Like.Text = "Invalid Zip"
        End If



    End Sub
End Class
