Imports Word = Microsoft.Office.Interop.Word
Public Class Honorarium
    ReadOnly con As New System.Data.OleDb.OleDbConnection(My.Settings.strCon)
    Public id As Integer



    Public Function LoadDataTable(sql As String) As DataTable
        Dim dt = New System.Data.DataTable
        Try
            Using dbcon As New System.Data.OleDb.OleDbConnection(My.Settings.strCon)
                Using cmd As New System.Data.OleDb.OleDbCommand(sql, dbcon)
                    dbcon.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
                dbcon.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function


    Public Async Sub LoadMe()
        Dim sql As String = "SELECT * FROM tbl_payroll"
        Dim dtsample As System.Data.DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("pstion").HeaderText = "POSITION"
        DataGridView1.Columns("fname").HeaderText = "NAME"
        DataGridView1.Columns("honorarium").HeaderText = "HONORARIUM"
        DataGridView1.Columns("deduction").HeaderText = "DEDUCTION"
        DataGridView1.Columns("r_date").HeaderText = "RECEIVED DATE"
        DataGridView1.Columns("net_pay").HeaderText = "NET PAY"

        DataGridView1.Columns("pstion").Width = 200
        DataGridView1.Columns("fname").Width = 250
        DataGridView1.Columns("honorarium").Width = 150
        DataGridView1.Columns("deduction").Width = 100
        DataGridView1.Columns("r_date").Width = 250
        DataGridView1.Columns("net_pay").Width = 100
    End Sub

    Async Function InsertQuery() As Task(Of Integer)



        Dim dt As DateTime = DateTime.Now
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New System.Data.OleDb.OleDbCommand("INSERT INTO tbl_payroll(pstion, fname,honorarium,deduction,r_date,net_pay) " &
                                         "VALUES(@pstion, @fname, @honorarium, @deduction, @r_date, @net_pay) ", con)
            mycmd.Parameters.AddWithValue("pstion", CmbPurpose.SelectedItem)
            mycmd.Parameters.AddWithValue("fname", TxtName.Text)
            mycmd.Parameters.AddWithValue("honorarium", Format(Val(TxtHonor.Text), "#,###,##0.00"))
            mycmd.Parameters.AddWithValue("deduction", Format(Val(TxtDeduct.Text), "#,###,##0.00"))
            mycmd.Parameters.AddWithValue("r_date", TxtRecieved.Text)
            mycmd.Parameters.AddWithValue("net_pay", Txtnet.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
    Private Sub Honorarium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DateTime = DateAndTime.Now
        TxtRecieved.Text = dt.ToString("MMMM d yyyy")
        LoadMe()
    End Sub

    Sub ResetFields()
        TxtName.ResetText()
        TxtHonor.ResetText()
        TxtDeduct.ResetText()
        Txtnet.ResetText()
        CmbPurpose.Text = "SELECT POSITION"
    End Sub



    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CmbPurpose.Text = "SELECT POSITION" Or TxtName.Text = "" Then
            MessageBox.Show("Position and Name field is required!", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try

            Await InsertQuery()
            MessageBox.Show("Successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMe()
            ResetFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub TxtDeduct_TextChanged(sender As Object, e As EventArgs) Handles TxtDeduct.TextChanged

        Txtnet.Text = Format(Val(TxtHonor.Text) - Val(TxtDeduct.Text), "#,###,##0.00")
    End Sub

    Private Sub TxtHonor_TextChanged(sender As Object, e As EventArgs) Handles TxtHonor.TextChanged

        Txtnet.Text = Format(Val(TxtHonor.Text), "#,###,##0.00")
    End Sub

    Private Sub TxtDeduct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDeduct.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TxtHonor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHonor.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub



    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim sql As String = "SELECT * FROM tbl_payroll WHERE fname LIKE '" & TxtSearch.Text & "%'"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress

    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
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

        UpdateBookMark("name", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("position", CmbPurpose.Text.Trim, wdDoc)
        UpdateBookMark("date", TxtRecieved.Text.Trim, wdDoc)

        UpdateBookMark("deduct1", Format(TxtDeduct.Text, "#, ##0.00"), wdDoc)
        UpdateBookMark("salary", Format(TxtHonor.Text, "#,##0.00"), wdDoc)
        UpdateBookMark("netpay", Txtnet.Text, wdDoc)
        UpdateBookMark("totaldeduct", Format(TxtDeduct.Text, "#, ##0.00"), wdDoc)


        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim Word() As Process = Process.GetProcessesByName("WINWORD")
            For Each Process As Process In Word
                Process.Kill()
            Next
        Catch ex As Exception
        End Try
        Try
            UpdateWordDocs("C:\Capstone\Docs\TempPayslip.docx")
            Dim app As Word.Application
            Dim doc As Word.Document
            Dim p As New PrintDialog
            app = New Word.Application
            app.WordBasic.FilePrintSetup(Printer:=p.PrinterSettings.PrinterName, DoNotSetAsSysDefault:=1)

            Dim m As Object = System.Reflection.Missing.Value
            doc = app.Documents.Open("C:\Capstone\Docs\TempPayslip.docx", m, m, m, m, m, m, m, m, m, m, m)
            app.PrintOut()
            app.Documents.Close()

            'Quit word application
            app.Quit()

            'Release 
            app = Nothing
        Catch ex As Exception

        End Try


    End Sub
End Class