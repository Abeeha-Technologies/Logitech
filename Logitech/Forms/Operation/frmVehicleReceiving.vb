Imports System.Data.SqlClient
Public Class frmVehicleReceiving

    Dim TblSearchListBindingSource As New BindingSource

    Dim OldDriverId As Long
    Dim OldVehicleId As Long


    Dim blnIsFormLoaded As Boolean = False
    Sub SetFormStateNew()
        blnIsFormLoaded = False

        FillCboDriver()

        FillCboVehicle()

        ClearMasterFields()

        FillMainSearchList()
        FilterMainSearchList()

        txtUser.Text = vUserName

        cboDriver.Focus()

        dgvDriverActivity.Rows.Clear()
        dgvVehicleActivity.Rows.Clear()

        blnIsFormLoaded = True
    End Sub


    Sub ClearMasterFields()

        txtCloseRemarks.Text = Nothing
        dtpCloseDate.Value = Now.Date

    End Sub
   
    Sub FillCboDriver()
        'If cboVehicle.Items.Count > 0 Then
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT EmployeeId, EmployeeName FROM dbo.tblEmployees ORDER BY EmployeeName"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("EmployeeId") = 0
        row.Item("EmployeeName") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)

        cboDriver.DataSource = dt
        cboDriver.DisplayMember = dt.Columns("EmployeeName").ToString
        cboDriver.ValueMember = dt.Columns("EmployeeId").ToString

        'End If
    End Sub

    Sub FillCboVehicle()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT VehicleId, VehicleNumber AS Vehicle FROM dbo.tblVehicles ORDER BY VehicleNumber"
            '.CommandText = "SELECT dbo.tblVehicles.VehicleId, dbo.tblVehicles.VehicleNumber, dbo.tblVehicleIssuance.Shift, CASE WHEN Shift = 'Day' THEN 'Available for Night' ELSE CASE WHEN Shift = 'Night' THEN 'Available for Day' ELSE 'Fully Available' END END AS Availability FROM dbo.tblVehicles LEFT OUTER JOIN dbo.tblVehicleIssuance ON dbo.tblVehicles.VehicleId = dbo.tblVehicleIssuance.VehicleId WHERE (dbo.tblVehicleIssuance.Shift IS NULL) OR (dbo.tblVehicleIssuance.Shift <> N'24 Hours') ORDER BY dbo.tblVehicles.VehicleNumber"
            '.CommandText = "SELECT DISTINCT tblVehicles.VehicleId, dbo.tblVehicles.VehicleNumber AS Vehicle, STUFF(Shifts,1,2,'') AS Shifts, CASE WHEN Shifts IS NULL THEN 'Availabe' ELSE CASE WHEN Shifts = ', Day' THEN ' Available for Night' ELSE CASE WHEN Shifts = ', Night' THEN ' Available for Day' ELSE CASE WHEN Shifts IN (', Night, Day', ', Day, Night', ', 24 Hours') THEN 'Not Available' ELSE Shifts END END END END AS Availability FROM dbo.tblVehicles LEFT OUTER JOIN dbo.tblVehicleIssuance ON dbo.tblVehicles.VehicleId = tblVehicleIssuance.VehicleId CROSS APPLY (SELECT ', ' + Shift FROM tblVehicleIssuance WHERE VehicleId = tblVehicleIssuance.VehicleId AND (dbo.tblVehicleIssuance.CloseDate IS NULL) FOR XML PATH('')) D ( Shifts ) WHERE CASE WHEN Shifts IS NULL THEN 'Availabe' ELSE CASE WHEN Shifts = ', Day' THEN ' Available for Night' ELSE CASE WHEN Shifts = ', Night' THEN ' Available for Day' ELSE CASE WHEN Shifts IN (', Night, Day', ', Day, Night', ', 24 Hours') THEN 'Not Available' ELSE Shifts END END END END <> 'Not Available' ORDER BY VehicleNumber"
        End With

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim row As DataRow = dt.NewRow
        row.Item("VehicleId") = 0
        row.Item("Vehicle") = "(--Select--)"
        'row.Item("Shifts") = "NULL"
        'row.Item("Availability") = "(--Select--)"

        dt.Rows.InsertAt(row, 0)

        cboVehicle.DataSource = dt
        cboVehicle.DisplayMember = dt.Columns(1).ToString
        cboVehicle.ValueMember = dt.Columns(0).ToString


        'Dim gch As Syncfusion.Windows.Forms.Grid.GridColHidden = New Syncfusion.Windows.Forms.Grid.GridColHidden(1) 'Hides column number '1'
        'cboVehicle.ListBox.Grid.ColHiddenEntries.Add(gch)

        'gch = New Syncfusion.Windows.Forms.Grid.GridColHidden(3) 'Hides column number '3'
        'cboVehicle.ListBox.Grid.ColHiddenEntries.Add(gch)

        'cboVehicle.ListBox.Grid.ColWidths(2) = 100
        'cboVehicle.ListBox.Grid.ColWidths(4) = 200
        'cboVehicle.ListBox.Grid.ColStyles(2).AutoSize = True


    End Sub




    Sub FillMainSearchList()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim qryStr As New System.Text.StringBuilder
        Dim cmd As New SqlCommand

        qryStr.Append("SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate AS Date, dbo.tblEmployees.EmployeeName AS Driver, dbo.tblVehicles.VehicleNumber AS [Veh #], dbo.tblVehicleIssuance.Shift, dbo.tblVehicleIssuance.RentPerDay, dbo.tblVehicleIssuance.CloseDate, dbo.tblVehicleIssuance.Remarks FROM dbo.tblEmployees RIGHT OUTER JOIN dbo.tblVehicleIssuance LEFT OUTER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId ON dbo.tblEmployees.EmployeeId = dbo.tblVehicleIssuance.EmployeeId ORDER BY Driver, [Veh #]")

        With cmd
            .Connection = Conn
            .CommandText = qryStr.ToString
            .Parameters.Clear()

        End With
        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        TblSearchListBindingSource.DataSource = dt

        dgvList.DataSource = TblSearchListBindingSource

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If


        If dt.Rows.Count > 0 Then
            dgvList.Columns("IssueId").Visible = False
            dgvList.Columns("Veh #").Width = 80
            dgvList.Columns("Driver").Width = 90
            dgvList.Columns("Shift").Width = 60
            dgvList.Columns("Remarks").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If


        If SplitContainer.Panel2Collapsed = False Then
            HideColumns()
        Else
            ShowColumns()

        End If

    End Sub

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetFormStateNew()

        txtSearchText.Text = Nothing
        cboSearchStatus.SelectedIndex = 1

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SetFormStateNew()
    End Sub

    
    
    Sub UpdateIssueId(IssueId As Long)

        'If cboDriver.SelectedIndex < 1 Then
        '    MsgBox("Please Select Driver", , "Error")
        '    cboDriver.Focus()
        '    Exit Sub
        'End If

        'If cboVehicle.SelectedIndex < 1 Then
        '    MsgBox("Please Select Vehicle", , "Error")
        '    cboVehicle.Focus()
        '    Exit Sub
        'End If

        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
        End With

        Dim trans As SqlTransaction

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If

        trans = Conn.BeginTransaction()

        With cmd
            .Transaction = trans
            .CommandText = "UPDATE tblVehicleIssuance SET CloseDate = @CloseDate, CloseRemarks = @CloseRemarks WHERE IssueId = @Original_IssueId"
            .Parameters.Clear()
            .Parameters.Add("@CloseDate", SqlDbType.Date).Value = dtpCloseDate.Value
            .Parameters.Add("@CloseRemarks", SqlDbType.NVarChar).Value = txtCloseRemarks.Text
            .Parameters.Add("@Original_IssueId", SqlDbType.BigInt).Value = IssueId
            .ExecuteNonQuery()
        End With

        trans.Commit()
        MsgBox("Updated Successfully")
        SetFormStateNew()




    End Sub


    Private Sub frmAccounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
       
        If e.KeyCode = Keys.F5 Then
            btnRefresh_Click(Me, Nothing)

        End If

    End Sub


    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        'If dgvList.RowCount > 0 Then
        '    txtId.Text = dgvList.CurrentRow.Cells("IssueId").Value


        '    If SplitContainer.Panel2Collapsed = True Then
        '        ShowDetailPanel()
        '    End If
        'End If

    End Sub

    Sub ShowDetailPanel()
        SplitContainer.Panel2Collapsed = False
        picPanelExtender.BackgroundImage = imgList.Images(0)

        HideColumns()
    End Sub
    Sub HideDetailPanel()
        SplitContainer.Panel2Collapsed = True
        picPanelExtender.BackgroundImage = imgList.Images(1)
        ShowColumns()
    End Sub
    Sub HideColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "Veh #" Or col.HeaderText = "Shift" Or col.HeaderText = "Driver" Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next
    End Sub
    Sub ShowColumns()
        For Each col As DataGridViewColumn In dgvList.Columns
            If col.HeaderText = "IssueId" Then
                col.Visible = False
            Else
                col.Visible = True
            End If
        Next
    End Sub

    Private Sub picPanelExtender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPanelExtender.Click
        If SplitContainer.Panel2Collapsed = False Then
            HideDetailPanel()
        Else
            ShowDetailPanel()

        End If
    End Sub
    Private Sub cboSearchStatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSearchStatus.SelectedIndexChanged
        If blnIsFormLoaded = True Then
            FilterMainSearchList()
        End If
    End Sub
    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged
        If blnIsFormLoaded = True Then
            If txtSearchText.Focused = True Then
                FilterMainSearchList()
            End If
        End If

    End Sub
    Sub FilterMainSearchList()

        Dim qry As New System.Text.StringBuilder
        If Not Me.txtSearchText.Text = "" Then
            qry.Append("[Veh #] + ' ' + Driver LIKE '%" & txtSearchText.Text & "%' AND")
        End If
        If cboSearchStatus.SelectedIndex = 1 Then

            qry.Append(" CloseDate IS NULL AND")
        End If

        If cboSearchStatus.SelectedIndex = 2 Then

            qry.Append(" CloseDate NOT IS NULL AND")
        End If



        If qry.Length > 0 Then
            qry.Replace(qry.ToString, qry.Remove(qry.Length - 3, 3).ToString)

            TblSearchListBindingSource.Filter = qry.ToString


        Else
            TblSearchListBindingSource.RemoveFilter()

        End If
    End Sub
    Private Sub dgvList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvList.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvList_CellDoubleClick(Me, Nothing)
        End If
    End Sub

    Private Sub btnAddDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmEmployees
        frm.ShowDialog()
        FillCboDriver()

    End Sub
    Private Sub btnAddVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmVehicles
        frm.ShowDialog()
        FillCboVehicle()

    End Sub


    Private Sub dtpRegistrationDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpCloseDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboDriver.Focus()
        End If
    End Sub

    Private Sub cboDriver_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDriver.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboVehicle.Focus()
        End If
    End Sub
    Private Sub cboVehicle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVehicle.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCloseRemarks.Focus()
        End If
    End Sub

    Private Sub txtCloseRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCloseRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.Validate()
        End If
    End Sub

    Private Sub tsbList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbList.Click
        If SplitContainer.Panel1Collapsed = False Then
            SplitContainer.Panel1Collapsed = True
            tsbList.Text = "Show List"
        Else
            SplitContainer.Panel1Collapsed = False
            tsbList.Text = "Hide List"

        End If
    End Sub






    Private Sub cboDriver_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDriver.SelectedIndexChanged
        If blnIsFormLoaded = True Then

            FillDriverActivity(cboDriver.SelectedValue)
        End If
    End Sub
    Sub FillDriverActivity(DriverId As Long)

        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        OpenNewConnection()

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicles.VehicleNumber, dbo.tblVehicleIssuance.Shift FROM dbo.tblVehicleIssuance INNER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId GROUP BY dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.CloseDate, dbo.tblVehicles.VehicleNumber, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.Shift, dbo.tblVehicleIssuance.EmployeeId HAVING (dbo.tblVehicleIssuance.CloseDate IS NULL) AND (dbo.tblVehicleIssuance.EmployeeId = @EmployeeId)"
            .Parameters.Clear()
            .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = DriverId
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dgvDriverActivity.Rows.Clear()

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                dgvDriverActivity.Rows.Add(row.Item("IssueId"), row.Item("IssueDate"), row.Item("VehicleNumber"), row.Item("Shift"))
            Next
        End If
        dgvDriverActivity.ClearSelection()
    End Sub


    Private Sub cboVehicle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboVehicle.SelectedIndexChanged

        If blnIsFormLoaded = True Then

            FillVehicleActivity(cboVehicle.SelectedValue)

        End If
    End Sub
    Sub FillVehicleActivity(VehicleId As Long)

        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        OpenNewConnection()

        With cmd
            .Connection = Conn
            .CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblEmployees.EmployeeName, dbo.tblVehicleIssuance.Shift FROM dbo.tblVehicleIssuance INNER JOIN dbo.tblEmployees ON dbo.tblVehicleIssuance.EmployeeId = dbo.tblEmployees.EmployeeId GROUP BY dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.CloseDate, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.Shift, dbo.tblEmployees.EmployeeName, dbo.tblVehicleIssuance.VehicleId HAVING (dbo.tblVehicleIssuance.CloseDate IS NULL) AND (dbo.tblVehicleIssuance.VehicleId = @VehicleId)"
            .Parameters.Clear()
            .Parameters.Add("@VehicleId", SqlDbType.BigInt).Value = VehicleId
        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dgvVehicleActivity.Rows.Clear()

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                dgvVehicleActivity.Rows.Add(row("IssueId"), row.Item("IssueDate"), row.Item("EmployeeName"), row.Item("Shift"))
            Next
        End If
        dgvVehicleActivity.ClearSelection()

    End Sub

    Private Sub dgvDriverActivity_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDriverActivity.CellContentClick

        Dim colName As String = dgvDriverActivity.Columns(e.ColumnIndex).Name
        If dgvDriverActivity.Rows.Count > 0 Then

            If colName = "dgvDriverActivityReceive" Then


                UpdateIssueId(dgvDriverActivity.CurrentRow.Cells("dgvDriverActivityIssueId").Value)

            End If


        End If
    End Sub
End Class