Imports System.Data.OleDb

Public Class AddCases
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Async Function InsertQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_covid(FULLNAME, FULLADDRESS, AGE, GENDER, CONDITION, SYMPTOMS)" &
                                         "VALUES(@FULLNAME, @FULLADDRESS, @AGE, @GENDER, @CONDITION, @SYMPTOMS)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text.Trim.ToUpper)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text.Trim.ToUpper)
            mycmd.Parameters.AddWithValue("AGE", TxtAge.Text.Trim.ToUpper)
            mycmd.Parameters.AddWithValue("GENDER", CmbGender.Text)
            mycmd.Parameters.AddWithValue("CONDITION", ComboBox1.Text)
            mycmd.Parameters.AddWithValue("DESCRIPTION", TxtDescription.Text.Trim.ToUpper)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_covid" &
                                         " SET FULLNAME = '" & TxtName.Text & "'," &
                                         " FULLADDRESS = '" & TxtAddress.Text & "'," &
                                         " AGE = '" & TxtAge.Text & "'," &
                                         " GENDER = '" & CmbGender.Text & "'," &
                                        " CONDITION = '" & ComboBox1.Text & "'," &
                                         " SYMPTOMS = '" & TxtDescription.Text & "'" &
                                         " WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", CovidCases.id)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Sub ResetFields()
        TxtName.ResetText()
        TxtAddress.ResetText()
        CmbGender.ResetText()
        ComboBox1.Text = "--Choose Condition--"
        TxtDescription.ResetText()
        TxtAge.ResetText()
    End Sub



    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(CovidCases)
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGender.SelectedIndexChanged

    End Sub

    Private Sub CmbGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGender.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtAge_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtAge_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(CovidCases)
    End Sub

    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button1.MouseHover
        Guna2Button1.ImageSize = New Size(55, 55)
    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave
        Guna2Button1.ImageSize = New Size(45, 45)
    End Sub

    Private Sub TxtAge_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtAge.KeyPress
        If Not IsNumeric(TxtAge.Text) Then
            e.Handled = True
        End If
    End Sub

    Private Async Sub BtnSa_Click(sender As Object, e As EventArgs) Handles BtnSa.Click
        If BtnSa.Text = "UPDATE" Then
            Await UpdateQuery()
            MessageBox.Show("Patient Updated Successfully", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetFields()
        Else
            Await InsertQuery()
            MessageBox.Show("Patient Added Successfully", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetFields()
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub BtnSa_MouseHover(sender As Object, e As EventArgs) Handles BtnSa.MouseHover
        BtnSa.ImageSize = New Size(40, 40)
    End Sub

    Private Sub BtnSa_MouseLeave(sender As Object, e As EventArgs) Handles BtnSa.MouseLeave
        BtnSa.ImageSize = New Size(30, 30)
    End Sub
End Class