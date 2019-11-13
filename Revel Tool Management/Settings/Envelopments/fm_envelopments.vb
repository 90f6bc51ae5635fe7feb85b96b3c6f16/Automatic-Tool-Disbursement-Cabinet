Imports System.IO

Public Class fm_envelopments
    Dim config As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Public database_id As String = ""
    Public database_name As String = ""
    Public database_locations As String = ""
    Public state As Boolean = False
    Private type As Integer = 0
    Dim op As New SaveFileDialog

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        op.Filter = "Database File (.db3)|*.db3"
        If op.ShowDialog() = DialogResult.OK Then
            txtLocation.Text = op.FileName
        End If
    End Sub

    Private Sub fm_envelopments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If database_id <> "" Then
            Me.Text = Me.Text & " - แก้ไข"
            txtName.Text = database_name
            txtLocation.Text = database_locations
            type = 1
        Else
            Me.Text = Me.Text & " - เพิ่ม"
            type = 0
        End If
    End Sub

    Private Sub cmdCancle_Click(sender As Object, e As EventArgs) Handles cmdCancle.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ")
        ElseIf txtLocation.Text = "" Then
            MsgBox("กรุณากรอกตำแหน่งของฐานข้อมูล")
        ElseIf type = 0 Then

            config.ExecuteNonQuery("INSERT INTO tb_database (database_name,database_location,database_use) VALUES ('" & txtName.Text & "','" & txtLocation.Text & "','0')")
            Dim p As String = Path.GetDirectoryName(op.FileName)
            Dim sys As New CreateDatabase(txtLocation.Text)

            If (Not System.IO.Directory.Exists(p & "\images")) Then
                System.IO.Directory.CreateDirectory(p & "\images")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\users")) Then
                System.IO.Directory.CreateDirectory(p & "\images\users")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\tools")) Then
                System.IO.Directory.CreateDirectory(p & "\images\tools")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\suppliers")) Then
                System.IO.Directory.CreateDirectory(p & "\images\suppliers")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\machines")) Then
                System.IO.Directory.CreateDirectory(p & "\images\machines")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\incidents")) Then
                System.IO.Directory.CreateDirectory(p & "\images\incidents")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\brands")) Then
                System.IO.Directory.CreateDirectory(p & "\images\brands")
            End If

            state = True

        ElseIf type = 1 Then

            config.ExecuteNonQuery("UPDATE tb_database SET database_name = '" & txtName.Text & "',database_location = '" & txtLocation.Text & "' WHERE database_id = '" & database_id & "'")
            Dim p As String = Path.GetDirectoryName(database_locations)
            Dim p2 As String = Path.GetDirectoryName(op.FileName)
            My.Computer.FileSystem.CopyDirectory(p, p2, True)

            If My.Computer.FileSystem.FileExists(p2 & "\" & Path.GetFileName(database_locations)) Then
                My.Computer.FileSystem.RenameFile(p2 & "\" & Path.GetFileName(database_locations), op.FileName)
            End If
            If (Not System.IO.Directory.Exists(p2 & "\images")) Then
                System.IO.Directory.CreateDirectory(p2 & "\images")
            End If

            If (Not System.IO.Directory.Exists(p2 & "\images\users")) Then
                System.IO.Directory.CreateDirectory(p2 & "\images\users")
            End If

            If (Not System.IO.Directory.Exists(p2 & "\images\tools")) Then
                System.IO.Directory.CreateDirectory(p2 & "\images\tools")
            End If

            If (Not System.IO.Directory.Exists(p2 & "\images\suppliers")) Then
                System.IO.Directory.CreateDirectory(p2 & "\images\suppliers")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\machines")) Then
                System.IO.Directory.CreateDirectory(p & "\images\machines")
            End If

            If (Not System.IO.Directory.Exists(p & "\images\incidents")) Then
                System.IO.Directory.CreateDirectory(p & "\images\incidents")
            End If

            If (Not System.IO.Directory.Exists(p2 & "\images\brands")) Then
                System.IO.Directory.CreateDirectory(p2 & "\images\brands")
            End If

            state = True

        End If
        Me.Close()
    End Sub
End Class