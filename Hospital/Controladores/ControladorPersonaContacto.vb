Public Class ControladorPersonaContacto

    Function registrar(personaContacto As PersonaContacto) As Boolean
        Try
            Using Almacen As New ProyectoEntities1
                Almacen.sp_registra
            End Using
        Catch ex As Exception

        End Try
    End Function
End Class
