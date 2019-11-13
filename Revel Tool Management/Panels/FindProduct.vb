Imports System.IO

Public Class FindProduct

    Public jobs_id As Int16 = 0
    Public products_id As New ArrayList
    Public products_name As New ArrayList
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Sub refreshData()
        Dim str As String = ""



        If tbSearch.Text <> "" Then
            str = " WHERE ( products_code Like '%" & tbSearch.Text & "%' OR products_name1 Like '%" & tbSearch.Text & "%' OR products_name2 Like '%" & tbSearch.Text & "%' ) "
        End If

        If jobs_id = 0 Then
            dgvData.DataSource = config.GetDataTable("SELECT tb_products.products_id , products_code, products_group_name , products_type_name, products_brand_name FROM tb_products " &
                                                     "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id " &
                                                     "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id " &
                                                     "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id " &
                                                     str &
                                                     " GROUP BY tb_products.products_id ORDER BY products_code")
        Else
            dgvData.DataSource = config.GetDataTable("SELECT tb_products.products_id , products_code, products_group_name , products_type_name, products_brand_name  FROM tb_products " &
                                                     "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id " &
                                                     "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id " &
                                                     "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id " &
                                                     "LEFT JOIN tb_jobs_op_tools_use ON tb_products.products_id = tb_jobs_op_tools_use.products_id " &
                                                     "LEFT JOIN tb_jobs_op_tools ON tb_jobs_op_tools_use.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id " &
                                                     "LEFT JOIN tb_jobs_op ON tb_jobs_op_tools.jobs_op_id = tb_jobs_op.jobs_op_id " &
                                                     "WHERE jobs_id = '" & jobs_id.ToString & "' " &
                                                     str &
                                                     " GROUP BY tb_products.products_id ORDER BY products_code")
        End If


    End Sub


    Private Sub StockFindProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False
        dgvData.AutoGenerateColumns = False

        refreshData()

    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colSelect" Then
                If dgvData.Rows(e.RowIndex).Selected Then
                    dgvData.Rows(e.RowIndex).Selected = False
                Else
                    dgvData.Rows(e.RowIndex).Selected = True
                End If

            End If
        End If
    End Sub


    Private Sub cmdSearchALL_Click(sender As Object, e As EventArgs) Handles cmdSearchALL.Click
        refreshData()
    End Sub

    Private Sub tbSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearch.KeyPress
        Try
            If Convert.ToByte(e.KeyChar) = Keys.Enter Then
                refreshData()
            End If
        Catch ex As Exception
            e.Handled = True
        End Try

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        products_id.Clear()
        products_name.Clear()

        For Each dr As DataGridViewRow In dgvData.SelectedRows
            products_id.Add(dr.Cells("id").Value)
            products_name.Add(dr.Cells("products_code").Value)
        Next
        Me.Close()

    End Sub

    Private Sub cmdCancle_Click(sender As Object, e As EventArgs) Handles cmdCancle.Click
        Me.Close()
    End Sub
End Class