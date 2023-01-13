Imports System.Data.SqlClient
Public Class frmRecordLog

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dgvLog.DataSource = Nothing

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim cmdText As New System.Text.StringBuilder

        cmdText.Append("SELECT VoucherId, LogType, SessionUser, SysTimeStamp FROM tblRecordLog")

        cmdText.Append(" WHERE SysDateStamp >= @DateFrom AND SysDateStamp <= @DateTo")

        If txtSearchText.Text <> Nothing Then
            cmdText.Append(" AND VoucherId LIKE '%" & txtSearchText.Text & "%'")
        End If
        If cboVoucherType.SelectedIndex > 0 Then
            cmdText.Append(" AND VoucherType = '" & cboVoucherType.SelectedValue.ToString & "'")
        End If

        cmdText.Append(" ORDER BY VoucherId, SysTimeStamp")

   
        With cmd
            .Connection = Conn
            .CommandText = cmdText.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value
        End With

        dt.Clear()
        da.SelectCommand = cmd



        da.Fill(dt)

        dgvLog.DataSource = dt

        dgvLog.Columns(0).Width = 120
        dgvLog.Columns(3).Width = 250
    End Sub

    Private Sub frmRecordLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDateFrom.Value = DateAdd(DateInterval.Day, -10, Now)
        FillCboVoucherType()

    End Sub
    Sub FillCboVoucherType()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT VoucherType FROM vwGeneralJournal GROUP BY VoucherType"
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        Dim row As DataRow = dt.NewRow
        row(0) = "--(All)--"

        dt.Rows.InsertAt(row, 0)

        cboVoucherType.DataSource = dt
        cboVoucherType.ValueMember = dt.Columns(0).ToString
        cboVoucherType.DisplayMember = dt.Columns(0).ToString
    End Sub
End Class