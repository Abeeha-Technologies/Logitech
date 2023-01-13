Imports System.Data.SqlClient
Public Class frmRptVouchers

    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "ReportGeneralLedger"

        Dim childForm As frmAccountSearch

        ' Create the child form.
        childForm = New frmAccountSearch(initialValue, Nothing)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub

    Private Sub frmReportChartOfAccounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnSearchAcc_Click(sender, e)
        End If
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
        If txtVoucherId.Text = Nothing Then
            MsgBox("Please Enter Voucher Id")
            Exit Sub
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

        qry.Append("SELECT * FROM vwGeneralJournal")

        If txtVoucherTo.Text = Nothing Then
            qry.Append(" WHERE VoucherId = @VoucherId") ' JV-2019-7-1
        Else
            
            qry.Append(" WHERE VoucherType = @VoucherType AND VoucherYear = @VoucherYear AND VoucherMonth = @VoucherMonth AND (VoucherNo >= @VoucherFrom AND VoucherNo <= @VoucherTo)")
        End If
        Dim VoucherIdParts() As String
        VoucherIdParts = txtVoucherId.Text.Split("-")
        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = txtVoucherId.Text
            .Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherIdParts(0).ToString
            .Parameters.Add("@VoucherYear", SqlDbType.Int).Value = Val(VoucherIdParts(1).ToString)
            .Parameters.Add("@VoucherMonth", SqlDbType.Int).Value = Val(VoucherIdParts(2).ToString)
            .Parameters.Add("@VoucherFrom", SqlDbType.Int).Value = Val(VoucherIdParts(3).ToString)
            .Parameters.Add("@VoucherTo", SqlDbType.Int).Value = Val(txtVoucherTo.Text)
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Dim VoucherTitle As String = ""
        If VoucherIdParts(0).ToString = "BPV" Then
            VoucherTitle = "Bank Payment Voucher"
        ElseIf VoucherIdParts(0).ToString = "BRV" Then
            VoucherTitle = "Bank Receipt Voucher"
        ElseIf VoucherIdParts(0).ToString = "CPV" Then
            VoucherTitle = "Cash Payment Voucher"
        ElseIf VoucherIdParts(0).ToString = "CRV" Then
            VoucherTitle = "Cash Receipt Voucher"
        ElseIf VoucherIdParts(0).ToString = "JV" Then
            VoucherTitle = "Journal Voucher"
        Else
            VoucherTitle = VoucherIdParts(0).ToString
        End If
        Dim frm As New frmRptViewer
        frm.Text = VoucherTitle
        Dim rpt As Object
        rpt = New rptJournalVoucher
        rpt.SetDataSource(dt)
        rpt.setParameterValue("CompanyName", vCompanyName)
        rpt.setParameterValue("VoucherTitle", VoucherTitle)
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
        frm.Activate()
        frm.BringToFront()

    End Sub

    Private Sub txtVoucherId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoucherId.KeyDown
        If e.KeyCode = Keys.Space Then
            btnSearchVoucher_Click(sender, e)
        End If
    End Sub

  

    Private Sub btnSearchVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchVoucher.Click
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "VoucherReport"

        Dim childForm As frmVoucherSearch

        ' Create the child form.
        childForm = New frmVoucherSearch(initialValue, Nothing)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub

  

End Class