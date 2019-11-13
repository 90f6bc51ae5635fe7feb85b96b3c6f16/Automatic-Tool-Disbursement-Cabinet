Imports System.IO

Public Class ProductBrands
    Private products_brand_name As String = ""
    Private products_brand_id As String = ""
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Dim editIndex As Integer = -1
    Sub refreshData()
        dt_main = config.GetDataTable("Select * , (Select COUNT(*) FROM tb_products_brand WHERE products_brand_id <= t1.products_brand_id ) As 'no' FROM tb_products_brand as t1 ORDER BY products_brand_name")
        dgvData.DataSource = dt_main
    End Sub

    Sub clearData()
        products_brand_id = ""
        products_brand_name = ""
        txtName.Text = ""
        cmdSubmit.Text = "Add"
    End Sub

    Function checkName(ByVal name As String)
        If editIndex > -1 Then
            If dt_main.Rows(editIndex).Item("products_brand_name") = name Then
                Return False
            End If
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_product_brand WHERE products_brand_name = '" & name & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If txtName.Text = "" Then
            MsgBox("Please input name of product brand.")
            txtName.Select()
        ElseIf txtName.Text.Replace(" ", "") = "" Then
            MsgBox("Please input name of product brand.")
            txtName.Select()
        ElseIf checkName(txtName.Text) Then
            MsgBox("This name of product brand is already")
            txtName.Select()
        Else
            Dim products_brand As New Dictionary(Of String, String)
            products_brand.Add("products_brand_name", txtName.Text)
            If cmdSubmit.Text = "Add" Then
                If config.Insert("tb_products_brand", products_brand) Then
                    MsgBox("Add product brand complate")
                    clearData()
                    refreshData()
                End If
            Else
                If config.Update("tb_products_brand", products_brand, "products_brand_name = '" & products_brand_name & "'") Then
                    MsgBox("Update product brand complate")
                    clearData()
                    refreshData()
                End If
            End If
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearData()
    End Sub

    Private Sub Productsbrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.EnableHeadersVisualStyles = False
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)

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
                products_brand_id = dt_main.Rows(e.RowIndex).Item("products_brand_id").ToString
                products_brand_name = dt_main.Rows(e.RowIndex).Item("products_brand_name").ToString

                editIndex = e.RowIndex
                txtName.Text = products_brand_name
                cmdSubmit.Text = "Save"
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then
                If dt_main.Rows(e.RowIndex).Item("products_brand_id") = 1 Then
                    MsgBox("You can not delete default data.")
                Else
                    If MessageBox.Show("You want to delete products brand " & dt_main.Rows(e.RowIndex).Item("products_brand_name"), "Delete products brand", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        If config.ExecuteNonQuery("DELETE FROM tb_products_brand WHERE products_brand_id ='" & dt_main.Rows(e.RowIndex).Item("products_brand_id") & "'") Then
                            config.ExecuteNonQuery("UPDATE tb_products SET products_brand_id = '1' WHERE products_brand_id = '" & dt_main.Rows(e.RowIndex).Item("products_brand_id") & "' ")
                            refreshData()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class