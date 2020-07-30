Public Class ExamenSangre
    Inherits Examen
    Private _hemoglobina As Double
    Private _hematocrito As Double
    Private _trigliceridos As Double
    Private _colesterol As Double
    Private _acidoUrico As Double
    Private _creatinina As Double
    Private _id As Integer
    Private _idConsulta As Integer

    Property idConsulta As Integer
        Get
            Return _idConsulta
        End Get
        Set
            _idConsulta = Value
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

    Property creatinina As Double
        Get
            Return _creatinina
        End Get
        Set
            _creatinina = Value
        End Set
    End Property

    Property acidoUrico As Double
        Get
            Return _acidoUrico
        End Get
        Set
            _acidoUrico = Value
        End Set
    End Property

    Property colesterol As Double
        Get
            Return _colesterol
        End Get
        Set
            _colesterol = Value
        End Set
    End Property

    Property trigliceridos As Double
        Get
            Return _trigliceridos
        End Get
        Set
            _trigliceridos = Value
        End Set
    End Property

    Property hematocrito As Double
        Get
            Return _hematocrito
        End Get
        Set
            _hematocrito = Value
        End Set
    End Property

    Property hemoglobina As Double
        Get
            Return _hemoglobina
        End Get
        Set
            _hemoglobina = Value
        End Set
    End Property

    Public Sub New(idConsulta As Integer, id As Integer, creatinina As Double, acidoUrico As Double, colesterol As Double, trigliceridos As Double, hematocrito As Double, hemoglobina As Double)
        Me.idConsulta = idConsulta
        Me.id = id
        Me.creatinina = creatinina
        Me.acidoUrico = acidoUrico
        Me.colesterol = colesterol
        Me.trigliceridos = trigliceridos
        Me.hematocrito = hematocrito
        Me.hemoglobina = hemoglobina
    End Sub

    Public Sub New()
    End Sub
End Class
