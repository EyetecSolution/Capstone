Imports System.Data.OleDb
Public Class Organizational
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Public Async Function RetrieveData(btnName As String) As Task
        Dim strItem As String = btnName
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim arrImage As Byte()

        Using mycmd As New OleDbCommand("SELECT photos" &
                                         " From tbl_officials" &
                                         " WHERE fname = '" & strItem & "'", con)

            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                arrImage = myReader("photos")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                PictureBox1.Image = Image.FromStream(mstream)
            End If
        End Using

    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        OrganActions.ShowDialog()
    End Sub
    Private Async Sub Btn9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub Btn10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub Btn11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Organizational_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim btnName As String = Btn1.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim btnName As String = Btn2.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button4_Click_1(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim btnName As String = Btn3.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim btnName As String = Btn4.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Dim btnName As String = Btn5.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim btnName As String = Btn11.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Dim btnName As String = Btn7.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Dim btnName As String = Btn8.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Dim btnName As String = Btn9.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Btn10.Click
        Dim btnName As String = Btn10.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn11.Click
        Dim btnName As String = Btn11.Text
        Await RetrieveData(btnName)
    End Sub

    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button1.MouseHover
        Guna2Button1.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave
        Guna2Button1.ImageSize = New Size(30, 30)

    End Sub

    Private Sub Btn1_MouseHover(sender As Object, e As EventArgs) Handles Btn1.MouseHover

    End Sub

    Private Sub Guna2Button2_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button2.MouseHover
        Guna2Button2.ImageSize = New Size(55, 55)
    End Sub

    Private Sub Guna2Button2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button2.MouseLeave
        Guna2Button2.ImageSize = New Size(45, 45)
    End Sub
End Class