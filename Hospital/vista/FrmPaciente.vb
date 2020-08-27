﻿Public Class FrmPaciente
    Private frmEnfemedades As New FrmEnfermedad
    Private paciente As Paciente
    Private controladorPaciente As New ControladorPaciente()
    Private controladorPersonaContacto As New ControladorPersonaContacto
    Private personaContacto As New PersonaContacto()
    Private listaEnfermedades As New List(Of Enfermedad)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()

    End Sub



    Public Function comprobarAgregar() As Boolean
        Return Not TxtCedula.Text.Equals("") And TxtNombre.Text.Equals("") And TxtAltura.Text.Equals("") And TxtCorreo.Text.Equals("") And TxtEdad.Text.Equals("") And TxtPeso.Text.Equals("") And TxtTelefono.Equals("")

    End Function

    Public Sub cargarTabla()
        paciente = New Paciente
        paciente.cedula = TxtBuscarCedula.Text

        Dim datosTabla = controladorPaciente.buscarPacientes(paciente)
        DataGridView1.DataSource = datosTabla
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If comprobarAgregar() Then
            paciente = New Paciente(Val(TxtCedula.Text), TxtNombre.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtTelefono.Text), TxtCorreo.Text, Val(TxtEdad.Text), Val(TxtPeso.Text), Val(TxtAltura.Text), ComboTipo.SelectedItem.ToString.Trim)

            If BtnRegistrar.Text = "Registrar" Then
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
                If controladorPaciente.actualizar(paciente) = 1 Then
                    MsgBox("se actualizó correctamente el paciente")
                Else
                    MsgBox("No se actualizo el paciente")
                End If
            End If

        Else
            MsgBox("Debe rellenar todos los campos")
        End If

        cargarTabla()
        limpiarCampos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not (TxtCedula.Text.Equals("")) Then
            paciente = New Paciente()
            paciente.cedula = Val(TxtCedula.Text)

            If controladorPaciente.eliminar(paciente) = 1 Then
                MsgBox("Se elimino correctamente el paciente")
            Else
                MsgBox("No se elimino el paciente")
            End If
        Else
            MsgBox("Debe rellenar todos los campos")
        End If
    End Sub

    Sub limpiarCampos()
        TxtCedula.Text = ""
        TxtNombre.Text = ""
        DateTimePicker1.ResetText()
        TxtTelefono.Text = ""
        TxtCorreo.Text = ""
        TxtEdad.Text = ""
        TxtAltura.Text = ""
        TxtPeso.Text = ""
        BtnPersonaC.Text = "Persona Contacto"
        BtnEnfermedades.Text = "Enfermedades"
        BtnMedicamentos.Text = "Medicamentos"
        ComboTipo.ResetText()
        BtnRegistrar.Text = "Registrar"
    End Sub


    Private Sub BtnEnfermedades_Click(sender As Object, e As EventArgs) Handles BtnEnfermedades.Click
        Dim paciente = New Paciente()
        If comprobarAgregar() Then

            paciente = New Paciente(Val(TxtCedula.Text), TxtNombre.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), Val(TxtTelefono.Text), TxtCorreo.Text, Val(TxtEdad.Text), Val(TxtPeso.Text), Val(TxtAltura.Text), ComboTipo.SelectedItem.ToString)
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

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        paciente = New Paciente

        paciente.cedula = Val(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)

        Dim result1 = controladorPaciente.cargar(paciente)

        paciente.nombre = result1.nombre
        paciente.fechaNacimiento = result1.fechaNacimiento
        paciente.correo = result1.correo
        paciente.telefono = result1.telefono
        paciente.edad = result1.edad
        paciente.altura = result1.altura
        paciente.contactosPersona = result1.contactosPersona
        paciente.tipoSangre = result1.tipoSangre

        TxtCedula.Text = paciente.cedula
        TxtNombre.Text = paciente.nombre
        DateTimePicker1.Value = paciente.fechaNacimiento

        TxtTelefono.Text = paciente.telefono
        TxtCorreo.Text = paciente.correo
        TxtEdad.Text = paciente.edad
        TxtPeso.Text = paciente.peso
        TxtAltura.Text = paciente.altura
        ComboTipo.SelectedIndex = ComboTipo.FindString(paciente.tipoSangre.Trim)

        BtnRegistrar.Text = "Actualizar"
    End Sub

    Private Sub BtnPersonaC_Click(sender As Object, e As EventArgs) Handles BtnPersonaC.Click
        If TxtNombre.Text = "" And TxtCedula.Text = "" Then
            MsgBox("Tiene que rellenar los campos Nombre y Cedula primero")

        Else
            personaContacto = New PersonaContacto
            Dim frmPersonaContacto As New FRMPersonaContactoRegistrar
            frmPersonaContacto.labelCedula.Text = TxtCedula.Text
            frmPersonaContacto.labelNombre.Text = TxtNombre.Text
            frmPersonaContacto.ShowDialog()
            personaContacto = frmPersonaContacto.personaContacto
            Try
                BtnPersonaC.Text = personaContacto.nombreCompleto
            Catch ex As Exception
                MsgBox("No se registro un paciente")
            End Try

            frmPersonaContacto.Close()
        End If
    End Sub

    Private Sub BtnMedicamentos_Click(sender As Object, e As EventArgs) Handles BtnMedicamentos.Click
        paciente = New Paciente
        paciente.cedula = TxtCedula.Text
        Dim result1 = controladorPaciente.cargar(paciente)

        paciente.nombre = result1.nombre
        paciente.fechaNacimiento = result1.fechaNacimiento
        paciente.correo = result1.correo
        paciente.telefono = result1.telefono
        paciente.edad = result1.edad
        paciente.altura = result1.altura
        paciente.contactosPersona = result1.contactosPersona
        paciente.tipoSangre = result1.tipoSangre

        Dim frmMedicamentos = New FrmMedicamentoAlergicoRegistrar(paciente)
        frmMedicamentos.ShowDialog()
    End Sub

    Private Sub TxtBuscarCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCedula.TextChanged
        cargarTabla()
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub AdministrarEnfermedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarEnfermedadesToolStripMenuItem.Click
        frmEnfemedades.Show()
    End Sub
End Class