Imports System.Data.SqlClient
Public Class frmRptVoucherValidation


    Private Sub frmReportChartOfAccounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
  
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
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If rdbParticularVoucherType.Checked = True Then
            If cboVoucherType.SelectedIndex < 1 Then
                MsgBox("Please Select Voucher Type")
                Exit Sub
            End If
        End If
        If Not bgwReporter.IsBusy Then
            bgwReporter.RunWorkerAsync()
        Else
            MsgBox("Please Wait While Processing your Previous Request.")
        End If
    End Sub



    Private Sub bgwReporter_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporter.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder
        Dim FilterCriteria As String = ""
        If rdbTransactionDate.Checked = True Then
            qry.Append("SELECT TransactionDate AS Date, ")
            FilterCriteria = "Transaction Date"
        ElseIf rdbEntryDate.Checked = True Then
            qry.Append("SELECT TransactionDate AS Date, ")
            FilterCriteria = "Entry Date"
        End If

        qry.Append("AccCode, AccName, Description, Debit, Credit, VoucherId FROM vwGeneralJournal WHERE VoucherType <> 'Opening Balance' ")

        If rdbTransactionDate.Checked = True Then
            qry.Append("AND TransactionDate >= @DateFrom AND TransactionDate <= @DateTo")
        ElseIf rdbEntryDate.Checked = True Then
            qry.Append("AND CONVERT(date,SysTimeStamp) >= @DateFrom AND CONVERT(date,SysTimeStamp) <= @DateTo")
        End If

        If rdbParticularVoucherType.Checked = True Then

            qry.Append(" AND VoucherType ='" & Trim(cboVoucherType.SelectedValue.ToString) & "'")
        End If

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date
            .Parameters.Add("@DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Dim frm As New frmRptViewer
        frm.Text = "Voucher Validation"
        Dim rpt As Object
        rpt = New rptVoucherValidation
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("DateFrom", dtpDateFrom.Value)
        rpt.SetParameterValue("DateTo", dtpDateTo.Value)
        rpt.SetParameterValue("FilterCriteria", FilterCriteria)
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub

 

    Private Sub frmRptVoucherValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStateNew()

    End Sub
    Sub SetFormStateNew()
        rdbTransactionDate.Checked = True
        rdbAllVoucherType.Checked = True
        cboVoucherType.Visible = False
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
        row(0) = "--(Select)--"

        dt.Rows.InsertAt(row, 0)

        cboVoucherType.DataSource = dt
        cboVoucherType.ValueMember = dt.Columns(0).ToString
        cboVoucherType.DisplayMember = dt.Columns(0).ToString
    End Sub

    Private Sub rdbParticularVoucherType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbParticularVoucherType.CheckedChanged
        If rdbAllVoucherType.Checked = True Then
            cboVoucherType.Visible = False
        Else
            cboVoucherType.Visible = True
        End If
    End Sub
End Class