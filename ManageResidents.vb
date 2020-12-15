Imports System.Data.OleDb
Public Class ManageResidents

    Public id As Integer
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Async Sub ManageResidents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sql As String = "SELECT ID, FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION
                             FROM tbl_residents"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        dgv.DataSource = dtsample

    End Sub

    Private Function LoadDataTable(sql As String) As DataTable
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

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim index As Integer
        Try

            index = e.RowIndex
            If index = -1 Then
                Exit Sub
            Else
                Dim selectedRow As DataGridViewRow
                selectedRow = dgv.Rows(index)
                id = selectedRow.Cells(0).Value
            End If
        Catch ex As Exception
            Throw ex
        End Try



    End Sub

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

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        PrintResidentInformation.ShowDialog()

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        AddNewResident.BtnSave.Text = "SAVE"
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(AddNewResident)
    End Sub

    Private Async Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(AddNewResident)

        AddNewResident.BtnSave.Text = "UPDATE"
        Await RetrieveData()
    End Sub

    Private Async Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Dim sql As String = "SELECT ID, FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION
                              FROM tbl_residents
                              WHERE FULLNAME LIKE '" & Guna2TextBox1.Text & "%' OR
                                    FULLADDRESS LIKE '" & Guna2TextBox1.Text & "%'"

        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        dgv.DataSource = dtsample
    End Sub
End Class