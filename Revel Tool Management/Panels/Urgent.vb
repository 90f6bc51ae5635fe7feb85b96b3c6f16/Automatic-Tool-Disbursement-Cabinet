Imports System.Globalization
Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Urgent
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Public user_id As Int16 = 0

    Sub refreshALLData()
        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        Dim st As String = firstDay.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH"))
        Dim en As String = firstDay.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH"))


        Dim pro As String = "SELECT SUM(order_qty) - SUM(order_recieve)  FROM tb_order_list WHERE  products_id = t2.products_id "

        dt_main = config.GetDataTable("SELECT t2.products_id, '0' as order_qty, products_consumption , products_reorder , products_code, products_name1, products_name2 ," &
                                      "IFNULL( (SELECT group_concat(suppliers_name) FROM tb_how2buy LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as suppliers_name , " &
                                      "IFNULL( (SELECT group_concat(products_supplier_code) FROM tb_how2buy WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as products_supplier_code,  " &
                                      "IFNULL((" & pro & "),0) as  products_order, SUM(products_qty) as qty , products_order_quantity  " &
                                      "FROM tb_products as t2 " &
                                      "LEFT JOIN tb_how2buy ON tb_how2buy.products_id = t2.products_id " &
                                      "WHERE t2.products_id IN ( " &
                                        " SELECT distinct products_id FROM tb_jobs_op_tools_use WHERE jobs_op_tools_use_inactive = 'Active'  " &
                                        ") " &
                                      "GROUP BY t2.products_id HAVING products_reorder > SUM(products_qty)  AND products_consumption > 0 " &
                                      "ORDER BY products_name1, products_code")
        dgvAll.DataSource = dt_main

    End Sub

    Private Sub Urgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAll.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvAll.EnableHeadersVisualStyles = False
        dgvAll.AutoGenerateColumns = False
        ColorTranslator.FromHtml(My.Settings.dgv_color)
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

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click

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
            xlWorkSheet.Cells(1, 3) = "Tool description"
            xlWorkSheet.Cells(1, 4) = "Supplier"
            xlWorkSheet.Cells(1, 5) = "Supplier code"
            xlWorkSheet.Cells(1, 6) = "Remark"
            xlWorkSheet.Cells(1, 7) = "Consumption"
            xlWorkSheet.Cells(1, 8) = "Reorder point"
            xlWorkSheet.Cells(1, 9) = "On hand Qty."
            xlWorkSheet.Cells(1, 10) = "On order Qty"
            xlWorkSheet.Cells(1, 11) = "New Order"
            xlWorkSheet.Columns("B:F").ColumnWidth = 35
            xlWorkSheet.Columns("G:K").ColumnWidth = 15


            xlWorkSheet.Rows(1).RowHeight = 16
            For i = 0 To dt_main.Rows.Count - 1
                xlWorkSheet.Rows(i + 2).RowHeight = 16
                xlWorkSheet.Cells(i + 2, 2) = dt_main.Rows(i).Item("products_code").ToString()
                xlWorkSheet.Cells(i + 2, 3) = dt_main.Rows(i).Item("products_name1").ToString()
                xlWorkSheet.Cells(i + 2, 4) = dt_main.Rows(i).Item("suppliers_name").ToString()
                xlWorkSheet.Cells(i + 2, 5) = dt_main.Rows(i).Item("products_supplier_code").ToString()
                xlWorkSheet.Cells(i + 2, 6) = dt_main.Rows(i).Item("products_name2").ToString()
                xlWorkSheet.Cells(i + 2, 7) = dt_main.Rows(i).Item("products_consumption").ToString()
                xlWorkSheet.Cells(i + 2, 8) = dt_main.Rows(i).Item("products_reorder").ToString()
                xlWorkSheet.Cells(i + 2, 9) = dt_main.Rows(i).Item("qty").ToString()
                xlWorkSheet.Cells(i + 2, 10) = dt_main.Rows(i).Item("products_order").ToString()
                xlWorkSheet.Cells(i + 2, 11) = dt_main.Rows(i).Item("products_order_quantity").ToString()
            Next

            xlWorkSheet.SaveAs(sv.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            Me.Close()
            'MsgBox("You can find the file " & sv.FileName)
        End If

    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim fm_order As New Order
        fm_order.user_id = user_id
        fm_order.ShowDialog()
        refreshALLData()
    End Sub


    Private Sub cmdOrderView_Click(sender As Object, e As EventArgs) Handles cmdOrderView.Click
        Dim fm_order_manage As New OrderManage
        fm_order_manage.user_id = user_id
        fm_order_manage.ShowDialog()
        refreshALLData()
    End Sub

    Private Sub Urgent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.first_login Then
            My.Settings.first_login = False
            My.Settings.Save()
        Else
            Dim fm As New Main
            fm.Show()
        End If
    End Sub

End Class