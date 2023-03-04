Imports System.Data.SqlClient
Public Class frmVehicleIssueTransaction

    Dim TblSearchListBindingSource As New BindingSource

    Dim blnIsFormLoaded As Boolean = False

    Sub SetFormStateNew()
        blnIsFormLoaded = False

        FillCboEmployee()

        ClearAllFields()

        FillMainSearchList()

        cboTransactionType.Focus()

        blnIsFormLoaded = True

    End Sub


    Sub ClearAllFields()

        txtId.Text = Nothing
        dtpTransactionDate.Value = Now.Date
        cboTransactionType.SelectedIndex = 0
        cboEmployee.SelectedIndex = 0
        dtpDateFrom.Value = Now.Date
        dtpDateTo.Value = Now.Date
        txtGrossDays.Text = 1
        txtLessDays.Text = 0
        txtNetDays.Text = 1
        txtRentPerDay.Text = 0
        txtAmount.Text = 0
        dtpTransactionDate.Value = Now.Date
        txtRentPerDay.Text = 0
        txtRemarks.Text = Nothing

        txtUser.Text = vUserName




    End Sub

    
    Sub FillCboEmployee()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) GROUP BY dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("EmployeeId") = 0
        row.Item("EmployeeName") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)

        cboEmployee.DataSource = dt
        cboEmployee.DisplayMember = dt.Columns("EmployeeName").ToString
        cboEmployee.ValueMember = dt.Columns("EmployeeId").ToString

        


    End Sub

    Sub FillCboShiftVehicleByEmployeeId(EmployeeId As Long)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            '.CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.IdNumber, dbo.tblEmployees.IdExpiry, dbo.tblEmployees.ContactNumber, dbo.tblEmployees.IBAN, dbo.tblEmployees.PassportNumber, dbo.tblEmployees.PassportExpiry, dbo.tblEmployees.Nationality, dbo.tblEmployees.Designation, dbo.tblEmployees.JoiningDate, dbo.tblVehicleIssuance.VehicleId, dbo.tblVehicles.VehicleNumber, dbo.tblVehicleIssuance.Remarks, dbo.tblVehicleIssuance.RentPerDay FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId LEFT OUTER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) ORDER BY dbo.tblVehicles.VehicleNumber"
            .CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicles.VehicleNumber AS Vehicle, dbo.tblVehicleIssuance.Shift, dbo.tblVehicleIssuance.RentPerDay AS [Rent / Day] FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) AND (dbo.tblVehicleIssuance.EmployeeId = @EmployeeId) ORDER BY dbo.tblVehicles.VehicleNumber"
            .Parameters.Clear()
            .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = EmployeeId
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("IssueId") = 0
        row.Item("Vehicle") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)


        cboShiftVehicle.DataSource = dt
        cboShiftVehicle.DisplayMember = dt.Columns("Vehicle").ToString
        cboShiftVehicle.ValueMember = dt.Columns("IssueId").ToString

        Dim gch As Syncfusion.Windows.Forms.Grid.GridColHidden = New Syncfusion.Windows.Forms.Grid.GridColHidden(1) 'Hides column number '1'
        cboShiftVehicle.ListBox.Grid.ColHiddenEntries.Add(gch)

        'gch = New Syncfusion.Windows.Forms.Grid.GridColHidden(3) 'Hides column number '3'
        'cboShiftVehicle.ListBox.Grid.ColHiddenEntries.Add(gch)

        cboShiftVehicle.ListBox.Grid.ColWidths(2) = 120
        cboShiftVehicle.ListBox.Grid.ColWidths(3) = 80
        cboShiftVehicle.ListBox.Grid.ColWidths(4) = 100
        cboShiftVehicle.ListBox.Grid.ColStyles(2).AutoSize = True


        'txtIssueId.DataBindings.Clear()
        'txtIssueId.DataBindings.Add(New Binding("Text", dt, "IssueId"))

        'txtIssueDate.DataBindings.Clear()
        'txtIssueDate.DataBindings.Add(New Binding("Text", dt, "IssueDate"))

        'txtIssueDriver.DataBindings.Clear()
        'txtIssueDriver.DataBindings.Add(New Binding("Text", dt, "EmployeeName"))

        'txtIssueRemarks.DataBindings.Clear()
        'txtIssueRemarks.DataBindings.Add(New Binding("Text", dt, "Remarks"))

        'txtIssueRentPerDay.DataBindings.Clear()
        'txtIssueRentPerDay.DataBindings.Add(New Binding("Text", dt, "RentPerDay"))


    End Sub


    Sub FillMainSearchList()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As String
        Dim cmd As New SqlCommand

        qryStr = "SELECT TransactionId AS Id, TransactionDate AS Date FROM dbo.tblVehicleIssueTransactions"

        With cmd
            .Connection = Conn
            .CommandText = qryStr.ToString
            .Parameters.Clear()

        End With
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        TblSearchListBindingSource.DataSource = dt

        dgvList.DataSource = TblSearchListBindingSource

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If


        If dt.Rows.Count > 0 Then
            dgvList.Columns("Id").Visible = True
            dgvList.Columns("Date").Width = 120
            dgvList.Columns("Date").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If


        If SplitContainer.Panel2Collapsed = False Then
            HideColumns()
        Else
            ShowColumns()

        End If

    End Sub

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStateNew()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SetFormStateNew()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtId.Text <> Nothing Then
            If MsgBox("Do you Really Want to Delete?" & vbNewLine & "This event is not reversable.", vbYesNo + vbCritical, "Confirmation") = vbYes Then

                If vRequireUserPasswordForDelete = "True" Then
                    frmPasswordInput.ShowDialog()
                    If frmPasswordInput.DialogResult = System.Windows.Forms.DialogResult.Yes Then

                        Delete(txtId.Text)
                        Exit Sub
                    Else

                        Exit Sub
                    End If

                End If

                Delete(txtId.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal AccId As Long)

        'Try
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter


        'With cmd
        '    .Connection = Conn
        '    .CommandType = CommandType.Text
        '    .CommandText = "SELECT VoucherId FROM vwGeneralJournal WHERE VoucherType <> 'Opening Balance' AND AccCode = @AccCode"
        '    .Parameters.Clear()
        '    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
        'End With

        'da.SelectCommand = cmd
        'dt.Clear()
        'da.Fill(dt)
        'If dt.Rows.Count > 0 Then
        '    Dim str As New System.Text.StringBuilder

        '    For i = 0 To dt.Rows.Count - 1
        '        If i = 0 Then
        '            str.Append(dt.Rows(i).Item("VoucherId").ToString)
        '        Else
        '            str.Append(" | " & dt.Rows(i).Item("VoucherId").ToString)
        '        End If
        '    Next

        '    MsgBox("You can not Delete Current record. There is transactions in following vouchers" & vbNewLine & str.ToString)
        '    Exit Sub
        'End If

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()

        End If

        'If dt.Rows.Count = 0 Then
        With cmd
            .Connection = Conn
            .CommandText = "DELETE FROM tblVehicleIssueTransactions WHERE IssueId = @IssueId"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = AccId
            .ExecuteNonQuery()
        End With
        MsgBox("Deleted Successfully")

        'End If

        SetFormStateNew()
        'Catch ex As Exception

        'Finally
        '    If Conn.State <> ConnectionState.Closed Then
        '        Conn.Close()
        '    End If

        'End Try


    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cboTransactionType.SelectedIndex < 1 Then
            MsgBox("Please Select Transaction", , "Error")
            cboTransactionType.Focus()
            Exit Sub
        End If

        If cboShiftVehicle.SelectedIndex < 0 Then
            MsgBox("Please Select Vehicle", , "Error")
            cboShiftVehicle.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If


        'Inser if Record is New
        If txtId.Text = Nothing Then

            'Start Inserting New Record
            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            Try

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "INSERT INTO tblVehicleIssueTransactions (IssueId, TransactionDate, DateFrom, DateTo, GrossDays, LessDays, NetDays, RentPerDay, Amount, TransactionType, Remarks, EnteredBy) VALUES (@IssueId, @TransactionDate, @DateFrom, @DateTo, @GrossDays, @LessDays, @NetDays, @RentPerDay, @Amount, @TransactionType, @Remarks, @EnteredBy)"
                    .Parameters.Clear()
                    .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 1).CellValue.ToString
                    .Parameters.Add("@TransactionDate", SqlDbType.Date).Value = dtpTransactionDate.Value
                    .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
                    .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value
                    .Parameters.Add("@GrossDays", SqlDbType.Int).Value = txtGrossDays.Text
                    .Parameters.Add("@LessDays", SqlDbType.Int).Value = txtLessDays.Text
                    .Parameters.Add("@NetDays", SqlDbType.Int).Value = txtNetDays.Text
                    .Parameters.Add("@RentPerDay", SqlDbType.Decimal).Value = txtRentPerDay.Text
                    .Parameters.Add("@Amount", SqlDbType.Decimal).Value = txtAmount.Text
                    .Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = cboTransactionType.SelectedItem
                    .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text
                    .Parameters.Add("@EnteredBy", SqlDbType.NVarChar).Value = vUserName

                    .ExecuteNonQuery()
                End With

                trans.Commit()
                MsgBox("Added Successfully")
                SetFormStateNew()

            Catch ex As Exception
                MessageBox.Show("Commit Exception Type: " & ex.GetType.ToString & Chr(13) & "Message: " & ex.Message)
                Try
                    trans.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show("Rollback Exception Type: " & ex2.GetType.ToString & Chr(13) & "Message: " & ex2.Message)
                End Try

            Finally
                cmd.Dispose()
                If Conn.State <> ConnectionState.Closed Then
                    Conn.Close()
                End If

            End Try

        End If

        If txtId.Text <> Nothing Then

            With cmd
                .CommandText = "UPDATE tblVehicleIssueTransactions SET IssueId = @IssueId, TransactionDate = @TransactionDate, DateFrom = @DateFrom, DateTo = @DateTo, GrossDays = @GrossDays, LessDays = @LessDays, NetDays = @NetDays, RentPerDay = @RentPerDay, Amount = @Amount, TransactionType = @TransactionType, Remarks = @Remarks WHERE TransactionId = @Original_TransactionId"
                .Parameters.Clear()
                .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 1).CellValue.ToString
                .Parameters.Add("@TransactionDate", SqlDbType.Date).Value = dtpTransactionDate.Value
                .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
                .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value
                .Parameters.Add("@GrossDays", SqlDbType.Int).Value = txtGrossDays.Text
                .Parameters.Add("@LessDays", SqlDbType.Int).Value = txtLessDays.Text
                .Parameters.Add("@NetDays", SqlDbType.Int).Value = txtNetDays.Text
                .Parameters.Add("@RentPerDay", SqlDbType.Decimal).Value = txtRentPerDay.Text
                .Parameters.Add("@Amount", SqlDbType.Decimal).Value = txtAmount.Text
                .Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = cboTransactionType.SelectedItem
                .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text
                .Parameters.Add("@Original_TransactionId", SqlDbType.BigInt).Value = Val(txtId.Text)
                .ExecuteNonQuery()
            End With

            MsgBox("Updated Successfully")
            SetFormStateNew()

        End If


    End Sub


    Private Sub frmAccounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnSave_Click(Me, Nothing)

        End If
        If e.KeyCode = Keys.F5 Then
            btnRefresh_Click(Me, Nothing)

        End If
        If e.KeyCode = Keys.Delete Then
            btnDelete_Click(Me, Nothing)
        End If
    End Sub


    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged
        FillDetail()
    End Sub
    Sub FillDetail()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT dbo.tblVehicleIssueTransactions.TransactionId, dbo.tblVehicleIssueTransactions.IssueId, dbo.tblVehicleIssueTransactions.TransactionDate, dbo.tblVehicleIssueTransactions.DateFrom, dbo.tblVehicleIssueTransactions.DateTo, dbo.tblVehicleIssueTransactions.GrossDays, dbo.tblVehicleIssueTransactions.LessDays, dbo.tblVehicleIssueTransactions.NetDays, dbo.tblVehicleIssueTransactions.RentPerDay, dbo.tblVehicleIssueTransactions.Amount, dbo.tblVehicleIssueTransactions.TransactionType, dbo.tblVehicleIssuance.VehicleId, dbo.tblVehicleIssuance.EmployeeId, dbo.tblVehicleIssueTransactions.Remarks FROM dbo.tblVehicleIssuance RIGHT OUTER JOIN dbo.tblVehicleIssueTransactions ON dbo.tblVehicleIssuance.IssueId = dbo.tblVehicleIssueTransactions.IssueId WHERE (dbo.tblVehicleIssueTransactions.TransactionId = @TransactionId)"
            .Parameters.Clear()
            .Parameters.Add("@TransactionId", SqlDbType.BigInt).Value = Val(txtId.Text)
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            'Dim dtVehicle As New DataTable

            'dtVehicle = cboVehicle.DataSource

            'Dim row As DataRow = dtVehicle.NewRow

            'row(0) = dt.Rows(0).Item("VehicleId")
            'row(2) = dt.Rows(0).Item("VehicleNumber")

            'dtVehicle.Rows.InsertAt(row, 1)

            'cboVehicle.DataSource = dtVehicle

            cboTransactionType.SelectedItem = dt.Rows(0).Item("TransactionType")
            dtpTransactionDate.Text = dt.Rows(0).Item("TransactionDate").ToString
            cboEmployee.SelectedValue = dt.Rows(0).Item("EmployeeId")
            cboShiftVehicle.SelectedValue = dt.Rows(0).Item("IssueId")
            dtpDateFrom.Value = dt.Rows(0).Item("DateFrom")
            dtpDateTo.Value = dt.Rows(0).Item("DateTo")
            txtGrossDays.Text = dt.Rows(0).Item("GrossDays")
            txtLessDays.Text = dt.Rows(0).Item("LessDays")
            txtNetDays.Text = dt.Rows(0).Item("NetDays")
            txtRentPerDay.Text = dt.Rows(0).Item("RentPerDay")
            txtAmount.Text = dt.Rows(0).Item("Amount")
            txtRemarks.Text = dt.Rows(0).Item("Remarks")
       
        Else

            ClearAllFields()


        End If
    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtId.Text = dgvList.CurrentRow.Cells("Id").Value


            If SplitContainer.Panel2Collapsed = True Then
                ShowDetailPanel()
            End If
        End If

    End Sub

    Sub ShowDetailPanel()
        SplitContainer.Panel2Collapsed = False
        picPanelExtender.BackgroundImage = imgList.Images(0)

        HideColumns()
    End Sub

    Sub HideDetailPanel()
        SplitContainer.Panel2Collapsed = True
        picPanelExtender.BackgroundImage = imgList.Images(1)
        ShowColumns()
    End Sub

    Sub HideColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "Id" Or col.HeaderText = "Date" Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
    End Sub

    Sub ShowColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "Id" Then
                col.Visible = False
            Else
                col.Visible = True
            End If
        Next
    End Sub

    Private Sub picPanelExtender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPanelExtender.Click
        If SplitContainer.Panel2Collapsed = False Then
            HideDetailPanel()
        Else
            ShowDetailPanel()

        End If
    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged
        If txtSearchText.Focused = True Then
            If Not Me.txtSearchText.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("Id + ' ' + Date LIKE '%" & txtSearchText.Text & "%'")


                TblSearchListBindingSource.Filter = qry.ToString


            Else
                TblSearchListBindingSource.RemoveFilter()

            End If
        End If

    End Sub
    Private Sub dgvList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvList.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvList_CellDoubleClick(Me, Nothing)
        End If
    End Sub

    Private Sub dtpTransactionDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTransactionDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboTransactionType.Focus()
        End If
    End Sub

    Private Sub cboTransactionType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTransactionType.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboEmployee.Focus()
        End If
    End Sub
    Private Sub cboEmployee_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cboEmployee.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboShiftVehicle.Focus()
        End If
    End Sub

    Private Sub cboShiftVehicle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cboShiftVehicle.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpDateFrom.Focus()
        End If
    End Sub

    Private Sub dtpDateFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDateFrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpDateTo.Focus()
        End If
    End Sub

    Private Sub dtpDateTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDateTo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtLessDays.Focus()
        End If
    End Sub
    Private Sub txtGrossDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrossDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtLessDays.Focus()
        End If
    End Sub

    Private Sub txtLessDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLessDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRentPerDay.Focus()
        End If
    End Sub

    Private Sub txtNetDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNetDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRentPerDay.Focus()
        End If
    End Sub
    Private Sub txtRentPerDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRentPerDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAmount.Focus()
        End If
    End Sub

   



    Private Sub tsbList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbList.Click
        If SplitContainer.Panel1Collapsed = False Then
            SplitContainer.Panel1Collapsed = True
            tsbList.Text = "Show List"
        Else
            SplitContainer.Panel1Collapsed = False
            tsbList.Text = "Hide List"

        End If
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateFrom.ValueChanged
        CalculateGrossDays()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateTo.ValueChanged
        CalculateGrossDays()
    End Sub
    Sub CalculateGrossDays()
        Dim days As Integer = (dtpDateTo.Value - dtpDateFrom.Value).Days + 1
        txtGrossDays.Text = days
        CalculateNetDays()
    End Sub

    Private Sub txtLessDays_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLessDays.TextChanged
        CalculateNetDays()
    End Sub
    Sub CalculateNetDays()
        txtNetDays.Text = Val(Replace(txtGrossDays.Text, ",", "")) - Val(Replace(txtLessDays.Text, ",", ""))
    End Sub
    Private Sub txtNetDays_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNetDays.TextChanged
        CalculateAmount()
    End Sub

    Private Sub txtRentPerDay_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRentPerDay.TextChanged
        CalculateAmount()
    End Sub
    Sub CalculateAmount()
        txtAmount.Text = Math.Round(Val(Replace(txtNetDays.Text, ",", "")) * Val(Replace(txtRentPerDay.Text, ",", "")), 2)
    End Sub

  
    Private Sub txtIssueRentPerDay_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIssueRentPerDay.TextChanged
        If txtId.Text = Nothing Then
            txtRentPerDay.Text = txtIssueRentPerDay.Text
        End If
    End Sub

    Private Sub cboEmployee_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmployee.SelectedIndexChanged
        If blnIsFormLoaded = True Then
            FillCboShiftVehicleByEmployeeId(cboEmployee.SelectedValue)
        End If
    End Sub


    Private Sub cboShiftVehicle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboShiftVehicle.SelectedIndexChanged
        txtRentPerDay.Text = cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 4).CellValue.ToString

    End Sub

    
    
  
End Class