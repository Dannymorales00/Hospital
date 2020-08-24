Public Class ControladorMedico


    Function Buscar(medico As Medico) As List(Of Medico)
        Dim listaMedicos As New List(Of Medico)
        Try

            Using almacen = New ProyectoEntities1()
                Dim Result = almacen.sp_buscar_medico(medico.cedula.ToString).ToList


                'For i As Integer = 0 To Result.Count - 1
                '    medico.cedula = Result.ElementAt(i).cedula
                '    medico.nombre = Result.ElementAt(i).nombre
                '    listaMedicos.Add(medico)
                '    MsgBox(listaMedicos.ElementAt(i).nombre)
                'Next
                For Each medico1 As sp_buscar_medico_Result In Result
                    Dim medico2 As New Medico()

                    medico2.cedula = medico1.cedula
                    medico2.nombre = medico1.nombre
                    listaMedicos.Add(medico2)

                Next
                Return listaMedicos

            End Using


        Catch ex As Exception
            MsgBox("error al buscar medicos" + ex.ToString)


        End Try


        Return listaMedicos
    End Function


End Class


