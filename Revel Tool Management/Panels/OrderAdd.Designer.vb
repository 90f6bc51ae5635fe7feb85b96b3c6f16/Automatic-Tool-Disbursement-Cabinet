<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderAdd
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAll = New System.Windows.Forms.DataGridView()
        Me.products_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_supplier_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_qty_balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_qty_on = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.tbRemark = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpEvent = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.cmdAddList = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbQty = New System.Windows.Forms.TextBox()
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAll
        '
        Me.dgvAll.AllowUserToAddRows = False
        Me.dgvAll.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvAll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAll.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.products_id, Me.products_code, Me.products_name2, Me.suppliers_name, Me.products_supplier_code, Me.products_name1, Me.products_min, Me.order_qty_balance, Me.order_qty_on, Me.order_qty, Me.coldel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAll.GridColor = System.Drawing.Color.White
        Me.dgvAll.Location = New System.Drawing.Point(7, 69)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.RowTemplate.Height = 30
        Me.dgvAll.Size = New System.Drawing.Size(1121, 487)
        Me.dgvAll.TabIndex = 9
        '
        'products_id
        '
        Me.products_id.DataPropertyName = "products_id"
        Me.products_id.HeaderText = "products_id"
        Me.products_id.Name = "products_id"
        Me.products_id.Visible = False
        '
        'products_code
        '
        Me.products_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.products_code.DataPropertyName = "products_code"
        Me.products_code.HeaderText = "Product code"
        Me.products_code.MinimumWidth = 200
        Me.products_code.Name = "products_code"
        Me.products_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'products_name2
        '
        Me.products_name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.products_name2.DataPropertyName = "products_name2"
        Me.products_name2.HeaderText = "Tool description"
        Me.products_name2.MinimumWidth = 150
        Me.products_name2.Name = "products_name2"
        Me.products_name2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'suppliers_name
        '
        Me.suppliers_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.suppliers_name.DataPropertyName = "suppliers_name"
        Me.suppliers_name.HeaderText = "Supplier"
        Me.suppliers_name.MinimumWidth = 150
        Me.suppliers_name.Name = "suppliers_name"
        '
        'products_supplier_code
        '
        Me.products_supplier_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.products_supplier_code.DataPropertyName = "products_supplier_code"
        Me.products_supplier_code.HeaderText = "Supplier code"
        Me.products_supplier_code.MinimumWidth = 150
        Me.products_supplier_code.Name = "products_supplier_code"
        '
        'products_name1
        '
        Me.products_name1.DataPropertyName = "products_name1"
        Me.products_name1.HeaderText = "Remark"
        Me.products_name1.Name = "products_name1"
        Me.products_name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.products_name1.Width = 120
        '
        'products_min
        '
        Me.products_min.DataPropertyName = "products_min"
        Me.products_min.HeaderText = "Mininum"
        Me.products_min.Name = "products_min"
        Me.products_min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'order_qty_balance
        '
        Me.order_qty_balance.DataPropertyName = "order_qty_balance"
        Me.order_qty_balance.HeaderText = "On hand Qty."
        Me.order_qty_balance.Name = "order_qty_balance"
        Me.order_qty_balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.order_qty_balance.Width = 140
        '
        'order_qty_on
        '
        Me.order_qty_on.DataPropertyName = "order_qty_on"
        Me.order_qty_on.HeaderText = "On order Qty."
        Me.order_qty_on.Name = "order_qty_on"
        Me.order_qty_on.Width = 140
        '
        'order_qty
        '
        Me.order_qty.DataPropertyName = "order_qty"
        Me.order_qty.HeaderText = "Reorder Qty."
        Me.order_qty.Name = "order_qty"
        Me.order_qty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.order_qty.Width = 140
        '
        'coldel
        '
        Me.coldel.HeaderText = ""
        Me.coldel.Name = "coldel"
        Me.coldel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldel.Text = "Delete"
        Me.coldel.UseColumnTextForButtonValue = True
        Me.coldel.Width = 80
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.Color.Gold
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(993, 559)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(140, 38)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdOrder
        '
        Me.cmdOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrder.BackColor = System.Drawing.Color.Gold
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(847, 559)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(140, 38)
        Me.cmdOrder.TabIndex = 11
        Me.cmdOrder.Text = "Save"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'tbRemark
        '
        Me.tbRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemark.Location = New System.Drawing.Point(345, 13)
        Me.tbRemark.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRemark.Name = "tbRemark"
        Me.tbRemark.Size = New System.Drawing.Size(783, 19)
        Me.tbRemark.TabIndex = 47
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(287, 15)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Remark :"
        Me.Label24.Visible = False
        '
        'dtpEvent
        '
        Me.dtpEvent.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEvent.Enabled = False
        Me.dtpEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEvent.Location = New System.Drawing.Point(84, 13)
        Me.dtpEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEvent.Name = "dtpEvent"
        Me.dtpEvent.Size = New System.Drawing.Size(176, 20)
        Me.dtpEvent.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(12, 15)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Order date :"
        '
        'cmdSend
        '
        Me.cmdSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSend.BackColor = System.Drawing.Color.Gold
        Me.cmdSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSend.Location = New System.Drawing.Point(701, 559)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(140, 38)
        Me.cmdSend.TabIndex = 48
        Me.cmdSend.Text = "Save and Export"
        Me.cmdSend.UseVisualStyleBackColor = False
        '
        'cmdAddList
        '
        Me.cmdAddList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddList.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdAddList.Location = New System.Drawing.Point(989, 39)
        Me.cmdAddList.Name = "cmdAddList"
        Me.cmdAddList.Size = New System.Drawing.Size(140, 21)
        Me.cmdAddList.TabIndex = 49
        Me.cmdAddList.Text = "Add order list"
        Me.cmdAddList.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(467, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "On hand qty : "
        '
        'lblOrder
        '
        Me.lblOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOrder.ForeColor = System.Drawing.Color.Black
        Me.lblOrder.Location = New System.Drawing.Point(714, 43)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(11, 13)
        Me.lblOrder.TabIndex = 61
        Me.lblOrder.Text = "-"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(622, 43)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "On order qty :"
        '
        'lblBalance
        '
        Me.lblBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(561, 44)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(11, 13)
        Me.lblBalance.TabIndex = 59
        Me.lblBalance.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Product code :"
        '
        'cbProduct
        '
        Me.cbProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(84, 41)
        Me.cbProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(253, 21)
        Me.cbProduct.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(344, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Minimum : "
        '
        'lblMin
        '
        Me.lblMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Black
        Me.lblMin.Location = New System.Drawing.Point(417, 43)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(11, 13)
        Me.lblMin.TabIndex = 63
        Me.lblMin.Text = "-"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(770, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Order :"
        '
        'tbQty
        '
        Me.tbQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQty.Location = New System.Drawing.Point(824, 41)
        Me.tbQty.Margin = New System.Windows.Forms.Padding(4)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(158, 19)
        Me.tbQty.TabIndex = 66
        '
        'OrderAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 601)
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProduct)
        Me.Controls.Add(Me.cmdAddList)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.tbRemark)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.dtpEvent)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.dgvAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OrderAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAll As DataGridView
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdOrder As Button
    Friend WithEvents tbRemark As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents dtpEvent As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdSend As Button
    Friend WithEvents cmdAddList As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProduct As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbQty As TextBox
    Friend WithEvents products_id As DataGridViewTextBoxColumn
    Friend WithEvents products_code As DataGridViewTextBoxColumn
    Friend WithEvents products_name2 As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents products_supplier_code As DataGridViewTextBoxColumn
    Friend WithEvents products_name1 As DataGridViewTextBoxColumn
    Friend WithEvents products_min As DataGridViewTextBoxColumn
    Friend WithEvents order_qty_balance As DataGridViewTextBoxColumn
    Friend WithEvents order_qty_on As DataGridViewTextBoxColumn
    Friend WithEvents order_qty As DataGridViewTextBoxColumn
    Friend WithEvents coldel As DataGridViewButtonColumn
End Class
