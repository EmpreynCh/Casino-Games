<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTossCoin
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
        lblMoneyTC = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cb2 = New ComboBox()
        cb1 = New ComboBox()
        pb3 = New PictureBox()
        pb2 = New PictureBox()
        btnToss = New Button()
        pb1 = New PictureBox()
        Timer1 = New Timer(components)
        CType(pb3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMoneyTC
        ' 
        lblMoneyTC.AutoSize = True
        lblMoneyTC.BackColor = Color.Transparent
        lblMoneyTC.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblMoneyTC.ForeColor = Color.Yellow
        lblMoneyTC.Location = New Point(170, 20)
        lblMoneyTC.Name = "lblMoneyTC"
        lblMoneyTC.Size = New Size(26, 27)
        lblMoneyTC.TabIndex = 8
        lblMoneyTC.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(23, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 27)
        Label5.TabIndex = 9
        Label5.Text = "Your Money:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(825, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 27)
        Label3.TabIndex = 9
        Label3.Text = "Choose your bet"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(23, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(229, 27)
        Label4.TabIndex = 9
        Label4.Text = "Enter your bet here"
        ' 
        ' cb2
        ' 
        cb2.BackColor = SystemColors.Window
        cb2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cb2.FormattingEnabled = True
        cb2.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900", "1000"})
        cb2.Location = New Point(23, 105)
        cb2.Name = "cb2"
        cb2.Size = New Size(229, 36)
        cb2.TabIndex = 10
        ' 
        ' cb1
        ' 
        cb1.BackColor = SystemColors.Window
        cb1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cb1.FormattingEnabled = True
        cb1.Items.AddRange(New Object() {"Head", "Tail"})
        cb1.Location = New Point(812, 105)
        cb1.Name = "cb1"
        cb1.Size = New Size(229, 36)
        cb1.TabIndex = 10
        ' 
        ' pb3
        ' 
        pb3.BackColor = Color.Transparent
        pb3.Image = My.Resources.Resources._215493183_102337315463387_4758247658345453117_n_removebg_preview
        pb3.Location = New Point(479, 20)
        pb3.Name = "pb3"
        pb3.Size = New Size(144, 129)
        pb3.SizeMode = PictureBoxSizeMode.StretchImage
        pb3.TabIndex = 11
        pb3.TabStop = False
        ' 
        ' pb2
        ' 
        pb2.BackColor = Color.Transparent
        pb2.Location = New Point(710, 253)
        pb2.Name = "pb2"
        pb2.Size = New Size(236, 221)
        pb2.SizeMode = PictureBoxSizeMode.StretchImage
        pb2.TabIndex = 11
        pb2.TabStop = False
        ' 
        ' btnToss
        ' 
        btnToss.BackColor = Color.White
        btnToss.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnToss.ForeColor = SystemColors.ActiveCaptionText
        btnToss.Location = New Point(423, 554)
        btnToss.Name = "btnToss"
        btnToss.Size = New Size(222, 75)
        btnToss.TabIndex = 12
        btnToss.Text = "Start"
        btnToss.UseVisualStyleBackColor = False
        ' 
        ' pb1
        ' 
        pb1.BackColor = Color.Transparent
        pb1.Location = New Point(141, 253)
        pb1.Name = "pb1"
        pb1.Size = New Size(236, 221)
        pb1.SizeMode = PictureBoxSizeMode.StretchImage
        pb1.TabIndex = 11
        pb1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' frmTossCoin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.tosscoinbackground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1100, 680)
        Controls.Add(btnToss)
        Controls.Add(pb2)
        Controls.Add(pb1)
        Controls.Add(pb3)
        Controls.Add(cb1)
        Controls.Add(cb2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(lblMoneyTC)
        ForeColor = SystemColors.ControlLightLight
        Name = "frmTossCoin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmTossCoin"
        CType(pb3, ComponentModel.ISupportInitialize).EndInit()
        CType(pb2, ComponentModel.ISupportInitialize).EndInit()
        CType(pb1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMoneyTC As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb2 As ComboBox
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents btnToss As Button
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
