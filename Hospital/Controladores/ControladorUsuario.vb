Public Class ControladorUsuario


    Function Eliminar(usuario As Usuario) As Integer
        Dim result As Integer = 0

        Try

            Using almacen = New ProyectoEntities1()

                result = almacen.sp_eliminar_usuario(usuario.cedula).SingleOrDefault

            End Using


        Catch ex As Exception
            MsgBox("error al eliminar...")
            'MsgBox(ex)

        End Try



        Return result
    End Function


    Function Registrar(usuario As Usuario) As Integer
        Dim result As Integer = 0
        Try

            Using almacen = New ProyectoEntities1()

                result = almacen.sp_registrar_usuario(usuario.cedula, usuario.contrasena, usuario.correo, usuario.fechaNacimiento, usuario.nombre, usuario.nombreUsuario, usuario.telefono, usuario.tipo).SingleOrDefault

            End Using


        Catch ex As Exception
            MsgBox("error al agregar...")
            'MsgBox(ex)

        End Try

        Return result
    End Function




    Function Buscar(usuario As Usuario) As Usuario

        Dim usuario1 As Usuario = Nothing

        Try

            Using almacen = New ProyectoEntities1()

                Dim Result = almacen.sp_buscar_usuario(usuario.cedula).SingleOrDefault
                Result.



            End Using


        Catch ex As Exception
            MsgBox("error al buscar...")
            'MsgBox(ex)

        End Try

        Return usuario1

    End Function

End Class
