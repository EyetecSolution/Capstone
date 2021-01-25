Imports System.Data.OleDb
Public Class BCHistory
    Public catTitle As String
    Public id As Integer = 1



    Public Async Function PaymentDetails(sql As String) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Using mycmd As New OleDbCommand(sql, con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                Payment.TxtName.Text = myReader("FULLNAME")
                Payment.TxtDate.Text = myReader("DATEISSUED")
                Payment.TxtAmount.Text = Format(myReader("FEES"), "0.00")
            End If
        End Using

    End Function

    Public Async Function RetrieveDataBarangayC(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT * FROM tbl_clearance  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                BClearance.TxtName.Text = myReader("FULLNAME")
                BClearance.TxtAddress.Text = myReader("FULLADDRESS")
                BClearance.CmbPurpose.Text = myReader("PURPOSE")
                BClearance.CmbPurpose.Text = myReader("DATEISSUED")
                BClearance.TxtCtc.Text = myReader("CTCNO")
                BClearance.TxtOR.Text = myReader("ORNO")

            End If
        End Using

    End Function

    Public Async Function RetrieveDataBusiness(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT * FROM tbl_business  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                BusinessClearance.TxtName.Text = myReader("FULLNAME")
                BusinessClearance.TxtAddress.Text = myReader("FULLADDRESS")
                BusinessClearance.TxtBusinessname.Text = myReader("BUSINESSNAME")
                BusinessClearance.TxtBusinesslocation.Text = myReader("BUSINESSLOCATION")
                BusinessClearance.DateTimePicker2.Value = myReader("DATEISSUED")
                BusinessClearance.TxtOr.Text = myReader("ORNO")
                BusinessClearance.TxtCtc.Text = myReader("CTCNO")
                BusinessClearance.DateTimePicker1.Value = myReader("VALIDITY")
                BusinessClearance.TxtAmount.Text = myReader("FEES")

            End If
        End Using

    End Function

    Public Async Function RetrieveDataIndigency(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT *FROM tbl_indigency  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                Indigency.TxtName.Text = myReader("FULLNAME")
                Indigency.TxtAddress.Text = myReader("FULLADDRESS")
                Indigency.CmbPurpose.Text = myReader("PURPOSE")
                Indigency.DateTimePicker1.Value = myReader("BIRTHDATE")
                Indigency.TxtAge.Text = myReader("AGE")
                Indigency.DateTimePicker2.Value = myReader("DATEISSUED")
                Indigency.CmbPurpose.Text = myReader("PURPOSE")
            End If
        End Using

    End Function

    Public Async Function RetrieveResidency(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT * FROM tbl_residency  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                Residency.TxtName.Text = myReader("FULLNAME")
                Residency.TxtAddress.Text = myReader("FULLADDRESS")
                Residency.TxtPurpose.Text = myReader("PURPOSE")
                Residency.DateTimePicker2.Value = myReader("DATEISSUED")
            End If
        End Using

    End Function

    Public Async Function RetrieveNonResidency(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT * FROM tbl_nonresidency  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                NonResidency.TxtName.Text = myReader("FULLNAME")
                NonResidency.TxtAddress.Text = myReader("FULLADDRESS")
                NonResidency.DateTimePicker2.Value = myReader("DATEISSUED")
            End If
        End Using

    End Function

    Public Async Function RetrieveSoloParent(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT *FROM tbl_soloparent  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                SoloParent.TxtName.Text = myReader("FULLNAME")
                SoloParent.TxtAddress.Text = myReader("FULLADDRESS")
                SoloParent.TxtChildNo.Text = myReader("NOOFCHILDREN")
                SoloParent.DateTimePicker2.Value = myReader("DATEISSUED")
            End If
        End Using

    End Function

    Public Async Function RetrieveOATH(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT *FROM tbl_oath WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                OATH.TxtName.Text = myReader("FULLNAME")
                OATH.TxtAddress.Text = myReader("FULLADDRESS")
                OATH.TxtResiding.Text = myReader("NORESIDING")
                OATH.CmbPurpose.Text = myReader("YEARMONTH")
                OATH.DateTimePicker2.Value = myReader("DATEISSUED")
                OATH.DateTimePicker1.Value = myReader("BIRTHDATE")
                OATH.TxtAge.Text = myReader("AGE")
                OATH.TxtWitness.Text = myReader("WITNESS")
            End If
        End Using

    End Function

    Public Async Function RetrieveSpes(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT * FROM tbl_spes  WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                Spes.TxtName.Text = myReader("FULLNAME")
                Spes.TxtAddress.Text = myReader("FULLADDRESS")
                Spes.TxtFather.Text = myReader("FATHERNAME")
                Spes.TxtMother.Text = myReader("MOTHERNAME")
                Spes.TxtOccu.Text = myReader("FATHEROCCU")
                Spes.TxtOccu1.Text = myReader("MOTHEROCCU")
                Spes.DateTimePicker2.Value = myReader("DATEISSUED")
            End If
        End Using

    End Function

    Public Async Function RetrieveSpes1(id As Integer) As Task
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("SELECT *FROM tbl_spes1 WHERE ID= @ID", con)
            mycmd.Parameters.AddWithValue("@ID", id)
            Dim myReader As OleDbDataReader = Await mycmd.ExecuteReaderAsync
            If myReader.Read Then
                Spes1.TxtName.Text = myReader("FULLNAME")
                Spes1.TxtAddress.Text = myReader("FULLADDRESS")
                Spes1.TxtSchoolYear.Text = myReader("SCHOOLYEAR")
                Spes1.TxtAge.Text = myReader("AGE")
                Spes1.DateTimePicker2.Value = myReader("DATEISSUED")
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
    Public Async Sub LoadBclearance()
        Dim sql As String = "SELECT * FROM tbl_clearance"
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

    Public Async Sub LoadIndigency()
        Dim sql As String = "SELECT * FROM tbl_indigency"
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

    Public Async Sub LoadNonRes()
        Dim sql As String = "SELECT * FROM tbl_nonresidency"
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

    Public Async Sub LoadRes()
        Dim sql As String = "SELECT * FROM tbl_residency"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("PURPOSE").HeaderText = "PURPOSE"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("FEES").HeaderText = "FEES"
        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("PURPOSE").Width = 200
        DataGridView1.Columns("DATEISSUED").Width = 150
        DataGridView1.Columns("FEES").Width = 70

    End Sub

    Public Async Sub LoadSoloParent()
        Dim sql As String = "SELECT * FROM tbl_soloparent"

        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("NOOFCHILDREN").HeaderText = "NO. OF CHILD"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"

        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("NOOFCHILDREN").Width = 200
        DataGridView1.Columns("DATEISSUED").Width = 150

    End Sub

    Public Async Sub LoadOATH()
        Dim sql As String = "SELECT * FROM tbl_oath"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("NORESIDING").HeaderText = "NO. OF RESIDING"
        DataGridView1.Columns("YEARMONTH").HeaderText = "YEARMONTH"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("AGE").HeaderText = "AGE"

        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("NORESIDING").Width = 250
        DataGridView1.Columns("YEARMONTH").Width = 100
        DataGridView1.Columns("DATEISSUED").Width = 150
        DataGridView1.Columns("AGE").Width = 150

    End Sub

    Public Async Sub LoadSpes()
        Dim sql As String = "SELECT * FROM tbl_spes"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("FATHERNAME").HeaderText = "FATHER NAME"
        DataGridView1.Columns("MOTHERNAME").HeaderText = "MOTHER NAME"
        DataGridView1.Columns("FATHEROCCU").HeaderText = "FATHER OCCUPATION"
        DataGridView1.Columns("MOTHEROCCU").HeaderText = "MOTHER OCCUPATION"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"

        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("FATHERNAME").Width = 200
        DataGridView1.Columns("MOTHERNAME").Width = 200
        DataGridView1.Columns("FATHEROCCU").Width = 200
        DataGridView1.Columns("MOTHEROCCU").Width = 200
        DataGridView1.Columns("DATEISSUED").Width = 150

    End Sub

    Public Async Sub LoadSpes1()
        Dim sql As String = "SELECT * FROM tbl_spes1"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("FULLADDRESS").HeaderText = "FULL ADDRESS"
        DataGridView1.Columns("AGE").HeaderText = "AGE"
        DataGridView1.Columns("SCHOOLYEAR").HeaderText = "SCHOOL YEAR"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"

        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("FULLADDRESS").Width = 500
        DataGridView1.Columns("AGE").Width = 70
        DataGridView1.Columns("SCHOOLYEAR").Width = 150
        DataGridView1.Columns("DATEISSUED").Width = 150

    End Sub

    Public Async Sub LoadBusinessClearance()
        Dim sql As String = "SELECT * FROM tbl_business"
        Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
        DataGridView1.DataSource = dtsample
        DataGridView1.Columns("FULLNAME").HeaderText = "FULL NAME"
        DataGridView1.Columns("BUSINESSNAME").HeaderText = "BUSINESS NAME"
        DataGridView1.Columns("BUSINESSLOCATION").HeaderText = "BUSINESS LOCATION"
        DataGridView1.Columns("DATEISSUED").HeaderText = "DATE ISSUED"
        DataGridView1.Columns("ORNO").HeaderText = "OR NO."
        DataGridView1.Columns("CTCNO").HeaderText = "CTC NO."
        DataGridView1.Columns("VALIDITY").HeaderText = "VALIDITY"
        DataGridView1.Columns("FEES").HeaderText = "FEES"

        DataGridView1.Columns("ID").Width = 40
        DataGridView1.Columns("FULLNAME").Width = 200
        DataGridView1.Columns("BUSINESSNAME").Width = 400
        DataGridView1.Columns("BUSINESSLOCATION").Width = 500
        DataGridView1.Columns("DATEISSUED").Width = 150
        DataGridView1.Columns("ORNO").Width = 100
        DataGridView1.Columns("CTCNO").Width = 100
        DataGridView1.Columns("VALIDITY").Width = 100
        DataGridView1.Columns("FEES").Width = 70

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
            Case "businessc"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(BusinessClearance)
            Case "indigency"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Indigency)
            Case "non-residency"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(NonResidency)
            Case "residency"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Residency)
            Case "solo-parent"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(SoloParent)
            Case "OATH"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(OATH)
            Case "SPES"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Spes)
            Case "SPES1"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Spes1)
        End Select
    End Sub

    Private Async Sub BCHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sql As String = "SELECT COUNT(*) FROM tbl_clearance"
        Dim sqlx As String = "SELECT COUNT(*) FROM tbl_business"
        Dim sql1 As String = "SELECT COUNT(*) FROM tbl_indigency"
        Dim sql2 As String = "SELECT COUNT(*) FROM tbl_nonresidency"
        Dim sql3 As String = "SELECT COUNT(*) FROM tbl_residency"
        Dim sql4 As String = "SELECT COUNT(*) FROM tbl_soloparent"
        Dim sql5 As String = "SELECT COUNT(*) FROM tbl_oath"
        Dim sql6 As String = "SELECT COUNT(*) FROM tbl_spes"
        Dim sql7 As String = "SELECT COUNT(*) FROM tbl_spes1"

        Select Case catTitle
            Case "Barangay Clearance"
                LoadBclearance()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql))
            Case "businessc"
                LoadBusinessClearance()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sqlx))
            Case "indigency"
                LoadIndigency()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql1))
            Case "non-residency"
                LoadNonRes()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql2))
            Case "residency"
                LoadRes()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql3))
            Case "solo-parent"
                LoadSoloParent()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql4))
            Case "OATH"
                LoadOATH()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql5))
            Case "SPES"
                LoadSpes()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql6))
            Case "SPES1"
                LoadSpes1()
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", Await LoadDataCount(sql7))
        End Select

    End Sub

    Private Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Select Case catTitle
            Case "Barangay Clearance"
                Dim sql As String = "SELECT * FROM tbl_clearance WHERE FULLNAME LIKE '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "businessc"
                Dim sql As String = "SELECT * FROM tbl_business '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "indigency"
                Dim sql As String = "SELECT * FROM tbl_indigency '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "non-residency"
                Dim sql As String = "SELECT * FROM tbl_nonresidency '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "residency"
                Dim sql As String = "SELECT * FROM tbl_residency '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "solo-parent"
                Dim sql As String = "SELECT * FROM tbl_soloparent '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "OATH"
                Dim sql As String = "SELECT * FROM tbl_oath '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)

            Case "SPES"
                Dim sql As String = "SELECT * FROM tbl_spes '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
            Case "SPES1"
                Dim sql As String = "SELECT * FROM tbl_spes1 '" & TxtSearch.Text & "%' OR DATEISSUED  LIKE '" & TxtSearch.Text & "%'"
                Dim dtsample As DataTable = Await Task(Of DataTable).Run(Function() LoadDataTable(sql))
                DataGridView1.DataSource = dtsample
                LblCount.Text = String.Format("TRANSACTION COUNT: ( {0} )", DataGridView1.Rows.Count)
        End Select


    End Sub



    Private Async Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Select Case catTitle
            Case "Barangay Clearance"
                Await RetrieveDataBarangayC(id)
                BClearance.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(BClearance)
            Case "businessc"
                Await RetrieveDataBusiness(id)
                BusinessClearance.BtnSave.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(BusinessClearance)
            Case "indigency"
                Await RetrieveDataIndigency(id)
                Indigency.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Indigency)
            Case "non-residency"
                Await RetrieveNonResidency(id)
                NonResidency.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(NonResidency)
            Case "residency"
                Await RetrieveResidency(id)
                Residency.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Residency)
            Case "solo-parent"
                Await RetrieveSoloParent(id)
                SoloParent.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(SoloParent)
            Case "OATH"
                Await RetrieveOATH(id)
                OATH.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(OATH)
            Case "SPES"
                Await RetrieveSpes(id)
                Spes.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Spes)
            Case "SPES1"
                Await RetrieveSpes1(id)
                Spes1.BtnS.Text = "UPDATE"
                Dashboard.activefrm.Hide()
                Dashboard.OpenFormChild(Spes1)
        End Select

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
                id = selectedRow.Cells(0).Value
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(FormDocument)
    End Sub
End Class