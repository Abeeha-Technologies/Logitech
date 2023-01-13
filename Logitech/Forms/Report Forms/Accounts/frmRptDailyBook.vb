Imports System.Data.SqlClient
Public Class frmRptDailyBook

    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAcc.Click
        ShowAccSearchDialog("ReportDayBook", "DayBook")

    End Sub

    Sub ShowAccSearchDialog(ByVal Source1 As String, ByVal Source2 As String)
        ' Get the value that the child will be initialised with
        Dim InitialValue1, InitialValue2 As String
        InitialValue1 = Nothing
        InitialValue2 = Nothing

        InitialValue1 = Source1
        InitialValue2 = Source2

        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(InitialValue1, InitialValue2)

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
        If txtAccName.Text = Nothing Then
            MsgBox("Pleasse sselect Valid Account")
            Exit Sub
        End If

        If Not bgwReporter.IsBusy Then
            bgwReporter.RunWorkerAsync()
        Else
            MsgBox("Please Wait While Processing your Previous Request.")
        End If
    End Sub



    Private Sub bgwReporter_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporter.RunWorkerCompleted
        GetAccOpeningBalance(txtAccCode.Text, dtpDateFrom.Text)
        GetAccClosingBalance(txtAccCode.Text, dtpDateFrom.Text)
        If chkAccountSpecific.Checked = True Then
            GetReceiptTransactions(txtAccCode.Text, dtpDateFrom.Value.Date, dtpDateTo.Value.Date, True)
            GetPaymentTransactions(txtAccCode.Text, dtpDateFrom.Value.Date, dtpDateTo.Value.Date, True)
        Else
            GetReceiptTransactions(txtAccCode.Text, dtpDateFrom.Value.Date, dtpDateTo.Value.Date, False)
            GetPaymentTransactions(txtAccCode.Text, dtpDateFrom.Value.Date, dtpDateTo.Value.Date, False)
        End If
        

    End Sub
    Sub GetReceiptTransactions(ByVal AccCode As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal IsSpecific As Boolean)
        dgvReceipts.Rows.Clear()

        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Dim qry As New System.Text.StringBuilder

        If IsSpecific = True Then
            qry.Append("SELECT VoucherId, AccCode, AccName, Credit AS Amount FROM dbo.vwDayBook WHERE (TransactionDate >= @DateFrom) AND (TransactionDate <= @DateTo) AND (MasterAccCode = @MasterAccCode) AND (Credit > 0)")
        Else
            qry.Append("SELECT VoucherId, AccCode, AccName, Credit AS Amount FROM dbo.vwDayBook WHERE (TransactionDate >= @DateFrom) AND (TransactionDate <= @DateTo) AND (Credit > 0) AND (VoucherType <> N'SV' AND VoucherType <> N'PRV' AND VoucherType <> N'TrV')")
            qry.Append(" UNION ALL ")
            qry.Append("SELECT VoucherId, AccCode, AccName, Debit AS Amount FROM dbo.vwDayBook WHERE (TransactionDate >= @DateFrom) AND (TransactionDate <= @DateTo) AND (VoucherType <> N'PRV') AND (VoucherType <> N'TrV') AND (MasterAccCode = @MasterAccCode)")
        End If



        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@MasterAccCode", SqlDbType.NVarChar).Value = AccCode
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = DateFrom
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = DateTo
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows

                dgvReceipts.Rows.Add(row("VoucherId"), row("AccCode"), row("AccName"), row("Amount"))
            Next
        Else
            dgvReceipts.Rows.Clear()
        End If

    End Sub
    Sub GetPaymentTransactions(ByVal AccCode As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal IsSpecific As Boolean)
        dgvPayments.Rows.Clear()

        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Dim qry As New System.Text.StringBuilder

        If IsSpecific = True Then

            qry.Append("SELECT VoucherId, AccCode, AccName, Debit AS Amount FROM dbo.vwDayBook WHERE (TransactionDate >= @DateFrom) AND (TransactionDate <= @DateTo) AND (MasterAccCode = @MasterAccCode) AND (Debit > 0)")
        Else
            qry.Append("SELECT VoucherId, AccCode, AccName, Debit AS Amount FROM dbo.vwDayBook WHERE (TransactionDate >= @DateFrom) AND (TransactionDate <= @DateTo) AND (Debit > 0) AND (VoucherType <> N'SV' AND VoucherType <> N'PRV' AND VoucherType <> N'TrV')")
        End If





        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@MasterAccCode", SqlDbType.NVarChar).Value = AccCode
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = DateFrom
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = DateTo
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows

                dgvPayments.Rows.Add(row("VoucherId"), row("AccCode"), row("AccName"), row("Amount"))
            Next
        Else
            dgvPayments.Rows.Clear()
        End If

    End Sub


    Private Sub txtAccCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccCode.KeyDown
        If e.KeyCode = Keys.Space Then
            btnSearchAcc_Click(sender, e)
        End If
    End Sub

    Sub GetAccDetail(ByVal Source As String, ByVal AccCode As String)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim cmdText As New System.Text.StringBuilder
        cmdText.Append("SELECT AccName, AccNature, CreditLimit, CreditDays FROM tblAccChartOfAccounts WHERE IsAccount = 1 AND AccCode = @AccCode")

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
            If Source = "Main" Then
                txtAccName.Text = dt.Rows(0).Item("AccName")
            

            End If
        Else
            If Source = "Main" Then
                txtAccName.Text = Nothing

            End If
        End If

        

    End Sub
    Sub GetAccOpeningBalance(ByVal AccCode As String, ByVal DateTo As Date)
        Dim dt As New DataTable
        Dim dClosing As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT SUM(Debit-Credit) AS Balance FROM vwGeneralJournal WHERE IsAccount = 1 AND AccCode = @AccCode AND TransactionDate < @DateTo"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateFrom.Value.Date
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim Balance, BalancePlus As Double
        Dim DrCr As String = "Nill"

        Balance = Val(dt.Rows(0).Item("Balance").ToString)

        If Balance > 0 Then
            BalancePlus = Balance
            DrCr = "Dr"
        ElseIf Balance < 0 Then
            BalancePlus = Balance * -1
            DrCr = "Cr"
        Else
            DrCr = "Nill"
        End If
        '

        txtOpeningBalance.Text = Format(BalancePlus, "#,###") & " " & DrCr



    End Sub

    Sub GetAccClosingBalance(ByVal AccCode As String, ByVal DateTo As Date)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT SUM(Debit-Credit) AS Balance FROM vwGeneralJournal WHERE IsAccount = 1 AND AccCode = @AccCode AND TransactionDate <= @DateTo"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim Balance, BalancePlus As Double
        Dim DrCr As String = "Nill"

        Balance = Val(dt.Rows(0).Item("Balance").ToString)

        If Balance > 0 Then
            BalancePlus = Balance
            DrCr = "Dr"
        ElseIf Balance < 0 Then
            BalancePlus = Balance * -1
            DrCr = "Cr"
        Else
            DrCr = "Nill"
        End If
        '

        txtClosingBalance.Text = Format(BalancePlus, "#,###") & " " & DrCr


    End Sub

    Private Sub txtAccCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCode.TextChanged
        GetAccDetail("Main", Trim(txtAccCode.Text))
        

    End Sub



    Private Sub frmRptDailyBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAccCode.Text = vDefaultCashAccCode
    End Sub

    Private Sub dgvReceipts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReceipts.CellContentClick
        CalculateReceiptsTotal()
    End Sub
    Private Sub dgvReceipts_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvReceipts.RowsAdded
        CalculateReceiptsTotal()
    End Sub

    Private Sub dgvReceipts_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvReceipts.RowsRemoved
        CalculateReceiptsTotal()
    End Sub

    
    Sub CalculateReceiptsTotal()
        txtTotalReceipts.Text = CDec(0)
        If dgvReceipts.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvReceipts.Rows
                txtTotalReceipts.Text += CDec(row.Cells("dgvReceiptsAmount").Value)

            Next
        End If
        
    End Sub

    Private Sub dgvPayments_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPayments.CellContentClick
        CalculatePaymentsTotal()
    End Sub
    Private Sub dgvPayments_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvPayments.RowsAdded
        CalculatePaymentsTotal()
    End Sub

    Private Sub dgvPayments_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvPayments.RowsRemoved
        CalculatePaymentsTotal()
    End Sub
    Sub CalculatePaymentsTotal()
        txtTotalPayments.Text = CDec(0)
        If dgvPayments.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvPayments.Rows
                txtTotalPayments.Text += CDec(row.Cells("dgvPaymentsAmount").Value)

            Next
        End If
        
    End Sub

End Class