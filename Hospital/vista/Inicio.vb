Public Class FrmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(500, 500)
        '.........point(x,y)// x = izquierda, y = arriba
        Me.GrupoIniciar.Location = New Point(115, 75)
        Me.GrupoRegistrar.Location = New Point(30.7, 75)


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



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub


End Class
