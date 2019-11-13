Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_actual_toollife

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""


        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "



        dt_main = config.GetDataTable("SELECT tb_stock_log.stock_log_id, jobs_name, jobs_op_tools_name , event_date, " &
                                      "jobs_op_name, " &
                                      "jobs_op_tools_name, " &
                                      "machines_name, " &
                                      "products_code, " &
                                      "IFNULL(products_conner,'1') as products_conner, " &
                                      "ifnull(AVG( ifnull(records_toollife,0) ),0) as tl_insert, " &
                                      "ifnull(AVG( ifnull(toollife,0) ),0) as target_tl_conner, " &
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
                                      "AND tb_jobs_op_tools_use.jobs_op_tools_id =  '" & cbProcess.SelectedValue.ToString & "' " &
                                      "AND tb_jobs_op_tools_use.products_id ='" & lbToolUse.SelectedValue.ToString & "' " & str &
                                      " GROUP BY tb_stock_log.stock_log_id, tb_jobs.jobs_id , tb_jobs_op.jobs_op_id, tb_machines.machines_id, tb_jobs_op_tools.jobs_op_tools_id, jobs_op_tools_use_id , tb_products.products_id " &
                                      " ORDER BY tb_stock_log.stock_log_id, tb_jobs.jobs_id , tb_jobs_op.jobs_op_id, tb_machines.machines_id, tb_jobs_op_tools.jobs_op_tools_id, jobs_op_tools_use_id , tb_products.products_id DESC")



        For i As Int32 = 0 To dt_main.Rows.Count - 1
            dt_main.Rows(i).Item("stock_log_id") = (i + 1).ToString
        Next

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_actual_toollife.rdlc"
            'ElseIf cbChartType.SelectedItem = "Pie" Then

            '    Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_actual_toollife_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_actual_toollife_Line.rdlc"
        End If

        Dim datasource As New ReportDataSource("tb_toollife_record", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()

        Dim tg As Integer = 30
        Dim date_start As New ReportParameter("date_start", dt)
        Dim date_end As New ReportParameter("date_end", dn)
        Dim target As New ReportParameter("target", tg)
        'Me.rvView.LocalReport.ReportEmbeddedResource = "rp_actual_toollife.rdlc"
        Me.rvView.LocalReport.SetParameters(New ReportParameter() {date_start, date_end, target})

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

        If cbJobs.Items.Count > 0 Then

            cbJobs.SelectedIndex = 0

            Dim dt As DataTable = config.GetDataTable("SELECT jobs_op_tools_id , jobs_op_name|| ' - '||jobs_op_tools_name as jobs_op_tools_name  FROM tb_jobs_op LEFT JOIN tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id WHERE jobs_id = '" & cbJobs.SelectedValue.ToString & "'")

            cbProcess.DataSource = dt
            cbProcess.DisplayMember = "jobs_op_tools_name"
            cbProcess.ValueMember = "jobs_op_tools_id"
            If cbProcess.Items.Count > 0 Then
                cbProcess.SelectedIndex = 0
                Dim dt_tool As DataTable = config.GetDataTable("SELECT tb_products.products_id as products_id , products_code  FROM tb_jobs_op_tools_use LEFT JOIN tb_products ON tb_jobs_op_tools_use.products_id = tb_products.products_id WHERE jobs_op_tools_id = '" & cbProcess.SelectedValue.ToString & "'  AND products_code not null AND products_group_id = '3'")

                lbToolUse.DataSource = dt_tool
                lbToolUse.DisplayMember = "products_code"
                lbToolUse.ValueMember = "products_id"
            End If

        End If

        cbChartType.SelectedIndex = 0

    End Sub

    Sub getJobs()

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs ")


        cbJobs.DataSource = dt
        cbJobs.DisplayMember = "jobs_name"
        cbJobs.ValueMember = "jobs_id"


    End Sub

    Private Sub cbJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJobs.SelectedIndexChanged
        If cbJobs.SelectedIndex > -1 Then
            Dim dt As DataTable = config.GetDataTable("SELECT jobs_op_tools_id , jobs_op_name|| ' - '||jobs_op_tools_name as jobs_op_tools_name  FROM tb_jobs_op LEFT JOIN tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id WHERE jobs_id = '" & cbJobs.SelectedValue.ToString & "'")

            cbProcess.DataSource = dt
            cbProcess.DisplayMember = "jobs_op_tools_name"
            cbProcess.ValueMember = "jobs_op_tools_id"
        End If
    End Sub

    Private Sub cbProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProcess.SelectedIndexChanged
        If cbProcess.SelectedIndex > -1 Then
            Dim dt As DataTable = config.GetDataTable("SELECT tb_products.products_id as products_id , products_code  FROM tb_jobs_op_tools_use LEFT JOIN tb_products ON tb_jobs_op_tools_use.products_id = tb_products.products_id WHERE jobs_op_tools_id = '" & cbProcess.SelectedValue.ToString & "'  AND products_code not null AND products_group_id = '3'")

            lbToolUse.DataSource = dt
            lbToolUse.DisplayMember = "products_code"
            lbToolUse.ValueMember = "products_id"
        End If
    End Sub
End Class