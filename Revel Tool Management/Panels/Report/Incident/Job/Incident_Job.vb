Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class Incident_Job
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""

        Dim st As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim en As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        str = " AND incident_time >= '" & st & "' and incident_time <= '" & en & "'"


        Dim dt As DataTable = config.GetDataTable("SELECT incident_id, jobs_name, jobs_op_name, machines_name, shift, " &
                                                 " incident_type_name, incident_subject, incident_user, incident_time, incident_detail, incident_cost, incident_action, incident_image, products_code " &
                                                 " FROM tb_incident, tb_jobs, tb_machines, tb_jobs_op_tools, tb_products, tb_incident_type, tb_jobs_op " &
                                                 " WHERE tb_incident.jobs_id = tb_jobs.jobs_id " &
                                                 " AND tb_incident.incident_type_id = tb_incident_type.incident_type_id " &
                                                 " AND tb_incident.machines_id = tb_machines.machines_id " &
                                                 " AND tb_incident.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id " &
                                                 " AND tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
                                                 " AND tb_incident.products_id = tb_products.products_id " & str & " GROUP BY incident_id ORDER BY jobs_name, incident_time")

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Job_rp.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Job_rp_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Job_rp_Line.rdlc"
        End If

        Dim datasource As New ReportDataSource("Incident_Jobs", dt)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()

    End Sub


    Private Sub Incident_Job_One_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)

        cbChartType.SelectedIndex = 0
    End Sub
End Class