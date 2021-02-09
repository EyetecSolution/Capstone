Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word

Public Class BClearance

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(Residents)
        Residents.BtnUse.Visible = True
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

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



    Private Async Sub BtnS_Click(sender As Object, e As EventArgs)
        Dim price As Integer = Val(TxtFees.Text)

        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtCtc.Text) Or String.IsNullOrEmpty(TxtOR.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CmbPurpose.Text = "--Choose Purpose--" Then
            MessageBox.Show("Purpose is required", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            If BtnSa.Text = "SAVE" Then
                PassData()
                Await InsertQuery()
                BackgroundWorker1.RunWorkerAsync()
                ResetTextField()
            Else
                PassData()
                Await UpdateQuery()
                BackgroundWorker2.RunWorkerAsync()
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


    Public fname, address, dtoday, myear, orNo, ctcNo, issuedmain, issued1, purpose As String
    Public Sub PassData()
        Dim dtFormat As String = "MM/d/yyyy"
        Dim monthFrmat As String = "MMMM"
        fname = TxtName.Text
        address = TxtAddress.Text
        dtoday = DateTimePicker2.Value.Day.ToString()
        myear = DateTimePicker2.Value.ToString("Y").ToUpper
        orNo = TxtOR.Text.Trim
        ctcNo = TxtCtc.Text.Trim
        issuedmain = DateTimePicker2.Value.ToString(dtFormat)
        issued1 = DateTimePicker2.Value.ToString(dtFormat)
        purpose = CmbPurpose.Text
    End Sub
    Private Sub UpdateWordDocs(sPath As String)

        Try
            Dim Word() As Process = Process.GetProcessesByName("WINWORD")
            For Each Process As Process In Word
                Process.Kill()
            Next
        Catch ex As Exception
        End Try


        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("fName", fname, wdDoc)
        UpdateBookMark("fName2", fname, wdDoc)
        UpdateBookMark("fName3", fname, wdDoc)
        UpdateBookMark("fAddress", address, wdDoc)
        UpdateBookMark("dtoday", dtoday, wdDoc)
        UpdateBookMark("mYear", myear, wdDoc)
        UpdateBookMark("orNo", orNo, wdDoc)
        UpdateBookMark("ctcNo", ctcNo, wdDoc)
        UpdateBookMark("issuedmain", issuedmain, wdDoc)
        UpdateBookMark("issued1", issued1, wdDoc)
        UpdateBookMark("Purpose", purpose, wdDoc)

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

        Using mycmd As New OleDbCommand("INSERT INTO tbl_clearance(FULLNAME,FULLADDRESS, PURPOSE, DATEISSUED, ISSUEDAT, CTCNO, ORNO, VALIDITY, FEES)" &
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

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs)
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
    Private Sub TxtFees_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFees.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txtissued_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtissued.KeyPress
        e.Handled = True
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Async Sub BtnS_Click_1(sender As Object, e As EventArgs) Handles BtnSa.Click
        Dim price As Integer = Val(TxtFees.Text)

        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtCtc.Text) Or String.IsNullOrEmpty(TxtOR.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CmbPurpose.Text = "--Choose Purpose--" Then
            MessageBox.Show("Purpose is required", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            If BtnSa.Text = "SAVE" Then
                PassData()
                Await InsertQuery()
                BackgroundWorker1.RunWorkerAsync()
                ResetTextField()
            Else
                PassData()
                Await UpdateQuery()
                BackgroundWorker2.RunWorkerAsync()
                ResetTextField()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnPreview_Click_1(sender As Object, e As EventArgs) Handles BtnPreviewa.Click
        PrintPreview.checkLoad = "BClearance"
        PrintPreview.Show()
    End Sub

    Private Sub BtnSa_MouseHover(sender As Object, e As EventArgs) Handles BtnSa.MouseHover
        BtnSa.ImageSize = New Size(40, 40)
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

    Private Sub TxtCtc_TextChanged(sender As Object, e As EventArgs) Handles TxtCtc.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If BCHistory.catTitle = "Barangay Clearance" Then
            BCHistory.LoadBclearance()
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

    Private Sub TxtValidity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValidity.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtName_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CmbPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPurpose.SelectedIndexChanged
        Dim purpose As Integer = CmbPurpose.SelectedIndex

        Select Case purpose
            Case 0
                TxtFees.Text = 50
            Case 1
                TxtFees.Text = 350
            Case 2
                TxtFees.Text = 350
            Case 3
                TxtFees.Text = 50
            Case 4
                TxtFees.Text = 50
            Case 5
                TxtFees.Text = 50
            Case 6
                TxtFees.Text = 50
            Case 7
                TxtFees.Text = 50
        End Select
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        UpdateWordDocs("C:\Capstone\Docs\TempClearance.docx")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Barangay Clearance added." & vbNewLine & "The Document will available for printing.", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        UpdateWordDocs("C:\Capstone\Docs\TempClearance.docx")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        MessageBox.Show("Clearance updated! and" & vbNewLine & "The Document will available for printing.", "Documents Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class