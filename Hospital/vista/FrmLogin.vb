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
            'MsgBox("Error al validar el usuario")

        End Try


        Return 0
    End Function
    Private Sub AjustarGrupoControles()
        Centrar(GrupoIniciar)

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If ValidarTxt() Then
            usuario = New Usuario()
            usuario.nombreUsuario = TxtNombreUsuario.Text
            usuario.contrasena = TxtContraseña.Text

            If ValidarUSuario() = 1 Then
                MessageBox.Show("Bienvenido, " + usuario.nombreUsuario, "", MessageBoxButtons.OK)

                Entrar()

            Else
                MessageBox.Show("¡Datos incorrectos!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else
            MessageBox.Show("Debe Ingresar un usuario y una contraseña", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If




    End Sub

    Private Sub Entrar()

        Dim frmPrincipal = New FrmPrincipal(usuarioParametro)
        frmPrincipal.Show()
        Me.Hide()

    End Sub


    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

End Class
