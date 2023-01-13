<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleReceiving
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicleReceiving))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSearchStatus = New System.Windows.Forms.ComboBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.dgvVehicleActivity = New System.Windows.Forms.DataGridView()
        Me.dgvVehicleActivityIssueId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicleActivityIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicleActivityEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicleActivityShift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboVehicle = New System.Windows.Forms.ComboBox()
        Me.dgvDriverActivity = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCloseRemarks = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpCloseDate = New System.Windows.Forms.DateTimePicker()
        Me.cboDriver = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbList = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSearchText = New Logitech.TextBoxHint()
        Me.dgvDriverActivityIssueId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityVehicle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityShift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityReceive = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        CType(Me.dgvVehicleActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDriverActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1234, 15)
        Me.Panel15.TabIndex = 1
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
        Me.SplitContainer.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer.Panel1.Controls.Add(Me.cboSearchStatus)
        Me.SplitContainer.Panel1.Controls.Add(Me.dgvList)
        Me.SplitContainer.Panel1.Controls.Add(Me.picPanelExtender)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer.Panel1.Controls.Add(Me.txtSearchText)
        Me.SplitContainer.Panel1Collapsed = True
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
        Me.SplitContainer.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(5, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Status"
        '
        'cboSearchStatus
        '
        Me.cboSearchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchStatus.FormattingEnabled = True
        Me.cboSearchStatus.Items.AddRange(New Object() {"Closed", "Active", "All"})
        Me.cboSearchStatus.Location = New System.Drawing.Point(61, 43)
        Me.cboSearchStatus.Name = "cboSearchStatus"
        Me.cboSearchStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboSearchStatus.TabIndex = 2
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
        Me.dgvList.Location = New System.Drawing.Point(8, 96)
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
        Me.dgvList.Size = New System.Drawing.Size(231, 559)
        Me.dgvList.TabIndex = 4
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
        Me.pnlContainer.Controls.Add(Me.dgvVehicleActivity)
        Me.pnlContainer.Controls.Add(Me.cboVehicle)
        Me.pnlContainer.Controls.Add(Me.dgvDriverActivity)
        Me.pnlContainer.Controls.Add(Me.Label21)
        Me.pnlContainer.Controls.Add(Me.Label30)
        Me.pnlContainer.Controls.Add(Me.Label31)
        Me.pnlContainer.Controls.Add(Me.txtCloseRemarks)
        Me.pnlContainer.Controls.Add(Me.Label22)
        Me.pnlContainer.Controls.Add(Me.dtpCloseDate)
        Me.pnlContainer.Controls.Add(Me.cboDriver)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Location = New System.Drawing.Point(7, 49)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1215, 606)
        Me.pnlContainer.TabIndex = 0
        '
        'dgvVehicleActivity
        '
        Me.dgvVehicleActivity.AllowUserToAddRows = False
        Me.dgvVehicleActivity.AllowUserToDeleteRows = False
        Me.dgvVehicleActivity.AllowUserToResizeColumns = False
        Me.dgvVehicleActivity.AllowUserToResizeRows = False
        Me.dgvVehicleActivity.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvVehicleActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVehicleActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVehicleActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVehicleActivity.ColumnHeadersHeight = 30
        Me.dgvVehicleActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVehicleActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvVehicleActivityIssueId, Me.dgvVehicleActivityIssueDate, Me.dgvVehicleActivityEmployee, Me.dgvVehicleActivityShift})
        Me.dgvVehicleActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvVehicleActivity.EnableHeadersVisualStyles = False
        Me.dgvVehicleActivity.GridColor = System.Drawing.SystemColors.Control
        Me.dgvVehicleActivity.Location = New System.Drawing.Point(124, 409)
        Me.dgvVehicleActivity.MultiSelect = False
        Me.dgvVehicleActivity.Name = "dgvVehicleActivity"
        Me.dgvVehicleActivity.ReadOnly = True
        Me.dgvVehicleActivity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVehicleActivity.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvVehicleActivity.RowHeadersVisible = False
        Me.dgvVehicleActivity.RowHeadersWidth = 40
        Me.dgvVehicleActivity.Size = New System.Drawing.Size(380, 120)
        Me.dgvVehicleActivity.TabIndex = 3
        Me.dgvVehicleActivity.Visible = False
        '
        'dgvVehicleActivityIssueId
        '
        Me.dgvVehicleActivityIssueId.HeaderText = "IssueId"
        Me.dgvVehicleActivityIssueId.Name = "dgvVehicleActivityIssueId"
        Me.dgvVehicleActivityIssueId.ReadOnly = True
        '
        'dgvVehicleActivityIssueDate
        '
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dgvVehicleActivityIssueDate.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVehicleActivityIssueDate.HeaderText = "Issue Date"
        Me.dgvVehicleActivityIssueDate.Name = "dgvVehicleActivityIssueDate"
        Me.dgvVehicleActivityIssueDate.ReadOnly = True
        Me.dgvVehicleActivityIssueDate.Width = 120
        '
        'dgvVehicleActivityEmployee
        '
        Me.dgvVehicleActivityEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvVehicleActivityEmployee.HeaderText = "Driver"
        Me.dgvVehicleActivityEmployee.Name = "dgvVehicleActivityEmployee"
        Me.dgvVehicleActivityEmployee.ReadOnly = True
        '
        'dgvVehicleActivityShift
        '
        Me.dgvVehicleActivityShift.HeaderText = "Shift"
        Me.dgvVehicleActivityShift.Name = "dgvVehicleActivityShift"
        Me.dgvVehicleActivityShift.ReadOnly = True
        Me.dgvVehicleActivityShift.Width = 80
        '
        'cboVehicle
        '
        Me.cboVehicle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVehicle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboVehicle.FormattingEnabled = True
        Me.cboVehicle.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboVehicle.Location = New System.Drawing.Point(124, 379)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(250, 24)
        Me.cboVehicle.TabIndex = 9
        Me.cboVehicle.Visible = False
        '
        'dgvDriverActivity
        '
        Me.dgvDriverActivity.AllowUserToAddRows = False
        Me.dgvDriverActivity.AllowUserToDeleteRows = False
        Me.dgvDriverActivity.AllowUserToResizeColumns = False
        Me.dgvDriverActivity.AllowUserToResizeRows = False
        Me.dgvDriverActivity.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvDriverActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDriverActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDriverActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDriverActivity.ColumnHeadersHeight = 30
        Me.dgvDriverActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDriverActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvDriverActivityIssueId, Me.dgvDriverActivityIssueDate, Me.dgvDriverActivityVehicle, Me.dgvDriverActivityShift, Me.dgvDriverActivityReceive})
        Me.dgvDriverActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDriverActivity.EnableHeadersVisualStyles = False
        Me.dgvDriverActivity.GridColor = System.Drawing.SystemColors.Control
        Me.dgvDriverActivity.Location = New System.Drawing.Point(124, 224)
        Me.dgvDriverActivity.MultiSelect = False
        Me.dgvDriverActivity.Name = "dgvDriverActivity"
        Me.dgvDriverActivity.ReadOnly = True
        Me.dgvDriverActivity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDriverActivity.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDriverActivity.RowHeadersVisible = False
        Me.dgvDriverActivity.RowHeadersWidth = 40
        Me.dgvDriverActivity.Size = New System.Drawing.Size(480, 120)
        Me.dgvDriverActivity.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(21, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 16)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Remarks"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label30.Location = New System.Drawing.Point(21, 198)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 16)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Driver"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(21, 383)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 16)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Vehicle"
        Me.Label31.Visible = False
        '
        'txtCloseRemarks
        '
        Me.txtCloseRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCloseRemarks.Location = New System.Drawing.Point(124, 75)
        Me.txtCloseRemarks.Multiline = True
        Me.txtCloseRemarks.Name = "txtCloseRemarks"
        Me.txtCloseRemarks.Size = New System.Drawing.Size(250, 60)
        Me.txtCloseRemarks.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(21, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 16)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Receiving Date"
        '
        'dtpCloseDate
        '
        Me.dtpCloseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpCloseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCloseDate.Location = New System.Drawing.Point(124, 47)
        Me.dtpCloseDate.Name = "dtpCloseDate"
        Me.dtpCloseDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpCloseDate.TabIndex = 3
        '
        'cboDriver
        '
        Me.cboDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboDriver.FormattingEnabled = True
        Me.cboDriver.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboDriver.Location = New System.Drawing.Point(124, 194)
        Me.cboDriver.Name = "cboDriver"
        Me.cboDriver.Size = New System.Drawing.Size(250, 24)
        Me.cboDriver.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detail"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(970, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Logged User : "
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(1089, 19)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(114, 19)
        Me.txtUser.TabIndex = 3
        Me.txtUser.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbList, Me.btnSave, Me.btnRefresh, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1234, 46)
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
        Me.tsbList.Visible = False
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
        Me.btnSave.Visible = False
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
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "Go_Forward_48px.png")
        Me.imgList.Images.SetKeyName(1, "Go_Back_48px.png")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Advance ERP"
        '
        'txtSearchText
        '
        Me.txtSearchText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSearchText.HintDetails.HintFadeSpeed = 0
        Me.txtSearchText.HintDetails.HintText = "Type Here to Search"
        Me.txtSearchText.Location = New System.Drawing.Point(8, 70)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(231, 20)
        Me.txtSearchText.TabIndex = 3
        '
        'dgvDriverActivityIssueId
        '
        Me.dgvDriverActivityIssueId.HeaderText = "IssueId"
        Me.dgvDriverActivityIssueId.Name = "dgvDriverActivityIssueId"
        Me.dgvDriverActivityIssueId.ReadOnly = True
        '
        'dgvDriverActivityIssueDate
        '
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.dgvDriverActivityIssueDate.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDriverActivityIssueDate.HeaderText = "Issue Date"
        Me.dgvDriverActivityIssueDate.Name = "dgvDriverActivityIssueDate"
        Me.dgvDriverActivityIssueDate.ReadOnly = True
        Me.dgvDriverActivityIssueDate.Width = 120
        '
        'dgvDriverActivityVehicle
        '
        Me.dgvDriverActivityVehicle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvDriverActivityVehicle.HeaderText = "Vehicle"
        Me.dgvDriverActivityVehicle.Name = "dgvDriverActivityVehicle"
        Me.dgvDriverActivityVehicle.ReadOnly = True
        '
        'dgvDriverActivityShift
        '
        Me.dgvDriverActivityShift.HeaderText = "Shift"
        Me.dgvDriverActivityShift.Name = "dgvDriverActivityShift"
        Me.dgvDriverActivityShift.ReadOnly = True
        Me.dgvDriverActivityShift.Width = 80
        '
        'dgvDriverActivityReceive
        '
        Me.dgvDriverActivityReceive.HeaderText = "Return"
        Me.dgvDriverActivityReceive.Name = "dgvDriverActivityReceive"
        Me.dgvDriverActivityReceive.ReadOnly = True
        Me.dgvDriverActivityReceive.Text = "Return"
        Me.dgvDriverActivityReceive.UseColumnTextForButtonValue = True
        '
        'frmVehicleReceiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.ControlBox = false
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Panel15)
        Me.KeyPreview = true
        Me.Name = "frmVehicleReceiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving Form"
        Me.SplitContainer.Panel1.ResumeLayout(false)
        Me.SplitContainer.Panel1.PerformLayout
        Me.SplitContainer.Panel2.ResumeLayout(false)
        Me.SplitContainer.Panel2.PerformLayout
        CType(Me.SplitContainer,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer.ResumeLayout(false)
        CType(Me.dgvList,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picPanelExtender,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlContainer.ResumeLayout(false)
        Me.pnlContainer.PerformLayout
        CType(Me.dgvVehicleActivity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvDriverActivity,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents picPanelExtender As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpCloseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tsbList As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCloseRemarks As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSearchStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dgvVehicleActivity As System.Windows.Forms.DataGridView
    Friend WithEvents dgvVehicleActivityIssueId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityEmployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityShift As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivity As System.Windows.Forms.DataGridView
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboDriver As System.Windows.Forms.ComboBox
    Friend WithEvents cboVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDriverActivityIssueId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityVehicle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityShift As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityReceive As System.Windows.Forms.DataGridViewButtonColumn
End Class
