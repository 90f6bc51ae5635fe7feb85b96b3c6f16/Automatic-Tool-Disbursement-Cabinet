Imports System.Globalization
Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Public Class OrderAdd
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Dim mail As New Email
    Public user_id As Int16 = 0

    Sub getQty(ByVal id As String)
        Try
            Dim str As String = " WHERE ((t2.products_id = " & id & ")) "

            Dim pro As String = "SELECT  SUM(ifnull(order_qty,0)) -SUM( ifnull(order_recieve,0))  FROM tb_order_list WHERE  products_id = t2.products_id "


            Dim dt_qty = config.GetDataTable("SELECT products_min,  SUM(products_qty) as qty , ifnull((" & pro & "),0) as  order_qty " &
                                             "FROM tb_products as t2 " &
                                             "LEFT JOIN tb_how2buy ON tb_how2buy.products_id = t2.products_id " &
                                             "" & str & " ORDER BY products_name1, products_code")


            lblOrder.Text = dt_qty.Rows(0).Item("order_qty").ToString
            lblMin.Text = dt_qty.Rows(0).Item("products_min").ToString
            lblBalance.Text = dt_qty.Rows(0).Item("qty").ToString
        Catch
        End Try
    End Sub

    Sub refreshProductsData(ByVal index As String)

        Dim str As String = ""
        Dim dt_product = config.GetDataTable("SELECT * FROM tb_products " & str & " ORDER BY products_code")
        cbProduct.DataSource = dt_product
        cbProduct.DisplayMember = "products_code"
        cbProduct.ValueMember = "products_id"
        cbProduct.AutoCompleteSource = AutoCompleteSource.ListItems
        cbProduct.DropDownStyle = ComboBoxStyle.DropDown
        cbProduct.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" Then
            If cbProduct.Items.Count > 0 Then
                cbProduct.SelectedValue = index
            End If
        End If
    End Sub

    Sub add_list()
        If cbProduct.SelectedIndex > -1 Then
            Dim str As String = " WHERE ((t2.products_id = " & cbProduct.SelectedValue & ")) "

            Dim pro As String = "SELECT  SUM(ifnull(order_qty,0)) -SUM( ifnull(order_recieve,0))  FROM tb_order_list as tl WHERE  tl.products_id = t2.products_id "


            Dim dt_qty = config.GetDataTable("SELECT t2.products_id , products_code, products_name1, products_name2,  products_min,  SUM(products_qty) as order_qty_balance , ifnull((" & pro & "),0) as  order_qty_on, " &
                                             "IFNULL( (SELECT group_concat(suppliers_name) FROM tb_how2buy LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as suppliers_name , " &
                                             "IFNULL( (SELECT group_concat(products_supplier_code) FROM tb_how2buy WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as products_supplier_code  " &
                                             "FROM tb_products as t2 " &
                                             "LEFT JOIN tb_how2buy ON tb_how2buy.products_id = t2.products_id " &
                                             "" & str & " ORDER BY products_name1, products_code "
                                             )



            Try
                tbQty.Text = Convert.ToInt16(tbQty.Text)
                Dim products_id As String = dt_qty.Rows(0).Item("products_id").ToString

                Dim products_code As String = dt_qty.Rows(0).Item("products_code").ToString
                Dim products_name_1 As String = dt_qty.Rows(0).Item("products_name1").ToString
                Dim products_name_2 As String = dt_qty.Rows(0).Item("products_name2").ToString
                Dim suppliers_name As String = dt_qty.Rows(0).Item("suppliers_name").ToString
                Dim suppliers_code As String = dt_qty.Rows(0).Item("products_supplier_code").ToString

                Dim products_min As String = dt_qty.Rows(0).Item("products_min").ToString
                Dim order_qty_balance As String = dt_qty.Rows(0).Item("order_qty_balance").ToString
                Dim order_qty_on As String = dt_qty.Rows(0).Item("order_qty_on").ToString
                Dim order_qty As String = tbQty.Text

                dgvAll.Rows.Add(products_id, products_code, products_name_2, suppliers_name, suppliers_code, products_name_1, products_min, order_qty_balance, order_qty_on, order_qty)

                lblOrder.Text = "-"
                lblMin.Text = "-"
                lblBalance.Text = "-"
                cbProduct.SelectedIndex = 0
                tbQty.Text = "0"
            Catch ex As Exception
                tbQty.Text = "0"
                MsgBox("Please input order qty.")
            End Try
        End If
    End Sub


    Private Sub Urgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAll.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvAll.EnableHeadersVisualStyles = False
        dgvAll.AutoGenerateColumns = False
        ColorTranslator.FromHtml(My.Settings.dgv_color)
        refreshProductsData("")
        dtpEvent.CustomFormat = "yyyy-MMM-dd HH: mm"


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click

        Dim order As New Dictionary(Of String, String)
        order.Add("order_date", dtpEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")))
        order.Add("order_by", user_id)
        order.Add("order_send", "Save")
        order.Add("order_remark", tbRemark.Text)

        If config.Insert("tb_order", order) Then
            Dim dt_new As DataTable = config.GetDataTable("SELECT MAX(order_id) as last_id FROM tb_order ;")

            Dim order_id As Int16 = 0


            If dt_new.Rows.Count > 0 Then
                order_id = dt_new.Rows(0).Item("last_id")
            Else
                order_id = 0
            End If


            For i = 0 To dgvAll.Rows.Count - 1
                Dim qty As Int16 = 0

                Try
                    qty = dgvAll.Rows(i).Cells("order_qty").Value.ToString()
                Catch ex As Exception

                End Try
                If qty > 0 Then
                    Dim order_list As New Dictionary(Of String, String)
                    order_list.Add("order_id", order_id)
                    order_list.Add("products_id", dgvAll.Rows(i).Cells("products_id").Value.ToString())
                    order_list.Add("order_qty_balance", dgvAll.Rows(i).Cells("order_qty_balance").Value.ToString())
                    order_list.Add("order_qty_on", dgvAll.Rows(i).Cells("order_qty_on").Value.ToString())
                    order_list.Add("order_qty", dgvAll.Rows(i).Cells("order_qty").Value.ToString())
                    order_list.Add("order_recieve", "0")

                    If config.Insert("tb_order_list", order_list) Then

                    End If
                End If

            Next


        End If
        Me.Close()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
        Dim sv As New SaveFileDialog
        sv.Filter = "Excel |*.xlsx"

        If sv.ShowDialog() = DialogResult.OK Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Cells(1, 2) = "Product code"
            xlWorkSheet.Cells(1, 3) = "Process"
            xlWorkSheet.Cells(1, 4) = "Tool description"
            xlWorkSheet.Cells(1, 5) = "Supplier"
            xlWorkSheet.Cells(1, 6) = "Supplier code"
            xlWorkSheet.Cells(1, 7) = "Minimum"
            xlWorkSheet.Cells(1, 8) = "Qty"
            xlWorkSheet.Cells(1, 9) = "On order"
            xlWorkSheet.Cells(1, 10) = "Order"
            xlWorkSheet.Columns("B:D").ColumnWidth = 35
            xlWorkSheet.Columns("E:F").ColumnWidth = 15


            xlWorkSheet.Rows(1).RowHeight = 16
            For i = 0 To dgvAll.Rows.Count - 1
                xlWorkSheet.Rows(i + 2).RowHeight = 16
                xlWorkSheet.Cells(i + 2, 2) = dgvAll.Rows(i).Cells("products_code").Value.ToString()
                xlWorkSheet.Cells(i + 2, 3) = dgvAll.Rows(i).Cells("products_name1").Value.ToString()
                xlWorkSheet.Cells(i + 2, 4) = dgvAll.Rows(i).Cells("products_name2").Value.ToString()
                xlWorkSheet.Cells(i + 2, 5) = dgvAll.Rows(i).Cells("suppliers_name").Value.ToString()
                xlWorkSheet.Cells(i + 2, 6) = dgvAll.Rows(i).Cells("products_supplier_code").Value.ToString()
                xlWorkSheet.Cells(i + 2, 7) = dgvAll.Rows(i).Cells("products_min").Value.ToString()
                xlWorkSheet.Cells(i + 2, 8) = dgvAll.Rows(i).Cells("order_qty_balance").Value.ToString()
                xlWorkSheet.Cells(i + 2, 9) = dgvAll.Rows(i).Cells("order_qty_on").Value.ToString()
                xlWorkSheet.Cells(i + 2, 10) = dgvAll.Rows(i).Cells("order_qty").Value.ToString()
            Next

            xlWorkSheet.SaveAs(sv.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)




            Dim order As New Dictionary(Of String, String)
            order.Add("order_date", dtpEvent.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN")))
            order.Add("order_by", user_id)
            order.Add("order_send", "Save")
            order.Add("order_remark", tbRemark.Text)

            If config.Insert("tb_order", order) Then
                Dim dt_new As DataTable = config.GetDataTable("SELECT MAX(order_id) as last_id FROM tb_order ;")

                Dim order_id As Int16 = 0


                If dt_new.Rows.Count > 0 Then
                    order_id = dt_new.Rows(0).Item("last_id")
                Else
                    order_id = 0
                End If


                For i = 0 To dgvAll.Rows.Count - 1
                    Dim qty As Int16 = 0

                    Try
                        qty = dgvAll.Rows(i).Cells("order_qty").Value.ToString()
                    Catch ex As Exception

                    End Try
                    If qty > 0 Then
                        Dim order_list As New Dictionary(Of String, String)
                        order_list.Add("order_id", order_id)
                        order_list.Add("products_id", dgvAll.Rows(i).Cells("products_id").Value.ToString())
                        order_list.Add("order_qty_balance", dgvAll.Rows(i).Cells("order_qty_balance").Value.ToString())
                        order_list.Add("order_qty_on", dgvAll.Rows(i).Cells("order_qty_on").Value.ToString())
                        order_list.Add("order_qty", dgvAll.Rows(i).Cells("order_qty").Value.ToString())
                        order_list.Add("order_recieve", "0")


                        If config.Insert("tb_order_list", order_list) Then

                        End If
                    End If

                Next

                Try

                    Dim email_from As String = My.Settings.email_from
                    Dim email_to As String = My.Settings.email_to
                    Dim smtp As String = My.Settings.smtp
                    Dim port As String = My.Settings.port
                    Dim email_user As String = My.Settings.email_user
                    Dim email_pass As String = My.Settings.email_pass
                    Dim subject As String = My.Settings.subject
                    Dim body As String = My.Settings.body

                    'mail.send_email(email_from,
                    '       email_to,
                    '       smtp,
                    '       port,
                    '       email_user,
                    '       email_pass,
                    '       subject,
                    '       body,
                    '        sv.FileName)


                    order = New Dictionary(Of String, String)
                    order.Add("order_send", "Send")

                    If config.Update("tb_order", order, "order_id = '" & order_id & "'") Then
                        MsgBox("Sned email complete.")
                    End If

                    'send_email("mr.blue.hk@gmail.com",
                    '           "revelsoft@outlook.com",
                    '           "smtp.gmail.com",
                    '           465,
                    '           "mr.blue.hk@gmail.com",
                    '           "yo123546",
                    '           "New order form store.",
                    '           "You have new order from store. you can see order detail in attach file.",
                    '           sv.FileName)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            End If


            Me.Close()
        End If
    End Sub

    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduct.SelectedIndexChanged
        If cbProduct.SelectedIndex <> -1 Then
            getQty(cbProduct.SelectedValue.ToString())

        End If
    End Sub

    Private Sub cmdAddList_Click(sender As Object, e As EventArgs) Handles cmdAddList.Click
        add_list()

    End Sub

    Private Sub dgvAll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAll.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            'TODO - Button Clicked - Execute Code Here
            If dgvAll.Columns(e.ColumnIndex).Name = "coldel" Then
                If MessageBox.Show("Do you want to Delete Product Data" & dgvAll.Rows(e.RowIndex).Cells("products_code").Value & " ใช่หรือไม่", "ลบข้อมูลการรับสินค้าเข้า", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    dgvAll.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
        Try
            If Convert.ToByte(e.KeyChar) = Keys.Enter Then
                add_list()
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub
End Class