Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AjustarGrupoControles()

        ValidarUSuario()




    End Sub

    Private Sub ValidarUSuario()




    End Sub

    Private Sub AjustarGrupoControles()

        Me.Size = New Size(400, 500)
        '-----point(x,y)    x = izquierda, y = arriba
        Me.GrupoIniciar.Location = New Point(70, 70)

    End Sub

End Class
