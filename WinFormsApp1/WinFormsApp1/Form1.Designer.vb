<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        txtMoney = New TextBox()
        btnEnter = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Algerian", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(237, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(334, 38)
        Label2.TabIndex = 1
        Label2.Text = "Enter Your Money"
        ' 
        ' txtMoney
        ' 
        txtMoney.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        txtMoney.ForeColor = SystemColors.WindowText
        txtMoney.Location = New Point(244, 229)
        txtMoney.Margin = New Padding(3, 4, 3, 4)
        txtMoney.Name = "txtMoney"
        txtMoney.Size = New Size(327, 61)
        txtMoney.TabIndex = 2
        txtMoney.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.Black
        btnEnter.Font = New Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        btnEnter.ForeColor = Color.White
        btnEnter.Location = New Point(292, 372)
        btnEnter.Margin = New Padding(3, 4, 3, 4)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(211, 75)
        btnEnter.TabIndex = 3
        btnEnter.Text = "START"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.c6687968897221_Y3JvcCwxMjkzLDEwMTIsMjUzLDA
        ClientSize = New Size(800, 632)
        Controls.Add(btnEnter)
        Controls.Add(txtMoney)
        Controls.Add(Label2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbJackPoy As RadioButton
    Friend WithEvents rbSlotMachine As RadioButton
    Friend WithEvents rbCoinToss As RadioButton
    Friend WithEvents rbLucky9 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents btnEnter As Button
End Class
