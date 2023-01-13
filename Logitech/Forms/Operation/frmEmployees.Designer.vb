<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.txtSearchText = New Logitech.TextBoxHint()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.txtGLAccCode = New System.Windows.Forms.TextBox()
        Me.txtDetailAttachmentRowIndex = New System.Windows.Forms.TextBox()
        Me.btnAddAttachment = New System.Windows.Forms.Button()
        Me.btnLoadPictureAttachment = New System.Windows.Forms.Button()
        Me.chkIsDefaultImageAttachment = New System.Windows.Forms.CheckBox()
        Me.AttachmentPicture = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDetailAttachmentName = New System.Windows.Forms.TextBox()
        Me.dgvAttachments = New System.Windows.Forms.DataGridView()
        Me.AttachmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ViewAttachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EditAttachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteAttachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpJoiningDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.dtpIdExpiry = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIBAN = New System.Windows.Forms.TextBox()
        Me.txtEmployeeIdNumber = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnZoomPicture = New System.Windows.Forms.Button()
        Me.ProfilePicture = New System.Windows.Forms.PictureBox()
        Me.chkIsSameImage = New System.Windows.Forms.CheckBox()
        Me.chkIsDefaultImage = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnClearProductPicture = New System.Windows.Forms.Button()
        Me.btnLoadPicture = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpPassportExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPasssportNumber = New System.Windows.Forms.TextBox()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        CType(Me.AttachmentPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployeeIdNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel15.TabIndex = 0
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
        Me.SplitContainer.TabIndex = 1
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
        Me.dgvList.TabIndex = 2
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
        Me.txtSearchText.TabIndex = 1
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
        Me.pnlContainer.Controls.Add(Me.txtDetailAttachmentRowIndex)
        Me.pnlContainer.Controls.Add(Me.btnAddAttachment)
        Me.pnlContainer.Controls.Add(Me.btnLoadPictureAttachment)
        Me.pnlContainer.Controls.Add(Me.chkIsDefaultImageAttachment)
        Me.pnlContainer.Controls.Add(Me.AttachmentPicture)
        Me.pnlContainer.Controls.Add(Me.Label17)
        Me.pnlContainer.Controls.Add(Me.txtDetailAttachmentName)
        Me.pnlContainer.Controls.Add(Me.dgvAttachments)
        Me.pnlContainer.Controls.Add(Me.Label16)
        Me.pnlContainer.Controls.Add(Me.Label14)
        Me.pnlContainer.Controls.Add(Me.dtpJoiningDate)
        Me.pnlContainer.Controls.Add(Me.Label11)
        Me.pnlContainer.Controls.Add(Me.Label12)
        Me.pnlContainer.Controls.Add(Me.txtDesignation)
        Me.pnlContainer.Controls.Add(Me.Label7)
        Me.pnlContainer.Controls.Add(Me.txtContactNumber)
        Me.pnlContainer.Controls.Add(Me.dtpIdExpiry)
        Me.pnlContainer.Controls.Add(Me.Label4)
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.txtIBAN)
        Me.pnlContainer.Controls.Add(Me.txtEmployeeIdNumber)
        Me.pnlContainer.Controls.Add(Me.dtpDateOfBirth)
        Me.pnlContainer.Controls.Add(Me.Label10)
        Me.pnlContainer.Controls.Add(Me.btnZoomPicture)
        Me.pnlContainer.Controls.Add(Me.ProfilePicture)
        Me.pnlContainer.Controls.Add(Me.chkIsSameImage)
        Me.pnlContainer.Controls.Add(Me.chkIsDefaultImage)
        Me.pnlContainer.Controls.Add(Me.Label19)
        Me.pnlContainer.Controls.Add(Me.btnClearProductPicture)
        Me.pnlContainer.Controls.Add(Me.btnLoadPicture)
        Me.pnlContainer.Controls.Add(Me.Label9)
        Me.pnlContainer.Controls.Add(Me.Label6)
        Me.pnlContainer.Controls.Add(Me.Label5)
        Me.pnlContainer.Controls.Add(Me.Label20)
        Me.pnlContainer.Controls.Add(Me.dtpPassportExpiryDate)
        Me.pnlContainer.Controls.Add(Me.Label33)
        Me.pnlContainer.Controls.Add(Me.Label30)
        Me.pnlContainer.Controls.Add(Me.Label31)
        Me.pnlContainer.Controls.Add(Me.txtEmployeeName)
        Me.pnlContainer.Controls.Add(Me.Label15)
        Me.pnlContainer.Controls.Add(Me.cboNationality)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.txtId)
        Me.pnlContainer.Controls.Add(Me.txtPasssportNumber)
        Me.pnlContainer.Location = New System.Drawing.Point(7, 49)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(961, 606)
        Me.pnlContainer.TabIndex = 1
        '
        'txtGLAccCode
        '
        Me.txtGLAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtGLAccCode.Location = New System.Drawing.Point(218, 19)
        Me.txtGLAccCode.Name = "txtGLAccCode"
        Me.txtGLAccCode.Size = New System.Drawing.Size(40, 22)
        Me.txtGLAccCode.TabIndex = 65
        Me.txtGLAccCode.TabStop = False
        Me.txtGLAccCode.Visible = False
        '
        'txtDetailAttachmentRowIndex
        '
        Me.txtDetailAttachmentRowIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDetailAttachmentRowIndex.Location = New System.Drawing.Point(686, 294)
        Me.txtDetailAttachmentRowIndex.Name = "txtDetailAttachmentRowIndex"
        Me.txtDetailAttachmentRowIndex.Size = New System.Drawing.Size(24, 22)
        Me.txtDetailAttachmentRowIndex.TabIndex = 64
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
        Me.btnAddAttachment.Location = New System.Drawing.Point(526, 349)
        Me.btnAddAttachment.Name = "btnAddAttachment"
        Me.btnAddAttachment.Size = New System.Drawing.Size(203, 24)
        Me.btnAddAttachment.TabIndex = 63
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
        Me.btnLoadPictureAttachment.Location = New System.Drawing.Point(735, 349)
        Me.btnLoadPictureAttachment.Name = "btnLoadPictureAttachment"
        Me.btnLoadPictureAttachment.Size = New System.Drawing.Size(70, 24)
        Me.btnLoadPictureAttachment.TabIndex = 62
        Me.btnLoadPictureAttachment.TabStop = False
        Me.btnLoadPictureAttachment.Text = "Browse"
        Me.btnLoadPictureAttachment.UseVisualStyleBackColor = False
        '
        'chkIsDefaultImageAttachment
        '
        Me.chkIsDefaultImageAttachment.AutoSize = True
        Me.chkIsDefaultImageAttachment.Location = New System.Drawing.Point(713, 298)
        Me.chkIsDefaultImageAttachment.Name = "chkIsDefaultImageAttachment"
        Me.chkIsDefaultImageAttachment.Size = New System.Drawing.Size(92, 17)
        Me.chkIsDefaultImageAttachment.TabIndex = 61
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
        Me.AttachmentPicture.Location = New System.Drawing.Point(811, 283)
        Me.AttachmentPicture.Name = "AttachmentPicture"
        Me.AttachmentPicture.Size = New System.Drawing.Size(100, 90)
        Me.AttachmentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AttachmentPicture.TabIndex = 60
        Me.AttachmentPicture.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(523, 325)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 16)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Description"
        '
        'txtDetailAttachmentName
        '
        Me.txtDetailAttachmentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDetailAttachmentName.Location = New System.Drawing.Point(605, 321)
        Me.txtDetailAttachmentName.Name = "txtDetailAttachmentName"
        Me.txtDetailAttachmentName.Size = New System.Drawing.Size(200, 22)
        Me.txtDetailAttachmentName.TabIndex = 59
        '
        'dgvAttachments
        '
        Me.dgvAttachments.AllowUserToAddRows = False
        Me.dgvAttachments.AllowUserToResizeColumns = False
        Me.dgvAttachments.AllowUserToResizeRows = False
        Me.dgvAttachments.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttachments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttachments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAttachments.ColumnHeadersHeight = 30
        Me.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAttachments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttachmentId, Me.AttachmentName, Me.AttachmentImage, Me.ViewAttachment, Me.EditAttachment, Me.DeleteAttachment})
        Me.dgvAttachments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAttachments.EnableHeadersVisualStyles = False
        Me.dgvAttachments.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAttachments.Location = New System.Drawing.Point(526, 381)
        Me.dgvAttachments.MultiSelect = False
        Me.dgvAttachments.Name = "dgvAttachments"
        Me.dgvAttachments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttachments.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAttachments.RowHeadersVisible = False
        Me.dgvAttachments.RowHeadersWidth = 40
        Me.dgvAttachments.Size = New System.Drawing.Size(385, 150)
        Me.dgvAttachments.TabIndex = 57
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
        Me.AttachmentName.HeaderText = "Description"
        Me.AttachmentName.Name = "AttachmentName"
        Me.AttachmentName.ReadOnly = True
        Me.AttachmentName.Width = 160
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(522, 294)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 20)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Extra Attachments"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(23, 484)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Joining Date"
        '
        'dtpJoiningDate
        '
        Me.dtpJoiningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpJoiningDate.Location = New System.Drawing.Point(126, 481)
        Me.dtpJoiningDate.Name = "dtpJoiningDate"
        Me.dtpJoiningDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpJoiningDate.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(23, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Designation"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(20, 427)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Job Detail"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDesignation.Location = New System.Drawing.Point(126, 453)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(276, 22)
        Me.txtDesignation.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(21, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contact #"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtContactNumber.Location = New System.Drawing.Point(124, 162)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(150, 22)
        Me.txtContactNumber.TabIndex = 13
        '
        'dtpIdExpiry
        '
        Me.dtpIdExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpIdExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIdExpiry.Location = New System.Drawing.Point(124, 106)
        Me.dtpIdExpiry.Name = "dtpIdExpiry"
        Me.dtpIdExpiry.Size = New System.Drawing.Size(150, 22)
        Me.dtpIdExpiry.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(21, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Id Expiry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(21, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "IBAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Bank Account Details"
        '
        'txtIBAN
        '
        Me.txtIBAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIBAN.Location = New System.Drawing.Point(124, 378)
        Me.txtIBAN.Name = "txtIBAN"
        Me.txtIBAN.Size = New System.Drawing.Size(278, 22)
        Me.txtIBAN.TabIndex = 23
        '
        'txtEmployeeIdNumber
        '
        Me.txtEmployeeIdNumber.BeforeTouchSize = New System.Drawing.Size(200, 22)
        Me.txtEmployeeIdNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeIdNumber.DoubleValue = 0.0R
        Me.txtEmployeeIdNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEmployeeIdNumber.Location = New System.Drawing.Point(124, 78)
        Me.txtEmployeeIdNumber.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txtEmployeeIdNumber.Name = "txtEmployeeIdNumber"
        Me.txtEmployeeIdNumber.NumberDecimalDigits = 0
        Me.txtEmployeeIdNumber.NumberGroupSeparator = ""
        Me.txtEmployeeIdNumber.Size = New System.Drawing.Size(200, 22)
        Me.txtEmployeeIdNumber.TabIndex = 6
        Me.txtEmployeeIdNumber.Text = "0"
        Me.txtEmployeeIdNumber.ThemeName = "Default"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(124, 134)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(150, 22)
        Me.dtpDateOfBirth.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(21, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Id #"
        '
        'btnZoomPicture
        '
        Me.btnZoomPicture.BackColor = System.Drawing.Color.White
        Me.btnZoomPicture.BackgroundImage = Global.Logitech.My.Resources.Resources.Zoom_24px
        Me.btnZoomPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnZoomPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZoomPicture.FlatAppearance.BorderSize = 0
        Me.btnZoomPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomPicture.Location = New System.Drawing.Point(727, 48)
        Me.btnZoomPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.btnZoomPicture.Name = "btnZoomPicture"
        Me.btnZoomPicture.Size = New System.Drawing.Size(26, 26)
        Me.btnZoomPicture.TabIndex = 30
        Me.btnZoomPicture.TabStop = False
        Me.btnZoomPicture.UseVisualStyleBackColor = False
        '
        'ProfilePicture
        '
        Me.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfilePicture.Image = Global.Logitech.My.Resources.Resources.DefaultImage
        Me.ProfilePicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProfilePicture.Location = New System.Drawing.Point(526, 48)
        Me.ProfilePicture.Name = "ProfilePicture"
        Me.ProfilePicture.Size = New System.Drawing.Size(200, 180)
        Me.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePicture.TabIndex = 55
        Me.ProfilePicture.TabStop = False
        '
        'chkIsSameImage
        '
        Me.chkIsSameImage.AutoSize = True
        Me.chkIsSameImage.Location = New System.Drawing.Point(732, 137)
        Me.chkIsSameImage.Name = "chkIsSameImage"
        Me.chkIsSameImage.Size = New System.Drawing.Size(85, 17)
        Me.chkIsSameImage.TabIndex = 34
        Me.chkIsSameImage.Text = "Same Image"
        Me.chkIsSameImage.UseVisualStyleBackColor = True
        Me.chkIsSameImage.Visible = False
        '
        'chkIsDefaultImage
        '
        Me.chkIsDefaultImage.AutoSize = True
        Me.chkIsDefaultImage.Location = New System.Drawing.Point(732, 111)
        Me.chkIsDefaultImage.Name = "chkIsDefaultImage"
        Me.chkIsDefaultImage.Size = New System.Drawing.Size(92, 17)
        Me.chkIsDefaultImage.TabIndex = 33
        Me.chkIsDefaultImage.Text = "Default Image"
        Me.chkIsDefaultImage.UseVisualStyleBackColor = True
        Me.chkIsDefaultImage.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(522, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 20)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Picture"
        '
        'btnClearProductPicture
        '
        Me.btnClearProductPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearProductPicture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearProductPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearProductPicture.Location = New System.Drawing.Point(636, 234)
        Me.btnClearProductPicture.Name = "btnClearProductPicture"
        Me.btnClearProductPicture.Size = New System.Drawing.Size(74, 24)
        Me.btnClearProductPicture.TabIndex = 32
        Me.btnClearProductPicture.TabStop = False
        Me.btnClearProductPicture.Text = "Clear"
        Me.btnClearProductPicture.UseVisualStyleBackColor = True
        '
        'btnLoadPicture
        '
        Me.btnLoadPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoadPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLoadPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadPicture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLoadPicture.Location = New System.Drawing.Point(560, 234)
        Me.btnLoadPicture.Name = "btnLoadPicture"
        Me.btnLoadPicture.Size = New System.Drawing.Size(70, 24)
        Me.btnLoadPicture.TabIndex = 31
        Me.btnLoadPicture.TabStop = False
        Me.btnLoadPicture.Text = "Browse"
        Me.btnLoadPicture.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(21, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Passsport  #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(330, 53)
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
        Me.Label5.Location = New System.Drawing.Point(330, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "* Required"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(21, 265)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 16)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Expiry Date"
        '
        'dtpPassportExpiryDate
        '
        Me.dtpPassportExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpPassportExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPassportExpiryDate.Location = New System.Drawing.Point(124, 262)
        Me.dtpPassportExpiryDate.Name = "dtpPassportExpiryDate"
        Me.dtpPassportExpiryDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpPassportExpiryDate.TabIndex = 18
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label33.Location = New System.Drawing.Point(21, 137)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 16)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Date of Birth"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label30.Location = New System.Drawing.Point(21, 294)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(71, 16)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "Nationality"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(21, 53)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Name"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEmployeeName.Location = New System.Drawing.Point(124, 50)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(200, 22)
        Me.txtEmployeeName.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(18, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Identity"
        '
        'cboNationality
        '
        Me.cboNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Items.AddRange(New Object() {"--(Select)--", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Côte d'Ivoire", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo (Congo-Brazzaville)", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czechia (Czech Republic)", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini (fmr. ""Swaziland"")", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (formerly Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Palestine State", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States of America", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.cboNationality.Location = New System.Drawing.Point(124, 290)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(150, 24)
        Me.cboNationality.TabIndex = 20
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
        'txtPasssportNumber
        '
        Me.txtPasssportNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPasssportNumber.Location = New System.Drawing.Point(124, 234)
        Me.txtPasssportNumber.Name = "txtPasssportNumber"
        Me.txtPasssportNumber.Size = New System.Drawing.Size(150, 22)
        Me.txtPasssportNumber.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(716, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 3
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
        Me.txtUser.TabIndex = 0
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
        Me.ToolStrip1.TabIndex = 2
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Advance ERP"
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Panel15)
        Me.KeyPreview = True
        Me.Name = "frmEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
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
        CType(Me.AttachmentPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployeeIdNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPasssportNumber As System.Windows.Forms.TextBox
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
    Friend WithEvents cboNationality As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents tsbList As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpPassportExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkIsSameImage As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsDefaultImage As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnClearProductPicture As System.Windows.Forms.Button
    Friend WithEvents btnLoadPicture As System.Windows.Forms.Button
    Friend WithEvents btnZoomPicture As System.Windows.Forms.Button
    Friend WithEvents ProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtEmployeeIdNumber As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents dtpIdExpiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIBAN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpJoiningDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents dgvAttachments As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents AttachmentPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDetailAttachmentName As System.Windows.Forms.TextBox
    Friend WithEvents chkIsDefaultImageAttachment As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoadPictureAttachment As System.Windows.Forms.Button
    Friend WithEvents btnAddAttachment As System.Windows.Forms.Button
    Friend WithEvents txtDetailAttachmentRowIndex As System.Windows.Forms.TextBox
    Friend WithEvents AttachmentId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttachmentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttachmentImage As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ViewAttachment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents EditAttachment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DeleteAttachment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtGLAccCode As System.Windows.Forms.TextBox
End Class
