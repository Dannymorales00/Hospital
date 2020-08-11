Public Class ControladorPersonaContacto

    Sub registrar(nombre As String, cedula As Integer, relacionFamiliar As String, telefono As Integer, cedulaPaciente As Integer, direccion As String)
        Try
            Using Almacen As New ProyectoEntities1
                Almacen.regis
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
