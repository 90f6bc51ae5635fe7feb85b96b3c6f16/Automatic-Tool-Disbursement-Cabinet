Imports System.Globalization
Imports System.IO

Public Class Products

    Dim log As New Log

    Dim edit_row As DataRow

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim products_type_id As String = ""
    Dim products_brand_id As String = ""
    Dim product_id As String = ""
    Dim editIndex As Integer = -1
    Dim How2editIndex As Integer = -1
    Dim dt_main As DataTable
    Dim dt_how2buy As DataTable
    Dim border As New BorderColor()


    Sub CalculateReorder()
        Dim monthly_day As Int32 = (My.Settings.monthly_day)
        Dim working_day As Int32 = (My.Settings.working_day)

        If tbPercentSafety.Text = "" Then
            tbPercentSafety.Text = "0"
        End If

        If tbConsumption.Text = "" Then
            tbConsumption.Text = "0"
        End If

        Dim products_percent_safety As Double = Convert.ToDouble(tbPercentSafety.Text)
        Dim products_consumption As Int32 = Convert.ToInt32(tbConsumption.Text)



        Dim lead_time As Int32 = 0

        If dt_how2buy IsNot Nothing Then
            For i As Integer = 0 To dt_how2buy.Rows.Count - 1
                If dt_how2buy.Rows(i).Item("how2buy_inactive") = "Active" Then
                    lead_time = Convert.ToInt32(dt_how2buy.Rows(i).Item("time_delivery").ToString)
                    Exit For
                End If
            Next
        End If


        If lead_time = 0 Then
            lead_time = 7
        End If

        Dim day_consumption As Double = products_consumption / monthly_day
        Dim lead_time_consumption As Double = lead_time * day_consumption

        Dim products_reorder As Int32 = lead_time_consumption + (lead_time_consumption * products_percent_safety / 100)
        Dim products_order_quantity As Int32 = working_day * day_consumption

        tbReorder.Text = products_reorder
        tbOrder.Text = products_order_quantity


    End Sub

    Function checkCode(ByVal name As String)

        If editIndex > -1 Then
            If dt_main.Rows(editIndex).Item("products_code") = name Then
                Return False
            End If
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products WHERE products_code = '" & name & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub refreshData()
        Dim str As String = ""
        If tbSearch.Text <> "" Then
            str = " AND (products_code LIKE '%" & tbSearch.Text & "%' OR products_name1 LIKE '%" & tbSearch.Text & "%' OR products_name2 LIKE '%" & tbSearch.Text & "%'OR products_group_name LIKE '%" & tbSearch.Text & "%'OR products_brand_name LIKE '%" & tbSearch.Text & "%'OR products_type_name LIKE '%" & tbSearch.Text & "%')"
        End If

        dt_main = config.GetDataTable("SELECT * FROM tb_products as t1 " &
                                      "LEFT JOIN  tb_products_type ON t1.products_type_id = tb_products_type.products_type_id " &
                                      "LEFT JOIN tb_products_brand ON t1.products_brand_id = tb_products_brand.products_brand_id " &
                                      "LEFT JOIN  tb_products_group ON t1.products_group_id = tb_products_group.products_group_id " &
                                      "WHERE  t1.products_id not null " & str & "   GROUP BY t1.products_id  ORDER BY products_name1, products_code")
        dgvData.DataSource = dt_main
    End Sub

    Sub refreshTypeData(ByVal index As String, ByVal group_id As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_type WHERE products_group_id = '" & group_id & "' ORDER BY products_type_name")
        cbtype.DataSource = dt
        cbtype.DisplayMember = "products_type_name"
        cbtype.ValueMember = "products_type_id"
        cbtype.AutoCompleteSource = AutoCompleteSource.ListItems
        cbtype.DropDownStyle = ComboBoxStyle.DropDown
        cbtype.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" Then
            cbtype.SelectedValue = index
        End If
    End Sub

    Sub refreshBrandData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_brand  ORDER BY products_brand_name")
        cbBrand.DataSource = dt
        cbBrand.DisplayMember = "products_brand_name"
        cbBrand.ValueMember = "products_brand_id"
        cbBrand.AutoCompleteSource = AutoCompleteSource.ListItems
        cbBrand.DropDownStyle = ComboBoxStyle.DropDown
        cbBrand.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" Then
            cbBrand.SelectedValue = index
        End If
    End Sub

    Sub refreshGroupData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_products_group  ORDER BY products_group_name")
        cbGroup.DataSource = dt
        cbGroup.DisplayMember = "products_group_name"
        cbGroup.ValueMember = "products_group_id"
        cbGroup.AutoCompleteSource = AutoCompleteSource.ListItems
        cbGroup.DropDownStyle = ComboBoxStyle.DropDown
        cbGroup.AutoCompleteMode = AutoCompleteMode.Suggest

        If index <> "" Then
            cbGroup.SelectedValue = index
        End If
    End Sub

    Sub refreshLocationData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT stock_layouts_id , (char(64 + stock_layouts_x) || stock_layouts_y ) as stock_layouts_name FROM tb_stock_layouts WHERE  stock_layouts_use = '1' ORDER BY stock_layouts_name")
        cbLocation.DataSource = dt
        cbLocation.DisplayMember = "stock_layouts_name"
        cbLocation.ValueMember = "stock_layouts_id"

        If index <> "" Then
            cbLocation.Text = index
        Else
            cbLocation.SelectedIndex = -1
        End If
    End Sub

    Sub refreshSupplierData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_suppliers ORDER BY suppliers_name")
        cbSuppliers.DataSource = dt
        cbSuppliers.DisplayMember = "suppliers_name"
        cbSuppliers.ValueMember = "suppliers_id"
        cbSuppliers.AutoCompleteSource = AutoCompleteSource.ListItems
        cbSuppliers.DropDownStyle = ComboBoxStyle.DropDown
        cbSuppliers.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" Then
            cbSuppliers.SelectedValue = index
        End If
    End Sub

    Sub refreshHow2buy()
        If dt_how2buy.Columns.Count = 0 Then
            dt_how2buy = New DataTable
            dt_how2buy.Columns.Add("how2buy_id")
            dt_how2buy.Columns.Add("products_id")
            dt_how2buy.Columns.Add("suppliers_id")
            dt_how2buy.Columns.Add("suppliers_name")
            dt_how2buy.Columns.Add("adjust")
            dt_how2buy.Columns.Add("products_supplier_code")
            dt_how2buy.Columns.Add("prices")
            dt_how2buy.Columns.Add("sale_prices")
            dt_how2buy.Columns.Add("slot")
            dt_how2buy.Columns.Add("time_delivery")
            dt_how2buy.Columns("how2buy_id").AutoIncrement = False
        End If

        dt_how2buy.Columns("how2buy_id").AutoIncrement = False
        dgvHow2Buy.DataSource = dt_how2buy
        refreshSupplierData("")
        cmdAddHow2Buy.Text = "Add"
        tbPrice.Text = ""
        tbSalePrice.Text = ""
        cbAdjust.SelectedIndex = 0
        refreshLocationData("")
        tbTimeDelivery.Text = ""
        How2editIndex = -1
    End Sub

    Sub Viewdata(ByVal index As Integer)
        clearData()

        tbCode.ReadOnly = True
        tbName1.ReadOnly = True
        tbName2.ReadOnly = True
        tbCustomerCode.ReadOnly = True
        tbConner.ReadOnly = True
        tbPercentSafety.ReadOnly = True
        tbConsumption.ReadOnly = True
        cbGroup.Enabled = False
        cbtype.Enabled = False
        cbBrand.Enabled = False


        cbSuppliers.Enabled = False
        cbStatus.Enabled = False
        tbPrice.ReadOnly = True
        tbTimeDelivery.ReadOnly = True

        cmdClear.Enabled = False

        cmdUpload.Enabled = False
        cmdChooseDrawing.Enabled = False
        cmdClearDrawing.Enabled = False
        cmdClearImage.Enabled = False


        cmdAddHow2Buy.Enabled = False
        cmdCancle.Enabled = False

        dgvHow2Buy.Enabled = False
        tbCode.Text = dt_main.Rows(index).Item("products_code").ToString
        tbName1.Text = dt_main.Rows(index).Item("products_name1").ToString
        tbName2.Text = dt_main.Rows(index).Item("products_name2").ToString
        tbCustomerCode.Text = dt_main.Rows(index).Item("products_customer_code").ToString

        tbPercentSafety.Text = dt_main.Rows(index).Item("products_percent_safety").ToString
        tbConsumption.Text = dt_main.Rows(index).Item("products_consumption").ToString
        tbReorder.Text = dt_main.Rows(index).Item("products_reorder").ToString
        tbOrder.Text = dt_main.Rows(index).Item("products_order_quantity").ToString

        refreshGroupData(dt_main.Rows(index).Item("products_group_id"))
        refreshTypeData(dt_main.Rows(index).Item("products_type_id"), cbGroup.SelectedValue)
        refreshBrandData(dt_main.Rows(index).Item("products_brand_id"))

        If dt_main.Rows(index).Item("products_image").ToString <> "" Then
            pbImage.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(index).Item("products_image")
        Else
            pbImage.ImageLocation = ""
        End If

        If dt_main.Rows(index).Item("products_drawing").ToString <> "" Then
            tbDrawing.Text = Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(index).Item("products_drawing")
        Else
            tbDrawing.Text = ""
        End If

        tbConner.Text = dt_main.Rows(index).Item("products_conner")

        dt_how2buy = config.GetDataTable("SELECT how2buy_id , products_id, tb2.suppliers_id as 'suppliers_id', suppliers_name, prices, ifnull((SELECT (char(64 + stock_layouts_x) || stock_layouts_y ) as slot FROM tb_stock_layouts WHERE  stock_layouts_id = tb2.slot),'-') as slot, time_delivery, sale_prices, adjust,products_supplier_code, products_cost, products_qty, how2buy_inactive FROM tb_how2buy as tb2, tb_suppliers WHERE tb2.suppliers_id = tb_suppliers.suppliers_id AND products_id = '" & dt_main.Rows(index).Item("products_id") & "'")
        refreshHow2buy()
    End Sub
    Sub clearData()

        dt_how2buy = New DataTable


        dt_how2buy.Columns.Add("how2buy_id")
        dt_how2buy.Columns.Add("products_id")
        dt_how2buy.Columns.Add("suppliers_id")
        dt_how2buy.Columns.Add("suppliers_name")
        dt_how2buy.Columns.Add("adjust")
        dt_how2buy.Columns.Add("products_supplier_code")
        dt_how2buy.Columns.Add("prices")
        dt_how2buy.Columns.Add("sale_prices")
        dt_how2buy.Columns.Add("slot")
        dt_how2buy.Columns.Add("time_delivery")
        dt_how2buy.Columns.Add("how2buy_inactive")

        dt_how2buy.Columns("how2buy_id").AutoIncrement = False

        tbCode.ReadOnly = False
        tbName1.ReadOnly = False
        tbName2.ReadOnly = False
        tbCustomerCode.ReadOnly = False
        tbConner.ReadOnly = False
        tbPercentSafety.ReadOnly = False
        tbConsumption.ReadOnly = False
        cbGroup.Enabled = True
        cbtype.Enabled = True
        cbBrand.Enabled = True


        cbSuppliers.Enabled = True
        cbStatus.Enabled = True
        tbPrice.ReadOnly = False
        tbTimeDelivery.ReadOnly = False

        cmdSubmit.Enabled = True

        cmdUpload.Enabled = True
        cmdViewImage.Enabled = True
        cmdClearImage.Enabled = True

        cmdChooseDrawing.Enabled = True
        cmdViewDrawing.Enabled = True
        cmdClearDrawing.Enabled = True

        cmdAddHow2Buy.Enabled = True
        cmdCancle.Enabled = True
        cmdClear.Enabled = True

        cbStatus.SelectedIndex = 0
        tbCode.Text = ""
        tbName1.Text = ""
        tbName2.Text = ""
        tbCustomerCode.Text = ""
        tbSupplierCode.Text = ""
        tbConner.Text = "0"
        tbPercentSafety.Text = "0"
        tbConsumption.Text = "0"
        tbReorder.Text = "0"
        tbOrder.Text = "0"
        tbPrice.Text = ""
        tbSalePrice.Text = ""
        tbTimeDelivery.Text = ""

        refreshGroupData("")

        If cbGroup.Items.Count > 0 Then
            cbGroup.SelectedIndex = 0
            refreshTypeData("", cbGroup.SelectedValue)
        End If

        refreshBrandData("")
        refreshSupplierData("")
        editIndex = -1


        pbImage.ImageLocation = ""
        dgvHow2Buy.DataSource = New DataTable
        dgvHow2Buy.Enabled = True
        cmdSubmit.Text = "Add"
    End Sub

    Function checkData() As Boolean
        If tbCode.Text = "" Then
            MsgBox("Please input products code.")
            tbCode.Select()
            Return False
        ElseIf checkCode(tbCode.Text) Then
            MsgBox("This name of product type is already")
            tbCode.Select()
            Return False
        ElseIf cbGroup.SelectedIndex < 0 Then
            MsgBox("Please choose products group.")
            cbtype.Select()
            Return False
        ElseIf cbtype.SelectedIndex < 0 Then
            MsgBox("Please choose products type.")
            cbtype.Select()
            Return False
        ElseIf cbBrand.SelectedIndex < 0 Then
            MsgBox("Please choose products brand.")
            cbBrand.Select()
        Else
            Return True
        End If
    End Function

    Private Sub cmdEditType_Click(sender As Object, e As EventArgs) Handles cmdEditType.Click
        Dim product_type As New ProductTypes
        product_type.ShowDialog()
        refreshTypeData(products_type_id, cbGroup.SelectedValue)
    End Sub

    Private Sub cmdEditBrand_Click(sender As Object, e As EventArgs) Handles cmdEditBrand.Click
        Dim product_brand As New ProductBrands
        product_brand.ShowDialog()
        refreshBrandData(products_brand_id)
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvHow2Buy.AutoGenerateColumns = False
        dgvData.AutoGenerateColumns = False
        dgvData.EnableHeadersVisualStyles = False
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        clearData()
        refreshHow2buy()
        refreshData()


    End Sub

    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Dim op As New OpenFileDialog
        op.Filter = "JPG|*.jpg;*.jpeg"
        If op.ShowDialog() = DialogResult.OK Then
            pbImage.ImageLocation = op.FileName
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearData()
        refreshData()

    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If cmdClear.Enabled = False Then
            cmdClear.Enabled = True
            clearData()
            refreshData()
        ElseIf checkData() Then
            Dim product As New Dictionary(Of String, String)
            product.Add("products_code", tbCode.Text)
            product.Add("products_name1", tbName1.Text)
            product.Add("products_name2", tbName2.Text)
            product.Add("products_customer_code", tbCustomerCode.Text)
            product.Add("products_group_id", cbGroup.SelectedValue)
            product.Add("products_type_id", cbtype.SelectedValue)
            product.Add("products_brand_id", cbBrand.SelectedValue)
            product.Add("products_conner", tbConner.Text)
            product.Add("products_percent_safety", tbPercentSafety.Text)
            product.Add("products_consumption", tbConsumption.Text)
            product.Add("products_reorder", tbReorder.Text)
            product.Add("products_order_quantity", tbOrder.Text)
            If cmdSubmit.Text = "Add" Then

                Dim img As String = ""
                If My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                End If

                Dim drawing As String = ""
                If My.Computer.FileSystem.FileExists(tbDrawing.Text) Then
                    Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                    drawing = time & Path.GetFileName(pbImage.ImageLocation)
                End If

                product.Add("products_image", img)
                product.Add("products_drawing", drawing)
                If config.Insert("tb_products", product) Then
                    If img <> "" Then
                        My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & img, True)
                    End If

                    If drawing <> "" Then
                        My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & drawing, True)
                    End If

                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "PRODUCT",
                            "INSERT",
                            (
                            " Add 1 product record by " & My.Settings.login_name & ". \n" &
                            " Product code : " & tbCode.Text & " \n " &
                            " Process : " & tbName1.Text & " \n " &
                            " Tool description  : " & tbName2.Text & " \n " &
                            " Customer code : " & tbCustomerCode.Text & " \n " &
                            " Supplier code : " & tbSupplierCode.Text & " \n " &
                            " Group : " & cbGroup.Text & " \n " &
                            " Type : " & cbtype.Text & " \n " &
                            " Brand : " & cbBrand.Text & " \n " &
                            " Safety stock : " & tbPercentSafety.Text & " \n " &
                            " Monthly consumption : " & tbConsumption.Text & " \n " &
                            " Reorder point : " & tbReorder.Text & " \n " &
                            " Order quantity : " & tbOrder.Text & " \n " &
                            " No. of edge : " & tbConner.Text & " \n " &
                            " Drawing : " & tbDrawing.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )

                End If

                Dim dt_new As DataTable = config.GetDataTable("SELECT MAX(products_id) as products_id FROM tb_products ")
                If dt_how2buy.Rows.Count > 0 Then

                    If dt_new.Rows.Count > 0 Then
                        For Each dr As DataRow In dt_how2buy.Rows
                            Dim how2buy As New Dictionary(Of String, String)
                            how2buy.Add("products_id", dt_new.Rows(0).Item("products_id"))
                            how2buy.Add("suppliers_id", dr("suppliers_id"))
                            how2buy.Add("adjust", dr("adjust"))
                            how2buy.Add("products_supplier_code", dr("products_supplier_code"))
                            how2buy.Add("prices", dr("prices"))
                            how2buy.Add("sale_prices", dr("sale_prices"))
                            how2buy.Add("how2buy_inactive", dr("how2buy_inactive"))
                            If dr("slot").ToString() <> "" Then
                                Dim x As String = Convert.ToByte(dr("slot").ToString().Chars(0)) - Keys.A + 1
                                Dim y As String = dr("slot").ToString().Substring(1, dr("slot").ToString().Length - 1)

                                Dim dt As DataTable = config.GetDataTable("SELECT stock_layouts_id FROM tb_stock_layouts WHERE stock_layouts_x = " & x & " AND stock_layouts_y = " & y)
                                If dt.Rows.Count > 0 Then
                                    how2buy.Add("slot", dt.Rows(0).Item(0))
                                Else
                                    how2buy.Add("slot", 0)
                                End If
                            Else
                                how2buy.Add("slot", 0)
                            End If


                            how2buy.Add("time_delivery", dr("time_delivery"))
                            config.Insert("tb_how2buy", how2buy)
                        Next
                    End If
                End If
                refreshData()
                clearData()

                For i As Integer = 0 To dt_main.Rows.Count - 1
                    If dt_new.Rows(0).Item("products_id") = dt_main.Rows(i).Item("products_id") Then
                        Viewdata(i)
                    End If
                Next

            Else

                Dim img As String = ""
                Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                If dt_main.Rows(editIndex).Item("products_image") = "" And My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                    My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & img, True)
                ElseIf dt_main.Rows(editIndex).Item("products_image") <> "" And Path.GetFileName(pbImage.ImageLocation) <> dt_main.Rows(editIndex).Item("products_image") And My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
                    img = time & Path.GetFileName(pbImage.ImageLocation)
                    If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_image")) Then
                        My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_image"))
                    End If
                    My.Computer.FileSystem.CopyFile(pbImage.ImageLocation, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & img, True)
                ElseIf pbImage.ImageLocation = "" Then
                    If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_image")) Then
                        My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_image"))
                    End If

                    img = ""
                Else
                    img = dt_main.Rows(editIndex).Item("products_image")
                End If

                product.Add("products_image", img)


                Dim drawing As String = ""
                Dim time_drawing As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")

                If dt_main.Rows(editIndex).Item("products_drawing") = "" And My.Computer.FileSystem.FileExists(tbDrawing.Text) Then
                    img = time & Path.GetFileName(tbDrawing.Text)
                    My.Computer.FileSystem.CopyFile(tbDrawing.Text, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & img, True)
                ElseIf dt_main.Rows(editIndex).Item("products_drawing") <> "" And Path.GetFileName(tbDrawing.Text) <> dt_main.Rows(editIndex).Item("products_drawing") And My.Computer.FileSystem.FileExists(tbDrawing.Text) Then
                    img = time & Path.GetFileName(tbDrawing.Text)
                    My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_drawing"))
                    My.Computer.FileSystem.CopyFile(tbDrawing.Text, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & img, True)
                ElseIf tbDrawing.Text = "" Then
                    If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_drawing")) Then
                        My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(editIndex).Item("products_drawing"))
                    End If
                    img = ""
                Else
                    img = dt_main.Rows(editIndex).Item("products_drawing")
                End If

                product.Add("products_drawing", img)

                If config.Update("tb_products", product, "products_id = '" & dt_main.Rows(editIndex).Item("products_id") & "'") Then

                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "PRODUCT",
                            "UPDATE",
                            (
                            " Update 1 product record by " & My.Settings.login_name & ". \n" &
                            " From data. " &
                            " Product code : " & edit_row.Item("products_code") & " \n " &
                            " Process : " & edit_row.Item("products_name1") & " \n " &
                            " Tool description  : " & edit_row.Item("products_name2") & " \n " &
                            " Customer code : " & edit_row.Item("products_customer_code") & " \n " &
                            " Group : " & edit_row.Item("products_group_name") & " \n " &
                            " Type : " & edit_row.Item("products_type_name") & " \n " &
                            " Brand : " & edit_row.Item("products_brand_name") & " \n " &
                            " Safety stock : " & edit_row.Item("products_percent_safety") & " \n " &
                            " Monthly consumption : " & edit_row.Item("products_consumption") & " \n " &
                            " Reorder point : " & edit_row.Item("products_reorder") & " \n " &
                            " Order quantity : " & edit_row.Item("products_order_quantity") & " \n " &
                            " No. of edge : " & edit_row.Item("products_conner") & " \n " &
                            " Drawing : " & edit_row.Item("products_drawing") & " \n " &
                            " Image. : " & edit_row.Item("products_image") & " \n " &
                            " To data. " &
                            " Product code : " & tbCode.Text & " \n " &
                            " Process : " & tbName1.Text & " \n " &
                            " Tool description  : " & tbName2.Text & " \n " &
                            " Customer code : " & tbCustomerCode.Text & " \n " &
                            " Supplier code : " & tbSupplierCode.Text & " \n " &
                            " Group : " & cbGroup.Text & " \n " &
                            " Type : " & cbtype.Text & " \n " &
                            " Brand : " & cbBrand.Text & " \n " &
                            " Safety stock : " & tbPercentSafety.Text & " \n " &
                            " Monthly consumption : " & tbConsumption.Text & " \n " &
                            " Reorder point : " & tbReorder.Text & " \n " &
                            " Order quantity : " & tbOrder.Text & " \n " &
                            " No. of edge : " & tbConner.Text & " \n " &
                            " Drawing : " & tbDrawing.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )
                End If


                If dt_how2buy.Rows.Count > 0 Then
                    Dim str As String = ""

                    For Each dr As DataRow In dt_how2buy.Rows
                        If dr("how2buy_id") <> 0 Then
                            If str <> "" Then
                                str = str & ","
                            End If
                            str = str & "'" & dr("how2buy_id") & "'"
                        End If
                    Next
                    If str <> "" Then
                        config.Delete("tb_how2buy", "products_id ='" & dt_main.Rows(editIndex).Item("products_id") & "' AND how2buy_id not in (" & str & ")")
                    End If


                    For Each dr As DataRow In dt_how2buy.Rows

                        Dim how2buy As New Dictionary(Of String, String)
                        how2buy.Add("products_id", dt_main.Rows(editIndex).Item("products_id"))
                        how2buy.Add("suppliers_id", dr("suppliers_id"))
                        how2buy.Add("prices", dr("prices"))
                        how2buy.Add("adjust", dr("adjust"))
                        how2buy.Add("products_supplier_code", dr("products_supplier_code"))
                        how2buy.Add("sale_prices", dr("sale_prices"))
                        how2buy.Add("how2buy_inactive", dr("how2buy_inactive"))
                        Dim x As String = Convert.ToByte(dr("slot").ToString().Chars(0)) - Keys.A + 1
                        Dim y As String = dr("slot").ToString().Substring(1, dr("slot").ToString().Length - 1)
                        Dim dt As DataTable = config.GetDataTable("SELECT stock_layouts_id FROM tb_stock_layouts WHERE stock_layouts_x = " & x & " AND stock_layouts_y = " & y)
                        If dt.Rows.Count > 0 Then
                            how2buy.Add("slot", dt.Rows(0).Item(0))
                        End If

                        how2buy.Add("time_delivery", dr("time_delivery"))

                        If Convert.ToInt16(dr("how2buy_id") = 0) Then
                            config.Insert("tb_how2buy", how2buy)
                        Else
                            config.Update("tb_how2buy", how2buy, "how2buy_id = '" & dr("how2buy_id") & "'")
                        End If
                    Next

                Else
                    config.Delete("tb_how2buy", "products_id ='" & dt_main.Rows(editIndex).Item("products_id") & "'")
                End If
                Dim d As Integer = editIndex
                refreshData()
                clearData()
                Viewdata(d)
            End If
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        refreshData()
        clearData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            dgvData.Rows(e.RowIndex).Selected = True
            'TODO - Button Clicked - Execute Code Here

            If dgvData.Columns(e.ColumnIndex).Name = "colPdf" Then
                If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_drawing")) Then
                    System.Diagnostics.Process.Start(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_drawing"))
                Else
                    MsgBox("Can not open drawing file.")
                End If
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colOpen" Then
                If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_image")) Then
                    System.Diagnostics.Process.Start(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_image"))
                Else
                    MsgBox("Can not open image file.")
                End If
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colView" Then
                editIndex = -1
                Viewdata(e.RowIndex)
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colEdit" Then
                clearData()
                editIndex = e.RowIndex
                edit_row = dt_main.Rows(e.RowIndex)
                tbCode.Text = dt_main.Rows(e.RowIndex).Item("products_code").ToString
                tbName1.Text = dt_main.Rows(e.RowIndex).Item("products_name1").ToString
                tbName2.Text = dt_main.Rows(e.RowIndex).Item("products_name2").ToString
                tbCustomerCode.Text = dt_main.Rows(e.RowIndex).Item("products_customer_code").ToString


                tbPercentSafety.Text = dt_main.Rows(e.RowIndex).Item("products_percent_safety").ToString
                tbConsumption.Text = dt_main.Rows(e.RowIndex).Item("products_consumption").ToString
                tbReorder.Text = dt_main.Rows(e.RowIndex).Item("products_reorder").ToString
                tbOrder.Text = dt_main.Rows(e.RowIndex).Item("products_order_quantity").ToString


                refreshGroupData(dt_main.Rows(e.RowIndex).Item("products_group_id"))
                refreshTypeData(dt_main.Rows(e.RowIndex).Item("products_type_id"), cbGroup.SelectedValue)
                refreshBrandData(dt_main.Rows(e.RowIndex).Item("products_brand_id"))

                If dt_main.Rows(e.RowIndex).Item("products_image").ToString <> "" Then
                    pbImage.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_image")
                Else
                    pbImage.ImageLocation = ""
                End If

                If dt_main.Rows(e.RowIndex).Item("products_drawing").ToString <> "" Then
                    tbDrawing.Text = Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_drawing")
                Else
                    tbDrawing.Text = ""
                End If

                tbConner.Text = dt_main.Rows(e.RowIndex).Item("products_conner")
                dt_how2buy = config.GetDataTable("SELECT how2buy_id , products_id, tb2.suppliers_id as 'suppliers_id', suppliers_name, prices, ifnull((SELECT (char(64 + stock_layouts_x) || stock_layouts_y ) as slot FROM tb_stock_layouts WHERE  stock_layouts_id = tb2.slot),'-') as slot, time_delivery, sale_prices, adjust, products_supplier_code, products_cost, products_qty, how2buy_inactive FROM tb_how2buy as tb2, tb_suppliers WHERE tb2.suppliers_id = tb_suppliers.suppliers_id AND products_id = '" & dt_main.Rows(e.RowIndex).Item("products_id") & "'")
                refreshHow2buy()
                cmdSubmit.Text = "Save"

            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then

                If MessageBox.Show("You want to delete " & dt_main.Rows(e.RowIndex).Item("products_code"), "Delete products", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If config.ExecuteNonQuery("DELETE FROM tb_products WHERE products_id ='" & dt_main.Rows(e.RowIndex).Item("products_id") & "'") Then
                        config.ExecuteNonQuery("DELETE FROM tb_how2buy WHERE products_id ='" & dt_main.Rows(e.RowIndex).Item("products_id") & "'")
                        If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_image")) Then
                            My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_image"))
                        End If

                        If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_drawing")) Then
                            My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & dt_main.Rows(e.RowIndex).Item("products_drawing"))
                        End If

                        log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "PRODUCT",
                            "DELETE",
                            (
                            " Remove 1 product record by " & My.Settings.login_name & ". \n" &
                            " Product code : " & dt_main.Rows(e.RowIndex).Item("products_code") & " \n " &
                            " Process : " & dt_main.Rows(e.RowIndex).Item("products_name1") & " \n " &
                            " Tool description  : " & dt_main.Rows(e.RowIndex).Item("products_name2") & " \n " &
                            " Customer code : " & dt_main.Rows(e.RowIndex).Item("products_customer_code") & " \n " &
                            " Group : " & dt_main.Rows(e.RowIndex).Item("products_group_name") & " \n " &
                            " Type : " & dt_main.Rows(e.RowIndex).Item("products_type_name") & " \n " &
                            " Brand : " & dt_main.Rows(e.RowIndex).Item("products_brand_name") & " \n " &
                            " Safety stock : " & dt_main.Rows(e.RowIndex).Item("products_percent_safety") & " \n " &
                            " Monthly consumption : " & dt_main.Rows(e.RowIndex).Item("products_consumption") & " \n " &
                            " Reorder point : " & dt_main.Rows(e.RowIndex).Item("products_reorder") & " \n " &
                            " Order quantity : " & dt_main.Rows(e.RowIndex).Item("products_order_quantity") & " \n " &
                            " No. of edge : " & dt_main.Rows(e.RowIndex).Item("products_conner") & " \n " &
                            " Drawing. : " & dt_main.Rows(e.RowIndex).Item("products_drawing") & " \n " &
                            " Image. : " & dt_main.Rows(e.RowIndex).Item("products_image") & " \n "
                            ),
                            My.Settings.login_name
                     )

                        refreshData()
                        editIndex = -1
                        clearData()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdAddHow2Buy_Click(sender As Object, e As EventArgs) Handles cmdAddHow2Buy.Click
        If cbSuppliers.SelectedIndex < 0 Then
            MsgBox("Please choose suppliers.")
            cbSuppliers.Select()
        ElseIf tbPrice.Text = "" Then
            MsgBox("Please input product price.")
            tbPrice.Select()
        ElseIf Not IsNumeric(tbPrice.Text) Then
            MsgBox("Please input product price number.")
            tbPrice.Select()
        ElseIf tbTimeDelivery.Text = "" Then
            MsgBox("Please input time delivery.")
            tbTimeDelivery.Select()
        Else
            If cmdAddHow2Buy.Text = "Add" Then
                Dim R As DataRow = dt_how2buy.NewRow
                R("how2buy_id") = "0"
                R("suppliers_id") = Convert.ToInt16(cbSuppliers.SelectedValue)
                R("suppliers_name") = cbSuppliers.SelectedItem("suppliers_name")
                R("products_supplier_code") = tbSupplierCode.Text
                R("adjust") = cbAdjust.SelectedItem
                R("prices") = tbPrice.Text
                R("sale_prices") = tbSalePrice.Text
                R("slot") = cbLocation.Text
                R("time_delivery") = tbTimeDelivery.Text
                R("how2buy_inactive") = cbStatus.Text
                dt_how2buy.Rows.Add(R)
                refreshHow2buy()
            Else
                dt_how2buy.Rows(How2editIndex).Item("suppliers_id") = Convert.ToInt16(cbSuppliers.SelectedValue)
                dt_how2buy.Rows(How2editIndex).Item("suppliers_name") = cbSuppliers.Text
                dt_how2buy.Rows(How2editIndex).Item("adjust") = cbAdjust.SelectedItem
                dt_how2buy.Rows(How2editIndex).Item("products_supplier_code") = tbSupplierCode.Text
                dt_how2buy.Rows(How2editIndex).Item("prices") = tbPrice.Text
                dt_how2buy.Rows(How2editIndex).Item("sale_prices") = tbSalePrice.Text
                dt_how2buy.Rows(How2editIndex).Item("slot") = cbLocation.Text
                dt_how2buy.Rows(How2editIndex).Item("time_delivery") = tbTimeDelivery.Text
                dt_how2buy.Rows(How2editIndex).Item("how2buy_inactive") = cbStatus.Text
                refreshHow2buy()
            End If
            CalculateReorder()
        End If
    End Sub

    Private Sub cmdCancle_Click(sender As Object, e As EventArgs) Handles cmdCancle.Click
        refreshHow2buy()
    End Sub

    Private Sub dgvHow2Buy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHow2Buy.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            If dgvHow2Buy.Columns(e.ColumnIndex).Name = "colHowEdit" Then
                How2editIndex = e.RowIndex
                tbTimeDelivery.Text = dt_how2buy.Rows(e.RowIndex).Item("time_delivery").ToString
                cbAdjust.SelectedItem = dt_how2buy.Rows(e.RowIndex).Item("adjust").ToString
                cbStatus.SelectedItem = dt_how2buy.Rows(e.RowIndex).Item("how2buy_inactive").ToString
                tbSupplierCode.Text = dt_how2buy.Rows(e.RowIndex).Item("products_supplier_code").ToString
                tbPrice.Text = dt_how2buy.Rows(e.RowIndex).Item("prices").ToString
                tbSalePrice.Text = dt_how2buy.Rows(e.RowIndex).Item("sale_prices").ToString
                refreshLocationData(dt_how2buy.Rows(e.RowIndex).Item("slot"))
                refreshSupplierData(dt_how2buy.Rows(e.RowIndex).Item("suppliers_id"))

                cmdAddHow2Buy.Text = "Save"
            ElseIf dgvHow2Buy.Columns(e.ColumnIndex).Name = "colHowDel" Then
                If MessageBox.Show("You want to delete buy data from  " & dt_how2buy.Rows(e.RowIndex).Item("suppliers_name") & ", price " & dt_how2buy.Rows(e.RowIndex).Item("prices") & " ?", "Delete how to buy", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    dt_how2buy.Rows.RemoveAt(e.RowIndex)
                    How2editIndex = -1
                    dgvHow2Buy.DataSource = dt_how2buy
                    MsgBox("Delete complete.")
                End If
            End If
        End If
    End Sub

    Private Sub tbPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrice.KeyPress
        Try
            If (Convert.ToByte(e.KeyChar) >= Keys.D0 And Convert.ToByte(e.KeyChar) <= Keys.D9) Or Convert.ToByte(e.KeyChar) = Keys.Back Or e.KeyChar = "." Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            e.Handled = True
        End Try

    End Sub

    Private Sub tbTimeDelivery_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTimeDelivery.KeyPress
        Try
            If (Convert.ToByte(e.KeyChar) >= Keys.D0 And Convert.ToByte(e.KeyChar) <= Keys.D9) Or Convert.ToByte(e.KeyChar) = Keys.Back Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            e.Handled = True
        End Try

    End Sub
    Private Sub tbMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbConsumption.KeyPress
        Try
            If (Convert.ToByte(e.KeyChar) >= Keys.D0 And Convert.ToByte(e.KeyChar) <= Keys.D9) Or Convert.ToByte(e.KeyChar) = Keys.Back Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            e.Handled = True
        End Try

    End Sub

    Private Sub tbMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPercentSafety.KeyPress
        Try
            If (Convert.ToByte(e.KeyChar) >= Keys.D0 And Convert.ToByte(e.KeyChar) <= Keys.D9) Or Convert.ToByte(e.KeyChar) = Keys.Back Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            e.Handled = True
        End Try

    End Sub
    Private Sub cmdSupplier_Click(sender As Object, e As EventArgs) Handles cmdSupplier.Click
        Dim supplier As New Suppliers
        supplier.ShowDialog()
        refreshSupplierData("")
    End Sub

    Private Sub cmdEditGroup_Click(sender As Object, e As EventArgs) Handles cmdEditGroup.Click
        Dim group As New ProductGroup
        group.ShowDialog()
        refreshGroupData("")
    End Sub

    Private Sub cbGroup_DropDownClosed(sender As Object, e As EventArgs) Handles cbGroup.DropDownClosed
        If cbGroup.SelectedIndex > -1 Then
            refreshTypeData("", cbGroup.SelectedValue)
        End If
    End Sub

    Private Sub cbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroup.SelectedIndexChanged
        If cbGroup.SelectedValue = "3" Then
            pnConner.Visible = True
        Else
            pnConner.Visible = False
            tbConner.Text = 0
        End If
    End Sub

    Private Sub cmdFindLocation_Click(sender As Object, e As EventArgs) Handles cmdFindLocation.Click
        Dim pfl As New StockLayoutFind

        If cbLocation.SelectedIndex > -1 Then
            pfl.stock_layout_id = cbLocation.SelectedValue.ToString
        End If


        pfl.ShowDialog()
        If pfl.stock_layout_id <> "" Then
            cbLocation.SelectedValue = pfl.stock_layout_id
        End If

    End Sub

    Private Declare Function CreateRectRgn Lib "gdi32.dll" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Private Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
    Private Declare Function CreateSolidBrush Lib "gdi32.dll" (ByVal crColor As Integer) As Integer
    Private Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Private Declare Function FrameRgn Lib "gdi32.dll" (ByVal hdc As Integer, ByVal hRgn As Integer, ByVal hBrush As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer

    Public Sub BorderColor(ByVal Ctl As Control, ByVal lColor As Color, Optional ByVal BorderWidth As Integer = 1)
        Dim i As Integer

        i = CreateRectRgn(BorderWidth, BorderWidth, Ctl.Width - BorderWidth, Ctl.Height - BorderWidth)
        SetWindowRgn(Ctl.Handle, i, False)

        i = CreateRectRgn(Ctl.Left, Ctl.Top, Ctl.Width + Ctl.Left, Ctl.Height + Ctl.Top)
        FrameRgn(GetDC(Ctl.Parent.Handle), i, CreateSolidBrush(CInt(ColorTranslator.ToWin32(lColor))), BorderWidth, BorderWidth)
    End Sub

    Private Sub cmdClearImage_Click(sender As Object, e As EventArgs) Handles cmdClearImage.Click
        pbImage.ImageLocation = ""
    End Sub

    Private Sub cmdViewImage_Click(sender As Object, e As EventArgs) Handles cmdViewImage.Click
        If My.Computer.FileSystem.FileExists(pbImage.ImageLocation) Then
            System.Diagnostics.Process.Start(pbImage.ImageLocation)
        End If
    End Sub

    Private Sub cmdChooseDrawing_Click(sender As Object, e As EventArgs) Handles cmdChooseDrawing.Click
        Dim op As New OpenFileDialog
        op.Filter = ""
        If op.ShowDialog() = DialogResult.OK Then
            tbDrawing.Text = op.FileName
        End If
    End Sub

    Private Sub cmdViewDrawing_Click(sender As Object, e As EventArgs) Handles cmdViewDrawing.Click
        If My.Computer.FileSystem.FileExists(tbDrawing.Text) Then
            System.Diagnostics.Process.Start(tbDrawing.Text)
        End If
    End Sub

    Private Sub cmdClearDrawing_Click(sender As Object, e As EventArgs) Handles cmdClearDrawing.Click
        tbDrawing.Text = ""
    End Sub

    Private Sub Products_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub

    Private Sub tbImport_Click(sender As Object, e As EventArgs) Handles tbImport.Click
        Dim fm As New ImportProduct
        fm.ShowDialog()
        refreshData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim fm As New ImportProductSupplier
        fm.Show()

    End Sub

    Private Sub tbConsumption_TextChanged(sender As Object, e As EventArgs) Handles tbConsumption.TextChanged
        CalculateReorder()
    End Sub

    Private Sub tbPercentSafety_TextChanged(sender As Object, e As EventArgs) Handles tbPercentSafety.TextChanged
        CalculateReorder()
    End Sub
End Class