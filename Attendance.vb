Imports System.Data.OleDb
Public Class Attendance
    ReadOnly con As New OleDbConnection(My.Settings.strCon)


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

    Public Async Sub LoadMe()
        Dim dt As DateTime = DateAndTime.Now
        LblDate.Text = $"DATE: {dt:MMMM, d yyyy}"
        Dim sql As String = "SELECT pstion, fname, tmein, tmeout
                             FROM tbl_attendance WHERE dt = #" & dt.ToString("M/d/yyyy") & "#"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("pstion").HeaderText = "POSITION"
        DataGridView1.Columns("fname").HeaderText = "EMPLOYEE"
        DataGridView1.Columns("tmein").HeaderText = "TIME IN"
        DataGridView1.Columns("tmeout").HeaderText = "TIME OUT"

        DataGridView1.Columns("pstion").Width = 300
        DataGridView1.Columns("fname").Width = 300
        DataGridView1.Columns("tmein").Width = 100
        DataGridView1.Columns("tmeout").Width = 100
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMe()
    End Sub
End Class