Imports System.IO
Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            Dim a As Integer = txtMoney.Text
            If a < 1000 Then
                MsgBox("Your money must 1000 or higher")
                txtMoney.Clear()
            Else
                Me.Hide()
                frmMenu.Show()
            End If
        Catch ex As Exception
            MsgBox("Invalid Input", vbCritical, "Error")
            txtMoney.Clear()
        End Try
        frmMenu.lblMoney.Text = Me.txtMoney.Text
    End Sub


End Class
