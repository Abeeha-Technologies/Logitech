<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherSearch
    Inherits System.Windows.Forms.Form
    Public Sub New(ByVal initialValue1 As String, ByVal InitialValue2 As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ValueFromParent1 = initialValue1
        ValueFromParent2 = InitialValue2

    End Sub
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboVoucherType = New System.Windows.Forms.ComboBox()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.txtParentValue1 = New System.Windows.Forms.TextBox()
        Me.txtParentValue2 = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.txtSearchText = New Logitech.TextBoxHint()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboVoucherType
        '
        Me.cboVoucherType.FormattingEnabled = True
        Me.cboVoucherType.Items.AddRange(New Object() {"", "JV", "CPV", "CRV", "BPV", "BRV"})
        Me.cboVoucherType.Location = New System.Drawing.Point(213, 12)
        Me.cboVoucherType.Name = "cboVoucherType"
        Me.cboVoucherType.Size = New System.Drawing.Size(124, 21)
        Me.cboVoucherType.TabIndex = 1
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccounts.BackgroundColor = System.Drawing.Color.White
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(12, 38)
        Me.dgvAccounts.MultiSelect = False
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.RowTemplate.Height = 20
        Me.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccounts.Size = New System.Drawing.Size(325, 391)
        Me.dgvAccounts.TabIndex = 2
        '
        'txtParentValue1
        '
        Me.txtParentValue1.Location = New System.Drawing.Point(343, 115)
        Me.txtParentValue1.Name = "txtParentValue1"
        Me.txtParentValue1.Size = New System.Drawing.Size(8, 20)
        Me.txtParentValue1.TabIndex = 3
        Me.txtParentValue1.TabStop = False
        Me.txtParentValue1.Visible = False
        '
        'txtParentValue2
        '
        Me.txtParentValue2.Location = New System.Drawing.Point(343, 141)
        Me.txtParentValue2.Name = "txtParentValue2"
        Me.txtParentValue2.Size = New System.Drawing.Size(8, 20)
        Me.txtParentValue2.TabIndex = 4
        Me.txtParentValue2.TabStop = False
        Me.txtParentValue2.Visible = False
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(251, 438)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(67, 20)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "Count: "
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearchText
        '
        Me.txtSearchText.HintDetails.HintText = "Type here to Search"
        Me.txtSearchText.Location = New System.Drawing.Point(12, 12)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(202, 20)
        Me.txtSearchText.TabIndex = 0
        '
        'frmVoucherSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 467)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtParentValue2)
        Me.Controls.Add(Me.txtParentValue1)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.cboVoucherType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmVoucherSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Voucher"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboVoucherType As System.Windows.Forms.ComboBox

    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParentAccNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtParentValue1 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentValue2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents txtSearchText As Logitech.TextBoxHint
End Class
