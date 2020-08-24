Public Class ControladorMedicamentos

    Private medicamentos As Medicamentos

    Public Function buscarMedicamentos(medicamentos As Medicamentos) As List(Of sp_select_medicamentos_Result)
        Try
            Using almacen As New ProyectoEntities1
                Return almacen.sp_select_medicamentos().ToList
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
