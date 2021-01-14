Imports System.Data.OleDb
Public Class BCHistory
    Public catTitle As String
    Public id As Integer

    Public Async Function RetrieveData() As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If




        Using mycmd As New OleDbCommand("SELECT *
                                         FROM tbl_clearance 
                                         WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                Payment.TxtName.Text = myReader("FULLNAME")
                Payment.TxtAddress.Text = myReader("FULLADDRESS")
                Payment.TxtDate.Text = myReader("DATEISSUED")
                Payment.TxtAmount.Text = Format(myReader("FEES"), "0.00")
            End If
        End Using

    End Function

    Public Async Function LoadDataCount(sql As String) As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand(sql, con)
            i = Await mycmd.ExecuteScalarAsync
        End Using
        Return i
    End Function

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Async Sub LoadBclearance()
        Dim sql As String = "SELECT * 
                             FROM tbl_clearance"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("PURPOSE").Width = 500
        DataGridView1.Columns("DATEISSUED").Width = 200
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("ISSUEDAT").Width = 200
        DataGridView1.Columns("ISSUEDAT").HeaderText = "ISSUED AT"
        DataGridView1.Columns("CTCNO").HeaderText = "CTC. No."
        DataGridView1.Columns("ORNO").HeaderText = "O.R No."
        DataGridView1.Columns("ORNO").HeaderText = "O.R No."
    End Sub

    Private Async Sub LoadIndigency()
        Dim sql As String = "SELECT * 
                             FROM tbl_indigency"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("AGE").Width = 70
        DataGridView1.Columns("DATEISSUED").Width = 150
        DataGridView1.Columns("PURPOSE").Width = 200

    End Sub

    Private Async Sub LoadNonRes()
        Dim sql As String = "SELECT * 
                             FROM tbl_nonresidency"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("DATEISSUED").Width = 150
        DataGridView1.Columns("ISSUEDAT").Width = 200

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
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Select Case catTitle
            Case "Barangay Clearance"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(BClearance)
            Case "indigency"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Indigency)
            Case "non-residency"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(NonResidency)
            Case "residency"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Residency)
        End Select
    End Sub

    Private Async Sub BCHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sql As String = "SELECT COUNT(*) FROM tbl_clearance"
        LblCount.Text = $"TRANSACTION COUNT ( {Await LoadDataCount(sql)} )"

        Select Case catTitle
            Case "Barangay Clearance"
                LoadBclearance()
            Case "indigency"
                LoadIndigency()
            Case "non-residency"
                LoadNonRes()
            Case "residency"
        End Select
    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Select Case catTitle
            Case "Barangay Clearance"
                Dim sql As String = "SELECT * FROM tbl_clearance
                              WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR
                                    DATEISSUED  LIKE '" & TxtSearch.Text & "%'"

                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = $"TRANSACTION COUNT ( {DataGridView1.Rows.Count} )"
            Case "indigency"
                Dim sql As String = "SELECT * FROM tbl_indigency
                              WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR
                                    DATEISSUED  LIKE '" & TxtSearch.Text & "%'"

                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = $"TRANSACTION COUNT ( {DataGridView1.Rows.Count} )"
            Case "non-residency"
                Dim sql As String = "SELECT * FROM tbl_nonresidency
                              WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR
                                    DATEISSUED  LIKE '" & TxtSearch.Text & "%'"

                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = $"TRANSACTION COUNT ( {DataGridView1.Rows.Count} )"
            Case "residency"
                Dim sql As String = "SELECT * FROM tbl_residency
                              WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR
                                    DATEISSUED  LIKE '" & TxtSearch.Text & "%'"

                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = $"TRANSACTION COUNT ( {DataGridView1.Rows.Count} )"
        End Select


    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click

    End Sub

    Private Async Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        Dashboard.activefrm.Hide()
        Dashboard.OpenFormChild(Payment)
        Await RetrieveData()
        Payment.category = "BARANGAY CLEARANCE"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        Try

            index = e.RowIndex
            If index = -1 Then
                Exit Sub
            Else
                Dim selectedRow As DataGridViewRow
                selectedRow = DataGridView1.Rows(index)
                id = selectedRow.Cells(1).Value
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class