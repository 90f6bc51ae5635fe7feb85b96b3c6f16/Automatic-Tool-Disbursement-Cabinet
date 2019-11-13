Imports System.Data.SQLite
Imports System.IO

Public Class ConfigDatabase
    Protected dbConnection As String

    ' <summary>  
    '     Single Param Constructor for specifying the DB file.  
    ' </summary>  
    ' <param name="inputFile">The File containing the DB</param>  
    Sub New(ByVal DBDirectoryInfo As String, ByVal inputFile As String)
        Dim sourceFile As String = Path.Combine(DBDirectoryInfo, inputFile)
        dbConnection = String.Format("Data Source={0}", sourceFile)
    End Sub


    ' <summary>  
    '     Allows the programmer to run a query against the Database.  
    ' </summary>  
    ' <param name="sql">The SQL to run</param>  
    ' <returns>A DataTable containing the re+sult set.</returns>  
    Function GetDataTable(ByRef sql As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Try
            Dim cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
            cnn.Open()
            Dim mycommand As SQLiteCommand = New SQLiteCommand(cnn)
            mycommand.CommandText = sql
            Dim reader As SQLiteDataReader = mycommand.ExecuteReader()
            dt.Load(reader)
            reader.Close()
            cnn.Close()
        Catch ex As Exception

        End Try
        Return dt
    End Function


    ' <summary>  
    '     Allows the programmer to interact with the database for purposes other than a query.  
    ' </summary>  
    ' <param name="sql">The SQL to be run.</param>  
    ' <returns>An Integer containing the number of rows updated.</returns>  
    Function ExecuteNonQuery(ByVal sql As String) As Integer
        Dim cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
        cnn.Open()
        Dim mycommand As SQLiteCommand = New SQLiteCommand(cnn)
        mycommand.CommandText = sql
        Dim rowsUpdated As Integer = mycommand.ExecuteNonQuery()
        cnn.Close()
        Return rowsUpdated
    End Function


    ' <summary>  
    '     Allows the programmer to retrieve single items from the DB.  
    ' </summary>  
    ' <param name="sql">The query to run.</param>  
    ' <returns>A string.</returns>  
    Function ExecuteScalar(ByVal sql As String) As String
        Dim cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
        cnn.Open()
        Dim mycommand As SQLiteCommand = New SQLiteCommand(cnn)
        mycommand.CommandText = sql
        Dim value As Object = mycommand.ExecuteScalar()
        cnn.Close()
        If (value <> vbNull) Then
            Return value.ToString()
        Else
            Return ""
        End If
    End Function

    ' <summary>  
    '     Allows the programmer to easily update rows in the DB.  
    ' </summary>  
    ' <param name="tableName">The table to update.</param>  
    ' <param name="data">A dictionary containing Column names And their New values.</param>  
    ' <param name="where">The where clause for the update statement.</param>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function Update(ByVal tableName As String, ByVal data As Dictionary(Of String, String), ByVal where As String) As Boolean
        Dim vals As String = ""
        Dim returnCode As Boolean = True
        If (data.Count >= 1) Then
            For Each Val As KeyValuePair(Of String, String) In data
                vals += String.Format(" {0} = '{1}',", Val.Key.ToString(), Val.Value.ToString())
            Next
            vals = vals.Substring(0, vals.Length - 1)
        End If
        Try
            Me.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where))
        Catch ex As Exception
            returnCode = False
            'ServiceLogWriter.LogError(ex) 
        End Try
        Return returnCode

    End Function

    ' <summary>  
    '     Allows the programmer to easily delete rows from the DB.  
    ' </summary>  
    ' <param name="tableName">The table from which to delete.</param>  
    ' <param name="where">The where clause for the delete.</param>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function Delete(ByVal tableName As String, ByVal where As String) As Boolean
        Dim returnCode As Boolean = True
        Try
            Me.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where))
        Catch ex As Exception
            returnCode = False
        End Try
        Return returnCode
    End Function

    ' <summary>  
    '     Allows the programmer to easily insert into the DB  
    ' </summary>  
    ' <param name="tableName">The table into which we insert the data.</param>  
    ' <param name="data">A dictionary containing the column names And data for the insert.</param>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function Insert(ByVal tableName As String, ByVal data As Dictionary(Of String, String)) As Boolean
        Dim columns As String = ""
        Dim values As String = ""
        Dim returnCode As Boolean = True

        For Each Val As KeyValuePair(Of String, String) In data
            columns += String.Format(" {0},", Val.Key.ToString())
            values += String.Format(" '{0}',", Val.Value)
        Next

        columns = columns.Substring(0, columns.Length - 1)
        values = values.Substring(0, values.Length - 1)

        Try
            Me.ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values))
        Catch ex As Exception
            returnCode = False
        End Try
        Return returnCode

    End Function

    ' <summary>  
    '     Allows the programmer to easily delete all data from the DB.  
    ' </summary>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function ClearDB() As Boolean
        Dim tables As New DataTable
        Try
            tables = Me.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;")
            For Each table As DataTable In tables.Rows
                Me.ClearTable(table("NAME").ToString())
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    ' <summary>  
    '     Allows the user to easily clear all data from a specific table.  
    ' </summary>  
    ' <param name="table">The name of the table to clear.</param>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function ClearTable(ByRef table As String) As Boolean
        Try
            Me.ExecuteNonQuery(String.Format("delete from {0};", table))
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    ' <summary>  
    '     Allows the programmer to easily test connect to the DB.  
    ' </summary>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function TestConnection() As Boolean
        Using cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
            Try
                cnn.Open()
                Return True
            Catch ex As Exception
                If cnn.State <> ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try

        End Using
    End Function


    ' <summary>  
    '     Allows the programmer to easily test if table exists in the DB.  
    ' </summary>  
    ' <returns>A boolean true Or false to signify success Or failure.</returns>  
    Function IsTableExists(ByRef tableName As String) As Boolean
        Dim count As String = "0"
        If (dbConnection = "") Then
            Return False
        End If

        Using cnn As SQLiteConnection = New SQLiteConnection(dbConnection)
            Try
                cnn.Open()
                If (tableName = vbNull Or cnn.State <> ConnectionState.Open) Then
                    Return False
                End If
                Dim Sql As String = String.Format("SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND name ='{0}'", tableName)
                count = ExecuteScalar(Sql)
            Catch ex As Exception
                If (cnn.State <> ConnectionState.Open) Then
                    cnn.Close()
                End If
            End Try
            Return Convert.ToInt32(count) > 0
        End Using
    End Function
End Class
