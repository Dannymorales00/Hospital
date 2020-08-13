Public Class PersonaContacto
    Private _nombreCompleto As String
    Private _relacionFamiliar As String
    Private _telefono As Integer
    Private _direccion As String
    Private _cedula As String
    Private _cedulaPaciente As Integer

    Property cedulaPaciente As Integer
        Get
            Return _cedulaPaciente
        End Get
        Set
            _cedulaPaciente = Value
        End Set
    End Property

    Property cedula As String
        Get
            Return _cedula
        End Get
        Set
            _cedula = Value
        End Set
    End Property
    Property direccion As String
        Get
            Return _direccion
        End Get
        Set
            _direccion = Value
        End Set
    End Property

    Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set
            _telefono = Value
        End Set
    End Property

    Property relacionFamiliar As String
        Get
            Return _relacionFamiliar
        End Get
        Set
            _relacionFamiliar = Value
        End Set
    End Property

    Property nombreCompleto As String
        Get
            Return _nombreCompleto
        End Get
        Set
            _nombreCompleto = Value
        End Set
    End Property

    Public Sub New(direccion As String, telefono As Integer, relacionFamiliar As String, nombreCompleto As String)
        Me.direccion = direccion
        Me.telefono = telefono
        Me.relacionFamiliar = relacionFamiliar
        Me.nombreCompleto = nombreCompleto
    End Sub



    Public Sub New()
    End Sub
End Class
