Public Class MedicamentoAlergico
    Private _id As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _cedulaPaciente As String

    Property cedulaPaciente As String
        Get
            Return _cedulaPaciente
        End Get
        Set
            _cedulaPaciente = Value
        End Set
    End Property

    Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set
            _descripcion = Value
        End Set
    End Property

    Property nombre As String
        Get
            Return _nombre
        End Get
        Set
            _nombre = Value
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

    Public Sub New(cedulaPaciente As String, descripcion As String, nombre As String, id As Integer)
        Me.cedulaPaciente = cedulaPaciente
        Me.descripcion = descripcion
        Me.nombre = nombre
        Me.id = id
    End Sub

    Public Sub New()
    End Sub
End Class
