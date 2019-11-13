Imports System.IO

Public Class StockLayoutDetail

    Public stock_layout_id As String = ""
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Sub refreshData()

        Dim si As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND tb_how2buy.how2buy_id = t2.how2buy_id AND stock_type = 'in' "
        Dim so As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND tb_how2buy.how2buy_id = t2.how2buy_id AND stock_type = 'out' "

        dt_main = config.GetDataTable("SELECT * , (ifnull((" & si & "),0) - ifnull((" & so & "),0)) as dQty  FROM tb_products ,tb_how2buy as t2 , tb_suppliers, tb_stock_layouts WHERE t2.slot = tb_stock_layouts.stock_layouts_id AND tb_products.products_id = t2.products_id AND tb_suppliers.suppliers_id = t2.suppliers_id AND tb_stock_layouts.stock_layouts_id = '" & stock_layout_id & "'")
        dgvData.DataSource = dt_main
    End Sub

    Private Sub StockLayoutDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False
        dgvData.AutoGenerateColumns = False
        refreshData()
    End Sub
End Class