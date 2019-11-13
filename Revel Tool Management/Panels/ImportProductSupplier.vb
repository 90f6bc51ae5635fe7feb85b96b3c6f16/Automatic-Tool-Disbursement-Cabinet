Imports System.IO

Public Class ImportProductSupplier

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Private Sub cmdBrown_Click(sender As Object, e As EventArgs) Handles cmdBrown.Click
        Dim fm As OpenFileDialog = New OpenFileDialog()
        fm.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

        If fm.ShowDialog() = DialogResult.OK Then
            tbFile.Text = fm.FileName
        End If
    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = tbFile.Text

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            dgvData.DataSource = dataSet.Tables(0)

            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            dgvData.Rows(e.RowIndex).Selected = True
            'TODO - Button Clicked - Execute Code Here

            If dgvData.Columns(e.ColumnIndex).Name = "colDel" Then
                dgvData.Rows.RemoveAt(e.RowIndex)
            End If

        End If

    End Sub

    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click

        Dim dt As DataTable = dgvData.DataSource
        Dim error_format As Int32 = 0
        Dim already_in_system As Int32 = 0
        Dim product_complete As Int32 = 0

        For i As Int16 = 0 To dt.Rows.Count - 1

            Dim dt_product As DataTable = config.GetDataTable("SELECT * FROM tb_how2buy As t1 LEFT JOIN tb_suppliers ON t1.suppliers_id = tb_suppliers.suppliers_id
							                                            LEFT JOIN tb_products ON t1.products_id = tb_products.products_id
		                                                                WHERE tb_suppliers.suppliers_name = '" & dt.Rows(i).Item(1).ToString & "'
                                                                        AND   tb_products.products_code = '" & dt.Rows(i).Item(0).ToString & "'
                                                              ")
            Dim get_id_supplier As DataTable = config.GetDataTable(" SELECT suppliers_id FROM tb_suppliers WHERE tb_suppliers.suppliers_name = '" & dt.Rows(i).Item(1).ToString & "'")


            If dt_product.Rows.Count > 0 Then
                already_in_system += 1
                dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

            Else
                Dim supplier As New Dictionary(Of String, String)
                Dim supplier_new As New Dictionary(Of String, String)


                If get_id_supplier.Rows.Count < 1 Then
                    supplier_new.Add("suppliers_name", dt.Rows(i).Item(1).ToString)
                    config.Insert("tb_suppliers", supplier_new)
                End If

                Dim get_id_suppliers As DataTable = config.GetDataTable(" SELECT suppliers_id FROM tb_suppliers WHERE tb_suppliers.suppliers_name = '" & dt.Rows(i).Item(1).ToString & "'")
                Dim get_id_products As DataTable = config.GetDataTable(" SELECT products_id FROM tb_products WHERE products_code = '" & dt.Rows(i).Item(0).ToString & "'")

                If get_id_products.Rows.Count > 0 Then

                    supplier.Add("products_id", get_id_products.Rows(0).Item(0).ToString)
                    supplier.Add("suppliers_id", get_id_suppliers.Rows(0).Item(0).ToString)
                    supplier.Add("prices", dt.Rows(i).Item(4).ToString)
                    supplier.Add("sale_prices", dt.Rows(i).Item(5).ToString)
                    supplier.Add("time_delivery", dt.Rows(i).Item(3).ToString)


                    If config.Insert("tb_how2buy", supplier) Then
                        product_complete += 1
                        dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Green

                    Else
                        error_format += 1
                        dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    End If
                Else
                    error_format += 1
                    dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Red

                End If
            End If
        Next

        lbAlready.Text = already_in_system.ToString
        lbError.Text = error_format.ToString
        lbSuccess.Text = product_complete.ToString

        MsgBox("Import product " & product_complete & " of " & dt.Rows.Count & " complete")

        Dim fm As New Suppliers
        fm.refreshSuppliers()
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Me.Close()
    End Sub
End Class