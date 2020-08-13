Public Class FrmPaciente
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private paciente As Paciente
    Private controladorPaciente As New ControladorPaciente()

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If comprobarAgregar() Then
            paciente = New Paciente(Val(TxtRegistroCedula.Text), TxtRegistroNombre.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtTelefono.Text), TxtCorreo.Text, Val(TxtEdad.Text), Val(TxtPeso.Text), Val(TxtAltura.Text), ComboTipoSangre.SelectedItem.ToString)
            If controladorPaciente.registrar(paciente) = 1 Then
                MsgBox("se agrego correctamente el paciente")
            Else
                MsgBox("No se agrego el paciente")
            End If
        Else
            MsgBox("Debe rellenar todos los campos")
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not (TxtEliminarCedula.Text.Equals("")) Then
            paciente = New Paciente()
            paciente.cedula = Val(TxtEliminarCedula.Text)

            If controladorPaciente.eliminar(paciente) = 1 Then
                MsgBox("Se elimino correctamente el paciente")
            Else
                MsgBox("No se elimino el paciente")
            End If
        Else
            MsgBox("Debe rellenar todos los campos")
        End If
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click, BtnCargar.Click
        If Not (TxtActualizarCedula.Text.Equals("")) Then
            paciente = New Paciente()
            paciente.cedula = Val(TxtActualizarCedula.Text)
            Dim result = controladorPaciente.cargar(paciente)
            TxtActualizarNombre.Text = result.nombre
            DateTimePicker2.Value = result.fechaNacimiento
            TxtActualizarTelefono.Text = result.telefono
            TxtActualizarCorreo.Text = result.correo
            TxtActualizarEdad.Text = result.edad
            TxtActualizarPeso.Text = result.peso
            TxtActualizarAltura.Text = result.altura
            ComboTipo2.SelectedIndex = ComboTipo2.FindString(result.tipoSangre.Trim)
        Else
            MsgBox("Debe rellenar el campo cedula para cargar un paciente")
        End If
    End Sub

    Public Function comprobarAgregar()
        Return Not (TxtRegistroCedula.Text.Equals("") AndAlso TxtRegistroNombre.Text.Equals("") AndAlso TxtAltura.Text.Equals("") AndAlso TxtCorreo.Text.Equals("") AndAlso TxtEdad.Text.Equals("") AndAlso TxtPeso.Text.Equals("") AndAlso TxtTelefono.Text.Equals("") AndAlso ComboTipoSangre.SelectedIndex < 0 AndAlso DateTimePicker1.Checked)
    End Function

    Public Function comprabarActualizar() As Boolean
        Return Not (TxtActualizarCedula.Text.Equals("") AndAlso TxtActualizarNombre.Text.Equals("") AndAlso TxtActualizarAltura.Text.Equals("") AndAlso TxtActualizarCorreo.Text.Equals("") AndAlso TxtActualizarEdad.Text.Equals("") AndAlso TxtActualizarPeso.Text.Equals("") AndAlso TxtActualizarTelefono.Text.Equals("") AndAlso ComboTipo2.SelectedIndex < 0 AndAlso DateTimePicker2.Checked)
    End Function

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If comprabarActualizar() Then
            paciente = New Paciente(Val(TxtActualizarCedula.Text), TxtActualizarNombre.Text, DateTimePicker2.Value.ToString("yyyy-MM-dd"), Val(TxtActualizarTelefono.Text), TxtActualizarCorreo.Text, Val(TxtActualizarEdad.Text), Val(TxtActualizarPeso.Text), Val(TxtActualizarAltura.Text), ComboTipo2.SelectedItem.ToString)

            If controladorPaciente.actualizar(paciente) = 1 Then
                MsgBox("se actualizó correctamente el paciente")
            Else
                MsgBox("No se actualizo el paciente")
            End If
        Else
            MsgBox("Debe rellenar los campos para actualizar un paciente")
        End If


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        paciente = New Paciente()
        paciente.cedula = Val(TxtBuscarCedula.Text)
        Dim result = controladorPaciente.cargar(paciente)

    End Sub
End Class