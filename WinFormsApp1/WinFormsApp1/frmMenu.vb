

Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbTossCoin.Checked = True Then
            Me.Hide()
            frmTossCoin.Show()
        ElseIf rbJacknpoy.Checked = True Then
            Me.Hide()
            frmJacknpoy.Show()
        ElseIf rbSlotMachine.Checked = True Then
            Me.Hide()
            frmSlotMachine.Show()
        ElseIf rbLuckNine.Checked = True Then
            Me.Hide()
            frmLucky9.Show()
        End If
        frmTossCoin.lblMoneyTC.Text = Me.lblMoney.Text
        frmJacknpoy.lblMoneyJP.Text = Me.lblMoney.Text
        frmSlotMachine.lblMoneySM.Text = Me.lblMoney.Text
        frmLucky9.lblMoneyLN.Text = Me.lblMoney.Text
    End Sub
    Private Sub frmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Form1.Show()
        Form1.txtMoney.Enabled = False
        Form1.txtMoney.Text = Me.lblMoney.Text
    End Sub
End Class
