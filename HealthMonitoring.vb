Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word

Public Class HealthMonitoring
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub


    Async Function InsertQuery() As Task(Of Integer)
        Dim dt As DateTime = DateTime.Now
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_health(fname,faddress, contactno, temp, q1, q2, q3, q4, q5, q6, q7, q8, datefile)" &
                                         "VALUES(@fname, @faddress, @contactno, @temp, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, datefile )", con)
            mycmd.Parameters.AddWithValue("fname", TxtName.Text)
            mycmd.Parameters.AddWithValue("faddress", TxtName.Text)
            mycmd.Parameters.AddWithValue("contactno", TxtContact.Text)
            mycmd.Parameters.AddWithValue("temp", TxtTemp.Text)
            mycmd.Parameters.AddWithValue("q1", Cmb1.SelectedItem)
            mycmd.Parameters.AddWithValue("q2", Cmb2.SelectedItem)
            mycmd.Parameters.AddWithValue("q3", Cmb3.SelectedItem)
            mycmd.Parameters.AddWithValue("q4", Cmb4.SelectedItem)
            mycmd.Parameters.AddWithValue("q5", Cmb5.SelectedItem)
            mycmd.Parameters.AddWithValue("q6", Cmb6.SelectedItem)
            mycmd.Parameters.AddWithValue("q7", Cmb7.SelectedItem)
            mycmd.Parameters.AddWithValue("q8", Cmb8.SelectedItem)
            mycmd.Parameters.AddWithValue("datefile", dt.ToString("MMMM d yyyy"))
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Public Sub ResetFields()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtContact.ResetText()
        TxtTemp.ResetText()
    End Sub


    Private Sub TxtContact_TextChanged(sender As Object, e As EventArgs) Handles TxtContact.TextChanged

    End Sub

    Private Sub TxtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTemp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTemp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub Cmb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb1.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb2.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb3.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb4.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb5.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb6.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb7.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmb8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb8.KeyPress
        e.Handled = True
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BarangayManagement)
    End Sub

    Private Sub BtnPreviewa_Click(sender As Object, e As EventArgs) Handles BtnPreviewa.Click
        PrintPreview.checkLoad = "healthmonitoring"
        PrintPreview.Show()
    End Sub

    Private Async Sub BtnSa_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Cmb1.Text = "SELECT" Or
         Cmb2.Text = "SELECT" Or
         Cmb3.Text = "SELECT" Or
         Cmb4.Text = "SELECT" Or
         Cmb5.Text = "SELECT" Or
         Cmb6.Text = "SELECT" Or
         Cmb7.Text = "SELECT" Or
         Cmb8.Text = "SELECT" Then
            MessageBox.Show("Make sure the selected answer is not 'SELECT'", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            MessageBox.Show("Health Monitoring Successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button2.MouseHover
        Guna2Button2.ImageSize = New Size(55, 55)
    End Sub

    Private Sub Guna2Button2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button2.MouseLeave
        Guna2Button2.ImageSize = New Size(45, 45)
    End Sub

    Private Sub BtnSave_MouseHover(sender As Object, e As EventArgs) Handles BtnSave.MouseHover
        BtnSave.ImageSize = New Size(40, 40)
    End Sub

    Private Sub BtnSave_MouseLeave(sender As Object, e As EventArgs) Handles BtnSave.MouseLeave
        BtnSave.ImageSize = New Size(30, 30)
    End Sub

    Private Sub BtnPreviewa_MouseHover(sender As Object, e As EventArgs) Handles BtnPreviewa.MouseHover
        BtnPreviewa.ImageSize = New Size(40, 40)
    End Sub

    Private Sub BtnPreviewa_MouseLeave(sender As Object, e As EventArgs) Handles BtnPreviewa.MouseLeave
        BtnPreviewa.ImageSize = New Size(30, 30)
    End Sub
End Class