Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_stock_in

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""

        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND event_date >= '" & dt & "' and event_date <= '" & dn & "'"

        Dim sj As String = "SELECT jobs_name FROM tb_jobs WHERE jobs_id = t2.jobs_id"
        Dim sm As String = "SELECT machines_name FROM tb_machines WHERE machines_id = t2.machines_id"

        Dim ss As String = "SELECT suppliers_name FROM tb_suppliers WHERE tb_suppliers.suppliers_id = t3.suppliers_id"
        Dim sp As String = "SELECT products_code FROM tb_products WHERE tb_products.products_id = t4.products_id"

        Dim spt As String = "SELECT products_group_name FROM tb_products_group WHERE  tb_products_group.products_group_id = t4.products_group_id"
        Dim spg As String = "SELECT products_type_name FROM tb_products_type WHERE tb_products_type.products_type_id = t4.products_type_id"
        Dim spb As String = "SELECT products_brand_name FROM tb_products_brand WHERE tb_products_brand.products_brand_id = t4.products_brand_id"

        Dim st As String = "SELECT jobs_op_tools_name FROM tb_jobs_op_tools WHERE jobs_op_tools_id = t2.jobs_op_tools_id"

        dt_main = config.GetDataTable("SELECT stock_log_id, event_date, ( " & sj & ") as jobs_name , ( " & sm & ") as machines_name , ( " & st & ") as jobs_op_tools_name , " &
                                      "( " & sp & ") as products_code, ( " & spt & ") as products_group_name, ( " & spg & ") as products_type_name, ( " & spb & ") as products_brand_name, " &
                                      "( " & ss & ") as suppliers_name, stock_qty, stock_qty as prices, ( stock_qty * stock_price) as cost " &
                                      "FROM tb_stock_log as t2, tb_how2buy as t3, tb_products as t4  " &
                                      "WHERE t2.how2buy_id = t3.how2buy_id " &
                                      "AND t3.products_id = t4.products_id " &
                                      "AND stock_type = 'out' " & str & " ORDER BY t2.stock_log_id DESC")


        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_Line.rdlc"
        End If


        Dim datasource As New ReportDataSource("dt_stock_out", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()

    End Sub


    Private Sub rp_stock_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
    End Sub
End Class