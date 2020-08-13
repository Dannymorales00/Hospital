Public Class FrmCita
    Private cita As Citas
    Private buscarPaciente As FrmBuscarPaciente
    Private buscarMedico As BuscarMedico
    Private paciente As New Paciente
    Private medico As New Medico


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
    Private Sub BtnMedico_Click(sender As Object, e As EventArgs) Handles BtnMedico.Click
        cargarMedico()

    End Sub

    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        cargarPaciente()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

    End Sub
End Class