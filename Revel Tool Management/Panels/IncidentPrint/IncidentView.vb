Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class IncidentView
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Public dt As New DataTable
    Private Sub IncidentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dt.Rows.Count > 0 Then

            Dim str As String = ""
            If dt.Rows(0).Item("incident_image").ToString <> "" Then
                str = Path.GetDirectoryName(My.Settings.database_location) & "\images\incidents\" & dt.Rows(0).Item("incident_image")
            Else
                str = Path.GetDirectoryName(My.Settings.database_location) & "\images\incidents\default.jpg"
            End If

            Dim str_tool As String = ""
            If dt.Rows(0).Item("incident_image_tool").ToString <> "" Then
                str_tool = Path.GetDirectoryName(My.Settings.database_location) & "\images\incidents\" & dt.Rows(0).Item("incident_image_tool")
            Else
                str_tool = Path.GetDirectoryName(My.Settings.database_location) & "\images\incidents\default.jpg"
            End If

            Dim imgs As ReportParameter = New ReportParameter("imgs", "File:\" & str, True)
            Dim imgs_tool As ReportParameter = New ReportParameter("imgs_tool", "File:\" & str_tool, True)

            Dim datasource As New ReportDataSource("tb_incident", dt)
            Me.rvView.LocalReport.DataSources.Clear()


            Me.rvView.LocalReport.EnableExternalImages = True
            Me.rvView.LocalReport.SetParameters(New ReportParameter() {imgs, imgs_tool})
            Me.rvView.LocalReport.DataSources.Add(datasource)


        End If

        Me.rvView.RefreshReport()
    End Sub
End Class