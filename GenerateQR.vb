Imports QRCoder
Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure
Imports MessagingToolkit.QRCode.Codec
Public Class GenerateQR
    Dim Reader As QRCodeDecoder
    Dim Cap As New Capture

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BtnQR.Click

        If BtnQR.Text = "SAVE" Then
            If TxtName.Text = "" Or CmbPurpose.Text = "SELECT POSITION" Then
                MessageBox.Show("Nothing Data will be added please fill the required fields!", "Generate Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                SaveFileDialog1.ShowDialog()
            End If
        Else
            Scanner()
        End If
    End Sub

    Sub Scanner()
        Timer1.Enabled = True
        Try
            Reader = New QRCodeDecoder
            TxtName.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MessageBox.Show("QRCode Detected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Scan Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(TxtName.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        Dim str As String = CmbPurpose.Text & ", " & TxtName.Text
        Try
            PictureBox1.Image = code.GetGraphic(6)
            SaveFileDialog1.FileName = TxtName.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            PictureBox1.Image = Cap.QueryFrame.ToBitmap()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class