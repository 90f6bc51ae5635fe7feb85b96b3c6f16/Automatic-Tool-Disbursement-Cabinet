Public Class Settings

    Dim panels As New Dictionary(Of String, String)
    Dim envel As New Envelopments

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        My.Settings.working_day = ndWork.Value
        My.Settings.cut_stock_day = ndCutStockDate.Value
        My.Settings.cut_stock_hour = ndCutStockHour.Value
        My.Settings.cut_stock_min = ndCutStockMin.Value

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ndCutStockDate.Value = My.Settings.cut_stock_day
        ndCutStockHour.Value = My.Settings.cut_stock_hour
        ndCutStockMin.Value = My.Settings.cut_stock_min

        ndWork.Value = My.Settings.working_day
    End Sub
End Class