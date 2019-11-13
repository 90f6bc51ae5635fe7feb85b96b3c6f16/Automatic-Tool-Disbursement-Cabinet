Imports System.IO

Public Class StockSlot

    Public products_id As String = ""
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim dt_main As New DataTable
    Dim editIndex As Integer = -1
    Sub refreshData()
        dt_main = config.GetDataTable("SELECT * , ifnull((SELECT (char(64 + stock_layouts_x) || stock_layouts_y ) as slot FROM tb_stock_layouts WHERE  stock_layouts_id = t2.slot),'-') as slot2, products_qty as dQty  FROM tb_products ,tb_how2buy as t2 , tb_suppliers WHERE tb_products.products_id = t2.products_id AND tb_suppliers.suppliers_id = t2.suppliers_id AND tb_products.products_id = '" & products_id & "'")
        dgvData.DataSource = dt_main
    End Sub

    Private Sub StockSlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False
        dgvData.AutoGenerateColumns = False
        refreshData()
    End Sub
End Class