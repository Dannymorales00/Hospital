Public Class FrmLogin
    Private usuario As Usuario
    Private usuarioParametro As Usuario




    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario = New Usuario()
        usuarioParametro = New Usuario()
        AjustarGrupoControles()


    End Sub

    Private Function ValidarTxt() As Boolean

        Return Not (TxtNombreUsuario.Text.Equals("")) And Not (TxtContraseña.Text.Equals(""))

    End Function



    Private Function ValidarUSuario() As Integer

        Try

            Using almacen = New ProyectoEntities1

                Dim Result = almacen.sp_validar_usuario(usuario.nombreUsuario, usuario.contrasena).ToList

                If Result.Count > 0 Then
                    usuarioParametro.nombreUsuario = Result.ElementAt(0).nombreUsuario
                    usuarioParametro.tipo = Result.ElementAt(0).tipo
                    Return 1
                End If

            End Using

        Catch ex As Exception
            MsgBox("Error al validar el usuario")

        End Try


        Return 0
    End Function

    Private Sub AjustarGrupoControles()

        Me.Size = New Size(400, 400)
        '-----point(x,y)    x = izquierda, y = arriba
        Me.GrupoIniciar.Location = New Point(70, 60)

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If ValidarTxt() Then
            usuario = New Usuario()
            usuario.nombreUsuario = TxtNombreUsuario.Text
            usuario.contrasena = TxtContraseña.Text

            If ValidarUSuario() = 1 Then
                MsgBox("Bienvenido")
                Entrar()

            Else
                MsgBox("No se logro Ingresar ¡Datos incorrectos!")

            End If

        Else
            MsgBox("Debe Ingresar un usuario y una contraseña")

        End If




    End Sub

    Private Sub Entrar()

        Dim frmPrincipal = New FrmPrincipal(usuarioParametro)
        frmPrincipal.Show()
        Me.Hide()

    End Sub


End Class
