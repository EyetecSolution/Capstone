Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Dashboard
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    ReadOnly sqlQuery As String = Nothing
    ReadOnly cmd As New OleDbCommand
    Public usern As String = Nothing
    Public activefrm As Form
    'Slider Transition
    Private Sub SliderTransition(ByVal wth As Integer, ByVal state As Boolean)
        PanelSlider.Width = wth
        PanelSlider.Visible = state
    End Sub

    'Clean before slide 
    Private Sub CleanButton()
        Dim arrCtrl() As Guna.UI2.WinForms.Guna2Button =
        {BtnHome, BtnBM, BtnCert, BtnResidents, BtnRecords, BtnPayment, BtnCovid, BtnUsers}
        For Each myctrl As Guna.UI2.WinForms.Guna2Button In arrCtrl
            myctrl.FillColor = Color.Maroon
        Next
    End Sub

    'Change Panel Content
    Private Sub BtnSlide_Click(sender As Object, e As EventArgs) Handles BtnSlide.Click
        If PanelSlider.Width = 366 Then
            HomeContent.CovidPanel.Visible = False
            HomeContent.PanelSlide.Dock = DockStyle.Fill
            BtnSlide.Image = Image.FromFile("..\..\Resources\images\forward_48px.png")
            LabelNotes.Visible = False
            PanelNotes.Visible = False
            SliderTransition(50, True)
            BtnSlide.Location = New Point(10)
            SeparatorLine.Visible = False
            FormDocument.addSpaces()

        Else
            CleanButton()
            HomeContent.CovidPanel.Visible = True
            HomeContent.PanelSlide.Dock = DockStyle.Top
            HomeContent.CovidPanel.Dock = DockStyle.Top
            BtnSlide.Image = Image.FromFile("..\..\Resources\images\back_48px.png")
            LabelNotes.Visible = True
            PanelNotes.Visible = True
            SliderTransition(366, True)
            BtnSlide.Location = New Point(162, 33)
            SeparatorLine.Visible = True
            SeparatorLine.SendToBack()
            FormDocument.removeSpace()

        End If
    End Sub
    'Time and LabelMarquee animation
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim tme As DateTime = DateTime.Now


        LabelTime.Text = "TIME: " + tme.ToLongTimeString()


        If LabelMarque.Location.X + LabelMarque.Width < 0 Then
            LabelMarque.Location = New Point(Guna2Panel7.Width, LabelMarque.Location.Y)
        Else
            LabelMarque.Location = New Point(LabelMarque.Location.X - 3, LabelMarque.Location.Y)
        End If

        LabelMarqueeText()


    End Sub

    'Date
    Public Sub Dt()
        Dim mydt As DateTime = Date.Now
        Dim frmt As String = "ddd, MMM dd yyyy"

        LabelDate.Text = mydt.ToString(frmt)

    End Sub

    'Savenotes into dbase
    Async Function SaveNotes() As Task(Of Integer)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE notes 
                                         SET fld_notes = '" & TxtNotes.Text & "'
                                         WHERE ID=1", con)
            Dim i As Integer = Await mycmd.ExecuteNonQueryAsync
            Return i
        End Using

    End Function

    'Save Notes
    Private Async Sub BtnSaveNotes_Click(sender As Object, e As EventArgs) Handles BtnSaveNotes.Click

        Try
            Dim saveNoteResult As Integer = Await SaveNotes()
            If TxtNotes.Text <> "" Then
                If saveNoteResult > 0 Then
                    MessageBox.Show("Notes save successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Nothing to save to your notes!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try

    End Sub

    Public Async Function RetrieveNotes() As Task

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Using mycmd As New OleDbCommand("SELECT fld_notes FROM notes WHERE ID=1", con)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                TxtNotes.Text = myReader("fld_notes")
            End If
        End Using
    End Function

    'LabelMarqueeText
    Public Sub LabelMarqueeText()
        Dim current As DateTime = DateTime.Now
        If current.Hour < 12 Then
            LabelMarque.Text = "BARANGAY SAN MIGUEL, INFORMATION MANAGEMENT SYSTEM " + " GOOD MORNING " '+ usern.ToUpper + "!"
        ElseIf current.Hour < 18 And current.Hour >= 12 Then
            LabelMarque.Text = "BARANGAY SAN MIGUEL, INFORMATION MANAGEMENT SYSTEM " + " GOOD AFTERNOON " ' + usern.ToUpper + "!"
        Else
            LabelMarque.Text = "BARANGAY SAN MIGUEL, INFORMATION MANAGEMENT SYSTEM " + " GOOD EVENING  " '+ usern.ToUpper + "!"
        End If
    End Sub

    Private Sub BtnBM_Click(sender As Object, e As EventArgs) Handles BtnBM.Click
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnBM)
        End If


    End Sub

    Private Sub ActiveButton(ctrl As Guna.UI2.WinForms.Guna2Button)
        Dim arrCtrl() As Guna.UI2.WinForms.Guna2Button =
        {BtnHome, BtnBM, BtnCert, BtnResidents, BtnRecords, BtnPayment, BtnCovid, BtnUsers}



        For Each myctrl As Guna.UI2.WinForms.Guna2Button In arrCtrl
            If myctrl.Name = ctrl.Name Then
                myctrl.FillColor = Color.FromArgb(255, 204, 0)
            Else
                myctrl.FillColor = Color.Maroon
            End If

        Next
    End Sub

    Public Function OpenFormChild(frm As Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        PanelContent.Controls.Add(frm)
        frm.Show()
        activefrm = frm
        Return activefrm
    End Function
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        activefrm.Close()
        OpenFormChild(HomeContent)
        HomeContent.CovidPanel.Visible = True
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnHome)
            PanelContent.Controls.Clear()
            OpenFormChild(HomeContent)
            HomeContent.PanelSlide.Dock = DockStyle.Fill
            HomeContent.CovidPanel.Visible = False
        End If
    End Sub

    Private Sub BtnCert_Click(sender As Object, e As EventArgs) Handles BtnCert.Click
        activefrm.Close()
        OpenFormChild(FormDocument)
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnCert)
        End If
    End Sub

    Private Sub BtnResidents_Click(sender As Object, e As EventArgs) Handles BtnResidents.Click
        activefrm.Close()
        OpenFormChild(residents)
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnResidents)
        End If
    End Sub

    Private Sub BtnRecords_Click(sender As Object, e As EventArgs) Handles BtnRecords.Click
        activefrm.Close()
        OpenFormChild(BlotterRecords)
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnRecords)
        End If
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click

        If PanelSlider.Width = 50 Then
            ActiveButton(BtnPayment)
        End If
    End Sub

    Private Sub BtnCovid_Click(sender As Object, e As EventArgs) Handles BtnCovid.Click
        activefrm.Close()
        OpenFormChild(CovidCases)
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnCovid)
        End If
    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        activefrm.Close()
        OpenFormChild(useraccount)
        If PanelSlider.Width = 50 Then
            ActiveButton(BtnUsers)
        End If
    End Sub
    'Form closing events
    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim msgboxresponse As MsgBoxResult
        If e.CloseReason = CloseReason.UserClosing Then
            msgboxresponse = MsgBox("Logging out?",
                                MsgBoxStyle.Question + MsgBoxStyle.YesNo, "IMS")
            If msgboxresponse <> MsgBoxResult.Yes Then
                e.Cancel = True
                Return
            Else
                LoginForm.Show()
            End If
        End If
    End Sub
    'Marque Timer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LabelMarqueeText()
        Timer2.Stop()
    End Sub
    Private Sub LabelMarque_TextChanged(sender As Object, e As EventArgs) Handles LabelMarque.TextChanged

        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomeContent.CovidPanel.Visible = True
    End Sub

End Class