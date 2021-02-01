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
    Public dt As DateTime = DateAndTime.Now
    Public Async Sub LoadMe(sql As String)
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("fname").HeaderText = "EMPLOYEE"
        DataGridView1.Columns("TimeIN").HeaderText = "TIME IN"
        DataGridView1.Columns("TimeOut").HeaderText = "TIME OUT"

        'DataGridView1.Columns("fname").Width = 300
        'DataGridView1.Columns("timein").Width = 100
        'DataGridView1.Columns("timeout").Width = 100
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT fname, TimeIN, TimeOut FROM tbl_attendance WHERE dt= #" & dt.ToString("M/d/yyyy") & "#"
        LoadMe(sql)
    End Sub

    Private Sub DTTo_ValueChanged(sender As Object, e As EventArgs) Handles DTTo.ValueChanged
        Dim sql As String = "SELECT fname, TimeIN, TimeOut FROM tbl_attendance WHERE dt= #" & DTTo.Value.ToString("M/d/yyyy") & "#"
        LoadMe(sql)
    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2Button2_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button2.MouseHover
        Guna2Button2.ImageSize = New Size(55, 55)
    End Sub

    Private Sub Guna2Button2_MouseLeave(sender As Object, e As EventArgs)
        Guna2Button2.ImageSize = New Size(45, 45)
    End Sub
End Class