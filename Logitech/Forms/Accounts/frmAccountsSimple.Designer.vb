<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountsSimple
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountsSimple))
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.txtSearchText = New Logitech.TextBoxHint()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtInvoiceGraceDays = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cboParentAccount = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCreditDays = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.txtCreditLimit = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.btnAddAccType = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtNTN = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLandline = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.chkIsAccount = New System.Windows.Forms.CheckBox()
        Me.btnSearchAcc = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccLevel = New System.Windows.Forms.TextBox()
        Me.txtOpeningCredit = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.cboAccNature = New System.Windows.Forms.ComboBox()
        Me.txtOpeningDebit = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.dtpOpeningDate = New System.Windows.Forms.DateTimePicker()
        Me.cboAccType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtAccCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbList = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtThisLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        CType(Me.txtInvoiceGraceDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpeningCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpeningDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1234, 15)
        Me.Panel15.TabIndex = 2
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.Location = New System.Drawing.Point(0, 15)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SplitContainer.Panel1.Controls.Add(Me.dgvList)
        Me.SplitContainer.Panel1.Controls.Add(Me.txtSearchText)
        Me.SplitContainer.Panel1.Controls.Add(Me.picPanelExtender)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer.Panel1MinSize = 250
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.pnlContainer)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtUser)
        Me.SplitContainer.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer.Size = New System.Drawing.Size(1234, 666)
        Me.SplitContainer.SplitterDistance = 250
        Me.SplitContainer.TabIndex = 3
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvList.ColumnHeadersHeight = 40
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvList.Location = New System.Drawing.Point(8, 61)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(231, 594)
        Me.dgvList.TabIndex = 43
        Me.dgvList.TabStop = False
        '
        'txtSearchText
        '
        Me.txtSearchText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSearchText.HintDetails.HintFadeSpeed = 0
        Me.txtSearchText.HintDetails.HintText = "Type Here to Search"
        Me.txtSearchText.Location = New System.Drawing.Point(8, 35)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(231, 20)
        Me.txtSearchText.TabIndex = 42
        '
        'picPanelExtender
        '
        Me.picPanelExtender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPanelExtender.BackgroundImage = Global.Logitech.My.Resources.Resources.Go_Forward_48px
        Me.picPanelExtender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPanelExtender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPanelExtender.ErrorImage = Nothing
        Me.picPanelExtender.Location = New System.Drawing.Point(217, 6)
        Me.picPanelExtender.Name = "picPanelExtender"
        Me.picPanelExtender.Size = New System.Drawing.Size(22, 22)
        Me.picPanelExtender.TabIndex = 41
        Me.picPanelExtender.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(12, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Search"
        '
        'pnlContainer
        '
        Me.pnlContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContainer.AutoScroll = True
        Me.pnlContainer.BackColor = System.Drawing.SystemColors.Window
        Me.pnlContainer.Controls.Add(Me.Label32)
        Me.pnlContainer.Controls.Add(Me.txtInvoiceGraceDays)
        Me.pnlContainer.Controls.Add(Me.Label31)
        Me.pnlContainer.Controls.Add(Me.cboParentAccount)
        Me.pnlContainer.Controls.Add(Me.Label16)
        Me.pnlContainer.Controls.Add(Me.Label14)
        Me.pnlContainer.Controls.Add(Me.Label5)
        Me.pnlContainer.Controls.Add(Me.txtCreditDays)
        Me.pnlContainer.Controls.Add(Me.txtCreditLimit)
        Me.pnlContainer.Controls.Add(Me.btnAddAccType)
        Me.pnlContainer.Controls.Add(Me.Label27)
        Me.pnlContainer.Controls.Add(Me.Label28)
        Me.pnlContainer.Controls.Add(Me.txtGST)
        Me.pnlContainer.Controls.Add(Me.Label29)
        Me.pnlContainer.Controls.Add(Me.txtNTN)
        Me.pnlContainer.Controls.Add(Me.Label10)
        Me.pnlContainer.Controls.Add(Me.txtPostalCode)
        Me.pnlContainer.Controls.Add(Me.Label11)
        Me.pnlContainer.Controls.Add(Me.txtCountry)
        Me.pnlContainer.Controls.Add(Me.Label23)
        Me.pnlContainer.Controls.Add(Me.txtState)
        Me.pnlContainer.Controls.Add(Me.txtAddress2)
        Me.pnlContainer.Controls.Add(Me.Label24)
        Me.pnlContainer.Controls.Add(Me.Label25)
        Me.pnlContainer.Controls.Add(Me.txtCity)
        Me.pnlContainer.Controls.Add(Me.Label26)
        Me.pnlContainer.Controls.Add(Me.txtAddress1)
        Me.pnlContainer.Controls.Add(Me.Label15)
        Me.pnlContainer.Controls.Add(Me.Label17)
        Me.pnlContainer.Controls.Add(Me.txtWebsite)
        Me.pnlContainer.Controls.Add(Me.Label18)
        Me.pnlContainer.Controls.Add(Me.txtFax)
        Me.pnlContainer.Controls.Add(Me.Label19)
        Me.pnlContainer.Controls.Add(Me.txtEmail)
        Me.pnlContainer.Controls.Add(Me.Label20)
        Me.pnlContainer.Controls.Add(Me.txtMobile)
        Me.pnlContainer.Controls.Add(Me.Label21)
        Me.pnlContainer.Controls.Add(Me.txtLandline)
        Me.pnlContainer.Controls.Add(Me.Label22)
        Me.pnlContainer.Controls.Add(Me.txtContactName)
        Me.pnlContainer.Controls.Add(Me.chkIsAccount)
        Me.pnlContainer.Controls.Add(Me.btnSearchAcc)
        Me.pnlContainer.Controls.Add(Me.Label9)
        Me.pnlContainer.Controls.Add(Me.Label6)
        Me.pnlContainer.Controls.Add(Me.Label4)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Controls.Add(Me.txtAccLevel)
        Me.pnlContainer.Controls.Add(Me.txtOpeningCredit)
        Me.pnlContainer.Controls.Add(Me.cboAccNature)
        Me.pnlContainer.Controls.Add(Me.txtOpeningDebit)
        Me.pnlContainer.Controls.Add(Me.dtpOpeningDate)
        Me.pnlContainer.Controls.Add(Me.cboAccType)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.txtId)
        Me.pnlContainer.Controls.Add(Me.txtAccCode)
        Me.pnlContainer.Controls.Add(Me.Label7)
        Me.pnlContainer.Controls.Add(Me.Label12)
        Me.pnlContainer.Controls.Add(Me.txtAccName)
        Me.pnlContainer.Location = New System.Drawing.Point(7, 49)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(961, 606)
        Me.pnlContainer.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label32.Location = New System.Drawing.Point(421, 410)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 16)
        Me.Label32.TabIndex = 60
        Me.Label32.Text = "Sale Days"
        '
        'txtInvoiceGraceDays
        '
        Me.txtInvoiceGraceDays.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtInvoiceGraceDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvoiceGraceDays.DoubleValue = 0.0R
        Me.txtInvoiceGraceDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtInvoiceGraceDays.Location = New System.Drawing.Point(526, 407)
        Me.txtInvoiceGraceDays.Name = "txtInvoiceGraceDays"
        Me.txtInvoiceGraceDays.NumberDecimalDigits = 0
        Me.txtInvoiceGraceDays.Size = New System.Drawing.Size(125, 22)
        Me.txtInvoiceGraceDays.TabIndex = 61
        Me.txtInvoiceGraceDays.Text = "0"
        Me.txtInvoiceGraceDays.ThemeName = "Default"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(18, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 16)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Catagory"
        '
        'cboParentAccount
        '
        Me.cboParentAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParentAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboParentAccount.FormattingEnabled = True
        Me.cboParentAccount.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboParentAccount.Location = New System.Drawing.Point(121, 48)
        Me.cboParentAccount.Name = "cboParentAccount"
        Me.cboParentAccount.Size = New System.Drawing.Size(250, 24)
        Me.cboParentAccount.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(554, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 16)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Local Currency"
        Me.Label16.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(421, 298)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Crerdit Limit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(421, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Credit Days"
        '
        'txtCreditDays
        '
        Me.txtCreditDays.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtCreditDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreditDays.DoubleValue = 0.0R
        Me.txtCreditDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCreditDays.Location = New System.Drawing.Point(526, 323)
        Me.txtCreditDays.Name = "txtCreditDays"
        Me.txtCreditDays.NumberDecimalDigits = 0
        Me.txtCreditDays.Size = New System.Drawing.Size(125, 22)
        Me.txtCreditDays.TabIndex = 55
        Me.txtCreditDays.Text = "0"
        Me.txtCreditDays.ThemeName = "Default"
        '
        'txtCreditLimit
        '
        Me.txtCreditLimit.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreditLimit.DoubleValue = 0.0R
        Me.txtCreditLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCreditLimit.Location = New System.Drawing.Point(526, 295)
        Me.txtCreditLimit.Name = "txtCreditLimit"
        Me.txtCreditLimit.NumberDecimalDigits = 0
        Me.txtCreditLimit.Size = New System.Drawing.Size(125, 22)
        Me.txtCreditLimit.TabIndex = 53
        Me.txtCreditLimit.Text = "0"
        Me.txtCreditLimit.ThemeName = "Default"
        '
        'btnAddAccType
        '
        Me.btnAddAccType.BackgroundImage = CType(resources.GetObject("btnAddAccType.BackgroundImage"), System.Drawing.Image)
        Me.btnAddAccType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddAccType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAccType.Location = New System.Drawing.Point(377, 48)
        Me.btnAddAccType.Name = "btnAddAccType"
        Me.btnAddAccType.Size = New System.Drawing.Size(24, 24)
        Me.btnAddAccType.TabIndex = 11
        Me.btnAddAccType.TabStop = False
        Me.btnAddAccType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAccType.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(420, 185)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 20)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Financials"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label28.Location = New System.Drawing.Point(420, 379)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 16)
        Me.Label28.TabIndex = 58
        Me.Label28.Text = "GST"
        '
        'txtGST
        '
        Me.txtGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtGST.Location = New System.Drawing.Point(526, 379)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(125, 22)
        Me.txtGST.TabIndex = 59
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label29.Location = New System.Drawing.Point(420, 351)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 16)
        Me.Label29.TabIndex = 56
        Me.Label29.Text = "NTN"
        '
        'txtNTN
        '
        Me.txtNTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNTN.Location = New System.Drawing.Point(526, 351)
        Me.txtNTN.Name = "txtNTN"
        Me.txtNTN.Size = New System.Drawing.Size(125, 22)
        Me.txtNTN.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(663, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPostalCode.Location = New System.Drawing.Point(751, 134)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(125, 22)
        Me.txtPostalCode.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(420, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCountry.Location = New System.Drawing.Point(526, 134)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(125, 22)
        Me.txtCountry.TabIndex = 38
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(663, 109)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Province"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtState.Location = New System.Drawing.Point(751, 106)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(125, 22)
        Me.txtState.TabIndex = 36
        '
        'txtAddress2
        '
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAddress2.Location = New System.Drawing.Point(526, 78)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(350, 22)
        Me.txtAddress2.TabIndex = 32
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(420, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 20)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Address"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(423, 102)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 16)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCity.Location = New System.Drawing.Point(526, 106)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(125, 22)
        Me.txtCity.TabIndex = 34
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label26.Location = New System.Drawing.Point(420, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 16)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "Street"
        '
        'txtAddress1
        '
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAddress1.Location = New System.Drawing.Point(526, 50)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(350, 22)
        Me.txtAddress1.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(19, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Contact"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(19, 354)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtWebsite.Location = New System.Drawing.Point(122, 351)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(250, 22)
        Me.txtWebsite.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(19, 298)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 16)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Fax"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFax.Location = New System.Drawing.Point(122, 295)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(250, 22)
        Me.txtFax.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(19, 326)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEmail.Location = New System.Drawing.Point(122, 323)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 22)
        Me.txtEmail.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(19, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtMobile.Location = New System.Drawing.Point(122, 239)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(250, 22)
        Me.txtMobile.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(19, 270)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Landline"
        '
        'txtLandline
        '
        Me.txtLandline.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtLandline.Location = New System.Drawing.Point(122, 267)
        Me.txtLandline.Name = "txtLandline"
        Me.txtLandline.Size = New System.Drawing.Size(250, 22)
        Me.txtLandline.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(19, 214)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 16)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Name"
        '
        'txtContactName
        '
        Me.txtContactName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtContactName.Location = New System.Drawing.Point(122, 211)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(250, 22)
        Me.txtContactName.TabIndex = 14
        '
        'chkIsAccount
        '
        Me.chkIsAccount.AutoSize = True
        Me.chkIsAccount.Location = New System.Drawing.Point(246, 19)
        Me.chkIsAccount.Name = "chkIsAccount"
        Me.chkIsAccount.Size = New System.Drawing.Size(77, 17)
        Me.chkIsAccount.TabIndex = 3
        Me.chkIsAccount.Text = "Is Account"
        Me.chkIsAccount.UseVisualStyleBackColor = True
        Me.chkIsAccount.Visible = False
        '
        'btnSearchAcc
        '
        Me.btnSearchAcc.BackgroundImage = Global.Logitech.My.Resources.Resources.Search
        Me.btnSearchAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAcc.Location = New System.Drawing.Point(348, 79)
        Me.btnSearchAcc.Name = "btnSearchAcc"
        Me.btnSearchAcc.Size = New System.Drawing.Size(22, 20)
        Me.btnSearchAcc.TabIndex = 6
        Me.btnSearchAcc.TabStop = False
        Me.btnSearchAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchAcc.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(420, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Opening Debit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(420, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Opening Credit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(420, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Opening Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(18, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Acc Nature"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(18, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Acc Type"
        Me.Label2.Visible = False
        '
        'txtAccLevel
        '
        Me.txtAccLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccLevel.Location = New System.Drawing.Point(168, 19)
        Me.txtAccLevel.Name = "txtAccLevel"
        Me.txtAccLevel.Size = New System.Drawing.Size(32, 22)
        Me.txtAccLevel.TabIndex = 2
        Me.txtAccLevel.Visible = False
        '
        'txtOpeningCredit
        '
        Me.txtOpeningCredit.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtOpeningCredit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpeningCredit.DoubleValue = 0.0R
        Me.txtOpeningCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtOpeningCredit.Location = New System.Drawing.Point(526, 239)
        Me.txtOpeningCredit.Name = "txtOpeningCredit"
        Me.txtOpeningCredit.Size = New System.Drawing.Size(125, 22)
        Me.txtOpeningCredit.TabIndex = 48
        Me.txtOpeningCredit.Text = "0.00"
        Me.txtOpeningCredit.ThemeName = "Default"
        '
        'cboAccNature
        '
        Me.cboAccNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboAccNature.FormattingEnabled = True
        Me.cboAccNature.Items.AddRange(New Object() {"(--Select--)", "Asset", "Liability", "Equity", "Revenue", "Expense"})
        Me.cboAccNature.Location = New System.Drawing.Point(121, 455)
        Me.cboAccNature.Name = "cboAccNature"
        Me.cboAccNature.Size = New System.Drawing.Size(250, 24)
        Me.cboAccNature.TabIndex = 28
        Me.cboAccNature.Visible = False
        '
        'txtOpeningDebit
        '
        Me.txtOpeningDebit.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtOpeningDebit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpeningDebit.DoubleValue = 0.0R
        Me.txtOpeningDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtOpeningDebit.Location = New System.Drawing.Point(526, 211)
        Me.txtOpeningDebit.Name = "txtOpeningDebit"
        Me.txtOpeningDebit.Size = New System.Drawing.Size(125, 22)
        Me.txtOpeningDebit.TabIndex = 45
        Me.txtOpeningDebit.Text = "0.00"
        Me.txtOpeningDebit.ThemeName = "Default"
        '
        'dtpOpeningDate
        '
        Me.dtpOpeningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpOpeningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOpeningDate.Location = New System.Drawing.Point(526, 267)
        Me.dtpOpeningDate.Name = "dtpOpeningDate"
        Me.dtpOpeningDate.Size = New System.Drawing.Size(125, 22)
        Me.dtpOpeningDate.TabIndex = 51
        '
        'cboAccType
        '
        Me.cboAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboAccType.FormattingEnabled = True
        Me.cboAccType.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Employee", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense", "Vehicle"})
        Me.cboAccType.Location = New System.Drawing.Point(121, 425)
        Me.cboAccType.Name = "cboAccType"
        Me.cboAccType.Size = New System.Drawing.Size(250, 24)
        Me.cboAccType.TabIndex = 26
        Me.cboAccType.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtId.Location = New System.Drawing.Point(122, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(40, 22)
        Me.txtId.TabIndex = 1
        Me.txtId.TabStop = False
        Me.txtId.Visible = False
        '
        'txtAccCode
        '
        Me.txtAccCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccCode.Location = New System.Drawing.Point(121, 78)
        Me.txtAccCode.Name = "txtAccCode"
        Me.txtAccCode.ReadOnly = True
        Me.txtAccCode.Size = New System.Drawing.Size(250, 22)
        Me.txtAccCode.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(18, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Acc Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(18, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Acc Title"
        '
        'txtAccName
        '
        Me.txtAccName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccName.Location = New System.Drawing.Point(121, 106)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(250, 22)
        Me.txtAccName.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(716, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Logged User : "
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(835, 19)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(114, 19)
        Me.txtUser.TabIndex = 5
        Me.txtUser.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbList, Me.btnSave, Me.btnDelete, Me.btnRefresh, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(980, 46)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "Payment Voucher"
        '
        'tsbList
        '
        Me.tsbList.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.tsbList.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbList.Name = "tsbList"
        Me.tsbList.Size = New System.Drawing.Size(61, 43)
        Me.tsbList.Text = "Show List"
        Me.tsbList.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Logitech.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 43)
        Me.btnSave.Text = "&Save [Ctl +S]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Logitech.My.Resources.Resources.Delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(44, 43)
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Logitech.My.Resources.Resources.Reload
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(73, 43)
        Me.btnRefresh.Text = "Refres&h [F5]"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Logitech.My.Resources.Resources.Close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(58, 43)
        Me.btnClose.Text = "E&xit [Esc]"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtThisLevel, Me.UnderSelected, Me.ToolStripSeparator1, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 76)
        '
        'AtThisLevel
        '
        Me.AtThisLevel.Name = "AtThisLevel"
        Me.AtThisLevel.Size = New System.Drawing.Size(153, 22)
        Me.AtThisLevel.Text = "At this Level"
        Me.AtThisLevel.ToolTipText = "Insert Account At this Level"
        '
        'UnderSelected
        '
        Me.UnderSelected.Name = "UnderSelected"
        Me.UnderSelected.Size = New System.Drawing.Size(153, 22)
        Me.UnderSelected.Text = "Under Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(150, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "Go_Forward_48px.png")
        Me.imgList.Images.SetKeyName(1, "Go_Back_48px.png")
        '
        'frmAccountsSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Panel15)
        Me.KeyPreview = True
        Me.Name = "frmAccountsSimple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        CType(Me.txtInvoiceGraceDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpeningCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpeningDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents picPanelExtender As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAccCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AtThisLevel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnderSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOpeningCredit As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents cboAccNature As System.Windows.Forms.ComboBox
    Friend WithEvents txtOpeningDebit As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents dtpOpeningDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboAccType As System.Windows.Forms.ComboBox
    Friend WithEvents txtAccLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSearchAcc As System.Windows.Forms.Button
    Friend WithEvents chkIsAccount As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtLandline As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtNTN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddAccType As System.Windows.Forms.Button
    Friend WithEvents txtCreditDays As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtCreditLimit As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cboParentAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceGraceDays As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents tsbList As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
End Class
