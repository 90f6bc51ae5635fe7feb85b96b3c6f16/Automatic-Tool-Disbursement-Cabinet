Imports System.IO

Public Class ImportSupplier
    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim directory_Img As String = ""
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

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub tbFile_TextChanged(sender As Object, e As EventArgs) Handles tbFile.TextChanged

    End Sub

    Private Sub cmdBrown_Click(sender As Object, e As EventArgs) Handles cmdBrown.Click
        Dim fm As OpenFileDialog = New OpenFileDialog()
        fm.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

        If fm.ShowDialog() = DialogResult.OK Then
            tbFile.Text = fm.FileName
            directory_Img = Path.GetDirectoryName(fm.FileName)

        End If
    End Sub

    Private Sub ImportSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Dim fm As New Suppliers
        fm.refreshSuppliers()
        fm.clearData()
        Me.Close()
    End Sub

    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click




        Dim dt As DataTable = dgvData.DataSource
        Dim error_format As Int32 = 0
        Dim already_in_system As Int32 = 0
        Dim product_complete As Int32 = 0

        For i As Int16 = 0 To dt.Rows.Count - 1

            Dim dt_product As DataTable = config.GetDataTable("SELECT * FROM tb_suppliers where suppliers_name =  '" & dt.Rows(i).Item(0).ToString & "'")
            If dt_product.Rows.Count > 0 Then
                already_in_system += 1
                dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

            Else
                Dim supplier As New Dictionary(Of String, String)

                supplier.Add("suppliers_name", dt.Rows(i).Item("Suppliers  Name").ToString)
                supplier.Add("suppliers_contact", dt.Rows(i).Item("Suppliers  Contact").ToString)
                supplier.Add("suppliers_address", dt.Rows(i).Item("Suppliers  Address").ToString)
                supplier.Add("suppliers_tel", dt.Rows(i).Item("Suppliers  Tel").ToString)
                supplier.Add("suppliers_email", dt.Rows(i).Item("Suppliers  Email").ToString)
                supplier.Add("suppliers_fax", dt.Rows(i).Item("Suppliers  Fax").ToString)
                supplier.Add("suppliers_detail", dt.Rows(i).Item("Suppliers Detail").ToString)

                If dt.Rows(i).Item("Image").ToString <> "" Then
                    Dim name_Img As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff") & dt.Rows(i).Item("Image").ToString
                    Try
                        My.Computer.FileSystem.CopyFile(directory_Img & "\" & dt.Rows(i).Item("Image").ToString, Path.GetDirectoryName(My.Settings.database_location) & "\images\suppliers\" & name_Img, True)
                    Catch ex As Exception
                        supplier.Add("suppliers_image", "")
                    End Try
                    supplier.Add("suppliers_image", name_Img)
                Else
                    supplier.Add("suppliers_image", dt.Rows(i).Item("Image").ToString)
                End If



                If config.Insert("tb_suppliers", supplier) Then
                    product_complete += 1
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

        Dim fm As New Suppliers
        fm.refreshSuppliers()
    End Sub
End Class