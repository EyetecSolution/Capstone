Partial Class DataSet1
    Partial Public Class DTPaymentDataTable
        Private Sub DTPaymentDataTable_DTPaymentRowChanging(sender As Object, e As DTPaymentRowChangeEvent) Handles Me.DTPaymentRowChanging

        End Sub

    End Class

    Partial Public Class DTScheduleDataTable
        Private Sub DTScheduleDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.sdayColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class DTNonResidencyDataTable
        Private Sub DTNonResidencyDataTable_DTNonResidencyRowChanging(sender As Object, e As DTNonResidencyRowChangeEvent) Handles Me.DTNonResidencyRowChanging

        End Sub

    End Class

    Partial Public Class DTBarangayClearanceDataTable
        Private Sub DTBarangayClearanceDataTable_DTBarangayClearanceRowChanging(sender As Object, e As DTBarangayClearanceRowChangeEvent) Handles Me.DTBarangayClearanceRowChanging

        End Sub

    End Class

    Partial Public Class DTResidentsDataTable
        Private Sub DTResidentsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.GENDERColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

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
