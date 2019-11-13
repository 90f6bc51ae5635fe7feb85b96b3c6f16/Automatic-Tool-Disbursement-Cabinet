
Imports System.IO

Public Class Log
    Dim config As New ConfigDatabase(Path.GetDirectoryName(My.Settings.database_location), Path.GetFileName(My.Settings.database_location))

    Function add(log_date As String, log_page As String, log_type As String, log_remark As String, actionby As String)
        Dim log As New Dictionary(Of String, String)
        log.Add("log_date", log_date)
        log.Add("log_page", log_page)
        log.Add("log_type", log_type)
        log.Add("log_remark", log_remark)
        log.Add("actionby", actionby)

        If config.Insert("tb_log", log) Then
            Return True
        Else
            Return False
        End If
    End Function


    Function update(log_date As String, log_id As String, log_page As String, log_type As String, log_remark As String, actionby As String)
        Dim log As New Dictionary(Of String, String)
        log.Add("log_date", log_date)
        log.Add("log_page", log_page)
        log.Add("log_type", log_type)
        log.Add("log_remark", log_remark)
        log.Add("actionby", actionby)

        If config.Update("tb_log", log, "log_id = '" & log_id & "'") Then
            Return True
        Else
            Return False
        End If
    End Function


    Function delete(log_id As String)

        If config.ExecuteNonQuery("DELETE FROM tb_log WHERE log_id ='" & log_id & "'") Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
