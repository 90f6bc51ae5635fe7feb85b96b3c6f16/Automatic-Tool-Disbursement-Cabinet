Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class rp_stock_suppliers

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main, dt_sum As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""


        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "

        Dim str_in As String = ""

        For Each Item In lbSupplier.SelectedItems
            str_in &= "'" & Item(0).ToString() & "'"
            str_in &= ","
        Next

        If str_in = "" Then
            str_in = "'0'"
        Else
            str_in = str_in.Substring(0, str_in.Length - 1)
        End If

        dt_main = config.GetDataTable("SELECT tb_suppliers.suppliers_id ,  suppliers_name, SUM( stock_qty * stock_price) as cost " &
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
                                      "AND tb_suppliers.suppliers_id IN (" & str_in & ") " & str &
                                      "GROUP BY  tb_suppliers.suppliers_id  " &
                                      "ORDER BY  tb_suppliers.suppliers_id  DESC ")

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_suppliers.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_suppliers_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.rp_stock_suppliers_Line.rdlc"
        End If


        Dim date_start As New ReportParameter("date_start", dtpStart.Value.ToString("yyyy/MM/dd", CultureInfo.CreateSpecificCulture("en-EN")))
        Dim date_end As New ReportParameter("date_end", dtpEnd.Value.ToString("yyyy/MM/dd", CultureInfo.CreateSpecificCulture("en-EN")))

        Dim datasource As New ReportDataSource("dt_stock_out", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        If cbChartType.SelectedItem = "Pie" Then
            dt_sum = config.GetDataTable("SELECT SUM( stock_qty * stock_price) as cost " &
                                            "FROM tb_stock_log " &
                                            "LEFT JOIN tb_how2buy ON tb_stock_log.how2buy_id = tb_how2buy.how2buy_id " &
                                            "WHERE stock_type = 'out' " & str)

            If dt_sum.Rows.Count > 0 Then
                Dim all_max As New ReportParameter("all_max", Convert.ToDouble(dt_sum.Rows(0).Item(0).ToString))
                Me.rvView.LocalReport.SetParameters(New ReportParameter() {all_max, date_start, date_end})
            End If
            Me.rvView.LocalReport.SetParameters(New ReportParameter() {date_start, date_end})
        Else
            Me.rvView.LocalReport.SetParameters(New ReportParameter() {date_start, date_end})
        End If

        Me.rvView.RefreshReport()

    End Sub


    Private Sub rp_stock_suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        cbChartType.SelectedIndex = 0

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)
        getSupplier()

    End Sub

    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click
        For i As Int32 = 0 To lbSupplier.Items.Count - 1
            lbSupplier.SetSelected(i, True)
        Next
    End Sub

    Private Sub cmdUnselect_Click(sender As Object, e As EventArgs) Handles cmdUnselect.Click
        For i As Int32 = 0 To lbSupplier.Items.Count - 1
            lbSupplier.SetSelected(i, False)
        Next
    End Sub

    Sub getSupplier()

        Dim dt As DataTable = config.GetDataTable(
            "SELECT suppliers_id, suppliers_name FROM tb_Suppliers "
        )


        lbSupplier.DataSource = dt
        lbSupplier.DisplayMember = "suppliers_name"
        lbSupplier.ValueMember = "suppliers_id"


    End Sub

End Class