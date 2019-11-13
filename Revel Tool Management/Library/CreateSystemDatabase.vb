Imports System.Data.SQLite
Imports System.IO
Imports System.Resources

Public Class CreateSystemDatabase
    Protected dbConnection As String

    ' <summary>  
    '     Single Param Constructor for specifying the DB file.  
    ' </summary>  
    ' <param name="inputFile">The File containing the DB</param>  
    Sub New()

        Dim path As String = Application.StartupPath & "\database\"
        Dim str As String = System.IO.Path.Combine(path, "system.db3")
        dbConnection = String.Format("Data Source={0}", str)

        If (Not System.IO.Directory.Exists(path)) Then
            System.IO.Directory.CreateDirectory(path)
        End If

        If Not My.Computer.FileSystem.FileExists(str) Then
            SQLiteConnection.CreateFile(str)
            'Create tb_database
            If create_tables("CREATE TABLE tb_database (" &
                "database_id INTEGER PRIMARY KEY AUTOINCREMENT," &
                "database_name TEXT  NULL," &
                "database_location TEXT  NULL," &
                "database_use INTEGER  NULL" &
                ")") Then

                Dim configSys As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
                Dim p As String = Application.StartupPath & "\database_temp\"

                If (Not System.IO.Directory.Exists(p)) Then
                    System.IO.Directory.CreateDirectory(p)
                End If

                Dim sys As New CreateDatabase(p & "database.db3")
                configSys.ExecuteNonQuery("INSERT INTO tb_database (database_name,database_location,database_use) VALUES ('Default Database','" & p & "database.db3','1')")

                If (Not System.IO.Directory.Exists(p & "\images")) Then
                    System.IO.Directory.CreateDirectory(p & "\images")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\users")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\users")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\tools")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\tools")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\suppliers")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\suppliers")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\machines")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\machines")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\incidents")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\incidents")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\brands")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\brands")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\products")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\products")
                End If


                If (Not System.IO.Directory.Exists(p & "\images\drawing")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\drawing")
                End If

                If (Not System.IO.Directory.Exists(p & "\images\success")) Then
                    System.IO.Directory.CreateDirectory(p & "\images\success")
                End If

                Console.WriteLine("Create database tables success.")
                getDatabase()
            Else
                Console.WriteLine("Create database tables fail.")
            End If
        Else
            getDatabase()
        End If

    End Sub

    Function getDatabase() As Boolean
        Dim config As New ConfigDatabase(Application.StartupPath & "\database\", My.Settings.SystemDB)
        Dim dt As DataTable = config.GetDataTable("SELECT name FROM sqlite_master WHERE type='table'")
        Console.WriteLine(" tables Count : " & dt.Rows.Count)
        Console.WriteLine(" tables : ")
        For Each dr As DataRow In dt.Rows
            Console.WriteLine(dr.Item(0))
        Next

        dt = config.GetDataTable("SELECT * FROM tb_database WHERE database_use ='1'")
        For Each dr As DataRow In dt.Rows
            My.Settings.database_name = dr(1).ToString()
            My.Settings.database_location = dr(2).ToString()
            My.Settings.Save()
        Next
        Return True

    End Function
    Function create_tables(ByVal createLogTableSQL As String) As Boolean
        Dim cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
        Dim result As Boolean = False
        cnn.Open()
        Using sqlTransaction As SQLiteTransaction = cnn.BeginTransaction()
            Dim createCommand As SQLiteCommand = New SQLiteCommand(createLogTableSQL, cnn)
            createCommand.ExecuteNonQuery()
            createCommand.Dispose()
            sqlTransaction.Commit()
            result = True
        End Using
        cnn.Close()
        Return result
    End Function
End Class
