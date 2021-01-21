Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class BusinessClearance
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtfrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_business(FULLNAME, FULLADDRESS, BUSINESSNAME, BUSINESSLOCATION, DATEISSUED, ORNO, CTCNO, VALIDITY, FEES)" &
                                         "VALUES(@FULLNAME, @FULLADDRESS, @BUSINESSNAME, @BUSINESSLOCATION, @DATEISSUED, @CTCNO, @ORNO, @VALIDITY, @FEES)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("BUSINESSNAME", TxtBusinessname.Text)
            mycmd.Parameters.AddWithValue("BUSINESSLOCATION", TxtBusinesslocation.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtfrmat))
            mycmd.Parameters.AddWithValue("CTCNO", TxtCtc.Text)
            mycmd.Parameters.AddWithValue("ORNO", TxtOr.Text)
            mycmd.Parameters.AddWithValue("VALIDITY", DateTimePicker1.Value.ToString(dtfrmat))
            mycmd.Parameters.AddWithValue("FEES", TxtAmount.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim frmat As String = "M/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_business" &
                                         " SET FULLNAME= '" & TxtName.Text & "'," &
                                             " FULLADDRESS= '" & TxtAddress.Text & "'," &
                                             " BUSINESSNAME= '" & TxtBusinessname.Text & "'," &
                                             " BUSINESSLOCATION= '" & TxtBusinesslocation.Text & "'," &
                                             " DATEISSUED= '" & DateTimePicker2.Value.ToString(frmat) & "'," &
                                             " ORNO='" & TxtOr.Text & "'," &
                                             " CTCNO= '" & TxtCtc.Text & "'," &
                                             " VALIDITY='" & DateTimePicker1.Value.ToString(frmat) & "'" &
                                         "WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function


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

        UpdateBookMark("applicant", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("businessname", TxtBusinessname.Text.Trim, wdDoc)
        UpdateBookMark("businesslocation", TxtBusinesslocation.Text.Trim, wdDoc)
        UpdateBookMark("day", DateTimePicker2.Value.Day, wdDoc)
        UpdateBookMark("myear", DateTimePicker2.Value.ToString("Y"), wdDoc)
        UpdateBookMark("myear", DateTimePicker2.Value.ToString("Y"), wdDoc)
        UpdateBookMark("num1", TxtOr.Text, wdDoc)
        UpdateBookMark("num2", TxtCtc.Text, wdDoc)
        UpdateBookMark("dtissued", DateTimePicker2.Value.ToString(dtFormat), wdDoc)
        UpdateBookMark("valid", DateTimePicker1.Value.ToString("MMMM d yyyy"), wdDoc)
        UpdateBookMark("amount", TxtAmount.Text, wdDoc)


        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub
    Sub ResetTextFields()
        TxtName.ResetText()
        TxtBusinessname.ResetText()
        TxtBusinesslocation.ResetText()
        TxtOr.ResetText()
        TxtCtc.ResetText()
    End Sub



    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtBusinessname.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtBusinesslocation.Text) Or String.IsNullOrEmpty(TxtOr.Text) Or String.IsNullOrEmpty(TxtCtc.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If BtnSave.Text = "SAVE" Then
                Await InsertQuery()
                MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempBusinessC.docx")
                ResetTextFields()
            Else
                Await UpdateQuery()
                MessageBox.Show("Update successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempBusinessC.docx")
                ResetTextFields()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If BCHistory.catTitle = "businessc" Then
            BCHistory.LoadBusinessClearance()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "businessc"
        PrintPreview.Show()
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOr.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCtc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCtc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class