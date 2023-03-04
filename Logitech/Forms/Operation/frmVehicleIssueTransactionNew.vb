Imports System.Data.SqlClient
Public Class frmVehicleIssueTransactionNew

    Dim VoucherType As String = "RECEIPT"
    Dim TblSearchListBindingSource As New BindingSource

    Dim blnIsFormLoaded As Boolean = False
    Dim blnIsFillingData As Boolean = False

    Sub SetFormStateNew()

        blnIsFormLoaded = False

        FillCboEmployee()

        ClearMasterFields()
        txtTransactionNumber.Text = GetNewVoucherNumber.ToString

        CLearDetailFields()
        dgvDetail.Rows.Clear()

        FillMainSearchList()

        txtUser.Text = vUserName

        blnIsFormLoaded = True

        FillCboShiftVehicleByEmployeeId(cboEmployee.SelectedValue)

    End Sub

    Sub ClearMasterFields()

        txtIsEdit.Text = Nothing
        dtpTransactionDate.Value = Now.Date
        dtpDateFrom.Value = Now.Date
        dtpDateTo.Value = Now.Date
        txtGrossDays.Text = 1
        txtLessDays.Text = 0
        txtNetDays.Text = 1
        txtRentPerDay.Text = 0
        txtDetailAmount.Text = 0
        dtpTransactionDate.Value = Now.Date
        txtRentPerDay.Text = 0
        txtRemarks.Text = Nothing


    End Sub

    Sub CLearDetailFields()
        txtDetailRowIndex.Text = Nothing
        cboDetailTransactionType.SelectedIndex = 0
        txtDetailRemarks.Text = Nothing
        txtDetailAmount.Text = 0

        cboDetailTransactionType.Focus()
    End Sub

    Function GetNewVoucherNumber() As String
        GetNewVoucherNumber = "1"

        Dim tblName As String = "tblVehicleIssueTransactionMaster"
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim qryStr As New System.Text.StringBuilder


        qryStr.Append("SELECT MAX(TransactionNumber) FROM " & tblName)

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = qryStr.ToString
            .Parameters.Clear()
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            GetNewVoucherNumber = Val(dt.Rows(0).Item(0).ToString) + 1

        Else
            GetNewVoucherNumber = 1
        End If
    End Function

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
        row.Item("EmployeeName") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)

        cboEmployee.DataSource = dt
        cboEmployee.DisplayMember = "EmployeeName"
        cboEmployee.ValueMember = "EmployeeId"

        cboEmployee.SelectedValue = 0

        txtEmployeeGLCode.DataBindings.Clear()
        txtEmployeeGLCode.DataBindings.Add(New Binding("Text", dt, "GLAccCode"))


    End Sub

    Sub FillCboShiftVehicleByEmployeeId(EmployeeId As Long)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            '.CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.IdNumber, dbo.tblEmployees.IdExpiry, dbo.tblEmployees.ContactNumber, dbo.tblEmployees.IBAN, dbo.tblEmployees.PassportNumber, dbo.tblEmployees.PassportExpiry, dbo.tblEmployees.Nationality, dbo.tblEmployees.Designation, dbo.tblEmployees.JoiningDate, dbo.tblVehicleIssuance.VehicleId, dbo.tblVehicles.VehicleNumber, dbo.tblVehicleIssuance.Remarks, dbo.tblVehicleIssuance.RentPerDay FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId LEFT OUTER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) ORDER BY dbo.tblVehicles.VehicleNumber"
            .CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicles.VehicleNumber AS Vehicle, dbo.tblVehicleIssuance.Shift, dbo.tblVehicleIssuance.RentPerDay AS [Rent / Day], dbo.tblVehicles.GLAccCode FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) AND (dbo.tblVehicleIssuance.EmployeeId = @EmployeeId) ORDER BY Vehicle"
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

        cboShiftVehicle.SelectedIndex = 0
        cboShiftVehicle.DataSource = dt
        cboShiftVehicle.DisplayMember = "Vehicle"
        cboShiftVehicle.ValueMember = "IssueId"

        Dim gch As Syncfusion.Windows.Forms.Grid.GridColHidden = New Syncfusion.Windows.Forms.Grid.GridColHidden(1) 'Hides column number '1'
        cboShiftVehicle.ListBox.Grid.ColHiddenEntries.Add(gch)

        gch = New Syncfusion.Windows.Forms.Grid.GridColHidden(5) 'Hides column number '5'
        cboShiftVehicle.ListBox.Grid.ColHiddenEntries.Add(gch)

        cboShiftVehicle.ListBox.Grid.ColWidths(2) = 120
        cboShiftVehicle.ListBox.Grid.ColWidths(3) = 80
        cboShiftVehicle.ListBox.Grid.ColWidths(4) = 100
        cboShiftVehicle.ListBox.Grid.ColStyles(2).AutoSize = True


        txtVehicleGLCode.DataBindings.Clear()
        txtVehicleGLCode.DataBindings.Add(New Binding("Text", dt, "GLAccCode"))

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

        qryStr = "SELECT TransactionNumber AS Number, TransactionDate AS Date FROM dbo.tblVehicleIssueTransactionMaster"

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
            dgvList.Columns("Number").Visible = True
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
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width

        If screenWidth < 1679 Then
            SplitContainer.Panel1Collapsed = True
        Else
            SplitContainer.Panel1Collapsed = False
        End If

        SetFormStateNew()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SetFormStateNew()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtIsEdit.Text <> Nothing Then
            If MsgBox("Do you Really Want to Delete?" & vbNewLine & "This event is not reversable.", vbYesNo + vbCritical, "Confirmation") = vbYes Then

                If vRequireUserPasswordForDelete = "True" Then
                    frmPasswordInput.ShowDialog()
                    If frmPasswordInput.DialogResult = System.Windows.Forms.DialogResult.Yes Then

                        Delete(txtTransactionNumber.Text)
                        Exit Sub
                    Else

                        Exit Sub
                    End If

                End If
                Delete(txtTransactionNumber.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal TransNumber As Long)

        Dim cmd As New SqlCommand

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        Dim trans As SqlTransaction
        trans = Conn.BeginTransaction

        Try

            With cmd
                .Transaction = trans
                .Connection = Conn
                .CommandText = "DELETE FROM tblVehicleIssueTransactionMaster WHERE TransactionNumber = @TransactionNumber"
                .Parameters.Clear()
                .Parameters.Add("@TransactionNumber", SqlDbType.BigInt).Value = TransNumber
                .ExecuteNonQuery()
            End With

            Dim VoucherId As String
            VoucherId = VoucherType & "-" & TransNumber
            DeleteAccountingVoucher(VoucherId, "tblAccOtherVoucherMaster", trans)
            LogRecord("RECEIPT # " & TransNumber, VoucherType, vUserName, "DELETE", trans) 'INSERT , UPDATE, DELETE
            trans.Commit()

            MsgBox("Voucher Deleted")

            SetFormStateNew()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
        Finally
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

        End Try

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cboShiftVehicle.SelectedIndex < 0 Then
            MsgBox("Please Select Vehicle", , "Error")
            cboShiftVehicle.Focus()
            Exit Sub
        End If

        If dgvDetail.Rows.Count < 1 Then
            MsgBox("There sshould be at least 1 transaction")
            Exit Sub
        End If

        ' Start Checking Accounting Treatment

        ProposeAccountingTransactions()

        If Val(Replace(txtTotalDebit.Text, ",", "")) - Val(Replace(txtTotalCredit.Text, ",", "")) <> 0 Then
            MsgBox("There is differnece in accounting entry.")
            Exit Sub
        End If
        For Each row As DataGridViewRow In dgvAccountingTransactions.Rows
            If row.Cells("dgvAccountingTransactionsAccNameAccCode").Value.ToString = String.Empty Then
                MsgBox("There is something wrong in Acc Code Column in Accounting Transactions")
                Exit Sub
            End If
        Next

        ' Stop Checking Accounting Treatment



        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If


        'Inser if Record is New
        If txtIsEdit.Text = Nothing Then

            'Start Inserting New Record
            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            'Try

            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandText = "INSERT INTO tblVehicleIssueTransactionMaster (TransactionNumber, IssueId, TransactionDate, DateFrom, DateTo, GrossDays, LessDays, NetDays, RentPerDay, Remarks, EnteredBy) VALUES (@TransactionNumber, @IssueId, @TransactionDate, @DateFrom, @DateTo, @GrossDays, @LessDays, @NetDays, @RentPerDay, @Remarks, @EnteredBy)"
                .Parameters.Clear()
                .Parameters.Add("@TransactionNumber", SqlDbType.BigInt).Value = Val(txtTransactionNumber.Text)
                .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 1).CellValue.ToString
                .Parameters.Add("@TransactionDate", SqlDbType.Date).Value = dtpTransactionDate.Value
                .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
                .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value
                .Parameters.Add("@GrossDays", SqlDbType.Int).Value = txtGrossDays.Text
                .Parameters.Add("@LessDays", SqlDbType.Int).Value = txtLessDays.Text
                .Parameters.Add("@NetDays", SqlDbType.Int).Value = txtNetDays.Text
                .Parameters.Add("@RentPerDay", SqlDbType.Decimal).Value = txtRentPerDay.Text
                .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text
                .Parameters.Add("@EnteredBy", SqlDbType.NVarChar).Value = vUserName

                .ExecuteNonQuery()
            End With

            If dgvDetail.Rows.Count > 0 Then
                'With cmd
                '    .CommandText = "SELECT IDENT_CURRENT('tblVehicleIssueTransactionMaster')"

                'End With
                'Dim dtNewIdentity As New DataTable
                'Dim daNewIdentity As New SqlDataAdapter
                'daNewIdentity.SelectCommand = cmd
                'dtNewIdentity.Clear()
                'daNewIdentity.Fill(dtNewIdentity)

                'Dim LastTransactionId As Long
                'LastTransactionId = dtNewIdentity.Rows(0).Item(0).ToString

                For Each row As DataGridViewRow In dgvDetail.Rows
                    With cmd
                        .Connection = Conn
                        .Transaction = trans
                        .CommandText = "INSERT INTO tblVehicleIssueTransactionDetail (TransactionNumber, TransactionType, Amount, Remarks) VALUES (@TransactionNumber, @TransactionType, @Amount, @Remarks)"
                        .Parameters.Clear()
                        .Parameters.Add("@TransactionNumber", SqlDbType.BigInt).Value = Val(txtTransactionNumber.Text)
                        .Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = row.Cells("TransactionType").Value
                        .Parameters.Add("@Amount", SqlDbType.Decimal).Value = row.Cells("Amount").Value
                        .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = row.Cells("Remarks").Value

                        .ExecuteNonQuery()
                    End With
                Next
            End If

            If PostAccountingTransactionNew(trans) Then
                LogRecord("RECEIPT # " & txtTransactionNumber.Text, VoucherType, vUserName, "INSERT", trans) 'INSERT , UPDATE, DELETE
                trans.Commit()
                MsgBox("Added Successfully")
                If chkPreview.Checked = True Then
                    PreviewVoucher()
                End If
                SetFormStateNew()
            End If


            'Catch ex As Exception
            '    MessageBox.Show("Commit Exception Type: " & ex.GetType.ToString & Chr(13) & "Message: " & ex.Message)
            '    Try
            '        trans.Rollback()
            '    Catch ex2 As Exception
            '        MessageBox.Show("Rollback Exception Type: " & ex2.GetType.ToString & Chr(13) & "Message: " & ex2.Message)
            '    End Try

            'Finally
            '    cmd.Dispose()
            '    If Conn.State <> ConnectionState.Closed Then
            '        Conn.Close()
            '    End If

            'End Try

        End If

        If txtIsEdit.Text <> Nothing Then

            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            With cmd
                .Transaction = trans
                .CommandText = "UPDATE tblVehicleIssueTransactionMaster SET IssueId = @IssueId, TransactionDate = @TransactionDate, DateFrom = @DateFrom, DateTo = @DateTo, GrossDays = @GrossDays, LessDays = @LessDays, NetDays = @NetDays, RentPerDay = @RentPerDay, Remarks = @Remarks WHERE TransactionNumber = @Original_TransactionNumber"
                .Parameters.Clear()
                .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 1).CellValue.ToString
                .Parameters.Add("@TransactionDate", SqlDbType.Date).Value = dtpTransactionDate.Value
                .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
                .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value
                .Parameters.Add("@GrossDays", SqlDbType.Int).Value = txtGrossDays.Text
                .Parameters.Add("@LessDays", SqlDbType.Int).Value = txtLessDays.Text
                .Parameters.Add("@NetDays", SqlDbType.Int).Value = txtNetDays.Text
                .Parameters.Add("@RentPerDay", SqlDbType.Decimal).Value = txtRentPerDay.Text
                .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text
                .Parameters.Add("@Original_TransactionNumber", SqlDbType.BigInt).Value = Val(txtTransactionNumber.Text)
                .ExecuteNonQuery()
            End With

            'Create Checking Variables

            Dim blnStopCheck As Boolean = False
            Dim blnFound As Boolean = False


            '------ Start INSERT, UPDATE, DELETE Attachments ------'
            If dgvDetail.Rows.Count = 0 Then
                Dim cmdDelete As New SqlCommand
                Dim qryDelete As String
                qryDelete = "DELETE FROM tblVehicleIssueTransactionDetail WHERE TransactionNumber = " & Val(txtTransactionNumber.Text)
                With cmdDelete
                    .Transaction = trans
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = qryDelete

                End With
                cmdDelete.ExecuteNonQuery()
            End If



            'Start Check From DB


            Dim daExistingVehicles As New SqlDataAdapter
            Dim dtExistingVehicles As New DataTable
            Dim cmdExistingVehicles As New SqlCommand
            With cmdExistingVehicles
                .Transaction = trans
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT VehicleIssueTransactionDetailId FROM tblVehicleIssueTransactionDetail WHERE TransactionNumber =" & Val(txtTransactionNumber.Text)
            End With
            daExistingVehicles.SelectCommand = cmdExistingVehicles

            dtExistingVehicles.Clear()
            daExistingVehicles.Fill(dtExistingVehicles)
            For Each ExistingVehiclerow As DataRow In dtExistingVehicles.Rows
                blnStopCheck = False
                blnFound = False
                Dim ExistingSaleDetailId As Long = ExistingVehiclerow.Item(0).ToString


                For i As Integer = 0 To dgvDetail.Rows.Count - 1
                    If blnStopCheck = False Then


                        If ExistingSaleDetailId = Val(dgvDetail.Rows(i).Cells("VehicleIssueTransactionDetailId").Value) Then
                            blnStopCheck = True
                            blnFound = True

                        Else
                            blnStopCheck = False
                            blnFound = False


                        End If
                    End If
                    If i = dgvDetail.Rows.Count - 1 Then
                        If blnFound = False Then




                            Dim cmdDeleteVehicle As New SqlCommand
                            Dim qryDeleteVehicle As String
                            qryDeleteVehicle = "DELETE FROM tblVehicleIssueTransactionDetail WHERE VehicleIssueTransactionDetailId = " & ExistingSaleDetailId
                            With cmdDeleteVehicle
                                .Transaction = trans
                                .Connection = Conn
                                .CommandType = CommandType.Text
                                .CommandText = qryDeleteVehicle

                            End With
                            cmdDeleteVehicle.ExecuteNonQuery()

                        End If
                    End If

                Next


            Next

            'End Check From DB


            For i = 0 To dgvDetail.Rows.Count - 1

                If Val(dgvDetail.Rows(i).Cells("VehicleIssueTransactionDetailId").Value) > 0 Then
                    With cmd
                        .CommandText = "UPDATE tblVehicleIssueTransactionDetail SET TransactionType = @TransactionType, Amount = @Amount, Remarks = @Remarks WHERE VehicleIssueTransactionDetailId = @VehicleIssueTransactionDetailId"
                        .Parameters.Clear()
                        .Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = dgvDetail.Rows(i).Cells("TransactionType").Value
                        .Parameters.Add("@Amount", SqlDbType.Decimal).Value = dgvDetail.Rows(i).Cells("Amount").Value
                        .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = dgvDetail.Rows(i).Cells("Remarks").Value
                        .Parameters.Add("@VehicleIssueTransactionDetailId", SqlDbType.BigInt).Value = dgvDetail.Rows(i).Cells("VehicleIssueTransactionDetailId").Value
                        .ExecuteNonQuery()
                    End With
                End If

                If Val(dgvDetail.Rows(i).Cells("VehicleIssueTransactionDetailId").Value) < 1 Then
                    With cmd
                        .CommandText = "INSERT INTO tblVehicleIssueTransactionDetail (TransactionNumber, TransactionType, Amount, Remarks) VALUES (@TransactionNumber, @TransactionType, @Amount, @Remarks)"
                        .Parameters.Clear()
                        .Parameters.Add("@TransactionNumber", SqlDbType.BigInt).Value = Val(txtTransactionNumber.Text)
                        .Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = dgvDetail.Rows(i).Cells("TransactionType").Value
                        .Parameters.Add("@Amount", SqlDbType.Decimal).Value = dgvDetail.Rows(i).Cells("Amount").Value
                        .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = dgvDetail.Rows(i).Cells("Remarks").Value
                        .ExecuteNonQuery()
                    End With
                End If

            Next

            If PostAccountingTransactionNew(trans) Then
                LogRecord("RECEIPT # " & txtTransactionNumber.Text, VoucherType, vUserName, "UPDATE", trans) 'INSERT , UPDATE, DELETE
                trans.Commit()

                MsgBox("Updated Successfully")

                If chkPreview.Checked = True Then
                    PreviewVoucher()
                End If
                SetFormStateNew()
            End If


        End If


    End Sub
    Function DeleteAccountingVoucher(ByVal VoucherId As String, ByVal Table As String, ByVal trans As SqlTransaction) As Boolean
        DeleteAccountingVoucher = False
        Dim cmd As New SqlCommand
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        With cmd
            .Transaction = trans
            .Connection = Conn
            .CommandText = "DELETE FROM " & Table & " WHERE VoucherId = @VoucherId"
            .Parameters.Clear()
            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = VoucherId
            .ExecuteNonQuery()
        End With
        DeleteAccountingVoucher = True


    End Function
    Function PostAccountingTransactionNew(ByVal trans As SqlTransaction) As Boolean
        PostAccountingTransactionNew = False
        'It will First Delete Old Transaction and then Insert New Transaction

        'Creating some calculated Fields
        Dim VoucherNumber As String
        Dim VoucherId As String


        VoucherNumber = Val(txtTransactionNumber.Text)
        VoucherId = VoucherType & "-" & txtTransactionNumber.Text

        Dim cmd As New SqlCommand
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        With cmd
            .Connection = Conn
        End With

        'Try
        'Start Delete Transactions
        If DeleteAccountingVoucher(VoucherId, "tblAccOtherVoucherMaster", trans) Then
            'Insert Master Table Data
            With cmd
                .Transaction = trans
                .CommandText = "INSERT INTO tblAccOtherVoucherMaster (VoucherId, VoucherNo, VoucherType, VoucherDate, ChequeNumber, EntryUser, IsApproved, ApprovedBy) VALUES (@VoucherId, @VoucherNo, @VoucherType, @VoucherDate, @ChequeNumber, @EntryUser, @IsApproved, @ApprovedBy)"
                .Parameters.Clear()
                .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = VoucherId
                .Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNumber
                .Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherType
                .Parameters.Add("@VoucherDate", SqlDbType.Date).Value = dtpTransactionDate.Value
                .Parameters.Add("@ChequeNumber", SqlDbType.NVarChar).Value = ""
                .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = vUserName

                .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = True

                .Parameters.Add("@ApprovedBy", SqlDbType.NVarChar).Value = vUserName

                .ExecuteNonQuery()
            End With


            'Start New Addition, it will do all debits and Credit, so this will install various times
            For Each row As DataGridViewRow In dgvAccountingTransactions.Rows
                With cmd
                    .Transaction = trans
                    .CommandText = "INSERT INTO tblAccOtherVoucherDetail (VoucherId, AccCode, Description, Debit, Credit, CreditDays) VALUES (@VoucherId, @AccCode, @Description, @Debit, @Credit, @CreditDays)"
                    .Parameters.Clear()
                    .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = VoucherId
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = row.Cells("dgvAccountingTransactionsAccNameAccCode").Value
                    .Parameters.Add("@Description", SqlDbType.NVarChar).Value = row.Cells("dgvAccountingTransactionsDescription").Value
                    .Parameters.Add("@Debit", SqlDbType.Decimal).Value = Decimal.Parse(row.Cells("dgvAccountingTransactionsDebit").Value)
                    .Parameters.Add("@Credit", SqlDbType.Decimal).Value = Decimal.Parse(row.Cells("dgvAccountingTransactionsCredit").Value)
                    .Parameters.Add("@CreditDays", SqlDbType.Decimal).Value = 0
                    .ExecuteNonQuery()
                End With
            Next

            PostAccountingTransactionNew = True
        End If

    End Function

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


    Private Sub txtTransactionNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransactionNumber.TextChanged
        If blnIsFormLoaded = True Then
            blnIsFillingData = True

            FillMaster()
            FillTransactions()

            blnIsFillingData = False


        End If
    End Sub
    Sub FillMaster()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT dbo.tblVehicleIssueTransactionMaster.TransactionNumber, dbo.tblVehicleIssueTransactionMaster.IssueId, dbo.tblVehicleIssueTransactionMaster.TransactionDate, dbo.tblVehicleIssueTransactionMaster.DateFrom, dbo.tblVehicleIssueTransactionMaster.DateTo, dbo.tblVehicleIssueTransactionMaster.GrossDays, dbo.tblVehicleIssueTransactionMaster.LessDays, dbo.tblVehicleIssueTransactionMaster.NetDays, dbo.tblVehicleIssueTransactionMaster.RentPerDay, dbo.tblVehicleIssuance.VehicleId, dbo.tblVehicleIssuance.EmployeeId, dbo.tblVehicleIssueTransactionMaster.Remarks, dbo.tblVehicleIssueTransactionMaster.EnteredBy, dbo.tblVehicleIssueTransactionMaster.SysTimeStamp FROM dbo.tblVehicleIssuance RIGHT OUTER JOIN dbo.tblVehicleIssueTransactionMaster ON dbo.tblVehicleIssuance.IssueId = dbo.tblVehicleIssueTransactionMaster.IssueId WHERE (dbo.tblVehicleIssueTransactionMaster.TransactionNumber = @TransactionNumber)"
            .Parameters.Clear()
            .Parameters.Add("@TransactionNumber", SqlDbType.BigInt).Value = Val(txtTransactionNumber.Text)
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            txtIsEdit.Text = 1
            txtTransactionNumber.Text = dt.Rows(0).Item("TransactionNumber").ToString
            dtpTransactionDate.Text = dt.Rows(0).Item("TransactionDate").ToString
            cboEmployee.SelectedValue = dt.Rows(0).Item("EmployeeId")
            cboShiftVehicle.SelectedValue = dt.Rows(0).Item("IssueId")
            dtpDateFrom.Value = dt.Rows(0).Item("DateFrom")
            dtpDateTo.Value = dt.Rows(0).Item("DateTo")
            txtGrossDays.Text = dt.Rows(0).Item("GrossDays")
            txtLessDays.Text = dt.Rows(0).Item("LessDays")
            txtNetDays.Text = dt.Rows(0).Item("NetDays")
            txtRentPerDay.Text = dt.Rows(0).Item("RentPerDay")
            txtRemarks.Text = dt.Rows(0).Item("Remarks")

        Else

            ClearMasterFields()


        End If
    End Sub
    Sub FillTransactions()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT VehicleIssueTransactionDetailId, TransactionNumber, TransactionType, Amount, Remarks, SysTimeStamp FROM dbo.tblVehicleIssueTransactionDetail WHERE (TransactionNumber = @TransactionNumber)"
            .Parameters.Clear()
            .Parameters.Add("@TransactionNumber", SqlDbType.BigInt).Value = Val(txtTransactionNumber.Text)
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            dgvDetail.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgvDetail.Rows.Add(row.Item("VehicleIssueTransactionDetailId"), row.Item("TransactionType"), row.Item("Remarks"), row.Item("Amount"))

            Next
            CLearDetailFields()
        Else

            dgvDetail.Rows.Clear()
        End If


    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtTransactionNumber.Text = dgvList.CurrentRow.Cells("Number").Value


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
            If col.HeaderText = "Number" Or col.HeaderText = "Date" Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
    End Sub

    Sub ShowColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "Number" Then
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
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub txtRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboDetailTransactionType.Focus()
        End If
    End Sub


    Private Sub cboDetailTransactionType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDetailTransactionType.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDetailRemarks.Focus()
        End If
    End Sub
    Private Sub txtDetailRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetailRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDetailAmount.Focus()
        End If
    End Sub

    Private Sub txtDetailAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetailAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnPinDetail_Click(Me, Nothing)
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
        CalculateDaysTillToday()
        CalculateReceivableTillToday()
    End Sub

    Private Sub txtInformationIssueDate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInformationIssueDate.TextChanged
        CalculateDaysTillToday()
        CalculateReceivableTillToday()
    End Sub

    Sub CalculateGrossDays()
        Dim days As Integer = (dtpDateTo.Value - dtpDateFrom.Value).Days + 1
        txtGrossDays.Text = days
        CalculateNetDays()
    End Sub

    Sub CalculateDaysTillToday()
        If txtInformationIssueDate.Text <> Nothing Then

            Dim days As Integer = (dtpDateTo.Value - CDate(txtInformationIssueDate.Text)).Days + 1
            txtTotalDaysTillToday.Text = days
        Else
            txtTotalDaysTillToday.Text = 0
        End If
    End Sub

    Private Sub txtInformationIssueRentPerDay_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInformationIssueRentPerDay.TextChanged
        CalculateReceivableTillToday()
        CalculatePeriodSale()
    End Sub

    Sub CalculateReceivableTillToday()

        txtTotalReceivableTillToday.Text = Math.Round(Val(Replace(txtTotalDaysTillToday.Text, ",", "")) * Val(Replace(txtInformationIssueRentPerDay.Text, ",", "")) + AccBalance, 2)

    End Sub

    Private Sub txtTotalReceivableTillToday_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalReceivableTillToday.TextChanged
        CalculateBalanceReceivableTillToday()
    End Sub
    Private Sub txtTotalReceivedTillToday_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalReceivedTillToday.TextChanged
        CalculateBalanceReceivableTillToday()
    End Sub
    
    Sub CalculateBalanceReceivableTillToday()
        txtTotalBalanceReceivableTillToday.Text = Math.Round(Val(Replace(txtTotalReceivableTillToday.Text, ",", "")) - Val(Replace(txtTotalReceivedTillToday.Text, ",", "")), 2)
    End Sub
    Private Sub txtLessDays_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLessDays.TextChanged
        CalculateNetDays()
    End Sub

    Sub CalculateNetDays()
        txtNetDays.Text = Val(Replace(txtGrossDays.Text, ",", "")) - Val(Replace(txtLessDays.Text, ",", ""))
    End Sub

    Private Sub txtNetDays_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNetDays.TextChanged
        CalculateAmount()
        CalculatePeriodSale()
    End Sub

    Private Sub txtRentPerDay_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRentPerDay.TextChanged
        CalculateAmount()
        CalculatePeriodSale()
    End Sub

    Sub CalculateAmount()
        txtDetailAmount.Text = Math.Round(Val(Replace(txtNetDays.Text, ",", "")) * Val(Replace(txtRentPerDay.Text, ",", "")), 2)
    End Sub
    Sub CalculatePeriodSale()
        If txtIsEdit.Text = Nothing Then
            txtPeriodSale.Text = Math.Round(Val(Replace(txtInformationIssueRentPerDay.Text, ",", "")) * Val(Replace(txtNetDays.Text, ",", "")), 2)
        Else
            txtPeriodSale.Text = Math.Round(Val(Replace(txtInformationIssueRentPerDay.Text, ",", "")) * Val(Replace(txtNetDays.Text, ",", "")), 2)
        End If
    End Sub
    Private Sub cboEmployee_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmployee.SelectedIndexChanged
        If blnIsFormLoaded = True Then
            FillCboShiftVehicleByEmployeeId(cboEmployee.SelectedValue)
        End If
    End Sub

    Private Sub cboShiftVehicle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboShiftVehicle.SelectedIndexChanged

        If cboShiftVehicle.Items.Count > 1 Then
            txtRentPerDay.Text = cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 4).CellValue.ToString
            GetIssueHistory(cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 1).CellValue.ToString)
        Else
            txtRentPerDay.Text = 0
        End If
    End Sub

    Sub GetIssueHistory(IssueId As Long)

        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        OpenNewConnection()

        'Getting Issue Detail

        With cmd
            .Connection = Conn
            .CommandText = "SELECT IssueId, IssueDate, Remarks, RentPerDay, Shift, EnteredBy FROM dbo.tblVehicleIssuance GROUP BY IssueId, IssueDate, Remarks, RentPerDay, Shift, EnteredBy HAVING (IssueId = @IssueId)"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = IssueId
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            txtInformationIssueId.Text = dt.Rows(0).Item("IssueId")
            txtInformationIssueDate.Text = dt.Rows(0).Item("IssueDate")
            txtInformationIssueShift.Text = dt.Rows(0).Item("Shift")
            txtInformationIssueRentPerDay.Text = dt.Rows(0).Item("RentPerDay")

        Else
            txtInformationIssueId.Text = Nothing
            txtInformationIssueDate.Text = Nothing
            txtInformationIssueShift.Text = Nothing
            txtInformationIssueRentPerDay.Text = Nothing

        End If

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.Remarks, dbo.tblVehicleIssuance.RentPerDay, dbo.tblVehicleIssuance.Shift, dbo.tblVehicleIssuance.EnteredBy, dbo.tblVehicleIssueTransactionDetail.TransactionType, dbo.tblVehicleIssueTransactionMaster.DateFrom, dbo.tblVehicleIssueTransactionMaster.DateTo, dbo.tblVehicleIssueTransactionDetail.Amount FROM dbo.tblVehicleIssuance INNER JOIN dbo.tblVehicleIssueTransactionMaster ON dbo.tblVehicleIssuance.IssueId = dbo.tblVehicleIssueTransactionMaster.IssueId INNER JOIN dbo.tblVehicleIssueTransactionDetail ON dbo.tblVehicleIssueTransactionMaster.TransactionNumber = dbo.tblVehicleIssueTransactionDetail.TransactionNumber WHERE (dbo.tblVehicleIssuance.IssueId = @IssueId)"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = IssueId
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        CloseConnection()

        If dt.Rows.Count > 0 Then

            dgvIssueHistory.Rows.Clear()

            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    dgvIssueHistory.Rows.Add(row.Item("TransactionType"), row.Item("DateFrom"), row.Item("DateTo"), row.Item("Amount"))
                Next
            End If
            dgvIssueHistory.ClearSelection()
        Else

            dgvIssueHistory.Rows.Clear()
        End If

    End Sub

    Private Sub dgvDetail_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        Dim colName As String = dgvDetail.Columns(e.ColumnIndex).Name
        If colName = "dgvDetailRemoveRow" Then

            dgvDetail.Rows.Remove(dgvDetail.CurrentRow)

        End If
    End Sub

    Private Sub dgvDetail_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetail.CellDoubleClick
        FillTransactionDetail()
    End Sub

    Sub FillTransactionDetail()
        If dgvDetail.Rows.Count > 0 Then
            With dgvDetail.CurrentRow
                txtDetailRowIndex.Text = .Index
                cboDetailTransactionType.SelectedItem = .Cells.Item("TransactionType").Value
                txtDetailRemarks.Text = .Cells.Item("Remarks").Value
                txtDetailAmount.Text = .Cells.Item("Amount").Value
            End With

        End If

    End Sub

    Private Sub btnPinDetail_Click(sender As System.Object, e As System.EventArgs) Handles btnPinDetail.Click
        If cboDetailTransactionType.SelectedIndex = 0 Then
            MsgBox("please select Valid Transaction Type")
            cboDetailTransactionType.Focus()
            Exit Sub
        End If

        If txtDetailAmount.Text = 0 Then
            MsgBox("Please Enter Valid Amount")
            txtDetailAmount.Focus()
            Exit Sub
        End If

        'If Val(txtDetailRowGrossAmountOutput.Text) <= 0 Then
        '    MsgBox("Please Enter Valid Amount")
        '    Exit Sub
        'End If

        If txtDetailRowIndex.Text = Nothing Then

            dgvDetail.Rows.Add("", cboDetailTransactionType.SelectedItem.ToString, txtDetailRemarks.Text, txtDetailAmount.Text)

        Else

            For Each row As DataGridViewRow In dgvDetail.Rows
                If row.Index = txtDetailRowIndex.Text Then
                    row.Cells("TransactionType").Value = cboDetailTransactionType.SelectedItem.ToString
                    row.Cells("Remarks").Value = txtDetailRemarks.Text
                    row.Cells("Amount").Value = txtDetailAmount.Text
                End If

            Next

        End If

        CLearDetailFields()

        CalculateTransactionTotal()
    End Sub

    Sub CalculateTransactionTotal()
        txtDetailAmountTotalIncome.Text = 0
        txtDetailAmountTotalVehicleExpense.Text = 0

        For Each row As DataGridViewRow In dgvDetail.Rows

            If row.Cells("TransactionType").Value <> "Vehicle Expense" Then
                txtDetailAmountTotalIncome.Text += CDec(row.Cells("Amount").Value)

            ElseIf row.Cells("TransactionType").Value = "Vehicle Expense" Then
                txtDetailAmountTotalVehicleExpense.Text += CDec(row.Cells("Amount").Value)
            End If

        Next
    End Sub

    Private Sub TabPage2_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage2.Enter
        ProposeAccountingTransactions()
    End Sub

    Sub ProposeAccountingTransactions()
        dgvAccountingTransactions.Rows.Clear()


        For Each row As DataGridViewRow In dgvDetail.Rows
            If row.Cells("TransactionType").Value <> "Vehicle Expense" Then
                dgvAccountingTransactions.Rows.Add(vDefaultCashAccCode, "CASH A/C", "RECEIVED CASH - " & row.Cells("Remarks").Value, Val(Replace(row.Cells("Amount").Value, ",", "")), 0)
                dgvAccountingTransactions.Rows.Add(txtEmployeeGLCode.Text, cboEmployee.GetItemText(cboEmployee.SelectedItem), "CASH ADJUSTMENT AGAINST VEHICLE EXPENSE : " & row.Cells("Remarks").Value, 0, Val(Replace(row.Cells("Amount").Value, ",", "")))
            Else
                dgvAccountingTransactions.Rows.Add(txtVehicleGLCode.Text, cboShiftVehicle.ListBox.Grid.Model(cboShiftVehicle.SelectedIndex + 1, 2).CellValue.ToString & " EXPENSE A/C", "VEHICLE EXPENSE - " & row.Cells("Remarks").Value, Val(Replace(row.Cells("Amount").Value, ",", "")), 0)
                dgvAccountingTransactions.Rows.Add(txtEmployeeGLCode.Text, cboEmployee.GetItemText(cboEmployee.SelectedItem), "RECEIVED CASH : " & row.Cells("Remarks").Value, 0, Val(Replace(row.Cells("Amount").Value, ",", "")))
            End If

        Next
        dgvAccountingTransactions.Rows.Add(txtEmployeeGLCode.Text, cboEmployee.GetItemText(cboEmployee.SelectedItem), "OUTSTANDING RECEIVABLE FROM: " & dtpDateFrom.Value.Date & " TILL: " & dtpDateTo.Value.Date & " , NET DAYS: " & txtNetDays.Text & " @ " & txtInformationIssueRentPerDay.Text, Val(Replace(txtPeriodSale.Text, ",", "")), 0)
        dgvAccountingTransactions.Rows.Add(vDefaultSaleAccCode, "SALE A/C", "SALE - OUTSTANDING RECEIVABLE FROM: " & dtpDateFrom.Value.Date & " TILL: " & dtpDateTo.Value.Date & " , NET DAYS: " & txtNetDays.Text & " @ " & txtInformationIssueRentPerDay.Text, 0, Val(Replace(txtPeriodSale.Text, ",", "")))

    End Sub

    Private Sub dgvAccountingTransactions_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvAccountingTransactions.RowsAdded
        CalculateAcccountingTransactionsTotal()
    End Sub

    Private Sub dgvAccountingTransactions_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvAccountingTransactions.RowsRemoved
        CalculateAcccountingTransactionsTotal()
    End Sub

    Private Sub dgvAccountingTransactions_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccountingTransactions.CellValueChanged
        CalculateAcccountingTransactionsTotal()
    End Sub

    Sub CalculateAcccountingTransactionsTotal()
        txtTotalDebit.Text = CDec(0)
        txtTotalCredit.Text = CDec(0)

        For Each row As DataGridViewRow In dgvAccountingTransactions.Rows
            txtTotalDebit.Text += CDec(row.Cells("dgvAccountingTransactionsDebit").Value)
            txtTotalCredit.Text += CDec(row.Cells("dgvAccountingTransactionsCredit").Value)
        Next
    End Sub

    Private Sub btnPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnPreview.Click
        If txtIsEdit.Text <> Nothing Then

            PreviewVoucher()

        End If
    End Sub

    Sub PreviewVoucher()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT dbo.tblVehicleIssueTransactionMaster.TransactionNumber, dbo.tblVehicleIssueTransactionMaster.IssueId, dbo.tblVehicleIssueTransactionMaster.TransactionDate, dbo.tblVehicleIssueTransactionMaster.DateFrom, dbo.tblVehicleIssueTransactionMaster.DateTo, dbo.tblVehicleIssueTransactionMaster.GrossDays, dbo.tblVehicleIssueTransactionMaster.LessDays, dbo.tblVehicleIssueTransactionMaster.NetDays, dbo.tblVehicleIssueTransactionMaster.RentPerDay, dbo.tblVehicleIssueTransactionMaster.Remarks AS RemarksMaster, dbo.tblVehicleIssueTransactionMaster.EnteredBy, dbo.tblVehicleIssueTransactionMaster.SysTimeStamp, dbo.tblVehicleIssueTransactionDetail.TransactionType, dbo.tblVehicleIssueTransactionDetail.Amount, dbo.tblVehicleIssueTransactionDetail.Remarks AS RemarksDetail, dbo.tblEmployees.EmployeeName, dbo.tblVehicles.VehicleNumber FROM dbo.tblVehicleIssueTransactionMaster INNER JOIN dbo.tblVehicleIssueTransactionDetail ON dbo.tblVehicleIssueTransactionMaster.TransactionNumber = dbo.tblVehicleIssueTransactionDetail.TransactionNumber INNER JOIN dbo.tblVehicleIssuance ON dbo.tblVehicleIssueTransactionMaster.IssueId = dbo.tblVehicleIssuance.IssueId LEFT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId LEFT OUTER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId WHERE (dbo.tblVehicleIssueTransactionMaster.TransactionNumber = @TransactionNumber)")


        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@TransactionNumber", SqlDbType.NVarChar).Value = txtTransactionNumber.Text
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        Dim frm As New frmRptViewer
        frm.Text = "Transaction Report"

        Dim rpt As Object

        rpt = New rptTransactoinReceiptA5

        GetAccBalance("Employee", Trim(txtEmployeeGLCode.Text))

        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.setparametervalue("Address1", vCompanyAddress1)
        rpt.setparametervalue("Address2", vCompanyAddress2)
        rpt.setparametervalue("AccBalance", AccBalanceStr)



        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()

        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.TopMost = True

    End Sub

    Private Sub dgvDetail_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvDetail.CellFormatting

        ''Compare the value of second Column i.e. Column with Index 3.
        'If e.ColumnIndex = 3 AndAlso e.Value IsNot Nothing Then

        '    'Fetch the value of the second Column.

        '    Dim Amount As Decimal = Convert.ToInt64(e.Value)

        '    'Apply Background color based on value.

        '    If Amount = 0 Then
        '        e.CellStyle.ForeColor = Color.Green
        '    End If

        '    If Amount > 0 Then
        '        e.CellStyle.ForeColor = Color.Green
        '    End If

        '    If Amount < 0 Then
        '        e.CellStyle.ForeColor = Color.Red
        '    End If
        'End If
    End Sub

    Private Sub txtEmployeeGLCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmployeeGLCode.TextChanged
        GetAccBalance("Employee", Trim(txtEmployeeGLCode.Text))
    End Sub
    Dim AccBalance As Double
    Dim AccBalanceStr As String
    Sub GetAccBalance(ByVal Source As String, ByVal AccCode As String)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim cmdText As New System.Text.StringBuilder

        If Source <> "Employee" Then
            Exit Sub
        End If
        With cmd
            .Connection = Conn
            .CommandText = "SELECT SUM(Debit-Credit) AS Balance FROM vwGeneralJournal WHERE AccCode = @AccCode"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim BalancePlus As Double
        Dim DrCr As String = "Nill"
        AccBalance = Val(dt.Rows(0).Item("Balance").ToString)

        If AccBalance > 0 Then
            BalancePlus = AccBalance
            DrCr = "Dr"
        ElseIf AccBalance < 0 Then
            BalancePlus = AccBalance * -1
            DrCr = "Cr"
        Else
            DrCr = "Nill"
        End If
        If Source = "Employee" Then
            AccBalanceStr = Format(BalancePlus, "#,###") & "  " & DrCr
            lblBalance.Text = AccBalanceStr
        End If

    End Sub

   
    Private Sub txtInformationIssueId_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInformationIssueId.TextChanged
        GetReceivedTillToday(Val(txtInformationIssueId.Text))
    End Sub
    Sub GetReceivedTillToday(IssueId As Long)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssueTransactionMaster.IssueId, SUM(dbo.tblVehicleIssueTransactionDetail.Amount) AS Amount FROM dbo.tblVehicleIssueTransactionMaster INNER JOIN dbo.tblVehicleIssueTransactionDetail ON dbo.tblVehicleIssueTransactionMaster.TransactionNumber = dbo.tblVehicleIssueTransactionDetail.TransactionNumber GROUP BY dbo.tblVehicleIssueTransactionMaster.IssueId HAVING (dbo.tblVehicleIssueTransactionMaster.IssueId = @IssueId)"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = IssueId
        End With

        da.SelectCommand = cmd

        dt.Clear()

        da.Fill(dt)
        Dim Amount As Single = 0
        If dt.Rows.Count > 0 Then
            Amount = dt.Rows(0).Item("Amount")
        End If

        txtTotalReceivedTillToday.Text = Amount
    End Sub

   

  
End Class