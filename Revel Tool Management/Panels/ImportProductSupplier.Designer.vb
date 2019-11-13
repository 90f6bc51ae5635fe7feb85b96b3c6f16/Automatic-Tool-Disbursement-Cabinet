<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportProductSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportProductSupplier))
        Me.cmdBrown = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.lbError = New System.Windows.Forms.Label()
        Me.lbAlready = New System.Windows.Forms.Label()
        Me.lbSuccess = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.products_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.products_supplier_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_delivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBrown
        '
        Me.cmdBrown.BackColor = System.Drawing.Color.LightGray
        Me.cmdBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrown.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrown.ForeColor = System.Drawing.Color.Black
        Me.cmdBrown.Location = New System.Drawing.Point(900, 30)
        Me.cmdBrown.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrown.Name = "cmdBrown"
        Me.cmdBrown.Size = New System.Drawing.Size(111, 23)
        Me.cmdBrown.TabIndex = 52
        Me.cmdBrown.Text = "Choose File"
        Me.cmdBrown.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 35)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 13)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Excel file :"
        '
        'tbFile
        '
        Me.tbFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFile.ForeColor = System.Drawing.Color.Black
        Me.tbFile.Location = New System.Drawing.Point(79, 32)
        Me.tbFile.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.ReadOnly = True
        Me.tbFile.Size = New System.Drawing.Size(813, 19)
        Me.tbFile.TabIndex = 50
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.Color.LightGray
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.ForeColor = System.Drawing.Color.Black
        Me.cmdLoad.Location = New System.Drawing.Point(1019, 30)
        Me.cmdLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(111, 23)
        Me.cmdLoad.TabIndex = 49
        Me.cmdLoad.Text = "Load Data"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'lbError
        '
        Me.lbError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbError.BackColor = System.Drawing.Color.Red
        Me.lbError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbError.ForeColor = System.Drawing.Color.Black
        Me.lbError.Location = New System.Drawing.Point(459, 612)
        Me.lbError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(64, 32)
        Me.lbError.TabIndex = 70
        Me.lbError.Text = "0"
        Me.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAlready
        '
        Me.lbAlready.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbAlready.BackColor = System.Drawing.Color.Yellow
        Me.lbAlready.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlready.ForeColor = System.Drawing.Color.Black
        Me.lbAlready.Location = New System.Drawing.Point(215, 612)
        Me.lbAlready.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAlready.Name = "lbAlready"
        Me.lbAlready.Size = New System.Drawing.Size(64, 32)
        Me.lbAlready.TabIndex = 69
        Me.lbAlready.Text = "0"
        Me.lbAlready.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSuccess
        '
        Me.lbSuccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSuccess.BackColor = System.Drawing.Color.PaleGreen
        Me.lbSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSuccess.ForeColor = System.Drawing.Color.Black
        Me.lbSuccess.Location = New System.Drawing.Point(32, 612)
        Me.lbSuccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSuccess.Name = "lbSuccess"
        Me.lbSuccess.Size = New System.Drawing.Size(64, 32)
        Me.lbSuccess.TabIndex = 68
        Me.lbSuccess.Text = "0"
        Me.lbSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(104, 622)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Success"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(287, 622)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Already in tool register"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(531, 622)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Error format "
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClear.BackColor = System.Drawing.Color.Gold
        Me.cmdClear.FlatAppearance.BorderSize = 0
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Black
        Me.cmdClear.Location = New System.Drawing.Point(921, 612)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(100, 32)
        Me.cmdClear.TabIndex = 64
        Me.cmdClear.Text = "Close"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdImport
        '
        Me.cmdImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImport.BackColor = System.Drawing.Color.Gold
        Me.cmdImport.FlatAppearance.BorderSize = 0
        Me.cmdImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.ForeColor = System.Drawing.Color.Black
        Me.cmdImport.Location = New System.Drawing.Point(1029, 612)
        Me.cmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(100, 32)
        Me.cmdImport.TabIndex = 63
        Me.cmdImport.Text = "Import"
        Me.cmdImport.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.products_code, Me.suppliers_name, Me.products_supplier_code, Me.time_delivery, Me.prices, Me.sale_prices, Me.colDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData.Location = New System.Drawing.Point(20, 64)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(1110, 535)
        Me.dgvData.TabIndex = 71
        '
        'products_code
        '
        Me.products_code.DataPropertyName = "Product Code"
        Me.products_code.HeaderText = "Product code"
        Me.products_code.Name = "products_code"
        Me.products_code.ReadOnly = True
        Me.products_code.Width = 200
        '
        'suppliers_name
        '
        Me.suppliers_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.suppliers_name.DataPropertyName = "Supplier"
        Me.suppliers_name.HeaderText = "Supplier"
        Me.suppliers_name.MinimumWidth = 200
        Me.suppliers_name.Name = "suppliers_name"
        Me.suppliers_name.ReadOnly = True
        '
        'products_supplier_code
        '
        Me.products_supplier_code.DataPropertyName = "Supplier code"
        Me.products_supplier_code.HeaderText = "Supplier code"
        Me.products_supplier_code.MinimumWidth = 200
        Me.products_supplier_code.Name = "products_supplier_code"
        Me.products_supplier_code.ReadOnly = True
        Me.products_supplier_code.Width = 240
        '
        'time_delivery
        '
        Me.time_delivery.DataPropertyName = "Lead time"
        Me.time_delivery.HeaderText = "Lead time"
        Me.time_delivery.Name = "time_delivery"
        Me.time_delivery.ReadOnly = True
        Me.time_delivery.Width = 90
        '
        'prices
        '
        Me.prices.DataPropertyName = "Buying price"
        Me.prices.HeaderText = "Buying price"
        Me.prices.Name = "prices"
        Me.prices.ReadOnly = True
        Me.prices.Width = 120
        '
        'sale_prices
        '
        Me.sale_prices.DataPropertyName = "Selling price"
        Me.sale_prices.HeaderText = "Selling price"
        Me.sale_prices.Name = "sale_prices"
        Me.sale_prices.ReadOnly = True
        Me.sale_prices.Width = 120
        '
        'colDel
        '
        Me.colDel.HeaderText = "Del."
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Text = "Del."
        Me.colDel.UseColumnTextForButtonValue = True
        Me.colDel.Width = 40
        '
        'ImportProductSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 664)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.lbError)
        Me.Controls.Add(Me.lbAlready)
        Me.Controls.Add(Me.lbSuccess)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.cmdBrown)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbFile)
        Me.Controls.Add(Me.cmdLoad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportProductSupplier"
        Me.Text = "ImportProductSupplier"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBrown As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents tbFile As TextBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents lbError As Label
    Friend WithEvents lbAlready As Label
    Friend WithEvents lbSuccess As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdImport As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents products_code As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents products_supplier_code As DataGridViewTextBoxColumn
    Friend WithEvents time_delivery As DataGridViewTextBoxColumn
    Friend WithEvents prices As DataGridViewTextBoxColumn
    Friend WithEvents sale_prices As DataGridViewTextBoxColumn
    Friend WithEvents colDel As DataGridViewButtonColumn
End Class
