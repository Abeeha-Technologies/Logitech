Imports System.Data.SqlClient
Public Class frmReceiptVoucher
    Const VoucherType As String = "CRV"
    Const MasterTable As String = "tblAccReceiptVoucherMaster"
    Const DetailTable As String = "tblAccReceiptVoucherDetail"

    Dim ChangeVoucherNumberOn As String
    Dim ChangeVoucherNumberOnSpecificMonth As String

    Dim TblAccountSearchBindingSource As New BindingSource
    Dim pnlAccountSearchSource As String

    Sub SetformStateNew()
        AssignCompanyVariables()

        ClearMasterFields()
        nudVoucherNumber.Value = GetNewVoucherNumber.ToString

        ClearSearchPanels()

        ClearDetailFields()
        txtDescriptionDetail.Text = ""
        txtTotalAmount.Text = 0
        dgvTransactions.Rows.Clear()

        FillSearchDGV()

        txtAccTitleMaster.Focus()
    End Sub
    Sub ClearMasterFields()
        txtIsEdit.Text = Nothing

        txtAccCodeMaster.Text = Nothing
        txtAccTitleMaster.Text = Nothing
        txtAccBalanceMaster.Text = Nothing
        txtDescription.Text = Nothing
        txtChequeNumber.Text = Nothing

        txtUser.Text = vUserName






    End Sub

    Sub ClearSearchPanels()

        FillAccountSearchList()
    End Sub

    Sub FillAccountSearchList()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        With cmd
            .Connection = Conn
            .CommandText = "SELECT AccCode, AccName, AccType, AccNature FROM tblAccChartOfAccounts WHERE IsAccount = 1"
            .Parameters.Clear()
        End With
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        TblAccountSearchBindingSource.DataSource = dt

        dgvAccountSearch.DataSource = TblAccountSearchBindingSource
        dgvAccountSearch.Columns("AccCode").Width = 100
        dgvAccountSearch.Columns("AccType").Visible = False
        dgvAccountSearch.Columns("AccName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If
    End Sub


    Sub ClearDetailFields()
        txtDetailOrderRowIndex.Text = Nothing
        txtAccCodeDetail.Text = Nothing
        txtAccTitleDetail.Text = Nothing
        txtAmountDetail.Text = 0



    End Sub



    Function GetNewVoucherNumber() As String
        GetNewVoucherNumber = "1"

        Dim tblName As String = MasterTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim qryStr As New System.Text.StringBuilder

        Dim intSpecificMonth As Integer
        Dim intCurrentMonth As Integer
        Dim intCurrentYear As Integer

        qryStr.Append("SELECT MAX(VoucherNo) FROM " & tblName & " WHERE VoucherType ='" & cboVoucherType.SelectedItem.ToString & "'")
        If ChangeVoucherNumberOn = "Monthly" Then
            qryStr.Append(" AND DATEPART(year, VoucherDate) = @VoucherYear AND DATEPART(month, VoucherDate) = @VoucherMonth")
        ElseIf ChangeVoucherNumberOn = "Yearly" Then
            qryStr.Append(" AND DATEPART(year, VoucherDate) = @VoucherYear")
        End If
        If ChangeVoucherNumberOn = "Specific Month" Then
            If ChangeVoucherNumberOnSpecificMonth = "January" Then
                intSpecificMonth = 1
            ElseIf ChangeVoucherNumberOnSpecificMonth = "February" Then
                intSpecificMonth = 2
            ElseIf ChangeVoucherNumberOnSpecificMonth = "March" Then
                intSpecificMonth = 3
            ElseIf ChangeVoucherNumberOnSpecificMonth = "April" Then
                intSpecificMonth = 4
            ElseIf ChangeVoucherNumberOnSpecificMonth = "May" Then
                intSpecificMonth = 5
            ElseIf ChangeVoucherNumberOnSpecificMonth = "June" Then
                intSpecificMonth = 6
            ElseIf ChangeVoucherNumberOnSpecificMonth = "July" Then
                intSpecificMonth = 7
            ElseIf ChangeVoucherNumberOnSpecificMonth = "August" Then
                intSpecificMonth = 8
            ElseIf ChangeVoucherNumberOnSpecificMonth = "September" Then
                intSpecificMonth = 9
            ElseIf ChangeVoucherNumberOnSpecificMonth = "October" Then
                intSpecificMonth = 10
            ElseIf ChangeVoucherNumberOnSpecificMonth = "November" Then
                intSpecificMonth = 11
            ElseIf ChangeVoucherNumberOnSpecificMonth = "December" Then
                intSpecificMonth = 12
            Else
                intSpecificMonth = 0
            End If



            intCurrentMonth = Val(dtpVoucherDate.Value.Month.ToString)
            intCurrentYear = Val(dtpVoucherDate.Value.Year.ToString)
            If intCurrentMonth >= intSpecificMonth Then
                qryStr.Append(" AND DATEPART(year, VoucherDate) = @intCurrentYear AND DATEPART(month, VoucherDate) >= @intSpecificMonth")
            End If
        End If

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = qryStr.ToString
            .Parameters.Clear()
            .Parameters.Add("@VoucherYear", SqlDbType.NVarChar).Value = dtpVoucherDate.Value.Year.ToString
            .Parameters.Add("@VoucherMonth", SqlDbType.NVarChar).Value = dtpVoucherDate.Value.Month.ToString
            .Parameters.Add("@intCurrentYear", SqlDbType.NVarChar).Value = intCurrentYear
            .Parameters.Add("@intSpecificMonth", SqlDbType.NVarChar).Value = intSpecificMonth

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
    Private Sub frmReceiptVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplitContainer.Panel1Collapsed = True

        cboVoucherType.SelectedItem = VoucherType

        SetformStateNew()


    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmReceiptVoucher_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F9 Then
            If chkPreview.Checked = True Then
                chkPreview.Checked = False
            Else
                chkPreview.Checked = True
            End If
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

        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnSave_Click(Me, Nothing)

        End If
        If e.KeyCode = Keys.F5 Then
            btnRefresh_Click(Me, Nothing)

        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtAccCodeMaster.Text = Nothing Then
            MsgBox("Please Enter Valid Received Account")
            txtAccTitleMaster.Focus()
            Exit Sub
        End If
        If dgvTransactions.Rows.Count < 1 Then
            MsgBox("Voucher must have at least 1 transaction")
            Exit Sub
        End If
        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        trans = Conn.BeginTransaction
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .Transaction = trans
        End With
        If txtIsEdit.Text = Nothing Then
            Try
                With cmd
                    .CommandText = "INSERT INTO " & MasterTable & " (VoucherId, VoucherNo, VoucherType, VoucherDate, AccCode, Description, EntryUser, ChequeNumber, IsApproved) VALUES (@VoucherId, @VoucherNo, @VoucherType, @VoucherDate, @AccCode, @Description, @EntryUser, @ChequeNumber, @IsApproved)"
                    .Parameters.Clear()
                    .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
                    .Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = nudVoucherNumber.Value
                    .Parameters.Add("@voucherType", SqlDbType.NVarChar).Value = cboVoucherType.SelectedItem
                    .Parameters.Add("@VoucherDate", SqlDbType.Date).Value = dtpVoucherDate.Value
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtAccCodeMaster.Text
                    .Parameters.Add("@Description", SqlDbType.NVarChar).Value = Trim(txtDescription.Text)
                    .Parameters.Add("@ChequeNumber", SqlDbType.NVarChar).Value = txtChequeNumber.Text
                    .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = txtUser.Text
                    .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = chkIsApproved.Checked

                    .ExecuteNonQuery()
                End With

                If dgvTransactions.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In dgvTransactions.Rows
                        With cmd
                            .CommandText = "INSERT INTO " & DetailTable & " (VoucherId, AccCode, Description, Amount) VALUES (@VoucherId, @AccCode, @Description, @Amount)"
                            .Parameters.Clear()
                            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
                            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = row.Cells("AccCode").Value
                            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = row.Cells("Description").Value
                            .Parameters.Add("@Amount", SqlDbType.Decimal).Value = row.Cells("Amount").Value
                            .ExecuteNonQuery()
                        End With
                    Next
                End If

                trans.Commit()
                MsgBox("Saved Sucessfully", vbInformation, CompanyName)
                If chkPreview.Checked = True Then
                    PreviewVoucher()
                End If
                SetformStateNew()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Try
                    trans.Rollback()

                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                End Try
                If Conn.State <> ConnectionState.Open Then
                    Conn.Open()
                End If
            Finally
                If Conn.State <> ConnectionState.Closed Then
                    Conn.Close()
                End If
            End Try

        End If
        'End Insert


        'Start Update
        If txtIsEdit.Text <> Nothing Then
            Try
                With cmd
                    .CommandText = "UPDATE " & MasterTable & " SET VoucherNo = @VoucherNo, VoucherType = @VoucherType, VoucherDate = @VoucherDate, AccCode = @AccCode, Description = @Description, EntryUser = @EntryUser, ChequeNumber = @ChequeNumber, IsApproved = @IsApproved WHERE VoucherId = @VoucherId"
                    .Parameters.Clear()
                    .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
                    .Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = nudVoucherNumber.Value
                    .Parameters.Add("@voucherType", SqlDbType.NVarChar).Value = cboVoucherType.SelectedItem
                    .Parameters.Add("@VoucherDate", SqlDbType.Date).Value = dtpVoucherDate.Value
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtAccCodeMaster.Text
                    .Parameters.Add("@Description", SqlDbType.NVarChar).Value = txtDescription.Text
                    .Parameters.Add("@ChequeNumber", SqlDbType.NVarChar).Value = txtChequeNumber.Text
                    .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = txtUser.Text
                    .Parameters.Add("@IsApproved", SqlDbType.Bit).Value = chkIsApproved.Checked

                    .ExecuteNonQuery()
                End With

                If dgvTransactions.Rows.Count = 0 Then
                    Dim cmdDelete As New SqlCommand
                    Dim qryDelete As String
                    qryDelete = "DELETE FROM " & DetailTable & " WHERE PurchaseOrderId = '" & txtVoucherId.Text & "'"
                    With cmdDelete
                        .Transaction = trans
                        .Connection = Conn
                        .CommandType = CommandType.Text
                        .CommandText = qryDelete

                    End With
                    cmdDelete.ExecuteNonQuery()
                End If

                'Start Check From DB

                Dim blnStopCheck As Boolean = False
                Dim blnFound As Boolean = False


                Dim daExistingVehicles As New SqlDataAdapter
                Dim dtExistingVehicles As New DataTable
                Dim cmdExistingVehicles As New SqlCommand
                With cmdExistingVehicles
                    .Transaction = trans
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT DetailId FROM " & DetailTable & " WHERE VoucherId ='" & txtVoucherId.Text & "'"
                End With
                daExistingVehicles.SelectCommand = cmdExistingVehicles

                dtExistingVehicles.Clear()
                daExistingVehicles.Fill(dtExistingVehicles)
                For Each ExistingVehiclerow As DataRow In dtExistingVehicles.Rows
                    blnStopCheck = False
                    blnFound = False
                    Dim ExistingSaleDetailId As Long = ExistingVehiclerow.Item(0).ToString


                    For i As Integer = 0 To dgvTransactions.Rows.Count - 1
                        If blnStopCheck = False Then


                            If ExistingSaleDetailId = Val(dgvTransactions.Rows(i).Cells("DetailId").Value) Then
                                blnStopCheck = True
                                blnFound = True

                            Else
                                blnStopCheck = False
                                blnFound = False


                            End If
                        End If
                        If i = dgvTransactions.Rows.Count - 1 Then
                            If blnFound = False Then




                                Dim cmdDeleteVehicle As New SqlCommand
                                Dim qryDeleteVehicle As String
                                qryDeleteVehicle = "DELETE FROM " & DetailTable & " WHERE DetailId = " & ExistingSaleDetailId
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


                For i = 0 To dgvTransactions.Rows.Count - 1

                    If Val(dgvTransactions.Rows(i).Cells("DetailId").Value) > 0 Then
                        With cmd
                            .CommandText = "UPDATE " & DetailTable & " SET AccCode = @AccCode, Description = @Description, Amount = @Amount WHERE DetailId = @DetailId"
                            .Parameters.Clear()
                            .Parameters.Add("@DetailId", SqlDbType.BigInt).Value = dgvTransactions.Rows(i).Cells("DetailId").Value
                            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = dgvTransactions.Rows(i).Cells("AccCode").Value
                            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = dgvTransactions.Rows(i).Cells("Description").Value
                            .Parameters.Add("@Amount", SqlDbType.Decimal).Value = dgvTransactions.Rows(i).Cells("Amount").Value
                            .ExecuteNonQuery()
                        End With
                    End If

                    If Val(dgvTransactions.Rows(i).Cells("DetailId").Value) < 1 Then
                        With cmd
                            .CommandText = "INSERT INTO " & DetailTable & " (VoucherId, AccCode, Description, Amount) VALUES (@VoucherId, @AccCode, @Description, @Amount)"
                            .Parameters.Clear()
                            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
                            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = dgvTransactions.Rows(i).Cells("AccCode").Value
                            .Parameters.Add("@Description", SqlDbType.NVarChar).Value = dgvTransactions.Rows(i).Cells("Description").Value
                            .Parameters.Add("@Amount", SqlDbType.Decimal).Value = dgvTransactions.Rows(i).Cells("Amount").Value
                            .ExecuteNonQuery()
                        End With
                    End If




                Next

                trans.Commit()
                MsgBox("Saved Sucessfully", vbInformation, CompanyName)
                If chkPreview.Checked = True Then
                    PreviewVoucher()
                End If
                SetformStateNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Try
                    trans.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)

                End Try
                If Conn.State <> ConnectionState.Open Then
                    Conn.Open()
                End If
            Finally
                If Conn.State <> ConnectionState.Closed Then
                    Conn.Close()
                End If
            End Try

        End If
    End Sub
    Sub PreviewVoucher()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT * FROM vwGeneralJournal WHERE VoucherId = @VoucherId")

        Dim VoucherIdParts() As String
        VoucherIdParts = txtVoucherId.Text.Split("-")
        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Dim VoucherTitle As String = ""
        If VoucherIdParts(0).ToString = "BPV" Then
            VoucherTitle = "Bank Payment Voucher"
        ElseIf VoucherIdParts(0).ToString = "BRV" Then
            VoucherTitle = "Bank Receipt Voucher"
        ElseIf VoucherIdParts(0).ToString = "CPV" Then
            VoucherTitle = "Cash Payment Voucher"
        ElseIf VoucherIdParts(0).ToString = "CRV" Then
            VoucherTitle = "Cash Receipt Voucher"
        ElseIf VoucherIdParts(0).ToString = "JV" Then
            VoucherTitle = "Journal Voucher"
        Else
            VoucherTitle = VoucherIdParts(0).ToString
        End If

        Dim frm As New frmRptViewer
        frm.Text = VoucherTitle
        Dim rpt As Object
        rpt = New rptJournalVoucher
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.setParameterValue("VoucherTitle", VoucherTitle)
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.TopMost = True

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtIsEdit.Text <> Nothing Then
            If MsgBox("Do you Really Want to Delete?" & vbNewLine & "This event is not reversable.", vbYesNo + vbCritical, "Confirmation") = vbYes Then

                If vRequireUserPasswordForDelete = "True" Then
                    frmPasswordInput.ShowDialog()
                    If frmPasswordInput.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                        Delete(txtVoucherId.Text)
                        Exit Sub
                    Else
                        Exit Sub
                    End If

                End If
                Delete(txtVoucherId.Text)

            End If

        End If

    End Sub
    Sub Delete(ByVal VoucherId As String)

        Try
            Dim cmd As New SqlCommand

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            With cmd
                .Connection = Conn
                .CommandText = "DELETE FROM " & MasterTable & " WHERE VoucherId = @VoucherId"
                .Parameters.Clear()
                .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = VoucherId
                .ExecuteNonQuery()
            End With


            SetformStateNew()
            MsgBox("Voucher Deleted")
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
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SetformStateNew()
    End Sub

    Private Sub btnSearchAccMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAccMaster.Click
        ShowAccSearchDialog("Master")
    End Sub
    Private Sub btnSearchAccDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAccDetail.Click
        ShowAccSearchDialog("Detail")
    End Sub
    Sub ShowAccSearchDialog(ByVal Source As String)
        ' Get the value that the child will be initialised with
        Dim InitialValue1, InitialValue2 As String
        InitialValue1 = ""
        InitialValue2 = ""
        If Source = "Master" Then
            If cboVoucherType.SelectedItem = "BRV" Then
                InitialValue1 = "BRVMaster"
                InitialValue2 = "Bank"

            Else
                InitialValue1 = "CRVMaster"
                InitialValue2 = "Cash"

            End If
        End If
        If Source = "Detail" Then

            InitialValue1 = "PVDetail"
            InitialValue2 = txtAccCodeMaster.Text

        End If
        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(InitialValue1, InitialValue2)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub






    Private Sub txtTotalAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmount.TextChanged
        If Val(txtTotalAmount.Text) > 0 Then

            lblResult.Text = NumberToText(txtTotalAmount.Text) & " Rupees Only"
        Else
            lblResult.Text = Nothing
        End If
    End Sub

    Private Sub txtVoucherId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoucherId.TextChanged
        FillMaster()

        FillTransactions()

    End Sub
    Sub FillMaster()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT * FROM " & MasterTable & " WHERE VoucherId = @VoucherId"
            .Parameters.Clear()
            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            txtIsEdit.Text = 1
            cboVoucherType.SelectedItem = dt.Rows(0).Item("VoucherType")
            cboVoucherType.Enabled = False
            nudVoucherNumber.Value = dt.Rows(0).Item("VoucherNo")
            dtpVoucherDate.Value = dt.Rows(0).Item("VoucherDate")

            txtAccCodeMaster.Text = dt.Rows(0).Item("AccCode")
            txtDescription.Text = dt.Rows(0).Item("Description")
            txtChequeNumber.Text = dt.Rows(0).Item("ChequeNumber")



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
            .CommandText = "SELECT dbo.tblAccReceiptVoucherDetail.DetailId, dbo.tblAccReceiptVoucherDetail.VoucherId, dbo.tblAccReceiptVoucherDetail.AccCode, dbo.tblAccReceiptVoucherDetail.Description, dbo.tblAccReceiptVoucherDetail.Amount, dbo.tblAccReceiptVoucherDetail.SysTimeStamp, dbo.tblAccChartOfAccounts.AccName FROM dbo.tblAccReceiptVoucherDetail INNER JOIN dbo.tblAccChartOfAccounts ON dbo.tblAccReceiptVoucherDetail.AccCode = dbo.tblAccChartOfAccounts.AccCode WHERE VoucherId = @VoucherId"
            .Parameters.Clear()
            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            dgvTransactions.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgvTransactions.Rows.Add(row.Item("AccCode"), row.Item("AccName"), row.Item("Description"), row.Item("Amount"), row.Item("DetailId"))

            Next
            ClearDetailFields()
        Else

            dgvTransactions.Rows.Clear()
        End If
        CalcTotal()
    End Sub


    Private Sub dtpVoucherDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpVoucherDate.ValueChanged, cboVoucherType.SelectedIndexChanged
        If txtIsEdit.Text = Nothing Then
            nudVoucherNumber.Value = GetNewVoucherNumber.ToString
            AssignVoucherId()

        End If
        FillAccountSearchList()
    End Sub
    Sub AssignVoucherId()
        txtVoucherId.Text = cboVoucherType.SelectedItem.ToString & "-" & nudVoucherNumber.Value
    End Sub

    Private Sub txtAccCodeDetail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDetail.TextChanged
        Dim Criteria As String
        If txtAccTitleMaster.Text <> Nothing Then

            Criteria = "AccCode = @AccCode AND AccCode <> '" & txtAccCodeMaster.Text & "'"
        Else
            Criteria = "AccCode = @AccCode"

        End If
        GetAccDetail("Detail", Trim(txtAccCodeDetail.Text), Criteria)
    End Sub
    Private Sub txtAccTitleDetail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccTitleDetail.Validating
        Dim Criteria As String
        If txtAccTitleMaster.Text <> Nothing Then

            Criteria = "AccCode = @AccCode AND AccCode <> '" & txtAccCodeMaster.Text & "'"
        Else
            Criteria = "AccCode = @AccCode"

        End If
        GetAccDetail("Detail", Trim(txtAccCodeDetail.Text), Criteria)
        pnlAccountSearch.Visible = False
    End Sub

    Private Sub txtAccCodeMaster_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeMaster.TextChanged
        Dim Criteria As String

        If cboVoucherType.SelectedItem = "BRV" Then
            Criteria = "AccCode = @AccCode AND AccType = 'Bank'"
        Else
            Criteria = "AccCode = @AccCode AND AccType = 'Cash'"
        End If
        GetAccDetail("Master", Trim(txtAccCodeMaster.Text), Criteria)

    End Sub
    Private Sub txtAccTitleMaster_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccTitleMaster.Validating
        Dim Criteria As String

        If cboVoucherType.SelectedItem = "BRV" Then
            Criteria = "AccCode = @AccCode AND AccType = 'Bank'"
        Else
            Criteria = "AccCode = @AccCode AND AccType = 'Cash'"
        End If
        GetAccDetail("Master", Trim(txtAccCodeMaster.Text), Criteria)
        pnlAccountSearch.Visible = False
    End Sub
    Sub GetAccDetail(ByVal Source As String, ByVal AccCode As String, ByVal Criteria As String)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim cmdText As New System.Text.StringBuilder
        cmdText.Append("SELECT AccName, AccNature FROM tblAccChartOfAccounts WHERE IsAccount = 1 AND " & Criteria & " AND ")



        cmdText.Replace(cmdText.ToString, cmdText.Remove(cmdText.Length - 4, 4).ToString)

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
            If Source = "Master" Then
                txtAccTitleMaster.Text = dt.Rows(0).Item("AccName")
            Else
                txtAccTitleDetail.Text = dt.Rows(0).Item("AccName")
            End If

        Else
            If Source = "Master" Then
                txtAccTitleMaster.Text = Nothing
            Else
                txtAccTitleDetail.Text = Nothing
            End If
        End If

        With cmd
            .CommandText = "SELECT SUM(Debit-Credit) AS Balance FROM vwGeneralJournal WHERE AccCode = @AccCode"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
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
        If Source = "Master" Then
            txtAccBalanceMaster.Text = Format(BalancePlus, "#,###") & "  " & DrCr
        Else
            txtAccBalanceDetail.Text = Format(BalancePlus, "#,###") & "  " & DrCr
        End If

    End Sub



    Private Sub dgvTransactions_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.CellValueChanged
        CalcTotal()
    End Sub
    Sub CalcTotal()
        Dim TotalAmouont As Double
        TotalAmouont = 0
        For i = 0 To dgvTransactions.Rows.Count - 1
            TotalAmouont += dgvTransactions.Rows(i).Cells("Amount").Value
        Next
        txtTotalAmount.Text = TotalAmouont
    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged
        FillSearchDGV()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVoucherTypeSearch.SelectedIndexChanged
        FillSearchDGV()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateFrom.ValueChanged
        FillSearchDGV()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateTo.ValueChanged
        FillSearchDGV()
    End Sub
    Sub FillSearchDGV()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As String
        Dim cmd As New SqlCommand
        If SplitContainer.Panel2Collapsed = False Then
            qryStr = "SELECT VoucherId AS Voucher, VoucherType FROM vwGeneralJournal " & _
                     "WHERE TransactionDate >= @DateFrom AND TransactionDate <= @DateTo"
        Else

            qryStr = "SELECT VoucherId AS Voucher, AccCode AS Code, AccName AS Account, Description, Debit, Credit, VoucherType FROM vwGeneralJournal " & _
                     "WHERE TransactionDate >= @DateFrom AND TransactionDate <= @DateTo"
        End If

        qryStr &= " AND VoucherType ='" & cboVoucherTypeSearch.SelectedItem & "'"
        If txtSearchText.Text <> Nothing Then
            qryStr &= " AND VoucherId + ' ' + Description + ' ' + AccCode + ' ' + AccName LIKE '%" & txtSearchText.Text & "%'"
        End If

        If SplitContainer.Panel2Collapsed = False Then

            qryStr &= " GROUP BY VoucherId, VoucherType"

        End If
        qryStr &= " ORDER BY Voucher"
        With cmd
            .Connection = Conn
            .CommandText = qryStr.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value

        End With
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        dgvList.DataSource = dt
        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If
        If SplitContainer.Panel2Collapsed = False Then
            dgvList.Columns("Voucher").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Else
            dgvList.Columns("Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvList.Columns("Debit").DefaultCellStyle.Format = "#,###"
            dgvList.Columns("Credit").DefaultCellStyle.Format = "#,###"
        End If

        dgvList.Columns("VoucherType").Visible = False




        If SplitContainer.Panel2Collapsed = True Then
            For Each col As DataGridViewColumn In dgvList.Columns
                If col.HeaderText = "Voucher" Then
                Else
                    col.Visible = True
                End If
            Next
        Else
            For Each col As DataGridViewColumn In dgvList.Columns
                If col.HeaderText = "Voucher" Then
                Else
                    col.Visible = False
                End If
            Next
        End If

    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtVoucherId.Text = dgvList.CurrentRow.Cells("Voucher").Value
            If SplitContainer.Panel2Collapsed = True Then
                ShowDetailPanel()
            End If
        End If
    End Sub

    Private Sub dgvList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvList.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvList_CellDoubleClick(Me, Nothing)
        End If
    End Sub
    Private Sub cboVoucherType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVoucherType.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtVoucherId.Focus()
        End If
    End Sub

    Private Sub txtVoucherId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoucherId.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpVoucherDate.Focus()
        End If
    End Sub

    Private Sub dtpVoucherDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVoucherDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAccCodeMaster.Focus()
        End If
    End Sub

    Private Sub txtDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtChequeNumber.Focus()
        End If
    End Sub

    Private Sub txtChequeNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChequeNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAccCodeDetail.Focus()
        End If
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        txtDescriptionDetail.Text = txtDescription.Text
    End Sub

    Private Sub txtAmountDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmountDetail.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPin_Click(sender, e)
        End If
    End Sub

    Private Sub btnPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin.Click
        If txtAccTitleDetail.Text = Nothing Then
            MsgBox("Please enter valid Account")
            txtAccCodeDetail.Focus()
            Exit Sub
        End If
        If Val(txtAmountDetail.Text) <= 0 Then
            MsgBox("please Enter Valid Amount")
            Exit Sub
        End If
        If txtDetailOrderRowIndex.Text = Nothing Then
            dgvTransactions.Rows.Add(txtAccCodeDetail.Text, txtAccTitleDetail.Text, txtDescriptionDetail.Text, txtAmountDetail.Text, "")

        Else
            For Each row As DataGridViewRow In dgvTransactions.Rows
                If row.Index = txtDetailOrderRowIndex.Text Then
                    row.Cells("AccCode").Value = txtAccCodeDetail.Text
                    row.Cells("AccTitle").Value = txtAccTitleDetail.Text
                    row.Cells("Description").Value = txtDescriptionDetail.Text
                    row.Cells("Amount").Value = txtAmountDetail.Text
                End If

            Next

        End If

        ClearDetailFields()
        txtAccTitleDetail.Focus()

        CalcTotal()

    End Sub

    Private Sub dgvTransactions_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransactions.CellDoubleClick
        FillTransactionDetail()
    End Sub
    Sub FillTransactionDetail()
        If dgvTransactions.Rows.Count > 0 Then
            With dgvTransactions.CurrentRow
                txtDetailOrderRowIndex.Text = .Index
                txtAccCodeDetail.Text = .Cells.Item("AccCode").Value()
                txtDescriptionDetail.Text = .Cells.Item("Description").Value
                txtAmountDetail.Text = .Cells.Item("Amount").Value
            End With

        End If

    End Sub


    Private Sub txtAccCodeMaster_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccCodeMaster.KeyPress
        KeyPressNumeric(e, sender)
    End Sub

    Private Sub txtDescriptionDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescriptionDetail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAmountDetail.Focus()
        End If
    End Sub


    Private Sub txtAccCodeDetail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccCodeDetail.Validating

        If Trim(txtAccCodeDetail.TextLength) > 0 Then
            If txtAccTitleDetail.TextLength < 1 Then
                pnlAccountSearch.Visible = False
            End If
        End If
    End Sub

    Private Sub txtAccCodeDetail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccCodeDetail.KeyPress
        KeyPressNumeric(e, sender)
    End Sub

    Private Sub nudVoucherNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudVoucherNumber.ValueChanged
        AssignVoucherId()
    End Sub


    Private Sub nudVoucherNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudVoucherNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpVoucherDate.Focus()
        End If
    End Sub

    Private Sub lblAddNewAccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblAddNewAccount.LinkClicked

        If vAccounting = "Advanced" Then
            Dim frm As New frmAccountsAdvanced
            frm.ShowDialog()

        ElseIf vAccounting = "Simple" Then
            Dim frm As New frmAccountsSimple
            frm.ShowDialog()

        End If
        FillAccountSearchList()
    End Sub
    Sub ShowDetailPanel()
        SplitContainer.Panel2Collapsed = False
        picPanelExtender.BackgroundImage = imgList.Images(0)
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "Voucher" Then
            Else
                col.Visible = False
            End If
        Next
        FillSearchDGV()
    End Sub
    Sub HideDetailPanel()
        SplitContainer.Panel2Collapsed = True
        picPanelExtender.BackgroundImage = imgList.Images(1)
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "Voucher" Then
            Else
                col.Visible = True
            End If
        Next
        FillSearchDGV()
    End Sub

    Private Sub picPanelExtender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPanelExtender.Click
        If SplitContainer.Panel2Collapsed = False Then
            HideDetailPanel()
        Else
            ShowDetailPanel()

        End If

    End Sub


    Private Sub txtAccTitleMaster_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccTitleMaster.TextChanged
        Dim Criteria As String
        If cboVoucherType.SelectedItem = "BRV" Then
            Criteria = "AccType = 'Bank'"
        Else
            Criteria = "AccType = 'Cash'"
        End If

        If txtAccTitleMaster.Focused = True Then
            If Not Me.txtAccTitleMaster.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccTitleMaster.Text & "%' AND " & Criteria)
                pnlAccountSearchSource = "MasterTitle"

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeMaster.Text = Nothing


            End If
        End If
    End Sub

    Private Sub pnlAccountSearch_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlAccountSearch.VisibleChanged
        If pnlAccountSearchSource = "MasterTitle" Then
            If pnlAccountSearch.Visible = True Then
                'pnlAccountSearch.Location = New Point(82, 32)
                pnlAccountSearch.Size = New Size(450, 250)
            End If
        ElseIf pnlAccountSearchSource = "MasterCode" Then
            If pnlAccountSearch.Visible = True Then
                'pnlAccountSearch.Location = New Point(83, 32)
                pnlAccountSearch.Size = New Size(450, 250)
            End If
        ElseIf pnlAccountSearchSource = "DetailTitle" Then
            If pnlAccountSearch.Visible = True Then
                'pnlAccountSearch.Location = New Point(134, 177S)
                pnlAccountSearch.Size = New Size(450, 250)
            End If
        ElseIf pnlAccountSearchSource = "DetailCode" Then
            If pnlAccountSearch.Visible = True Then
                'pnlAccountSearch.Location = New Point(4, 177)
                pnlAccountSearch.Size = New Size(450, 250)
            End If

        End If
    End Sub

    Private Sub txtAccTitleMaster_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccTitleMaster.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                If txtAccCodeMaster.Text = Nothing Then
                    txtDescription.Focus()

                Else
                    txtDescription.Focus()
                End If
            End If
        End If
        If Not Me.txtAccTitleMaster.Text = "" Then
            If e.KeyCode = Keys.Enter Then
                If pnlAccountSearch.Visible = True Then

                    If dgvAccountSearch.RowCount > 0 Then
                        Dim int As Integer
                        For Each row As DataGridViewRow In dgvAccountSearch.Rows
                            If row.Selected = True Then
                                int = row.Index
                            End If
                        Next
                        dgvAccountSearch.Focus()
                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int).Cells(1)
                        SelectAccount("MasterTitle")
                        pnlAccountSearch.Visible = False
                        txtDescription.Focus()
                    End If
                End If
            End If

            If e.KeyCode = Keys.Down Then

                If pnlAccountSearch.Visible = True AndAlso dgvAccountSearch.Rows.Count > 0 Then

                    Dim int As Integer
                    For Each row As DataGridViewRow In dgvAccountSearch.Rows
                        If row.Selected = True Then
                            int = row.Index
                        End If
                    Next

                    If dgvAccountSearch.RowCount - 1 > int Then

                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int + 1).Cells(1)
                    Else
                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int).Cells(1)
                    End If


                End If

            End If
            If e.KeyCode = Keys.Up Then

                If pnlAccountSearch.Visible = True AndAlso dgvAccountSearch.Rows.Count > 0 Then

                    Dim int As Integer
                    For Each row As DataGridViewRow In dgvAccountSearch.Rows
                        If row.Selected = True Then
                            int = row.Index
                        End If
                    Next

                    If int > 0 Then

                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int - 1).Cells(1)
                    Else
                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int).Cells(1)
                    End If


                End If

            End If
        Else
            If e.KeyCode = Keys.Enter Then

                pnlAccountSearch.Visible = False
            End If
        End If
    End Sub
    Private Sub SelectAccount(ByVal Source As String)
        If Source = "MasterTitle" Or Source = "MasterCode" Then
            txtAccCodeMaster.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString

            txtDescription.Focus()
        ElseIf Source = "DetailTitle" Or Source = "DetailCode" Then
            txtAccCodeDetail.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString

            txtDescriptionDetail.Focus()

        End If


    End Sub

    Private Sub txtAccTitleDetail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccTitleDetail.TextChanged
        If txtAccTitleDetail.Focused = True Then
            If Not Me.txtAccTitleDetail.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccTitleDetail.Text & "%'")
                pnlAccountSearchSource = "DetailTitle"

                'pnlAccountSearch.Visible = False
                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()
                txtAccCodeDetail.Text = Nothing
                pnlAccountSearch.Visible = False


            End If
        End If


    End Sub


    Private Sub dgvAccountSearch_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccountSearch.CellDoubleClick
        If dgvAccountSearch.Rows.Count > 0 Then
            If pnlAccountSearchSource = "MasterCode" Or pnlAccountSearchSource = "MasterTitle" Then
                SelectAccount("MasterTitle")
            ElseIf pnlAccountSearchSource = "DetailCode" Or pnlAccountSearchSource = "DetailTitle" Then
                SelectAccount("DetailCode")

            End If


        End If
    End Sub



    Private Sub txtAccCodeMaster_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeMaster.Enter
        pnlAccountSearch.Location = New Point(82, 32)
    End Sub

    Private Sub txtAccTitleMaster_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccTitleMaster.Enter
        pnlAccountSearch.Location = New Point(82, 32)
    End Sub


    Private Sub txtAccTitleDetail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccTitleDetail.Enter
        pnlAccountSearch.Location = New Point(4, 177)
    End Sub


    Private Sub txtAccTitleDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccTitleDetail.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                If txtAccCodeDetail.Text = Nothing Then
                    txtDescriptionDetail.Focus()

                Else
                    txtDescriptionDetail.Focus()
                End If
            End If
        End If
        If Not Me.txtAccTitleDetail.Text = "" Then
            If e.KeyCode = Keys.Enter Then
                If pnlAccountSearch.Visible = True Then

                    If dgvAccountSearch.RowCount > 0 Then
                        Dim int As Integer
                        For Each row As DataGridViewRow In dgvAccountSearch.Rows
                            If row.Selected = True Then
                                int = row.Index
                            End If
                        Next
                        dgvAccountSearch.Focus()
                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int).Cells(1)
                        SelectAccount("DetailTitle")
                        pnlAccountSearch.Visible = False
                        txtDescriptionDetail.Focus()
                    End If
                End If
            End If

            If e.KeyCode = Keys.Down Then

                If pnlAccountSearch.Visible = True AndAlso dgvAccountSearch.Rows.Count > 0 Then

                    Dim int As Integer
                    For Each row As DataGridViewRow In dgvAccountSearch.Rows
                        If row.Selected = True Then
                            int = row.Index
                        End If
                    Next

                    If dgvAccountSearch.RowCount - 1 > int Then

                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int + 1).Cells(1)
                    Else
                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int).Cells(1)
                    End If


                End If

            End If
            If e.KeyCode = Keys.Up Then

                If pnlAccountSearch.Visible = True AndAlso dgvAccountSearch.Rows.Count > 0 Then

                    Dim int As Integer
                    For Each row As DataGridViewRow In dgvAccountSearch.Rows
                        If row.Selected = True Then
                            int = row.Index
                        End If
                    Next

                    If int > 0 Then

                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int - 1).Cells(1)
                    Else
                        dgvAccountSearch.CurrentCell = dgvAccountSearch.Rows(int).Cells(1)
                    End If


                End If

            End If
        Else
            If e.KeyCode = Keys.Enter Then

                pnlAccountSearch.Visible = False
            End If
        End If
    End Sub
    Private Sub dgvTransactions_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvTransactions.RowsAdded
        CalcTotal()
    End Sub

    Private Sub dgvTransactions_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvTransactions.RowsRemoved
        CalcTotal()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If txtIsEdit.Text <> Nothing Then
            'frmRptVouchers.txtVoucherId.Text = txtVoucherId.Text
            'frmRptVouchers.ShowDialog()
            PreviewVoucher()

        End If
    End Sub
    Private Sub btnApproveToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproveToggle.Click
        If txtIsEdit.Text <> Nothing Then
            If chkIsApproved.Checked = True Then
                chkIsApproved.Checked = False
            Else
                chkIsApproved.Checked = True
            End If
        End If
    End Sub

    Private Sub chkIsApproved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsApproved.CheckedChanged
        If chkIsApproved.Checked = True Then
            btnApproveToggle.Image = My.Resources.Resources.Png_CircleRed_24px
            btnApproveToggle.Text = "Draft"
        Else
            btnApproveToggle.Image = My.Resources.Resources.Png_CircleGreen_24px
            btnApproveToggle.Text = "Approve"
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

 
End Class