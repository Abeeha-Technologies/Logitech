Public Class frmPasswordInput
#Region "Subroutines & Functions"
    Sub FillData()
        txtUserName.Text = vUserName.ToString
    End Sub
    Sub SetFormStateNew()

        txtCurrentPassword.Text = Nothing
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

        If e.KeyCode = Keys.Enter Then
            btnSave_Click(Me, Nothing)

        End If
    End Sub

    Private Sub brnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetFormStateNew()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        Try

            Dim Result = dtLogin(Trim(txtUserName.Text), Encrypt(Trim(txtCurrentPassword.Text)))


            If Result.Rows.Count > 0 Then
                DialogResult = vbYes

            Else
                MsgBox("Wrong Password", vbOKOnly + vbInformation, "Error")
                DialogResult = vbNo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try





    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class