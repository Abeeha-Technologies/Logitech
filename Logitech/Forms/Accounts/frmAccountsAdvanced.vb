Imports System.Data.SqlClient
Public Class frmAccountsAdvanced
    Private dtSource As DataTable = Nothing
    Dim SelectedParentNodeTag As String
    Dim SelectedParentNodeName As String
    Dim OldAccName As String
    Sub SetFormStateNew()


        ClearAllFields()


        PopulateTreeView()

        txtAccCode.Text = GetNewAccCode()

    End Sub

    Function GetNewAccCode() As String
        GetNewAccCode = Nothing
        'firstly coded with dashes then they are commented to be in code to remember if needed

        Dim cmd As New SqlCommand
        Dim qry As String = ""
        Dim Prefix As String = ""
        Dim tblName As String = "tblAccChartOfAccounts"

        qry = "SELECT MAX(AccCode) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = qry
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()

        End If

        If IsDBNull(cmd.ExecuteScalar) Then
            GetNewAccCode = txtParentAccCode.Text & "01"
        Else
            If Val(txtAccLevel.Text) = 1 Then
                GetNewAccCode = (Val(cmd.ExecuteScalar) + 1).ToString("00")
            Else
                GetNewAccCode = "0" & (Val(cmd.ExecuteScalar) + 1).ToString()
            End If

        End If

        Return GetNewAccCode
        ''''''''''''''' Exit Sub '''''''''''''''''''''

        Exit Function

        If txtAccLevel.Text = 2 Then
            'qry = "SELECT MAX(RIGHT(AccCode,9)) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"
            'Prefix = Strings.Left(txtParentAccCode.Text, 2) & "-"
            qry = "SELECT MAX(LEFT(AccCode,4)) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"
            Prefix = Strings.Left(txtParentAccCode.Text, 2)
        End If
        If txtAccLevel.Text = 3 Then
            'qry = "SELECT MAX(RIGHT(AccCode,6)) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"
            'Prefix = Strings.Left(txtParentAccCode.Text, 5) & "-"
            qry = "SELECT MAX(LEFT(AccCode,6)) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"
            Prefix = Strings.Left(txtParentAccCode.Text, 4)
        End If
        If txtAccLevel.Text = 4 Then
            'qry = "SELECT MAX(RIGHT(AccCode,3)) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"
            'Prefix = Strings.Left(txtParentAccCode.Text, 8) & "-"
            qry = "SELECT MAX(LEFT(AccCode,9)) FROM " & tblName & " WHERE ParentAccCode = '" & txtParentAccCode.Text & "'"
            Prefix = Strings.Left(txtParentAccCode.Text, 6)
        End If

        Try

            With cmd
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = qry
            End With
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            If IsDBNull(cmd.ExecuteScalar) Then

                If txtAccLevel.Text = 1 Then
                    'GetNewAccCode = "01" & "00-00-000"
                    GetNewAccCode = "01" & "0000000"
                End If
                If txtAccLevel.Text = 2 Then
                    'GetNewAccCode = Prefix & "01" & "00-000"
                    GetNewAccCode = Prefix & "01" & "00000"
                End If
                If txtAccLevel.Text = 3 Then
                    GetNewAccCode = Prefix & "01" & "000"
                End If
                If txtAccLevel.Text = 4 Then
                    GetNewAccCode = Prefix & "001"
                End If

            Else

                If txtAccLevel.Text = 1 Then
                    'GetNewAccCode = (Val(cmd.ExecuteScalar) + 1).ToString("00") & "-00-00-000"
                    GetNewAccCode = (Val(cmd.ExecuteScalar) + 1).ToString("00") & "0000000"
                End If
                If txtAccLevel.Text = 2 Then
                    'GetNewAccCode = Prefix & (Val(cmd.ExecuteScalar) + 1).ToString("00") & "-00-000"
                    GetNewAccCode = (Val(cmd.ExecuteScalar) + 1).ToString("0000") & "00000"
                End If

                If txtAccLevel.Text = 3 Then
                    'GetNewAccCode = Prefix & (Val(cmd.ExecuteScalar) + 1).ToString("00") & "-000"
                    GetNewAccCode = (Val(cmd.ExecuteScalar) + 1).ToString("000000") & "000"
                End If
                If txtAccLevel.Text = 4 Then
                    GetNewAccCode = (Val(cmd.ExecuteScalar) + 1).ToString("000000000")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

        End Try
        
    End Function
    Sub ClearAllFields()
        txtIsEdit.Text = Nothing
        txtAccLevel.Text = 1
        txtParentAccCode.Text = Nothing
        chkIsAccount.Checked = True


        txtAccName.Text = Nothing
        cboAccType.SelectedItem = "General"
        cboAccNature.SelectedItem = Nothing
        cboAccNature.Enabled = True
        OldAccName = Nothing


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
        txtOpeningDebitFC.Text = 0
        txtOpeningCredit.Text = 0
        txtOpeningCreditFC.Text = 0
        dtpOpeningDate.Value = Now.Date
        txtCreditLimit.Text = 0
        txtCreditDays.Text = 0
        txtNTN.Text = Nothing
        txtGST.Text = Nothing


        txtUser.Text = vUserName



    End Sub

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetFormStateNew()

        If vCanDeleteVoucher = False Then
            btnDelete.Visible = False
        End If

    End Sub
    Sub PopulateTreeView()

        TreeView1.Nodes.Clear()

        dtSource = GetData()

        Dim dt As DataTable = GetChildData("")


        For Each dr As DataRow In dt.Rows
            Dim ParentNode As TreeNode = New TreeNode()
            ParentNode.Tag = dr("AccCode").ToString()
            ParentNode.Text = "(" & dr("AccCode").ToString() & ") " & dr("AccName").ToString()
            ParentNode.Name = dr("AccName").ToString()
            AddNodes(ParentNode)
            TreeView1.Nodes.Add(ParentNode)
        Next
    End Sub
    Private Sub AddNodes(ByRef node As TreeNode)
        Dim dt As DataTable = GetChildData(node.Tag)
        For Each row As DataRow In dt.Rows
            Dim ChildNode As TreeNode = New TreeNode()
            ChildNode.Tag = row("AccCode").ToString()
            ChildNode.Text = "(" & row("AccCode").ToString() & ") " & row("AccName").ToString()
            ChildNode.Name = row("AccName").ToString()
            AddNodes(ChildNode)
            node.Nodes.Add(ChildNode)
        Next
    End Sub
    Public Function GetChildData(ByVal ParentAccCode As String) As DataTable
        Dim dt As New DataTable
        dt.Columns.AddRange(New DataColumn() {New DataColumn("AccCode", GetType(String)), New DataColumn("ParentAccCode", GetType(String)), New DataColumn("AccName", GetType(String))})
        For Each dr As DataRow In dtSource.Rows
            If dr(1).ToString() <> ParentAccCode.ToString() Then
                Continue For
            End If
            Dim row As DataRow = dt.NewRow
            row("AccCode") = dr("AccCode")
            row("ParentAccCode") = dr("ParentAccCode")
            row("AccName") = dr("AccName")
            dt.Rows.Add(row)
        Next
        Return dt
    End Function
    Private Function GetData() As DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT AccCode, ParentAccCode, AccName FROM tblAccChartOfAccounts ORDER BY AccId"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        Return dt

    End Function


    Sub ShowDetailPanel()
        SplitContainer1.Panel2Collapsed = False
        picPanelExtender.BackgroundImage = imgList.Images(0)
        'For Each col As DataGridViewColumn In dgvList.Columns
        '    If col.HeaderText = "Order #" Then
        '    Else
        '        col.Visible = False
        '    End If
        'Next
    End Sub
    Sub HideDetailPanel()
        SplitContainer1.Panel2Collapsed = True
        picPanelExtender.BackgroundImage = imgList.Images(1)
        'For Each col As DataGridViewColumn In dgvList.Columns
        '    If col.HeaderText = "Order #" Then
        '    Else
        '        col.Visible = True
        '    End If
        'Next
    End Sub
    Private Sub picPanelExtender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPanelExtender.Click
        If SplitContainer1.Panel2Collapsed = False Then
            HideDetailPanel()
        Else
            ShowDetailPanel()

        End If
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


        'Try
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

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        If Val(dt.Rows(0).Item("Count")) > 0 Then
            MsgBox("You can not Delete Current record. There are " & dt.Rows(0).Item("Count") & " Accounts under this account")
            Exit Sub
        End If

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT Count(VoucherId) AS Count FROM vwGeneralJournal WHERE AccCode = @AccCode"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        If Val(dt.Rows(0).Item("Count")) > 0 Then
            MsgBox("You can not Delete Current record. There are transactions")
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

            With cmd
                .Connection = Conn
                .CommandText = "UPDATE tblAccChartOfAccounts SET IsAccount = 1 WHERE accCode = @AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
                .ExecuteNonQuery()
            End With

        End If

        SetFormStateNew()
        'Catch ex As Exception

        'Finally
        '    If Conn.State <> ConnectionState.Closed Then
        '        Conn.Close()
        '    End If

        'End Try





    End Sub

    Private Sub txtParentAccCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParentAccCode.TextChanged
        If txtIsEdit.Text = Nothing Then
            txtAccCode.Text = GetNewAccCode.ToString
        End If
        If txtParentAccCode.Text.Length > 0 Then
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter

            With cmd
                .Connection = Conn
                .CommandText = "SELECT AccName, AccNature FROM tblAccChartOfAccounts WHERE AccCode = @AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtParentAccName.Text = dt.Rows(0).Item("AccName").ToString
                cboAccNature.SelectedItem = dt.Rows(0).Item("AccNature").ToString
                cboAccNature.Enabled = False
            Else
                txtParentAccName.Text = Nothing
                cboAccNature.Enabled = True
            End If
        Else
            txtParentAccName.Text = Nothing
            cboAccNature.Enabled = True
        End If


    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        ClearAllFields()
        SetParentAcc("Under This")
    End Sub

    Private Sub UnderSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderSelected.Click, btnInsertUnderSelectedLevel.Click
        ClearAllFields()
        SetParentAcc("Under This")
    End Sub

    Private Sub AtThisLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtThisLevel.Click, btnInsertAtSelectedLeve.Click
        ClearAllFields()
        SetParentAcc("At This")
    End Sub
    Sub SetParentAcc(ByVal Under As String)

        If Under = "Under This" Then
            txtAccLevel.Text = TreeView1.SelectedNode.Level + 2
            txtParentAccCode.Text = TreeView1.SelectedNode.Tag

            'txtParentAccName.Text = TreeView1.SelectedNode.Name

        Else
            If TreeView1.Nodes.Count > 0 Then
                If TreeView1.SelectedNode.Level > 0 Then
                    txtAccLevel.Text = TreeView1.SelectedNode.Parent.Level + 2
                    txtParentAccCode.Text = TreeView1.SelectedNode.Parent.Tag
                    'txtParentAccName.Text = TreeView1.SelectedNode.Parent.Name

                Else
                    txtAccLevel.Text = 1
                    txtParentAccCode.Text = Nothing
                    'txtParentAccName.Text = Nothing

                End If
            Else
                txtAccLevel.Text = 1
                txtParentAccCode.Text = Nothing
                'txtParentAccName.Text = Nothing

            End If

        End If


    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click, btnEditSelected.Click
        Dim tn As TreeNode
        tn = TreeView1.SelectedNode
        If Not tn Is Nothing Then
            ShowDetail()
        End If

    End Sub
    Sub ShowDetail()
        If TreeView1.Nodes.Count > 0 Then
            txtAccCode.Text = TreeView1.SelectedNode.Tag
            If SplitContainer1.Panel2Collapsed = True Then
                ShowDetailPanel()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SelectedParentNodeTag = txtParentAccCode.Text
        SelectedParentNodeName = txtParentAccName.Text


        If txtAccName.Text = Nothing Then
            MsgBox("Please Enter some Account Title", , "Error")
            txtAccName.Focus()
            Exit Sub
        End If
        If cboAccType.SelectedIndex < 0 Then
            MsgBox("Please Select Account Type", , "Error")
            cboAccType.Focus()
            Exit Sub
        End If
        If cboAccNature.SelectedIndex < 0 Then
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


        'Start Check if the Parent Account is already registered
        If Not Val(txtAccLevel.Text) = 1 And Not txtParentAccCode.TextLength = 0 Then
            With cmd
                .CommandText = "SELECT Count(AccCode) AS Count FROM tblAccChartOfAccounts WHERE AccCode = @AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
            End With


            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) < 1 Then
                MsgBox(txtParentAccCode.Text & " is not registered yet, Please Add it first", vbCritical, "Error")
                Exit Sub
            End If

        End If
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If


        'Inser if Record is New
        If txtIsEdit.Text = Nothing Then
            chkIsAccount.Checked = True
            With cmd
                .Connection = Conn
                .CommandText = "SELECT COUNT(*) AS Count FROM tblAccChartOfAccounts WHERE (AccCode = @AccCode) HAVING (SUM(OpeningDebit) > 0) OR (SUM(OpeningCredit) > 0)"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
            End With

            dt.Clear()
            da.SelectCommand = cmd
            Dim result = da.Fill(dt)
            If result > 0 Then
                MsgBox("This Aaccount Can Not be Added, beacuse its Parent Account has Opening Balances" & Chr(13) & " Please clear its Parent Account Opening Balance", vbCritical + vbOKOnly, "Warning")
                Exit Sub
            End If

            'Check if Parent Account has any transasction
            With cmd
                .Connection = Conn
                .CommandText = "SELECT COUNT(*) AS Count FROM dbo.vwGeneralJournal WHERE (AccCode = @AccCode) AND (VoucherType <> N'Opening Balance')"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            result = dt.Rows(0).Item(0)
            If result > 0 Then
                MsgBox("This Aaccount Can Not be Added, beacuse its Parent Account has some accounting transactions" & Chr(13) & " Please delete its Parent Account transascctions", vbCritical + vbOKOnly, "Warning")
                Exit Sub
            End If


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
                    .CommandText = "INSERT INTO tblAccChartOfAccounts (AccCode, AccName, ParentAccCode, AccLevel, IsAccount, OpeningDate, OpeningDebit, OpeningCredit, OpeningDebitFC, OpeningCreditFC, CreditLimit, CreditDays, AccType, AccNature, Address1, Address2, City, State, Country, PostalCode, ContactName, Mobile, LandLine, Fax, Email, Website, NTN, GST, EntryUser) VALUES (@AccCode, @AccName, @ParentAccCode, @AccLevel, @IsAccount, @OpeningDate, @OpeningDebit, @OpeningCredit, @OpeningDebitFC, @OpeningCreditFC, @CreditLimit, @CreditDays, @AccType, @AccNature, @Address1, @Address2, @City, @State, @Country, @PostalCode, @ContactName, @Mobile, @LandLine, @Fax, @Email, @Website, @NTN, @GST, @EntryUser)"
                    .Parameters.Clear()
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = Trim(txtAccCode.Text)
                    .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtAccName.Text)
                    .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
                    .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = txtAccLevel.Text
                    .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = chkIsAccount.Checked
                    .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = dtpOpeningDate.Value
                    .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = txtOpeningDebit.Text
                    .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = txtOpeningCredit.Text
                    .Parameters.Add("@OpeningDebitFC", SqlDbType.Decimal).Value = txtOpeningDebitFC.Text
                    .Parameters.Add("@OpeningCreditFC", SqlDbType.Decimal).Value = txtOpeningCreditFC.Text
                    .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = txtCreditLimit.Text
                    .Parameters.Add("@CreditDays", SqlDbType.Int).Value = txtCreditDays.Text
                    .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedItem
                    .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedItem
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
                    .ExecuteNonQuery()
                End With

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "UPDATE tblAccChartOfAccounts SET IsAccount = 0 WHERE AccCode = @AccCode"
                    .Parameters.Clear()
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
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

            With cmd
                .CommandText = "UPDATE tblAccChartOfAccounts SET AccCode = @AccCode, AccName = @AccName, ParentAccCode = @ParentAccCode, AccLevel = @AccLevel, IsAccount = @IsAccount, OpeningDate = @OpeningDate, OpeningDebit = @OpeningDebit, OpeningCredit = @OpeningCredit, OpeningDebitFC = @OpeningDebitFC, OpeningCreditFC = @OpeningCreditFC, CreditLimit = @CreditLimit, CreditDays = @CreditDays, AccType = @AccType, AccNature = @AccNature, Address1 = @Address1, Address2 = @Address2, City = @City, State = @State, Country = @Country, PostalCode = @PostalCode, ContactName = @ContactName, Mobile= @Mobile, Landline = @Landline, Fax = @Fax, Email = @Email, Website = @Website, NTN = @NTN, GST = @GST, EntryUser = @EntryUser WHERE AccCode = @Original_AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtAccName.Text)
                .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
                .Parameters.Add("@AccLevel", SqlDbType.Int).Value = txtAccLevel.Text
                .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = chkIsAccount.Checked
                .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = dtpOpeningDate.Value
                .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = txtOpeningDebit.Text
                .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = txtOpeningCredit.Text
                .Parameters.Add("@OpeningDebitFC", SqlDbType.Decimal).Value = txtOpeningDebitFC.Text
                .Parameters.Add("@OpeningCreditFC", SqlDbType.Decimal).Value = txtOpeningCreditFC.Text
                .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = txtCreditLimit.Text
                .Parameters.Add("@CreditDays", SqlDbType.Int).Value = txtCreditDays.Text
                .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = cboAccType.SelectedItem
                .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedItem
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
                .Parameters.Add("@Original_AccCode", SqlDbType.NVarChar).Value = txtAccCode.Text
                .ExecuteNonQuery()
            End With

            With cmd
                .CommandText = "UPDATE tblAccChartOfAccounts SET AccNature = @AccNature WHERE ParentAccCode = @Original_ParentAccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = cboAccNature.SelectedItem.ToString
                .Parameters.Add("@Original_ParentAccCode", SqlDbType.NVarChar).Value = txtAccCode.Text
                .ExecuteNonQuery()
            End With

            With cmd
                .Connection = Conn
                .CommandText = "UPDATE tblAccChartOfAccounts SET IsAccount = 0 WHERE AccCode = @AccCode"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtParentAccCode.Text
                .ExecuteNonQuery()
            End With

            MsgBox("Updated Successfully")
            SetFormStateNew()

        End If


        'FindNodeByTag()

        Dim tn As TreeNode() = TreeView1.Nodes.Find(SelectedParentNodeName, True)
        For i As Integer = 0 To tn.Length - 1
            TreeView1.SelectedNode = tn(i)
            TreeView1.SelectedNode.Expand()
        Next


    End Sub
    Sub FindNodeByTag()
        Dim nodes As TreeNodeCollection = TreeView1.Nodes
        For Each n As TreeNode In nodes
            FindRecursiveTag(n)
        Next
    End Sub
    Sub FindRecursiveTag(ByVal treeNode As TreeNode)
        For Each tn As TreeNode In treeNode.Nodes
            If tn.Tag.ToString() = SelectedParentNodeTag Then
                tn.BackColor = Color.Yellow
                'tn.Expand()
                'TreeView1.SelectedNode = tn
                'TreeView1_AfterSelect(Me, Nothing)
                FindRecursiveTag(tn)
            End If
        Next
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
        initialValue = "AddAccount"

        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(initialValue, Nothing)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub


    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim tn As TreeNode
        tn = TreeView1.SelectedNode
        If Not tn Is Nothing Then
            ShowDetail()
        End If

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
            txtParentAccCode.Text = dt.Rows(0).Item("ParentAccCode").ToString
            txtAccLevel.Text = dt.Rows(0).Item("AccLevel").ToString
            chkIsAccount.Checked = dt.Rows(0).Item("IsAccount").ToString

            txtContactName.Text = dt.Rows(0).Item("ContactName").ToString
            txtMobile.Text = dt.Rows(0).Item("Mobile").ToString
            txtLandline.Text = dt.Rows(0).Item("LandLine").ToString
            txtFax.Text = dt.Rows(0).Item("Fax").ToString
            txtEmail.Text = dt.Rows(0).Item("Email").ToString
            txtWebsite.Text = dt.Rows(0).Item("Website").ToString

            txtAddress1.Text = dt.Rows(0).Item("Address1").ToString
            txtAddress2.Text = dt.Rows(0).Item("Address2").ToString
            txtCity.Text = dt.Rows(0).Item("City").ToString
            txtState.Text = dt.Rows(0).Item("State").ToString
            txtCountry.Text = dt.Rows(0).Item("Country").ToString
            txtPostalCode.Text = dt.Rows(0).Item("PostalCode").ToString

            dtpOpeningDate.Value = dt.Rows(0).Item("OpeningDate").ToString
            txtOpeningDebit.Text = dt.Rows(0).Item("OpeningDebit").ToString
            txtOpeningDebitFC.Text = dt.Rows(0).Item("OpeningDebitFC").ToString
            txtOpeningCredit.Text = dt.Rows(0).Item("OpeningCredit").ToString
            txtOpeningCreditFC.Text = dt.Rows(0).Item("OpeningCreditFC").ToString
            txtCreditLimit.Text = dt.Rows(0).Item("CreditLimit").ToString
            txtCreditDays.Text = dt.Rows(0).Item("CreditDays").ToString
            txtNTN.Text = dt.Rows(0).Item("NTN").ToString
            txtGST.Text = dt.Rows(0).Item("GST").ToString
            

            cboAccType.SelectedItem = dt.Rows(0).Item("AccType").ToString
            cboAccNature.SelectedItem = dt.Rows(0).Item("AccNature").ToString
            OldAccName = dt.Rows(0).Item("AccName").ToString
        Else
            txtIsEdit.Text = Nothing
            chkIsAccount.Checked = True

            txtAccName.Text = Nothing
            
            chkIsAccount.Checked = True

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

            dtpOpeningDate.Value = Now.Date
            txtOpeningDebit.Text = 0
            txtOpeningDebitFC.Text = 0
            txtOpeningCredit.Text = 0
            txtOpeningCreditFC.Text = 0
            txtCreditLimit.Text = 0
            txtCreditDays.Text = 0
            txtNTN.Text = Nothing
            txtGST.Text = Nothing

            cboAccType.SelectedItem = "General"
            cboAccNature.SelectedItem = Nothing
            cboAccNature.Enabled = True
            OldAccName = Nothing

        End If
    End Sub



    Private Sub btnExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandAll.Click
        TreeView1.ExpandAll()
    End Sub

    Private Sub btnCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollapseAll.Click
        TreeView1.CollapseAll()
        txtParentAccCode.Text = Nothing
    End Sub

    Private Sub txtAccCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAccName.Focus()
        End If
    End Sub

    Private Sub txtAccName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAccType.Focus()
        End If
    End Sub
    Private Sub txtParentAccName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParentAccName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAccType.Focus()
        End If
    End Sub

    Private Sub cboAccType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAccType.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAccNature.Focus()
        End If
    End Sub

    Private Sub cboAccNature_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAccNature.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContactName.Focus()
        End If
    End Sub

    Private Sub txtContactName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContactName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMobile.Focus()
        End If
    End Sub

    Private Sub txtMobile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLandline.Focus()
        End If
    End Sub
    Private Sub txtLandline_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLandline.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFax.Focus()
        End If
    End Sub
    Private Sub txtFax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        End If
    End Sub
    Private Sub txtEmail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtWebsite.Focus()
        End If
    End Sub
    Private Sub txtWebsite_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWebsite.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress1.Focus()
        End If
    End Sub
    Private Sub txtAddress1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress2.Focus()
        End If
    End Sub
    Private Sub txtAddress2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCity.Focus()
        End If
    End Sub
    Private Sub txtCity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtState.Focus()
        End If
    End Sub
    Private Sub txtState_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtState.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCountry.Focus()
        End If
    End Sub
    Private Sub txtCountry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPostalCode.Focus()
        End If
    End Sub
    Private Sub txtPostalCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPostalCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOpeningDebit.Focus()
        End If
    End Sub
    Private Sub txtOpeningDebit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpeningDebit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOpeningDebitFC.Focus()
        End If
    End Sub
    Private Sub txtOpeningDebitFC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpeningDebitFC.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOpeningCredit.Focus()
        End If
    End Sub
    Private Sub txtOpeningCredit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpeningCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOpeningCreditFC.Focus()
        End If
    End Sub
    Private Sub txtOpeningCreditFC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpeningCreditFC.KeyDown
        If e.KeyCode = Keys.Enter Then
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
            txtCreditDays.Focus()
        End If
    End Sub
    Private Sub txtCreditDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCreditDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNTN.Focus()
        End If
    End Sub

    Private Sub txtNTN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNTN.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGST.Focus()
        End If
    End Sub

    


    Private Sub TreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Button = MouseButtons.Right Then
            TreeView1.SelectedNode = e.Node
        End If
    End Sub


End Class