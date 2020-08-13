Public Class FrmCita
    Private cita As Citas
    Private buscarPaciente As BuscarPaciente
    Private paciente As New Paciente
    Private medico As New Medico


    Public Sub cargarPaciente()
        Dim pacienteForm As New BuscarPaciente
        pacienteForm.ShowDialog()
        paciente = pacienteForm.pacienteRetorno
        pacienteForm.Close()

        If Not paciente.cedula = Nothing Then
            LblPaciente.Text = paciente.cedula.ToString

        End If
    End Sub

    Private Sub BtnMedico_Click(sender As Object, e As EventArgs) Handles BtnMedico.Click

    End Sub

    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        cargarPaciente()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

    End Sub
End Class