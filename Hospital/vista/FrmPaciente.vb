Public Class FrmPaciente
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private paciente As Paciente
    Private controladorPaciente As New ControladorPaciente()
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        paciente = New Paciente(Val(TxtRegistroCedula.Text), TxtRegistroNombre.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtTelefono.Text), TxtCorreo.Text, Val(TxtEdad.Text), Val(TxtPeso.Text), Val(TxtAltura.Text), ComboTipoSangre.SelectedItem.ToString)

        controladorPaciente.registrar(paciente)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        paciente = New Paciente()
        paciente.cedula = Val(TxtEliminarCedula.Text)
        controladorPaciente.eliminar(paciente)
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click, BtnCargar.Click
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




    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        paciente = New Paciente(Val(TxtActualizarCedula.Text), TxtActualizarNombre.Text, DateTimePicker2.Value.ToString("yyyy-MM-dd"), Val(TxtActualizarTelefono.Text), TxtActualizarCorreo.Text, Val(TxtActualizarEdad.Text), Val(TxtActualizarPeso.Text), Val(TxtActualizarAltura.Text), ComboTipo2.SelectedItem.ToString)

        controladorPaciente.actualizar(paciente)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        paciente = New Paciente()
        paciente.cedula = Val(TxtBuscarCedula.Text)
        Dim result = controladorPaciente.cargar(paciente)

    End Sub
End Class