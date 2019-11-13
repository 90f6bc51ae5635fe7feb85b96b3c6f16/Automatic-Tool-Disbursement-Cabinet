Imports System.Globalization
Imports System.IO

Public Class Main

    Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Public userid As Int16
    Public usertype As String
    Public username As String
    Public userpic As String
    Function check_urgent() As Boolean
        Dim firstDay As DateTime = New DateTime(Today.Year, Today.Month, 1)

        Dim dt_main As DataTable = config.GetDataTable("SELECT products_reorder , products_code, products_name1, products_name2 , SUM(products_qty) as qty " &
                                                       "FROM tb_products as t2 " &
                                                       "LEFT JOIN tb_how2buy ON tb_how2buy.products_id = t2.products_id " &
                                                       "WHERE t2.products_id IN ( " &
                                                       " SELECT distinct products_id FROM tb_jobs_op_tools_use WHERE jobs_op_tools_use_inactive = 'Active'  " &
                                                        ") " &
                                                       "GROUP BY t2.products_id " &
                                                       "HAVING products_reorder > SUM(products_qty) AND products_reorder > 0  ORDER BY products_name1, products_code")
        If dt_main.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function


    Private Sub cmdExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim settings As New Settings
        settings.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnMain.Location = New Point((Me.Width - pnMain.Width) \ 2, (Me.Height - pnMain.Height) \ 2)

        userid = My.Settings.userid
        usertype = My.Settings.usertype
        username = My.Settings.username
        userpic = My.Settings.userpic

        Label1.Text = username
        If My.Computer.FileSystem.FileExists(Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & userpic) Then
            pbUser.ImageLocation = Path.GetDirectoryName(My.Settings.database_location) & "\images\users\" & userpic
        End If
        Label2.Text = usertype

        If My.Settings.license1 = "0" Then
            cmdStock.Enabled = False

        End If

        If My.Settings.license2 = "0" Then
            cmdStockIssue.Enabled = False

        End If

        If My.Settings.license3 = "0" Then
            cmdRestock.Enabled = False

        End If
        If My.Settings.license4 = "0" Then
            cmdProducts.Enabled = False

        End If

        If My.Settings.license5 = "0" Then
            cmdStockLayout.Enabled = False

        End If

        If My.Settings.license6 = "0" Then
            cmdSupplier.Enabled = False

        End If
        If My.Settings.license7 = "0" Then
            cmdReports.Enabled = False

        End If

        If My.Settings.license8 = "0" Then
            cmdUsers.Enabled = False

        End If
        If My.Settings.license9 = "0" Then
            cmdUrgentStock.Enabled = False

        End If

        If My.Settings.license10 = "0" Then
            cmdInnovation.Enabled = False

        End If


        If My.Settings.first_login Then
            If check_urgent() Then
                Dim fm_urgent As New Urgent
                fm_urgent.user_id = userid
                fm_urgent.ShowDialog()
            End If
        End If




    End Sub

    Private Sub cmdStock_Click(sender As Object, e As EventArgs) Handles cmdStock.Click
        Dim fm_stock As New StockList
        fm_stock.Show()

        Me.Close()
    End Sub

    Private Sub cmdProducts_Click(sender As Object, e As EventArgs) Handles cmdProducts.Click
        Dim fm_products As New Products
        fm_products.Show()

        Me.Close()
    End Sub

    Private Sub cmdStockLayout_Click(sender As Object, e As EventArgs) Handles cmdStockLayout.Click
        Dim fm_stock_layout As New StockLayout
        fm_stock_layout.Show()

        Me.Close()
    End Sub

    Private Sub cmdSupplier_Click(sender As Object, e As EventArgs) Handles cmdSupplier.Click
        Dim fm_supplier As New Suppliers
        fm_supplier.Show()

        Me.Close()
    End Sub

    Private Sub cmdUsers_Click(sender As Object, e As EventArgs) Handles cmdUsers.Click
        Dim fm_user As New name
        fm_user.Show()

        Me.Close()
    End Sub

    Private Sub cmdReports_Click(sender As Object, e As EventArgs) Handles cmdReports.Click
        Dim fm_report As New Report
        fm_report.Show()

        Me.Close()
    End Sub

    Private Sub cmdUrgentStock_Click(sender As Object, e As EventArgs) Handles cmdUrgentStock.Click
        Dim fm_urgent As New Urgent
        fm_urgent.user_id = userid
        My.Settings.first_login = False
        My.Settings.Save()
        fm_urgent.Show()

        Me.Close()
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Dim fm_login As New SplashScreen
        fm_login.Show()

        Me.Close()
    End Sub

    Private Sub cmdStockIssue_Click(sender As Object, e As EventArgs) Handles cmdStockIssue.Click
        Dim fm_stockissue As New StockIssue
        fm_stockissue.employee_name = username
        fm_stockissue.date_disabled = False
        fm_stockissue.Show()

        Me.Close()
    End Sub

    Private Sub cmdRestock_Click(sender As Object, e As EventArgs) Handles cmdRestock.Click
        Dim fm_restock As New Restock
        fm_restock.user_id = userid
        fm_restock.employee_name = username
        fm_restock.date_disabled = False
        fm_restock.Show()

        Me.Close()
    End Sub

    Private Sub cmdInnovation_Click(sender As Object, e As EventArgs) Handles cmdInnovation.Click
        System.Diagnostics.Process.Start("http://www.futuresupreme.com/innovation.php")
    End Sub

    Private Sub cmdStock_MouseLeave(sender As Object, e As EventArgs) Handles cmdStock.MouseLeave
        cmdStock.Image = My.Resources.inventory_stock_list
    End Sub

    Private Sub cmdStock_MouseMove(sender As Object, e As EventArgs) Handles cmdStock.MouseMove
        cmdStock.Image = My.Resources.inventory_stock_list_hover
    End Sub

    Private Sub cmdInnovation_MouseLeave(sender As Object, e As EventArgs) Handles cmdInnovation.MouseLeave
        cmdInnovation.Image = My.Resources.innovation
    End Sub

    Private Sub cmdInnovation_MouseMove(sender As Object, e As EventArgs) Handles cmdInnovation.MouseMove
        cmdInnovation.Image = My.Resources.innovation_hover
    End Sub

    Private Sub cmdStockIssue_MouseLeave(sender As Object, e As EventArgs) Handles cmdStockIssue.MouseLeave
        cmdStockIssue.Image = My.Resources.inventory_stock_issue
    End Sub

    Private Sub cmdStockIssue_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdStockIssue.MouseMove
        cmdStockIssue.Image = My.Resources.inventory_stock_issue_hover
    End Sub

    Private Sub cmdRestock_MouseLeave(sender As Object, e As EventArgs) Handles cmdRestock.MouseLeave
        cmdRestock.Image = My.Resources.inventory_restock
    End Sub

    Private Sub cmdRestock_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdRestock.MouseMove
        cmdRestock.Image = My.Resources.inventory_restock_hover
    End Sub

    Private Sub cmdProducts_MouseLeave(sender As Object, e As EventArgs) Handles cmdProducts.MouseLeave
        cmdProducts.Image = My.Resources.product
    End Sub

    Private Sub cmdProducts_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdProducts.MouseMove
        cmdProducts.Image = My.Resources.product_hover
    End Sub

    Private Sub cmdStockLayout_MouseLeave(sender As Object, e As EventArgs) Handles cmdStockLayout.MouseLeave
        cmdStockLayout.Image = My.Resources.layout_south
    End Sub

    Private Sub cmdStockLayout_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdStockLayout.MouseMove
        cmdStockLayout.Image = My.Resources.layout_south_hover
    End Sub

    Private Sub cmdSupplier_MouseLeave(sender As Object, e As EventArgs) Handles cmdSupplier.MouseLeave
        cmdSupplier.Image = My.Resources.suppliers
    End Sub

    Private Sub cmdSupplier_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdSupplier.MouseMove
        cmdSupplier.Image = My.Resources.suppliers_hover
    End Sub

    Private Sub cmdUsers_MouseLeave(sender As Object, e As EventArgs) Handles cmdUsers.MouseLeave
        cmdUsers.Image = My.Resources.user
    End Sub

    Private Sub cmdUsers_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdUsers.MouseMove
        cmdUsers.Image = My.Resources.user_hover
    End Sub

    Private Sub cmdUrgentStock_MouseLeave(sender As Object, e As EventArgs) Handles cmdUrgentStock.MouseLeave
        cmdUrgentStock.Image = My.Resources.urgent
    End Sub

    Private Sub cmdUrgentStock_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdUrgentStock.MouseMove
        cmdUrgentStock.Image = My.Resources.urgent_hover
    End Sub

    Private Sub cmdReports_MouseLeave(sender As Object, e As EventArgs) Handles cmdReports.MouseLeave
        cmdReports.Image = My.Resources.report1
    End Sub

    Private Sub cmdReports_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdReports.MouseMove
        cmdReports.Image = My.Resources.report_hover1
    End Sub
End Class
