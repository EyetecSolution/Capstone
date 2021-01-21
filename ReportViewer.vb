Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class ReportViewer
    Public reportCheck As String

    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Public Sub ReportLoad(dgv As DataGridView, pathName As String, tableLoad As String)

        Dim ds As New DataSet1
        'Add Rows from the datagridview
        Dim row As DataRow
        Dim colcount As Integer = dgv.Columns.Count - 1
        For i As Integer = 0 To dgv.Rows.Count - 1
            row = ds.Tables(tableLoad).Rows.Add
            For Each column As DataGridViewColumn In dgv.Columns
                row.Item(column.Index) = dgv.Rows.Item(i).Cells(column.Index).Value
            Next
        Next


        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = pathName
            .DataSources.Add(New ReportDataSource("DataSet1", ds.Tables(tableLoad)))
        End With

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If reportCheck = "Schedule" Then
            Dim schedParam As New ReportParameter("scheduleDateRange", Schedule.schedRange)
            ReportViewer1.LocalReport.SetParameters(schedParam)
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class