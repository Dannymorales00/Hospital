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


End Class
