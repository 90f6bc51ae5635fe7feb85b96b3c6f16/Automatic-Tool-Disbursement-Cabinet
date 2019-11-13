<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserType
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserType))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbLicense1 = New System.Windows.Forms.CheckBox()
        Me.cbLicense5 = New System.Windows.Forms.CheckBox()
        Me.cbLicense2 = New System.Windows.Forms.CheckBox()
        Me.cbLicense3 = New System.Windows.Forms.CheckBox()
        Me.cbLicense6 = New System.Windows.Forms.CheckBox()
        Me.cbLicense10 = New System.Windows.Forms.CheckBox()
        Me.cbLicense8 = New System.Windows.Forms.CheckBox()
        Me.cbLicense4 = New System.Windows.Forms.CheckBox()
        Me.cbLicense9 = New System.Windows.Forms.CheckBox()
        Me.cbLicense7 = New System.Windows.Forms.CheckBox()
        Me.user_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_type_license1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.user_type_license10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(82, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(368, 20)
        Me.txtName.TabIndex = 1
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.Gold
        Me.cmdSubmit.FlatAppearance.BorderSize = 0
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSubmit.Location = New System.Drawing.Point(456, 8)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubmit.TabIndex = 2
        Me.cmdSubmit.Text = "Add"
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Gold
        Me.cmdClear.FlatAppearance.BorderSize = 0
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(537, 8)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
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
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_type, Me.user_type_license1, Me.user_type_license2, Me.user_type_license3, Me.user_type_license4, Me.user_type_license5, Me.user_type_license6, Me.user_type_license7, Me.user_type_license8, Me.user_type_license9, Me.user_type_license10, Me.colEdit, Me.colDel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData.GridColor = System.Drawing.Color.White
        Me.dgvData.Location = New System.Drawing.Point(12, 107)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(11)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData.Size = New System.Drawing.Size(984, 482)
        Me.dgvData.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "License"
        '
        'cbLicense1
        '
        Me.cbLicense1.AutoSize = True
        Me.cbLicense1.Location = New System.Drawing.Point(82, 51)
        Me.cbLicense1.Name = "cbLicense1"
        Me.cbLicense1.Size = New System.Drawing.Size(78, 17)
        Me.cbLicense1.TabIndex = 15
        Me.cbLicense1.Text = "1.Stock list"
        Me.cbLicense1.UseVisualStyleBackColor = True
        '
        'cbLicense5
        '
        Me.cbLicense5.AutoSize = True
        Me.cbLicense5.Location = New System.Drawing.Point(537, 51)
        Me.cbLicense5.Name = "cbLicense5"
        Me.cbLicense5.Size = New System.Drawing.Size(96, 17)
        Me.cbLicense5.TabIndex = 16
        Me.cbLicense5.Text = "5. Tool register"
        Me.cbLicense5.UseVisualStyleBackColor = True
        '
        'cbLicense2
        '
        Me.cbLicense2.AutoSize = True
        Me.cbLicense2.Location = New System.Drawing.Point(187, 51)
        Me.cbLicense2.Name = "cbLicense2"
        Me.cbLicense2.Size = New System.Drawing.Size(93, 17)
        Me.cbLicense2.TabIndex = 17
        Me.cbLicense2.Text = "2. Stock issue"
        Me.cbLicense2.UseVisualStyleBackColor = True
        '
        'cbLicense3
        '
        Me.cbLicense3.AutoSize = True
        Me.cbLicense3.Location = New System.Drawing.Point(303, 51)
        Me.cbLicense3.Name = "cbLicense3"
        Me.cbLicense3.Size = New System.Drawing.Size(104, 17)
        Me.cbLicense3.TabIndex = 18
        Me.cbLicense3.Text = "3. Stock receive"
        Me.cbLicense3.UseVisualStyleBackColor = True
        '
        'cbLicense6
        '
        Me.cbLicense6.AutoSize = True
        Me.cbLicense6.Location = New System.Drawing.Point(82, 73)
        Me.cbLicense6.Name = "cbLicense6"
        Me.cbLicense6.Size = New System.Drawing.Size(97, 17)
        Me.cbLicense6.TabIndex = 20
        Me.cbLicense6.Text = "6. Stock layout"
        Me.cbLicense6.UseVisualStyleBackColor = True
        '
        'cbLicense10
        '
        Me.cbLicense10.AutoSize = True
        Me.cbLicense10.Location = New System.Drawing.Point(537, 73)
        Me.cbLicense10.Name = "cbLicense10"
        Me.cbLicense10.Size = New System.Drawing.Size(94, 17)
        Me.cbLicense10.TabIndex = 29
        Me.cbLicense10.Text = "10. Innovation"
        Me.cbLicense10.UseVisualStyleBackColor = True
        '
        'cbLicense8
        '
        Me.cbLicense8.AutoSize = True
        Me.cbLicense8.Location = New System.Drawing.Point(303, 73)
        Me.cbLicense8.Name = "cbLicense8"
        Me.cbLicense8.Size = New System.Drawing.Size(70, 17)
        Me.cbLicense8.TabIndex = 28
        Me.cbLicense8.Text = "8. Report"
        Me.cbLicense8.UseVisualStyleBackColor = True
        '
        'cbLicense4
        '
        Me.cbLicense4.AutoSize = True
        Me.cbLicense4.Location = New System.Drawing.Point(419, 51)
        Me.cbLicense4.Name = "cbLicense4"
        Me.cbLicense4.Size = New System.Drawing.Size(76, 17)
        Me.cbLicense4.TabIndex = 27
        Me.cbLicense4.Text = "4. Reorder"
        Me.cbLicense4.UseVisualStyleBackColor = True
        '
        'cbLicense9
        '
        Me.cbLicense9.AutoSize = True
        Me.cbLicense9.Location = New System.Drawing.Point(419, 73)
        Me.cbLicense9.Name = "cbLicense9"
        Me.cbLicense9.Size = New System.Drawing.Size(60, 17)
        Me.cbLicense9.TabIndex = 25
        Me.cbLicense9.Text = "9. User"
        Me.cbLicense9.UseVisualStyleBackColor = True
        '
        'cbLicense7
        '
        Me.cbLicense7.AutoSize = True
        Me.cbLicense7.Location = New System.Drawing.Point(187, 74)
        Me.cbLicense7.Name = "cbLicense7"
        Me.cbLicense7.Size = New System.Drawing.Size(76, 17)
        Me.cbLicense7.TabIndex = 24
        Me.cbLicense7.Text = "7. Supplier"
        Me.cbLicense7.UseVisualStyleBackColor = True
        '
        'user_type
        '
        Me.user_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_type.DataPropertyName = "user_type_name"
        Me.user_type.HeaderText = "Type name"
        Me.user_type.Name = "user_type"
        Me.user_type.ReadOnly = True
        '
        'user_type_license1
        '
        Me.user_type_license1.DataPropertyName = "user_type_license1"
        Me.user_type_license1.FalseValue = "0"
        Me.user_type_license1.HeaderText = "1"
        Me.user_type_license1.IndeterminateValue = "0"
        Me.user_type_license1.Name = "user_type_license1"
        Me.user_type_license1.ReadOnly = True
        Me.user_type_license1.TrueValue = "1"
        Me.user_type_license1.Width = 35
        '
        'user_type_license2
        '
        Me.user_type_license2.DataPropertyName = "user_type_license2"
        Me.user_type_license2.FalseValue = "0"
        Me.user_type_license2.HeaderText = "2"
        Me.user_type_license2.IndeterminateValue = "0"
        Me.user_type_license2.Name = "user_type_license2"
        Me.user_type_license2.ReadOnly = True
        Me.user_type_license2.TrueValue = "1"
        Me.user_type_license2.Width = 35
        '
        'user_type_license3
        '
        Me.user_type_license3.DataPropertyName = "user_type_license3"
        Me.user_type_license3.FalseValue = "0"
        Me.user_type_license3.HeaderText = "3"
        Me.user_type_license3.IndeterminateValue = "0"
        Me.user_type_license3.Name = "user_type_license3"
        Me.user_type_license3.ReadOnly = True
        Me.user_type_license3.TrueValue = "1"
        Me.user_type_license3.Width = 35
        '
        'user_type_license4
        '
        Me.user_type_license4.DataPropertyName = "user_type_license4"
        Me.user_type_license4.FalseValue = "0"
        Me.user_type_license4.HeaderText = "4"
        Me.user_type_license4.IndeterminateValue = "0"
        Me.user_type_license4.Name = "user_type_license4"
        Me.user_type_license4.ReadOnly = True
        Me.user_type_license4.TrueValue = "1"
        Me.user_type_license4.Width = 35
        '
        'user_type_license5
        '
        Me.user_type_license5.DataPropertyName = "user_type_license5"
        Me.user_type_license5.FalseValue = "0"
        Me.user_type_license5.HeaderText = "5"
        Me.user_type_license5.IndeterminateValue = "0"
        Me.user_type_license5.Name = "user_type_license5"
        Me.user_type_license5.ReadOnly = True
        Me.user_type_license5.TrueValue = "1"
        Me.user_type_license5.Width = 35
        '
        'user_type_license6
        '
        Me.user_type_license6.DataPropertyName = "user_type_license6"
        Me.user_type_license6.FalseValue = "0"
        Me.user_type_license6.HeaderText = "6"
        Me.user_type_license6.IndeterminateValue = "0"
        Me.user_type_license6.Name = "user_type_license6"
        Me.user_type_license6.ReadOnly = True
        Me.user_type_license6.TrueValue = "1"
        Me.user_type_license6.Width = 35
        '
        'user_type_license7
        '
        Me.user_type_license7.DataPropertyName = "user_type_license7"
        Me.user_type_license7.FalseValue = "0"
        Me.user_type_license7.HeaderText = "7"
        Me.user_type_license7.IndeterminateValue = "0"
        Me.user_type_license7.Name = "user_type_license7"
        Me.user_type_license7.ReadOnly = True
        Me.user_type_license7.TrueValue = "1"
        Me.user_type_license7.Width = 35
        '
        'user_type_license8
        '
        Me.user_type_license8.DataPropertyName = "user_type_license8"
        Me.user_type_license8.FalseValue = "0"
        Me.user_type_license8.HeaderText = "8"
        Me.user_type_license8.IndeterminateValue = "0"
        Me.user_type_license8.Name = "user_type_license8"
        Me.user_type_license8.ReadOnly = True
        Me.user_type_license8.TrueValue = "1"
        Me.user_type_license8.Width = 35
        '
        'user_type_license9
        '
        Me.user_type_license9.DataPropertyName = "user_type_license9"
        Me.user_type_license9.FalseValue = "0"
        Me.user_type_license9.HeaderText = "9"
        Me.user_type_license9.IndeterminateValue = "0"
        Me.user_type_license9.Name = "user_type_license9"
        Me.user_type_license9.ReadOnly = True
        Me.user_type_license9.TrueValue = "1"
        Me.user_type_license9.Width = 35
        '
        'user_type_license10
        '
        Me.user_type_license10.DataPropertyName = "user_type_license10"
        Me.user_type_license10.FalseValue = "0"
        Me.user_type_license10.HeaderText = "10"
        Me.user_type_license10.IndeterminateValue = "0"
        Me.user_type_license10.Name = "user_type_license10"
        Me.user_type_license10.ReadOnly = True
        Me.user_type_license10.TrueValue = "0"
        Me.user_type_license10.Width = 35
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEdit.Text = "Edit"
        Me.colEdit.UseColumnTextForButtonValue = True
        Me.colEdit.Width = 50
        '
        'colDel
        '
        Me.colDel.HeaderText = "Del."
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDel.Text = "Del."
        Me.colDel.UseColumnTextForButtonValue = True
        Me.colDel.Width = 50
        '
        'UserType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.cbLicense10)
        Me.Controls.Add(Me.cbLicense8)
        Me.Controls.Add(Me.cbLicense4)
        Me.Controls.Add(Me.cbLicense9)
        Me.Controls.Add(Me.cbLicense7)
        Me.Controls.Add(Me.cbLicense6)
        Me.Controls.Add(Me.cbLicense3)
        Me.Controls.Add(Me.cbLicense2)
        Me.Controls.Add(Me.cbLicense5)
        Me.Controls.Add(Me.cbLicense1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 640)
        Me.MinimumSize = New System.Drawing.Size(1024, 480)
        Me.Name = "UserType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User type"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents cbLicense1 As CheckBox
    Friend WithEvents cbLicense5 As CheckBox
    Friend WithEvents cbLicense2 As CheckBox
    Friend WithEvents cbLicense3 As CheckBox
    Friend WithEvents cbLicense6 As CheckBox
    Friend WithEvents cbLicense10 As CheckBox
    Friend WithEvents cbLicense8 As CheckBox
    Friend WithEvents cbLicense4 As CheckBox
    Friend WithEvents cbLicense9 As CheckBox
    Friend WithEvents cbLicense7 As CheckBox
    Friend WithEvents user_type As DataGridViewTextBoxColumn
    Friend WithEvents user_type_license1 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license2 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license3 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license4 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license5 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license6 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license7 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license8 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license9 As DataGridViewCheckBoxColumn
    Friend WithEvents user_type_license10 As DataGridViewCheckBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDel As DataGridViewButtonColumn
End Class
