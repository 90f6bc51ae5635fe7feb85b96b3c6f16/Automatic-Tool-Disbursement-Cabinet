<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportProduct
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportProduct))
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdBrown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbSuccess = New System.Windows.Forms.Label()
        Me.lbAlready = New System.Windows.Forms.Label()
        Me.lbError = New System.Windows.Forms.Label()
        Me.products_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_customer_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_conner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_factor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_group_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_brand_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lead_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selling_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drawing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(13, 17)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Excel file :"
        '
        'tbFile
        '
        Me.tbFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFile.ForeColor = System.Drawing.Color.Black
        Me.tbFile.Location = New System.Drawing.Point(76, 14)
        Me.tbFile.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.ReadOnly = True
        Me.tbFile.Size = New System.Drawing.Size(813, 19)
        Me.tbFile.TabIndex = 44
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.Color.LightGray
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.ForeColor = System.Drawing.Color.Black
        Me.cmdLoad.Location = New System.Drawing.Point(1016, 12)
        Me.cmdLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(111, 23)
        Me.cmdLoad.TabIndex = 43
        Me.cmdLoad.Text = "Load Data"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.products_code, Me.products_name2, Me.products_customer_code, Me.products_conner, Me.products_factor, Me.products_name1, Me.products_group_name, Me.products_type_name, Me.products_brand_name, Me.supplier, Me.supplier_code, Me.lead_time, Me.price, Me.selling_price, Me.Image, Me.Drawing, Me.colDel})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvData.GridColor = System.Drawing.Color.White
        Me.dgvData.Location = New System.Drawing.Point(16, 43)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvData.RowTemplate.Height = 30
        Me.dgvData.Size = New System.Drawing.Size(1114, 529)
        Me.dgvData.TabIndex = 42
        '
        'cmdImport
        '
        Me.cmdImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImport.BackColor = System.Drawing.Color.Gold
        Me.cmdImport.FlatAppearance.BorderSize = 0
        Me.cmdImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.ForeColor = System.Drawing.Color.Black
        Me.cmdImport.Location = New System.Drawing.Point(1030, 580)
        Me.cmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(100, 32)
        Me.cmdImport.TabIndex = 46
        Me.cmdImport.Text = "Import"
        Me.cmdImport.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClear.BackColor = System.Drawing.Color.Gold
        Me.cmdClear.FlatAppearance.BorderSize = 0
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Black
        Me.cmdClear.Location = New System.Drawing.Point(922, 580)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(100, 32)
        Me.cmdClear.TabIndex = 47
        Me.cmdClear.Text = "Close"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdBrown
        '
        Me.cmdBrown.BackColor = System.Drawing.Color.LightGray
        Me.cmdBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrown.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrown.ForeColor = System.Drawing.Color.Black
        Me.cmdBrown.Location = New System.Drawing.Point(897, 12)
        Me.cmdBrown.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrown.Name = "cmdBrown"
        Me.cmdBrown.Size = New System.Drawing.Size(111, 23)
        Me.cmdBrown.TabIndex = 48
        Me.cmdBrown.Text = "Choose File"
        Me.cmdBrown.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(532, 590)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Error format "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(288, 590)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Already in tool register"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(105, 590)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Success"
        '
        'lbSuccess
        '
        Me.lbSuccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSuccess.BackColor = System.Drawing.Color.PaleGreen
        Me.lbSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSuccess.ForeColor = System.Drawing.Color.Black
        Me.lbSuccess.Location = New System.Drawing.Point(33, 580)
        Me.lbSuccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSuccess.Name = "lbSuccess"
        Me.lbSuccess.Size = New System.Drawing.Size(64, 32)
        Me.lbSuccess.TabIndex = 52
        Me.lbSuccess.Text = "0"
        Me.lbSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAlready
        '
        Me.lbAlready.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbAlready.BackColor = System.Drawing.Color.Yellow
        Me.lbAlready.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlready.ForeColor = System.Drawing.Color.Black
        Me.lbAlready.Location = New System.Drawing.Point(216, 580)
        Me.lbAlready.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAlready.Name = "lbAlready"
        Me.lbAlready.Size = New System.Drawing.Size(64, 32)
        Me.lbAlready.TabIndex = 53
        Me.lbAlready.Text = "0"
        Me.lbAlready.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbError
        '
        Me.lbError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbError.BackColor = System.Drawing.Color.Red
        Me.lbError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbError.ForeColor = System.Drawing.Color.Black
        Me.lbError.Location = New System.Drawing.Point(460, 580)
        Me.lbError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(64, 32)
        Me.lbError.TabIndex = 54
        Me.lbError.Text = "0"
        Me.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'products_code
        '
        Me.products_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.products_code.DataPropertyName = "Product code"
        Me.products_code.HeaderText = "Product code"
        Me.products_code.MinimumWidth = 150
        Me.products_code.Name = "products_code"
        Me.products_code.ReadOnly = True
        Me.products_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'products_name2
        '
        Me.products_name2.DataPropertyName = "Tool discription"
        Me.products_name2.HeaderText = "Tool discription"
        Me.products_name2.MinimumWidth = 150
        Me.products_name2.Name = "products_name2"
        Me.products_name2.ReadOnly = True
        Me.products_name2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.products_name2.Width = 150
        '
        'products_customer_code
        '
        Me.products_customer_code.DataPropertyName = "Customer code"
        Me.products_customer_code.HeaderText = "Customer code"
        Me.products_customer_code.MinimumWidth = 150
        Me.products_customer_code.Name = "products_customer_code"
        Me.products_customer_code.ReadOnly = True
        Me.products_customer_code.Width = 150
        '
        'products_conner
        '
        Me.products_conner.DataPropertyName = "No of edge"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.products_conner.DefaultCellStyle = DataGridViewCellStyle3
        Me.products_conner.HeaderText = "No. of edge"
        Me.products_conner.MinimumWidth = 100
        Me.products_conner.Name = "products_conner"
        Me.products_conner.ReadOnly = True
        Me.products_conner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'products_factor
        '
        Me.products_factor.DataPropertyName = "Factor"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.products_factor.DefaultCellStyle = DataGridViewCellStyle4
        Me.products_factor.HeaderText = "Factor"
        Me.products_factor.MinimumWidth = 100
        Me.products_factor.Name = "products_factor"
        Me.products_factor.ReadOnly = True
        '
        'products_name1
        '
        Me.products_name1.DataPropertyName = "Remark"
        Me.products_name1.HeaderText = "Remark"
        Me.products_name1.MinimumWidth = 150
        Me.products_name1.Name = "products_name1"
        Me.products_name1.ReadOnly = True
        Me.products_name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.products_name1.Width = 150
        '
        'products_group_name
        '
        Me.products_group_name.DataPropertyName = "Group"
        Me.products_group_name.HeaderText = "Group"
        Me.products_group_name.Name = "products_group_name"
        Me.products_group_name.ReadOnly = True
        '
        'products_type_name
        '
        Me.products_type_name.DataPropertyName = "Type"
        Me.products_type_name.HeaderText = "Type"
        Me.products_type_name.Name = "products_type_name"
        Me.products_type_name.ReadOnly = True
        '
        'products_brand_name
        '
        Me.products_brand_name.DataPropertyName = "Brand"
        Me.products_brand_name.HeaderText = "Brand"
        Me.products_brand_name.Name = "products_brand_name"
        Me.products_brand_name.ReadOnly = True
        '
        'supplier
        '
        Me.supplier.DataPropertyName = "Supplier"
        Me.supplier.HeaderText = "Supplier"
        Me.supplier.Name = "supplier"
        Me.supplier.ReadOnly = True
        '
        'supplier_code
        '
        Me.supplier_code.DataPropertyName = "Supplier code"
        Me.supplier_code.HeaderText = "Supplier code"
        Me.supplier_code.Name = "supplier_code"
        Me.supplier_code.ReadOnly = True
        '
        'lead_time
        '
        Me.lead_time.DataPropertyName = "Lead time"
        Me.lead_time.HeaderText = "Lead time"
        Me.lead_time.Name = "lead_time"
        Me.lead_time.ReadOnly = True
        '
        'price
        '
        Me.price.DataPropertyName = "Buying price"
        Me.price.HeaderText = "Buying price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'selling_price
        '
        Me.selling_price.DataPropertyName = "Selling price"
        Me.selling_price.HeaderText = "Selling price"
        Me.selling_price.Name = "selling_price"
        Me.selling_price.ReadOnly = True
        '
        'Image
        '
        Me.Image.DataPropertyName = "Image"
        Me.Image.HeaderText = "Image"
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = True
        '
        'Drawing
        '
        Me.Drawing.DataPropertyName = "Drawing"
        Me.Drawing.HeaderText = "Drawing"
        Me.Drawing.Name = "Drawing"
        Me.Drawing.ReadOnly = True
        '
        'colDel
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2)
        Me.colDel.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDel.HeaderText = "Del."
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Text = "Del."
        Me.colDel.UseColumnTextForButtonValue = True
        Me.colDel.Width = 60
        '
        'ImportProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 633)
        Me.Controls.Add(Me.lbError)
        Me.Controls.Add(Me.lbAlready)
        Me.Controls.Add(Me.lbSuccess)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdBrown)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbFile)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.dgvData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImportProduct"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label22 As Label
    Friend WithEvents tbFile As TextBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cmdImport As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdBrown As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbSuccess As Label
    Friend WithEvents lbAlready As Label
    Friend WithEvents lbError As Label
    Friend WithEvents products_code As DataGridViewTextBoxColumn
    Friend WithEvents products_name2 As DataGridViewTextBoxColumn
    Friend WithEvents products_customer_code As DataGridViewTextBoxColumn
    Friend WithEvents products_conner As DataGridViewTextBoxColumn
    Friend WithEvents products_factor As DataGridViewTextBoxColumn
    Friend WithEvents products_name1 As DataGridViewTextBoxColumn
    Friend WithEvents products_group_name As DataGridViewTextBoxColumn
    Friend WithEvents products_type_name As DataGridViewTextBoxColumn
    Friend WithEvents products_brand_name As DataGridViewTextBoxColumn
    Friend WithEvents supplier As DataGridViewTextBoxColumn
    Friend WithEvents supplier_code As DataGridViewTextBoxColumn
    Friend WithEvents lead_time As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents selling_price As DataGridViewTextBoxColumn
    Friend WithEvents Image As DataGridViewTextBoxColumn
    Friend WithEvents Drawing As DataGridViewTextBoxColumn
    Friend WithEvents colDel As DataGridViewButtonColumn
End Class
