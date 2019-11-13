Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class ReturnPrint
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Public dt As New DataTable

    Public return_id As String = ""
    Public return_date As String = ""
    Public return_remark As String = ""
    Public return_send As String = ""
    Public return_by As String = ""

    Private Sub ReturnPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dt.Rows.Count > 0 Then
            Dim return_id_ As New ReportParameter("return_id", return_id)
            Dim return_date_ As New ReportParameter("return_date", return_date)
            Dim return_remark_ As New ReportParameter("return_remark", return_remark)
            Dim return_send_ As New ReportParameter("return_send", return_send)
            Dim return_by_ As New ReportParameter("return_by", return_by)

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("stock_log_id") = i + 1
            Next

            Dim datasource As New ReportDataSource("tb_stock_out", dt)
            Me.rvView.LocalReport.DataSources.Clear()

            Me.rvView.LocalReport.EnableExternalImages = True
            Me.rvView.LocalReport.SetParameters(New ReportParameter() {return_id_, return_date_, return_remark_, return_send_, return_by_})
            Me.rvView.LocalReport.DataSources.Add(datasource)

        End If

        Me.rvView.RefreshReport()
    End Sub
End Class