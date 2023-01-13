<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicles))
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.txtSearchText = New Logitech.TextBoxHint()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpRenewDate = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnVehicleModel = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cboVehicleMake = New System.Windows.Forms.ComboBox()
        Me.txtModelYear = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.btnAddVehicleMake = New System.Windows.Forms.Button()
        Me.txtVehicleNumber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpRegistrationDate = New System.Windows.Forms.DateTimePicker()
        Me.cboVehicleModel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtChasisNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEngineNumber = New System.Windows.Forms.TextBox()
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
        Me.txtGLAccCode = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        CType(Me.txtModelYear, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlContainer.Controls.Add(Me.txtGLAccCode)
        Me.pnlContainer.Controls.Add(Me.Label6)
        Me.pnlContainer.Controls.Add(Me.Label5)
        Me.pnlContainer.Controls.Add(Me.Label4)
        Me.pnlContainer.Controls.Add(Me.Label21)
        Me.pnlContainer.Controls.Add(Me.Label20)
        Me.pnlContainer.Controls.Add(Me.dtpExpiryDate)
        Me.pnlContainer.Controls.Add(Me.Label18)
        Me.pnlContainer.Controls.Add(Me.dtpRenewDate)
        Me.pnlContainer.Controls.Add(Me.Label33)
        Me.pnlContainer.Controls.Add(Me.Label30)
        Me.pnlContainer.Controls.Add(Me.btnVehicleModel)
        Me.pnlContainer.Controls.Add(Me.Label31)
        Me.pnlContainer.Controls.Add(Me.cboVehicleMake)
        Me.pnlContainer.Controls.Add(Me.txtModelYear)
        Me.pnlContainer.Controls.Add(Me.btnAddVehicleMake)
        Me.pnlContainer.Controls.Add(Me.txtVehicleNumber)
        Me.pnlContainer.Controls.Add(Me.Label15)
        Me.pnlContainer.Controls.Add(Me.Label22)
        Me.pnlContainer.Controls.Add(Me.dtpRegistrationDate)
        Me.pnlContainer.Controls.Add(Me.cboVehicleModel)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.txtId)
        Me.pnlContainer.Controls.Add(Me.txtChasisNumber)
        Me.pnlContainer.Controls.Add(Me.Label7)
        Me.pnlContainer.Controls.Add(Me.Label12)
        Me.pnlContainer.Controls.Add(Me.txtEngineNumber)
        Me.pnlContainer.Location = New System.Drawing.Point(7, 49)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(961, 606)
        Me.pnlContainer.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(380, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "* Required"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(380, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "* Required"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(380, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "* Required"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(21, 138)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 16)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Vehicle #"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(21, 325)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 16)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Expiry Date"
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpiryDate.Location = New System.Drawing.Point(124, 322)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpExpiryDate.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(21, 297)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Renew Date"
        '
        'dtpRenewDate
        '
        Me.dtpRenewDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpRenewDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRenewDate.Location = New System.Drawing.Point(124, 294)
        Me.dtpRenewDate.Name = "dtpRenewDate"
        Me.dtpRenewDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpRenewDate.TabIndex = 25
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label33.Location = New System.Drawing.Point(21, 110)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(37, 16)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Year"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label30.Location = New System.Drawing.Point(21, 81)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 16)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Model"
        '
        'btnVehicleModel
        '
        Me.btnVehicleModel.BackgroundImage = CType(resources.GetObject("btnVehicleModel.BackgroundImage"), System.Drawing.Image)
        Me.btnVehicleModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVehicleModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehicleModel.Location = New System.Drawing.Point(514, 73)
        Me.btnVehicleModel.Name = "btnVehicleModel"
        Me.btnVehicleModel.Size = New System.Drawing.Size(24, 24)
        Me.btnVehicleModel.TabIndex = 9
        Me.btnVehicleModel.TabStop = False
        Me.btnVehicleModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVehicleModel.UseVisualStyleBackColor = True
        Me.btnVehicleModel.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(21, 53)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Make"
        '
        'cboVehicleMake
        '
        Me.cboVehicleMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboVehicleMake.FormattingEnabled = True
        Me.cboVehicleMake.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboVehicleMake.Location = New System.Drawing.Point(124, 49)
        Me.cboVehicleMake.Name = "cboVehicleMake"
        Me.cboVehicleMake.Size = New System.Drawing.Size(250, 24)
        Me.cboVehicleMake.TabIndex = 3
        '
        'txtModelYear
        '
        Me.txtModelYear.BeforeTouchSize = New System.Drawing.Size(200, 22)
        Me.txtModelYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtModelYear.DoubleValue = 2015.0R
        Me.txtModelYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtModelYear.Location = New System.Drawing.Point(124, 107)
        Me.txtModelYear.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txtModelYear.Name = "txtModelYear"
        Me.txtModelYear.NumberDecimalDigits = 0
        Me.txtModelYear.NumberGroupSeparator = ""
        Me.txtModelYear.Size = New System.Drawing.Size(125, 22)
        Me.txtModelYear.TabIndex = 11
        Me.txtModelYear.Text = "2015"
        Me.txtModelYear.ThemeName = "Default"
        '
        'btnAddVehicleMake
        '
        Me.btnAddVehicleMake.BackgroundImage = CType(resources.GetObject("btnAddVehicleMake.BackgroundImage"), System.Drawing.Image)
        Me.btnAddVehicleMake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddVehicleMake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddVehicleMake.Location = New System.Drawing.Point(514, 45)
        Me.btnAddVehicleMake.Name = "btnAddVehicleMake"
        Me.btnAddVehicleMake.Size = New System.Drawing.Size(24, 24)
        Me.btnAddVehicleMake.TabIndex = 5
        Me.btnAddVehicleMake.TabStop = False
        Me.btnAddVehicleMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddVehicleMake.UseVisualStyleBackColor = True
        Me.btnAddVehicleMake.Visible = False
        '
        'txtVehicleNumber
        '
        Me.txtVehicleNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtVehicleNumber.Location = New System.Drawing.Point(124, 135)
        Me.txtVehicleNumber.Name = "txtVehicleNumber"
        Me.txtVehicleNumber.Size = New System.Drawing.Size(250, 22)
        Me.txtVehicleNumber.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(18, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Registration"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(21, 269)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 16)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Register Date"
        '
        'dtpRegistrationDate
        '
        Me.dtpRegistrationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegistrationDate.Location = New System.Drawing.Point(124, 266)
        Me.dtpRegistrationDate.Name = "dtpRegistrationDate"
        Me.dtpRegistrationDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpRegistrationDate.TabIndex = 23
        '
        'cboVehicleModel
        '
        Me.cboVehicleModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboVehicleModel.FormattingEnabled = True
        Me.cboVehicleModel.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboVehicleModel.Location = New System.Drawing.Point(124, 77)
        Me.cboVehicleModel.Name = "cboVehicleModel"
        Me.cboVehicleModel.Size = New System.Drawing.Size(250, 24)
        Me.cboVehicleModel.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtId.Location = New System.Drawing.Point(124, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(40, 22)
        Me.txtId.TabIndex = 1
        Me.txtId.TabStop = False
        Me.txtId.Visible = False
        '
        'txtChasisNumber
        '
        Me.txtChasisNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtChasisNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtChasisNumber.Location = New System.Drawing.Point(124, 163)
        Me.txtChasisNumber.Name = "txtChasisNumber"
        Me.txtChasisNumber.Size = New System.Drawing.Size(250, 22)
        Me.txtChasisNumber.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(21, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Chasis #"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(21, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Engine #"
        '
        'txtEngineNumber
        '
        Me.txtEngineNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEngineNumber.Location = New System.Drawing.Point(124, 191)
        Me.txtEngineNumber.Name = "txtEngineNumber"
        Me.txtEngineNumber.Size = New System.Drawing.Size(250, 22)
        Me.txtEngineNumber.TabIndex = 19
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
        'txtGLAccCode
        '
        Me.txtGLAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtGLAccCode.Location = New System.Drawing.Point(209, 19)
        Me.txtGLAccCode.Name = "txtGLAccCode"
        Me.txtGLAccCode.Size = New System.Drawing.Size(40, 22)
        Me.txtGLAccCode.TabIndex = 66
        Me.txtGLAccCode.TabStop = False
        Me.txtGLAccCode.Visible = False
        '
        'frmVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Panel15)
        Me.KeyPreview = True
        Me.Name = "frmVehicles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicles"
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
        CType(Me.txtModelYear, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtEngineNumber As System.Windows.Forms.TextBox
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
    Friend WithEvents dtpRegistrationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboVehicleModel As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnAddVehicleMake As System.Windows.Forms.Button
    Friend WithEvents txtModelYear As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cboVehicleMake As System.Windows.Forms.ComboBox
    Friend WithEvents tsbList As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents txtChasisNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnVehicleModel As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpRenewDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVehicleNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtGLAccCode As System.Windows.Forms.TextBox
End Class
