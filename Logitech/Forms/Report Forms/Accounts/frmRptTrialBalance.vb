Imports System.Data.SqlClient
Public Class frmRptTrialBalance
    Dim rpt As Object
    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAcc.Click
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "ReportTrialBalance"

        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(initialValue, Nothing)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub

    Private Sub frmReportChartOfAccounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnSearchAcc_Click(sender, e)
        End If
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
        If Not bgwReporter.IsBusy Then
            bgwReporter.RunWorkerAsync()
        Else
            MsgBox("Please Wait While Processing your Previous Request.")
        End If
    End Sub



    Private Sub bgwReporter_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporter.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT Trial.AccCode, Trial.AccName, Trial.CurrentDebit, Trial.CurrentCredit, Trial.AccType, Trial.OpeningDebit, Trial.OpeningCredit, Trial.ParentAccCode, Trial.ParentAccName ")
        qry.Append("FROM (")

        qry.Append("SELECT dbo.tblAccChartOfAccounts.AccCode, dbo.tblAccChartOfAccounts.AccName, ISNULL(vwGeneralJournal_2.CurrentDebit, 0) AS CurrentDebit, ISNULL(vwGeneralJournal_2.CurrentCredit, 0) AS CurrentCredit, dbo.tblAccChartOfAccounts.AccType, ISNULL((SELECT SUM(Debit) AS OpeningDebit FROM dbo.vwGeneralJournal WHERE (AccCode = dbo.tblAccChartOfAccounts.AccCode) AND (TransactionDate < @DateFrom)), 0) AS OpeningDebit, ISNULL((SELECT SUM(Credit) AS OpeningCredit FROM dbo.vwGeneralJournal AS vwGeneralJournal_3 WHERE (AccCode = dbo.tblAccChartOfAccounts.AccCode) AND (TransactionDate < @DateFrom)), 0) AS OpeningCredit, dbo.tblAccChartOfAccounts.ParentAccCode, tblAccChartOfAccounts_1.AccName AS ParentAccName FROM dbo.tblAccChartOfAccounts LEFT OUTER JOIN dbo.tblAccChartOfAccounts AS tblAccChartOfAccounts_1 ON dbo.tblAccChartOfAccounts.ParentAccCode = tblAccChartOfAccounts_1.AccCode LEFT OUTER JOIN (SELECT     AccCode, SUM(Debit) AS CurrentDebit, SUM(Credit) AS CurrentCredit FROM dbo.vwGeneralJournal AS vwGeneralJournal_1 WHERE (TransactionDate >= @DateFrom) AND (TransactionDate <= @DateTo) GROUP BY AccCode) AS vwGeneralJournal_2 ON dbo.tblAccChartOfAccounts.AccCode = vwGeneralJournal_2.AccCode WHERE (dbo.tblAccChartOfAccounts.IsAccount = 1)")
        If Val(txtAccCode.Text) > 0 Then
            qry.Append(" AND tblAccChartOfAccounts.AccCode LIKE '" & Trim(txtAccCode.Text) & "%'")
        End If

        qry.Append(") AS Trial")

        If chkWithZeroBalance.Checked = False Then
            qry.Append(" INNER JOIN (")
            qry.Append("SELECT AccCode, SUM(Debit - Credit) AS Balance FROM dbo.vwGeneralJournal AS vwGeneralJournal_2 WHERE (TransactionDate <= @DateTo) AND (IsAccount = 1) GROUP BY AccCode HAVING (SUM(Debit - Credit) <> 0)")
            qry.Append(") AS NotZero ON NotZero.AccCode = Trial.AccCode")
        End If

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            If Val(txtAccCode.Text) > 0 Then
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
            End If
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count < 1 Then
            MsgBox("No Record to Show")
            Exit Sub
        End If


        

        rpt = New rptTrialBalance
        rpt.SetDataSource(dt)

        rpt.SetParameterValue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateFrom", dtpDateFrom.Value)
        rpt.SetParameterValue("DateTo", dtpDateFrom.Value)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    
    End Sub

    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        frm.Text = "Trial Balance"
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub txtAccCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccCode.KeyDown
        If e.KeyCode = Keys.Space Then
            btnSearchAcc_Click(sender, e)
        End If
    End Sub
    Sub GetAccDetail(ByVal AccCode As String)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim cmdText As New System.Text.StringBuilder
        cmdText.Append("SELECT AccName, AccNature FROM tblAccChartOfAccounts WHERE IsAccount = 1 AND AccCode = @AccCode")

        With cmd
            .Connection = Conn
            .CommandText = cmdText.ToString
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            txtAccName.Text = dt.Rows(0).Item("AccName")
        Else

            txtAccName.Text = Nothing
        End If



    End Sub

    Private Sub txtAccCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCode.TextChanged
        GetAccDetail(Trim(txtAccCode.Text))
    End Sub

  

End Class