Public Class MedicamentoAlergico
    Private _id As Integer
    Private _cedulaPaciente As String

    Property cedulaPaciente As String
        Get
            Return _cedulaPaciente
        End Get
        Set
            _cedulaPaciente = Value
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

    Public Sub New(cedulaPaciente As String, id As Integer)
        Me.cedulaPaciente = cedulaPaciente
        Me.id = id
    End Sub

    Public Sub New()
    End Sub
End Class
