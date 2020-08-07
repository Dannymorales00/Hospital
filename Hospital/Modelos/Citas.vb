Public Class Citas


    Private _paciente As Paciente
    Private _fechaHora As Date
    Private _especialidadSolicitada As String
    Private _medico As Medico
    Private _id As Integer
    Private _consultaMedica As ConsultaMedica

    Property consultaMedica As ConsultaMedica
        Get
            Return _consultaMedica
        End Get
        Set
            _consultaMedica = Value
        End Set
    End Property

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property
    Property medico As Medico
        Get
            Return _medico
        End Get
        Set
            _medico = Value
        End Set
    End Property

    Property especialidadSolicitada As String
        Get
            Return _especialidadSolicitada
        End Get
        Set
            _especialidadSolicitada = Value
        End Set
    End Property

    Property fechaHora As DateTime
        Get
            Return _fechaHora
        End Get
        Set
            _fechaHora = Value
        End Set
    End Property


    Property paciente As Paciente
        Get
            Return _paciente
        End Get
        Set
            _paciente = Value
        End Set
    End Property

    Public Sub New(consultaMedica As ConsultaMedica, id As Integer, medico As Medico, especialidadSolicitada As String, fechaHora As Date, paciente As Paciente)
        Me.consultaMedica = consultaMedica
        Me.id = id
        Me.medico = medico
        Me.especialidadSolicitada = especialidadSolicitada
        Me.fechaHora = fechaHora
        Me.paciente = paciente
    End Sub

    Public Sub New()
    End Sub
End Class
