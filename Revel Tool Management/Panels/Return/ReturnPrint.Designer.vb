<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnPrint))
        Me.rvView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvView
        '
        Me.rvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.ReturnPrint.rdlc"
        Me.rvView.Location = New System.Drawing.Point(0, 0)
        Me.rvView.Name = "rvView"
        Me.rvView.ServerReport.BearerToken = Nothing
        Me.rvView.Size = New System.Drawing.Size(1008, 601)
        Me.rvView.TabIndex = 1
        '
        'ReturnPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.rvView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReturnPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return print"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvView As Microsoft.Reporting.WinForms.ReportViewer
End Class
