<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptBalanceSheet
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
        Me.bgwReporter = New System.ComponentModel.BackgroundWorker()
        Me.bgwReportMonthly = New System.ComponentModel.BackgroundWorker()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkHideDetail = New System.Windows.Forms.CheckBox()
        Me.chkMonthly = New System.Windows.Forms.CheckBox()
        Me.btnPopup = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSearchAcc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkWithZeroBalance = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtAccCode = New System.Windows.Forms.MaskedTextBox()
        Me.cRptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgwReporter
        '
        '
        'bgwReportMonthly
        '
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(884, 15)
        Me.Panel15.TabIndex = 29
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkHideDetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkMonthly)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPopup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSearchAcc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAccName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkWithZeroBalance)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOk)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAccCode)
        Me.SplitContainer1.Panel1MinSize = 250
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.cRptViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(884, 596)
        Me.SplitContainer1.SplitterDistance = 267
        Me.SplitContainer1.TabIndex = 30
        '
        'chkHideDetail
        '
        Me.chkHideDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkHideDetail.Location = New System.Drawing.Point(63, 246)
        Me.chkHideDetail.Name = "chkHideDetail"
        Me.chkHideDetail.Size = New System.Drawing.Size(190, 20)
        Me.chkHideDetail.TabIndex = 33
        Me.chkHideDetail.Text = "Hide Detail"
        Me.chkHideDetail.UseVisualStyleBackColor = True
        '
        'chkMonthly
        '
        Me.chkMonthly.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMonthly.Location = New System.Drawing.Point(63, 220)
        Me.chkMonthly.Name = "chkMonthly"
        Me.chkMonthly.Size = New System.Drawing.Size(190, 20)
        Me.chkMonthly.TabIndex = 32
        Me.chkMonthly.Text = "Show Monthly Figures"
        Me.chkMonthly.UseVisualStyleBackColor = True
        '
        'btnPopup
        '
        Me.btnPopup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPopup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPopup.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnPopup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPopup.Location = New System.Drawing.Point(176, 369)
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
        Me.Label3.Location = New System.Drawing.Point(14, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Date To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Acc Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Date From"
        '
        'btnSearchAcc
        '
        Me.btnSearchAcc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAcc.BackgroundImage = Global.Logitech.My.Resources.Resources.Search
        Me.btnSearchAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearchAcc.Location = New System.Drawing.Point(234, 86)
        Me.btnSearchAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchAcc.Name = "btnSearchAcc"
        Me.btnSearchAcc.Size = New System.Drawing.Size(20, 18)
        Me.btnSearchAcc.TabIndex = 13
        Me.btnSearchAcc.TabStop = False
        Me.btnSearchAcc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 48)
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
        Me.dtpDateTo.Location = New System.Drawing.Point(90, 167)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(163, 20)
        Me.dtpDateTo.TabIndex = 19
        '
        'txtAccName
        '
        Me.txtAccName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccName.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAccName.Location = New System.Drawing.Point(17, 112)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.ReadOnly = True
        Me.txtAccName.Size = New System.Drawing.Size(238, 20)
        Me.txtAccName.TabIndex = 20
        Me.txtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Balance Sheet"
        '
        'chkWithZeroBalance
        '
        Me.chkWithZeroBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkWithZeroBalance.Location = New System.Drawing.Point(63, 194)
        Me.chkWithZeroBalance.Name = "chkWithZeroBalance"
        Me.chkWithZeroBalance.Size = New System.Drawing.Size(191, 20)
        Me.chkWithZeroBalance.TabIndex = 26
        Me.chkWithZeroBalance.Text = "Show All With Zero Balance"
        Me.chkWithZeroBalance.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(92, 273)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(162, 40)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "Generate Report [Enter]"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = Global.Logitech.My.Resources.Resources.Close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(153, 321)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close [Esc]"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(91, 141)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(163, 20)
        Me.dtpDateFrom.TabIndex = 17
        '
        'txtAccCode
        '
        Me.txtAccCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAccCode.Location = New System.Drawing.Point(92, 85)
        Me.txtAccCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccCode.Name = "txtAccCode"
        Me.txtAccCode.Size = New System.Drawing.Size(163, 20)
        Me.txtAccCode.TabIndex = 12
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
        Me.cRptViewer.Size = New System.Drawing.Size(613, 596)
        Me.cRptViewer.TabIndex = 1
        Me.cRptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRptBalanceSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel15)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRptBalanceSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Sheet"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgwReporter As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwReportMonthly As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chkHideDetail As System.Windows.Forms.CheckBox
    Friend WithEvents chkMonthly As System.Windows.Forms.CheckBox
    Friend WithEvents btnPopup As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnSearchAcc As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkWithZeroBalance As System.Windows.Forms.CheckBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAccCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cRptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
