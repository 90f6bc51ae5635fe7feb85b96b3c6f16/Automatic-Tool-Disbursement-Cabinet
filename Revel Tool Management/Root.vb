Imports System.Globalization
Imports System.IO
Public Class Root

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))
    Public userid As Int16
    Public usertype As String
    Public username As String
    Public userpic As String

    Private Sub cmdStockList_Click(sender As Object, e As EventArgs) Handles cmdStock.Click
        Dim fm_stock As New StockList
        fm_stock.ShowDialog()
    End Sub

    Private Sub cmdIssue_Click(sender As Object, e As EventArgs) Handles cmdStockIssue.Click
        Dim fm_stock As New StockIssue
        fm_stock.employee_name = username
        fm_stock.date_disabled = True
        fm_stock.ShowDialog()
    End Sub

    Private Sub cmdRestock_Click(sender As Object, e As EventArgs) Handles cmdRestock.Click
        Dim fm_stock As New Restock
        fm_stock.user_id = userid
        fm_stock.employee_name = username
        fm_stock.date_disabled = True
        fm_stock.ShowDialog()
    End Sub

    Private Sub cmdProducts_Click(sender As Object, e As EventArgs) Handles cmdProducts.Click
        Dim fm_products As New Products
        fm_products.ShowDialog()
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Dim fm_login As New SplashScreen
        fm_login.Show()

        Me.Hide()
    End Sub


    Private Sub cmdUrgentStock_Click(sender As Object, e As EventArgs) Handles cmdUrgentStock.Click
        Dim fm_urgent As New Urgent
        fm_urgent.user_id = userid
        fm_urgent.ShowDialog()
    End Sub

    Private Sub cmdReport_Click(sender As Object, e As EventArgs) Handles cmdReports.Click
        Dim fm_report As New Report
        fm_report.ShowDialog()
    End Sub

    Private Sub pbUser_Paint(sender As Object, e As PaintEventArgs)
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 0, 168, 236), ButtonBorderStyle.Solid)
    End Sub

    Private Sub Root_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnMain.Location = New Point((Me.Width - pnMain.Width) \ 2, (Me.Height - pnMain.Height) \ 2)
        Label1.Text = username
        If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & userpic) Then
            pbUser.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & userpic
        End If

        Label2.Text = usertype
        If check_urgent() Then
            Dim fm_urgent As New Urgent
            fm_urgent.ShowDialog()
        End If
    End Sub


    Function check_urgent() As Boolean
        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        Dim st As String = firstDay.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("th-TH"))
        Dim en As String = firstDay.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("th-TH"))

        Dim str2 As String = " AND event_date >= '" & st & "' and event_date <= '" & en & "'"

        Dim si As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in' " & str2
        Dim so As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out' " & str2


        Dim sai As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in' and event_date <= '" & st & "'"
        Dim sao As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out' and event_date <= '" & st & "'"

        Dim si_qty As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'in'"
        Dim so_qty As String = "SELECT SUM(stock_qty)  FROM tb_stock_log , tb_how2buy WHERE tb_stock_log.how2buy_id = tb_how2buy.how2buy_id AND products_id = t2.products_id AND stock_type = 'out'"
        Dim pro As String = "SELECT SUM(order_qty) - SUM(order_recieve)  FROM tb_order_list WHERE  products_id = t2.products_id "

        'Dim dt_main As DataTable = config.GetDataTable("SELECT products_min ,products_code, products_name1, products_name2 , (ifnull((" & si_qty & "),0) - ifnull((" & so_qty & "),0)) as qty   FROM tb_products as t2 GROUP BY t2.products_id HAVING products_min > (((ifnull((" & si & "),0) - ifnull((" & so & "),0)) + (ifnull((" & sai & "),0) - ifnull((" & sao & "),0))) + ifnull((" & pro & "),0) )  ORDER BY products_name1, products_code")

        Dim dt_main As DataTable = config.GetDataTable("SELECT products_min ,products_code, products_name1, products_name2 , (ifnull((" & si_qty & "),0) - ifnull((" & so_qty & "),0)) as qty   FROM tb_products as t2 GROUP BY t2.products_id HAVING products_min > (((ifnull((" & si & "),0) - ifnull((" & so & "),0)) + (ifnull((" & sai & "),0) - ifnull((" & sao & "),0)))  )  ORDER BY products_name1, products_code")
        If dt_main.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Private Sub Root_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub cmdInnovation_Click(sender As Object, e As EventArgs) Handles cmdInnovation.Click
        System.Diagnostics.Process.Start("http://www.futuresupreme.com/innovation.php")
    End Sub
End Class