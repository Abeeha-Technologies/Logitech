Imports System.Data.SqlClient
Public Class frmRptBalances

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

    Private Sub btnPayables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayables.Click
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

    Private Sub btnReceivables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivables.Click
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

        qry.Append("SELECT dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) AS Balance, CASE WHEN (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) > 0 THEN (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) ELSE (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) * - 1 END AS BalancePlus, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName AS ParentAccName FROM dbo.tblAccChartOfAccounts LEFT OUTER JOIN dbo.vwGeneralJournal ON dbo.tblAccChartOfAccounts.AccCode = dbo.vwGeneralJournal.AccCode LEFT OUTER JOIN dbo.tblAccChartOfAccounts AS tblAccChartOfAccounts_1 ON dbo.tblAccChartOfAccounts.ParentAccCode = tblAccChartOfAccounts_1.AccCode WHERE (dbo.tblAccChartOfAccounts.IsAccount = 1) AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo) AND (dbo.tblAccChartOfAccounts.AccType = N'Customer' OR dbo.tblAccChartOfAccounts.AccType = N'Supplier') GROUP BY dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName HAVING (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) > 0)")

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Me.Text = "Receivables Report"

        rpt = New rptReceivables
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    End Sub

    Private Sub btnCashAndBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashAndBank.Click
        If Not bgwReporterCashAndBank.IsBusy Then
            bgwReporterCashAndBank.RunWorkerAsync()
        Else
            MsgBox("Please Wait While Processing your Previous Request.")
        End If
    End Sub
    Private Sub bgwReporterCashAndBank_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporterCashAndBank.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) AS Balance, CASE WHEN (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) > 0 THEN (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) ELSE (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit)) * - 1 END AS BalancePlus, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName AS ParentAccName FROM dbo.tblAccChartOfAccounts LEFT OUTER JOIN dbo.vwGeneralJournal ON dbo.tblAccChartOfAccounts.AccCode = dbo.vwGeneralJournal.AccCode LEFT OUTER JOIN dbo.tblAccChartOfAccounts AS tblAccChartOfAccounts_1 ON dbo.tblAccChartOfAccounts.ParentAccCode = tblAccChartOfAccounts_1.AccCode WHERE (dbo.tblAccChartOfAccounts.IsAccount = 1) AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo) AND (dbo.tblAccChartOfAccounts.AccType = N'Cash') OR (dbo.tblAccChartOfAccounts.AccType = N'Bank') GROUP BY dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName HAVING (SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) <> 0)")

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Me.Text = "Cash and Bank Account Report"

        rpt = New rptCashAndBank
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
End Class