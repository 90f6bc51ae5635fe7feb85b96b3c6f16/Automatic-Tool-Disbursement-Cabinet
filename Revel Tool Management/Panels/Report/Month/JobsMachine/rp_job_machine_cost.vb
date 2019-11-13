Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_job_machine_cost

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

        Dim str_machine As String = ""

        For Each Item In lbMachine.SelectedItems
            str_machine &= "'" & Item(0).ToString() & "'"
            str_machine &= ","
        Next

        If str_machine = "" Then
            str_machine = "'0'"
        Else
            str_machine = str_machine.Substring(0, str_machine.Length - 1)
        End If

        Dim str_group As String = ""

        If cbGroup.SelectedValue > 0 Then
            str_group = " AND tb_products.products_group_id = '" & cbGroup.SelectedValue & "' "
        End If


        dt_main = config.GetDataTable("SELECT  strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes') as event_date , jobs_name , jobs_op_name, machines_name , SUM( stock_qty * stock_price) as cost " &
                                      "FROM tb_stock_log " &
                                      "LEFT JOIN tb_how2buy ON tb_stock_log.how2buy_id = tb_how2buy.how2buy_id " &
                                      "LEFT JOIN tb_products ON tb_how2buy.products_id = tb_products.products_id  " &
                                      "LEFT JOIN tb_jobs ON tb_stock_log.jobs_id = tb_jobs.jobs_id  " &
                                      "LEFT JOIN tb_jobs_op ON tb_stock_log.jobs_op_id = tb_jobs_op.jobs_op_id  " &
                                      "LEFT JOIN tb_machines ON tb_stock_log.machines_id = tb_machines.machines_id  " &
                                      "LEFT JOIN tb_suppliers ON tb_how2buy.suppliers_id = tb_suppliers.suppliers_id  " &
                                      "LEFT JOIN tb_products_group ON tb_products.products_group_id = tb_products_group.products_group_id  " &
                                      "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id  " &
                                      "LEFT JOIN tb_products_brand ON tb_products.products_brand_id = tb_products_brand.products_brand_id  " &
                                      "LEFT JOIN tb_jobs_op_tools ON tb_stock_log.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id  " &
                                      "WHERE stock_type = 'out' " &
                                      "AND tb_stock_log.machines_id IN (" & str_machine & ") " &
                                      str_group & str &
                                      "GROUP BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes'), jobs_name, jobs_op_name, machines_name " &
                                      "ORDER BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes'), jobs_name, jobs_op_name, machines_name ASC ")


        Dim sum_max As Double = 0

        For i As Int16 = 0 To dt_main.Rows.Count - 1
            sum_max += Convert.ToDouble(dt_main.Rows(i).Item(4).ToString())
        Next

        Dim cost_max As New ReportParameter("cost_max", sum_max)

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_job_machine_cost.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_job_machine_cost_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_job_machine_cost_Line.rdlc"
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
                                      str_group & str &
                                      "GROUP BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes')  " &
                                      "ORDER BY strftime('%Y-%m' , event_date  , '-" & cut_stock_day.ToString & " days' , '-" & cut_stock_hour.ToString & " hours','-" & cut_stock_min.ToString & " minutes')  DESC ")

            If dt_sum.Rows.Count > 0 Then
                Dim all_max As New ReportParameter("all_max", Convert.ToDouble(dt_sum.Rows(0).Item(2).ToString))
                Me.rvView.LocalReport.SetParameters(New ReportParameter() {cost_max, all_max})
            Else
                Me.rvView.LocalReport.SetParameters(New ReportParameter() {cost_max})
            End If


        Else
            Me.rvView.LocalReport.SetParameters(New ReportParameter() {cost_max})
        End If
        Me.rvView.RefreshReport()

    End Sub


    Private Sub rp_stock_jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMachines()
        refreshGroupData("")
        cbChartType.SelectedIndex = 0

        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click
        For i As Int32 = 0 To lbMachine.Items.Count - 1
            lbMachine.SetSelected(i, True)
        Next
    End Sub

    Private Sub cmdUnselect_Click(sender As Object, e As EventArgs) Handles cmdUnselect.Click
        For i As Int32 = 0 To lbMachine.Items.Count - 1
            lbMachine.SetSelected(i, False)
        Next
    End Sub

    Sub getMachines()

        Dim dt As DataTable = config.GetDataTable(
            "SELECT machines_id, machines_name FROM tb_machines "
        )

        '"LEFT JOIN tb_jobs_op_machines ON tb_machines.machines_id = tb_jobs_op_machines.machines_id " &
        '"LEFT JOIN tb_jobs_op ON tb_jobs_op_machines.jobs_op_id = tb_jobs_op.jobs_op_id" &
        '"LEFT JOIN tb_jobs ON tb_jobs_op.jobs_id = tb_jobs.jobs_id"

        lbMachine.DataSource = dt
        lbMachine.DisplayMember = "machines_name"
        lbMachine.ValueMember = "machines_id"


    End Sub

End Class