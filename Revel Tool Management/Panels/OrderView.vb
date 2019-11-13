Imports System.Globalization
Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Public Class OrderView
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main, dt_list As New DataTable
    Dim mail As New Email
    Public user_id As Int16 = 0
    Public order_id As Int16 = 0


    Sub refreshALLData()
        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dt_main = config.GetDataTable("SELECT * FROM tb_order WHERE order_id = '" & order_id & "'")
        If dt_main.Rows.Count > 0 Then

            tbDate.Text = dt_main.Rows(0).Item("order_date").ToString
            tbRemark.Text = dt_main.Rows(0).Item("order_remark").ToString

            If dt_main.Rows(0).Item("order_send").ToString = "0" Then
                cmdSend.Enabled = False
            Else
                cmdSend.Enabled = True
            End If

            dt_list = config.GetDataTable("SELECT * , " &
                                            "IFNULL( (SELECT group_concat(suppliers_name) FROM tb_how2buy LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id WHERE products_id = tb1.products_id AND how2buy_inactive = 'Active'), '-') as suppliers_name, " &
                                            "IFNULL( (SELECT group_concat(products_supplier_code) FROM tb_how2buy WHERE products_id = tb1.products_id AND how2buy_inactive = 'Active'), '-') as products_supplier_code  " &
                                            " FROM tb_order_list LEFT JOIN tb_products as tb1 ON tb_order_list.products_id = tb1.products_id WHERE order_id = '" & order_id & "'")
            dgvAll.DataSource = dt_list
        End If



    End Sub

    Private Sub Urgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAll.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvAll.EnableHeadersVisualStyles = False
        dgvAll.AutoGenerateColumns = False
        ColorTranslator.FromHtml(My.Settings.dgv_color)

        refreshALLData()
    End Sub


    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim order As New Dictionary(Of String, String)
        order.Add("order_remark", tbRemark.Text)

        If config.Update("tb_order", order, "order_id = '" & order_id & "'") Then
            MsgBox("Update complete.")
        End If


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
            order.Add("order_send", "Send")

            If config.Update("tb_order", order, "order_id = '" & order_id & "'") Then
                MsgBox("Sned email complete.")
            End If

            MsgBox("Export complete.")
        End If


    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("คุณต้องการลบข้อมูล ใช้หรือไม่", "ลบข้อมูลการสั่งสินค้า", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            config.ExecuteNonQuery("DELETE FROM tb_order_list WHERE order_id = '" & order_id & "'")
            config.ExecuteNonQuery("DELETE FROM tb_order WHERE order_id = '" & order_id & "'")
            Me.Close()
        End If
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

                Dim order As New Dictionary(Of String, String)
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
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class