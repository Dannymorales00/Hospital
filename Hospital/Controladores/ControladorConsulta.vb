Public Class ControladorConsulta




    Function buscar_por_cedula(cedula As Integer) As List(Of ConsultaMedica)
        Dim ListaConsultas As New List(Of ConsultaMedica)

        Try

            Using almacen = New ProyectoEntities1

                Dim Result = almacen.sp_buscar_consulta_con_cedula(cedula).ToList

                If Result.Count > 0 Then

                    For Each consulta1 As sp_buscar_consulta_con_cedula_Result In Result
                        Dim consulta2 As New ConsultaMedica()

                        consulta2.id = consulta1.id
                        consulta2.idCitas = consulta1.idCitas
                        consulta2.altura = consulta1.altura
                        consulta2.descripcionProceso = consulta1.descripcionProceso
                        consulta2.descripcionSintomas = consulta1.descripcionSintomas
                        consulta2.peso = consulta1.peso
                        consulta2.presion = consulta1.presion
                        consulta2.sintomas = consulta1.sintomas


                        ListaConsultas.Add(consulta2)

                    Next
                    Return ListaConsultas


                End If


            End Using

        Catch ex As Exception

        End Try



        Return ListaConsultas
    End Function


End Class
