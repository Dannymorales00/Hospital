Public Class ConsultaMedica
    Private _presion As Integer
    Private _peso As Double
    Private _altura As Double
    Private _sintomas As String
    Private _descripcionProceso As String
    Private _descripcionSintomas As String
    Private _id As Integer
    Private _idCitas As Integer
    'Private _medicamentosRecetados As MedicamentoRecetado
    'Private _examenSangre As ExamenSangre
    'Private _examenOrina As ExamenOrina

    Public Sub New(presion As Integer, peso As Double, altura As Double, sintomas As String, descripcionProceso As String, descripcionSintomas As String, id As Integer, idCitas As Integer)
        _presion = presion
        _peso = peso
        _altura = altura
        _sintomas = sintomas
        _descripcionProceso = descripcionProceso
        '_medicamentosRecetados = medicamentosRecetados
        _descripcionSintomas = descripcionSintomas
        '_examenSangre = examenSangre
        '_examenOrina = examenOrina
        _id = id
        _idCitas = idCitas
    End Sub

    Public Sub New()
    End Sub
    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property
    Property idCitas As Integer
        Get
            Return _idCitas
        End Get
        Set
            _idCitas = Value
        End Set
    End Property

    Property descripcionSintomas As String
        Get
            Return _descripcionSintomas
        End Get
        Set
            _descripcionSintomas = Value
        End Set
    End Property



    Property descripcionProceso As String
        Get
            Return _descripcionProceso
        End Get
        Set
            _descripcionProceso = Value
        End Set
    End Property

    Property sintomas As String
        Get
            Return _sintomas
        End Get
        Set
            _sintomas = Value
        End Set
    End Property

    Property altura As Double
        Get
            Return _altura
        End Get
        Set
            _altura = Value
        End Set
    End Property

    Property peso As Double
        Get
            Return _peso
        End Get
        Set
            _peso = Value
        End Set
    End Property

    Property presion As Integer
        Get
            Return _presion
        End Get
        Set
            _presion = Value
        End Set
    End Property

    'Public Property MedicamentosRecetados As MedicamentoRecetado
    '    Get
    '        Return _medicamentosRecetados
    '    End Get
    '    Set(value As MedicamentoRecetado)
    '        _medicamentosRecetados = value
    '    End Set
    'End Property

    'Public Property ExamenSangre As ExamenSangre
    '    Get
    '        Return _examenSangre
    '    End Get
    '    Set(value As ExamenSangre)
    '        _examenSangre = value
    '    End Set
    'End Property

    'Public Property ExamenOrina As ExamenOrina
    '    Get
    '        Return _examenOrina
    '    End Get
    '    Set(value As ExamenOrina)
    '        _examenOrina = value
    '    End Set
    'End Property
End Class
