Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word

Public Class BClearance

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(residents)
        residents.BtnUse.Visible = True
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtCtc.Text) Or String.IsNullOrEmpty(TxtOR.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempClearance.docx")
            ResetTextField()
        Catch ex As Exception
            MessageBox.Show("Database Error occured: Please contact your software developer in order to fix this issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub

    Dim dayStr() As String = {"1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th"}

    Private Sub UpdateWordDocs(sPath As String)
        Dim dtFormat As String = "MM/d/yyyy"
        Dim monthFrmat As String = "MMMM"
        Dim objWordApp = New Word.Application
        objWordApp.Visible = False
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("fName", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("fName2", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("fName3", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("fAddress", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("dtoday", $"{DateTimePicker2.Value.Day.ToString()}", wdDoc)
        UpdateBookMark("mYear", DateTimePicker2.Value.ToString("Y").ToUpper, wdDoc)
        UpdateBookMark("orNo", TxtOR.Text.Trim, wdDoc)
        UpdateBookMark("ctcNo", TxtCtc.Text.Trim, wdDoc)
        UpdateBookMark("issuedmain", DateTimePicker2.Value.ToString(dtFormat), wdDoc)
        UpdateBookMark("issued1", DateTimePicker2.Value.ToString(dtFormat), wdDoc)
        UpdateBookMark("Purpose", CmbPurpose.Text, wdDoc)

        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub
    Async Function InsertQuery() As Task(Of Integer)
        Dim dtfrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_clearance(FULLNAME,FULLADDRESS, PURPOSE, DATEISSUED, ISSUEDAT, CTCNO, ORNO, VALIDITY, FEES) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @PURPOSE, @DATEISSUED, @ISSUEDAT, @CTCNO, @ORNO, @VALIDITY, @FEES)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("PURPOSE", CmbPurpose.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtfrmat))
            mycmd.Parameters.AddWithValue("ISSUEDAT", Txtissued.Text)
            mycmd.Parameters.AddWithValue("CTCNO", TxtCtc.Text)
            mycmd.Parameters.AddWithValue("ORNO", TxtOR.Text)
            mycmd.Parameters.AddWithValue("VALIDITY", TxtValidity.Text)
            mycmd.Parameters.AddWithValue("FEES", TxtFees.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function



    Sub ResetTextField()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtCtc.ResetText()
        TxtOR.ResetText()
        CmbPurpose.ResetText()
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        PrintPreview.checkLoad = "BClearance"
        PrintPreview.Show()
    End Sub

    Private Sub BClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class