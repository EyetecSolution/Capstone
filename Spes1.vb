Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class Spes1
    ReadOnly con As New OleDbConnection(My.Settings.strCon)


    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub TxtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSchoolYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSchoolYear.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "SPES1"
        PrintPreview.Show()
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
        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("age", TxtAge.Text.Trim, wdDoc)
        UpdateBookMark("schoolyear", TxtSchoolYear.Text.Trim, wdDoc)
        UpdateBookMark("day", $"{DateTimePicker2.Value.Day}th", wdDoc)
        UpdateBookMark("myear", $"{DateTimePicker2.Value.ToString("Y").ToUpper}", wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub


    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtSchoolYear.Text) Or String.IsNullOrEmpty(TxtAge.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BtnS.Text = "SAVE" Then
            Try
                Await InsertQuery()
                MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempSpesout.docx")
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempSpesout.docx")
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_spes1(FULLNAME,FULLADDRESS, AGE, SCHOOLYEAR, DATEISSUED) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @AGE, @SCHOOLYEAR, @DATEISSUED)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("AGE", TxtAge.Text)
            mycmd.Parameters.AddWithValue("SCHOOLYEAR", TxtSchoolYear.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_spes1
                                         SET FULLNAME= '" & TxtName.Text & "',
                                             FULLADDRESS= '" & TxtAddress.Text & "',
                                             AGE= '" & TxtAge.Text & "',
                                             SCHOOLYEAR= '" & TxtSchoolYear.Text & "',
                                             DATEISSUED= '" & DateTimePicker2.Value & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Sub ResetTextField()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtSchoolYear.ResetText()
        TxtAge.ResetText()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(residents)
        residents.BtnUse.Visible = True
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If BCHistory.catTitle = "SPES1" Then
            BCHistory.LoadSpes1()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub
End Class