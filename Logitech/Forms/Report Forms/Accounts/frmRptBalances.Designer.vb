<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptBalances
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
        Me.bgwReporterReceivables = New System.ComponentModel.BackgroundWorker()
        Me.bgwReportPayables = New System.ComponentModel.BackgroundWorker()
        Me.bgwReporterCashAndBank = New System.ComponentModel.BackgroundWorker()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnReceivables = New System.Windows.Forms.Button()
        Me.btnPayables = New System.Windows.Forms.Button()
        Me.btnCashAndBank = New System.Windows.Forms.Button()
        Me.btnPopup = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cRptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgwReporterReceivables
        '
        '
        'bgwReportPayables
        '
        '
        'bgwReporterCashAndBank
        '
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1046, 15)
        Me.Panel15.TabIndex = 28
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 15)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnReceivables)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPayables)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCashAndBank)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPopup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel1MinSize = 250
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.cRptViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(1046, 508)
        Me.SplitContainer1.SplitterDistance = 267
        Me.SplitContainer1.TabIndex = 29
        '
        'btnReceivables
        '
        Me.btnReceivables.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceivables.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnReceivables.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnReceivables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceivables.Location = New System.Drawing.Point(146, 127)
        Me.btnReceivables.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReceivables.Name = "btnReceivables"
        Me.btnReceivables.Size = New System.Drawing.Size(107, 40)
        Me.btnReceivables.TabIndex = 34
        Me.btnReceivables.Text = "Receivables"
        Me.btnReceivables.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReceivables.UseVisualStyleBackColor = True
        '
        'btnPayables
        '
        Me.btnPayables.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayables.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayables.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnPayables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayables.Location = New System.Drawing.Point(145, 175)
        Me.btnPayables.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPayables.Name = "btnPayables"
        Me.btnPayables.Size = New System.Drawing.Size(108, 40)
        Me.btnPayables.TabIndex = 33
        Me.btnPayables.Text = "Payables"
        Me.btnPayables.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayables.UseVisualStyleBackColor = True
        '
        'btnCashAndBank
        '
        Me.btnCashAndBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCashAndBank.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCashAndBank.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnCashAndBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashAndBank.Location = New System.Drawing.Point(16, 127)
        Me.btnCashAndBank.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCashAndBank.Name = "btnCashAndBank"
        Me.btnCashAndBank.Size = New System.Drawing.Size(113, 40)
        Me.btnCashAndBank.TabIndex = 32
        Me.btnCashAndBank.Text = "Cash && Bank"
        Me.btnCashAndBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCashAndBank.UseVisualStyleBackColor = True
        '
        'btnPopup
        '
        Me.btnPopup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPopup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPopup.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnPopup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPopup.Location = New System.Drawing.Point(176, 271)
        Me.btnPopup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPopup.Name = "btnPopup"
        Me.btnPopup.Size = New System.Drawing.Size(77, 27)
        Me.btnPopup.TabIndex = 31
        Me.btnPopup.Text = "Popup"
        Me.btnPopup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPopup.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Date To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Filter"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(90, 87)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(163, 20)
        Me.dtpDateTo.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Receivable / Payable / Cash && Bank Balances List"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = Global.Logitech.My.Resources.Resources.Close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(145, 223)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close [Esc]"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cRptViewer
        '
        Me.cRptViewer.ActiveViewIndex = -1
        Me.cRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cRptViewer.CachedPageNumberPerDoc = 10
        Me.cRptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cRptViewer.Location = New System.Drawing.Point(0, 0)
        Me.cRptViewer.Name = "cRptViewer"
        Me.cRptViewer.ShowGroupTreeButton = False
        Me.cRptViewer.ShowLogo = False
        Me.cRptViewer.ShowParameterPanelButton = False
        Me.cRptViewer.Size = New System.Drawing.Size(775, 508)
        Me.cRptViewer.TabIndex = 1
        Me.cRptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRptBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 523)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel15)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRptBalances"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receivable / Payable / Cash & Bank List"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgwReporterReceivables As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwReportPayables As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwReporterCashAndBank As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnReceivables As System.Windows.Forms.Button
    Friend WithEvents btnPayables As System.Windows.Forms.Button
    Friend WithEvents btnCashAndBank As System.Windows.Forms.Button
    Friend WithEvents btnPopup As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cRptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
