Public Class MedicamentoRecetado
    Private _nombre As String
    Private _id As Integer
    Private _descripcion As String
    Private _idCita As Integer

    Property idCita As Integer
        Get
            Return _idCita
        End Get
        Set
            _idCita = Value
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

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
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
End Class
