<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Root
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Root))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.cmdInnovation = New System.Windows.Forms.Button()
        Me.cmdStock = New System.Windows.Forms.Button()
        Me.cmdProduction = New System.Windows.Forms.Button()
        Me.cmdRestock = New System.Windows.Forms.Button()
        Me.cmdProducts = New System.Windows.Forms.Button()
        Me.cmdStockIssue = New System.Windows.Forms.Button()
        Me.cmdUrgentStock = New System.Windows.Forms.Button()
        Me.cmdReports = New System.Windows.Forms.Button()
        Me.cmdIncidents = New System.Windows.Forms.Button()
        Me.cmdToolLifeRecords = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMain.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 25
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1040, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Thana"
        '
        'pbUser
        '
        Me.pbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbUser.ErrorImage = Global.Revel_Tool_Management.My.Resources.Resources.admin
        Me.pbUser.Image = Global.Revel_Tool_Management.My.Resources.Resources.admin
        Me.pbUser.InitialImage = Global.Revel_Tool_Management.My.Resources.Resources.admin
        Me.pbUser.Location = New System.Drawing.Point(982, 20)
        Me.pbUser.Margin = New System.Windows.Forms.Padding(2)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(48, 52)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUser.TabIndex = 16
        Me.pbUser.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1042, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Sale"
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
        Me.pnMain.Controls.Add(Me.cmdInnovation)
        Me.pnMain.Controls.Add(Me.cmdStock)
        Me.pnMain.Controls.Add(Me.cmdProduction)
        Me.pnMain.Controls.Add(Me.cmdRestock)
        Me.pnMain.Controls.Add(Me.cmdProducts)
        Me.pnMain.Controls.Add(Me.cmdStockIssue)
        Me.pnMain.Controls.Add(Me.cmdUrgentStock)
        Me.pnMain.Controls.Add(Me.cmdReports)
        Me.pnMain.Controls.Add(Me.cmdIncidents)
        Me.pnMain.Controls.Add(Me.cmdToolLifeRecords)
        Me.pnMain.Location = New System.Drawing.Point(159, 215)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1021, 254)
        Me.pnMain.TabIndex = 26
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
        Me.cmdInnovation.Location = New System.Drawing.Point(818, 126)
        Me.cmdInnovation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdInnovation.Name = "cmdInnovation"
        Me.cmdInnovation.Size = New System.Drawing.Size(200, 120)
        Me.cmdInnovation.TabIndex = 23
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
        Me.cmdStock.Location = New System.Drawing.Point(2, 2)
        Me.cmdStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdStock.Name = "cmdStock"
        Me.cmdStock.Size = New System.Drawing.Size(200, 120)
        Me.cmdStock.TabIndex = 3
        Me.cmdStock.UseVisualStyleBackColor = False
        '
        'cmdProduction
        '
        Me.cmdProduction.FlatAppearance.BorderSize = 0
        Me.cmdProduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdProduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdProduction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdProduction.Image = Global.Revel_Tool_Management.My.Resources.Resources.production
        Me.cmdProduction.Location = New System.Drawing.Point(207, 126)
        Me.cmdProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdProduction.Name = "cmdProduction"
        Me.cmdProduction.Size = New System.Drawing.Size(200, 120)
        Me.cmdProduction.TabIndex = 5
        Me.cmdProduction.UseVisualStyleBackColor = False
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
        Me.cmdRestock.Location = New System.Drawing.Point(410, 2)
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
        Me.cmdProducts.Location = New System.Drawing.Point(410, 126)
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
        Me.cmdStockIssue.Location = New System.Drawing.Point(206, 2)
        Me.cmdStockIssue.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdStockIssue.Name = "cmdStockIssue"
        Me.cmdStockIssue.Size = New System.Drawing.Size(200, 120)
        Me.cmdStockIssue.TabIndex = 19
        Me.cmdStockIssue.UseVisualStyleBackColor = False
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
        Me.cmdUrgentStock.Location = New System.Drawing.Point(3, 126)
        Me.cmdUrgentStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdUrgentStock.Name = "cmdUrgentStock"
        Me.cmdUrgentStock.Size = New System.Drawing.Size(200, 120)
        Me.cmdUrgentStock.TabIndex = 14
        Me.cmdUrgentStock.UseVisualStyleBackColor = False
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
        Me.cmdReports.Location = New System.Drawing.Point(614, 126)
        Me.cmdReports.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(200, 120)
        Me.cmdReports.TabIndex = 13
        Me.cmdReports.UseVisualStyleBackColor = False
        '
        'cmdIncidents
        '
        Me.cmdIncidents.FlatAppearance.BorderSize = 0
        Me.cmdIncidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIncidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIncidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIncidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdIncidents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdIncidents.Image = Global.Revel_Tool_Management.My.Resources.Resources.warning
        Me.cmdIncidents.Location = New System.Drawing.Point(614, 2)
        Me.cmdIncidents.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdIncidents.Name = "cmdIncidents"
        Me.cmdIncidents.Size = New System.Drawing.Size(200, 120)
        Me.cmdIncidents.TabIndex = 10
        Me.cmdIncidents.UseVisualStyleBackColor = False
        '
        'cmdToolLifeRecords
        '
        Me.cmdToolLifeRecords.FlatAppearance.BorderSize = 0
        Me.cmdToolLifeRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdToolLifeRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdToolLifeRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdToolLifeRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdToolLifeRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdToolLifeRecords.Image = Global.Revel_Tool_Management.My.Resources.Resources.record
        Me.cmdToolLifeRecords.Location = New System.Drawing.Point(818, 2)
        Me.cmdToolLifeRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdToolLifeRecords.Name = "cmdToolLifeRecords"
        Me.cmdToolLifeRecords.Size = New System.Drawing.Size(200, 120)
        Me.cmdToolLifeRecords.TabIndex = 11
        Me.cmdToolLifeRecords.UseVisualStyleBackColor = False
        '
        'Root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Root"
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
    Friend WithEvents cmdProduction As Button
    Friend WithEvents cmdRestock As Button
    Friend WithEvents cmdProducts As Button
    Friend WithEvents cmdStockIssue As Button
    Friend WithEvents cmdUrgentStock As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdLogout As Button
    Friend WithEvents cmdReports As Button
    Friend WithEvents cmdIncidents As Button
    Friend WithEvents cmdToolLifeRecords As Button
    Friend WithEvents pnMain As Panel
    Friend WithEvents cmdInnovation As Button
End Class
