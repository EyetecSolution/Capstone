Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class BusinessClearance
    Public fullname, businessn, businessloc, day, myear, num1, num2, dtissued, valid, amount As String

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
            mycmd.Parameters.AddWithValue("VALIDITY", TextBox1.Text)
            mycmd.Parameters.AddWithValue("FEES", CDbl(TxtAmount.Text))
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
                                             " VALIDITY='" & TextBox1.Text & "'" &
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

    Public Sub PassData()
        Dim dtFormat As String = "MM/d/yyyy"
        fullname = TxtName.Text
        businessn = TxtBusinessname.Text.Trim
        businessloc = TxtBusinesslocation.Text.Trim
        day = DateTimePicker2.Value.Day
        myear = DateTimePicker2.Value.ToString("Y")
        num1 = TxtOr.Text
        num2 = TxtCtc.Text
        dtissued = DateTimePicker2.Value.ToString(dtFormat)
        valid = TextBox1.Text
        amount = TxtAmount.Text
    End Sub


    Private Sub UpdateWordDocs(sPath As String)

        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("applicant", fullname, wdDoc)
        UpdateBookMark("businessname", businessn, wdDoc)
        UpdateBookMark("businesslocation", businessloc, wdDoc)
        UpdateBookMark("day", day, wdDoc)
        UpdateBookMark("myear", myear, wdDoc)
        UpdateBookMark("num1", num1, wdDoc)
        UpdateBookMark("num2", num2, wdDoc)
        UpdateBookMark("dtissued", dtissued, wdDoc)
        UpdateBookMark("valid", valid, wdDoc)
        UpdateBookMark("amount", amount, wdDoc)


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
                BackgroundWorker1.RunWorkerAsync()
                ResetTextFields()
            Else
                PassData()
                Await UpdateQuery()
                BackgroundWorker2.RunWorkerAsync()
                ResetTextFields()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "businessc"
        PrintPreview.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel9_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel9.Click

    End Sub

    Private Sub Guna2Button2_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button2.MouseHover
        Guna2Button2.ImageSize = New Size(40, 40)
    End Sub



    Private Sub Guna2Button2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button2.MouseLeave
        Guna2Button2.ImageSize = New Size(30, 30)

    End Sub

    Private Sub Guna2Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2Button2.KeyPress

    End Sub

    Private Sub BtnSave_MouseHover(sender As Object, e As EventArgs) Handles BtnSave.MouseHover
        BtnSave.ImageSize = New Size(40, 40)
    End Sub

    Private Sub BtnSave_MouseLeave(sender As Object, e As EventArgs) Handles BtnSave.MouseLeave
        BtnSave.ImageSize = New Size(30, 30)
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If BCHistory.catTitle = "businessc" Then
            BCHistory.LoadBusinessClearance()
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

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOr_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCtc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Residents)
        Residents.BtnUse.Visible = True
    End Sub

    Private Sub BusinessClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        UpdateWordDocs("C:\Capstone\Docs\TempBusinessC.docx")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        MessageBox.Show("Update Succesfully" & vbNewLine & "The Document will available for printing.", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        UpdateWordDocs("C:\Capstone\Docs\TempBusinessC.docx")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Business clearance added. " & vbNewLine & "The Document will available for printing.", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class