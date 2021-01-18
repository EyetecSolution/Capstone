Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportViewer
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport("SELECT FULLNAME, FULLADDRESS, PURPOSE, DATEISSUED, CTCNO, ORNO, FEES FROM tbl_clearance")

    End Sub

    Sub LoadReport(query As String)

        Dim rptDS As New ReportDataSource
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Rerport1.rdlc"
                .DataSources.Clear()
            End With

            'Dim ds As New DataSet1
            Dim da As New OleDbDataAdapter

            con.Open()
            da.SelectCommand = New OleDbCommand(query, con)
            'da.Fill(ds.Tables("TableClearance"))
            'rptDS = New ReportDataSource("DataSet1", ds.Tables("TableClearance"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try


    End Sub






End Class