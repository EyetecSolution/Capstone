Imports System.Data.OleDb
Public Class OrganActions
    ReadOnly con As New OleDbConnection(My.Settings.strCon)


    Async Function UpdateQuery() As Task(Of Integer)

        Dim arrImage As Byte()
        Dim mstream As New System.IO.MemoryStream
        Dim i As Integer
        Dim textName As String
        If TxtName.Text = "" Then textName = CmbOfficials.SelectedItem Else textName = TxtName.Text
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()

        Dim fileSize As UInt32
        fileSize = mstream.Length
        mstream.Close()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try



            Using mycmd As New OleDbCommand("UPDATE tbl_officials SET fname=@fname,
                                                                      photos=@photos
                                                                  WHERE fname='" & CmbOfficials.SelectedItem & "'", con)
                mycmd.Parameters.AddWithValue("@fname", textName)
                mycmd.Parameters.AddWithValue("@photos", arrImage)

                i = Await mycmd.ExecuteNonQueryAsync
            End Using

        Catch ex As Exception

        End Try
        Return i
    End Function

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbOfficials.KeyPress
        e.Handled = True
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click



        Try
            Await UpdateQuery()
            MessageBox.Show("Updated! Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadNames()
            CmbOfficials.Text = "---Choose Name---"
            TxtName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        OpenFileDialog1.Filter = "File Name | *.jpg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub

    Public Async Function RetrieveData() As Task
        Dim strItem As String = CmbOfficials.SelectedItem
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim arrImage As Byte()

        Using mycmd As New OleDbCommand("SELECT photos
                                         From tbl_officials
                                         WHERE fname = '" & strItem & "'", con)

            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                arrImage = myReader("photos")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                PictureBox1.Image = Image.FromStream(mstream)
            End If
        End Using

    End Function

    Private Sub OrganActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNames()
    End Sub

    Public Sub LoadNames()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter


        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        da = New OleDbDataAdapter("SELECT fname FROM tbl_officials", con)
        da.Fill(dt)

        Dim items = dt.AsEnumerable().Select(Function(d) DirectCast(d(0).ToString(), Object)).ToArray()
        CmbOfficials.Items.Clear()
        CmbOfficials.Items.AddRange(items)
        con.Close()
    End Sub

    Private Async Sub CmbOfficials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOfficials.SelectedIndexChanged
        Await RetrieveData()
    End Sub
End Class