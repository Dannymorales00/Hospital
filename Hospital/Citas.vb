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

Partial Public Class Citas
    Public Property id As Integer
    Public Property especialidad As String
    Public Property fechaHora As Date
    Public Property cedula_paciente As Integer
    Public Property cedula_medico As Integer

    Public Overridable Property Medico As Medico
    Public Overridable Property Paciente As Paciente
    Public Overridable Property ConsultaMedica As ICollection(Of ConsultaMedica) = New HashSet(Of ConsultaMedica)

End Class
