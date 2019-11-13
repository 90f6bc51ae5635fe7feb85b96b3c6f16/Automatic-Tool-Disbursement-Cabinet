Imports System.Globalization
Imports System.IO

Public Class Suppliers

    Dim log As New Log
    Dim edit_row As DataRow

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim suppliers_id As String = ""
    Dim editIndex As Integer = -1
    Dim dt_main As DataTable


    Function checkName(ByVal name As String)
        If editIndex > -1 Then
            If dt_main.Rows(editIndex).Item("suppliers_name") = name Then
                Return False
            End If
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FORM tb_suppliers WHERE suppliers_name = '" & name & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub refreshSuppliers()
        Dim str As String = ""
        If tbSearch.Text <> "" Then
            str = " WHERE (suppliers_name LIKE '%" & tbSearch.Text & "%' OR suppliers_contact LIKE '%" & tbSearch.Text & "%')"
        End If
        dt_main = config.GetDataTable("SELECT * FROM tb_suppliers as t1" & str & " ORDER BY suppliers_name")
        dgvData.DataSource = dt_main

    End Sub

    Sub ViewData(ByVal index As Integer)
        tbName.ReadOnly = True
        tbContact.ReadOnly = True
        tbTel.ReadOnly = True
        tbEmail.ReadOnly = True
        tbAddress.ReadOnly = True
        tbFax.ReadOnly = True
        tbDetail.ReadOnly = True
        cmdClear.Enabled = False
        cmdUpload.Enabled = False

        tbName.Text = dt_main.Rows(index).Item("suppliers_name").ToString
        tbContact.Text = dt_main.Rows(index).Item("suppliers_contact").ToString
        tbTel.Text = dt_main.Rows(index).Item("suppliers_tel").ToString
        tbEmail.Text = dt_main.Rows(index).Item("suppliers_email").ToString
        tbAddress.Text = dt_main.Rows(index).Item("suppliers_address").ToString
        tbFax.Text = dt_main.Rows(index).Item("suppliers_fax").ToString
        tbDetail.Text = dt_main.Rows(index).Item("suppliers_detail").ToString

        If dt_main.Rows(index).Item("suppliers_image").ToString <> "" Then
            pbImage.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & dt_main.Rows(index).Item("suppliers_image").ToString
        Else
            pbImage.ImageLocation = vbNull
        End If
    End Sub

    Sub clearData()

        tbName.ReadOnly = False
        tbContact.ReadOnly = False
        tbTel.ReadOnly = False
        tbEmail.ReadOnly = False
        tbAddress.ReadOnly = False
        tbFax.ReadOnly = False
        tbDetail.ReadOnly = False
        cmdSubmit.Enabled = True
        cmdUpload.Enabled = True
        cmdClear.Enabled = True


        tbName.Text = ""
        tbContact.Text = ""
        tbTel.Text = ""
        tbEmail.Text = ""
        tbAddress.Text = ""
        tbFax.Text = ""
        tbDetail.Text = ""
        pbImage.ImageLocation = vbNull
        cmdSubmit.Text = "Add"

        editIndex = -1
        suppliers_id = ""
    End Sub

    Function checkData() As Boolean
        Dim ch_email As New RegexUtilities
        If tbName.Text = "" Then
            MsgBox("Please input supplier name.")
            tbName.Select()
            Return False
        ElseIf checkName(tbName.Text) Then
            MsgBox("This supplier name is already.")
            tbName.Select()
            Return False
        ElseIf tbContact.Text = "" Then
            MsgBox("Please input contact name.")
            tbContact.Select()
            Return False
        ElseIf tbEmail.Text <> "" And Not ch_email.IsValidEmail(tbEmail.Text) Then
            MsgBox("Invalid e-mail format.")
            tbEmail.Select()
            Return False
        ElseIf tbAddress.Text = "" Then
            MsgBox("Please input address.")
            tbAddress.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.AutoGenerateColumns = False
        dgvData.EnableHeadersVisualStyles = False
        clearData()
        refreshSuppliers()
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If cmdClear.Enabled = False Then
            cmdClear.Enabled = True
            clearData()
            editIndex = -1
        ElseIf checkData() Then
            Dim suppliers As New Dictionary(Of String, String)
            suppliers.Add("suppliers_name", tbName.Text)
            suppliers.Add("suppliers_contact", tbContact.Text)
            suppliers.Add("suppliers_address", tbAddress.Text)
            suppliers.Add("suppliers_tel", tbTel.Text)
            suppliers.Add("suppliers_fax", tbFax.Text)
            suppliers.Add("suppliers_email", tbEmail.Text)
            suppliers.Add("suppliers_detail", tbDetail.Text)
            If cmdSubmit.Text = "Add" Then
                Dim img As String = ""
                If My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                End If

                suppliers.Add("suppliers_image", img)
                If config.Insert("tb_suppliers", suppliers) Then
                    If img <> "" Then
                        My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & img, True)
                    End If

                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "SUPPLIER",
                            "INSERT",
                            (
                            " Add 1 supplier record by " & My.Settings.login_name & ". \n" &
                            " Supplier name : " & tbName.Text & " \n " &
                            " Contact : " & tbContact.Text & " \n " &
                            " Address : " & tbAddress.Text & " \n " &
                            " Telephone : " & tbTel.Text & " \n " &
                            " Email : " & tbEmail.Text & " \n " &
                            " Fax : " & tbFax.Text & " \n " &
                            " Detail : " & tbDetail.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )
                End If


                Dim dt_new As DataTable = config.GetDataTable("SELECT * FROM tb_suppliers WHERE suppliers_name = '" & tbName.Text & "'")
                refreshSuppliers()
                clearData()
                For i As Integer = 0 To dt_main.Rows.Count - 1
                    If dt_new.Rows(0).Item("suppliers_id") = dt_main.Rows(i).Item("suppliers_id") Then
                        ViewData(i)
                    End If
                Next
            Else

                Dim img As String = ""
                Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                If dt_main.Rows(editIndex).Item("suppliers_image") = "" And My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                    My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & img, True)
                ElseIf dt_main.Rows(editIndex).Item("suppliers_image") <> "" And Path.GetFileName(pbImage.ImageLocation) <> dt_main.Rows(editIndex).Item("suppliers_image") And My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                    My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & dt_main.Rows(editIndex).Item("suppliers_image"))
                    My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & img, True)
                Else
                    img = dt_main.Rows(editIndex).Item("suppliers_image")
                End If
                suppliers.Add("suppliers_image", img)

                If config.Update("tb_suppliers", suppliers, "suppliers_id = '" & dt_main.Rows(editIndex).Item("suppliers_id") & "'") Then
                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "SUPPLIER",
                            "UPDATE",
                            (
                            " Update 1 supplier record by " & My.Settings.login_name & ". \n" &
                            " From data ." &
                            " Supplier name : " & edit_row.Item("suppliers_name") & " \n " &
                            " Contact : " & edit_row.Item("suppliers_contact") & " \n " &
                            " Address : " & edit_row.Item("suppliers_address") & " \n " &
                            " Telephone : " & edit_row.Item("suppliers_tel") & " \n " &
                            " Email : " & edit_row.Item("suppliers_email") & " \n " &
                            " Fax : " & edit_row.Item("suppliers_fax") & " \n " &
                            " Detail : " & edit_row.Item("suppliers_detail") & " \n " &
                            " Image. : " & edit_row.Item("suppliers_image") & " \n " &
                            " To data ." &
                            " Supplier name : " & tbName.Text & " \n " &
                            " Contact : " & tbContact.Text & " \n " &
                            " Address : " & tbAddress.Text & " \n " &
                            " Telephone : " & tbTel.Text & " \n " &
                            " Email : " & tbEmail.Text & " \n " &
                            " Fax : " & tbFax.Text & " \n " &
                            " Detail : " & tbDetail.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )
                End If

                Dim d As Integer = editIndex
                refreshSuppliers()
                clearData()
                ViewData(d)

            End If
        End If
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
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colEdit" Then
                clearData()
                Try




                    editIndex = e.RowIndex
                    edit_row = dt_main.Rows(e.RowIndex)
                    tbName.Text = dt_main.Rows(e.RowIndex).Item("suppliers_name")
                    tbContact.Text = dt_main.Rows(e.RowIndex).Item("suppliers_contact")
                    tbTel.Text = dt_main.Rows(e.RowIndex).Item("suppliers_tel")
                    tbEmail.Text = dt_main.Rows(e.RowIndex).Item("suppliers_email")
                    tbAddress.Text = dt_main.Rows(e.RowIndex).Item("suppliers_address")
                    tbFax.Text = dt_main.Rows(e.RowIndex).Item("suppliers_fax")
                    tbDetail.Text = dt_main.Rows(e.RowIndex).Item("suppliers_detail")
                Catch ex As Exception
                End Try


                If dt_main.Rows(e.RowIndex).Item("suppliers_image").ToString <> "" Then
                    pbImage.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & dt_main.Rows(e.RowIndex).Item("suppliers_image")
                Else
                    pbImage.ImageLocation = vbNull
                End If

                cmdSubmit.Text = "Save"
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then
                If MessageBox.Show("You want to delete " & dt_main(e.RowIndex).Item("suppliers_name"), "Delete suppliers", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If config.ExecuteNonQuery("DELETE FROM tb_suppliers WHERE suppliers_id ='" & dt_main(e.RowIndex).Item("suppliers_id") & "'") Then
                        If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & dt_main.Rows(e.RowIndex).Item("suppliers_image")) Then
                            My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & dt_main.Rows(e.RowIndex).Item("suppliers_image"))
                            log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                                "SUPPLIER",
                                "DELETE",
                                (
                                " Remove 1 supplier record by " & My.Settings.login_name & ". \n" &
                                " Supplier name : " & dt_main.Rows(e.RowIndex).Item("suppliers_name") & " \n " &
                                " Contact : " & dt_main.Rows(e.RowIndex).Item("suppliers_contact") & " \n " &
                                " Address : " & dt_main.Rows(e.RowIndex).Item("suppliers_address") & " \n " &
                                " Telephone : " & dt_main.Rows(e.RowIndex).Item("suppliers_tel") & " \n " &
                                " Email : " & dt_main.Rows(e.RowIndex).Item("suppliers_email") & " \n " &
                                " Fax : " & edit_row.Item("suppliers_fax") & " \n " &
                                " Detail : " & dt_main.Rows(e.RowIndex).Item("suppliers_detail") & " \n " &
                                " Image. : " & dt_main.Rows(e.RowIndex).Item("suppliers_image") & " \n "
                                ),
                                My.Settings.login_name
                         )
                        End If
                        refreshSuppliers()
                        clearData()
                        editIndex = -1
                    End If
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
        refreshSuppliers()
        clearData()
    End Sub

    Private Sub Suppliers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fm As New ImportSupplier
        fm.Show()

    End Sub
End Class