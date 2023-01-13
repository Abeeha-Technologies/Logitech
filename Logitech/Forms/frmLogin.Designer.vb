<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim BannerTextInfo1 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo()
        Dim BannerTextInfo2 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.lblLiscenceTypeTitle = New System.Windows.Forms.Label()
        Me.lblLiscenceTypeValue = New System.Windows.Forms.Label()
        Me.lblLiscencedToTitle = New System.Windows.Forms.Label()
        Me.lblLiscencedToValue = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLoginImage = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlUserName = New System.Windows.Forms.Panel()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlUserPassword = New System.Windows.Forms.Panel()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.picLoginHeader = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.BannerTextProvider = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picLoginImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserName.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserPassword.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picLoginHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnActivate)
        Me.Panel1.Controls.Add(Me.lblLiscenceTypeTitle)
        Me.Panel1.Controls.Add(Me.lblLiscenceTypeValue)
        Me.Panel1.Controls.Add(Me.lblLiscencedToTitle)
        Me.Panel1.Controls.Add(Me.lblLiscencedToValue)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.lblSlogan)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.picLoginImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 530)
        Me.Panel1.TabIndex = 0
        '
        'btnActivate
        '
        Me.btnActivate.BackColor = System.Drawing.Color.Red
        Me.btnActivate.FlatAppearance.BorderSize = 0
        Me.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivate.ForeColor = System.Drawing.Color.Black
        Me.btnActivate.Location = New System.Drawing.Point(142, 483)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(148, 35)
        Me.btnActivate.TabIndex = 28
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = False
        '
        'lblLiscenceTypeTitle
        '
        Me.lblLiscenceTypeTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiscenceTypeTitle.ForeColor = System.Drawing.Color.White
        Me.lblLiscenceTypeTitle.Location = New System.Drawing.Point(10, 377)
        Me.lblLiscenceTypeTitle.Name = "lblLiscenceTypeTitle"
        Me.lblLiscenceTypeTitle.Size = New System.Drawing.Size(280, 23)
        Me.lblLiscenceTypeTitle.TabIndex = 21
        Me.lblLiscenceTypeTitle.Text = "Liscence Type"
        Me.lblLiscenceTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLiscenceTypeValue
        '
        Me.lblLiscenceTypeValue.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiscenceTypeValue.ForeColor = System.Drawing.Color.White
        Me.lblLiscenceTypeValue.Location = New System.Drawing.Point(10, 405)
        Me.lblLiscenceTypeValue.Name = "lblLiscenceTypeValue"
        Me.lblLiscenceTypeValue.Size = New System.Drawing.Size(280, 23)
        Me.lblLiscenceTypeValue.TabIndex = 20
        Me.lblLiscenceTypeValue.Text = "Lifetime"
        Me.lblLiscenceTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLiscencedToTitle
        '
        Me.lblLiscencedToTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiscencedToTitle.ForeColor = System.Drawing.Color.White
        Me.lblLiscencedToTitle.Location = New System.Drawing.Point(10, 273)
        Me.lblLiscencedToTitle.Name = "lblLiscencedToTitle"
        Me.lblLiscencedToTitle.Size = New System.Drawing.Size(280, 23)
        Me.lblLiscencedToTitle.TabIndex = 19
        Me.lblLiscencedToTitle.Text = "Liscenced To"
        Me.lblLiscencedToTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLiscencedToValue
        '
        Me.lblLiscencedToValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLiscencedToValue.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiscencedToValue.ForeColor = System.Drawing.Color.White
        Me.lblLiscencedToValue.Location = New System.Drawing.Point(10, 300)
        Me.lblLiscencedToValue.Name = "lblLiscencedToValue"
        Me.lblLiscencedToValue.Size = New System.Drawing.Size(280, 76)
        Me.lblLiscencedToValue.TabIndex = 18
        Me.lblLiscencedToValue.Text = "Advance ERP"
        Me.lblLiscencedToValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.White
        Me.lblVersion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(13, 502)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 16)
        Me.lblVersion.TabIndex = 17
        Me.lblVersion.Text = "Version 2022"
        '
        'lblSlogan
        '
        Me.lblSlogan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.ForeColor = System.Drawing.Color.White
        Me.lblSlogan.Location = New System.Drawing.Point(10, 194)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(280, 23)
        Me.lblSlogan.TabIndex = 16
        Me.lblSlogan.Text = "One Point Solution"
        Me.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(10, 156)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 39)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Advance ERP"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLoginImage
        '
        Me.picLoginImage.Image = CType(resources.GetObject("picLoginImage.Image"), System.Drawing.Image)
        Me.picLoginImage.Location = New System.Drawing.Point(95, 21)
        Me.picLoginImage.Name = "picLoginImage"
        Me.picLoginImage.Size = New System.Drawing.Size(120, 120)
        Me.picLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoginImage.TabIndex = 12
        Me.picLoginImage.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(15, 135)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(236, 24)
        Me.lblHeader.TabIndex = 15
        Me.lblHeader.Text = "Login to your account"
        '
        'pnlUserName
        '
        Me.pnlUserName.BackColor = System.Drawing.Color.White
        Me.pnlUserName.Controls.Add(Me.txtUserName)
        Me.pnlUserName.Controls.Add(Me.PictureBox1)
        Me.pnlUserName.Location = New System.Drawing.Point(0, 185)
        Me.pnlUserName.Name = "pnlUserName"
        Me.pnlUserName.Size = New System.Drawing.Size(450, 45)
        Me.pnlUserName.TabIndex = 16
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        BannerTextInfo1.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        BannerTextInfo1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        BannerTextInfo1.Text = "Username"
        BannerTextInfo1.Visible = True
        Me.BannerTextProvider.SetBannerText(Me.txtUserName, BannerTextInfo1)
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.txtUserName.Location = New System.Drawing.Point(45, 12)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(393, 20)
        Me.txtUserName.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Logitech.My.Resources.Resources.Login_User_24px
        Me.PictureBox1.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'pnlUserPassword
        '
        Me.pnlUserPassword.BackColor = System.Drawing.SystemColors.Control
        Me.pnlUserPassword.Controls.Add(Me.txtUserPassword)
        Me.pnlUserPassword.Controls.Add(Me.PictureBox3)
        Me.pnlUserPassword.Location = New System.Drawing.Point(0, 236)
        Me.pnlUserPassword.Name = "pnlUserPassword"
        Me.pnlUserPassword.Size = New System.Drawing.Size(450, 45)
        Me.pnlUserPassword.TabIndex = 17
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.SystemColors.Control
        BannerTextInfo2.Color = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        BannerTextInfo2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        BannerTextInfo2.Text = "Password"
        BannerTextInfo2.Visible = True
        Me.BannerTextProvider.SetBannerText(Me.txtUserPassword, BannerTextInfo2)
        Me.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtUserPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.txtUserPassword.Location = New System.Drawing.Point(45, 12)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(393, 20)
        Me.txtUserPassword.TabIndex = 28
        Me.txtUserPassword.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Logitech.My.Resources.Resources.Login_Password_24px
        Me.PictureBox3.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(15, 341)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(148, 35)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(270, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Abeeha Technologies"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(178, 341)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(148, 35)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.chkShowPassword)
        Me.Panel2.Controls.Add(Me.lblNote)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.picLoginHeader)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.pnlUserPassword)
        Me.Panel2.Controls.Add(Me.picLogo)
        Me.Panel2.Controls.Add(Me.pnlUserName)
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Location = New System.Drawing.Point(300, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 506)
        Me.Panel2.TabIndex = 1
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.chkShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.DimGray
        Me.chkShowPassword.Location = New System.Drawing.Point(45, 288)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(124, 21)
        Me.chkShowPassword.TabIndex = 27
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.Black
        Me.lblNote.Location = New System.Drawing.Point(16, 314)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(0, 17)
        Me.lblNote.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(264, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Software By"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picLoginHeader
        '
        Me.picLoginHeader.Image = Global.Logitech.My.Resources.Resources.Login_Bismillah
        Me.picLoginHeader.Location = New System.Drawing.Point(15, 12)
        Me.picLoginHeader.Name = "picLoginHeader"
        Me.picLoginHeader.Size = New System.Drawing.Size(422, 94)
        Me.picLoginHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoginHeader.TabIndex = 22
        Me.picLoginHeader.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(367, 431)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 45)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLoginImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserName.ResumeLayout(False)
        Me.pnlUserName.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserPassword.ResumeLayout(False)
        Me.pnlUserPassword.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picLoginHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSlogan As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLoginImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlUserName As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlUserPassword As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblLiscenceTypeTitle As System.Windows.Forms.Label
    Friend WithEvents lblLiscenceTypeValue As System.Windows.Forms.Label
    Friend WithEvents lblLiscencedToTitle As System.Windows.Forms.Label
    Friend WithEvents lblLiscencedToValue As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents picLoginHeader As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents BannerTextProvider As Syncfusion.Windows.Forms.BannerTextProvider
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox

End Class
