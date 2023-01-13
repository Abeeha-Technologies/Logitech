Imports System.Data.SqlClient
Public Class frmRptVehicleDetailList
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

        qry.Append("SELECT dbo.tblVehicles.VehicleId, dbo.tblVehicles.MakeId, dbo.tblVehicleMake.MakeName, dbo.tblVehicles.ModelId, dbo.tblVehicleModel.ModelName, dbo.tblVehicles.ModelYear, dbo.tblVehicles.VehicleNumber, dbo.tblVehicles.ChasisNumber, dbo.tblVehicles.EngineNumber, dbo.tblVehicles.RegistrationDate, dbo.tblVehicles.RenewDate, dbo.tblVehicles.ExpiryDate, dbo.tblVehicles.GLAccCode FROM dbo.tblVehicles INNER JOIN dbo.tblVehicleModel ON dbo.tblVehicles.ModelId = dbo.tblVehicleModel.ModelId INNER JOIN dbo.tblVehicleMake ON dbo.tblVehicles.MakeId = dbo.tblVehicleMake.MakeId")
        If cboVehicle.SelectedIndex > 0 Then
            qry.Append(" WHERE (tblVehicles.VehicleId = " & cboVehicle.SelectedValue & ")")
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


        rpt = New rptVehicleDetailList
        rpt.SetDataSource(dt)
        rpt.setparametervalue("CompanyName", vCompanyName)
        cRptViewer.ReportSource = rpt
        cRptViewer.Refresh()

    End Sub


    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        Dim frm As New frmRptViewer
        frm.Text = "Vehicle Detail List"
        frm.cRptViewer.ReportSource = rpt
        frm.cRptViewer.Refresh()
        frm.Show()
        frm.Activate()
        frm.BringToFront()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmIssueDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillCboVehicle()
    End Sub
    Sub FillCboVehicle()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT VehicleId, VehicleNumber FROM dbo.tblVehicles GROUP BY VehicleId, VehicleNumber ORDER BY VehicleNumber"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("VehicleId") = 0
        row.Item("VehicleNumber") = "(--All--)"

        dt.Rows.InsertAt(row, 0)

        cboVehicle.DataSource = dt
        cboVehicle.DisplayMember = "VehicleNumber"
        cboVehicle.ValueMember = "VehicleId"

        cboVehicle.SelectedValue = 0

    End Sub
End Class