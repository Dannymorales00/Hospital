Public Class FrmLogin
    Private usuario As Usuario
    Private nombreUsuario As String
    Private Contraseña As String

    Public Property P_NombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property P_Contraseña As String
        Get
            Return Contraseña
        End Get
        Set(value As String)
            Contraseña = value
        End Set
    End Property

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AjustarGrupoControles()


    End Sub

    Private Function ValidarTxt() As Boolean

        Return Not (TxtUsuario.Text.Equals("")) AndAlso Not (TxtContraseña.Text.Equals(""))

    End Function



    Private Function ValidarUSuario() As Integer
        Dim Result As Integer = 0

        Try




            Using almacen = New ProyectoEntities1

                Result = almacen.sp_validar_usuario(P_NombreUsuario, P_Contraseña).SingleOrDefault


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
            P_NombreUsuario = TxtUsuario.Text
            P_Contraseña = TxtContraseña.Text

            If ValidarUSuario() = 1 Then
                MsgBox("Bienvenido")
                Entrar()

            Else
                MsgBox("No se logro Ingresar ¡Datos incorrectos!")

            End If



        End If




    End Sub

    Private Sub Entrar()
        Dim frmPrincipal = New FrmPrincipal()
        frmPrincipal.Show()
        Me.Hide()




    End Sub


End Class
