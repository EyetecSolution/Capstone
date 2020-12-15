Imports System.IO

Public Class HomeContent

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ImageSlider1.SlideNext()
    End Sub

    Private Sub ImageSlider1_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles ImageSlider1.ContextButtonClick
        Dim currentBtn As String = e.Item.Name
        Select Case currentBtn
            Case "AddPhotos"
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    Dim mypath As String = FolderBrowserDialog1.SelectedPath
                    Dim filters As String() = {"*.jpg", "*.png"}
                    Dim filePaths As String() = filters.SelectMany(Function(f) Directory.GetFiles(mypath, f)).ToArray()
                    If filePaths.Length > 0 Then
                        ImageSlider1.Images.Clear()
                        For Each fle As String In filePaths
                            ImageSlider1.Images.Add(Image.FromFile(fle))
                        Next
                        MessageBox.Show("Images loaded successfully!", "ims", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("There's something wrong with the directory check if contains of images", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If


        End Select
    End Sub


End Class