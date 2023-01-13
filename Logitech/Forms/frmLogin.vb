Imports Microsoft.Win32
Imports System.Data.SqlClient

Public Class frmLogin

    Dim blnDrag As Boolean
    Dim MouseX, MouseY As Long
    Private intLogonAttempts As Integer
    Private AllowedAttempts As Integer = 3


    Private Sub frmLogin_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown, picLoginImage.MouseDown, lblTitle.MouseDown, lblSlogan.MouseDown, lblLiscencedToTitle.MouseDown, lblLiscencedToValue.MouseDown, lblLiscenceTypeTitle.MouseDown, lblLiscenceTypeValue.MouseDown, lblVersion.MouseDown, picLogo.MouseDown, Panel2.MouseDown, picLoginHeader.MouseDown, lblHeader.MouseDown
        blnDrag = True
        MouseX = System.Windows.Forms.Cursor.Position.X - Me.Left
        MouseY = System.Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub frmLogin_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove, picLoginImage.MouseMove, lblTitle.MouseMove, lblSlogan.MouseMove, lblLiscencedToTitle.MouseMove, lblLiscencedToValue.MouseMove, lblLiscenceTypeTitle.MouseMove, lblLiscenceTypeValue.MouseMove, lblVersion.MouseMove, picLogo.MouseMove, Panel2.MouseMove, picLoginHeader.MouseMove, lblHeader.MouseMove

        If blnDrag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - MouseY
            Me.Left = System.Windows.Forms.Cursor.Position.X - MouseX
        End If
    End Sub



    Private Sub frmLogin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, Panel1.MouseUp, picLoginImage.MouseUp, lblTitle.MouseUp, lblSlogan.MouseUp, lblLiscencedToTitle.MouseUp, lblLiscencedToValue.MouseUp, lblLiscenceTypeTitle.MouseUp, lblLiscenceTypeValue.MouseUp, lblVersion.MouseUp, picLogo.MouseUp, Panel2.MouseUp, picLoginHeader.MouseUp, lblHeader.MouseUp
        blnDrag = False
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub txtUserName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.Enter
        txtUserName.SelectAll()
        SetActivePanel(pnlUserName)
    End Sub
    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'SendKeys.Send("{tab}")
            If txtUserPassword.TextLength > 0 Then
                btnLogin.PerformClick()
            Else
                txtUserPassword.Focus()
            End If
        End If

    End Sub
    Private Sub txtUserPassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserPassword.Enter
        Me.txtUserPassword.SelectAll()
        SetActivePanel(pnlUserPassword)
    End Sub
    Private Sub txtUserPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'SendKeys.Send("{tab}")
            If txtUserName.TextLength > 0 Then
                btnLogin.PerformClick()
            Else
                txtUserName.Focus()
            End If

        End If
    End Sub
    Sub SetActivePanel(ByVal pnl As Panel)
        If pnl.Name = "pnlUserName" Then
            pnlUserName.BackColor = Color.White
            txtUserName.BackColor = Color.White
            pnlUserPassword.BackColor = SystemColors.Control
            txtUserPassword.BackColor = SystemColors.Control
        Else
            pnlUserPassword.BackColor = Color.White
            txtUserPassword.BackColor = Color.White
            pnlUserName.BackColor = SystemColors.Control
            txtUserName.BackColor = SystemColors.Control


        End If
    End Sub


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Start Registry Key Coding

        Dim regKey As RegistryKey

        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Abeeha Technologies\AdvanceERP", True)

        If regKey Is Nothing Then

            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
            regKey.CreateSubKey("Abeeha Technologies\AdvanceERP")
            'regKey.Close()

            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Abeeha Technologies\AdvanceERP", True)

            regKey.SetValue("DueDate", FirstTimeDateTo.ToString("dd-MM-yyyy"))
            regKey.SetValue("IsExpired", 0)
            regKey.Close()
        End If

        If Not regKey Is Nothing Then

            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Abeeha Technologies\AdvanceERP", True)
            DueDate = DateTime.ParseExact(regKey.GetValue("DueDate"), "dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)
            IsExpired = regKey.GetValue("IsExpired")
            regKey.Close()

        End If

        ' End Registry Key Coding

        AssignSystemVariables()

        If Len(vStartDate) = 0 Then
            UpdateSettingById(vStartDateId, Now.Date.ToString("dd-MM-yyyy"))
            AssignSystemVariables()
        End If

        StartDate = DateTime.ParseExact(vStartDate.ToString, "dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)

        If IsTrialVersion = False Then
            CheckComputerRegistration()
        Else
            lblLiscenceTypeValue.Text = TrialDays & " Days Trial"
            CheckTrialExpiry()
        End If


        If IsLiscenced = True Then
            CheckLiscence()
            lblLiscenceTypeValue.Text = "Liscenced till " & DueDate
        End If

        Dim dtUsers = SelectFunction("SELECT * FROM tblUsers")
        If dtUsers.Rows.Count < 1 Then
            ShowUserDialog("First", Nothing)
            txtUserName.Focus()
        Else

            txtUserName.Focus()
        End If

        Dim dtCompany = SelectFunction("SELECT * FROM tblCompany")
        If dtCompany.Rows.Count < 1 Then
            ShowSettingDialog("First", Nothing)
        End If

        AssignCompanyVariables()

        lblLiscencedToValue.Text = vCompanyName

        If IsExpired = False Then
            btnActivate.Visible = False
        Else
            btnActivate.Visible = True
        End If

    End Sub



    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If IsExpired = False Then
            Me.btnLogin.Enabled = False



            Dim user As String
            Dim pass As String
            user = Trim(Me.txtUserName.Text)
            pass = Trim(Me.txtUserPassword.Text)

            If String.IsNullOrEmpty(user) Then

                lblNote.Text = "Error: Please Enter Username"
                lblNote.ForeColor = Color.DarkRed
                Me.txtUserName.Focus()
                Me.btnLogin.Enabled = True
                Exit Sub
            ElseIf String.IsNullOrEmpty(pass) Then

                lblNote.Text = "Error: Please Enter Password"
                lblNote.ForeColor = Color.DarkRed
                Me.txtUserPassword.Focus()
                Me.btnLogin.Enabled = True
                Exit Sub
            End If

            Try

                Dim dtUsers = dtLogin(user, Encrypt(pass))

                If dtUsers.Rows.Count > 0 Then

                    If dtUsers.Rows(0).Item("Disabled") = True Then
                        MsgBox("User Disabled")
                        Exit Sub
                    End If

                    'Start Assign User Variables
                    AssignUserVariables(dtUsers.Rows(0).Item("UserId").ToString)
                    'End Assign User Variables



                    AssignSystemVariables()




                    frmMain.Show()

                    Me.Close()
                Else

                    Me.txtUserName.Focus()
                    Me.btnLogin.Enabled = True
                    intLogonAttempts += 1

                    If intLogonAttempts < AllowedAttempts Then
                        lblNote.Text = "Invalid username or password. " & AllowedAttempts - intLogonAttempts & " attempts left"

                    Else
                        MsgBox("It seems that you are not authorized to use this application or you have missed your " & AllowedAttempts & " chance." & vbCrLf & "Please contact your system administrator.", vbCritical, "Restricted Access!")
                        Application.Exit()
                    End If

                End If



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Me.btnLogin.Enabled = True


        End If
        
    End Sub

    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtUserPassword.UseSystemPasswordChar = False
        Else
            txtUserPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        Dim dt As New DataTable
        Dim connectionString As String = "workstation id=DataAdvanceERP.mssql.somee.com;packet size=4096;user id=omer4_AdvanceERP;pwd=Laptop123;data source=DataAdvanceERP.mssql.somee.com;persist security info=False;initial catalog=DataAdvanceERP"

        Dim RemoteConn As New SqlConnection(connectionString)

        With cmd
            .Connection = RemoteConn
            .CommandText = "SELECT * FROM tblCustomerProducts WHERE CustomerId = @CustomerId AND Product = @Product"
            .Parameters.Clear()
            .Parameters.Add("@CustomerId", SqlDbType.BigInt).Value = vCustomerId
            .Parameters.Add("@Product", SqlDbType.NVarChar).Value = vProduct
        End With
        da.SelectCommand = cmd
        If RemoteConn.State <> ConnectionState.Open Then
            RemoteConn.Open()
        End If
        dt.Clear()
        da.Fill(dt)

        If RemoteConn.State <> ConnectionState.Closed Then
            RemoteConn.Close()
        End If
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Token") = True Then
                Dim regKey As RegistryKey
                regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Abeeha Technologies\AdvanceERP", True)

                regKey.SetValue("DueDate", CDate(dt.Rows(0).Item("LicenseDueDate").ToString).ToString("dd-MM-yyyy"))
                regKey.SetValue("IsExpired", 0)
                regKey.Close()

                With cmd
                    .Connection = RemoteConn
                    .CommandText = "UPDATE tblCustomerProducts SET Token = 0 WHERE CustomerId = @CustomerId AND Product = @Product"
                    .Parameters.Clear()
                    .Parameters.Add("@CustomerId", SqlDbType.BigInt).Value = vCustomerId
                    .Parameters.Add("@Product", SqlDbType.NVarChar).Value = vProduct
                End With

                If RemoteConn.State <> ConnectionState.Open Then
                    RemoteConn.Open()
                End If

                cmd.ExecuteNonQuery()

                If RemoteConn.State <> ConnectionState.Closed Then
                    RemoteConn.Close()
                End If

                MsgBox("Activation Successful. Please Restart the software")
                Application.Restart()
            Else
                MsgBox("Please Contact your Service Provider with your Customer Id: " & vCustomerId.ToString & vbNewLine & "Error Code 0xToken")
            End If
        Else
            MsgBox("Please Contact your Service Provider with your Customer Id: " & vCustomerId.ToString & vbNewLine & "Error Code 0xRecord")
        End If
    End Sub

  
End Class
