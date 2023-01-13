Imports System.Data.SqlClient
Public Class frmRptChartOfAccounts

    Private Sub btnSearchAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAcc.Click
        ' Get the value that the child will be initialised with
        Dim initialValue As String
        initialValue = "AccountReport"

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
        If Not bgwReporter.IsBusy Then
            bgwReporter.RunWorkerAsync()
        Else
            MsgBox("Please Wait while processing your previous request.")
        End If
    End Sub



    Private Sub bgwReporter_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporter.RunWorkerCompleted
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim qry As New System.Text.StringBuilder

        qry.Append("SELECT * FROM tblAccChartOfAccounts WHERE AccLevel <= @AccLevel AND")

        If Val(txtAccCode.Text) > 0 Then
            qry.Append(" AccCode LIKE '" & Trim(txtAccCode.Text) & "%' AND")
        End If

        qry.Replace(qry.ToString, qry.Remove(qry.Length - 4, 4).ToString)

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
            .Parameters.Add("@AccLevel", SqlDbType.Int).Value = cboLevel.Text.ToString
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        Dim frm As New frmRptViewer
        frm.Text = "Chart Of Accounts"
        Dim rpt As Object
        rpt = New rptChartOfAccounts
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        rpt.SetParameterValue("PrintedLevel", cboLevel.Text)
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtAccCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccCode.KeyDown
        If e.KeyCode = Keys.Space Then
            btnSearchAcc_Click(sender, e)
        End If
    End Sub

    Private Sub frmRptChartOfAccounts_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class