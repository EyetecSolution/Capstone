Imports System.Data.OleDb


Public Class TanodReports
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public id As Integer

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
    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_tanodreport 
                                         SET reporter_name = '" & TxtName.Text & "',
                                              case_type = '" & TxtCaseType.Text & "',
                                              place = '" & TxtLocation.Text & "',
                                              dtime = '" & TxtDayTime.Text & "',
                                              main_subject = '" & TxtMainSubject.Text & "',
                                              involved = '" & TxtInvolved.Text & "',
                                              statement = '" & TxtStatement.Text & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", id)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function InsertQuery() As Task(Of Integer)
        Dim dt As DateTime = DateTime.Now
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_tanodreport(reporter_name, case_type, place, dtime, main_subject, involved, statement) 
                                         VALUES(@reporter_name, @case_type, @place, @dtime, @main_subject, @involved, @statement) ", con)
            mycmd.Parameters.AddWithValue("reporter_name", TxtName.Text)
            mycmd.Parameters.AddWithValue("case_type", TxtCaseType.Text)
            mycmd.Parameters.AddWithValue("place", TxtLocation.Text)
            mycmd.Parameters.AddWithValue("dtime", TxtDayTime.Text)
            mycmd.Parameters.AddWithValue("main_subject", TxtMainSubject.Text)
            mycmd.Parameters.AddWithValue("involved", TxtInvolved.Text)
            mycmd.Parameters.AddWithValue("statement", TxtStatement.Text)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
    Public Sub ResetFields()
        TxtName.ResetText()
        TxtLocation.ResetText()
        TxtInvolved.ResetText()
        TxtDayTime.ResetText()
        TxtCaseType.ResetText()
        TxtMainSubject.ResetText()
        TxtStatement.ResetText()
    End Sub
    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(TxtName.Text) Then
            MessageBox.Show("Name field is required!", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If BtnSave.Text = "SAVE" Then
            Try
                Await InsertQuery()
                MessageBox.Show("Report Successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMe()
                ResetFields()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Report Successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMe()
                BtnSave.Text = "SAVE"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub



    Public Async Sub LoadMe()
        Dim sql As String = "SELECT *
                             FROM tbl_tanodreport"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("reporter_name").HeaderText = "TANOD NAME"
        DataGridView1.Columns("case_type").HeaderText = "URI NG KASO"
        DataGridView1.Columns("place").HeaderText = "LUGAR NG PINANGYARIHAN"
        DataGridView1.Columns("dtime").HeaderText = "ARAW/ORAS NG PANGYAYARI"
        DataGridView1.Columns("main_subject").HeaderText = "PANGYAYARI"
        DataGridView1.Columns("involved").HeaderText = "SANGKOT"
        DataGridView1.Columns("statement").HeaderText = "PAG-KAKAGANAP"
        DataGridView1.Columns("ID").Width = 30
        DataGridView1.Columns("reporter_name").Width = 250
        DataGridView1.Columns("case_type").Width = 200
        DataGridView1.Columns("place").Width = 300
        DataGridView1.Columns("dtime").Width = 200
        DataGridView1.Columns("main_subject").Width = 300
        DataGridView1.Columns("involved").Width = 200
        DataGridView1.Columns("statement").Width = 400
    End Sub
    Private Sub TanodReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMe()
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
                                         FROM tbl_tanodreport
                                         WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = mycmd.ExecuteReader
            If myReader.Read Then
                TxtName.Text = myReader("reporter_name")
                TxtCaseType.Text = myReader("case_type")
                TxtLocation.Text = myReader("place")
                TxtDayTime.Text = myReader("dtime")
                TxtInvolved.Text = myReader("involved")
                TxtStatement.Text = myReader("statement")
                TxtMainSubject.Text = myReader("statement")
            End If
        End Using
    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim sql As String = "SELECT *
                              FROM tbl_tanodreport
                              WHERE reporter_name LIKE '" & TxtSearch.Text & "%'"


        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
    End Sub
End Class