<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rp_log
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_logBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rp_log_db = New Revel_Tool_Management.rp_log_db()
        Me.dt_stock_issueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rp_stock_issue = New Revel_Tool_Management.rp_stock_issue()
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPageAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPage = New System.Windows.Forms.ComboBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        CType(Me.tb_logBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_log_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_stock_issueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_stock_issue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_logBindingSource
        '
        Me.tb_logBindingSource.DataMember = "tb_log"
        Me.tb_logBindingSource.DataSource = Me.rp_log_db
        '
        'rp_log_db
        '
        Me.rp_log_db.DataSetName = "rp_log_db"
        Me.rp_log_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dt_stock_issueBindingSource
        '
        Me.dt_stock_issueBindingSource.DataMember = "dt_stock_issue"
        Me.dt_stock_issueBindingSource.DataSource = Me.rp_stock_issue
        '
        'rp_stock_issue
        '
        Me.rp_stock_issue.DataSetName = "rp_stock_issue"
        Me.rp_stock_issue.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvView
        '
        Me.rvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_logBindingSource
        Me.rvView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_log_view.rdlc"
        Me.rvView.Location = New System.Drawing.Point(12, 75)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(1000, 560)
        Me.rvView.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbPageAll)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbPage)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 57)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Parameter"
        '
        'cbPageAll
        '
        Me.cbPageAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPageAll.AutoSize = True
        Me.cbPageAll.Location = New System.Drawing.Point(767, 20)
        Me.cbPageAll.Name = "cbPageAll"
        Me.cbPageAll.Size = New System.Drawing.Size(66, 17)
        Me.cbPageAll.TabIndex = 24
        Me.cbPageAll.Text = "Show all"
        Me.cbPageAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(339, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Job :"
        '
        'cbPage
        '
        Me.cbPage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPage.FormattingEnabled = True
        Me.cbPage.Items.AddRange(New Object() {"Stock Issue", "Stock Receive", "Tool Register", "Production", "Machine", "Supplier", "User", "Incident", "Success Story"})
        Me.cbPage.Location = New System.Drawing.Point(377, 18)
        Me.cbPage.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPage.Name = "cbPage"
        Me.cbPage.Size = New System.Drawing.Size(383, 21)
        Me.cbPage.TabIndex = 22
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(176, 19)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(154, 20)
        Me.dtpEnd.TabIndex = 19
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Location = New System.Drawing.Point(839, 18)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(155, 24)
        Me.cmdSearch.TabIndex = 21
        Me.cmdSearch.Text = "ดูรายงาน"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(6, 19)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(154, 20)
        Me.dtpStart.TabIndex = 18
        '
        'rp_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rvView)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rp_log"
        Me.Text = "Form1"
        CType(Me.tb_logBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_log_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_stock_issueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_stock_issue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents cmdSearch As Button
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dt_stock_issueBindingSource As BindingSource
    Friend WithEvents rp_stock_issue As rp_stock_issue
    Friend WithEvents Label5 As Label
    Friend WithEvents cbPage As ComboBox
    Friend WithEvents cbPageAll As CheckBox
    Friend WithEvents tb_logBindingSource As BindingSource
    Friend WithEvents rp_log_db As rp_log_db
End Class
