Public Class ControladorExamenSangre

    Function Registrar(examenSangre As ExamenSangre) As Integer

        Try
            Using almacen = New ProyectoEntities1
                Dim Result = almacen.sp_registrar_ExamenSangre(examenSangre.idConsulta, examenSangre.acidoUrico, examenSangre.creatinina, examenSangre.colesterol, examenSangre.hematocrito, examenSangre.hemoglobina, examenSangre.trigliceridos).SingleOrDefault
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

    Function Buscar(examenSangre As ExamenSangre) As List(Of ExamenSangre)
        Dim ListaExamenSangre As New List(Of ExamenSangre)
        Try

            Using almacen As New ProyectoEntities1

                Dim Result = almacen.sp_buscar_ExamenSangre(examenSangre.idConsulta).ToList


                If Result.Count > 0 Then


                    For Each examenSangre1 As sp_buscar_ExamenSangre_Result In Result
                        Dim examenSangre2 As New ExamenSangre()

                        examenSangre2.id = examenSangre1.id
                        examenSangre2.IdConsulta = examenSangre1.idConsulta
                        examenSangre2.acidoUrico = examenSangre1.acidoUrico
                        examenSangre2.creatinina = examenSangre1.creatinina
                        examenSangre2.colesterol = examenSangre1.colesterol
                        examenSangre2.hematocrito = examenSangre1.hematocrito
                        examenSangre2.hemoglobina = examenSangre1.hemoglobina
                        examenSangre2.trigliceridos = examenSangre1.trigliceridos


                        ListaExamenSangre.Add(examenSangre2)

                    Next
                    Return ListaExamenSangre


                End If
            End Using

        Catch ex As Exception
            MsgBox("Error al buscar")
            MsgBox(ex.Message)
        End Try

        Return ListaExamenSangre

    End Function



    Function Actualizar(examenSangre As ExamenSangre) As Integer

        Try

            Using almacen = New ProyectoEntities1
                Dim Result = almacen.sp_actualizar_ExamenSangre(examenSangre.id, examenSangre.idConsulta, examenSangre.acidoUrico, examenSangre.creatinina, examenSangre.colesterol, examenSangre.hematocrito, examenSangre.hemoglobina, examenSangre.trigliceridos).SingleOrDefault
                Return Result

            End Using


        Catch ex As Exception

        End Try


        Return 0
    End Function
    Function Eliminar(examenSangre As ExamenSangre) As Integer
        Try

            Using almacen = New ProyectoEntities1
                MsgBox(examenSangre.idConsulta)
                Dim Result = almacen.sp_eliminar_ExamenSangre(examenSangre.idConsulta).SingleOrDefault

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
