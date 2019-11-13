Imports System.Globalization
Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Public Class Order
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Dim mail As New Email
    Public user_id As Int16 = 0



    Sub refreshALLData()
        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        Dim st As String = firstDay.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim en As String = firstDay.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))


        Dim str2 As String = " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & en & "') "


        Dim pro As String = "SELECT ifnull(SUM(ifnull(order_qty,0)),0) - ifnull(SUM(ifnull(order_recieve,0)),0)  FROM tb_order_list WHERE  products_id = t2.products_id "

        dt_main = config.GetDataTable("SELECT t2.products_id, products_order_quantity  as order_qty, products_consumption , products_code, " &
                                      "ifnull(products_max,0) as products_max, products_name1, products_name2 , ifnull((" & pro & "),0) as  order_qty_on, " &
                                      "SUM(products_qty) as order_qty_balance , " &
                                      "IFNULL( (SELECT group_concat(suppliers_name) FROM tb_how2buy LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as suppliers_name , " &
                                      "IFNULL( (SELECT group_concat(products_supplier_code) FROM tb_how2buy WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as products_supplier_code  " &
                                      "FROM tb_products as t2 " &
                                      "LEFT JOIN tb_how2buy ON tb_how2buy.products_id = t2.products_id " &
                                      "GROUP BY t2.products_id " &
                                      "HAVING products_reorder > ( SUM(products_qty) + ifnull((" & pro & "),0) ) AND products_reorder > 0  ORDER BY products_name1, products_code")

        dgvAll.DataSource = dt_main

    End Sub

    Private Sub Urgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAll.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvAll.EnableHeadersVisualStyles = False
        dgvAll.AutoGenerateColumns = False
        ColorTranslator.FromHtml(My.Settings.dgv_color)

        dtpEvent.CustomFormat = "yyyy-MMM-dd HH:mm"

        refreshALLData()
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
            xlWorkSheet.Cells(1, 7) = "Consumption"
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
                xlWorkSheet.Cells(i + 2, 7) = dgvAll.Rows(i).Cells("products_consumption").Value.ToString()
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
End Class