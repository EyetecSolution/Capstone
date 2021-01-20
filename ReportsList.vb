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

    Public Sub LoadReport(sql As String, spath As String)
        ReportViewer.ClearanceReport(sql, spath)
        ReportViewer.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Select Case CmbPurpose.SelectedIndex
            Case 1
                LoadReport("SELECT FULLNAME, FULLADDRESS, PURPOSE, DATEISSUED, CTCNO, ORNO FROM tbl_clearance WHERE paymentstatus = 'Paid' ", "C:\Capstone\Reports\ReportBClearance.rdlc")
            Case 2
                LoadReport("SELECT FULLNAME, FULLADDRESS, BUSINESSNAME, BUSINESSLOCATION, DATEISSUED, CTCNO, ORNO FROM tbl_business", "C:\Capstone\Reports\ReportBusinessClearance.rdlc")
            Case 3
                LoadReport("SELECT FULLNAME, FULLADDRESS, BIRTHDATE, AGE, DATEISSUED, PURPOSE FROM tbl_indigency", "C:\Capstone\Reports\ReportIndigency.rdlc")
            Case 4
                LoadReport("SELECT FULLNAME, FULLADDRESS, DATEISSUED FROM tbl_nonresidency", "C:\Capstone\Reports\ReportNonResidency.rdlc")
            Case 5
                LoadReport("SELECT FULLNAME, FULLADDRESS, DATEISSUED, PURPOSE FROM tbl_residency", "C:\Capstone\Reports\ReportResidency.rdlc")
            Case 6
                LoadReport("SELECT FULLNAME, FULLADDRESS, NOOFCHILDREN, DATEISSUED FROM tbl_soloparent", "C:\Capstone\Reports\ReportSoloParent.rdlc")
            Case 7
                LoadReport("SELECT FULLNAME, FULLADDRESS, NORESIDING, YEARMONTH, DATEISSUED, BIRTHDATE, AGE, WITNESS FROM tbl_oath", "C:\Capstone\Reports\ReportOath.rdlc")
            Case 8
                LoadReport("SELECT FULLNAME, FULLADDRESS, FATHERNAME, MOTHERNAME, FATHEROCCU, MOTHEROCCU, DATEISSUED FROM tbl_spes", "C:\Capstone\Reports\ReportSPES.rdlc")
            Case 9
                LoadReport("SELECT FULLNAME, FULLADDRESS, AGE, SCHOOLYEAR, DATEISSUED FROM tbl_spes1", "C:\Capstone\Reports\ReportSpes1.rdlc")
        End Select


    End Sub

    Private Sub ReportsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class