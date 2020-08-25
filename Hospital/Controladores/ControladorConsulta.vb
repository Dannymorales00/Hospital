Public Class ControladorConsulta

    Function registrarEnfermera(consulta As ConsultaMedica) As Boolean
        Try
            Using almacen As New ProyectoEntities1
                almacen.sp_registrar_consulta(consulta.idCitas, consulta.presion, consulta.peso, consulta.altura, consulta.sintomas)
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Error al agregar Consulta")
        End Try
        Return False
    End Function

    Function buscarConsultasHoy(medico As Medico) As List(Of sp_buscar_consulta_Result)
        Try
            Using almacen As New ProyectoEntities1
                almacen.sp_buscar_consulta(medico.cedula).ToList
            End Using
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

End Class
