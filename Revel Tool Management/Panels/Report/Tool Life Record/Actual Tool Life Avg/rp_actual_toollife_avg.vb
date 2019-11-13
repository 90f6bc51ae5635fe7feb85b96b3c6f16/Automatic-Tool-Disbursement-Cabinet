Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_actual_toollife_avg

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""


        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "



        Dim str_jobs As String = ""

        For Each Item In lbJobs.SelectedItems
            str_jobs &= "'" & Item(0).ToString() & "'"
            str_jobs &= ","
        Next

        If str_jobs = "" Then
            str_jobs = "'0'"
        Else
            str_jobs = str_jobs.Substring(0, str_jobs.Length - 1)
        End If


        dt_main = config.GetDataTable("SELECT jobs_name, jobs_op_name , jobs_op_tools_name , " &
                                      "machines_name, " &
                                      "products_code, " &
                                      "products_conner, " &
                                      "ifnull(AVG( records_toollife ),0) as tl_insert, " &
                                      "ifnull(AVG( toollife ),0) as target_tl_conner, " &
                                      "suppliers_name, " &
                                      "SUM(stock_qty) as stock_qty, " &
                                      "stock_price as prices, SUM( stock_qty * stock_price) as cost " &
                                      "FROM tb_stock_log  " &
                                      "LEFT JOIN tb_how2buy ON  tb_stock_log.how2buy_id = tb_how2buy.how2buy_id " &
                                      "LEFT JOIN tb_suppliers ON  tb_how2buy.suppliers_id = tb_suppliers.suppliers_id " &
                                      "LEFT JOIN tb_records ON  tb_stock_log.stock_log_id = tb_records.stock_log_id " &
                                      "LEFT JOIN tb_products ON  tb_how2buy.products_id = tb_products.products_id " &
                                      "LEFT JOIN tb_jobs ON  tb_stock_log.jobs_id = tb_jobs.jobs_id " &
                                      "LEFT JOIN tb_jobs_op ON  tb_stock_log.jobs_op_id = tb_jobs_op.jobs_op_id " &
                                      "LEFT JOIN tb_jobs_op_tools ON  tb_stock_log.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id " &
                                      "LEFT JOIN tb_jobs_op_tools_use ON  tb_jobs_op_tools.jobs_op_tools_id = tb_jobs_op_tools_use.jobs_op_tools_id " &
                                      "LEFT JOIN tb_machines ON  tb_stock_log.machines_id = tb_machines.machines_id " &
                                      "WHERE stock_type = 'out' " &
                                      "AND tb_jobs_op_tools_use.products_id =  tb_products.products_id " &
                                      "AND tb_products.products_group_id = '3' " &
                                      "AND tb_stock_log.jobs_id IN (" & str_jobs & ") " & str &
                                      " GROUP BY tb_jobs.jobs_id , tb_jobs_op.jobs_op_id, tb_machines.machines_id, tb_jobs_op_tools.jobs_op_tools_id, jobs_op_tools_use_id , tb_products.products_id " &
                                      " ORDER BY tb_jobs.jobs_id , tb_jobs_op.jobs_op_id, tb_machines.machines_id, tb_jobs_op_tools.jobs_op_tools_id, jobs_op_tools_use_id , tb_products.products_id DESC")


        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_actual_toollife_avg.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_actual_toollife_avg_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_actual_toollife_avg_Line.rdlc"
        End If

        Dim datasource As New ReportDataSource("tb_toollife_record", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()

        Dim date_start As New ReportParameter("date_start", dt)
        Dim date_end As New ReportParameter("date_end", dn)
        'Me.rvView.LocalReport.ReportEmbeddedResource = "rp_actual_toollife.rdlc"
        Me.rvView.LocalReport.SetParameters(New ReportParameter() {date_start, date_end})

        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()

    End Sub


    Private Sub rp_stock_process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)

        getJobs()

        cbChartType.SelectedIndex = 0

    End Sub

    Sub getJobs()

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs ")


        lbJobs.DataSource = dt
        lbJobs.DisplayMember = "jobs_name"
        lbJobs.ValueMember = "jobs_id"


    End Sub

    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click
        For i As Int32 = 0 To lbJobs.Items.Count - 1
            lbJobs.SetSelected(i, True)
        Next
    End Sub

    Private Sub cmdUnselect_Click(sender As Object, e As EventArgs) Handles cmdUnselect.Click
        For i As Int32 = 0 To lbJobs.Items.Count - 1
            lbJobs.SetSelected(i, False)
        Next
    End Sub
End Class