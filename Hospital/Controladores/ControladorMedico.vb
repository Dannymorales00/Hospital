﻿Public Class ControladorMedico


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
                    Dim medico2 As Medico
                    medico2 = New Medico()

                    medico2.cedula = medico1.cedula
                    medico2.nombre = medico1.nombre
                    listaMedicos.Add(medico2)

                Next

                MsgBox(listaMedicos.ElementAt(0).nombre)
                MsgBox(listaMedicos.ElementAt(1).nombre)
                MsgBox(listaMedicos.ElementAt(2).nombre)
                Return listaMedicos

            End Using


        Catch ex As Exception
            MsgBox("error al buscar medicos" + ex.ToString)


        End Try





        Return listaMedicos
    End Function







End Class
