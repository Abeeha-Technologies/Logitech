Imports System.Data.SqlClient
Public Class frmAccountsSimple
    Dim OldAccName As String
    Dim OldAccCode As String
    Dim OldParentAccCode As String

    Dim TblSearchListBindingSource As New BindingSource
    Sub SetFormStateNew()

        FillCboParentAccount()
        ClearAllFields()


        FillMainSearchList()

        txtAccName.Focus()

    End Sub


    Sub ClearAllFields()

        OldAccName = Nothing
        OldAccCode = Nothing
        OldParentAccCode = Nothing

        txtId.Text = Nothing
        txtAccLevel.Text = 2
        chkIsAccount.Checked = True

        txtAccName.Text = Nothing

        txtContactName.Text = Nothing
        txtMobile.Text = Nothing
        txtLandline.Text = Nothing
        txtFax.Text = Nothing
        txtEmail.Text = Nothing
        txtWebsite.Text = Nothing

        txtAddress1.Text = Nothing
        txtAddress2.Text = Nothing
        txtCity.Text = Nothing
        txtState.Text = Nothing
        txtCountry.Text = Nothing
        txtPostalCode.Text = Nothing


        txtOpeningDebit.Text = 0
        txtOpeningCredit.Text = 0
        dtpOpeningDate.Value = Now.Date
        txtCreditLimit.Text = 0
        txtCreditDays.Text = 0
        txtNTN.Text = Nothing
        txtGST.Text = Nothing
        txtInvoiceGraceDays.Text = 0

        txtUser.Text = vUserName


    End Sub
    Sub FillCboParentAccount()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT AccCode + ' - ' + AccName AS Name, AccCode, AccName, AccType, AccNature FROM dbo.tblAccChartOfAccounts WHERE (AccLevel = 1) GROUP BY AccCode + ' - ' + AccName, AccCode, AccName, AccType, AccNature ORDER BY AccCode"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("Name") = "(--Select--)"
        row.Item("AccCode") = "00"
        row.Item("AccName") = "(--Select--)"
        row.Item("AccType") = "(--Select--)"
        row.Item("AccNature") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)

        cboParentAccount.DataSource = dt
        cboParentAccount.DisplayMember = dt.Columns("Name").ToString
        cboParentAccount.ValueMember = dt.Columns("AccCode").ToString

        cboAccType.DataSource = dt
        cboAccType.DisplayMember = dt.Columns("AccType").ToString
        cboAccType.ValueMember = dt.Columns("AccType").ToString

        cboAccNature.DataSource = dt
        cboAccNature.DisplayMember = dt.Columns("AccNature").ToString
        cboAccNature.ValueMember = dt.Columns("AccNature").ToString

    End Sub

    

    Sub FillMainSearchList()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As String
        Dim cmd As New SqlCommand

        qryStr = "SELECT AccId, AccCode, AccName, ContactName AS Contact, Mobile, Landline, Email, City FROM tblAccChartOfAccounts WHERE AccLevel > 1"

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

            dgvList.Columns("AccName").Width = 200
            dgvList.Columns("Contact").Width = 150
            dgvList.Columns("Mobile").Width = 120
            dgvList.Columns("Landline").Width = 120
            dgvList.Columns("Email").Width = 120
            dgvList.Columns("City").Width = 200
            dgvList.Columns("AccName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

            If cboAccType.SelectedValue = "Employee" Then
                MsgBox("Employee Account should be Deleted from Employee Form")
                Exit Sub
            End If

            If MsgBox("Do you Really Want to Delete?" & vbNewLine & "This event is not reversable.", vbYesNo + vbCritical, "Confirmation") = vbYes Then

                If vRequireUserPasswordForDelete = "True" Then
                    frmPasswordInput.ShowDialog()
                    If frmPasswordInput.DialogResult = Windows.Forms.DialogResult.Yes Then
                        Delete(txtId.Text, txtAccCode.Text)
                        Exit Sub
                    Else
                        Exit Sub
                    End If

                End If
                Delete(txtId.Text, txtAccCode.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal AccId As String, ByVal AccCode As String)

        Try
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter


            With cmd
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT EmployeeName FROM vwGeneralJournal WHERE GLAccCode = @GLAccCode"
                .Parameters.Clear()
                .Parameters.Add("@GLAccCode", SqlDbType.NVarChar).Value = AccCode
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim str As New System.Text.StringBuilder

                For i = 0 To dt.Rows.Count - 1
                    If i = 0 Then
                        str.Append(dt.Rows(i).Item("EmployeeName").ToString)
                    Else
                        str.Append(" | " & dt.Rows(i).Item("EmployeeName").ToString)
                    End If
                Next

                MsgBox("You can not Delete Current record. There is transactions in following Employees" & vbNewLine & str.ToString)
                Exit Sub
            End If


            With cmd
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT VoucherId FROM vwGeneralJournal WHERE VoucherType <> 'Opening Balance' AND AccCode = @AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim str As New System.Text.StringBuilder

                For i = 0 To dt.Rows.Count - 1
                    If i = 0 Then
                        str.Append(dt.Rows(i).Item("VoucherId").ToString)
                    Else
                        str.Append(" | " & dt.Rows(i).Item("VoucherId").ToString)
                    End If
                Next

                MsgBox("You can not Delete Current record. There is transactions in following vouchers" & vbNewLine & str.ToString)
                Exit Sub
            End If

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()

            End If

            If dt.Rows.Count = 0 Then
                With cmd
                    .CommandText = "DELETE FROM tblAccChartOfAccounts WHERE AccId = @AccId"
                    .Parameters.Clear()
                    .Parameters.Add("@AccId", SqlDbType.BigInt).Value = AccId
                    .ExecuteNonQuery()
                End With


            End If

            SetFormStateNew()
        Catch ex As Exception

        Finally
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

        End Try





    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cboParentAccount.SelectedIndex < 1 Then
            MsgBox("Please Select Catagory", , "Error")
            cboParentAccount.Focus()
            Exit Sub
        End If

        If cboAccType.SelectedIndex < 1 Then
            MsgBox("Please Select Catagory", , "Error")
            cboParentAccount.Focus()
            Exit Sub
        End If

        If cboAccNature.SelectedIndex < 1 Then
            MsgBox("Please Select Catagory", , "Error")
            cboParentAccount.Focus()
            Exit Sub
        End If

        If txtAccCode.Text = Nothing Then
            MsgBox("Please Select Catagory", , "Error")
            cboParentAccount.Focus()
            Exit Sub
        End If

        If txtAccName.Text = Nothing Then
            MsgBox("Please Enter some Account Title", , "Error")
            txtAccName.Focus()
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




        'Check if Acc Name Duplicates
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        If OldAccName <> txtAccName.Text Then
            With cmd
                .CommandText = "SELECT Count(AccCode) AS Count FROM tblAccChartOfAccounts WHERE AccName COLLATE Latin1_General_CS_AS = @AccName"
                .Parameters.Clear()
                .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = txtAccName.Text
            End With



            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) > 0 Then
                If MsgBox(txtAccName.Text & " seems Duplicates. Do you still want to add?", vbCritical + vbYesNo, "Error") = vbNo Then
                    Exit Sub
                End If

            End If
        End If
        'End Check Duplicate





        'Inser if Record is New
        If txtId.Text = Nothing Then

            If cboAccType.SelectedValue = "Employee" Then
                MsgBox("Employee Account should be added from Employee Form")
                Exit Sub
            End If

            If cboAccType.SelectedValue = "Vehicle" Then
                MsgBox("Vehicle Account should be added from Vehicle Form")
                Exit Sub
            End If

            'Check if Acc Code Duplicates
            With cmd
                .CommandText = "SELECT Count(AccCode) AS Count FROM tblAccChartOfAccounts WHERE AccCode = @AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtAccCode.Text
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) > 0 Then
                MsgBox(txtAccCode.Text & " seems Duplicates.", vbCritical + vbOKOnly, "Error")
                Exit Sub
            End If
            'End Check Acc Code Duplicate

            chkIsAccount.Checked = True

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
                    .CommandText = "INSERT INTO tblAccChartOfAccounts (AccCode, AccName, ParentAccCode, AccLevel, IsAccount, OpeningDate, OpeningDebit, OpeningCredit, CreditLimit, CreditDays, AccType, AccNature, Address1, Address2, City, State, Country, PostalCode, ContactName, Mobile, LandLine, Fax, Email, Website, NTN, GST, EntryUser, InvoiceGraceDays) VALUES (@AccCode, @AccName, @ParentAccCode, @AccLevel, @IsAccount, @OpeningDate, @OpeningDebit, @OpeningCredit, @CreditLimit, @CreditDays, @AccType, @AccNature, @Address1, @Address2, @City, @State, @Country, @PostalCode, @ContactName, @Mobile, @LandLine, @Fax, @Email, @Website, @NTN, @GST, @EntryUser, @InvoiceGraceDays)"
                    .Parameters.Clear()
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
                    .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtAccName.Text)
                    .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = cboParentAccount.SelectedValue
                    .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = txtAccLevel.Text
                    .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = chkIsAccount.Checked
                    .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = dtpOpeningDate.Value
                    .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = txtOpeningDebit.Text
                    .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = txtOpeningCredit.Text
                    .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = txtCreditLimit.Text
                    .Parameters.Add("@CreditDays", SqlDbType.Int).Value = txtCreditDays.Text
                    .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedValue
                    .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedValue
                    .Parameters.Add("@Address1", SqlDbType.NVarChar).Value = Trim(txtAddress1.Text)
                    .Parameters.Add("@Address2", SqlDbType.NVarChar).Value = Trim(txtAddress2.Text)
                    .Parameters.Add("@City", SqlDbType.NVarChar).Value = Trim(txtCity.Text)
                    .Parameters.Add("@State", SqlDbType.NVarChar).Value = Trim(txtState.Text)
                    .Parameters.Add("@Country", SqlDbType.NVarChar).Value = Trim(txtCountry.Text)
                    .Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = Trim(txtPostalCode.Text)
                    .Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = Trim(txtContactName.Text)
                    .Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = Trim(txtMobile.Text)
                    .Parameters.Add("@Landline", SqlDbType.NVarChar).Value = Trim(txtLandline.Text)
                    .Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Trim(txtFax.Text)
                    .Parameters.Add("@Email", SqlDbType.NVarChar).Value = Trim(txtEmail.Text)
                    .Parameters.Add("@Website", SqlDbType.NVarChar).Value = Trim(txtWebsite.Text)
                    .Parameters.Add("@NTN", SqlDbType.NVarChar).Value = Trim(txtNTN.Text)
                    .Parameters.Add("@GST", SqlDbType.NVarChar).Value = Trim(txtGST.Text)
                    .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = vUserName
                    .Parameters.Add("@InvoiceGraceDays", SqlDbType.Int).Value = txtInvoiceGraceDays.Text
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
                .CommandText = "UPDATE tblAccChartOfAccounts SET AccCode = @AccCode, AccName = @AccName, ParentAccCode = @ParentAccCode, AccLevel = @AccLevel, IsAccount = @IsAccount, OpeningDate = @OpeningDate, OpeningDebit = @OpeningDebit, OpeningCredit = @OpeningCredit, CreditLimit = @CreditLimit, CreditDays = @CreditDays, AccType = @AccType, AccNature = @AccNature, Address1 = @Address1, Address2 = @Address2, City = @City, State = @State, Country = @Country, PostalCode = @PostalCode, ContactName = @ContactName, Mobile= @Mobile, Landline = @Landline, Fax = @Fax, Email = @Email, Website = @Website, NTN = @NTN, GST = @GST, EntryUser = @EntryUser, InvoiceGraceDays = @InvoiceGraceDays WHERE AccId = @Original_AccId"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
                .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtAccName.Text)
                .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = cboParentAccount.SelectedValue
                .Parameters.Add("@AccLevel", SqlDbType.Int).Value = txtAccLevel.Text
                .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = chkIsAccount.Checked
                .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = dtpOpeningDate.Value
                .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = txtOpeningDebit.Text
                .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = txtOpeningCredit.Text
                .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = txtCreditLimit.Text
                .Parameters.Add("@CreditDays", SqlDbType.Int).Value = txtCreditDays.Text
                .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedValue
                .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedValue
                .Parameters.Add("@Address1", SqlDbType.NVarChar).Value = Trim(txtAddress1.Text)
                .Parameters.Add("@Address2", SqlDbType.NVarChar).Value = Trim(txtAddress2.Text)
                .Parameters.Add("@City", SqlDbType.NVarChar).Value = Trim(txtCity.Text)
                .Parameters.Add("@State", SqlDbType.NVarChar).Value = Trim(txtState.Text)
                .Parameters.Add("@Country", SqlDbType.NVarChar).Value = Trim(txtCountry.Text)
                .Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = Trim(txtPostalCode.Text)
                .Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = Trim(txtContactName.Text)
                .Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = Trim(txtMobile.Text)
                .Parameters.Add("@Landline", SqlDbType.NVarChar).Value = Trim(txtLandline.Text)
                .Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Trim(txtFax.Text)
                .Parameters.Add("@Email", SqlDbType.NVarChar).Value = Trim(txtEmail.Text)
                .Parameters.Add("@Website", SqlDbType.NVarChar).Value = Trim(txtWebsite.Text)
                .Parameters.Add("@NTN", SqlDbType.NVarChar).Value = Trim(txtNTN.Text)
                .Parameters.Add("@GST", SqlDbType.NVarChar).Value = Trim(txtGST.Text)
                .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = vUserName
                .Parameters.Add("@InvoiceGraceDays", SqlDbType.Int).Value = txtInvoiceGraceDays.Text
                .Parameters.Add("@Original_AccId", SqlDbType.NVarChar).Value = txtId.Text
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
        If e.KeyCode = Keys.F1 Then
            btnSearchAcc_Click(Me, Nothing)
        End If
    End Sub

    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAcc.Click
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "AddAccountSimple"

        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(initialValue, Nothing)

        ' Show the child dialog.
        childForm.ShowDialog()
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
            .CommandText = "SELECT * FROM tblAccChartOfAccounts WHERE AccId = @AccId"
            .Parameters.Clear()
            .Parameters.Add("@AccId", SqlDbType.NVarChar).Value = txtId.Text
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtAccLevel.Text = dt.Rows(0).Item("AccLevel").ToString
            chkIsAccount.Checked = dt.Rows(0).Item("IsAccount").ToString

            txtAccCode.Text = dt.Rows(0).Item("AccCode").ToString
            txtAccName.Text = dt.Rows(0).Item("AccName").ToString


            txtContactName.Text = dt.Rows(0).Item("ContactName").ToString
            txtMobile.Text = dt.Rows(0).Item("Mobile").ToString
            txtLandline.Text = dt.Rows(0).Item("Landline").ToString
            txtFax.Text = dt.Rows(0).Item("Fax").ToString
            txtEmail.Text = dt.Rows(0).Item("Email").ToString
            txtWebsite.Text = dt.Rows(0).Item("Website").ToString

            txtAddress1.Text = dt.Rows(0).Item("Address1").ToString
            txtAddress2.Text = dt.Rows(0).Item("Address2").ToString
            txtCity.Text = dt.Rows(0).Item("City").ToString
            txtState.Text = dt.Rows(0).Item("State").ToString
            txtCountry.Text = dt.Rows(0).Item("Country").ToString
            txtPostalCode.Text = dt.Rows(0).Item("PostalCode").ToString

            txtOpeningDebit.Text = dt.Rows(0).Item("OpeningDebit").ToString
            txtOpeningCredit.Text = dt.Rows(0).Item("OpeningCredit").ToString
            dtpOpeningDate.Text = dt.Rows(0).Item("OpeningDate").ToString
            txtCreditLimit.Text = dt.Rows(0).Item("CreditLimit").ToString
            txtCreditDays.Text = dt.Rows(0).Item("CreditDays").ToString

            txtNTN.Text = dt.Rows(0).Item("NTN").ToString
            txtGST.Text = dt.Rows(0).Item("GST").ToString
            txtInvoiceGraceDays.Text = dt.Rows(0).Item("InvoiceGraceDays").ToString

            OldAccName = dt.Rows(0).Item("AccName").ToString
            OldAccCode = dt.Rows(0).Item("AccCode").ToString
            OldParentAccCode = dt.Rows(0).Item("ParentAccCode").ToString


            cboParentAccount.SelectedValue = dt.Rows(0).Item("ParentAccCode").ToString

            cboAccType.SelectedItem = dt.Rows(0).Item("AccType").ToString
            cboAccNature.SelectedItem = dt.Rows(0).Item("AccNature").ToString
        Else
            ClearAllFields()


        End If
    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtId.Text = dgvList.CurrentRow.Cells("AccId").Value


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
            If col.HeaderText = "AccName" Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
    End Sub
    Sub ShowColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "AccId" Then
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

                qry.Append("AccCode + ' ' + AccName + ' ' + Contact + ' ' + Mobile + ' ' + Landline + ' ' + Email + ' ' + City LIKE '%" & txtSearchText.Text & "%'")


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

    Private Sub btnAddAccType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccType.Click
        Dim frm As New frmAccountsParenting
        frm.ShowDialog()
        FillCboParentAccount()

    End Sub



    
    Private Sub cboParentAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParentAccount.SelectedIndexChanged
        If cboParentAccount.SelectedIndex = 0 Then
            txtAccCode.Text = Nothing
        Else

            If txtId.Text = Nothing Then
                txtAccCode.Text = cboParentAccount.SelectedValue.ToString & GetNewAccCode(cboParentAccount.SelectedValue.ToString).ToString

            End If

            If txtId.Text <> Nothing Then
                If cboParentAccount.SelectedValue <> OldParentAccCode Then
                    Dim cmd As New SqlCommand
                    Dim da As New SqlDataAdapter
                    Dim dt As New DataTable

                    With cmd
                        .Connection = Conn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT VoucherId FROM vwGeneralJournal WHERE VoucherType <> 'Opening Balance' AND AccCode = @AccCode"
                        .Parameters.Clear()
                        .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = OldAccCode
                    End With

                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        cboParentAccount.SelectedValue = OldParentAccCode
                        txtAccCode.Text = OldAccCode

                        Dim str As New System.Text.StringBuilder

                        For i = 0 To dt.Rows.Count - 1
                            str.Append(dt.Rows(i).Item("VoucherId").ToString & vbNewLine)
                        Next

                        MsgBox("You can not Change Acc Code. There is/are transactions in following vouchers" & vbNewLine & str.ToString)

                        Exit Sub
                    End If
                    txtAccCode.Text = cboParentAccount.SelectedValue.ToString & GetNewAccCode(cboParentAccount.SelectedValue.ToString).ToString
                Else

                    txtAccCode.Text = OldAccCode
                End If

            End If
        End If
    End Sub


    Private Sub txtAccCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAccName.Focus()
        End If
    End Sub
  
    Private Sub cboParentAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboParentAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAccName.Focus()
        End If
    End Sub
    Private Sub txtAccName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtContactName.Focus()
        End If
    End Sub
    Private Sub txtContactName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContactName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtMobile.Focus()
        End If
    End Sub

    Private Sub txtMobile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtFax.Focus()
        End If
    End Sub

    Private Sub txtFax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtWebsite.Focus()
        End If
    End Sub

    Private Sub txtWebsite_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWebsite.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAddress1.Focus()
        End If
    End Sub

    Private Sub txtAddress1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtAddress2.Focus()
        End If
    End Sub
    Private Sub txtAddress2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCity.Focus()
        End If
    End Sub
    Private Sub txtCity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtState.Focus()
        End If
    End Sub
    Private Sub txtState_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtState.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCountry.Focus()
        End If
    End Sub
    Private Sub txtCountry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtPostalCode.Focus()
        End If
    End Sub
    Private Sub txtPostalCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPostalCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtOpeningDebit.Focus()
        End If
    End Sub
    Private Sub txtOpeningDebit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpeningDebit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOpeningCredit.Focus()
        End If
    End Sub
    Private Sub txtOpeningDebitFC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtOpeningCredit.Focus()
        End If
    End Sub
    Private Sub txtOpeningCredit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpeningCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpOpeningDate.Focus()
        End If
    End Sub
    Private Sub txtOpeningCreditFC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpOpeningDate.Focus()
        End If
    End Sub
    Private Sub dtpOpeningDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpOpeningDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCreditLimit.Focus()
        End If
    End Sub
    Private Sub txtCreditLimit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCreditLimit.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCreditDays.Focus()
        End If
    End Sub
    Private Sub txtCreditDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCreditDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtNTN.Focus()
        End If
    End Sub
    Private Sub txtNTN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNTN.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtGST.Focus()
        End If
    End Sub
    Private Sub txtGST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGST.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtInvoiceGraceDays.Focus()
        End If
    End Sub
    Private Sub txtInvoiceGraceDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInvoiceGraceDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.Validate()
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