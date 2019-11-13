Imports System.Data.SQLite
Imports System.IO
Imports System.Threading

Public Class SplashScreen

    Private WithEvents TestWorker As System.ComponentModel.BackgroundWorker

    Private Sub TestWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles TestWorker.DoWork
        Dim ListText As String
        Dim Value As Integer = 100

        Dim sys As New CreateSystemDatabase()

        ListText = String.Concat(Value, "%")
        TestWorker.ReportProgress(100, ListText)
    End Sub


    Private Sub TestWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles TestWorker.ProgressChanged
        prgThread.Value = e.ProgressPercentage
        lblProgress.Text = e.UserState
    End Sub

    Private Sub TestWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TestWorker.RunWorkerCompleted
        pnLogin.Enabled = True
    End Sub

    Function Login()
        'txtUsername.Text = "admin"
        'txtPasswords.Text = "default"
        If txtUsername.Text = "" Then
            lblAlert.Text = "Please input your email."
        ElseIf txtPasswords.Text = "" Then
            lblAlert.Text = "Please input your password."
        Else
            lblAlert.Text = ""
            Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
            Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_user , tb_user_type WHERE tb_user.user_type_id = tb_user_type.user_type_id AND user_username = '" & txtUsername.Text & "' AND user_password ='" & txtPasswords.Text & "'")
            If dt.Rows.Count > 0 Then


                My.Settings.user_id = dt.Rows(0)("user_id").ToString()
                My.Settings.login_name = dt.Rows(0)("user_name").ToString() & " " & dt.Rows(0)("user_lastname").ToString()

                My.Settings.license1 = dt.Rows(0)("user_type_license1").ToString()
                My.Settings.license2 = dt.Rows(0)("user_type_license2").ToString()
                My.Settings.license3 = dt.Rows(0)("user_type_license3").ToString()
                My.Settings.license4 = dt.Rows(0)("user_type_license4").ToString()
                My.Settings.license5 = dt.Rows(0)("user_type_license5").ToString()
                My.Settings.license6 = dt.Rows(0)("user_type_license6").ToString()
                My.Settings.license7 = dt.Rows(0)("user_type_license7").ToString()
                My.Settings.license8 = dt.Rows(0)("user_type_license8").ToString()
                My.Settings.license9 = dt.Rows(0)("user_type_license9").ToString()
                My.Settings.license10 = dt.Rows(0)("user_type_license10").ToString()

                My.Settings.userid = Convert.ToInt16(dt.Rows(0)("user_id").ToString())
                My.Settings.username = dt.Rows(0)("user_name").ToString()
                My.Settings.userpic = dt.Rows(0)("user_image").ToString()
                My.Settings.usertype = dt.Rows(0)("user_type_name").ToString()
                My.Settings.first_login = True
                Main.Show()

                'If (dt.Rows(0)("user_type_id").ToString() <> 1) Then
                '    Root.userid = Convert.ToInt16(dt.Rows(0)("user_id").ToString())
                '    Root.username = dt.Rows(0)("user_name").ToString()
                '    Root.userpic = dt.Rows(0)("user_image").ToString()
                '    Root.usertype = dt.Rows(0)("user_type_name").ToString()

                '    Root.Show()

                'Else
                '    Main.userid = Convert.ToInt16(dt.Rows(0)("user_id").ToString())
                '    Main.username = dt.Rows(0)("user_name").ToString()
                '    Main.userpic = dt.Rows(0)("user_image").ToString()
                '    Main.usertype = dt.Rows(0)("user_type_name").ToString()
                '    Main.Show()

                'End If


                My.Settings.Save()

                Me.Close()
            Else
                lblAlert.Text = "Login fail. Wrong Username or Password."
            End If
        End If
    End Function

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnLogin.Location = New Point((Me.Width - pnLogin.Width) \ 2, (Me.Height - pnLogin.Height) \ 2)
        pnLogin.Enabled = False
        prgThread.Value = 0
        TestWorker = New System.ComponentModel.BackgroundWorker
        TestWorker.WorkerReportsProgress = True
        TestWorker.WorkerSupportsCancellation = True
        TestWorker.RunWorkerAsync()

    End Sub


    Private Sub cmdCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancle.Click
        TestWorker.CancelAsync()
        Application.Exit()
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Login()
    End Sub

    Private Sub txtPasswords_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPasswords.KeyPress
        Try
            If Convert.ToByte(e.KeyChar) = Keys.Enter Then
                Login()
            End If
        Catch ex As Exception
            e.Handled = True
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.futuresupreme.com")
    End Sub
End Class
