<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlotMachine
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
        components = New ComponentModel.Container()
        sheshh = New PictureBox()
        pb2 = New PictureBox()
        pb3 = New PictureBox()
        pb4 = New PictureBox()
        btnStart = New Button()
        lblMoneySM = New Label()
        lblLose = New Label()
        Panel1 = New Panel()
        lblJack = New Label()
        lblText = New Label()
        lblSlotmachine = New Label()
        lblJackpot = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        time1 = New Timer(components)
        time2 = New Timer(components)
        time3 = New Timer(components)
        CType(sheshh, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' sheshh
        ' 
        sheshh.BackColor = SystemColors.ActiveCaptionText
        sheshh.Location = New Point(261, 177)
        sheshh.Name = "sheshh"
        sheshh.Size = New Size(743, 271)
        sheshh.TabIndex = 0
        sheshh.TabStop = False
        ' 
        ' pb2
        ' 
        pb2.Location = New Point(298, 212)
        pb2.Name = "pb2"
        pb2.Size = New Size(197, 200)
        pb2.SizeMode = PictureBoxSizeMode.StretchImage
        pb2.TabIndex = 1
        pb2.TabStop = False
        ' 
        ' pb3
        ' 
        pb3.Location = New Point(534, 212)
        pb3.Name = "pb3"
        pb3.Size = New Size(197, 200)
        pb3.SizeMode = PictureBoxSizeMode.StretchImage
        pb3.TabIndex = 1
        pb3.TabStop = False
        ' 
        ' pb4
        ' 
        pb4.Location = New Point(764, 212)
        pb4.Name = "pb4"
        pb4.Size = New Size(197, 200)
        pb4.SizeMode = PictureBoxSizeMode.StretchImage
        pb4.TabIndex = 1
        pb4.TabStop = False
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnStart.Location = New Point(515, 587)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(185, 77)
        btnStart.TabIndex = 2
        btnStart.Text = "SPIN"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' lblMoneySM
        ' 
        lblMoneySM.AutoSize = True
        lblMoneySM.BackColor = Color.Transparent
        lblMoneySM.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblMoneySM.ForeColor = Color.Yellow
        lblMoneySM.Location = New Point(205, 30)
        lblMoneySM.Name = "lblMoneySM"
        lblMoneySM.Size = New Size(31, 32)
        lblMoneySM.TabIndex = 9
        lblMoneySM.Text = "0"
        ' 
        ' lblLose
        ' 
        lblLose.AutoSize = True
        lblLose.BackColor = Color.Transparent
        lblLose.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLose.ForeColor = Color.Yellow
        lblLose.Location = New Point(90, 26)
        lblLose.Name = "lblLose"
        lblLose.Size = New Size(296, 32)
        lblLose.TabIndex = 10
        lblLose.Text = "You Lose! Try Again!"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblSlotmachine)
        Panel1.Controls.Add(lblJack)
        Panel1.Controls.Add(lblText)
        Panel1.Controls.Add(lblLose)
        Panel1.Location = New Point(399, 454)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(456, 94)
        Panel1.TabIndex = 11
        ' 
        ' lblJack
        ' 
        lblJack.AutoSize = True
        lblJack.BackColor = Color.Transparent
        lblJack.Font = New Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        lblJack.ForeColor = Color.Yellow
        lblJack.Location = New Point(57, 21)
        lblJack.Name = "lblJack"
        lblJack.Size = New Size(379, 39)
        lblJack.TabIndex = 10
        lblJack.Text = "You got the Jackpot!!!"
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.BackColor = Color.Transparent
        lblText.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblText.ForeColor = Color.Yellow
        lblText.Location = New Point(57, 26)
        lblText.Name = "lblText"
        lblText.Size = New Size(368, 32)
        lblText.TabIndex = 10
        lblText.Text = "You got a pair! You win 50"
        ' 
        ' lblSlotmachine
        ' 
        lblSlotmachine.AutoSize = True
        lblSlotmachine.BackColor = Color.Transparent
        lblSlotmachine.Font = New Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblSlotmachine.ForeColor = Color.Yellow
        lblSlotmachine.Location = New Point(17, 0)
        lblSlotmachine.Name = "lblSlotmachine"
        lblSlotmachine.Size = New Size(419, 67)
        lblSlotmachine.TabIndex = 10
        lblSlotmachine.Text = "SLOT MACHINE"
        ' 
        ' lblJackpot
        ' 
        lblJackpot.AutoSize = True
        lblJackpot.BackColor = Color.Transparent
        lblJackpot.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblJackpot.ForeColor = Color.Yellow
        lblJackpot.Location = New Point(1143, 30)
        lblJackpot.Name = "lblJackpot"
        lblJackpot.Size = New Size(31, 32)
        lblJackpot.TabIndex = 12
        lblJackpot.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(1014, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 32)
        Label4.TabIndex = 10
        Label4.Text = "Jackpot:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(27, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 32)
        Label1.TabIndex = 14
        Label1.Text = "Your Money:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(-784, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 32)
        Label2.TabIndex = 13
        Label2.Text = "Your Money"
        ' 
        ' time1
        ' 
        ' 
        ' time2
        ' 
        ' 
        ' time3
        ' 
        ' 
        ' frmSlotMachine
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Untitled_design2
        ClientSize = New Size(1278, 722)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(lblJackpot)
        Controls.Add(Panel1)
        Controls.Add(lblMoneySM)
        Controls.Add(btnStart)
        Controls.Add(pb4)
        Controls.Add(pb3)
        Controls.Add(pb2)
        Controls.Add(sheshh)
        Name = "frmSlotMachine"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSlotMachine"
        CType(sheshh, ComponentModel.ISupportInitialize).EndInit()
        CType(pb2, ComponentModel.ISupportInitialize).EndInit()
        CType(pb3, ComponentModel.ISupportInitialize).EndInit()
        CType(pb4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents sheshh As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents pb4 As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblMoneySM As Label
    Friend WithEvents lblLose As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblJackpot As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents time1 As Timer
    Friend WithEvents time2 As Timer
    Friend WithEvents time3 As Timer
    Friend WithEvents lblSlotmachine As Label
    Friend WithEvents lblText As Label
    Friend WithEvents lblJack As Label
End Class
