Public Class PrintPreview

    Public checkLoad As String
    Private Sub PrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spire.License.LicenseProvider.SetLicenseKey(My.Resources.strKey)
        Select Case checkLoad
            Case "BClearance"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempClearance.docx")
            Case "businessc"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempBusinessC.docx")
            Case "Indigency"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempIndigency.docx")
            Case "Residency"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempResidency.docx")
            Case "Non-Residency"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempNonresidency.docx")
            Case "Solo-Parent"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempSoloparent.docx")
            Case "SPES"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempSpes.docx")
            Case "SPES1"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempSpesout.docx")
            Case "OATH"
                LoadDocs("C:\Capstone\BSITCapstone\Docs\TempJobOath.docx")

        End Select
    End Sub

    Sub LoadDocs(sPath As String)
        Try
            DocViewer1.LoadFromFile(sPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class