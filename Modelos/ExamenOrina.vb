Public Class ExamenOrina
    Inherits Examen
    Private _id As Integer
    Private _glucosa As Double
    Private _eritrocitos As Double
    Private _color As String
    Private _leucocitos As Double
    Private idConsulta As Integer


    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property


    Property leucitos As Double
        Get
            Return _leucocitos
        End Get
        Set
            _leucocitos = Value
        End Set
    End Property

    Property color As String
        Get
            Return _color
        End Get
        Set
            _color = Value
        End Set
    End Property

    Property eritrocitos As Double
        Get
            Return _eritrocitos
        End Get
        Set
            _eritrocitos = Value
        End Set
    End Property

    Property glucosa As Double
        Get
            Return _glucosa
        End Get
        Set
            _glucosa = Value
        End Set
    End Property

    Public Sub New(id As Integer, leucitos As Double, color As String, eritrocitos As Double, glucosa As Double)
        Me.id = id
        Me.leucitos = leucitos
        Me.color = color
        Me.eritrocitos = eritrocitos
        Me.glucosa = glucosa
    End Sub

    Public Sub New()
    End Sub
End Class
