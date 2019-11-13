<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderManage))
        Me.dgvAll = New System.Windows.Forms.DataGridView()
        Me.order_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_send = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colview = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdOutSearch = New System.Windows.Forms.Button()
        Me.dtpEnds = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmdOrder = New System.Windows.Forms.Button()
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.order_date, Me.order_by, Me.order_name, Me.order_remark, Me.order_id, Me.order_send, Me.colview})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAll.GridColor = System.Drawing.Color.White
        Me.dgvAll.Location = New System.Drawing.Point(12, 59)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.ReadOnly = True
        Me.dgvAll.RowTemplate.Height = 30
        Me.dgvAll.Size = New System.Drawing.Size(1252, 494)
        Me.dgvAll.TabIndex = 9
        '
        'order_date
        '
        Me.order_date.DataPropertyName = "order_date"
        Me.order_date.HeaderText = "Order Date"
        Me.order_date.Name = "order_date"
        Me.order_date.ReadOnly = True
        Me.order_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.order_date.Width = 150
        '
        'order_by
        '
        Me.order_by.DataPropertyName = "order_by"
        Me.order_by.HeaderText = "order_by"
        Me.order_by.Name = "order_by"
        Me.order_by.ReadOnly = True
        Me.order_by.Visible = False
        '
        'order_name
        '
        Me.order_name.DataPropertyName = "order_name"
        Me.order_name.HeaderText = "Order By"
        Me.order_name.Name = "order_name"
        Me.order_name.ReadOnly = True
        Me.order_name.Width = 150
        '
        'order_remark
        '
        Me.order_remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.order_remark.DataPropertyName = "order_remark"
        Me.order_remark.HeaderText = "Remark"
        Me.order_remark.Name = "order_remark"
        Me.order_remark.ReadOnly = True
        Me.order_remark.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'order_id
        '
        Me.order_id.DataPropertyName = "order_id"
        Me.order_id.HeaderText = "order_id"
        Me.order_id.Name = "order_id"
        Me.order_id.ReadOnly = True
        Me.order_id.Visible = False
        '
        'order_send
        '
        Me.order_send.DataPropertyName = "order_send"
        Me.order_send.HeaderText = "Status"
        Me.order_send.Name = "order_send"
        Me.order_send.ReadOnly = True
        '
        'colview
        '
        Me.colview.HeaderText = ""
        Me.colview.Name = "colview"
        Me.colview.ReadOnly = True
        Me.colview.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colview.Text = "Manage"
        Me.colview.UseColumnTextForButtonValue = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.Color.Gold
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(1124, 559)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(140, 38)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdOutSearch)
        Me.GroupBox3.Controls.Add(Me.dtpEnds)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpStart)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.tbSearch)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1248, 52)
        Me.GroupBox3.TabIndex = 12
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
        'dtpEnds
        '
        Me.dtpEnds.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEnds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnds.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnds.Location = New System.Drawing.Point(989, 20)
        Me.dtpEnds.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEnds.Name = "dtpEnds"
        Me.dtpEnds.Size = New System.Drawing.Size(199, 19)
        Me.dtpEnds.TabIndex = 30
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
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(717, 20)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(199, 19)
        Me.dtpStart.TabIndex = 28
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
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(85, 20)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(555, 19)
        Me.tbSearch.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 23)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Search :"
        '
        'cmdOrder
        '
        Me.cmdOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrder.BackColor = System.Drawing.Color.Gold
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(978, 559)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(140, 38)
        Me.cmdOrder.TabIndex = 13
        Me.cmdOrder.Text = "Add Order"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'OrderManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 601)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.dgvAll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAll As DataGridView
    Friend WithEvents cmdClose As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdOutSearch As Button
    Friend WithEvents dtpEnds As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents order_date As DataGridViewTextBoxColumn
    Friend WithEvents order_by As DataGridViewTextBoxColumn
    Friend WithEvents order_name As DataGridViewTextBoxColumn
    Friend WithEvents order_remark As DataGridViewTextBoxColumn
    Friend WithEvents order_id As DataGridViewTextBoxColumn
    Friend WithEvents order_send As DataGridViewTextBoxColumn
    Friend WithEvents colview As DataGridViewButtonColumn
    Friend WithEvents cmdOrder As Button
End Class
