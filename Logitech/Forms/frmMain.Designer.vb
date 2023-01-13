<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelNavigationItems = New System.Windows.Forms.Panel()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.pnlUtilitiesSubMenu = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnUtilities = New System.Windows.Forms.Button()
        Me.pnlSaleReportsSubMenu = New System.Windows.Forms.Panel()
        Me.btnSaleReports = New System.Windows.Forms.Button()
        Me.pnlOperationReportsSubMenu = New System.Windows.Forms.Panel()
        Me.btnVehicleList = New System.Windows.Forms.Button()
        Me.btnRptEmployeeList = New System.Windows.Forms.Button()
        Me.btnRptIssueList = New System.Windows.Forms.Button()
        Me.btnEmployeesOutstanding = New System.Windows.Forms.Button()
        Me.btnOperationReports = New System.Windows.Forms.Button()
        Me.pnlAccountsReportsSubMenu = New System.Windows.Forms.Panel()
        Me.btnDayBook = New System.Windows.Forms.Button()
        Me.btnDailyCashTransactionReport = New System.Windows.Forms.Button()
        Me.btnVoucherValidation = New System.Windows.Forms.Button()
        Me.btnVouchersReport = New System.Windows.Forms.Button()
        Me.btnReceivablePayableBalances = New System.Windows.Forms.Button()
        Me.btnIncomeStatement = New System.Windows.Forms.Button()
        Me.btnBalanceSHeet = New System.Windows.Forms.Button()
        Me.btnTrialBalance = New System.Windows.Forms.Button()
        Me.btnGeneralLedger = New System.Windows.Forms.Button()
        Me.btnChartofAccounts = New System.Windows.Forms.Button()
        Me.btnAccountsReports = New System.Windows.Forms.Button()
        Me.pnlOperationsSubMenu = New System.Windows.Forms.Panel()
        Me.btnVehicleReceiving = New System.Windows.Forms.Button()
        Me.btnSaleVoucher = New System.Windows.Forms.Button()
        Me.btnVehicleIssuance = New System.Windows.Forms.Button()
        Me.btnOperations = New System.Windows.Forms.Button()
        Me.pnlVouchersSubMenu = New System.Windows.Forms.Panel()
        Me.btnJV = New System.Windows.Forms.Button()
        Me.btnBRV = New System.Windows.Forms.Button()
        Me.btnBPV = New System.Windows.Forms.Button()
        Me.btnCRV = New System.Windows.Forms.Button()
        Me.btnCPV = New System.Windows.Forms.Button()
        Me.btnVouchers = New System.Windows.Forms.Button()
        Me.pnlDefineSubMenu = New System.Windows.Forms.Panel()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnVehicles = New System.Windows.Forms.Button()
        Me.btnCAO = New System.Windows.Forms.Button()
        Me.btnDefine = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PanelNavigationHeader = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabbedMDIManagerMain = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager(Me.components)
        Me.pnlNavigation.SuspendLayout()
        Me.PanelNavigationItems.SuspendLayout()
        Me.pnlUtilitiesSubMenu.SuspendLayout()
        Me.pnlOperationReportsSubMenu.SuspendLayout()
        Me.pnlAccountsReportsSubMenu.SuspendLayout()
        Me.pnlOperationsSubMenu.SuspendLayout()
        Me.pnlVouchersSubMenu.SuspendLayout()
        Me.pnlDefineSubMenu.SuspendLayout()
        Me.PanelNavigationHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "MainNew_Menu_24px.png")
        Me.imgList.Images.SetKeyName(1, "MainNew_MenuClose_24px.png")
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlNavigation.Controls.Add(Me.btnSettings)
        Me.pnlNavigation.Controls.Add(Me.btnShutdown)
        Me.pnlNavigation.Controls.Add(Me.Label2)
        Me.pnlNavigation.Controls.Add(Me.Label3)
        Me.pnlNavigation.Controls.Add(Me.PanelNavigationItems)
        Me.pnlNavigation.Controls.Add(Me.PanelNavigationHeader)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(230, 1061)
        Me.pnlNavigation.TabIndex = 14
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = Global.Logitech.My.Resources.Resources.mainnew_settings_24px
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(55, 1010)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSettings.Size = New System.Drawing.Size(50, 35)
        Me.btnSettings.TabIndex = 13
        Me.btnSettings.TabStop = False
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShutdown.FlatAppearance.BorderSize = 0
        Me.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutdown.Image = CType(resources.GetObject("btnShutdown.Image"), System.Drawing.Image)
        Me.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShutdown.Location = New System.Drawing.Point(-1, 1010)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnShutdown.Size = New System.Drawing.Size(50, 35)
        Me.btnShutdown.TabIndex = 12
        Me.btnShutdown.TabStop = False
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(43, 977)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 46)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Complete Solution For your Business"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(132, 1036)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Version 2022"
        '
        'PanelNavigationItems
        '
        Me.PanelNavigationItems.AutoScroll = True
        Me.PanelNavigationItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PanelNavigationItems.Controls.Add(Me.btnBackup)
        Me.PanelNavigationItems.Controls.Add(Me.pnlUtilitiesSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnUtilities)
        Me.PanelNavigationItems.Controls.Add(Me.pnlSaleReportsSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnSaleReports)
        Me.PanelNavigationItems.Controls.Add(Me.pnlOperationReportsSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnOperationReports)
        Me.PanelNavigationItems.Controls.Add(Me.pnlAccountsReportsSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnAccountsReports)
        Me.PanelNavigationItems.Controls.Add(Me.pnlOperationsSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnOperations)
        Me.PanelNavigationItems.Controls.Add(Me.pnlVouchersSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnVouchers)
        Me.PanelNavigationItems.Controls.Add(Me.pnlDefineSubMenu)
        Me.PanelNavigationItems.Controls.Add(Me.btnDefine)
        Me.PanelNavigationItems.Controls.Add(Me.btnHome)
        Me.PanelNavigationItems.Location = New System.Drawing.Point(0, 50)
        Me.PanelNavigationItems.Name = "PanelNavigationItems"
        Me.PanelNavigationItems.Size = New System.Drawing.Size(230, 916)
        Me.PanelNavigationItems.TabIndex = 1
        '
        'btnBackup
        '
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(0, 1180)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBackup.Size = New System.Drawing.Size(213, 35)
        Me.btnBackup.TabIndex = 17
        Me.btnBackup.Text = "  Backup / Restore"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'pnlUtilitiesSubMenu
        '
        Me.pnlUtilitiesSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlUtilitiesSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUtilitiesSubMenu.Controls.Add(Me.Button5)
        Me.pnlUtilitiesSubMenu.Controls.Add(Me.btnChangePassword)
        Me.pnlUtilitiesSubMenu.Controls.Add(Me.btnUsers)
        Me.pnlUtilitiesSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUtilitiesSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlUtilitiesSubMenu.Location = New System.Drawing.Point(0, 930)
        Me.pnlUtilitiesSubMenu.Name = "pnlUtilitiesSubMenu"
        Me.pnlUtilitiesSubMenu.Size = New System.Drawing.Size(213, 250)
        Me.pnlUtilitiesSubMenu.TabIndex = 16
        Me.pnlUtilitiesSubMenu.Tag = "SubMenu"
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(0, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(211, 25)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Record Log"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnChangePassword.Location = New System.Drawing.Point(0, 25)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnChangePassword.Size = New System.Drawing.Size(211, 25)
        Me.btnChangePassword.TabIndex = 1
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUsers.Location = New System.Drawing.Point(0, 0)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnUsers.Size = New System.Drawing.Size(211, 25)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnUtilities
        '
        Me.btnUtilities.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUtilities.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUtilities.FlatAppearance.BorderSize = 0
        Me.btnUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUtilities.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtilities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUtilities.Image = CType(resources.GetObject("btnUtilities.Image"), System.Drawing.Image)
        Me.btnUtilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUtilities.Location = New System.Drawing.Point(0, 895)
        Me.btnUtilities.Name = "btnUtilities"
        Me.btnUtilities.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUtilities.Size = New System.Drawing.Size(213, 35)
        Me.btnUtilities.TabIndex = 15
        Me.btnUtilities.Text = "  Utilities"
        Me.btnUtilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUtilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUtilities.UseVisualStyleBackColor = True
        '
        'pnlSaleReportsSubMenu
        '
        Me.pnlSaleReportsSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSaleReportsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSaleReportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSaleReportsSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlSaleReportsSubMenu.Location = New System.Drawing.Point(0, 870)
        Me.pnlSaleReportsSubMenu.Name = "pnlSaleReportsSubMenu"
        Me.pnlSaleReportsSubMenu.Size = New System.Drawing.Size(213, 25)
        Me.pnlSaleReportsSubMenu.TabIndex = 14
        Me.pnlSaleReportsSubMenu.Tag = "SubMenu"
        Me.pnlSaleReportsSubMenu.Visible = False
        '
        'btnSaleReports
        '
        Me.btnSaleReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaleReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaleReports.FlatAppearance.BorderSize = 0
        Me.btnSaleReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaleReports.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaleReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSaleReports.Image = CType(resources.GetObject("btnSaleReports.Image"), System.Drawing.Image)
        Me.btnSaleReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaleReports.Location = New System.Drawing.Point(0, 835)
        Me.btnSaleReports.Name = "btnSaleReports"
        Me.btnSaleReports.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSaleReports.Size = New System.Drawing.Size(213, 35)
        Me.btnSaleReports.TabIndex = 13
        Me.btnSaleReports.Text = "  Sale Reports"
        Me.btnSaleReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaleReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaleReports.UseVisualStyleBackColor = True
        Me.btnSaleReports.Visible = False
        '
        'pnlOperationReportsSubMenu
        '
        Me.pnlOperationReportsSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlOperationReportsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOperationReportsSubMenu.Controls.Add(Me.btnVehicleList)
        Me.pnlOperationReportsSubMenu.Controls.Add(Me.btnRptEmployeeList)
        Me.pnlOperationReportsSubMenu.Controls.Add(Me.btnRptIssueList)
        Me.pnlOperationReportsSubMenu.Controls.Add(Me.btnEmployeesOutstanding)
        Me.pnlOperationReportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOperationReportsSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlOperationReportsSubMenu.Location = New System.Drawing.Point(0, 735)
        Me.pnlOperationReportsSubMenu.Name = "pnlOperationReportsSubMenu"
        Me.pnlOperationReportsSubMenu.Size = New System.Drawing.Size(213, 100)
        Me.pnlOperationReportsSubMenu.TabIndex = 12
        Me.pnlOperationReportsSubMenu.Tag = "SubMenu"
        '
        'btnVehicleList
        '
        Me.btnVehicleList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehicleList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVehicleList.FlatAppearance.BorderSize = 0
        Me.btnVehicleList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehicleList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVehicleList.Location = New System.Drawing.Point(0, 75)
        Me.btnVehicleList.Name = "btnVehicleList"
        Me.btnVehicleList.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnVehicleList.Size = New System.Drawing.Size(211, 25)
        Me.btnVehicleList.TabIndex = 3
        Me.btnVehicleList.Text = "Vehicle List"
        Me.btnVehicleList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehicleList.UseVisualStyleBackColor = True
        '
        'btnRptEmployeeList
        '
        Me.btnRptEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptEmployeeList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRptEmployeeList.FlatAppearance.BorderSize = 0
        Me.btnRptEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRptEmployeeList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptEmployeeList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnRptEmployeeList.Location = New System.Drawing.Point(0, 50)
        Me.btnRptEmployeeList.Name = "btnRptEmployeeList"
        Me.btnRptEmployeeList.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnRptEmployeeList.Size = New System.Drawing.Size(211, 25)
        Me.btnRptEmployeeList.TabIndex = 2
        Me.btnRptEmployeeList.Text = "Employee List"
        Me.btnRptEmployeeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRptEmployeeList.UseVisualStyleBackColor = True
        '
        'btnRptIssueList
        '
        Me.btnRptIssueList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptIssueList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRptIssueList.FlatAppearance.BorderSize = 0
        Me.btnRptIssueList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRptIssueList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptIssueList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnRptIssueList.Location = New System.Drawing.Point(0, 25)
        Me.btnRptIssueList.Name = "btnRptIssueList"
        Me.btnRptIssueList.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnRptIssueList.Size = New System.Drawing.Size(211, 25)
        Me.btnRptIssueList.TabIndex = 1
        Me.btnRptIssueList.Text = "Issue List"
        Me.btnRptIssueList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRptIssueList.UseVisualStyleBackColor = True
        '
        'btnEmployeesOutstanding
        '
        Me.btnEmployeesOutstanding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployeesOutstanding.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmployeesOutstanding.FlatAppearance.BorderSize = 0
        Me.btnEmployeesOutstanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeesOutstanding.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeesOutstanding.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEmployeesOutstanding.Location = New System.Drawing.Point(0, 0)
        Me.btnEmployeesOutstanding.Name = "btnEmployeesOutstanding"
        Me.btnEmployeesOutstanding.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnEmployeesOutstanding.Size = New System.Drawing.Size(211, 25)
        Me.btnEmployeesOutstanding.TabIndex = 0
        Me.btnEmployeesOutstanding.Text = "Employees Outstanding"
        Me.btnEmployeesOutstanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployeesOutstanding.UseVisualStyleBackColor = True
        '
        'btnOperationReports
        '
        Me.btnOperationReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperationReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOperationReports.FlatAppearance.BorderSize = 0
        Me.btnOperationReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOperationReports.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperationReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnOperationReports.Image = CType(resources.GetObject("btnOperationReports.Image"), System.Drawing.Image)
        Me.btnOperationReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperationReports.Location = New System.Drawing.Point(0, 700)
        Me.btnOperationReports.Name = "btnOperationReports"
        Me.btnOperationReports.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnOperationReports.Size = New System.Drawing.Size(213, 35)
        Me.btnOperationReports.TabIndex = 5
        Me.btnOperationReports.Text = "  Operation Reports"
        Me.btnOperationReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperationReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOperationReports.UseVisualStyleBackColor = True
        '
        'pnlAccountsReportsSubMenu
        '
        Me.pnlAccountsReportsSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlAccountsReportsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnDayBook)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnDailyCashTransactionReport)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnVoucherValidation)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnVouchersReport)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnReceivablePayableBalances)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnIncomeStatement)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnBalanceSHeet)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnTrialBalance)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnGeneralLedger)
        Me.pnlAccountsReportsSubMenu.Controls.Add(Me.btnChartofAccounts)
        Me.pnlAccountsReportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAccountsReportsSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlAccountsReportsSubMenu.Location = New System.Drawing.Point(0, 450)
        Me.pnlAccountsReportsSubMenu.Name = "pnlAccountsReportsSubMenu"
        Me.pnlAccountsReportsSubMenu.Size = New System.Drawing.Size(213, 250)
        Me.pnlAccountsReportsSubMenu.TabIndex = 10
        Me.pnlAccountsReportsSubMenu.Tag = "SubMenu"
        '
        'btnDayBook
        '
        Me.btnDayBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDayBook.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDayBook.FlatAppearance.BorderSize = 0
        Me.btnDayBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDayBook.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDayBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDayBook.Location = New System.Drawing.Point(0, 225)
        Me.btnDayBook.Name = "btnDayBook"
        Me.btnDayBook.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnDayBook.Size = New System.Drawing.Size(211, 25)
        Me.btnDayBook.TabIndex = 10
        Me.btnDayBook.Text = "Day Book"
        Me.btnDayBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDayBook.UseVisualStyleBackColor = True
        '
        'btnDailyCashTransactionReport
        '
        Me.btnDailyCashTransactionReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDailyCashTransactionReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDailyCashTransactionReport.FlatAppearance.BorderSize = 0
        Me.btnDailyCashTransactionReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDailyCashTransactionReport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyCashTransactionReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDailyCashTransactionReport.Location = New System.Drawing.Point(0, 200)
        Me.btnDailyCashTransactionReport.Name = "btnDailyCashTransactionReport"
        Me.btnDailyCashTransactionReport.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnDailyCashTransactionReport.Size = New System.Drawing.Size(211, 25)
        Me.btnDailyCashTransactionReport.TabIndex = 9
        Me.btnDailyCashTransactionReport.Text = "Daily Cash Transaction Report"
        Me.btnDailyCashTransactionReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDailyCashTransactionReport.UseVisualStyleBackColor = True
        '
        'btnVoucherValidation
        '
        Me.btnVoucherValidation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoucherValidation.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVoucherValidation.FlatAppearance.BorderSize = 0
        Me.btnVoucherValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucherValidation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoucherValidation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVoucherValidation.Location = New System.Drawing.Point(0, 175)
        Me.btnVoucherValidation.Name = "btnVoucherValidation"
        Me.btnVoucherValidation.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnVoucherValidation.Size = New System.Drawing.Size(211, 25)
        Me.btnVoucherValidation.TabIndex = 8
        Me.btnVoucherValidation.Text = "Voucher Validation"
        Me.btnVoucherValidation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoucherValidation.UseVisualStyleBackColor = True
        '
        'btnVouchersReport
        '
        Me.btnVouchersReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVouchersReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVouchersReport.FlatAppearance.BorderSize = 0
        Me.btnVouchersReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVouchersReport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVouchersReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVouchersReport.Location = New System.Drawing.Point(0, 150)
        Me.btnVouchersReport.Name = "btnVouchersReport"
        Me.btnVouchersReport.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnVouchersReport.Size = New System.Drawing.Size(211, 25)
        Me.btnVouchersReport.TabIndex = 7
        Me.btnVouchersReport.Text = "Vouchers"
        Me.btnVouchersReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVouchersReport.UseVisualStyleBackColor = True
        '
        'btnReceivablePayableBalances
        '
        Me.btnReceivablePayableBalances.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceivablePayableBalances.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReceivablePayableBalances.FlatAppearance.BorderSize = 0
        Me.btnReceivablePayableBalances.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceivablePayableBalances.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceivablePayableBalances.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnReceivablePayableBalances.Location = New System.Drawing.Point(0, 125)
        Me.btnReceivablePayableBalances.Name = "btnReceivablePayableBalances"
        Me.btnReceivablePayableBalances.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnReceivablePayableBalances.Size = New System.Drawing.Size(211, 25)
        Me.btnReceivablePayableBalances.TabIndex = 5
        Me.btnReceivablePayableBalances.Text = "Receivable / Payable"
        Me.btnReceivablePayableBalances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceivablePayableBalances.UseVisualStyleBackColor = True
        '
        'btnIncomeStatement
        '
        Me.btnIncomeStatement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncomeStatement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIncomeStatement.FlatAppearance.BorderSize = 0
        Me.btnIncomeStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncomeStatement.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncomeStatement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnIncomeStatement.Location = New System.Drawing.Point(0, 100)
        Me.btnIncomeStatement.Name = "btnIncomeStatement"
        Me.btnIncomeStatement.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnIncomeStatement.Size = New System.Drawing.Size(211, 25)
        Me.btnIncomeStatement.TabIndex = 4
        Me.btnIncomeStatement.Text = "Income Statment"
        Me.btnIncomeStatement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncomeStatement.UseVisualStyleBackColor = True
        '
        'btnBalanceSHeet
        '
        Me.btnBalanceSHeet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalanceSHeet.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBalanceSHeet.FlatAppearance.BorderSize = 0
        Me.btnBalanceSHeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalanceSHeet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalanceSHeet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBalanceSHeet.Location = New System.Drawing.Point(0, 75)
        Me.btnBalanceSHeet.Name = "btnBalanceSHeet"
        Me.btnBalanceSHeet.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnBalanceSHeet.Size = New System.Drawing.Size(211, 25)
        Me.btnBalanceSHeet.TabIndex = 3
        Me.btnBalanceSHeet.Text = "Balance Sheet"
        Me.btnBalanceSHeet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBalanceSHeet.UseVisualStyleBackColor = True
        '
        'btnTrialBalance
        '
        Me.btnTrialBalance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrialBalance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTrialBalance.FlatAppearance.BorderSize = 0
        Me.btnTrialBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrialBalance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrialBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnTrialBalance.Location = New System.Drawing.Point(0, 50)
        Me.btnTrialBalance.Name = "btnTrialBalance"
        Me.btnTrialBalance.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnTrialBalance.Size = New System.Drawing.Size(211, 25)
        Me.btnTrialBalance.TabIndex = 2
        Me.btnTrialBalance.Text = "Trial Balance"
        Me.btnTrialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrialBalance.UseVisualStyleBackColor = True
        '
        'btnGeneralLedger
        '
        Me.btnGeneralLedger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeneralLedger.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGeneralLedger.FlatAppearance.BorderSize = 0
        Me.btnGeneralLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneralLedger.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneralLedger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnGeneralLedger.Location = New System.Drawing.Point(0, 25)
        Me.btnGeneralLedger.Name = "btnGeneralLedger"
        Me.btnGeneralLedger.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnGeneralLedger.Size = New System.Drawing.Size(211, 25)
        Me.btnGeneralLedger.TabIndex = 1
        Me.btnGeneralLedger.Text = "General Ledger"
        Me.btnGeneralLedger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneralLedger.UseVisualStyleBackColor = True
        '
        'btnChartofAccounts
        '
        Me.btnChartofAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnChartofAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChartofAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChartofAccounts.FlatAppearance.BorderSize = 0
        Me.btnChartofAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChartofAccounts.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChartofAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnChartofAccounts.Location = New System.Drawing.Point(0, 0)
        Me.btnChartofAccounts.Name = "btnChartofAccounts"
        Me.btnChartofAccounts.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnChartofAccounts.Size = New System.Drawing.Size(211, 25)
        Me.btnChartofAccounts.TabIndex = 0
        Me.btnChartofAccounts.Text = "Chart of Accounts"
        Me.btnChartofAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChartofAccounts.UseVisualStyleBackColor = False
        '
        'btnAccountsReports
        '
        Me.btnAccountsReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccountsReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountsReports.FlatAppearance.BorderSize = 0
        Me.btnAccountsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountsReports.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountsReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAccountsReports.Image = CType(resources.GetObject("btnAccountsReports.Image"), System.Drawing.Image)
        Me.btnAccountsReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountsReports.Location = New System.Drawing.Point(0, 415)
        Me.btnAccountsReports.Name = "btnAccountsReports"
        Me.btnAccountsReports.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccountsReports.Size = New System.Drawing.Size(213, 35)
        Me.btnAccountsReports.TabIndex = 4
        Me.btnAccountsReports.Text = "  Account Reports"
        Me.btnAccountsReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountsReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccountsReports.UseVisualStyleBackColor = True
        '
        'pnlOperationsSubMenu
        '
        Me.pnlOperationsSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlOperationsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOperationsSubMenu.Controls.Add(Me.btnVehicleReceiving)
        Me.pnlOperationsSubMenu.Controls.Add(Me.btnSaleVoucher)
        Me.pnlOperationsSubMenu.Controls.Add(Me.btnVehicleIssuance)
        Me.pnlOperationsSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOperationsSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlOperationsSubMenu.Location = New System.Drawing.Point(0, 340)
        Me.pnlOperationsSubMenu.Name = "pnlOperationsSubMenu"
        Me.pnlOperationsSubMenu.Size = New System.Drawing.Size(213, 75)
        Me.pnlOperationsSubMenu.TabIndex = 8
        Me.pnlOperationsSubMenu.Tag = "SubMenu"
        Me.pnlOperationsSubMenu.Visible = False
        '
        'btnVehicleReceiving
        '
        Me.btnVehicleReceiving.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehicleReceiving.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVehicleReceiving.FlatAppearance.BorderSize = 0
        Me.btnVehicleReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehicleReceiving.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleReceiving.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVehicleReceiving.Location = New System.Drawing.Point(0, 50)
        Me.btnVehicleReceiving.Name = "btnVehicleReceiving"
        Me.btnVehicleReceiving.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnVehicleReceiving.Size = New System.Drawing.Size(211, 25)
        Me.btnVehicleReceiving.TabIndex = 2
        Me.btnVehicleReceiving.Text = "Vehicle Receiveing"
        Me.btnVehicleReceiving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehicleReceiving.UseVisualStyleBackColor = True
        '
        'btnSaleVoucher
        '
        Me.btnSaleVoucher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaleVoucher.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaleVoucher.FlatAppearance.BorderSize = 0
        Me.btnSaleVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaleVoucher.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaleVoucher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSaleVoucher.Location = New System.Drawing.Point(0, 25)
        Me.btnSaleVoucher.Name = "btnSaleVoucher"
        Me.btnSaleVoucher.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnSaleVoucher.Size = New System.Drawing.Size(211, 25)
        Me.btnSaleVoucher.TabIndex = 1
        Me.btnSaleVoucher.Text = "Transactions"
        Me.btnSaleVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaleVoucher.UseVisualStyleBackColor = True
        '
        'btnVehicleIssuance
        '
        Me.btnVehicleIssuance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehicleIssuance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVehicleIssuance.FlatAppearance.BorderSize = 0
        Me.btnVehicleIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehicleIssuance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleIssuance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVehicleIssuance.Location = New System.Drawing.Point(0, 0)
        Me.btnVehicleIssuance.Name = "btnVehicleIssuance"
        Me.btnVehicleIssuance.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnVehicleIssuance.Size = New System.Drawing.Size(211, 25)
        Me.btnVehicleIssuance.TabIndex = 0
        Me.btnVehicleIssuance.Text = "Vehicle Issuance"
        Me.btnVehicleIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehicleIssuance.UseVisualStyleBackColor = True
        '
        'btnOperations
        '
        Me.btnOperations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperations.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOperations.FlatAppearance.BorderSize = 0
        Me.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOperations.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnOperations.Image = CType(resources.GetObject("btnOperations.Image"), System.Drawing.Image)
        Me.btnOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperations.Location = New System.Drawing.Point(0, 305)
        Me.btnOperations.Name = "btnOperations"
        Me.btnOperations.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnOperations.Size = New System.Drawing.Size(213, 35)
        Me.btnOperations.TabIndex = 3
        Me.btnOperations.Text = "  Operations"
        Me.btnOperations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOperations.UseVisualStyleBackColor = True
        '
        'pnlVouchersSubMenu
        '
        Me.pnlVouchersSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlVouchersSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVouchersSubMenu.Controls.Add(Me.btnJV)
        Me.pnlVouchersSubMenu.Controls.Add(Me.btnBRV)
        Me.pnlVouchersSubMenu.Controls.Add(Me.btnBPV)
        Me.pnlVouchersSubMenu.Controls.Add(Me.btnCRV)
        Me.pnlVouchersSubMenu.Controls.Add(Me.btnCPV)
        Me.pnlVouchersSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVouchersSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlVouchersSubMenu.Location = New System.Drawing.Point(0, 180)
        Me.pnlVouchersSubMenu.Name = "pnlVouchersSubMenu"
        Me.pnlVouchersSubMenu.Size = New System.Drawing.Size(213, 125)
        Me.pnlVouchersSubMenu.TabIndex = 6
        Me.pnlVouchersSubMenu.Tag = "SubMenu"
        '
        'btnJV
        '
        Me.btnJV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnJV.FlatAppearance.BorderSize = 0
        Me.btnJV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJV.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnJV.Location = New System.Drawing.Point(0, 100)
        Me.btnJV.Name = "btnJV"
        Me.btnJV.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnJV.Size = New System.Drawing.Size(211, 25)
        Me.btnJV.TabIndex = 4
        Me.btnJV.Text = "Journal Voucher"
        Me.btnJV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJV.UseVisualStyleBackColor = True
        '
        'btnBRV
        '
        Me.btnBRV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBRV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBRV.FlatAppearance.BorderSize = 0
        Me.btnBRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBRV.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBRV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBRV.Location = New System.Drawing.Point(0, 75)
        Me.btnBRV.Name = "btnBRV"
        Me.btnBRV.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnBRV.Size = New System.Drawing.Size(211, 25)
        Me.btnBRV.TabIndex = 3
        Me.btnBRV.Text = "Bank Receipt Voucher"
        Me.btnBRV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBRV.UseVisualStyleBackColor = True
        '
        'btnBPV
        '
        Me.btnBPV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBPV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBPV.FlatAppearance.BorderSize = 0
        Me.btnBPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPV.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBPV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBPV.Location = New System.Drawing.Point(0, 50)
        Me.btnBPV.Name = "btnBPV"
        Me.btnBPV.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnBPV.Size = New System.Drawing.Size(211, 25)
        Me.btnBPV.TabIndex = 2
        Me.btnBPV.Text = "Bank Payment Voucher"
        Me.btnBPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBPV.UseVisualStyleBackColor = True
        '
        'btnCRV
        '
        Me.btnCRV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCRV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCRV.FlatAppearance.BorderSize = 0
        Me.btnCRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCRV.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCRV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnCRV.Location = New System.Drawing.Point(0, 25)
        Me.btnCRV.Name = "btnCRV"
        Me.btnCRV.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnCRV.Size = New System.Drawing.Size(211, 25)
        Me.btnCRV.TabIndex = 1
        Me.btnCRV.Text = "Cash Receipt Voucher"
        Me.btnCRV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCRV.UseVisualStyleBackColor = True
        '
        'btnCPV
        '
        Me.btnCPV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCPV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCPV.FlatAppearance.BorderSize = 0
        Me.btnCPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCPV.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnCPV.Location = New System.Drawing.Point(0, 0)
        Me.btnCPV.Name = "btnCPV"
        Me.btnCPV.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnCPV.Size = New System.Drawing.Size(211, 25)
        Me.btnCPV.TabIndex = 0
        Me.btnCPV.Text = "Cash Payment Voucher"
        Me.btnCPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCPV.UseVisualStyleBackColor = True
        '
        'btnVouchers
        '
        Me.btnVouchers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVouchers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVouchers.FlatAppearance.BorderSize = 0
        Me.btnVouchers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVouchers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVouchers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVouchers.Image = CType(resources.GetObject("btnVouchers.Image"), System.Drawing.Image)
        Me.btnVouchers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVouchers.Location = New System.Drawing.Point(0, 145)
        Me.btnVouchers.Name = "btnVouchers"
        Me.btnVouchers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnVouchers.Size = New System.Drawing.Size(213, 35)
        Me.btnVouchers.TabIndex = 2
        Me.btnVouchers.Text = "  Accounting Vouchers"
        Me.btnVouchers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVouchers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVouchers.UseVisualStyleBackColor = True
        '
        'pnlDefineSubMenu
        '
        Me.pnlDefineSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlDefineSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDefineSubMenu.Controls.Add(Me.btnEmployees)
        Me.pnlDefineSubMenu.Controls.Add(Me.btnVehicles)
        Me.pnlDefineSubMenu.Controls.Add(Me.btnCAO)
        Me.pnlDefineSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDefineSubMenu.ForeColor = System.Drawing.Color.Silver
        Me.pnlDefineSubMenu.Location = New System.Drawing.Point(0, 70)
        Me.pnlDefineSubMenu.Name = "pnlDefineSubMenu"
        Me.pnlDefineSubMenu.Size = New System.Drawing.Size(213, 75)
        Me.pnlDefineSubMenu.TabIndex = 4
        Me.pnlDefineSubMenu.Tag = "SubMenu"
        '
        'btnEmployees
        '
        Me.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmployees.FlatAppearance.BorderSize = 0
        Me.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployees.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEmployees.Location = New System.Drawing.Point(0, 50)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnEmployees.Size = New System.Drawing.Size(211, 25)
        Me.btnEmployees.TabIndex = 3
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnVehicles
        '
        Me.btnVehicles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehicles.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVehicles.FlatAppearance.BorderSize = 0
        Me.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehicles.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnVehicles.Location = New System.Drawing.Point(0, 25)
        Me.btnVehicles.Name = "btnVehicles"
        Me.btnVehicles.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnVehicles.Size = New System.Drawing.Size(211, 25)
        Me.btnVehicles.TabIndex = 1
        Me.btnVehicles.Text = "Vehicles"
        Me.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehicles.UseVisualStyleBackColor = True
        '
        'btnCAO
        '
        Me.btnCAO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCAO.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCAO.FlatAppearance.BorderSize = 0
        Me.btnCAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCAO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCAO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnCAO.Location = New System.Drawing.Point(0, 0)
        Me.btnCAO.Name = "btnCAO"
        Me.btnCAO.Padding = New System.Windows.Forms.Padding(43, 0, 0, 0)
        Me.btnCAO.Size = New System.Drawing.Size(211, 25)
        Me.btnCAO.TabIndex = 0
        Me.btnCAO.Text = "Chart of Accounts"
        Me.btnCAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCAO.UseVisualStyleBackColor = True
        '
        'btnDefine
        '
        Me.btnDefine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefine.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDefine.FlatAppearance.BorderSize = 0
        Me.btnDefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefine.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDefine.Image = CType(resources.GetObject("btnDefine.Image"), System.Drawing.Image)
        Me.btnDefine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefine.Location = New System.Drawing.Point(0, 35)
        Me.btnDefine.Name = "btnDefine"
        Me.btnDefine.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDefine.Size = New System.Drawing.Size(213, 35)
        Me.btnDefine.TabIndex = 1
        Me.btnDefine.Text = "  Define"
        Me.btnDefine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDefine.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(213, 35)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "  Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PanelNavigationHeader
        '
        Me.PanelNavigationHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PanelNavigationHeader.Controls.Add(Me.btnMenu)
        Me.PanelNavigationHeader.Controls.Add(Me.Label1)
        Me.PanelNavigationHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNavigationHeader.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PanelNavigationHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelNavigationHeader.Name = "PanelNavigationHeader"
        Me.PanelNavigationHeader.Size = New System.Drawing.Size(230, 50)
        Me.PanelNavigationHeader.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.ImageIndex = 0
        Me.btnMenu.ImageList = Me.imgList
        Me.btnMenu.Location = New System.Drawing.Point(-1, 7)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMenu.Size = New System.Drawing.Size(49, 35)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.TabStop = False
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(56, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Advance ERP"
        '
        'TabbedMDIManagerMain
        '
        Me.TabbedMDIManagerMain.AttachedTo = Me
        Me.TabbedMDIManagerMain.CloseButtonBackColor = System.Drawing.Color.OrangeRed
        Me.TabbedMDIManagerMain.CloseButtonToolTip = "Close"
        Me.TabbedMDIManagerMain.DropDownButtonToolTip = ""
        Me.TabbedMDIManagerMain.ImageSize = New System.Drawing.Size(24, 24)
        Me.TabbedMDIManagerMain.NeedUpdateHostedForm = False
        Me.TabbedMDIManagerMain.ShowCloseButton = True
        Me.TabbedMDIManagerMain.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbey)
        Me.TabbedMDIManagerMain.ThemeName = "TabRendererDockingWhidbey"
        Me.TabbedMDIManagerMain.ThemesEnabled = True
        Me.TabbedMDIManagerMain.UseIconsInTabs = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(41,Byte),Integer), CType(CType(52,Byte),Integer))
        Me.BackgroundImage = Global.Logitech.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(41,Byte),Integer), CType(CType(52,Byte),Integer))
        Me.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(41,Byte),Integer), CType(CType(52,Byte),Integer))
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(223,Byte),Integer), CType(CType(138,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1390, 1061)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.KeyPreview = true
        Me.Name = "frmMain"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software By Abeeha Technologies (+92 301 2786700 , +92 305 7815275)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlNavigation.ResumeLayout(false)
        Me.pnlNavigation.PerformLayout
        Me.PanelNavigationItems.ResumeLayout(false)
        Me.pnlUtilitiesSubMenu.ResumeLayout(false)
        Me.pnlOperationReportsSubMenu.ResumeLayout(false)
        Me.pnlAccountsReportsSubMenu.ResumeLayout(false)
        Me.pnlOperationsSubMenu.ResumeLayout(false)
        Me.pnlVouchersSubMenu.ResumeLayout(false)
        Me.pnlDefineSubMenu.ResumeLayout(false)
        Me.PanelNavigationHeader.ResumeLayout(false)
        Me.PanelNavigationHeader.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents pnlNavigation As System.Windows.Forms.Panel
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelNavigationItems As System.Windows.Forms.Panel
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents pnlUtilitiesSubMenu As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnUtilities As System.Windows.Forms.Button
    Friend WithEvents pnlSaleReportsSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnSaleReports As System.Windows.Forms.Button
    Friend WithEvents pnlOperationReportsSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnEmployeesOutstanding As System.Windows.Forms.Button
    Friend WithEvents btnOperationReports As System.Windows.Forms.Button
    Friend WithEvents pnlAccountsReportsSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnDayBook As System.Windows.Forms.Button
    Friend WithEvents btnDailyCashTransactionReport As System.Windows.Forms.Button
    Friend WithEvents btnVoucherValidation As System.Windows.Forms.Button
    Friend WithEvents btnVouchersReport As System.Windows.Forms.Button
    Friend WithEvents btnReceivablePayableBalances As System.Windows.Forms.Button
    Friend WithEvents btnIncomeStatement As System.Windows.Forms.Button
    Friend WithEvents btnBalanceSHeet As System.Windows.Forms.Button
    Friend WithEvents btnTrialBalance As System.Windows.Forms.Button
    Friend WithEvents btnGeneralLedger As System.Windows.Forms.Button
    Friend WithEvents btnChartofAccounts As System.Windows.Forms.Button
    Friend WithEvents btnAccountsReports As System.Windows.Forms.Button
    Friend WithEvents pnlVouchersSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnJV As System.Windows.Forms.Button
    Friend WithEvents btnBRV As System.Windows.Forms.Button
    Friend WithEvents btnBPV As System.Windows.Forms.Button
    Friend WithEvents btnCRV As System.Windows.Forms.Button
    Friend WithEvents btnCPV As System.Windows.Forms.Button
    Friend WithEvents btnVouchers As System.Windows.Forms.Button
    Friend WithEvents pnlDefineSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnVehicles As System.Windows.Forms.Button
    Friend WithEvents btnCAO As System.Windows.Forms.Button
    Friend WithEvents btnDefine As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents PanelNavigationHeader As System.Windows.Forms.Panel
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabbedMDIManagerMain As Syncfusion.Windows.Forms.Tools.TabbedMDIManager
    Friend WithEvents pnlOperationsSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnVehicleReceiving As System.Windows.Forms.Button
    Friend WithEvents btnSaleVoucher As System.Windows.Forms.Button
    Friend WithEvents btnVehicleIssuance As System.Windows.Forms.Button
    Friend WithEvents btnOperations As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnRptIssueList As System.Windows.Forms.Button
    Friend WithEvents btnRptEmployeeList As System.Windows.Forms.Button
    Friend WithEvents btnVehicleList As System.Windows.Forms.Button
End Class
