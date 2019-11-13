<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuccessStory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuccessStory))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.tbDetail = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdUpload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbResultSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cbGroupSearch = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdBrand = New System.Windows.Forms.Button()
        Me.cbBrand = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbMaterial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbPartName = New System.Windows.Forms.TextBox()
        Me.cbResult = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdClearFile = New System.Windows.Forms.Button()
        Me.cmdViewFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.partname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.success_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(665, 17)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(288, 20)
        Me.tbSearch.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(617, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Search :"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.partname, Me.material, Me.success_brand, Me.Column5, Me.result, Me.colView, Me.colEdit, Me.colDel})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvData.GridColor = System.Drawing.Color.White
        Me.dgvData.Location = New System.Drawing.Point(5, 47)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvData.RowTemplate.Height = 30
        Me.dgvData.Size = New System.Drawing.Size(978, 251)
        Me.dgvData.TabIndex = 0
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClear.BackColor = System.Drawing.Color.Gold
        Me.cmdClear.FlatAppearance.BorderSize = 0
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Black
        Me.cmdClear.Location = New System.Drawing.Point(825, 235)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 11
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSubmit.BackColor = System.Drawing.Color.Gold
        Me.cmdSubmit.FlatAppearance.BorderSize = 0
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSubmit.ForeColor = System.Drawing.Color.Black
        Me.cmdSubmit.Location = New System.Drawing.Point(908, 235)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubmit.TabIndex = 12
        Me.cmdSubmit.Text = "Add"
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'tbDetail
        '
        Me.tbDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbDetail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbDetail.Location = New System.Drawing.Point(95, 112)
        Me.tbDetail.Multiline = True
        Me.tbDetail.Name = "tbDetail"
        Me.tbDetail.Size = New System.Drawing.Size(888, 76)
        Me.tbDetail.TabIndex = 5
        '
        'tbName
        '
        Me.tbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbName.Location = New System.Drawing.Point(95, 32)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(888, 20)
        Me.tbName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(50, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Detail : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subject :"
        '
        'cmdUpload
        '
        Me.cmdUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpload.BackColor = System.Drawing.Color.LightGray
        Me.cmdUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdUpload.ForeColor = System.Drawing.Color.Black
        Me.cmdUpload.Location = New System.Drawing.Point(664, 194)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(102, 23)
        Me.cmdUpload.TabIndex = 10
        Me.cmdUpload.Text = "Choose file"
        Me.cmdUpload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbResultSearch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgvData)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbGroupSearch)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 304)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'cbResultSearch
        '
        Me.cbResultSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResultSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbResultSearch.FormattingEnabled = True
        Me.cbResultSearch.Items.AddRange(New Object() {"Show all", "Success", "Fail"})
        Me.cbResultSearch.Location = New System.Drawing.Point(382, 17)
        Me.cbResultSearch.Name = "cbResultSearch"
        Me.cbResultSearch.Size = New System.Drawing.Size(229, 21)
        Me.cbResultSearch.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(330, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Result : "
        '
        'cmdSearch
        '
        Me.cmdSearch.BackgroundImage = CType(resources.GetObject("cmdSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSearch.Location = New System.Drawing.Point(959, 14)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(24, 24)
        Me.cmdSearch.TabIndex = 17
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cbGroupSearch
        '
        Me.cbGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroupSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbGroupSearch.FormattingEnabled = True
        Me.cbGroupSearch.Items.AddRange(New Object() {"Show all", "Turning", "Milling", "Drilling", "Tapping", "End milling", "Reaming", "Special", "Other"})
        Me.cbGroupSearch.Location = New System.Drawing.Point(95, 17)
        Me.cbGroupSearch.Name = "cbGroupSearch"
        Me.cbGroupSearch.Size = New System.Drawing.Size(229, 21)
        Me.cbGroupSearch.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Product group : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdBrand)
        Me.GroupBox2.Controls.Add(Me.cbBrand)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbMaterial)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbPartName)
        Me.GroupBox2.Controls.Add(Me.cbResult)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbGroup)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmdClearFile)
        Me.GroupBox2.Controls.Add(Me.cmdViewFile)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbFile)
        Me.GroupBox2.Controls.Add(Me.cmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdUpload)
        Me.GroupBox2.Controls.Add(Me.cmdSubmit)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbDetail)
        Me.GroupBox2.Controls.Add(Me.tbName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(989, 276)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TPR"
        '
        'cmdBrand
        '
        Me.cmdBrand.BackgroundImage = CType(resources.GetObject("cmdBrand.BackgroundImage"), System.Drawing.Image)
        Me.cmdBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBrand.FlatAppearance.BorderSize = 0
        Me.cmdBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrand.Location = New System.Drawing.Point(917, 59)
        Me.cmdBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrand.Name = "cmdBrand"
        Me.cmdBrand.Size = New System.Drawing.Size(23, 21)
        Me.cmdBrand.TabIndex = 33
        Me.cmdBrand.UseVisualStyleBackColor = True
        '
        'cbBrand
        '
        Me.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbBrand.FormattingEnabled = True
        Me.cbBrand.Items.AddRange(New Object() {"Success", "Fail"})
        Me.cbBrand.Location = New System.Drawing.Point(681, 59)
        Me.cbBrand.Name = "cbBrand"
        Me.cbBrand.Size = New System.Drawing.Size(229, 21)
        Me.cbBrand.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(634, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Brand :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(625, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Material :"
        '
        'tbMaterial
        '
        Me.tbMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbMaterial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbMaterial.Location = New System.Drawing.Point(681, 86)
        Me.tbMaterial.Name = "tbMaterial"
        Me.tbMaterial.Size = New System.Drawing.Size(229, 20)
        Me.tbMaterial.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(28, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Part name :"
        '
        'tbPartName
        '
        Me.tbPartName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbPartName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbPartName.Location = New System.Drawing.Point(95, 86)
        Me.tbPartName.Name = "tbPartName"
        Me.tbPartName.Size = New System.Drawing.Size(528, 20)
        Me.tbPartName.TabIndex = 27
        '
        'cbResult
        '
        Me.cbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbResult.FormattingEnabled = True
        Me.cbResult.Items.AddRange(New Object() {"Success", "Fail"})
        Me.cbResult.Location = New System.Drawing.Point(94, 222)
        Me.cbResult.Name = "cbResult"
        Me.cbResult.Size = New System.Drawing.Size(200, 21)
        Me.cbResult.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(42, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Result : "
        '
        'cbGroup
        '
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Items.AddRange(New Object() {"Turning", "Milling", "Drilling", "Tapping", "End milling", "Reaming", "Special", "Other"})
        Me.cbGroup.Location = New System.Drawing.Point(394, 59)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(229, 21)
        Me.cbGroup.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(305, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Product group : "
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(95, 58)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(53, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Date :"
        '
        'cmdClearFile
        '
        Me.cmdClearFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClearFile.BackColor = System.Drawing.Color.LightGray
        Me.cmdClearFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdClearFile.ForeColor = System.Drawing.Color.Black
        Me.cmdClearFile.Location = New System.Drawing.Point(880, 194)
        Me.cmdClearFile.Name = "cmdClearFile"
        Me.cmdClearFile.Size = New System.Drawing.Size(102, 23)
        Me.cmdClearFile.TabIndex = 16
        Me.cmdClearFile.Text = "Clear file"
        Me.cmdClearFile.UseVisualStyleBackColor = False
        '
        'cmdViewFile
        '
        Me.cmdViewFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdViewFile.BackColor = System.Drawing.Color.LightGray
        Me.cmdViewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdViewFile.ForeColor = System.Drawing.Color.Black
        Me.cmdViewFile.Location = New System.Drawing.Point(772, 194)
        Me.cmdViewFile.Name = "cmdViewFile"
        Me.cmdViewFile.Size = New System.Drawing.Size(102, 23)
        Me.cmdViewFile.TabIndex = 15
        Me.cmdViewFile.Text = "View file"
        Me.cmdViewFile.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(59, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "File :"
        '
        'tbFile
        '
        Me.tbFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbFile.Location = New System.Drawing.Point(95, 196)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.ReadOnly = True
        Me.tbFile.Size = New System.Drawing.Size(563, 20)
        Me.tbFile.TabIndex = 13
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "success_name"
        Me.Column2.HeaderText = "Subject"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'partname
        '
        Me.partname.DataPropertyName = "success_partname"
        Me.partname.HeaderText = "Part name"
        Me.partname.MinimumWidth = 150
        Me.partname.Name = "partname"
        Me.partname.ReadOnly = True
        Me.partname.Width = 150
        '
        'material
        '
        Me.material.DataPropertyName = "success_material"
        Me.material.HeaderText = "Material"
        Me.material.MinimumWidth = 150
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        Me.material.Width = 150
        '
        'success_brand
        '
        Me.success_brand.DataPropertyName = "success_brand"
        Me.success_brand.HeaderText = "Brand"
        Me.success_brand.MinimumWidth = 150
        Me.success_brand.Name = "success_brand"
        Me.success_brand.ReadOnly = True
        Me.success_brand.Width = 150
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "success_detail"
        Me.Column5.HeaderText = "Detail"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'result
        '
        Me.result.DataPropertyName = "success_result"
        Me.result.HeaderText = "Result"
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        '
        'colView
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        Me.colView.DefaultCellStyle = DataGridViewCellStyle3
        Me.colView.HeaderText = "View"
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        Me.colView.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colView.Text = "View"
        Me.colView.UseColumnTextForButtonValue = True
        Me.colView.Width = 60
        '
        'colEdit
        '
        Me.colEdit.DataPropertyName = "user_edit"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        Me.colEdit.DefaultCellStyle = DataGridViewCellStyle4
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Text = "Edit"
        Me.colEdit.UseColumnTextForButtonValue = True
        Me.colEdit.Width = 60
        '
        'colDel
        '
        Me.colDel.DataPropertyName = "user_del"
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
        'SuccessStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SuccessStory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSearch As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents tbDetail As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdUpload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdClearFile As Button
    Friend WithEvents cmdViewFile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbFile As TextBox
    Friend WithEvents cbResultSearch As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbGroupSearch As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cbResult As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbMaterial As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPartName As TextBox
    Friend WithEvents cbBrand As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdBrand As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents partname As DataGridViewTextBoxColumn
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents success_brand As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents result As DataGridViewTextBoxColumn
    Friend WithEvents colView As DataGridViewButtonColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDel As DataGridViewButtonColumn
End Class
