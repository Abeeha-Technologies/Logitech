Imports System.Data.SqlClient
Public Class frmVehicleIssuance

    Dim TblSearchListBindingSource As New BindingSource

    Dim OldDriverId As Long
    Dim OldVehicleId As Long
    Dim OldShift As String


    Dim blnIsFormLoaded As Boolean = False
    Sub SetFormStateNew()
        blnIsFormLoaded = False

        FillCboDriver()

        FillCboVehicle()

        ClearMasterFields()

        ClearDetailFieldsAttachment()
        dgvAttachments.Rows.Clear()

        FillMainSearchList()
        FilterMainSearchList()

        txtUser.Text = vUserName

        cboDriver.Focus()

        dgvDriverActivity.Rows.Clear()
        dgvVehicleActivity.Rows.Clear()

        blnIsFormLoaded = True
    End Sub


    Sub ClearMasterFields()
        OldDriverId = 0
        OldVehicleId = 0
        OldShift = Nothing

        txtId.Text = Nothing
        txtRemarks.Text = Nothing
        dtpIssueDate.Value = Now.Date
        txtRentPerDay.Text = 0
        cboShift.SelectedIndex = 0

    End Sub
    Sub ClearDetailFieldsAttachment()
        txtDetailAttachmentRowIndex.Text = Nothing
        txtDetailAttachmentName.Text = Nothing
        SetDefaultImageAttachment()
    End Sub

    Sub SetDefaultImageAttachment()
        Me.AttachmentPicture.Image = Global.Logitech.My.Resources.Resources.DefaultImage
        chkIsDefaultImageAttachment.Checked = True
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtId.Text <> Nothing Then
            If MsgBox("Do you Really Want to Delete?" & vbNewLine & "This event is not reversable.", vbYesNo + vbCritical, "Confirmation") = vbYes Then

                If vRequireUserPasswordForDelete = "True" Then
                    frmPasswordInput.ShowDialog()
                    If frmPasswordInput.DialogResult = System.Windows.Forms.DialogResult.Yes Then

                        Delete(txtId.Text)
                        Exit Sub
                    Else

                        Exit Sub
                    End If

                End If

                Delete(txtId.Text)

            End If

        End If
    End Sub
    Sub Delete(ByVal AccId As Long)

        'Try
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter


        'With cmd
        '    .Connection = Conn
        '    .CommandType = CommandType.Text
        '    .CommandText = "SELECT VoucherId FROM vwGeneralJournal WHERE VoucherType <> 'Opening Balance' AND AccCode = @AccCode"
        '    .Parameters.Clear()
        '    .Parameters.Add("@AccCode", SqlDbType.NVarChar).Value = AccCode
        'End With

        'da.SelectCommand = cmd
        'dt.Clear()
        'da.Fill(dt)
        'If dt.Rows.Count > 0 Then
        '    Dim str As New System.Text.StringBuilder

        '    For i = 0 To dt.Rows.Count - 1
        '        If i = 0 Then
        '            str.Append(dt.Rows(i).Item("VoucherId").ToString)
        '        Else
        '            str.Append(" | " & dt.Rows(i).Item("VoucherId").ToString)
        '        End If
        '    Next

        '    MsgBox("You can not Delete Current record. There is transactions in following vouchers" & vbNewLine & str.ToString)
        '    Exit Sub
        'End If

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()

        End If

        'If dt.Rows.Count = 0 Then
        With cmd
            .Connection = Conn
            .CommandText = "DELETE FROM tblVehicleIssuance WHERE IssueId = @IssueId"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = AccId
            .ExecuteNonQuery()
        End With
        MsgBox("Deleted Successfully")

        'End If

        SetFormStateNew()
        'Catch ex As Exception

        'Finally
        '    If Conn.State <> ConnectionState.Closed Then
        '        Conn.Close()
        '    End If

        'End Try


    End Sub

    Dim arrImage() As Byte
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cboDriver.SelectedIndex < 1 Then
            MsgBox("Please Select Driver", , "Error")
            cboDriver.Focus()
            Exit Sub
        End If

        If cboVehicle.SelectedIndex < 1 Then
            MsgBox("Please Select Vehicle", , "Error")
            cboVehicle.Focus()
            Exit Sub
        End If
        If cboShift.SelectedIndex < 1 Then
            MsgBox("Please select Shift", , "Error")
            cboShift.Focus()
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

        'Start Driver Checking
        If cboDriver.SelectedValue <> OldDriverId Then
            If dgvDriverActivity.Rows.Count >= 2 Then
                MsgBox("One Driver Can have Maximum 2 shifts")
                Exit Sub
            End If
        End If

        If cboShift.SelectedItem <> OldShift Then
            If cboShift.SelectedItem = "24 Hours" Then
                If txtId.Text = Nothing And dgvDriverActivity.Rows.Count > 0 Then
                    MsgBox("One driver can only work 24 hours if he is not working in any shift")
                    Exit Sub
                End If

                If txtId.Text <> Nothing Then
                    Dim count As Integer = 0

                    For Each row As DataGridViewRow In dgvDriverActivity.Rows

                        If Val(row.Cells("dgvDriverActivityIssueId").Value) <> Val(txtId.Text) Then
                            count += 1
                        End If
                    Next
                    MsgBox(count)
                    If count > 0 Then
                        MsgBox("One driver can only work 24 hours if he is not working in any shift")
                        Exit Sub
                    End If
                End If

            End If


            Dim blnFoundChecking As Boolean = False
            Dim blnStopCheckChecking As Boolean = False
            For Each row As DataGridViewRow In dgvDriverActivity.Rows
                If blnStopCheckChecking = False Then
                    If row.Cells("dgvDriverActivityShift").Value = "24 Hours" And row.Cells("dgvDriverActivityIssueId").Value <> Val(txtId.Text) Then
                        blnFoundChecking = True
                    End If
                End If
            Next
            If blnFoundChecking = True Then
                MsgBox("Driver is already working in 24 hours Shift")
                Exit Sub
            End If

            blnFoundChecking = False
            blnStopCheckChecking = False

            For Each row As DataGridViewRow In dgvDriverActivity.Rows
                If blnStopCheckChecking = False Then
                    If row.Cells("dgvDriverActivityShift").Value = cboShift.SelectedItem Then
                        blnFoundChecking = True
                    End If
                End If
            Next

            If blnFoundChecking = True Then
                MsgBox("Driver is already working in " & cboShift.SelectedItem)
                Exit Sub
            End If
        End If

        'End Driver Checking

        'Start Vehicle Checking
        If cboVehicle.SelectedValue <> OldVehicleId Then
            If dgvVehicleActivity.Rows.Count >= 2 Then
                MsgBox("One Vehicle Can be on Maximum 2 shifts")
                Exit Sub
            End If
            Dim blnFoundChecking As Boolean = False
            Dim blnStopCheckChecking As Boolean = False
            For Each row As DataGridViewRow In dgvVehicleActivity.Rows
                If blnStopCheckChecking = False Then
                    If row.Cells("dgvVehicleActivityShift").Value = cboShift.SelectedItem Then
                        blnFoundChecking = True
                    End If
                End If
            Next

            If blnFoundChecking = True Then
                MsgBox("Vehicle is already in " & cboShift.SelectedItem)
                Exit Sub
            End If
        End If

        If cboShift.SelectedItem <> OldShift Then

            If cboShift.SelectedItem = "24 Hours" Then
                If txtId.Text = Nothing And dgvVehicleActivity.Rows.Count > 0 Then
                    MsgBox("One Vehicle can only work 24 hours if he is not working in any shift")
                    Exit Sub
                End If

                If txtId.Text <> Nothing Then
                    Dim count As Integer = 0

                    For Each row As DataGridViewRow In dgvVehicleActivity.Rows
                        If row.Cells("dgvVehicleActivityIssueId").Value <> txtId.Text Then
                            count += 1
                        End If
                    Next

                    If count > 0 Then
                        MsgBox("One Vehicle can only work 24 hours if he is not working in any shift")
                        Exit Sub
                    End If
                End If

            End If


            Dim blnFoundChecking As Boolean = False
            Dim blnStopCheckChecking As Boolean = False
            'For Each row As DataGridViewRow In dgvDriverActivity.Rows
            '    If blnStopCheckChecking = False Then
            '        If row.Cells("dgvDriverActivityShift").Value = "24 Hours" Then
            '            blnFoundChecking = True
            '        End If
            '    End If
            'Next
            'If blnFoundChecking = True Then
            '    MsgBox("Driver is already working in 24 hours Shift")
            '    Exit Sub
            'End If

            blnFoundChecking = False
            blnStopCheckChecking = False

            For Each row As DataGridViewRow In dgvVehicleActivity.Rows
                If blnStopCheckChecking = False Then
                    If row.Cells("dgvVehicleActivityShift").Value = cboShift.SelectedItem Then
                        blnFoundChecking = True
                    End If
                End If
            Next

            If blnFoundChecking = True Then
                MsgBox("Vehicle is already in " & cboShift.SelectedItem)
                Exit Sub
            End If
        End If

        'End Driver Checking

        'Inser if Record is New
        If txtId.Text = Nothing Then


            'Start Inserting New Record
            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            Try

                With cmd
                    .Connection = Conn
                    .Transaction = trans
                    .CommandText = "INSERT INTO tblVehicleIssuance (IssueDate, Remarks, EmployeeId, VehicleId, RentPerDay, Shift, EnteredBy) VALUES (@IssueDate, @Remarks, @EmployeeId, @VehicleId, @RentPerDay, @Shift, @EnteredBy)"
                    .Parameters.Clear()
                    .Parameters.Add("@IssueDate", SqlDbType.Date).Value = dtpIssueDate.Value
                    .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = Trim(txtRemarks.Text)
                    .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = cboDriver.SelectedValue
                    .Parameters.Add("@VehicleId", SqlDbType.BigInt).Value = cboVehicle.SelectedValue
                    .Parameters.Add("@RentPerDay", SqlDbType.Decimal).Value = txtRentPerDay.Text
                    .Parameters.Add("@Shift", SqlDbType.NVarChar).Value = cboShift.SelectedItem
                    .Parameters.Add("@EnteredBy", SqlDbType.NVarChar).Value = vUserName

                    .ExecuteNonQuery()
                End With



                If dgvAttachments.Rows.Count > 0 Then
                    With cmd
                        .CommandText = "SELECT IDENT_CURRENT('tblVehicleIssuance')"

                    End With
                    Dim dtNewIdentity As New DataTable
                    Dim daNewIdentity As New SqlDataAdapter
                    daNewIdentity.SelectCommand = cmd
                    dtNewIdentity.Clear()
                    daNewIdentity.Fill(dtNewIdentity)

                    Dim LastEmployeeId As Long
                    LastEmployeeId = dtNewIdentity.Rows(0).Item(0).ToString


                    For Each row As DataGridViewRow In dgvAttachments.Rows
                        With cmd
                            .Transaction = trans
                            .CommandText = "INSERT INTO tblVehicleIssuanceAttachments (IssueId, AttachmentName, AttachmentImage) VALUES (@IssueId, @AttachmentName, @AttachmentImage)"
                            .Parameters.Clear()
                            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = LastEmployeeId
                            .Parameters.Add("@AttachmentName", SqlDbType.NVarChar).Value = row.Cells("AttachmentName").Value
                            .Parameters.Add("@AttachmentImage", SqlDbType.Image).Value = row.Cells("AttachmentImage").Value

                            .ExecuteNonQuery()
                        End With
                    Next
                End If

                trans.Commit()
                MsgBox("Added Successfully")
                SetFormStateNew()

            Catch ex As Exception
                MessageBox.Show("Commit Exception Type: " & ex.GetType.ToString & Chr(13) & "Message: " & ex.Message)
                Try
                    trans.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show("Rollback Exception Type: " & ex2.GetType.ToString & Chr(13) & "Message: " & ex2.Message)
                End Try

            Finally
                cmd.Dispose()
                If Conn.State <> ConnectionState.Closed Then
                    Conn.Close()
                End If

            End Try

        End If

        If txtId.Text <> Nothing Then

            Dim trans As SqlTransaction
            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If
            trans = Conn.BeginTransaction()

            With cmd
                .Transaction = trans
                .CommandText = "UPDATE tblVehicleIssuance SET IssueDate = @IssueDate, Remarks = @Remarks, EmployeeId = @EmployeeId, VehicleId = @VehicleId, RentPerDay = @RentPerDay, Shift = @Shift WHERE IssueId = @Original_IssueId"
                .Parameters.Clear()
                .Parameters.Add("@IssueDate", SqlDbType.Date).Value = dtpIssueDate.Value
                .Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = Trim(txtRemarks.Text)
                .Parameters.Add("@EmployeeId", SqlDbType.BigInt).Value = cboDriver.SelectedValue
                .Parameters.Add("@VehicleId", SqlDbType.BigInt).Value = cboVehicle.SelectedValue
                .Parameters.Add("@RentPerDay", SqlDbType.Decimal).Value = txtRentPerDay.Text
                .Parameters.Add("@Shift", SqlDbType.NVarChar).Value = cboShift.SelectedItem
                .Parameters.Add("@Original_IssueId", SqlDbType.BigInt).Value = Val(txtId.Text)
                .ExecuteNonQuery()
            End With

            'Creat Checking Variables

            Dim blnStopCheck As Boolean = False
            Dim blnFound As Boolean = False


            '------ Start INSERT, UPDATE, DELETE Attachments ------'
            If dgvAttachments.Rows.Count = 0 Then
                Dim cmdDelete As New SqlCommand
                Dim qryDelete As String
                qryDelete = "DELETE FROM tblVehicleIssuanceAttachments WHERE IssueId = " & Val(txtId.Text)
                With cmdDelete
                    .Transaction = trans
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = qryDelete

                End With
                cmdDelete.ExecuteNonQuery()
            End If

            'Start Check From DB


            Dim daExistingVehicles As New SqlDataAdapter
            Dim dtExistingVehicles As New DataTable
            Dim cmdExistingVehicles As New SqlCommand
            With cmdExistingVehicles
                .Transaction = trans
                .Connection = Conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT AttachmentId FROM tblVehicleIssuanceAttachments WHERE IssueId =" & Val(txtId.Text)
            End With
            daExistingVehicles.SelectCommand = cmdExistingVehicles

            dtExistingVehicles.Clear()
            daExistingVehicles.Fill(dtExistingVehicles)
            For Each ExistingVehiclerow As DataRow In dtExistingVehicles.Rows
                blnStopCheck = False
                blnFound = False
                Dim ExistingSaleDetailId As Long = ExistingVehiclerow.Item(0).ToString


                For i As Integer = 0 To dgvAttachments.Rows.Count - 1
                    If blnStopCheck = False Then


                        If ExistingSaleDetailId = Val(dgvAttachments.Rows(i).Cells("AttachmentId").Value) Then
                            blnStopCheck = True
                            blnFound = True

                        Else
                            blnStopCheck = False
                            blnFound = False


                        End If
                    End If
                    If i = dgvAttachments.Rows.Count - 1 Then
                        If blnFound = False Then

                            Dim cmdDeleteVehicle As New SqlCommand
                            Dim qryDeleteVehicle As String
                            qryDeleteVehicle = "DELETE FROM tblVehicleIssuanceAttachments WHERE AttachmentId = " & ExistingSaleDetailId
                            With cmdDeleteVehicle
                                .Transaction = trans
                                .Connection = Conn
                                .CommandType = CommandType.Text
                                .CommandText = qryDeleteVehicle

                            End With
                            cmdDeleteVehicle.ExecuteNonQuery()

                        End If
                    End If

                Next


            Next

            'End Check From DB


            For i = 0 To dgvAttachments.Rows.Count - 1

                If Val(dgvAttachments.Rows(i).Cells("AttachmentId").Value) > 0 Then
                    With cmd
                        .CommandText = "UPDATE tblVehicleIssuanceAttachments SET AttachmentName = @AttachmentName, AttachmentImage = @AttachmentImage WHERE AttachmentId = @AttachmentId"
                        .Parameters.Clear()
                        .Parameters.Add("@AttachmentName", SqlDbType.NVarChar).Value = dgvAttachments.Rows(i).Cells("AttachmentName").Value
                        .Parameters.Add("@AttachmentImage", SqlDbType.Image).Value = dgvAttachments.Rows(i).Cells("AttachmentImage").Value
                        .Parameters.Add("@AttachmentId", SqlDbType.BigInt).Value = dgvAttachments.Rows(i).Cells("AttachmentId").Value
                        .ExecuteNonQuery()
                    End With
                End If

                If Val(dgvAttachments.Rows(i).Cells("AttachmentId").Value) < 1 Then
                    With cmd
                        .CommandText = "INSERT INTO tblVehicleIssuanceAttachments (IssueId, AttachmentName, AttachmentImage) VALUES (@IssueId, @AttachmentName, @AttachmentImage)"
                        .Parameters.Clear()
                        .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = Val(txtId.Text)
                        .Parameters.Add("@AttachmentName", SqlDbType.NVarChar).Value = dgvAttachments.Rows(i).Cells("AttachmentName").Value
                        .Parameters.Add("@AttachmentImage", SqlDbType.Image).Value = dgvAttachments.Rows(i).Cells("AttachmentImage").Value

                        .ExecuteNonQuery()
                    End With
                End If


            Next

            trans.Commit()
            MsgBox("Updated Successfully")
            SetFormStateNew()

        End If




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
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnSave_Click(Me, Nothing)

        End If
        If e.KeyCode = Keys.F5 Then
            btnRefresh_Click(Me, Nothing)

        End If
        If e.KeyCode = Keys.Delete Then
            btnDelete_Click(Me, Nothing)
        End If
    End Sub


    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged
        FillDetail()
        FillAttachments()
    End Sub
    Sub FillDetail()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT dbo.tblVehicleIssuance.IssueId, dbo.tblVehicleIssuance.IssueDate, dbo.tblVehicleIssuance.CloseDate, dbo.tblVehicleIssuance.EmployeeId, dbo.tblVehicleIssuance.VehicleId, dbo.tblVehicleIssuance.Remarks, dbo.tblVehicles.VehicleNumber, dbo.tblVehicleIssuance.RentPerDay, dbo.tblVehicleIssuance.Shift, dbo.tblVehicleIssuance.EnteredBy, dbo.tblVehicleIssuance.SysTimeStamp FROM dbo.tblVehicleIssuance INNER JOIN dbo.tblVehicles ON dbo.tblVehicleIssuance.VehicleId = dbo.tblVehicles.VehicleId WHERE (dbo.tblVehicleIssuance.IssueId = @IssueId)"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = Val(txtId.Text)
        End With

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            'Dim dtVehicle As New DataTable

            'dtVehicle = cboVehicle.DataSource

            'Dim row As DataRow = dtVehicle.NewRow

            'row(0) = dt.Rows(0).Item("VehicleId")
            'row(1) = dt.Rows(0).Item("VehicleNumber")

            'dtVehicle.Rows.InsertAt(row, 1)

            'cboVehicle.DataSource = dtVehicle

            dtpIssueDate.Text = dt.Rows(0).Item("IssueDate").ToString
            cboDriver.SelectedValue = dt.Rows(0).Item("EmployeeId")
            cboVehicle.SelectedValue = dt.Rows(0).Item("VehicleId")
            txtRemarks.Text = dt.Rows(0).Item("Remarks")
            txtRentPerDay.Text = dt.Rows(0).Item("RentPerDay")
            cboShift.SelectedItem = dt.Rows(0).Item("Shift")

            OldDriverId = dt.Rows(0).Item("EmployeeId")
            OldVehicleId = dt.Rows(0).Item("VehicleId")
            OldShift = dt.Rows(0).Item("Shift")

        Else
            ClearMasterFields()


        End If
    End Sub
    Sub FillAttachments()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT AttachmentId, IssueId, AttachmentName, AttachmentImage FROM dbo.tblVehicleIssuanceAttachments WHERE (IssueId = @IssueId)"
            .Parameters.Clear()
            .Parameters.Add("@IssueId", SqlDbType.BigInt).Value = Val(txtId.Text)
        End With
        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            dgvAttachments.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dgvAttachments.Rows.Add(row.Item("AttachmentId"), row.Item("AttachmentName"), row.Item("AttachmentImage"))

            Next
            ClearDetailFieldsAttachment()
        Else

            dgvAttachments.Rows.Clear()
        End If

        dgvAttachments.ClearSelection()
    End Sub
    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        If dgvList.RowCount > 0 Then
            txtId.Text = dgvList.CurrentRow.Cells("IssueId").Value


            If SplitContainer.Panel2Collapsed = True Then
                ShowDetailPanel()
            End If
        End If

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

    Private Sub btnAddDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDriver.Click
        Dim frm As New frmEmployees
        frm.ShowDialog()
        FillCboDriver()

    End Sub
    Private Sub btnAddVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVehicle.Click
        Dim frm As New frmVehicles
        frm.ShowDialog()
        FillCboVehicle()

    End Sub


    Private Sub dtpRegistrationDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpIssueDate.KeyDown
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
            txtRentPerDay.Focus()
        End If
    End Sub
    Private Sub txtRentPerDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRentPerDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cboShift.Focus()
        End If
    End Sub

    Private Sub cboShift_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtRemarks.Focus()
        End If
    End Sub
    Private Sub txtRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown
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





    

    Private Sub btnAddAttachment_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAttachment.Click
        If chkIsDefaultImageAttachment.Checked = True Then
            MsgBox("Please Select some Image")
            Exit Sub
        End If

        If txtDetailAttachmentName.Text.Trim.Length < 1 Then
            MsgBox("Please Enter Description")
            Exit Sub

        End If

        If chkIsDefaultImageAttachment.Checked = False Then


        End If
        Dim ms As New System.IO.MemoryStream()
        AttachmentPicture.Image.Save(ms, AttachmentPicture.Image.RawFormat)
        Dim img As Byte()
        img = ms.ToArray()

        If txtDetailAttachmentRowIndex.Text = Nothing Then
            dgvAttachments.Rows.Add("", txtDetailAttachmentName.Text, img)

        Else
            For Each row As DataGridViewRow In dgvAttachments.Rows
                If row.Index = txtDetailAttachmentRowIndex.Text Then
                    row.Cells("AttachmentName").Value = txtDetailAttachmentName.Text
                    row.Cells("AttachmentImage").Value = img
                End If

            Next

        End If

        ClearDetailFieldsAttachment()
    End Sub

    Private Sub btnLoadPictureAttachment_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadPictureAttachment.Click
        LoadPicture("Attachment")
    End Sub
    Sub LoadPicture(Source As String)

        OpenFileDialog1.DefaultExt = "JPG"
        OpenFileDialog1.Filter = "Images (*.JPG;*.JPEG;*.PNG;*.GIF; *.BMP) | *.jpg;*.jpeg;*.PNG;*.gif;*.BMP; |JPG Images (*.jpg;*.jpeg;) | *.jpg;*.jpeg; |PNG Images (*.PNG) | *.PNG; |GIF Images (*,gif) | *.gif; |BMP Images (*.BMP) | *.BMP; "

        'Dim ms As New MemoryStream
        'ProductPicture.Image.Save(ms, ProductPicture.Image.RawFormat)
        'ms.ToArray()



        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Source = "Profile" Then
                'ProfilePicture.Image.Dispose()
                'ProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)


                'chkIsDefaultImage.Checked = False
                'chkIsSameImage.Checked = False

            ElseIf Source = "Attachment" Then
                AttachmentPicture.Image.Dispose()
                AttachmentPicture.Image = Image.FromFile(OpenFileDialog1.FileName)

                chkIsDefaultImageAttachment.Checked = False

            End If
        End If
    End Sub

    Private Sub AttachmentPicture_Click(sender As System.Object, e As System.EventArgs) Handles AttachmentPicture.Click
        If chkIsDefaultImageAttachment.Checked = True Then
            LoadPicture("Attachment")
            Exit Sub
        End If

        ZoomImage("Attachment")
    End Sub
    Sub ZoomImage(Source As String)
        Dim frm As New frmImageViewer
        If Source = "Profile" Then
            'frm.KpImageViewer1.Image = ProfilePicture.Image
        ElseIf Source = "Attachment" Then
            frm.KpImageViewer1.Image = AttachmentPicture.Image
        ElseIf Source = "AttachmentDetail" Then

            Dim imgData As Byte()
            imgData = CType(dgvAttachments.CurrentRow.Cells("AttachmentImage").Value, Byte())
            Dim ms As New System.IO.MemoryStream(imgData)
            frm.KpImageViewer1.Image = Image.FromStream(ms)


        End If

        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()
    End Sub

    Private Sub dgvAttachments_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAttachments.CellContentClick

        Dim colName As String = dgvAttachments.Columns(e.ColumnIndex).Name
        If dgvAttachments.Rows.Count > 0 Then

            If colName = "DeleteAttachment" Then

                If dgvAttachments.CurrentRow.IsNewRow = False Then

                    dgvAttachments.Rows.Remove(dgvAttachments.CurrentRow)
                End If



            End If

            If colName = "ViewAttachment" Then

                If dgvAttachments.CurrentRow.IsNewRow = False Then

                    ZoomImage("AttachmentDetail")
                End If



            End If

            If colName = "EditAttachment" Then
                If dgvAttachments.CurrentRow.IsNewRow = False Then
                    FillAttachmentDetail()
                End If
            End If
        End If
    End Sub
    Sub FillAttachmentDetail()




        If dgvAttachments.Rows.Count > 0 Then
            With dgvAttachments.CurrentRow
                txtDetailAttachmentRowIndex.Text = .Index
                txtDetailAttachmentName.Text = .Cells("AttachmentName").Value
                chkIsDefaultImageAttachment.Checked = False
                Dim imgData As Byte()
                imgData = CType(dgvAttachments.CurrentRow.Cells("AttachmentImage").Value, Byte())
                Dim ms As New System.IO.MemoryStream(imgData)
                AttachmentPicture.Image = Image.FromStream(ms)

            End With

        End If
    End Sub
    Private Sub dgvAttachments_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAttachments.CellDoubleClick
        FillAttachmentDetail()

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

        CloseConnection()

        dgvDriverActivity.Rows.Clear()

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                dgvDriverActivity.Rows.Add(row.Item("IssueId"), row.Item("IssueDate"), row.Item("VehicleNumber"), row.Item("Shift"))
            Next
        End If
        dgvDriverActivity.ClearSelection()
    End Sub

    
    Private Sub cboVehicle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboVehicle.SelectedIndexChanged
        'Dim Availability As String = Nothing

        'Availability = cboVehicle.ListBox.Grid.Model(cboVehicle.SelectedIndex + 1, 3).CellValue.ToString
        'FillCboAvailableShift(Availability)

        'MsgBox(Availability)

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

End Class