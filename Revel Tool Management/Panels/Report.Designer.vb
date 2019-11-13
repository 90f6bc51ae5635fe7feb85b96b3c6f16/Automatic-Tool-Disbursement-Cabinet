<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CPP by job")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CPP by process")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cost by job")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cost by OP")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tooling cost by process")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tooling cost by machine")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tooling cost by product code")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool issue")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool issue by product cost")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool receive")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool receive by product cost")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly report", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by job")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by OP")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by machine")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by process")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by brand")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by supplier")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by product code")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by product group")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary by product type")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary report", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock list")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock receiving")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock issuing")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock issuing by job")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock movement report", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Machine")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product code")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Abnormal report", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool life Avg.")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool life by process")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool life record", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34})
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job cpp analysis")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job cost analysis")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool process cpp anlysis")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tool process cost analysis")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product cost analysis")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40})
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Data Log")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.tvReport = New System.Windows.Forms.TreeView()
        Me.pnReport = New System.Windows.Forms.Panel()
        Me.cmdSetting = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tvReport
        '
        Me.tvReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvReport.Location = New System.Drawing.Point(12, 12)
        Me.tvReport.Name = "tvReport"
        TreeNode1.Name = "JobCPP"
        TreeNode1.Tag = "JobCPP"
        TreeNode1.Text = "CPP by job"
        TreeNode2.Name = "Node0"
        TreeNode2.Tag = "ProcessCPP"
        TreeNode2.Text = "CPP by process"
        TreeNode3.Name = "Node1"
        TreeNode3.Tag = "JobCost"
        TreeNode3.Text = "Cost by job"
        TreeNode4.Name = "Node2"
        TreeNode4.Tag = "JobOperationCost"
        TreeNode4.Text = "Cost by OP"
        TreeNode5.Name = "Node3"
        TreeNode5.Tag = "JobProcessCost"
        TreeNode5.Text = "Tooling cost by process"
        TreeNode6.Name = "Node4"
        TreeNode6.Tag = "MachineCost"
        TreeNode6.Text = "Tooling cost by machine"
        TreeNode7.Name = "Node5"
        TreeNode7.Tag = "ProductCost"
        TreeNode7.Text = "Tooling cost by product code"
        TreeNode8.Name = "Node6"
        TreeNode8.Tag = "StockIssueCost"
        TreeNode8.Text = "Tool issue"
        TreeNode9.Name = "Node0"
        TreeNode9.Tag = "StockIssueProductCost"
        TreeNode9.Text = "Tool issue by product cost"
        TreeNode10.Name = "Node7"
        TreeNode10.Tag = "RestockCost"
        TreeNode10.Text = "Tool receive"
        TreeNode11.Name = "Node0"
        TreeNode11.Tag = "RestockProductCost"
        TreeNode11.Text = "Tool receive by product cost"
        TreeNode12.Name = "Node0"
        TreeNode12.Tag = "jobMonth"
        TreeNode12.Text = "Monthly report"
        TreeNode13.Name = "Node0"
        TreeNode13.Tag = "ndSJobs"
        TreeNode13.Text = "Summary by job"
        TreeNode14.Name = "Node2"
        TreeNode14.Tag = "ndSOperations"
        TreeNode14.Text = "Summary by OP"
        TreeNode15.Name = "Node1"
        TreeNode15.Tag = "ndSMachines"
        TreeNode15.Text = "Summary by machine"
        TreeNode16.Name = "Node3"
        TreeNode16.Tag = "ndSProcess"
        TreeNode16.Text = "Summary by process"
        TreeNode17.Name = "Node5"
        TreeNode17.Tag = "ndSProductBrands"
        TreeNode17.Text = "Summary by brand"
        TreeNode18.Name = "Node8"
        TreeNode18.Tag = "ndSSuppliers"
        TreeNode18.Text = "Summary by supplier"
        TreeNode19.Name = "Node4"
        TreeNode19.Tag = "ndSProducts"
        TreeNode19.Text = "Summary by product code"
        TreeNode20.Name = "Node6"
        TreeNode20.Tag = "ndSProductGroups"
        TreeNode20.Text = "Summary by product group"
        TreeNode21.Name = "Node7"
        TreeNode21.Tag = "ndSProductTypes"
        TreeNode21.Text = "Summary by product type"
        TreeNode22.Name = "ndStock"
        TreeNode22.Tag = "ndStock"
        TreeNode22.Text = "Summary report"
        TreeNode23.Name = "StockList"
        TreeNode23.Tag = "ndStockList"
        TreeNode23.Text = "Stock list"
        TreeNode24.Name = "ReStock"
        TreeNode24.Tag = "ndReStock"
        TreeNode24.Text = "Stock receiving"
        TreeNode25.Name = "Stock Issue"
        TreeNode25.Tag = "ndIssue"
        TreeNode25.Text = "Stock issuing"
        TreeNode26.Name = "ndSPWeek"
        TreeNode26.Tag = "ndSPWeek"
        TreeNode26.Text = "Stock issuing by job"
        TreeNode27.Name = "Stock Report"
        TreeNode27.Text = "Stock movement report"
        TreeNode28.Name = "rpIncidentType"
        TreeNode28.Tag = "IRType"
        TreeNode28.Text = "Summary"
        TreeNode29.Name = "rpJobs1"
        TreeNode29.Tag = "IRJobs1"
        TreeNode29.Text = "Job"
        TreeNode30.Name = "rpMachine"
        TreeNode30.Tag = "IRMachine"
        TreeNode30.Text = "Machine"
        TreeNode31.Name = "rpSummary"
        TreeNode31.Tag = "IRSummary"
        TreeNode31.Text = "Product code"
        TreeNode32.Name = "ndIncident"
        TreeNode32.Text = "Abnormal report"
        TreeNode33.Name = "Node0"
        TreeNode33.Tag = "ndTLRecordAvg"
        TreeNode33.Text = "Tool life Avg."
        TreeNode34.Name = "Node1"
        TreeNode34.Tag = "ndTLRecord"
        TreeNode34.Text = "Tool life by process"
        TreeNode35.Name = "ndTLRecord"
        TreeNode35.Tag = ""
        TreeNode35.Text = "Tool life record"
        TreeNode36.Name = "Node1"
        TreeNode36.Tag = "JobCPPAnalysis"
        TreeNode36.Text = "Job cpp analysis"
        TreeNode37.Name = "Node2"
        TreeNode37.Tag = "JobCostAnalysis"
        TreeNode37.Text = "Job cost analysis"
        TreeNode38.Name = "Node3"
        TreeNode38.Tag = "ToolProcessCPPAnalysis"
        TreeNode38.Text = "Tool process cpp anlysis"
        TreeNode39.Name = "Node0"
        TreeNode39.Tag = "ToolProcessCostAnalysis"
        TreeNode39.Text = "Tool process cost analysis"
        TreeNode40.Name = "Node4"
        TreeNode40.Tag = "ProductCostAnalysis"
        TreeNode40.Text = "Product cost analysis"
        TreeNode41.Name = "Node0"
        TreeNode41.Text = "Analysis"
        TreeNode42.Name = "DataLog"
        TreeNode42.Tag = "DataLog"
        TreeNode42.Text = "Data Log"
        Me.tvReport.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode22, TreeNode27, TreeNode32, TreeNode35, TreeNode41, TreeNode42})
        Me.tvReport.Size = New System.Drawing.Size(235, 670)
        Me.tvReport.TabIndex = 0
        '
        'pnReport
        '
        Me.pnReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnReport.Location = New System.Drawing.Point(253, 12)
        Me.pnReport.Name = "pnReport"
        Me.pnReport.Size = New System.Drawing.Size(743, 705)
        Me.pnReport.TabIndex = 1
        '
        'cmdSetting
        '
        Me.cmdSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSetting.Location = New System.Drawing.Point(12, 689)
        Me.cmdSetting.Name = "cmdSetting"
        Me.cmdSetting.Size = New System.Drawing.Size(116, 28)
        Me.cmdSetting.TabIndex = 2
        Me.cmdSetting.Text = "System Setting"
        Me.cmdSetting.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Location = New System.Drawing.Point(131, 689)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(116, 28)
        Me.cmdExport.TabIndex = 3
        Me.cmdExport.Text = "Export Database"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdSetting)
        Me.Controls.Add(Me.pnReport)
        Me.Controls.Add(Me.tvReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvReport As TreeView
    Friend WithEvents pnReport As Panel
    Friend WithEvents cmdSetting As Button
    Friend WithEvents cmdExport As Button
End Class
