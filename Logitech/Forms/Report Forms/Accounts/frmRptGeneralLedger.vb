Imports System.Data.SqlClient
Public Class frmRptGeneralLedger
    Dim rpt As Object

    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAcc.Click
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "ReportGeneralLedger"

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

        qry.Append("SELECT GL.VoucherId, GL.VoucherType, GL.TransactionDate, GL.AccCode, GL.Description, GL.ChequeNumber, GL.Debit, GL.Credit, GL.AccName, GL.AccLevel, GL.AccNature, GL.AccType, GL.IsOpening ")
        qry.Append("FROM (")

        qry.Append("SELECT '' AS VoucherId, '' AS VoucherType, '' AS TransactionDate, AccCode, 'Opening Balance' AS Description, '' AS ChequeNumber, SUM(Debit) AS Debit, SUM(Credit) AS Credit, AccName, AccLevel, AccNature, AccType, 1 AS IsOpening FROM dbo.vwGeneralJournal WHERE TransactionDate < @DateFrom AND IsAccount = 1")
        If Val(txtAccCode.Text) > 0 Then
            qry.Append(" AND AccCode LIKE '" & Trim(txtAccCode.Text) & "%'")
        End If

        qry.Append(" GROUP BY AccCode, AccName, AccLevel, AccNature, AccType")
        qry.Append(" UNION ALL ")
        qry.Append("SELECT VoucherId, VoucherType, TransactionDate, AccCode, Description, ChequeNumber, Debit, Credit, AccName, AccLevel, AccNature, AccType, 0 AS IsOpening FROM dbo.vwGeneralJournal WHERE TransactionDate >= @DateFrom AND TransactionDate <= @DateTo AND IsAccount = 1")

        If Val(txtAccCode.Text) > 0 Then
            qry.Append(" AND AccCode LIKE '" & Trim(txtAccCode.Text) & "%'")
        End If

        qry.Append(") AS GL")

        If chkWithZeroBalance.Checked = False Then
            qry.Append(" INNER JOIN (")
            qry.Append("SELECT AccCode, SUM(Debit - Credit) AS Balance FROM dbo.vwGeneralJournal AS vwGeneralJournal_2 WHERE (TransactionDate <= @DateTo) AND (IsAccount = 1) GROUP BY AccCode HAVING (SUM(Debit - Credit) <> 0)")
            qry.Append(") AS NotZero ON NotZero.AccCode = GL.AccCode")
        End If

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
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


        rpt = New rptGeneralLedger
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateFrom", dtpDateFrom.Value)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
        
    End Sub


    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        frm.Text = "General Ledger"
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