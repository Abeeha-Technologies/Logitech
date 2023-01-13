<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountsAdvanced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountsAdvanced))
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditSelected = New System.Windows.Forms.Button()
        Me.btnInsertUnderSelectedLevel = New System.Windows.Forms.Button()
        Me.btnInsertAtSelectedLeve = New System.Windows.Forms.Button()
        Me.btnExpandAll = New System.Windows.Forms.Button()
        Me.btnCollapseAll = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtThisLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picPanelExtender = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.chkIsAccount = New System.Windows.Forms.CheckBox()
        Me.btnSearchAcc = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtParentAccName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParentAccCode = New System.Windows.Forms.TextBox()
        Me.txtAccLevel = New System.Windows.Forms.TextBox()
        Me.cboAccNature = New System.Windows.Forms.ComboBox()
        Me.cboAccType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIsEdit = New System.Windows.Forms.TextBox()
        Me.txtAccCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtLandline = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOpeningCreditFC = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.txtOpeningDebitFC = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCreditDays = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.txtCreditLimit = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtNTN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtOpeningCredit = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.txtOpeningDebit = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.dtpOpeningDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtOpeningCreditFC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpeningDebitFC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpeningCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpeningDebit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 15)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEditSelected)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnInsertUnderSelectedLevel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnInsertAtSelectedLeve)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExpandAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCollapseAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picPanelExtender)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1MinSize = 250
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlContainer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtUser)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 696)
        Me.SplitContainer1.SplitterDistance = 280
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.Logitech.My.Resources.Resources.Pointer_48px
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(11, 662)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.Logitech.My.Resources.Resources.Pointer_48px
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(11, 633)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Logitech.My.Resources.Resources.Pointer_48px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(11, 604)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'btnEditSelected
        '
        Me.btnEditSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditSelected.Location = New System.Drawing.Point(39, 662)
        Me.btnEditSelected.Name = "btnEditSelected"
        Me.btnEditSelected.Size = New System.Drawing.Size(230, 23)
        Me.btnEditSelected.TabIndex = 48
        Me.btnEditSelected.Text = "Edit Selected A/C"
        Me.btnEditSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditSelected.UseVisualStyleBackColor = True
        '
        'btnInsertUnderSelectedLevel
        '
        Me.btnInsertUnderSelectedLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertUnderSelectedLevel.Location = New System.Drawing.Point(39, 604)
        Me.btnInsertUnderSelectedLevel.Name = "btnInsertUnderSelectedLevel"
        Me.btnInsertUnderSelectedLevel.Size = New System.Drawing.Size(230, 23)
        Me.btnInsertUnderSelectedLevel.TabIndex = 47
        Me.btnInsertUnderSelectedLevel.Text = "Insert A/C under Selected Level"
        Me.btnInsertUnderSelectedLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertUnderSelectedLevel.UseVisualStyleBackColor = True
        '
        'btnInsertAtSelectedLeve
        '
        Me.btnInsertAtSelectedLeve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertAtSelectedLeve.Location = New System.Drawing.Point(39, 633)
        Me.btnInsertAtSelectedLeve.Name = "btnInsertAtSelectedLeve"
        Me.btnInsertAtSelectedLeve.Size = New System.Drawing.Size(230, 23)
        Me.btnInsertAtSelectedLeve.TabIndex = 46
        Me.btnInsertAtSelectedLeve.Text = "Insert A/C at Selected Level"
        Me.btnInsertAtSelectedLeve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertAtSelectedLeve.UseVisualStyleBackColor = True
        '
        'btnExpandAll
        '
        Me.btnExpandAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandAll.Location = New System.Drawing.Point(113, 575)
        Me.btnExpandAll.Name = "btnExpandAll"
        Me.btnExpandAll.Size = New System.Drawing.Size(75, 23)
        Me.btnExpandAll.TabIndex = 45
        Me.btnExpandAll.Text = "Expand All"
        Me.btnExpandAll.UseVisualStyleBackColor = True
        '
        'btnCollapseAll
        '
        Me.btnCollapseAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCollapseAll.Location = New System.Drawing.Point(194, 575)
        Me.btnCollapseAll.Name = "btnCollapseAll"
        Me.btnCollapseAll.Size = New System.Drawing.Size(75, 23)
        Me.btnCollapseAll.TabIndex = 44
        Me.btnCollapseAll.Text = "Collapse All"
        Me.btnCollapseAll.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Indent = 19
        Me.TreeView1.Location = New System.Drawing.Point(12, 49)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(257, 520)
        Me.TreeView1.TabIndex = 1
        Me.TreeView1.TabStop = False
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
        'picPanelExtender
        '
        Me.picPanelExtender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPanelExtender.BackgroundImage = Global.Logitech.My.Resources.Resources.Go_Forward_48px
        Me.picPanelExtender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPanelExtender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPanelExtender.ErrorImage = Nothing
        Me.picPanelExtender.Location = New System.Drawing.Point(247, 6)
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
        Me.pnlContainer.Controls.Add(Me.Label30)
        Me.pnlContainer.Controls.Add(Me.Label4)
        Me.pnlContainer.Controls.Add(Me.txtOpeningCreditFC)
        Me.pnlContainer.Controls.Add(Me.txtOpeningDebitFC)
        Me.pnlContainer.Controls.Add(Me.Label5)
        Me.pnlContainer.Controls.Add(Me.Label6)
        Me.pnlContainer.Controls.Add(Me.txtCreditDays)
        Me.pnlContainer.Controls.Add(Me.txtCreditLimit)
        Me.pnlContainer.Controls.Add(Me.Label27)
        Me.pnlContainer.Controls.Add(Me.Label28)
        Me.pnlContainer.Controls.Add(Me.txtGST)
        Me.pnlContainer.Controls.Add(Me.Label29)
        Me.pnlContainer.Controls.Add(Me.txtNTN)
        Me.pnlContainer.Controls.Add(Me.Label9)
        Me.pnlContainer.Controls.Add(Me.txtPostalCode)
        Me.pnlContainer.Controls.Add(Me.Label21)
        Me.pnlContainer.Controls.Add(Me.txtCountry)
        Me.pnlContainer.Controls.Add(Me.Label23)
        Me.pnlContainer.Controls.Add(Me.txtState)
        Me.pnlContainer.Controls.Add(Me.txtAddress2)
        Me.pnlContainer.Controls.Add(Me.Label24)
        Me.pnlContainer.Controls.Add(Me.Label25)
        Me.pnlContainer.Controls.Add(Me.txtCity)
        Me.pnlContainer.Controls.Add(Me.Label26)
        Me.pnlContainer.Controls.Add(Me.txtAddress1)
        Me.pnlContainer.Controls.Add(Me.Label22)
        Me.pnlContainer.Controls.Add(Me.Label33)
        Me.pnlContainer.Controls.Add(Me.Label34)
        Me.pnlContainer.Controls.Add(Me.txtOpeningCredit)
        Me.pnlContainer.Controls.Add(Me.txtOpeningDebit)
        Me.pnlContainer.Controls.Add(Me.dtpOpeningDate)
        Me.pnlContainer.Controls.Add(Me.Label15)
        Me.pnlContainer.Controls.Add(Me.Label17)
        Me.pnlContainer.Controls.Add(Me.txtWebsite)
        Me.pnlContainer.Controls.Add(Me.Label18)
        Me.pnlContainer.Controls.Add(Me.txtFax)
        Me.pnlContainer.Controls.Add(Me.Label19)
        Me.pnlContainer.Controls.Add(Me.txtEmail)
        Me.pnlContainer.Controls.Add(Me.Label20)
        Me.pnlContainer.Controls.Add(Me.txtMobile)
        Me.pnlContainer.Controls.Add(Me.Label31)
        Me.pnlContainer.Controls.Add(Me.txtLandline)
        Me.pnlContainer.Controls.Add(Me.Label32)
        Me.pnlContainer.Controls.Add(Me.txtContactName)
        Me.pnlContainer.Controls.Add(Me.chkIsAccount)
        Me.pnlContainer.Controls.Add(Me.btnSearchAcc)
        Me.pnlContainer.Controls.Add(Me.Label16)
        Me.pnlContainer.Controls.Add(Me.txtParentAccName)
        Me.pnlContainer.Controls.Add(Me.Label14)
        Me.pnlContainer.Controls.Add(Me.Label11)
        Me.pnlContainer.Controls.Add(Me.Label10)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Controls.Add(Me.txtParentAccCode)
        Me.pnlContainer.Controls.Add(Me.txtAccLevel)
        Me.pnlContainer.Controls.Add(Me.cboAccNature)
        Me.pnlContainer.Controls.Add(Me.cboAccType)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Controls.Add(Me.txtIsEdit)
        Me.pnlContainer.Controls.Add(Me.txtAccCode)
        Me.pnlContainer.Controls.Add(Me.Label7)
        Me.pnlContainer.Controls.Add(Me.Label12)
        Me.pnlContainer.Controls.Add(Me.txtAccName)
        Me.pnlContainer.Location = New System.Drawing.Point(7, 49)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(931, 636)
        Me.pnlContainer.TabIndex = 0
        '
        'chkIsAccount
        '
        Me.chkIsAccount.AutoSize = True
        Me.chkIsAccount.Location = New System.Drawing.Point(275, 503)
        Me.chkIsAccount.Name = "chkIsAccount"
        Me.chkIsAccount.Size = New System.Drawing.Size(77, 17)
        Me.chkIsAccount.TabIndex = 52
        Me.chkIsAccount.Text = "Is Account"
        Me.chkIsAccount.UseVisualStyleBackColor = True
        Me.chkIsAccount.Visible = False
        '
        'btnSearchAcc
        '
        Me.btnSearchAcc.BackgroundImage = Global.Logitech.My.Resources.Resources.Search
        Me.btnSearchAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAcc.Location = New System.Drawing.Point(349, 48)
        Me.btnSearchAcc.Name = "btnSearchAcc"
        Me.btnSearchAcc.Size = New System.Drawing.Size(22, 20)
        Me.btnSearchAcc.TabIndex = 3
        Me.btnSearchAcc.TabStop = False
        Me.btnSearchAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchAcc.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(19, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Parent Acc Title"
        '
        'txtParentAccName
        '
        Me.txtParentAccName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtParentAccName.Location = New System.Drawing.Point(122, 103)
        Me.txtParentAccName.Name = "txtParentAccName"
        Me.txtParentAccName.ReadOnly = True
        Me.txtParentAccName.Size = New System.Drawing.Size(250, 22)
        Me.txtParentAccName.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(160, 476)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Acc Level"
        Me.Label14.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(160, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Parent Acc Code"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(160, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Is Edit"
        Me.Label10.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(19, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Acc Nature"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(19, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Acc Type"
        '
        'txtParentAccCode
        '
        Me.txtParentAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtParentAccCode.Location = New System.Drawing.Point(275, 445)
        Me.txtParentAccCode.Name = "txtParentAccCode"
        Me.txtParentAccCode.Size = New System.Drawing.Size(97, 22)
        Me.txtParentAccCode.TabIndex = 50
        Me.txtParentAccCode.Visible = False
        '
        'txtAccLevel
        '
        Me.txtAccLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccLevel.Location = New System.Drawing.Point(275, 473)
        Me.txtAccLevel.Name = "txtAccLevel"
        Me.txtAccLevel.Size = New System.Drawing.Size(97, 22)
        Me.txtAccLevel.TabIndex = 51
        Me.txtAccLevel.Visible = False
        '
        'cboAccNature
        '
        Me.cboAccNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboAccNature.FormattingEnabled = True
        Me.cboAccNature.Items.AddRange(New Object() {"Asset", "Liability", "Equity", "Revenue", "Expense"})
        Me.cboAccNature.Location = New System.Drawing.Point(122, 158)
        Me.cboAccNature.Name = "cboAccNature"
        Me.cboAccNature.Size = New System.Drawing.Size(250, 24)
        Me.cboAccNature.TabIndex = 11
        '
        'cboAccType
        '
        Me.cboAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboAccType.FormattingEnabled = True
        Me.cboAccType.Items.AddRange(New Object() {"General", "Customer", "Supplier", "Cash", "Bank"})
        Me.cboAccType.Location = New System.Drawing.Point(122, 131)
        Me.cboAccType.Name = "cboAccType"
        Me.cboAccType.Size = New System.Drawing.Size(250, 21)
        Me.cboAccType.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic"
        '
        'txtIsEdit
        '
        Me.txtIsEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIsEdit.Location = New System.Drawing.Point(275, 417)
        Me.txtIsEdit.Name = "txtIsEdit"
        Me.txtIsEdit.Size = New System.Drawing.Size(97, 22)
        Me.txtIsEdit.TabIndex = 48
        Me.txtIsEdit.TabStop = False
        Me.txtIsEdit.Visible = False
        '
        'txtAccCode
        '
        Me.txtAccCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccCode.Location = New System.Drawing.Point(122, 47)
        Me.txtAccCode.Name = "txtAccCode"
        Me.txtAccCode.Size = New System.Drawing.Size(250, 22)
        Me.txtAccCode.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(19, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Acc Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(19, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Acc Title"
        '
        'txtAccName
        '
        Me.txtAccName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccName.Location = New System.Drawing.Point(122, 75)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(250, 22)
        Me.txtAccName.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(686, 18)
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
        Me.txtUser.Location = New System.Drawing.Point(805, 19)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnDelete, Me.btnRefresh, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(950, 46)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "Payment Voucher"
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(19, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Contact"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(19, 381)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 126
        Me.Label17.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtWebsite.Location = New System.Drawing.Point(122, 378)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(250, 22)
        Me.txtWebsite.TabIndex = 127
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(19, 325)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 16)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Fax"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFax.Location = New System.Drawing.Point(122, 322)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(250, 22)
        Me.txtFax.TabIndex = 123
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(19, 353)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEmail.Location = New System.Drawing.Point(122, 350)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 22)
        Me.txtEmail.TabIndex = 125
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(19, 269)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 16)
        Me.Label20.TabIndex = 118
        Me.Label20.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtMobile.Location = New System.Drawing.Point(122, 266)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(250, 22)
        Me.txtMobile.TabIndex = 119
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(19, 297)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 16)
        Me.Label31.TabIndex = 120
        Me.Label31.Text = "Landline"
        '
        'txtLandline
        '
        Me.txtLandline.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtLandline.Location = New System.Drawing.Point(122, 294)
        Me.txtLandline.Name = "txtLandline"
        Me.txtLandline.Size = New System.Drawing.Size(250, 22)
        Me.txtLandline.TabIndex = 121
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label32.Location = New System.Drawing.Point(19, 241)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 16)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "Name"
        '
        'txtContactName
        '
        Me.txtContactName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtContactName.Location = New System.Drawing.Point(122, 238)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(250, 22)
        Me.txtContactName.TabIndex = 117
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label30.Location = New System.Drawing.Point(693, 187)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 16)
        Me.Label30.TabIndex = 174
        Me.Label30.Text = "Forign Currency"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(558, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Local Currency"
        '
        'txtOpeningCreditFC
        '
        Me.txtOpeningCreditFC.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtOpeningCreditFC.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtOpeningCreditFC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpeningCreditFC.DoubleValue = 0.0R
        Me.txtOpeningCreditFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtOpeningCreditFC.Location = New System.Drawing.Point(670, 237)
        Me.txtOpeningCreditFC.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtOpeningCreditFC.Name = "txtOpeningCreditFC"
        Me.txtOpeningCreditFC.NullString = ""
        Me.txtOpeningCreditFC.Size = New System.Drawing.Size(125, 22)
        Me.txtOpeningCreditFC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtOpeningCreditFC.TabIndex = 172
        Me.txtOpeningCreditFC.Text = "0.00"
        '
        'txtOpeningDebitFC
        '
        Me.txtOpeningDebitFC.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtOpeningDebitFC.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtOpeningDebitFC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpeningDebitFC.DoubleValue = 0.0R
        Me.txtOpeningDebitFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtOpeningDebitFC.Location = New System.Drawing.Point(670, 209)
        Me.txtOpeningDebitFC.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtOpeningDebitFC.Name = "txtOpeningDebitFC"
        Me.txtOpeningDebitFC.NullString = ""
        Me.txtOpeningDebitFC.Size = New System.Drawing.Size(125, 22)
        Me.txtOpeningDebitFC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtOpeningDebitFC.TabIndex = 171
        Me.txtOpeningDebitFC.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(425, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Crerdit Limit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(425, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Credit Days"
        '
        'txtCreditDays
        '
        Me.txtCreditDays.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtCreditDays.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtCreditDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreditDays.DoubleValue = 0.0R
        Me.txtCreditDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCreditDays.Location = New System.Drawing.Point(530, 321)
        Me.txtCreditDays.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCreditDays.Name = "txtCreditDays"
        Me.txtCreditDays.NullString = ""
        Me.txtCreditDays.NumberDecimalDigits = 0
        Me.txtCreditDays.Size = New System.Drawing.Size(125, 22)
        Me.txtCreditDays.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtCreditDays.TabIndex = 168
        Me.txtCreditDays.Text = "0"
        '
        'txtCreditLimit
        '
        Me.txtCreditLimit.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtCreditLimit.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreditLimit.DoubleValue = 0.0R
        Me.txtCreditLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCreditLimit.Location = New System.Drawing.Point(530, 293)
        Me.txtCreditLimit.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCreditLimit.Name = "txtCreditLimit"
        Me.txtCreditLimit.NullString = ""
        Me.txtCreditLimit.NumberDecimalDigits = 0
        Me.txtCreditLimit.Size = New System.Drawing.Size(125, 22)
        Me.txtCreditLimit.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtCreditLimit.TabIndex = 167
        Me.txtCreditLimit.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(424, 183)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 20)
        Me.Label27.TabIndex = 162
        Me.Label27.Text = "Financials"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label28.Location = New System.Drawing.Point(424, 377)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 16)
        Me.Label28.TabIndex = 165
        Me.Label28.Text = "GST"
        '
        'txtGST
        '
        Me.txtGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtGST.Location = New System.Drawing.Point(530, 377)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(125, 22)
        Me.txtGST.TabIndex = 166
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label29.Location = New System.Drawing.Point(424, 349)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 16)
        Me.Label29.TabIndex = 163
        Me.Label29.Text = "NTN"
        '
        'txtNTN
        '
        Me.txtNTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNTN.Location = New System.Drawing.Point(530, 349)
        Me.txtNTN.Name = "txtNTN"
        Me.txtNTN.Size = New System.Drawing.Size(125, 22)
        Me.txtNTN.TabIndex = 164
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(667, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPostalCode.Location = New System.Drawing.Point(755, 132)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(125, 22)
        Me.txtPostalCode.TabIndex = 161
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(424, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 16)
        Me.Label21.TabIndex = 158
        Me.Label21.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCountry.Location = New System.Drawing.Point(530, 132)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(125, 22)
        Me.txtCountry.TabIndex = 159
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(667, 107)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 156
        Me.Label23.Text = "Province"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtState.Location = New System.Drawing.Point(755, 104)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(125, 22)
        Me.txtState.TabIndex = 157
        '
        'txtAddress2
        '
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAddress2.Location = New System.Drawing.Point(530, 76)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(350, 22)
        Me.txtAddress2.TabIndex = 153
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(424, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 20)
        Me.Label24.TabIndex = 150
        Me.Label24.Text = "Address"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(427, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 16)
        Me.Label25.TabIndex = 154
        Me.Label25.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCity.Location = New System.Drawing.Point(530, 104)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(125, 22)
        Me.txtCity.TabIndex = 155
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label26.Location = New System.Drawing.Point(424, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 16)
        Me.Label26.TabIndex = 151
        Me.Label26.Text = "Street"
        '
        'txtAddress1
        '
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAddress1.Location = New System.Drawing.Point(530, 48)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(350, 22)
        Me.txtAddress1.TabIndex = 152
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(424, 209)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 16)
        Me.Label22.TabIndex = 149
        Me.Label22.Text = "Opening Debit"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label33.Location = New System.Drawing.Point(424, 237)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(97, 16)
        Me.Label33.TabIndex = 148
        Me.Label33.Text = "Opening Credit"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label34.Location = New System.Drawing.Point(424, 265)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(91, 16)
        Me.Label34.TabIndex = 147
        Me.Label34.Text = "Opening Date"
        '
        'txtOpeningCredit
        '
        Me.txtOpeningCredit.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtOpeningCredit.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtOpeningCredit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpeningCredit.DoubleValue = 0.0R
        Me.txtOpeningCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtOpeningCredit.Location = New System.Drawing.Point(530, 237)
        Me.txtOpeningCredit.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtOpeningCredit.Name = "txtOpeningCredit"
        Me.txtOpeningCredit.NullString = ""
        Me.txtOpeningCredit.Size = New System.Drawing.Size(125, 22)
        Me.txtOpeningCredit.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtOpeningCredit.TabIndex = 145
        Me.txtOpeningCredit.Text = "0.00"
        '
        'txtOpeningDebit
        '
        Me.txtOpeningDebit.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtOpeningDebit.BeforeTouchSize = New System.Drawing.Size(125, 22)
        Me.txtOpeningDebit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpeningDebit.DoubleValue = 0.0R
        Me.txtOpeningDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtOpeningDebit.Location = New System.Drawing.Point(530, 209)
        Me.txtOpeningDebit.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtOpeningDebit.Name = "txtOpeningDebit"
        Me.txtOpeningDebit.NullString = ""
        Me.txtOpeningDebit.Size = New System.Drawing.Size(125, 22)
        Me.txtOpeningDebit.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtOpeningDebit.TabIndex = 144
        Me.txtOpeningDebit.Text = "0.00"
        '
        'dtpOpeningDate
        '
        Me.dtpOpeningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpOpeningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOpeningDate.Location = New System.Drawing.Point(530, 265)
        Me.dtpOpeningDate.Name = "dtpOpeningDate"
        Me.dtpOpeningDate.Size = New System.Drawing.Size(125, 22)
        Me.dtpOpeningDate.TabIndex = 146
        '
        'frmAccountsAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 711)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel15)
        Me.KeyPreview = True
        Me.Name = "frmAccountsAdvanced"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Chart of Accounts"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picPanelExtender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtOpeningCreditFC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpeningDebitFC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpeningCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpeningDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AtThisLevel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnderSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtIsEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAccNature As System.Windows.Forms.ComboBox
    Friend WithEvents cboAccType As System.Windows.Forms.ComboBox
    Friend WithEvents txtParentAccCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAccLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtParentAccName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchAcc As System.Windows.Forms.Button
    Friend WithEvents chkIsAccount As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExpandAll As System.Windows.Forms.Button
    Friend WithEvents btnCollapseAll As System.Windows.Forms.Button
    Friend WithEvents btnEditSelected As System.Windows.Forms.Button
    Friend WithEvents btnInsertUnderSelectedLevel As System.Windows.Forms.Button
    Friend WithEvents btnInsertAtSelectedLeve As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtLandline As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOpeningCreditFC As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtOpeningDebitFC As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCreditDays As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtCreditLimit As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtNTN As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtOpeningCredit As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents txtOpeningDebit As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents dtpOpeningDate As System.Windows.Forms.DateTimePicker
End Class
