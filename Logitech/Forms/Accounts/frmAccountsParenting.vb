Imports System.Data.SqlClient
Public Class frmAccountsParenting
    Dim OldAccName As String
    Dim OldAccType As String
    Dim OldAccNature As String

    Dim TblSearchListBindingSource As New BindingSource

    Sub SetFormStateNew()

        ClearAllFields()
        txtAccCode.Text = GetNewId.ToString

        FillMainSearchList()

    End Sub


    Sub ClearAllFields()
        OldAccName = Nothing
        txtIsEdit.Text = Nothing

        txtAccName.Text = Nothing
        cboAccType.SelectedItem = "(--Select--)"
        cboAccNature.SelectedItem = "(--Select--)"
        txtUser.Text = vUserName

    End Sub
    Function GetNewId() As String
        GetNewId = "01"
        Dim tblName As String = "tblAccChartOfAccounts"
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim qryStr As New System.Text.StringBuilder


        qryStr.Append("SELECT MAX(CONVERT(INT, AccCode)) AS AccCode FROM " & tblName & " WHERE AccLevel = 1")


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
            GetNewId = (Val(dt.Rows(0).Item(0).ToString()) + 1).ToString("00")

        Else
            GetNewId = "01"
        End If
    End Function

    Sub FillMainSearchList()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As String
        Dim cmd As New SqlCommand

        qryStr = "SELECT AccCode, AccName FROM tblAccChartOfAccounts WHERE AccLevel = 1"

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
            dgvList.Columns(1).Width = 200
            dgvList.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If


        If SplitContainer.Panel2Collapsed = False Then
            For Each col As DataGridViewColumn In dgvList.Columns
                If col.HeaderText = "AccName" Then
                    dgvList.Columns("AccName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Else
                    col.Visible = False
                End If
            Next
        Else
            For Each col As DataGridViewColumn In dgvList.Columns
                If col.HeaderText = "AccName" Then
                Else
                    col.Visible = True
                End If
            Next

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
        If txtIsEdit.Text <> Nothing Then
            If MsgBox("Do you Really Want to Delete?" & vbNewLine & "This event is not reversable.", vbYesNo + vbCritical, "Confirmation") = vbYes Then

                If vRequireUserPasswordForDelete = "True" Then
                    frmPasswordInput.ShowDialog()
                    If frmPasswordInput.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                        Delete(txtAccCode.Text)
                        Exit Sub
                    Else
                        Exit Sub
                    End If

                End If
                Delete(txtAccCode.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal AccCode As String)


        Try
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter

            With cmd
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT Count(ParentAccCode) AS Count FROM tblAccChartOfAccounts WHERE ParentAccCode = @ParentAccCode"
                .Parameters.Clear()
                .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = AccCode
            End With
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If Val(dt.Rows(0).Item("Count")) > 0 Then
                MsgBox("You can not Delete Current record. There are " & dt.Rows(0).Item("Count") & " Accounts under this Type")
                Exit Sub
            End If

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            If Val(dt.Rows(0).Item("Count")) = 0 Then
                With cmd
                    .CommandText = "DELETE FROM tblAccChartOfAccounts WHERE AccCode = @AccCode"
                    .Parameters.Clear()
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
                    .ExecuteNonQuery()
                End With



            End If

            SetFormStateNew()
            MsgBox("Record Deleted")
        Catch ex As Exception

        Finally
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

        End Try





    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtAccName.Text = Nothing Then
            MsgBox("Please Enter Some Account Type Name", , "Error")
            txtAccName.Focus()
            Exit Sub
        End If

        If cboAccNature.SelectedItem = "(--Select--)" Then
            MsgBox("Please Select Account Nature", , "Error")
            cboAccNature.Focus()
            Exit Sub
        End If
        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
        End With

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

            Try

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "INSERT INTO tblAccChartOfAccounts (AccCode, AccName, ParentAccCode, AccLevel, IsAccount, OpeningDate, OpeningDebit, OpeningCredit, CreditLimit, CreditDays, AccType, AccNature, Address1, Address2, City, State, Country, PostalCode, ContactName, Mobile, LandLine, Fax, Email, Website, NTN, GST, InvoiceGraceDays, EntryUser) VALUES (@AccCode, @AccName, @ParentAccCode, @AccLevel, @IsAccount, @OpeningDate, @OpeningDebit, @OpeningCredit, @CreditLimit, @CreditDays, @AccType, @AccNature, @Address1, @Address2, @City, @State, @Country, @PostalCode, @ContactName, @Mobile, @LandLine, @Fax, @Email, @Website, @NTN, @GST, @InvoiceGraceDays, @EntryUser)"
                    .Parameters.Clear()
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
                    .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtAccName.Text)
                    .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = 1
                    .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = False
                    .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = Now.Date
                    .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@CreditDays", SqlDbType.Int).Value = 0
                    .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedItem.ToString
                    .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedItem.ToString
                    .Parameters.Add("@Address1", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Address2", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@City", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@State", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Country", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Landline", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Fax", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Email", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Website", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@NTN", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@GST", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@InvoiceGraceDays", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = vUserName
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

        If txtIsEdit.Text <> Nothing Then

            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            Try

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "UPDATE tblAccChartOfAccounts SET AccName = @AccName, AccType = @AccType, AccNature = @AccNature, EntryUser = @EntryUser WHERE AccCode = @Original_AccCode"
                    .Parameters.Clear()
                    .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtAccName.Text)
                    .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedItem.ToString
                    .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedItem.ToString
                    .Parameters.Add("@EntryUser", SqlDbType.NVarChar).Value = vUserName
                    .Parameters.Add("@Original_AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
                    .ExecuteNonQuery()
                End With

                If OldAccType <> cboAccType.SelectedItem Then
                    With cmd
                        .Connection = Conn
                        .Transaction = trans
                        .CommandText = "UPDATE tblAccChartOfAccounts SET AccType = @AccType, AccNature = @AccNature WHERE ParentAccCode = @Original_AccCode"
                        .Parameters.Clear()
                        .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedItem.ToString
                        .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedItem.ToString
                        .Parameters.Add("@Original_AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
                        .ExecuteNonQuery()
                    End With
                End If

                trans.Commit()
                MsgBox("Updated Successfully")
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

    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "AddAccountBasic"

        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(initialValue, Nothing)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub



    Private Sub txtAccCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCode.TextChanged
        FillDetail()
    End Sub
    Sub FillDetail()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM tblAccChartOfAccounts WHERE AccCode = @AccCode"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtAccCode.Text
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtIsEdit.Text = 1
            txtAccName.Text = dt.Rows(0).Item("AccName").ToString
            cboAccType.SelectedItem = dt.Rows(0).Item("AccType").ToString

            OldAccName = dt.Rows(0).Item("AccName").ToString
            OldAccType = dt.Rows(0).Item("AccType").ToString
            OldAccNature = dt.Rows(0).Item("AccNature").ToString

        Else
            ClearAllFields()


        End If
    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtAccCode.Text = dgvList.CurrentRow.Cells("AccCode").Value

            If SplitContainer.Panel2Collapsed = True Then
                ShowDetailPanel()
            End If
        End If

    End Sub

    Sub ShowDetailPanel()
        SplitContainer.Panel2Collapsed = False
        picPanelExtender.BackgroundImage = imgList.Images(0)
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "AccName" Then
            Else
                col.Visible = False
            End If
        Next
    End Sub
    Sub HideDetailPanel()
        SplitContainer.Panel2Collapsed = True
        picPanelExtender.BackgroundImage = imgList.Images(1)
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "AccName" Then
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

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtSearchText.Text & "%'")

                TblSearchListBindingSource.Filter = qry.ToString


            Else
                TblSearchListBindingSource.RemoveFilter()

            End If
        End If

    End Sub
    Private Sub dgvList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvList.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvList_CellDoubleClick(Me, Nothing)
        End If
    End Sub

    Private Sub cboAccType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccType.SelectedIndexChanged
        If cboAccType.SelectedItem = "Asset" Then

            cboAccNature.SelectedItem = "Asset"

        ElseIf cboAccType.SelectedItem = "Customer" Then

            cboAccNature.SelectedItem = "Asset"

        ElseIf cboAccType.SelectedItem = "Employee" Then

            cboAccNature.SelectedItem = "Asset"

        ElseIf cboAccType.SelectedItem = "Cash" Then

            cboAccNature.SelectedItem = "Asset"

        ElseIf cboAccType.SelectedItem = "Bank" Then

            cboAccNature.SelectedItem = "Asset"

        ElseIf cboAccType.SelectedItem = "Liability" Then

            cboAccNature.SelectedItem = "Liability"

        ElseIf cboAccType.SelectedItem = "Supplier" Then

            cboAccNature.SelectedItem = "Liability"

        ElseIf cboAccType.SelectedItem = "Equity" Then

            cboAccNature.SelectedItem = "Equity"

        ElseIf cboAccType.SelectedItem = "Revenue" Then

            cboAccNature.SelectedItem = "Revenue"

        ElseIf cboAccType.SelectedItem = "Expense" Then

            cboAccNature.SelectedItem = "Expense"

        ElseIf cboAccType.SelectedItem = "Vehicle" Then

            cboAccNature.SelectedItem = "Expense"

        Else
            cboAccNature.SelectedItem = Nothing

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