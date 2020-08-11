Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IniciarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesiónToolStripMenuItem.Click
        GrupoRegistrar.Show()
    End Sub


    Private Sub mostrarAgregar()
        GrupoRegistrar.Show()

    End Sub


    Private Sub ocultarAgregar()
        GrupoRegistrar.Hide()

    End Sub

    Private Sub RegistrarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarseToolStripMenuItem.Click
        GrupoRegistrar.Hide()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        GrupoRegistrar.Hide()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        GrupoRegistrar.Hide()
    End Sub
End Class