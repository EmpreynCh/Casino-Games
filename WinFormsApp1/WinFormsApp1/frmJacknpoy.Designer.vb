<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJacknpoy
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
        PB2 = New PictureBox()
        PB3 = New PictureBox()
        btnStart = New Button()
        btnRock = New Button()
        btnPaper = New Button()
        btnScissor = New Button()
        GroupBox1 = New GroupBox()
        CB2 = New ComboBox()
        lblMoneyJP = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label4 = New Label()
        CType(PB2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PB3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PB2
        ' 
        PB2.BackColor = Color.Transparent
        PB2.Location = New Point(85, 166)
        PB2.Name = "PB2"
        PB2.Size = New Size(300, 271)
        PB2.SizeMode = PictureBoxSizeMode.StretchImage
        PB2.TabIndex = 0
        PB2.TabStop = False
        ' 
        ' PB3
        ' 
        PB3.BackColor = Color.Transparent
        PB3.Location = New Point(841, 166)
        PB3.Name = "PB3"
        PB3.Size = New Size(303, 282)
        PB3.SizeMode = PictureBoxSizeMode.StretchImage
        PB3.TabIndex = 0
        PB3.TabStop = False
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnStart.Location = New Point(521, 491)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(191, 66)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRock
        ' 
        btnRock.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnRock.Location = New Point(20, 36)
        btnRock.Name = "btnRock"
        btnRock.Size = New Size(191, 66)
        btnRock.TabIndex = 1
        btnRock.Text = "Rock"
        btnRock.UseVisualStyleBackColor = True
        ' 
        ' btnPaper
        ' 
        btnPaper.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnPaper.Location = New Point(347, 36)
        btnPaper.Name = "btnPaper"
        btnPaper.Size = New Size(191, 66)
        btnPaper.TabIndex = 1
        btnPaper.Text = "Paper"
        btnPaper.UseVisualStyleBackColor = True
        ' 
        ' btnScissor
        ' 
        btnScissor.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnScissor.Location = New Point(667, 36)
        btnScissor.Name = "btnScissor"
        btnScissor.Size = New Size(191, 66)
        btnScissor.TabIndex = 1
        btnScissor.Text = "Scissor"
        btnScissor.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(btnPaper)
        GroupBox1.Controls.Add(btnScissor)
        GroupBox1.Controls.Add(btnRock)
        GroupBox1.Location = New Point(174, 563)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(888, 125)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "."
        ' 
        ' CB2
        ' 
        CB2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        CB2.FormattingEnabled = True
        CB2.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900", "1000"})
        CB2.Location = New Point(862, 84)
        CB2.Name = "CB2"
        CB2.Size = New Size(248, 45)
        CB2.TabIndex = 3
        ' 
        ' lblMoneyJP
        ' 
        lblMoneyJP.AutoSize = True
        lblMoneyJP.BackColor = Color.Transparent
        lblMoneyJP.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblMoneyJP.ForeColor = Color.Yellow
        lblMoneyJP.Location = New Point(204, 30)
        lblMoneyJP.Name = "lblMoneyJP"
        lblMoneyJP.Size = New Size(31, 32)
        lblMoneyJP.TabIndex = 8
        lblMoneyJP.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(28, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 32)
        Label1.TabIndex = 9
        Label1.Text = "Your Money:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(841, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(279, 32)
        Label4.TabIndex = 9
        Label4.Text = "Enter your bet here"
        ' 
        ' frmJacknpoy
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Untitled_design
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1241, 700)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(lblMoneyJP)
        Controls.Add(CB2)
        Controls.Add(GroupBox1)
        Controls.Add(btnStart)
        Controls.Add(PB3)
        Controls.Add(PB2)
        DoubleBuffered = True
        Name = "frmJacknpoy"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PB2, ComponentModel.ISupportInitialize).EndInit()
        CType(PB3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRock As Button
    Friend WithEvents btnPaper As Button
    Friend WithEvents btnScissor As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB2 As ComboBox
    Friend WithEvents lblMoneyJP As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
