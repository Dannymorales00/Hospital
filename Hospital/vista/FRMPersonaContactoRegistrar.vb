Public Class FRMPersonaContactoRegistrar
    Dim conPersonaContacto As New ControladorPersonaContacto
    Private _personaContacto As PersonaContacto

    Property personaContacto As PersonaContacto
        Get
            Return _personaContacto
        End Get
        Set
            _personaContacto = Value
        End Set
    End Property

    Sub limpiarCampos()
        nombreTxt.Text = ""
        cedulaTxt.Text = ""
        labelCedula.Text = "******"
        labelNombre.Text = "******"
        telefonoTxt.Text = ""
        direccionTxt.Text = ""
        relacionTxt.Text = ""
    End Sub
    Function comprobarCampos() As Boolean
        If nombreTxt.Text IsNot "" And cedulaTxt.Text IsNot "" And relacionTxt IsNot "" And telefonoTxt IsNot "" And labelCedula IsNot "******" And direccionTxt IsNot "" Then
            Return True
        Else
            MsgBox("Rellene todos los campos")
            Return False
        End If
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarCampos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If comprobarCampos() Then
            personaContacto.nombreCompleto = nombreTxt.Text
            personaContacto.cedula = CInt(cedulaTxt.Text)
            personaContacto.relacionFamiliar = relacionTxt.Text
            personaContacto.telefono = telefonoTxt.Text
            personaContacto.cedulaPaciente = labelCedula.Text
            personaContacto.direccion = direccionTxt.Text
            Me.Hide()
        End If

    End Sub

    Private Sub FRMPersonaContactoRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class