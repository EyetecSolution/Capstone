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

        If BCHistory.catTitle = "Barangay Clearance" Then
            BCHistory.LoadBclearance()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub
    Async Function UpdateQuery() As Task(Of Integer)
        Dim frmat As String = "M/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_clearance" &
                                         " SET FULLNAME= '" & TxtName.Text & "', " &
                                             "FULLADDRESS= '" & TxtAddress.Text & "', " &
                                             "PURPOSE= '" & CmbPurpose.SelectedItem & "', " &
                                             "DATEISSUED= '" & DateTimePicker2.Value.ToString(frmat) & "', " &
                                             "CTCNO='" & TxtCtc.Text & "', " &
                                             "ORNO= '" & TxtOR.Text & "'" &
                                             "WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtCtc.Text) Or String.IsNullOrEmpty(TxtOR.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CmbPurpose.Text = "--Choose Purpose--" Then
            MessageBox.Show("Purpose is required", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            If BtnS.Text = "SAVE" Then
                Await InsertQuery()
                UpdateWordDocs("C:\Capstone\Docs\TempClearance.docx")
                MessageBox.Show("New Barangay Clearance applicant added! and" & vbNewLine & "The Document will available for printing.", "Documents Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetTextField()
            Else
                Await UpdateQuery()
                UpdateWordDocs("C:\Capstone\Docs\TempClearance.docx")
                MessageBox.Show("Clearance updated! and" & vbNewLine & "The Document will available for printing.", "Documents Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetTextField()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub



    Private Sub UpdateWordDocs(sPath As String)

        Try
            Dim Word() As Process = Process.GetProcessesByName("WINWORD")
            For Each Process As Process In Word
                Process.Kill()
            Next
        Catch ex As Exception
        End Try

        Dim dtFormat As String = "MM/d/yyyy"
        Dim monthFrmat As String = "MMMM"
        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("fName", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("fName2", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("fName3", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("fAddress", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("dtoday", DateTimePicker2.Value.Day.ToString(), wdDoc)
        UpdateBookMark("mYear", DateTimePicker2.Value.ToString("Y").ToUpper, wdDoc)
        UpdateBookMark("orNo", TxtOR.Text.Trim, wdDoc)
        UpdateBookMark("ctcNo", TxtCtc.Text.Trim, wdDoc)
        UpdateBookMark("issuedmain", DateTimePicker2.Value.ToString(dtFormat), wdDoc)
        UpdateBookMark("issued1", DateTimePicker2.Value.ToString(dtFormat), wdDoc)
        UpdateBookMark("Purpose", CmbPurpose.Text, wdDoc)

        wdDoc.Save()
        wdDoc.Close()
        objWordApp.Quit()
    End Sub
    Async Function InsertQuery() As Task(Of Integer)
        Dim dtfrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_clearance(FULLNAME,FULLADDRESS, PURPOSE, DATEISSUED, ISSUEDAT, CTCNO, ORNO, VALIDITY, FEES, paymentstatus)" &
                                         "VALUES(@FULLNAME, @FULLADDRESS, @PURPOSE, @DATEISSUED, @ISSUEDAT, @CTCNO, @ORNO, @VALIDITY, @FEES)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("PURPOSE", CmbPurpose.SelectedItem)
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


    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub CmbPurpose_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPurpose.KeyPress
        e.Handled = True
    End Sub


    Private Sub TxtCtc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCtc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOR.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub TxtFees_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFees.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txtissued_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtissued.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtValidity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValidity.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtCtc_TextChanged(sender As Object, e As EventArgs) Handles TxtCtc.TextChanged

    End Sub

    Private Sub TxtName_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




    Private Sub BClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class