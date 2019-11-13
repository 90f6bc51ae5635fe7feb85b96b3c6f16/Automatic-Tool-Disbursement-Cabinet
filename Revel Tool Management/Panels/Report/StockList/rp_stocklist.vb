Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class rp_stocklist
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""


        Dim st As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim en As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        Dim str2 As String = " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & en & "') "

        Dim si As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in' " & str2
        Dim so As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out' " & str2
        Dim sr As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'return' " & str2


        Dim sai As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in' and strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "')"
        Dim sao As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out' and strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "')"
        Dim sar As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'return' and strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "')"


        Dim si_qty As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in'"
        Dim so_qty As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out'"
        Dim sr_qty As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'return'"

        dt_main = config.GetDataTable("SELECT products_code, " &
                                      "IFNULL( (SELECT prices FROM tb_how2buy WHERE products_id = t2.products_id AND how2buy_inactive = 'Active' LIMIT 0,1), '0') as price , " &
                                      "0 as total , " &
                                      "IFNULL( (SELECT group_concat(products_supplier_code) FROM tb_how2buy WHERE products_id = t2.products_id AND how2buy_inactive = 'Active'), '-') as products_name1 , " &
                                      "IFNULL( (SELECT group_concat(char(64 + stock_layouts_x) || stock_layouts_y ) FROM tb_stock_layouts , tb_how2buy WHERE  stock_layouts_id = tb_how2buy.slot AND products_id = t2.products_id), '-') as stock_layout , " &
                                      "ifnull((" & si & "),0) - ifnull((" & sr & "),0) as qty_in , ifnull((" & so & "),0) as qty_out , ((ifnull((" & si_qty & "),0) - ifnull((" & sr_qty & "),0) - ifnull((" & so_qty & "),0))) as qty , (ifnull((" & sai & "),0) - ifnull((" & sar & "),0) - ifnull((" & sao & "),0)) as amount  FROM tb_products as t2 " & str & " ORDER BY products_name1, products_code")

        For i As Integer = 0 To dt_main.Rows.Count - 1
            dt_main.Rows(i).Item("total") = Convert.ToInt32(dt_main.Rows(i).Item("qty").ToString) * Convert.ToDouble(dt_main.Rows(i).Item("price").ToString)
        Next

        Dim datasource As New ReportDataSource("rp_stock_list", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()
    End Sub

    Private Sub rp_stocklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
    End Sub
End Class