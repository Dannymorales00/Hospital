Imports System.ComponentModel

Public Class FrmPrincipal
    Private usuario As Usuario
    Private frmUsuario As FrmUsuario

    Public Sub New(usuario1 As Usuario)
        usuario = New Usuario()
        frmUsuario = New FrmUsuario()
        usuario = usuario1
        InitializeComponent()

    End Sub



    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MenuPerfilNombreUSuario.Text = "Username: " + usuario.nombreUsuario
        Me.MenuPerfilTipo.Text = "Tipo: " + usuario.tipo

    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        frmUsuario.Show()

    End Sub
End Class