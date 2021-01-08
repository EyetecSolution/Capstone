Public Class PrintPreview

    Public checkLoad As String
    Private Sub PrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spire.License.LicenseProvider.SetLicenseKey(My.Resources.strKey)
        Select Case checkLoad
            Case "BClearance"
                LoadBClearance()
        End Select
    End Sub

    Sub LoadBClearance()
        Try
            DocViewer1.LoadFromFile("C:\Capstone\BSITCapstone\Docs\TempClearance.docx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class