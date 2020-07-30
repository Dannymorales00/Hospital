Public Class Usuario
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

    Property fechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set
            _fechaNacimiento = Value
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

    Property correo As String
        Get
            Return _correo
        End Get
        Set
            _correo = Value
        End Set
    End Property

    Property nombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set
            _nombreUsuario = Value
        End Set
    End Property

    Property contrasena As String
        Get
            Return _contrasena
        End Get
        Set
            _contrasena = Value
        End Set
    End Property

    Property tipo As Int16
        Get
            Return _tipo
        End Get
        Set
            _tipo = Value
        End Set
    End Property

    Private _cedula As Integer
    Private _nombre As String
    Private _fechaNacimiento As String
    Private _telefono As Integer
    Private _correo As String
    Private _nombreUsuario As String
    Private _contrasena As String
    Private _tipo As Int16

    Public Sub New(cedula As Integer, nombre As String, fechaNacimiento As String, telefono As Short, correo As String, nombreUsuario As String, contrasena As String, tipo As Short)
        Me.cedula = cedula
        Me.nombre = nombre
        Me.fechaNacimiento = fechaNacimiento
        Me.telefono = telefono
        Me.correo = correo
        Me.nombreUsuario = nombreUsuario
        Me.contrasena = contrasena
        Me.tipo = tipo
    End Sub

    Public Sub New()
    End Sub


End Class
