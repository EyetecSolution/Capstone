Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word

Public Class HealthMonitoring
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub



    Private Sub UpdateWordDocs(sPath As String)
        Dim dt As DateTime = DateTime.Now
        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("contact", TxtContact.Text.Trim, wdDoc)
        UpdateBookMark("temp", TxtTemp.Text.Trim, wdDoc)
        UpdateBookMark("q1", Cmb1.SelectedItem, wdDoc)
        UpdateBookMark("q2", Cmb2.SelectedItem, wdDoc)
        UpdateBookMark("q3", Cmb3.SelectedItem, wdDoc)
        UpdateBookMark("q4", Cmb4.SelectedItem, wdDoc)
        UpdateBookMark("q5", Cmb5.SelectedItem, wdDoc)
        UpdateBookMark("q6", Cmb6.SelectedItem, wdDoc)
        UpdateBookMark("q7", Cmb7.SelectedItem, wdDoc)
        UpdateBookMark("q8", Cmb8.SelectedItem, wdDoc)
        UpdateBookMark("date", dt.ToString("MMMM d yyyy"), wdDoc)


        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub
    Async Function InsertQuery() As Task(Of Integer)
        Dim dt As DateTime = DateTime.Now
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_health(fname,faddress, contactno, temp, q1, q2, q3, q4, q5, q6, q7, q8, datefile) 
                                         VALUES(@fname, @faddress, @contactno, @temp, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, datefile )", con)
            mycmd.Parameters.AddWithValue("fname", TxtName.Text)
            mycmd.Parameters.AddWithValue("faddress", TxtName.Text)
            mycmd.Parameters.AddWithValue("contactno", TxtContact.Text)
            mycmd.Parameters.AddWithValue("temp", TxtTemp.Text)
            mycmd.Parameters.AddWithValue("q1", Cmb1.SelectedItem)
            mycmd.Parameters.AddWithValue("q2", Cmb2.SelectedItem)
            mycmd.Parameters.AddWithValue("q3", Cmb3.SelectedItem)
            mycmd.Parameters.AddWithValue("q4", Cmb4.SelectedItem)
            mycmd.Parameters.AddWithValue("q5", Cmb5.SelectedItem)
            mycmd.Parameters.AddWithValue("q6", Cmb6.SelectedItem)
            mycmd.Parameters.AddWithValue("q7", Cmb7.SelectedItem)
            mycmd.Parameters.AddWithValue("q8", Cmb8.SelectedItem)
            mycmd.Parameters.AddWithValue("datefile", dt.ToString("MMMM d yyyy"))
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If Cmb1.Text = "SELECT" Or
           Cmb2.Text = "SELECT" Or
           Cmb3.Text = "SELECT" Or
           Cmb4.Text = "SELECT" Or
           Cmb5.Text = "SELECT" Or
           Cmb6.Text = "SELECT" Or
           Cmb7.Text = "SELECT" Or
           Cmb8.Text = "SELECT" Then
            MessageBox.Show("Make sure the selected answer is not 'SELECT'", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            MessageBox.Show("Health Monitoring Successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempHealthMonitoring.docx")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PrintPreview.checkLoad = "healthmonitoring"
        PrintPreview.Show()
    End Sub
End Class