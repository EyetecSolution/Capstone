Imports System.IO
Imports System.Data.OleDb

Public Class HomeContent
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public Async Function LoadDataTable(sql As String) As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand(sql, con)
            i = Await mycmd.ExecuteScalarAsync
        End Using
        Return i
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ImageSlider1.SlideNext()
    End Sub

    Private Sub ImageSlider1_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles ImageSlider1.ContextButtonClick
        Dim currentBtn As String = e.Item.Name
        Select Case currentBtn
            Case "AddPhotos"
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    Dim mypath As String = FolderBrowserDialog1.SelectedPath
                    Dim filters As String() = {"*.jpg", "*.png"}
                    Dim filePaths As String() = filters.SelectMany(Function(f) Directory.GetFiles(mypath, f)).ToArray()
                    If filePaths.Length > 0 Then
                        ImageSlider1.Images.Clear()
                        For Each fle As String In filePaths
                            ImageSlider1.Images.Add(Image.FromFile(fle))
                        Next
                        MessageBox.Show("Images loaded successfully!", "ims", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("There's something wrong with the directory check if contains of images", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If


        End Select
    End Sub

    Private Async Sub HomeContent_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sql1 As String = "SELECT COUNT(*) FROM tbl_covid WHERE CONDITION='CONFIRMED'"
        Dim sql2 As String = "SELECT COUNT(*) FROM tbl_covid WHERE CONDITION='PUI'"
        Dim sql3 As String = "SELECT COUNT(*) FROM tbl_covid WHERE CONDITION='PUM(ONGOING)'"
        Dim sql4 As String = "SELECT COUNT(*) FROM tbl_covid WHERE CONDITION='PUM(CLEAR)'"
        Dim sql5 As String = "SELECT COUNT(*) FROM tbl_covid WHERE CONDITION='DEATH'"
        Dim sql6 As String = "SELECT COUNT(*) FROM tbl_covid WHERE CONDITION='RECOVERED'"
        LblConfirmed.Text = Await LoadDataTable(sql1)
        LblPUI.Text = Await LoadDataTable(sql2)
        LblPUMO.Text = Await LoadDataTable(sql3)
        LblPUMC.Text = Await LoadDataTable(sql4)
        LblDeath.Text = Await LoadDataTable(sql5)
        LblRecovered.Text = Await LoadDataTable(sql6)
    End Sub
End Class