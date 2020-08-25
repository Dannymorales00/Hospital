Public Class ControladorCita
    Private cita As Citas
    Public Function registrar(cita As Citas) As Integer
        Dim result As Integer = 0
        Try
            Using almacen As New ProyectoEntities1
                result = almacen.sp_registrar_cita(cita.especialidadSolicitada, cita.fechaHora, cita.paciente.cedula, cita.medico.cedula).SingleOrDefault
            End Using
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Function eliminar(cita As Citas) As Integer
        Dim result As Integer = 0
        Try
            Using almacen As New ProyectoEntities1
                result = almacen.sp_eliminar_cita(cita.id).SingleOrDefault
            End Using
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Function actualizar(cita As Citas) As Integer
        Dim result As Integer = 0
        Try
            Using almacen As New ProyectoEntities1
                result = almacen.sp_update_cita(cita.id, cita.especialidadSolicitada, cita.fechaHora, cita.paciente.cedula, cita.medico.cedula).SingleOrDefault
            End Using
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Function buscarCitas(cita As Citas) As List(Of sp_select_citas_Result)
        Try
            Using almacen As New ProyectoEntities1
                Return almacen.sp_select_citas(cita.paciente.cedula.ToString).ToList
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function buscarCitasHoy() As List(Of sp_buscar_citas_Result)
        Try
            Using almacen As New ProyectoEntities1
                Return almacen.sp_buscar_citas().ToList
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
