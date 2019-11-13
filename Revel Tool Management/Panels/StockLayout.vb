Imports System.IO

Public Class StockLayout

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))



    Dim maxRow As Integer = 1
    Dim maxCol As Integer = 1


    Sub IncreateRows()
        If maxRow < 25 Then
            maxRow += 1
            config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '1' WHERE  CAST(stock_layouts_y AS int) = " & maxRow & " AND CAST(stock_layouts_x AS int) <= " & maxCol & "")

            AutoGenerateTables()
        End If
    End Sub

    Sub IncreateColumns()
        If maxCol < 25 Then
            maxCol += 1
            config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '1' WHERE  CAST(stock_layouts_x AS int) = " & maxCol & " AND CAST(stock_layouts_y AS int) <= " & maxRow & "")

            AutoGenerateTables()
        End If
    End Sub

    Sub DecreateRows()
        If maxRow > 1 Then

            config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '0' WHERE CAST(stock_layouts_y AS int) = " & maxRow)
            maxRow -= 1
            AutoGenerateTables()
        End If
    End Sub

    Sub DecreateColumns()
        If maxCol > 1 Then

            config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '0' WHERE  CAST(stock_layouts_x AS int) = " & maxCol)
            maxCol -= 1
            AutoGenerateTables()
        End If
    End Sub

    Sub AutoGenerateTables()
        Dim dt_row As DataTable = config.GetDataTable("SELECT stock_layouts_y From tb_stock_layouts WHERE stock_layouts_use = 1 Group By stock_layouts_y ORDER BY  CAST(stock_layouts_y AS int)")
        Dim dt_column As DataTable = config.GetDataTable("SELECT stock_layouts_x From tb_stock_layouts WHERE stock_layouts_use = 1 Group By stock_layouts_x ORDER BY  CAST(stock_layouts_x AS int)")

        Dim col(dt_column.Rows.Count) As String
        Dim row(dt_row.Rows.Count) As String

        maxCol = dt_column.Rows.Count
        maxRow = dt_row.Rows.Count

        tbCol.Text = maxCol
        tbRow.Text = maxRow

        For i As Integer = 0 To dt_column.Rows.Count - 1
            col(i) = Convert.ToChar(Keys.A + Convert.ToInt32(dt_column.Rows(i).Item("stock_layouts_x")) - 1)

        Next

        For i As Integer = 0 To dt_row.Rows.Count - 1
            row(i) = dt_row.Rows(i).Item("stock_layouts_y")
        Next

        tlpDisplay.Controls.Clear()

        tlpDisplay.ColumnStyles.Clear()
        tlpDisplay.RowStyles.Clear()

        tlpDisplay.ColumnCount = 1
        tlpDisplay.RowCount = 1

        tlpDisplay.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 48))
        tlpDisplay.RowStyles.Add(New RowStyle(SizeType.Absolute, 48))

        For i As Integer = 1 To col.Count
            Dim lbl As New Label
            lbl.Margin = New Padding(0, 0, 0, 0)
            lbl.Text = col(i - 1)
            lbl.Dock = DockStyle.Fill
            lbl.TextAlign = ContentAlignment.MiddleCenter

            tlpDisplay.ColumnCount += 1
            tlpDisplay.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 48))
            tlpDisplay.Controls.Add(lbl, i, 0)

        Next

        For i As Integer = 1 To row.Count
            Dim lbl As New Label
            lbl.Margin = New Padding(0, 0, 0, 0)
            lbl.Text = row(i - 1)
            lbl.Dock = DockStyle.Fill
            lbl.TextAlign = ContentAlignment.MiddleCenter



            tlpDisplay.RowCount += 1
            tlpDisplay.RowStyles.Add(New RowStyle(SizeType.Absolute, 48))
            tlpDisplay.Controls.Add(lbl, 0, i)
        Next

        For i As Integer = 1 To col.Count - 1
            For j As Integer = 1 To row.Count - 1

                Dim bt As New Button
                bt.Margin = New Padding(1, 1, 1, 1)
                bt.Padding = New Padding(0, 0, 0, 0)
                bt.FlatStyle = FlatStyle.Flat
                bt.FlatAppearance.BorderColor = Color.LightGray

                bt.FlatAppearance.BorderSize = 1

                Dim dt As DataTable = config.GetDataTable("SELECT stock_layouts_id FROM tb_how2buy, tb_stock_layouts WHERE tb_how2buy.slot = tb_stock_layouts.stock_layouts_id AND stock_layouts_x = '" & Convert.ToByte(col(i - 1).Chars(0)) - Keys.A + 1 & "' AND stock_layouts_y = '" & row(j - 1) & "'")
                If dt.Rows.Count > 0 Then
                    bt.BackColor = ColorTranslator.FromHtml(My.Settings.dgv_color)
                    bt.ForeColor = Color.White
                    bt.Font = New Font(bt.Font.Name, bt.Font.Size, Font.Style.Bold)


                Else
                    bt.BackColor = Color.LightGray
                    bt.Font = New Font(bt.Font.Name, bt.Font.Size, Font.Style.Bold)
                End If

                bt.Dock = DockStyle.Fill
                bt.Text = col(i - 1) & row(j - 1)

                AddHandler bt.Click, AddressOf Stock_Click

                tlpDisplay.Controls.Add(bt, i, j)

            Next
        Next
    End Sub

    Private Sub Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bt As Button = sender
        Dim x As String = Convert.ToByte(bt.Text.Chars(0)) - Keys.A + 1
        Dim y As String = bt.Text.Substring(1, bt.Text.Length - 1)
        Dim dt As DataTable = config.GetDataTable("SELECT stock_layouts_id FROM tb_stock_layouts WHERE stock_layouts_x = " & x & " AND stock_layouts_y = " & y)
        If dt.Rows.Count > 0 Then
            Dim pg As New StockLayoutDetail
            pg.stock_layout_id = dt.Rows(0).Item(0)
            pg.ShowDialog()
        End If
    End Sub

    Private Sub StockLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tlpDisplay.BorderStyle = BorderStyle.FixedSingle
        ' config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '0' ")
        ' config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '1' WHERE stock_layouts_x = '1' AND stock_layouts_y = '1' ")

        AutoGenerateTables()
    End Sub

    Private Sub cmdColSub_Click(sender As Object, e As EventArgs) Handles cmdColSub.Click
        DecreateColumns()
    End Sub

    Private Sub cmdColAdd_Click(sender As Object, e As EventArgs) Handles cmdColAdd.Click
        IncreateColumns()
    End Sub

    Private Sub cmdRowSub_Click(sender As Object, e As EventArgs) Handles cmdRowSub.Click
        DecreateRows()
    End Sub

    Private Sub cmdRowAdd_Click(sender As Object, e As EventArgs) Handles cmdRowAdd.Click
        IncreateRows()
    End Sub

    Private Sub tbCol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRow.KeyPress, tbCol.KeyPress
        Try
            If (Convert.ToByte(e.KeyChar) >= Keys.D0 And Convert.ToByte(e.KeyChar) <= Keys.D9) Or Convert.ToByte(e.KeyChar) = Keys.Back Then
                e.Handled = False
            ElseIf Convert.ToByte(e.KeyChar) = Keys.Enter Then
                e.Handled = False
                maxCol = Convert.ToInt32(tbCol.Text)
                maxRow = Convert.ToInt32(tbRow.Text)

                If maxRow > 26 Then
                    maxRow = 26
                ElseIf maxRow < 1 Then
                    maxRow = 1
                End If

                If maxCol > 26 Then
                    maxCol = 26
                ElseIf maxCol < 1 Then
                    maxCol = 1
                End If

                config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '0' WHERE CAST(stock_layouts_y AS int) >= " & maxRow)
                config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '0' WHERE CAST(stock_layouts_x AS int) >= " & maxCol)


                config.ExecuteNonQuery("UPDATE  tb_stock_layouts SET stock_layouts_use = '1' WHERE  CAST(stock_layouts_y AS int) <= " & maxRow & " AND CAST(stock_layouts_x AS int) <= " & maxCol & "")

                AutoGenerateTables()
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub
    Dim border As New BorderColor()
    Private Sub tlpDisplay_Paint(sender As Object, e As PaintEventArgs) Handles tlpDisplay.Paint
        border.SetBorderColor(tlpDisplay, ColorTranslator.FromHtml(My.Settings.dgv_color))
    End Sub

    Private Sub StockLayout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fm As New Main
        fm.Show()
    End Sub
End Class