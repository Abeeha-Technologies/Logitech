Imports System.Data.SqlClient
Module mdlRecordLog

    Public Sub LogRecord(ByVal VoucherId As String, ByVal VoucherType As String, ByVal SessionUser As String, ByVal LogType As String, ByVal trans As SqlTransaction)

        Dim cmd As New SqlCommand

        With cmd
            .Transaction = trans
            .Connection = Conn
            .CommandText = "INSERT INTO tblRecordLog (VoucherId, VoucherType, LogType, SessionUser) VALUES (@VoucherId, @VoucherType, @LogType, @SessionUser)"
            .Parameters.Clear()
            .Parameters.Add("@VoucherId", SqlDbType.NVarChar).Value = VoucherId
            .Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherType
            .Parameters.Add("@LogType", SqlDbType.NVarChar).Value = LogType
            .Parameters.Add("@SessionUser", SqlDbType.NVarChar).Value = SessionUser
        End With

        Try

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

            cmd.ExecuteNonQuery()




        Catch ex As Exception

            MsgBox(ex.Message)

            If Conn.State <> ConnectionState.Closed Then
                Conn.Close()
            End If

        End Try


    End Sub
End Module
