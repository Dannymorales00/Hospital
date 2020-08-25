Public Class ControladorExamenOrina

    Function Registrar(examenOrina As ExamenOrina) As Integer

        Try
            Using almacen = New ProyectoEntities1
                Dim Result = almacen.sp_registrar_ExamenOrina(examenOrina.IdConsulta, examenOrina.color, examenOrina.eritrocitos, examenOrina.glucosa, examenOrina.Leucocitos).SingleOrDefault
                If Result = 1 Then
                    Return Result

                End If

            End Using

        Catch ex As Exception
            'MsgBox(Error al registrar)
            'MsgBox(ex.Message)
            'MsgBox(ex.ToString)

        End Try

        Return 0
    End Function

    Function Buscar(examenOrina As ExamenOrina) As List(Of ExamenOrina)
        Dim ListaExamenOrina As New List(Of ExamenOrina)
        Try

            Using almacen As New ProyectoEntities1

                Dim Result = almacen.sp_buscar_ExamenOrina(examenOrina.IdConsulta).ToList


                If Result.Count > 0 Then


                    For Each examenOrina1 As sp_buscar_ExamenOrina_Result In Result
                        Dim examenOrina2 As New ExamenOrina()

                        examenOrina2.id = examenOrina1.id
                        examenOrina2.IdConsulta = examenOrina1.idConsulta
                        examenOrina2.color = examenOrina1.color
                        examenOrina2.eritrocitos = examenOrina1.eritrocitos
                        examenOrina2.glucosa = examenOrina1.glucosa
                        examenOrina2.leucocitos = examenOrina1.leucocitos


                        ListaExamenOrina.Add(examenOrina2)

                    Next
                    Return ListaExamenOrina


                End If
            End Using

        Catch ex As Exception
            MsgBox("Error al buscar")
            MsgBox(ex.Message)
        End Try

        Return ListaExamenOrina

    End Function



    Function Actualizar(examenOrina As ExamenOrina) As Integer

        Try

            Using almacen = New ProyectoEntities1
                Dim Result = almacen.sp_actualizar_ExamenOrina(examenOrina.id, examenOrina.IdConsulta, examenOrina.color, examenOrina.eritrocitos, examenOrina.glucosa, examenOrina.Leucocitos).SingleOrDefault
                Return Result

            End Using


        Catch ex As Exception

        End Try


        Return 0
    End Function
    Function Eliminar(examenOrina As ExamenOrina) As Integer
        Try

            Using almacen = New ProyectoEntities1
                Dim Result = almacen.sp_eliminar_ExamenOrina(examenOrina.IdConsulta).SingleOrDefault

                If Result = 1 Then
                    Return Result

                Else
                    'MsgBox("Error al eliminar")

                End If
            End Using

        Catch ex As Exception

        End Try



        Return 0
    End Function





End Class
