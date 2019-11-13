Imports System.Globalization
Imports System.IO

Public Class Restock

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim in_stock_log_id As String = ""
    Dim out_stock_log_id As String = ""
    Dim type_id As String = ""

    Dim editIndex As Integer = -1
    Dim dt_main As DataTable
    Dim dt_in As DataTable
    Dim dt_out As DataTable
    Dim dt_qty As DataTable
    Dim dt_product As DataTable
    Dim stock_layout As DataTable
    Dim qty, products_order As Int16
    Public employee_name As String = ""
    Public date_disabled As Boolean = True


    Public user_id As Int16 = 0

    Dim log As New Log

    Dim edit_row As DataRow

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDataIN.EnableHeadersVisualStyles = False
        dgvDataIN.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)


        dgvDataIN.AutoGenerateColumns = False


        dtpEventIN.Enabled = Not date_disabled



        clearINData()
        refreshINData()

        If cbRecieveProduct.Items.Count > 0 Then
            cbRecieveProduct.SelectedIndex = 0
        End If

        getQty(cbRecieveProduct.SelectedValue)
    End Sub

    Function checkDataIN() As Boolean
        Dim ch_email As New RegexUtilities

        Dim qty As Int16 = 0
        Dim stock_price As Double = 0

        If tbQty.Text = "" Then
            qty = 0
            tbQty.Text = 0
        Else
            Try
                qty = Convert.ToInt16(tbQty.Text)
            Catch ex As Exception
                qty = 0
                tbQty.Text = 0
            End Try

        End If


        If tbStockPrice.Text = "" Then
            stock_price = 0
            tbStockPrice.Text = 0
        Else
            Try
                stock_price = Convert.ToDouble(tbStockPrice.Text)
            Catch ex As Exception
                stock_price = 0
                tbStockPrice.Text = 0
            End Try

        End If

        If cbRecieveProduct.Text = "" Then
            MsgBox("Plese select product. ")
            cbRecieveProduct.Select()
        ElseIf cbRecieveHow2Buy.Items.Count = 0 Then
            MsgBox("Product [" & cbRecieveProduct.Text & "] does not have supplier please add supplier at tool register page. ")
            cbRecieveHow2Buy.Text = ""
            cbRecieveHow2Buy.Select()
        ElseIf cbRecieveHow2Buy.Text = "" Then
            MsgBox("Plese select supplier. ")
            cbRecieveHow2Buy.Select()
        ElseIf qty < 1 Then
            MsgBox("Plese insert product qty More than 0. ")
            tbQty.Select()
            Return False
        Else
            Return True
        End If
    End Function


    Sub clearINData()
        refreshProductsData("")
        If cbRecieveProduct.Items.Count > 0 Then
            cbRecieveProduct.SelectedIndex = 0
            refreshHow2BuyData("", cbRecieveProduct.SelectedValue)
        End If

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)


        dtpINStart.Value = firstDay
        dtpINEnd.Value = firstDay.AddMonths(1).AddDays(-1)
        dtpEventIN.Value = DateTime.Now
        dtpINEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpINStart.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpEventIN.CustomFormat = "yyyy-MMM-dd HH:mm"

        tbQty.Text = ""
        in_stock_log_id = ""
        txtEmployee.Text = employee_name
        tbRecieveRemark.Text = ""
    End Sub


    Sub refreshProductsData(ByVal index As String)

        Dim str As String = ""
        dt_product = config.GetDataTable("SELECT * FROM tb_products " & str & " ORDER BY products_code")
        cbRecieveProduct.DataSource = dt_product
        cbRecieveProduct.DisplayMember = "products_code"
        cbRecieveProduct.ValueMember = "products_id"
        cbRecieveProduct.AutoCompleteSource = AutoCompleteSource.ListItems
        cbRecieveProduct.DropDownStyle = ComboBoxStyle.DropDown
        cbRecieveProduct.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" Then
            cbRecieveProduct.SelectedValue = index
        End If
    End Sub


    Sub refreshHow2BuyData(ByVal index As String, ByVal products_id As String)

        Dim str As String = " AND products_id = '" & products_id & "'"
        Dim dt As DataTable = config.GetDataTable("SELECT CASE adjust WHEN '' THEN suppliers_name ELSE suppliers_name || '[' || products_supplier_code || ']' || '['|| IFNULL(adjust,'-') || ']' END   as 'suppliers_name' , " &
                                                  "how2buy_id FROM tb_how2buy , tb_suppliers WHERE tb_how2buy.suppliers_id = tb_suppliers.suppliers_id " & str & " ORDER BY suppliers_name")
        cbRecieveHow2Buy.DataSource = dt
        cbRecieveHow2Buy.DisplayMember = "suppliers_name"
        cbRecieveHow2Buy.ValueMember = "how2buy_id"
        cbRecieveHow2Buy.AutoCompleteSource = AutoCompleteSource.ListItems
        cbRecieveHow2Buy.DropDownStyle = ComboBoxStyle.DropDown
        cbRecieveHow2Buy.AutoCompleteMode = AutoCompleteMode.Suggest
        If cbRecieveHow2Buy.Items.Count > 0 Then
            If index <> "" Then
                cbRecieveHow2Buy.SelectedValue = index
            End If
        Else
            cbRecieveHow2Buy.Text = ""
        End If

    End Sub

    Sub refreshINData()





        Dim str As String = ""
        If tbINSearch.Text <> "" Then
            str = " AND ((products_code LIKE '%" & tbINSearch.Text & "%') OR (products_name1 LIKE '%" & tbINSearch.Text & "%') OR (products_name2 LIKE '%" & tbINSearch.Text & "%')) "
        End If

        Dim st As String = dtpINStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim en As String = dtpINEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & en & "') "

        dt_in = config.GetDataTable("SELECT *, printf('%.2f', sale_prices) AS sale_prices_2 FROM tb_stock_log, tb_how2buy, tb_products, tb_suppliers , tb_products_type WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND tb_how2buy.products_id = tb_products.products_id AND tb_how2buy.suppliers_id = tb_suppliers.suppliers_id AND tb_products_type.products_type_id = tb_products.products_type_id AND stock_type = 'in' " & str & " ORDER BY tb_stock_log.event_date DESC")
        dgvDataIN.DataSource = dt_in
    End Sub


    Sub getQty(ByVal id As String)
        Try
            Dim str As String = " WHERE ((products_id = " & id & ")) "
            Dim st As String = dtpINStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
            Dim en As String = dtpINEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

            Dim str2 As String = " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & en & "') "


            Dim si As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in' " & str2
            Dim so As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out' " & str2


            Dim sai As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in' and event_date <= '" & st & "'"
            Dim sao As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out' and event_date <= '" & st & "'"


            Dim pro As String = "SELECT  SUM(ifnull(order_qty,0)) -SUM( ifnull(order_recieve,0))  FROM tb_order_list WHERE  products_id = t2.products_id "


            dt_qty = config.GetDataTable("SELECT * , ifnull((" & si & "),0) as qty_in , ifnull((" & so & "),0) as qty_out , ((ifnull((" & si & "),0) - ifnull((" & so & "),0)) + (ifnull((" & sai & "),0) - ifnull((" & sao & "),0))) as qty , (ifnull((" & sai & "),0) - ifnull((" & sao & "),0)) as amount , ifnull((" & pro & "),0) as  order_qty FROM tb_products as t2 " & str & " ORDER BY products_name1, products_code")

            qty = dt_qty.Rows(0).Item("qty")

            products_order = dt_qty.Rows(0).Item("order_qty")
            lblBalance.Text = qty.ToString
            lblOrder.Text = products_order.ToString


            Dim slot As String = "select * from tb_how2buy,tb_stock_layouts where tb_how2buy.products_id = " & id & " AND tb_how2buy.slot = tb_stock_layouts.stock_layouts_id"
            stock_layout = config.GetDataTable(slot)
            Dim location_x As Int16 = stock_layout.Rows(0).Item("stock_layouts_x")
            Dim location_y As Int16 = stock_layout.Rows(0).Item("stock_layouts_y")

            lblLocation.Text = Convert.ToChar(Keys.A + Convert.ToInt32(location_x) - 1) & location_y.ToString()
        Catch
        End Try
    End Sub

    Private Sub cmdRecieveSave_Click(sender As Object, e As EventArgs) Handles cmdRecieveSave.Click
        If checkDataIN() Then
            Dim stock_log As New Dictionary(Of String, String)
            stock_log.Add("how2buy_id", cbRecieveHow2Buy.SelectedValue)
            stock_log.Add("stock_type", "in")
            stock_log.Add("stock_qty", tbQty.Text)
            stock_log.Add("stock_price", tbStockPrice.Text)
            stock_log.Add("event_date", dtpEventIN.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")))
            stock_log.Add("updateby", txtEmployee.Text)
            stock_log.Add("stock_remark", tbRecieveRemark.Text)

            If in_stock_log_id = "" Then
                If config.Insert("tb_stock_log", stock_log) Then



                    Dim dt_new As DataTable = config.GetDataTable("SELECT order_id , order_list_id , ifnull(order_qty,0) as order_qty, ifnull(order_recieve,0) as order_recieve FROM tb_order_list WHERE products_id = '" & cbRecieveProduct.SelectedValue.ToString & "' AND  order_qty > order_recieve ")
                    Dim recieve_qty As Int16 = Convert.ToInt16(tbQty.Text)
                    For i As Int16 = 0 To dt_new.Rows.Count - 1
                        Dim order_list As New Dictionary(Of String, String)

                        Dim order_qty As Integer = dt_new.Rows(i).Item("order_qty")
                        Dim order_recieve As Integer = dt_new.Rows(i).Item("order_recieve")
                        Dim balance As Integer = order_qty - order_recieve

                        If (balance < recieve_qty) Then
                            order_list.Add("order_recieve", (order_qty).ToString)
                            recieve_qty = recieve_qty - balance

                        Else
                            order_list.Add("order_recieve", (order_recieve + recieve_qty).ToString)
                            recieve_qty = 0
                        End If
                        config.Update("tb_order_list", order_list, "order_list_id = '" & dt_new.Rows(i).Item("order_list_id") & "'")

                        If recieve_qty <= 0 Then
                            Exit For
                        End If

                    Next



                    Dim dt_how2buy As DataTable = config.GetDataTable("SELECT *  FROM tb_how2buy WHERE tb_how2buy.how2buy_id = '" & cbRecieveHow2Buy.SelectedValue.ToString & "' ")

                    If dt_how2buy.Rows.Count > 0 Then
                        Dim old_qty As Integer = Convert.ToInt16(dt_how2buy.Rows(0).Item("products_qty").ToString)
                        Dim old_cost As Double = Convert.ToDouble(dt_how2buy.Rows(0).Item("products_cost").ToString)
                        Dim add_cost As Double = Convert.ToDouble(tbStockPrice.Text)
                        Dim add_qty As Integer = Convert.ToInt16(tbQty.Text)

                        Dim new_qty As Integer = old_qty + add_qty
                        Dim new_cost As Double = ((old_qty * old_cost) + (add_qty * add_cost)) / new_qty

                        Dim how2buy As New Dictionary(Of String, String)
                        how2buy.Add("products_qty", new_qty)
                        how2buy.Add("products_cost", new_cost)

                        config.Update("tb_how2buy", how2buy, "how2buy_id = '" & cbRecieveHow2Buy.SelectedValue.ToString & "'")


                    End If


                    log.add(dtpEventIN.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")),
                                "STOCK RECEIVE",
                                "INSERT",
                                (
                                " Add 1 Received by " & txtEmployee.Text & ". \n" &
                                " Product code : " & cbRecieveProduct.Text & " \n " &
                                " Supplier : " & cbRecieveHow2Buy.Text & " \n " &
                                " Received Qty. : " & tbQty.Text & " \n " &
                                " Location : " & lblLocation.Text & " \n " &
                                " Received date : " & dtpEventIN.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")) & " \n " &
                                " Received by : " & txtEmployee.Text & " \n "
                                ),
                                My.Settings.login_name
                         )

                        refreshINData()
                        clearINData()
                    End If
                Else

                If config.Update("tb_stock_log", stock_log, "stock_log_id = '" & in_stock_log_id & "'") Then

                    Dim dt_new As DataTable = config.GetDataTable("SELECT order_id , order_list_id , ifnull(order_qty,0) as order_qty, ifnull(order_recieve,0) as order_recieve FROM tb_order_list WHERE products_id = '" & cbRecieveProduct.SelectedValue.ToString & "' AND  order_qty > order_recieve ")

                    Dim recieve_qty As Int16 = Convert.ToInt16(tbQty.Text)
                    For i As Int16 = 0 To dt_new.Rows.Count - 1
                        Dim order_list As New Dictionary(Of String, String)


                        Dim order_qty As Integer = dt_new.Rows(i).Item("order_qty")
                        Dim order_recieve As Integer = dt_new.Rows(i).Item("order_recieve")
                        Dim balance As Integer = order_qty - order_recieve

                        If (balance < recieve_qty) Then
                            order_list.Add("order_recieve", (order_qty).ToString)
                            recieve_qty = recieve_qty - balance
                        Else
                            order_list.Add("order_recieve", (order_recieve + recieve_qty).ToString)
                            recieve_qty = 0
                        End If
                        config.Update("tb_order_list", order_list, "order_list_id = '" & dt_new.Rows(i).Item("order_list_id") & "'")

                        If recieve_qty <= 0 Then
                            Exit For
                        End If

                    Next

                    log.add(dtpEventIN.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")),
                            "STOCK RECEIVE",
                            "UPDATE",
                            (
                            " Update 1 Received by " & txtEmployee.Text & ". \n" &
                            " From data. \n" &
                            " Product code : " & edit_row.Item("products_code").ToString & " \n " &
                            " Supplier : " & edit_row.Item("suppliers_name").ToString & " \n " &
                            " Received Qty. : " & edit_row.Item("stock_qty").ToString & " \n " &
                            " Received date : " & edit_row.Item("event_date").ToString & " \n " &
                            " Received by : " & edit_row.Item("updateby").ToString & " \n " &
                            " To data. \n" &
                            " Product code : " & cbRecieveProduct.Text & " \n " &
                            " Supplier : " & cbRecieveHow2Buy.Text & " \n " &
                            " Received Qty. : " & tbQty.Text & " \n " &
                            " Received date : " & dtpEventIN.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")) & " \n " &
                            " Received by : " & txtEmployee.Text & " \n "
                            ),
                            My.Settings.login_name
                     )

                    refreshINData()
                    clearINData()
                    in_stock_log_id = ""
                End If
            End If
        End If

    End Sub


    Private Sub cmdRecieveCancel_Click(sender As Object, e As EventArgs) Handles cmdRecieveCancel.Click
        refreshINData()

        clearINData()
    End Sub


    Private Sub dgvDataIN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataIN.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            'TODO - Button Clicked - Execute Code Here
            If dgvDataIN.Columns(e.ColumnIndex).Name = "colINEdit" Then

                dgvDataIN.Rows(e.RowIndex).Selected = True
                edit_row = dt_in.Rows(e.RowIndex)
                clearINData()
                tbQty.Text = dt_in.Rows(e.RowIndex).Item("stock_qty")
                tbRecieveRemark.Text = dt_in.Rows(e.RowIndex).Item("stock_remark")
                dtpEventIN.Value = Convert.ToDateTime(dt_in.Rows(e.RowIndex).Item("event_date"))
                in_stock_log_id = dt_in.Rows(e.RowIndex).Item("stock_log_id")
                refreshProductsData(dt_in.Rows(e.RowIndex).Item("products_id"))
                If cbRecieveProduct.Items.Count > 0 Then
                    If cbRecieveProduct.SelectedIndex > -1 Then
                        refreshHow2BuyData(dt_in.Rows(e.RowIndex).Item("how2buy_id"), cbRecieveProduct.SelectedValue)
                    End If

                End If



            ElseIf dgvDataIN.Columns(e.ColumnIndex).Name = "colINDel" Then
                If MessageBox.Show("Do you want to Delete Product Data" & dt_in.Rows(e.RowIndex).Item("products_code") & "จำนวน " & dt_in.Rows(e.RowIndex).Item("stock_qty") & " ชิ้น หรือไม่", "ลบข้อมูลการรับสินค้าเข้า", MessageBoxButtons.YesNo) = DialogResult.Yes Then



                    If config.ExecuteNonQuery("DELETE FROM tb_stock_log WHERE stock_log_id ='" & dt_in.Rows(e.RowIndex).Item("stock_log_id") & "'") Then

                        Dim dt_how2buy As DataTable = config.GetDataTable("SELECT *  FROM tb_how2buy WHERE tb_how2buy.how2buy_id = '" & dt_in.Rows(e.RowIndex).Item("how2buy_id").ToString & "' ")

                        If dt_how2buy.Rows.Count > 0 Then
                            Dim old_qty As Integer = Convert.ToInt16(dt_how2buy.Rows(0).Item("products_qty").ToString)
                            Dim old_cost As Double = Convert.ToDouble(dt_how2buy.Rows(0).Item("products_cost").ToString)
                            Dim delete_cost As Double = Convert.ToDouble(dt_in.Rows(e.RowIndex).Item("stock_price").ToString)
                            Dim delete_qty As Integer = Convert.ToInt16(dt_in.Rows(e.RowIndex).Item("stock_qty").ToString)

                            Dim new_qty As Integer = old_qty - delete_qty
                            Dim new_cost As Double = ((old_qty * old_cost) - (delete_qty * delete_cost)) / new_qty

                            Dim how2buy As New Dictionary(Of String, String)
                            how2buy.Add("products_qty", new_qty)
                            how2buy.Add("products_cost", new_cost)

                            config.Update("tb_how2buy", how2buy, "how2buy_id = '" & dt_in.Rows(e.RowIndex).Item("how2buy_id").ToString & "'")


                        End If

                        Dim dt_new As DataTable = config.GetDataTable("SELECT order_id , order_list_id , ifnull(order_qty,0) as order_qty, ifnull(order_recieve,0) as order_recieve FROM tb_order_list WHERE products_id = '" & dt_in.Rows(e.RowIndex).Item("products_id").ToString & "' AND  order_recieve > 0 ORDER BY order_id DESC ")
                        Dim recieve_qty As Int16 = Convert.ToInt16(dt_in.Rows(e.RowIndex).Item("stock_qty").ToString)
                        For i As Int16 = 0 To dt_new.Rows.Count - 1
                            Dim order_list As New Dictionary(Of String, String)

                            Dim order_recieve As Integer = dt_new.Rows(i).Item("order_recieve")
                            Dim balance As Integer = recieve_qty - order_recieve

                            If (balance > 0) Then
                                order_list.Add("order_recieve", "0")
                                recieve_qty = balance

                            Else
                                order_list.Add("order_recieve", (order_recieve - recieve_qty).ToString)
                                recieve_qty = 0
                            End If

                            config.Update("tb_order_list", order_list, "order_list_id = '" & dt_new.Rows(i).Item("order_list_id") & "'")

                            If recieve_qty <= 0 Then
                                Exit For
                            End If

                        Next


                        log.add(dtpEventIN.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")),
                            "STOCK LIST",
                            "DELETE",
                            (
                            " Remove 1 Issue by " & txtEmployee.Text & ".  \n" &
                            " Product code : " & dt_in.Rows(e.RowIndex).Item("products_code").ToString & " \n " &
                            " Supplier : " & dt_in.Rows(e.RowIndex).Item("suppliers_name").ToString & " \n " &
                            " Received Qty. : " & dt_in.Rows(e.RowIndex).Item("stock_qty").ToString & " \n " &
                            " Received date : " & dt_in.Rows(e.RowIndex).Item("event_date").ToString & " \n " &
                            " Received by : " & dt_in.Rows(e.RowIndex).Item("updateby").ToString & " \n "
                            ),
                            My.Settings.login_name
                        )
                        clearINData()
                        refreshINData()
                    End If
                End If



            End If


        End If
    End Sub


    Private Sub cmdINSearch_Click(sender As Object, e As EventArgs)
        refreshINData()
        clearINData()
    End Sub


    Function get_op(ByVal machine As String) As String
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs_op_machines WHERE machines_id = '" & machine & "'")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("jobs_op_id")
        Else
            Return "0"
        End If
    End Function


    Private Sub cbRecieveProduct_DropDownClosed(sender As Object, e As EventArgs)
        If cbRecieveProduct.Items.Count > 0 Then
            If cbRecieveProduct.SelectedIndex > -1 Then
                refreshHow2BuyData("", cbRecieveProduct.SelectedValue)
            End If

        End If
    End Sub



    Private Sub cmdFindProduct_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub cmdFindSup_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub cbRecieveHow2Buy_DropDownClosed(sender As Object, e As EventArgs)
        If cbRecieveHow2Buy.Items.Count > 0 And cbRecieveHow2Buy.SelectedIndex > -1 Then
            Dim dt As DataTable = config.GetDataTable("SELECT ifnull((SELECT (char(64 + stock_layouts_x) || stock_layouts_y ) as slot FROM tb_stock_layouts WHERE  stock_layouts_id = t2.slot),'-') as slot  FROM tb_how2buy as t2 WHERE how2buy_id = '" & cbRecieveHow2Buy.SelectedValue & "'")
            If dt.Rows.Count > 0 Then
                lblLocation.Text = dt.Rows(0).Item(0)
            End If
        End If
    End Sub

    Private Sub cbRecieveProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRecieveProduct.SelectedIndexChanged
        If cbRecieveProduct.Items.Count > 0 Then
            If cbRecieveProduct.SelectedIndex > -1 Then
                refreshHow2BuyData("", cbRecieveProduct.SelectedValue.ToString)
            End If
        Else
            cbRecieveHow2Buy.Items.Clear()
            cbRecieveHow2Buy.Text = ""
        End If
        If cbRecieveProduct.SelectedIndex <> -1 Then
            getQty(cbRecieveProduct.SelectedValue.ToString())

        End If
    End Sub

    Private Sub cbRecieveHow2Buy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRecieveHow2Buy.SelectedIndexChanged
        If cbRecieveHow2Buy.Items.Count > 0 Then
            If cbRecieveHow2Buy.SelectedIndex > -1 Then
                Dim dt As DataTable = config.GetDataTable("SELECT ifnull((SELECT (char(64 + stock_layouts_x) || stock_layouts_y ) as slot FROM tb_stock_layouts WHERE  stock_layouts_id = t2.slot),'-') as slot , prices  FROM tb_how2buy as t2 WHERE how2buy_id = '" & cbRecieveHow2Buy.SelectedValue.ToString & "'")
                If dt.Rows.Count > 0 Then
                    lblLocation.Text = dt.Rows(0).Item(0)
                    tbStockPrice.Text = dt.Rows(0).Item("prices").ToString
                End If


            End If
        End If
    End Sub

    Private Sub dgvDataIN_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        For i As Int16 = e.RowIndex To e.RowCount + e.RowIndex - 1
            Dim d() As String = dgvDataIN.Rows(i).Cells(0).Value.ToString.Split("-")
            dgvDataIN.Rows(i).Cells(0).Value = d(2) & "-" & d(1) & "-" & d(0)
        Next
    End Sub

    Private Sub cmdFindProduct_Click_1(sender As Object, e As EventArgs) Handles cmdFindProduct.Click
        Dim sfp As New StockFindProduct
        sfp.ShowDialog()
        If sfp.products_id <> "" Then
            cbRecieveProduct.SelectedValue = sfp.products_id
            If cbRecieveProduct.Items.Count > 0 Then
                If cbRecieveProduct.SelectedIndex > -1 Then
                    refreshHow2BuyData("", cbRecieveProduct.SelectedValue)
                End If
            End If
        End If
    End Sub

    Private Sub cmdINSearch_Click_1(sender As Object, e As EventArgs) Handles cmdINSearch.Click
        refreshINData()

    End Sub

    Private Sub cmdFindSup_Click_1(sender As Object, e As EventArgs) Handles cmdFindSup.Click
        Dim sfs As New StockFindSuppliers
        sfs.ShowDialog()
        If sfs.how2buy_id <> "" Then
            cbRecieveHow2Buy.SelectedValue = sfs.how2buy_id
        End If
    End Sub

    Private Sub Restock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()

    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim fm_order_manage As New OrderManage
        fm_order_manage.ShowDialog()
    End Sub
End Class