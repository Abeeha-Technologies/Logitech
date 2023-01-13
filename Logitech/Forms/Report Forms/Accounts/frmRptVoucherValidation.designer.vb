<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptVoucherValidation
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
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bgwReporter = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboVoucherType = New System.Windows.Forms.ComboBox()
        Me.rdbParticularVoucherType = New System.Windows.Forms.RadioButton()
        Me.rdbAllVoucherType = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbTransactionDate = New System.Windows.Forms.RadioButton()
        Me.rdbEntryDate = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.Image = Global.Logitech.My.Resources.Resources.Detail
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(192, 173)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(123, 40)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "Preview [Enter]"
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
        Me.btnClose.Location = New System.Drawing.Point(323, 173)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 40)
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
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Voucher Validation"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(279, 15)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(121, 22)
        Me.dtpDateTo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Date To"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(92, 17)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(114, 22)
        Me.dtpDateFrom.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date From"
        '
        'bgwReporter
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboVoucherType)
        Me.GroupBox1.Controls.Add(Me.rdbParticularVoucherType)
        Me.GroupBox1.Controls.Add(Me.rdbAllVoucherType)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 79)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'cboVoucherType
        '
        Me.cboVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVoucherType.FormattingEnabled = True
        Me.cboVoucherType.Location = New System.Drawing.Point(279, 44)
        Me.cboVoucherType.Name = "cboVoucherType"
        Me.cboVoucherType.Size = New System.Drawing.Size(121, 24)
        Me.cboVoucherType.TabIndex = 21
        '
        'rdbParticularVoucherType
        '
        Me.rdbParticularVoucherType.AutoSize = True
        Me.rdbParticularVoucherType.Location = New System.Drawing.Point(103, 46)
        Me.rdbParticularVoucherType.Name = "rdbParticularVoucherType"
        Me.rdbParticularVoucherType.Size = New System.Drawing.Size(139, 17)
        Me.rdbParticularVoucherType.TabIndex = 20
        Me.rdbParticularVoucherType.TabStop = True
        Me.rdbParticularVoucherType.Text = "Particular Voucher Type"
        Me.rdbParticularVoucherType.UseVisualStyleBackColor = True
        '
        'rdbAllVoucherType
        '
        Me.rdbAllVoucherType.AutoSize = True
        Me.rdbAllVoucherType.Location = New System.Drawing.Point(10, 46)
        Me.rdbAllVoucherType.Name = "rdbAllVoucherType"
        Me.rdbAllVoucherType.Size = New System.Drawing.Size(68, 17)
        Me.rdbAllVoucherType.TabIndex = 2
        Me.rdbAllVoucherType.TabStop = True
        Me.rdbAllVoucherType.Text = "All Types"
        Me.rdbAllVoucherType.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbTransactionDate)
        Me.GroupBox2.Controls.Add(Me.rdbEntryDate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 48)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'rdbTransactionDate
        '
        Me.rdbTransactionDate.AutoSize = True
        Me.rdbTransactionDate.Location = New System.Drawing.Point(10, 17)
        Me.rdbTransactionDate.Name = "rdbTransactionDate"
        Me.rdbTransactionDate.Size = New System.Drawing.Size(129, 20)
        Me.rdbTransactionDate.TabIndex = 1
        Me.rdbTransactionDate.TabStop = True
        Me.rdbTransactionDate.Text = "Transaction Date"
        Me.rdbTransactionDate.UseVisualStyleBackColor = True
        '
        'rdbEntryDate
        '
        Me.rdbEntryDate.AutoSize = True
        Me.rdbEntryDate.Location = New System.Drawing.Point(145, 17)
        Me.rdbEntryDate.Name = "rdbEntryDate"
        Me.rdbEntryDate.Size = New System.Drawing.Size(88, 20)
        Me.rdbEntryDate.TabIndex = 0
        Me.rdbEntryDate.TabStop = True
        Me.rdbEntryDate.Text = "Entry Date"
        Me.rdbEntryDate.UseVisualStyleBackColor = True
        '
        'frmRptVoucherValidation
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 226)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRptVoucherValidation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Validation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bgwReporter As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbParticularVoucherType As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAllVoucherType As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTransactionDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEntryDate As System.Windows.Forms.RadioButton
    Friend WithEvents cboVoucherType As System.Windows.Forms.ComboBox
End Class
