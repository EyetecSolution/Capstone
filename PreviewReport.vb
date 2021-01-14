Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class PreviewReport
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Sub PreviewReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
        'LoadReport()

    End Sub


    Sub LoadReport()
        '    Dim rptDS As ReportDataSource
        '    Me.ReportViewer1.RefreshReport()

        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '    End If

        '    Try
        '        With ReportViewer1.LocalReport
        '            .ReportPath = Application.StartupPath & "\Reports\Report1.rdlc"
        '            .DataSources.Clear()
        '        End With

        '        Dim ds As New DataSet1
        '        Dim da As New OleDbDataAdapter

        '        con.Open()
        '        da.SelectCommand = New OleDbCommand("SELECT * FROM tbl_clearance", con)
        '        da.Fill(ds.Tables("bclearance"))
        '        con.Close()
        '        rptDS = New ReportDataSource("DataSet1", ds.Tables("bclearance"))
        '        ReportViewer1.LocalReport.DataSources.Add(rptDS)
        '        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        '        ReportViewer1.ZoomMode = ZoomMode.Percent
        '        ReportViewer1.ZoomPercent = 30

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)

        '    End Try
    End Sub
End Class