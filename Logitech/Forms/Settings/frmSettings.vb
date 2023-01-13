
Imports System.Data.SqlClient
Public Class frmSettings

    Dim pnlAccountSearchSource As String
    Dim TblAccountSearchBindingSource As New BindingSource
    Dim SetupDone = False

    Public WriteOnly Property ValueFromParent1() As String
        Set(ByVal Value As String)
            Me.txtParentValue1.Text = Value
        End Set
    End Property
    Public WriteOnly Property ValueFromParent2() As String
        Set(ByVal Value As String)
            Me.txtParentValue2.Text = Value
        End Set
    End Property

#Region "Variables"

    Public DatabaseName As String = "Data"
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        ApplySettings()
        If Me.txtParentValue1.Text = "First" Then
            SetupDone = True
            frmLogin.Show()
            Me.Close()
        Else
            AssignCompanyVariables()
            Me.Close()
        End If
    End Sub
    Sub ApplySettings()
        UpdateCompanyProfile()

    End Sub
    Sub UpdateCompanyProfile()

        If txtName.Text = Nothing Then
            MsgBox("Please Enter Company Name")
            txtName.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        trans = Conn.BeginTransaction
        If txtId.Text = Nothing Then
            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblCompany (Name, Address1, Address2, City, State, Country, PostalCode, Mobile, Landline, Fax, Email, Website, NTN, GST) VALUES (@Name, @Address1, @Address2, @City, @State, @Country, @PostalCode, @Mobile, @Landline, @Fax, @Email, @Website, @NTN, @GST)"
                .Parameters.Clear()
                .Parameters.Add("@Name", SqlDbType.NVarChar).Value = Trim(txtName.Text)
                .Parameters.Add("@Address1", SqlDbType.NVarChar).Value = Trim(txtAddress1.Text)
                .Parameters.Add("@Address2", SqlDbType.NVarChar).Value = Trim(txtAddress2.Text)
                .Parameters.Add("@City", SqlDbType.NVarChar).Value = Trim(txtCity.Text)
                .Parameters.Add("@State", SqlDbType.NVarChar).Value = Trim(txtState.Text)
                .Parameters.Add("@Country", SqlDbType.NVarChar).Value = Trim(txtCountry.Text)
                .Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = Trim(txtPostalCode.Text)
                .Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = Trim(txtMobile.Text)
                .Parameters.Add("@Landline", SqlDbType.NVarChar).Value = Trim(txtLandline.Text)
                .Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Trim(txtFax.Text)
                .Parameters.Add("@Email", SqlDbType.NVarChar).Value = Trim(txtEmail.Text)
                .Parameters.Add("@Website", SqlDbType.NVarChar).Value = Trim(txtWebsite.Text)
                .Parameters.Add("@NTN", SqlDbType.NVarChar).Value = Trim(txtNTN.Text)
                .Parameters.Add("@GST", SqlDbType.NVarChar).Value = Trim(txtGST.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable

            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandType = CommandType.Text
                .CommandText = "SELECT MAX(CompanyId) FROM tblCompany "
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            Dim NewCompanyId As Long
            NewCompanyId = Val(dt.Rows(0).Item(0).ToString)

            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblCompanyPreference (CompanyId, RequireUserPasswordForDelete, AutoBackupEveryXDays, AutoBackupDirectory, LastAutoBackupDate, AutoBackupOnClose, DefaultCashAccCode, DefaultSaleAccCode) VALUES(@CompanyId, @RequireUserPasswordForDelete, @AutoBackupEveryXDays, @AutoBackupDirectory, @LastAutoBackupDate, @AutoBackupOnClose, @DefaultCashAccCode, @DefaultSaleAccCode)"
                .Parameters.Clear()

                .Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = NewCompanyId
                .Parameters.Add("@RequireUserPasswordForDelete", SqlDbType.Bit).Value = chkRequireUserPasswordToDelete.Checked

                .Parameters.Add("@AutoBackupEveryXDays", SqlDbType.Int).Value = Val(txtAutoBackupDays.Text)
                .Parameters.Add("@AutoBackupDirectory", SqlDbType.NVarChar).Value = Trim(txtAutoBackupDirectory.Text)
                .Parameters.Add("@LastAutoBackupDate", SqlDbType.Date).Value = "01-01-2001"
                .Parameters.Add("@AutoBackupOnClose", SqlDbType.Bit).Value = chkAutoBackupOnClose.Checked

                'Default Accounts

                .Parameters.Add("@DefaultCashAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultCashAccount.Text)
                .Parameters.Add("@DefaultSaleAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultSaleAccount.Text)

                '.Parameters.Add("@DefaultProductSaleAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultProductSaleAccount.Text)
                '.Parameters.Add("@DefaultProductCOGSAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultProductCOGSAccount.Text)
                '.Parameters.Add("@DefaultSaleDiscountAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultSaleDiscountAccount.Text)
                '.Parameters.Add("@DefaultSaleTransportationDiscountAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultTransportationDiscountAccount.Text)
                '.Parameters.Add("@DefaultCarriageDebitAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultCarriageDebitAccount.Text)
                '.Parameters.Add("@DefaultCarriageCreditAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultCarriageCreditAccount.Text)
                .ExecuteNonQuery()
            End With
            trans.Commit()
        End If

        If txtId.Text <> Nothing Then
            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblCompany SET Name = @Name, Address1 = @Address1, Address2 = @Address2, City = @City, State = @State, Country = @Country, PostalCode = @PostalCode, Mobile = @Mobile, Landline = @Landline, Fax = @Fax, Email = @Email, NTN = @NTN, GST = @GST, Website = @Website WHERE CompanyId = @CompanyId"
                .Parameters.Clear()
                .Parameters.Add("@Name", SqlDbType.NVarChar).Value = Trim(txtName.Text)
                .Parameters.Add("@Address1", SqlDbType.NVarChar).Value = Trim(txtAddress1.Text)
                .Parameters.Add("@Address2", SqlDbType.NVarChar).Value = Trim(txtAddress2.Text)
                .Parameters.Add("@City", SqlDbType.NVarChar).Value = Trim(txtCity.Text)
                .Parameters.Add("@State", SqlDbType.NVarChar).Value = Trim(txtState.Text)
                .Parameters.Add("@Country", SqlDbType.NVarChar).Value = Trim(txtCountry.Text)
                .Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = Trim(txtPostalCode.Text)
                .Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = Trim(txtMobile.Text)
                .Parameters.Add("@Landline", SqlDbType.NVarChar).Value = Trim(txtLandline.Text)
                .Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Trim(txtFax.Text)
                .Parameters.Add("@Email", SqlDbType.NVarChar).Value = Trim(txtEmail.Text)
                .Parameters.Add("@Website", SqlDbType.NVarChar).Value = Trim(txtWebsite.Text)
                .Parameters.Add("@NTN", SqlDbType.NVarChar).Value = Trim(txtNTN.Text)
                .Parameters.Add("@GST", SqlDbType.NVarChar).Value = Trim(txtGST.Text)
                .Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = txtId.Text
                .ExecuteNonQuery()
            End With

            With cmd
                .Connection = Conn
                .Transaction = trans
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblCompanyPreference SET RequireUserPasswordForDelete = @RequireUserPasswordForDelete, AutoBackupEveryXDays = @AutoBackupEveryXDays, AutoBackupDirectory = @AutoBackupDirectory, AutoBackupOnClose = @AutoBackupOnClose, DefaultCashAccCode = @DefaultCashAccCode, DefaultSaleAccCode = @DefaultSaleAccCode WHERE CompanyId = @CompanyId"
                .Parameters.Clear()
                .Parameters.Add("@RequireUserPasswordForDelete", SqlDbType.Bit).Value = chkRequireUserPasswordToDelete.Checked
                .Parameters.Add("@AutoBackupEveryXDays", SqlDbType.Int).Value = Val(txtAutoBackupDays.Text)
                .Parameters.Add("@AutoBackupDirectory", SqlDbType.NVarChar).Value = Trim(txtAutoBackupDirectory.Text)
                .Parameters.Add("@AutoBackupOnClose", SqlDbType.Bit).Value = chkAutoBackupOnClose.Checked

                'Default Accounts

                .Parameters.Add("@DefaultCashAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultCashAccount.Text)
                .Parameters.Add("@DefaultSaleAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultSaleAccount.Text)
                '.Parameters.Add("@DefaultProductPurchaseAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultProductPurchaseAccount.Text)
                '.Parameters.Add("@DefaultProductSaleAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultProductSaleAccount.Text)
                '.Parameters.Add("@DefaultProductCOGSAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultProductCOGSAccount.Text)
                '.Parameters.Add("@DefaultSaleDiscountAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultSaleDiscountAccount.Text)
                '.Parameters.Add("@DefaultSaleTransportationDiscountAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultTransportationDiscountAccount.Text)
                '.Parameters.Add("@DefaultCarriageCreditAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultCarriageCreditAccount.Text)
                '.Parameters.Add("@DefaultCarriageDebitAccCode", SqlDbType.NVarChar).Value = Trim(txtAccCodeDefaultCarriageDebitAccount.Text)

                .Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = txtId.Text
                .ExecuteNonQuery()
            End With
            trans.Commit()
        End If

    End Sub

    Private Sub frmSettingsNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnSave_Click(Nothing, Nothing)
        End If

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
        dgvAccountSearch.Columns("AccCode").Width = 80
        dgvAccountSearch.Columns("AccName").Width = 100
        dgvAccountSearch.Columns("AccType").Width = 80
        dgvAccountSearch.Columns("AccNature").Width = 80
        dgvAccountSearch.Columns("AccType").Visible = False
        dgvAccountSearch.Columns("AccName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearSearchPanels()

        If txtParentValue1.Text = "Backup" Then
            MozPane1.SelectItem(3)
            MozItemBackupRestore_Click(Me, e)
        Else

            MozPane1.SelectItem(0)
            MozItemCompany_Click(Me, e)
        End If
        If txtParentValue1.Text <> "First" Then
            AssignCompanyVariables()

            'Company Info
            txtId.Text = vCompanyId
            txtName.Text = vCompanyName
            txtAddress1.Text = vCompanyAddress1
            txtAddress2.Text = vCompanyAddress2
            txtCity.Text = vCompanyCity
            txtState.Text = vCompanyState
            txtCountry.Text = vCompanyCountry
            txtPostalCode.Text = vCompanyPostalCode
            txtMobile.Text = vCompanyMobile
            txtLandline.Text = vCompanyLandline
            txtFax.Text = vCompanyFax
            txtEmail.Text = vCompanyEmail
            txtWebsite.Text = vCompanyWebsite
            txtNTN.Text = vCompanyNTN
            txtGST.Text = vCompanyGST
            txtAutoBackupDays.Text = vAutoBackupEveryXDays
            txtAutoBackupDirectory.Text = vAutoBackupDirectory

            chkRequireUserPasswordToDelete.Checked = vRequireUserPasswordForDelete
            chkAutoBackupOnClose.Checked = vAutoBackupOnClose


            'Default Accounts
            txtAccCodeDefaultCashAccount.Text = vDefaultCashAccCode
            txtAccCodeDefaultSaleAccount.Text = vDefaultSaleAccCode
            'txtAccCodeDefaultProductPurchaseAccount.Text = vDefaultProductPurchaseAccCode
            'txtAccCodeDefaultProductSaleAccount.Text = vDefaultProductSaleAccCode
            'txtAccCodeDefaultProductCOGSAccount.Text = vDefaultProductCOGSAccCode
            'txtAccCodeDefaultSaleDiscountAccount.Text = vDefaultSaleDiscountAccCode
            'txtAccCodeDefaultTransportationDiscountAccount.Text = vDefaultTransportationDiscountAccCode
            'txtAccCodeDefaultCarriageDebitAccount.Text = vDefaultCarriageDebitAccCode
            'txtAccCodeDefaultCarriageCreditAccount.Text = vDefaultCarriageCreditAccCode

        End If


        'Users
        FillUsersList()


    End Sub

    Sub FillUsersList()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandText = "SELECT UserId, Disabled AS Active, UserName AS Name FROM tblUsers WHERE Disabled = 0 ORDER BY UserName"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dgvUsers.DataSource = dt
        dgvUsers.Columns("UserId").Visible = False
        dgvUsers.Columns("Active").Visible = False
        dgvUsers.Columns("Active").Width = 100
        dgvUsers.Columns("Name").ReadOnly = True
        dgvUsers.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub txtId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtName.Focus()
        End If

    End Sub
    Private Sub txtName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
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
            txtNTN.Focus()
        End If
    End Sub

    Private Sub txtNTN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNTN.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGST.Focus()
        End If
    End Sub

    Private Sub txtGST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGST.KeyDown
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

    Private Sub MozItemCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MozItemCompany.Click
        HideChildPanels()
        pnlCompany.Visible = True
        pnlCompany.Dock = DockStyle.Fill
    End Sub

    Private Sub MozItemUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MozItemUsers.Click
        HideChildPanels()
        pnlUsers.Visible = True
        pnlUsers.Dock = DockStyle.Fill
        dgvUsers.CurrentCell = dgvUsers.Rows(0).Cells(2)
    End Sub
    Sub HideChildPanels()
        For Each pnl As Panel In pnlContainer.Controls
            pnl.Visible = False

        Next
    End Sub


    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        Dim frm As New frmUsers(Nothing, Nothing)
        frm.ShowDialog()
        FillUsersList()
    End Sub

    Private Sub MozItemReferences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MozItemReferences.Click
        HideChildPanels()
        pnlReference.Visible = True
        pnlReference.Dock = DockStyle.Fill
    End Sub

    Public Sub MozItemBackupRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MozItemBackupRestore.Click
        HideChildPanels()
        pnlBackupRestore.Visible = True
        pnlBackupRestore.Dock = DockStyle.Fill
        ProgressBar1.Value = 0
        lblNoteProgress.Visible = False
    End Sub


    Private Sub btnBackupPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupPath.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Try
                txtAutoBackupDirectory.Text = FolderBrowserDialog1.SelectedPath

                'daSettings.UpdateBySettingId(txtBackupPatch.Text, vAutoBackupPathId)

            Catch ex As Exception
                MessageBox.Show(Err.Description)
            End Try
        End If
    End Sub



    Private Sub txtAutoBackupDays_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAutoBackupDays.Validating
        If Val(txtAutoBackupDays.Text) > 365 Then
            e.Cancel = True
            lblNote.Visible = True
            lblNote.Text = " ! ! ! Max 365 Days Allowed."
        Else
            lblNote.Visible = False
        End If
    End Sub

    Private Sub btnBackupDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupDirectory.Click
        ProgressBar1.Value = 0

        Dim BackupPath As String
        BackupPath = txtAutoBackupDirectory.Text
        If Len(BackupPath) < 1 Then
            MsgBox("No Valid Backup Path is selected, Please select backup path and Try Again")
            Exit Sub
        End If

        Dim fname As String
        fname = DatabaseName & " " & Format(Now(), "dd-MM-yyyy hh;mm")

        Dim FilePath As String
        FilePath = BackupPath & "\" & fname
        RunBackup(FilePath)

    End Sub
    Public Sub RunBackup(ByVal BackupPath As String)

        lblNoteProgress.Visible = False
        Try
            Dim cmd As New SqlCommand
            Dim constr As String
            constr = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"

            Dim con As New SqlConnection(constr)
            ProgressBar1.Value = 20
            If con.State <> ConnectionState.Open Then
                con.Open()

            End If
            ProgressBar1.Value = 40

            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()

            End If
            ProgressBar1.Value = 60


            cmd = New SqlCommand("BACKUP DATABASE " & DatabaseName & " to disk='" & BackupPath & "'", Conn)
            Conn.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            ProgressBar1.Value = 80
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

            ProgressBar1.Value = 100
            lblNoteProgress.Visible = True
            lblNoteProgress.Text = "Database Backup Succesfull!"

        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("It seems the back path is incorrect or changed. Please select valid path and try again.")
            Else
                MessageBox.Show("Err Number: " & Err.Number & vbNewLine & Err.Description)
            End If

        End Try

    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        ProgressBar1.Value = 0
        lblNoteProgress.Visible = False

        Dim fname As String
        fname = DatabaseName & " " & Format(Now(), "dd-MM-yyyy hh;mm")
        SaveFileDialog1.FileName = fname

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            ProgressBar1.Value = 10
            Dim FilePath As String
            FilePath = SaveFileDialog1.FileName
            RunBackup(FilePath)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ProgressBar1.Value = 0
        lblNoteProgress.Visible = False
        Try
            Dim cmd As New SqlCommand


            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                ProgressBar1.Value = 10
                Try
                    Dim constr As String
                    constr = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
                    Dim con As New SqlConnection(constr)
                    ProgressBar1.Value = 20
                    If con.State <> ConnectionState.Open Then
                        con.Open()

                    End If
                    ProgressBar1.Value = 40

                    If Conn.State <> ConnectionState.Closed Then
                        Conn.Close()

                    End If
                    ProgressBar1.Value = 60


                    cmd = New SqlCommand("RESTORE DATABASE " & DatabaseName & " FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE", con)

                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    ProgressBar1.Value = 80
                    If Conn.State <> ConnectionState.Closed Then
                        Conn.Close()
                    End If

                    ProgressBar1.Value = 100

                    lblNoteProgress.Visible = True
                    lblNoteProgress.Text = "Database Restore Succesfull!"

                Catch ex As Exception
                    MessageBox.Show(Err.Description)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub



    Private Sub btnSearchAccDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowAccSearchDialog("SettingsDefaultCashAccount")
    End Sub

    Private Sub btnSearchAccDefaultProductSaleAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowAccSearchDialog("SettingsDefaultProductSaleAccount")
    End Sub






    Private Sub txtAccNameDefaultCashAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultCashAccount.Enter
        pnlAccountSearch.Location = New Point(147, 53)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccTitleDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultCashAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultSaleAccount.Focus()
            End If
        End If
        If Not Me.txtAccNameDefaultCashAccount.Text = "" Then
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
                        SelectAccount("DefaultCashAccount")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultSaleAccount.Focus()
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

    Private Sub txtAccTitleDetail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultCashAccount.TextChanged
        If txtAccNameDefaultCashAccount.Focused = True Then
            If Not Me.txtAccNameDefaultCashAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultCashAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString
            Else

                TblAccountSearchBindingSource.RemoveFilter()

                txtAccCodeDefaultCashAccount.Text = Nothing
                pnlAccountSearch.Visible = False


            End If
        End If


    End Sub

    Private Sub txtAccNameDefaultCashAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultCashAccount.Validating

        GetAccDetail("DefaultCashAccount", txtAccCodeDefaultCashAccount.Text)
        pnlAccountSearch.Visible = False
    End Sub

    Private Sub txtAccCodeDefaultCashAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultCashAccount.TextChanged
        If Not txtAccNameDefaultCashAccount.Focused = True Then
            GetAccDetail("DefaultCashAccount", Trim(txtAccCodeDefaultCashAccount.Text))
        End If
    End Sub

    Private Sub txtAccNameDefaultSaleAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultSaleAccount.Enter
        pnlAccountSearch.Location = New Point(147, 109)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultSaleAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultSaleAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultProductSaleAccount.Focus()
            End If
        End If

        If Not Me.txtAccNameDefaultSaleAccount.Text = "" Then
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
                        SelectAccount("DefaultSaleAccount")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultProductSaleAccount.Focus()
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

    Private Sub txtAccNameDefaultSaleAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultSaleAccount.TextChanged
        If txtAccNameDefaultSaleAccount.Focused = True Then
            If Not Me.txtAccNameDefaultSaleAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultSaleAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultSaleAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultSaleAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultSaleAccount.Validating

        GetAccDetail("DefaultSaleAccount", Trim(txtAccCodeDefaultSaleAccount.Text))

        pnlAccountSearch.Visible = False


    End Sub
    Private Sub txtAccCodeDefaultSaleAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultSaleAccount.TextChanged
        If Not txtAccNameDefaultSaleAccount.Focused = True Then
            GetAccDetail("DefaultSaleAccount", Trim(txtAccCodeDefaultSaleAccount.Text))
        End If
    End Sub

    Private Sub txtAccNameDefaultProductSaleAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultProductSaleAccount.Enter
        pnlAccountSearch.Location = New Point(147, 135)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultProductSaleAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultProductSaleAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultProductCOGSAccount.Focus()
            End If
        End If

        If Not Me.txtAccNameDefaultProductSaleAccount.Text = "" Then
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
                        SelectAccount("ProductSaleAccount")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultProductCOGSAccount.Focus()
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

    Private Sub txtAccNameDefaultProductSaleAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultProductSaleAccount.TextChanged
        If txtAccNameDefaultProductSaleAccount.Focused = True Then
            If Not Me.txtAccNameDefaultProductSaleAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultProductSaleAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultProductSaleAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultProductSaleAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultProductSaleAccount.Validating

        GetAccDetail("ProductSaleAccount", Trim(txtAccCodeDefaultProductSaleAccount.Text))

        pnlAccountSearch.Visible = False

    End Sub
    Private Sub txtAccCodeDefaultProductSaleAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultProductSaleAccount.TextChanged
        If Not txtAccNameDefaultProductSaleAccount.Focused = True Then
            GetAccDetail("ProductSaleAccount", Trim(txtAccCodeDefaultProductSaleAccount.Text))
        End If
    End Sub

    Private Sub txtAccNameDefaultProductCOGSAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultProductCOGSAccount.Enter
        pnlAccountSearch.Location = New Point(147, 161)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultProductCOGSAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultProductCOGSAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultSaleDiscountAccount.Focus()
            End If
        End If

        If Not Me.txtAccNameDefaultProductCOGSAccount.Text = "" Then
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
                        SelectAccount("ProductCOGSAccount")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultSaleDiscountAccount.Focus()
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

    Private Sub txtAccNameDefaultProductCOGSAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultProductCOGSAccount.TextChanged
        If txtAccNameDefaultProductCOGSAccount.Focused = True Then
            If Not Me.txtAccNameDefaultProductCOGSAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultProductCOGSAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultProductCOGSAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultProductCOGSAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultProductCOGSAccount.Validating

        GetAccDetail("ProductCOGSAccount", Trim(txtAccCodeDefaultProductCOGSAccount.Text))

        pnlAccountSearch.Visible = False
    End Sub

    Private Sub txtAccCodeDefaultProductCOGSAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultProductCOGSAccount.TextChanged
        If Not txtAccNameDefaultProductCOGSAccount.Focused = True Then
            GetAccDetail("ProductCOGSAccount", Trim(txtAccCodeDefaultProductCOGSAccount.Text))
        End If
    End Sub

    Private Sub txtAccNameDefaultSaleDiscountAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultSaleDiscountAccount.Enter
        pnlAccountSearch.Location = New Point(147, 187)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultSaleDiscountAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultSaleDiscountAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultTransportationDiscountAccount.Focus()
            End If
        End If

        If Not Me.txtAccNameDefaultSaleDiscountAccount.Text = "" Then
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
                        SelectAccount("SaleDiscount")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultTransportationDiscountAccount.Focus()
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

    Private Sub txtAccNameDefaultSaleDiscountAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultSaleDiscountAccount.TextChanged
        If txtAccNameDefaultSaleDiscountAccount.Focused = True Then
            If Not Me.txtAccNameDefaultSaleDiscountAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultSaleDiscountAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultSaleDiscountAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultSaleDiscountAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultSaleDiscountAccount.Validating

        GetAccDetail("SaleDiscount", Trim(txtAccCodeDefaultSaleDiscountAccount.Text))

        If txtAccNameDefaultSaleDiscountAccount.Text <> Nothing And txtAccCodeDefaultSaleDiscountAccount.Text = Nothing Then
            e.Cancel = True
        Else
            pnlAccountSearch.Visible = False
        End If

    End Sub
    Private Sub txtAccCodeDefaultSaleDiscountAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultSaleDiscountAccount.TextChanged
        If Not txtAccNameDefaultSaleDiscountAccount.Focused = True Then
            GetAccDetail("SaleDiscount", Trim(txtAccCodeDefaultSaleDiscountAccount.Text))
        End If
    End Sub

    Private Sub txtAccNameDefaultTransportationDiscountAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultTransportationDiscountAccount.Enter
        pnlAccountSearch.Location = New Point(147, 212)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultTransportationDiscountAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultTransportationDiscountAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultCarriageDebitAccount.Focus()
            End If
        End If

        If Not Me.txtAccNameDefaultTransportationDiscountAccount.Text = "" Then
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
                        SelectAccount("TransportationDiscount")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultCarriageDebitAccount.Focus()
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

    Private Sub txtAccNameDefaultTransportationDiscountAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultTransportationDiscountAccount.TextChanged
        If txtAccNameDefaultTransportationDiscountAccount.Focused = True Then
            If Not Me.txtAccNameDefaultTransportationDiscountAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultTransportationDiscountAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultTransportationDiscountAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultTransportationDiscountAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultTransportationDiscountAccount.Validating

        GetAccDetail("TransportationDiscount", Trim(txtAccCodeDefaultTransportationDiscountAccount.Text))
        pnlAccountSearch.Visible = False

    End Sub

    Private Sub txtAccCodeDefaultTransportationDiscountAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultTransportationDiscountAccount.TextChanged
        If Not txtAccNameDefaultTransportationDiscountAccount.Focused = True Then
            GetAccDetail("TransportationDiscount", Trim(txtAccCodeDefaultTransportationDiscountAccount.Text))
        End If
    End Sub



    Private Sub txtAccNameDefaultCarriageDebitAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultCarriageDebitAccount.Enter
        pnlAccountSearch.Location = New Point(147, 238)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultCarriageDebitAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultCarriageDebitAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                txtAccNameDefaultCarriageCreditAccount.Focus()
            End If
        End If

        If Not Me.txtAccNameDefaultCarriageDebitAccount.Text = "" Then
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
                        SelectAccount("CarriageDebit")
                        pnlAccountSearch.Visible = False
                        txtAccNameDefaultCarriageCreditAccount.Focus()
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

    Private Sub txtAccNameDefaultCarriageDebitAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultCarriageDebitAccount.TextChanged
        If txtAccNameDefaultCarriageDebitAccount.Focused = True Then
            If Not Me.txtAccNameDefaultCarriageDebitAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultCarriageDebitAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultCarriageDebitAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultCarriageDebitAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultCarriageDebitAccount.Validating

        GetAccDetail("CarriageDebit", Trim(txtAccCodeDefaultCarriageDebitAccount.Text))
        pnlAccountSearch.Visible = False

    End Sub

    Private Sub txtAccCodeDefaultCarriageDebitAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultCarriageDebitAccount.TextChanged
        If Not txtAccNameDefaultCarriageDebitAccount.Focused = True Then
            GetAccDetail("CarriageDebit", Trim(txtAccCodeDefaultCarriageDebitAccount.Text))
        End If
    End Sub

    Private Sub txtAccNameDefaultCarriageCreditAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultCarriageCreditAccount.Enter
        pnlAccountSearch.Location = New Point(147, 263)
        pnlAccountSearch.Size = New Size(340, 150)
    End Sub
    Private Sub txtAccNameDefaultCarriageCreditAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNameDefaultCarriageCreditAccount.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If pnlAccountSearch.Visible = True Then
                e.Handled = True
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If pnlAccountSearch.Visible = False Then
                Me.Validate()
            End If
        End If

        If Not Me.txtAccNameDefaultCarriageCreditAccount.Text = "" Then
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
                        SelectAccount("CarriageCredit")
                        pnlAccountSearch.Visible = False
                        Me.Validate()
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

    Private Sub txtAccNameDefaultCarriageCreditAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNameDefaultCarriageCreditAccount.TextChanged
        If txtAccNameDefaultCarriageCreditAccount.Focused = True Then
            If Not Me.txtAccNameDefaultCarriageCreditAccount.Text = "" Then
                Dim qry As New System.Text.StringBuilder

                qry.Append("AccCode + ' ' + AccName LIKE '%" & txtAccNameDefaultCarriageCreditAccount.Text & "%'")

                pnlAccountSearch.Visible = True

                TblAccountSearchBindingSource.Filter = qry.ToString


            Else
                TblAccountSearchBindingSource.RemoveFilter()

                pnlAccountSearch.Visible = False
                txtAccCodeDefaultCarriageCreditAccount.Text = Nothing


            End If
        End If
    End Sub
    Private Sub txtAccNameDefaultCarriageCreditAccount_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAccNameDefaultCarriageCreditAccount.Validating

        GetAccDetail("CarriageCredit", Trim(txtAccCodeDefaultCarriageCreditAccount.Text))
        pnlAccountSearch.Visible = False

    End Sub

    Private Sub txtAccCodeDefaultCarriageCreditAccount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccCodeDefaultCarriageCreditAccount.TextChanged
        If Not txtAccNameDefaultCarriageCreditAccount.Focused = True Then
            GetAccDetail("CarriageCredit", Trim(txtAccCodeDefaultCarriageCreditAccount.Text))
        End If
    End Sub

    Private Sub SelectAccount(ByVal Source As String)

        If Source = "DefaultCashAccount" Then
            txtAccCodeDefaultCashAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultCashAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

            txtAccNameDefaultSaleAccount.Focus()
        ElseIf Source = "DefaultSaleAccount" Then
            txtAccCodeDefaultSaleAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultSaleAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

        ElseIf Source = "ProductSaleAccount" Then
            txtAccCodeDefaultProductSaleAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultProductSaleAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

        ElseIf Source = "ProductCOGSAccount" Then
            txtAccCodeDefaultProductCOGSAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultProductCOGSAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

        ElseIf Source = "SaleDiscount" Then
            txtAccCodeDefaultSaleDiscountAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultSaleDiscountAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

        ElseIf Source = "TransportationDiscount" Then
            txtAccCodeDefaultTransportationDiscountAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultTransportationDiscountAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

        ElseIf Source = "CarriageDebit" Then
            txtAccCodeDefaultCarriageDebitAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultCarriageDebitAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString

        ElseIf Source = "CarriageCredit" Then
            txtAccCodeDefaultCarriageCreditAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccCode").Value.ToString
            txtAccNameDefaultCarriageCreditAccount.Text = dgvAccountSearch.CurrentRow.Cells("AccName").Value.ToString


        End If


    End Sub
    Sub GetAccDetail(ByVal Source As String, ByVal AccCode As String)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim cmdText As New System.Text.StringBuilder

        cmdText.Append("SELECT AccName, AccNature FROM tblAccChartOfAccounts WHERE IsAccount = 1 AND AccCode = @AccCode")

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
            If Source = "DefaultCashAccount" Then
                txtAccNameDefaultCashAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "DefaultSaleAccount" Then
                txtAccNameDefaultSaleAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "ProductSaleAccount" Then
                txtAccNameDefaultProductSaleAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "ProductCOGSAccount" Then
                txtAccNameDefaultProductCOGSAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "SaleDiscount" Then
                txtAccNameDefaultSaleDiscountAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "TransportationDiscount" Then
                txtAccNameDefaultTransportationDiscountAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "CarriageDebit" Then

                txtAccNameDefaultCarriageDebitAccount.Text = dt.Rows(0).Item("AccName")

            ElseIf Source = "CarriageCredit" Then
                txtAccNameDefaultCarriageCreditAccount.Text = dt.Rows(0).Item("AccName")

            End If



        Else
            If Source = "DefaultCashAccount" Then
                txtAccNameDefaultCashAccount.Text = Nothing

            ElseIf Source = "DefaultSaleAccount" Then
                txtAccNameDefaultSaleAccount.Text = Nothing

            ElseIf Source = "ProductSaleAccount" Then
                txtAccNameDefaultProductSaleAccount.Text = Nothing

            ElseIf Source = "ProductCOGSAccount" Then
                txtAccNameDefaultProductCOGSAccount.Text = Nothing

            ElseIf Source = "SaleDiscount" Then
                txtAccNameDefaultSaleDiscountAccount.Text = Nothing

            ElseIf Source = "TransportationDiscount" Then
                txtAccNameDefaultTransportationDiscountAccount.Text = Nothing
            ElseIf Source = "CariageDebit" Then

                txtAccNameDefaultCarriageDebitAccount.Text = Nothing

            ElseIf Source = "CarriageCredit" Then
                txtAccNameDefaultCarriageCreditAccount.Text = Nothing

            End If


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

    Private Sub frmSettings_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.txtParentValue1.Text = "First" And SetupDone = False Then
            If txtId.Text = Nothing Then
                If MsgBox("Company Profile Setup Required to use Application" & vbNewLine & "Click 'Yes' -  to close application." & vbNewLine & "Click 'No' - to Continue Setup Company.", vbYesNo + vbInformation, "Error") = vbYes Then

                    Application.ExitThread()
                End If
                e.Cancel = True
            End If
        End If
    End Sub

  
    Private Sub btnPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPacking.Click
        'frmProductLineItem.ShowDialog()
    End Sub

    Private Sub btnRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRooms.Click
        'frmProductCategory.ShowDialog()
    End Sub

    Private Sub btnRacks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRacks.Click
        'frmProductSubCategory.ShowDialog()
    End Sub

    Private Sub btnLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocation.Click
        'frmLocation.ShowDialog()
    End Sub

    Private Sub btnZone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZone.Click
        'frmZone.ShowDialog()
    End Sub


    Private Sub btnRemoveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveUser.Click
        If MsgBox("Do you realy want to Disable this user?", vbYesNo + vbQuestion, vCompanyName) = vbYes Then
            If vUserName = dgvUsers.CurrentRow.Cells("Name").Value Then
                MsgBox("You can not disable your self")
                Exit Sub
            End If
            Dim cmd As New SqlCommand
            With cmd
                .Connection = Conn
                .CommandText = "UPDATE tblUsers SET Disabled = @Disabled, DisableDate = @DisableDate WHERE UserId = @Original_UserId"
                .Parameters.Clear()
                .Parameters.Add("@Disabled", SqlDbType.Bit).Value = True
                .Parameters.Add("@DisableDate", SqlDbType.Date).Value = Now.Date
                .Parameters.Add("@Original_UserId", SqlDbType.BigInt).Value = dgvUsers.CurrentRow.Cells("UserId").Value

            End With
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            cmd.ExecuteNonQuery()

            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If
            FillUsersList()
        End If

    End Sub


End Class