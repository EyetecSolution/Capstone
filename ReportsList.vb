Imports System.Data.OleDb
Public Class ReportsList
    Public chkLoad As String
    Public chkStreet As Boolean
    Public chkDate As Boolean
    Public dbase As DataTable
    Private Async Sub LoadDbase(sql As String)
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        dbase = dtsample
    End Sub





    Public Function LoadDataTable(sql As String) As DataTable
        Dim dt = New DataTable
        Try
            Using dbcon As New OleDbConnection(My.Settings.strCon)
                Using cmd As New OleDbCommand(sql, dbcon)
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

    Public Sub LoadReport(dgv As DataGridView, spath As String, loadTable As String)
        ReportViewer.ReportLoad(dgv, spath, loadTable)
        ReportViewer.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Select Case CmbPurpose.SelectedIndex
            Case 0
                LoadReport(DataGridView1, "C:\Capstone\Reports\ResidentReport.rdlc", "DTResidents")
            Case 1
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportBClearance.rdlc", "DTBarangayClearance")
            Case 2
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportBusinessClearance.rdlc", "DTBusinessClearance")
            Case 3
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportNonResidency.rdlc", "DTIndigency")
            Case 4
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportNonResidency.rdlc", "DTNonResidency")
            Case 5
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportResidency.rdlc", "DTResidency")
            Case 6
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportSoloParent.rdlc", "DTSoloParent")
            Case 7
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportOath.rdlc", "DTSpes")
            Case 8
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportSPES.rdlc", "DTSpes1")
            Case 9
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportSpes1.rdlc", "DTPayment")
            Case 10
                LoadReport(DataGridView1, "C:\Capstone\Reports\ReportTotal.rdlc", "DTPayment")
        End Select



    End Sub



    Private Sub CmbPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPurpose.SelectedIndexChanged
        If CmbPurpose.SelectedIndex = 0 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION FROM tbl_residents")
        ElseIf CmbPurpose.SelectedIndex = 1 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, PURPOSE, DATEISSUED, CTCNO, ORNO FROM tbl_clearance")
        ElseIf CmbPurpose.SelectedIndex = 2 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, BUSINESSNAME, BUSINESSLOCATION, DATEISSUED, ORNO, CTCNO FROM tbl_business")
        ElseIf CmbPurpose.SelectedIndex = 3 Then
            LoadDbase("SELECT FULLNAME, FULLNAME, FULLADDRESS, BIRTHDATE, AGE, DATEISSUED, PURPOSE FROM tbl_indigency")
        ElseIf CmbPurpose.SelectedIndex = 4 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, DATEISSUED FROM tbl_nonresidency")
        ElseIf CmbPurpose.SelectedIndex = 5 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, PURPOSE, DATEISSUED  FROM tbl_residency")
        ElseIf CmbPurpose.SelectedIndex = 6 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, NOOFCHILDREN, DATEISSUED FROM tbl_soloparent")
        ElseIf CmbPurpose.SelectedIndex = 7 Then
            LoadDbase("SELECT * FROM tbl_oath")
        ElseIf CmbPurpose.SelectedIndex = 8 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, FATHERNAME, MOTHERNAME, FATHEROCCU, MOTHEROCCU, DATEISSUED FROM tbl_spes")
        ElseIf CmbPurpose.SelectedIndex = 9 Then
            LoadDbase("SELECT FULLNAME, FULLADDRESS, AGE, SCHOOLYEAR, DATEISSUED FROM tbl_spes1")
        ElseIf CmbPurpose.SelectedIndex = 10 Then
            LoadDbase("SELECT fname, DATEISSUED, total_amount, issued_document FROM tbl_payment")
        End If
    End Sub

    Private Sub CmbStreets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStreets.SelectedIndexChanged
        If CmbPurpose.Text = "SELECT REPORT" Then
            MessageBox.Show("Please select report before searching the street Thank you!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If CmbPurpose.SelectedIndex = 10 Then
            MessageBox.Show("No [FULLADDRESS] Field From " & CmbPurpose.SelectedItem, "Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        dbase.DefaultView.RowFilter = "FULLADDRESS Like '%" & CmbStreets.SelectedItem & "%'"

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DTFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTFrom.ValueChanged
        If CmbPurpose.SelectedIndex = 0 Then
            MessageBox.Show("No [DATEISSUED] Field From " & CmbPurpose.SelectedItem, "Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CmbPurpose.SelectedIndex = -1 Then
            MessageBox.Show("Nothing to search...", "Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        dbase.DefaultView.RowFilter = "DATEISSUED = '" & DTFrom.Value.ToString("M/d/yyyy") & "'"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DTTo_ValueChanged(sender As Object, e As EventArgs) Handles DTTo.ValueChanged
        If CmbPurpose.SelectedIndex = 0 Then
            MessageBox.Show("No [DATEISSUED] Field FROM " & CmbPurpose.SelectedItem, "Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CmbPurpose.SelectedIndex = -1 Then
            MessageBox.Show("Nothing to search...", "Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        dbase.DefaultView.RowFilter = "DATEISSUED >= '" & DTFrom.Value.ToString("M/d/yyyy") & "' and DATEISSUED <= '" & DTTo.Value.ToString("M/d/yyyy") & "'"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


End Class