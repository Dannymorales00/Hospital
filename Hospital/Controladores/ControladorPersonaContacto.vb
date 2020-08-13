Public Class ControladorPersonaContacto

    Function registrar(personaContacto As PersonaContacto) As Boolean
        Try
            Using Almacen As New ProyectoEntities1
                Almacen.sp_registrar_persona_contacto(personaContacto.cedula, personaContacto.nombreCompleto, personaContacto.relacionFamiliar, personaContacto.telefono, personaContacto.direccion, personaContacto.cedulaPaciente)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
