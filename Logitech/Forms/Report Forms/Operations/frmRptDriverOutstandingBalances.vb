Imports System.Data.SqlClient
Public Class frmRptDriverOutstandingBalances

    Dim rpt As Object

    Private Sub frmReportChartOfAccounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            If (ActiveControl.GetType) Is GetType(ComboBox) Then

                Dim ctl As ComboBox = ActiveControl

                If ctl.DroppedDown = True Then

                Else
                    Me.Close()
                End If

            Else
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPayables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not bgwReportPayables.IsBusy Then
            bgwReportPayables.RunWorkerAsync()
        Else
            MsgBox("Please Wait While Processing your Previous Request.")
        End If
    End Sub



    Private Sub bgwReportPayables_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReportPayables.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) AS Balance, CASE WHEN (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) > 0 THEN (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) ELSE (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) * - 1 END AS BalancePlus, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName AS ParentAccName FROM dbo.tblAccChartOfAccounts LEFT OUTER JOIN dbo.vwGeneralJournal ON dbo.tblAccChartOfAccounts.AccCode = dbo.vwGeneralJournal.AccCode LEFT OUTER JOIN dbo.tblAccChartOfAccounts AS tblAccChartOfAccounts_1 ON dbo.tblAccChartOfAccounts.ParentAccCode = tblAccChartOfAccounts_1.AccCode WHERE (dbo.tblAccChartOfAccounts.IsAccount = 1) AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo) AND (dbo.tblAccChartOfAccounts.AccType = N'Customer' OR dbo.tblAccChartOfAccounts.AccType = N'Supplier') GROUP BY dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName HAVING (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) < 0)")

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        Me.Text = "Payable Report"


        rpt = New rptPayables
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    End Sub

    Private Sub btnReceivables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        If Not bgwReporterReceivables.IsBusy Then
            bgwReporterReceivables.RunWorkerAsync()
        Else
            MsgBox("Please Wait While Processing your Previous Request.")
        End If
    End Sub
    Private Sub bgwReporterReceivables_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporterReceivables.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.GLAccCode, dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.RentPerDay, DATEDIFF(day, dbo.tblVehicleIssuance.IssueDate, @DateTo) + 1 AS TotalDays, (DATEDIFF(day, dbo.tblVehicleIssuance.IssueDate, @DateTo) + 1) * dbo.tblVehicleIssuance.RentPerDay AS TotalReceivable, SUM(ISNULL(dbo.tblVehicleIssueTransactionDetail.Amount, 0)) AS TotalReceived, ISNULL(derivedtbl_LedgerBalance.Balance, 0) AS NonReceiptBalance FROM (SELECT dbo.vwGeneralJournal.AccCode, SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) AS Balance FROM dbo.vwGeneralJournal INNER JOIN dbo.tblEmployees AS tblEmployees_1 ON dbo.vwGeneralJournal.AccCode = tblEmployees_1.GLAccCode WHERE (dbo.vwGeneralJournal.VoucherType <> N'RECEIPT') GROUP BY dbo.vwGeneralJournal.AccCode) AS derivedtbl_LedgerBalance RIGHT OUTER JOIN dbo.tblEmployees ON derivedtbl_LedgerBalance.AccCode = dbo.tblEmployees.GLAccCode RIGHT OUTER JOIN dbo.tblVehicleIssueTransactionDetail INNER JOIN dbo.tblVehicleIssueTransactionMaster ON dbo.tblVehicleIssueTransactionDetail.TransactionNumber = dbo.tblVehicleIssueTransactionMaster.TransactionNumber RIGHT OUTER JOIN dbo.tblVehicleIssuance ON dbo.tblVehicleIssueTransactionMaster.IssueId = dbo.tblVehicleIssuance.IssueId ON dbo.tblEmployees.EmployeeId = dbo.tblVehicleIssuance.EmployeeId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) GROUP BY dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.GLAccCode, dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.RentPerDay, ISNULL(derivedtbl_LedgerBalance.Balance, 0)")

        If cboEmployee.SelectedIndex > 0 Then
            qry.Append(" HAVING (dbo.tblVehicleIssuance.EmployeeId = " & cboEmployee.SelectedValue & ")")
        End If

        qry.Append(" ORDER BY dbo.tblEmployees.EmployeeName")

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Me.Text = "Outstanding Report"

        rpt = New rptEmployeeOutstanding
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    End Sub

   
    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        frm.Text = Me.Text
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmRptDriverOutstandingBalances_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillCboEmployee()
    End Sub
    Sub FillCboEmployee()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.GLAccCode FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) GROUP BY dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.GLAccCode ORDER BY dbo.tblEmployees.EmployeeName"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("EmployeeId") = 0
        row.Item("EmployeeName") = "(--All--)"
        row.Item("GLAccCode") = String.Empty

        dt.Rows.InsertAt(row, 0)

        cboEmployee.DataSource = dt
        cboEmployee.DisplayMember = "EmployeeName"
        cboEmployee.ValueMember = "EmployeeId"

        cboEmployee.SelectedValue = 0

        txtEmployeeGLCode.DataBindings.Clear()
        txtEmployeeGLCode.DataBindings.Add(New Binding("Text", dt, "GLAccCode"))


    End Sub
End Class