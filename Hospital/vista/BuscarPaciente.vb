Public Class BuscarPaciente
    Private paciente As Paciente

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

End Class