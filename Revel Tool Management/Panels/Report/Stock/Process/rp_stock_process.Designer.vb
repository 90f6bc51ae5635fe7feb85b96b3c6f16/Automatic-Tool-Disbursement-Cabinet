﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rp_stock_process
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdUnselect = New System.Windows.Forms.Button()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.lbProcess = New System.Windows.Forms.ListBox()
        Me.cbJobs = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbChartType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(779, 19)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(155, 24)
        Me.cmdSearch.TabIndex = 21
        Me.cmdSearch.Text = "View"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'rvView
        '
        Me.rvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_process.rdlc"
        Me.rvView.Location = New System.Drawing.Point(12, 161)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(1000, 471)
        Me.rvView.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbGroup)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmdUnselect)
        Me.GroupBox1.Controls.Add(Me.cmdSelectAll)
        Me.GroupBox1.Controls.Add(Me.lbProcess)
        Me.GroupBox1.Controls.Add(Me.cbJobs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbChartType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 146)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Parameter"
        '
        'cmdUnselect
        '
        Me.cmdUnselect.Location = New System.Drawing.Point(779, 77)
        Me.cmdUnselect.Name = "cmdUnselect"
        Me.cmdUnselect.Size = New System.Drawing.Size(72, 24)
        Me.cmdUnselect.TabIndex = 38
        Me.cmdUnselect.Text = "Unselect"
        Me.cmdUnselect.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Location = New System.Drawing.Point(779, 49)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(72, 24)
        Me.cmdSelectAll.TabIndex = 37
        Me.cmdSelectAll.Text = "Select all"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'lbProcess
        '
        Me.lbProcess.FormattingEnabled = True
        Me.lbProcess.Location = New System.Drawing.Point(336, 19)
        Me.lbProcess.Name = "lbProcess"
        Me.lbProcess.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbProcess.Size = New System.Drawing.Size(437, 121)
        Me.lbProcess.TabIndex = 36
        '
        'cbJobs
        '
        Me.cbJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJobs.FormattingEnabled = True
        Me.cbJobs.Items.AddRange(New Object() {"Candle", "Pie", "Line"})
        Me.cbJobs.Location = New System.Drawing.Point(101, 72)
        Me.cbJobs.Name = "cbJobs"
        Me.cbJobs.Size = New System.Drawing.Size(229, 21)
        Me.cbJobs.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Jobs :"
        '
        'cbChartType
        '
        Me.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChartType.FormattingEnabled = True
        Me.cbChartType.Items.AddRange(New Object() {"Candle", "Pie", "Line"})
        Me.cbChartType.Location = New System.Drawing.Point(101, 45)
        Me.cbChartType.Name = "cbChartType"
        Me.cbChartType.Size = New System.Drawing.Size(229, 21)
        Me.cbChartType.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Chart type :"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyyy-MM-dd HH:mm"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(176, 19)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(154, 20)
        Me.dtpEnd.TabIndex = 19
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "yyyyy-MM-dd HH:mm"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(6, 19)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(154, 20)
        Me.dtpStart.TabIndex = 18
        '
        'cbGroup
        '
        Me.cbGroup.BackColor = System.Drawing.SystemColors.Info
        Me.cbGroup.DisplayMember = "products_group_name"
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGroup.ForeColor = System.Drawing.Color.Black
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Location = New System.Drawing.Point(101, 100)
        Me.cbGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(228, 21)
        Me.cbGroup.TabIndex = 39
        Me.cbGroup.ValueMember = "products_group_id"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(51, 103)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Group :"
        '
        'rp_stock_process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.rvView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rp_stock_process"
        Me.Text = "Stock process report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents rvView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents cbChartType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbProcess As ListBox
    Friend WithEvents cbJobs As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdUnselect As Button
    Friend WithEvents cmdSelectAll As Button
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents Label16 As Label
End Class