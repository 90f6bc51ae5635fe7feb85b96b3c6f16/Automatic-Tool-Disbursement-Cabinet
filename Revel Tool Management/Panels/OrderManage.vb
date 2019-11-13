Imports System.Globalization
Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Public Class OrderManage
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable

    Public user_id As Int16 = 0

    Sub send_email(email_from As String, email_to As String, smtp As String, port As Int16, user As String, pass As String, subject As String, body As String, file As String)
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient(smtp)
        mail.From = New MailAddress(email_from)
        mail.[To].Add(email_to)
        mail.Subject = subject
        mail.Body = body

        Dim attachment As System.Net.Mail.Attachment
        attachment = New System.Net.Mail.Attachment(file)
        mail.Attachments.Add(attachment)

        SmtpServer.Port = port '587
        SmtpServer.Credentials = New System.Net.NetworkCredential(user, pass)
        SmtpServer.EnableSsl = True

        SmtpServer.Send(mail)
        MessageBox.Show("mail Send")



        'Dim mail As New MailMessage()
        'Dim SmtpServer As New SmtpClient("smtp.gmail.com")
        'mail.From = New MailAddress("your_email_address@gmail.com")
        'mail.[To].Add("to_address")
        'mail.Subject = "Test Mail - 1"
        'mail.Body = "mail with attachment"

        'Dim attachment As System.Net.Mail.Attachment
        'attachment = New System.Net.Mail.Attachment("your attachment file")
        'mail.Attachments.Add(attachment)

        'SmtpServer.Port = 587
        'SmtpServer.Credentials = New System.Net.NetworkCredential("username", "password")
        'SmtpServer.EnableSsl = True

        'SmtpServer.Send(mail)
        'MessageBox.Show("mail Send")


    End Sub

    Sub refreshALLData()
        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)
        Dim str As String = ""
        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnds.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , order_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , order_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "

        dt_main = config.GetDataTable("SELECT * , user_name || ' ' || user_lastname as order_name FROM tb_order LEFT JOIN tb_user ON tb_order.order_by = tb_user.user_id WHERE order_remark LIKE ('%" & tbSearch.Text & "%') " & str & " ORDER BY strftime('%Y-%m-%d %H:%M' , order_date) DESC ")
        dgvAll.DataSource = dt_main

    End Sub

    Private Sub Urgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAll.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvAll.EnableHeadersVisualStyles = False
        dgvAll.AutoGenerateColumns = False
        ColorTranslator.FromHtml(My.Settings.dgv_color)

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnds.Value = firstDay.AddMonths(1).AddDays(-1)

        dtpEnds.CustomFormat = "yyyy-MM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MM-dd HH:mm"


        refreshALLData()
    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub dgvAll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAll.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            'TODO - Button Clicked - Execute Code Here
            If dgvAll.Columns(e.ColumnIndex).Name = "colview" Then
                Dim fm_order_view As New OrderView
                fm_order_view.order_id = Convert.ToInt32(dgvAll.Rows(e.RowIndex).Cells("order_id").Value.ToString)
                fm_order_view.user_id = user_id
                fm_order_view.ShowDialog()
                refreshALLData()
            End If
        End If
    End Sub

    Private Sub cmdOutSearch_Click(sender As Object, e As EventArgs) Handles cmdOutSearch.Click
        refreshALLData()
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim fm_order_view As New OrderAdd
        fm_order_view.user_id = user_id
        fm_order_view.ShowDialog()
        refreshALLData()
    End Sub
End Class