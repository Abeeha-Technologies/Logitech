Imports System.Data.SqlClient
Public Class frmRptDTR
    Dim rpt As Object

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        'Sart Calculating Opening and Closing Cash

        Dim OpeningCash As Decimal
        Dim BalanceCash As Decimal
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        If vDefaultCashAccCode = Nothing Then
            MsgBox("Cash Account is not defined in Settings." & vbNewLine & "To do this, Go to Settings --> Voucher --> Default Cash Account")
            Exit Sub
        End If

        Try

            With cmd
                .Connection = Conn
                .CommandText = "SELECT SUM(Debit - Credit) AS Opening FROM vwGeneralJournal WHERE AccCode = '" & vDefaultCashAccCode & "' AND TransactionDate < @DateFrom"
                .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            OpeningCash = Val(dt.Rows(0).Item(0).ToString)


            Dim cmd1 As New SqlCommand
            Dim da1 As New SqlDataAdapter
            Dim dt1 As New DataTable
            With cmd1
                .Connection = Conn
                .CommandText = "SELECT SUM(Debit - Credit) AS Balance FROM vwGeneralJournal WHERE AccCode = '" & vDefaultCashAccCode & "' AND TransactionDate <= @DateTo"
                .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
            End With

            da1.SelectCommand = cmd1
            dt1.Clear()
            da1.Fill(dt1)

            BalanceCash = Val(dt1.Rows(0).Item(0).ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If
            cmd.Dispose()

        End Try

        'Stop Calculating Opening and Closing Cash

        With cmd
            .Connection = Conn
            .CommandText = "SELECT VoucherId, VoucherType, TransactionDate, AccCode, Description, ChequeNumber, Debit, Credit, AccName, AccLevel, AccNature, AccType, VoucherYear, VoucherMonth, VoucherNo, SysTimeStamp, IsAccount FROM dbo.vwGeneralJournal WHERE (dbo.vwGeneralJournal.TransactionDate >= @DateFrom) AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo)"
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        rpt = New rptDailyTransactionReport
        rpt.SetDataSource(dt)
        rpt.SetParameterValue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateFrom", dtpDateFrom.Value.ToString)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value.ToString)
        rpt.SetParameterValue("OpeningCash", OpeningCash)
        rpt.SetParameterValue("ClosingCash", BalanceCash)


        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()
    End Sub

    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        frm.Text = "Daily Transaction Report"
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmRptDTR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub


    
   
End Class