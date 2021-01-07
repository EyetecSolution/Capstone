Imports System.Data.OleDb
Public Class CovidCases
    Dim confirmedCat As String = Nothing
    Public id As Integer
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Public Async Function RetrieveData() As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT *
                                         FROM tbl_covid 
                                         WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                AddCases.ID.Text = myReader("ID")
                AddCases.TxtName.Text = myReader("FULLNAME")
                AddCases.TxtAddress.Text = myReader("FULLADDRESS")
                AddCases.CmbGender.Text = myReader("GENDER")
                AddCases.TxtAge.Text = myReader("AGE")
                AddCases.CmbCategory.Text = myReader("CONDITION")
                AddCases.TxtDescription.Text = myReader("SYMPTOMS")
            End If
        End Using

    End Function
    Private Async Sub LoadMe()
        Dim sql As String = "SELECT *
                             FROM tbl_covid"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("ID").Width = 100
        DataGridView1.Columns("ID").HeaderText = "PATIENT #"
        DataGridView1.Columns("FULLNAME").Width = 250
        DataGridView1.Columns("FULLADDRESS").Width = 250
        DataGridView1.Columns("AGE").Width = 70
        DataGridView1.Columns("GENDER").Width = 200
        DataGridView1.Columns("CONDITION").Width = 250
        DataGridView1.Columns("SYMPTOMS").Width = 250




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
    Private Sub CovidCases_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CmbCategory.Items.Count > 0 Then
            CmbCategory.SelectedIndex = 0
        End If
        LoadMe()

    End Sub

    Private Async Sub CmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategory.SelectedIndexChanged
        Dim index As Integer = CmbCategory.SelectedIndex

        Select Case index
            Case 0
                confirmedCat = "PUM(CLEAR)"
            Case 1
                confirmedCat = "PUM(ONGOING)"
            Case 2
                confirmedCat = "PUI"
            Case 3
                confirmedCat = "DEATH"
            Case 4
                confirmedCat = "RECOVERED"
            Case 5
                confirmedCat = "CONFIRMED"
        End Select

        Dim sql As String = "SELECT * FROM tbl_covid
                             WHERE CONDITION LIKE '" & confirmedCat & "'"


        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub

    Private Sub CmbCategory_Click(sender As Object, e As EventArgs) Handles CmbCategory.Click
        If CmbCategory.Text = "Choose Category" Then
            CmbCategory.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(AddCases)
    End Sub

    Private Async Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells("ID").Value
            Await RetrieveData()
            AddCases.BtnSave.Text = "UPDATE"
            Dashboard.activefrm.Close()
            Dashboard.OpenFormChild(AddCases)

        ElseIf colName = "delete" Then
            'Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            'id = row.Cells("ID").Value
            'Dim msg = MessageBox.Show($"Are you sure do you want to permanently remove Patient #{row.Cells("ID").Value}", "Action Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'If msg = vbYes Then
            '    MessageBox.Show("Delete")
            'End If

        End If
    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim sql As String = "SELECT * FROM tbl_covid
                             WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' AND CONDITION LIKE '" & confirmedCat & "'"


        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub
End Class