<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.cmdInnovation = New System.Windows.Forms.Button()
        Me.cmdStock = New System.Windows.Forms.Button()
        Me.cmdRestock = New System.Windows.Forms.Button()
        Me.cmdProducts = New System.Windows.Forms.Button()
        Me.cmdStockIssue = New System.Windows.Forms.Button()
        Me.cmdStockLayout = New System.Windows.Forms.Button()
        Me.cmdUrgentStock = New System.Windows.Forms.Button()
        Me.cmdSupplier = New System.Windows.Forms.Button()
        Me.cmdReports = New System.Windows.Forms.Button()
        Me.cmdUsers = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1003, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Sale"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1001, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Thana"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdLogout)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 96)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Revel_Tool_Management.My.Resources.Resources.header
        Me.PictureBox1.Image = Global.Revel_Tool_Management.My.Resources.Resources.header
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'pbUser
        '
        Me.pbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbUser.ErrorImage = Global.Revel_Tool_Management.My.Resources.Resources.admin
        Me.pbUser.Image = Global.Revel_Tool_Management.My.Resources.Resources.admin
        Me.pbUser.InitialImage = Global.Revel_Tool_Management.My.Resources.Resources.admin
        Me.pbUser.Location = New System.Drawing.Point(943, 20)
        Me.pbUser.Margin = New System.Windows.Forms.Padding(2)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(48, 52)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUser.TabIndex = 16
        Me.pbUser.TabStop = False
        '
        'cmdLogout
        '
        Me.cmdLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLogout.FlatAppearance.BorderSize = 0
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.Color.White
        Me.cmdLogout.Image = CType(resources.GetObject("cmdLogout.Image"), System.Drawing.Image)
        Me.cmdLogout.Location = New System.Drawing.Point(1184, 0)
        Me.cmdLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(96, 96)
        Me.cmdLogout.TabIndex = 15
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'pnMain
        '
        Me.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnMain.Controls.Add(Me.cmdInnovation)
        Me.pnMain.Controls.Add(Me.cmdStock)
        Me.pnMain.Controls.Add(Me.cmdRestock)
        Me.pnMain.Controls.Add(Me.cmdProducts)
        Me.pnMain.Controls.Add(Me.cmdStockIssue)
        Me.pnMain.Controls.Add(Me.cmdStockLayout)
        Me.pnMain.Controls.Add(Me.cmdUrgentStock)
        Me.pnMain.Controls.Add(Me.cmdSupplier)
        Me.pnMain.Controls.Add(Me.cmdReports)
        Me.pnMain.Controls.Add(Me.cmdUsers)
        Me.pnMain.Location = New System.Drawing.Point(127, 140)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1038, 521)
        Me.pnMain.TabIndex = 23
        '
        'cmdInnovation
        '
        Me.cmdInnovation.FlatAppearance.BorderSize = 0
        Me.cmdInnovation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdInnovation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdInnovation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInnovation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdInnovation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdInnovation.Image = Global.Revel_Tool_Management.My.Resources.Resources.innovation
        Me.cmdInnovation.Location = New System.Drawing.Point(827, 141)
        Me.cmdInnovation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdInnovation.Name = "cmdInnovation"
        Me.cmdInnovation.Size = New System.Drawing.Size(200, 120)
        Me.cmdInnovation.TabIndex = 24
        Me.cmdInnovation.UseVisualStyleBackColor = False
        '
        'cmdStock
        '
        Me.cmdStock.FlatAppearance.BorderSize = 0
        Me.cmdStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdStock.Image = Global.Revel_Tool_Management.My.Resources.Resources.inventory_stock_list
        Me.cmdStock.Location = New System.Drawing.Point(11, 17)
        Me.cmdStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdStock.Name = "cmdStock"
        Me.cmdStock.Size = New System.Drawing.Size(200, 120)
        Me.cmdStock.TabIndex = 3
        Me.cmdStock.UseVisualStyleBackColor = False
        '
        'cmdRestock
        '
        Me.cmdRestock.FlatAppearance.BorderSize = 0
        Me.cmdRestock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdRestock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdRestock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdRestock.Image = Global.Revel_Tool_Management.My.Resources.Resources.inventory_restock
        Me.cmdRestock.Location = New System.Drawing.Point(419, 17)
        Me.cmdRestock.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRestock.Name = "cmdRestock"
        Me.cmdRestock.Size = New System.Drawing.Size(200, 120)
        Me.cmdRestock.TabIndex = 20
        Me.cmdRestock.UseVisualStyleBackColor = False
        '
        'cmdProducts
        '
        Me.cmdProducts.FlatAppearance.BorderSize = 0
        Me.cmdProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdProducts.Image = Global.Revel_Tool_Management.My.Resources.Resources.product
        Me.cmdProducts.Location = New System.Drawing.Point(623, 17)
        Me.cmdProducts.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdProducts.Name = "cmdProducts"
        Me.cmdProducts.Size = New System.Drawing.Size(200, 120)
        Me.cmdProducts.TabIndex = 6
        Me.cmdProducts.UseVisualStyleBackColor = False
        '
        'cmdStockIssue
        '
        Me.cmdStockIssue.FlatAppearance.BorderSize = 0
        Me.cmdStockIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdStockIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdStockIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStockIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdStockIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdStockIssue.Image = Global.Revel_Tool_Management.My.Resources.Resources.inventory_stock_issue
        Me.cmdStockIssue.Location = New System.Drawing.Point(215, 17)
        Me.cmdStockIssue.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdStockIssue.Name = "cmdStockIssue"
        Me.cmdStockIssue.Size = New System.Drawing.Size(200, 120)
        Me.cmdStockIssue.TabIndex = 19
        Me.cmdStockIssue.UseVisualStyleBackColor = False
        '
        'cmdStockLayout
        '
        Me.cmdStockLayout.FlatAppearance.BorderSize = 0
        Me.cmdStockLayout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdStockLayout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdStockLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStockLayout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdStockLayout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdStockLayout.Image = Global.Revel_Tool_Management.My.Resources.Resources.layout_south
        Me.cmdStockLayout.Location = New System.Drawing.Point(827, 17)
        Me.cmdStockLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdStockLayout.Name = "cmdStockLayout"
        Me.cmdStockLayout.Size = New System.Drawing.Size(200, 120)
        Me.cmdStockLayout.TabIndex = 7
        Me.cmdStockLayout.UseVisualStyleBackColor = False
        '
        'cmdUrgentStock
        '
        Me.cmdUrgentStock.FlatAppearance.BorderSize = 0
        Me.cmdUrgentStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdUrgentStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdUrgentStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUrgentStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdUrgentStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdUrgentStock.Image = Global.Revel_Tool_Management.My.Resources.Resources.urgent
        Me.cmdUrgentStock.Location = New System.Drawing.Point(623, 141)
        Me.cmdUrgentStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdUrgentStock.Name = "cmdUrgentStock"
        Me.cmdUrgentStock.Size = New System.Drawing.Size(200, 120)
        Me.cmdUrgentStock.TabIndex = 14
        Me.cmdUrgentStock.UseVisualStyleBackColor = False
        '
        'cmdSupplier
        '
        Me.cmdSupplier.FlatAppearance.BorderSize = 0
        Me.cmdSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdSupplier.Image = Global.Revel_Tool_Management.My.Resources.Resources.suppliers
        Me.cmdSupplier.Location = New System.Drawing.Point(11, 141)
        Me.cmdSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSupplier.Name = "cmdSupplier"
        Me.cmdSupplier.Size = New System.Drawing.Size(200, 120)
        Me.cmdSupplier.TabIndex = 8
        Me.cmdSupplier.UseVisualStyleBackColor = False
        '
        'cmdReports
        '
        Me.cmdReports.FlatAppearance.BorderSize = 0
        Me.cmdReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdReports.Image = Global.Revel_Tool_Management.My.Resources.Resources.report1
        Me.cmdReports.Location = New System.Drawing.Point(215, 141)
        Me.cmdReports.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(200, 120)
        Me.cmdReports.TabIndex = 13
        Me.cmdReports.UseVisualStyleBackColor = False
        '
        'cmdUsers
        '
        Me.cmdUsers.FlatAppearance.BorderSize = 0
        Me.cmdUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdUsers.Image = Global.Revel_Tool_Management.My.Resources.Resources.user
        Me.cmdUsers.Location = New System.Drawing.Point(419, 141)
        Me.cmdUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(200, 120)
        Me.cmdUsers.TabIndex = 12
        Me.cmdUsers.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 738)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(594, 597)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "หน้าหลัก"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdStock As Button
    Friend WithEvents cmdSupplier As Button
    Friend WithEvents cmdStockLayout As Button
    Friend WithEvents cmdProducts As Button
    Friend WithEvents cmdUrgentStock As Button
    Friend WithEvents cmdReports As Button
    Friend WithEvents cmdUsers As Button
    Friend WithEvents cmdLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents cmdStockIssue As Button
    Friend WithEvents cmdRestock As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnMain As Panel
    Friend WithEvents cmdInnovation As Button
End Class
