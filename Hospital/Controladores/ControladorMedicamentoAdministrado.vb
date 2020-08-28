Public Class ControladorMedicamentoAdministrado

    Function registrar(medicamento As MedicamentoAdministrado) As Boolean
        Try
            Using almacen As New ProyectoEntities1
                If almacen.sp_registrar_medicamento_administrado(medicamento.id_consulta, medicamento.medicamento).SingleOrDefault = 1 Then
                    Return True
                End If

            End Using

        Catch ex As Exception

        End Try
        Return False
    End Function
End Class
