﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class ProyectoEntities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ProyectoEntities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function sp_actualizar_ExamenOrina(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer), color As String, eritrocitos As Nullable(Of Double), glucosa As Nullable(Of Double), leucocitos As Nullable(Of Double)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Dim colorParameter As ObjectParameter = If(color IsNot Nothing, New ObjectParameter("color", color), New ObjectParameter("color", GetType(String)))

        Dim eritrocitosParameter As ObjectParameter = If(eritrocitos.HasValue, New ObjectParameter("eritrocitos", eritrocitos), New ObjectParameter("eritrocitos", GetType(Double)))

        Dim glucosaParameter As ObjectParameter = If(glucosa.HasValue, New ObjectParameter("glucosa", glucosa), New ObjectParameter("glucosa", GetType(Double)))

        Dim leucocitosParameter As ObjectParameter = If(leucocitos.HasValue, New ObjectParameter("leucocitos", leucocitos), New ObjectParameter("leucocitos", GetType(Double)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_actualizar_ExamenOrina", idParameter, idConsultaParameter, colorParameter, eritrocitosParameter, glucosaParameter, leucocitosParameter)
    End Function

    Public Overridable Function sp_actualizar_ExamenSangre(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer), acidoUrico As Nullable(Of Double), creatinina As Nullable(Of Double), colesterol As Nullable(Of Double), hematocrito As Nullable(Of Double), hemoglobina As Nullable(Of Double), trigliceridos As Nullable(Of Double)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Dim acidoUricoParameter As ObjectParameter = If(acidoUrico.HasValue, New ObjectParameter("acidoUrico", acidoUrico), New ObjectParameter("acidoUrico", GetType(Double)))

        Dim creatininaParameter As ObjectParameter = If(creatinina.HasValue, New ObjectParameter("creatinina", creatinina), New ObjectParameter("creatinina", GetType(Double)))

        Dim colesterolParameter As ObjectParameter = If(colesterol.HasValue, New ObjectParameter("colesterol", colesterol), New ObjectParameter("colesterol", GetType(Double)))

        Dim hematocritoParameter As ObjectParameter = If(hematocrito.HasValue, New ObjectParameter("hematocrito", hematocrito), New ObjectParameter("hematocrito", GetType(Double)))

        Dim hemoglobinaParameter As ObjectParameter = If(hemoglobina.HasValue, New ObjectParameter("hemoglobina", hemoglobina), New ObjectParameter("hemoglobina", GetType(Double)))

        Dim trigliceridosParameter As ObjectParameter = If(trigliceridos.HasValue, New ObjectParameter("trigliceridos", trigliceridos), New ObjectParameter("trigliceridos", GetType(Double)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_actualizar_ExamenSangre", idParameter, idConsultaParameter, acidoUricoParameter, creatininaParameter, colesterolParameter, hematocritoParameter, hemoglobinaParameter, trigliceridosParameter)
    End Function

    Public Overridable Function sp_actualizar_paciente(cedula As Nullable(Of Integer), nombre As String, edad As Nullable(Of Integer), correo As String, fechaNacimiento As Nullable(Of Date), peso As Nullable(Of Double), altura As Nullable(Of Double), telefono As Nullable(Of Integer), tipoSangre As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim edadParameter As ObjectParameter = If(edad.HasValue, New ObjectParameter("edad", edad), New ObjectParameter("edad", GetType(Integer)))

        Dim correoParameter As ObjectParameter = If(correo IsNot Nothing, New ObjectParameter("correo", correo), New ObjectParameter("correo", GetType(String)))

        Dim fechaNacimientoParameter As ObjectParameter = If(fechaNacimiento.HasValue, New ObjectParameter("fechaNacimiento", fechaNacimiento), New ObjectParameter("fechaNacimiento", GetType(Date)))

        Dim pesoParameter As ObjectParameter = If(peso.HasValue, New ObjectParameter("peso", peso), New ObjectParameter("peso", GetType(Double)))

        Dim alturaParameter As ObjectParameter = If(altura.HasValue, New ObjectParameter("altura", altura), New ObjectParameter("altura", GetType(Double)))

        Dim telefonoParameter As ObjectParameter = If(telefono.HasValue, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(Integer)))

        Dim tipoSangreParameter As ObjectParameter = If(tipoSangre IsNot Nothing, New ObjectParameter("tipoSangre", tipoSangre), New ObjectParameter("tipoSangre", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_actualizar_paciente", cedulaParameter, nombreParameter, edadParameter, correoParameter, fechaNacimientoParameter, pesoParameter, alturaParameter, telefonoParameter, tipoSangreParameter)
    End Function

    Public Overridable Function sp_buscar_enfermedad(id As Nullable(Of Integer)) As ObjectResult(Of sp_buscar_enfermedad_Result)
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_buscar_enfermedad_Result)("sp_buscar_enfermedad", idParameter)
    End Function

    Public Overridable Function sp_buscar_ExamenOrina(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_buscar_ExamenOrina", idParameter, idConsultaParameter)
    End Function

    Public Overridable Function sp_buscar_ExamenSangre(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_buscar_ExamenSangre", idParameter, idConsultaParameter)
    End Function

    Public Overridable Function sp_buscar_paciente(cedula As Nullable(Of Integer)) As ObjectResult(Of sp_buscar_paciente_Result)
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_buscar_paciente_Result)("sp_buscar_paciente", cedulaParameter)
    End Function

    Public Overridable Function sp_buscar_usuario(cedula As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_buscar_usuario", cedulaParameter)
    End Function

    Public Overridable Function sp_eliminar_cita(id As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_cita", idParameter)
    End Function

    Public Overridable Function sp_eliminar_enfermedad(id As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_enfermedad", idParameter)
    End Function

    Public Overridable Function sp_eliminar_ExamenOrina(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_ExamenOrina", idParameter, idConsultaParameter)
    End Function

    Public Overridable Function sp_eliminar_ExamenSangre(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_ExamenSangre", idParameter, idConsultaParameter)
    End Function

    Public Overridable Function sp_eliminar_medicamento_alergico(id As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_medicamento_alergico", idParameter)
    End Function

    Public Overridable Function sp_eliminar_medicamento_Recetado(id As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_medicamento_Recetado", idParameter)
    End Function

    Public Overridable Function sp_eliminar_paciente(cedula As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_paciente", cedulaParameter)
    End Function

    Public Overridable Function sp_eliminar_usuario(cedula As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_eliminar_usuario", cedulaParameter)
    End Function

    Public Overridable Function sp_modificar_enfermedad(id As Nullable(Of Integer), enfermedad As String, descripcion As String) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim enfermedadParameter As ObjectParameter = If(enfermedad IsNot Nothing, New ObjectParameter("enfermedad", enfermedad), New ObjectParameter("enfermedad", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_modificar_enfermedad", idParameter, enfermedadParameter, descripcionParameter)
    End Function

    Public Overridable Function sp_modificar_paciente(cedula As Nullable(Of Integer), nombre As String, edad As Nullable(Of Integer), correo As String, fechaNacimiento As Nullable(Of Date), peso As Nullable(Of Double), altura As Nullable(Of Double), telefono As Nullable(Of Integer), tiposangre As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim edadParameter As ObjectParameter = If(edad.HasValue, New ObjectParameter("edad", edad), New ObjectParameter("edad", GetType(Integer)))

        Dim correoParameter As ObjectParameter = If(correo IsNot Nothing, New ObjectParameter("correo", correo), New ObjectParameter("correo", GetType(String)))

        Dim fechaNacimientoParameter As ObjectParameter = If(fechaNacimiento.HasValue, New ObjectParameter("fechaNacimiento", fechaNacimiento), New ObjectParameter("fechaNacimiento", GetType(Date)))

        Dim pesoParameter As ObjectParameter = If(peso.HasValue, New ObjectParameter("peso", peso), New ObjectParameter("peso", GetType(Double)))

        Dim alturaParameter As ObjectParameter = If(altura.HasValue, New ObjectParameter("altura", altura), New ObjectParameter("altura", GetType(Double)))

        Dim telefonoParameter As ObjectParameter = If(telefono.HasValue, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(Integer)))

        Dim tiposangreParameter As ObjectParameter = If(tiposangre IsNot Nothing, New ObjectParameter("tiposangre", tiposangre), New ObjectParameter("tiposangre", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_modificar_paciente", cedulaParameter, nombreParameter, edadParameter, correoParameter, fechaNacimientoParameter, pesoParameter, alturaParameter, telefonoParameter, tiposangreParameter)
    End Function

    Public Overridable Function sp_modificar_usuario(cedula As Nullable(Of Integer), contraseña As String, correo As String, fechaNacimiento As Nullable(Of Date), nombre As String, nombreUsuario As String, telefono As String, tipo As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim contraseñaParameter As ObjectParameter = If(contraseña IsNot Nothing, New ObjectParameter("contraseña", contraseña), New ObjectParameter("contraseña", GetType(String)))

        Dim correoParameter As ObjectParameter = If(correo IsNot Nothing, New ObjectParameter("correo", correo), New ObjectParameter("correo", GetType(String)))

        Dim fechaNacimientoParameter As ObjectParameter = If(fechaNacimiento.HasValue, New ObjectParameter("fechaNacimiento", fechaNacimiento), New ObjectParameter("fechaNacimiento", GetType(Date)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim nombreUsuarioParameter As ObjectParameter = If(nombreUsuario IsNot Nothing, New ObjectParameter("nombreUsuario", nombreUsuario), New ObjectParameter("nombreUsuario", GetType(String)))

        Dim telefonoParameter As ObjectParameter = If(telefono IsNot Nothing, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(String)))

        Dim tipoParameter As ObjectParameter = If(tipo IsNot Nothing, New ObjectParameter("tipo", tipo), New ObjectParameter("tipo", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_modificar_usuario", cedulaParameter, contraseñaParameter, correoParameter, fechaNacimientoParameter, nombreParameter, nombreUsuarioParameter, telefonoParameter, tipoParameter)
    End Function

    Public Overridable Function sp_registrar_cita(especialidad As String, fechaHora As Nullable(Of Date), cedulaPaciente As Nullable(Of Integer), cedulaMedico As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim especialidadParameter As ObjectParameter = If(especialidad IsNot Nothing, New ObjectParameter("especialidad", especialidad), New ObjectParameter("especialidad", GetType(String)))

        Dim fechaHoraParameter As ObjectParameter = If(fechaHora.HasValue, New ObjectParameter("fechaHora", fechaHora), New ObjectParameter("fechaHora", GetType(Date)))

        Dim cedulaPacienteParameter As ObjectParameter = If(cedulaPaciente.HasValue, New ObjectParameter("cedulaPaciente", cedulaPaciente), New ObjectParameter("cedulaPaciente", GetType(Integer)))

        Dim cedulaMedicoParameter As ObjectParameter = If(cedulaMedico.HasValue, New ObjectParameter("cedulaMedico", cedulaMedico), New ObjectParameter("cedulaMedico", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_cita", especialidadParameter, fechaHoraParameter, cedulaPacienteParameter, cedulaMedicoParameter)
    End Function

    Public Overridable Function sp_registrar_enfermedad(cedulaPaciente As Nullable(Of Integer), enfermedad As String, descripcion As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaPacienteParameter As ObjectParameter = If(cedulaPaciente.HasValue, New ObjectParameter("cedulaPaciente", cedulaPaciente), New ObjectParameter("cedulaPaciente", GetType(Integer)))

        Dim enfermedadParameter As ObjectParameter = If(enfermedad IsNot Nothing, New ObjectParameter("enfermedad", enfermedad), New ObjectParameter("enfermedad", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_enfermedad", cedulaPacienteParameter, enfermedadParameter, descripcionParameter)
    End Function

    Public Overridable Function sp_registrar_ExamenOrina(idConsulta As Nullable(Of Integer), color As String, eritrocitos As Nullable(Of Double), glucosa As Nullable(Of Double), leucocitos As Nullable(Of Double)) As ObjectResult(Of Nullable(Of Integer))
        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Dim colorParameter As ObjectParameter = If(color IsNot Nothing, New ObjectParameter("color", color), New ObjectParameter("color", GetType(String)))

        Dim eritrocitosParameter As ObjectParameter = If(eritrocitos.HasValue, New ObjectParameter("eritrocitos", eritrocitos), New ObjectParameter("eritrocitos", GetType(Double)))

        Dim glucosaParameter As ObjectParameter = If(glucosa.HasValue, New ObjectParameter("glucosa", glucosa), New ObjectParameter("glucosa", GetType(Double)))

        Dim leucocitosParameter As ObjectParameter = If(leucocitos.HasValue, New ObjectParameter("leucocitos", leucocitos), New ObjectParameter("leucocitos", GetType(Double)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_ExamenOrina", idConsultaParameter, colorParameter, eritrocitosParameter, glucosaParameter, leucocitosParameter)
    End Function

    Public Overridable Function sp_registrar_ExamenSangre(idConsulta As Nullable(Of Integer), acidoUrico As Nullable(Of Double), creatinina As Nullable(Of Double), colesterol As Nullable(Of Double), hematocrito As Nullable(Of Double), hemoglobina As Nullable(Of Double), trigliceridos As Nullable(Of Double)) As ObjectResult(Of Nullable(Of Integer))
        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Dim acidoUricoParameter As ObjectParameter = If(acidoUrico.HasValue, New ObjectParameter("acidoUrico", acidoUrico), New ObjectParameter("acidoUrico", GetType(Double)))

        Dim creatininaParameter As ObjectParameter = If(creatinina.HasValue, New ObjectParameter("creatinina", creatinina), New ObjectParameter("creatinina", GetType(Double)))

        Dim colesterolParameter As ObjectParameter = If(colesterol.HasValue, New ObjectParameter("colesterol", colesterol), New ObjectParameter("colesterol", GetType(Double)))

        Dim hematocritoParameter As ObjectParameter = If(hematocrito.HasValue, New ObjectParameter("hematocrito", hematocrito), New ObjectParameter("hematocrito", GetType(Double)))

        Dim hemoglobinaParameter As ObjectParameter = If(hemoglobina.HasValue, New ObjectParameter("hemoglobina", hemoglobina), New ObjectParameter("hemoglobina", GetType(Double)))

        Dim trigliceridosParameter As ObjectParameter = If(trigliceridos.HasValue, New ObjectParameter("trigliceridos", trigliceridos), New ObjectParameter("trigliceridos", GetType(Double)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_ExamenSangre", idConsultaParameter, acidoUricoParameter, creatininaParameter, colesterolParameter, hematocritoParameter, hemoglobinaParameter, trigliceridosParameter)
    End Function

    Public Overridable Function sp_registrar_medicamento_alergico(cedula As Nullable(Of Integer), medicamento As String, descripcion As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim medicamentoParameter As ObjectParameter = If(medicamento IsNot Nothing, New ObjectParameter("medicamento", medicamento), New ObjectParameter("medicamento", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_medicamento_alergico", cedulaParameter, medicamentoParameter, descripcionParameter)
    End Function

    Public Overridable Function sp_registrar_medicamento_recetado(idConsulta As Nullable(Of Integer), medicamento As String, descripcion As String) As ObjectResult(Of Nullable(Of Integer))
        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Dim medicamentoParameter As ObjectParameter = If(medicamento IsNot Nothing, New ObjectParameter("medicamento", medicamento), New ObjectParameter("medicamento", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_medicamento_recetado", idConsultaParameter, medicamentoParameter, descripcionParameter)
    End Function

    Public Overridable Function sp_registrar_paciente(cedula As Nullable(Of Integer), nombre As String, edad As Nullable(Of Integer), correo As String, fechaNacimiento As Nullable(Of Date), peso As Nullable(Of Double), altura As Nullable(Of Double), telefono As Nullable(Of Integer), tiposangre As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim edadParameter As ObjectParameter = If(edad.HasValue, New ObjectParameter("edad", edad), New ObjectParameter("edad", GetType(Integer)))

        Dim correoParameter As ObjectParameter = If(correo IsNot Nothing, New ObjectParameter("correo", correo), New ObjectParameter("correo", GetType(String)))

        Dim fechaNacimientoParameter As ObjectParameter = If(fechaNacimiento.HasValue, New ObjectParameter("fechaNacimiento", fechaNacimiento), New ObjectParameter("fechaNacimiento", GetType(Date)))

        Dim pesoParameter As ObjectParameter = If(peso.HasValue, New ObjectParameter("peso", peso), New ObjectParameter("peso", GetType(Double)))

        Dim alturaParameter As ObjectParameter = If(altura.HasValue, New ObjectParameter("altura", altura), New ObjectParameter("altura", GetType(Double)))

        Dim telefonoParameter As ObjectParameter = If(telefono.HasValue, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(Integer)))

        Dim tiposangreParameter As ObjectParameter = If(tiposangre IsNot Nothing, New ObjectParameter("tiposangre", tiposangre), New ObjectParameter("tiposangre", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_paciente", cedulaParameter, nombreParameter, edadParameter, correoParameter, fechaNacimientoParameter, pesoParameter, alturaParameter, telefonoParameter, tiposangreParameter)
    End Function

    Public Overridable Function sp_registrar_usuario(cedula As Nullable(Of Integer), contraseña As String, correo As String, fechaNacimiento As Nullable(Of Date), nombre As String, nombreUsuario As String, telefono As String, tipo As String) As ObjectResult(Of Nullable(Of Integer))
        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim contraseñaParameter As ObjectParameter = If(contraseña IsNot Nothing, New ObjectParameter("contraseña", contraseña), New ObjectParameter("contraseña", GetType(String)))

        Dim correoParameter As ObjectParameter = If(correo IsNot Nothing, New ObjectParameter("correo", correo), New ObjectParameter("correo", GetType(String)))

        Dim fechaNacimientoParameter As ObjectParameter = If(fechaNacimiento.HasValue, New ObjectParameter("fechaNacimiento", fechaNacimiento), New ObjectParameter("fechaNacimiento", GetType(Date)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim nombreUsuarioParameter As ObjectParameter = If(nombreUsuario IsNot Nothing, New ObjectParameter("nombreUsuario", nombreUsuario), New ObjectParameter("nombreUsuario", GetType(String)))

        Dim telefonoParameter As ObjectParameter = If(telefono IsNot Nothing, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(String)))

        Dim tipoParameter As ObjectParameter = If(tipo IsNot Nothing, New ObjectParameter("tipo", tipo), New ObjectParameter("tipo", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_registrar_usuario", cedulaParameter, contraseñaParameter, correoParameter, fechaNacimientoParameter, nombreParameter, nombreUsuarioParameter, telefonoParameter, tipoParameter)
    End Function

    Public Overridable Function sp_select_citas() As ObjectResult(Of sp_select_citas_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_select_citas_Result)("sp_select_citas")
    End Function

    Public Overridable Function sp_select_medicamento_alergico() As ObjectResult(Of sp_select_medicamento_alergico_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_select_medicamento_alergico_Result)("sp_select_medicamento_alergico")
    End Function

    Public Overridable Function sp_select_medicamentos_recetados() As ObjectResult(Of sp_select_medicamentos_recetados_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_select_medicamentos_recetados_Result)("sp_select_medicamentos_recetados")
    End Function

    Public Overridable Function sp_update_cita(id As Nullable(Of Integer), especialidad As String, fechaHora As Nullable(Of Date), cedula_paciente As Nullable(Of Integer), cedula_medico As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim especialidadParameter As ObjectParameter = If(especialidad IsNot Nothing, New ObjectParameter("especialidad", especialidad), New ObjectParameter("especialidad", GetType(String)))

        Dim fechaHoraParameter As ObjectParameter = If(fechaHora.HasValue, New ObjectParameter("fechaHora", fechaHora), New ObjectParameter("fechaHora", GetType(Date)))

        Dim cedula_pacienteParameter As ObjectParameter = If(cedula_paciente.HasValue, New ObjectParameter("cedula_paciente", cedula_paciente), New ObjectParameter("cedula_paciente", GetType(Integer)))

        Dim cedula_medicoParameter As ObjectParameter = If(cedula_medico.HasValue, New ObjectParameter("cedula_medico", cedula_medico), New ObjectParameter("cedula_medico", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_update_cita", idParameter, especialidadParameter, fechaHoraParameter, cedula_pacienteParameter, cedula_medicoParameter)
    End Function

    Public Overridable Function sp_update_medicamento_alergico(id As Nullable(Of Integer), cedula As Nullable(Of Integer), medicamento As String, descripcion As String) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim cedulaParameter As ObjectParameter = If(cedula.HasValue, New ObjectParameter("cedula", cedula), New ObjectParameter("cedula", GetType(Integer)))

        Dim medicamentoParameter As ObjectParameter = If(medicamento IsNot Nothing, New ObjectParameter("medicamento", medicamento), New ObjectParameter("medicamento", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_update_medicamento_alergico", idParameter, cedulaParameter, medicamentoParameter, descripcionParameter)
    End Function

    Public Overridable Function sp_update_medicamento_recetado(id As Nullable(Of Integer), idConsulta As Nullable(Of Integer), medicamento As String, descripcion As String) As ObjectResult(Of Nullable(Of Integer))
        Dim idParameter As ObjectParameter = If(id.HasValue, New ObjectParameter("id", id), New ObjectParameter("id", GetType(Integer)))

        Dim idConsultaParameter As ObjectParameter = If(idConsulta.HasValue, New ObjectParameter("idConsulta", idConsulta), New ObjectParameter("idConsulta", GetType(Integer)))

        Dim medicamentoParameter As ObjectParameter = If(medicamento IsNot Nothing, New ObjectParameter("medicamento", medicamento), New ObjectParameter("medicamento", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_update_medicamento_recetado", idParameter, idConsultaParameter, medicamentoParameter, descripcionParameter)
    End Function

    Public Overridable Function sp_validar_usuario(nombreUsuario As String, contraseña As String) As ObjectResult(Of Nullable(Of Integer))
        Dim nombreUsuarioParameter As ObjectParameter = If(nombreUsuario IsNot Nothing, New ObjectParameter("nombreUsuario", nombreUsuario), New ObjectParameter("nombreUsuario", GetType(String)))

        Dim contraseñaParameter As ObjectParameter = If(contraseña IsNot Nothing, New ObjectParameter("contraseña", contraseña), New ObjectParameter("contraseña", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("sp_validar_usuario", nombreUsuarioParameter, contraseñaParameter)
    End Function

End Class
