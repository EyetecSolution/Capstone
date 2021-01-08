
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word

Public Class Sample
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt As String = "MMMM"
        MessageBox.Show(DateTimePicker1.Value.ToString("Y"))
    End Sub
End Class