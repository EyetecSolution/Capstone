
Imports MessagingToolkit.QRCode.Codec
Public Class GenQRCODE

    Dim activefrm As Form

    Public Function OpenFormChild(frm As Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Panel4.Controls.Add(frm)
        frm.Show()
        activefrm = frm
        Return activefrm
    End Function

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        activefrm.Close()
        OpenFormChild(GenerateQR)
        GenerateQR.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        activefrm.Close()
        GenerateQR.CmbPurpose.Visible = False
        GenerateQR.Guna2HtmlLabel1.Text = "DETAILS :"
        GenerateQR.BtnQR.Text = "SCAN"
        OpenFormChild(GenerateQR)
        GenerateQR.Timer1.Enabled = True
        GenerateQR.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub GenQRCODE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFormChild(Dummy)
    End Sub
End Class