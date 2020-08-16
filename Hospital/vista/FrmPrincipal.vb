Imports System.ComponentModel

Public Class FrmPrincipal
    Private usuario As Usuario

    Public Sub New(usuario1 As Usuario)
        usuario = New Usuario()
        usuario = usuario1
        'MsgBox(usuario.tipo)
        InitializeComponent()

    End Sub

    Private Sub FrmPrincipal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("Si cierra la aplicacion puede que no se guarden algunos cambios, realmente desea salir?", MsgBoxStyle.YesNo, "Salir?") = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MenuPerfilNombreUSuario.Text = "Username: " + usuario.nombreUsuario
        Me.MenuPerfilTipo.Text = "Tipo: " + usuario.tipo

    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilToolStripMenuItem.Click

    End Sub
End Class