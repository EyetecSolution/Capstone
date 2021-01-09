Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class Residency

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtPurpose.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempResidency.docx")
            ResetTextField()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_residency(FULLNAME,FULLADDRESS, PURPOSE, DATEISSUED) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @PURPOSE, @DATEISSUED)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("PURPOSE", TxtPurpose.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))


            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Sub ResetTextField()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtPurpose.ResetText()
    End Sub

    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub

    Private Sub UpdateWordDocs(sPath As String)
        Dim dtFormat As String = "MM/d/yyyy"
        Dim monthFrmat As String = "MMMM"
        Dim objWordApp = New Word.Application
        objWordApp.Visible = False
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name1", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("name2", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("purpose", TxtPurpose.Text.Trim, wdDoc)
        UpdateBookMark("day", $"{DateTimePicker2.Value.Day.ToString()}th", wdDoc)
        UpdateBookMark("myear", $"{DateTimePicker2.Value.ToString("Y").ToUpper}", wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "Residency"
        PrintPreview.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub
End Class