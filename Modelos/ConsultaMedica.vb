Public Class ConsultaMedica
    Private _presion As Integer
    Private _peso As Double
    Private _altura As Double
    Private _sintomas As String
    Private _descripcionProceso As String
    Private _medicamentosRecetados As MedicamentoRecetado
    Private _descripcionSintomas As String
    Private _examen As List(Of Examen)
    Private _id As Integer
    Private _idCitas As Integer

    Public Sub New(idCitas As Integer, id As Integer, examen As List(Of Examen), descripcionSintomas As String, descripcionProceso As String, sintomas As String, altura As Double, peso As Double, presion As Integer, medicamentosRecetados As MedicamentoRecetado)
        Me.idCitas = idCitas
        Me.id = id
        Me.examen = examen
        Me.descripcionSintomas = descripcionSintomas
        Me.descripcionProceso = descripcionProceso
        Me.sintomas = sintomas
        Me.altura = altura
        Me.peso = peso
        Me.presion = presion
        Me.MedicamentosRecetados = medicamentosRecetados
    End Sub

    Public Sub New()
    End Sub
    Property idCitas As Integer
        Get
            Return _idCitas
        End Get
        Set
            _idCitas = Value
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


    Property examen As List(Of Examen)
        Get
            Return _examen
        End Get
        Set
            _examen = Value
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

    Public Property MedicamentosRecetados As MedicamentoRecetado
        Get
            Return _medicamentosRecetados
        End Get
        Set(value As MedicamentoRecetado)
            _medicamentosRecetados = value
        End Set
    End Property
End Class
