Public Class MedicamentoAdministrado
    Private _id As Integer
    Private _id_consulta As Integer
    Private _medicamento As Integer

    Property medicamento As Integer
        Get
            Return _medicamento
        End Get
        Set
            _medicamento = Value
        End Set
    End Property

    Property id_consulta As Integer
        Get
            Return _id_consulta
        End Get
        Set
            _id_consulta = Value
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

    Public Sub New()
    End Sub

    Public Sub New(id_consulta As Integer, medicamento As Integer)
        Me.medicamento = medicamento
        Me.id_consulta = id_consulta
    End Sub
End Class
