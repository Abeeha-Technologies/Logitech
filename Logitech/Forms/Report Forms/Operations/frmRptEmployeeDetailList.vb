Imports System.Data.SqlClient
Public Class frmRptEmployeeDetailList
    Dim rpt As Object



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

        qry.Append("SELECT EmployeeId, EmployeeName, IdNumber, IdExpiry, DateOfBirth, ContactNumber, IBAN, PassportNumber, PassportExpiry, Nationality, Designation, JoiningDate, EmployeePicture, GLAccCode FROM dbo.tblEmployees")
        If cboEmployee.SelectedIndex > 0 Then
            qry.Append(" WHERE (EmployeeId = " & cboEmployee.SelectedValue & ")")
        End If

        With cmd
            .Connection = Conn
            .CommandText = qry.ToString
            .Parameters.Clear()
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        If dt.Rows.Count < 1 Then
            MsgBox("No Record to Show")
            Exit Sub
        End If


        rpt = New rptEmployeeDetailList
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()

    End Sub


    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        frm.Text = "Employee Detail List"
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmIssueDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillCboEmployee()
    End Sub
    Sub FillCboEmployee()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.GLAccCode FROM dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId WHERE (dbo.tblVehicleIssuance.CloseDate IS NULL) GROUP BY dbo.tblVehicleIssuance.EmployeeId, dbo.tblEmployees.EmployeeName, dbo.tblEmployees.GLAccCode ORDER BY dbo.tblEmployees.EmployeeName"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("EmployeeId") = 0
        row.Item("EmployeeName") = "(--All--)"

        dt.Rows.InsertAt(row, 0)

        cboEmployee.DataSource = dt
        cboEmployee.DisplayMember = "EmployeeName"
        cboEmployee.ValueMember = "EmployeeId"

        cboEmployee.SelectedValue = 0

    End Sub
End Class