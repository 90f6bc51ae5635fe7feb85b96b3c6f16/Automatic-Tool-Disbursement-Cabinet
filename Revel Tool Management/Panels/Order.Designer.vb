<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.tbRemark = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpEvent = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.products_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_supplier_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_qty_balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_qty_on = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.products_code, Me.products_id, Me.products_name2, Me.suppliers_name, Me.products_supplier_code, Me.products_name1, Me.products_max, Me.products_min, Me.order_qty_balance, Me.order_qty_on, Me.order_qty})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAll.GridColor = System.Drawing.Color.White
        Me.dgvAll.Location = New System.Drawing.Point(12, 40)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.RowTemplate.Height = 30
        Me.dgvAll.Size = New System.Drawing.Size(988, 513)
        Me.dgvAll.TabIndex = 9
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.Color.Gold
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(860, 559)
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
        Me.cmdOrder.Location = New System.Drawing.Point(714, 559)
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
        Me.tbRemark.Size = New System.Drawing.Size(650, 19)
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
        Me.cmdSend.Location = New System.Drawing.Point(568, 559)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(140, 38)
        Me.cmdSend.TabIndex = 48
        Me.cmdSend.Text = "Save and Export"
        Me.cmdSend.UseVisualStyleBackColor = False
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
        'products_id
        '
        Me.products_id.DataPropertyName = "products_id"
        Me.products_id.HeaderText = "products_id"
        Me.products_id.Name = "products_id"
        Me.products_id.Visible = False
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
        'products_max
        '
        Me.products_max.DataPropertyName = "products_consumption"
        Me.products_max.HeaderText = "Consumption"
        Me.products_max.Name = "products_max"
        '
        'products_min
        '
        Me.products_min.DataPropertyName = "products_reorder"
        Me.products_min.HeaderText = "Reorder point"
        Me.products_min.Name = "products_min"
        Me.products_min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'order_qty_balance
        '
        Me.order_qty_balance.DataPropertyName = "order_qty_balance"
        Me.order_qty_balance.HeaderText = "On hand Qty."
        Me.order_qty_balance.Name = "order_qty_balance"
        Me.order_qty_balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.order_qty_balance.Width = 120
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
        Me.order_qty.Width = 120
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.tbRemark)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.dtpEvent)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.dgvAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
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
    Friend WithEvents products_code As DataGridViewTextBoxColumn
    Friend WithEvents products_id As DataGridViewTextBoxColumn
    Friend WithEvents products_name2 As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents products_supplier_code As DataGridViewTextBoxColumn
    Friend WithEvents products_name1 As DataGridViewTextBoxColumn
    Friend WithEvents products_max As DataGridViewTextBoxColumn
    Friend WithEvents products_min As DataGridViewTextBoxColumn
    Friend WithEvents order_qty_balance As DataGridViewTextBoxColumn
    Friend WithEvents order_qty_on As DataGridViewTextBoxColumn
    Friend WithEvents order_qty As DataGridViewTextBoxColumn
End Class
