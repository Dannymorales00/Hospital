Public Class FrmPaciente
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private paciente As Paciente
    Private controladorPaciente As New ControladorPaciente()
    Private controladorPersonaContacto As New ControladorPersonaContacto
    Private personaContacto As New PersonaContacto()
    Private listaEnfermedades As New List(Of Enfermedad)
    Public Function comprobarAgregar() As Boolean
        Return Not TxtRegistroCedula.Text.Equals("") And Not TxtRegistroNombre.Text.Equals("") And Not TxtAltura.Text.Equals("") And Not TxtCorreo.Text.Equals("") And Not TxtEdad.Text.Equals("") And Not TxtPeso.Text.Equals("") And Not TxtTelefono.Equals("")
        'Not TxtRegistroCedula.Text = "" And Not TxtRegistroNombre.Text = "" And Not TxtAltura.Text = "" And Not TxtCorreo.Text = "" And Not TxtEdad.Text = "" And Not btnPersonaContacto.Text = "Persona Contacto" And Not TxtPeso.Text = "" And Not TxtTelefono.Text = "" And Not ComboTipoSangre.SelectedIndex < 0 And DateTimePicker1.Checked
    End Function
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If comprobarAgregar() Then
            paciente = New Paciente(Val(TxtRegistroCedula.Text), TxtRegistroNombre.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtTelefono.Text), TxtCorreo.Text, Val(TxtEdad.Text), Val(TxtPeso.Text), Val(TxtAltura.Text), ComboTipoSangre.SelectedItem.ToString)
            If controladorPaciente.registrar(paciente) = 1 Then
                MsgBox("Se agrego correctamente el paciente")


                If controladorPersonaContacto.registrar(personaContacto) Then
                    MsgBox("Se agrego el contacto la persona contacto ")

                Else
                    MsgBox("Error al agregar el contacto del paciente")
                End If
            Else
                MsgBox("No se agrego el paciente")
            End If
        Else
            MsgBox("Debe rellenar todos los campos")
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not (TxtEliminarCedula.Text.Equals("")) Then
            paciente = New Paciente()
            paciente.cedula = Val(TxtEliminarCedula.Text)

            If controladorPaciente.eliminar(paciente) = 1 Then
                MsgBox("Se elimino correctamente el paciente")
            Else
                MsgBox("No se elimino el paciente")
            End If
        Else
            MsgBox("Debe rellenar todos los campos")
        End If
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click, BtnCargar.Click
        If Not (TxtActualizarCedula.Text.Equals("")) Then
            paciente = New Paciente()
            paciente.cedula = Val(TxtActualizarCedula.Text)
            Dim result = controladorPaciente.cargar(paciente)
            TxtActualizarNombre.Text = result.nombre
            DateTimePicker2.Value = result.fechaNacimiento
            TxtActualizarTelefono.Text = result.telefono
            TxtActualizarCorreo.Text = result.correo
            TxtActualizarEdad.Text = result.edad
            TxtActualizarPeso.Text = result.peso
            TxtActualizarAltura.Text = result.altura
            ComboTipo2.SelectedIndex = ComboTipo2.FindString(result.tipoSangre.Trim)
        Else
            MsgBox("Debe rellenar el campo cedula para cargar un paciente")
        End If
    End Sub



    Public Function comprabarActualizar() As Boolean
        Return Not (TxtActualizarCedula.Text.Equals("") AndAlso TxtActualizarNombre.Text.Equals("") AndAlso TxtActualizarAltura.Text.Equals("") AndAlso TxtActualizarCorreo.Text.Equals("") AndAlso TxtActualizarEdad.Text.Equals("") AndAlso TxtActualizarPeso.Text.Equals("") AndAlso TxtActualizarTelefono.Text.Equals("") AndAlso ComboTipo2.SelectedIndex < 0 AndAlso DateTimePicker2.Checked)
    End Function

    Sub limpiarCampos()
        TxtRegistroCedula.Text = ""
        TxtRegistroNombre.Text = ""
        DateTimePicker1.ResetText()
        TxtTelefono.Text = ""
        TxtCorreo.Text = ""
        TxtEdad.Text = ""
        TxtAltura.Text = ""
        TxtPeso.Text = ""
        btnPersonaContacto.Text = "Persona Contacto"
        ComboTipoSangre.ResetText()

    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If comprabarActualizar() Then
            paciente = New Paciente(Val(TxtActualizarCedula.Text), TxtActualizarNombre.Text, DateTimePicker2.Value.ToString("yyyy-MM-dd"), Val(TxtActualizarTelefono.Text), TxtActualizarCorreo.Text, Val(TxtActualizarEdad.Text), Val(TxtActualizarPeso.Text), Val(TxtActualizarAltura.Text), ComboTipo2.SelectedItem.ToString)

            If controladorPaciente.actualizar(paciente) = 1 Then
                MsgBox("se actualizó correctamente el paciente")
            Else
                MsgBox("No se actualizo el paciente")
            End If
        Else
            MsgBox("Debe rellenar los campos para actualizar un paciente")
        End If


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        paciente = New Paciente()
        paciente.cedula = Val(TxtBuscarCedula.Text)
        Dim result = controladorPaciente.cargar(paciente)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPersonaContacto.Click
        If TxtRegistroNombre.Text = "" And TxtRegistroCedula.Text = "" Then
            MsgBox("Tiene que rellenar los campos Nombre y Cedula primero")

        Else
            personaContacto = New PersonaContacto
            Dim frmPersonaContacto As New FRMPersonaContactoRegistrar
            frmPersonaContacto.labelCedula.Text = TxtRegistroCedula.Text
            frmPersonaContacto.labelNombre.Text = TxtRegistroNombre.Text
            frmPersonaContacto.ShowDialog()
            personaContacto = frmPersonaContacto.personaContacto
            Try
                btnPersonaContacto.Text = personaContacto.nombreCompleto
            Catch ex As Exception
                MsgBox("No se registro un paciente")
            End Try

            frmPersonaContacto.Close()
        End If

    End Sub

    Private Sub BtnEnfermedades_Click(sender As Object, e As EventArgs) Handles BtnEnfermedades.Click
        Dim paciente = New Paciente()
        If comprobarAgregar() Then

            paciente = New Paciente(Val(TxtRegistroCedula.Text), TxtRegistroNombre.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtTelefono.Text), TxtCorreo.Text, Val(TxtEdad.Text), Val(TxtPeso.Text), Val(TxtAltura.Text), ComboTipoSangre.SelectedItem.ToString)
            Dim frmEnfermedad = New FrmPacienteEnfermedad(paciente)
            frmEnfermedad.ShowDialog()

            If frmEnfermedad.P_ListaEnfermedades.Count > 0 Then
                listaEnfermedades = frmEnfermedad.P_ListaEnfermedades

                For Each elemento As Enfermedad In listaEnfermedades

                    MsgBox("Enfermedad: " + elemento.nombre + " // Descripcion: " + elemento.descripcion)


                Next



            End If


        Else
            MsgBox("Debe rellenar todos los campos de paciente para agregar enfermedades")

        End If





    End Sub
End Class