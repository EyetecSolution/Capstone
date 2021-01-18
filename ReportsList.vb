Imports System.Data.OleDb
Public Class ReportsList

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
    Private Sub ListOfBarangayClearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfBarangayClearanceToolStripMenuItem.Click
        LoadDataClearance()
        LblTitle.Text = "LIST OF BARANGAY CLEARANCE"
    End Sub
End Class