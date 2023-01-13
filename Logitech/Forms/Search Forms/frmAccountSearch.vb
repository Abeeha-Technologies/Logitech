Imports System.Data.SqlClient
Public Class frmAccountSearch


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

    'Dim ParentArray() As String

    Private Sub frmAccountSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Account Search"

        SetFormStateNew()
        ''ParentArray = txtParentValue.Text.Split("|")

    End Sub
    Sub SetFormStateNew()
        txtSearchText.Focus()
        txtSearchText.Text = Nothing
        cboAccType.SelectedIndex = 0
        txtSearchText.Focus()
        FillDGV()
    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged
        FillDGV()
    End Sub
    Sub FillDGV()
        Try
            Dim cmd As New SqlCommand
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            Dim cmdText As New System.Text.StringBuilder

            cmdText.Append("SELECT AccCode, AccName, AccType, AccId FROM tblAccChartOfAccounts WHERE")


            If txtParentValue1.Text <> "AddAccount" Or txtParentValue1.Text <> "AddAccountBasic" Then
                cmdText.Append(" IsAccount = 1 AND  ")
            End If
            If txtParentValue1.Text = "CRVMaster" Or txtParentValue1.Text = "CPVMaster" Then
                cmdText.Append(" AccType ='Cash' AND ")
            End If
            If txtParentValue1.Text = "BRVMaster" Or txtParentValue1.Text = "BPVMaster" Then
                cmdText.Append(" AccType ='Bank' AND ")
            End If
            If txtParentValue1.Text = "PVDetail" Or txtParentValue1.Text = "RVDetail" Then
                cmdText.Append(" AccCode <> '" & txtParentValue2.Text & "' AND ")
            End If




            If Not txtSearchText.Text = Nothing Then

                cmdText.Append(" AccCode + ' ' + AccName LIKE N'%" & txtSearchText.Text.ToString & "%' AND  ")
            End If
            If cboAccType.SelectedIndex > 0 Then
                cmdText.Append(" AccType =N'" & cboAccType.SelectedItem.ToString & "' AND  ")
            End If
            If txtParentValue1.Text <> "AddAccount" Or txtParentValue1.Text <> "AddAccountBasic" Then
                cmdText.Replace(cmdText.ToString, cmdText.Remove(cmdText.Length - 5, 5).ToString)
            Else
                cmdText.Replace(cmdText.ToString, cmdText.Remove(cmdText.Length - 6, 6).ToString)
            End If

            With cmd
                .Connection = Conn
                .CommandText = cmdText.ToString
            End With

            dt.Clear()
            da.SelectCommand = cmd
            da.Fill(dt)

            dgvAccounts.DataSource = dt
            dgvAccounts.Columns(0).Width = 150
            dgvAccounts.Columns(1).Width = 400
            dgvAccounts.Columns(2).Width = 250
            dgvAccounts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            lblCount.Text = "Count: " & dgvAccounts.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cboAccType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccType.SelectedIndexChanged
        FillDGV()
    End Sub


    Private Sub tblAccChartOfAccountsDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.CellDoubleClick

    

        If txtParentValue1.Text = "AddAccount" Then
            With Me.dgvAccounts.CurrentRow
                frmAccountsAdvanced.txtAccCode.Text = .Cells(0).Value

            End With
            Me.Close()
        End If

        If txtParentValue1.Text = "AddAccountSimple" Then
            With Me.dgvAccounts.CurrentRow
                frmAccountsSimple.txtId.Text = .Cells(3).Value

            End With
            Me.Close()
        End If

        'If txtParentValue1.Text = "AccountReport" Then
        '    With Me.dgvAccounts.CurrentRow
        '        frmRptChartOfAccounts.txtAccCode.Text = .Cells(0).Value

        '    End With
        '    Me.Close()
        'End If

        If txtParentValue1.Text = "CPVMaster" Or txtParentValue1.Text = "BPVMaster" Then
            With Me.dgvAccounts.CurrentRow
                frmPaymentVoucher.txtAccCodeMaster.Text = .Cells(0).Value

            End With
            Me.Close()
        End If
        If txtParentValue1.Text = "CRVMaster" Or txtParentValue1.Text = "BRVMaster" Then
            With Me.dgvAccounts.CurrentRow
                frmReceiptVoucher.txtAccCodeMaster.Text = .Cells(0).Value

            End With
            Me.Close()
        End If
        If txtParentValue1.Text = "PVDetail" Then
            With Me.dgvAccounts.CurrentRow
                frmPaymentVoucher.txtAccCodeDetail.Text = .Cells(0).Value

            End With
            Me.Close()
        End If
        If txtParentValue1.Text = "RVDetail" Then
            With Me.dgvAccounts.CurrentRow
                frmReceiptVoucher.txtAccCodeDetail.Text = .Cells(0).Value

            End With
            Me.Close()
        End If


        If txtParentValue1.Text = "JournalVoucherDetail" Then
            With Me.dgvAccounts.CurrentRow
                frmJournalVoucher.txtAccCodeDetail.Text = .Cells(0).Value

            End With
            Me.Close()
        End If
        If txtParentValue1.Text = "ReportGeneralLedger" Then
            With Me.dgvAccounts.CurrentRow
                frmRptGeneralLedger.txtAccCode.Text = .Cells(0).Value

            End With
            Me.Close()
        End If

        If txtParentValue1.Text = "ReportTrialBalance" Then
            With Me.dgvAccounts.CurrentRow
                frmRptTrialBalance.txtAccCode.Text = .Cells(0).Value

            End With
            Me.Close()
        End If

        If txtParentValue1.Text = "ReportBalanceSheet" Then
            With Me.dgvAccounts.CurrentRow
                frmRptBalanceSheet.txtAccCode.Text = .Cells(0).Value

            End With
            Me.Close()
        End If

        If txtParentValue1.Text = "SettingsDefaultCashAccount" Then
            With Me.dgvAccounts.CurrentRow
                Dim frm As New frmSettings(Nothing, Nothing)
                frm.txtAccCodeDefaultCashAccount.Text = .Cells(0).Value
            End With
            Me.Close()
        End If

        If txtParentValue1.Text = "SettingsDefaultProductSaleAccount" Then
            With Me.dgvAccounts.CurrentRow
                Dim frm As New frmSettings(Nothing, Nothing)
                frm.txtAccCodeDefaultCashAccount.Text = .Cells(0).Value
            End With
            Me.Close()
        End If

        If txtParentValue1.Text = "ReportDayBook" Then
            With Me.dgvAccounts.CurrentRow
                frmRptDailyBook.txtAccCode.Text = .Cells(0).Value
            End With
            Me.Close()
        End If
    End Sub



    Private Sub frmAccountSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            If Me.dgvAccounts.SelectedRows.Count > 0 Then
                tblAccChartOfAccountsDataGridView_CellDoubleClick(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub txtSearchText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchText.KeyDown



        If e.KeyCode = Keys.Down Then

            dgvAccounts.Focus()
            'dgvAccounts.CurrentCell = dgvAccounts.Rows(dgvAccounts.CurrentRow.Index + 1).Cells(2)
            If dgvAccounts.RowCount > 1 Then

                dgvAccounts.CurrentCell = dgvAccounts.Rows(1).Cells(2)
            End If
            If dgvAccounts.RowCount = 1 Then
                dgvAccounts.CurrentCell = dgvAccounts.Rows(0).Cells(2)
            End If

            If dgvAccounts.RowCount < 1 Then
                txtSearchText.Focus()
            End If
        End If

    End Sub

End Class