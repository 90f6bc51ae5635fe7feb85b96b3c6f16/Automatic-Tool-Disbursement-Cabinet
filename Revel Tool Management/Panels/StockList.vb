Imports System.Globalization
Imports System.IO

Public Class StockList

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Dim in_stock_log_id As String = ""
    Dim out_stock_log_id As String = ""
    Dim type_id As String = ""

    Dim editIndex As Integer = -1
    Dim dt_main As DataTable
    Dim dt_in As DataTable
    Dim dt_out As DataTable

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAll.EnableHeadersVisualStyles = False
        dgvAll.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvAll.AutoGenerateColumns = False

        refreshALLData()

    End Sub


    Sub refreshALLData()

        Dim str As String = ""
        If tbAllSearch.Text <> "" Then
            str = " WHERE ((products_code LIKE '%" & tbAllSearch.Text & "%') OR (products_name1 LIKE '%" & tbAllSearch.Text & "%') OR (products_name2 LIKE '%" & tbAllSearch.Text & "%')) "
        End If

        Dim pro As String = "SELECT SUM(order_qty) - SUM(order_recieve)  FROM tb_order_list WHERE  products_id = t2.products_id "

        dt_main = config.GetDataTable("SELECT *, ifnull((" & pro & "),0) as  products_order_2 , SUM(products_qty) as qty " &
                                      "FROM tb_products as t2 " &
                                      "LEFT JOIN tb_how2buy ON t2.products_id = tb_how2buy.products_id " &
                                      str & "GROUP BY t2.products_id ORDER BY products_name1, products_code")
        dgvAll.DataSource = dt_main

    End Sub


    Function get_op(ByVal machine As String) As String
        Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_jobs_op_machines WHERE machines_id = '" & machine & "'")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("jobs_op_id")
        Else
            Return "0"
        End If
    End Function



    Private Sub cmdSearchALL_Click(sender As Object, e As EventArgs)
        refreshALLData()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)
        refreshALLData()
    End Sub

    Private Sub dgvAll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub cmdSearchALL_Click_1(sender As Object, e As EventArgs) Handles cmdSearchALL.Click
        refreshALLData()

    End Sub

    Private Sub dgvAll_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAll.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            'TODO - Button Clicked - Execute Code Here
            If dgvAll.Columns(e.ColumnIndex).Name = "colView" Then
                Dim sh As New StockSlot
                sh.products_id = dt_main.Rows(e.RowIndex).Item("products_id").ToString
                sh.ShowDialog()
            End If
        End If

    End Sub

    Private Sub tbAllSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAllSearch.KeyPress
        If Convert.ToByte(e.KeyChar) = Keys.Enter Then
            refreshALLData()
        End If
    End Sub

    Private Sub StockList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub
End Class