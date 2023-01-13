<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleIssuance
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicleIssuance))
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSearchStatus = New System.Windows.Forms.ComboBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvVehicleActivity = New System.Windows.Forms.DataGridView()
        Me.dgvVehicleActivityIssueId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicleActivityIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicleActivityEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVehicleActivityShift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDriverActivity = New System.Windows.Forms.DataGridView()
        Me.dgvDriverActivityIssueId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityVehicle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDriverActivityShift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboVehicle = New System.Windows.Forms.ComboBox()
        Me.txtDetailAttachmentRowIndex = New System.Windows.Forms.TextBox()
        Me.btnAddAttachment = New System.Windows.Forms.Button()
        Me.btnLoadPictureAttachment = New System.Windows.Forms.Button()
        Me.chkIsDefaultImageAttachment = New System.Windows.Forms.CheckBox()
        Me.AttachmentPicture = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDetailAttachmentName = New System.Windows.Forms.TextBox()
        Me.dgvAttachments = New System.Windows.Forms.DataGridView()
        Me.AttachmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ViewAttachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EditAttachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteAttachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboShift = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRentPerDay = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.cboDriver = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbList = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSearchText = New Logitech.TextBoxHint()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvVehicleActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDriverActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttachmentPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRentPerDay, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cboSearchStatus.Items.AddRange(New Object() {"All", "Active", "Closed"})
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
        Me.pnlContainer.Controls.Add(Me.Panel1)
        Me.pnlContainer.Controls.Add(Me.Label10)
        Me.pnlContainer.Controls.Add(Me.cboVehicle)
        Me.pnlContainer.Controls.Add(Me.txtDetailAttachmentRowIndex)
        Me.pnlContainer.Controls.Add(Me.btnAddAttachment)
        Me.pnlContainer.Controls.Add(Me.btnLoadPictureAttachment)
        Me.pnlContainer.Controls.Add(Me.chkIsDefaultImageAttachment)
        Me.pnlContainer.Controls.Add(Me.AttachmentPicture)
        Me.pnlContainer.Controls.Add(Me.Label18)
        Me.pnlContainer.Controls.Add(Me.txtDetailAttachmentName)
        Me.pnlContainer.Controls.Add(Me.dgvAttachments)
        Me.pnlContainer.Controls.Add(Me.Label19)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.cboShift)
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Controls.Add(Me.txtRentPerDay)
        Me.pnlContainer.Controls.Add(Me.Label6)
        Me.pnlContainer.Controls.Add(Me.Label5)
        Me.pnlContainer.Controls.Add(Me.Label21)
        Me.pnlContainer.Controls.Add(Me.Label30)
        Me.pnlContainer.Controls.Add(Me.btnAddDriver)
        Me.pnlContainer.Controls.Add(Me.Label31)
        Me.pnlContainer.Controls.Add(Me.btnAddVehicle)
        Me.pnlContainer.Controls.Add(Me.txtRemarks)
        Me.pnlContainer.Controls.Add(Me.Label22)
        Me.pnlContainer.Controls.Add(Me.dtpIssueDate)
        Me.pnlContainer.Controls.Add(Me.cboDriver)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.txtId)
        Me.pnlContainer.Location = New System.Drawing.Point(7, 49)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(961, 606)
        Me.pnlContainer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dgvVehicleActivity)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dgvDriverActivity)
        Me.Panel1.Location = New System.Drawing.Point(534, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 313)
        Me.Panel1.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(5, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Vehicle Activity"
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
        Me.dgvVehicleActivity.Location = New System.Drawing.Point(9, 180)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Driver Activity"
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
        Me.dgvDriverActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvDriverActivityIssueId, Me.dgvDriverActivityIssueDate, Me.dgvDriverActivityVehicle, Me.dgvDriverActivityShift})
        Me.dgvDriverActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDriverActivity.EnableHeadersVisualStyles = False
        Me.dgvDriverActivity.GridColor = System.Drawing.SystemColors.Control
        Me.dgvDriverActivity.Location = New System.Drawing.Point(9, 27)
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
        Me.dgvDriverActivity.Size = New System.Drawing.Size(380, 120)
        Me.dgvDriverActivity.TabIndex = 1
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(530, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 20)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Information"
        '
        'cboVehicle
        '
        Me.cboVehicle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVehicle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboVehicle.FormattingEnabled = True
        Me.cboVehicle.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboVehicle.Location = New System.Drawing.Point(124, 126)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(250, 24)
        Me.cboVehicle.TabIndex = 9
        '
        'txtDetailAttachmentRowIndex
        '
        Me.txtDetailAttachmentRowIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDetailAttachmentRowIndex.Location = New System.Drawing.Point(179, 351)
        Me.txtDetailAttachmentRowIndex.Name = "txtDetailAttachmentRowIndex"
        Me.txtDetailAttachmentRowIndex.Size = New System.Drawing.Size(24, 22)
        Me.txtDetailAttachmentRowIndex.TabIndex = 19
        Me.txtDetailAttachmentRowIndex.TabStop = False
        Me.txtDetailAttachmentRowIndex.Visible = False
        '
        'btnAddAttachment
        '
        Me.btnAddAttachment.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAddAttachment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnAddAttachment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAttachment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddAttachment.Location = New System.Drawing.Point(19, 406)
        Me.btnAddAttachment.Name = "btnAddAttachment"
        Me.btnAddAttachment.Size = New System.Drawing.Size(203, 24)
        Me.btnAddAttachment.TabIndex = 23
        Me.btnAddAttachment.TabStop = False
        Me.btnAddAttachment.Text = "Add Attachment"
        Me.btnAddAttachment.UseVisualStyleBackColor = False
        '
        'btnLoadPictureAttachment
        '
        Me.btnLoadPictureAttachment.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoadPictureAttachment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadPictureAttachment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadPictureAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadPictureAttachment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadPictureAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLoadPictureAttachment.Location = New System.Drawing.Point(228, 406)
        Me.btnLoadPictureAttachment.Name = "btnLoadPictureAttachment"
        Me.btnLoadPictureAttachment.Size = New System.Drawing.Size(70, 24)
        Me.btnLoadPictureAttachment.TabIndex = 24
        Me.btnLoadPictureAttachment.TabStop = False
        Me.btnLoadPictureAttachment.Text = "Browse"
        Me.btnLoadPictureAttachment.UseVisualStyleBackColor = False
        '
        'chkIsDefaultImageAttachment
        '
        Me.chkIsDefaultImageAttachment.AutoSize = True
        Me.chkIsDefaultImageAttachment.Location = New System.Drawing.Point(206, 355)
        Me.chkIsDefaultImageAttachment.Name = "chkIsDefaultImageAttachment"
        Me.chkIsDefaultImageAttachment.Size = New System.Drawing.Size(92, 17)
        Me.chkIsDefaultImageAttachment.TabIndex = 20
        Me.chkIsDefaultImageAttachment.Text = "Default Image"
        Me.chkIsDefaultImageAttachment.UseVisualStyleBackColor = True
        Me.chkIsDefaultImageAttachment.Visible = False
        '
        'AttachmentPicture
        '
        Me.AttachmentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AttachmentPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AttachmentPicture.Image = Global.Logitech.My.Resources.Resources.DefaultImage
        Me.AttachmentPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AttachmentPicture.Location = New System.Drawing.Point(304, 340)
        Me.AttachmentPicture.Name = "AttachmentPicture"
        Me.AttachmentPicture.Size = New System.Drawing.Size(100, 90)
        Me.AttachmentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AttachmentPicture.TabIndex = 78
        Me.AttachmentPicture.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(16, 382)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 16)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Description"
        '
        'txtDetailAttachmentName
        '
        Me.txtDetailAttachmentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDetailAttachmentName.Location = New System.Drawing.Point(98, 378)
        Me.txtDetailAttachmentName.Name = "txtDetailAttachmentName"
        Me.txtDetailAttachmentName.Size = New System.Drawing.Size(200, 22)
        Me.txtDetailAttachmentName.TabIndex = 22
        '
        'dgvAttachments
        '
        Me.dgvAttachments.AllowUserToAddRows = False
        Me.dgvAttachments.AllowUserToResizeColumns = False
        Me.dgvAttachments.AllowUserToResizeRows = False
        Me.dgvAttachments.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttachments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttachments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvAttachments.ColumnHeadersHeight = 30
        Me.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAttachments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttachmentId, Me.AttachmentName, Me.AttachmentImage, Me.ViewAttachment, Me.EditAttachment, Me.DeleteAttachment})
        Me.dgvAttachments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAttachments.EnableHeadersVisualStyles = False
        Me.dgvAttachments.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAttachments.Location = New System.Drawing.Point(19, 438)
        Me.dgvAttachments.MultiSelect = False
        Me.dgvAttachments.Name = "dgvAttachments"
        Me.dgvAttachments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttachments.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvAttachments.RowHeadersVisible = False
        Me.dgvAttachments.RowHeadersWidth = 40
        Me.dgvAttachments.Size = New System.Drawing.Size(385, 150)
        Me.dgvAttachments.TabIndex = 25
        '
        'AttachmentId
        '
        Me.AttachmentId.HeaderText = "AttachmentId"
        Me.AttachmentId.Name = "AttachmentId"
        Me.AttachmentId.Visible = False
        Me.AttachmentId.Width = 60
        '
        'AttachmentName
        '
        Me.AttachmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AttachmentName.HeaderText = "Description"
        Me.AttachmentName.Name = "AttachmentName"
        Me.AttachmentName.ReadOnly = True
        '
        'AttachmentImage
        '
        Me.AttachmentImage.HeaderText = "Image"
        Me.AttachmentImage.Image = Global.Logitech.My.Resources.Resources.DefaultImage
        Me.AttachmentImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.AttachmentImage.Name = "AttachmentImage"
        Me.AttachmentImage.Visible = False
        '
        'ViewAttachment
        '
        Me.ViewAttachment.HeaderText = "View"
        Me.ViewAttachment.Name = "ViewAttachment"
        Me.ViewAttachment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewAttachment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ViewAttachment.Text = "View"
        Me.ViewAttachment.UseColumnTextForButtonValue = True
        Me.ViewAttachment.Width = 65
        '
        'EditAttachment
        '
        Me.EditAttachment.HeaderText = "Edit"
        Me.EditAttachment.Name = "EditAttachment"
        Me.EditAttachment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditAttachment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EditAttachment.Text = "Edit"
        Me.EditAttachment.UseColumnTextForButtonValue = True
        Me.EditAttachment.Width = 65
        '
        'DeleteAttachment
        '
        Me.DeleteAttachment.HeaderText = "Delete"
        Me.DeleteAttachment.Name = "DeleteAttachment"
        Me.DeleteAttachment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeleteAttachment.Text = "Delete"
        Me.DeleteAttachment.UseColumnTextForButtonValue = True
        Me.DeleteAttachment.Width = 65
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(15, 351)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 20)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Extra Attachments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(21, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Shift"
        '
        'cboShift
        '
        Me.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboShift.FormattingEnabled = True
        Me.cboShift.Items.AddRange(New Object() {"(--Select--)", "24 Hours", "Day", "Night"})
        Me.cboShift.Location = New System.Drawing.Point(124, 182)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.Size = New System.Drawing.Size(250, 24)
        Me.cboShift.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(21, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Rent Per Day"
        '
        'txtRentPerDay
        '
        Me.txtRentPerDay.BeforeTouchSize = New System.Drawing.Size(126, 22)
        Me.txtRentPerDay.DoubleValue = 0.0R
        Me.txtRentPerDay.Location = New System.Drawing.Point(124, 156)
        Me.txtRentPerDay.Name = "txtRentPerDay"
        Me.txtRentPerDay.Size = New System.Drawing.Size(115, 20)
        Me.txtRentPerDay.TabIndex = 13
        Me.txtRentPerDay.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(410, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "* Required"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(410, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "* Required"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(21, 213)
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
        Me.Label30.Location = New System.Drawing.Point(21, 100)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 16)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Driver"
        '
        'btnAddDriver
        '
        Me.btnAddDriver.BackgroundImage = CType(resources.GetObject("btnAddDriver.BackgroundImage"), System.Drawing.Image)
        Me.btnAddDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDriver.Location = New System.Drawing.Point(380, 96)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(24, 24)
        Me.btnAddDriver.TabIndex = 6
        Me.btnAddDriver.TabStop = False
        Me.btnAddDriver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(21, 130)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 16)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Vehicle"
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.BackgroundImage = CType(resources.GetObject("btnAddVehicle.BackgroundImage"), System.Drawing.Image)
        Me.btnAddVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddVehicle.Location = New System.Drawing.Point(380, 126)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(24, 24)
        Me.btnAddVehicle.TabIndex = 10
        Me.btnAddVehicle.TabStop = False
        Me.btnAddVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtRemarks.Location = New System.Drawing.Point(124, 212)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(250, 60)
        Me.txtRemarks.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(21, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 16)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Register Date"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIssueDate.Location = New System.Drawing.Point(124, 47)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpIssueDate.TabIndex = 3
        '
        'cboDriver
        '
        Me.cboDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboDriver.FormattingEnabled = True
        Me.cboDriver.Items.AddRange(New Object() {"(--Select--)", "Asset", "Customer", "Cash", "Bank", "Liability", "Supplier", "Equity", "Revenue", "Expense"})
        Me.cboDriver.Location = New System.Drawing.Point(124, 96)
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
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(716, 18)
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
        Me.txtUser.Location = New System.Drawing.Point(835, 19)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbList, Me.btnSave, Me.btnDelete, Me.btnRefresh, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(980, 46)
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
        'frmVehicleIssuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Panel15)
        Me.KeyPreview = True
        Me.Name = "frmVehicleIssuance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issuance Form"
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvVehicleActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDriverActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttachmentPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRentPerDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDriver As System.Windows.Forms.ComboBox
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tsbList As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents btnAddDriver As System.Windows.Forms.Button
    Friend WithEvents btnAddVehicle As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRentPerDay As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboShift As System.Windows.Forms.ComboBox
    Friend WithEvents txtDetailAttachmentRowIndex As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAttachment As System.Windows.Forms.Button
    Friend WithEvents btnLoadPictureAttachment As System.Windows.Forms.Button
    Friend WithEvents chkIsDefaultImageAttachment As System.Windows.Forms.CheckBox
    Friend WithEvents AttachmentPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDetailAttachmentName As System.Windows.Forms.TextBox
    Friend WithEvents dgvAttachments As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSearchStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvDriverActivity As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvVehicleActivity As System.Windows.Forms.DataGridView
    Friend WithEvents AttachmentId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttachmentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttachmentImage As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ViewAttachment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents EditAttachment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DeleteAttachment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvDriverActivityIssueId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityVehicle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDriverActivityShift As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityIssueId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityEmployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvVehicleActivityShift As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
