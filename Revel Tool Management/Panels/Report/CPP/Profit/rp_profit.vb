Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_profit

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""

        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND event_date >= '" & dt & "' and event_date <= '" & dn & "'"

        Dim sj As String = "SELECT jobs_name FROM tb_jobs WHERE jobs_id = t2.jobs_id"


        Dim ss As String = "SELECT suppliers_name FROM tb_suppliers WHERE tb_suppliers.suppliers_id = t3.suppliers_id"
        Dim sp As String = "SELECT products_code FROM tb_products WHERE tb_products.products_id = t4.products_id"


        Dim st As String = "SELECT jobs_op_tools_name FROM tb_jobs_op_tools WHERE jobs_op_tools_id = t2.jobs_op_tools_id"

        dt_main = config.GetDataTable("SELECT  ( " & sj & ") as jobs_name , ( " & st & ") as jobs_op_tools_name , " &
                                      "( " & sp & ") as products_code, " &
                                      "( " & ss & ") as suppliers_name, SUM(stock_qty) as stock_qty, stock_price as prices, SUM( stock_qty * stock_price) as cost " &
                                      "FROM tb_stock_log as t2, tb_how2buy as t3, tb_products as t4  " &
                                      "WHERE t2.how2buy_id = t3.how2buy_id " &
                                      "AND t3.products_id = t4.products_id " &
                                      "AND t2.jobs_id = '" & cbJobs.SelectedValue.ToString & "'" &
                                      "AND stock_type = 'out' " & str & " GROUP BY jobs_id , jobs_op_id, jobs_op_tools_id,t3.products_id ORDER BY jobs_id , jobs_op_id, jobs_op_tools_id,t3.products_id DESC")

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_profit.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_profit_pie.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_profit_line.rdlc"
        End If


        Dim datasource As New ReportDataSource("dt_stock_out", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()

        Dim date_start As New ReportParameter("date_start", dt)
        Dim date_end As New ReportParameter("date_end", dn)

        Dim revenue As New ReportParameter("revenue", txtCost.Text)

        Me.rvView.LocalReport.SetParameters(New ReportParameter() {date_start, date_end, revenue})

        Me.rvView.LocalReport.DataSources.Add(datasource)


        Me.rvView.RefreshReport()

    End Sub

    Sub refreshJobspData(ByVal index As String)
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs ORDER BY jobs_name")
        cbJobs.DataSource = dt
        cbJobs.ValueMember = "jobs_id"
        cbJobs.DisplayMember = "jobs_name"
        If index <> "" Then
            cbJobs.SelectedValue = index
        End If
    End Sub


    Private Sub rp_stock_process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)

        refreshJobspData("")

        cbChartType.SelectedIndex = 0


    End Sub

End Class