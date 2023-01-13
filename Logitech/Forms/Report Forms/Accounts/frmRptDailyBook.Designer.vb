<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDailyBook
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccCode = New System.Windows.Forms.TextBox()
        Me.btnSearchAcc = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClosingBalance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOpeningBalance = New System.Windows.Forms.TextBox()
        Me.bgwReporter = New System.ComponentModel.BackgroundWorker()
        Me.dgvReceipts = New System.Windows.Forms.DataGridView()
        Me.dgvReceiptsVoucherId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReceiptsAccCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReceiptsAccName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReceiptsAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalReceipts = New System.Windows.Forms.TextBox()
        Me.txtTotalPayments = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.dgvPaymentsVoucherId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPaymentsAccCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPaymentsAccName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPaymentsAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkAccountSpecific = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(431, 47)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(115, 40)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "Detail [Enter]"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = Global.Logitech.My.Resources.Resources.Close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(431, 95)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close [Esc]"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Day Book"
        '
        'txtAccCode
        '
        Me.txtAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAccCode.Location = New System.Drawing.Point(89, 15)
        Me.txtAccCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccCode.Name = "txtAccCode"
        Me.txtAccCode.Size = New System.Drawing.Size(204, 22)
        Me.txtAccCode.TabIndex = 12
        '
        'btnSearchAcc
        '
        Me.btnSearchAcc.Location = New System.Drawing.Point(301, 12)
        Me.btnSearchAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchAcc.Name = "btnSearchAcc"
        Me.btnSearchAcc.Size = New System.Drawing.Size(96, 28)
        Me.btnSearchAcc.TabIndex = 13
        Me.btnSearchAcc.TabStop = False
        Me.btnSearchAcc.Text = "Search (F1)"
        Me.btnSearchAcc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Account No"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtAccName)
        Me.Panel1.Controls.Add(Me.dtpDateTo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpDateFrom)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnSearchAcc)
        Me.Panel1.Controls.Add(Me.txtClosingBalance)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAccCode)
        Me.Panel1.Controls.Add(Me.txtOpeningBalance)
        Me.Panel1.Location = New System.Drawing.Point(13, 47)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 140)
        Me.Panel1.TabIndex = 17
        '
        'txtAccName
        '
        Me.txtAccName.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccName.Location = New System.Drawing.Point(7, 51)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.ReadOnly = True
        Me.txtAccName.Size = New System.Drawing.Size(390, 22)
        Me.txtAccName.TabIndex = 20
        Me.txtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(277, 112)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(121, 22)
        Me.dtpDateTo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Date To"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(90, 114)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(114, 22)
        Me.dtpDateFrom.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(218, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Closing"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date From"
        '
        'txtClosingBalance
        '
        Me.txtClosingBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtClosingBalance.Location = New System.Drawing.Point(278, 79)
        Me.txtClosingBalance.Name = "txtClosingBalance"
        Me.txtClosingBalance.ReadOnly = True
        Me.txtClosingBalance.Size = New System.Drawing.Size(120, 22)
        Me.txtClosingBalance.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Opening"
        '
        'txtOpeningBalance
        '
        Me.txtOpeningBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpeningBalance.Location = New System.Drawing.Point(71, 79)
        Me.txtOpeningBalance.Name = "txtOpeningBalance"
        Me.txtOpeningBalance.ReadOnly = True
        Me.txtOpeningBalance.Size = New System.Drawing.Size(120, 22)
        Me.txtOpeningBalance.TabIndex = 20
        '
        'bgwReporter
        '
        '
        'dgvReceipts
        '
        Me.dgvReceipts.AllowUserToAddRows = False
        Me.dgvReceipts.AllowUserToDeleteRows = False
        Me.dgvReceipts.AllowUserToResizeRows = False
        Me.dgvReceipts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvReceipts.BackgroundColor = System.Drawing.Color.SeaGreen
        Me.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReceipts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvReceiptsVoucherId, Me.dgvReceiptsAccCode, Me.dgvReceiptsAccName, Me.dgvReceiptsAmount})
        Me.dgvReceipts.Location = New System.Drawing.Point(13, 273)
        Me.dgvReceipts.Name = "dgvReceipts"
        Me.dgvReceipts.ReadOnly = True
        Me.dgvReceipts.RowHeadersVisible = False
        Me.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReceipts.Size = New System.Drawing.Size(580, 300)
        Me.dgvReceipts.TabIndex = 18
        '
        'dgvReceiptsVoucherId
        '
        Me.dgvReceiptsVoucherId.HeaderText = "Vr Id"
        Me.dgvReceiptsVoucherId.Name = "dgvReceiptsVoucherId"
        Me.dgvReceiptsVoucherId.ReadOnly = True
        Me.dgvReceiptsVoucherId.Width = 120
        '
        'dgvReceiptsAccCode
        '
        Me.dgvReceiptsAccCode.HeaderText = "AccCode"
        Me.dgvReceiptsAccCode.Name = "dgvReceiptsAccCode"
        Me.dgvReceiptsAccCode.ReadOnly = True
        Me.dgvReceiptsAccCode.Width = 120
        '
        'dgvReceiptsAccName
        '
        Me.dgvReceiptsAccName.HeaderText = "Account"
        Me.dgvReceiptsAccName.Name = "dgvReceiptsAccName"
        Me.dgvReceiptsAccName.ReadOnly = True
        Me.dgvReceiptsAccName.Width = 200
        '
        'dgvReceiptsAmount
        '
        Me.dgvReceiptsAmount.HeaderText = "Amount"
        Me.dgvReceiptsAmount.Name = "dgvReceiptsAmount"
        Me.dgvReceiptsAmount.ReadOnly = True
        Me.dgvReceiptsAmount.Width = 120
        '
        'txtTotalReceipts
        '
        Me.txtTotalReceipts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalReceipts.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalReceipts.Location = New System.Drawing.Point(443, 579)
        Me.txtTotalReceipts.Name = "txtTotalReceipts"
        Me.txtTotalReceipts.ReadOnly = True
        Me.txtTotalReceipts.Size = New System.Drawing.Size(150, 22)
        Me.txtTotalReceipts.TabIndex = 21
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPayments.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalPayments.Location = New System.Drawing.Point(1029, 576)
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.ReadOnly = True
        Me.txtTotalPayments.Size = New System.Drawing.Size(150, 22)
        Me.txtTotalPayments.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 582)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Receipts"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(920, 579)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Total Payments"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline)
        Me.Label9.Location = New System.Drawing.Point(8, 245)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Receipts"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline)
        Me.Label10.Location = New System.Drawing.Point(594, 245)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Payments"
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.AllowUserToResizeRows = False
        Me.dgvPayments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvPayments.BackgroundColor = System.Drawing.Color.Firebrick
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPaymentsVoucherId, Me.dgvPaymentsAccCode, Me.dgvPaymentsAccName, Me.dgvPaymentsAmount})
        Me.dgvPayments.Location = New System.Drawing.Point(599, 273)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayments.Size = New System.Drawing.Size(580, 300)
        Me.dgvPayments.TabIndex = 28
        '
        'dgvPaymentsVoucherId
        '
        Me.dgvPaymentsVoucherId.HeaderText = "Vr Id"
        Me.dgvPaymentsVoucherId.Name = "dgvPaymentsVoucherId"
        Me.dgvPaymentsVoucherId.ReadOnly = True
        Me.dgvPaymentsVoucherId.Width = 120
        '
        'dgvPaymentsAccCode
        '
        Me.dgvPaymentsAccCode.HeaderText = "AccCode"
        Me.dgvPaymentsAccCode.Name = "dgvPaymentsAccCode"
        Me.dgvPaymentsAccCode.ReadOnly = True
        Me.dgvPaymentsAccCode.Width = 120
        '
        'dgvPaymentsAccName
        '
        Me.dgvPaymentsAccName.HeaderText = "Account"
        Me.dgvPaymentsAccName.Name = "dgvPaymentsAccName"
        Me.dgvPaymentsAccName.ReadOnly = True
        Me.dgvPaymentsAccName.Width = 200
        '
        'dgvPaymentsAmount
        '
        Me.dgvPaymentsAmount.HeaderText = "Amount"
        Me.dgvPaymentsAmount.Name = "dgvPaymentsAmount"
        Me.dgvPaymentsAmount.ReadOnly = True
        Me.dgvPaymentsAmount.Width = 120
        '
        'chkAccountSpecific
        '
        Me.chkAccountSpecific.AutoSize = True
        Me.chkAccountSpecific.Location = New System.Drawing.Point(431, 147)
        Me.chkAccountSpecific.Name = "chkAccountSpecific"
        Me.chkAccountSpecific.Size = New System.Drawing.Size(126, 20)
        Me.chkAccountSpecific.TabIndex = 29
        Me.chkAccountSpecific.Text = "Account Specific"
        Me.chkAccountSpecific.UseVisualStyleBackColor = True
        '
        'frmRptDailyBook
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1206, 629)
        Me.Controls.Add(Me.chkAccountSpecific)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalPayments)
        Me.Controls.Add(Me.txtTotalReceipts)
        Me.Controls.Add(Me.dgvReceipts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRptDailyBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Day Book"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvReceipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchAcc As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bgwReporter As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvReceipts As System.Windows.Forms.DataGridView
    Friend WithEvents txtOpeningBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalReceipts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtClosingBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvPayments As System.Windows.Forms.DataGridView
    Friend WithEvents dgvReceiptsVoucherId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvReceiptsAccCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvReceiptsAccName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvReceiptsAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPaymentsVoucherId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPaymentsAccCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPaymentsAccName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPaymentsAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkAccountSpecific As System.Windows.Forms.CheckBox
End Class
