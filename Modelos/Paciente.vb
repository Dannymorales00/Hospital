Public Class Paciente
    Private _cedula As Integer
    Private _nombre As String
    Private _fechaNacimiento As Date
    Private _telefono As Integer
    Private _correo As String
    Private _edad As Short
    Private _peso As Double
    Private _altura As Double
    Private _tipoSangre As String
    Private _contactosPersona As List(Of PersonaContacto)
    Private _enfermedades As List(Of Enfermedad)
    Private _medicamentos As List(Of MedicamentoAlergico)

    Property medicamentos As List(Of MedicamentoAlergico)
        Get
            Return _medicamentos
        End Get
        Set
            _medicamentos = Value
        End Set
    End Property

    Property enfermedades As List(Of Enfermedad)
        Get
            Return _enfermedades
        End Get
        Set
            _enfermedades = Value
        End Set
    End Property

    Property contactosPersona As List(Of PersonaContacto)
        Get
            Return _contactosPersona
        End Get
        Set
            _contactosPersona = Value
        End Set
    End Property



    Property tipoSangre As String
        Get
            Return _tipoSangre
        End Get
        Set
            _tipoSangre = Value
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

    Property edad As Int16
        Get
            Return _edad
        End Get
        Set
            _edad = Value
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

    Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set
            _telefono = Value
        End Set
    End Property

    Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set
            _fechaNacimiento = Value
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

    Property cedula As Integer
        Get
            Return _cedula
        End Get
        Set
            _cedula = Value
        End Set
    End Property

    Public Sub New(medicamentos As List(Of MedicamentoAlergico), enfermedades As List(Of Enfermedad), contactosPersona As List(Of PersonaContacto), tipoSangre As String, altura As Double, peso As Double, edad As Short, correo As String, telefono As Integer, fechaNacimiento As Date, nombre As String, cedula As Integer)
        Me.medicamentos = medicamentos
        Me.enfermedades = enfermedades
        Me.contactosPersona = contactosPersona
        Me.tipoSangre = tipoSangre
        Me.altura = altura
        Me.peso = peso
        Me.edad = edad
        Me.correo = correo
        Me.telefono = telefono
        Me.fechaNacimiento = fechaNacimiento
        Me.nombre = nombre
        Me.cedula = cedula
    End Sub

    Public Sub New()
    End Sub

End Class
