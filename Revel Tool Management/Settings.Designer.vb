<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ndCutStockDate = New System.Windows.Forms.NumericUpDown()
        Me.ndWork = New System.Windows.Forms.NumericUpDown()
        Me.ndCutStockHour = New System.Windows.Forms.NumericUpDown()
        Me.ndCutStockMin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ndCutStockDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCutStockHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCutStockMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(269, 75)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(188, 76)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Day :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Working day :"
        '
        'ndCutStockDate
        '
        Me.ndCutStockDate.Location = New System.Drawing.Point(52, 22)
        Me.ndCutStockDate.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.ndCutStockDate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndCutStockDate.Name = "ndCutStockDate"
        Me.ndCutStockDate.Size = New System.Drawing.Size(73, 20)
        Me.ndCutStockDate.TabIndex = 8
        Me.ndCutStockDate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ndWork
        '
        Me.ndWork.Location = New System.Drawing.Point(95, 79)
        Me.ndWork.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.ndWork.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndWork.Name = "ndWork"
        Me.ndWork.Size = New System.Drawing.Size(73, 20)
        Me.ndWork.TabIndex = 9
        Me.ndWork.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ndCutStockHour
        '
        Me.ndCutStockHour.Location = New System.Drawing.Point(189, 22)
        Me.ndCutStockHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.ndCutStockHour.Name = "ndCutStockHour"
        Me.ndCutStockHour.Size = New System.Drawing.Size(36, 20)
        Me.ndCutStockHour.TabIndex = 10
        '
        'ndCutStockMin
        '
        Me.ndCutStockMin.Location = New System.Drawing.Point(246, 22)
        Me.ndCutStockMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.ndCutStockMin.Name = "ndCutStockMin"
        Me.ndCutStockMin.Size = New System.Drawing.Size(36, 20)
        Me.ndCutStockMin.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = " :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Time :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ndCutStockDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ndCutStockHour)
        Me.GroupBox1.Controls.Add(Me.ndCutStockMin)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 57)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cut stock"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 111)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ndWork)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System setting"
        CType(Me.ndCutStockDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCutStockHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCutStockMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ndCutStockDate As NumericUpDown
    Friend WithEvents ndWork As NumericUpDown
    Friend WithEvents ndCutStockHour As NumericUpDown
    Friend WithEvents ndCutStockMin As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
