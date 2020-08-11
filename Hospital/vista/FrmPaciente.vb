Public Class FrmPaciente
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private paciente As Paciente
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_registrar_paciente(Val(TxtRegistroCedula.Text), TxtRegistroNombre.Text, Val(TxtEdad.Text), TxtCorreo.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtPeso.Text), Val(TxtAltura.Text), Val(TxtTelefono.Text), ComboTipoSangre.SelectedItem.ToString).SingleOrDefault
                If result = 1 Then
                    MsgBox("Se inserto correctamente")

                Else
                    MsgBox("No se inserto correctamente")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_eliminar_paciente(Val(TxtEliminarCedula.Text)).SingleOrDefault
                If result = 1 Then
                    MsgBox("Se elimino correctamente")

                Else
                    MsgBox("No se elimino correctamente")
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click, BtnCargar.Click
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_buscar_paciente(Val(TxtActualizarCedula.Text)).SingleOrDefault

                TxtActualizarNombre.Text = result.nombre
                DateTimePicker2.Value = result.fechaNacimiento
                TxtActualizarTelefono.Text = result.telefono
                TxtActualizarCorreo.Text = result.correo
                TxtActualizarEdad.Text = result.edad
                TxtActualizarPeso.Text = result.peso
                TxtActualizarAltura.Text = result.altura
                ComboTipo2.Text = result.tipoSangre

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_actualizar_paciente(Val(TxtActualizarCedula.Text), TxtActualizarNombre.Text, Val(TxtActualizarEdad.Text), TxtActualizarCorreo.Text, DateTimePicker2.Value.ToString("yyyy-MM-dd"), Val(TxtActualizarPeso.Text), Val(TxtActualizarAltura.Text), Val(TxtActualizarTelefono.Text), ComboTipo2.SelectedItem.ToString).SingleOrDefault
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