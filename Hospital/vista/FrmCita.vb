Public Class FrmCita
    Private cita As Citas
    Private buscarPaciente As FrmBuscarPaciente
    Private buscarMedico As BuscarMedico
    Private paciente As New Paciente
    Private medico As New Medico
    Private controladorCita As New ControladorCita
    Private conPaciente As New ControladorPaciente
    Private conMedico As New ControladorMedico

    Private Sub FrmCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()
    End Sub

    Public Sub cargarPaciente()
        Dim pacienteForm As New FrmBuscarPaciente
        pacienteForm.ShowDialog()
        paciente = pacienteForm.PacienteRetorno1
        pacienteForm.Close()

        If Not paciente.cedula = Nothing Then
            LblPaciente.Text = paciente.nombre

        End If
    End Sub

    Public Sub cargarMedico()
        Dim medicoForm As New BuscarMedico
        medicoForm.ShowDialog()
        medico = medicoForm.P_Medico
        medicoForm.Close()

        If Not medico.cedula = 0 Then
            LblMedico.Text = medico.nombre
        End If

    End Sub

    Public Function comprobarRegistrar() As Boolean
        Return (TxtRegistrarEspecialidad IsNot Nothing And DateTimeFecha.Checked And DateTimeHora.Checked And paciente IsNot Nothing And medico IsNot Nothing)
    End Function
    Private Sub BtnMedico_Click(sender As Object, e As EventArgs) Handles BtnMedico.Click
        cargarMedico()
    End Sub

    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        cargarPaciente()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If comprobarRegistrar() Then
            cita = New Citas
            cita.especialidadSolicitada = TxtRegistrarEspecialidad.Text
            cita.fechaHora = DateTimeFecha.Value.ToString("yyyy-MM-dd") + " " + DateTimeHora.Value.ToString("hh:mm:ss")
            cita.paciente = paciente
            cita.medico = medico
            If BtnRegistrar.Text = "Registrar" Then
                If controladorCita.registrar(cita) = 1 Then
                    MsgBox("se agrego correctamente la cita")
                Else
                    MsgBox("No se agrego la cita")
                End If
            Else
                If controladorCita.actualizar(cita) = 1 Then
                    MsgBox("Se actualizo la cita correctamente")
                Else
                    MsgBox("Error al actualizar la cita")
                End If
            End If

        Else
            MsgBox("Debe rellenar todos los campos")
        End If

        cargarTabla()
        limpiarCampos()


    End Sub

    Public Sub cargarTabla()
        cita = New Citas
        paciente = New Paciente
        paciente.cedula = TxtCedulaP.Text
        cita.paciente = paciente
        Dim datosTabla = controladorCita.buscarCitas(cita)
        DataGridCitas.DataSource = datosTabla
    End Sub

    Public Sub limpiarCampos()
        TxtRegistrarEspecialidad.Text = ""
        paciente = New Paciente()
        medico = New Medico()
        LblPaciente.Text = "Paciente Seleccionado"
        LblMedico.Text = "Medico Seleccionado"
        TxtCedulaP.Text = ""
        BtnRegistrar.Text = "Registrar"
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        cita = New Citas
        cita.id = Val(LblID.Text)
        controladorCita.eliminar(cita)
        cargarTabla()
        limpiarCampos()
    End Sub

    Private Sub DataGridCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCitas.CellClick
        TxtRegistrarEspecialidad.Text = DataGridCitas.Item(1, DataGridCitas.CurrentRow.Index).Value

        Dim fecha As String = DataGridCitas.Item(2, DataGridCitas.CurrentRow.Index).Value

        DateTimeFecha.Value = fecha.Split(" ").ElementAt(0)


        DateTimeHora.Value = "2020-11-01" + " " + fecha.Split(" ").ElementAt(1)

        paciente = New Paciente
        medico = New Medico
        paciente.cedula = Val(DataGridCitas.Item(3, DataGridCitas.CurrentRow.Index).Value)
        medico.cedula = DataGridCitas.Item(4, DataGridCitas.CurrentRow.Index).Value

        Dim result1 = conPaciente.cargar(paciente)
        Dim result2 = conMedico.Buscar(medico)

        paciente.nombre = result1.nombre
        paciente.fechaNacimiento = result1.fechaNacimiento
        paciente.correo = result1.correo
        paciente.telefono = result1.telefono
        paciente.edad = result1.edad
        paciente.altura = result1.altura
        paciente.contactosPersona = result1.contactosPersona
        paciente.tipoSangre = result1.tipoSangre


        medico.cedula = result2.ElementAt(0).cedula
        medico.nombre = result2.ElementAt(0).nombre

        LblPaciente.Text = paciente.nombre
        LblMedico.Text = medico.nombre
        LblID.Text = DataGridCitas.Item(0, DataGridCitas.CurrentRow.Index).Value
        BtnRegistrar.Text = "Actualizar"
    End Sub

    Private Sub TxtCedulaP_TextChanged(sender As Object, e As EventArgs) Handles TxtCedulaP.TextChanged
        cargarTabla()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Hide()
    End Sub
End Class