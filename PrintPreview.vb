Imports System.ComponentModel
Public Class PrintPreview

    Public checkLoad As String
    Private Sub PrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spire.License.LicenseProvider.SetLicenseKey(My.Resources.strKey)
        Select Case checkLoad
            Case "BClearance"
                LoadDocs("C:\Capstone\Docs\TempClearance.docx")
            Case "businessc"
                LoadDocs("C:\Capstone\Docs\TempBusinessC.docx")
            Case "Indigency"
                LoadDocs("C:\Capstone\Docs\TempIndigency.docx")
            Case "Residency"
                LoadDocs("C:\Capstone\Docs\TempResidency.docx")
            Case "Non-Residency"
                LoadDocs("C:\Capstone\Docs\TempNonresidency.docx")
            Case "Solo-Parent"
                LoadDocs("C:\Capstone\Docs\TempSoloparent.docx")
            Case "SPES"
                LoadDocs("C:\Capstone\Docs\TempSpes.docx")
            Case "SPES1"
                LoadDocs("C:\Capstone\Docs\TempSpesout.docx")
            Case "OATH"
                LoadDocs("C:\Capstone\Docs\TempJobOath.docx")
            Case "healthmonitoring"
                LoadDocs("C:\Capstone\Docs\TempHealthMonitoring.docx")


        End Select
    End Sub

    Sub LoadDocs(sPath As String)
        Try
            DocViewer1.LoadFromFile(sPath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintPreview_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dashboard.Show()
    End Sub
End Class