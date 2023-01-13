Imports System.Data.SqlClient
Module mdlFunctions
    Function GetNewAccCode(ParentAccCode As String) As String
        GetNewAccCode = "001"
        Dim tblName As String = "tblAccChartOfAccounts"
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim qryStr As New System.Text.StringBuilder


        qryStr.Append("SELECT MAX(CONVERT(INT, SUBSTRING(AccCode,3,LEN(AccCode)))) AS AccCode FROM " & tblName & " WHERE ParentAccCode = @ParentAccCode")


        With cmd
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = qryStr.ToString
            .Parameters.Clear()
            .Parameters.Add("@ParentAccCode", SqlDbType.NVarChar).Value = ParentAccCode

        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            GetNewAccCode = (Val(dt.Rows(0).Item(0).ToString()) + 1).ToString("000")

        Else
            GetNewAccCode = "001"
        End If
    End Function
End Module
