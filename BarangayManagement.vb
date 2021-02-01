Public Class BarangayManagement
    Private Sub BarangayManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblMissionn.Text = "Increase the quality of life of the citizens and maintain a harmonious and peaceful community."
        LblMisyon.Text = "Mapataas ang antas ng pamumuhay ng mga mamamayan at mapanatili ang isang maayos at tahimik na pamayanan."
        LblVision.Text = "A peaceful community with faithful and God-fearing citizens, obeying the laws implemented by the authority, trusting and believing in the power of unity and protecting the environment."
        LblPananaw.Text = "Magkaroon ng isang mapayapang pamayanan na ang pangunahing sandata ay ang pananalig at takot sa Diyos, Sumunod sa mga batas na pinatutupad ng mga may kapangyarihan, nagtitiwala sa lakas ng pagkakaisa at kumakalinga sa kalikasan."
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Organizational)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(HealthMonitoring)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(TanodReports)
    End Sub

    Private Sub Btn1_Click_1(sender As Object, e As EventArgs) Handles Btn1.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Schedule)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Honorarium)
    End Sub

    Private Sub Guna2HtmlLabel12_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel12.Click

    End Sub

    Private Sub Btn1_MouseHover(sender As Object, e As EventArgs) Handles Btn1.MouseHover
        Btn1.ImageSize = New Size(47, 47)
    End Sub

    Private Sub Btn1_MouseLeave(sender As Object, e As EventArgs) Handles Btn1.MouseLeave
        Btn1.ImageSize = New Size(35, 35)
    End Sub

    Private Sub Guna2Button2_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button2.MouseHover
        Guna2Button2.ImageSize = New Size(47, 47)
    End Sub

    Private Sub Guna2Button2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button2.MouseLeave
        Guna2Button2.ImageSize = New Size(35, 35)
    End Sub

    Private Sub Guna2Button3_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button3.MouseHover
        Guna2Button3.ImageSize = New Size(47, 47)
    End Sub

    Private Sub Guna2Button3_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button3.MouseLeave
        Guna2Button3.ImageSize = New Size(35, 35)
    End Sub

    Private Sub Guna2Button4_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button4.MouseHover
        Guna2Button4.ImageSize = New Size(47, 47)
    End Sub

    Private Sub Guna2Button4_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button4.MouseLeave
        Guna2Button4.ImageSize = New Size(35, 35)
    End Sub

    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button1.MouseHover
        Guna2Button1.ImageSize = New Size(47, 47)
    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave
        Guna2Button1.ImageSize = New Size(37, 37)
    End Sub
End Class