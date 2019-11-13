
Imports System.Data.SQLite
Imports System.IO

Public Class CreateDatabase
    Protected dbConnection As String

    ' <summary>  
    '     Single Param Constructor for specifying the DB file.  
    ' </summary>  
    ' <param name="inputFile">The File containing the DB</param>  
    Sub New(ByVal sourceFile As String)
        dbConnection = String.Format("Data Source={0}", sourceFile)

        If (Not System.IO.Directory.Exists(Path.GetDirectoryName(sourceFile))) Then
            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(sourceFile))
        End If

        If Not My.Computer.FileSystem.FileExists(sourceFile) Then
            SQLiteConnection.CreateFile(sourceFile)

            '1. Create tb_user 
            If create_tables("CREATE TABLE tb_user (" &
            "user_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "user_name TEXT  DEFAULT ''," &
            "user_lastname TEXT  DEFAULT ''," &
            "user_type_id INTEGER  DEFAULT 0," &
            "user_tel TEXT  DEFAULT ''," &
            "user_email TEXT  DEFAULT ''," &
            "user_username TEXT  DEFAULT ''," &
            "user_password TEXT  DEFAULT ''," &
            "user_image TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("1. Create user tables success.")
            Else
                Console.WriteLine("1. Create user tables fail.")
            End If

            '2. Create tb_user_type
            If create_tables("CREATE TABLE tb_user_type (" &
            "user_type_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "user_type_license1 INTEGER DEFAULT 0," &
            "user_type_license2 INTEGER DEFAULT 0," &
            "user_type_license3 INTEGER DEFAULT 0," &
            "user_type_license4 INTEGER DEFAULT 0," &
            "user_type_license5 INTEGER DEFAULT 0," &
            "user_type_license6 INTEGER DEFAULT 0," &
            "user_type_license7 INTEGER DEFAULT 0," &
            "user_type_license8 INTEGER DEFAULT 0," &
            "user_type_license9 INTEGER DEFAULT 0," &
            "user_type_license10 INTEGER DEFAULT 0," &
            "user_type_license11 INTEGER DEFAULT 0," &
            "user_type_license12 INTEGER DEFAULT 0," &
            "user_type_license13 INTEGER DEFAULT 0," &
            "user_type_license14 INTEGER DEFAULT 0," &
            "user_type_license15 INTEGER DEFAULT 0," &
            "user_type_license16 INTEGER DEFAULT 0," &
            "user_type_name TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("2. Create user type tables success.")
            Else
                Console.WriteLine("2. Create user type tables fail.")
            End If


            '3. Create tb_suppliers
            If create_tables("CREATE TABLE tb_suppliers (" &
            "suppliers_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "suppliers_name TEXT  DEFAULT ''," &
            "suppliers_contact TEXT  DEFAULT ''," &
            "suppliers_address TEXT  DEFAULT ''," &
            "suppliers_tel TEXT  DEFAULT ''," &
            "suppliers_email TEXT  DEFAULT ''," &
            "suppliers_fax TEXT  DEFAULT ''," &
            "suppliers_image TEXT  DEFAULT ''," &
            "suppliers_detail TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("3. Create suppliers tables success.")
            Else
                Console.WriteLine("3. Create suppliers tables fail.")
            End If

            '4. Create tb_products_brands
            If create_tables("CREATE TABLE tb_products_brand (" &
            "products_brand_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "products_brand_name TEXT  DEFAULT ''," &
            "products_brand_detail TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("5. Create products brands tables success.")
            Else
                Console.WriteLine("5. Create products brands tables fail.")
            End If

            '5. Create tb_products_group
            If create_tables("CREATE TABLE tb_products_group (" &
            "products_group_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "products_group_name TEXT  DEFAULT ''," &
            "products_group_detail TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("6. Create products group tables success.")
            Else
                Console.WriteLine("6. Create products group tables fail.")
            End If

            '6. Create tb_products_types
            If create_tables("CREATE TABLE tb_products_type (" &
            "products_type_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "products_group_id INTEGER," &
            "products_type_name TEXT  DEFAULT ''," &
            "products_type_detail TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("7. Create products types tables success.")
            Else
                Console.WriteLine("7. Create products types tables fail.")
            End If

            '7. Create tb_products
            If create_tables("CREATE TABLE tb_products (" &
            "products_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "products_code TEXT  DEFAULT ''," &
            "products_name1 TEXT  DEFAULT ''," &
            "products_name2 TEXT  DEFAULT ''," &
            "products_customer_code TEXT  DEFAULT ''," &
            "products_group_id INTEGER  DEFAULT 0," &
            "products_type_id INTEGER  DEFAULT 0," &
            "products_brand_id INTEGER  DEFAULT 0," &
            "products_min INTEGER  DEFAULT 0," & 'เลิกใช้งาน
            "products_max INTEGER  DEFAULT 0," & 'เลิกใช้งาน
            "products_conner INTEGER  DEFAULT 0," &
            "products_order INTEGER  DEFAULT 0," &
            "products_image TEXT  DEFAULT ''," &
            "products_drawing TEXT  DEFAULT ''," &
            "products_detail TEXT  DEFAULT ''," &
            "products_reorder	INTEGER DEFAULT 0," &
            "products_factor	REAL DEFAULT 0," & 'เลิกใช้งาน
            "products_consumption	INTEGER DEFAULT 0," &'เพิ่มใหม่
            "products_percent_safety  REAL DEFAULT 0," &'เพิ่มใหม่
            "products_order_quantity  REAL DEFAULT 0" &'เพิ่มใหม่
            ")") Then
                Console.WriteLine("8. Create products tables success.")
            Else
                Console.WriteLine("8. Create products tables fail.")
            End If

            '8. Create tb_how2buy
            If create_tables("CREATE TABLE tb_how2buy (" &
            "how2buy_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "products_id TEXT  DEFAULT ''," &
            "suppliers_id TEXT  DEFAULT ''," &
            "prices REAL DEFAULT 0," &
            "sale_prices REAL DEFAULT  0," &
            "products_qty INTEGER  DEFAULT 0, " &
            "slot TEXT  DEFAULT '', " &
            "adjust TEXT  DEFAULT '', " &
            "products_supplier_code TEXT DEFAULT ''," &
            "products_cost REAL DEFAULT 0," &
            "time_delivery INTEGER  DEFAULT 0," &
            "how2buy_inactive TEXT DEFAULT 'Active'" &
            ")") Then
                Console.WriteLine("9. Create how2buy tables success.")
            Else
                Console.WriteLine("9. Create how2buy tables fail.")
            End If

            '9. Create tb_machines
            If create_tables("CREATE TABLE tb_machines (" &
            "machines_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "machines_name TEXT  DEFAULT ''," &
            "machines_model TEXT  DEFAULT ''," &
            "machines_brand TEXT  DEFAULT ''," &
            "machines_detail TEXT  DEFAULT ''," &
            "machines_type TEXT  DEFAULT ''," &
            "machines_spindle TEXT  DEFAULT ''," &
            "machines_image TEXT  DEFAULT ''," &
            "machines_status INTEGER  DEFAULT 0" &
            ")") Then
                Console.WriteLine("10. Create machine tables success.")
            Else
                Console.WriteLine("10. Create machine tables fail.")
            End If

            '10. Create tb_jobs
            If create_tables("CREATE TABLE tb_jobs (" &
            "jobs_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "jobs_name TEXT  DEFAULT ''," &
            "jobs_no TEXT  DEFAULT ''," &
            "jobs_cpp REAL  DEFAULT 0," &
            "jobs_material TEXT  DEFAULT ''," &
            "jobs_hardness TEXT  DEFAULT ''," &
            "jobs_start TEXT  DEFAULT ''," &
            "jobs_end TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("11. Create jobs tables success.")
            Else
                Console.WriteLine("11. Create jobs tables fail.")
            End If

            '11. Create tb_jobs_op
            If create_tables("CREATE TABLE tb_jobs_op (" &
            "jobs_op_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "jobs_id INTEGER  DEFAULT 0," &
            "jobs_op_name TEXT  DEFAULT ''," &
            "jobs_op_no INTEGER  DEFAULT 0" &
            ")") Then
                Console.WriteLine("12. Create jobs op tables success.")
            Else
                Console.WriteLine("12. Create jobs op tables fail.")
            End If

            '12. Create tb_jobs_op_machine
            If create_tables("CREATE TABLE tb_jobs_op_machines (" &
            "jobs_op_machines_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "jobs_op_id TEXT  DEFAULT ''," &
            "machines_id INTEGER  DEFAULT 0," &
            "production INTEGER  DEFAULT 0," &
            "date_start TEXT  DEFAULT ''," &
            "date_end TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("13. Create tb_jobs_op_machine tables success.")
            Else
                Console.WriteLine("13. Create tb_jobs_op_machine tables fail.")
            End If

            '13. Create tb_jobs_op_tools
            If create_tables("CREATE TABLE tb_jobs_op_tools (" &
            "jobs_op_tools_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "jobs_op_id INTEGER  DEFAULT 0," &
            "jobs_op_tools_name TEXT  DEFAULT ''," &
            "jobs_op_tools_drawing TEXT  DEFAULT ''," &
            "jobs_op_tools_no INTEGER  DEFAULT 0" &
            ")") Then
                Console.WriteLine("14. Create jobs_op_tools tables success.")
            Else
                Console.WriteLine("14. Create jobs_op_tools tables fail.")
            End If

            '14. Create tb_jobs_op_tools_use
            If create_tables("CREATE TABLE tb_jobs_op_tools_use (" &
            "jobs_op_tools_use_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "jobs_op_tools_id INTEGER  DEFAULT 0 ," &
            "toollife INTEGER  DEFAULT 0 ," &
            "jobs_op_tools_use_inactive TEXT DEFAULT 'Active' ," &
            "jobs_op_tools_use_min INTEGER  DEFAULT 0 ," &
            "jobs_op_tools_use_max INTEGER  DEFAULT 0 ," &
            "jobs_op_tools_use_reorder INTEGER  DEFAULT 0 ," &
            "products_id INTEGER  DEFAULT 0" &
            ")") Then
                Console.WriteLine("15. Create tb_jobs_op_tools_use tables success.")
            Else
                Console.WriteLine("15. Create tb_jobs_op_tools_use tables fail.")
            End If


            '16. Create tb_stock_log
            If create_tables("CREATE TABLE tb_stock_log (" &
            "stock_log_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "how2buy_id INTEGER  DEFAULT 0," &
            "stock_type TEXT  DEFAULT ''," &
            "jobs_id INTEGER  DEFAULT 0, " &
            "machines_id INTEGER  DEFAULT 0," &
            "jobs_op_id INTEGER  DEFAULT 0," &
            "jobs_op_tools_id INTEGER  DEFAULT 0," &
            "return_id	INTEGER DEFAULT 0," &
            "stock_qty INTEGER  DEFAULT 0," &
            "stock_price REAL  DEFAULT 0," &
            "event_date TEXT  DEFAULT ''," &
            "updateby TEXT  DEFAULT ''," &
            "stock_remark TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("16. Create tb_stock_log tables success.")
            Else
                Console.WriteLine("16. Create tb_stock_log tables fail.")
            End If


            '17. Create tb_records
            If create_tables("CREATE TABLE tb_records (" &
            "records_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "records_date TEXT  DEFAULT ''," &
            "stock_log_id INTEGER  DEFAULT 0," &
            "records_toollife INTEGER  DEFAULT 0" &
            ")") Then
                Console.WriteLine("17. Create tb_records tables success.")
            Else
                Console.WriteLine("17. Create tb_records tables fail.")
            End If




            '19. Create tb_incident
            If create_tables("CREATE TABLE tb_incident (" &
            "incident_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "jobs_id INTEGER  DEFAULT 0," &
            "jobs_op_id INTEGER  DEFAULT 0," &
            "machines_id INTEGER  DEFAULT 0," &
            "jobs_op_tools_id INTEGER  DEFAULT 0," &
            "products_id INTEGER  DEFAULT 0," &
            "shift TEXT  DEFAULT ''," &
            "incident_type_id INTEGER," &
            "incident_subject TEXT  DEFAULT ''," &
            "incident_user TEXT  DEFAULT ''," &
            "incident_time TEXT  DEFAULT ''," &
            "incident_detail TEXT  DEFAULT ''," &
            "incident_cost REAL DEFAULT 0," &
            "incident_action TEXT  DEFAULT ''," &
            "incident_image TEXT  DEFAULT ''," &
            "incident_tl_target	REAL DEFAULT 0, " &
            "incident_tl_actual	REAL DEFAULT 0," &
            "incident_image_tool TEXT DEFAULT ''" &
            ")") Then
                Console.WriteLine("19. Create tb_incident tables success.")
            Else
                Console.WriteLine("19. Create tb_incident tables fail.")
            End If

            '20. Create tb_incident_type
            If create_tables("CREATE TABLE tb_incident_type (" &
            "incident_type_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "incident_type_name TEXT  DEFAULT ''," &
            "incident_type_detail TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("20. Create incident type tables success.")
            Else
                Console.WriteLine("20. Create incident type tables fail.")
            End If

            '21. Create tb_stock_layout
            If create_tables("CREATE TABLE tb_stock_layouts (" &
            "stock_layouts_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "stock_layouts_x TEXT  DEFAULT ''," &
            "stock_layouts_y TEXT  DEFAULT ''," &
            "stock_layouts_z TEXT  DEFAULT ''," &
            "stock_layouts_use TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("21. Create stock layout tables success.")
            Else
                Console.WriteLine("21. Create stock layout tables fail.")
            End If

            '22. Create tb_productions
            If create_tables("CREATE TABLE tb_productions (" &
            "productions_id INTEGER PRIMARY KEY AUTOINCREMENT," &
            "productions_jobs_id TEXT  DEFAULT ''," &
            "productions_month INTEGER  DEFAULT 0," &
            "productions_year INTEGER  DEFAULT 0," &
            "productions_plan_qty INTEGER  DEFAULT 0," &
            "productions_qty INTEGER  DEFAULT 0," &
            "productions_remark TEXT  DEFAULT ''" &
            ")") Then
                Console.WriteLine("21. Create stock layout tables success.")
            Else
                Console.WriteLine("21. Create stock layout tables fail.")
            End If

            '23. Create tb_order
            If create_tables("CREATE TABLE tb_order ( " &
                "order_id	INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "order_date  TEXT DEFAULT '', " &
                "order_send  TEXT DEFAULT '', " &
                "order_remark	TEXT DEFAULT '', " &
                "order_by    INTEGER DEFAULT 0 " &
            ");") Then
                Console.WriteLine("23. Create order tables success.")
            Else
                Console.WriteLine("23. Create order tables fail.")
            End If

            '24. Create tb_productions
            If create_tables("CREATE TABLE tb_order_list (  " &
                "order_list_id	INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "order_id	INTEGER DEFAULT 0, " &
                "products_id	INTEGER DEFAULT 0, " &
                "order_qty_balance	INTEGER DEFAULT 0, " &
                "order_qty_on	INTEGER DEFAULT 0, " &
                "order_qty	INTEGER DEFAULT 0, " &
                "order_recieve	INTEGER DEFAULT 0 " &
            ");") Then
                Console.WriteLine("24. Create order list tables success.")
            Else
                Console.WriteLine("24. Create order list tables fail.")
            End If



            '25. Create tb_log
            If create_tables("CREATE TABLE tb_log (  " &
                "log_id	INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "log_date TEXT DEFAULT '', " &
                "log_page TEXT DEFAULT '', " &
                "log_type TEXT DEFAULT '', " &
                "log_remark	TEXT DEFAULT '', " &
                "actionby	INTEGER DEFAULT 0 " &
            ");") Then
                Console.WriteLine("25. Create log tables success.")
            Else
                Console.WriteLine("25. Create log tables fail.")
            End If


            '26. Create tb_success
            If create_tables("CREATE TABLE tb_success (  " &
                "success_id	INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "success_date TEXT DEFAULT '', " &
                "success_name TEXT DEFAULT '', " &
                "success_type TEXT DEFAULT '', " &
                "success_brand TEXT DEFAULT '', " &
                "success_partname TEXT DEFAULT '', " &
                "success_material TEXT DEFAULT '', " &
                "success_result TEXT DEFAULT '', " &
                "success_detail TEXT DEFAULT '', " &
                "success_image TEXT DEFAULT '' " &
            ");") Then
                Console.WriteLine("26. Create success tables success.")
            Else
                Console.WriteLine("26. Create success tables fail.")
            End If


            '27. Create tb_return
            If create_tables("CREATE TABLE tb_return ( " &
                "return_id	INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "return_date  TEXT DEFAULT '', " &
                "return_remark  TEXT DEFAULT '', " &
                "return_send  TEXT DEFAULT '', " &
                "return_by    TEXT DEFAULT '' " &
            ");") Then
                Console.WriteLine("27. Create return tables success.")
            Else
                Console.WriteLine("27. Create return tables fail.")
            End If

            '28. Create tb_machine_brand
            If create_tables("CREATE TABLE tb_machines_brand ( " &
                "machines_brand_name  TEXT DEFAULT '', " &
                "PRIMARY KEY(machines_brand_name)  " &
            ");") Then
                Console.WriteLine("28. Create machine brand tables success.")
            Else
                Console.WriteLine("28. Create machine brand tables fail.")
            End If

            '29. Create tb_machine_model
            If create_tables("CREATE TABLE tb_machines_model ( " &
                "machines_model_name  TEXT DEFAULT '', " &
                "machines_brand_name  TEXT DEFAULT '',  " &
                "PRIMARY KEY(machines_model_name)  " &
            ");") Then
                Console.WriteLine("29. Create machine model tables success.")
            Else
                Console.WriteLine("29. Create machine model tables fail.")
            End If


            '30. Create tb_machine_type
            If create_tables("CREATE TABLE tb_machines_type ( " &
                "machines_type_name  TEXT DEFAULT '', " &
                "PRIMARY KEY(machines_type_name)  " &
            ");") Then
                Console.WriteLine("30. Create machine model tables success.")
            Else
                Console.WriteLine("30. Create machine model tables fail.")
            End If

            '30. Create tb_machine_spindle
            If create_tables("CREATE TABLE tb_machines_spindle ( " &
                "machines_spindle_name  TEXT DEFAULT '', " &
                "PRIMARY KEY(machines_spindle_name)  " &
            ");") Then
                Console.WriteLine("31. Create machine spindle tables success.")
            Else
                Console.WriteLine("31. Create machine spindle tables fail.")
            End If


            Dim config As New ConfigDatabase(Path.GetDirectoryName(sourceFile), Path.GetFileName(sourceFile))




            'Insert user default
            Dim admin As New Dictionary(Of String, String)
            admin.Add("user_name", "Administators")
            admin.Add("user_lastname", "Team")
            admin.Add("user_tel", "0986959369")
            admin.Add("user_email", "santisook.d@revelsoft.co.th")
            admin.Add("user_username", "admin")
            admin.Add("user_password", "default")
            admin.Add("user_type_id", "1")
            admin.Add("user_image", "")

            If config.Insert("tb_user", admin) Then
                Console.WriteLine("Insert user default success.")
            Else
                Console.WriteLine("Insert user default fail.")
            End If


            'Insert user type default
            Dim user_type As New Dictionary(Of String, String)
            user_type.Add("user_type_name", "Admin")
            user_type.Add("user_type_license1", "1")
            user_type.Add("user_type_license2", "1")
            user_type.Add("user_type_license3", "1")
            user_type.Add("user_type_license4", "1")
            user_type.Add("user_type_license5", "1")
            user_type.Add("user_type_license6", "1")
            user_type.Add("user_type_license7", "1")
            user_type.Add("user_type_license8", "1")
            user_type.Add("user_type_license9", "1")
            user_type.Add("user_type_license10", "1")
            user_type.Add("user_type_license11", "1")
            user_type.Add("user_type_license12", "1")
            user_type.Add("user_type_license13", "1")
            user_type.Add("user_type_license14", "1")
            user_type.Add("user_type_license15", "1")
            user_type.Add("user_type_license16", "1")
            If config.Insert("tb_user_type", user_type) Then
                Console.WriteLine("Insert user type default success.")
            Else
                Console.WriteLine("Insert user type default fail.")
            End If


            'Insert products group default ------------------------------------------------------------------------------------------------
            Dim products_group As New Dictionary(Of String, String)
            products_group.Add("products_group_name", "Any")
            If config.Insert("tb_products_group", products_group) Then
                Console.WriteLine("Insert products group default success.")
            Else
                Console.WriteLine("Insert products group default fail.")
            End If


            products_group = New Dictionary(Of String, String)
            products_group.Add("products_group_name", "Durable")
            If config.Insert("tb_products_group", products_group) Then
                Console.WriteLine("Insert products group Durable success.")
            Else
                Console.WriteLine("Insert products group Durable fail.")
            End If


            products_group = New Dictionary(Of String, String)
            products_group.Add("products_group_name", "Consumable")
            If config.Insert("tb_products_group", products_group) Then
                Console.WriteLine("Insert products group Consumable success.")
            Else
                Console.WriteLine("Insert products group Consumable fail.")
            End If


            products_group = New Dictionary(Of String, String)
            products_group.Add("products_group_name", "Spare part")
            If config.Insert("tb_products_group", products_group) Then
                Console.WriteLine("Insert products group Spare part success.")
            Else
                Console.WriteLine("Insert products group Spare part fail.")
            End If

            '-----------------------------------------------------------------------------------------------------------------------------





            'Insert products type default ------------------------------------------------------------------------------------------------
            Dim products_type As New Dictionary(Of String, String)
                products_type.Add("products_group_id", "1")
                products_type.Add("products_type_name", "Any")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type default success.")
            Else
                Console.WriteLine("Insert products type default fail.")
            End If

            products_type = New Dictionary(Of String, String)
            products_type.Add("products_group_id", "2")
            products_type.Add("products_type_name", "Holder")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type Holder success.")
            Else
                Console.WriteLine("Insert products type Holder fail.")
            End If


            products_type = New Dictionary(Of String, String)
            products_type.Add("products_group_id", "2")
            products_type.Add("products_type_name", "Arbor")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type Arbor success.")
            Else
                Console.WriteLine("Insert products type Arbor fail.")
            End If

            products_type = New Dictionary(Of String, String)
            products_type.Add("products_group_id", "3")
            products_type.Add("products_type_name", "Insert")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type Insert success.")
            Else
                Console.WriteLine("Insert products type Insert fail.")
            End If



            products_type = New Dictionary(Of String, String)
            products_type.Add("products_group_id", "4")
            products_type.Add("products_type_name", "Screw")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type Screw success.")
            Else
                Console.WriteLine("Insert products type Screw fail.")
            End If

            products_type = New Dictionary(Of String, String)
            products_type.Add("products_group_id", "4")
            products_type.Add("products_type_name", "Clamp")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type Clamp success.")
            Else
                Console.WriteLine("Insert products type Clamp fail.")
            End If

            products_type = New Dictionary(Of String, String)
            products_type.Add("products_group_id", "4")
            products_type.Add("products_type_name", "Support Base")
            If config.Insert("tb_products_type", products_type) Then
                Console.WriteLine("Insert products type Support Base success.")
            Else
                Console.WriteLine("Insert products type Support Base fail.")
            End If







            'Insert products brand default
            Dim products_brand As New Dictionary(Of String, String)
                products_brand.Add("products_brand_name", "Any")
            If config.Insert("tb_products_brand", products_brand) Then
                Console.WriteLine("Insert products brand default success.")
            Else
                Console.WriteLine("Insert products brand default fail.")
            End If




            'Insert incident type default ----------------------------------------------------------------------------------------------------
            Dim incident_type As New Dictionary(Of String, String)
                incident_type.Add("incident_type_name", "Any")
            If config.Insert("tb_incident_type", incident_type) Then
                Console.WriteLine("Insert incident type default success.")
            Else
                Console.WriteLine("Insert incident type default fail.")
            End If

            incident_type = New Dictionary(Of String, String)
            incident_type.Add("incident_type_name", "Machine")
            If config.Insert("tb_incident_type", incident_type) Then
                Console.WriteLine("Insert incident type Machine success.")
            Else
                Console.WriteLine("Insert incident type Machine fail.")
            End If

            incident_type = New Dictionary(Of String, String)
            incident_type.Add("incident_type_name", "Operator")
            If config.Insert("tb_incident_type", incident_type) Then
                Console.WriteLine("Insert incident type Operator success.")
            Else
                Console.WriteLine("Insert incident type Operator fail.")
            End If

            incident_type = New Dictionary(Of String, String)
            incident_type.Add("incident_type_name", "Tooling")
            If config.Insert("tb_incident_type", incident_type) Then
                Console.WriteLine("Insert incident type Tooling success.")
            Else
                Console.WriteLine("Insert incident type Tooling fail.")
            End If

            incident_type = New Dictionary(Of String, String)
            incident_type.Add("incident_type_name", "Coolant")
            If config.Insert("tb_incident_type", incident_type) Then
                Console.WriteLine("Insert incident type Coolant success.")
            Else
                Console.WriteLine("Insert incident type Coolant fail.")
            End If
            '-----------------------------------------------------------------------------------------------------------------------------------

            Dim k As Int16 = 0
            For i As Int16 = 1 To 26
                For j As Int16 = 1 To 26
                    'For k As Int16 = 0 To 12
                    Dim tb_stock_layouts = New Dictionary(Of String, String)
                    tb_stock_layouts.Add("stock_layouts_x", i)
                    tb_stock_layouts.Add("stock_layouts_y", j)
                    tb_stock_layouts.Add("stock_layouts_z", k)
                    If i = 1 And j = 1 Then
                        tb_stock_layouts.Add("stock_layouts_use", "1")
                    Else
                        tb_stock_layouts.Add("stock_layouts_use", "0")
                    End If


                    If config.Insert("tb_stock_layouts", tb_stock_layouts) Then
                        Console.WriteLine("Insert tb_stock_layouts data " & i & " - " & j & "(" & k & ") success.")
                    Else
                        Console.WriteLine("Insert tb_stock_layouts data " & i & " - " & j & "(" & k & ") fail.")
                    End If
                    'Next
                Next
            Next
        Else

            End If
    End Sub

    Function create_tables(ByVal createLogTableSQL As String) As Boolean
        Dim cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
        cnn.Open()
        Using sqlTransaction As SQLiteTransaction = cnn.BeginTransaction()
            Dim createCommand As SQLiteCommand = New SQLiteCommand(createLogTableSQL, cnn)
            createCommand.ExecuteNonQuery()
            createCommand.Dispose()
            sqlTransaction.Commit()
            Return True
        End Using
        Return False
    End Function

End Class
