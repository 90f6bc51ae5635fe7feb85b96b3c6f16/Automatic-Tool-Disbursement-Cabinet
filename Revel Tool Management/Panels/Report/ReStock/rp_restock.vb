Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class rp_restock
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub rp_restock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""



        Dim st As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim en As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & st & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & en & "') "

        dt_main = config.GetDataTable("SELECT event_date,products_code,products_type_name,suppliers_name,prices,stock_qty,stock_price,tb_how2buy.products_supplier_code,updateby FROM tb_stock_log, tb_how2buy, tb_products, tb_suppliers , tb_products_type WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND tb_how2buy.products_id = tb_products.products_id AND tb_how2buy.suppliers_id = tb_suppliers.suppliers_id AND tb_products_type.products_type_id = tb_products.products_type_id AND stock_type = 'in' " & str & " ORDER BY tb_stock_log.event_date DESC")

        Dim datasource As New ReportDataSource("rp_re_stock", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()
    End Sub

End Class