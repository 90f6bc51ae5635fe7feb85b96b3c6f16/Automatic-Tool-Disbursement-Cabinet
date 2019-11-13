<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Envelopments
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
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.cmdDefault = New System.Windows.Forms.Button()
        Me.lvView = New System.Windows.Forms.ListView()
        Me.colname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDefault = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.collocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb
        '
        Me.gb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb.Controls.Add(Me.cmdDefault)
        Me.gb.Controls.Add(Me.lvView)
        Me.gb.Controls.Add(Me.cmdRemove)
        Me.gb.Controls.Add(Me.cmdEdit)
        Me.gb.Controls.Add(Me.cmdAdd)
        Me.gb.Location = New System.Drawing.Point(12, 12)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(479, 173)
        Me.gb.TabIndex = 0
        Me.gb.TabStop = False
        Me.gb.Text = "ฐานข้อมูล"
        '
        'cmdDefault
        '
        Me.cmdDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDefault.Location = New System.Drawing.Point(409, 19)
        Me.cmdDefault.Name = "cmdDefault"
        Me.cmdDefault.Size = New System.Drawing.Size(64, 24)
        Me.cmdDefault.TabIndex = 5
        Me.cmdDefault.Text = "ใช้งาน"
        Me.cmdDefault.UseVisualStyleBackColor = True
        '
        'lvView
        '
        Me.lvView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colname, Me.colDefault, Me.collocation})
        Me.lvView.Location = New System.Drawing.Point(6, 19)
        Me.lvView.Name = "lvView"
        Me.lvView.Size = New System.Drawing.Size(397, 148)
        Me.lvView.TabIndex = 4
        Me.lvView.UseCompatibleStateImageBehavior = False
        Me.lvView.View = System.Windows.Forms.View.Details
        '
        'colname
        '
        Me.colname.Text = "ชื่อฐานข้อมูล"
        Me.colname.Width = 180
        '
        'colDefault
        '
        Me.colDefault.Text = "สถานะ"
        '
        'collocation
        '
        Me.collocation.Text = "ตำแหน่ง"
        Me.collocation.Width = 200
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Location = New System.Drawing.Point(409, 109)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(64, 24)
        Me.cmdRemove.TabIndex = 3
        Me.cmdRemove.Text = "ลบ"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(409, 79)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 24)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "แก้ไข"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Location = New System.Drawing.Point(409, 49)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 24)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "เพิ่ม"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Envelopments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 197)
        Me.Controls.Add(Me.gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Envelopments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envelopments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gb.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb As GroupBox
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents lvView As ListView
    Friend WithEvents colname As ColumnHeader
    Friend WithEvents collocation As ColumnHeader
    Friend WithEvents cmdDefault As Button
    Friend WithEvents colDefault As ColumnHeader
End Class
