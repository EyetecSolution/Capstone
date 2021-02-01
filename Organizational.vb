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
    Private Async Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim btnName As String = Btn1.Text
        Await RetrieveData(btnName)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        OrganActions.ShowDialog()
    End Sub

    Private Async Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim btnName As String = Btn2.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Dim btnName As String = Btn3.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim btnName As String = Btn4.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Dim btnName As String = Btn5.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Dim btnName As String = Btn6.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Dim btnName As String = Btn7.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Dim btnName As String = Btn8.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Dim btnName As String = Btn9.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn10_Click(sender As Object, e As EventArgs) Handles Btn10.Click
        Dim btnName As String = Btn10.Text
        Await RetrieveData(btnName)
    End Sub

    Private Async Sub Btn11_Click(sender As Object, e As EventArgs) Handles Btn11.Click
        Dim btnName As String = Btn11.Text
        Await RetrieveData(btnName)
    End Sub

    Private Sub Organizational_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
    End Sub
End Class