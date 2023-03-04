Imports System.Data.SqlClient
Public Class frmEmployees
    Dim OldEmployeeName As String
    Dim OldEmployeeIdNumber As String

    Dim TblSearchListBindingSource As New BindingSource
    Sub SetFormStateNew()

        ClearAllFields()

        ClearDetailFieldsAttachment()
        dgvAttachments.Rows.Clear()

        FillMainSearchList()

        txtEmployeeName.Focus()

    End Sub


    Sub ClearAllFields()

        OldEmployeeName = Nothing
        OldEmployeeIdNumber = Nothing

        txtId.Text = Nothing
        txtGLAccCode.Text = Nothing
        txtEmployeeName.Text = Nothing
        txtEmployeeIdNumber.Text = Nothing
        dtpIdExpiry.Value = Now.Date
        dtpDateOfBirth.Value = Now.Date
        txtContactNumber.Text = Nothing

        txtPasssportNumber.Text = Nothing
        dtpPassportExpiryDate.Value = Now.Date
        cboNationality.SelectedIndex = 0

        txtIBAN.Text = Nothing

        txtDesignation.Text = Nothing
        dtpJoiningDate.Value = Now.Date

        txtUser.Text = vUserName

        SetDefaultImage()

    End Sub

    Sub ClearDetailFieldsAttachment()
        txtDetailAttachmentRowIndex.Text = Nothing
        txtDetailAttachmentName.Text = Nothing
        SetDefaultImageAttachment()
    End Sub

    Sub SetDefaultImage()
        Me.ProfilePicture.Image = Global.Logitech.My.Resources.Resources.DefaultImage
        chkIsDefaultImage.Checked = True
        chkIsSameImage.Checked = False
    End Sub

    Sub SetDefaultImageAttachment()
        Me.AttachmentPicture.Image = Global.Logitech.My.Resources.Resources.DefaultImage
        chkIsDefaultImageAttachment.Checked = True
    End Sub


    Sub FillMainSearchList()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As String
        Dim cmd As New SqlCommand

        qryStr = "SELECT EmployeeId, EmployeeName AS Employee, IdNumber AS Id, DateOfBirth, PassportNumber AS [Passport #], PassportExpiry, Nationality FROM dbo.tblEmployees"

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
            dgvList.Columns("EmployeeId").Visible = False
            dgvList.Columns("Employee").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If


        If SplitContainer.Panel2Collapsed = False Then
            HideColumns()
        Else
            ShowColumns()

        End If

    End Sub

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStateNew()
        GetEmployeeParentAccCode()
    End Sub
    Dim EmployeeParentAccCode As String = Nothing
    Dim EmployeeParentAccType As String = Nothing
    Dim EmployeeParentAccNature As String = Nothing

    Sub GetEmployeeParentAccCode()
        EmployeeParentAccCode = Nothing
        EmployeeParentAccType = Nothing
        EmployeeParentAccNature = Nothing

        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT AccCode, AccType, AccNature FROM tblAccChartOfAccounts WHERE AccLevel = 1  AND AccType = 'Employee'"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            EmployeeParentAccCode = dt.Rows(0).Item("AccCode")
            EmployeeParentAccType = dt.Rows(0).Item("AccType")
            EmployeeParentAccNature = dt.Rows(0).Item("AccNature")
        Else
            CreateNewEmployeeCategoryAccount()
            GetEmployeeParentAccCode()
        End If

    End Sub
    Sub CreateNewEmployeeCategoryAccount()
        Dim NewCategoryCode As String
        NewCategoryCode = GetNewCategoryCode.ToString

        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "INSERT INTO tblAccChartOfAccounts (AccCode, AccName, ParentAccCode, AccLevel, IsAccount, OpeningDate, OpeningDebit, OpeningCredit, CreditLimit, CreditDays, AccType, AccNature, Address1, Address2, City, State, Country, PostalCode, ContactName, Mobile, LandLine, Fax, Email, Website, NTN, GST, InvoiceGraceDays, EntryUser) VALUES (@AccCode, @AccName, @ParentAccCode, @AccLevel, @IsAccount, @OpeningDate, @OpeningDebit, @OpeningCredit, @CreditLimit, @CreditDays, @AccType, @AccNature, @Address1, @Address2, @City, @State, @Country, @PostalCode, @ContactName, @Mobile, @LandLine, @Fax, @Email, @Website, @NTN, @GST, @InvoiceGraceDays, @EntryUser)"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = NewCategoryCode
            .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = "Employees"
            .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = String.Empty
            .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = 1
            .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = False
            .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = Now.Date
            .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = 0
            .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = 0
            .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = 0
            .Parameters.Add("@CreditDays", SqlDbType.Int).Value = 0
            .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = "Employee"
            .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = "Asset"
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
                    If frmPasswordInput.DialogResult = System.Windows.Forms.DialogResult.Yes Then
                        Delete(txtId.Text, txtGLAccCode.Text)

                        Exit Sub
                    Else
                        Exit Sub
                    End If

                End If
                Delete(txtId.Text, txtGLAccCode.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal Id As String, GLAccCode As String)

        'Try
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()

        End If


        'Start Deleting from tblAccChartofAccounts
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT VoucherId FROM vwGeneralJournal WHERE VoucherType <> 'Opening Balance' AND AccCode = @AccCode"
            .Parameters.Clear()
            .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = GLAccCode
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

        If dt.Rows.Count = 0 Then
            MsgBox("ID: " & Id & vbNewLine & "GL Code: " & GLAccCode)
            With cmd
                .CommandText = "DELETE FROM tblAccChartOfAccounts WHERE AccCode = @GLAccCode"
                .Parameters.Clear()
                .Parameters.Add("@GLAccCode", SqlDbType.NVarChar).Value = GLAccCode
                .ExecuteNonQuery()
            End With


        End If

        'Start Deleting from tblEmployees
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT IssueId FROM tblVehicleIssuance WHERE EmployeeId = @EmployeeId"
            .Parameters.Clear()
            .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = Id
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

        

        If dt.Rows.Count = 0 Then

            With cmd
                .CommandText = "DELETE FROM tblEmployees WHERE EmployeeId = @EmployeeId"
                .Parameters.Clear()
                .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = Id
                .ExecuteNonQuery()
            End With


        End If
        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If
        SetFormStateNew()
        'Catch ex As Exception
        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If
        'Finally
        '    If Conn.State <> ConnectionState.Closed Then
        '        Conn.Close()
        '    End If

        'End Try





    End Sub

    Dim arrImage() As Byte
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtEmployeeName.Text = Nothing Then
            MsgBox("Please Enter Name")
            txtEmployeeName.Focus()
            Exit Sub
        End If

        If txtEmployeeIdNumber.Text = Nothing Then
            MsgBox("Please Enter Employee Id #", , "Error")
            txtEmployeeIdNumber.Focus()
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


        If chkIsDefaultImage.Checked = False Then
            Dim ms As New System.IO.MemoryStream()
            ProfilePicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = ms.GetBuffer()
            Dim FileSize As UInt32
            FileSize = ms.Length
        End If

        'Start Check Duplicate

        'Check if Acc Name Duplicates
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        If OldEmployeeName <> txtEmployeeName.Text Then
            With cmd
                .CommandText = "SELECT Count(EmployeeId) AS Count FROM tblEmployees WHERE EmployeeName COLLATE Latin1_General_CS_AS = @EmployeeName"
                .Parameters.Clear()
                .Parameters.Add("@EmployeeName", SqlDbType.NVarChar).Value = txtEmployeeName.Text
            End With



            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) > 0 Then
                If MsgBox(txtEmployeeName.Text & " seems Duplicates. Do you still want to add?", vbCritical + vbYesNo, "Error") = vbNo Then
                    Exit Sub
                End If

            End If
        End If

        'Check Duplicate Employee Number
        If OldEmployeeIdNumber <> txtEmployeeIdNumber.Text Then
            With cmd
                .CommandText = "SELECT Count(EmployeeId) AS Count FROM tblEmployees WHERE IdNumber = @IdNumber"
                .Parameters.Clear()
                .Parameters.Add("@IdNumber", SqlDbType.BigInt).Value = Val(txtEmployeeIdNumber.Text)
            End With



            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) > 0 Then
                If MsgBox(txtEmployeeIdNumber.Text & " seems Duplicates. Do you still want to add?", vbCritical + vbYesNo, "Error") = vbNo Then
                    Exit Sub
                End If

            End If
        End If
        'End Check Duplicate



        'Inser if Record is New
        If txtId.Text = Nothing Then

            'Insert Account

            Dim NewAccCode As String = Nothing

            NewAccCode = EmployeeParentAccCode & GetNewAccCode(EmployeeParentAccCode).ToString


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
                    .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtEmployeeName.Text)
                    .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = EmployeeParentAccCode
                    .Parameters.Add("@AccLevel", SqlDbType.NVarChar).Value = 2
                    .Parameters.Add("@IsAccount", SqlDbType.Bit).Value = True
                    .Parameters.Add("@OpeningDate", SqlDbType.Date).Value = Now.Date
                    .Parameters.Add("@OpeningDebit", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@OpeningCredit", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = 0
                    .Parameters.Add("@CreditDays", SqlDbType.Int).Value = 0
                    .Parameters.Add("@AccType", SqlDbType.NVarChar).Value = EmployeeParentAccType
                    .Parameters.Add("@AccNature", SqlDbType.NVarChar).Value = EmployeeParentAccNature
                    .Parameters.Add("@Address1", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Address2", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@City", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@State", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Country", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = String.Empty
                    .Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = txtContactNumber.Text
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



            Dim cmdText As New System.Text.StringBuilder
            cmdText.Append("INSERT INTO tblEmployees (EmployeeName, IdNumber, IdExpiry, DateOfBirth, ContactNumber, IBAN, PassportNumber, PassportExpiry, Nationality, Designation, JoiningDate, EnteredBy, GLAccCode")
            If chkIsDefaultImage.Checked = False Then
                cmdText.Append(", EmployeePicture")
            End If
            cmdText.Append(") VALUES (@EmployeeName, @IdNumber, @IdExpiry, @DateOfBirth, @ContactNumber, @IBAN, @PassportNumber, @PassportExpiry, @Nationality, @Designation, @JoiningDate, @EnteredBy, @GLAccCode")
            If chkIsDefaultImage.Checked = False Then
                cmdText.Append(", @EmployeePicture")
            End If

            cmdText.Append(")")


            Try

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = cmdText.ToString
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeName", SqlDbType.NVarChar).Value = Trim(txtEmployeeName.Text)
                    .Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = Trim(txtEmployeeIdNumber.Text)
                    .Parameters.Add("@IdExpiry", SqlDbType.Date).Value = dtpIdExpiry.Value
                    .Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtpDateOfBirth.Value
                    .Parameters.Add("@ContactNumber", SqlDbType.NVarChar).Value = Trim(txtContactNumber.Text)
                    .Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = Trim(txtIBAN.Text)
                    .Parameters.Add("@PassportNumber", SqlDbType.NVarChar).Value = Trim(txtPasssportNumber.Text)
                    .Parameters.Add("@PassportExpiry", SqlDbType.Date).Value = dtpPassportExpiryDate.Value
                    .Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = cboNationality.SelectedItem
                    .Parameters.Add("@Designation", SqlDbType.NVarChar).Value = Trim(txtDesignation.Text)
                    .Parameters.Add("@JoiningDate", SqlDbType.Date).Value = dtpJoiningDate.Value
                    .Parameters.Add("@GLAccCode", SqlDbType.NVarChar).Value = NewAccCode
                    .Parameters.Add("@EnteredBy", SqlDbType.NVarChar).Value = vUserName
                    If chkIsDefaultImage.Checked = False Then
                        .Parameters.Add("@EmployeePicture", SqlDbType.Image).Value = arrImage
                    End If
                    .ExecuteNonQuery()
                End With




                If dgvAttachments.Rows.Count > 0 Then
                    With cmd
                        .CommandText = "SELECT IDENT_CURRENT('tblEmployees')"

                    End With
                    Dim dtNewIdentity As New DataTable
                    Dim daNewIdentity As New SqlDataAdapter
                    daNewIdentity.SelectCommand = cmd
                    dtNewIdentity.Clear()
                    daNewIdentity.Fill(dtNewIdentity)

                    Dim LastEmployeeId As Long
                    LastEmployeeId = dtNewIdentity.Rows(0).Item(0).ToString

                    For Each row As DataGridViewRow In dgvAttachments.Rows
                        With cmd
                            .Transaction = trans
                            .CommandText = "INSERT INTO tblEmployeeAttachments (EmployeeId, AttachmentName, AttachmentImage) VALUES (@EmployeeId, @AttachmentName, @AttachmentImage)"
                            .Parameters.Clear()
                            .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = LastEmployeeId
                            .Parameters.Add("@AttachmentName", SqlDbType.NVarChar).Value = row.Cells("AttachmentName").Value
                            .Parameters.Add("@AttachmentImage", SqlDbType.Image).Value = row.Cells("AttachmentImage").Value

                            .ExecuteNonQuery()
                        End With
                    Next
                End If

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

            If OldEmployeeName <> txtEmployeeName.Text Then
                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "UPDATE tblAccChartOfAccounts SET AccName = @AccName WHERE AccCode = @AccCode"
                    .Parameters.Clear()

                    .Parameters.Add("@AccName", SqlDbType.NVarChar).Value = Trim(txtEmployeeName.Text)
                    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = txtGLAccCode.Text
                    .ExecuteNonQuery()

                End With

            End If

            Dim cmdText As New System.Text.StringBuilder

            cmdText.Append("UPDATE tblEmployees SET EmployeeName = @EmployeeName, IdNumber = @IdNumber, IdExpiry = @IdExpiry, DateOfBirth = @DateOfBirth, ContactNumber = @ContactNumber, IBAN = @IBAN, PassportNumber = @PassportNumber, PassportExpiry = @PassportExpiry, Nationality = @Nationality, Designation = @Designation, JoiningDate = @JoiningDate")

            If chkIsDefaultImage.Checked = False Then
                cmdText.Append(", EmployeePicture = @EmployeePicture")
            Else
                cmdText.Append(", EmployeePicture = NULL")
            End If

            cmdText.Append(" WHERE EmployeeId = @Original_EmployeeId")
            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandText = cmdText.ToString
                .Parameters.Clear()
                .Parameters.Add("@EmployeeName", SqlDbType.NVarChar).Value = Trim(txtEmployeeName.Text)
                .Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = Trim(txtEmployeeIdNumber.Text)
                .Parameters.Add("@IdExpiry", SqlDbType.Date).Value = dtpIdExpiry.Value
                .Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtpDateOfBirth.Value
                .Parameters.Add("@ContactNumber", SqlDbType.NVarChar).Value = Trim(txtContactNumber.Text)
                .Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = Trim(txtIBAN.Text)
                .Parameters.Add("@PassportNumber", SqlDbType.NVarChar).Value = Trim(txtPasssportNumber.Text)
                .Parameters.Add("@PassportExpiry", SqlDbType.Date).Value = dtpPassportExpiryDate.Value
                .Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = cboNationality.SelectedItem
                .Parameters.Add("@Designation", SqlDbType.NVarChar).Value = Trim(txtDesignation.Text)
                .Parameters.Add("@JoiningDate", SqlDbType.Date).Value = dtpJoiningDate.Value
                If chkIsDefaultImage.Checked = False Then
                    .Parameters.Add("@EmployeePicture", SqlDbType.Image).Value = arrImage
                End If
                .Parameters.Add("@Original_EmployeeId", SqlDbType.BigInt).Value = txtId.Text
                .ExecuteNonQuery()
            End With

            'Create Checking Variables

            Dim blnStopCheck As Boolean = False
            Dim blnFound As Boolean = False


            '------ Start INSERT, UPDATE, DELETE Attachments ------'
            If dgvAttachments.Rows.Count = 0 Then
                Dim cmdDelete As New SqlCommand
                Dim qryDelete As String
                qryDelete = "DELETE FROM tblEmployeeAttachments WHERE EmployeeId = " & Val(txtId.Text)
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
                .CommandText = "SELECT AttachmentId FROM tblEmployeeAttachments WHERE EmployeeId =" & Val(txtId.Text)
            End With
            daExistingVehicles.SelectCommand = cmdExistingVehicles

            dtExistingVehicles.Clear()
            daExistingVehicles.Fill(dtExistingVehicles)
            For Each ExistingVehiclerow As DataRow In dtExistingVehicles.Rows
                blnStopCheck = False
                blnFound = False
                Dim ExistingSaleDetailId As Long = ExistingVehiclerow.Item(0).ToString


                For i As Integer = 0 To dgvAttachments.Rows.Count - 1
                    If blnStopCheck = False Then


                        If ExistingSaleDetailId = Val(dgvAttachments.Rows(i).Cells("AttachmentId").Value) Then
                            blnStopCheck = True
                            blnFound = True

                        Else
                            blnStopCheck = False
                            blnFound = False

                        End If
                    End If
                    If i = dgvAttachments.Rows.Count - 1 Then
                        If blnFound = False Then

                            Dim cmdDeleteVehicle As New SqlCommand
                            Dim qryDeleteVehicle As String
                            qryDeleteVehicle = "DELETE FROM tblEmployeeAttachments WHERE AttachmentId = " & ExistingSaleDetailId
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


            For i = 0 To dgvAttachments.Rows.Count - 1

                If Val(dgvAttachments.Rows(i).Cells("AttachmentId").Value) > 0 Then
                    With cmd

                        .CommandText = "UPDATE tblEmployeeAttachments SET AttachmentName = @AttachmentName, AttachmentImage = @AttachmentImage WHERE AttachmentId = @AttachmentId"
                        .Parameters.Clear()
                        .Parameters.Add("@AttachmentName", SqlDbType.NVarChar).Value = dgvAttachments.Rows(i).Cells("AttachmentName").Value
                        .Parameters.Add("@AttachmentImage", SqlDbType.Image).Value = dgvAttachments.Rows(i).Cells("AttachmentImage").Value
                        .Parameters.Add("@AttachmentId", SqlDbType.BigInt).Value = dgvAttachments.Rows(i).Cells("AttachmentId").Value
                        .ExecuteNonQuery()
                    End With
                End If

                If Val(dgvAttachments.Rows(i).Cells("AttachmentId").Value) < 1 Then
                    With cmd
                        .CommandText = "INSERT INTO tblEmployeeAttachments (EmployeeId, AttachmentName, AttachmentImage) VALUES (@EmployeeId, @AttachmentName, @AttachmentImage)"
                        .Parameters.Clear()
                        .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = Val(txtId.Text)
                        .Parameters.Add("@AttachmentName", SqlDbType.NVarChar).Value = dgvAttachments.Rows(i).Cells("AttachmentName").Value
                        .Parameters.Add("@AttachmentImage", SqlDbType.Image).Value = dgvAttachments.Rows(i).Cells("AttachmentImage").Value

                        .ExecuteNonQuery()
                    End With
                End If


            Next
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
        FillAttachments()
    End Sub
    Sub FillDetail()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM tblEmployees WHERE EmployeeId = @EmployeeId"
            .Parameters.Clear()
            .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = Val(txtId.Text)
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtGLAccCode.Text = dt.Rows(0).Item("GLAccCode")
            txtEmployeeName.Text = dt.Rows(0).Item("EmployeeName")
            OldEmployeeName = dt.Rows(0).Item("EmployeeName")
            txtEmployeeIdNumber.Text = dt.Rows(0).Item("IdNumber")
            OldEmployeeIdNumber = dt.Rows(0).Item("IdNumber")
            dtpIdExpiry.Value = dt.Rows(0).Item("IdExpiry")
            dtpDateOfBirth.Value = dt.Rows(0).Item("DateOfBirth")
            txtContactNumber.Text = dt.Rows(0).Item("ContactNumber")

            txtPasssportNumber.Text = dt.Rows(0).Item("PassportNumber")
            dtpPassportExpiryDate.Value = dt.Rows(0).Item("PassportExpiry").ToString
            cboNationality.SelectedItem = dt.Rows(0).Item("Nationality")

            txtIBAN.Text = dt.Rows(0).Item("IBAN")

            txtDesignation.Text = dt.Rows(0).Item("Designation")
            dtpJoiningDate.Value = dt.Rows(0).Item("JoiningDate")

            If Not IsDBNull(dt.Rows(0).Item("EmployeePicture")) Then
                arrImage = dt.Rows(0).Item("EmployeePicture")
                Dim ms As New System.IO.MemoryStream(arrImage)
                ProfilePicture.Image = Image.FromStream(ms)
                chkIsDefaultImage.Checked = False
                chkIsSameImage.Checked = True
            Else
                SetDefaultImage()
            End If

        Else
            ClearAllFields()


        End If
    End Sub
    Sub FillAttachments()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT AttachmentId, EmployeeId, AttachmentName, AttachmentImage FROM dbo.tblEmployeeAttachments WHERE (EmployeeId = @EmployeeId)"
            .Parameters.Clear()
            .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = Val(txtId.Text)
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            dgvAttachments.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgvAttachments.Rows.Add(row.Item("AttachmentId"), row.Item("AttachmentName"), row.Item("AttachmentImage"))

            Next
            ClearDetailFieldsAttachment()
        Else

            dgvAttachments.Rows.Clear()
        End If


    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtId.Text = dgvList.CurrentRow.Cells("EmployeeId").Value


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
            If col.HeaderText = "Employee" Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
    End Sub
    Sub ShowColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "EmployeeId" Then
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

                qry.Append("Employee + ' ' + Id + ' ' + [Passport #] LIKE '%" & txtSearchText.Text & "%'")


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

    Private Sub txtEmployeeName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtEmployeeIdNumber.Focus()
        End If
    End Sub
    Private Sub txtEmployeeIdNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeIdNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpIdExpiry.Focus()
        End If
    End Sub
    Private Sub dtpIdExpiry_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpIdExpiry.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpDateOfBirth.Focus()
        End If
    End Sub
    Private Sub dtpDateOfBirth_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpDateOfBirth.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtContactNumber.Focus()
        End If
    End Sub
    Private Sub txtContactNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContactNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtPasssportNumber.Focus()
        End If
    End Sub
    Private Sub txtPasssportNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasssportNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpPassportExpiryDate.Focus()
        End If
    End Sub

    Private Sub dtpPassportExpiryDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpPassportExpiryDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboNationality.Focus()
        End If
    End Sub

    Private Sub cboNationality_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboNationality.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtIBAN.Focus()
        End If
    End Sub

    Private Sub txtIBAN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIBAN.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDesignation.Focus()
        End If
    End Sub
    Private Sub txtDesignation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesignation.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtpJoiningDate.Focus()
        End If
    End Sub
    Private Sub dtpJoiningDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpJoiningDate.KeyDown
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

    Private Sub btnZoomPicture_Click(sender As System.Object, e As System.EventArgs) Handles ProfilePicture.Click, btnZoomPicture.Click
        If chkIsDefaultImage.Checked = True Then
            LoadPicture("Profile")
            Exit Sub
        End If

        ZoomImage("Profile")

    End Sub
    Private Sub AttachmentPicture_Click(sender As System.Object, e As System.EventArgs) Handles AttachmentPicture.Click
        If chkIsDefaultImageAttachment.Checked = True Then
            LoadPicture("Attachment")
            Exit Sub
        End If

        ZoomImage("Attachment")
    End Sub
    Sub ZoomImage(Source As String)
        Dim frm As New frmImageViewer
        If Source = "Profile" Then
            frm.KpImageViewer1.Image = ProfilePicture.Image
        ElseIf Source = "Attachment" Then
            frm.KpImageViewer1.Image = AttachmentPicture.Image
        ElseIf Source = "AttachmentDetail" Then

            Dim imgData As Byte()
            imgData = CType(dgvAttachments.CurrentRow.Cells("AttachmentImage").Value, Byte())
            Dim ms As New System.IO.MemoryStream(imgData)
            frm.KpImageViewer1.Image = Image.FromStream(ms)


        End If

        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()
    End Sub

    Private Sub btnLoadPicture_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadPicture.Click
        LoadPicture("Profile")
    End Sub
    Private Sub btnLoadPictureAttachment_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadPictureAttachment.Click
        LoadPicture("Attachment")
    End Sub
    Sub LoadPicture(Source As String)

        OpenFileDialog1.DefaultExt = "JPG"
        OpenFileDialog1.Filter = "Images (*.JPG;*.JPEG;*.PNG;*.GIF; *.BMP) | *.jpg;*.jpeg;*.PNG;*.gif;*.BMP; |JPG Images (*.jpg;*.jpeg;) | *.jpg;*.jpeg; |PNG Images (*.PNG) | *.PNG; |GIF Images (*,gif) | *.gif; |BMP Images (*.BMP) | *.BMP; "

        'Dim ms As New MemoryStream
        'ProductPicture.Image.Save(ms, ProductPicture.Image.RawFormat)
        'ms.ToArray()



        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Source = "Profile" Then
                ProfilePicture.Image.Dispose()
                ProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)


                chkIsDefaultImage.Checked = False
                chkIsSameImage.Checked = False

            ElseIf Source = "Attachment" Then
                AttachmentPicture.Image.Dispose()
                AttachmentPicture.Image = Image.FromFile(OpenFileDialog1.FileName)

                chkIsDefaultImageAttachment.Checked = False

            End If
        End If
    End Sub

    Private Sub btnClearProductPicture_Click(sender As System.Object, e As System.EventArgs) Handles btnClearProductPicture.Click
        SetDefaultImage()
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAttachment.Click
        If chkIsDefaultImageAttachment.Checked = True Then
            MsgBox("Please Select some Image")
            Exit Sub
        End If

        If txtDetailAttachmentName.Text.Trim.Length < 1 Then
            MsgBox("Please Enter Description")
            Exit Sub

        End If

        If chkIsDefaultImageAttachment.Checked = False Then


        End If
        Dim ms As New System.IO.MemoryStream()
        AttachmentPicture.Image.Save(ms, AttachmentPicture.Image.RawFormat)
        Dim img As Byte()
        img = ms.ToArray()

        If txtDetailAttachmentRowIndex.Text = Nothing Then
            dgvAttachments.Rows.Add("", txtDetailAttachmentName.Text, img)

        Else
            For Each row As DataGridViewRow In dgvAttachments.Rows
                If row.Index = txtDetailAttachmentRowIndex.Text Then
                    row.Cells("AttachmentName").Value = txtDetailAttachmentName.Text
                    row.Cells("AttachmentImage").Value = img
                End If

            Next

        End If

        ClearDetailFieldsAttachment()


    End Sub

    Private Sub dgvAttachments_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAttachments.CellContentClick

        Dim colName As String = dgvAttachments.Columns(e.ColumnIndex).Name
        If dgvAttachments.Rows.Count > 0 Then

            If colName = "DeleteAttachment" Then

                If dgvAttachments.CurrentRow.IsNewRow = False Then

                    dgvAttachments.Rows.Remove(dgvAttachments.CurrentRow)
                End If



            End If

            If colName = "ViewAttachment" Then

                If dgvAttachments.CurrentRow.IsNewRow = False Then

                    ZoomImage("AttachmentDetail")
                End If



            End If

            If colName = "EditAttachment" Then
                If dgvAttachments.CurrentRow.IsNewRow = False Then
                    FillAttachmentDetail()
                End If
            End If
        End If
    End Sub

    Sub FillAttachmentDetail()




        If dgvAttachments.Rows.Count > 0 Then
            With dgvAttachments.CurrentRow
                txtDetailAttachmentRowIndex.Text = .Index
                txtDetailAttachmentName.Text = .Cells("AttachmentName").Value
                chkIsDefaultImageAttachment.Checked = False
                Dim imgData As Byte()
                imgData = CType(dgvAttachments.CurrentRow.Cells("AttachmentImage").Value, Byte())
                Dim ms As New System.IO.MemoryStream(imgData)
                AttachmentPicture.Image = Image.FromStream(ms)

            End With

        End If
    End Sub

    Private Sub dgvAttachments_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAttachments.CellDoubleClick
        FillAttachmentDetail()

    End Sub


End Class