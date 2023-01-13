<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cRptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'cRptViewer
        '
        Me.cRptViewer.ActiveViewIndex = -1
        Me.cRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cRptViewer.CachedPageNumberPerDoc = 10
        Me.cRptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cRptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cRptViewer.Location = New System.Drawing.Point(0, 0)
        Me.cRptViewer.Name = "cRptViewer"
        Me.cRptViewer.ShowGroupTreeButton = False
        Me.cRptViewer.ShowLogo = False
        Me.cRptViewer.ShowParameterPanelButton = False
        Me.cRptViewer.Size = New System.Drawing.Size(711, 470)
        Me.cRptViewer.TabIndex = 0
        Me.cRptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRptViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 470)
        Me.Controls.Add(Me.cRptViewer)
        Me.KeyPreview = True
        Me.Name = "frmRptViewer"
        Me.Text = "Report:"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cRptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
