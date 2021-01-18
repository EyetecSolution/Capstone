Public Class BarangayManagement
    Private Sub BarangayManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVision.Text = "To alleviate poverty by providing opportunities for personal growth and the improvement of the standards of living through a natural resource based livelihood and skills training programs;
                          To arrest the continuing environmental degradation gaining prevalence in the Municipality through sustainable methods of farming and providing continuing restoration and protection of natural resources;"
        LblMission.Text = "Baras is a community of peace loving people living in harmony with nature where family is able to provide for its basic needs. It is imbued with a dynamic spirit seeking progress without sacrificing time tested values within a unique culture of its own ever mindful of leaving a legacy of a sustained development led by a consistent, responsible, efficient and committed government leaders who holds as sacred the mandate of its people in the discharge of the functions of public office as a public trust"
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
End Class