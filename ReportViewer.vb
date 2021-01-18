Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportViewer
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Public Sub ClearanceReport(sqlQuery As String, pathname As String)
        Dim dt As New DataTable
        Using cmd As New OleDbCommand(sqlQuery, con)
            Using da As New OleDbDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
            End Using
        End Using
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = pathname
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class