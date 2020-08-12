Public Class FRMPersonaContacto
    Dim conPersonaContacto As New ControladorPersonaContacto
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conPersonaContacto.registrar(nombreTxt.Text, CInt(cedulaTxt.Text), relacionTxt.Text, CInt(telefonoTxt.Text), labelCedula.Text, direccionTxt.Text)
    End Sub
    Function comprobarCampos() As Boolean
        If nombreTxt.Text IsNot "" And cedulaTxt.Text IsNot "" And relacionTxt IsNot "" And telefonoTxt IsNot "" And labelCedula IsNot "******" And Then

        End If
    End Function

    Private Sub FRMPersonaContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class