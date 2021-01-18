Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class OATH
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
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

        UpdateBookMark("name1", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("name2", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("name3", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("age", TxtAge.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("address2", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("noresiding", TxtResiding.Text.Trim, wdDoc)
        UpdateBookMark("noresiding2", TxtResiding.Text.Trim, wdDoc)
        UpdateBookMark("yearmonth", CmbPurpose.SelectedItem.Trim, wdDoc)
        UpdateBookMark("yearmonth2", CmbPurpose.SelectedItem.Trim, wdDoc)
        UpdateBookMark("today", DateTimePicker2.Value.Day, wdDoc)
        UpdateBookMark("today2", $"{DateTimePicker1.Value.Day}", wdDoc)
        UpdateBookMark("myear", DateTimePicker2.Value.ToString("Y").ToUpper, wdDoc)
        UpdateBookMark("myear2", DateTimePicker2.Value.ToString("Y").ToUpper, wdDoc)
        UpdateBookMark("date", DateTimePicker2.Value.ToString("MMMM d yyyy"), wdDoc)
        UpdateBookMark("date2", DateTimePicker2.Value.ToString("MMMM d yyyy"), wdDoc)
        UpdateBookMark("witness", TxtWitness.Text, wdDoc)
        UpdateBookMark("witness2", TxtWitness.Text, wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM-dd-yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_oath(FULLNAME,FULLADDRESS, NORESIDING,  YEARMONTH, DATEISSUED,BIRTHDATE, AGE, WITNESS) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @NORESIDING, @YEARMONTH, @DATEISSUED, @BIRTHDATE, @AGE, @WITNESS)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("NORESIDING", TxtResiding.Text)
            mycmd.Parameters.AddWithValue("YEARMONTH", CmbPurpose.SelectedItem)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))
            mycmd.Parameters.AddWithValue("BIRTHDATE", DateTimePicker2.Value.ToString(dtFrmat))
            mycmd.Parameters.AddWithValue("AGE", TxtAge.Text)
            mycmd.Parameters.AddWithValue("WITNESS", TxtWitness.Text)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_oath
                                         SET FULLNAME= '" & TxtName.Text & "',
                                             FULLADDRESS= '" & TxtAddress.Text & "',
                                             NORESIDING= '" & TxtResiding.Text & "',
                                             YEARMONTH= '" & CmbPurpose.SelectedItem & "',
                                             DATEISSUED='" & DateTimePicker2.Value & "',
                                             BIRTHDATE='" & DateTimePicker2.Value & "',
                                             AGE= '" & TxtAge.Text & "',
                                             WITNESS= '" & TxtWitness.Text & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function


    Private Sub CmbPurpose_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPurpose.KeyPress
        e.Handled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = DateTimePicker1.Value.Year
        Dim age As Integer = today - dob
        TxtAge.Text = age
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(residents)
        residents.BtnUse.Visible = True
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If BCHistory.catTitle = "OATH" Then
            BCHistory.LoadOATH()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtAge.Text) Or String.IsNullOrEmpty(CmbPurpose.Text) Or String.IsNullOrEmpty(TxtResiding.Text) Or String.IsNullOrEmpty(TxtWitness.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If BtnS.Text = "SAVE" Then
            Try
                Await InsertQuery()
                MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempJobOath.docx")
                ResetTextField()
            Catch ex As Exception

            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Update successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempJobOath.docx")
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "OATH"
        PrintPreview.Show()
    End Sub
End Class