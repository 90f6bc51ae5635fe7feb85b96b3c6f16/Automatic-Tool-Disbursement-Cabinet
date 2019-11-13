Imports System.IO

Public Class StockFindProduct

    Public products_id As String
    Public jobs_op_tools_id As String
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Sub refreshData()
        Dim str As String = ""

        If cbProductsBrand.SelectedIndex > -1 And cbProductsBrand.SelectedIndex < cbProductsBrand.Items.Count - 1 Then
            str &= " tb_products.products_brand_id = '" & cbProductsBrand.SelectedValue & "' "
        End If

        If cbProductsType.SelectedIndex > -1 And cbProductsType.SelectedIndex < cbProductsType.Items.Count - 1 Then
            str &= " tb_products.products_type_id = '" & cbProductsType.SelectedValue & "' "

        End If

        If cbProductsGroup.SelectedIndex > -1 And cbProductsGroup.SelectedIndex < cbProductsGroup.Items.Count - 1 Then
            str &= " tb_products.products_group_id = '" & cbProductsGroup.SelectedValue & "' "
        End If

        If tbSearch.Text <> "" Then
            str = " And products_code Like '%" & tbSearch.Text & "%'"
        End If

        If jobs_op_tools_id <> "" Then
            dgvData.DataSource = config.GetDataTable("SELECT * FROM tb_products, tb_products_type, tb_products_group, tb_products_brand, tb_jobs_op_tools_use " &
                                                            "WHERE tb_products.products_brand_id = tb_products_brand.products_brand_id " &
                                                            "AND tb_products.products_group_id = tb_products_group.products_group_id " &
                                                            "AND tb_products.products_type_id = tb_products_type.products_type_id " &
                                                            "AND tb_products.products_id = tb_jobs_op_tools_use.products_id " &
                                                            "AND tb_jobs_op_tools_use.jobs_op_tools_id = '" & jobs_op_tools_id & "' " &
                                                            str &
                                                            " ORDER BY products_code")
        Else
            dgvData.DataSource = config.GetDataTable("SELECT * FROM tb_products, tb_products_type, tb_products_group, tb_products_brand " &
                                                            "WHERE tb_products.products_brand_id = tb_products_brand.products_brand_id " &
                                                            "AND tb_products.products_group_id = tb_products_group.products_group_id " &
                                                            "AND tb_products.products_type_id = tb_products_type.products_type_id " &
                                                            str &
                                                            " ORDER BY products_code")
        End If

    End Sub



    Sub refreshGroupData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_group ORDER BY products_group_name")

        Dim row As DataRow = dt.NewRow
        row("products_group_id") = "0"
        row("products_group_name") = "All Groups"
        dt.Rows.Add(row)

        cbProductsGroup.DataSource = dt
        cbProductsGroup.DisplayMember = "products_group_name"
        cbProductsGroup.ValueMember = "products_group_id"
        'cbProductsGroup.AutoCompleteSource = AutoCompleteSource.ListItems
        'cbProductsGroup.DropDownStyle = ComboBoxStyle.DropDown
        'cbProductsGroup.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" And index <> "All Groups" Then
            cbProductsGroup.SelectedValue = index
        Else
            cbProductsGroup.SelectedIndex = cbProductsGroup.Items.Count - 1
        End If
    End Sub

    Sub refreshTypeData(ByVal index As String)

        Dim str As String = ""
        If cbProductsGroup.Text <> "All Groups" Then
            str = " WHERE products_group_id = '" & cbProductsGroup.SelectedValue & "' "
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_type " & str & " ORDER BY products_type_name")

        Dim row As DataRow = dt.NewRow
        row("products_type_id") = "0"
        row("products_type_name") = "All Types"
        dt.Rows.Add(row)

        cbProductsType.DataSource = dt
        cbProductsType.DisplayMember = "products_type_name"
        cbProductsType.ValueMember = "products_type_id"
        'cbProductsType.AutoCompleteSource = AutoCompleteSource.ListItems
        'cbProductsType.DropDownStyle = ComboBoxStyle.DropDown
        'cbProductsType.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" And index <> "All Types" Then
            cbProductsType.SelectedValue = index
        Else
            cbProductsType.SelectedIndex = cbProductsType.Items.Count - 1
        End If
    End Sub

    Sub refreshBrandData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_brand ORDER BY products_brand_name")

        Dim row As DataRow = dt.NewRow
        row("products_brand_id") = "0"
        row("products_brand_name") = "All Brands"
        dt.Rows.Add(row)

        cbProductsBrand.DataSource = dt
        cbProductsBrand.DisplayMember = "products_brand_name"
        cbProductsBrand.ValueMember = "products_brand_id"
        'cbProductsBrand.AutoCompleteSource = AutoCompleteSource.ListItems
        'cbProductsBrand.DropDownStyle = ComboBoxStyle.DropDown
        'cbProductsBrand.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" And index <> "All Brands" Then
            cbProductsBrand.SelectedValue = index
        Else
            cbProductsBrand.SelectedIndex = cbProductsBrand.Items.Count - 1
        End If
    End Sub

    Private Sub StockFindProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False
        dgvData.AutoGenerateColumns = False
        refreshGroupData("All Groups")
        If cbProductsGroup.Items.Count > 0 Then
            refreshTypeData("All Types")
        End If
        refreshBrandData("All Brands")
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colSelect" Then
                products_id = dgvData.Rows(e.RowIndex).Cells("id").Value
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cbProductsGroup_DropDownClosed(sender As Object, e As EventArgs) Handles cbProductsGroup.DropDownClosed
        refreshTypeData("All Types")
    End Sub

    Private Sub cmdSearchALL_Click(sender As Object, e As EventArgs) Handles cmdSearchALL.Click
        refreshData()
    End Sub
End Class