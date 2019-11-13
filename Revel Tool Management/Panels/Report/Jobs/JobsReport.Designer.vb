<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobsReport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.dt_stock_issueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rp_stock_issue = New Revel_Tool_Management.rp_stock_issue()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbOutJob = New System.Windows.Forms.ComboBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rp_jobs = New Revel_Tool_Management.rp_jobs()
        Me.rp_jobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAll = New System.Windows.Forms.CheckBox()
        CType(Me.dt_stock_issueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_stock_issue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.rp_jobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_jobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbAll)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbOutJob)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 58)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Parameter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Job :"
        '
        'cbOutJob
        '
        Me.cbOutJob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutJob.FormattingEnabled = True
        Me.cbOutJob.Location = New System.Drawing.Point(46, 21)
        Me.cbOutJob.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOutJob.Name = "cbOutJob"
        Me.cbOutJob.Size = New System.Drawing.Size(699, 21)
        Me.cbOutJob.TabIndex = 22
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
        'rvView
        '
        Me.rvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "rp_jobs"
        ReportDataSource3.Value = Me.rp_jobsBindingSource
        Me.rvView.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_jobs_table.rdlc"
        Me.rvView.Location = New System.Drawing.Point(4, 76)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(1000, 536)
        Me.rvView.TabIndex = 44
        '
        'rp_jobs
        '
        Me.rp_jobs.DataSetName = "rp_jobs"
        Me.rp_jobs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rp_jobsBindingSource
        '
        Me.rp_jobsBindingSource.DataMember = "rp_jobs"
        Me.rp_jobsBindingSource.DataSource = Me.rp_jobs
        '
        'cbAll
        '
        Me.cbAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(752, 23)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(66, 17)
        Me.cbAll.TabIndex = 24
        Me.cbAll.Text = "Show all"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'JobsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rvView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JobsReport"
        Me.Text = "JobsReport"
        CType(Me.dt_stock_issueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_stock_issue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.rp_jobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_jobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dt_stock_issueBindingSource As BindingSource
    Friend WithEvents rp_stock_issue As rp_stock_issue
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbOutJob As ComboBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents rvView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rp_jobsBindingSource As BindingSource
    Friend WithEvents rp_jobs As rp_jobs
    Friend WithEvents cbAll As CheckBox
End Class
