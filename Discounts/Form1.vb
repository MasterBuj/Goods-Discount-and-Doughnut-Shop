Imports System.Globalization

Public Class Form1

    'Often when perishable goods are sold, a discount is given that depends on how long an 
    'item has been on a store's shelf.Assume that in a particular store, the first day an 
    'item is for sale for no discount.On the second day assume that a 10% discount is given, 
    'on the third day a 15% discount, and on the fourth day a 20% discount up to 25%.

    'Write a program to read the price of an item and then compute its sale price for the 
    'second third, and fourth days. Prompt the user for the needed input and display the 
    'results with proper labels. Make sure that your program will not accept numbers less than zero.
    
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles calDiscount.Click
        Dim origPrice As Double = inputPrice.Value

        firstDay.Text = origPrice
        secondDay.Text = origPrice - (origPrice * 0.1)
        thirdDay.Text = origPrice - (origPrice * 0.15)
        fourthDay.Text = origPrice - (origPrice * 0.2)

        d1.Text = "0%"
        d2.Text = "10%"
        d3.Text = "15%"
        d4.Text = "20%"
    End Sub


    'The Delectable Doughnut Shop normally sells its doughnuts for Php 12.00 each, 
    'six for PhP 72.00 or PhP 144.00 per dozen. Bulk purchases are given an extra 
    '2% discount for each 10 dozen per order up to 20% (that is, when 100 or more dozen are ordered).

    'Write a program to read the purchases and compute the total amount. Prompt the user for the needed 
    'input and display the results with proper labels. Make sure that your program will not accept numbers less than zero.
    
    Private Sub DozenPreset(sender As Object, e As EventArgs) Handles p6.Click, dz8.Click, dz6.Click, dz4.Click, dz3.Click, dz2.Click, dz10.Click, dz1.Click, Button2.Click

        Dim dozen As Integer = 12

        Select Case sender.Text
            Case "Clear"
                piecesOfDoughnut.Value = 0
            Case "6 pcs"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (6)
            Case "1 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (1 * dozen)
            Case "2 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (2 * dozen)
            Case "3 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (3 * dozen)
            Case "4 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (4 * dozen)
            Case "6 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (6 * dozen)
            Case "8 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (8 * dozen)
            Case "10 " & vbCrLf & "dozen"
                piecesOfDoughnut.Value = piecesOfDoughnut.Value + (10 * dozen)
        End Select

    End Sub

    Private Sub CalDougnut_Click(sender As Object, e As EventArgs) Handles calDougnut.Click
        Dim allPieces As Integer = piecesOfDoughnut.Value
        Dim dozen As Integer = allPieces \ 12
        Dim pieces As Integer = allPieces - (dozen * 12)
        Dim price As Double = 12.0
        Dim dozenPrice As Double = price * 12.0

        dozenLabel.Text = If(dozen > 0, dozen & "x Dozen", "")
        piecesLabel.Text = If(pieces > 0, pieces & "x Pieces", "")
        dozenPrizeLabel.Text = If(dozen > 0, "Php " & (dozen * dozenPrice).ToString("N", CultureInfo.InvariantCulture), "")
        piecesPrizeLabel.Text = If(pieces > 0, "Php " & (pieces * price).ToString("N", CultureInfo.InvariantCulture), "")

        Dim discount As Double = ((dozen * dozenPrice) * ((dozen / 10) * 0.02))
        totalBeforeDiscount.Text = "Php " & ((dozen * dozenPrice) + (pieces * price)).ToString("N", CultureInfo.InvariantCulture)
        discountLabel.Text = If(dozen >= 10, "Php -" & discount.ToString("N", CultureInfo.InvariantCulture), 0)
        totalAmountLabel.Text = "Php " & ((dozen * dozenPrice) + (pieces * price) - discount).ToString("N", CultureInfo.InvariantCulture)
    End Sub


End Class