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
                usuario1 = New Usuario()
                usuario1.cedula = Result.cedula
                usuario1.contrasena = Result.contraseña
                usuario1.correo = Result.correo
                usuario1.fechaNacimiento = Result.fechaNacimiento
                usuario1.nombre = Result.nombre
                usuario1.nombreUsuario = Result.nombreUsuario
                usuario1.telefono = Result.telefono
                usuario1.tipo = Result.tipo


            End Using


        Catch ex As Exception
            'MsgBox("error al buscar...")
            'MsgBox(ex)

        End Try

        Return usuario1

    End Function



    Function Actualizar(usuario As Usuario) As Integer
        Dim result As Integer = 0
        Try

            Using almacen = New ProyectoEntities1()

                result = almacen.sp_actualizar_usuario(usuario.cedula, usuario.contrasena, usuario.correo, usuario.fechaNacimiento, usuario.nombre, usuario.nombreUsuario, usuario.telefono, usuario.tipo).SingleOrDefault



            End Using


        Catch ex As Exception
            MsgBox("error al agregar...")
            'MsgBox(ex)

        End Try

        Return result

    End Function

    Function obtenerCedulaMedico(usuario As Usuario) As sp_obtener_cedula_medico_Result

        Try
            Using almacen As New ProyectoEntities1
                Return almacen.sp_obtener_cedula_medico(usuario.nombreUsuario).SingleOrDefault
            End Using
        Catch ex As Exception

        End Try
        Return Nothing
    End Function



End Class
