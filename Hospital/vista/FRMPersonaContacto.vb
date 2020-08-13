﻿Public Class FRMPersonaContacto
    Dim conPersonaContacto As New ControladorPersonaContacto
    Dim paciente As New Paciente

    Sub limpiarCampos()
        nombreTxt.Text = ""
        cedulaTxt.Text = ""
        labelCedula.Text = "******"
        labelNombre.Text = "******"
        telefonoTxt.Text = ""
        direccionTxt.Text = ""
        relacionTxt.Text = "a"
    End Sub

    Sub cargarTabla()
        Dim personaContacto As New PersonaContacto
        personaContacto.cedula = cedulaBuscarTxt.Text
        Dim datosTabla = conPersonaContacto.consultar(personaContacto)
        tablaPersonas.DataSource = datosTabla

    End Sub











    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If comprobarCampos() Then
            Dim personaContacto As New PersonaContacto

            personaContacto.nombreCompleto = nombreTxt.Text
            PersonaContacto.cedula = CInt(cedulaTxt.Text)
            personaContacto.relacionFamiliar = relacionTxt.Text
            personaContacto.telefono = telefonoTxt.Text
            personaContacto.cedulaPaciente = labelCedula.Text
            personaContacto.direccion = direccionTxt.Text
            personaContacto.cedulaPaciente = CInt(labelCedula.Text)
            If conPersonaContacto.registrar(personaContacto) Then
                limpiarCampos()
                MsgBox("Se inserto la persona correctamente")

            Else
                MsgBox("Error al agregar la persona")
            End If


        End If

    End Sub
    Function comprobarCampos() As Boolean
        If nombreTxt.Text IsNot "" AndAlso cedulaTxt.Text IsNot "" AndAlso relacionTxt IsNot "" AndAlso telefonoTxt IsNot "" AndAlso labelCedula IsNot "******" AndAlso direccionTxt IsNot "" Then
            Return True
        Else
            MsgBox("Rellene todos los campos")
            Return False
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarCampos()

    End Sub

    Private Sub FRMPersonaContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()
    End Sub

    Private Sub cedulaBuscarTxt_TextChanged(sender As Object, e As EventArgs) Handles cedulaBuscarTxt.KeyPress
        cargarTabla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pacienteForm As New BuscarPaciente
        pacienteForm.ShowDialog()
        paciente = pacienteForm.pacienteRetorno
        pacienteForm.Close()

        If paciente.cedula = Nothing Then
        Else
            labelCedula.Text = paciente.cedula.ToString
            labelNombre.Text = paciente.nombre
        End If

    End Sub
End Class