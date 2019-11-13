Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_analysis_job_cpp

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim cut_stock As Int16 = 15
    Dim dt_main, dt_sum As New DataTable

    Sub refreshGroupData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT products_group_id, products_group_name FROM tb_products_group  ORDER BY products_group_name")
        dt.Rows.Add(0, "ALL")

        Dim dt_view As DataView = dt.DefaultView
        dt_view.Sort = "products_group_id ASC"
        dt = dt_view.ToTable

        cbGroup.DataSource = dt
        cbGroup.DisplayMember = "products_group_name"
        cbGroup.ValueMember = "products_group_id"

        If index <> "" Then
            cbGroup.SelectedValue = index
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            cut_stock = Convert.ToInt16(My.Settings.cut_stock_day)
        Catch ex As Exception
            cut_stock = 15
        End Try


        Dim str As String = ""

        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "


        Dim str_group As String = ""

        If cbGroup.SelectedValue > 0 Then
            str_group = " AND tb_products.products_group_id = '" & cbGroup.SelectedValue & "' "
        End If


        dt_main = config.GetDataTable("SELECT 'stock-'| tb_jobs.jobs_id as stock_log_id,  strftime('%Y-%m' , event_date  , '-" & cut_stock.ToString & " days') as event_date , jobs_name , SUM( stock_qty * stock_price) as cost ,  " &
                                      " IFNULL((" &
                                      "SELECT productions_qty FROM tb_productions WHERE productions_jobs_id = tb1.jobs_id  " &
                                      "AND productions_month = CAST(strftime('%m' , tb1.event_date  , '-" & cut_stock.ToString & " days')  AS INTEGER)" &
                                       "AND productions_year = CAST(strftime('%Y' , tb1.event_date  , '-" & cut_stock.ToString & " days')  AS INTEGER)" &
                                      "),'1') as productions_qty ," &
                                      " (SUM( stock_qty * stock_price) / IFNULL((" &
                                      "SELECT productions_qty FROM tb_productions WHERE productions_jobs_id = tb1.jobs_id  " &
                                      "AND productions_month = CAST(strftime('%m' , tb1.event_date  , '-" & cut_stock.ToString & " days')  AS INTEGER) " &
                                       "AND productions_year = CAST(strftime('%Y' , tb1.event_date  , '-" & cut_stock.ToString & " days')  AS INTEGER) " &
                                      "),'1') )as cpp " &
                                      "FROM tb_stock_log as tb1 " &
                                      "LEFT JOIN tb_how2buy ON tb1.how2buy_id = tb_how2buy.how2buy_id " &
                                      "LEFT JOIN tb_products ON tb_how2buy.products_id = tb_products.products_id  " &
                                      "LEFT JOIN tb_jobs ON tb1.jobs_id = tb_jobs.jobs_id  " &
                                      "LEFT JOIN tb_machines ON tb1.machines_id = tb_machines.machines_id  " &
                                      "LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id  " &
                                      "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id  " &
                                      "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id  " &
                                      "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id  " &
                                      "LEFT JOIN tb_jobs_op_tools ON tb1.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id  " &
                                      "WHERE stock_type = 'out' " &
                                      str_group & str &
                                      "GROUP BY strftime('%Y-%m' , event_date  , '-" & cut_stock.ToString & " days'), jobs_name " &
                                      "ORDER BY cpp DESC LIMIT 0 , 10 ")


        Dim sum_max As Double = 0

        For i As Integer = 0 To dt_main.Rows.Count - 1
            dt_main.Rows(i).Item("stock_log_id") = i + 1
        Next


        Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_analysis_job_cpp.rdlc"

        Dim datasource As New ReportDataSource("dt_stock_out", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()

    End Sub


    Private Sub rp_stock_jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
        refreshGroupData("")
    End Sub

End Class