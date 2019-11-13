<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rp_restock
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rp_re_stock = New Revel_Tool_Management.rp_re_stock()
        Me.GroupBox1.SuspendLayout()
        CType(Me.rp_re_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 58)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Parameter"
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
        Me.cmdSearch.Location = New System.Drawing.Point(342, 15)
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
        'rvView
        '
        Me.rvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "rp_stock_issue"
        ReportDataSource1.Value = Nothing
        Me.rvView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_restock_table.rdlc"
        Me.rvView.Location = New System.Drawing.Point(12, 76)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(1000, 559)
        Me.rvView.TabIndex = 43
        '
        'rp_re_stock
        '
        Me.rp_re_stock.DataSetName = "rp_re_stock"
        Me.rp_re_stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rp_restock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.rvView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rp_restock"
        Me.Text = "rp_restock"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.rp_re_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents cmdSearch As Button
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents rvView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rp_re_stock As rp_re_stock
End Class
