Imports System.Data.SqlClient

Public Class frmUsers
    Dim OldUserName As String
    Dim OldCanCreateUsers As Boolean

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

#Region "Subroutines & Functions"
    Sub FillDGV()
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable


        Dim QueryBuilder As New System.Text.StringBuilder

        QueryBuilder.Append("SELECT * FROM tblUsers WHERE")

        If txtSearchText.Text <> Nothing Then
            QueryBuilder.Append(" UserName LIKE '" & txtSearchText.Text & "%'   AND")
        End If

        QueryBuilder.Replace(QueryBuilder.ToString, QueryBuilder.Remove(QueryBuilder.Length - 6, 6).ToString)


        With cmd
            .Connection = Conn
            .CommandText = QueryBuilder.ToString
        End With



        da.SelectCommand = cmd

        dt.Clear()
        da.Fill(dt)

        dgv.DataSource = dt

        dgv.Columns("UserId").Visible = False
        dgv.Columns("UserPassword").Visible = False

        For Each col As DataGridViewColumn In dgv.Columns
            If col.HeaderText = "UserName" Then
                col.Width = 200
                col.Visible = True
            ElseIf col.HeaderText = "DisbaleDate" Then
                col.Width = 120
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
        dgv.Columns("UserName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        lblTotal.Text = "Count: " & dgv.RowCount

    End Sub
    Sub SetFormStateNew()

        txtUserId.Text = Nothing
        ClearAllFields()


        txtUserName.Focus()
        FillDGV()
        lblTotal.Text = "Count: " & dgv.RowCount

    End Sub
    Sub ClearAllFields()
        OldCanCreateUsers = False
        OldUserName = Nothing
        chkDisable.Checked = False

        txtUserName.Text = Nothing

        'Forms
        chkCreateUser.Checked = False
        chkDefineAcounts.Checked = False
        chkEnterAccountingVoucher.Checked = False
        chkDefineOperations.Checked = False
        chkEnterOpperationalVoucher.Checked = False
        chkEditVoucher.Checked = False
        chkCanDeleteVoucher.Checked = False
        chkSystemSettings.Checked = False
        chkCanViewDashboard.Checked = False
        chkCanApproveVoucher.Checked = False
        chkCanEditApproveVoucher.Checked = False

        'Reports

        chkCanViewIncomeStatement.Checked = False
        chkCanViewBalanceSheetReport.Checked = False
        chkCanViewTrialBalanceReport.Checked = False
        chkCanViewGeneralLedgerReport.Checked = False
        chkCanViewPurchaseReport.Checked = False
        chkCanViewSaleReport.Checked = False


        nudBackDateDays.Value = 0
    End Sub


    Sub FillDetail()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        With cmd
            .Connection = Conn
            .CommandText = "SELECT * FROM tblUsers WHERE UserId = @UserId"
            .Parameters.Clear()
            .Parameters.Add("@UserId", SqlDbType.BigInt).Value = Val(txtUserId.Text)
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            txtUserName.Text = dt.Rows(0).Item("UserName")
            nudBackDateDays.Value = dt.Rows(0).Item("BackDateEntryDays")

            chkCreateUser.Checked = dt.Rows(0).Item("CanCreateUsers")

            chkDefineAcounts.Checked = dt.Rows(0).Item("CanDefineAccounts")
            chkEnterAccountingVoucher.Checked = dt.Rows(0).Item("CanEnterAccountingVoucher")

            chkDefineOperations.Checked = dt.Rows(0).Item("CanDefineOperations")
            chkEnterOpperationalVoucher.Checked = dt.Rows(0).Item("CanEnterOperationalVoucher")

            chkEditVoucher.Checked = dt.Rows(0).Item("CanEditVouchers")
            chkCanDeleteVoucher.Checked = dt.Rows(0).Item("CanDeleteVoucher")

            chkSystemSettings.Checked = dt.Rows(0).Item("CanSystemSettings")
            chkCanViewDashboard.Checked = dt.Rows(0).Item("CanViewDashboard")

            chkCanApproveVoucher.Checked = dt.Rows(0).Item("CanApproveVouchers")
            chkCanEditApproveVoucher.Checked = dt.Rows(0).Item("CanEditApprovedVouchers")

            chkCanViewIncomeStatement.Checked = dt.Rows(0).Item("CanViewIncomeStatementReport")
            chkCanViewBalanceSheetReport.Checked = dt.Rows(0).Item("CanViewBalanceSheetReport")

            chkCanViewTrialBalanceReport.Checked = dt.Rows(0).Item("CanViewTrialBalanceReport")
            chkCanViewGeneralLedgerReport.Checked = dt.Rows(0).Item("CanViewGeneralLedgerReport")

            chkCanViewPurchaseReport.Checked = dt.Rows(0).Item("CanViewPurchaseReport")
            chkCanViewSaleReport.Checked = dt.Rows(0).Item("CanViewSaleReport")

            chkDisable.Checked = dt.Rows(0).Item("Disabled")
            OldUserName = dt.Rows(0).Item("UserName")

        Else
            ClearAllFields()

        End If

    End Sub
#End Region
    Private Sub frmRegion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStateNew()
        If txtParentValue1.Text = "First" Then
            txtSearchText.Visible = False
            dgv.Visible = False
        End If
    End Sub

    Private Sub frmRegion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If

        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnSave_Click(Me, Nothing)

        End If
    End Sub

    Private Sub brnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnReset.Click
        SetFormStateNew()
    End Sub




    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Trim(txtUserName.Text).Length < 1 Then
            MsgBox("Please Enter User Name")
            txtUserName.Focus()
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

        If OldUserName <> txtUserName.Text Then
            With cmd
                .Connection = Conn
                .CommandText = "SELECT Count(UserId) AS Count FROM tblUsers WHERE UserName COLLATE Latin1_General_CS_AS = @UserName"
                .Parameters.Clear()
                .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = Trim(txtUserName.Text)
            End With

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If Val(dt.Rows(0).Item("Count")) > 0 Then
                MsgBox(txtUserName.Text & " is Duplicate", vbCritical + vbOK, "Error")
                Exit Sub
            End If
        End If
        'End Check Duplicate

        'Inser if Record is New
        If txtUserId.Text = Nothing Then


            If chkDisable.Checked = True Then
                MsgBox("New User should not Already In-Active")
                Exit Sub
            End If

            With cmd
                .Connection = Conn
                .CommandText = "INSERT INTO tblUsers (UserName, UserPassword, BackDateEntryDays, CanCreateUsers, CanEditVouchers, CanDeleteVoucher, CanEnterAccountingVoucher, CanEnterOperationalVoucher, CanDefineOperations, CanDefineAccounts, CanSystemSettings, CanViewIncomeStatementReport, CanViewBalanceSheetReport, CanViewTrialBalanceReport, CanViewGeneralLedgerReport, CanViewPurchaseReport, CanViewSaleReport, CanEditApprovedVouchers, Disabled, CanApproveVouchers, CanViewDashboard) VALUES (@UserName, @UserPassword, @BackDateEntryDays, @CanCreateUsers, @CanEditVouchers, @CanDeleteVoucher, @CanEnterAccountingVoucher, @CanEnterOperationalVoucher, @CanDefineOperations, @CanDefineAccounts, @CanSystemSettings, @CanViewIncomeStatementReport, @CanViewBalanceSheetReport, @CanViewTrialBalanceReport, @CanViewGeneralLedgerReport, @CanViewPurchaseReport, @CanViewSaleReport, @CanEditApprovedVouchers, @Disabled, @CanApproveVouchers, @CanViewDashboard)"
                .Parameters.Clear()
                .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = Trim(txtUserName.Text)
                .Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = Encrypt(12345)
                .Parameters.Add("@BackDateEntryDays", SqlDbType.Int).Value = nudBackDateDays.Value
                .Parameters.Add("@CanCreateUsers", SqlDbType.Bit).Value = chkCreateUser.Checked
                .Parameters.Add("@CanEditVouchers", SqlDbType.Bit).Value = chkEditVoucher.Checked
                .Parameters.Add("@CanDeleteVoucher", SqlDbType.Bit).Value = chkCanDeleteVoucher.Checked
                .Parameters.Add("@CanEnterAccountingVoucher", SqlDbType.Bit).Value = chkEnterAccountingVoucher.Checked
                .Parameters.Add("@CanEnterOperationalVoucher", SqlDbType.Bit).Value = chkEnterOpperationalVoucher.Checked
                .Parameters.Add("@CanDefineOperations", SqlDbType.Bit).Value = chkDefineOperations.Checked
                .Parameters.Add("@CanDefineAccounts", SqlDbType.Bit).Value = chkDefineAcounts.Checked
                .Parameters.Add("@CanSystemSettings", SqlDbType.Bit).Value = chkSystemSettings.Checked
                .Parameters.Add("@CanViewIncomeStatementReport", SqlDbType.Bit).Value = chkCanViewIncomeStatement.Checked
                .Parameters.Add("@CanViewBalanceSheetReport", SqlDbType.Bit).Value = chkCanViewBalanceSheetReport.Checked
                .Parameters.Add("@CanViewTrialBalanceReport", SqlDbType.Bit).Value = chkCanViewTrialBalanceReport.Checked
                .Parameters.Add("@CanViewGeneralLedgerReport", SqlDbType.Bit).Value = chkCanViewGeneralLedgerReport.Checked
                .Parameters.Add("@CanViewPurchaseReport", SqlDbType.Bit).Value = chkCanViewPurchaseReport.Checked
                .Parameters.Add("@CanViewSaleReport", SqlDbType.Bit).Value = chkCanViewSaleReport.Checked
                .Parameters.Add("@CanEditApprovedVouchers", SqlDbType.Bit).Value = chkCanEditApproveVoucher.Checked
                .Parameters.Add("@Disabled", SqlDbType.Bit).Value = chkDisable.Checked
                .Parameters.Add("@CanApproveVouchers", SqlDbType.Bit).Value = chkCanApproveVoucher.Checked
                .Parameters.Add("@CanViewDashboard", SqlDbType.Bit).Value = chkCanViewDashboard.Checked
                .ExecuteNonQuery()
            End With

            MsgBox("Saved Succefully with new Password: 12345")
            SetFormStateNew()

        End If

        If txtUserId.Text <> Nothing Then

            If vUserName = Trim(txtUserName.Text) Then
                If OldCanCreateUsers = True Then
                    If chkCreateUser.Checked = False Then
                        MsgBox("You can not disable yourself to creating users")
                        Exit Sub
                    End If
                End If
            End If

            If chkDisable.Checked = True Then
                If vUserName = Trim(txtUserName.Text) Then
                    MsgBox("You can not disbale yourself")
                    Exit Sub
                End If

            End If

            Dim qry As New System.Text.StringBuilder

            qry.Append("UPDATE tblUsers SET BackDateEntryDays = @BackDateEntryDays, CanCreateUsers = @CanCreateUsers, CanEditVouchers = @CanEditVouchers, CanDeleteVoucher = @CanDeleteVoucher, CanEnterAccountingVoucher = @CanEnterAccountingVoucher, CanEnterOperationalVoucher = @CanEnterOperationalVoucher, CanDefineOperations = @CanDefineOperations, CanDefineAccounts = @CanDefineAccounts, CanSystemSettings = @CanSystemSettings, CanViewIncomeStatementReport = @CanViewIncomeStatementReport, CanViewBalanceSheetReport = @CanViewBalanceSheetReport, CanViewTrialBalanceReport = @CanViewTrialBalanceReport, CanViewGeneralLedgerReport = @CanViewGeneralLedgerReport, CanViewPurchaseReport = @CanViewPurchaseReport, CanViewSaleReport = @CanViewSaleReport, CanEditApprovedVouchers = @CanEditApprovedVouchers, Disabled = @Disabled, CanApproveVouchers = @CanApproveVouchers, CanViewDashboard = @CanViewDashboard")
            If chkDisable.Checked = True Then
                qry.Append(", DisableDate = @DisableDate")
            End If
            qry.Append(" WHERE UserId = @Original_UserId")

            With cmd
                .Connection = Conn
                .CommandText = qry.ToString
                .Parameters.Clear()
                .Parameters.Add("@BackDateEntryDays", SqlDbType.Int).Value = nudBackDateDays.Value
                .Parameters.Add("@CanCreateUsers", SqlDbType.Bit).Value = chkCreateUser.Checked
                .Parameters.Add("@CanEditVouchers", SqlDbType.Bit).Value = chkEditVoucher.Checked
                .Parameters.Add("@CanDeleteVoucher", SqlDbType.Bit).Value = chkCanDeleteVoucher.Checked
                .Parameters.Add("@CanEnterAccountingVoucher", SqlDbType.Bit).Value = chkEnterAccountingVoucher.Checked
                .Parameters.Add("@CanEnterOperationalVoucher", SqlDbType.Bit).Value = chkEnterOpperationalVoucher.Checked
                .Parameters.Add("@CanDefineOperations", SqlDbType.Bit).Value = chkDefineOperations.Checked
                .Parameters.Add("@CanDefineAccounts", SqlDbType.Bit).Value = chkDefineAcounts.Checked
                .Parameters.Add("@CanSystemSettings", SqlDbType.Bit).Value = chkSystemSettings.Checked
                .Parameters.Add("@CanViewIncomeStatementReport", SqlDbType.Bit).Value = chkCanViewIncomeStatement.Checked
                .Parameters.Add("@CanViewBalanceSheetReport", SqlDbType.Bit).Value = chkCanViewBalanceSheetReport.Checked
                .Parameters.Add("@CanViewTrialBalanceReport", SqlDbType.Bit).Value = chkCanViewTrialBalanceReport.Checked
                .Parameters.Add("@CanViewGeneralLedgerReport", SqlDbType.Bit).Value = chkCanViewGeneralLedgerReport.Checked
                .Parameters.Add("@CanViewPurchaseReport", SqlDbType.Bit).Value = chkCanViewPurchaseReport.Checked
                .Parameters.Add("@CanViewSaleReport", SqlDbType.Bit).Value = chkCanViewSaleReport.Checked
                .Parameters.Add("@CanEditApprovedVouchers", SqlDbType.Bit).Value = chkCanEditApproveVoucher.Checked
                .Parameters.Add("@Disabled", SqlDbType.Bit).Value = chkDisable.Checked
                If chkDisable.Checked = True Then
                    .Parameters.Add("@DisableDate", SqlDbType.Date).Value = Now.Date
                Else
                    .Parameters.Add("@DisableDate", SqlDbType.Date).Value = DBNull.Value
                End If
                .Parameters.Add("@CanApproveVouchers", SqlDbType.Bit).Value = chkCanApproveVoucher.Checked
                .Parameters.Add("@CanViewDashboard", SqlDbType.Bit).Value = chkCanViewDashboard.Checked
                .Parameters.Add("@Original_UserId", SqlDbType.BigInt).Value = txtUserId.Text
                .ExecuteNonQuery()
            End With

            MsgBox("Saved Updated")
            SetFormStateNew()


        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        txtUserId.Text = dgv.CurrentRow.Cells("UserId").Value
    End Sub


    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged
        FillDGV()
    End Sub

    Private Sub btnResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPassword.Click
        If Val(txtUserId.Text) < 1 Then
            Exit Sub
        End If
        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
        End With

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        With cmd
            .Connection = Conn
            .CommandText = "UPDATE tblUsers SET UserPassword = @UserPassword WHERE UserId = @Original_UserId"
            .Parameters.Clear()
            .Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = Encrypt(12345)
            .Parameters.Add("@Original_UserId", SqlDbType.BigInt).Value = Val(txtUserId.Text)
            .ExecuteNonQuery()
        End With
        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If

        MsgBox("Password Reset to   -->   12345")
        SetFormStateNew()
    End Sub

    Private Sub txtUserId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserId.TextChanged
        FillDetail()
    End Sub
End Class