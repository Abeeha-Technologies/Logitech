<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DoubleTextBox1 = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.TabbedMDIManager1 = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager(Me.components)
        CType(Me.DoubleTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'DoubleTextBox1
        '
        Me.DoubleTextBox1.DoubleValue = 1.0R
        Me.DoubleTextBox1.Location = New System.Drawing.Point(8, 8)
        Me.DoubleTextBox1.Name = "DoubleTextBox1"
        Me.DoubleTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DoubleTextBox1.TabIndex = 1
        Me.DoubleTextBox1.Text = "1.00"
        '
        'TabbedMDIManager1
        '
        Me.TabbedMDIManager1.AttachedTo = Me
        Me.TabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White
        Me.TabbedMDIManager1.CloseButtonToolTip = ""
        Me.TabbedMDIManager1.DropDownButtonToolTip = ""
        Me.TabbedMDIManager1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabbedMDIManager1.NeedUpdateHostedForm = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DoubleTextBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DoubleTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DoubleTextBox1 As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents TabbedMDIManager1 As Syncfusion.Windows.Forms.Tools.TabbedMDIManager
End Class
