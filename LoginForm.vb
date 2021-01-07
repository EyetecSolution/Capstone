Imports System.Data.OleDb

Public Class LoginForm

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Async Function LogUsers() As Task(Of Integer)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM tbl_users WHERE username = '" & TxtUsername.Text & "' AND userpass = '" & TxtPassword.Text & "' ", con)

            Dim count As Integer = Await cmd.ExecuteScalarAsync
            Return count
        End Using
    End Function

    Private Sub LoginForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            BtnLog.PerformClick()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim msg = MessageBox.Show("Close application?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If msg = vbYes Then
            End
        End If

    End Sub

    Private Sub TxtPassword_IconRightClick(sender As Object, e As EventArgs) Handles TxtPassword.IconRightClick
        'When TxtPassword icon right is click 

        If TxtPassword.UseSystemPasswordChar = True Then
            TxtPassword.IconRight = Image.FromFile("..\..\Resources\images\invisible_48px.png")
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
            TxtPassword.IconRight = Image.FromFile("..\..\Resources\images\icons8_eye_32.png")
        End If
    End Sub

    Private Async Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        Dim i As Integer = Await LogUsers()
        Dashboard.usern = TxtUsername.Text

        If i > 0 Then
            Timer1.Stop()
            Await Dashboard.RetrieveNotes
            Dashboard.LabelMarqueeText()
            Dashboard.Dt()
            Dashboard.OpenFormChild(HomeContent)
            Dashboard.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect username or password please check your credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsername.ResetText()
            TxtPassword.ResetText()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub
End Class
