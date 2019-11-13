Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class rp_log

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String

        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        Dim str_type As String = "log_page = '" & cbPage.Text.ToUpper() & "' AND"

        If cbPageAll.Checked Then
            str_type = ""
        End If
        str &= " WHERE " & str_type & " strftime('%Y-%m-%d %H:%M' , log_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') AND strftime('%Y-%m-%d %H:%M' , log_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "

        dt_main = config.GetDataTable("SELECT *  FROM tb_log  " & str & " ORDER BY strftime('%Y-%m-%d %H:%M' , log_date ) DESC")
        Dim datasource As New ReportDataSource("rp_log_view", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()
    End Sub




    Private Sub stock_issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)

        cbPage.SelectedIndex = 0
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbPageAll.CheckedChanged
        If cbPageAll.Checked Then
            cbPage.Enabled = False

        Else
            cbPage.Enabled = True

        End If
    End Sub


End Class