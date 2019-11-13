<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockLayout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockLayout))
        Me.tlpDisplay = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdColAdd = New System.Windows.Forms.Button()
        Me.cmdColSub = New System.Windows.Forms.Button()
        Me.cmdRowAdd = New System.Windows.Forms.Button()
        Me.cmdRowSub = New System.Windows.Forms.Button()
        Me.tbCol = New System.Windows.Forms.TextBox()
        Me.tbRow = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpDisplay
        '
        Me.tlpDisplay.AutoSize = True
        Me.tlpDisplay.ColumnCount = 2
        Me.tlpDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDisplay.Location = New System.Drawing.Point(3, 3)
        Me.tlpDisplay.Name = "tlpDisplay"
        Me.tlpDisplay.RowCount = 2
        Me.tlpDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDisplay.Size = New System.Drawing.Size(64, 64)
        Me.tlpDisplay.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tlpDisplay)
        Me.Panel2.Location = New System.Drawing.Point(52, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 480)
        Me.Panel2.TabIndex = 2
        '
        'cmdColAdd
        '
        Me.cmdColAdd.Location = New System.Drawing.Point(125, 76)
        Me.cmdColAdd.Name = "cmdColAdd"
        Me.cmdColAdd.Size = New System.Drawing.Size(30, 30)
        Me.cmdColAdd.TabIndex = 3
        Me.cmdColAdd.Text = "+"
        Me.cmdColAdd.UseVisualStyleBackColor = True
        '
        'cmdColSub
        '
        Me.cmdColSub.Location = New System.Drawing.Point(55, 76)
        Me.cmdColSub.Name = "cmdColSub"
        Me.cmdColSub.Size = New System.Drawing.Size(30, 30)
        Me.cmdColSub.TabIndex = 4
        Me.cmdColSub.Text = "-"
        Me.cmdColSub.UseVisualStyleBackColor = True
        '
        'cmdRowAdd
        '
        Me.cmdRowAdd.Location = New System.Drawing.Point(19, 174)
        Me.cmdRowAdd.Name = "cmdRowAdd"
        Me.cmdRowAdd.Size = New System.Drawing.Size(30, 30)
        Me.cmdRowAdd.TabIndex = 6
        Me.cmdRowAdd.Text = "+"
        Me.cmdRowAdd.UseVisualStyleBackColor = True
        '
        'cmdRowSub
        '
        Me.cmdRowSub.Location = New System.Drawing.Point(19, 112)
        Me.cmdRowSub.Name = "cmdRowSub"
        Me.cmdRowSub.Size = New System.Drawing.Size(30, 30)
        Me.cmdRowSub.TabIndex = 5
        Me.cmdRowSub.Text = "-"
        Me.cmdRowSub.UseVisualStyleBackColor = True
        '
        'tbCol
        '
        Me.tbCol.Location = New System.Drawing.Point(89, 82)
        Me.tbCol.Name = "tbCol"
        Me.tbCol.Size = New System.Drawing.Size(30, 20)
        Me.tbCol.TabIndex = 7
        '
        'tbRow
        '
        Me.tbRow.Location = New System.Drawing.Point(19, 148)
        Me.tbRow.Name = "tbRow"
        Me.tbRow.Size = New System.Drawing.Size(30, 20)
        Me.tbRow.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Layout"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StockLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbRow)
        Me.Controls.Add(Me.tbCol)
        Me.Controls.Add(Me.cmdRowAdd)
        Me.Controls.Add(Me.cmdRowSub)
        Me.Controls.Add(Me.cmdColSub)
        Me.Controls.Add(Me.cmdColAdd)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StockLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Layout"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpDisplay As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdColAdd As Button
    Friend WithEvents cmdColSub As Button
    Friend WithEvents cmdRowAdd As Button
    Friend WithEvents cmdRowSub As Button
    Friend WithEvents tbCol As TextBox
    Friend WithEvents tbRow As TextBox
    Friend WithEvents Label1 As Label
End Class
