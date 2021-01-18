Imports System.Data.OleDb

Public Class AddNewResident
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    ReadOnly cmd As New OleDbCommand
    ReadOnly sql As String
    Private myid As Integer
    Public checkActive As Boolean = False

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtfrmat As String = "M/d/yyyy"
        Dim arrImage As Byte()
        Dim mstream As New System.IO.MemoryStream
        Dim i As Integer
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()

        Dim fileSize As UInt32
        fileSize = mstream.Length
        mstream.Close()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try


            Using mycmd As New OleDbCommand("INSERT INTO tbl_residents 
                                         (FULLNAME, FULLADDRESS,BIRTHPLACE,BIRTHDATE,AGE,GENDER,CIVILSTATUS,CITIZENSHIP, OCCUPATION,PHOTO)
                                        VALUES(@FULLNAME,@FULLADDRESS,@BIRTHPLACE,@BIRTHDATE,@AGE,@GENDER,@CIVILSTATUS,@CITIZENSHIP, @OCCUPATION,@PHOTO)", con)
                With mycmd
                    .Parameters.AddWithValue("@FULLNAME", TxtName.Text)
                    .Parameters.AddWithValue("@FULLADDRESS", TxtAddress.Text)
                    .Parameters.AddWithValue("@BIRTHPLACE", TxtBirth.Text)
                    .Parameters.AddWithValue("@BIRTHDATE", TxtBdate.Value.ToString(dtfrmat))
                    .Parameters.AddWithValue("@AGE", Val(LabelAge.Text))
                    .Parameters.AddWithValue("@GENDER", CmbGender.Text)
                    .Parameters.AddWithValue("@CIVILSTATUS", CmbCivilStat.Text)
                    .Parameters.AddWithValue("@CITIZENSHIP", TxtCitizen.Text)
                    If TxtOccupation.Text = "" Then
                        .Parameters.AddWithValue("@OCCUPATION", "N/A")
                    Else
                        .Parameters.AddWithValue("@OCCUPATION", TxtOccupation.Text)
                    End If
                    .Parameters.AddWithValue("@PHOTO", arrImage)
                End With
                If TxtName.Text = "" Or TxtAddress.Text = "" Or TxtBirth.Text = "" Or TxtCitizen.Text = "" Or CmbCivilStat.Text = "" Or CmbGender.Text = "" Then

                    MessageBox.Show("There's some blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    i = Await mycmd.ExecuteNonQueryAsync
                End If

            End Using

        Catch ex As Exception

        End Try
        Return i
    End Function



    Private Sub TxtBdate_ValueChanged(sender As Object, e As EventArgs) Handles TxtBdate.ValueChanged
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = TxtBdate.Value.Year
        Dim age As Integer = today - dob
        LabelAge.Text = age
    End Sub

    Private Sub AddNewResident_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtBdate.Format = DateTimePickerFormat.Custom
        TxtBdate.CustomFormat = "MMM dd yyyy"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "File Name | *.jpg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub

    Async Function UpdateQuery() As Task(Of Integer)
        Dim frmat As String = "M/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_residents 
                                         SET FULLNAME = '" & TxtName.Text & "',
                                         FULLADDRESS = '" & TxtAddress.Text & "',
                                         BIRTHPLACE = '" & TxtBirth.Text & "',
                                         BIRTHDATE = '" & TxtBdate.Value.ToString(frmat) & "',
                                         AGE = '" & LabelAge.Text & "',
                                         GENDER = '" & CmbGender.Text & "',
                                         CIVILSTATUS = '" & CmbCivilStat.Text & "',
                                         CITIZENSHIP = '" & TxtCitizen.Text & "',
                                         OCCUPATION = '" & TxtOccupation.Text & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", txtid.Text)
            If TxtName.Text = "" Or TxtAddress.Text = "" Or TxtBirth.Text = "" Or TxtCitizen.Text = "" Or CmbCivilStat.Text = "" Or CmbGender.Text = "" Then
                MessageBox.Show("There's some blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                i = Await mycmd.ExecuteNonQueryAsync
            End If
        End Using
        Return i
    End Function

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BtnSave.Text = "SAVE" Then
            Dim i As Integer = Await InsertQuery()
            If i > 0 Then
                MessageBox.Show("Resident Successfully Added!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtName.ResetText()
                TxtAddress.ResetText()
                TxtBirth.ResetText()
                LabelAge.Text = "0"
                CmbCivilStat.SelectedItem = ""
                CmbGender.SelectedItem = ""
                TxtOccupation.ResetText()
                TxtCitizen.ResetText()

            End If
        Else

            Dim i As Integer = Await UpdateQuery()
            If i > 0 Then
                MessageBox.Show("Resident successfully updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()
        Dashboard.OpenFormChild(residents)

        Select Case BCHistory.catTitle
            Case "Barangay Clearance"
                residents.BtnUse.Visible = True
            'Case "businessc"
            Case "indigency"
                residents.BtnUse.Visible = True
            Case "non-residency"
                residents.BtnUse.Visible = True
            Case "residency"
                residents.BtnUse.Visible = True
            Case "solo-parent"
                residents.BtnUse.Visible = True
            Case "SPES"
                residents.BtnUse.Visible = True
            Case "SPES1"
                residents.BtnUse.Visible = True
            Case "OATH"
                residents.BtnUse.Visible = True
        End Select
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCitizen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCitizen.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class