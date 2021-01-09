Imports System.Data.OleDb
Public Class BCHistory


    Public Async Function LoadDataCount(sql As String) As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand(sql, con)
            i = Await mycmd.ExecuteScalarAsync
        End Using
        Return i
    End Function

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Async Sub LoadMe()
        Dim sql As String = "SELECT * 
                             FROM tbl_clearance"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("PURPOSE").Width = 500
        DataGridView1.Columns("DATEISSUED").Width = 200
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("ISSUEDAT").Width = 200
        DataGridView1.Columns("ISSUEDAT").HeaderText = "ISSUED AT"
        DataGridView1.Columns("CTCNO").HeaderText = "CTC. No."
        DataGridView1.Columns("ORNO").HeaderText = "O.R No."
        DataGridView1.Columns("ORNO").HeaderText = "O.R No."



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
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BClearance)
    End Sub

    Private Async Sub BCHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMe()
        Dim sql As String = "SELECT COUNT(*) FROM tbl_clearance"
        LblCount.Text = $"Transaction Count ( {Await LoadDataCount(sql)} )"
    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim sql As String = "SELECT * FROM tbl_clearance
                              WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR
                                    DATEISSUED  LIKE '" & TxtSearch.Text & "%'"

        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub
End Class