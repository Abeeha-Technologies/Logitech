<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.brnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabDetail = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.nudBackDateDays = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkDisable = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtParentValue2 = New System.Windows.Forms.TextBox()
        Me.txtParentValue1 = New System.Windows.Forms.TextBox()
        Me.chkCanViewBalanceSheetReport = New System.Windows.Forms.CheckBox()
        Me.chkCanViewTrialBalanceReport = New System.Windows.Forms.CheckBox()
        Me.chkCanViewSaleReport = New System.Windows.Forms.CheckBox()
        Me.chkCanViewPurchaseReport = New System.Windows.Forms.CheckBox()
        Me.chkCanViewGeneralLedgerReport = New System.Windows.Forms.CheckBox()
        Me.chkCanViewIncomeStatement = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkCanApproveVoucher = New System.Windows.Forms.CheckBox()
        Me.chkCanViewDashboard = New System.Windows.Forms.CheckBox()
        Me.chkCanDeleteVoucher = New System.Windows.Forms.CheckBox()
        Me.chkSystemSettings = New System.Windows.Forms.CheckBox()
        Me.chkDefineAcounts = New System.Windows.Forms.CheckBox()
        Me.chkDefineOperations = New System.Windows.Forms.CheckBox()
        Me.chkEnterOpperationalVoucher = New System.Windows.Forms.CheckBox()
        Me.chkEnterAccountingVoucher = New System.Windows.Forms.CheckBox()
        Me.chkEditVoucher = New System.Windows.Forms.CheckBox()
        Me.chkCreateUser = New System.Windows.Forms.CheckBox()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.txtSearchText = New Logitech.TextBoxHint()
        Me.chkCanEditApproveVoucher = New System.Windows.Forms.CheckBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetail.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nudBackDateDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(448, 481)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 20)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Label3"
        '
        'txtUserId
        '
        Me.txtUserId.Enabled = False
        Me.txtUserId.Location = New System.Drawing.Point(598, 16)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(50, 20)
        Me.txtUserId.TabIndex = 1
        Me.txtUserId.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(68, 15)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(134, 20)
        Me.txtUserName.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(347, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 40)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close [Esc]"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'brnReset
        '
        Me.brnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnReset.Image = CType(resources.GetObject("brnReset.Image"), System.Drawing.Image)
        Me.brnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.brnReset.Location = New System.Drawing.Point(134, 472)
        Me.brnReset.Name = "brnReset"
        Me.brnReset.Size = New System.Drawing.Size(75, 40)
        Me.brnReset.TabIndex = 10
        Me.brnReset.Text = "Reset"
        Me.brnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.brnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(12, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 40)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save [Ctrl + S]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 309)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 20
        Me.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(692, 157)
        Me.dgv.TabIndex = 8
        Me.dgv.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(576, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'tabDetail
        '
        Me.tabDetail.Controls.Add(Me.TabPage1)
        Me.tabDetail.Location = New System.Drawing.Point(12, 12)
        Me.tabDetail.Name = "tabDetail"
        Me.tabDetail.SelectedIndex = 0
        Me.tabDetail.Size = New System.Drawing.Size(692, 265)
        Me.tabDetail.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.nudBackDateDays)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.chkDisable)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtUserId)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtUserName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(684, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'nudBackDateDays
        '
        Me.nudBackDateDays.Location = New System.Drawing.Point(299, 15)
        Me.nudBackDateDays.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudBackDateDays.Name = "nudBackDateDays"
        Me.nudBackDateDays.Size = New System.Drawing.Size(65, 20)
        Me.nudBackDateDays.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Back Date Days"
        '
        'chkDisable
        '
        Me.chkDisable.AutoSize = True
        Me.chkDisable.Location = New System.Drawing.Point(427, 17)
        Me.chkDisable.Name = "chkDisable"
        Me.chkDisable.Size = New System.Drawing.Size(86, 17)
        Me.chkDisable.TabIndex = 16
        Me.chkDisable.Text = "Disable User"
        Me.chkDisable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Ivory
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(785, 191)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permissions"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtParentValue2)
        Me.GroupBox5.Controls.Add(Me.txtParentValue1)
        Me.GroupBox5.Controls.Add(Me.chkCanViewBalanceSheetReport)
        Me.GroupBox5.Controls.Add(Me.chkCanViewTrialBalanceReport)
        Me.GroupBox5.Controls.Add(Me.chkCanViewSaleReport)
        Me.GroupBox5.Controls.Add(Me.chkCanViewPurchaseReport)
        Me.GroupBox5.Controls.Add(Me.chkCanViewGeneralLedgerReport)
        Me.GroupBox5.Controls.Add(Me.chkCanViewIncomeStatement)
        Me.GroupBox5.Location = New System.Drawing.Point(340, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(329, 165)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Reports"
        '
        'txtParentValue2
        '
        Me.txtParentValue2.Location = New System.Drawing.Point(211, 111)
        Me.txtParentValue2.Name = "txtParentValue2"
        Me.txtParentValue2.Size = New System.Drawing.Size(8, 20)
        Me.txtParentValue2.TabIndex = 22
        Me.txtParentValue2.TabStop = False
        Me.txtParentValue2.Visible = False
        '
        'txtParentValue1
        '
        Me.txtParentValue1.Location = New System.Drawing.Point(197, 130)
        Me.txtParentValue1.Name = "txtParentValue1"
        Me.txtParentValue1.Size = New System.Drawing.Size(8, 20)
        Me.txtParentValue1.TabIndex = 21
        Me.txtParentValue1.TabStop = False
        Me.txtParentValue1.Visible = False
        '
        'chkCanViewBalanceSheetReport
        '
        Me.chkCanViewBalanceSheetReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewBalanceSheetReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewBalanceSheetReport.Location = New System.Drawing.Point(6, 42)
        Me.chkCanViewBalanceSheetReport.Name = "chkCanViewBalanceSheetReport"
        Me.chkCanViewBalanceSheetReport.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewBalanceSheetReport.TabIndex = 6
        Me.chkCanViewBalanceSheetReport.Text = "View Balance Sheet"
        Me.chkCanViewBalanceSheetReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewBalanceSheetReport.UseCompatibleTextRendering = True
        Me.chkCanViewBalanceSheetReport.UseVisualStyleBackColor = True
        '
        'chkCanViewTrialBalanceReport
        '
        Me.chkCanViewTrialBalanceReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewTrialBalanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewTrialBalanceReport.Location = New System.Drawing.Point(6, 65)
        Me.chkCanViewTrialBalanceReport.Name = "chkCanViewTrialBalanceReport"
        Me.chkCanViewTrialBalanceReport.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewTrialBalanceReport.TabIndex = 5
        Me.chkCanViewTrialBalanceReport.Text = "View Trial Balance"
        Me.chkCanViewTrialBalanceReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewTrialBalanceReport.UseCompatibleTextRendering = True
        Me.chkCanViewTrialBalanceReport.UseVisualStyleBackColor = True
        '
        'chkCanViewSaleReport
        '
        Me.chkCanViewSaleReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewSaleReport.Location = New System.Drawing.Point(6, 134)
        Me.chkCanViewSaleReport.Name = "chkCanViewSaleReport"
        Me.chkCanViewSaleReport.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewSaleReport.TabIndex = 4
        Me.chkCanViewSaleReport.Text = "View Sale Report"
        Me.chkCanViewSaleReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewSaleReport.UseCompatibleTextRendering = True
        Me.chkCanViewSaleReport.UseVisualStyleBackColor = True
        '
        'chkCanViewPurchaseReport
        '
        Me.chkCanViewPurchaseReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewPurchaseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewPurchaseReport.Location = New System.Drawing.Point(6, 111)
        Me.chkCanViewPurchaseReport.Name = "chkCanViewPurchaseReport"
        Me.chkCanViewPurchaseReport.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewPurchaseReport.TabIndex = 3
        Me.chkCanViewPurchaseReport.Text = "View Purchase Report"
        Me.chkCanViewPurchaseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewPurchaseReport.UseCompatibleTextRendering = True
        Me.chkCanViewPurchaseReport.UseVisualStyleBackColor = True
        '
        'chkCanViewGeneralLedgerReport
        '
        Me.chkCanViewGeneralLedgerReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewGeneralLedgerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewGeneralLedgerReport.Location = New System.Drawing.Point(6, 88)
        Me.chkCanViewGeneralLedgerReport.Name = "chkCanViewGeneralLedgerReport"
        Me.chkCanViewGeneralLedgerReport.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewGeneralLedgerReport.TabIndex = 2
        Me.chkCanViewGeneralLedgerReport.Text = "View General Ledger"
        Me.chkCanViewGeneralLedgerReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewGeneralLedgerReport.UseCompatibleTextRendering = True
        Me.chkCanViewGeneralLedgerReport.UseVisualStyleBackColor = True
        '
        'chkCanViewIncomeStatement
        '
        Me.chkCanViewIncomeStatement.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewIncomeStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewIncomeStatement.Location = New System.Drawing.Point(6, 19)
        Me.chkCanViewIncomeStatement.Name = "chkCanViewIncomeStatement"
        Me.chkCanViewIncomeStatement.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewIncomeStatement.TabIndex = 1
        Me.chkCanViewIncomeStatement.Text = "View Income Statement"
        Me.chkCanViewIncomeStatement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewIncomeStatement.UseCompatibleTextRendering = True
        Me.chkCanViewIncomeStatement.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkCanEditApproveVoucher)
        Me.GroupBox4.Controls.Add(Me.chkCanApproveVoucher)
        Me.GroupBox4.Controls.Add(Me.chkCanViewDashboard)
        Me.GroupBox4.Controls.Add(Me.chkCanDeleteVoucher)
        Me.GroupBox4.Controls.Add(Me.chkSystemSettings)
        Me.GroupBox4.Controls.Add(Me.chkDefineAcounts)
        Me.GroupBox4.Controls.Add(Me.chkDefineOperations)
        Me.GroupBox4.Controls.Add(Me.chkEnterOpperationalVoucher)
        Me.GroupBox4.Controls.Add(Me.chkEnterAccountingVoucher)
        Me.GroupBox4.Controls.Add(Me.chkEditVoucher)
        Me.GroupBox4.Controls.Add(Me.chkCreateUser)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 165)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forms"
        '
        'chkCanApproveVoucher
        '
        Me.chkCanApproveVoucher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanApproveVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanApproveVoucher.Location = New System.Drawing.Point(161, 88)
        Me.chkCanApproveVoucher.Name = "chkCanApproveVoucher"
        Me.chkCanApproveVoucher.Size = New System.Drawing.Size(140, 17)
        Me.chkCanApproveVoucher.TabIndex = 11
        Me.chkCanApproveVoucher.Text = "Approve Voucher"
        Me.chkCanApproveVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanApproveVoucher.UseCompatibleTextRendering = True
        Me.chkCanApproveVoucher.UseVisualStyleBackColor = True
        '
        'chkCanViewDashboard
        '
        Me.chkCanViewDashboard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanViewDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanViewDashboard.Location = New System.Drawing.Point(161, 65)
        Me.chkCanViewDashboard.Name = "chkCanViewDashboard"
        Me.chkCanViewDashboard.Size = New System.Drawing.Size(140, 17)
        Me.chkCanViewDashboard.TabIndex = 10
        Me.chkCanViewDashboard.Text = "View Dashboard"
        Me.chkCanViewDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanViewDashboard.UseCompatibleTextRendering = True
        Me.chkCanViewDashboard.UseVisualStyleBackColor = True
        '
        'chkCanDeleteVoucher
        '
        Me.chkCanDeleteVoucher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanDeleteVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanDeleteVoucher.Location = New System.Drawing.Point(161, 19)
        Me.chkCanDeleteVoucher.Name = "chkCanDeleteVoucher"
        Me.chkCanDeleteVoucher.Size = New System.Drawing.Size(140, 17)
        Me.chkCanDeleteVoucher.TabIndex = 9
        Me.chkCanDeleteVoucher.Text = "Delete Voucher"
        Me.chkCanDeleteVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanDeleteVoucher.UseCompatibleTextRendering = True
        Me.chkCanDeleteVoucher.UseVisualStyleBackColor = True
        '
        'chkSystemSettings
        '
        Me.chkSystemSettings.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSystemSettings.Location = New System.Drawing.Point(161, 42)
        Me.chkSystemSettings.Name = "chkSystemSettings"
        Me.chkSystemSettings.Size = New System.Drawing.Size(140, 17)
        Me.chkSystemSettings.TabIndex = 6
        Me.chkSystemSettings.Text = "System Settings"
        Me.chkSystemSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkSystemSettings.UseCompatibleTextRendering = True
        Me.chkSystemSettings.UseVisualStyleBackColor = True
        '
        'chkDefineAcounts
        '
        Me.chkDefineAcounts.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDefineAcounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDefineAcounts.Location = New System.Drawing.Point(6, 42)
        Me.chkDefineAcounts.Name = "chkDefineAcounts"
        Me.chkDefineAcounts.Size = New System.Drawing.Size(140, 17)
        Me.chkDefineAcounts.TabIndex = 5
        Me.chkDefineAcounts.Text = "Chart of Accounts"
        Me.chkDefineAcounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkDefineAcounts.UseCompatibleTextRendering = True
        Me.chkDefineAcounts.UseVisualStyleBackColor = True
        '
        'chkDefineOperations
        '
        Me.chkDefineOperations.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDefineOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDefineOperations.Location = New System.Drawing.Point(6, 88)
        Me.chkDefineOperations.Name = "chkDefineOperations"
        Me.chkDefineOperations.Size = New System.Drawing.Size(140, 17)
        Me.chkDefineOperations.TabIndex = 4
        Me.chkDefineOperations.Text = "Definations"
        Me.chkDefineOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkDefineOperations.UseCompatibleTextRendering = True
        Me.chkDefineOperations.UseVisualStyleBackColor = True
        '
        'chkEnterOpperationalVoucher
        '
        Me.chkEnterOpperationalVoucher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnterOpperationalVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEnterOpperationalVoucher.Location = New System.Drawing.Point(6, 111)
        Me.chkEnterOpperationalVoucher.Name = "chkEnterOpperationalVoucher"
        Me.chkEnterOpperationalVoucher.Size = New System.Drawing.Size(140, 17)
        Me.chkEnterOpperationalVoucher.TabIndex = 3
        Me.chkEnterOpperationalVoucher.Text = "Operational Vouchers"
        Me.chkEnterOpperationalVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkEnterOpperationalVoucher.UseCompatibleTextRendering = True
        Me.chkEnterOpperationalVoucher.UseVisualStyleBackColor = True
        '
        'chkEnterAccountingVoucher
        '
        Me.chkEnterAccountingVoucher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnterAccountingVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEnterAccountingVoucher.Location = New System.Drawing.Point(6, 65)
        Me.chkEnterAccountingVoucher.Name = "chkEnterAccountingVoucher"
        Me.chkEnterAccountingVoucher.Size = New System.Drawing.Size(140, 17)
        Me.chkEnterAccountingVoucher.TabIndex = 2
        Me.chkEnterAccountingVoucher.Text = "Accounting Vouchers"
        Me.chkEnterAccountingVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkEnterAccountingVoucher.UseCompatibleTextRendering = True
        Me.chkEnterAccountingVoucher.UseVisualStyleBackColor = True
        '
        'chkEditVoucher
        '
        Me.chkEditVoucher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEditVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEditVoucher.Location = New System.Drawing.Point(6, 134)
        Me.chkEditVoucher.Name = "chkEditVoucher"
        Me.chkEditVoucher.Size = New System.Drawing.Size(140, 17)
        Me.chkEditVoucher.TabIndex = 1
        Me.chkEditVoucher.Text = "Edit Vouchers"
        Me.chkEditVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkEditVoucher.UseCompatibleTextRendering = True
        Me.chkEditVoucher.UseVisualStyleBackColor = True
        '
        'chkCreateUser
        '
        Me.chkCreateUser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCreateUser.Location = New System.Drawing.Point(6, 19)
        Me.chkCreateUser.Name = "chkCreateUser"
        Me.chkCreateUser.Size = New System.Drawing.Size(140, 17)
        Me.chkCreateUser.TabIndex = 0
        Me.chkCreateUser.Text = "Users"
        Me.chkCreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCreateUser.UseCompatibleTextRendering = True
        Me.chkCreateUser.UseVisualStyleBackColor = True
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.Image = CType(resources.GetObject("btnResetPassword.Image"), System.Drawing.Image)
        Me.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetPassword.Location = New System.Drawing.Point(215, 472)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(126, 40)
        Me.btnResetPassword.TabIndex = 20
        Me.btnResetPassword.Text = "Reset Password"
        Me.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'txtSearchText
        '
        Me.txtSearchText.HintDetails.HintText = "Type Here to Search"
        Me.txtSearchText.Location = New System.Drawing.Point(12, 283)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(250, 20)
        Me.txtSearchText.TabIndex = 17
        '
        'chkCanEditApproveVoucher
        '
        Me.chkCanEditApproveVoucher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCanEditApproveVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanEditApproveVoucher.Location = New System.Drawing.Point(161, 111)
        Me.chkCanEditApproveVoucher.Name = "chkCanEditApproveVoucher"
        Me.chkCanEditApproveVoucher.Size = New System.Drawing.Size(140, 17)
        Me.chkCanEditApproveVoucher.TabIndex = 12
        Me.chkCanEditApproveVoucher.Text = "Edit Approve Voucher"
        Me.chkCanEditApproveVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chkCanEditApproveVoucher.UseCompatibleTextRendering = True
        Me.chkCanEditApproveVoucher.UseVisualStyleBackColor = True
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 521)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.tabDetail)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.brnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgv)
        Me.KeyPreview = True
        Me.Name = "frmUsers"
        Me.Text = "Users"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetail.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.nudBackDateDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents brnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
    Friend WithEvents tabDetail As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanViewIncomeStatement As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCreateUser As System.Windows.Forms.CheckBox
    Friend WithEvents btnResetPassword As System.Windows.Forms.Button
    Friend WithEvents chkDefineOperations As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnterOpperationalVoucher As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnterAccountingVoucher As System.Windows.Forms.CheckBox
    Friend WithEvents chkEditVoucher As System.Windows.Forms.CheckBox
    Friend WithEvents chkDefineAcounts As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanViewBalanceSheetReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanViewTrialBalanceReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanViewSaleReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanViewPurchaseReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanViewGeneralLedgerReport As System.Windows.Forms.CheckBox
    Friend WithEvents nudBackDateDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDisable As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystemSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanDeleteVoucher As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanApproveVoucher As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanViewDashboard As System.Windows.Forms.CheckBox
    Friend WithEvents txtParentValue2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentValue1 As System.Windows.Forms.TextBox
    Friend WithEvents chkCanEditApproveVoucher As System.Windows.Forms.CheckBox
End Class
