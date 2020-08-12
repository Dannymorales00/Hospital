Public Class FRMPersonaContacto
    Dim conPersonaContacto As New ControladorPersonaContacto
    Dim personaContacto As New PersonaContacto
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If comprobarCampos() Then
            personaContacto.nombreCompleto = nombreTxt.Text
            personaContacto.cedula = CInt(cedulaTxt.Text)
            personaContacto.relacionFamiliar = relacionTxt.Text
            personaContacto.telefono = telefonoTxt.Text
            personaContacto.cedulaPaciente = labelCedula.Text
            personaContacto.direccion = direccionTxt.Text
            conPersonaContacto.registrar(personaContacto)
            limpiarCampos()
        End If

    End Sub
    Function comprobarCampos() As Boolean
        If nombreTxt.Text IsNot "" And cedulaTxt.Text IsNot "" And relacionTxt IsNot "" And telefonoTxt IsNot "" And labelCedula IsNot "******" And direccionTxt IsNot "" Then
            Return True
        Else
            MsgBox("Rellene todos los campos")
            Return False
        End If
    End Function

    Sub limpiarCampos()
        nombreTxt.Text = ""
        cedulaTxt.Text = ""
        labelCedula.Text = "******"
        labelNombre.Text = "******"
        telefonoTxt.Text = ""
        direccionTxt.Text = ""
        relacionTxt.Text = "a"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarCampos()
    End Sub
End Class