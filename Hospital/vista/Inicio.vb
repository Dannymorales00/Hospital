Public Class FrmLogin
    Private usuario As Usuario
    Private usuarioParametro As Usuario




    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario = New Usuario()
        usuarioParametro = New Usuario()
        AjustarGrupoControles()


    End Sub

    Private Function ValidarTxt() As Boolean

        Return Not (TxtNombreUsuario.Text.Equals("")) AndAlso Not (TxtContraseña.Text.Equals(""))

    End Function



    Private Function ValidarUSuario() As Integer
        Dim Result As Integer = 0


        Try

            Using almacen = New ProyectoEntities1

                Result = almacen.sp_validar_usuario(usuario.nombreUsuario, usuario.contrasena).SingleOrDefault

            End Using

            Using almacen1 = New ProyectoEntities1

                Dim Result2 = almacen1.sp_Buscar_usuario2(usuario.nombreUsuario, usuario.contrasena).SingleOrDefault
                usuarioParametro.nombre = Result2.nombre
                usuarioParametro.nombreUsuario = Result2.nombreUsuario
                usuarioParametro.tipo = Result2.tipo

            End Using


        Catch ex As Exception
            MsgBox("Error al validar el usuario")

        End Try


        Return Result
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



        End If




    End Sub

    Private Sub Entrar()
        Dim frmPrincipal = New FrmPrincipal(usuarioParametro)
        frmPrincipal.Show()
        Me.Hide()




    End Sub


End Class
