Imports System.IO

Public Class ProductTypes
    Private products_type_name As String = ""
    Private products_type_id As String = ""
    Private products_group_id As String = ""
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Dim editIndex As Integer = -1

    Sub refreshData()
        dt_main = config.GetDataTable("SELECT * FROM tb_products_type as t1 , tb_products_group WHERE t1.products_group_id = tb_products_group.products_group_id AND t1.products_group_id = '" & cbGroup.SelectedValue & "' ORDER BY products_type_name")
        dgvData.DataSource = dt_main

    End Sub

    Sub refreshGroupData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_group ORDER BY products_group_name")
        cbGroup.DataSource = dt
        If index <> "" Then
            cbGroup.SelectedValue = index
        End If
    End Sub

    Sub clearData()
        refreshGroupData("")
        products_type_name = ""
        products_type_id = ""
        products_group_id = ""
        txtName.Text = ""
        cmdSubmit.Text = "Add"
        editIndex = -1
    End Sub

    Function checkName(ByVal name As String)
        If editIndex > -1 Then
            If products_type_name = name Then
                Return False
            End If
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_type WHERE products_type_name = '" & name & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If txtName.Text = "" Then
            MsgBox("Please input name of product type.")
            txtName.Select()
        ElseIf txtName.Text.Replace(" ", "") = "" Then
            MsgBox("Please input name of product type.")
            txtName.Select()
        ElseIf checkName(txtName.Text) Then
            MsgBox("This name of product type is already.")
            txtName.Select()
        Else
            Dim products_type As New Dictionary(Of String, String)
            products_type.Add("products_group_id", cbGroup.SelectedValue)
            products_type.Add("products_type_name", txtName.Text)

            If cmdSubmit.Text = "Add" Then
                If config.Insert("tb_products_type", products_type) Then
                    MsgBox("Add product type complate")
                    txtName.Text = ""
                    refreshData()
                End If
            Else
                If config.Update("tb_products_type", products_type, "products_type_name = '" & products_type_name & "'") Then
                    MsgBox("Update product type complate")
                    txtName.Text = ""
                    cmdSubmit.Text = "Add"
                    refreshData()
                End If
            End If
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        refreshData()
        clearData()
    End Sub

    Private Sub UserType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False

        dgvData.AutoGenerateColumns = False
        refreshData()
        clearData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            dgvData.Rows(e.RowIndex).Selected = True
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colEdit" Then
                products_group_id = dt_main.Rows(e.RowIndex).Item("products_group_id").ToString
                products_type_name = dt_main.Rows(e.RowIndex).Item("products_type_name").ToString
                products_type_id = dt_main.Rows(e.RowIndex).Item("products_type_id").ToString

                editIndex = e.RowIndex
                txtName.Text = products_type_name

                refreshGroupData(products_group_id)

                cmdSubmit.Text = "Save"
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then
                If dt_main.Rows(e.RowIndex).Item("products_type_id") = 1 Then
                    MsgBox("You can not delete default data.")
                Else
                    If MessageBox.Show("You want to delete products type " & dt_main.Rows(e.RowIndex).Item("products_type_name"), "Delete products type", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        If config.ExecuteNonQuery("DELETE FROM tb_products_type WHERE products_type_id ='" & dt_main.Rows(e.RowIndex).Item("products_type_id") & "'") Then
                            config.ExecuteNonQuery("UPDATE tb_products SET products_type_id = '1' WHERE products_type_id = '" & dt_main.Rows(e.RowIndex).Item("products_type_id") & "' ")
                            refreshData()
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub cmdEditGroup_Click(sender As Object, e As EventArgs) Handles cmdEditGroup.Click
        Dim group As New ProductGroup
        group.ShowDialog()
        refreshGroupData("")
        refreshData()
    End Sub

    Private Sub cbGroup_DropDownClosed(sender As Object, e As EventArgs) Handles cbGroup.DropDownClosed
        refreshData()

    End Sub
End Class