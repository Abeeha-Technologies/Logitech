<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageViewer
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
        Me.PanelDoubleBuffered1 = New KaiwaProjects.PanelDoubleBuffered()
        Me.KpImageViewer1 = New KaiwaProjects.KpImageViewer()
        Me.PanelDoubleBuffered1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDoubleBuffered1
        '
        Me.PanelDoubleBuffered1.Controls.Add(Me.KpImageViewer1)
        Me.PanelDoubleBuffered1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDoubleBuffered1.Location = New System.Drawing.Point(0, 0)
        Me.PanelDoubleBuffered1.Name = "PanelDoubleBuffered1"
        Me.PanelDoubleBuffered1.Size = New System.Drawing.Size(1063, 554)
        Me.PanelDoubleBuffered1.TabIndex = 1
        '
        'KpImageViewer1
        '
        Me.KpImageViewer1.AllowDrop = True
        Me.KpImageViewer1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.KpImageViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KpImageViewer1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KpImageViewer1.GifAnimation = False
        Me.KpImageViewer1.GifFPS = 15.0R
        Me.KpImageViewer1.Image = Nothing
        Me.KpImageViewer1.Location = New System.Drawing.Point(0, 0)
        Me.KpImageViewer1.MenuColor = System.Drawing.Color.LightSteelBlue
        Me.KpImageViewer1.MenuPanelColor = System.Drawing.Color.LightSteelBlue
        Me.KpImageViewer1.MinimumSize = New System.Drawing.Size(454, 157)
        Me.KpImageViewer1.Name = "KpImageViewer1"
        Me.KpImageViewer1.NavigationPanelColor = System.Drawing.Color.LightSteelBlue
        Me.KpImageViewer1.NavigationTextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KpImageViewer1.OpenButton = False
        Me.KpImageViewer1.PreviewButton = True
        Me.KpImageViewer1.PreviewPanelColor = System.Drawing.Color.LightSteelBlue
        Me.KpImageViewer1.PreviewText = "Preview"
        Me.KpImageViewer1.PreviewTextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KpImageViewer1.Rotation = 0
        Me.KpImageViewer1.Scrollbars = False
        Me.KpImageViewer1.ShowPreview = True
        Me.KpImageViewer1.Size = New System.Drawing.Size(1063, 554)
        Me.KpImageViewer1.TabIndex = 0
        Me.KpImageViewer1.TextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KpImageViewer1.Zoom = 100.0R
        '
        'frmImageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 554)
        Me.Controls.Add(Me.PanelDoubleBuffered1)
        Me.Name = "frmImageViewer"
        Me.Text = "Form1"
        Me.PanelDoubleBuffered1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KpImageViewer1 As KaiwaProjects.KpImageViewer
    Friend WithEvents PanelDoubleBuffered1 As KaiwaProjects.PanelDoubleBuffered
End Class
