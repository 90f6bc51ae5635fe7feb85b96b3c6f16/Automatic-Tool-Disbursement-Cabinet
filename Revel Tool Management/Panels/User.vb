Imports System.Globalization
Imports System.IO

Public Class name

    Dim log As New Log
    Dim edit_row As DataRow

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim user_type_id As String = ""
    Dim user_id As String = ""
    Dim editIndex As Integer = -1
    Dim dt_main As DataTable

    Function checkUsername(ByVal username As String)

        If editIndex > -1 Then
            If dt_main.Rows(editIndex).Item("user_username") = username Then
                Return False
            End If
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_user WHERE user_username = '" & username & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub refreshUser()
        Dim str As String = ""
        If tbSearch.Text <> "" Then
            str = " AND (user_name LIKE '%" & tbSearch.Text & "%' OR user_lastname LIKE '%" & tbSearch.Text & "%')"
        End If
        dt_main = config.GetDataTable("SELECT  * , user_name || ' ' || user_lastname as name  FROM tb_user as t1, tb_user_type WHERE t1.user_type_id = tb_user_type.user_type_id " & str)
        dgvData.DataSource = dt_main
    End Sub

    Sub refreshUserType(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_user_type")
        cbUsertype.DataSource = dt
        If index <> "" Then
            cbUsertype.SelectedValue = index
        End If
    End Sub

    Sub ViewData(ByVal index As Integer)
        tbName.ReadOnly = True
        tbLastname.ReadOnly = True
        tbTel.ReadOnly = True
        tbEmail.ReadOnly = True
        tbPassword.ReadOnly = True
        tbPasswordConfirm.ReadOnly = True
        cbUsertype.Enabled = False
        cmdClear.Enabled = False
        cmdUpload.Enabled = False

        tbName.Text = dt_main.Rows(index).Item("user_name").ToString
        tbLastname.Text = dt_main.Rows(index).Item("user_lastname").ToString
        tbTel.Text = dt_main.Rows(index).Item("user_tel").ToString
        tbEmail.Text = dt_main.Rows(index).Item("user_email").ToString
        tbUsername.Text = dt_main.Rows(index).Item("user_username").ToString
        tbPassword.Text = dt_main.Rows(index).Item("user_password").ToString
        tbPasswordConfirm.Text = dt_main.Rows(index).Item("user_password").ToString
        refreshUserType(dt_main.Rows(index).Item("user_type_id"))
        If dt_main.Rows(index).Item("user_image").ToString <> "" Then
            pbImage.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & dt_main.Rows(index).Item("user_image")
        Else
            pbImage.ImageLocation = vbNull
        End If

    End Sub

    Sub clearData()

        tbName.ReadOnly = False
        tbLastname.ReadOnly = False
        tbTel.ReadOnly = False
        tbEmail.ReadOnly = False
        tbPassword.ReadOnly = False
        tbPasswordConfirm.ReadOnly = False
        cbUsertype.Enabled = True
        cmdSubmit.Enabled = True
        cmdUpload.Enabled = True
        cmdClear.Enabled = True


        tbName.Text = ""
        tbLastname.Text = ""
        tbTel.Text = ""
        tbEmail.Text = ""
        tbUsername.Text = ""
        tbPassword.Text = ""
        tbPasswordConfirm.Text = ""
        refreshUserType("")
        pbImage.ImageLocation = vbNull
        cmdSubmit.Text = "Add"
    End Sub

    Function checkData() As Boolean
        Dim ch_email As New RegexUtilities
        If tbName.Text = "" Then
            MsgBox("Please input name.")
            tbName.Select()
            Return False
        ElseIf tbLastname.Text = "" Then
            MsgBox("Please input lastname.")
            tbLastname.Select()
            Return False
        ElseIf Not ch_email.IsValidEmail(tbEmail.Text) And tbEmail.Text <> "" Then
            MsgBox("Invalid e-mail format.")
            tbEmail.Select()
            Return False
        ElseIf tbUsername.Text = "" Then
            MsgBox("Please input username.")
            tbUsername.Select()
            Return False
        ElseIf checkUsername(tbUsername.Text) Then
            MsgBox("Username is already.")
            tbUsername.Select()
            Return False
        ElseIf tbPassword.Text = "" Then
            MsgBox("Please input password.")
            tbPassword.Select()
            Return False
        ElseIf tbPasswordConfirm.Text = "" Then
            MsgBox("Please confirm password.")
            tbPasswordConfirm.Select()
            Return False
        ElseIf tbPassword.Text <> tbPasswordConfirm.Text Then
            MsgBox("Passwords not math.")
            tbPasswordConfirm.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If cmdClear.Enabled = False Then
            cmdClear.Enabled = True
            clearData()
            editIndex = -1
        ElseIf checkData() Then
            If cmdSubmit.Text = "Add" Then
                Dim admin As New Dictionary(Of String, String)
                Dim img As String = ""
                If My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                End If

                admin.Add("user_name", tbName.Text)
                admin.Add("user_lastname", tbLastname.Text)
                admin.Add("user_tel", tbTel.Text)
                admin.Add("user_email", tbEmail.Text)
                admin.Add("user_username", tbUsername.Text)
                admin.Add("user_password", tbPassword.Text)
                admin.Add("user_type_id", cbUsertype.SelectedValue)
                admin.Add("user_image", img)

                If config.Insert("tb_user", admin) Then
                    If img <> "" Then
                        My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & img, True)
                    End If

                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "USER",
                            "INSERT",
                            (
                            " Add 1 user record by " & My.Settings.login_name & ". \n" &
                            " Name : " & tbName.Text & " \n " &
                            " Lastname : " & tbLastname.Text & " \n " &
                            " Telephone : " & tbTel.Text & " \n " &
                            " Email : " & tbEmail.Text & " \n " &
                            " Username : " & tbUsername.Text & " \n " &
                            " User type : " & cbUsertype.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )
                End If



                Dim dt_new As DataTable = config.GetDataTable("SELECT * FROM tb_user WHERE user_username = '" & tbUsername.Text & "'")
                refreshUser()
                clearData()
                For i As Integer = 0 To dt_main.Rows.Count - 1
                    If dt_new.Rows(0).Item("user_id") = dt_main.Rows(i).Item("user_id") Then
                        ViewData(i)
                    End If
                Next
                editIndex = -1
            Else
                Dim admin As New Dictionary(Of String, String)
                Dim img As String = ""
                Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                If dt_main.Rows(editIndex).Item("user_image") = "" And My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                    My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & img, True)
                ElseIf dt_main.Rows(editIndex).Item("user_image") <> "" And Path.GetFileName(pbImage.ImageLocation) <> dt_main.Rows(editIndex).Item("user_image") And My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                    My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & dt_main.Rows(editIndex).Item("user_image"))
                    My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & img, True)
                Else
                    img = dt_main.Rows(editIndex).Item("user_image")
                End If


                admin.Add("user_name", tbName.Text)
                admin.Add("user_lastname", tbLastname.Text)
                admin.Add("user_tel", tbTel.Text)
                admin.Add("user_email", tbEmail.Text)
                admin.Add("user_username", tbUsername.Text)
                admin.Add("user_password", tbPassword.Text)
                admin.Add("user_type_id", cbUsertype.SelectedValue)
                admin.Add("user_image", img)

                If config.Update("tb_user", admin, "user_id = '" & dt_main.Rows(editIndex).Item("user_id") & "'") Then
                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                           "USER",
                           "UPDATE",
                           (
                           " Update 1 user record by " & My.Settings.login_name & ". \n" &
                           " From data." &
                           " Name : " & edit_row.Item("user_name") & " \n " &
                           " Lastname : " & edit_row.Item("user_lastname") & " \n " &
                           " Telephone : " & edit_row.Item("user_tel") & " \n " &
                           " Email : " & edit_row.Item("user_email") & " \n " &
                           " Username : " & edit_row.Item("user_username") & " \n " &
                           " User type : " & edit_row.Item("user_type_name") & " \n " &
                           " Image. : " & edit_row.Item("user_image") & " \n " &
                           " To data." &
                           " Name : " & tbName.Text & " \n " &
                           " Lastname : " & tbLastname.Text & " \n " &
                           " Telephone : " & tbTel.Text & " \n " &
                           " Email : " & tbEmail.Text & " \n " &
                           " Username : " & tbUsername.Text & " \n " &
                           " User type : " & cbUsertype.Text & " \n " &
                           " Image. : " & img & " \n "
                           ),
                           My.Settings.login_name
                    )
                End If


                refreshUser()
                clearData()
                ViewData(editIndex)
                editIndex = -1
            End If
        End If
    End Sub

    Private Sub cmdEditUserType_Click(sender As Object, e As EventArgs) Handles cmdEditUserType.Click
        Dim user_type As New UserType
        user_type.ShowDialog()
        refreshUserType(user_type_id)
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.AutoGenerateColumns = False
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        cmdClear.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        cmdSubmit.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False
        clearData()
        refreshUser()
        refreshUserType("")
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            dgvData.Rows(e.RowIndex).Selected = True
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colView" Then
                clearData()
                ViewData(e.RowIndex)
                editIndex = -1
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colEdit" Then
                clearData()
                editIndex = e.RowIndex
                edit_row = dt_main.Rows(e.RowIndex)
                tbName.Text = dt_main.Rows(e.RowIndex).Item("user_name").ToString
                tbLastname.Text = dt_main.Rows(e.RowIndex).Item("user_lastname").ToString
                tbTel.Text = dt_main.Rows(e.RowIndex).Item("user_tel").ToString
                tbEmail.Text = dt_main.Rows(e.RowIndex).Item("user_email").ToString
                tbUsername.Text = dt_main.Rows(e.RowIndex).Item("user_username").ToString
                tbPassword.Text = dt_main.Rows(e.RowIndex).Item("user_password").ToString
                tbPasswordConfirm.Text = dt_main.Rows(e.RowIndex).Item("user_password").ToString
                refreshUserType(dt_main.Rows(e.RowIndex).Item("user_type_id"))

                If dt_main.Rows(e.RowIndex).Item("user_id") = 1 Then
                    cbUsertype.Enabled = False
                End If

                If dt_main.Rows(e.RowIndex).Item("user_image").ToString <> "" Then
                    pbImage.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & dt_main.Rows(e.RowIndex).Item("user_image")
                Else
                    pbImage.ImageLocation = vbNull
                End If

                cmdSubmit.Text = "Save"

            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then
                If dt_main.Rows(e.RowIndex).Item("user_id") <> 1 Then
                    If MessageBox.Show("You want to delete " & dt_main.Rows(e.RowIndex).Item("user_name"), "Delete user data.", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        If config.ExecuteNonQuery("DELETE FROM tb_user WHERE user_id ='" & dt_main.Rows(e.RowIndex).Item("user_id") & "'") Then
                            If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & dt_main.Rows(e.RowIndex).Item("user_image")) Then
                                My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & dt_main.Rows(e.RowIndex).Item("user_image"))
                                log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                                       "USER",
                                       "DELETE",
                                       (
                                       " Remove 1 user record by " & My.Settings.login_name & ". \n" &
                                       " Name : " & dt_main.Rows(e.RowIndex).Item("user_name") & " \n " &
                                       " Lastname : " & dt_main.Rows(e.RowIndex).Item("user_lastname") & " \n " &
                                       " Telephone : " & dt_main.Rows(e.RowIndex).Item("user_tel") & " \n " &
                                       " Email : " & dt_main.Rows(e.RowIndex).Item("user_email") & " \n " &
                                       " Username : " & dt_main.Rows(e.RowIndex).Item("user_username") & " \n " &
                                       " User type : " & dt_main.Rows(e.RowIndex).Item("user_type_name") & " \n " &
                                       " Image. : " & dt_main.Rows(e.RowIndex).Item("user_image") & " \n "
                                       ),
                                       My.Settings.login_name
                                )
                            End If
                            clearData()
                            refreshUser()
                            editIndex = -1
                        End If
                    End If
                Else
                    MsgBox("You can not delete default data.")
                End If

            End If
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearData()
    End Sub

    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Dim op As New OpenFileDialog
        op.Filter = "JPG|*.jpg;*.jpeg"
        If op.ShowDialog() = DialogResult.OK Then
            pbImage.ImageLocation = op.FileName
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        clearData()
        refreshUser()
    End Sub

    Private Sub name_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub
End Class