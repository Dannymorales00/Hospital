Public Class FrmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MostrarIniciarSesion()

    End Sub

    Private Sub IniciarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesiónToolStripMenuItem.Click

        Me.MostrarIniciarSesion()

    End Sub

    Private Sub MostrarIniciarSesion()

        Me.GrupoIniciar.Visible = True
        Me.GrupoRegistrar.Visible = False


    End Sub

    Private Sub MostrarRegistrar()

        Me.GrupoIniciar.Visible = False
        Me.GrupoRegistrar.Visible = True

    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RegistrarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarseToolStripMenuItem.Click

        Me.MostrarRegistrar()

    End Sub

End Class
