Imports System.Data.OleDb

Public Class residents

    Public id As Integer
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Private Async Sub loadData()
        Dim sql As String = "SELECT ID, FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION
                             FROM tbl_residents"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("BIRTHPLACE").HeaderText = "BIRTH PLACE"
        DataGridView1.Columns("BIRTHDATE").HeaderText = "BIRTH DATE"
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("ID").Width = 30
        DataGridView1.Columns("FULLADDRESS").Width = 400
        DataGridView1.Columns("BIRTHPLACE").Width = 250
        DataGridView1.Columns("AGE").Width = 100
        DataGridView1.Columns("GENDER").Width = 100
        DataGridView1.Columns("CIVILSTATUS").Width = 150
        DataGridView1.Columns("CITIZENSHIP").Width = 150
        DataGridView1.Columns("OCCUPATION").Width = 150
        DataGridView1.Columns("BIRTHDATE").Width = 200




    End Sub

    Public Sub Dgv_rowstyle()
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)

            End If
        Next
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

    Public Async Function RetrieveData() As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim arrImage As Byte()

        Using mycmd As New OleDbCommand("SELECT *
                                         FROM tbl_residents 
                                         WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                AddNewResident.txtid.Text = myReader("ID")
                AddNewResident.TxtName.Text = myReader("FULLNAME")
                AddNewResident.TxtAddress.Text = myReader("FULLADDRESS")
                AddNewResident.TxtBirth.Text = myReader("BIRTHPLACE")
                AddNewResident.TxtBdate.Value = myReader("BIRTHDATE")
                AddNewResident.LabelAge.Text = myReader("AGE")
                AddNewResident.CmbGender.Text = myReader("GENDER")
                AddNewResident.CmbCivilStat.Text = myReader("CIVILSTATUS")
                AddNewResident.TxtCitizen.Text = myReader("CITIZENSHIP")
                AddNewResident.TxtOccupation.Text = myReader("OCCUPATION")
                arrImage = myReader("PHOTO")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                AddNewResident.PictureBox1.Image = Image.FromStream(mstream)
            End If
        End Using

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        AddNewResident.BtnSave.Text = "SAVE"
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(AddNewResident)
    End Sub

    Private Async Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(AddNewResident)

        AddNewResident.BtnSave.Text = "UPDATE"
        AddNewResident.LblHeader2.Text = "UPDATE INFORMATION"
        Await RetrieveData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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

    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim sql As String = "SELECT ID, FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION
                              FROM tbl_residents
                              WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR
                                    FULLADDRESS LIKE '" & TxtSearch.Text & "%'"

        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub

    Private Sub residents_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        Dgv_rowstyle()


    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged
        Dgv_rowstyle()

    End Sub


End Class