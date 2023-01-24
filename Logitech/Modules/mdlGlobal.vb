Imports System.Data.SqlClient
Imports System.Management
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

'Omer comment
Imports System.Net.NetworkInformation

Module mdlGlobal
#Region "Variables"

#Region "Application Variables"

    Public vCustomerId As Long = 10
    Public vProduct As String = "LogiTech"

    Public DueDate As Date
    Public IsExpired As Boolean

    Public StartDate As Date

    'Trial Variables
    Public IsTrialVersion As Boolean = False
    Public TrialDays As Integer = 2
    Dim TrialIntimationDays As Integer = 2


    'Valid Till Variable
    Public IsLiscenced As Boolean = True
    Public FirstTimeDateTo As Date = DateTime.ParseExact("14-12-2023", "dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)
    Dim LiscenceIntimationDays As Integer = 10

    'Connection Variable
    Public Conn As New SqlClient.SqlConnection(My.Settings.DataConn)


#End Region

#Region "System Setting Variables"


    Public vStartDateId As Integer = 0
    Public vStartDate As String = ""                      'Software first Run Date

    Public vAccountingId As Integer = 0
    Public vAccounting As String = ""


#End Region

#Region "User Variables"


    Public vUserName As String


    Public vBackDateEntryDays As Integer
    Public vCanCreateUsers As Boolean
    Public vCanEditVouchers As Boolean
    Public vCanDeleteVoucher As Boolean
    Public vCanEnterAccountingVoucher As Boolean
    Public vCanEnterOperationalVoucher As Boolean
    Public vCanDefineOperations As Boolean
    Public vCanDefineAccounts As Boolean
    Public vCanSystemSettings As Boolean
    Public vCanViewIncomeStatementReport As Boolean
    Public vCanViewBalanceSheetReport As Boolean
    Public vCanViewTrialBalanceReport As Boolean
    Public vCanViewGeneralLedgerReport As Boolean
    Public vCanViewPurchaseReport As Boolean
    Public vCanViewSaleReport As Boolean
    Public vCanViewTradingReport As Boolean
    Public vCanEditApprovedVouchers As Boolean
    Public vCanApproveVouchers As Boolean
    Public vCanViewDashboard As Boolean

#End Region
#Region "Company Variables"
    Public vCompanyId As Long
    Public vCompanyName As String = ""
    Public vCompanyAddress1 As String = ""
    Public vCompanyAddress2 As String = ""
    Public vCompanyCity As String = ""
    Public vCompanyState As String = ""
    Public vCompanyCountry As String = ""
    Public vCompanyPostalCode As String = ""
    Public vCompanyMobile As String = ""
    Public vCompanyLandline As String = ""
    Public vCompanyFax As String = ""
    Public vCompanyEmail As String = ""
    Public vCompanyNTN As String = ""
    Public vCompanyGST As String = ""
    Public vCompanyWebsite As String = ""

#End Region

#Region "Company Preference Variables"
    Public vRequireUserPasswordForDelete As Boolean
    Public vAllowNegativeInventorySale As Boolean
    Public vAutoBackupEveryXDays As Integer
    Public vAutoBackupDirectory As String
    Public vLastAutoBackupDate As Date
    Public vAutoBackupOnClose As Boolean
    Public vDefaultCashAccCode As String
    Public vDefaultSaleAccCode As String

#End Region

#End Region

#Region "Sub and Functions"

#Region "Password Security"
    Public Function Encrypt(ByVal clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Function Decrypt(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
#End Region

    Function SelectFunction(ByVal qry) As DataTable


        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim qryStr As New System.Text.StringBuilder


        qryStr.Append(qry)

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = qryStr.ToString
            .Parameters.Clear()

        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        SelectFunction = dt

    End Function

    Sub AssignSystemVariables()

        Dim dtSettings As New DataTable
        dtSettings = SelectFunction("SELECT SettingId, SettingName, SettingValue, Remarks FROM tblSystemSettings")

        vStartDateId = dtSettings.Rows(0).Item("SettingId").ToString
        vStartDate = dtSettings.Rows(0).Item("SettingValue").ToString

        vAccountingId = dtSettings.Rows(1).Item("SettingId").ToString
        vAccounting = dtSettings.Rows(1).Item("SettingValue").ToString

    End Sub
    Sub AssignUserVariables(ByVal InputUserId As String)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT * FROM tblUsers WHERE UserId = @UserId"
            .Parameters.Clear()
            .Parameters.Add("@UserId", SqlDbType.BigInt).Value = InputUserId
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            vUserName = dt.Rows(0).Item("UserName").ToString

            vBackDateEntryDays = dt.Rows(0).Item("BackDateEntryDays").ToString
            vCanCreateUsers = dt.Rows(0).Item("CanCreateUsers").ToString
            vCanEditVouchers = dt.Rows(0).Item("CanEditVouchers").ToString
            vCanDeleteVoucher = dt.Rows(0).Item("CanDeleteVoucher").ToString
            vCanEnterAccountingVoucher = dt.Rows(0).Item("CanEnterAccountingVoucher").ToString
            vCanEnterOperationalVoucher = dt.Rows(0).Item("CanEnterOperationalVoucher").ToString
            vCanDefineOperations = dt.Rows(0).Item("CanDefineOperations").ToString
            vCanDefineAccounts = dt.Rows(0).Item("CanDefineAccounts").ToString
            vCanSystemSettings = dt.Rows(0).Item("CanSystemSettings").ToString
            vCanViewIncomeStatementReport = dt.Rows(0).Item("CanViewIncomeStatementReport").ToString
            vCanViewBalanceSheetReport = dt.Rows(0).Item("CanViewBalanceSheetReport").ToString
            vCanViewTrialBalanceReport = dt.Rows(0).Item("CanViewTrialBalanceReport").ToString
            vCanViewGeneralLedgerReport = dt.Rows(0).Item("CanViewGeneralLedgerReport").ToString
            vCanViewPurchaseReport = dt.Rows(0).Item("CanViewPurchaseReport").ToString
            vCanViewSaleReport = dt.Rows(0).Item("CanViewSaleReport").ToString
            vCanEditApprovedVouchers = dt.Rows(0).Item("CanEditApprovedVouchers").ToString
            vCanApproveVouchers = dt.Rows(0).Item("CanApproveVouchers").ToString
            vCanViewDashboard = dt.Rows(0).Item("CanViewDashBoard").ToString
        End If

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If
    End Sub


    Function dtLogin(ByVal UserName As String, ByVal UserPassword As String) As DataTable


        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim qryStr As New System.Text.StringBuilder


        qryStr.Append("SELECT * FROM tblUsers WHERE (UserName COLLATE Latin1_General_CS_AS = @UserName) AND (UserPassword COLLATE Latin1_General_CS_AS = @UserPassword)")

        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = qryStr.ToString
            .Parameters.Clear()
            .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName
            .Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = UserPassword

        End With

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        dtLogin = dt

        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If

    End Function

    Sub UpdateSettingById(ByVal SettingId As Long, ByVal SettingValue As String)
        Dim cmd As New SqlCommand
        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "UPDATE tblSystemSettings SET SettingValue = @SettingValue WHERE SettingId = @SettingId"
            .Parameters.Clear()
            .Parameters.Add("@SettingValue", SqlDbType.NVarChar).Value = SettingValue
            .Parameters.Add("@SettingId", SqlDbType.BigInt).Value = SettingId

        End With
        Try
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If
        End Try


    End Sub

    Sub AssignCompanyVariables()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT TOP (1) * FROM tblCompany"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)

        vCompanyId = dt.Rows(0).Item("CompanyId").ToString
        vCompanyName = dt.Rows(0).Item("Name").ToString
        vCompanyAddress1 = dt.Rows(0).Item("Address1").ToString
        vCompanyAddress2 = dt.Rows(0).Item("Address2").ToString
        vCompanyCity = dt.Rows(0).Item("City").ToString
        vCompanyState = dt.Rows(0).Item("State").ToString
        vCompanyCountry = dt.Rows(0).Item("Country").ToString
        vCompanyPostalCode = dt.Rows(0).Item("PostalCode").ToString
        vCompanyMobile = dt.Rows(0).Item("Mobile").ToString
        vCompanyLandline = dt.Rows(0).Item("LandLine").ToString
        vCompanyFax = dt.Rows(0).Item("Fax").ToString
        vCompanyEmail = dt.Rows(0).Item("Email").ToString
        vCompanyWebsite = dt.Rows(0).Item("Website").ToString
        vCompanyNTN = dt.Rows(0).Item("NTN").ToString
        vCompanyGST = dt.Rows(0).Item("GST").ToString

        AssignCompanyPreferenceVariables()

    End Sub
    Sub AssignCompanyPreferenceVariables()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        With cmd
            .Connection = Conn
            .CommandText = "SELECT * FROM tblCompanyPreference WHERE CompanyId = @CompanyId"
            .Parameters.Clear()
            .Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = vCompanyId
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            vRequireUserPasswordForDelete = dt.Rows(0).Item("RequireUserPasswordForDelete")
            vAutoBackupEveryXDays = dt.Rows(0).Item("AutoBackupEveryXDays")
            vAutoBackupDirectory = dt.Rows(0).Item("AutoBackupDirectory").ToString
            vLastAutoBackupDate = dt.Rows(0).Item("LastAutoBackupDate").ToString
            vAutoBackupOnClose = dt.Rows(0).Item("AutoBackupOnClose")
            vDefaultCashAccCode = dt.Rows(0).Item("DefaultCashAccCode").ToString
            vDefaultSaleAccCode = dt.Rows(0).Item("DefaultSaleAccCode").ToString

        End If
    End Sub

    
#End Region

#Region "Key Press Handler"
    Public Sub KeyPressNumeric(ByVal e As KeyPressEventArgs, ByVal txt As TextBox)

        'If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = "." Then
        '    e.Handled = True
        'End If
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txt.Text.IndexOf(".") > 0) Then
            e.Handled = True
        End If
    End Sub
    Public Sub KeyPressContactNumber(ByVal e As KeyPressEventArgs, ByVal txt As TextBox)

        'If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = "." Then
        '    e.Handled = True
        'End If
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txt.Text.IndexOf(".") > 0) Then
            e.Handled = True
        End If
    End Sub
    Public Sub KeyNumericPress(ByVal e As KeyPressEventArgs, ByVal txt As MaskedTextBox)

        'If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = "." Then
        '    e.Handled = True
        'End If
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txt.Text.IndexOf(".") > 0) Then
            e.Handled = True
        End If
    End Sub
    Public Sub KeyNumericPressMaskedTextbox(ByVal e As KeyPressEventArgs, ByVal txt As MaskedTextBox)

        'If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = "." Then
        '    e.Handled = True
        'End If
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txt.Text.IndexOf(".") > 0) Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Registration"
    Public Function GetUniqueID() As String
        Dim cpuInfo As String = String.Empty
        Dim mc As New ManagementClass("win32_processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim str As String
        For Each mo As ManagementObject In moc
            If cpuInfo = "" Then
                'Get only the first CPU's ID
                cpuInfo = mo.Properties("ProcessorId").Value.ToString()
                Exit For
            End If
        Next
        'Dim drive = "C"
        'Dim dsk As New ManagementObject("win32_logicaldisk.deviceid=""" + drive + ":""")
        'dsk.[Get]()
        'Dim volumeSerial As String = dsk("VolumeSerialNumber").ToString()
        Return cpuInfo.ToString
    End Function
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Public Sub CheckComputerRegistration()

        Dim regnum As String = GetUniqueID()

        ' BFEBFBFF000306A9 Omer
        ' BFEBFBFF00020655 Ehsan Markeint Officer
        ' BFEBFBFF000306D4 Ehsan
        ' BFEBFBFF000206A7 Himalaya


        Dim registeredMachines() As String = {"BFEBFBFF000306A9", "BFEBFBFF000206A7"}
        Dim isRegister As Boolean = False
        For Each item In registeredMachines
            If item = regnum Then
                isRegister = True
                Exit For
            End If
        Next


        If isRegister = True Then

        Else
            InputBox("This Machine is not registered. Please contact at 03057815275 , 03012786700." & vbNewLine & vbNewLine & "Please provide the following Id to Customer Support.", "Registration Failed", regnum)
            Application.Exit()


        End If

    End Sub


    Public Sub CheckTrialExpiry()
        If IsTrialVersion = True Then

            If My.Settings.IsExpired = True Then
                MsgBox("Your " & TrialDays & " Days Trial Version is Expired" & vbNewLine & "Please contact: 03012786700", vbCritical, "Error")
                Application.Exit()

            End If

            Dim ActiveDays As Integer
            ActiveDays = DateDiff(DateInterval.Day, StartDate, Now.Date)

            Dim RemainingDays As Integer

            RemainingDays = TrialDays - ActiveDays

            If RemainingDays < TrialIntimationDays And RemainingDays > 0 Then
                MsgBox("Reminder!" & vbNewLine & "Your " & TrialDays & " Days Trial Version will Expire after " & TrialDays - ActiveDays & " Day(s)." & vbNewLine & "Please contact: 03012786700", vbInformation, "Information")
            End If

            If RemainingDays = 0 And TrialIntimationDays > 0 Then
                MsgBox("Reminder!" & vbNewLine & "Your " & TrialDays & " Days Trial Version will Expire today." & vbNewLine & "Please contact: 03012786700", vbInformation, "Information")
            End If

            If ActiveDays < 0 Then
                MsgBox("Your " & TrialDays & " Days Trial Version is Expired" & vbNewLine & "Please contact: 03012786700", vbCritical, "Error")
                My.Settings.IsExpired = True
                My.Settings.Save()
                Application.Exit()
            End If
            If ActiveDays > TrialDays Then
                MsgBox("Your " & TrialDays & " Days Trial Version is Expired" & vbNewLine & "Please contact: 03012786700", vbCritical, "Error")
                My.Settings.IsExpired = True
                My.Settings.Save()
                Application.Exit()
            End If

        End If
    End Sub
    Public sub CheckLiscence()

        If IsLiscenced = True Then
            'If My.Settings.IsExpired = True Then
            If IsExpired = True Then

                MsgBox("Your Liscence till " & DueDate & " is Expired." & vbNewLine & "Please contact: 03012786700", vbCritical, "Error")
                frmLogin.lblNote.Text = "Your Liscence till " & DueDate & " is Expired. Please contact: 03012786700"
                frmLogin.btnLogin.Enabled = False
                frmLogin.btnLogin.BackColor = Color.Red
                frmLogin.btnLogin.Text = "Expired"
                'Application.Exit()
                Exit Sub
            End If

            Dim RemainingDays As Decimal
            RemainingDays = DateDiff(DateInterval.Day, Now.Date, DueDate)

            If RemainingDays < LiscenceIntimationDays And RemainingDays > 0 Then
                MsgBox("Your liscence will Expire after " & RemainingDays & " Day(s) on " & DueDate & "." & vbNewLine & "Please contact: 03012786700", vbInformation, "Information")
            End If
            If RemainingDays = 0 And LiscenceIntimationDays > 0 Then
                MsgBox("Your Liscence will Expire today." & vbNewLine & "Please contact: 03012786700", vbInformation, "Information")
            End If
            If RemainingDays < 0 Then
                MsgBox("Your Liscence till " & DueDate & " is Expired." & vbNewLine & "Please contact: 03012786700", vbCritical, "Error")
                'My.Settings.IsExpired = True
                'My.Settings.Save()

                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Abeeha Technologies\AdvanceERP", True)

                regKey.SetValue("IsExpired", 1)
                frmLogin.btnLogin.Enabled = False
                frmLogin.btnLogin.BackColor = Color.Red
                frmLogin.btnLogin.Text = "Expired"
                IsExpired = True
                'Application.Exit()
            End If

        End If
    End Sub

#End Region



    Sub OpenNewConnection()
        If Conn.State <> ConnectionState.Closed Then
            Conn.Close()
        End If

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
    End Sub

    Sub CloseConnection()

        If Conn.State <> ConnectionState.Open Then
            Conn.Open()
        End If
    End Sub
End Module
