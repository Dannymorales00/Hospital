Public Class ControladorPaciente
    Private paciente As Paciente


    Public Sub registrar(paciente As Paciente)
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_registrar_paciente(paciente.cedula, paciente.nombre, paciente.edad, paciente.correo, paciente.fechaNacimiento, paciente.peso, paciente.altura, paciente.telefono, paciente.tipoSangre).SingleOrDefault
                If result = 1 Then
                    MsgBox("Se inserto correctamente")

                Else
                    MsgBox("No se inserto correctamente")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(paciente As Paciente)
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_eliminar_paciente(paciente.cedula).SingleOrDefault
                If result = 1 Then
                    MsgBox("Se elimino correctamente")

                Else
                    MsgBox("No se elimino correctamente")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Public Function cargar(paciente As Paciente) As Paciente
        Dim paciente2 As Paciente = New Paciente()
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_buscar_paciente(Val(paciente.cedula)).SingleOrDefault


                paciente2.nombre = result.nombre
                paciente2.fechaNacimiento = result.fechaNacimiento
                paciente2.telefono = result.telefono
                paciente2.correo = result.correo
                paciente2.edad = result.edad
                paciente2.peso = result.peso
                paciente2.altura = result.altura
                paciente2.tipoSangre = result.tipoSangre

            End Using
        Catch ex As Exception

        End Try
        Return paciente2
    End Function

    Public Sub actualizar(paciente As Paciente)
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_actualizar_paciente(paciente.cedula, paciente.nombre, paciente.edad, paciente.correo, paciente.fechaNacimiento, paciente.peso, paciente.altura, paciente.telefono, paciente.tipoSangre).SingleOrDefault
                If result = 1 Then
                    MsgBox("Se actualizo correctamente")

                Else
                    MsgBox("No se actualizo correctamente")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub










End Class



