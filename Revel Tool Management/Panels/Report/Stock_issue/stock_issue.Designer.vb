<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock_issue
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.dt_stock_issueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rp_stock_issue = New Revel_Tool_Management.rp_stock_issue()
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbShowAll = New System.Windows.Forms.CheckBox()
        Me.cbProcessAll = New System.Windows.Forms.CheckBox()
        Me.cbMachineAll = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbOutProcess = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbOutMachine = New System.Windows.Forms.ComboBox()
        Me.cbJobAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbOutJob = New System.Windows.Forms.ComboBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        CType(Me.dt_stock_issueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_stock_issue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'rvView
        '
        Me.rvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "rp_stock_issue"
        ReportDataSource1.Value = Me.dt_stock_issueBindingSource
        Me.rvView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_issue.rdlc"
        Me.rvView.Location = New System.Drawing.Point(12, 128)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(1000, 507)
        Me.rvView.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbShowAll)
        Me.GroupBox1.Controls.Add(Me.cbProcessAll)
        Me.GroupBox1.Controls.Add(Me.cbMachineAll)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbOutProcess)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbOutMachine)
        Me.GroupBox1.Controls.Add(Me.cbJobAll)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbOutJob)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 110)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Parameter"
        '
        'cbShowAll
        '
        Me.cbShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbShowAll.AutoSize = True
        Me.cbShowAll.Location = New System.Drawing.Point(839, 77)
        Me.cbShowAll.Name = "cbShowAll"
        Me.cbShowAll.Size = New System.Drawing.Size(109, 17)
        Me.cbShowAll.TabIndex = 31
        Me.cbShowAll.Text = "Show all machine"
        Me.cbShowAll.UseVisualStyleBackColor = True
        '
        'cbProcessAll
        '
        Me.cbProcessAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProcessAll.AutoSize = True
        Me.cbProcessAll.Location = New System.Drawing.Point(767, 77)
        Me.cbProcessAll.Name = "cbProcessAll"
        Me.cbProcessAll.Size = New System.Drawing.Size(66, 17)
        Me.cbProcessAll.TabIndex = 30
        Me.cbProcessAll.Text = "Show all"
        Me.cbProcessAll.UseVisualStyleBackColor = True
        '
        'cbMachineAll
        '
        Me.cbMachineAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMachineAll.AutoSize = True
        Me.cbMachineAll.Location = New System.Drawing.Point(767, 49)
        Me.cbMachineAll.Name = "cbMachineAll"
        Me.cbMachineAll.Size = New System.Drawing.Size(66, 17)
        Me.cbMachineAll.TabIndex = 29
        Me.cbMachineAll.Text = "Show all"
        Me.cbMachineAll.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(310, 78)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Process :"
        '
        'cbOutProcess
        '
        Me.cbOutProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutProcess.FormattingEnabled = True
        Me.cbOutProcess.Location = New System.Drawing.Point(377, 75)
        Me.cbOutProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOutProcess.Name = "cbOutProcess"
        Me.cbOutProcess.Size = New System.Drawing.Size(383, 21)
        Me.cbOutProcess.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(315, 50)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Machine :"
        '
        'cbOutMachine
        '
        Me.cbOutMachine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutMachine.FormattingEnabled = True
        Me.cbOutMachine.Location = New System.Drawing.Point(377, 47)
        Me.cbOutMachine.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOutMachine.Name = "cbOutMachine"
        Me.cbOutMachine.Size = New System.Drawing.Size(383, 21)
        Me.cbOutMachine.TabIndex = 25
        '
        'cbJobAll
        '
        Me.cbJobAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbJobAll.AutoSize = True
        Me.cbJobAll.Location = New System.Drawing.Point(767, 20)
        Me.cbJobAll.Name = "cbJobAll"
        Me.cbJobAll.Size = New System.Drawing.Size(66, 17)
        Me.cbJobAll.TabIndex = 24
        Me.cbJobAll.Text = "Show all"
        Me.cbJobAll.UseVisualStyleBackColor = True
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
        'cbOutJob
        '
        Me.cbOutJob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutJob.FormattingEnabled = True
        Me.cbOutJob.Location = New System.Drawing.Point(377, 18)
        Me.cbOutJob.Margin = New System.Windows.Forms.Padding(4)
        Me.cbOutJob.Name = "cbOutJob"
        Me.cbOutJob.Size = New System.Drawing.Size(383, 21)
        Me.cbOutJob.TabIndex = 22
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
        Me.cmdSearch.Text = "View"
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
        'stock_issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rvView)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_issue"
        Me.Text = "Form1"
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
    Friend WithEvents cbOutJob As ComboBox
    Friend WithEvents cbJobAll As CheckBox
    Friend WithEvents cbProcessAll As CheckBox
    Friend WithEvents cbMachineAll As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbOutProcess As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbOutMachine As ComboBox
    Friend WithEvents cbShowAll As CheckBox
End Class
