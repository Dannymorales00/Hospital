Public Class ControladorEnfermedad


    Function Registrar(enfermedad As Enfermedad) As Integer
        Dim Result As Integer = 0
        Try

            Using almacen As New ProyectoEntities1

                Result = almacen.sp_registrar_enfermedad(enfermedad.cedulaPaciente, enfermedad.nombre, enfermedad.descripcion).SingleOrDefault
                Return Result


            End Using

        Catch ex As Exception
            MsgBox("Error al registrar la enfermedad")
        End Try


        Return Result
    End Function


    Function Buscar(enfermedad As Enfermedad) As List(Of Enfermedad)
        Dim ListaEnfermedad As New List(Of Enfermedad)
        Try

            Using almacen As New ProyectoEntities1

                Dim Result = almacen.sp_buscar_enfermedad(enfermedad.cedulaPaciente).ToList

                If Result.Count > 0 Then


                    For Each enfermedad1 As sp_buscar_enfermedad_Result In Result
                        Dim enfermedad2 As New Enfermedad()

                        enfermedad2.cedulaPaciente = enfermedad1.cedula_paciente.ToString
                        enfermedad2.nombre = enfermedad1.enfermedad
                        enfermedad2.descripcion = enfermedad1.descripcion
                        enfermedad2.id = enfermedad1.id
                        ListaEnfermedad.Add(enfermedad2)

                    Next
                    Return ListaEnfermedad


                End If
            End Using

        Catch ex As Exception
            MsgBox("Error al buscar")
            MsgBox(ex.Message)
        End Try

        Return ListaEnfermedad
    End Function



    Function Eliminar(enfermedad As Enfermedad) As Integer
        Dim Result As Integer = 0
        Try

            Using almacen As New ProyectoEntities1

                Result = almacen.sp_eliminar_enfermedad(enfermedad.cedulaPaciente, enfermedad.nombre).SingleOrDefault

                Return Result


            End Using


        Catch ex As Exception
            MsgBox("Error al eliminar la enfermedad")
            MsgBox(ex.Message)
        End Try




        Return Result
    End Function

    Function Actualizar(enfermedad As Enfermedad) As Integer
        Dim Result As Integer = 0
        Try

            Using almacen As New ProyectoEntities1

                Result = almacen.sp_actualizar_enfermedad(enfermedad.id, enfermedad.nombre, enfermedad.descripcion).SingleOrDefault

                Return Result


            End Using


        Catch ex As Exception
            MsgBox("Error al actualizar la enfermedad")
            MsgBox(ex.Message)
        End Try


        Return 0
    End Function






End Class
