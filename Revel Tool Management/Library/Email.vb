Imports System.Net.Mail

Public Class Email
    Sub send_email(email_from As String, email_to As String, smtp As String, port As Int16, user As String, pass As String, subject As String, body As String, file As String)
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient(smtp)
        mail.From = New MailAddress(email_from)
        mail.[To].Add(email_to)
        mail.Subject = subject
        mail.Body = body

        If (My.Computer.FileSystem.FileExists(file)) Then
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(file)
            mail.Attachments.Add(attachment)
        End If


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
End Class
