Public Class FRMPersonaContacto
    Dim conPersonaContacto As New ControladorPersonaContacto
    Dim paciente As New Paciente
    Dim personaContacto As New PersonaContacto
    Sub limpiarCampos()
        nombreTxt.Text = ""
        cedulaTxt.Text = ""
        labelCedula.Text = "******"
        labelNombre.Text = "******"
        telefonoTxt.Text = ""
        direccionTxt.Text = ""
        relacionTxt.Text = ""
        cedulaTxt.ReadOnly = False
        btnRegistrar.Text = "Registrar"
    End Sub

    Sub cargarTabla()
        personaContacto = New PersonaContacto
        personaContacto.cedula = cedulaBuscarTxt.Text
        Dim datosTabla = conPersonaContacto.consultar(personaContacto)
        tablaPersonas.DataSource = datosTabla

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If comprobarCampos() Then
            personaContacto = New PersonaContacto

            personaContacto.nombreCompleto = nombreTxt.Text
            personaContacto.cedula = CInt(cedulaTxt.Text)
            personaContacto.relacionFamiliar = relacionTxt.Text
            personaContacto.telefono = telefonoTxt.Text
            personaContacto.cedulaPaciente = labelCedula.Text
            personaContacto.direccion = direccionTxt.Text
            personaContacto.cedulaPaciente = CInt(labelCedula.Text)
            If btnRegistrar.Text = "Registrar" Then
                If conPersonaContacto.registrar(personaContacto) Then

                    MsgBox("Se inserto la persona correctamente")

                Else
                    MsgBox("Error al agregar la persona")
                End If
            Else
                If conPersonaContacto.actualizar(personaContacto) Then

                    MsgBox("Se actualizo la persona correctamente")

                Else
                    MsgBox("Error al actualizar la persona")
                End If
            End If
            cargarTabla()
            limpiarCampos()

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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pacienteForm As New FrmBuscarPaciente
        pacienteForm.ShowDialog()
        paciente = pacienteForm.PacienteRetorno1
        pacienteForm.Close()

        If paciente.cedula = Nothing Then
        Else
            labelCedula.Text = paciente.cedula.ToString
            labelNombre.Text = paciente.nombre
        End If

    End Sub

    Private Sub tablaPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaPersonas.CellClick
        nombreTxt.Text = tablaPersonas.Item(0, tablaPersonas.CurrentRow.Index).Value
        cedulaTxt.Text = tablaPersonas.Item(1, tablaPersonas.CurrentRow.Index).Value
        relacionTxt.Text = tablaPersonas.Item(2, tablaPersonas.CurrentRow.Index).Value
        telefonoTxt.Text = tablaPersonas.Item(3, tablaPersonas.CurrentRow.Index).Value
        direccionTxt.Text = tablaPersonas.Item(4, tablaPersonas.CurrentRow.Index).Value
        labelNombre.Text = tablaPersonas.Item(5, tablaPersonas.CurrentRow.Index).Value
        labelCedula.Text = tablaPersonas.Item(6, tablaPersonas.CurrentRow.Index).Value
        cedulaTxt.ReadOnly = True
        btnRegistrar.Text = "Actualizar"


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        personaContacto = New PersonaContacto
        personaContacto.cedula = cedulaTxt.Text
        conPersonaContacto.eliminar(personaContacto)
        cargarTabla()
        limpiarCampos()

    End Sub

    Private Sub cedulaBuscarTxt_TextChanged(sender As Object, e As EventArgs) Handles cedulaBuscarTxt.TextChanged
        cargarTabla()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub labelNombre_Click(sender As Object, e As EventArgs) Handles labelNombre.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub labelCedula_Click(sender As Object, e As EventArgs) Handles labelCedula.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub telefonoTxt_TextChanged(sender As Object, e As EventArgs) Handles telefonoTxt.TextChanged

    End Sub

    Private Sub tablaPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaPersonas.CellContentClick

    End Sub

    Private Sub relacionTxt_TextChanged(sender As Object, e As EventArgs) Handles relacionTxt.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cedulaTxt_TextChanged(sender As Object, e As EventArgs) Handles cedulaTxt.TextChanged

    End Sub

    Private Sub direccionTxt_TextChanged(sender As Object, e As EventArgs) Handles direccionTxt.TextChanged

    End Sub

    Private Sub nombreTxt_TextChanged(sender As Object, e As EventArgs) Handles nombreTxt.TextChanged

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Hide()
    End Sub
End Class