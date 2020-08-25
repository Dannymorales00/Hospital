Public Class ExamenOrina
    Inherits Examen
    Private _id As Integer
    Private _idConsulta As Integer
    Private _glucosa As Double
    Private _eritrocitos As Double
    Private _color As String
    Private _leucocitos As Double



    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property
    Public Property IdConsulta As Integer
        Get
            Return _idConsulta
        End Get
        Set(value As Integer)
            _idConsulta = value
        End Set
    End Property
    Public Property Leucocitos As Double
        Get
            Return _leucocitos
        End Get
        Set(value As Double)
            _leucocitos = value
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



    Public Sub New(id As Integer, idConsulta As Integer, glucosa As Double, eritrocitos As Double, color As String, leucocitos As Double)
        _id = id
        _idConsulta = idConsulta
        _glucosa = glucosa
        _eritrocitos = eritrocitos
        _color = color
        _leucocitos = leucocitos
    End Sub

    Public Sub New()
    End Sub
End Class
