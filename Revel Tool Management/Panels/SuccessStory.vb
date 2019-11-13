Imports System.Globalization
Imports System.IO

Public Class SuccessStory

    Dim log As New Log
    Dim edit_row As DataRow

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Dim editIndex As Integer = -1
    Dim dt_main As DataTable


    Sub refreshData()
        Dim str As String = ""
        str = " WHERE (success_name LIKE '%" & tbSearch.Text & "%' OR success_detail LIKE '%" & tbSearch.Text & "%') "


        If cbGroupSearch.SelectedIndex > 0 Then
            str &= " AND success_type = '" & cbGroupSearch.Text & "' "
        End If

        If cbResultSearch.SelectedIndex > 0 Then
            str &= " AND success_result = '" & cbResultSearch.Text & "' "
        End If

        dt_main = config.GetDataTable("SELECT *  FROM tb_success " & str)
        dgvData.DataSource = dt_main

    End Sub

    Sub refreshBrand(ByVal brand_name As String)
        Dim dt_brand As DataTable = config.GetDataTable("SELECT products_brand_name FROM tb_products_brand ORDER BY products_brand_name")
        cbBrand.DataSource = dt_brand
        cbBrand.DisplayMember = "products_brand_name"

        cbBrand.Text = brand_name
    End Sub

    Sub ViewData(ByVal index As Integer)
        tbName.ReadOnly = True
        tbDetail.ReadOnly = True
        tbPartName.ReadOnly = True
        tbMaterial.ReadOnly = True
        cbGroup.Enabled = False
        cbBrand.Enabled = False
        cbResult.Enabled = False
        dtpDate.Enabled = False

        cmdUpload.Enabled = False
        cmdViewFile.Enabled = True
        cmdClearFile.Enabled = False
        cmdClear.Enabled = False
        cmdUpload.Enabled = False

        editIndex = -1

        Try
            dtpDate.Value = Convert.ToDateTime(dt_main.Rows(index).Item("success_date").ToString)
        Catch ex As Exception

        End Try

        cbResult.Text = dt_main.Rows(index).Item("success_result").ToString
        cbGroup.Text = dt_main.Rows(index).Item("success_type").ToString
        cbBrand.Text = dt_main.Rows(index).Item("success_brand").ToString

        tbName.Text = dt_main.Rows(index).Item("success_name").ToString
        tbPartName.Text = dt_main.Rows(index).Item("success_partname").ToString
        tbMaterial.Text = dt_main.Rows(index).Item("success_material").ToString
        tbDetail.Text = dt_main.Rows(index).Item("success_detail").ToString

        If dt_main.Rows(index).Item("success_image").ToString <> "" Then
            tbFile.Text = Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & dt_main.Rows(index).Item("success_image")
        Else
            tbFile.Text = ""
        End If
    End Sub

    Sub clearData()

        tbName.ReadOnly = False
        tbPartName.ReadOnly = False
        tbMaterial.ReadOnly = False
        tbDetail.ReadOnly = False
        cbGroup.Enabled = True
        cbBrand.Enabled = True
        cbResult.Enabled = True
        dtpDate.Enabled = True

        cmdUpload.Enabled = True
        cmdViewFile.Enabled = True
        cmdClearFile.Enabled = True
        cmdSubmit.Enabled = True
        cmdUpload.Enabled = True
        cmdClear.Enabled = True




        tbName.Text = ""
        tbDetail.Text = ""
        tbFile.Text = ""
        cmdSubmit.Text = "Add"




    End Sub

    Function checkData() As Boolean
        Dim ch_email As New RegexUtilities
        If tbName.Text = "" Then
            MsgBox("Please input TPR name.")
            tbName.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)

        dgvData.AutoGenerateColumns = False
        dgvData.EnableHeadersVisualStyles = False
        clearData()
        refreshData()

        cbGroup.SelectedIndex = 0
        cbGroupSearch.SelectedIndex = 0

        cbResult.SelectedIndex = 0
        cbResultSearch.SelectedIndex = 0
        refreshBrand("")

        dtpDate.CustomFormat = "yyyy-MMM-dd HH:mm"

    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click

        If cmdClear.Enabled = False Then
            cmdClear.Enabled = True
            clearData()
            editIndex = -1
        ElseIf checkData() Then
            If cmdSubmit.Text = "Add" Then
                Dim success As New Dictionary(Of String, String)
                Dim img As String = ""
                If My.Computer.FileSystem.FileExists(tbFile.Text) Then
                    Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                    img = time & Path.GetFileName(tbFile.Text)
                End If

                success.Add("success_name", tbName.Text)
                success.Add("success_date", dtpDate.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")))
                success.Add("success_type", cbGroup.Text)
                success.Add("success_brand", cbBrand.Text)
                success.Add("success_partname", tbPartName.Text)
                success.Add("success_material", tbMaterial.Text)
                success.Add("success_result", cbResult.Text)
                success.Add("success_detail", tbDetail.Text)
                success.Add("success_image", img)

                If config.Insert("tb_success", success) Then
                    If img <> "" Then
                        My.Computer.FileSystem.CopyFile(tbFile.Text, Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & img, True)
                    End If
                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "TPR",
                            "INSERT",
                            (
                            " Add 1 TPR record by " & My.Settings.login_name & ". \n" &
                            " TPR name : " & tbName.Text & " \n " &
                            " TPR date : " & dtpDate.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")) & " \n " &
                            " TPR group : " & cbGroup.Text & " \n " &
                            " TPR result : " & cbResult.Text & " \n " &
                            " TPR detail : " & tbDetail.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )
                End If


                Dim dt_new As DataTable = config.GetDataTable("SELECT MAX(success_id) as success_id FROM tb_success ")
                refreshData()
                clearData()
                For i As Integer = 0 To dt_main.Rows.Count - 1
                    If dt_new.Rows(0).Item("success_id") = dt_main.Rows(i).Item("success_id") Then
                        ViewData(i)
                    End If
                Next
                editIndex = -1
            Else
                Dim success As New Dictionary(Of String, String)
                Dim img As String = ""
                Dim time As String = DateTime.Now.ToString("ddMMyyyyHHmmssfff")
                If dt_main.Rows(editIndex).Item("success_image") = "" And My.Computer.FileSystem.FileExists(tbFile.Text) Then
                    img = time & Path.GetFileName(tbFile.Text)
                    My.Computer.FileSystem.CopyFile(tbFile.Text, Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & img, True)
                ElseIf dt_main.Rows(editIndex).Item("success_image") <> "" And Path.GetFileName(tbFile.Text) <> dt_main.Rows(editIndex).Item("success_image") And My.Computer.FileSystem.FileExists(tbFile.Text) Then
                    img = time & Path.GetFileName(tbFile.Text)
                    My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & dt_main.Rows(editIndex).Item("success_image"))
                    My.Computer.FileSystem.CopyFile(tbFile.Text, Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & img, True)
                Else
                    img = dt_main.Rows(editIndex).Item("success_image")
                End If

                success.Add("success_name", tbName.Text)
                success.Add("success_date", dtpDate.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")))
                success.Add("success_type", cbGroup.Text)
                success.Add("success_brand", cbBrand.Text)
                success.Add("success_partname", tbPartName.Text)
                success.Add("success_material", tbMaterial.Text)
                success.Add("success_detail", tbDetail.Text)
                success.Add("success_result", cbResult.Text)
                success.Add("success_image", img)
                If config.Update("tb_success", success, "success_id = '" & dt_main.Rows(editIndex).Item("success_id") & "'") Then
                    log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                            "TPR",
                            "UPDATE",
                            (
                            " Update 1 TPR record by " & My.Settings.login_name & ". \n" &
                            " From data." &
                            " TPR name : " & edit_row.Item("success_name") & " \n " &
                            " TPR date : " & edit_row.Item("success_date") & " \n " &
                            " TPR group : " & edit_row.Item("success_type") & " \n " &
                            " TPR result : " & edit_row.Item("success_result") & " \n " &
                            " TPR detail : " & edit_row.Item("success_detail") & " \n " &
                            " Image. : " & edit_row.Item("success_image") & " \n " &
                            " To data." &
                            " TPR name : " & tbName.Text & " \n " &
                            " TPR date : " & dtpDate.Value.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")) & " \n " &
                            " TPR group : " & cbGroup.Text & " \n " &
                            " TPR result : " & cbResult.Text & " \n " &
                            " TPR detail : " & tbDetail.Text & " \n " &
                            " Image. : " & img & " \n "
                            ),
                            My.Settings.login_name
                     )
                End If

                refreshData()
                clearData()
                ViewData(editIndex)
                editIndex = -1
            End If
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearData()
        refreshData()
    End Sub

    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Dim op As New OpenFileDialog
        op.Filter = "PDF|*.pdf;|EXCEL File|*.xls;*.xlsx;"
        If op.ShowDialog() = DialogResult.OK Then
            tbFile.Text = op.FileName
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        clearData()
        refreshData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            dgvData.Rows(e.RowIndex).Selected = True
            'TODO - Button Clicked - Execute Code Here
            If dgvData.Columns(e.ColumnIndex).Name = "colView" Then
                clearData()

                ViewData(e.RowIndex)
                editIndex = -1
            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colEdit" Then

                clearData()
                editIndex = e.RowIndex
                edit_row = dt_main.Rows(e.RowIndex)
                Try
                    dtpDate.Value = Convert.ToDateTime(dt_main.Rows(e.RowIndex).Item("success_date").ToString)
                Catch ex As Exception

                End Try

                cbResult.Text = dt_main.Rows(e.RowIndex).Item("success_result").ToString
                cbGroup.Text = dt_main.Rows(e.RowIndex).Item("success_type").ToString
                cbBrand.Text = dt_main.Rows(e.RowIndex).Item("success_brand").ToString

                tbName.Text = dt_main.Rows(e.RowIndex).Item("success_name").ToString
                tbPartName.Text = dt_main.Rows(e.RowIndex).Item("success_partname").ToString
                tbMaterial.Text = dt_main.Rows(e.RowIndex).Item("success_material").ToString
                tbDetail.Text = dt_main.Rows(e.RowIndex).Item("success_detail").ToString

                If dt_main.Rows(e.RowIndex).Item("success_image").ToString <> "" Then
                    tbFile.Text = Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & dt_main.Rows(e.RowIndex).Item("success_image")
                Else
                    tbFile.Text = ""
                End If

                cmdSubmit.Text = "Save"

            ElseIf dgvData.Columns(e.ColumnIndex).Name = "colDel" Then

                If MessageBox.Show("You want to delete success " & dt_main.Rows(e.RowIndex).Item("success_name"), "Delete success data", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If config.ExecuteNonQuery("DELETE FROM tb_success WHERE success_id ='" & dt_main.Rows(e.RowIndex).Item("success_id") & "'") Then
                        If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & dt_main.Rows(e.RowIndex).Item("success_image")) Then
                            My.Computer.FileSystem.DeleteFile(Path.GetDirectoryName(My.Settings.database_location) & "\images\success\" & dt_main.Rows(e.RowIndex).Item("success_image"))
                            log.add(Date.Now.ToString("yyyy-MM-dd HH:mm", CultureInfo.CreateSpecificCulture("th-TH")),
                                "TPR",
                                "DELETE",
                                (
                                " Remove 1 TPR record by " & My.Settings.login_name & ". \n" &
                                " TPR name : " & dt_main.Rows(e.RowIndex).Item("success_name") & " \n " &
                                " TPR date : " & dt_main.Rows(e.RowIndex).Item("success_date") & " \n " &
                                " TPR group : " & dt_main.Rows(e.RowIndex).Item("success_type") & " \n " &
                                " TPR result : " & dt_main.Rows(e.RowIndex).Item("success_result") & " \n " &
                                " TPR detail : " & dt_main.Rows(e.RowIndex).Item("success_detail") & " \n " &
                                " Image. : " & dt_main.Rows(e.RowIndex).Item("success_image") & " \n "
                                ),
                                My.Settings.login_name
                         )
                        End If
                        refreshData()
                        clearData()
                        editIndex = -1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdViewFile_Click(sender As Object, e As EventArgs) Handles cmdViewFile.Click
        System.Diagnostics.Process.Start(tbFile.Text)
    End Sub

    Private Sub cmdClearFile_Click(sender As Object, e As EventArgs) Handles cmdClearFile.Click
        tbFile.Text = ""
    End Sub

    Private Sub SuccessStory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub

    Private Sub cmdBrand_Click(sender As Object, e As EventArgs) Handles cmdBrand.Click
        Dim fm As New ProductBrands
        fm.ShowDialog()
        If editIndex > 0 Then
            refreshBrand(dt_main.Rows(editIndex).Item("success_brand").ToString)
        Else
            refreshBrand("")
        End If
    End Sub
End Class