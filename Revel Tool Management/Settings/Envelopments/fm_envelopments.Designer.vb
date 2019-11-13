<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_envelopments
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdCancle = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อฐานข้อมูล :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ตำแหน่งที่เก็บ :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(99, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(345, 20)
        Me.txtName.TabIndex = 2
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(98, 35)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(293, 20)
        Me.txtLocation.TabIndex = 3
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(397, 33)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(45, 23)
        Me.cmdOpen.TabIndex = 4
        Me.cmdOpen.Text = "เลือก"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdCancle
        '
        Me.cmdCancle.Location = New System.Drawing.Point(367, 62)
        Me.cmdCancle.Name = "cmdCancle"
        Me.cmdCancle.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancle.TabIndex = 5
        Me.cmdCancle.Text = "ยกเลิก"
        Me.cmdCancle.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(286, 62)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "บันทึก"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'fm_envelopments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 92)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancle)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fm_envelopments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ฐานข้อมูล"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cmdOpen As Button
    Friend WithEvents cmdCancle As Button
    Friend WithEvents cmdSave As Button
End Class
