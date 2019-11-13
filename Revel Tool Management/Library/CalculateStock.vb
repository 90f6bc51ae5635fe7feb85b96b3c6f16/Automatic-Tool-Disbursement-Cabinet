
Imports System.IO

Public Class CalculateStock
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Function calculate(ByVal jobs_id As Int32, ByVal production As Int32, ByVal products_id As Int32)

        Dim monthly_day As Int32 = (My.Settings.monthly_day)
        Dim percent_safety As Int32 = (My.Settings.percent_safety)
        Dim working_day As Int32 = (My.Settings.working_day)

        Dim str_product As String = ""
        If products_id = 0 Then
            str_product = "AND tb2.products_id not null"
        Else
            str_product = "AND tb2.products_id = '" & products_id & "' "
        End If


        Dim dt_jobs As DataTable = config.GetDataTable("select  tb_jobs_op_tools_use.jobs_op_tools_use_id,  tb2.products_id , tb2.products_group_id , " &
                                                       " IFNULL( (" &
                                                       " SELECT MAX(time_delivery) FROM tb_how2buy WHERE products_id = tb2.products_id AND how2buy_inactive = 'Active'" &
                                                       " ),0) as time_delivery, jobs_op_tools_use_inactive ,toollife, " &
                                                       "CASE (products_conner) WHEN 0 THEN 1 WHEN null THEN 1 ELSE products_conner END as products_conner ,products_factor  from tb_jobs " &
                                                       "LEFT JOIN  tb_jobs_op ON tb_jobs.jobs_id = tb_jobs_op.jobs_id " &
                                                       "LEFT JOIN  tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
                                                       "LEFT JOIN  tb_jobs_op_tools_use ON tb_jobs_op_tools.jobs_op_tools_id = tb_jobs_op_tools_use.jobs_op_tools_id " &
                                                       "LEFT JOIN  tb_products as tb2 ON tb_jobs_op_tools_use.products_id = tb2.products_id " &
                                                       "WHERE tb_jobs.jobs_id = '" & jobs_id & "' " & str_product & " " &
                                                       "ORDER BY tb_jobs_op_tools_use.jobs_op_tools_id ")



        For i As Int32 = 0 To dt_jobs.Rows.Count - 1

            Dim tools_use As New Dictionary(Of String, String)
            If dt_jobs.Rows(i).Item("products_group_id").ToString = "3" Then

                Dim leed_time As Double = Convert.ToDouble(dt_jobs.Rows(i).Item("time_delivery").ToString)
                Dim toollife As Double = Convert.ToDouble(dt_jobs.Rows(i).Item("toollife").ToString) * Convert.ToInt32(dt_jobs.Rows(i).Item("products_conner").ToString)
                Dim use_per_month As Double = Convert.ToDouble(production / toollife)
                Dim use_per_day As Double = Convert.ToDouble(use_per_month / monthly_day)
                Dim factor As Double = Convert.ToDouble(dt_jobs.Rows(i).Item("products_factor").ToString)

                Dim min As Int32 = use_per_day * leed_time

                Dim reorder As Int32 = min + (min * factor)

                Dim max As Int32 = (reorder - min) + reorder


                If dt_jobs.Rows(i).Item("jobs_op_tools_use_inactive").ToString = "Active" Then
                    tools_use.Add("jobs_op_tools_use_min", min)
                    tools_use.Add("jobs_op_tools_use_max", max)
                    tools_use.Add("jobs_op_tools_use_reorder", reorder)
                Else
                    tools_use.Add("jobs_op_tools_use_min", 0)
                    tools_use.Add("jobs_op_tools_use_max", 0)
                    tools_use.Add("jobs_op_tools_use_reorder", 0)
                End If
            Else
                tools_use.Add("jobs_op_tools_use_min", 0)
                tools_use.Add("jobs_op_tools_use_max", 0)
                tools_use.Add("jobs_op_tools_use_reorder", 0)
            End If

            If config.Update("tb_jobs_op_tools_use", tools_use, "jobs_op_tools_use_id = '" & dt_jobs.Rows(i).Item("jobs_op_tools_use_id").ToString & "'") Then
                Dim dt_product As DataTable = config.GetDataTable("SELECT IFNULL(SUM(jobs_op_tools_use_min),0) as min , " &
                                                                  "IFNULL(SUM(jobs_op_tools_use_max),0) as max, " &
                                                                  "IFNULL(SUM(jobs_op_tools_use_reorder),0) as reorder " &
                                                                  "FROM tb_jobs_op_tools_use  " &
                                                                  "WHERE products_id = '" & dt_jobs.Rows(i).Item("products_id").ToString & "'")
                If dt_product.Rows.Count > 0 Then
                    Dim product As New Dictionary(Of String, String)
                    product.Add("products_min", dt_product.Rows(0).Item("min").ToString)
                    product.Add("products_max", dt_product.Rows(0).Item("max").ToString)
                    product.Add("products_reorder", dt_product.Rows(0).Item("reorder").ToString)
                    config.Update("tb_products", product, "products_id = '" & dt_jobs.Rows(i).Item("products_id").ToString & "'")
                End If
            End If


        Next

        Return True

    End Function

    Function getJobAndProduction(ByVal products_id As Int16)

        Dim dt As New DataTable
        dt.Columns.Add("jobs_id")
        dt.Columns.Add("productions_plan_qty")

        Dim dt_tool As DataTable = config.GetDataTable("SELECT distinct tb_jobs.jobs_id  from tb_jobs " &
                                                       "LEFT JOIN  tb_jobs_op ON tb_jobs.jobs_id = tb_jobs_op.jobs_id " &
                                                       "LEFT JOIN  tb_jobs_op_tools ON tb_jobs_op.jobs_op_id = tb_jobs_op_tools.jobs_op_id " &
                                                       "LEFT JOIN  tb_jobs_op_tools_use ON tb_jobs_op_tools.jobs_op_tools_id = tb_jobs_op_tools_use.jobs_op_tools_id " &
                                                       "LEFT JOIN  tb_products ON tb_jobs_op_tools_use.products_id = tb_products.products_id " &
                                                       "WHERE tb_products.products_id = '" & products_id & "' AND tb_jobs.jobs_id not null " &
                                                       "ORDER BY tb_jobs.jobs_id ")

        For i As Int32 = 0 To dt_tool.Rows.Count - 1

            Dim dt_productions As DataTable = config.GetDataTable("SELECT * " &
                                                                  " FROM tb_productions " &
                                                                  " WHERE productions_year = ( " &
                                                                        "SELECT MAX(productions_year) " &
                                                                        "FROM tb_productions " &
                                                                        "WHERE productions_jobs_id = '" & dt_tool.Rows(i).Item("jobs_id").ToString & "' " &
                                                                        "GROUP BY productions_jobs_id " &
                                                                  ") AND productions_jobs_id = '" & dt_tool.Rows(i).Item("jobs_id").ToString & "' ORDER BY productions_month DESC LIMIT 0,1")

            Dim R As DataRow = dt.NewRow
            R("jobs_id") = dt_tool.Rows(i).Item("jobs_id").ToString
            If dt_productions.Rows.Count > 0 Then
                R("productions_plan_qty") = Convert.ToInt32(dt_productions.Rows(0).Item("productions_plan_qty").ToString)
            Else
                R("productions_plan_qty") = 0
            End If


            dt.Rows.Add(R)

        Next


        Return dt
    End Function


End Class
