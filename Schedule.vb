Imports System.Data.OleDb
Public Class Schedule
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public id As Integer
    Public Function LoadData(sql As String) As DataTable
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

    Private Async Sub LoadData()
        Dim sql As String = "SELECT *
                             FROM tbl_schedule"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("pstion").HeaderText = "POSITION"
        DataGridView1.Columns("fname").HeaderText = "FULL NAME"
        DataGridView1.Columns("mday").HeaderText = "Monday"
        DataGridView1.Columns("tday").HeaderText = "Tuesday"
        DataGridView1.Columns("wday").HeaderText = "Wedneday"
        DataGridView1.Columns("thday").HeaderText = "Thursday"
        DataGridView1.Columns("fday").HeaderText = "Friday"
        DataGridView1.Columns("satday").HeaderText = "Saturday"
        DataGridView1.Columns("sday").HeaderText = "Sunday"
        DataGridView1.Columns("schedrange").HeaderText = "SCHEDULE RANGE"

        DataGridView1.Columns("pstion").Width = 150
        DataGridView1.Columns("fname").Width = 250
        DataGridView1.Columns("mday").Width = 200
        DataGridView1.Columns("tday").Width = 200
        DataGridView1.Columns("wday").Width = 200
        DataGridView1.Columns("thday").Width = 200
        DataGridView1.Columns("fday").Width = 200
        DataGridView1.Columns("satday").Width = 200
        DataGridView1.Columns("sday").Width = 200
        DataGridView1.Columns("schedrange").Width = 300



    End Sub
    Async Function InsertQuery() As Task(Of Integer)

        Dim i As Integer



        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try


            Using mycmd As New OleDbCommand("INSERT INTO tbl_schedule 
                                         (pstion, fname, mday, tday, wday, thday, fday, satday, sday, schedrange)
                                        VALUES(@pstion, @fname, @mday, @tday, @wday, @thday, @fday, @satday, @sday, @schedrange)", con)
                With mycmd
                    .Parameters.AddWithValue("@pstion", CmbPurpose.SelectedItem)
                    .Parameters.AddWithValue("@fname", TxtName.Text)
                    .Parameters.AddWithValue("@mday", TxtMonday.Text)
                    .Parameters.AddWithValue("@tday", TxtTuesday.Text)
                    .Parameters.AddWithValue("@wday", TxtWednesday.Text)
                    .Parameters.AddWithValue("@thday", TxtThursday.Text)
                    .Parameters.AddWithValue("@fday", TxtFriday.Text)
                    .Parameters.AddWithValue("@satday", TxtSat.Text)
                    .Parameters.AddWithValue("@sday", TxtSunday.Text)
                    .Parameters.AddWithValue("@schedrange", $"{DateTimePicker2.Value:MMMM d yyyy} TO {DateTimePicker1.Value:MMMM d yyyy}")

                    i = Await mycmd.ExecuteNonQueryAsync

                End With

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return i
    End Function
    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_schedule 
                                         SET pstion = '" & CmbPurpose.SelectedItem & "',
                                             fname = '" & TxtName.Text & "',
                                             mday = '" & TxtMonday.Text & "',
                                             tday = '" & TxtTuesday.Text & "',
                                             wday = '" & TxtWednesday.Text & "',
                                             thday = '" & TxtThursday.Text & "',
                                             fday = '" & TxtFriday.Text & "',
                                             satday = '" & TxtSat.Text & "',
                                             sday = '" & TxtSunday.Text & "',
                                             schedrange = '" & DateTimePicker2.Value.ToString("MMMM dd yyyy") & "TO" & DateTimePicker1.Value.ToString("MMMM d yyyy") & "' 
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", id)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
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

    Private Async Sub LoadMe()
        Dim sql As String = "SELECT *
                             FROM tbl_schedule"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("ID").Width = 30
        DataGridView1.Columns("position").Width = 250
        DataGridView1.Columns("fname").Width = 250
        DataGridView1.Columns("position").HeaderText = "POSITION"
        DataGridView1.Columns("fname").HeaderText = "FULL NAME"
    End Sub

    Sub ResetFields()
        CmbPurpose.Text = "SELECT POSITION"
        TxtName.ResetText()
        TxtMonday.ResetText()
        TxtTuesday.ResetText()
        TxtWednesday.ResetText()
        TxtThursday.ResetText()
        TxtFriday.ResetText()
        TxtSat.ResetText()
        TxtSunday.ResetText()
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(TxtName.Text) Or CmbPurpose.Text = "SELECT POSITION" Then
            MessageBox.Show("Name field and position is required!", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If BtnSave.Text = "SAVE" Then
            Try
                Await InsertQuery()
                MessageBox.Show("Scheduling successfully saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetFields()
            Catch ex As Exception

            Finally
                con.Close()

            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Scheduling successfully saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ResetFields()
                BtnSave.Text = "SAVE"
            Catch ex As Exception

            Finally
                con.Close()

            End Try
        End If


    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        BtnSave.Text = "UPDATE"
        Dim index As Integer
        Try

            index = e.RowIndex
            If index = -1 Then
                Exit Sub
            Else
                Dim selectedRow As DataGridViewRow
                selectedRow = DataGridView1.Rows(index)
                id = selectedRow.Cells(0).Value
            End If
        Catch ex As Exception
            Throw ex
        End Try

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If




        Using mycmd As New OleDbCommand("SELECT *
                                         FROM tbl_schedule
                                         WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = mycmd.ExecuteReader
            If myReader.Read Then
                TxtName.Text = myReader("fname")
                CmbPurpose.Text = myReader("pstion")
                TxtMonday.Text = myReader("mday")
                TxtTuesday.Text = myReader("mday")
                TxtWednesday.Text = myReader("wday")
                TxtThursday.Text = myReader("thday")
                TxtFriday.Text = myReader("fday")
                TxtSat.Text = myReader("satday")
                TxtSunday.Text = myReader("sday")

            End If
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Attendance)
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        TxtName.ResetText()
        TxtMonday.ResetText()
        TxtTuesday.ResetText()
        TxtWednesday.ResetText()
        TxtThursday.ResetText()
        TxtFriday.ResetText()
        TxtSat.ResetText()
        TxtSunday.ResetText()
        BtnSave.Text = "SAVE"
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Private Sub TxtTuesday_TextChanged(sender As Object, e As EventArgs) Handles TxtTuesday.TextChanged

    End Sub

    Private Sub TxtFriday_TextChanged(sender As Object, e As EventArgs) Handles TxtFriday.TextChanged

    End Sub
End Class