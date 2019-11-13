Imports System.IO

Public Class ImportProduct

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim directory_Img As String = ""

    Private Sub ImportProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.AutoGenerateColumns = False

    End Sub

    Private Sub cmdBrown_Click(sender As Object, e As EventArgs) Handles cmdBrown.Click

        Dim fm As OpenFileDialog = New OpenFileDialog()
        fm.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

        If fm.ShowDialog() = DialogResult.OK Then
            tbFile.Text = fm.FileName
            directory_Img = Path.GetDirectoryName(fm.FileName)
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

            Dim col_main As DataGridViewColumnCollection = dgvData.Columns
            Dim col As DataColumnCollection = dataSet.Tables(0).Columns
            Dim i As Int16 = 0

            For i = 0 To col_main.Count - 1
                Dim j As Int16 = 0
                Dim ch As Boolean = False
                For j = 0 To col.Count - 1
                    If col_main(i).DataPropertyName = col(j).ColumnName Then
                        ch = True
                    End If
                Next
                If ch = False Then
                    Exit For
                End If
            Next

            If i = col_main.Count - 1 Then
                dgvData.DataSource = dataSet.Tables(0)
            Else
                MsgBox("Don't have Column " & col_main(i).DataPropertyName)
            End If


            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click
        Dim dt As DataTable = dgvData.DataSource


        Dim error_format As Int32 = 0
        Dim already_in_system As Int32 = 0
        Dim product_complete As Int32 = 0

        If dt Is Nothing Then
            MsgBox("please input excel file")
            Exit Sub
        End If




        For i As Int16 = 0 To dt.Rows.Count - 1


            Dim dt_product As DataTable = config.GetDataTable("SELECT * FROM tb_products WHERE products_code = '" & dt.Rows(i).Item("Product code").ToString & "'")
                Dim dt_group As DataTable = config.GetDataTable("SELECT * FROM tb_products_group WHERE products_group_name = '" & dt.Rows(i).Item("Group").ToString & "'")
                Dim dt_brand As DataTable = config.GetDataTable("SELECT * FROM tb_products_brand WHERE products_brand_name = '" & dt.Rows(i).Item("Brand").ToString & "'")
                Dim get_id_supplier As DataTable = config.GetDataTable(" SELECT suppliers_id FROM tb_suppliers WHERE tb_suppliers.suppliers_name = '" & dt.Rows(i).Item("Supplier").ToString & "'")

            If dt_product.Rows.Count > 0 Then

                If get_id_supplier.Rows.Count > 0 Then
                    updateHow2buy(i, dt_product.Rows(0).Item(0).ToString, get_id_supplier.Rows(0).Item(0).ToString)
                End If
                already_in_system += 1
                dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            Else

                Dim product As New Dictionary(Of String, String)
                Dim product_group As New Dictionary(Of String, String)
                Dim product_type As New Dictionary(Of String, String)
                Dim product_brand As New Dictionary(Of String, String)

                If dt_group.Rows.Count < 1 Then
                    product_group.Add("products_group_name", dt.Rows(i).Item("Group").ToString)
                    config.Insert("tb_products_group", product_group)
                End If

                Dim get_id_group As DataTable = config.GetDataTable("SELECT products_group_id FROM  tb_products_group WHERE products_group_name = '" & dt.Rows(i).Item("Group").ToString & "'")
                Dim dt_type As DataTable = config.GetDataTable("SELECT * FROM tb_products_type   WHERE products_group_id = '" & get_id_group.Rows(0).Item(0).ToString & "'
                                                                AND products_type_name = '" & dt.Rows(i).Item("Type").ToString & "'"
                                                                   )
                If dt_type.Rows.Count < 1 Then
                    product_type.Add("products_group_id", get_id_group.Rows(0).Item(0).ToString)
                    product_type.Add("products_type_name", dt.Rows(i).Item("Type").ToString)
                    config.Insert("tb_products_type", product_type)
                End If

                If dt_brand.Rows.Count < 1 Then
                    product_brand.Add("products_brand_name", dt.Rows(i).Item("Brand").ToString)
                    config.Insert("tb_products_brand", product_brand)
                End If

                Dim get_id_type As DataTable = config.GetDataTable("SELECT products_type_id FROM  tb_products_type WHERE products_type_name = '" & dt.Rows(i).Item("Type").ToString & "'")
                Dim get_id_bran As DataTable = config.GetDataTable("SELECT products_brand_id  FROM tb_products_brand WHERE products_brand_name = '" & dt.Rows(i).Item("Brand").ToString & "'")

                product.Add("products_code", dt.Rows(i).Item("Product code").ToString)
                product.Add("products_name2", dt.Rows(i).Item("Tool discription").ToString)
                product.Add("products_customer_code", dt.Rows(i).Item("Customer code").ToString)
                product.Add("products_conner", dt.Rows(i).Item("No of edge").ToString)
                product.Add("products_factor", dt.Rows(i).Item("Factor").ToString)
                product.Add("products_name1", dt.Rows(i).Item("Remark").ToString)
                product.Add("products_group_id", get_id_group.Rows(0).Item(0).ToString)
                product.Add("products_type_id", get_id_type.Rows(0).Item(0).ToString)
                product.Add("products_brand_id", get_id_bran.Rows(0).Item(0).ToString)


                If dt.Rows(i).Item("Image").ToString <> "" Then
                    Dim name_Img As String = dt.Rows(i).Item("Product code").ToString & DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                    Try
                        My.Computer.FileSystem.CopyFile(directory_Img & "\" & dt.Rows(i).Item("Image").ToString, Path.GetDirectoryName(My.Settings.database_location) & "\images\products\" & name_Img, True)
                        product.Add("products_image", name_Img)
                    Catch ex As Exception
                        product.Add("products_image", "")
                    End Try
                Else
                    product.Add("products_image", dt.Rows(i).Item("Image").ToString)
                End If

                If dt.Rows(i).Item("Drawing").ToString <> "" Then
                    Try
                        Dim name_Img As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff") & dt.Rows(i).Item("Drawing").ToString
                        My.Computer.FileSystem.CopyFile(directory_Img & "\" & dt.Rows(i).Item("Drawing").ToString, Path.GetDirectoryName(My.Settings.database_location) & "\images\drawing\" & name_Img, True)
                        product.Add("products_drawing", name_Img)
                    Catch ex As Exception
                        product.Add("products_drawing", "")
                    End Try
                Else
                    product.Add("products_drawing", dt.Rows(i).Item("Drawing").ToString)
                End If

                If config.Insert("tb_products", product) Then
                    product_complete += 1
                    addHow2buy(i)
                    dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Green
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

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Me.Close()


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

    Private Sub tbFile_TextChanged(sender As Object, e As EventArgs) Handles tbFile.TextChanged

    End Sub

    Private Sub addHow2buy(i As Int16)

        Dim dt As DataTable = dgvData.DataSource
        Dim error_format As Int32 = 0
        Dim already_in_system As Int32 = 0
        Dim product_complete As Int32 = 0

        Dim supplier As New Dictionary(Of String, String)
        Dim supplier_new As New Dictionary(Of String, String)
        Dim get_id_supplier As DataTable = config.GetDataTable(" SELECT suppliers_id FROM tb_suppliers WHERE tb_suppliers.suppliers_name = '" & dt.Rows(i).Item("Supplier").ToString & "'")

        If get_id_supplier.Rows.Count < 1 Then
            supplier_new.Add("suppliers_name", dt.Rows(i).Item("Supplier").ToString)

            config.Insert("tb_suppliers", supplier_new)
        End If

        Dim get_id_suppliers As DataTable = config.GetDataTable(" SELECT suppliers_id FROM tb_suppliers WHERE tb_suppliers.suppliers_name = '" & dt.Rows(i).Item("Supplier").ToString & "'")
        Dim get_id_products As DataTable = config.GetDataTable(" SELECT products_id FROM tb_products WHERE products_code = '" & dt.Rows(i).Item("Product code").ToString & "'")

        If get_id_products.Rows.Count > 0 Then


            supplier.Add("products_id", get_id_products.Rows(0).Item(0).ToString)
            supplier.Add("suppliers_id", get_id_suppliers.Rows(0).Item(0).ToString)
            supplier.Add("prices", dt.Rows(i).Item("Buying price").ToString)
            supplier.Add("sale_prices", dt.Rows(i).Item("Selling price").ToString)
            supplier.Add("time_delivery", dt.Rows(i).Item("Lead time").ToString)



            If config.Insert("tb_how2buy", supplier) Then
                product_complete += 1
                'dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Green

            Else
                error_format += 1
                'dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If

        End If

    End Sub

    Private Sub updateHow2buy(i As Int16, pro_id As Int16, suppli_id As Int16)
        Dim dt As DataTable = dgvData.DataSource

        If config.ExecuteNonQuery("UPDATE tb_how2buy SET time_delivery ='" & dt.Rows(i).Item("Lead time").ToString & "' , prices = '" & dt.Rows(i).Item("Buying price").ToString & "' ,sale_prices  = '" & dt.Rows(i).Item("Selling price").ToString & "'   WHERE products_id  =  '" & pro_id & "'   AND suppliers_id = '" & suppli_id & "' ") Then
            dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
        Else
            dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Red
        End If

    End Sub

End Class