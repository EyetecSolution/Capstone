Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class Indigency
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_indigency
                                         SET FULLNAME= '" & TxtName.Text & "',
                                             FULLADDRESS= '" & TxtAddress.Text & "',
                                             BIRTHDATE= '" & DateTimePicker1.Value & "',
                                             AGE= '" & TxtAge.Text & "',
                                             DATEISSUED='" & DateTimePicker2.Value & "',
                                             PURPOSE= '" & CmbPurpose.Text & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM-dd-yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_indigency(FULLNAME,FULLADDRESS, BIRTHDATE,  AGE, DATEISSUED, PURPOSE) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @BIRTHDATE, @AGE, @DATEISSUED, @PURPOSE)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("BIRTHDATE", DateTimePicker1.Value.ToString(dtFrmat))
            mycmd.Parameters.AddWithValue("AGE", TxtAge.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))
            mycmd.Parameters.AddWithValue("PURPOSE", CmbPurpose.Text)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function


    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtAge.Text) Or String.IsNullOrEmpty(CmbPurpose.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If BtnS.Text = "SAVE" Then
            Try
                Await InsertQuery()
                MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempIndigency.docx")
                ResetTextField()
            Catch ex As Exception

            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Update successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempIndigency.docx")
                ResetTextField()
            Catch ex As Exception

            End Try
        End If


    End Sub



    Sub ResetTextField()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtAge.ResetText()
        CmbPurpose.ResetText()
    End Sub

    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub

    Private Sub UpdateWordDocs(sPath As String)
        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("age", TxtAge.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("purpose", CmbPurpose.Text.Trim, wdDoc)
        UpdateBookMark("day", $"{DateTimePicker2.Value.Day}th", wdDoc)
        UpdateBookMark("myear", $"{DateTimePicker2.Value.ToString("Y").ToUpper}", wdDoc)


        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "Indigency"
        PrintPreview.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        If BCHistory.catTitle = "indigency" Then
            BCHistory.LoadIndigency()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)


    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(residents)
        residents.BtnUse.Visible = True
    End Sub


    Private Sub CmbPurpose_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPurpose.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = DateTimePicker1.Value.Year
        Dim age As Integer = today - dob
        TxtAge.Text = age
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub
End Class