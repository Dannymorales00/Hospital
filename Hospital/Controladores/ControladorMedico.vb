Public Class ControladorMedico


    Function Buscar(medico As Medico) As List(Of Medico)

        Dim listaMedicos As New List(Of Medico)


        Try

            Using almacen = New ProyectoEntities1()

                Dim Result = almacen.sp_buscar_medico(medico.cedula).ToList
                MsgBox(Result.ElementAt(0).cedula + "cedula..")

                'For i = 0 To Result.Count

                '    medico.cedula = Result.ElementAt(i).cedula
                '    medico.nombre = Result.ElementAt(i).nombre
                '    MsgBox(medico.cedula + "cedula..")
                '    listaMedicos.Add(medico)

                'Next




            End Using




        Catch ex As Exception
            MsgBox("error al buscar medicos")


        End Try





        Return listaMedicos
    End Function







End Class
