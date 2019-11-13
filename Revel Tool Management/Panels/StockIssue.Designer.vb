<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockIssue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockIssue))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdOutSearch = New System.Windows.Forms.Button()
        Me.dtpOutEnds = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpOutStart = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbOutSearch = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgvOut = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updateby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOutEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colOutDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gbOut = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.tbOutRemark = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbOutHow2Buy = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpOutEvent = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdOutCancel = New System.Windows.Forms.Button()
        Me.tbOutQty = New System.Windows.Forms.TextBox()
        Me.cmdOutSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbOutProduct = New System.Windows.Forms.ComboBox()
        Me.cmdFindProductOut = New System.Windows.Forms.Button()
        Me.cmdFindSuppliersOut = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOut.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdOutSearch)
        Me.GroupBox3.Controls.Add(Me.dtpOutEnds)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpOutStart)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.tbOutSearch)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 186)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1308, 52)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'cmdOutSearch
        '
        Me.cmdOutSearch.BackgroundImage = CType(resources.GetObject("cmdOutSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdOutSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdOutSearch.Location = New System.Drawing.Point(1201, 16)
        Me.cmdOutSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOutSearch.Name = "cmdOutSearch"
        Me.cmdOutSearch.Size = New System.Drawing.Size(32, 30)
        Me.cmdOutSearch.TabIndex = 24
        Me.cmdOutSearch.UseVisualStyleBackColor = True
        '
        'dtpOutEnds
        '
        Me.dtpOutEnds.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpOutEnds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOutEnds.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutEnds.Location = New System.Drawing.Point(989, 18)
        Me.dtpOutEnds.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpOutEnds.Name = "dtpOutEnds"
        Me.dtpOutEnds.Size = New System.Drawing.Size(199, 19)
        Me.dtpOutEnds.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(931, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "To date :"
        '
        'dtpOutStart
        '
        Me.dtpOutStart.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpOutStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOutStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutStart.Location = New System.Drawing.Point(717, 20)
        Me.dtpOutStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpOutStart.Name = "dtpOutStart"
        Me.dtpOutStart.Size = New System.Drawing.Size(199, 19)
        Me.dtpOutStart.TabIndex = 28
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(649, 23)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "From date :"
        '
        'tbOutSearch
        '
        Me.tbOutSearch.Location = New System.Drawing.Point(93, 20)
        Me.tbOutSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.tbOutSearch.Name = "tbOutSearch"
        Me.tbOutSearch.Size = New System.Drawing.Size(547, 19)
        Me.tbOutSearch.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 23)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Product code :"
        '
        'dgvOut
        '
        Me.dgvOut.AllowUserToAddRows = False
        Me.dgvOut.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvOut.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOut.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.suppliers_name, Me.updateby, Me.stock_remark, Me.Column7, Me.stock_price, Me.amount, Me.colOutEdit, Me.colOutDel})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOut.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvOut.GridColor = System.Drawing.Color.White
        Me.dgvOut.Location = New System.Drawing.Point(13, 244)
        Me.dgvOut.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvOut.Name = "dgvOut"
        Me.dgvOut.ReadOnly = True
        Me.dgvOut.RowTemplate.Height = 30
        Me.dgvOut.Size = New System.Drawing.Size(1319, 275)
        Me.dgvOut.TabIndex = 9
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "event_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Issued date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "products_code"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'suppliers_name
        '
        Me.suppliers_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.suppliers_name.DataPropertyName = "suppliers_name"
        Me.suppliers_name.HeaderText = "Supplier"
        Me.suppliers_name.Name = "suppliers_name"
        Me.suppliers_name.ReadOnly = True
        '
        'updateby
        '
        Me.updateby.DataPropertyName = "updateby"
        Me.updateby.HeaderText = "User"
        Me.updateby.Name = "updateby"
        Me.updateby.ReadOnly = True
        Me.updateby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'stock_remark
        '
        Me.stock_remark.DataPropertyName = "stock_remark"
        Me.stock_remark.HeaderText = "Remark"
        Me.stock_remark.Name = "stock_remark"
        Me.stock_remark.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "stock_qty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column7.HeaderText = "Issued Qty."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'stock_price
        '
        Me.stock_price.DataPropertyName = "stock_price"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.stock_price.DefaultCellStyle = DataGridViewCellStyle4
        Me.stock_price.HeaderText = "AVG. Cost"
        Me.stock_price.Name = "stock_price"
        Me.stock_price.ReadOnly = True
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'colOutEdit
        '
        Me.colOutEdit.HeaderText = ""
        Me.colOutEdit.Name = "colOutEdit"
        Me.colOutEdit.ReadOnly = True
        Me.colOutEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colOutEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colOutEdit.Text = "Edit"
        Me.colOutEdit.UseColumnTextForButtonValue = True
        Me.colOutEdit.Visible = False
        Me.colOutEdit.Width = 40
        '
        'colOutDel
        '
        Me.colOutDel.HeaderText = ""
        Me.colOutDel.Name = "colOutDel"
        Me.colOutDel.ReadOnly = True
        Me.colOutDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colOutDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colOutDel.Text = "Del."
        Me.colOutDel.UseColumnTextForButtonValue = True
        Me.colOutDel.Width = 40
        '
        'gbOut
        '
        Me.gbOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOut.Controls.Add(Me.Label10)
        Me.gbOut.Controls.Add(Me.txtEmployee)
        Me.gbOut.Controls.Add(Me.Label4)
        Me.gbOut.Controls.Add(Me.lblBalance)
        Me.gbOut.Controls.Add(Me.lblLocation)
        Me.gbOut.Controls.Add(Me.tbOutRemark)
        Me.gbOut.Controls.Add(Me.Label24)
        Me.gbOut.Controls.Add(Me.Label20)
        Me.gbOut.Controls.Add(Me.cbOutHow2Buy)
        Me.gbOut.Controls.Add(Me.Label13)
        Me.gbOut.Controls.Add(Me.dtpOutEvent)
        Me.gbOut.Controls.Add(Me.Label17)
        Me.gbOut.Controls.Add(Me.cmdOutCancel)
        Me.gbOut.Controls.Add(Me.tbOutQty)
        Me.gbOut.Controls.Add(Me.cmdOutSave)
        Me.gbOut.Controls.Add(Me.Label7)
        Me.gbOut.Controls.Add(Me.Label8)
        Me.gbOut.Controls.Add(Me.cbOutProduct)
        Me.gbOut.Controls.Add(Me.cmdFindProductOut)
        Me.gbOut.Controls.Add(Me.cmdFindSuppliersOut)
        Me.gbOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gbOut.Location = New System.Drawing.Point(13, 23)
        Me.gbOut.Margin = New System.Windows.Forms.Padding(4)
        Me.gbOut.Name = "gbOut"
        Me.gbOut.Padding = New System.Windows.Forms.Padding(4)
        Me.gbOut.Size = New System.Drawing.Size(1308, 155)
        Me.gbOut.TabIndex = 10
        Me.gbOut.TabStop = False
        Me.gbOut.Text = "Stock Issue"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(166, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "On hand Qty : "
        '
        'txtEmployee
        '
        Me.txtEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(93, 125)
        Me.txtEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.Size = New System.Drawing.Size(233, 19)
        Me.txtEmployee.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(50, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "User :"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(248, 82)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(10, 13)
        Me.lblBalance.TabIndex = 45
        Me.lblBalance.Text = "-"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLocation.Location = New System.Drawing.Point(672, 106)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblLocation.TabIndex = 44
        '
        'tbOutRemark
        '
        Me.tbOutRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbOutRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOutRemark.Location = New System.Drawing.Point(830, 82)
        Me.tbOutRemark.Margin = New System.Windows.Forms.Padding(4)
        Me.tbOutRemark.Multiline = True
        Me.tbOutRemark.Name = "tbOutRemark"
        Me.tbOutRemark.Size = New System.Drawing.Size(252, 46)
        Me.tbOutRemark.TabIndex = 43
        Me.tbOutRemark.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(763, 98)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Remark :"
        Me.Label24.Visible = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(762, 38)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Supplier :"
        '
        'cbOutHow2Buy
        '
        Me.cbOutHow2Buy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutHow2Buy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbOutHow2Buy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbOutHow2Buy.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutHow2Buy.FormattingEnabled = True
        Me.cbOutHow2Buy.Location = New System.Drawing.Point(821, 35)
        Me.cbOutHow2Buy.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOutHow2Buy.Name = "cbOutHow2Buy"
        Me.cbOutHow2Buy.Size = New System.Drawing.Size(425, 21)
        Me.cbOutHow2Buy.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(599, 78)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Location :"
        '
        'dtpOutEvent
        '
        Me.dtpOutEvent.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpOutEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOutEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutEvent.Location = New System.Drawing.Point(399, 76)
        Me.dtpOutEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpOutEvent.Name = "dtpOutEvent"
        Me.dtpOutEvent.Size = New System.Drawing.Size(176, 20)
        Me.dtpOutEvent.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(323, 82)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Issued date :"
        '
        'cmdOutCancel
        '
        Me.cmdOutCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOutCancel.BackColor = System.Drawing.Color.Gold
        Me.cmdOutCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOutCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOutCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmdOutCancel.Location = New System.Drawing.Point(1090, 91)
        Me.cmdOutCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOutCancel.Name = "cmdOutCancel"
        Me.cmdOutCancel.Size = New System.Drawing.Size(99, 28)
        Me.cmdOutCancel.TabIndex = 10
        Me.cmdOutCancel.Text = "Cancel"
        Me.cmdOutCancel.UseVisualStyleBackColor = False
        '
        'tbOutQty
        '
        Me.tbOutQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOutQty.Location = New System.Drawing.Point(93, 76)
        Me.tbOutQty.Margin = New System.Windows.Forms.Padding(4)
        Me.tbOutQty.Name = "tbOutQty"
        Me.tbOutQty.Size = New System.Drawing.Size(66, 19)
        Me.tbOutQty.TabIndex = 10
        '
        'cmdOutSave
        '
        Me.cmdOutSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOutSave.BackColor = System.Drawing.Color.Gold
        Me.cmdOutSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOutSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOutSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmdOutSave.Location = New System.Drawing.Point(1197, 90)
        Me.cmdOutSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOutSave.Name = "cmdOutSave"
        Me.cmdOutSave.Size = New System.Drawing.Size(99, 28)
        Me.cmdOutSave.TabIndex = 9
        Me.cmdOutSave.Text = "Save"
        Me.cmdOutSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Product code :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(22, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Issued Qty :"
        '
        'cbOutProduct
        '
        Me.cbOutProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbOutProduct.BackColor = System.Drawing.Color.White
        Me.cbOutProduct.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbOutProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutProduct.ForeColor = System.Drawing.Color.Black
        Me.cbOutProduct.FormattingEnabled = True
        Me.cbOutProduct.Location = New System.Drawing.Point(93, 35)
        Me.cbOutProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOutProduct.Name = "cbOutProduct"
        Me.cbOutProduct.Size = New System.Drawing.Size(570, 21)
        Me.cbOutProduct.TabIndex = 9
        '
        'cmdFindProductOut
        '
        Me.cmdFindProductOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFindProductOut.BackgroundImage = CType(resources.GetObject("cmdFindProductOut.BackgroundImage"), System.Drawing.Image)
        Me.cmdFindProductOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindProductOut.Location = New System.Drawing.Point(671, 26)
        Me.cmdFindProductOut.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFindProductOut.Name = "cmdFindProductOut"
        Me.cmdFindProductOut.Size = New System.Drawing.Size(32, 30)
        Me.cmdFindProductOut.TabIndex = 32
        Me.cmdFindProductOut.UseVisualStyleBackColor = True
        '
        'cmdFindSuppliersOut
        '
        Me.cmdFindSuppliersOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFindSuppliersOut.BackgroundImage = CType(resources.GetObject("cmdFindSuppliersOut.BackgroundImage"), System.Drawing.Image)
        Me.cmdFindSuppliersOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindSuppliersOut.Location = New System.Drawing.Point(1254, 26)
        Me.cmdFindSuppliersOut.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFindSuppliersOut.Name = "cmdFindSuppliersOut"
        Me.cmdFindSuppliersOut.Size = New System.Drawing.Size(32, 30)
        Me.cmdFindSuppliersOut.TabIndex = 41
        Me.cmdFindSuppliersOut.UseVisualStyleBackColor = True
        '
        'StockIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 543)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvOut)
        Me.Controls.Add(Me.gbOut)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StockIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Issue"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOut.ResumeLayout(False)
        Me.gbOut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdOutSearch As Button
    Friend WithEvents dtpOutEnds As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpOutStart As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents tbOutSearch As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dgvOut As DataGridView
    Friend WithEvents gbOut As GroupBox
    Friend WithEvents tbOutRemark As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cbOutHow2Buy As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpOutEvent As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdOutCancel As Button
    Friend WithEvents tbOutQty As TextBox
    Friend WithEvents cmdOutSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbOutProduct As ComboBox
    Friend WithEvents cmdFindProductOut As Button
    Friend WithEvents cmdFindSuppliersOut As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents updateby As DataGridViewTextBoxColumn
    Friend WithEvents stock_remark As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents stock_price As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents colOutEdit As DataGridViewButtonColumn
    Friend WithEvents colOutDel As DataGridViewButtonColumn
End Class
