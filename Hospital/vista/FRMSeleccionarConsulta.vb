Public Class FRMSeleccionarConsulta
    Dim conConsulta As New ControladorConsulta
    Dim consulta As ConsultaMedica
    Dim medico As Medico
    Private Sub FRMSeleccionarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub cargarTabla()
        medico = New Medico
        medico.cedula = CInt(lblMedico.Text)
        DataGridView1.DataSource = conConsulta.buscarConsultasHoy(medico)

    End Sub
End Class