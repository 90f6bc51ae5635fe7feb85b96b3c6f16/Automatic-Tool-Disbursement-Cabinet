<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.txtPasswords = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.prgThread = New System.Windows.Forms.ProgressBar()
        Me.pnLogin = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancle = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pnLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loading : "
        Me.Label1.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Location = New System.Drawing.Point(133, 473)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(16, 13)
        Me.lblProgress.TabIndex = 1
        Me.lblProgress.Text = "..."
        Me.lblProgress.Visible = False
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.Gold
        Me.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdLogin.Location = New System.Drawing.Point(74, 352)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(219, 44)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'txtPasswords
        '
        Me.txtPasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPasswords.Location = New System.Drawing.Point(74, 280)
        Me.txtPasswords.Name = "txtPasswords"
        Me.txtPasswords.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswords.Size = New System.Drawing.Size(219, 31)
        Me.txtPasswords.TabIndex = 2
        Me.txtPasswords.WordWrap = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(74, 193)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(219, 31)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.WordWrap = False
        '
        'lblAlert
        '
        Me.lblAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlert.ForeColor = System.Drawing.Color.Red
        Me.lblAlert.Location = New System.Drawing.Point(62, 399)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(246, 44)
        Me.lblAlert.TabIndex = 15
        Me.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prgThread
        '
        Me.prgThread.Location = New System.Drawing.Point(65, 489)
        Me.prgThread.Name = "prgThread"
        Me.prgThread.Size = New System.Drawing.Size(721, 10)
        Me.prgThread.Step = 1
        Me.prgThread.TabIndex = 16
        Me.prgThread.Visible = False
        '
        'pnLogin
        '
        Me.pnLogin.BackgroundImage = Global.Revel_Tool_Management.My.Resources.Resources.loadingpage
        Me.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnLogin.Controls.Add(Me.Label2)
        Me.pnLogin.Controls.Add(Me.cmdCancle)
        Me.pnLogin.Controls.Add(Me.LinkLabel1)
        Me.pnLogin.Controls.Add(Me.txtPasswords)
        Me.pnLogin.Controls.Add(Me.cmdLogin)
        Me.pnLogin.Controls.Add(Me.txtUsername)
        Me.pnLogin.Controls.Add(Me.lblAlert)
        Me.pnLogin.Controls.Add(Me.prgThread)
        Me.pnLogin.Controls.Add(Me.lblProgress)
        Me.pnLogin.Controls.Add(Me.Label1)
        Me.pnLogin.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.pnLogin.Location = New System.Drawing.Point(84, 44)
        Me.pnLogin.Name = "pnLogin"
        Me.pnLogin.Size = New System.Drawing.Size(862, 503)
        Me.pnLogin.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(513, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tel. 02 001 6900-3"
        '
        'cmdCancle
        '
        Me.cmdCancle.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancle.FlatAppearance.BorderSize = 0
        Me.cmdCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdCancle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdCancle.Location = New System.Drawing.Point(784, 45)
        Me.cmdCancle.Name = "cmdCancle"
        Me.cmdCancle.Size = New System.Drawing.Size(32, 32)
        Me.cmdCancle.TabIndex = 18
        Me.cmdCancle.Text = "X"
        Me.cmdCancle.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkVisited = True
        Me.LinkLabel1.Location = New System.Drawing.Point(475, 391)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(221, 24)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.futuresupreme.com"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 625)
        Me.Controls.Add(Me.pnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnLogin.ResumeLayout(False)
        Me.pnLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents txtPasswords As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents prgThread As System.Windows.Forms.ProgressBar
    Friend WithEvents lblAlert As System.Windows.Forms.Label
    Friend WithEvents pnLogin As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cmdCancle As Button
    Friend WithEvents Label2 As Label
End Class
