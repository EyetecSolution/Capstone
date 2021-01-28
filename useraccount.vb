Imports System.Data.OleDb
Public Class useraccount
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public id As Integer

    Async Function DeleteQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("DELETE FROM tbl_users WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", id)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
    Async Function UserExist() As Task(Of Integer)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tbl_users WHERE username = '" & TxtUser.Text & "'", con)

            Dim count As Integer = Await cmd.ExecuteScalarAsync
            Return count
        End Using
    End Function
    Async Function InsertQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_users(username,userpass) VALUES(@username, @userpass)", con)
            mycmd.Parameters.AddWithValue("username", TxtUser.Text)
            mycmd.Parameters.AddWithValue("userpass", TxtPass.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_users  SET username = '" & TxtUser.Text & "', userpass = '" & TxtPass.Text & "' WHERE ID=@ID", con)
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
        Dim sql As String = "SELECT ID, username, userpass FROM tbl_users"

        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("ID").Width = 50
        DataGridView1.Columns("username").Width = 250
        DataGridView1.Columns("userpass").Width = 250
        DataGridView1.Columns("username").HeaderText = "USERNAME"
        DataGridView1.Columns("userpass").HeaderText = "PASSWORD"
        DataGridView1.Columns("edit").DisplayIndex = 4
        DataGridView1.Columns("delete").DisplayIndex = 4

    End Sub

    Private Sub Useraccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMe()

    End Sub

    Private Async Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells("ID").Value
            TxtUser.Text = row.Cells("username").Value
            TxtPass.Text = row.Cells("userpass").Value
            BtnBack.Text = "UPDATE"
        ElseIf colName = "delete" Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells("ID").Value
            Dim msg = MessageBox.Show("Are you sure do you want to permanently remove " & row.Cells("username").Value, "Action Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If msg = vbYes Then
                Try
                    Await DeleteQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    LoadMe()
                End Try


            End If
        End If
        LoadMe()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        BtnBack.Text = "SAVE"
        Clear()
    End Sub

    Sub Clear()
        TxtUser.ResetText()
        TxtPass.ResetText()
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim fileBackupDestination As String = "C:\Capstone\Dbase\IMSDbase" & Format(Now, "yyyy-M-d") & ".mdb"
            Dim databaseFile As String = "C:\Capstone\Dbase\IMSDbase.mdb"
            FileCopy(databaseFile, fileBackupDestination)
            MessageBox.Show("Database backup has been successfully", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            Dim restorefile As String = "C:\Capstone\Dbase\IMSDbase.mdb"
            Dim msgText As String
            OpenFileDialog1.Filter = "Access |*.mdb"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                msgText = "Are you sure you want to restore your database? it will overwrite your database since the backup have made."
                If MessageBox.Show(msgText, "Restore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    FileCopy(OpenFileDialog1.FileName, restorefile)
                    MessageBox.Show("Database has been restore", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async  Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        If String.IsNullOrEmpty(TxtUser.Text) Or String.IsNullOrEmpty(TxtPass.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If BtnBack.Text = "UPDATE" Then
            Try
                Dim i As Integer = Await UpdateQuery()
                MessageBox.Show("Updated Successfully!", "BSIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnBack.Text = "SAVE"
                Clear()
                LoadMe()
            Catch ex As Exception
                MessageBox.Show("Error Occured on Database: " & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Dim i As Integer = Await UserExist()
            If i > 0 Then
                MessageBox.Show("User Already exist please change your username", "User Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUser.ResetText()
                Exit Sub
            End If
            Try
                Await InsertQuery()
                MessageBox.Show("New user added Successfully!", "BSIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnBack.Text = "SAVE"
                Clear()
                LoadMe()
            Catch ex As Exception
                MessageBox.Show("Error Occured on Database: " & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        LoadMe()

    End Sub
End Class