Imports System.Globalization
Imports System.IO

Public Class UserType

    Dim log As New Log

    Dim edit_row As DataRow


    Private user_type_name As String = ""
    Private user_type_id As String = ""
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Dim editIndex As Integer = -1

    Sub refreshUserType()
        dt_main = config.GetDataTable("SELECT * FROM tb_user_type as t1 ")
        dgvData.DataSource = dt_main
        editIndex = -1
    End Sub

    Sub clearData()
        cbLicense1.Enabled = True
        cbLicense2.Enabled = True
        cbLicense3.Enabled = True
        cbLicense4.Enabled = True
        cbLicense5.Enabled = True
        cbLicense6.Enabled = True
        cbLicense7.Enabled = True
        cbLicense8.Enabled = True
        cbLicense9.Enabled = True
        cbLicense10.Enabled = True

        cbLicense1.Checked = False
        cbLicense2.Checked = False
        cbLicense3.Checked = False
        cbLicense4.Checked = False
        cbLicense5.Checked = False
        cbLicense6.Checked = False
        cbLicense7.Checked = False
        cbLicense8.Checked = False
        cbLicense9.Checked = False
        cbLicense10.Checked = False

        user_type_name = ""
        txtName.Text = ""
        cmdSubmit.Text = "Add"
    End Sub

    Function checkUserTypeName(ByVal name As String)

        If editIndex > -1 Then
            If dt_main.Rows(editIndex).Item("user_type_name") = name Then
                Return False
            End If
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_user_type WHERE user_type_name = '" & name & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If txtName.Text = "" Then
            MsgBox("Please input type name.")
            txtName.Select()
        ElseIf checkUserTypeName(txtName.Text) Then
            MsgBox("Type name is already.")
            txtName.Select()
        Else

            Dim user_type As New Dictionary(Of String, String)
            user_type.Add("user_type_name", txtName.Text)
            user_type.Add("user_type_license1", Convert.ToInt32(cbLicense1.Checked))
            user_type.Add("user_type_license2", Convert.ToInt32(cbLicense2.Checked))
            user_type.Add("user_type_license3", Convert.ToInt32(cbLicense3.Checked))
            user_type.Add("user_type_license4", Convert.ToInt32(cbLicense4.Checked))
            user_type.Add("user_type_license5", Convert.ToInt32(cbLicense5.Checked))
            user_type.Add("user_type_license6", Convert.ToInt32(cbLicense6.Checked))
            user_type.Add("user_type_license7", Convert.ToInt32(cbLicense7.Checked))
            user_type.Add("user_type_license8", Convert.ToInt32(cbLicense8.Checked))
            user_type.Add("user_type_license9", Convert.ToInt32(cbLicense9.Checked))
            user_type.Add("user_type_license10", Convert.ToInt32(cbLicense10.Checked))


            If cmdSubmit.Text = "Add" Then

                If config.Insert("tb_user_type", user_type) Then
                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "USER TYPE",
                            "INSERT",
                            (
                            " Add 1 user type record by " & My.Settings.login_name & ". \n" &
                            " User type name : " & txtName.Text & " \n " &
                            " 1. Stock list : " & cbLicense1.Checked & " \n " &
                            " 2. Stock issue : " & cbLicense2.Checked & " \n " &
                            " 3. Stock receive : " & cbLicense3.Checked & " \n " &
                            " 4. Reorder : " & cbLicense4.Checked & " \n " &
                            " 5. Tool register : " & cbLicense5.Checked & " \n " &
                            " 6. Stock layout : " & cbLicense6.Checked & " \n " &
                            " 7. Supplier : " & cbLicense7.Checked & " \n " &
                            " 8. Report : " & cbLicense8.Checked & " \n " &
                            " 9. User : " & cbLicense9.Checked & " \n " &
                            " 10. Innovation : " & cbLicense10.Checked & " \n "
                            ),
                            My.Settings.login_name
                     )
                    MsgBox("Add user type complete.")
                    refreshUserType()
                    clearData()
                End If
            Else
                If config.Update("tb_user_type", user_type, "user_type_name = '" & user_type_name & "'") Then
                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "USER TYPE",
                            "UPDATE",
                            (
                            "Update 1 user type record by " & My.Settings.login_name & ". \n" &
                            "From data." &
                            " User type name : " & edit_row.Item("user_type_name") & " \n " &
                            " 1. Stock list : " & edit_row.Item("user_type_license1") & " \n " &
                            " 2. Stock issue : " & edit_row.Item("user_type_license2") & " \n " &
                            " 3. Stock receive : " & edit_row.Item("user_type_license3") & " \n " &
                            " 4. Reorder : " & edit_row.Item("user_type_license4") & " \n " &
                            " 5. Tool register : " & edit_row.Item("user_type_license5") & " \n " &
                            " 6. Stock layout : " & edit_row.Item("user_type_license6") & " \n " &
                            " 7. Supplier : " & edit_row.Item("user_type_license7") & " \n " &
                            " 8. Report : " & edit_row.Item("user_type_license8") & " \n " &
                            " 9. User : " & edit_row.Item("user_type_license9") & " \n " &
                            " 10. Innovation : " & edit_row.Item("user_type_license10") & " \n " &
                            "To data." &
                            " User type name : " & txtName.Text & " \n " &
                            " 1. Stock list : " & cbLicense1.Checked & " \n " &
                            " 2. Stock issue : " & cbLicense2.Checked & " \n " &
                            " 3. Stock receive : " & cbLicense3.Checked & " \n " &
                            " 4. Reorder : " & cbLicense4.Checked & " \n " &
                            " 5. Tool register : " & cbLicense5.Checked & " \n " &
                            " 6. Stock layout : " & cbLicense6.Checked & " \n " &
                            " 7. Supplier : " & cbLicense7.Checked & " \n " &
                            " 8. Report : " & cbLicense8.Checked & " \n " &
                            " 9. User : " & cbLicense9.Checked & " \n " &
                            " 10. Innovation : " & cbLicense10.Checked & " \n "
                            ),
                            My.Settings.login_name
                     )
                    MsgBox("Update user type complete")
                    refreshUserType()
                    clearData()
                End If
            End If
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearData()
    End Sub

    Private Sub UserType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.AutoGenerateColumns = False
        dgvData.EnableHeadersVisualStyles = False
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)

        refreshUserType()
        clearData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            dgvData.Rows(e.RowIndex).Selected = True
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colEdit" Then
                user_type_name = dt_main.Rows(e.RowIndex).Item("user_type_name")
                user_type_id = dt_main.Rows(e.RowIndex).Item("user_type_id")
                edit_row = dt_main.Rows(e.RowIndex)
                If dt_main.Rows(e.RowIndex).Item("user_type_id") = 1 Then
                    cbLicense1.Enabled = True
                    cbLicense2.Enabled = True
                    cbLicense3.Enabled = True
                    cbLicense4.Enabled = True
                    cbLicense5.Enabled = True
                    cbLicense6.Enabled = True
                    cbLicense7.Enabled = True
                    cbLicense8.Enabled = True
                    cbLicense9.Enabled = True
                    cbLicense10.Enabled = True
                End If

                cbLicense1.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license1"))
                cbLicense2.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license2"))
                cbLicense3.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license3"))
                cbLicense4.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license4"))
                cbLicense5.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license5"))
                cbLicense6.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license6"))
                cbLicense7.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license7"))
                cbLicense8.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license8"))
                cbLicense9.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license9"))
                cbLicense10.Checked = Convert.ToBoolean(dt_main.Rows(e.RowIndex).Item("user_type_license10"))

                editIndex = e.RowIndex
                txtName.Text = user_type_name
                cmdSubmit.Text = "Save"
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then
                If dt_main.Rows(e.RowIndex).Item("user_type_id") = 1 Then
                    MsgBox("You can not delete default data.")
                Else
                    If MessageBox.Show("You want to delete user type " & dt_main.Rows(e.RowIndex).Item("user_type_name"), "Delete user type", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        If config.ExecuteNonQuery("DELETE FROM tb_user_type WHERE user_type_id ='" & dt_main.Rows(e.RowIndex).Item("user_type_id") & "'") Then
                            config.ExecuteNonQuery("UPDATE tb_user SET user_type_id = '1' WHERE user_type_id = '" & dt_main.Rows(e.RowIndex).Item("user_type_id") & "' ")

                            log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "USER TYPE",
                            "DELETE",
                            (
                            "Delate 1 user type record by " & My.Settings.login_name & ". \n" &
                            " User type name : " & dt_main.Rows(e.RowIndex).Item("user_type_name") & " \n " &
                            " 1. Stock list : " & dt_main.Rows(e.RowIndex).Item("user_type_license1") & " \n " &
                            " 2. Stock issue : " & dt_main.Rows(e.RowIndex).Item("user_type_license2") & " \n " &
                            " 3. Stock receive : " & dt_main.Rows(e.RowIndex).Item("user_type_license3") & " \n " &
                            " 4. Reorder : " & dt_main.Rows(e.RowIndex).Item("user_type_license4") & " \n " &
                            " 5. Tool register : " & dt_main.Rows(e.RowIndex).Item("user_type_license5") & " \n " &
                            " 6. Stock layout : " & dt_main.Rows(e.RowIndex).Item("user_type_license6") & " \n " &
                            " 7. Supplier : " & dt_main.Rows(e.RowIndex).Item("user_type_license7") & " \n " &
                            " 8. Report : " & dt_main.Rows(e.RowIndex).Item("user_type_license8") & " \n " &
                            " 9. User : " & dt_main.Rows(e.RowIndex).Item("user_type_license9") & " \n " &
                            " 10. Innovation : " & dt_main.Rows(e.RowIndex).Item("user_type_license10") & " \n "
                            ),
                            My.Settings.login_name
                     )
                            refreshUserType()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class