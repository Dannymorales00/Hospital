Public Class ControladorPaciente
    Private paciente As Paciente


    Public Function registrar(paciente As Paciente) As Integer
        Dim result As Integer = 0
        Try
            Using Almacen As New ProyectoEntities1
                result = Almacen.sp_registrar_paciente(paciente.cedula, paciente.nombre, paciente.edad, paciente.correo, paciente.fechaNacimiento, paciente.peso, paciente.altura, paciente.telefono, paciente.tipoSangre).SingleOrDefault

            End Using
        Catch ex As Exception

        End Try
        Return result
    End Function

    Public Function eliminar(paciente As Paciente) As Integer
        Dim result As Integer = 0
        Try
            Using Almacen As New ProyectoEntities1
                result = Almacen.sp_eliminar_paciente(paciente.cedula).SingleOrDefault

            End Using
        Catch ex As Exception

        End Try
        Return result
    End Function

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

    Public Function actualizar(paciente As Paciente) As Integer
        Dim result As Integer = 0
        Try
            Using Almacen As New ProyectoEntities1
                result = Almacen.sp_actualizar_paciente(paciente.cedula, paciente.nombre, paciente.edad, paciente.correo, paciente.fechaNacimiento, paciente.peso, paciente.altura, paciente.telefono, paciente.tipoSangre).SingleOrDefault

            End Using
        Catch ex As Exception

        End Try
        Return result
    End Function


    Public Function buscarPacientes(paciente As Paciente) As List(Of sp_buscar_pacientes_Result)
        Dim pacientes As New List(Of Paciente)
        Try
            Using almacen As New ProyectoEntities1
                Return almacen.sp_buscar_pacientes(paciente.cedula.ToString).ToList
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class



