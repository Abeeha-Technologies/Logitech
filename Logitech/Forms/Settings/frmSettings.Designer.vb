<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form
    Public Sub New(ByVal initialValue1 As String, ByVal InitialValue2 As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ValueFromParent1 = initialValue1
        ValueFromParent2 = InitialValue2

    End Sub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MozPane1 = New Pabo.MozBar.MozPane()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MozItemCompany = New Pabo.MozBar.MozItem()
        Me.MozItemUsers = New Pabo.MozBar.MozItem()
        Me.MozItemReferences = New Pabo.MozBar.MozItem()
        Me.MozItemBackupRestore = New Pabo.MozBar.MozItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNTN = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLandline = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkRequireUserPasswordToDelete = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pnlAccountSearch = New System.Windows.Forms.Panel()
        Me.lblAddNewAccount = New System.Windows.Forms.LinkLabel()
        Me.dgvAccountSearch = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAccCodeDefaultCarriageCreditAccount = New System.Windows.Forms.TextBox()
        Me.txtAccNameDefaultCashAccount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAccCodeDefaultCashAccount = New System.Windows.Forms.TextBox()
        Me.txtAccNameDefaultCarriageCreditAccount = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAccCodeDefaultCarriageDebitAccount = New System.Windows.Forms.TextBox()
        Me.txtAccNameDefaultSaleAccount = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtAccNameDefaultCarriageDebitAccount = New System.Windows.Forms.TextBox()
        Me.txtAccCodeDefaultSaleAccount = New System.Windows.Forms.TextBox()
        Me.txtAccCodeDefaultTransportationDiscountAccount = New System.Windows.Forms.TextBox()
        Me.txtAccNameDefaultProductSaleAccount = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAccNameDefaultTransportationDiscountAccount = New System.Windows.Forms.TextBox()
        Me.txtAccCodeDefaultProductSaleAccount = New System.Windows.Forms.TextBox()
        Me.txtAccCodeDefaultSaleDiscountAccount = New System.Windows.Forms.TextBox()
        Me.txtAccNameDefaultProductCOGSAccount = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtAccNameDefaultSaleDiscountAccount = New System.Windows.Forms.TextBox()
        Me.txtAccCodeDefaultProductCOGSAccount = New System.Windows.Forms.TextBox()
        Me.pnlCompany = New System.Windows.Forms.Panel()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlReference = New System.Windows.Forms.Panel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btnZone = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.btnRacks = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnPacking = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.btnRemoveUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlBackupRestore = New System.Windows.Forms.Panel()
        Me.lblNoteProgress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.chkAutoBackupOnClose = New System.Windows.Forms.CheckBox()
        Me.txtAutoBackupDays = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnBackupDirectory = New System.Windows.Forms.Button()
        Me.txtAutoBackupDirectory = New System.Windows.Forms.TextBox()
        Me.btnBackupPath = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtParentValue2 = New System.Windows.Forms.TextBox()
        Me.txtParentValue1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MozPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MozPane1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlAccountSearch.SuspendLayout()
        CType(Me.dgvAccountSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlCompany.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        Me.pnlReference.SuspendLayout()
        Me.pnlUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackupRestore.SuspendLayout()
        Me.SuspendLayout()
        '
        'MozPane1
        '
        Me.MozPane1.BackColor = System.Drawing.Color.Silver
        Me.MozPane1.BorderColor = System.Drawing.Color.Silver
        Me.MozPane1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None
        Me.MozPane1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MozPane1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MozPane1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MozPane1.ImageList = Me.ImageList1
        Me.MozPane1.ItemBorderStyles.Focus = System.Windows.Forms.ButtonBorderStyle.None
        Me.MozPane1.ItemBorderStyles.Selected = System.Windows.Forms.ButtonBorderStyle.None
        Me.MozPane1.ItemColors.Background = System.Drawing.Color.Silver
        Me.MozPane1.ItemColors.Border = System.Drawing.Color.Silver
        Me.MozPane1.ItemColors.Divider = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.MozPane1.ItemColors.FocusBackground = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.MozPane1.ItemColors.FocusBorder = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.MozPane1.ItemColors.SelectedBackground = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.MozPane1.ItemColors.SelectedBorder = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MozPane1.ItemColors.Text = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MozPane1.Items.AddRange(New Pabo.MozBar.MozItem() {Me.MozItemCompany, Me.MozItemUsers, Me.MozItemReferences, Me.MozItemBackupRestore})
        Me.MozPane1.Location = New System.Drawing.Point(0, 0)
        Me.MozPane1.Name = "MozPane1"
        Me.MozPane1.SelectButton = Pabo.MozBar.MozSelectButton.Any
        Me.MozPane1.Size = New System.Drawing.Size(150, 470)
        Me.MozPane1.TabIndex = 0
        Me.MozPane1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Settings_Company_32px.png")
        Me.ImageList1.Images.SetKeyName(1, "Settings_User_32px.png")
        Me.ImageList1.Images.SetKeyName(2, "Settings_Reference_32px.png")
        Me.ImageList1.Images.SetKeyName(3, "Settings_Backup_32px.png")
        '
        'MozItemCompany
        '
        Me.MozItemCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MozItemCompany.Images.Focus = 0
        Me.MozItemCompany.Images.FocusImage = CType(resources.GetObject("resource.FocusImage"), System.Drawing.Image)
        Me.MozItemCompany.Images.Normal = 0
        Me.MozItemCompany.Images.NormalImage = CType(resources.GetObject("resource.NormalImage"), System.Drawing.Image)
        Me.MozItemCompany.Images.Selected = 0
        Me.MozItemCompany.Images.SelectedImage = CType(resources.GetObject("resource.SelectedImage"), System.Drawing.Image)
        Me.MozItemCompany.Location = New System.Drawing.Point(2, 2)
        Me.MozItemCompany.Name = "MozItemCompany"
        Me.MozItemCompany.Size = New System.Drawing.Size(146, 63)
        Me.MozItemCompany.TabIndex = 0
        Me.MozItemCompany.Text = "Company"
        '
        'MozItemUsers
        '
        Me.MozItemUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MozItemUsers.Images.Focus = 1
        Me.MozItemUsers.Images.FocusImage = CType(resources.GetObject("resource.FocusImage1"), System.Drawing.Image)
        Me.MozItemUsers.Images.Normal = 1
        Me.MozItemUsers.Images.NormalImage = CType(resources.GetObject("resource.NormalImage1"), System.Drawing.Image)
        Me.MozItemUsers.Images.Selected = 1
        Me.MozItemUsers.Images.SelectedImage = CType(resources.GetObject("resource.SelectedImage1"), System.Drawing.Image)
        Me.MozItemUsers.Location = New System.Drawing.Point(2, 67)
        Me.MozItemUsers.Name = "MozItemUsers"
        Me.MozItemUsers.Size = New System.Drawing.Size(146, 63)
        Me.MozItemUsers.TabIndex = 1
        Me.MozItemUsers.Text = "Users"
        '
        'MozItemReferences
        '
        Me.MozItemReferences.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MozItemReferences.Images.Focus = 2
        Me.MozItemReferences.Images.FocusImage = CType(resources.GetObject("resource.FocusImage2"), System.Drawing.Image)
        Me.MozItemReferences.Images.Normal = 2
        Me.MozItemReferences.Images.NormalImage = CType(resources.GetObject("resource.NormalImage2"), System.Drawing.Image)
        Me.MozItemReferences.Images.Selected = 2
        Me.MozItemReferences.Images.SelectedImage = CType(resources.GetObject("resource.SelectedImage2"), System.Drawing.Image)
        Me.MozItemReferences.Location = New System.Drawing.Point(2, 132)
        Me.MozItemReferences.Name = "MozItemReferences"
        Me.MozItemReferences.Size = New System.Drawing.Size(146, 63)
        Me.MozItemReferences.TabIndex = 4
        Me.MozItemReferences.Text = "References"
        Me.MozItemReferences.Visible = False
        '
        'MozItemBackupRestore
        '
        Me.MozItemBackupRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MozItemBackupRestore.Images.Focus = 3
        Me.MozItemBackupRestore.Images.FocusImage = CType(resources.GetObject("resource.FocusImage3"), System.Drawing.Image)
        Me.MozItemBackupRestore.Images.Normal = 3
        Me.MozItemBackupRestore.Images.NormalImage = CType(resources.GetObject("resource.NormalImage3"), System.Drawing.Image)
        Me.MozItemBackupRestore.Images.Selected = 3
        Me.MozItemBackupRestore.Images.SelectedImage = CType(resources.GetObject("resource.SelectedImage3"), System.Drawing.Image)
        Me.MozItemBackupRestore.Location = New System.Drawing.Point(2, 197)
        Me.MozItemBackupRestore.Name = "MozItemBackupRestore"
        Me.MozItemBackupRestore.Size = New System.Drawing.Size(146, 63)
        Me.MozItemBackupRestore.TabIndex = 3
        Me.MozItemBackupRestore.Text = "Backup / Restore"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(150, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(501, 46)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "Payment Voucher"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 43)
        Me.btnSave.Text = "&Save && Close [Ctl +S]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 43)
        Me.btnClose.Text = "&Cancel [Esc]"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(77, 24)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(501, 424)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtPostalCode)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtCountry)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtState)
        Me.TabPage1.Controls.Add(Me.txtAddress2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtCity)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtAddress1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtWebsite)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtFax)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtGST)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtNTN)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtMobile)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtLandline)
        Me.TabPage1.Controls.Add(Me.txtId)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.DimGray
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(493, 392)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Company Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(243, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Financials"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(224, 349)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPostalCode.Location = New System.Drawing.Point(312, 346)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(135, 20)
        Me.txtPostalCode.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(7, 345)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCountry.Location = New System.Drawing.Point(72, 346)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(135, 20)
        Me.txtCountry.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(224, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Province"
        '
        'txtState
        '
        Me.txtState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtState.Location = New System.Drawing.Point(312, 320)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(135, 20)
        Me.txtState.TabIndex = 38
        '
        'txtAddress2
        '
        Me.txtAddress2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress2.Location = New System.Drawing.Point(72, 294)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(375, 20)
        Me.txtAddress2.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGray
        Me.Label15.Location = New System.Drawing.Point(7, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCity.Location = New System.Drawing.Point(72, 320)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(135, 20)
        Me.txtCity.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Street"
        '
        'txtAddress1
        '
        Me.txtAddress1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress1.Location = New System.Drawing.Point(72, 268)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(375, 20)
        Me.txtAddress1.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Basic"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(7, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtWebsite.Location = New System.Drawing.Point(72, 203)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(150, 20)
        Me.txtWebsite.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(7, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fax"
        '
        'txtFax
        '
        Me.txtFax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFax.Location = New System.Drawing.Point(72, 151)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(150, 20)
        Me.txtFax.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(254, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "GST"
        '
        'txtGST
        '
        Me.txtGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGST.Location = New System.Drawing.Point(297, 125)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(150, 20)
        Me.txtGST.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(254, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "NTN"
        '
        'txtNTN
        '
        Me.txtNTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNTN.Location = New System.Drawing.Point(297, 99)
        Me.txtNTN.Name = "txtNTN"
        Me.txtNTN.Size = New System.Drawing.Size(150, 20)
        Me.txtNTN.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(7, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(72, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMobile.Location = New System.Drawing.Point(72, 99)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(150, 20)
        Me.txtMobile.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Landline"
        '
        'txtLandline
        '
        Me.txtLandline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLandline.Location = New System.Drawing.Point(72, 125)
        Me.txtLandline.Name = "txtLandline"
        Me.txtLandline.Size = New System.Drawing.Size(150, 20)
        Me.txtLandline.TabIndex = 7
        '
        'txtId
        '
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(88, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(48, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(72, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(375, 20)
        Me.txtName.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(493, 392)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Preferences"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.chkRequireUserPasswordToDelete)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(487, 386)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'chkRequireUserPasswordToDelete
        '
        Me.chkRequireUserPasswordToDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRequireUserPasswordToDelete.Location = New System.Drawing.Point(3, 3)
        Me.chkRequireUserPasswordToDelete.Name = "chkRequireUserPasswordToDelete"
        Me.chkRequireUserPasswordToDelete.Size = New System.Drawing.Size(332, 24)
        Me.chkRequireUserPasswordToDelete.TabIndex = 1
        Me.chkRequireUserPasswordToDelete.Text = "Require User Password to Delete any Voucher"
        Me.chkRequireUserPasswordToDelete.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.pnlAccountSearch)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(493, 392)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Default Accounts"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pnlAccountSearch
        '
        Me.pnlAccountSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccountSearch.Controls.Add(Me.lblAddNewAccount)
        Me.pnlAccountSearch.Controls.Add(Me.dgvAccountSearch)
        Me.pnlAccountSearch.Location = New System.Drawing.Point(147, 123)
        Me.pnlAccountSearch.Name = "pnlAccountSearch"
        Me.pnlAccountSearch.Size = New System.Drawing.Size(265, 113)
        Me.pnlAccountSearch.TabIndex = 11
        Me.pnlAccountSearch.Visible = False
        '
        'lblAddNewAccount
        '
        Me.lblAddNewAccount.ActiveLinkColor = System.Drawing.Color.Black
        Me.lblAddNewAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAddNewAccount.AutoSize = True
        Me.lblAddNewAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddNewAccount.DisabledLinkColor = System.Drawing.Color.Black
        Me.lblAddNewAccount.LinkColor = System.Drawing.Color.Black
        Me.lblAddNewAccount.Location = New System.Drawing.Point(6, 85)
        Me.lblAddNewAccount.Name = "lblAddNewAccount"
        Me.lblAddNewAccount.Size = New System.Drawing.Size(158, 13)
        Me.lblAddNewAccount.TabIndex = 80
        Me.lblAddNewAccount.TabStop = True
        Me.lblAddNewAccount.Text = "Click Here to Add New Account"
        Me.lblAddNewAccount.VisitedLinkColor = System.Drawing.Color.Black
        '
        'dgvAccountSearch
        '
        Me.dgvAccountSearch.AllowUserToAddRows = False
        Me.dgvAccountSearch.AllowUserToDeleteRows = False
        Me.dgvAccountSearch.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvAccountSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccountSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAccountSearch.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAccountSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccountSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccountSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccountSearch.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAccountSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgvAccountSearch.Name = "dgvAccountSearch"
        Me.dgvAccountSearch.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccountSearch.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAccountSearch.RowHeadersVisible = False
        Me.dgvAccountSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccountSearch.Size = New System.Drawing.Size(263, 78)
        Me.dgvAccountSearch.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultCarriageCreditAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultCashAccount)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultCashAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultCarriageCreditAccount)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultCarriageDebitAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultSaleAccount)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultCarriageDebitAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultSaleAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultTransportationDiscountAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultProductSaleAccount)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultTransportationDiscountAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultProductSaleAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultSaleDiscountAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultProductCOGSAccount)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.txtAccNameDefaultSaleDiscountAccount)
        Me.GroupBox1.Controls.Add(Me.txtAccCodeDefaultProductCOGSAccount)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 75)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Default Accounts"
        '
        'txtAccCodeDefaultCarriageCreditAccount
        '
        Me.txtAccCodeDefaultCarriageCreditAccount.Location = New System.Drawing.Point(340, 203)
        Me.txtAccCodeDefaultCarriageCreditAccount.Name = "txtAccCodeDefaultCarriageCreditAccount"
        Me.txtAccCodeDefaultCarriageCreditAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultCarriageCreditAccount.TabIndex = 114
        Me.txtAccCodeDefaultCarriageCreditAccount.Visible = False
        '
        'txtAccNameDefaultCashAccount
        '
        Me.txtAccNameDefaultCashAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultCashAccount.Location = New System.Drawing.Point(145, 22)
        Me.txtAccNameDefaultCashAccount.Name = "txtAccNameDefaultCashAccount"
        Me.txtAccNameDefaultCashAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultCashAccount.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(2, 207)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 13)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "Carriage P/A To"
        Me.Label20.Visible = False
        '
        'txtAccCodeDefaultCashAccount
        '
        Me.txtAccCodeDefaultCashAccount.Location = New System.Drawing.Point(340, 22)
        Me.txtAccCodeDefaultCashAccount.Name = "txtAccCodeDefaultCashAccount"
        Me.txtAccCodeDefaultCashAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultCashAccount.TabIndex = 19
        '
        'txtAccNameDefaultCarriageCreditAccount
        '
        Me.txtAccNameDefaultCarriageCreditAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultCarriageCreditAccount.Location = New System.Drawing.Point(145, 203)
        Me.txtAccNameDefaultCarriageCreditAccount.Name = "txtAccNameDefaultCarriageCreditAccount"
        Me.txtAccNameDefaultCarriageCreditAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultCarriageCreditAccount.TabIndex = 113
        Me.txtAccNameDefaultCarriageCreditAccount.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(2, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Cash Account"
        '
        'txtAccCodeDefaultCarriageDebitAccount
        '
        Me.txtAccCodeDefaultCarriageDebitAccount.Location = New System.Drawing.Point(340, 179)
        Me.txtAccCodeDefaultCarriageDebitAccount.Name = "txtAccCodeDefaultCarriageDebitAccount"
        Me.txtAccCodeDefaultCarriageDebitAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultCarriageDebitAccount.TabIndex = 111
        Me.txtAccCodeDefaultCarriageDebitAccount.Visible = False
        '
        'txtAccNameDefaultSaleAccount
        '
        Me.txtAccNameDefaultSaleAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultSaleAccount.Location = New System.Drawing.Point(145, 49)
        Me.txtAccNameDefaultSaleAccount.Name = "txtAccNameDefaultSaleAccount"
        Me.txtAccNameDefaultSaleAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultSaleAccount.TabIndex = 4
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(2, 182)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 13)
        Me.Label42.TabIndex = 109
        Me.Label42.Text = "Carriage Charged To"
        Me.Label42.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(2, 53)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(71, 13)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Sale Account"
        '
        'txtAccNameDefaultCarriageDebitAccount
        '
        Me.txtAccNameDefaultCarriageDebitAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultCarriageDebitAccount.Location = New System.Drawing.Point(145, 178)
        Me.txtAccNameDefaultCarriageDebitAccount.Name = "txtAccNameDefaultCarriageDebitAccount"
        Me.txtAccNameDefaultCarriageDebitAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultCarriageDebitAccount.TabIndex = 110
        Me.txtAccNameDefaultCarriageDebitAccount.Visible = False
        '
        'txtAccCodeDefaultSaleAccount
        '
        Me.txtAccCodeDefaultSaleAccount.Location = New System.Drawing.Point(340, 50)
        Me.txtAccCodeDefaultSaleAccount.Name = "txtAccCodeDefaultSaleAccount"
        Me.txtAccCodeDefaultSaleAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultSaleAccount.TabIndex = 88
        '
        'txtAccCodeDefaultTransportationDiscountAccount
        '
        Me.txtAccCodeDefaultTransportationDiscountAccount.Location = New System.Drawing.Point(340, 152)
        Me.txtAccCodeDefaultTransportationDiscountAccount.Name = "txtAccCodeDefaultTransportationDiscountAccount"
        Me.txtAccCodeDefaultTransportationDiscountAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultTransportationDiscountAccount.TabIndex = 108
        Me.txtAccCodeDefaultTransportationDiscountAccount.Visible = False
        '
        'txtAccNameDefaultProductSaleAccount
        '
        Me.txtAccNameDefaultProductSaleAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultProductSaleAccount.Location = New System.Drawing.Point(145, 75)
        Me.txtAccNameDefaultProductSaleAccount.Name = "txtAccNameDefaultProductSaleAccount"
        Me.txtAccNameDefaultProductSaleAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultProductSaleAccount.TabIndex = 6
        Me.txtAccNameDefaultProductSaleAccount.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(2, 156)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(120, 13)
        Me.Label41.TabIndex = 104
        Me.Label41.Text = "Transportation Discount"
        Me.Label41.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(2, 79)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Product Sale Acc"
        Me.Label23.Visible = False
        '
        'txtAccNameDefaultTransportationDiscountAccount
        '
        Me.txtAccNameDefaultTransportationDiscountAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultTransportationDiscountAccount.Location = New System.Drawing.Point(145, 152)
        Me.txtAccNameDefaultTransportationDiscountAccount.Name = "txtAccNameDefaultTransportationDiscountAccount"
        Me.txtAccNameDefaultTransportationDiscountAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultTransportationDiscountAccount.TabIndex = 105
        Me.txtAccNameDefaultTransportationDiscountAccount.Visible = False
        '
        'txtAccCodeDefaultProductSaleAccount
        '
        Me.txtAccCodeDefaultProductSaleAccount.Location = New System.Drawing.Point(340, 76)
        Me.txtAccCodeDefaultProductSaleAccount.Name = "txtAccCodeDefaultProductSaleAccount"
        Me.txtAccCodeDefaultProductSaleAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultProductSaleAccount.TabIndex = 91
        Me.txtAccCodeDefaultProductSaleAccount.Visible = False
        '
        'txtAccCodeDefaultSaleDiscountAccount
        '
        Me.txtAccCodeDefaultSaleDiscountAccount.Location = New System.Drawing.Point(340, 128)
        Me.txtAccCodeDefaultSaleDiscountAccount.Name = "txtAccCodeDefaultSaleDiscountAccount"
        Me.txtAccCodeDefaultSaleDiscountAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultSaleDiscountAccount.TabIndex = 97
        Me.txtAccCodeDefaultSaleDiscountAccount.Visible = False
        '
        'txtAccNameDefaultProductCOGSAccount
        '
        Me.txtAccNameDefaultProductCOGSAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultProductCOGSAccount.Location = New System.Drawing.Point(145, 101)
        Me.txtAccNameDefaultProductCOGSAccount.Name = "txtAccNameDefaultProductCOGSAccount"
        Me.txtAccNameDefaultProductCOGSAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultProductCOGSAccount.TabIndex = 8
        Me.txtAccNameDefaultProductCOGSAccount.Visible = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(2, 131)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 13)
        Me.Label40.TabIndex = 9
        Me.Label40.Text = "Sale Discount Acc"
        Me.Label40.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(2, 105)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(99, 13)
        Me.Label39.TabIndex = 7
        Me.Label39.Text = "Product COGS Acc"
        Me.Label39.Visible = False
        '
        'txtAccNameDefaultSaleDiscountAccount
        '
        Me.txtAccNameDefaultSaleDiscountAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccNameDefaultSaleDiscountAccount.Location = New System.Drawing.Point(145, 127)
        Me.txtAccNameDefaultSaleDiscountAccount.Name = "txtAccNameDefaultSaleDiscountAccount"
        Me.txtAccNameDefaultSaleDiscountAccount.Size = New System.Drawing.Size(189, 20)
        Me.txtAccNameDefaultSaleDiscountAccount.TabIndex = 10
        Me.txtAccNameDefaultSaleDiscountAccount.Visible = False
        '
        'txtAccCodeDefaultProductCOGSAccount
        '
        Me.txtAccCodeDefaultProductCOGSAccount.Location = New System.Drawing.Point(340, 102)
        Me.txtAccCodeDefaultProductCOGSAccount.Name = "txtAccCodeDefaultProductCOGSAccount"
        Me.txtAccCodeDefaultProductCOGSAccount.Size = New System.Drawing.Size(64, 20)
        Me.txtAccCodeDefaultProductCOGSAccount.TabIndex = 94
        Me.txtAccCodeDefaultProductCOGSAccount.Visible = False
        '
        'pnlCompany
        '
        Me.pnlCompany.Controls.Add(Me.TabControl1)
        Me.pnlCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCompany.Location = New System.Drawing.Point(0, 0)
        Me.pnlCompany.Name = "pnlCompany"
        Me.pnlCompany.Size = New System.Drawing.Size(501, 424)
        Me.pnlCompany.TabIndex = 5
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.pnlCompany)
        Me.pnlContainer.Controls.Add(Me.pnlReference)
        Me.pnlContainer.Controls.Add(Me.pnlUsers)
        Me.pnlContainer.Controls.Add(Me.pnlBackupRestore)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(150, 46)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(501, 424)
        Me.pnlContainer.TabIndex = 6
        '
        'pnlReference
        '
        Me.pnlReference.BackColor = System.Drawing.Color.White
        Me.pnlReference.Controls.Add(Me.Label43)
        Me.pnlReference.Controls.Add(Me.btnZone)
        Me.pnlReference.Controls.Add(Me.Label22)
        Me.pnlReference.Controls.Add(Me.btnLocation)
        Me.pnlReference.Controls.Add(Me.Label37)
        Me.pnlReference.Controls.Add(Me.btnRacks)
        Me.pnlReference.Controls.Add(Me.Label36)
        Me.pnlReference.Controls.Add(Me.btnPacking)
        Me.pnlReference.Controls.Add(Me.Label24)
        Me.pnlReference.Controls.Add(Me.btnRooms)
        Me.pnlReference.Controls.Add(Me.Label34)
        Me.pnlReference.Controls.Add(Me.Label35)
        Me.pnlReference.Location = New System.Drawing.Point(126, 130)
        Me.pnlReference.Name = "pnlReference"
        Me.pnlReference.Size = New System.Drawing.Size(116, 98)
        Me.pnlReference.TabIndex = 9
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Gray
        Me.Label43.Location = New System.Drawing.Point(150, 283)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(182, 13)
        Me.Label43.TabIndex = 44
        Me.Label43.Text = "Geographical marks of your copmany"
        Me.Label43.Visible = False
        '
        'btnZone
        '
        Me.btnZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnZone.Location = New System.Drawing.Point(23, 278)
        Me.btnZone.Name = "btnZone"
        Me.btnZone.Size = New System.Drawing.Size(120, 23)
        Me.btnZone.TabIndex = 43
        Me.btnZone.Text = "Zone"
        Me.btnZone.UseVisualStyleBackColor = True
        Me.btnZone.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Gray
        Me.Label22.Location = New System.Drawing.Point(149, 235)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(170, 13)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Warehouses, Godowns, Locations"
        Me.Label22.Visible = False
        '
        'btnLocation
        '
        Me.btnLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLocation.Location = New System.Drawing.Point(22, 230)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(120, 23)
        Me.btnLocation.TabIndex = 41
        Me.btnLocation.Text = "Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        Me.btnLocation.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.Gray
        Me.Label37.Location = New System.Drawing.Point(149, 187)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(152, 13)
        Me.Label37.TabIndex = 40
        Me.Label37.Text = "Extend Catagoriies of Products"
        Me.Label37.Visible = False
        '
        'btnRacks
        '
        Me.btnRacks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRacks.Location = New System.Drawing.Point(22, 182)
        Me.btnRacks.Name = "btnRacks"
        Me.btnRacks.Size = New System.Drawing.Size(120, 23)
        Me.btnRacks.TabIndex = 39
        Me.btnRacks.Text = "Sub Cataogory"
        Me.btnRacks.UseVisualStyleBackColor = True
        Me.btnRacks.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Gray
        Me.Label36.Location = New System.Drawing.Point(149, 91)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(259, 13)
        Me.Label36.TabIndex = 38
        Me.Label36.Text = "Your Product Line i.e. Raw Material, Finished Material"
        Me.Label36.Visible = False
        '
        'btnPacking
        '
        Me.btnPacking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPacking.Location = New System.Drawing.Point(22, 86)
        Me.btnPacking.Name = "btnPacking"
        Me.btnPacking.Size = New System.Drawing.Size(120, 23)
        Me.btnPacking.TabIndex = 37
        Me.btnPacking.Text = "Line Items"
        Me.btnPacking.UseVisualStyleBackColor = True
        Me.btnPacking.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Gray
        Me.Label24.Location = New System.Drawing.Point(149, 139)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(125, 13)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Catagorize your Products"
        Me.Label24.Visible = False
        '
        'btnRooms
        '
        Me.btnRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRooms.Location = New System.Drawing.Point(22, 134)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(120, 23)
        Me.btnRooms.TabIndex = 33
        Me.btnRooms.Text = "Cataogry"
        Me.btnRooms.UseVisualStyleBackColor = True
        Me.btnRooms.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(20, 42)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(109, 13)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "Adjust the lookup lists"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(18, 18)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(102, 20)
        Me.Label35.TabIndex = 29
        Me.Label35.Text = "References"
        '
        'pnlUsers
        '
        Me.pnlUsers.BackColor = System.Drawing.SystemColors.Window
        Me.pnlUsers.Controls.Add(Me.btnRemoveUser)
        Me.pnlUsers.Controls.Add(Me.btnAddUser)
        Me.pnlUsers.Controls.Add(Me.dgvUsers)
        Me.pnlUsers.Controls.Add(Me.Label19)
        Me.pnlUsers.Controls.Add(Me.Label14)
        Me.pnlUsers.Location = New System.Drawing.Point(0, 285)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(205, 139)
        Me.pnlUsers.TabIndex = 6
        '
        'btnRemoveUser
        '
        Me.btnRemoveUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRemoveUser.Location = New System.Drawing.Point(380, 355)
        Me.btnRemoveUser.Name = "btnRemoveUser"
        Me.btnRemoveUser.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveUser.TabIndex = 31
        Me.btnRemoveUser.Text = "Disable"
        Me.btnRemoveUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddUser.Location = New System.Drawing.Point(299, 355)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 23)
        Me.btnAddUser.TabIndex = 30
        Me.btnAddUser.Text = "Add"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AllowUserToResizeColumns = False
        Me.dgvUsers.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvUsers.ColumnHeadersHeight = 40
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUsers.Location = New System.Drawing.Point(22, 71)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(433, 278)
        Me.dgvUsers.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(20, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(261, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Give multiple accounts and control their access rights."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 20)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Users"
        '
        'pnlBackupRestore
        '
        Me.pnlBackupRestore.BackColor = System.Drawing.SystemColors.Window
        Me.pnlBackupRestore.Controls.Add(Me.lblNoteProgress)
        Me.pnlBackupRestore.Controls.Add(Me.ProgressBar1)
        Me.pnlBackupRestore.Controls.Add(Me.lblNote)
        Me.pnlBackupRestore.Controls.Add(Me.chkAutoBackupOnClose)
        Me.pnlBackupRestore.Controls.Add(Me.txtAutoBackupDays)
        Me.pnlBackupRestore.Controls.Add(Me.Label33)
        Me.pnlBackupRestore.Controls.Add(Me.Label32)
        Me.pnlBackupRestore.Controls.Add(Me.Label31)
        Me.pnlBackupRestore.Controls.Add(Me.Label30)
        Me.pnlBackupRestore.Controls.Add(Me.Label29)
        Me.pnlBackupRestore.Controls.Add(Me.Label28)
        Me.pnlBackupRestore.Controls.Add(Me.btnBackupDirectory)
        Me.pnlBackupRestore.Controls.Add(Me.txtAutoBackupDirectory)
        Me.pnlBackupRestore.Controls.Add(Me.btnBackupPath)
        Me.pnlBackupRestore.Controls.Add(Me.Label27)
        Me.pnlBackupRestore.Controls.Add(Me.Button2)
        Me.pnlBackupRestore.Controls.Add(Me.btnBackup)
        Me.pnlBackupRestore.Controls.Add(Me.Label25)
        Me.pnlBackupRestore.Controls.Add(Me.Label26)
        Me.pnlBackupRestore.Location = New System.Drawing.Point(253, 344)
        Me.pnlBackupRestore.Name = "pnlBackupRestore"
        Me.pnlBackupRestore.Size = New System.Drawing.Size(118, 68)
        Me.pnlBackupRestore.TabIndex = 8
        '
        'lblNoteProgress
        '
        Me.lblNoteProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNoteProgress.Location = New System.Drawing.Point(23, 76)
        Me.lblNoteProgress.Name = "lblNoteProgress"
        Me.lblNoteProgress.Size = New System.Drawing.Size(425, 13)
        Me.lblNoteProgress.TabIndex = 50
        Me.lblNoteProgress.Text = ". . ."
        Me.lblNoteProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoteProgress.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(22, -170)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(68, 12)
        Me.ProgressBar1.TabIndex = 49
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNote.Location = New System.Drawing.Point(205, 259)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(22, 13)
        Me.lblNote.TabIndex = 48
        Me.lblNote.Text = ". . ."
        Me.lblNote.Visible = False
        '
        'chkAutoBackupOnClose
        '
        Me.chkAutoBackupOnClose.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAutoBackupOnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAutoBackupOnClose.Location = New System.Drawing.Point(20, 308)
        Me.chkAutoBackupOnClose.Name = "chkAutoBackupOnClose"
        Me.chkAutoBackupOnClose.Size = New System.Drawing.Size(150, 24)
        Me.chkAutoBackupOnClose.TabIndex = 47
        Me.chkAutoBackupOnClose.Text = "Auto Backup On Close"
        Me.chkAutoBackupOnClose.UseVisualStyleBackColor = True
        '
        'txtAutoBackupDays
        '
        Me.txtAutoBackupDays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAutoBackupDays.Location = New System.Drawing.Point(115, 256)
        Me.txtAutoBackupDays.Name = "txtAutoBackupDays"
        Me.txtAutoBackupDays.Size = New System.Drawing.Size(40, 20)
        Me.txtAutoBackupDays.TabIndex = 45
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(160, 260)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 13)
        Me.Label33.TabIndex = 44
        Me.Label33.Text = "Days"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(20, 260)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 13)
        Me.Label32.TabIndex = 43
        Me.Label32.Text = "Backup Every "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(19, 222)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(184, 20)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "Auto Backup Settings"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(178, 161)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(126, 13)
        Me.Label30.TabIndex = 41
        Me.Label30.Text = "Restore data to any point"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(178, 132)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(260, 13)
        Me.Label29.TabIndex = 40
        Me.Label29.Text = "Backup you Data in custom folder of your own choice"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(178, 103)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(198, 13)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Backup you Data in already set directory"
        '
        'btnBackupDirectory
        '
        Me.btnBackupDirectory.AutoSize = True
        Me.btnBackupDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBackupDirectory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackupDirectory.Location = New System.Drawing.Point(23, 98)
        Me.btnBackupDirectory.Name = "btnBackupDirectory"
        Me.btnBackupDirectory.Size = New System.Drawing.Size(149, 23)
        Me.btnBackupDirectory.TabIndex = 38
        Me.btnBackupDirectory.Text = "Backup to Directory"
        Me.btnBackupDirectory.UseVisualStyleBackColor = True
        '
        'txtAutoBackupDirectory
        '
        Me.txtAutoBackupDirectory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAutoBackupDirectory.Location = New System.Drawing.Point(115, 282)
        Me.txtAutoBackupDirectory.Name = "txtAutoBackupDirectory"
        Me.txtAutoBackupDirectory.ReadOnly = True
        Me.txtAutoBackupDirectory.Size = New System.Drawing.Size(272, 20)
        Me.txtAutoBackupDirectory.TabIndex = 37
        '
        'btnBackupPath
        '
        Me.btnBackupPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBackupPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackupPath.Location = New System.Drawing.Point(393, 278)
        Me.btnBackupPath.Name = "btnBackupPath"
        Me.btnBackupPath.Size = New System.Drawing.Size(20, 20)
        Me.btnBackupPath.TabIndex = 36
        Me.btnBackupPath.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(20, 286)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 13)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "Backup Directory"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(23, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Restore"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackup.Location = New System.Drawing.Point(23, 127)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(149, 23)
        Me.btnBackup.TabIndex = 33
        Me.btnBackup.Text = "Backup to Custom Folder"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(20, 42)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(229, 13)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Keep your data backup to avoid any unforseen"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(18, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(148, 20)
        Me.Label26.TabIndex = 31
        Me.Label26.Text = "Backup / Restore"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtParentValue2
        '
        Me.txtParentValue2.Location = New System.Drawing.Point(520, 2)
        Me.txtParentValue2.Name = "txtParentValue2"
        Me.txtParentValue2.Size = New System.Drawing.Size(8, 20)
        Me.txtParentValue2.TabIndex = 10
        Me.txtParentValue2.TabStop = False
        Me.txtParentValue2.Visible = False
        '
        'txtParentValue1
        '
        Me.txtParentValue1.Location = New System.Drawing.Point(506, 21)
        Me.txtParentValue1.Name = "txtParentValue1"
        Me.txtParentValue1.Size = New System.Drawing.Size(8, 20)
        Me.txtParentValue1.TabIndex = 9
        Me.txtParentValue1.TabStop = False
        Me.txtParentValue1.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(23, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Zone"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(651, 470)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.txtParentValue2)
        Me.Controls.Add(Me.txtParentValue1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MozPane1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.MozPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MozPane1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.pnlAccountSearch.ResumeLayout(False)
        Me.pnlAccountSearch.PerformLayout()
        CType(Me.dgvAccountSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlCompany.ResumeLayout(False)
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlReference.ResumeLayout(False)
        Me.pnlReference.PerformLayout()
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsers.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackupRestore.ResumeLayout(False)
        Me.pnlBackupRestore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MozPane1 As Pabo.MozBar.MozPane
    Friend WithEvents MozItemCompany As Pabo.MozBar.MozItem
    Friend WithEvents MozItemUsers As Pabo.MozBar.MozItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNTN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLandline As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlCompany As System.Windows.Forms.Panel
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlUsers As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents MozItemBackupRestore As Pabo.MozBar.MozItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pnlBackupRestore As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnBackupDirectory As System.Windows.Forms.Button
    Friend WithEvents txtAutoBackupDirectory As System.Windows.Forms.TextBox
    Friend WithEvents btnBackupPath As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtAutoBackupDays As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblNoteProgress As System.Windows.Forms.Label
    Friend WithEvents txtParentValue2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentValue1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtAccCodeDefaultCashAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAccNameDefaultCashAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents pnlAccountSearch As System.Windows.Forms.Panel
    Friend WithEvents lblAddNewAccount As System.Windows.Forms.LinkLabel
    Friend WithEvents dgvAccountSearch As System.Windows.Forms.DataGridView
    Friend WithEvents chkAutoBackupOnClose As System.Windows.Forms.CheckBox
    Friend WithEvents MozItemReferences As Pabo.MozBar.MozItem
    Friend WithEvents pnlReference As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnRooms As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnRacks As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents btnPacking As System.Windows.Forms.Button
    Friend WithEvents txtAccCodeDefaultSaleAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultSaleAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAccCodeDefaultSaleDiscountAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultSaleDiscountAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAccCodeDefaultProductCOGSAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultProductCOGSAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAccCodeDefaultProductSaleAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultProductSaleAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAccCodeDefaultTransportationDiscountAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultTransportationDiscountAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnLocation As System.Windows.Forms.Button
    Friend WithEvents txtAccCodeDefaultCarriageCreditAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultCarriageCreditAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAccCodeDefaultCarriageDebitAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtAccNameDefaultCarriageDebitAccount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveUser As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents btnZone As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents chkRequireUserPasswordToDelete As System.Windows.Forms.CheckBox
End Class
