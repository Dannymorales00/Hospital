Public Class FrmCita
    Private cita As Citas
    Private buscarPaciente As FrmBuscarPaciente
    Private buscarMedico As BuscarMedico
    Private paciente As New Paciente
    Private medico As New Medico
    Private controladorCita As New ControladorCita

    Private Sub FrmCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub cargarPaciente()
        Dim pacienteForm As New FrmBuscarPaciente
        pacienteForm.ShowDialog()
        paciente = pacienteForm.PacienteRetorno1
        pacienteForm.Close()

        If Not paciente.cedula = Nothing Then
            LblPaciente.Text = paciente.cedula.ToString

        End If
    End Sub

    Public Sub cargarMedico()
        Dim medicoForm As New BuscarMedico
        medicoForm.ShowDialog()
        medico = medicoForm.P_Medico
        medicoForm.Close()

        If Not medico.cedula = Nothing Then
            LblMedico.Text = medico.cedula.ToString
        End If

    End Sub

    Public Function comprobarRegistrar() As Boolean
        Return Not (TxtRegistrarEspecialidad.Equals("") And DateTimeFecha.Checked And DateTimeHora.Checked And paciente IsNot Nothing And medico IsNot Nothing)
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
            If controladorCita.registrar(cita) = 1 Then
                MsgBox("se agrego correctamente la cita")
            Else
                MsgBox("No se agrego la cita")
            End If
        Else
        MsgBox("Debe rellenar todos los campos")
        End If




    End Sub


End Class