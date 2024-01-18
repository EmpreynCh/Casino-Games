<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMenu))
        rbLuckNine = New RadioButton()
        Button1 = New Button()
        rbTossCoin = New RadioButton()
        rbSlotMachine = New RadioButton()
        rbJacknpoy = New RadioButton()
        Label1 = New Label()
        lblMoney = New Label()
        lblMoney2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rbLuckNine
        ' 
        rbLuckNine.AutoSize = True
        rbLuckNine.BackColor = Color.Transparent
        rbLuckNine.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        rbLuckNine.ForeColor = Color.White
        rbLuckNine.Location = New Point(328, 359)
        rbLuckNine.Name = "rbLuckNine"
        rbLuckNine.Size = New Size(141, 36)
        rbLuckNine.TabIndex = 0
        rbLuckNine.TabStop = True
        rbLuckNine.Text = "Lucky 9"
        rbLuckNine.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(307, 478)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 75)
        Button1.TabIndex = 4
        Button1.Text = "Play"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' rbTossCoin
        ' 
        rbTossCoin.AutoSize = True
        rbTossCoin.BackColor = Color.Transparent
        rbTossCoin.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        rbTossCoin.ForeColor = Color.White
        rbTossCoin.Location = New Point(328, 302)
        rbTossCoin.Name = "rbTossCoin"
        rbTossCoin.Size = New Size(170, 36)
        rbTossCoin.TabIndex = 0
        rbTossCoin.TabStop = True
        rbTossCoin.Text = "Toss Coin"
        rbTossCoin.UseVisualStyleBackColor = False
        ' 
        ' rbSlotMachine
        ' 
        rbSlotMachine.AutoSize = True
        rbSlotMachine.BackColor = Color.Transparent
        rbSlotMachine.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        rbSlotMachine.ForeColor = Color.White
        rbSlotMachine.Location = New Point(328, 237)
        rbSlotMachine.Name = "rbSlotMachine"
        rbSlotMachine.Size = New Size(212, 36)
        rbSlotMachine.TabIndex = 0
        rbSlotMachine.TabStop = True
        rbSlotMachine.Text = "Slot Machine"
        rbSlotMachine.UseVisualStyleBackColor = False
        ' 
        ' rbJacknpoy
        ' 
        rbJacknpoy.AutoSize = True
        rbJacknpoy.BackColor = Color.Transparent
        rbJacknpoy.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        rbJacknpoy.ForeColor = Color.White
        rbJacknpoy.Location = New Point(328, 169)
        rbJacknpoy.Name = "rbJacknpoy"
        rbJacknpoy.Size = New Size(202, 36)
        rbJacknpoy.TabIndex = 0
        rbJacknpoy.TabStop = True
        rbJacknpoy.Text = "Jack En Poy"
        rbJacknpoy.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(253, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 60)
        Label1.TabIndex = 5
        Label1.Text = "CASINO GAMES"
        ' 
        ' lblMoney
        ' 
        lblMoney.AutoSize = True
        lblMoney.BackColor = Color.Transparent
        lblMoney.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblMoney.ForeColor = Color.Yellow
        lblMoney.Location = New Point(152, 565)
        lblMoney.Name = "lblMoney"
        lblMoney.Size = New Size(31, 32)
        lblMoney.TabIndex = 12
        lblMoney.Text = "0"
        ' 
        ' lblMoney2
        ' 
        lblMoney2.AutoSize = True
        lblMoney2.BackColor = Color.Transparent
        lblMoney2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblMoney2.ForeColor = Color.Yellow
        lblMoney2.Location = New Point(44, 565)
        lblMoney2.Name = "lblMoney2"
        lblMoney2.Size = New Size(112, 32)
        lblMoney2.TabIndex = 13
        lblMoney2.Text = "Money:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.maxresdefault_removebg_preview
        PictureBox1.Location = New Point(29, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(188, 131)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.slotmachinelogo_removebg_preview
        PictureBox2.Location = New Point(631, 88)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(188, 117)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources._215493183_102337315463387_4758247658345453117_n_removebg_preview1
        PictureBox3.Location = New Point(44, 266)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(154, 154)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(631, 255)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(188, 117)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.c6687968897221_Y3JvcCwxMjkzLDEwMTIsMjUzLDA
        ClientSize = New Size(863, 633)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(lblMoney2)
        Controls.Add(lblMoney)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(rbJacknpoy)
        Controls.Add(rbSlotMachine)
        Controls.Add(rbTossCoin)
        Controls.Add(rbLuckNine)
        Name = "frmMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmGame"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbLuckNine As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents rbTossCoin As RadioButton
    Friend WithEvents rbSlotMachine As RadioButton
    Friend WithEvents rbJacknpoy As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblMoney2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
