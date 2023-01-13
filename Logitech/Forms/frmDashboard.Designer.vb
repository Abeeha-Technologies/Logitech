<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSale = New AdvanceERP.UI.RadiusPanel()
        Me.cboSale = New System.Windows.Forms.ComboBox()
        Me.ChartSale = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dtpDateToSale = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFromSale = New System.Windows.Forms.DateTimePicker()
        Me.lblSaleAmountDetail = New System.Windows.Forms.Label()
        Me.lblSalesAmount = New System.Windows.Forms.Label()
        Me.pnlSaleIcon = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlIdExpire = New AdvanceERP.UI.RadiusPanel()
        Me.dgvIdExpire = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlPassportExpiry = New AdvanceERP.UI.RadiusPanel()
        Me.dgvPassportExpire = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvCashBankBalances = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FlowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlVehicleExpriy = New AdvanceERP.UI.RadiusPanel()
        Me.dgvVehicleExpire = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSale.SuspendLayout()
        CType(Me.ChartSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlIdExpire.SuspendLayout()
        CType(Me.dgvIdExpire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPassportExpiry.SuspendLayout()
        CType(Me.dgvPassportExpire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCashBankBalances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVehicleExpriy.SuspendLayout()
        CType(Me.dgvVehicleExpire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSale
        '
        Me.pnlSale.AutoSize = True
        Me.pnlSale.BackColor = System.Drawing.Color.White
        Me.pnlSale.BorderColor = System.Drawing.Color.White
        Me.pnlSale.BorderFocusColor = System.Drawing.Color.White
        Me.pnlSale.BorderRadius = 7
        Me.pnlSale.BorderSize = 1
        Me.pnlSale.Controls.Add(Me.cboSale)
        Me.pnlSale.Controls.Add(Me.ChartSale)
        Me.pnlSale.Controls.Add(Me.dtpDateToSale)
        Me.pnlSale.Controls.Add(Me.dtpDateFromSale)
        Me.pnlSale.Controls.Add(Me.lblSaleAmountDetail)
        Me.pnlSale.Controls.Add(Me.lblSalesAmount)
        Me.pnlSale.Controls.Add(Me.pnlSaleIcon)
        Me.pnlSale.Controls.Add(Me.Label1)
        Me.pnlSale.Controls.Add(Me.ShapeContainer1)
        Me.pnlSale.Location = New System.Drawing.Point(25, 25)
        Me.pnlSale.Name = "pnlSale"
        Me.pnlSale.Size = New System.Drawing.Size(718, 250)
        Me.pnlSale.TabIndex = 1
        Me.pnlSale.UnderlinedStyle = False
        '
        'cboSale
        '
        Me.cboSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSale.FormattingEnabled = True
        Me.cboSale.Items.AddRange(New Object() {"Last 7 Days", "This Month", "Last Month"})
        Me.cboSale.Location = New System.Drawing.Point(563, 10)
        Me.cboSale.Name = "cboSale"
        Me.cboSale.Size = New System.Drawing.Size(121, 29)
        Me.cboSale.TabIndex = 13
        Me.cboSale.TabStop = False
        '
        'ChartSale
        '
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.Name = "ChartArea1"
        Me.ChartSale.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.ChartSale.Legends.Add(Legend1)
        Me.ChartSale.Location = New System.Drawing.Point(216, 67)
        Me.ChartSale.Name = "ChartSale"
        Me.ChartSale.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.EmptyPointStyle.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series1.YValuesPerPoint = 2
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.ChartSale.Series.Add(Series1)
        Me.ChartSale.Size = New System.Drawing.Size(480, 170)
        Me.ChartSale.TabIndex = 10
        Me.ChartSale.Text = "Chart1"
        '
        'dtpDateToSale
        '
        Me.dtpDateToSale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateToSale.Location = New System.Drawing.Point(326, 15)
        Me.dtpDateToSale.Name = "dtpDateToSale"
        Me.dtpDateToSale.Size = New System.Drawing.Size(106, 20)
        Me.dtpDateToSale.TabIndex = 9
        Me.dtpDateToSale.Visible = False
        '
        'dtpDateFromSale
        '
        Me.dtpDateFromSale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFromSale.Location = New System.Drawing.Point(214, 15)
        Me.dtpDateFromSale.Name = "dtpDateFromSale"
        Me.dtpDateFromSale.Size = New System.Drawing.Size(106, 20)
        Me.dtpDateFromSale.TabIndex = 8
        Me.dtpDateFromSale.Visible = False
        '
        'lblSaleAmountDetail
        '
        Me.lblSaleAmountDetail.BackColor = System.Drawing.Color.White
        Me.lblSaleAmountDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaleAmountDetail.ForeColor = System.Drawing.Color.Silver
        Me.lblSaleAmountDetail.Location = New System.Drawing.Point(18, 122)
        Me.lblSaleAmountDetail.Name = "lblSaleAmountDetail"
        Me.lblSaleAmountDetail.Size = New System.Drawing.Size(182, 82)
        Me.lblSaleAmountDetail.TabIndex = 4
        Me.lblSaleAmountDetail.Text = "Total Sale (Aug)"
        '
        'lblSalesAmount
        '
        Me.lblSalesAmount.AutoSize = True
        Me.lblSalesAmount.BackColor = System.Drawing.Color.White
        Me.lblSalesAmount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSalesAmount.Location = New System.Drawing.Point(16, 85)
        Me.lblSalesAmount.Name = "lblSalesAmount"
        Me.lblSalesAmount.Size = New System.Drawing.Size(112, 32)
        Me.lblSalesAmount.TabIndex = 2
        Me.lblSalesAmount.Text = "Rs 2,000"
        '
        'pnlSaleIcon
        '
        Me.pnlSaleIcon.BackColor = System.Drawing.Color.White
        Me.pnlSaleIcon.BackgroundImage = Global.Logitech.My.Resources.Resources.Dashboard_Sale_22px
        Me.pnlSaleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSaleIcon.Location = New System.Drawing.Point(16, 15)
        Me.pnlSaleIcon.Name = "pnlSaleIcon"
        Me.pnlSaleIcon.Size = New System.Drawing.Size(22, 22)
        Me.pnlSaleIcon.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(45, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(718, 250)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 210
        Me.LineShape1.X2 = 210
        Me.LineShape1.Y1 = 50
        Me.LineShape1.Y2 = 235
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Logitech.My.Resources.Resources.bg
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlSale)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlIdExpire)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlPassportExpiry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlVehicleExpriy)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvCashBankBalances)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1350, 847)
        Me.SplitContainer1.SplitterDistance = 1081
        Me.SplitContainer1.TabIndex = 4
        '
        'pnlIdExpire
        '
        Me.pnlIdExpire.BackColor = System.Drawing.Color.White
        Me.pnlIdExpire.BorderColor = System.Drawing.Color.White
        Me.pnlIdExpire.BorderFocusColor = System.Drawing.Color.White
        Me.pnlIdExpire.BorderRadius = 7
        Me.pnlIdExpire.BorderSize = 1
        Me.pnlIdExpire.Controls.Add(Me.dgvIdExpire)
        Me.pnlIdExpire.Controls.Add(Me.Label6)
        Me.pnlIdExpire.Location = New System.Drawing.Point(753, 25)
        Me.pnlIdExpire.Name = "pnlIdExpire"
        Me.pnlIdExpire.Size = New System.Drawing.Size(320, 250)
        Me.pnlIdExpire.TabIndex = 14
        Me.pnlIdExpire.UnderlinedStyle = False
        '
        'dgvIdExpire
        '
        Me.dgvIdExpire.AllowUserToAddRows = False
        Me.dgvIdExpire.AllowUserToDeleteRows = False
        Me.dgvIdExpire.AllowUserToResizeColumns = False
        Me.dgvIdExpire.AllowUserToResizeRows = False
        Me.dgvIdExpire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvIdExpire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvIdExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIdExpire.ColumnHeadersVisible = False
        Me.dgvIdExpire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIdExpire.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvIdExpire.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvIdExpire.GridColor = System.Drawing.Color.White
        Me.dgvIdExpire.Location = New System.Drawing.Point(0, 50)
        Me.dgvIdExpire.MultiSelect = False
        Me.dgvIdExpire.Name = "dgvIdExpire"
        Me.dgvIdExpire.ReadOnly = True
        Me.dgvIdExpire.RowHeadersVisible = False
        Me.dgvIdExpire.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvIdExpire.Size = New System.Drawing.Size(320, 200)
        Me.dgvIdExpire.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(41, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Id to be Expire in 15 Days"
        '
        'pnlPassportExpiry
        '
        Me.pnlPassportExpiry.BackColor = System.Drawing.Color.White
        Me.pnlPassportExpiry.BorderColor = System.Drawing.Color.White
        Me.pnlPassportExpiry.BorderFocusColor = System.Drawing.Color.White
        Me.pnlPassportExpiry.BorderRadius = 7
        Me.pnlPassportExpiry.BorderSize = 1
        Me.pnlPassportExpiry.Controls.Add(Me.dgvPassportExpire)
        Me.pnlPassportExpiry.Controls.Add(Me.Label4)
        Me.pnlPassportExpiry.Location = New System.Drawing.Point(25, 285)
        Me.pnlPassportExpiry.Name = "pnlPassportExpiry"
        Me.pnlPassportExpiry.Size = New System.Drawing.Size(320, 250)
        Me.pnlPassportExpiry.TabIndex = 13
        Me.pnlPassportExpiry.UnderlinedStyle = False
        '
        'dgvPassportExpire
        '
        Me.dgvPassportExpire.AllowUserToAddRows = False
        Me.dgvPassportExpire.AllowUserToDeleteRows = False
        Me.dgvPassportExpire.AllowUserToResizeRows = False
        Me.dgvPassportExpire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPassportExpire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPassportExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPassportExpire.ColumnHeadersVisible = False
        Me.dgvPassportExpire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartyName, Me.Amount})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPassportExpire.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPassportExpire.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvPassportExpire.GridColor = System.Drawing.Color.White
        Me.dgvPassportExpire.Location = New System.Drawing.Point(0, 50)
        Me.dgvPassportExpire.MultiSelect = False
        Me.dgvPassportExpire.Name = "dgvPassportExpire"
        Me.dgvPassportExpire.ReadOnly = True
        Me.dgvPassportExpire.RowHeadersVisible = False
        Me.dgvPassportExpire.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvPassportExpire.Size = New System.Drawing.Size(320, 200)
        Me.dgvPassportExpire.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(41, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Passsport Expiry in 15 Days"
        '
        'dgvCashBankBalances
        '
        Me.dgvCashBankBalances.AllowUserToAddRows = False
        Me.dgvCashBankBalances.AllowUserToDeleteRows = False
        Me.dgvCashBankBalances.AllowUserToResizeColumns = False
        Me.dgvCashBankBalances.AllowUserToResizeRows = False
        Me.dgvCashBankBalances.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCashBankBalances.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCashBankBalances.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCashBankBalances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCashBankBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCashBankBalances.ColumnHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Malgun Gothic", 12.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCashBankBalances.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCashBankBalances.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCashBankBalances.Location = New System.Drawing.Point(7, 52)
        Me.dgvCashBankBalances.MultiSelect = False
        Me.dgvCashBankBalances.Name = "dgvCashBankBalances"
        Me.dgvCashBankBalances.ReadOnly = True
        Me.dgvCashBankBalances.RowHeadersVisible = False
        Me.dgvCashBankBalances.RowTemplate.Height = 30
        Me.dgvCashBankBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCashBankBalances.Size = New System.Drawing.Size(246, 795)
        Me.dgvCashBankBalances.TabIndex = 3
        Me.dgvCashBankBalances.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(3, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Cash && Bank"
        '
        'FlowLayout1
        '
        Me.FlowLayout1.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.Near
        Me.FlowLayout1.ContainerControl = Me.SplitContainer1.Panel1
        Me.FlowLayout1.HGap = 10
        Me.FlowLayout1.HorzNearMargin = 25
        Me.FlowLayout1.TopMargin = 25
        Me.FlowLayout1.VGap = 10
        '
        'pnlVehicleExpriy
        '
        Me.pnlVehicleExpriy.BackColor = System.Drawing.Color.White
        Me.pnlVehicleExpriy.BorderColor = System.Drawing.Color.White
        Me.pnlVehicleExpriy.BorderFocusColor = System.Drawing.Color.White
        Me.pnlVehicleExpriy.BorderRadius = 7
        Me.pnlVehicleExpriy.BorderSize = 1
        Me.pnlVehicleExpriy.Controls.Add(Me.dgvVehicleExpire)
        Me.pnlVehicleExpriy.Controls.Add(Me.Label2)
        Me.pnlVehicleExpriy.Location = New System.Drawing.Point(355, 285)
        Me.pnlVehicleExpriy.Name = "pnlVehicleExpriy"
        Me.pnlVehicleExpriy.Size = New System.Drawing.Size(320, 250)
        Me.pnlVehicleExpriy.TabIndex = 15
        Me.pnlVehicleExpriy.UnderlinedStyle = False
        '
        'dgvVehicleExpire
        '
        Me.dgvVehicleExpire.AllowUserToAddRows = False
        Me.dgvVehicleExpire.AllowUserToDeleteRows = False
        Me.dgvVehicleExpire.AllowUserToResizeColumns = False
        Me.dgvVehicleExpire.AllowUserToResizeRows = False
        Me.dgvVehicleExpire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvVehicleExpire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVehicleExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicleExpire.ColumnHeadersVisible = False
        Me.dgvVehicleExpire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVehicleExpire.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvVehicleExpire.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvVehicleExpire.GridColor = System.Drawing.Color.White
        Me.dgvVehicleExpire.Location = New System.Drawing.Point(0, 50)
        Me.dgvVehicleExpire.MultiSelect = False
        Me.dgvVehicleExpire.Name = "dgvVehicleExpire"
        Me.dgvVehicleExpire.ReadOnly = True
        Me.dgvVehicleExpire.RowHeadersVisible = False
        Me.dgvVehicleExpire.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvVehicleExpire.Size = New System.Drawing.Size(320, 200)
        Me.dgvVehicleExpire.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(41, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vehicle Expiry in 15 Days"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "PartyName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "PartyName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'PartyName
        '
        Me.PartyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PartyName.DefaultCellStyle = DataGridViewCellStyle4
        Me.PartyName.HeaderText = "PartyName"
        Me.PartyName.Name = "PartyName"
        Me.PartyName.ReadOnly = True
        '
        'Amount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 120
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1350, 847)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "Dashboard"
        Me.Text = "Home"
        Me.pnlSale.ResumeLayout(False)
        Me.pnlSale.PerformLayout()
        CType(Me.ChartSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlIdExpire.ResumeLayout(False)
        Me.pnlIdExpire.PerformLayout()
        CType(Me.dgvIdExpire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPassportExpiry.ResumeLayout(False)
        Me.pnlPassportExpiry.PerformLayout()
        CType(Me.dgvPassportExpire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCashBankBalances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVehicleExpriy.ResumeLayout(False)
        Me.pnlVehicleExpriy.PerformLayout()
        CType(Me.dgvVehicleExpire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSale As New AdvanceERP.UI.RadiusPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlSaleIcon As System.Windows.Forms.Panel
    Friend WithEvents lblSaleAmountDetail As System.Windows.Forms.Label
    Friend WithEvents lblSalesAmount As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dtpDateToSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFromSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChartSale As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlPassportExpiry As AdvanceERP.UI.RadiusPanel
    Friend WithEvents dgvPassportExpire As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlIdExpire As AdvanceERP.UI.RadiusPanel
    Friend WithEvents dgvIdExpire As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvCashBankBalances As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FlowLayout1 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cboSale As System.Windows.Forms.ComboBox
    Friend WithEvents pnlVehicleExpriy As AdvanceERP.UI.RadiusPanel
    Friend WithEvents dgvVehicleExpire As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
