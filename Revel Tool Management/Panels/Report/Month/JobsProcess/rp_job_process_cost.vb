﻿Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_job_process_cost

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim cut_stock_day As Int16 = 14
    Dim cut_stock_hour As Int16 = 0
    Dim cut_stock_min As Int16 = 0

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
            cut_stock_day = Convert.ToInt16(My.Settings.cut_stock_day) - 1
        Catch ex As Exception
            cut_stock_day = 14
        End Try

        Try
            cut_stock_hour = Convert.ToInt16(My.Settings.cut_stock_hour)
        Catch ex As Exception
            cut_stock_hour = 0
        End Try

        Try
            cut_stock_min = Convert.ToInt16(My.Settings.cut_stock_min)
        Catch ex As Exception
            cut_stock_min = 0
        End Try


        Dim str As String = ""

        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "

        Dim str_op As String = ""

        For Each Item In lbProcess.SelectedItems
            str_op &= "'" & Item(0).ToString() & "'"
            str_op &= ","
        Next

        If str_op = "" Then
            str_op = "'0'"
        Else
            str_op = str_op.Substring(0, str_op.Length - 1)
        End If

        Dim str_group As String = ""

        If cbGroup.SelectedValue > 0 Then
            str_group = " AND tb_products.products_group_id = '" & cbGroup.SelectedValue & "' "
        End If

        dt_main = config.GetDataTable("SELECT  strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes') as event_date , jobs_name , jobs_op_name, jobs_op_tools_name , SUM( stock_qty * stock_price) as cost " &
                                      "FROM tb_stock_log " &
                                      "LEFT JOIN tb_how2buy ON tb_stock_log.how2buy_id = tb_how2buy.how2buy_id " &
                                      "LEFT JOIN tb_products ON tb_how2buy.products_id = tb_products.products_id  " &
                                      "LEFT JOIN tb_jobs ON tb_stock_log.jobs_id = tb_jobs.jobs_id  " &
                                      "LEFT JOIN tb_jobs_op ON tb_stock_log.jobs_op_id = tb_jobs_op.jobs_op_id  " &
                                      "LEFT JOIN tb_jobs_op_tools ON tb_stock_log.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id  " &
                                      "LEFT JOIN tb_machines ON tb_stock_log.machines_id = tb_machines.machines_id  " &
                                      "LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id  " &
                                      "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id  " &
                                      "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id  " &
                                      "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id  " &
                                      "WHERE stock_type = 'out' " &
                                      "AND tb_stock_log.jobs_op_tools_id IN (" & str_op & ") " &
                                      str_group & str &
                                      "GROUP BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes'), jobs_name, jobs_op_name, jobs_op_tools_name " &
                                      "ORDER BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes'), jobs_name, jobs_op_name, jobs_op_tools_name DESC ")


        Dim sum_max As Double = 0

        For i As Int16 = 0 To dt_main.Rows.Count - 1
            sum_max += Convert.ToDouble(dt_main.Rows(i).Item(4).ToString())
        Next

        Dim cost_max As New ReportParameter("cost_max", sum_max)

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_job_process_cost.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_job_process_cost_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_job_process_cost_Line.rdlc"
        End If

        Dim datasource As New ReportDataSource("dt_stock_out", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        If cbChartType.SelectedItem = "Pie" Then
            dt_sum = config.GetDataTable("SELECT  strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes') as event_date , jobs_name , SUM( stock_qty * stock_price) as cost " &
                                      "FROM tb_stock_log " &
                                      "LEFT JOIN tb_how2buy ON tb_stock_log.how2buy_id = tb_how2buy.how2buy_id " &
                                      "LEFT JOIN tb_products ON tb_how2buy.products_id = tb_products.products_id  " &
                                      "LEFT JOIN tb_jobs ON tb_stock_log.jobs_id = tb_jobs.jobs_id  " &
                                      "LEFT JOIN tb_machines ON tb_stock_log.machines_id = tb_machines.machines_id  " &
                                      "LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id  " &
                                      "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id  " &
                                      "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id  " &
                                      "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id  " &
                                      "LEFT JOIN tb_jobs_op_tools ON tb_stock_log.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id  " &
                                      "WHERE stock_type = 'out' " &
                                      "AND tb_jobs.jobs_id = '" & cbJobs.SelectedValue.ToString & "' " &
                                      str_group & str &
                                      "GROUP BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes')  " &
                                      "ORDER BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes')  DESC ")

            If dt_sum.Rows.Count > 0 Then
                Dim all_max As New ReportParameter("all_max", Convert.ToDouble(dt_sum.Rows(0).Item(2).ToString))
                Me.rvView.LocalReport.SetParameters(New ReportParameter() {cost_max, all_max})
            Else
                Dim all_max As New ReportParameter("all_max", 1.0)
                Me.rvView.LocalReport.SetParameters(New ReportParameter() {cost_max, all_max})
            End If


        Else
            Me.rvView.LocalReport.SetParameters(New ReportParameter() {cost_max})
        End If
        Me.rvView.RefreshReport()

    End Sub


    Private Sub rp_stock_jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getJobs()
        refreshGroupData("")
        cbChartType.SelectedIndex = 0

        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
    End Sub


    Sub getJobs()

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs ")


        cbJobs.DataSource = dt
        cbJobs.DisplayMember = "jobs_name"
        cbJobs.ValueMember = "jobs_id"


        cbJobs.SelectedIndex = 0


        Dim dt_op As DataTable = config.GetDataTable("SELECT jobs_op_tools_id , jobs_op_name|| ' - '||jobs_op_tools_name as jobs_op_tools_name   FROM tb_jobs_op LEFT JOIN tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id  WHERE jobs_id = '" & cbJobs.SelectedValue.ToString & "'")


        lbProcess.DataSource = dt_op
        lbProcess.DisplayMember = "jobs_op_tools_name"
        lbProcess.ValueMember = "jobs_op_tools_id"

    End Sub

    Private Sub cbJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJobs.SelectedIndexChanged

        If cbJobs.SelectedIndex > -1 Then
            Dim dt As DataTable = config.GetDataTable("SELECT jobs_op_tools_id , jobs_op_name|| ' - '||jobs_op_tools_name as jobs_op_tools_name  FROM tb_jobs_op LEFT JOIN tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id WHERE jobs_id = '" & cbJobs.SelectedValue.ToString & "'")


            lbProcess.DataSource = dt
            lbProcess.DisplayMember = "jobs_op_tools_name"
            lbProcess.ValueMember = "jobs_op_tools_id"
        End If


    End Sub

    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click
        For i As Int32 = 0 To lbProcess.Items.Count - 1
            lbProcess.SetSelected(i, True)
        Next
    End Sub

    Private Sub cmdUnselect_Click(sender As Object, e As EventArgs) Handles cmdUnselect.Click
        For i As Int32 = 0 To lbProcess.Items.Count - 1
            lbProcess.SetSelected(i, False)
        Next
    End Sub

End Class