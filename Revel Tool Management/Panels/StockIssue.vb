Imports System.Globalization
Imports System.IO

Public Class StockIssue

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim in_stock_log_id As String = ""
    Dim out_stock_log_id As String = ""
    Dim type_id As String = ""

    Dim editIndex As Integer = -1
    Dim dt_main As DataTable
    Dim dt_out As DataTable
    Dim dt_qty As DataTable
    Dim stock_layout As DataTable
    Dim qty As Int16

    Public employee_name As String = ""
    Public date_disabled As Boolean = True

    Dim log As New Log
    Dim edit_row As DataRow

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOut.EnableHeadersVisualStyles = False
        dgvOut.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvOut.AutoGenerateColumns = False

        dtpOutEvent.Enabled = Not date_disabled

        'clearOUTData()

        refreshOUTData()

        If cbOutProduct.Items.Count > 0 Then
            cbOutProduct.SelectedIndex = 0
        End If




    End Sub


    Function checkDataOUT() As Boolean
        Dim ch_email As New RegexUtilities
        Dim qtyOut As Int16 = 0

        If tbOutQty.Text = "" Then
            qtyOut = 0
            tbOutQty.Text = 0
        Else
            Try
                qtyOut = Convert.ToInt16(tbOutQty.Text)
            Catch ex As Exception
                qtyOut = 0
                tbOutQty.Text = 0
            End Try

        End If
        If tbOutQty.Text = "" Then
            MsgBox("Please Insert Product Qty")
            tbOutQty.Select()
            Return False
        ElseIf cbOutHow2Buy.Items.Count = 0 Then
            MsgBox("Product [" & cbOutProduct.Text & "] does not have supplier please add supplier at tool register page. ")
            cbOutHow2Buy.Text = ""
            cbOutHow2Buy.Select()
        ElseIf qtyOut > qty Then
            MsgBox("Qty Not Enough")
            tbOutQty.Focus()
            Return False
        ElseIf qtyOut < 1 Then
            MsgBox("Please input qty more than 0 ")
            tbOutQty.Select()
            Return False
        Else
            Return True
        End If
    End Function

    'Sub clearOUTData()
    '    refreshJobsData("", "")
    '    If cbOutJob.Items.Count > 0 Then
    '        cbOutJob.SelectedIndex = 0
    '        refreshMachinesData("", cbOutJob.SelectedValue)
    '    End If

    '    If cbOutMachine.Items.Count > 0 Then
    '        cbOutMachine.SelectedIndex = 0
    '        refreshProcessData("", cbOutMachine.SelectedValue)
    '    End If

    '    If cbOutProcess.Items.Count > 0 Then
    '        cbOutProcess.SelectedIndex = 0
    '        refreshProductsDataOut("", cbOutProcess.SelectedValue)
    '    End If

    '    If cbOutProduct.Items.Count > 0 Then
    '        cbOutProduct.SelectedIndex = 0
    '        refreshHow2BuyDataOut("", cbOutProduct.SelectedValue)
    '    End If


    '    tbOutQty.Text = ""
    '    out_stock_log_id = ""
    '    tbOutRemark.Text = ""
    '    txtEmployee.Text = employee_name



    '    Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

    '    dtpOutStart.Value = firstDay
    '    dtpOutEnds.Value = firstDay.AddMonths(1).AddDays(-1)

    '    dtpOutEvent.Value = DateTime.Now

    '    dtpOutEvent.CustomFormat = "yyyy-MMM-dd HH:mm"
    '    dtpOutEnds.CustomFormat = "yyyy-MMM-dd HH:mm"
    '    dtpOutStart.CustomFormat = "yyyy-MMM-dd HH:mm"

    'End Sub

    'Sub refreshJobsData(ByVal index As String, ByVal machines_id As String)

    '    Dim str As String = ""
    '    If machines_id <> "" Then
    '        str = ", tb_jobs_op_machines , tb_jobs_op , tb_jobs  WHERE tb_jobs_op.jobs_id = tb_jobs.jobs_id AND tb_jobs_op.jobs_op_id = tb_jobs_op_machines.jobs_op_id AND machines_id = '" & machines_id & "' ORDER BY jobs_name"
    '    End If
    '    Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs " & str)
    '    cbOutJob.DataSource = dt
    '    cbOutJob.DisplayMember = "jobs_name"
    '    cbOutJob.ValueMember = "jobs_id"
    '    cbOutJob.AutoCompleteSource = AutoCompleteSource.ListItems
    '    cbOutJob.DropDownStyle = ComboBoxStyle.DropDown
    '    cbOutJob.AutoCompleteMode = AutoCompleteMode.Suggest
    '    If index <> "" Then
    '        cbOutJob.SelectedValue = index
    '    End If
    'End Sub

    'Sub refreshMachinesData(ByVal index As String, ByVal jobs_id As String)

    '    Dim str As String = ""
    '    If jobs_id <> "" Then
    '        str = ", tb_jobs_op_machines, tb_jobs_op WHERE tb_machines.machines_id = tb_jobs_op_machines.machines_id AND tb_jobs_op.jobs_op_id = tb_jobs_op_machines.jobs_op_id AND jobs_id = '" & jobs_id & "'  ORDER BY machines_name"
    '    End If
    '    Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_machines " & str)
    '    cbOutMachine.DataSource = dt
    '    cbOutMachine.DisplayMember = "machines_name"
    '    cbOutMachine.ValueMember = "machines_id"
    '    cbOutMachine.AutoCompleteSource = AutoCompleteSource.ListItems
    '    cbOutMachine.DropDownStyle = ComboBoxStyle.DropDown
    '    cbOutMachine.AutoCompleteMode = AutoCompleteMode.Suggest
    '    If index <> "" Then
    '        cbOutMachine.SelectedValue = index
    '    Else
    '        cbOutMachine.SelectedIndex = -1
    '        cbOutMachine.Text = ""
    '    End If
    'End Sub

    'Sub refreshProcessData(ByVal index As String, ByVal machines As String)

    '    Dim dt As DataTable = config.GetDataTable("SELECT  * FROM tb_jobs_op, tb_jobs_op_tools , tb_jobs_op_machines " &
    '                                              " WHERE tb_jobs_op_tools.jobs_op_id = tb_jobs_op_machines.jobs_op_id " &
    '                                              " AND tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
    '                                              " AND machines_id = '" & machines & "' AND jobs_id = '" & cbOutJob.SelectedValue & "' ORDER BY jobs_op_tools_name ")
    '    cbOutProcess.DataSource = dt
    '    cbOutProcess.DisplayMember = "jobs_op_tools_name"
    '    cbOutProcess.ValueMember = "jobs_op_tools_id"
    '    cbOutProcess.AutoCompleteSource = AutoCompleteSource.ListItems
    '    cbOutProcess.DropDownStyle = ComboBoxStyle.DropDown
    '    cbOutProcess.AutoCompleteMode = AutoCompleteMode.Suggest
    '    If index <> "" Then
    '        cbOutProcess.SelectedValue = index
    '    End If
    'End Sub


    Sub refreshOUTData()
        Dim str As String = ""
        If tbOutSearch.Text <> "" Then
            str = " AND ((products_code LIKE '%" & tbOutSearch.Text & "%') OR (products_name1 LIKE '%" & tbOutSearch.Text & "%') OR (products_name2 LIKE '%" & tbOutSearch.Text & "%')) "
        End If

        Dim dt As String = dtpOutStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpOutEnds.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "


        dt_out = config.GetDataTable("SELECT * , stock_qty * stock_price as amount " &
                                      "FROM tb_stock_log " &
                                      "LEFT JOIN tb_how2buy ON tb_stock_log.how2buy_id = tb_how2buy.how2buy_id " &
                                      "LEFT JOIN tb_products ON tb_how2buy.products_id = tb_products.products_id  " &
                                      "LEFT JOIN tb_jobs ON tb_stock_log.jobs_id = tb_jobs.jobs_id  " &
                                      "LEFT JOIN tb_machines ON tb_stock_log.machines_id = tb_machines.machines_id  " &
                                      "LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id  " &
                                      "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id  " &
                                      "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id  " &
                                      "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id  " &
                                      "LEFT JOIN tb_jobs_op_tools ON tb_stock_log.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id  " &
                                      "WHERE stock_type = 'out' " & str &
                                      "ORDER BY strftime('%Y-%m-%d %H:%M' , event_date )  DESC ")
        dgvOut.DataSource = dt_out
    End Sub
    Sub getQty(ByVal how2buy_id As String)
        Try

            Dim qty_in As Int16 = 0
            Dim qty_out As Int16 = 0

            Dim dt_qty_in As DataTable = config.GetDataTable("SELECT IFNULL(SUM(stock_qty),0) as qty  FROM tb_stock_log  WHERE stock_type = 'in' AND tb_stock_log.how2buy_id = " & how2buy_id)
            Dim dt_qty_out As DataTable = config.GetDataTable("SELECT IFNULL(SUM(stock_qty),0) as qty  FROM tb_stock_log  WHERE stock_type = 'out' AND tb_stock_log.how2buy_id = " & how2buy_id)

            If dt_qty_in.Rows.Count > 0 Then
                qty_in = dt_qty_in.Rows(0).Item("qty")
            End If

            If dt_qty_out.Rows.Count > 0 Then
                qty_out = dt_qty_out.Rows(0).Item("qty")
            End If

            Dim qty_product As Int16 = qty_in - qty_out

            lblBalance.Text = qty_product.ToString
            qty = qty_product

            Dim slot As String = "select * from tb_how2buy,tb_stock_layouts where tb_how2buy.how2buy_id = " & how2buy_id & " AND tb_how2buy.slot = tb_stock_layouts.stock_layouts_id"
            stock_layout = config.GetDataTable(slot)

            If stock_layout.Rows.Count > 0 Then
                Dim location_x As Int16 = stock_layout.Rows(0).Item("stock_layouts_x")
                Dim location_y As Int16 = stock_layout.Rows(0).Item("stock_layouts_y")

                lblLocation.Text = Convert.ToChar(Keys.A + Convert.ToInt32(location_x) - 1) & location_y.ToString()
            End If

        Catch

        End Try
    End Sub

    Sub refreshProductsDataOut(ByVal index As String, ByVal op_tools_use As String)

        Dim dt As DataTable = config.GetDataTable("SELECT *  FROM tb_jobs_op_tools_use, tb_products " &
                                                  " WHERE tb_jobs_op_tools_use.products_id = tb_products.products_id " &
                                                  "AND jobs_op_tools_id = '" & op_tools_use & "' ORDER BY products_code ")

        cbOutProduct.DataSource = dt
        cbOutProduct.DisplayMember = "products_code"
        cbOutProduct.ValueMember = "products_id"
        cbOutProduct.AutoCompleteSource = AutoCompleteSource.ListItems
        cbOutProduct.DropDownStyle = ComboBoxStyle.DropDown
        cbOutProduct.AutoCompleteMode = AutoCompleteMode.Suggest


        'Label1.Text = dt.Rows("l")

        If index <> "" Then
            cbOutProduct.SelectedValue = index
        End If
    End Sub


    Sub refreshHow2BuyDataOut(ByVal index As String, ByVal products_id As String)

        Dim str As String = " AND products_id = '" & products_id & "'"
        Dim dt As DataTable = config.GetDataTable("SELECT CASE adjust WHEN '' THEN suppliers_name ELSE suppliers_name || '[' || products_supplier_code || ']' || '['|| IFNULL(adjust,'-') || ']' END   as 'suppliers_name' , " &
                                                  "how2buy_id FROM tb_how2buy , tb_suppliers WHERE tb_how2buy.suppliers_id = tb_suppliers.suppliers_id " & str & " ORDER BY suppliers_name")
        cbOutHow2Buy.DataSource = dt
        cbOutHow2Buy.DisplayMember = "suppliers_name"
        cbOutHow2Buy.ValueMember = "how2buy_id"
        cbOutHow2Buy.AutoCompleteSource = AutoCompleteSource.ListItems
        cbOutHow2Buy.DropDownStyle = ComboBoxStyle.DropDown
        cbOutHow2Buy.AutoCompleteMode = AutoCompleteMode.Suggest
        If cbOutHow2Buy.Items.Count > 0 Then
            If index <> "" Then
                cbOutHow2Buy.SelectedValue = index
            End If
        Else
            cbOutHow2Buy.Text = ""
        End If

    End Sub




    Function get_op(ByVal machine As String) As String
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs_op_machines WHERE machines_id = '" & machine & "'")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("jobs_op_id")
        Else
            Return "0"
        End If
    End Function


    Private Sub cmdOutSearch_Click(sender As Object, e As EventArgs)
        refreshOUTData()
        'clearOUTData()
    End Sub



    'Private Sub cbOutJob_DropDownClosed(sender As Object, e As EventArgs)
    '    If cbOutJob.Items.Count > 0 And cbOutJob.SelectedIndex > -1 Then
    '        refreshMachinesData("", cbOutJob.SelectedValue)
    '        If cbOutMachine.Items.Count > 0 Then
    '            cbOutMachine.SelectedIndex = 0
    '        End If

    '    End If
    'End Sub

    'Private Sub cbOutMachine_DropDownClosed(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub cbOutProcess_DropDownClosed(sender As Object, e As EventArgs)
    '    If cbOutProcess.Items.Count > 0 And cbOutProcess.SelectedIndex > -1 Then
    '        refreshProductsDataOut("", cbOutProcess.SelectedValue)
    '        If cbOutProduct.Items.Count > 0 Then
    '            cbOutProduct.SelectedIndex = 0
    '        End If
    '    End If
    'End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)
        refreshOUTData()
    End Sub



    Private Sub cmdFindProductOut_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub cbOutHow2Buy_DropDownClosed(sender As Object, e As EventArgs) Handles cbOutHow2Buy.DropDownClosed

    End Sub

    Private Sub cbOutProduct_DropDownClosed(sender As Object, e As EventArgs)
        If cbOutProduct.Items.Count > 0 Then
            refreshHow2BuyDataOut("", cbOutProduct.SelectedValue)
        End If
    End Sub

    'Private Sub cbOutJob_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If cbOutJob.Items.Count > 0 Then
    '        If cbOutJob.SelectedIndex > -1 Then
    '            refreshMachinesData("", cbOutJob.SelectedValue.ToString)
    '            If cbOutMachine.Items.Count > 0 Then
    '                cbOutMachine.SelectedIndex = 0
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub cbOutMachine_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If cbOutMachine.Items.Count > 0 Then
    '        If cbOutMachine.SelectedIndex > -1 Then
    '            refreshProcessData("", cbOutMachine.SelectedValue.ToString)
    '            If cbOutProcess.Items.Count > 0 Then
    '                cbOutProcess.SelectedIndex = 0
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub cbOutProcess_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If cbOutProcess.Items.Count > 0 Then
    '        If cbOutProcess.SelectedIndex > -1 Then
    '            refreshProductsDataOut("", cbOutProcess.SelectedValue.ToString)
    '            If cbOutProduct.Items.Count > 0 Then
    '                cbOutProduct.SelectedIndex = 0
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub cbOutProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOutProduct.SelectedIndexChanged
        If cbOutProduct.Items.Count > 0 Then
            If cbOutProduct.SelectedIndex > -1 Then
                refreshHow2BuyDataOut("", cbOutProduct.SelectedValue.ToString)
                cbOutHow2Buy.SelectedIndex = 0
                If cbOutHow2Buy.Items.Count > 0 Then
                    getQty(cbOutHow2Buy.SelectedValue.ToString)
                End If
            End If
        End If

    End Sub

    Private Sub cbOutHow2Buy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOutHow2Buy.SelectedIndexChanged
        If cbOutHow2Buy.Items.Count > 0 Then
            If cbOutHow2Buy.SelectedIndex > -1 Then
                getQty(cbOutHow2Buy.SelectedValue.ToString)
            End If
        End If
    End Sub

    Private Sub dgvOut_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        For i As Int16 = e.RowIndex To e.RowCount + e.RowIndex - 1
            Dim d() As String = dgvOut.Rows(i).Cells(0).Value.ToString.Split("-")
            dgvOut.Rows(i).Cells(0).Value = d(2) & "-" & d(1) & "-" & d(0)
        Next
    End Sub

    'Private Sub cmdFindProductOut_Click_1(sender As Object, e As EventArgs) Handles cmdFindProductOut.Click
    '    If cbOutProcess.Items.Count > 0 And cbOutProcess.SelectedIndex > -1 Then
    '        Dim sfpo As New StockFindProduct
    '        sfpo.jobs_op_tools_id = cbOutProcess.SelectedValue
    '        sfpo.ShowDialog()
    '        If sfpo.products_id <> "" Then
    '            cbOutProduct.SelectedValue = sfpo.products_id
    '        End If
    '    End If


    'End Sub

    Private Sub cmdFindSuppliersOut_Click_1(sender As Object, e As EventArgs) Handles cmdFindSuppliersOut.Click
        Dim sfso As New StockFindSuppliers
        sfso.ShowDialog()
        If sfso.how2buy_id <> "" Then
            cbOutProduct.SelectedValue = sfso.how2buy_id
        End If
    End Sub

    Private Sub cmdOutSearch_Click_1(sender As Object, e As EventArgs) Handles cmdOutSearch.Click
        refreshOUTData()

    End Sub

    Private Sub cmdOutSave_Click_1(sender As Object, e As EventArgs) Handles cmdOutSave.Click

        If checkDataOUT() Then
            Dim stock_log As New Dictionary(Of String, String)
            stock_log.Add("how2buy_id", cbOutHow2Buy.SelectedValue)
            stock_log.Add("stock_type", "out")
            'stock_log.Add("jobs_id", cbOutJob.SelectedValue)
            'stock_log.Add("machines_id", cbOutMachine.SelectedValue)
            'stock_log.Add("jobs_op_tools_id", cbOutProcess.SelectedValue)
            'stock_log.Add("jobs_op_id", get_op(cbOutMachine.SelectedValue))
            stock_log.Add("stock_qty", tbOutQty.Text)
            stock_log.Add("event_date", dtpOutEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")))
            stock_log.Add("stock_remark", tbOutRemark.Text)
            stock_log.Add("updateby", txtEmployee.Text)

            Dim dt_how2buy As DataTable = config.GetDataTable("SELECT *  FROM tb_how2buy WHERE tb_how2buy.how2buy_id = '" & cbOutHow2Buy.SelectedValue.ToString & "' ")

            If dt_how2buy.Rows.Count > 0 Then
                stock_log.Add("stock_price", dt_how2buy.Rows(0).Item("products_cost"))
            Else
                stock_log.Add("stock_price", 0)
            End If

            If out_stock_log_id = "" Then
                    If config.Insert("tb_stock_log", stock_log) Then


                    If dt_how2buy.Rows.Count > 0 Then
                        Dim old_qty As Integer = Convert.ToInt16(dt_how2buy.Rows(0).Item("products_qty").ToString)
                        Dim add_qty As Double = Convert.ToInt16(tbOutQty.Text)

                        Dim new_qty As Integer = old_qty - add_qty

                        Dim how2buy As New Dictionary(Of String, String)
                        how2buy.Add("products_qty", new_qty)

                        config.Update("tb_how2buy", how2buy, "how2buy_id = '" & cbOutHow2Buy.SelectedValue.ToString & "'")
                    End If

                    log.add(dtpOutEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")),
                            "STOCK LIST",
                            "INSERT",
                            (
                            " Add 1 Issue by " & txtEmployee.Text & ". \n" &
                            " Product code : " & cbOutProduct.Text & " \n " &
                            " Issue Qty. : " & tbOutQty.Text & " \n " &
                            " Issued date : " & dtpOutEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")) & " \n " &
                            " Issued by : " & txtEmployee.Text & " \n "
                            ),
                            My.Settings.login_name
                     )
                    refreshOUTData()
                    'clearOUTData()
                End If
                Else
                    If config.Update("tb_stock_log", stock_log, "stock_log_id = '" & out_stock_log_id & "'") Then
                    log.add(dtpOutEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")),
                            "STOCK LIST",
                            "UPDATE",
                            (
                            " Update 1 Issue by " & txtEmployee.Text & ". \n" &
                            " Form data. \n" &
                            " Product code : " & edit_row.Item("products_code").ToString & " \n " &
                            " Issue Qty. : " & edit_row.Item("stock_qty").ToString & " \n " &
                            " Job : " & edit_row.Item("jobs_name").ToString & " \n " &
                            " Machine : " & edit_row.Item("machines_name").ToString & " \n " &
                            " Process : " & edit_row.Item("jobs_op_tools_name").ToString & " \n " &
                            " Issued date : " & edit_row.Item("event_date").ToString & " \n " &
                            " Issued by : " & edit_row.Item("updateby").ToString & " \n " &
                            " To data . \n" &
                            " Product code : " & cbOutProduct.Text & " \n " &
                            " Issue Qty. : " & tbOutQty.Text & " \n " &
                            " Issued date : " & dtpOutEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")) & " \n " &
                            " Issued by : " & txtEmployee.Text & " \n "
                            ),
                            My.Settings.login_name
                    )

                    refreshOUTData()
                    'clearOUTData()
                    out_stock_log_id = ""
                    End If
                End If
            End If
    End Sub

    Private Sub cmdOutCancel_Click_1(sender As Object, e As EventArgs) Handles cmdOutCancel.Click
        refreshOUTData()
        'clearOUTData()
    End Sub



    Private Sub dgvOut_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOut.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            'TODO - Button Clicked - Execute Code Here
            If dgvOut.Columns(e.ColumnIndex).Name = "colOutEdit" Then
                dgvOut.Rows(e.RowIndex).Selected = True
                'clearOUTData()
                edit_row = dt_out.Rows(e.RowIndex)
                tbOutQty.Text = dt_out.Rows(e.RowIndex).Item("stock_qty")
                tbOutRemark.Text = dt_out.Rows(e.RowIndex).Item("stock_remark")
                dtpOutEvent.Value = Convert.ToDateTime(dt_out.Rows(e.RowIndex).Item("event_date"))

                'refreshJobsData(dt_out.Rows(e.RowIndex).Item("jobs_id"), "")
                'refreshMachinesData(dt_out.Rows(e.RowIndex).Item("machines_id"), "")
                'refreshProcessData(dt_out.Rows(e.RowIndex).Item("jobs_op_tools_id"), dt_out.Rows(e.RowIndex).Item("machines_id"))

                cbOutProduct.SelectedValue = dt_out.Rows(e.RowIndex).Item("products_id")

                cbOutHow2Buy.SelectedValue = dt_out.Rows(e.RowIndex).Item("how2buy_id")

                out_stock_log_id = dt_out.Rows(e.RowIndex).Item("stock_log_id")

            ElseIf dgvOut.Columns(e.ColumnIndex).Name = "colOutDel" Then
                If MessageBox.Show("Do you want to Delete Product Data" & dt_out.Rows(e.RowIndex).Item("products_code") & "จำนวน " & dt_out.Rows(e.RowIndex).Item("stock_qty") & " ชิ้น หรือไม่", "ลบข้อมูลการรับสินค้าเข้า", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If config.ExecuteNonQuery("DELETE FROM tb_stock_log WHERE stock_log_id ='" & dt_out.Rows(e.RowIndex).Item("stock_log_id") & "'") Then

                        Dim dt_how2buy As DataTable = config.GetDataTable("SELECT *  FROM tb_how2buy WHERE tb_how2buy.how2buy_id = '" & dt_out.Rows(e.RowIndex).Item("how2buy_id").ToString & "' ")

                        If dt_how2buy.Rows.Count > 0 Then
                            Dim old_qty As Integer = Convert.ToInt16(dt_how2buy.Rows(0).Item("products_qty").ToString)
                            Dim old_cost As Double = Convert.ToDouble(dt_how2buy.Rows(0).Item("products_cost").ToString)
                            Dim delete_cost As Double = Convert.ToDouble(dt_out.Rows(e.RowIndex).Item("stock_price").ToString)
                            Dim delete_qty As Integer = Convert.ToInt16(dt_out.Rows(e.RowIndex).Item("stock_qty").ToString)

                            Dim new_qty As Integer = old_qty + delete_qty
                            Dim new_cost As Double = ((old_qty * old_cost) + (delete_qty * delete_cost)) / new_qty

                            Dim how2buy As New Dictionary(Of String, String)
                            how2buy.Add("products_qty", new_qty)
                            how2buy.Add("products_cost", new_cost)

                            config.Update("tb_how2buy", how2buy, "how2buy_id = '" & dt_out.Rows(e.RowIndex).Item("how2buy_id").ToString & "'")

                        End If

                        log.add(dtpOutEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")),
                            "STOCK LIST",
                            "DELETE",
                            (
                            " Remove 1 Issue by " & txtEmployee.Text & ".  \n" &
                            " Product code : " & dt_out.Rows(e.RowIndex).Item("products_code").ToString & " \n " &
                            " Issue Qty. : " & dt_out.Rows(e.RowIndex).Item("stock_qty").ToString & " \n " &
                            " Job : " & dt_out.Rows(e.RowIndex).Item("jobs_name").ToString & " \n " &
                            " Machine : " & dt_out.Rows(e.RowIndex).Item("machines_name").ToString & " \n " &
                            " Process : " & dt_out.Rows(e.RowIndex).Item("jobs_op_tools_name").ToString & " \n " &
                            " Issued date : " & dt_out.Rows(e.RowIndex).Item("event_date").ToString & " \n " &
                            " Issued by : " & dt_out.Rows(e.RowIndex).Item("updateby").ToString & " \n "
                            ),
                            My.Settings.login_name
                     )
                        'clearOUTData()
                        refreshOUTData()
                    End If
                End If
            End If
        End If
    End Sub




    Private Sub tbOutSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbOutSearch.KeyPress
        Try
            If Convert.ToByte(e.KeyChar) = Keys.Enter Then
                refreshOUTData()
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub

    Private Sub StockIssue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub

    Private Sub CmdFindProductOut_Click_1(sender As Object, e As EventArgs) Handles cmdFindProductOut.Click

    End Sub
End Class