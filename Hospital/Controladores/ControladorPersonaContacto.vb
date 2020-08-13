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

    Function consultar(personaContacto As PersonaContacto) As List(Of sp_select_persona_contacto_Result)

        Try
            Using Almacen As New ProyectoEntities1
                Return Almacen.sp_select_persona_contacto(personaContacto.cedula).ToList

            End Using
        Catch ex As Exception
            MsgBox("Error:" + ex.ToString)
            Return Nothing
        End Try
    End Function
End Class
