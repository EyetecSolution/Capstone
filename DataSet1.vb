Partial Class DataSet1
    Partial Public Class DTSpes1DataTable
        Private Sub DTSpes1DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SCHOOLYEARColumn.ColumnName) Then
            End If

        End Sub

    End Class

    Partial Public Class DTSpesDataTable
        Private Sub DTSpesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FATHERNAMEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class DTOathDataTable
        Private Sub DTOathDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NORESIDINGColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class DTSoloParentDataTable
        Private Sub DTSoloParentDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DATEISSUEDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
