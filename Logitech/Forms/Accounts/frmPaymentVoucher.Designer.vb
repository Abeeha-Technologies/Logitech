<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentVoucher))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbList = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnPreview = New System.Windows.Forms.ToolStripButton()
        Me.btnApproveToggle = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkIsApproved = New System.Windows.Forms.CheckBox()
        Me.pnlAccountSearch = New System.Windows.Forms.Panel()
        Me.lblAddNewAccount = New System.Windows.Forms.LinkLabel()
        Me.dgvAccountSearch = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDetailOrderRowIndex = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAccCodeDetail = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalAmount = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.nudVoucherNumber = New System.Windows.Forms.NumericUpDown()
        Me.txtVoucherId = New System.Windows.Forms.TextBox()
        Me.dtpVoucherDate = New System.Windows.Forms.DateTimePicker()
        Me.cboVoucherType = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAccBalanceDetail = New System.Windows.Forms.TextBox()
        Me.btnPin = New System.Windows.Forms.Button()
        Me.btnSearchAccDetail = New System.Windows.Forms.Button()
        Me.txtDescriptionDetail = New System.Windows.Forms.TextBox()
        Me.txtAccTitleDetail = New System.Windows.Forms.TextBox()
        Me.txtAmountDetail = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.AccCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIsEdit = New System.Windows.Forms.TextBox()
        Me.txtAccCodeMaster = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChequeNumber = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtAccBalanceMaster = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchAccMaster = New System.Windows.Forms.Button()
        Me.txtAccTitleMaster = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboVoucherTypeSearch = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlTopDivider = New System.Windows.Forms.Panel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.txtSearchText = New Logitech.TextBoxHint()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkPreview = New System.Windows.Forms.CheckBox()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlAccountSearch.SuspendLayout()
        CType(Me.dgvAccountSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtTotalAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudVoucherNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtAmountDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbList, Me.btnSave, Me.btnPreview, Me.btnDelete, Me.btnRefresh, Me.btnApproveToggle, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(930, 46)
        Me.ToolStrip1.TabIndex = 1
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
        'btnPreview
        '
        Me.btnPreview.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(52, 43)
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnApproveToggle
        '
        Me.btnApproveToggle.Image = Global.Logitech.My.Resources.Resources.Png_CircleGreen_24px
        Me.btnApproveToggle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnApproveToggle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApproveToggle.Name = "btnApproveToggle"
        Me.btnApproveToggle.Size = New System.Drawing.Size(56, 43)
        Me.btnApproveToggle.Text = "&Approve"
        Me.btnApproveToggle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnApproveToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(911, 515)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.chkIsApproved)
        Me.TabPage1.Controls.Add(Me.pnlAccountSearch)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtIsEdit)
        Me.TabPage1.Controls.Add(Me.txtAccCodeMaster)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(903, 484)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkIsApproved
        '
        Me.chkIsApproved.AutoSize = True
        Me.chkIsApproved.Location = New System.Drawing.Point(518, 38)
        Me.chkIsApproved.Name = "chkIsApproved"
        Me.chkIsApproved.Size = New System.Drawing.Size(83, 17)
        Me.chkIsApproved.TabIndex = 85
        Me.chkIsApproved.Text = "Is Approved"
        Me.chkIsApproved.UseVisualStyleBackColor = True
        Me.chkIsApproved.Visible = False
        '
        'pnlAccountSearch
        '
        Me.pnlAccountSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccountSearch.Controls.Add(Me.lblAddNewAccount)
        Me.pnlAccountSearch.Controls.Add(Me.dgvAccountSearch)
        Me.pnlAccountSearch.Location = New System.Drawing.Point(620, 33)
        Me.pnlAccountSearch.Name = "pnlAccountSearch"
        Me.pnlAccountSearch.Size = New System.Drawing.Size(175, 72)
        Me.pnlAccountSearch.TabIndex = 82
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
        Me.lblAddNewAccount.Location = New System.Drawing.Point(6, 44)
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
        Me.dgvAccountSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccountSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgvAccountSearch.Name = "dgvAccountSearch"
        Me.dgvAccountSearch.ReadOnly = True
        Me.dgvAccountSearch.RowHeadersVisible = False
        Me.dgvAccountSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccountSearch.Size = New System.Drawing.Size(173, 35)
        Me.dgvAccountSearch.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.txtDetailOrderRowIndex)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.txtAccCodeDetail)
        Me.Panel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(4, 130)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(831, 25)
        Me.Panel7.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Balance"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Paid To"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(728, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Amount"
        '
        'txtDetailOrderRowIndex
        '
        Me.txtDetailOrderRowIndex.Location = New System.Drawing.Point(643, 3)
        Me.txtDetailOrderRowIndex.Name = "txtDetailOrderRowIndex"
        Me.txtDetailOrderRowIndex.Size = New System.Drawing.Size(25, 20)
        Me.txtDetailOrderRowIndex.TabIndex = 10
        Me.txtDetailOrderRowIndex.TabStop = False
        Me.txtDetailOrderRowIndex.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(379, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Description"
        '
        'txtAccCodeDetail
        '
        Me.txtAccCodeDetail.Location = New System.Drawing.Point(165, 2)
        Me.txtAccCodeDetail.Name = "txtAccCodeDetail"
        Me.txtAccCodeDetail.Size = New System.Drawing.Size(90, 20)
        Me.txtAccCodeDetail.TabIndex = 1
        Me.txtAccCodeDetail.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.txtTotalAmount)
        Me.Panel3.Controls.Add(Me.lblResult)
        Me.Panel3.Location = New System.Drawing.Point(3, 439)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(888, 27)
        Me.Panel3.TabIndex = 83
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BeforeTouchSize = New System.Drawing.Size(100, 22)
        Me.txtTotalAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalAmount.DoubleValue = 0.0R
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAmount.Location = New System.Drawing.Point(731, 6)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.ReadOnlyBackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 15)
        Me.txtTotalAmount.TabIndex = 43
        Me.txtTotalAmount.Text = "0.00"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalAmount.ThemeName = "Default"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblResult.Location = New System.Drawing.Point(-1, 4)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(733, 19)
        Me.lblResult.TabIndex = 22
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(3, 113)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(183, 13)
        Me.Label31.TabIndex = 81
        Me.Label31.Text = "Double Click on Record to Edit"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.nudVoucherNumber)
        Me.Panel1.Controls.Add(Me.txtVoucherId)
        Me.Panel1.Controls.Add(Me.dtpVoucherDate)
        Me.Panel1.Controls.Add(Me.cboVoucherType)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(701, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(192, 110)
        Me.Panel1.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vr Type"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(2, 89)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Date"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(2, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Voucher Id"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(2, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Voucher #"
        '
        'nudVoucherNumber
        '
        Me.nudVoucherNumber.Location = New System.Drawing.Point(77, 33)
        Me.nudVoucherNumber.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudVoucherNumber.Name = "nudVoucherNumber"
        Me.nudVoucherNumber.Size = New System.Drawing.Size(110, 20)
        Me.nudVoucherNumber.TabIndex = 2
        '
        'txtVoucherId
        '
        Me.txtVoucherId.BackColor = System.Drawing.SystemColors.Window
        Me.txtVoucherId.Location = New System.Drawing.Point(77, 59)
        Me.txtVoucherId.Name = "txtVoucherId"
        Me.txtVoucherId.ReadOnly = True
        Me.txtVoucherId.Size = New System.Drawing.Size(110, 20)
        Me.txtVoucherId.TabIndex = 3
        '
        'dtpVoucherDate
        '
        Me.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVoucherDate.Location = New System.Drawing.Point(77, 85)
        Me.dtpVoucherDate.Name = "dtpVoucherDate"
        Me.dtpVoucherDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpVoucherDate.TabIndex = 5
        '
        'cboVoucherType
        '
        Me.cboVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVoucherType.FormattingEnabled = True
        Me.cboVoucherType.Items.AddRange(New Object() {"CPV", "BPV"})
        Me.cboVoucherType.Location = New System.Drawing.Point(77, 6)
        Me.cboVoucherType.Name = "cboVoucherType"
        Me.cboVoucherType.Size = New System.Drawing.Size(110, 21)
        Me.cboVoucherType.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoScroll = True
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtAccBalanceDetail)
        Me.Panel4.Controls.Add(Me.btnPin)
        Me.Panel4.Controls.Add(Me.btnSearchAccDetail)
        Me.Panel4.Controls.Add(Me.txtDescriptionDetail)
        Me.Panel4.Controls.Add(Me.txtAccTitleDetail)
        Me.Panel4.Controls.Add(Me.txtAmountDetail)
        Me.Panel4.Controls.Add(Me.dgvTransactions)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(3, 129)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(890, 300)
        Me.Panel4.TabIndex = 40
        '
        'txtAccBalanceDetail
        '
        Me.txtAccBalanceDetail.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccBalanceDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccBalanceDetail.Location = New System.Drawing.Point(281, 25)
        Me.txtAccBalanceDetail.Name = "txtAccBalanceDetail"
        Me.txtAccBalanceDetail.ReadOnly = True
        Me.txtAccBalanceDetail.Size = New System.Drawing.Size(100, 22)
        Me.txtAccBalanceDetail.TabIndex = 5
        Me.txtAccBalanceDetail.TabStop = False
        '
        'btnPin
        '
        Me.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPin.Image = CType(resources.GetObject("btnPin.Image"), System.Drawing.Image)
        Me.btnPin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPin.Location = New System.Drawing.Point(832, 23)
        Me.btnPin.Name = "btnPin"
        Me.btnPin.Size = New System.Drawing.Size(30, 24)
        Me.btnPin.TabIndex = 11
        Me.btnPin.TabStop = False
        Me.btnPin.UseVisualStyleBackColor = False
        '
        'btnSearchAccDetail
        '
        Me.btnSearchAccDetail.BackgroundImage = Global.Logitech.My.Resources.Resources.Search
        Me.btnSearchAccDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchAccDetail.Location = New System.Drawing.Point(260, 26)
        Me.btnSearchAccDetail.Name = "btnSearchAccDetail"
        Me.btnSearchAccDetail.Size = New System.Drawing.Size(20, 20)
        Me.btnSearchAccDetail.TabIndex = 2
        Me.btnSearchAccDetail.TabStop = False
        Me.btnSearchAccDetail.UseVisualStyleBackColor = True
        '
        'txtDescriptionDetail
        '
        Me.txtDescriptionDetail.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescriptionDetail.Location = New System.Drawing.Point(381, 25)
        Me.txtDescriptionDetail.Name = "txtDescriptionDetail"
        Me.txtDescriptionDetail.Size = New System.Drawing.Size(350, 22)
        Me.txtDescriptionDetail.TabIndex = 7
        Me.txtDescriptionDetail.TabStop = False
        '
        'txtAccTitleDetail
        '
        Me.txtAccTitleDetail.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccTitleDetail.Location = New System.Drawing.Point(0, 25)
        Me.txtAccTitleDetail.Name = "txtAccTitleDetail"
        Me.txtAccTitleDetail.Size = New System.Drawing.Size(281, 22)
        Me.txtAccTitleDetail.TabIndex = 4
        '
        'txtAmountDetail
        '
        Me.txtAmountDetail.BeforeTouchSize = New System.Drawing.Size(100, 22)
        Me.txtAmountDetail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountDetail.DoubleValue = 0.0R
        Me.txtAmountDetail.Location = New System.Drawing.Point(731, 25)
        Me.txtAmountDetail.Name = "txtAmountDetail"
        Me.txtAmountDetail.Size = New System.Drawing.Size(100, 22)
        Me.txtAmountDetail.TabIndex = 9
        Me.txtAmountDetail.Text = "0.00"
        Me.txtAmountDetail.ThemeName = "Default"
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToResizeRows = False
        Me.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.ColumnHeadersVisible = False
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccCode, Me.AccTitle, Me.Description, Me.Amount, Me.DetailId})
        Me.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvTransactions.Location = New System.Drawing.Point(0, 47)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.RowTemplate.Height = 24
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactions.Size = New System.Drawing.Size(888, 251)
        Me.dgvTransactions.TabIndex = 12
        '
        'AccCode
        '
        DataGridViewCellStyle2.Format = "00-00-00-000"
        Me.AccCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccCode.HeaderText = "Acc Code"
        Me.AccCode.Name = "AccCode"
        Me.AccCode.ReadOnly = True
        Me.AccCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccCode.Width = 80
        '
        'AccTitle
        '
        Me.AccTitle.HeaderText = "Acc Name"
        Me.AccTitle.Name = "AccTitle"
        Me.AccTitle.ReadOnly = True
        Me.AccTitle.Width = 300
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 350
        '
        'Amount
        '
        Me.Amount.HeaderText = "Debit"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'DetailId
        '
        Me.DetailId.HeaderText = "DetailId"
        Me.DetailId.Name = "DetailId"
        Me.DetailId.ReadOnly = True
        Me.DetailId.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(461, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Is Edit"
        Me.Label15.Visible = False
        '
        'txtIsEdit
        '
        Me.txtIsEdit.Location = New System.Drawing.Point(506, 96)
        Me.txtIsEdit.Name = "txtIsEdit"
        Me.txtIsEdit.Size = New System.Drawing.Size(63, 20)
        Me.txtIsEdit.TabIndex = 28
        Me.txtIsEdit.Visible = False
        '
        'txtAccCodeMaster
        '
        Me.txtAccCodeMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAccCodeMaster.Location = New System.Drawing.Point(506, 10)
        Me.txtAccCodeMaster.Name = "txtAccCodeMaster"
        Me.txtAccCodeMaster.Size = New System.Drawing.Size(130, 20)
        Me.txtAccCodeMaster.TabIndex = 7
        Me.txtAccCodeMaster.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtChequeNumber)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Controls.Add(Me.txtAccBalanceMaster)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSearchAccMaster)
        Me.Panel2.Controls.Add(Me.txtAccTitleMaster)
        Me.Panel2.Location = New System.Drawing.Point(3, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 58)
        Me.Panel2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Chq #"
        '
        'txtChequeNumber
        '
        Me.txtChequeNumber.Location = New System.Drawing.Point(387, 31)
        Me.txtChequeNumber.Name = "txtChequeNumber"
        Me.txtChequeNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeNumber.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(79, 32)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(250, 20)
        Me.txtDescription.TabIndex = 12
        '
        'txtAccBalanceMaster
        '
        Me.txtAccBalanceMaster.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccBalanceMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAccBalanceMaster.Location = New System.Drawing.Point(387, 5)
        Me.txtAccBalanceMaster.Name = "txtAccBalanceMaster"
        Me.txtAccBalanceMaster.ReadOnly = True
        Me.txtAccBalanceMaster.Size = New System.Drawing.Size(100, 20)
        Me.txtAccBalanceMaster.TabIndex = 10
        Me.txtAccBalanceMaster.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Description"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(-696, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Paid From"
        '
        'btnSearchAccMaster
        '
        Me.btnSearchAccMaster.BackgroundImage = Global.Logitech.My.Resources.Resources.Search
        Me.btnSearchAccMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchAccMaster.Location = New System.Drawing.Point(308, 7)
        Me.btnSearchAccMaster.Name = "btnSearchAccMaster"
        Me.btnSearchAccMaster.Size = New System.Drawing.Size(20, 18)
        Me.btnSearchAccMaster.TabIndex = 8
        Me.btnSearchAccMaster.TabStop = False
        Me.btnSearchAccMaster.UseVisualStyleBackColor = True
        '
        'txtAccTitleMaster
        '
        Me.txtAccTitleMaster.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccTitleMaster.Location = New System.Drawing.Point(79, 6)
        Me.txtAccTitleMaster.Name = "txtAccTitleMaster"
        Me.txtAccTitleMaster.Size = New System.Drawing.Size(250, 20)
        Me.txtAccTitleMaster.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Date From"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(103, 63)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(109, 20)
        Me.dtpDateFrom.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Date To"
        '
        'cboVoucherTypeSearch
        '
        Me.cboVoucherTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVoucherTypeSearch.FormattingEnabled = True
        Me.cboVoucherTypeSearch.Items.AddRange(New Object() {"CPV", "BPV"})
        Me.cboVoucherTypeSearch.Location = New System.Drawing.Point(103, 36)
        Me.cboVoucherTypeSearch.Name = "cboVoucherTypeSearch"
        Me.cboVoucherTypeSearch.Size = New System.Drawing.Size(109, 21)
        Me.cboVoucherTypeSearch.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Voucher Type"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(103, 89)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(109, 20)
        Me.dtpDateTo.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(758, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(114, 19)
        Me.txtUser.TabIndex = 26
        Me.txtUser.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(639, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Logged User : "
        '
        'pnlTopDivider
        '
        Me.pnlTopDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlTopDivider.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopDivider.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopDivider.Name = "pnlTopDivider"
        Me.pnlTopDivider.Size = New System.Drawing.Size(1184, 15)
        Me.pnlTopDivider.TabIndex = 27
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
        Me.SplitContainer.Panel1.Controls.Add(Me.picPanelExtender)
        Me.SplitContainer.Panel1.Controls.Add(Me.txtSearchText)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer.Panel1.Controls.Add(Me.dtpDateTo)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer.Panel1.Controls.Add(Me.dtpDateFrom)
        Me.SplitContainer.Panel1.Controls.Add(Me.cboVoucherTypeSearch)
        Me.SplitContainer.Panel1MinSize = 250
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.chkPreview)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtUser)
        Me.SplitContainer.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer.Size = New System.Drawing.Size(1184, 576)
        Me.SplitContainer.SplitterDistance = 250
        Me.SplitContainer.TabIndex = 29
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvList.ColumnHeadersHeight = 40
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvList.Location = New System.Drawing.Point(12, 140)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.dgvList.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(227, 424)
        Me.dgvList.TabIndex = 43
        Me.dgvList.TabStop = False
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
        Me.picPanelExtender.TabIndex = 42
        Me.picPanelExtender.TabStop = False
        '
        'txtSearchText
        '
        Me.txtSearchText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSearchText.HintDetails.HintText = "Type Here to Search"
        Me.txtSearchText.Location = New System.Drawing.Point(12, 114)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(227, 20)
        Me.txtSearchText.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'chkPreview
        '
        Me.chkPreview.AutoSize = True
        Me.chkPreview.Location = New System.Drawing.Point(425, 16)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.Size = New System.Drawing.Size(128, 17)
        Me.chkPreview.TabIndex = 28
        Me.chkPreview.TabStop = False
        Me.chkPreview.Text = "Preview Voucher [F9]"
        Me.chkPreview.UseVisualStyleBackColor = True
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "Go_Forward_48px.png")
        Me.imgList.Images.SetKeyName(1, "Go_Back_48px.png")
        '
        'frmPaymentVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 591)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.pnlTopDivider)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPaymentVoucher"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Voucher"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlAccountSearch.ResumeLayout(False)
        Me.pnlAccountSearch.PerformLayout()
        CType(Me.dgvAccountSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtTotalAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudVoucherNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txtAmountDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dtpVoucherDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboVoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents txtVoucherId As System.Windows.Forms.TextBox
    Friend WithEvents txtAccCodeMaster As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchAccMaster As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtAccBalanceMaster As System.Windows.Forms.TextBox
    Friend WithEvents txtAccTitleMaster As System.Windows.Forms.TextBox
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIsEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboVoucherTypeSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSearchAccDetail As System.Windows.Forms.Button
    Friend WithEvents txtAmountDetail As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtAccCodeDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDetailOrderRowIndex As System.Windows.Forms.TextBox
    Friend WithEvents btnPin As System.Windows.Forms.Button
    Friend WithEvents txtAccTitleDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtDescriptionDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtAccBalanceDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents pnlTopDivider As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picPanelExtender As System.Windows.Forms.PictureBox
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents nudVoucherNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents pnlAccountSearch As System.Windows.Forms.Panel
    Friend WithEvents lblAddNewAccount As System.Windows.Forms.LinkLabel
    Friend WithEvents dgvAccountSearch As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkPreview As System.Windows.Forms.CheckBox
    Friend WithEvents AccCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnApproveToggle As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkIsApproved As System.Windows.Forms.CheckBox
    Friend WithEvents tsbList As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
End Class
