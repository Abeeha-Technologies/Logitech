Module mdlShowDialogs
    Sub ShowSettingDialog(ByVal Value1 As String, ByVal Value2 As String)
        ' Get the value that the child will be initialised with
        Dim InitialValue1, InitialValue2 As String
        InitialValue1 = Nothing
        InitialValue2 = Nothing

        InitialValue1 = Value1
        InitialValue2 = Value2

        Dim childForm As frmSettings

        ' Create the child form.
        childForm = New frmSettings(InitialValue1, InitialValue2)

        'Show the child dialog.
        childForm.ShowDialog()
    End Sub

    Sub ShowUserDialog(ByVal Value1 As String, ByVal Value2 As String)
        ' Get the value that the child will be initialised with
        Dim InitialValue1, InitialValue2 As String
        InitialValue1 = Nothing
        InitialValue2 = Nothing

        InitialValue1 = Value1
        InitialValue2 = Value2

        Dim childForm As frmUsers

        ' Create the child form.
        childForm = New frmUsers(InitialValue1, InitialValue2)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub

    Sub ShowAccSearchDialog(ByVal Source As String)
        ' Get the value that the child will be initialised with
        Dim InitialValue1, InitialValue2 As String
        InitialValue1 = ""
        InitialValue2 = ""


        InitialValue1 = Source
        InitialValue2 = Nothing


        Dim childForm As frmAccountSearch

        'Create the child form.
        childForm = New frmAccountSearch(InitialValue1, InitialValue2)

        ' Show the child dialog.
        childForm.ShowDialog()
    End Sub
End Module
