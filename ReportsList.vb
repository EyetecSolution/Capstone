Imports System.Data.OleDb
Public Class ReportsList
    Public chkLoad As String
    Private Async Sub LoadDataClearance()
        Dim sql As String = "SELECT *
                             FROM tbl_clearance"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("ISSUEDAT").HeaderText = "ISSUED AT"
        DataGridView1.Columns("CTCNO").HeaderText = "CTC NO."
        DataGridView1.Columns("ORNO").HeaderText = "OR NO."

        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 250
        DataGridView1.Columns("FULLADDRESS").Width = 250
        DataGridView1.Columns("PURPOSE").Width = 400
        DataGridView1.Columns("DATEISSUED").Width = 150
        DataGridView1.Columns("ISSUEDAT").Width = 150
        DataGridView1.Columns("CTCNO").Width = 100
        DataGridView1.Columns("ORNO").Width = 100
        DataGridView1.Columns("VALIDITY").Width = 150
        DataGridView1.Columns("FEES").Width = 100

    End Sub





    Public Function LoadDataTable(sql As String) As DataTable
        Dim dt = New DataTable
        Try
            Using dbcon As New OleDbConnection(My.Settings.strCon)
                Using cmd As New OleDbCommand(sql, dbcon)
                    dbcon.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
                dbcon.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function
    Private Sub ListOfBarangayClearanceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LoadDataClearance()
        chkLoad = "BarangayC"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Select Case chkLoad
            Case "BarangayC"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, PURPOSE, DATEISSUED, CTCNO, ORNO, FEES FROM tbl_clearance"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\Report1.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "businessc"
                Dim sql As String = "SELECT FULLNAME, BUSINESSNAME, BUSINESSLOCATION, DATEISSUED, CTCNO, ORNO, AMOUNT FROM tbl_business"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepBusiness.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "indigency"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, BIRTHDATE, AGE, DATEISSUED, PURPOSE FROM tbl_indigency"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepIndigency.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "residency"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, PURPOSE, DATEISSUED, FEES FROM tbl_residency"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepResidency.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "non-residency"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, DATEISSUED, FEES FROM tbl_nonresidency"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepNonResidency.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "soloparent"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, NOOFCHILDREN, DATEISSUED, FEES FROM tbl_soloparent"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepSoloParent.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "OATH"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, NORESIDING, YEARMONTH, DATEISSUED, BIRTHDATE, AGE, WITNESS FROM tbl_oath"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepOATH.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "spes"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, FATHERNAME, MOTHERNAME, DATEISSUED, FATHEROCCU, MOTHEROCCU FROM tbl_spes"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepSpes.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "spes1"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, AGE, SCHOOLYEAR, DATEISSUED FROM tbl_spes1"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepSpes1.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
            Case "residents"
                Dim sql As String = "SELECT FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION FROM tbl_residents"
                Dim pathname As String = "C:\Capstone\BSITCapstone\Reports\RepResidents.rdlc"
                ReportViewer.ClearanceReport(sql, pathname)
                ReportViewer.Show()
        End Select
    End Sub

    Private Sub ReportsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class