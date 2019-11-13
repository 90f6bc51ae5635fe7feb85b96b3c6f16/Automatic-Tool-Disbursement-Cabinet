Imports System.IO

Public Class StockFindSuppliers

    Public how2buy_id As String
    Public products_id As String
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Sub refreshData()
        Dim str As String = ""

        If tbSearch.Text <> "" Then
            str = " And suppliers_name Like '%" & tbSearch.Text & "%'"
        End If
        dgvData.DataSource = config.GetDataTable("SELECT * FROM tb_products, tb_how2buy, tb_suppliers " &
                                                            "WHERE tb_products.product_id = tb_how2buy.products_id " &
                                                            "AND tb_how2buy.suppliers_id =tb_suppliers.suppliers_id " &
                                                            "AND tb_products_id = '" & products_id & "'" &
                                                            str &
                                                            " ORDER BY suppliers_name")


    End Sub

    Private Sub StockFindSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
        dgvData.EnableHeadersVisualStyles = False
        dgvData.AutoGenerateColumns = True
        refreshData()
    End Sub

    Private Sub cmdSearchALL_Click(sender As Object, e As EventArgs) Handles cmdSearchALL.Click
        refreshData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colSelect" Then
                how2buy_id = dgvData.Rows(e.RowIndex).Cells("how2buy_id").Value
                Me.Close()
            End If
        End If
    End Sub

End Class