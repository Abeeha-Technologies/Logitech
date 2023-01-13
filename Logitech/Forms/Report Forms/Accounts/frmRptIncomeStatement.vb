Imports System.Data.SqlClient
Public Class frmRptIncomeStatement
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

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If chkMonthly.Checked = False Then
            If Not bgwReporter.IsBusy Then
                bgwReporter.RunWorkerAsync()
            Else
                MsgBox("Please Wait While Processing your Previous Request.")
            End If
        End If
        If chkMonthly.Checked = True Then
            If Not bgwReportMonthly.IsBusy Then
                bgwReportMonthly.RunWorkerAsync()
            Else
                MsgBox("Please Wait While Processing your Previous Request.")
            End If
        End If
    End Sub



    Private Sub bgwReporter_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporter.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT dbo.vwGeneralJournal.AccCode, dbo.vwGeneralJournal.AccName, SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) AS CurrentBalance, CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END AS CurrentBalancePlus, dbo.vwGeneralJournal.AccLevel, dbo.vwGeneralJournal.AccNature, dbo.vwGeneralJournal.AccType, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName AS ParentAccName FROM dbo.tblAccChartOfAccounts AS tblAccChartOfAccounts_1 RIGHT OUTER JOIN dbo.tblAccChartOfAccounts ON tblAccChartOfAccounts_1.AccCode = dbo.tblAccChartOfAccounts.ParentAccCode RIGHT OUTER JOIN dbo.vwGeneralJournal ON dbo.tblAccChartOfAccounts.AccCode = dbo.vwGeneralJournal.AccCode WHERE (dbo.vwGeneralJournal.TransactionDate >= @DateFrom) AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo) AND (dbo.vwGeneralJournal.IsAccount = 1) AND (dbo.vwGeneralJournal.AccNature = 'Revenue' OR dbo.vwGeneralJournal.AccNature = 'Expense') GROUP BY dbo.vwGeneralJournal.AccCode, dbo.vwGeneralJournal.AccName, dbo.vwGeneralJournal.AccLevel, dbo.vwGeneralJournal.AccNature,  dbo.vwGeneralJournal.AccType, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName")
        If chkWithZeroBalance.Checked = False Then
            qry.Append(" HAVING SUM(Debit - Credit) <> 0")
        End If
        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        rpt = New rptIncomeStatement
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateFrom", dtpDateFrom.Value)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    End Sub

    Private Sub bgwReportMonthly_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReportMonthly.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT AccCode, AccName, AccLevel, AccNature, AccType, ParentAccCode, ParentAccName, SUM(Jul) AS Jul, SUM(Aug) AS Aug, SUM(Sep) AS Sep, SUM(Oct) AS Oct, SUM(Nov) AS Nov, SUM(Dec) AS Dec, SUM(Jan) AS Jan, SUM(Feb) AS Feb, SUM(Mar) AS Mar, SUM(Apr) AS Apr, SUM(May) AS May, SUM(Jun) AS June FROM (SELECT dbo.vwGeneralJournal.AccCode, dbo.vwGeneralJournal.AccName, SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit) AS CurrentBalance, CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END AS CurrentBalancePlus, dbo.vwGeneralJournal.AccLevel, dbo.vwGeneralJournal.AccNature, dbo.vwGeneralJournal.AccType, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName AS ParentAccName, DATEPART(m, dbo.vwGeneralJournal.TransactionDate) AS Month, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 7 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Jul, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 8 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Aug, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 9 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Sep, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 10 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Oct, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 11 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Nov, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 12 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Dec, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 1 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Jan, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 2 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Feb, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 3 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Mar, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 4 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Apr, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 5 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS May, CASE WHEN DATEPART(m, dbo.vwGeneralJournal.TransactionDate) = 6 THEN CASE WHEN vwGeneralJournal.AccNature = 'Expense' THEN SUM(Debit - Credit) ELSE SUM(Debit - Credit) * - 1 END ELSE 0 END AS Jun FROM dbo.tblAccChartOfAccounts AS tblAccChartOfAccounts_1 RIGHT OUTER JOIN dbo.tblAccChartOfAccounts ON tblAccChartOfAccounts_1.AccCode = dbo.tblAccChartOfAccounts.ParentAccCode RIGHT OUTER JOIN dbo.vwGeneralJournal ON dbo.tblAccChartOfAccounts.AccCode = dbo.vwGeneralJournal.AccCode WHERE (dbo.vwGeneralJournal.TransactionDate >= @DateFrom) AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo) AND (dbo.vwGeneralJournal.IsAccount = 1) AND (dbo.vwGeneralJournal.AccNature = 'Revenue' OR dbo.vwGeneralJournal.AccNature = 'Expense') GROUP BY dbo.vwGeneralJournal.AccCode, dbo.vwGeneralJournal.AccName, dbo.vwGeneralJournal.AccLevel, dbo.vwGeneralJournal.AccNature, dbo.vwGeneralJournal.AccType, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName, DATEPART(m, dbo.vwGeneralJournal.TransactionDate)")
        If chkWithZeroBalance.Checked = False Then
            qry.Append(" HAVING SUM(Debit - Credit) <> 0")
        End If
        qry.Append(") AS vwIncomeStatement GROUP BY AccCode, AccName, AccLevel, AccNature, AccType, ParentAccCode, ParentAccName")
        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        rpt = New rptIncomeStatementMonthly
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateFrom", dtpDateFrom.Value)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)

        If chkHideDetail.Checked = True Then
            rpt.Section3.SectionFormat.EnableSuppress = True
            rpt.SetParameterValue("IsSummary", True)
        Else
            rpt.Section3.SectionFormat.EnableSuppress = False
            rpt.SetParameterValue("IsSummary", False)
        End If
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    End Sub
    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        If chkMonthly.Checked = True Then
            frm.Text = "Income Statment (Monthly)"
        Else
            frm.Text = "Income Statment"
        End If

        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub


End Class