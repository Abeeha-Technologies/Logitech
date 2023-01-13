Imports System.Data.SqlClient
Public Class frmVehicles
    Dim OldVehicleNumber As String

    Dim TblSearchListBindingSource As New BindingSource
    Sub SetFormStateNew()
        FillCboVehicleMake()

        ClearAllFields()

        FillMainSearchList()

        cboVehicleMake.Focus()

    End Sub


    Sub ClearAllFields()

        OldVehicleNumber = Nothing

        txtId.Text = Nothing
        txtModelYear.Text = Nothing
        txtVehicleNumber.Text = Nothing
        txtChasisNumber.Text = Nothing
        txtEngineNumber.Text = Nothing
        dtpRegistrationDate.Value = Now.Date
        dtpRenewDate.Value = Now.Date
        dtpExpiryDate.Value = Now.Date

        txtUser.Text = vUserName


    End Sub
    Sub FillCboVehicleMake()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT MakeId, MakeName FROM dbo.tblVehicleMake ORDER BY MakeName"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("MakeId") = 0
        row.Item("MakeName") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)

        cboVehicleMake.DataSource = dt
        cboVehicleMake.DisplayMember = dt.Columns("MakeName").ToString
        cboVehicleMake.ValueMember = dt.Columns("MakeId").ToString


    End Sub

    Sub FillCboVehicleModel()
        If cboVehicleMake.Items.Count > 0 Then
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable
            Dim cmd As New SqlCommand

            With cmd
                .Connection = Conn
                .CommandText = "SELECT dbo.tblVehicleModel.ModelId, dbo.tblVehicleModel.ModelName FROM dbo.tblVehicleMake INNER JOIN dbo.tblVehicleModel ON dbo.tblVehicleMake.MakeId = dbo.tblVehicleModel.MakeId WHERE (dbo.tblVehicleModel.MakeId = @MakeId) ORDER BY dbo.tblVehicleModel.ModelName"
                .Parameters.Clear()
                .Parameters.Add("@MakeId", SqlDbType.BigInt).Value = Val(cboVehicleMake.SelectedValue.ToString)
            End With

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            dt.Clear()
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim row As DataRow = dt.NewRow
            row.Item("ModelId") = 0
            row.Item("ModelName") = "(--Select--)"

            dt.Rows.InsertAt(row, 0)

            cboVehicleModel.DataSource = dt
            cboVehicleModel.DisplayMember = dt.Columns("ModelName").ToString
            cboVehicleModel.ValueMember = dt.Columns("ModelId").ToString

        End If
    End Sub


    Sub FillMainSearchList()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As String
        Dim cmd As New SqlCommand

        qryStr = "SELECT dbo.tblVehicles.VehicleId, dbo.tblVehicles.VehicleNumber AS [Veh #], dbo.tblVehicles.RegistrationDate, dbo.tblVehicles.RenewDate, dbo.tblVehicles.ExpiryDate, dbo.tblVehicles.MakeId, ISNULL(dbo.tblVehicleMake.MakeName, N'') AS MakeName, dbo.tblVehicles.ModelId, ISNULL(dbo.tblVehicleModel.ModelName, N'') AS ModelName, dbo.tblVehicles.ModelYear, dbo.tblVehicles.ChasisNumber, dbo.tblVehicles.EngineNumber FROM dbo.tblVehicleModel RIGHT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleModel.ModelId = dbo.tblVehicles.ModelId LEFT OUTER JOIN dbo.tblVehicleMake ON dbo.tblVehicles.MakeId = dbo.tblVehicleMake.MakeId ORDER BY dbo.tblVehicles.VehicleNumber"

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
            dgvList.Columns("VehicleId").Visible = False
            dgvList.Columns("Veh #").Width = 150
            dgvList.Columns("Veh #").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If


        If SplitContainer.Panel2Collapsed = False Then
            HideColumns()
        Else
            ShowColumns()

        End If

    End Sub

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStateNew()
        GetVehicleParentAccCode()
    End Sub
    Dim VehicleParentAccCode As String = Nothing
    Dim VehicleParentAccType As String = Nothing
    Dim VehicleParentAccNature As String = Nothing

    Sub GetVehicleParentAccCode()
        VehicleParentAccCode = Nothing
        VehicleParentAccType = Nothing
        VehicleParentAccNature = Nothing

        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT AccCode, AccType, AccNature FROM tblAccChartOfAccounts WHERE AccLevel = 1  AND AccType = 'Vehicle'"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            VehicleParentAccCode = dt.Rows(0).Item("AccCode")
            VehicleParentAccType = dt.Rows(0).Item("AccType")
            VehicleParentAccNature = dt.Rows(0).Item("AccNature")
        Else
            CreateNewVehicleCategoryAccount()
            GetVehicleParentAccCode()
        End If

    End Sub
    Sub CreateNewVehicleCategoryAccount()
        Dim NewCategoryCode As String
        NewCategoryCode = GetNewCategoryCode.ToString

        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "INSERT INTO tblAccChartOfAccounts (AccCode, AccName, ParentAccCode, AccLevel, IsAccount, OpeningDate, OpeningDebit, OpeningCredit, CreditLimit, CreditDays, AccType, AccNature, Address1, Address2, City, State, Country, PostalCode, ContactName, Mobile, LandLine, Fax, Email, Website, NTN, GST, InvoiceGraceDays, EntryUser) VALUES (@AccCode, @AccName, @ParentAccCode, @AccLevel, @IsAccount, @OpeningDate, @OpeningDebit, @OpeningCredit, @CreditLimit, @CreditDays, @AccType, @AccNature, @Address1, @Address2, @City, @State, @Country, @PostalCode, @ContactName, @Mobile, @LandLine, @Fax, @Email, @Website, @NTN, @GST, @InvoiceGraceDays, @EntryUser)"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = NewCategoryCode
            .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = "Vehicles"
            .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = String.Empty
            .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = 1
            .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = False
            .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = Now.Date
            .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = 0
            .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = 0
            .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = 0
            .Parameters.Add("@CreditDays", SqlDbType.Int).Value = 0
            .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = "Vehicle"
            .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = "Expense"
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


        End With
        Try
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            cmd.ExecuteNonQuery()

            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

        Catch ex As Exception
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If
            MsgBox(ex.Message)
        Finally
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If
        End Try


    End Sub

    Function GetNewCategoryCode() As String
        GetNewCategoryCode = "01"
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
            GetNewCategoryCode = (Val(dt.Rows(0).Item(0).ToString()) + 1).ToString("00")

        Else
            GetNewCategoryCode = "01"
        End If
    End Function

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
                    If frmPasswordInput.DialogResult = Windows.Forms.DialogResult.Yes Then
                        Delete(txtId.Text, txtChasisNumber.Text)
                        Exit Sub
                    Else
                        Exit Sub
                    End If

                End If
                Delete(txtId.Text, txtChasisNumber.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal AccId As String, ByVal Id As Long)

        Try
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter


            With cmd
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT VehicleId FROM tblVehicleIssuance WHERE VehicleId = @VehicleId"
                .Parameters.Clear()
                .Parameters.Add("@VehicleId", SqlDbType.BigInt).Value = Id
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim str As New System.Text.StringBuilder

                For i = 0 To dt.Rows.Count - 1
                    If i = 0 Then
                        str.Append(dt.Rows(i).Item("IssueId").ToString)
                    Else
                        str.Append(" | " & dt.Rows(i).Item("IssueId").ToString)
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
                    .CommandText = "DELETE FROM tblVehicles WHERE VehicleId = @VehicleId"
                    .Parameters.Clear()
                    .Parameters.Add("@VehicleId", SqlDbType.BigInt).Value = AccId
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

        If cboVehicleMake.SelectedIndex < 1 Then
            MsgBox("Please Select Vehicle Make", , "Error")
            cboVehicleMake.Focus()
            Exit Sub
        End If

        If cboVehicleModel.SelectedIndex < 1 Then
            MsgBox("Please Select Vehicle Model", , "Error")
            cboVehicleModel.Focus()
            Exit Sub
        End If

        If txtVehicleNumber.Text = Nothing Then
            MsgBox("Please Enter Vehicle #", , "Error")
            txtVehicleNumber.Focus()
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
        If OldVehicleNumber <> txtVehicleNumber.Text Then
            With cmd
                .CommandText = "SELECT Count(VehicleId) AS Count FROM tblVehicles WHERE VehicleNumber COLLATE Latin1_General_CS_AS = @VehicleNumber"
                .Parameters.Clear()
                .Parameters.Add("@VehicleNumber", SqlDbType.NVarChar).Value = txtVehicleNumber.Text
            End With



            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) > 0 Then
                If MsgBox(txtVehicleNumber.Text & " seems Duplicates. Do you still want to add?", vbCritical + vbYesNo, "Error") = vbNo Then
                    Exit Sub
                End If

            End If
        End If
        'End Check Duplicate





        'Inser if Record is New
        If txtId.Text = Nothing Then


            'Insert Account

            Dim NewAccCode As String = Nothing

            NewAccCode = VehicleParentAccCode & GetNewAccCode(VehicleParentAccCode).ToString


            'Start Inserting New Record
            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()


            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandText = "INSERT INTO tblAccChartOfAccounts (AccCode, AccName, ParentAccCode, AccLevel, IsAccount, OpeningDate, OpeningDebit, OpeningCredit, CreditLimit, CreditDays, AccType, AccNature, Address1, Address2, City, State, Country, PostalCode, ContactName, Mobile, LandLine, Fax, Email, Website, NTN, GST, InvoiceGraceDays, EntryUser) VALUES (@AccCode, @AccName, @ParentAccCode, @AccLevel, @IsAccount, @OpeningDate, @OpeningDebit, @OpeningCredit, @CreditLimit, @CreditDays, @AccType, @AccNature, @Address1, @Address2, @City, @State, @Country, @PostalCode, @ContactName, @Mobile, @LandLine, @Fax, @Email, @Website, @NTN, @GST, @InvoiceGraceDays, @EntryUser)"
                .Parameters.Clear()
                .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = NewAccCode
                .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtVehicleNumber.Text)
                .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = VehicleParentAccCode
                .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = 2
                .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = True
                .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = Now.Date
                .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = 0
                .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = 0
                .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = 0
                .Parameters.Add("@CreditDays", SqlDbType.Int).Value = 0
                .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = VehicleParentAccType
                .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = VehicleParentAccNature
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

            'End Insert Accounts

            Try

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "INSERT INTO tblVehicles (MakeId, ModelId, ModelYear, VehicleNumber, ChasisNumber, EngineNumber, RegistrationDate, RenewDate, ExpiryDate, GLAccCode, EnteredBy) VALUES (@MakeId, @ModelId, @ModelYear, @VehicleNumber, @ChasisNumber, @EngineNumber, @RegistrationDate, @RenewDate, @ExpiryDate, @GLAccCode, @EnteredBy)"
                    .Parameters.Clear()
                    .Parameters.Add("@MakeId", SqlDbType.BigInt).Value = cboVehicleMake.SelectedValue
                    .Parameters.Add("@ModelId", SqlDbType.BigInt).Value = cboVehicleModel.SelectedValue
                    .Parameters.Add("@ModelYear", SqlDbType.Int).Value = txtModelYear.Text
                    .Parameters.Add("@VehicleNumber", SqlDbType.NVarChar).Value = Trim(txtVehicleNumber.Text)
                    .Parameters.Add("@ChasisNumber", SqlDbType.NVarChar).Value = Trim(txtChasisNumber.Text)
                    .Parameters.Add("@EngineNumber", SqlDbType.NVarChar).Value = Trim(txtEngineNumber.Text)
                    .Parameters.Add("@RegistrationDate", SqlDbType.Date).Value = dtpRegistrationDate.Value
                    .Parameters.Add("@RenewDate", SqlDbType.Date).Value = dtpRenewDate.Value
                    .Parameters.Add("@ExpiryDate", SqlDbType.Date).Value = dtpExpiryDate.Value
                    .Parameters.Add("@GLAccCode", SqlDbType.NVarChar).Value = NewAccCode
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

            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            If OldVehicleNumber <> txtVehicleNumber.Text Then
              
                    With cmd
                        .Connection = Conn
                        .Transaction = trans
                        .CommandText = "UPDATE tblAccChartOfAccounts SET AccName = @AccName WHERE AccCode = @AccCode"
                        .Parameters.Clear()

                        .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtVehicleNumber.Text)
                        .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtGLAccCode.Text
                        .ExecuteNonQuery()
                    End With


            End If


            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandText = "UPDATE tblVehicles SET MakeId = @MakeId, ModelId = @ModelId, ModelYear = @ModelYear, VehicleNumber = @VehicleNumber, ChasisNumber = @ChasisNumber, EngineNumber = @EngineNumber, RegistrationDate = @RegistrationDate, RenewDate = @RenewDate, ExpiryDate = @ExpiryDate WHERE VehicleId = @Original_VehicleId"
                .Parameters.Clear()
                .Parameters.Add("@MakeId", SqlDbType.BigInt).Value = cboVehicleMake.SelectedValue
                .Parameters.Add("@ModelId", SqlDbType.BigInt).Value = cboVehicleModel.SelectedValue
                .Parameters.Add("@ModelYear", SqlDbType.Int).Value = txtModelYear.Text
                .Parameters.Add("@VehicleNumber", SqlDbType.NVarChar).Value = Trim(txtVehicleNumber.Text)
                .Parameters.Add("@ChasisNumber", SqlDbType.NVarChar).Value = Trim(txtChasisNumber.Text)
                .Parameters.Add("@EngineNumber", SqlDbType.NVarChar).Value = Trim(txtEngineNumber.Text)
                .Parameters.Add("@RegistrationDate", SqlDbType.Date).Value = dtpRegistrationDate.Value
                .Parameters.Add("@RenewDate", SqlDbType.Date).Value = dtpRenewDate.Value
                .Parameters.Add("@ExpiryDate", SqlDbType.Date).Value = dtpExpiryDate.Value
                .Parameters.Add("@Original_VehicleId", SqlDbType.BigInt).Value = txtId.Text
                .ExecuteNonQuery()
            End With

            trans.Commit()
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
            .CommandText = "SELECT * FROM tblVehicles WHERE VehicleId = @VehicleId"
            .Parameters.Clear()
            .Parameters.Add("@VehicleId", SqlDbType.BigInt).Value = Val(txtId.Text)
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtGLAccCode.Text = dt.Rows(0).Item("GLAccCode")
            cboVehicleMake.SelectedValue = dt.Rows(0).Item("MakeId")
            cboVehicleModel.SelectedValue = dt.Rows(0).Item("ModelId")
            txtModelYear.Text = dt.Rows(0).Item("ModelYear")
            txtVehicleNumber.Text = dt.Rows(0).Item("VehicleNumber")
            OldVehicleNumber = dt.Rows(0).Item("VehicleNumber").ToString
            txtChasisNumber.Text = dt.Rows(0).Item("ChasisNumber")
            txtEngineNumber.Text = dt.Rows(0).Item("EngineNumber")

            dtpRegistrationDate.Text = dt.Rows(0).Item("RegistrationDate").ToString
            dtpRenewDate.Text = dt.Rows(0).Item("RenewDate").ToString
            dtpExpiryDate.Text = dt.Rows(0).Item("ExpiryDate").ToString

        Else
            ClearAllFields()


        End If
    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtId.Text = dgvList.CurrentRow.Cells("VehicleId").Value


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
            If col.HeaderText = "Veh #" Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
    End Sub
    Sub ShowColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "VehicleId" Then
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

                qry.Append("[Veh #] + ' ' + ChasisNumber + ' ' + EngineNumber LIKE '%" & txtSearchText.Text & "%'")


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

    Private Sub btnAddVehicleMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVehicleMake.Click
        'Dim frm As New frmAccountsParenting
        'frm.ShowDialog()
        'FillCboParentAccount()

    End Sub




    Private Sub cboParentAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVehicleMake.SelectedIndexChanged
        FillCboVehicleModel()
    End Sub




    Private Sub cboVehicleMake_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVehicleMake.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboVehicleModel.Focus()
        End If
    End Sub
    Private Sub cboVehicleModel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVehicleModel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtModelYear.Focus()
        End If
    End Sub
    Private Sub txtModelYear_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtModelYear.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtVehicleNumber.Focus()
        End If
    End Sub
    Private Sub txtVehicleNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVehicleNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtChasisNumber.Focus()
        End If
    End Sub
    Private Sub txtChasisNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChasisNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtEngineNumber.Focus()
        End If
    End Sub
    Private Sub txtEngineNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEngineNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpRegistrationDate.Focus()
        End If
    End Sub

    Private Sub dtpRegistrationDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpRegistrationDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpRenewDate.Focus()
        End If
    End Sub

    Private Sub dtpRenewDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpRenewDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpExpiryDate.Focus()
        End If
    End Sub

    Private Sub dtpExpiryDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpExpiryDate.KeyDown
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