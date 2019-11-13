Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class JobsReport
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Sub refreshJobsData(ByVal index As String)

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs ")
        cbOutJob.DataSource = dt
        cbOutJob.DisplayMember = "jobs_name"
        cbOutJob.ValueMember = "jobs_id"
        cbOutJob.AutoCompleteSource = AutoCompleteSource.ListItems
        cbOutJob.DropDownStyle = ComboBoxStyle.DropDown
        cbOutJob.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" Then
            cbOutJob.SelectedValue = index
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        Dim str As String = ""
        If Not cbAll.Checked Then
            str &= " AND tb_jobs.jobs_id = '" & cbOutJob.SelectedValue.ToString & "' "
        End If

        dt_main = config.GetDataTable("SELECT * FROM tb_jobs " &
            "LEFT JOIN tb_jobs_op ON tb_jobs.jobs_id = tb_jobs_op.jobs_id " &
            "LEFT JOIN tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
            "LEFT JOIN tb_jobs_op_tools_use ON tb_jobs_op_tools.jobs_op_tools_id = tb_jobs_op_tools_use.jobs_op_tools_id " &
            "LEFT JOIN tb_products ON tb_jobs_op_tools_use.products_id = tb_products.products_id " &
            "LEFT JOIN tb_products_type ON tb_products.products_type_id = tb_products_type.products_type_id " &
            " WHERE tb_products.products_id != '' " &
            str &
            " GROUP BY tb_jobs.jobs_id , tb_jobs_op.jobs_op_id, tb_jobs_op_tools.jobs_op_tools_id, tb_jobs_op_tools_use.jobs_op_tools_use_id,tb_products.products_id")

        Dim datasource As New ReportDataSource("rp_jobs", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()
    End Sub

    Private Sub JobsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshJobsData("")
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        If cbAll.Checked Then
            cbOutJob.Enabled = False
        Else
            cbOutJob.Enabled = True
        End If
    End Sub
End Class