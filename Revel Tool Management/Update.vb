Imports System.Net
Imports System.IO
Imports System.IO.Compression.GZipStream

Public Class Update
    Public Sub CheckForUpdates()
        If pbUpdate.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropbox.com/s/ykhezqrcihwdns1/Versions.txt?dl=0")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()

            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                cmdUpdate.Text = ("You are up todate!")
                lblOut.Text = ("You may now close this dialog")
            Else
                cmdUpdate.Text = ("Downloading update!")
                browser.Navigate("https://dl.dropbox.com/s/ykhezqrcihwdns1/Versions.txt?dl=0")
                lblOut.Text = ("You may now close this dialog")
            End If
        End If
    End Sub

    Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))

    Sub UnZip()

    End Sub

    Sub DownloadZip()
        Dim remoteUri As String = "https://www.dropbox.com/s/c1ufxng2pgrjo8j/update.rar?dl=0"
        Dim fileName As String = "update.rar"
        Dim pasword As String = "..."
        Dim username As String = "..."

        Using client = New WebClient()
            client.DownloadFile(remoteUri, fileName)
        End Using
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        cmdUpdate.Enabled = False
        cmdUpdate.Text = "Checking for updates..."
        Timer1.Start()
        lblData.Text = pbUpdate.Value
        CheckForUpdates()

    End Sub

    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pbUpdate.Increment(5)
        lblData.Text = pbUpdate.Value
        If pbUpdate.Value = 100 Then
            Timer1.Stop()
            If pbUpdate.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropbox.com/s/ykhezqrcihwdns1/Versions.txt?dl=0")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()

                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    cmdUpdate.Text = ("You are up todate!")
                    lblOut.Text = ("You may now close this dialog")
                Else

                    cmdUpdate.Text = ("Downloading update!")

                    DownloadZip()
                    UnZip()

                    lblOut.Text = ("You may now close this dialog")
                End If
            End If
        End If
    End Sub
End Class