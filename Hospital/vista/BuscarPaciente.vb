Public Class BuscarPaciente
    Private paciente As Paciente
    Private controladorPaciente As New ControladorPaciente
    Private Sub BuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property Paciente1 As Paciente
        Get
            Return paciente
        End Get
        Set(value As Paciente)
            paciente = value
        End Set
    End Property

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        paciente = New Paciente()
        paciente.cedula = Val(TextBox1.Text)

        DataGridView1.DataSource = controladorPaciente.buscarPacientes(paciente)
    End Sub
End Class