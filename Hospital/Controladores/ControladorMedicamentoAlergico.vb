Public Class ControladorMedicamentoAlergico

    Function registrar(alergico As MedicamentoAlergico) As Boolean
        Try
            Using Almacen As New ProyectoEntities1
                Almacen.sp_registrar_medicamento_alergico(alergico.cedulaPaciente, alergico.id)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function consultar(alergico As MedicamentoAlergico) As List(Of sp_select_medicamento_alergico_Result)
        Try
            Using Almacen As New ProyectoEntities1
                Return Almacen.sp_select_medicamento_alergico().ToList
            End Using
        Catch ex As Exception
            MsgBox("Error:" + ex.ToString)
            Return Nothing
        End Try
    End Function

    Function eliminar(alergico As MedicamentoAlergico) As Boolean
        Try
            Using Almacen As New ProyectoEntities1
                Almacen.sp_eliminar_medicamento_alergico(alergico.id)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
