Imports System.IO

Public Class frmJacknpoy
    Dim rnd As New Random
    Dim time, p1 As Integer
    Dim rock As Integer = 2
    Dim scissors As Integer = 1
    Dim paper As Integer = 3
    Private Sub frmJacknpoy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMenu.Show()
        frmMenu.lblMoney.Text = Me.lblMoneyJP.Text
    End Sub
    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        PB2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\hand\2.png")
        CB2.Enabled = True
        p1 = 2
    End Sub
    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        PB2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\hand\3.png")
        CB2.Enabled = True
        p1 = 3
    End Sub
    Private Sub btnScissor_Click(sender As Object, e As EventArgs) Handles btnScissor.Click
        PB2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\hand\1.png")
        CB2.Enabled = True
        p1 = 1
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If PB2.Image Is Nothing Then
                MsgBox("Please choose your hand", vbInformation, "")
            ElseIf CB2.Text = "" Then
                MsgBox("Please choose your bet", vbInformation, "")
            ElseIf lblMoneyJP.Text = 0 Then
                MsgBox("Sorry you don't have sufficient money to play. Please close your game and reload again", vbInformation, "Insufficient funds")
                GroupBox1.Enabled = False
                CB2.Enabled = False
                PB2.Image = Nothing
                btnStart.Enabled = False
            ElseIf lblMoneyJP.Text < Val(CB2.Text) Then
                MsgBox("Insufficient money", vbInformation, "")
                PB2.Image = Nothing
            Else
                Timer1.Start()
                time = 0
                CB2.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim irnd, total As Integer
            irnd = rnd.Next(1, 4)
            PB3.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Hands\" & irnd & ".png")
            time += 1
            If time >= 15 Then
                Timer1.Stop()
                If btnRock.Enabled = True Then
                    If (p1 = scissors And irnd = rock) Or (p1 = paper And irnd = scissors) Or (p1 = rock And irnd = paper) Then
                        MsgBox("You won " & CB2.Text, vbInformation, "")
                        PB2.Image = Nothing
                        PB3.Image = Nothing
                        total = Val(lblMoneyJP.Text) + Val(CB2.Text)
                        lblMoneyJP.Text = total
                    ElseIf (p1 = scissors And irnd = paper) Or (p1 = rock And irnd = scissors) Or (p1 = paper And irnd = rock) Then
                        MsgBox("draw", vbInformation, "")
                        PB2.Image = Nothing
                        PB3.Image = Nothing
                    ElseIf (p1 = scissors And irnd = scissors) Or (p1 = rock And irnd = rock) Or (p1 = paper And irnd = paper) Then
                        MsgBox("You lost " & CB2.Text, vbInformation, "")
                        PB2.Image = Nothing
                        PB3.Image = Nothing
                        total = Val(lblMoneyJP.Text) - Val(CB2.Text)
                        lblMoneyJP.Text = total
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pb2_Click(sender As Object, e As EventArgs) Handles PB2.Click

    End Sub
End Class