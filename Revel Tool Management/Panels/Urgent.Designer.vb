<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Urgent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Urgent))
        Me.dgvAll = New System.Windows.Forms.DataGridView()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.cmdOrderView = New System.Windows.Forms.Button()
        Me.products_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_reorder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.products_code, Me.products_name2, Me.suppliers_name, Me.products_name1, Me.products_min, Me.products_reorder, Me.qty, Me.products_order})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAll.GridColor = System.Drawing.Color.White
        Me.dgvAll.Location = New System.Drawing.Point(12, 12)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.RowTemplate.Height = 30
        Me.dgvAll.Size = New System.Drawing.Size(1244, 541)
        Me.dgvAll.TabIndex = 9
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.BackColor = System.Drawing.Color.Gold
        Me.cmdExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExport.Location = New System.Drawing.Point(1116, 559)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(140, 38)
        Me.cmdExport.TabIndex = 10
        Me.cmdExport.Text = "Export Excel"
        Me.cmdExport.UseVisualStyleBackColor = False
        '
        'cmdOrder
        '
        Me.cmdOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrder.BackColor = System.Drawing.Color.Gold
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(970, 559)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(140, 38)
        Me.cmdOrder.TabIndex = 11
        Me.cmdOrder.Text = "Order"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'cmdOrderView
        '
        Me.cmdOrderView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrderView.BackColor = System.Drawing.Color.Gold
        Me.cmdOrderView.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrderView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOrderView.Location = New System.Drawing.Point(842, 559)
        Me.cmdOrderView.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOrderView.Name = "cmdOrderView"
        Me.cmdOrderView.Size = New System.Drawing.Size(121, 38)
        Me.cmdOrderView.TabIndex = 12
        Me.cmdOrderView.Text = "View Order"
        Me.cmdOrderView.UseVisualStyleBackColor = False
        '
        'products_code
        '
        Me.products_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.products_code.DataPropertyName = "products_code"
        Me.products_code.HeaderText = "Product code"
        Me.products_code.MinimumWidth = 150
        Me.products_code.Name = "products_code"
        Me.products_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'products_name2
        '
        Me.products_name2.DataPropertyName = "products_name2"
        Me.products_name2.HeaderText = "Tool description"
        Me.products_name2.Name = "products_name2"
        Me.products_name2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.products_name2.Width = 140
        '
        'suppliers_name
        '
        Me.suppliers_name.DataPropertyName = "suppliers_name"
        Me.suppliers_name.HeaderText = "Supplier"
        Me.suppliers_name.Name = "suppliers_name"
        Me.suppliers_name.Width = 150
        '
        'products_name1
        '
        Me.products_name1.DataPropertyName = "products_name1"
        Me.products_name1.HeaderText = "Remark"
        Me.products_name1.MinimumWidth = 150
        Me.products_name1.Name = "products_name1"
        Me.products_name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.products_name1.Width = 150
        '
        'products_min
        '
        Me.products_min.DataPropertyName = "products_consumption"
        Me.products_min.HeaderText = "Consumption"
        Me.products_min.MinimumWidth = 140
        Me.products_min.Name = "products_min"
        Me.products_min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.products_min.Width = 140
        '
        'products_reorder
        '
        Me.products_reorder.DataPropertyName = "products_reorder"
        Me.products_reorder.HeaderText = "Reorder point"
        Me.products_reorder.MinimumWidth = 160
        Me.products_reorder.Name = "products_reorder"
        Me.products_reorder.Width = 160
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "On hand Qty."
        Me.qty.MinimumWidth = 120
        Me.qty.Name = "qty"
        Me.qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.qty.Width = 120
        '
        'products_order
        '
        Me.products_order.DataPropertyName = "products_order"
        Me.products_order.HeaderText = "On order Qty."
        Me.products_order.MinimumWidth = 140
        Me.products_order.Name = "products_order"
        Me.products_order.Width = 140
        '
        'Urgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 601)
        Me.Controls.Add(Me.cmdOrderView)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.dgvAll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Urgent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Urgent"
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAll As DataGridView
    Friend WithEvents cmdExport As Button
    Friend WithEvents cmdOrder As Button
    Friend WithEvents cmdOrderView As Button
    Friend WithEvents products_code As DataGridViewTextBoxColumn
    Friend WithEvents products_name2 As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents products_name1 As DataGridViewTextBoxColumn
    Friend WithEvents products_min As DataGridViewTextBoxColumn
    Friend WithEvents products_reorder As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents products_order As DataGridViewTextBoxColumn
End Class
