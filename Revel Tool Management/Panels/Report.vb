Imports System.Globalization
Imports System.IO
Imports System.IO.Compression
Imports System.IO.Compression.ZipFile
Public Class Report
    Private Sub tvReport_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvReport.AfterSelect
        Dim nodes As TreeNode = tvReport.SelectedNode

        For Each nd As TreeNode In tvReport.Nodes
            nd.BackColor = Color.Transparent
            nd.ForeColor = Color.Black
            For Each nd1 As TreeNode In nd.Nodes
                nd1.BackColor = Color.Transparent
                nd1.ForeColor = Color.Black
                For Each nd2 As TreeNode In nd1.Nodes
                    nd2.BackColor = Color.Transparent
                    nd2.ForeColor = Color.Black
                Next
            Next
        Next

        tvReport.SelectedNode.BackColor = Color.MediumBlue
        tvReport.SelectedNode.ForeColor = Color.White

        Select Case nodes.Tag
            Case "IRSummary"
                Dim f As New Incident_Tool With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "IRType"
                Dim f As New Incident_Types With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "IRJobs"
                Dim f As New Cost_Jobs With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "IRJobs1"
                Dim f As New Incident_Job With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "IRMachine"
                Dim f As New Incident_Machine With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndStock"
                Dim f As New rp_stock_in With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSJobs"
                Dim f As New rp_stock_jobs With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndSMachines"
                Dim f As New rp_stock_machines With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSOperations"
                Dim f As New rp_stock_operations With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSProcess"
                Dim f As New rp_stock_process With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSProducts"
                Dim f As New rp_stock_products With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSProductGroups"
                Dim f As New rp_product_groups With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSProductTypes"
                Dim f As New rp_product_types With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSProductBrands"
                Dim f As New rp_product_brands With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndSSuppliers"
                Dim f As New rp_stock_suppliers With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndSPWeek"
                Dim f As New rp_per_week With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndSPMonth"
                Dim f As New rp_per_month With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndTLRecordAvg"
                Dim f As New rp_actual_toollife_avg With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndTLRecord"
                Dim f As New rp_actual_toollife With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndProfit"
                Dim f As New rp_profit With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndIssue"
                Dim f As New stock_issue With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndReStock"
                Dim f As New rp_restock With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()
            Case "ndStockList"
                Dim f As New rp_stocklist With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ndJobs"
                Dim f As New rp_stock_jobs With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "JobCPP"
                Dim f As New rp_job_cpp With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ProcessCPP"
                Dim f As New rp_job_process_cost_cpp With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "JobCost"
                Dim f As New rp_job_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "JobOperationCost"
                Dim f As New rp_job_operation_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "JobProcessCost"
                Dim f As New rp_job_process_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "MachineCost"
                Dim f As New rp_job_machine_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()


            Case "ProductCost"
                Dim f As New rp_job_product_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "StockIssueCost"
                Dim f As New rp_stock_issue_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "StockIssueProductCost"
                Dim f As New rp_stock_issue_product_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "RestockCost"

                Dim f As New rp_restock_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "RestockProductCost"

                Dim f As New rp_restock_product_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "DataLog"

                Dim f As New rp_log With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "JobCPPAnalysis"

                Dim f As New rp_analysis_job_cpp With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "JobCostAnalysis"

                Dim f As New rp_analysis_job_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ToolProcessCPPAnalysis"
                Dim f As New rp_analysis_process_cpp With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ToolProcessCostAnalysis"
                Dim f As New rp_analysis_process_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

            Case "ProductCostAnalysis"

                Dim f As New rp_analysis_product_cost With {.TopLevel = False, .AutoSize = False}
                f.Dock = DockStyle.Fill
                Me.pnReport.Controls.Clear()
                Me.pnReport.Controls.Add(f)
                f.Show()

        End Select

    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSetting_Click(sender As Object, e As EventArgs) Handles cmdSetting.Click
        Dim fm_setting As New Settings
        fm_setting.ShowDialog()
    End Sub

    Private Sub Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub

    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        Dim sv As New SaveFileDialog
        sv.Filter = "ZIP Files (*.zip*)|*.zip"
        If sv.ShowDialog = DialogResult.OK Then
            Dim fileDir As String = Path.GetDirectoryName(My.Settings.database_location)
            Dim zipPath As String = Path.GetDirectoryName(sv.FileName) & "\" & Path.GetFileName(sv.FileName) & "-" & DateTime.Now().ToString("yyyy-MM-dd HH-mm", CultureInfo.InvariantCulture) & ".zip"
            Dim tempPath As String = Path.GetDirectoryName(sv.FileName) & "\backup_temp" & "" & DateTime.Now().ToString("yyyyMMddHHmm", CultureInfo.InvariantCulture)

            Try
                If Not My.Computer.FileSystem.DirectoryExists(tempPath) Then
                    My.Computer.FileSystem.CreateDirectory(tempPath)
                Else
                    My.Computer.FileSystem.DeleteDirectory(tempPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(tempPath)
                End If
                My.Computer.FileSystem.CopyDirectory(
                    fileDir,
                    tempPath,
                    FileIO.UIOption.OnlyErrorDialogs,
                    FileIO.UICancelOption.DoNothing
                    )

                ZipFile.CreateFromDirectory(tempPath, zipPath)
                If My.Computer.FileSystem.DirectoryExists(tempPath) Then
                    My.Computer.FileSystem.DeleteDirectory(tempPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If

                MsgBox("Backup complete.")

            Catch ex As Exception
                MsgBox("Backup fail : " & ex.Message.ToString & ".")
            End Try
        End If
    End Sub
End Class