'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Paciente
    Public Property cedula As Integer
    Public Property nombre As String
    Public Property edad As Integer
    Public Property correo As String
    Public Property fechaNacimiento As Date
    Public Property peso As Double
    Public Property altura As Double
    Public Property telefono As Integer
    Public Property tipoSangre As String

    Public Overridable Property Citas As ICollection(Of Citas) = New HashSet(Of Citas)
    Public Overridable Property Enfermedad As ICollection(Of Enfermedad) = New HashSet(Of Enfermedad)
    Public Overridable Property MedicamentoAlergico As ICollection(Of MedicamentoAlergico) = New HashSet(Of MedicamentoAlergico)
    Public Overridable Property PersonaContacto As ICollection(Of PersonaContacto) = New HashSet(Of PersonaContacto)

End Class
