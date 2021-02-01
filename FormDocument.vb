Public Class FormDocument

    Sub AddSpaces()
        Btn1.Text = "BARANGAY                        CLEARANCE"
        Btn3.Text = "CERTIFICATE                                                       OF INDIGENCY"
        Btn4.Text = "CERTIFICATE                                                       OF RESIDENCY"
        Btn5.Text = "CERTIFICATE                                                       OF NON RESIDENCY"
        Btn6.Text = "CERTIFICATE                                                       OF SOLO PARENT"
        Btn7.Text = "SPES                                                              (School Youth)"
        Btn8.Text = "SPES                                                   (Out of School Youth)"
        Btn9.Text = "OATH                                                   OF UNDERTAKING/         CERTIFICATION"
    End Sub
    Sub RemoveSpace()
        Btn1.Text = "BARANGAY                   CLEARANCE"
        Btn3.Text = "CERTIFICATE                                 OF INDIGENCY"
        Btn4.Text = "CERTIFICATE                              OF RESIDENCY"
        Btn5.Text = "CERTIFICATE                              OF NON RESIDENCY"
        Btn6.Text = "CERTIFICATE                              OF SOLO PARENT"
        Btn7.Text = "SPES                                     (School Youth)"
        Btn8.Text = "SPES                                     (Out of School Youth)"
        Btn9.Text = "OATH                                          OF UNDERTAKING/         CERTIFICATION"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        BCHistory.catTitle = "Barangay Clearance"
        BCHistory.LblTitle.Text = "LIST OF BARANGAY CLEARANCE CLAIMED"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)



    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        BCHistory.catTitle = "indigency"
        BCHistory.LblTitle.Text = "LIST OF BARANGAY INDIGENCY CLAIMED"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)


    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        BCHistory.LblTitle.Text = "LIST OF CERTIFICATE OF RESIDENCY CLAIMED"
        BCHistory.catTitle = "residency"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)

    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        BCHistory.catTitle = "non-residency"
        BCHistory.LblTitle.Text = "LIST OF CERTIFICATE OF NON-RESIDENCY CLAIMED"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)


    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        BCHistory.LblTitle.Text = "LIST OF CERTIFICATE OF SOLO PARENT CLAIMED"
        BCHistory.catTitle = "solo-parent"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)

    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        BCHistory.LblTitle.Text = "LIST OF CERTIFICATE OF SPES(for school youth) CLAIMED"
        BCHistory.catTitle = "SPES"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)

    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        BCHistory.LblTitle.Text = "LIST OF CERTIFICATE OF SPES(for out of school youth) CLAIMED"
        BCHistory.catTitle = "SPES1"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)

    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        BCHistory.LblTitle.Text = "LIST OF CERTIFICATE OF OATH UNDERTAKING/CERTIFICATION CLAIMED"
        BCHistory.catTitle = "OATH"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        BCHistory.LblTitle.Text = "LIST OF BUSINESS CLEARANCE CLAIMED"
        BCHistory.catTitle = "businessc"
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(Payment)
    End Sub

    Private Sub FormDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_MouseHover(sender As Object, e As EventArgs) Handles Btn1.MouseHover
        Btn1.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn1_MouseLeave(sender As Object, e As EventArgs) Handles Btn1.MouseLeave
        Btn1.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn2_MouseHover(sender As Object, e As EventArgs) Handles Btn2.MouseHover
        Btn2.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn2_MouseLeave(sender As Object, e As EventArgs) Handles Btn2.MouseLeave
        Btn2.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn6_MouseHover(sender As Object, e As EventArgs) Handles Btn6.MouseHover
        Btn6.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn6_MouseLeave(sender As Object, e As EventArgs) Handles Btn6.MouseLeave
        Btn6.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn4_MouseHover(sender As Object, e As EventArgs) Handles Btn4.MouseHover
        Btn4.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn4_MouseLeave(sender As Object, e As EventArgs) Handles Btn4.MouseLeave
        Btn4.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn5_MouseHover(sender As Object, e As EventArgs) Handles Btn5.MouseHover
        Btn5.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn5_MouseLeave(sender As Object, e As EventArgs) Handles Btn5.MouseLeave
        Btn5.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn3_MouseHover(sender As Object, e As EventArgs) Handles Btn3.MouseHover
        Btn3.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn3_MouseLeave(sender As Object, e As EventArgs) Handles Btn3.MouseLeave
        Btn3.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn7_MouseHover(sender As Object, e As EventArgs) Handles Btn7.MouseHover
        Btn7.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn7_MouseLeave(sender As Object, e As EventArgs) Handles Btn7.MouseLeave
        Btn7.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn8_MouseHover(sender As Object, e As EventArgs) Handles Btn8.MouseHover
        Btn8.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn8_MouseLeave(sender As Object, e As EventArgs) Handles Btn8.MouseLeave
        Btn8.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Btn9_MouseHover(sender As Object, e As EventArgs) Handles Btn9.MouseHover
        Btn9.ImageSize = New Size(50, 50)
    End Sub

    Private Sub Btn9_MouseLeave(sender As Object, e As EventArgs) Handles Btn9.MouseLeave
        Btn9.ImageSize = New Size(40, 40)
    End Sub
End Class