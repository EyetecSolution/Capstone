Imports System.Data.OleDb
Public Class Payment
    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Public category As String
    Public tblparam As String = Nothing
    Async Function UpdateQuery(sql As String) As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand(sql, con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function
    Private Async Sub LoadMe()
        Dim sql As String = "SELECT * FROM tbl_payment"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("fname").Width = 100
        DataGridView1.Columns("faddress").Width = 200
        DataGridView1.Columns("dateissued").Width = 100
        DataGridView1.Columns("amount").Width = 100
        DataGridView1.Columns("cash").Width = 100
        DataGridView1.Columns("category").Width = 200
        DataGridView1.Columns("change").Width = 100
        DataGridView1.Columns("fname").HeaderText = "FULL NAME"
        DataGridView1.Columns("faddress").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("dateissued").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("amount").HeaderText = "AMOUNT"
        DataGridView1.Columns("cash").HeaderText = "CASH"
        DataGridView1.Columns("category").HeaderText = "CATEGORY"
        DataGridView1.Columns("change").HeaderText = "CHANGE"





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

    Private Sub TxtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAddress.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtChange_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtChange.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCash.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If TxtCash.Text = "" Then TxtChange.Text = "0.00"
    End Sub

    Private Async Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtCash.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetTextfield()
            LoadMe()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub



    Async Function InsertQuery() As Task(Of Integer)
        Dim dtfrmat As String = "MM-dd-yyyy"
        Dim dt As DateTime = CDate(TxtDate.Text)

        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_payment(fname,faddress, dateissued, amount, cash, category, change)" &
                                         " VALUES(@fname, @faddress, @dateissued, @amount, @cash, @category, @change)", con)
            mycmd.Parameters.AddWithValue("fname", TxtName.Text)
            mycmd.Parameters.AddWithValue("faddress", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("dateissued", dt.ToString(dtfrmat))
            mycmd.Parameters.AddWithValue("amount", CInt(TxtAmount.Text))
            mycmd.Parameters.AddWithValue("cash", CInt(TxtCash.Text))
            mycmd.Parameters.AddWithValue("category", category)
            mycmd.Parameters.AddWithValue("change", CDbl(TxtChange.Text))

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Public Sub ResetTextfield()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtDate.ResetText()
        TxtAmount.ResetText()
        TxtCash.ResetText()
        TxtChange.ResetText()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Select Case category
            Case "BARANGAY CLEARANCE"
                BCHistory.LoadBclearance()
            Case "BUSINESS CLEARANCE"
                BCHistory.LoadBusinessClearance()
            Case "CERTIFICATE OF NON-RESIDENCY"
                BCHistory.LoadNonRes()
            Case "CERTIFICATE OF RESIDENCY"
                BCHistory.LoadNonRes()
            Case "CERTIFICATE OF SOLO PARENT"
                BCHistory.LoadSoloParent()
        End Select
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub

    Private Sub TxtChange_TextChanged(sender As Object, e As EventArgs) Handles TxtChange.TextChanged

    End Sub

    Private Sub TxtCash_TextChanged(sender As Object, e As EventArgs) Handles TxtCash.TextChanged

        TxtChange.Text = Format(Val(TxtCash.Text) - Val(TxtAmount.Text), "0.00")

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMe()
    End Sub

    Private Async Sub CmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategory.SelectedIndexChanged


        Dim sql As String = "SELECT * FROM tbl_payment WHERE category LIKE '" & CmbCategory.SelectedItem & "'"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
    End Sub


End Class