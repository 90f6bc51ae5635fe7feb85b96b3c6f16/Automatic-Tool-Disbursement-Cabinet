<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Incident_Job

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Incident_Machine))
        Me.Incident_JobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Incident_Jobs = New Revel_Tool_Management.Incident_Jobs()
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbChartType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        CType(Me.Incident_JobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Incident_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Incident_JobsBindingSource
        '
        Me.Incident_JobsBindingSource.DataMember = "Incident_Jobs"
        Me.Incident_JobsBindingSource.DataSource = Me.Incident_Jobs
        '
        'Incident_Jobs
        '
        Me.Incident_Jobs.DataSetName = "Incident_Jobs"
        Me.Incident_Jobs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvView
        '
        Me.rvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Incident_Jobs"
        ReportDataSource1.Value = Me.Incident_JobsBindingSource
        Me.rvView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Machine.rdlc"
        Me.rvView.Location = New System.Drawing.Point(12, 76)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(984, 641)
        Me.rvView.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbChartType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 58)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Parameter"
        '
        'cbChartType
        '
        Me.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChartType.FormattingEnabled = True
        Me.cbChartType.Items.AddRange(New Object() {"Candle", "Pie", "Line"})
        Me.cbChartType.Location = New System.Drawing.Point(400, 18)
        Me.cbChartType.Name = "cbChartType"
        Me.cbChartType.Size = New System.Drawing.Size(229, 21)
        Me.cbChartType.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Chart type :"
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
        Me.cmdSearch.Location = New System.Drawing.Point(647, 15)
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
        'Incident_Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.rvView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Incident_Machine"
        Me.Text = "Incident_Madhine"
        CType(Me.Incident_JobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Incident_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents cmdSearch As Button
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Incident_JobsBindingSource As BindingSource
    Friend WithEvents Incident_Jobs As Incident_Jobs
    Friend WithEvents cbChartType As ComboBox
    Friend WithEvents Label4 As Label
End Class
