Imports System.Globalization
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class stock_issue
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim dt_main As New DataTable
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim str As String

        Dim dt As String = dtpStart.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))
        Dim dn As String = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("en-EN"))

        str &= " AND strftime('%Y-%m-%d %H:%M' , event_date ) >= strftime('%Y-%m-%d %H:%M' , '" & dt & "') and strftime('%Y-%m-%d %H:%M' , event_date) <= strftime('%Y-%m-%d %H:%M' , '" & dn & "') "


        If Not cbJobAll.Checked And cbOutJob.SelectedIndex > -1 Then
            str &= " AND t2.jobs_id = '" & cbOutJob.SelectedValue.ToString & "' "
        End If

        If Not cbMachineAll.Checked And Not cbShowAll.Checked And cbOutMachine.SelectedIndex > -1 Then
            str &= " AND t2.machines_id = '" & cbOutMachine.SelectedValue.ToString & "' "
        End If

        If Not cbProcessAll.Checked And cbOutProcess.SelectedIndex > -1 Then
            str &= " AND t2.jobs_op_tools_id = '" & cbOutProcess.SelectedValue.ToString & "' "
        End If


        Dim sj As String = "SELECT jobs_name FROM tb_jobs WHERE jobs_id = t2.jobs_id"
        Dim sm As String = "SELECT machines_name FROM tb_machines WHERE machines_id = t2.machines_id"
        Dim st As String = "SELECT jobs_op_tools_name FROM tb_jobs_op_tools WHERE jobs_op_tools_id = t2.jobs_op_tools_id"

        dt_main = config.GetDataTable("SELECT * , ( " & sj & ") as jobs_name , ( " & sm & ") as machines_name , ( " & st & ") as jobs_op_tools_name    FROM tb_stock_log as t2, tb_how2buy, tb_products, tb_suppliers , tb_products_type WHERE t2.how2buy_id = tb_how2buy.how2buy_id AND tb_how2buy.products_id = tb_products.products_id AND tb_how2buy.suppliers_id = tb_suppliers.suppliers_id AND tb_products_type.products_type_id = tb_products.products_type_id AND stock_type = 'out' " & str & " ORDER BY t2.event_date DESC")
        Dim datasource As New ReportDataSource("rp_stock_issue", dt_main)
        Me.rvView.LocalReport.DataSources.Clear()
        Me.rvView.LocalReport.DataSources.Add(datasource)
        Me.rvView.RefreshReport()
    End Sub

    Sub refreshJobsData(ByVal index As String)

        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs ")
        cbOutJob.DataSource = dt
        cbOutJob.DisplayMember = "jobs_name"
        cbOutJob.ValueMember = "jobs_id"
        cbOutJob.AutoCompleteSource = AutoCompleteSource.ListItems
        cbOutJob.DropDownStyle = ComboBoxStyle.DropDown
        cbOutJob.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" And cbOutJob.Items.Count > 0 Then
            cbOutJob.SelectedValue = index
        End If
    End Sub

    Sub refreshMachinesData(ByVal index As String, ByVal jobs_id As String)

        Dim str As String = ""
        If jobs_id <> "" Then
            str = ", tb_jobs_op_machines, tb_jobs_op WHERE tb_machines.machines_id = tb_jobs_op_machines.machines_id AND tb_jobs_op.jobs_op_id = tb_jobs_op_machines.jobs_op_id AND jobs_id = '" & jobs_id & "'  ORDER BY machines_name"
        End If
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_machines " & str)
        cbOutMachine.DataSource = dt
        cbOutMachine.DisplayMember = "machines_name"
        cbOutMachine.ValueMember = "machines_id"
        cbOutMachine.AutoCompleteSource = AutoCompleteSource.ListItems
        cbOutMachine.DropDownStyle = ComboBoxStyle.DropDown
        cbOutMachine.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" And cbOutMachine.Items.Count > 0 Then
            cbOutMachine.SelectedValue = index
        End If
    End Sub

    Sub refreshProcessData(ByVal index As String, ByVal machines As String)

        Dim dt As DataTable = config.GetDataTable("SELECT  * FROM tb_jobs_op, tb_jobs_op_tools , tb_jobs_op_machines " &
                                                  " WHERE tb_jobs_op_tools.jobs_op_id = tb_jobs_op_machines.jobs_op_id " &
                                                  " AND tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
                                                  " AND machines_id = '" & machines & "' AND jobs_id = '" & cbOutJob.SelectedValue & "' ORDER BY jobs_op_tools_name ")
        cbOutProcess.DataSource = dt
        cbOutProcess.DisplayMember = "jobs_op_tools_name"
        cbOutProcess.ValueMember = "jobs_op_tools_id"
        cbOutProcess.AutoCompleteSource = AutoCompleteSource.ListItems
        cbOutProcess.DropDownStyle = ComboBoxStyle.DropDown
        cbOutProcess.AutoCompleteMode = AutoCompleteMode.Suggest
        If index <> "" And cbOutProcess.Items.Count > 0 Then
            cbOutProcess.SelectedValue = index
        End If
    End Sub

    Private Sub stock_issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.CustomFormat = "yyyy-MMM-dd HH:mm"
        dtpStart.CustomFormat = "yyyy-MMM-dd HH:mm"

        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        dtpStart.Value = firstDay
        dtpEnd.Value = firstDay.AddMonths(1).AddDays(-1)

        refreshJobsData(0)
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbJobAll.CheckedChanged
        If cbJobAll.Checked Then
            cbOutJob.Enabled = False
            cbMachineAll.Enabled = False
            cbProcessAll.Enabled = False
            cbShowAll.Enabled = False

            cbMachineAll.Checked = True
            cbProcessAll.Checked = True
            cbShowAll.Checked = False

        Else
            cbOutJob.Enabled = True
            cbMachineAll.Enabled = True
            cbProcessAll.Enabled = True
            cbShowAll.Enabled = True


            cbMachineAll.Checked = False
            cbProcessAll.Checked = False

            cbShowAll.Checked = False
        End If
    End Sub

    Private Sub cbMachineAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbMachineAll.CheckedChanged
        If cbMachineAll.Checked Then
            cbOutMachine.Enabled = False
            cbProcessAll.Enabled = False
            cbShowAll.Enabled = False

            cbProcessAll.Checked = True
            cbShowAll.Enabled = False
        Else
            cbOutMachine.Enabled = True
            cbProcessAll.Enabled = True
            cbShowAll.Enabled = True

            cbProcessAll.Checked = False
            cbShowAll.Enabled = False
        End If
    End Sub

    Private Sub cbOperationAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbProcessAll.CheckedChanged
        If cbProcessAll.Checked Then
            cbOutProcess.Enabled = False
            cbShowAll.Checked = False
        Else
            cbOutProcess.Enabled = True
        End If
    End Sub

    Private Sub cbOutJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOutJob.SelectedIndexChanged
        If cbOutJob.Items.Count > 0 Then
            If cbOutJob.SelectedIndex > -1 Then
                refreshMachinesData("", cbOutJob.SelectedValue.ToString)
                If cbOutMachine.Items.Count > 0 Then
                    cbOutMachine.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub cbOutMachine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOutMachine.SelectedIndexChanged
        If cbOutMachine.Items.Count > 0 Then
            If cbOutMachine.SelectedIndex > -1 Then
                refreshProcessData("", cbOutMachine.SelectedValue.ToString)
                If cbOutProcess.Items.Count > 0 Then
                    cbOutProcess.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub cbOutJob_DropDownClosed(sender As Object, e As EventArgs) Handles cbOutJob.DropDownClosed
        If cbOutJob.Items.Count > 0 Then
            If cbOutJob.SelectedIndex > -1 Then
                refreshMachinesData("", cbOutJob.SelectedValue.ToString)
                If cbOutMachine.Items.Count > 0 Then
                    cbOutMachine.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub cbOutMachine_DropDownClosed(sender As Object, e As EventArgs) Handles cbOutMachine.DropDownClosed
        If cbOutMachine.Items.Count > 0 Then
            If cbOutMachine.SelectedIndex > -1 Then
                refreshProcessData("", cbOutMachine.SelectedValue.ToString)
                If cbOutProcess.Items.Count > 0 Then
                    cbOutProcess.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub cbShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowAll.CheckedChanged
        If cbShowAll.Checked Then
            cbOutProcess.Enabled = False
            cbProcessAll.Checked = False
        Else
            cbOutProcess.Enabled = True
        End If
    End Sub
End Class