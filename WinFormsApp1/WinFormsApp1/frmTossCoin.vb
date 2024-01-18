Imports System.IO

Public Class frmTossCoin
    Dim rnd As New Random
    Dim time As Integer
    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        If cb1.SelectedIndex = 0 Then
            pb1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Coin\0.png")
        ElseIf cb1.SelectedIndex = 1 Then
            pb1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Coin\1.png")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim irnd, total As Integer
            irnd = rnd.Next(0, 2)
            pb2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Coin\" & irnd & ".png")
            time += 1
            If time >= 15 Then
                Timer1.Stop()
                If cb1.SelectedIndex = irnd Then
                    MsgBox("You won " & cb2.Text, vbInformation, "")
                    total = Val(lblMoneyTC.Text) + Val(cb2.Text)
                    lblMoneyTC.Text = total
                    cb1.Enabled = True
                    cb2.Enabled = True
                ElseIf cb1.SelectedIndex <> irnd Then
                    MsgBox("You lost " & cb2.Text, vbInformation, "")
                    total = Val(lblMoneyTC.Text) - Val(cb2.Text)
                    lblMoneyTC.Text = total
                    cb1.Enabled = True
                    cb2.Enabled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Try
            If cb1.Text = "" Then
                MsgBox("Please choose your coin")
            ElseIf cb2.Text = "" Then
                MsgBox("Please choose your bet")
            ElseIf lblMoneyTC.Text = 0 Then
                MsgBox("Sorry you don't have sufficient money to play. Please close your game and reload again", vbInformation, "Insufficient funds")
                btnToss.Enabled = False
                cb1.Enabled = False
                cb2.Enabled = False
            ElseIf lblMoneyTC.Text < Val(cb2.Text) Then
                MsgBox("Insufficient money")
                cb1.Enabled = False
                cb2.Enabled = False
            Else
                Timer1.Start()
                time = 0
                cb1.Enabled = False
                cb2.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmTossCoin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMenu.Show()
        frmMenu.lblMoney.Text = Me.lblMoneyTC.Text
    End Sub
End Class