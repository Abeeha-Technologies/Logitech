Imports System.Data.SqlClient
Public Class frmDashboard

    Dim TotalSales As Decimal

    Dim dtSales As New DataTable
    Dim dtCashAndBanks As New DataTable


    Private Sub frmDashboard_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If Me.Tag = "Dashboard" Then
        '    e.Cancel = True
        'End If
    End Sub



    Private Sub cboSale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSale.SelectedIndexChanged
        If cboSale.SelectedItem = "Last 7 Days" Then
            dtpDateFromSale.Value = DateTime.Today.AddDays(-7)
            dtpDateToSale.Value = Today
            lblSaleAmountDetail.Text = "Total Sale" & vbNewLine & "(" & dtpDateFromSale.Value.ToString("dd-MMM") & " - " & dtpDateToSale.Value.ToString("dd-MMM") & ")"
        ElseIf cboSale.SelectedItem = "This Month" Then
            dtpDateFromSale.Value = New DateTime(Today.Year, Today.Month, 1)
            dtpDateToSale.Value = Today
            lblSaleAmountDetail.Text = "Total Sale (" & MonthName(Today.Month, True) & ")"
        ElseIf cboSale.SelectedItem = "Last Month" Then

            dtpDateFromSale.Value = New DateTime(Today.Year, Today.Month - 1, 1)
            dtpDateToSale.Value = New DateTime(Today.Year, Today.Month - 1, DateTime.DaysInMonth(Today.Year, Today.Month - 1))
            lblSaleAmountDetail.Text = "Total Sale (" & MonthName(Today.Month - 1, True) & ")"
        End If

        GetSales(dtpDateFromSale.Value, dtpDateToSale.Value)
    End Sub


    Private Sub frmDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboSale.SelectedItem = "Last 7 Days"

        LoadDashboadData()

    End Sub
    Sub LoadDashboadData()
        GetSales(dtpDateFromSale.Value, dtpDateToSale.Value)
        GetIdExpire()
        GetPassportExpire()
        GetVehicleExpire()

        GetCashAndBanks()
    End Sub


    Private Sub GetSales(ByVal DateFrom As Date, ByVal DateTo As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT TransactionDate AS Date, SUM(Credit - Debit) AS Amount FROM dbo.vwGeneralJournal WHERE (AccType = N'Revenue') GROUP BY TransactionDate HAVING (TransactionDate >= @DateFrom AND TransactionDate <= @DateTo)"
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = DateFrom
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = DateTo
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)


        TotalSales = 0

        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                TotalSales += Val(row(1))
            Next

        End If

        dtSales = dt

        lblSalesAmount.Text = "Rs, " & TotalSales

        ChartSale.DataSource = dtSales
        ChartSale.Series(0).Points.Clear()
        ChartSale.Series(0).XValueMember = "Date"
        ChartSale.Series(0).XValueType = DataVisualization.Charting.ChartValueType.Date
        ChartSale.Series(0).YValueMembers = "Amount"
        ChartSale.Series(0).YValueType = DataVisualization.Charting.ChartValueType.Double

    End Sub

    Private Sub GetIdExpire()
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT EmployeeName, IdExpiry AS [Expiry Date] FROM dbo.tblEmployees GROUP BY EmployeeName, IdExpiry HAVING (IdExpiry <= @IdExpiry) ORDER BY EmployeeName"
            .Parameters.Clear()
            .Parameters.Add("@IdExpiry", SqlDbType.Date).Value = DateTime.Today.AddDays(15)

        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dgvIdExpire.Rows.Clear()

        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                dgvIdExpire.Rows.Add(row("EmployeeName"), row("Expiry Date"))

            Next


        End If
        If dgvIdExpire.RowCount > 0 Then
            dgvIdExpire.CurrentCell.Selected = False
        End If
    End Sub

    Private Sub GetPassportExpire()
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT EmployeeName, PassportExpiry AS [Expiry Date] FROM dbo.tblEmployees GROUP BY EmployeeName, PassportExpiry HAVING (PassportExpiry <= @PassportExpiry) ORDER BY EmployeeName"
            .Parameters.Clear()
            .Parameters.Add("@PassportExpiry", SqlDbType.Date).Value = DateTime.Today.AddDays(15)

        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dgvPassportExpire.Rows.Clear()


        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                dgvPassportExpire.Rows.Add(row("EmployeeName"), row("Expiry Date"))
            Next


        End If
        If dgvPassportExpire.Rows.Count > 0 Then
            dgvPassportExpire.CurrentCell.Selected = False
        End If

    End Sub

    Private Sub GetVehicleExpire()
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT VehicleNumber, ExpiryDate AS [Expiry Date] FROM dbo.tblVehicles GROUP BY VehicleNumber, ExpiryDate HAVING (ExpiryDate <= @ExpiryDate) ORDER BY VehicleNumber"
            .Parameters.Clear()
            .Parameters.Add("@ExpiryDate", SqlDbType.Date).Value = DateTime.Today.AddDays(15)

        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dgvVehicleExpire.Rows.Clear()


        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows
                dgvVehicleExpire.Rows.Add(row("VehicleNumber"), row("Expiry Date"))
            Next


        End If
        If dgvVehicleExpire.Rows.Count > 0 Then
            dgvVehicleExpire.CurrentCell.Selected = False
        End If

    End Sub


    Sub GetCashAndBanks()
        'Dim dt As New DataTable
        'Dim cmd As New SqlCommand
        'Dim da As New SqlDataAdapter

        'With cmd
        '    .Connection = Conn
        '    .CommandText = "SELECT dbo.tblAccChartOfAccounts.AccName, ISNULL(SUM(dbo.vwGeneralJournal.Debit - dbo.vwGeneralJournal.Credit), 0) AS Balance FROM dbo.tblAccChartOfAccounts LEFT OUTER JOIN dbo.vwGeneralJournal ON dbo.tblAccChartOfAccounts.AccCode = dbo.vwGeneralJournal.AccCode WHERE (dbo.tblAccChartOfAccounts.IsAccount = 1) AND (dbo.tblAccChartOfAccounts.AccType = N'Cash' OR dbo.tblAccChartOfAccounts.AccType = N'Bank') AND (dbo.vwGeneralJournal.TransactionDate <= @DateTo) GROUP BY dbo.tblAccChartOfAccounts.AccName"
        '    .Parameters.Clear()
        '    .Parameters.Add("@DateTo", SqlDbType.Date).Value = Today.Date
        'End With

        'da.SelectCommand = cmd
        'dt.Clear()
        'da.Fill(dt)



        'dgvCashBankBalances.DataSource = dt

        'dgvCashBankBalances.Columns("AccName").Width = 250
        'dgvCashBankBalances.Columns("Balance").Width = 80
        'dgvCashBankBalances.Columns("Balance").DefaultCellStyle.Format = "N0"
        'dgvCashBankBalances.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvCashBankBalances.Columns("AccName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartSale.Click
        'frmSalesGraph.Show()
    End Sub

    Private Sub dgvCashBankBalances_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCashBankBalances.CellFormatting
        'Compare the value of second Column i.e. Column with Index 1.
        If e.ColumnIndex = 1 AndAlso e.Value IsNot Nothing Then

            'Fetch the value of the second Column.
            Dim Amount As Decimal = Convert.ToInt64(e.Value)

            'Apply Background color based on value.
            If Amount = 0 Then
                e.CellStyle.ForeColor = Color.Green
            End If

            If Amount > 0 Then
                e.CellStyle.ForeColor = Color.Green
            End If

            If Amount < 0 Then
                e.CellStyle.ForeColor = Color.Red
            End If
        End If
    End Sub


End Class