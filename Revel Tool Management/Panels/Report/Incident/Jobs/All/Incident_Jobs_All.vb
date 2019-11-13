Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class Cost_Jobs

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String = ""
        Dim str2 As String = ""

        Dim st As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim en As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        str = " AND incident_time >= '" & st & "' and incident_time <= '" & en & "'"

        If lvJobs.SelectedItems.Count > 0 Then
            For i As Integer = 0 To lvJobs.Items.Count - 1
                If lvJobs.GetItemCheckState(i) Then
                    If i > 0 And i < lvJobs.Items.Count - 1 Then
                        str2 &= ","
                    ElseIf i = 0 Then
                        str2 &= " AND tb_incident.jobs_id IN ("
                    ElseIf i = lvJobs.Items.Count - 1 Then
                        str2 &= ") "
                    End If
                    str2 &= "'" & dt_main.Rows(i).Item("jobs_id").ToString & "'"
                End If
            Next
        End If

        Dim dt As DataTable = config.GetDataTable("SELECT incident_id, jobs_name, jobs_op_name, machines_name, shift, " &
                                                 " incident_type_name, incident_subject, incident_user, incident_time, incident_detail, incident_cost, incident_action, incident_image, products_code " &
                                                 " FROM tb_incident, tb_jobs, tb_machines, tb_jobs_op_tools, tb_products, tb_incident_type, tb_jobs_op " &
                                                 " WHERE tb_incident.jobs_id = tb_jobs.jobs_id " &
                                                 " AND tb_incident.incident_type_id = tb_incident_type.incident_type_id " &
                                                 " AND tb_incident.machines_id = tb_machines.machines_id " &
                                                 " AND tb_incident.jobs_op_tools_id = tb_jobs_op_tools.jobs_op_tools_id " &
                                                 " AND tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
                                                 " AND tb_incident.products_id = tb_products.products_id " & str & str2 & " GROUP BY incident_id")

        If cbChartType.SelectedItem = "Candle" Then
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Jobs_All.rdlc"
        ElseIf cbChartType.SelectedItem = "Pie" Then

            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Jobs_All_PIE.rdlc"
        Else
            Me.rvView.LocalReport.ReportEmbeddedResource = "Revel_Tool_Management.Incident_Jobs_All_Line.rdlc"
        End If


        Dim datasource As New ReportDataSource("Incident_Jobs", dt)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()

    End Sub

    Sub refreshJob()
        dt_main = config.GetDataTable("SELECT * FROM tb_jobs ")
        If dt_main.Rows.Count > 0 Then
            lvJobs.Items.Clear()
            For Each dr As DataRow In dt_main.Rows
                lvJobs.Items.Add(dr("jobs_name"), CheckState.Checked)
            Next
        End If
    End Sub

    Private Sub Cost_Jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)

        refreshJob()
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged

        For i As Integer = 0 To lvJobs.Items.Count - 1
                lvJobs.SetItemCheckState(i, cbAll.Checked)
            Next

    End Sub
End Class