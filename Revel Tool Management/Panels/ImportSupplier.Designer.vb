<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportSupplier
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportSupplier))
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
        Me.suppliers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliers_detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.cmdBrown.Location = New System.Drawing.Point(895, 20)
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
        Me.Label22.Location = New System.Drawing.Point(11, 25)
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
        Me.tbFile.Location = New System.Drawing.Point(74, 22)
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
        Me.cmdLoad.Location = New System.Drawing.Point(1014, 20)
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
        Me.lbError.Location = New System.Drawing.Point(454, 583)
        Me.lbError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbError.Name = "lbError"
        Me.lbError.Size = New System.Drawing.Size(64, 32)
        Me.lbError.TabIndex = 62
        Me.lbError.Text = "0"
        Me.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAlready
        '
        Me.lbAlready.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbAlready.BackColor = System.Drawing.Color.Yellow
        Me.lbAlready.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlready.ForeColor = System.Drawing.Color.Black
        Me.lbAlready.Location = New System.Drawing.Point(210, 583)
        Me.lbAlready.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAlready.Name = "lbAlready"
        Me.lbAlready.Size = New System.Drawing.Size(64, 32)
        Me.lbAlready.TabIndex = 61
        Me.lbAlready.Text = "0"
        Me.lbAlready.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSuccess
        '
        Me.lbSuccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSuccess.BackColor = System.Drawing.Color.PaleGreen
        Me.lbSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSuccess.ForeColor = System.Drawing.Color.Black
        Me.lbSuccess.Location = New System.Drawing.Point(27, 583)
        Me.lbSuccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSuccess.Name = "lbSuccess"
        Me.lbSuccess.Size = New System.Drawing.Size(64, 32)
        Me.lbSuccess.TabIndex = 60
        Me.lbSuccess.Text = "0"
        Me.lbSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(99, 593)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Success"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(282, 593)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Already in tool register"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(526, 593)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 57
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
        Me.cmdClear.Location = New System.Drawing.Point(916, 583)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(100, 32)
        Me.cmdClear.TabIndex = 56
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
        Me.cmdImport.Location = New System.Drawing.Point(1024, 583)
        Me.cmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(100, 32)
        Me.cmdImport.TabIndex = 55
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
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.suppliers_name, Me.suppliers_contact, Me.suppliers_address, Me.suppliers_tel, Me.suppliers_email, Me.suppliers_fax, Me.suppliers_detail, Me.Image, Me.colDel})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvData.GridColor = System.Drawing.Color.White
        Me.dgvData.Location = New System.Drawing.Point(12, 51)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvData.RowTemplate.Height = 30
        Me.dgvData.Size = New System.Drawing.Size(1114, 508)
        Me.dgvData.TabIndex = 63
        '
        'suppliers_name
        '
        Me.suppliers_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.suppliers_name.DataPropertyName = "Suppliers  Name"
        Me.suppliers_name.HeaderText = "Suppliers  Name"
        Me.suppliers_name.MinimumWidth = 150
        Me.suppliers_name.Name = "suppliers_name"
        Me.suppliers_name.ReadOnly = True
        Me.suppliers_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'suppliers_contact
        '
        Me.suppliers_contact.DataPropertyName = "Suppliers  Contact"
        Me.suppliers_contact.HeaderText = "Suppliers  Contact"
        Me.suppliers_contact.MinimumWidth = 150
        Me.suppliers_contact.Name = "suppliers_contact"
        Me.suppliers_contact.ReadOnly = True
        Me.suppliers_contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.suppliers_contact.Width = 150
        '
        'suppliers_address
        '
        Me.suppliers_address.DataPropertyName = "Suppliers  Address"
        Me.suppliers_address.HeaderText = "Suppliers  Address"
        Me.suppliers_address.MinimumWidth = 150
        Me.suppliers_address.Name = "suppliers_address"
        Me.suppliers_address.ReadOnly = True
        Me.suppliers_address.Width = 150
        '
        'suppliers_tel
        '
        Me.suppliers_tel.DataPropertyName = "Suppliers  Tel"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.suppliers_tel.DefaultCellStyle = DataGridViewCellStyle3
        Me.suppliers_tel.HeaderText = "Suppliers  Tel"
        Me.suppliers_tel.MinimumWidth = 100
        Me.suppliers_tel.Name = "suppliers_tel"
        Me.suppliers_tel.ReadOnly = True
        Me.suppliers_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'suppliers_email
        '
        Me.suppliers_email.DataPropertyName = "Suppliers  Email"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.suppliers_email.DefaultCellStyle = DataGridViewCellStyle4
        Me.suppliers_email.HeaderText = "Suppliers  Email"
        Me.suppliers_email.MinimumWidth = 100
        Me.suppliers_email.Name = "suppliers_email"
        Me.suppliers_email.ReadOnly = True
        Me.suppliers_email.Width = 150
        '
        'suppliers_fax
        '
        Me.suppliers_fax.DataPropertyName = "Suppliers  Fax"
        Me.suppliers_fax.HeaderText = "Suppliers  Fax"
        Me.suppliers_fax.MinimumWidth = 150
        Me.suppliers_fax.Name = "suppliers_fax"
        Me.suppliers_fax.ReadOnly = True
        Me.suppliers_fax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.suppliers_fax.Width = 150
        '
        'suppliers_detail
        '
        Me.suppliers_detail.DataPropertyName = "Suppliers Detail"
        Me.suppliers_detail.HeaderText = "Suppliers Detail"
        Me.suppliers_detail.Name = "suppliers_detail"
        Me.suppliers_detail.ReadOnly = True
        '
        'Image
        '
        Me.Image.DataPropertyName = "Image"
        Me.Image.HeaderText = "Image"
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = True
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
        'ImportSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 634)
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
        Me.Name = "ImportSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImportSupplier"
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
    Friend WithEvents suppliers_name As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_contact As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_address As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_tel As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_email As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_fax As DataGridViewTextBoxColumn
    Friend WithEvents suppliers_detail As DataGridViewTextBoxColumn
    Friend WithEvents Image As DataGridViewTextBoxColumn
    Friend WithEvents colDel As DataGridViewButtonColumn
End Class
