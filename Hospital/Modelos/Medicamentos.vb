Public Class Medicamentos
    Private _idMed As Integer
    Private _nombreMed As String
    Private _descripcionMed As String

    Public Property IdMed As Integer
        Get
            Return _idMed
        End Get
        Set(value As Integer)
            _idMed = value
        End Set
    End Property

    Public Property NombreMed As String
        Get
            Return _nombreMed
        End Get
        Set(value As String)
            _nombreMed = value
        End Set
    End Property

    Public Property DescripcionMed As String
        Get
            Return _descripcionMed
        End Get
        Set(value As String)
            _descripcionMed = value
        End Set
    End Property

    Public Sub New(IdMed As Integer, NombreMed As String, DescripcionMed As String)
        Me.IdMed = IdMed
        Me.NombreMed = NombreMed
        Me.DescripcionMed = DescripcionMed
    End Sub

    Public Sub New()
    End Sub

End Class
