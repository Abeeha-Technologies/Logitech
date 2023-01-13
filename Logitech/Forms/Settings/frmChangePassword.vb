Imports System.Data.SqlClient
Public Class frmChangePassword
    Private intLogonAttempts As Integer
    Private AllowedAttempts As Integer = 3
#Region "Subroutines & Functions"
    Sub FillData()
        txtUserName.Text = vUserName.ToString
    End Sub
    Sub SetFormStateNew()


        txtCurrentPassword.Text = Nothing
        txtNewPassword.Text = Nothing
        txtConfirmNewPassword.Text = Nothing
        txtCurrentPassword.Focus()

    End Sub

#End Region
    Private Sub frmRegion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        FillData()
        SetFormStateNew()
    End Sub

    Private Sub frmRegion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If

        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnSave_Click(Me, Nothing)

        End If

        If e.KeyCode = Keys.F5 Then
            btnRefresh_Click(Me, Nothing)

        End If
    End Sub

    Private Sub brnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtRegionName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCurrentPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNewPassword.Focus()
        End If
    End Sub

    Private Sub txtRegionNameUrdu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtConfirmNewPassword.Focus()
        End If
    End Sub




    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Trim(txtCurrentPassword.Text).Length < 1 Then
            MsgBox("Please Enter Current Password")
            txtCurrentPassword.Focus()
            Exit Sub
        End If
        If Trim(txtNewPassword.Text).Length < 1 Then
            MsgBox("Please Enter New Password")
            txtNewPassword.Focus()
            Exit Sub
        End If
        If Trim(txtConfirmNewPassword.Text).Length < 1 Then
            MsgBox("Please Enter Confirm New Password")
            txtConfirmNewPassword.Focus()
            Exit Sub
        End If
        If txtNewPassword.Text <> txtConfirmNewPassword.Text Then
            MsgBox("New Password does not match")
            txtNewPassword.Focus()
            Exit Sub
        End If
        Try




            Dim Result = dtLogin(Trim(txtUserName.Text), Encrypt(Trim(txtCurrentPassword.Text)))

            If Result.Rows.Count > 0 Then

                If Conn.State <> ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim cmd As New SqlCommand

                With cmd
                    .Connection = Conn
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE tblUsers SET UserPassword = @UserPassword WHERE (UserName = @UserName)"
                    .Parameters.Clear()
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtUserName.Text
                    .Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = Encrypt(txtNewPassword.Text)
                    .ExecuteNonQuery()
                End With

                MsgBox("Updated Successfully")
            Else
                MsgBox("Wrong Current Password")
                Me.txtCurrentPassword.Focus()

                intLogonAttempts += 1

                If intLogonAttempts < AllowedAttempts Then

                    Exit Sub
                Else
                    MsgBox("It seems that you are not authorized to use this application or you have missed your " & AllowedAttempts & " chance." & vbCrLf & "Please contact your system administrator.", vbCritical, "Restricted Access!")
                    Application.Exit()
                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If
        End Try


        SetFormStateNew()


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        SetFormStateNew()
    End Sub
End Class