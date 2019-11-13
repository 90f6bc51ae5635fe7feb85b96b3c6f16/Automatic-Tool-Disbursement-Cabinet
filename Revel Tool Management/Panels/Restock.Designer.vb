<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Restock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdINSearch = New System.Windows.Forms.Button()
        Me.dtpINEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpINStart = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbINSearch = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvDataIN = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbStockPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdFindSup = New System.Windows.Forms.Button()
        Me.cmdFindProduct = New System.Windows.Forms.Button()
        Me.tbRecieveRemark = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpEventIN = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdRecieveCancel = New System.Windows.Forms.Button()
        Me.cmdRecieveSave = New System.Windows.Forms.Button()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRecieveHow2Buy = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbRecieveProduct = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coldddd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colINview = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colINEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colINDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdINSearch)
        Me.GroupBox1.Controls.Add(Me.dtpINEnd)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpINStart)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.tbINSearch)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 213)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1317, 52)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search "
        '
        'cmdINSearch
        '
        Me.cmdINSearch.BackgroundImage = CType(resources.GetObject("cmdINSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdINSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdINSearch.Location = New System.Drawing.Point(1146, 13)
        Me.cmdINSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdINSearch.Name = "cmdINSearch"
        Me.cmdINSearch.Size = New System.Drawing.Size(32, 30)
        Me.cmdINSearch.TabIndex = 24
        Me.cmdINSearch.UseVisualStyleBackColor = True
        '
        'dtpINEnd
        '
        Me.dtpINEnd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpINEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpINEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpINEnd.Location = New System.Drawing.Point(938, 18)
        Me.dtpINEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpINEnd.Name = "dtpINEnd"
        Me.dtpINEnd.Size = New System.Drawing.Size(199, 20)
        Me.dtpINEnd.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(880, 22)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "To date :"
        '
        'dtpINStart
        '
        Me.dtpINStart.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpINStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpINStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpINStart.Location = New System.Drawing.Point(672, 18)
        Me.dtpINStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpINStart.Name = "dtpINStart"
        Me.dtpINStart.Size = New System.Drawing.Size(199, 20)
        Me.dtpINStart.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(604, 22)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "From date :"
        '
        'tbINSearch
        '
        Me.tbINSearch.Location = New System.Drawing.Point(102, 18)
        Me.tbINSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.tbINSearch.Name = "tbINSearch"
        Me.tbINSearch.Size = New System.Drawing.Size(474, 19)
        Me.tbINSearch.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(17, 22)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Product code :"
        '
        'dgvDataIN
        '
        Me.dgvDataIN.AllowUserToAddRows = False
        Me.dgvDataIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvDataIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDataIN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDataIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDataIN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.suppliers_name, Me.adjust, Me.Coldddd, Me.Column5, Me.Column6, Me.DataGridViewTextBoxColumn4, Me.Column1, Me.DataGridViewTextBoxColumn5, Me.colINview, Me.colINEdit, Me.colINDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataIN.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDataIN.GridColor = System.Drawing.Color.White
        Me.dgvDataIN.Location = New System.Drawing.Point(14, 273)
        Me.dgvDataIN.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDataIN.Name = "dgvDataIN"
        Me.dgvDataIN.ReadOnly = True
        Me.dgvDataIN.RowTemplate.Height = 30
        Me.dgvDataIN.Size = New System.Drawing.Size(1317, 248)
        Me.dgvDataIN.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.tbStockPrice)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmdOrder)
        Me.GroupBox2.Controls.Add(Me.lblOrder)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtEmployee)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblBalance)
        Me.GroupBox2.Controls.Add(Me.lblLocation)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmdFindSup)
        Me.GroupBox2.Controls.Add(Me.cmdFindProduct)
        Me.GroupBox2.Controls.Add(Me.tbRecieveRemark)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.dtpEventIN)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmdRecieveCancel)
        Me.GroupBox2.Controls.Add(Me.cmdRecieveSave)
        Me.GroupBox2.Controls.Add(Me.tbQty)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbRecieveHow2Buy)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbRecieveProduct)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1317, 183)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock Receive"
        '
        'tbStockPrice
        '
        Me.tbStockPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStockPrice.Location = New System.Drawing.Point(92, 110)
        Me.tbStockPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tbStockPrice.Name = "tbStockPrice"
        Me.tbStockPrice.Size = New System.Drawing.Size(124, 19)
        Me.tbStockPrice.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(44, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Price  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(402, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "On hand Qty : "
        '
        'cmdOrder
        '
        Me.cmdOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrder.BackColor = System.Drawing.Color.Gold
        Me.cmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmdOrder.Location = New System.Drawing.Point(588, 147)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(99, 28)
        Me.cmdOrder.TabIndex = 55
        Me.cmdOrder.Text = "View Order"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOrder.ForeColor = System.Drawing.Color.Black
        Me.lblOrder.Location = New System.Drawing.Point(623, 114)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(11, 13)
        Me.lblOrder.TabIndex = 54
        Me.lblOrder.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(549, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Order Qty :"
        '
        'txtEmployee
        '
        Me.txtEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(92, 138)
        Me.txtEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.Size = New System.Drawing.Size(233, 19)
        Me.txtEmployee.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(49, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "User :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1093, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 49
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(496, 114)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(11, 13)
        Me.lblBalance.TabIndex = 47
        Me.lblBalance.Text = "-"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblLocation.Location = New System.Drawing.Point(1084, 115)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(11, 13)
        Me.lblLocation.TabIndex = 37
        Me.lblLocation.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1012, 115)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Location :"
        '
        'cmdFindSup
        '
        Me.cmdFindSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFindSup.BackgroundImage = CType(resources.GetObject("cmdFindSup.BackgroundImage"), System.Drawing.Image)
        Me.cmdFindSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindSup.Location = New System.Drawing.Point(839, 72)
        Me.cmdFindSup.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFindSup.Name = "cmdFindSup"
        Me.cmdFindSup.Size = New System.Drawing.Size(32, 30)
        Me.cmdFindSup.TabIndex = 35
        Me.cmdFindSup.UseVisualStyleBackColor = True
        '
        'cmdFindProduct
        '
        Me.cmdFindProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFindProduct.BackgroundImage = CType(resources.GetObject("cmdFindProduct.BackgroundImage"), System.Drawing.Image)
        Me.cmdFindProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindProduct.Location = New System.Drawing.Point(839, 38)
        Me.cmdFindProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFindProduct.Name = "cmdFindProduct"
        Me.cmdFindProduct.Size = New System.Drawing.Size(32, 30)
        Me.cmdFindProduct.TabIndex = 31
        Me.cmdFindProduct.UseVisualStyleBackColor = True
        '
        'tbRecieveRemark
        '
        Me.tbRecieveRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRecieveRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRecieveRemark.Location = New System.Drawing.Point(951, 44)
        Me.tbRecieveRemark.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRecieveRemark.Multiline = True
        Me.tbRecieveRemark.Name = "tbRecieveRemark"
        Me.tbRecieveRemark.Size = New System.Drawing.Size(331, 58)
        Me.tbRecieveRemark.TabIndex = 34
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(880, 48)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Reference :"
        '
        'dtpEventIN
        '
        Me.dtpEventIN.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpEventIN.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEventIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpEventIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEventIN.Location = New System.Drawing.Point(784, 111)
        Me.dtpEventIN.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEventIN.Name = "dtpEventIN"
        Me.dtpEventIN.Size = New System.Drawing.Size(199, 20)
        Me.dtpEventIN.TabIndex = 32
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(693, 115)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Received date :"
        '
        'cmdRecieveCancel
        '
        Me.cmdRecieveCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRecieveCancel.BackColor = System.Drawing.Color.Gold
        Me.cmdRecieveCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRecieveCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecieveCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmdRecieveCancel.Location = New System.Drawing.Point(696, 147)
        Me.cmdRecieveCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRecieveCancel.Name = "cmdRecieveCancel"
        Me.cmdRecieveCancel.Size = New System.Drawing.Size(99, 28)
        Me.cmdRecieveCancel.TabIndex = 8
        Me.cmdRecieveCancel.Text = "Cancel"
        Me.cmdRecieveCancel.UseVisualStyleBackColor = False
        '
        'cmdRecieveSave
        '
        Me.cmdRecieveSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRecieveSave.BackColor = System.Drawing.Color.Gold
        Me.cmdRecieveSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRecieveSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecieveSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.cmdRecieveSave.Location = New System.Drawing.Point(803, 147)
        Me.cmdRecieveSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRecieveSave.Name = "cmdRecieveSave"
        Me.cmdRecieveSave.Size = New System.Drawing.Size(99, 28)
        Me.cmdRecieveSave.TabIndex = 7
        Me.cmdRecieveSave.Text = "Save"
        Me.cmdRecieveSave.UseVisualStyleBackColor = False
        '
        'tbQty
        '
        Me.tbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQty.Location = New System.Drawing.Point(310, 109)
        Me.tbQty.Margin = New System.Windows.Forms.Padding(4)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(81, 19)
        Me.tbQty.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Supplier :"
        '
        'cbRecieveHow2Buy
        '
        Me.cbRecieveHow2Buy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRecieveHow2Buy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbRecieveHow2Buy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbRecieveHow2Buy.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecieveHow2Buy.FormattingEnabled = True
        Me.cbRecieveHow2Buy.Location = New System.Drawing.Point(92, 78)
        Me.cbRecieveHow2Buy.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRecieveHow2Buy.Name = "cbRecieveHow2Buy"
        Me.cbRecieveHow2Buy.Size = New System.Drawing.Size(739, 21)
        Me.cbRecieveHow2Buy.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(224, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Received Qty :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product code :"
        '
        'cbRecieveProduct
        '
        Me.cbRecieveProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRecieveProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbRecieveProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbRecieveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecieveProduct.FormattingEnabled = True
        Me.cbRecieveProduct.Location = New System.Drawing.Point(92, 45)
        Me.cbRecieveProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRecieveProduct.Name = "cbRecieveProduct"
        Me.cbRecieveProduct.Size = New System.Drawing.Size(739, 21)
        Me.cbRecieveProduct.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "event_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Received date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "products_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'suppliers_name
        '
        Me.suppliers_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.suppliers_name.DataPropertyName = "suppliers_name"
        Me.suppliers_name.HeaderText = "Supplier"
        Me.suppliers_name.Name = "suppliers_name"
        Me.suppliers_name.ReadOnly = True
        '
        'adjust
        '
        Me.adjust.DataPropertyName = "adjust"
        Me.adjust.HeaderText = "Price"
        Me.adjust.Name = "adjust"
        Me.adjust.ReadOnly = True
        '
        'Coldddd
        '
        Me.Coldddd.DataPropertyName = "products_type_name"
        Me.Coldddd.HeaderText = "Type"
        Me.Coldddd.Name = "Coldddd"
        Me.Coldddd.ReadOnly = True
        Me.Coldddd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "products_name1"
        Me.Column5.HeaderText = "Remark"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "stock_price"
        Me.Column6.HeaderText = "Unit Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "stock_qty"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Received Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "updateby"
        Me.Column1.HeaderText = "User"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "stock_remark"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Reference"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colINview
        '
        Me.colINview.HeaderText = ""
        Me.colINview.MinimumWidth = 10
        Me.colINview.Name = "colINview"
        Me.colINview.ReadOnly = True
        Me.colINview.Text = "view"
        Me.colINview.UseColumnTextForButtonValue = True
        Me.colINview.Visible = False
        Me.colINview.Width = 50
        '
        'colINEdit
        '
        Me.colINEdit.HeaderText = ""
        Me.colINEdit.Name = "colINEdit"
        Me.colINEdit.ReadOnly = True
        Me.colINEdit.Text = "Edit"
        Me.colINEdit.UseColumnTextForButtonValue = True
        Me.colINEdit.Visible = False
        Me.colINEdit.Width = 40
        '
        'colINDel
        '
        Me.colINDel.HeaderText = ""
        Me.colINDel.Name = "colINDel"
        Me.colINDel.ReadOnly = True
        Me.colINDel.Text = "Del."
        Me.colINDel.UseColumnTextForButtonValue = True
        Me.colINDel.Width = 40
        '
        'Restock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 543)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDataIN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Restock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Receive"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDataIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdINSearch As Button
    Friend WithEvents dtpINEnd As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpINStart As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents tbINSearch As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dgvDataIN As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdFindSup As Button
    Friend WithEvents cmdFindProduct As Button
    Friend WithEvents tbRecieveRemark As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents dtpEventIN As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdRecieveCancel As Button
    Friend WithEvents cmdRecieveSave As Button
    Friend WithEvents tbQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRecieveHow2Buy As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRecieveProduct As ComboBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdOrder As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbStockPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents adjust As DataGridViewTextBoxColumn
    Friend WithEvents Coldddd As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents colINview As DataGridViewButtonColumn
    Friend WithEvents colINEdit As DataGridViewButtonColumn
    Friend WithEvents colINDel As DataGridViewButtonColumn
End Class
