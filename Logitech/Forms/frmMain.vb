Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        HideAllSubMenus()


        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width

        If screenWidth < 1679 Then
            CollapeNavigation()

        End If


        'Start User Permissions
        If vCanCreateUsers = False Then
            btnUsers.Visible = False
        End If

        If vCanEnterAccountingVoucher = False Then
            btnVouchers.Visible = False

        End If

        If vCanEnterOperationalVoucher = False Then
            btnOperations.Visible = False
        End If

        If vCanDefineOperations = False Then
            btnVehicles.Visible = False
            btnEmployees.Visible = False

        End If

        If vCanDefineAccounts = False Then
            btnCAO.Visible = False

        End If

        If vCanSystemSettings = False Then

            btnSettings.Visible = False
        End If

        If vCanDefineAccounts = False And vCanDefineOperations = False Then
            btnDefine.Visible = False
        End If

        If vCanViewIncomeStatementReport = False Then
            btnIncomeStatement.Visible = False

        End If


        If vCanViewBalanceSheetReport = False Then
            btnBalanceSHeet.Visible = False

        End If

        If vCanViewTrialBalanceReport = False Then
            btnTrialBalance.Visible = False

        End If

        If vCanViewGeneralLedgerReport = False Then
            btnGeneralLedger.Visible = False

        End If

        If vCanViewPurchaseReport = False Then
            ''PurchaseReportsToolStripMenuItem.Visible = False
        End If
        If vCanViewSaleReport = False Then
            'SaleReportsToolStripMenuItem.Visible = False
        End If

        If vCanViewDashboard = True Then
            frmDashboard.MdiParent = Me
            frmDashboard.StartPosition = FormStartPosition.CenterScreen
            frmDashboard.Show()
            frmDashboard.Activate()
            btnHome.Visible = True
        Else
            btnHome.Visible = False
        End If
        'End User Permissions

    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If pnlNavigation.Width >= 230 Then
            HideAllSubMenus()
            CollapeNavigation()
        Else
            ExpandNavigation()
        End If
    End Sub
    Sub HideAllSubMenus()

        'Start Old Code
        'If pnlDefineSubMenu.Visible = True Then
        '    pnlDefineSubMenu.Visible = False
        'End If
        'If pnlVouchers.Visible = True Then
        '    pnlVouchers.Visible = False
        'End If

        'End Old Code

        For Each ctl As Control In PanelNavigationItems.Controls

            Dim subMenu As Panel
            If TypeOf ctl Is Panel Then
                subMenu = ctl
                If subMenu.Tag = "SubMenu" Then
                    subMenu.Visible = False

                End If
            End If


        Next

    End Sub
    Dim IsExpanded = True
    Sub CollapeNavigation()
        'Dim tmr As New Timer
        'tmr.Interval = 1
        'tmr.Start()
        'AddHandler tmr.Tick, Sub()
        '                         If pnlNavigation.Width >= 230 Then
        '                             pnlNavigation.Width -= 23
        '                         End If
        '                         If pnlNavigation.Width <= 50 Then
        '                             tmr.Stop()
        '                         End If
        '                     End Sub
        pnlNavigation.Width = 49
        btnMenu.Image = imgList.Images(0)
        IsExpanded = False
    End Sub
    Sub ExpandNavigation()
        'Dim tmr As New Timer
        'tmr.Interval = 1
        'tmr.Start()
        'AddHandler tmr.Tick, Sub()
        '                         If pnlNavigation.Width <= 230 Then
        '                             pnlNavigation.Width += 23
        '                         End If
        '                         If pnlNavigation.Width >= 230 Then
        '                             tmr.Stop()
        '                         End If
        '                     End Sub
        pnlNavigation.Width = 230
        btnMenu.Image = imgList.Images(1)
        IsExpanded = True
    End Sub
    Sub ShowSubMenu(ByVal subMenu As Panel)

        If IsExpanded = False Then
            ExpandNavigation()
        End If

        If subMenu.Visible = False Then
            'HideSubMenus(subMenu)
            HideAllSubMenus()

            subMenu.Height = 0
            subMenu.Visible = True

            'Start Here
            Dim SubMenuHeight As Integer = 0
            For Each btn As Button In subMenu.Controls
                If btn.Visible = True Then
                    SubMenuHeight += btn.Height
                End If
            Next

            Dim tmr As New Timer
            tmr.Interval = 10
            tmr.Start()
            AddHandler tmr.Tick, Sub()
                                     If subMenu.Height <= SubMenuHeight Then
                                         subMenu.Height += 8
                                     End If
                                     If subMenu.Height >= SubMenuHeight Then
                                         tmr.Stop()
                                     End If
                                 End Sub
        Else
            'subMenu.Visible = False
            HideAllSubMenus()
        End If
    End Sub
    
    Private Sub btnDefine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefine.Click
        ShowSubMenu(pnlDefineSubMenu)
    End Sub

    Private Sub btnCAO_Click(sender As System.Object, e As System.EventArgs) Handles btnCAO.Click
        If vAccounting = "Advanced" Then
            frmAccountsAdvanced.MdiParent = Me
            frmAccountsAdvanced.StartPosition = FormStartPosition.CenterScreen
            frmAccountsAdvanced.Show()

            frmAccountsAdvanced.Activate()

        ElseIf vAccounting = "Simple" Then
            frmAccountsSimple.MdiParent = Me
            frmAccountsSimple.StartPosition = FormStartPosition.CenterScreen
            frmAccountsSimple.Show()

            frmAccountsSimple.Activate()

        End If
    End Sub
    Private Sub btnVehicles_Click(sender As System.Object, e As System.EventArgs) Handles btnVehicles.Click
        frmVehicles.MdiParent = Me
        frmVehicles.StartPosition = FormStartPosition.CenterScreen
        frmVehicles.Show()

        frmVehicles.Activate()
    End Sub
    Private Sub btnGodown_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployees.Click
        frmEmployees.MdiParent = Me
        frmEmployees.StartPosition = FormStartPosition.CenterScreen
        frmEmployees.Show()

        frmEmployees.Activate()
    End Sub

    Private Sub btnCPV_Click(sender As System.Object, e As System.EventArgs) Handles btnCPV.Click
        frmPaymentVoucher.MdiParent = Me
        frmPaymentVoucher.StartPosition = FormStartPosition.CenterScreen
        frmPaymentVoucher.Show()
        frmPaymentVoucher.Activate()
        frmPaymentVoucher.ShowDetailPanel()
        frmPaymentVoucher.cboVoucherType.SelectedItem = "CPV"
        frmPaymentVoucher.cboVoucherTypeSearch.SelectedItem = "CPV"
    End Sub

    Private Sub btnCRV_Click(sender As System.Object, e As System.EventArgs) Handles btnCRV.Click
        frmReceiptVoucher.MdiParent = Me
        frmReceiptVoucher.StartPosition = FormStartPosition.CenterScreen
        frmReceiptVoucher.Show()
        frmReceiptVoucher.Activate()
        frmReceiptVoucher.ShowDetailPanel()
        frmReceiptVoucher.cboVoucherType.SelectedItem = "CRV"
        frmReceiptVoucher.cboVoucherTypeSearch.SelectedItem = "CRV"
    End Sub

    Private Sub btnBPV_Click(sender As System.Object, e As System.EventArgs) Handles btnBPV.Click
        frmPaymentVoucher.MdiParent = Me
        frmPaymentVoucher.StartPosition = FormStartPosition.CenterScreen
        frmPaymentVoucher.Show()
        frmPaymentVoucher.Activate()
        frmPaymentVoucher.ShowDetailPanel()
        frmPaymentVoucher.cboVoucherType.SelectedItem = "BPV"
        frmPaymentVoucher.cboVoucherTypeSearch.SelectedItem = "BPV"
    End Sub

    Private Sub btnBRV_Click(sender As System.Object, e As System.EventArgs) Handles btnBRV.Click
        frmReceiptVoucher.MdiParent = Me
        frmReceiptVoucher.StartPosition = FormStartPosition.CenterScreen
        frmReceiptVoucher.Show()
        frmReceiptVoucher.Activate()
        frmReceiptVoucher.ShowDetailPanel()
        frmReceiptVoucher.cboVoucherType.SelectedItem = "BRV"
        frmReceiptVoucher.cboVoucherTypeSearch.SelectedItem = "BRV"
    End Sub

    Private Sub btnJV_Click(sender As System.Object, e As System.EventArgs) Handles btnJV.Click
        frmJournalVoucher.MdiParent = Me
        frmJournalVoucher.StartPosition = FormStartPosition.CenterScreen
        frmJournalVoucher.Show()
        frmJournalVoucher.Activate()
    End Sub

  
  
    Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        ShowSettingDialog("General", Nothing)
    End Sub

    Private Sub btnHome_Click(sender As System.Object, e As System.EventArgs) Handles btnHome.Click


        frmDashboard.MdiParent = Me
        frmDashboard.StartPosition = FormStartPosition.CenterScreen
        frmDashboard.Show()
        frmDashboard.Activate()

    End Sub

    Private Sub btnVouchers_Click(sender As System.Object, e As System.EventArgs) Handles btnVouchers.Click
        ShowSubMenu(pnlVouchersSubMenu)
    End Sub

   
 
    
    Private Sub btnOperations_Click(sender As System.Object, e As System.EventArgs) Handles btnOperations.Click
        ShowSubMenu(pnlOperationsSubMenu)
    End Sub
    Private Sub btnPurchaseVoucher_Click(sender As System.Object, e As System.EventArgs) Handles btnVehicleIssuance.Click
        frmVehicleIssuance.MdiParent = Me
        frmVehicleIssuance.StartPosition = FormStartPosition.CenterScreen
        frmVehicleIssuance.Show()
        frmVehicleIssuance.Activate()
    End Sub

    Private Sub btnSaleVoucher_Click(sender As System.Object, e As System.EventArgs) Handles btnSaleVoucher.Click
        frmVehicleIssueTransactionNew.MdiParent = Me
        frmVehicleIssueTransactionNew.StartPosition = FormStartPosition.CenterScreen
        frmVehicleIssueTransactionNew.Show()
        frmVehicleIssueTransactionNew.Activate()
    End Sub

    Private Sub btnVehicleReceiving_Click(sender As System.Object, e As System.EventArgs) Handles btnVehicleReceiving.Click
        frmVehicleReceiving.MdiParent = Me
        frmVehicleReceiving.StartPosition = FormStartPosition.CenterScreen
        frmVehicleReceiving.Show()
        frmVehicleReceiving.Activate()
    End Sub

    Private Sub btnAccountsReports_Click(sender As System.Object, e As System.EventArgs) Handles btnAccountsReports.Click
        ShowSubMenu(pnlAccountsReportsSubMenu)
    End Sub

    Private Sub btnChartofAccounts_Click(sender As System.Object, e As System.EventArgs) Handles btnChartofAccounts.Click
        frmRptChartOfAccounts.MdiParent = Me
        frmRptChartOfAccounts.StartPosition = FormStartPosition.CenterScreen
        frmRptChartOfAccounts.Show()

        frmRptChartOfAccounts.Activate()
    End Sub

    Private Sub btnGeneralLedger_Click(sender As System.Object, e As System.EventArgs) Handles btnGeneralLedger.Click
        frmRptGeneralLedger.MdiParent = Me
        frmRptGeneralLedger.StartPosition = FormStartPosition.CenterScreen
        frmRptGeneralLedger.Show()
        frmRptGeneralLedger.Activate()
    End Sub

    Private Sub btnTrialBalance_Click(sender As System.Object, e As System.EventArgs) Handles btnTrialBalance.Click
        frmRptTrialBalance.MdiParent = Me
        frmRptTrialBalance.StartPosition = FormStartPosition.CenterScreen
        frmRptTrialBalance.Show()
        frmRptTrialBalance.Activate()
    End Sub

    Private Sub btnBalanceSHeet_Click(sender As System.Object, e As System.EventArgs) Handles btnBalanceSHeet.Click
        frmRptBalanceSheet.MdiParent = Me
        frmRptBalanceSheet.StartPosition = FormStartPosition.CenterScreen
        frmRptBalanceSheet.Show()
        frmRptBalanceSheet.Activate()
    End Sub

    Private Sub btnIncomeStatement_Click(sender As System.Object, e As System.EventArgs) Handles btnIncomeStatement.Click
        frmRptIncomeStatement.MdiParent = Me
        frmRptIncomeStatement.StartPosition = FormStartPosition.CenterScreen
        frmRptIncomeStatement.Show()
        frmRptIncomeStatement.Activate()
    End Sub

    Private Sub btnReceivablePayableBalances_Click(sender As System.Object, e As System.EventArgs) Handles btnReceivablePayableBalances.Click
        frmRptBalances.MdiParent = Me
        frmRptBalances.StartPosition = FormStartPosition.CenterScreen
        frmRptBalances.Show()
        frmRptBalances.Activate()
    End Sub


    Private Sub btnVouchersReport_Click(sender As System.Object, e As System.EventArgs) Handles btnVouchersReport.Click
        frmRptVouchers.MdiParent = Me
        frmRptVouchers.StartPosition = FormStartPosition.CenterScreen
        frmRptVouchers.Show()
        frmRptVouchers.Activate()
    End Sub

    Private Sub btnVoucherValidation_Click(sender As System.Object, e As System.EventArgs) Handles btnVoucherValidation.Click
        frmRptVoucherValidation.MdiParent = Me
        frmRptVoucherValidation.StartPosition = FormStartPosition.CenterScreen
        frmRptVoucherValidation.Show()
        frmRptVoucherValidation.Activate()
    End Sub

    Private Sub btnDailyCashTransactionReport_Click(sender As System.Object, e As System.EventArgs) Handles btnDailyCashTransactionReport.Click
        frmRptDTR.MdiParent = Me
        frmRptDTR.StartPosition = FormStartPosition.CenterScreen
        frmRptDTR.Show()
        frmRptDTR.Activate()
    End Sub

    Private Sub btnDayBook_Click(sender As System.Object, e As System.EventArgs) Handles btnDayBook.Click
        frmRptDailyBook.MdiParent = Me
        frmRptDailyBook.StartPosition = FormStartPosition.CenterScreen
        frmRptDailyBook.Show()
        frmRptDailyBook.Activate()
    End Sub

    Private Sub btnOperationReports_Click(sender As System.Object, e As System.EventArgs) Handles btnOperationReports.Click
        ShowSubMenu(pnlOperationReportsSubMenu)
    End Sub

    Private Sub btnUtilities_Click(sender As System.Object, e As System.EventArgs) Handles btnUtilities.Click
        ShowSubMenu(pnlUtilitiesSubMenu)
    End Sub

    Private Sub frmMain_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.WindowState = FormWindowState.Minimized
        Application.ExitThread()
    End Sub

    
    Private Sub btnUsers_Click(sender As System.Object, e As System.EventArgs) Handles btnUsers.Click
        Dim frm As New frmUsers(Nothing, Nothing)

        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
        frm.Activate()
    End Sub

    Private Sub btnChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles btnChangePassword.Click
        frmChangePassword.MdiParent = Me
        frmChangePassword.StartPosition = FormStartPosition.CenterScreen
        frmChangePassword.Show()
        frmChangePassword.Activate()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        frmRecordLog.MdiParent = Me
        frmRecordLog.StartPosition = FormStartPosition.CenterScreen
        frmRecordLog.Show()
        frmRecordLog.Activate()
    End Sub

    
    Private Sub btnEmployeesOutstanding_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployeesOutstanding.Click
        frmRptDriverOutstandingBalances.MdiParent = Me
        frmRptDriverOutstandingBalances.StartPosition = FormStartPosition.CenterScreen
        frmRptDriverOutstandingBalances.Show()

        frmRptDriverOutstandingBalances.Activate()
    End Sub

    Private Sub btnRptIssueList_Click(sender As System.Object, e As System.EventArgs) Handles btnRptIssueList.Click
        frmRptIssueDetail.MdiParent = Me
        frmRptIssueDetail.StartPosition = FormStartPosition.CenterScreen
        frmRptIssueDetail.Show()

        frmRptIssueDetail.Activate()
    End Sub

    Private Sub btnRptEmployeeList_Click(sender As System.Object, e As System.EventArgs) Handles btnRptEmployeeList.Click
        frmRptEmployeeDetailList.MdiParent = Me
        frmRptEmployeeDetailList.StartPosition = FormStartPosition.CenterScreen
        frmRptEmployeeDetailList.Show()

        frmRptEmployeeDetailList.Activate()
    End Sub

    Private Sub btnVehicleList_Click(sender As System.Object, e As System.EventArgs) Handles btnVehicleList.Click
        frmRptVehicleDetailList.MdiParent = Me
        frmRptVehicleDetailList.StartPosition = FormStartPosition.CenterScreen
        frmRptVehicleDetailList.Show()

        frmRptVehicleDetailList.Activate()
    End Sub
End Class