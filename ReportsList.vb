Imports System.Data.OleDb
Public Class ReportsList

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

    Private Async Sub loadData(sql As String)
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        If RdBClearance.Checked = True Then
            loadData("SELECT * FROM tbl_clearance")
        ElseIf RdBusinessC.Checked = True Then
            'loadData("SELECT * FROM tbl_bclearance")
        ElseIf RdIndigency.Checked = True Then
            loadData("SELECT * FROM tbl_indigency")
        ElseIf RdResidency.Checked = True Then
            loadData("SELECT * FROM tbl_residency")
        ElseIf RdNonRes.Checked = True Then
            loadData("SELECT * FROM tbl_nonresidency")
        ElseIf RdSoloParent.Checked = True Then
            loadData("SELECT * FROM tbl_soloparent")
        ElseIf RdSpes.Checked = True Then
            loadData("SELECT * FROM tbl_spes")
        End If
    End Sub

    Private Sub BtnShowAll_Click(sender As Object, e As EventArgs) Handles BtnShowAll.Click
        loadData("SELECT ID, FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION
                             FROM tbl_residents")
    End Sub

    Private Sub CmbStreet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStreet.SelectedIndexChanged

    End Sub

    Private Sub CmbStreet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbStreet.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        loadData("SELECT ID, FULLNAME, FULLADDRESS, BIRTHPLACE, BIRTHDATE, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, OCCUPATION FROM tbl_residents WHERE FULLADDRESS LIKE '%" & CmbStreet.Text & "%'")
    End Sub
End Class