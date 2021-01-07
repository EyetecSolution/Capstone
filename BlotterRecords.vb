Imports System.Data.OleDb
Public Class BlotterRecords
    ReadOnly con As New OleDbConnection(My.Settings.strCon)



    Private Async Sub LoadMe()
        Dim sql As String = "SELECT * FROM tbl_blotter"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("ID").Width = 150
        DataGridView1.Columns("ID").HeaderText = "CASE NO."
        DataGridView1.Columns("FULLNAME").Width = 250
        DataGridView1.Columns("FULLADDRESS").Width = 250
        DataGridView1.Columns("DESCRIPTION").Width = 250
        DataGridView1.Columns("AGE").Width = 150
        DataGridView1.Columns("GENDER").Width = 200
        DataGridView1.Columns("FILINGDATE").Width = 250
        DataGridView1.Columns("SCHEDULE").Width = 350
        DataGridView1.Columns("BYWHOM").Width = 250
        DataGridView1.Columns("print").DisplayIndex = 0


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
    Async Function InsertQuery() As Task(Of Integer)
        Dim i As Integer
        Dim dt As DateTime = Date.Now
        Dim dtfrmat As String = "M/d/yyyy"
        Dim tmefrmat As String = "h:mm tt"
        Dim dt2frmat As String = "MMMM d yyyy"
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_blotter(FULLNAME,FULLADDRESS,DESCRIPTION,AGE,GENDER,FILINGDATE,SCHEDULE,BYWHOM) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @DESCRIPTION, @AGE, @GENDER, @FILINGDATE, @SCHEDULE, @BYWHOM)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("DESCRIPTION", TxtDescription.Text)
            mycmd.Parameters.AddWithValue("AGE", TxtAge.Text)
            mycmd.Parameters.AddWithValue("GENDER", CmbGender.Text)
            mycmd.Parameters.AddWithValue("FILINGDATE", dt.ToString(dtfrmat))
            mycmd.Parameters.AddWithValue("SCHEDULE", $"{DateTimePicker2.Value.ToString(dt2frmat)} {DateTimePicker1.Value.ToString(tmefrmat)} TO {DateTimePicker3.Value.ToString(tmefrmat)}")
            mycmd.Parameters.AddWithValue("BYWHOM", TxtWhom.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BtnSave.Text = "SAVE" Then
            If TxtName.Text = "" Or TxtAddress.Text = "" Or TxtAge.Text = "" Or CmbGender.Text = "" Or TxtWhom.Text = "" Or TxtDescription.Text = "" Then
                MessageBox.Show("Blank field not required")
            Else
                Try
                    Await InsertQuery()
                    MessageBox.Show("Blotter added successfully")
                Catch ex As Exception
                    MessageBox.Show("Error Occured: " & ex.Message)
                End Try


            End If
        End If
    End Sub

    Private Sub BlotterRecords_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMe()

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim sql As String = "SELECT * FROM tbl_blotter
                             WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR SCHEDULE LIKE '" & TxtSearch.Text & "%'"


        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub
End Class