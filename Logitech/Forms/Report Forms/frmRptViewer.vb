Public Class frmRptViewer

    Private Sub frmRptViewer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cRptViewer_ClickPage(ByVal sender As System.Object, ByVal e As CrystalDecisions.Windows.Forms.PageMouseEventArgs) Handles cRptViewer.ClickPage
        If e.ObjectInfo.Name = "vouCode" Then
            'Dim frmToLoad As New formimageViewe
            'frmToLoad.LoadOrders(e.ObjectInfo.Text)
            'frmToLoad.Show()
        End If
    End Sub
End Class