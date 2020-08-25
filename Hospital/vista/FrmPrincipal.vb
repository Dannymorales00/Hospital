Imports System.ComponentModel

Public Class FrmPrincipal
    Private usuario As Usuario
    Private frmUsuario As FrmUsuario
    Private frmEnfermedades As FrmEnfermedad

    Public Sub New(usuario1 As Usuario)
        usuario = New Usuario()
        frmUsuario = New FrmUsuario()
        frmEnfermedades = New FrmEnfermedad()
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

    Private Sub BtnEnfermedades_Click(sender As Object, e As EventArgs) Handles BtnEnfermedades.Click
        frmEnfermedades.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmSelecionarCitas As New FRMSeleccionarCitas
        frmSelecionarCitas.ShowDialog()
    End Sub
End Class