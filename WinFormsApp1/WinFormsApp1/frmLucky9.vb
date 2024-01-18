Imports System.IO

Public Class frmLucky9
    Dim rnd As New Random
    Dim rnd1, rnd2, rnd3, rnd4, total As Integer ''' user 
    Dim rnd5, rnd6, rnd7, total1 As Integer ''' computer
    Private Sub frmLucky9_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMenu.Show()
        frmMenu.lblMoney.Text = Me.lblMoneyLN.Text
    End Sub
    Private Sub btnCarta_Click(sender As Object, e As EventArgs) Handles btnCarta.Click
        rnd1 = rnd.Next(0, 4)
        rnd4 = rnd.Next(1, 11)
        PB3.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd4 & ".png")
        PB3.Visible = True
        btnCarta.Enabled = False
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim a, b, c As Integer
        '''user
        If PB3.Image Is Nothing Then
            total = rnd2 + rnd3
            If total < 10 Then
                a = total
            ElseIf total = 10 Or total = 20 Then
                a = 0
            ElseIf total > 10 And total < 20 Then
                total = total - 10
                a = total
            End If
        Else
            total = rnd2 + rnd3 + rnd4
            If total < 10 Then
                a = total
            ElseIf total = 10 Or total = 20 Or total = 30 Then
                total = 0
                a = 0
            ElseIf total > 10 And total < 20 Then
                total = total - 10
                a = total
            ElseIf total > 20 Then
                total = total - 20
                a = total
            End If
        End If
        '''computer
        total1 = rnd5 + rnd6
        If total1 < 5 Then
            rnd1 = rnd.Next(0, 4)
            rnd7 = rnd.Next(1, 11)
            PB6.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd7 & ".png")
            PB6.Visible = True
        ElseIf total1 = 10 Or total1 = 20 Then
            rnd1 = rnd.Next(0, 4)
            rnd7 = rnd.Next(1, 11)
            PB6.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd7 & ".png")
            PB6.Visible = True
        ElseIf total1 > 10 And total1 < 20 Then
            total1 = total1 - 10
            If total1 < 5 Then
                rnd1 = rnd.Next(0, 4)
                rnd7 = rnd.Next(1, 11)
                PB6.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd7 & ".png")
                PB6.Visible = True
            End If
        End If
        If PB6.Image Is Nothing Then
            total1 = rnd5 + rnd6
            If total1 < 10 Then
                b = total1
            ElseIf total1 = 10 Or total1 = 20 Then
                b = 0
            ElseIf total1 > 10 And total1 < 20 Then
                total1 = total1 - 10
                b = total1
            End If
        Else
            total1 = rnd5 + rnd6 + rnd7
            If total1 < 10 Then
                b = total1
            ElseIf total1 = 10 Or total1 = 20 Or total1 = 30 Then
                total1 = 0
                b = 0
            ElseIf total1 > 10 And total1 < 20 Then
                total1 = total1 - 10
                b = total1
            ElseIf total1 > 20 Then
                total1 = total1 - 20
                b = total1
            End If
        End If
        If a > b Then
            PB4.Visible = True
            PB5.Visible = True
            MsgBox("You win " & CB1.Text, vbInformation, "")
            c = Val(lblMoneyLN.Text) + Val(CB1.Text)
            lblMoneyLN.Text = c
        ElseIf a < b Then
            PB4.Visible = True
            PB5.Visible = True
            MsgBox("You lose " & CB1.Text, vbInformation, "")
            c = Val(lblMoneyLN.Text) - Val(CB1.Text)
            lblMoneyLN.Text = c
        ElseIf a = b Then
            PB4.Visible = True
            PB5.Visible = True
            MsgBox("Draw", vbInformation, "")
        End If
        btnGetcard.Enabled = True
        btnCarta.Enabled = False
        btnShow.Enabled = False
    End Sub
    Private Sub btnGetcard_Click(sender As Object, e As EventArgs) Handles btnGetcard.Click
        If CB1.Text = "" Then
            MsgBox("Please choose your bet!", vbInformation, "")
        ElseIf lblMoneyLN.Text = 0 Then
            MsgBox("Sorry you don't have sufficient money to play. Please close your game and reload again", vbInformation, "Insufficient funds")
            CB1.Enabled = False
            btnGetcard.Enabled = False
        ElseIf lblMoneyLN.Text < Val(CB1.Text) Then
            MsgBox("Insufficient money", vbInformation, "")
            btnGetcard.Enabled = False
            CB1.Enabled = False
        Else
            total = 0
            total1 = 0
            btnCarta.Enabled = True
            btnShow.Enabled = True
            btnGetcard.Enabled = False
            '''User
            rnd1 = rnd.Next(0, 4)
            rnd2 = rnd.Next(1, 11)
            PB1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd2 & ".png")
            PB1.Visible = True
            rnd1 = rnd.Next(0, 4)
            rnd3 = rnd.Next(1, 11)
            PB2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd3 & ".png")
            PB2.Visible = True
            PB3.Image = Nothing
            PB3.Visible = False
            '''computer
            rnd1 = rnd.Next(0, 4)
            rnd5 = rnd.Next(1, 11)
            PB4.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd5 & ".png")
            rnd1 = rnd.Next(0, 4)
            rnd6 = rnd.Next(1, 11)
            PB5.Image = Image.FromFile(Directory.GetCurrentDirectory & "\deck\" & rnd1 & "\" & rnd6 & ".png")
            PB6.Image = Nothing
            PB6.Visible = False
            PB4.Visible = False
            PB5.Visible = False

        End If
    End Sub
End Class