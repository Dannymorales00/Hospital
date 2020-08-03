Public Class Medico
    Private _nombre As String
    Private _cedula As Integer

    Property cedula As Integer
        Get
            Return _cedula
        End Get
        Set
            _cedula = Value
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

    Public Sub New(nombre As String, cedula As Integer)
        Me.nombre = nombre
        Me.cedula = cedula
    End Sub

    Public Sub New()
    End Sub
End Class
