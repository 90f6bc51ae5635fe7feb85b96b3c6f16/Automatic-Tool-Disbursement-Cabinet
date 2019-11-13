Public Class Envelopments
    Dim config As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)

    Dim data As New List(Of Integer)
    Function Refersh() As Boolean
        Try
            Dim dt As DataTable = config.GetDataTable("SELECT * FROM tb_database")
            data.Clear()
            lvView.Items.Clear()

            For Each dr As DataRow In dt.Rows
                Dim l As New ListViewItem
                l.Text = dr.Item(1)
                If dr.Item(3) = 1 Then
                    l.SubItems.Add("ใช้งาน")
                Else
                    l.SubItems.Add("")
                End If
                l.SubItems.Add(dr.Item(2))
                lvView.Items.Add(l)
                data.Add(dr.Item(0))
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Envelopments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refersh()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim fm As New fm_envelopments
        fm.ShowDialog()
        Refersh()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If lvView.SelectedIndices(0) > -1 Then
            Dim fm As New fm_envelopments
            fm.database_id = data(lvView.SelectedIndices(0))
            fm.database_name = lvView.SelectedItems(0).SubItems(0).Text
            fm.database_locations = lvView.SelectedItems(0).SubItems(2).Text
            fm.ShowDialog()
            Refersh()
        End If
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If lvView.Items.Count > 1 Then
            If lvView.SelectedIndices(0) > -1 Then
                If lvView.SelectedItems(0).SubItems(1).Text = "" Then
                    If MessageBox.Show("คุณต้องการลบฐานข้อมูล " & lvView.SelectedItems(0).SubItems(0).Text, "ลบฐานข้อมูล", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        If config.ExecuteNonQuery("DELETE FROM tb_database WHERE database_id ='" & data(lvView.SelectedIndices(0)) & "'") Then
                            MsgBox("ลบข้อมูลเรียบร้อย")
                            Refersh()
                        End If
                    End If
                Else
                    MsgBox("ฐานข้อมูลกำลังใช้งานไม่สามารถลบได้")
                End If
            Else
                MsgBox("กรุณาเลือกฐานข้อมูลที่ต้องการลบ")
            End If
        Else
            MsgBox("ไม่สามารถลบฐานข้อมูลได้เนื่องจากฐานข้อมูลมี 1 ฐานข้อมูล")
        End If

    End Sub

    Private Sub cmdDefault_Click(sender As Object, e As EventArgs) Handles cmdDefault.Click
        If lvView.SelectedIndices(0) > -1 Then
            config.ExecuteNonQuery("UPDATE tb_database SET database_use = '0' ")
            config.ExecuteNonQuery("UPDATE tb_database SET database_use = '1' WHERE database_id = '" & data(lvView.SelectedIndices(0)) & "'")

            My.Settings.database_name = lvView.SelectedItems(0).SubItems(0).Text
            My.Settings.database_location = lvView.SelectedItems(0).SubItems(2).Text
            My.Settings.Save()

            Refersh()
        End If

    End Sub
End Class