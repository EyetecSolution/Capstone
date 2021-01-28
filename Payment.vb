
Imports Word = Microsoft.Office.Interop.Word


Public Class Payment
    ReadOnly con As New System.Data.OleDb.OleDbConnection(My.Settings.strCon)
    Public category As String
    Public tblparam As String = Nothing
    Dim accumulator As Integer = 0

    Async Function UpdateQuery(sql As String) As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New System.Data.OleDb.OleDbCommand(sql, con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function



    Private Sub TxtAddress_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TxtDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtChange_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtChange.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCash.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If TxtCash.Text = "" Then TxtChange.Text = "0.00"
    End Sub
    Private Async Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        Try
            Dim Word() As Process = Process.GetProcessesByName("WINWORD")
            For Each Process As Process In Word
                Process.Kill()
            Next
        Catch ex As Exception
        End Try
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtCash.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            PrintNow()
            MessageBox.Show("Payment successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetTextfield()
        Catch ex As Exception


        End Try

    End Sub




    Public Async Function InsertQuery() As Task(Of Integer)
        Dim docsCollection() As String = {TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text}

        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New System.Data.OleDb.OleDbCommand("INSERT INTO tbl_payment(fname, DATEISSUED, total_amount, cash, issued_document, change)" &
                                         " VALUES(@fname, @DATEISSUED, @total_amount, @cash, @issued_document, @change)", con)
            mycmd.Parameters.AddWithValue("fname", TxtName.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", Date.Now.ToString("M/d/yyyy"))
            mycmd.Parameters.AddWithValue("total_amount", Val(TextBox9.Text))
            mycmd.Parameters.AddWithValue("cash", Val(TxtCash.Text))
            mycmd.Parameters.AddWithValue("issued_document", String.Join(" ", docsCollection))
            mycmd.Parameters.AddWithValue("change", TxtChange.Text)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Public Sub ResetTextfield()
        TxtName.ResetText()
        TxtDate.ResetText()
        TxtAmount.ResetText()
        TxtCash.ResetText()
        TxtChange.ResetText()
    End Sub



    Private Sub TxtCash_TextChanged(sender As Object, e As EventArgs) Handles TxtCash.TextChanged

        TxtChange.Text = Format(Val(TxtCash.Text) - Val(TxtAmount.Text), "0.00")

    End Sub





    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Word.Range
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

        UpdateBookMark("date", Date.Now.ToString("MMMM d yyyy"), wdDoc)
        UpdateBookMark("name", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("space0", TextBox10.Text, wdDoc)
        UpdateBookMark("space1", TextBox11.Text, wdDoc)
        UpdateBookMark("space2", TextBox12.Text, wdDoc)
        UpdateBookMark("space3", TextBox13.Text, wdDoc)
        UpdateBookMark("space4", TextBox14.Text, wdDoc)
        UpdateBookMark("space5", TextBox15.Text, wdDoc)
        UpdateBookMark("space6", TextBox16.Text, wdDoc)
        UpdateBookMark("space7", TextBox17.Text, wdDoc)

        UpdateBookMark("pay0", TextBox1.Text.Trim, wdDoc)
        UpdateBookMark("pay1", TextBox2.Text.Trim, wdDoc)
        UpdateBookMark("pay2", TextBox3.Text.Trim, wdDoc)
        UpdateBookMark("pay3", TextBox4.Text.Trim, wdDoc)
        UpdateBookMark("pay4", TextBox5.Text.Trim, wdDoc)
        UpdateBookMark("pay5", TextBox6.Text.Trim, wdDoc)
        UpdateBookMark("pay6", TextBox7.Text.Trim, wdDoc)
        UpdateBookMark("pay7", TextBox8.Text.Trim, wdDoc)
        UpdateBookMark("total", TextBox9.Text.Trim, wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Sub PrintNow()
        Try
            UpdateWordDocs("C:\Capstone\Docs\TempReceipt.docx")
            Dim app As Word.Application
            Dim doc As Word.Document
            Dim p As New PrintDialog
            app = New Word.Application
            app.WordBasic.FilePrintSetup(Printer:=p.PrinterSettings.PrinterName, DoNotSetAsSysDefault:=1)

            Dim m As Object = System.Reflection.Missing.Value
            doc = app.Documents.Open("C:\Capstone\Docs\TempReceipt.docx", m, m, m, m, m, m, m, m, m, m, m)
            app.PrintOut()
            app.Documents.Close()

            'Quit word application
            app.Quit()

            'Release 
            app = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(FormDocument)
    End Sub
End Class