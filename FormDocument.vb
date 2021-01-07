Public Class FormDocument
    Sub addSpaces()
        Btn1.Text = "BARANGAY                        CLEARANCE"
        Btn3.Text = "CERTIFICATE                              OF INDIGENCY"
        Btn4.Text = "CERTIFICATE                              OF RESIDENCY"
        Btn5.Text = "CERTIFICATE                              OF NON RESIDENCY"
        Btn6.Text = "CERTIFICATE                              OF SOLO PARENT"
        Btn7.Text = "SPES                                             (For School Youth)"
        Btn8.Text = "SPES                                             (For Out of School Youth)"
        Btn9.Text = "OATH                                          OF UNDERTAKING"
    End Sub
    Sub removeSpace()
        Btn1.Text = "BARANGAY               CLEARANCE"
        Btn3.Text = "CERTIFICATE                       OF INDIGENCY"
        Btn4.Text = "CERTIFICATE                   OF RESIDENCY"
        Btn5.Text = "CERTIFICATE OF             NON RESIDENCY"
        Btn6.Text = "CERTIFICATE OF           SOLO PARENT"
        Btn7.Text = "SPES                             (For School Youth)"
        Btn8.Text = "SPES                                     (For Out of School Youth)"
        Btn9.Text = "OATH OF      UNDERTAKING"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub
End Class