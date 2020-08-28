Public Class ControladorMedicamentoRecetado

    Function registrar(medicamento As MedicamentoRecetado) As Boolean
        Try
            Using almacen As New ProyectoEntities1
                If almacen.sp_registrar_medicamentos_recetados(medicamento.id_consulta, medicamento.medicamento).SingleOrDefault = 1 Then
                    Return True
                End If
            End Using


        Catch ex As Exception

        End Try
        Return False
    End Function

End Class
