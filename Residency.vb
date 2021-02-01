Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class Residency

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Async Sub BtnS_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtPurpose.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BtnSa.Text = "SAVE" Then
            Try
                Await InsertQuery()

                UpdateWordDocs("C:\Capstone\Docs\TempResidency.docx")
                Dim i = MessageBox.Show("Certificate of Residency added." & vbNewLine & "The Document will available for printing." & vbNewLine & "Any Other Transaction? " & TxtName.Text, "BSMIMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If i = vbYes Then
                    Dashboard.activefrm.Hide()
                    Dashboard.OpenFormChild(FormDocument)
                Else
                    Dashboard.activefrm.Hide()
                    Dashboard.OpenFormChild(Payment)
                End If
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Update successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempResidency.docx")
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_residency" &
                                         " SET FULLNAME= '" & TxtName.Text & "'," &
                                             " FULLADDRESS= '" & TxtAddress.Text & "'," &
                                             " PURPOSE= '" & TxtPurpose.Text & "'," &
                                             " DATEISSUED='" & DateTimePicker2.Value & "'" &
                                         " WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_residency(FULLNAME,FULLADDRESS, PURPOSE, DATEISSUED, FEES)" &
                                         " VALUES(@FULLNAME, @FULLADDRESS, @PURPOSE, @DATEISSUED, @FEES)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("PURPOSE", TxtPurpose.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))
            mycmd.Parameters.AddWithValue("FEES", Amount.Text)


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
        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name1", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("name2", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("purpose", TxtPurpose.Text.Trim, wdDoc)
        UpdateBookMark("day", DateTimePicker2.Value.Day, wdDoc)
        UpdateBookMark("myear", DateTimePicker2.Value.ToString("Y").ToUpper, wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        PrintPreview.checkLoad = "Residency"
        PrintPreview.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Residents.BtnUse.Visible = True
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Residents)
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        If BCHistory.catTitle = "residency" Then
            BCHistory.LoadRes()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSa_MouseHover(sender As Object, e As EventArgs) Handles BtnSa.MouseHover
        BtnSa.ImageSize = New Size(40, 40)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub BtnSa_Click(sender As Object, e As EventArgs) Handles BtnSa.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtPurpose.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BtnSa.Text = "SAVE" Then
            Try
                Await InsertQuery()

                UpdateWordDocs("C:\Capstone\Docs\TempResidency.docx")
                Dim i = MessageBox.Show("Certificate of Residency added." & vbNewLine & "The Document will available for printing." & vbNewLine & "Any Other Transaction? " & TxtName.Text, "BSMIMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If i = vbYes Then
                    Dashboard.activefrm.Hide()
                    Dashboard.OpenFormChild(FormDocument)
                Else
                    Dashboard.activefrm.Hide()
                    Dashboard.OpenFormChild(Payment)
                End If
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Update successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\Docs\TempResidency.docx")
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnPreviewa_Click(sender As Object, e As EventArgs) Handles BtnPreviewa.Click
        PrintPreview.checkLoad = "Residency"
        PrintPreview.Show()
    End Sub

    Private Sub BtnSa_MouseLeave(sender As Object, e As EventArgs) Handles BtnSa.MouseLeave
        BtnSa.ImageSize = New Size(30, 30)
    End Sub

    Private Sub BtnPreviewa_MouseHover(sender As Object, e As EventArgs) Handles BtnPreviewa.MouseHover
        BtnPreviewa.ImageSize = New Size(40, 40)
    End Sub

    Private Sub BtnPreviewa_MouseLeave(sender As Object, e As EventArgs) Handles BtnPreviewa.MouseLeave
        BtnPreviewa.ImageSize = New Size(30, 30)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If BCHistory.catTitle = "residency" Then
            BCHistory.LoadRes()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button1.MouseHover
        Guna2Button1.ImageSize = New Size(55, 55)
    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave
        Guna2Button1.ImageSize = New Size(45, 45)
    End Sub
End Class