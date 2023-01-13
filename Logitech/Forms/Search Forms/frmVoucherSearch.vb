Imports System.Data.SqlClient
Public Class frmVoucherSearch


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

        Me.Text = "Voucher Search"

        SetFormStateNew()
        ''ParentArray = txtParentValue.Text.Split("|")

    End Sub
    Sub SetFormStateNew()
        txtSearchText.Focus()
        txtSearchText.Text = Nothing
        cboVoucherType.SelectedIndex = 0
        txtSearchText.Focus()
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

            cmdText.Append("SELECT VoucherId, VoucherType FROM vwGeneralJournal WHERE VoucherId <> NULL OR VoucherId <> '' AND ")



            If Not txtSearchText.Text = Nothing Then
                cmdText.Append(" VoucherId LIKE '%" & txtSearchText.Text.ToString & "%' AND ")
            End If
            If cboVoucherType.SelectedIndex > 0 Then
                cmdText.Append(" VoucherType='" & cboVoucherType.SelectedItem.ToString & "' AND ")
            End If
            cmdText.Replace(cmdText.ToString, cmdText.Remove(cmdText.Length - 4, 4).ToString)
            cmdText.Append("GROUP BY VoucherId, VoucherType")


            With cmd
                .Connection = Conn
                .CommandText = cmdText.ToString
            End With

            dt.Clear()
            da.SelectCommand = cmd
            da.Fill(dt)

            dgvAccounts.DataSource = dt
            dgvAccounts.Columns(0).Width = 200
            dgvAccounts.Columns(1).Width = 100
            dgvAccounts.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            lblCount.Text = "Count: " & dgvAccounts.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cboAccType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVoucherType.SelectedIndexChanged
        FillDGV()
    End Sub


    Private Sub tblAccChartOfAccountsDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccounts.CellDoubleClick



        If txtParentValue1.Text = "VoucherReport" Then
            With Me.dgvAccounts.CurrentRow
                frmRptVouchers.txtVoucherId.Text = .Cells(0).Value

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

                dgvAccounts.CurrentCell = dgvAccounts.Rows(1).Cells(0)
            End If
            If dgvAccounts.RowCount = 1 Then
                dgvAccounts.CurrentCell = dgvAccounts.Rows(0).Cells(0)
            End If

            If dgvAccounts.RowCount < 1 Then
                txtSearchText.Focus()
            End If
        End If

    End Sub

End Class