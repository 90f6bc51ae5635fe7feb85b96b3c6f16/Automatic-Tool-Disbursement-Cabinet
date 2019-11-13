<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update))
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.pbUpdate = New System.Windows.Forms.ProgressBar()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(12, 137)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(280, 23)
        Me.cmdUpdate.TabIndex = 0
        Me.cmdUpdate.Text = "Check for update."
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'pbUpdate
        '
        Me.pbUpdate.Location = New System.Drawing.Point(12, 166)
        Me.pbUpdate.Name = "pbUpdate"
        Me.pbUpdate.Size = New System.Drawing.Size(239, 23)
        Me.pbUpdate.TabIndex = 1
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(257, 172)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(13, 13)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = ".."
        '
        'lblOut
        '
        Me.lblOut.Location = New System.Drawing.Point(12, 113)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(280, 21)
        Me.lblOut.TabIndex = 3
        Me.lblOut.Text = "."
        Me.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'browser
        '
        Me.browser.Location = New System.Drawing.Point(409, 12)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(32, 25)
        Me.browser.TabIndex = 4
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 201)
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.pbUpdate)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(320, 240)
        Me.MinimumSize = New System.Drawing.Size(320, 240)
        Me.Name = "Update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check for update."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdUpdate As Button
    Friend WithEvents pbUpdate As ProgressBar
    Friend WithEvents lblData As Label
    Friend WithEvents lblOut As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents browser As WebBrowser
End Class
