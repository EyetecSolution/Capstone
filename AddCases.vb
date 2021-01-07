Imports System.Data.OleDb

Public Class AddCases
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Async Function InsertQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_covid(FULLNAME, FULLADDRESS, AGE, GENDER, CONDITION, SYMPTOMS) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @AGE, @GENDER, @CONDITION, @SYMPTOMS)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("AGE", TxtAge.Text)
            mycmd.Parameters.AddWithValue("GENDER", CmbGender.Text)
            mycmd.Parameters.AddWithValue("CONDITION", CmbCategory.Text)
            mycmd.Parameters.AddWithValue("DESCRIPTION", TxtDescription.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_covid
                                         SET FULLNAME = '" & TxtName.Text & "',
                                         FULLADDRESS = '" & TxtAddress.Text & "',
                                         AGE = '" & TxtAge.Text & "',
                                         GENDER = '" & CmbGender.Text & "',
                                         CONDITION = '" & CmbCategory.Text & "',
                                         SYMPTOMS = '" & TxtDescription.Text & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", ID.Text)
            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(CovidCases)
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If BtnSave.Text = "UPDATE" Then
            Await UpdateQuery()
            MessageBox.Show("Patient Updated Successfully", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Await InsertQuery()
            MessageBox.Show("Patient Added Successfully", "BSMIMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class