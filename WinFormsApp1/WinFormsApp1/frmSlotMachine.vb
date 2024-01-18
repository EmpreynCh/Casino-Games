Imports System.IO

Public Class frmSlotMachine
    Dim rnd As New Random
    Dim time, irnd1, irnd2, irnd3, tots As Integer
    Private Sub frmSlotMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\CARDS\0.png")
        pb3.Image = Image.FromFile(Directory.GetCurrentDirectory & "\CARDS\0.png")
        pb4.Image = Image.FromFile(Directory.GetCurrentDirectory & "\CARDS\0.png")
    End Sub
    Private Sub time1_Tick(sender As Object, e As EventArgs) Handles time1.Tick
        irnd1 = rnd.Next(0, 6)
        pb2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\CARDS\" & irnd1 & ".png")
        time += 1
        If time >= 35 Then
            time1.Stop()
        End If
    End Sub

    Private Sub pb3_Click(sender As Object, e As EventArgs) Handles pb3.Click

    End Sub

    Private Sub time2_Tick(sender As Object, e As EventArgs) Handles time2.Tick
        irnd2 = rnd.Next(0, 6)
        pb3.Image = Image.FromFile(Directory.GetCurrentDirectory & "\CARDS\" & irnd2 & ".png")
        time += 1
        If time >= 45 Then
            time2.Stop()
        End If
    End Sub
    Private Sub time3_Tick(sender As Object, e As EventArgs) Handles time3.Tick
        irnd3 = rnd.Next(0, 6)
        pb4.Image = Image.FromFile(Directory.GetCurrentDirectory & "\CARDS\" & irnd3 & ".png")
        time += 1
        If time >= 55 Then
            time3.Stop()
            If irnd1 = irnd2 Or irnd1 = irnd3 Or irnd2 = irnd3 Then
                lblSlotmachine.Visible = False
                lblText.Visible = True
                tots = Val(lblMoneySM.Text) + 50
                lblMoneySM.Text = tots
            Else
                lblSlotmachine.Visible = False
                lblLose.Visible = True
                tots = Val(lblJackpot.Text) + 50
                lblJackpot.Text = tots
            End If
            If irnd1 = irnd2 And irnd1 = irnd3 And irnd2 = irnd3 Then
                MsgBox("JACKPOT")
                lblSlotmachine.Visible = False
                lblJack.Visible = True
                tots = Val(lblMoneySM.Text) + Val(lblJackpot.Text)
                lblMoneySM.Text = tots
                lblJackpot.Text = 0
            End If
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If lblMoneySM.Text = 0 Then
            MsgBox("Sorry you don't have sufficient money to play. Please close your game and reload again", vbInformation, "Insufficient funds")
        Else
            time1.Start()
            time2.Start()
            time3.Start()
            time = 0
        End If
        tots = Val(lblMoneySM.Text) - 25
        lblMoneySM.Text = tots
        lblText.Visible = False
        lblLose.Visible = False
        lblJack.Visible = False
        lblSlotmachine.Visible = True
    End Sub
    Private Sub frmSlotMachine_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMenu.Show()
        frmMenu.lblMoney.Text = Me.lblMoneySM.Text
    End Sub


End Class

