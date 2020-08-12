Public Class FrmUsuario
    Private usuario As Usuario
    Private controladorUsuario As ControladorUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.usuario = New Usuario()
        Me.controladorUsuario = New ControladorUsuario()

        AjustesVentanas()
        MostrarAgregar()

    End Sub



    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If Comprobar() Then

            Me.usuario = New Usuario()
            usuario.cedula = Val(TxtCedula.Text)
            usuario.nombre = TxtNombre.Text
            usuario.nombreUsuario = TxtNombreUsuario.Text
            usuario.telefono = Val(TxtTelefono.Text)
            usuario.contrasena = TxtContraseña.Text
            usuario.correo = TxtCorreo.Text
            usuario.tipo = CBTipo.SelectedItem.ToString
            usuario.fechaNacimiento = DateTimePickerAgregar.Value

            If controladorUsuario.Registrar(usuario) = 1 Then
                MsgBox("se agrego correctamente el usuario")
                Limpiar()

            Else
                MsgBox("No se agrego el usuario")

            End If
        Else

            MsgBox("Debe rellenar todos los campos")

        End If


    End Sub


    Function Comprobar() As Boolean

        Return Not (TxtNombre.Text.Equals("") AndAlso TxtCedula.Text.Equals("") AndAlso TxtContraseña.Text.Equals("") AndAlso TxtCorreo.Text.Equals("") AndAlso TxtTelefono.Text.Equals("") AndAlso TxtNombreUsuario.Text.Equals("") AndAlso CBTipo.SelectedIndex < 0)

    End Function

    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtNombreUsuario.Text = ""
        TxtCedula.Text = ""
        TxtContraseña.Text = ""
        TxtCorreo.Text = ""
        TxtTelefono.Text = ""
        TxtNombreUsuario.Text = ""
        CBTipo.SelectedIndex = -1
    End Sub







    Private Sub AjustesVentanas()

        Me.Size = New Size(500, 500)
        '-----point(x,y)    x = izquierda, y = arriba
        Me.GrupoAgregar.Location = New Point(70, 60)
        Me.GrupoActualizar.Location = New Point(70, 60)
        Me.GrupoEliminar.Location = New Point(70, 60)
        Me.GrupoBuscar.Location = New Point(70, 60)

    End Sub


    Private Sub MostrarAgregar()

        Me.GrupoAgregar.Show()
        Me.GrupoActualizar.Hide()
        Me.GrupoEliminar.Hide()
        Me.GrupoBuscar.Hide()

    End Sub


    Private Sub MostrarActualizar()

        Me.GrupoAgregar.Hide()
        Me.GrupoActualizar.Show()
        Me.GrupoEliminar.Hide()
        Me.GrupoBuscar.Hide()

    End Sub

    Private Sub MostrarEliminar()

        Me.GrupoAgregar.Hide()
        Me.GrupoActualizar.Hide()
        Me.GrupoEliminar.Show()
        Me.GrupoBuscar.Hide()

    End Sub

    Private Sub MostrarBuscar()

        Me.GrupoAgregar.Hide()
        Me.GrupoActualizar.Hide()
        Me.GrupoEliminar.Hide()
        Me.GrupoBuscar.Show()

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        MostrarAgregar()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        MostrarEliminar()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        MostrarActualizar()

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        MostrarBuscar()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If Not (TxtCedulaEliminar.Text.Equals("")) Then

            Me.usuario = New Usuario()
            usuario.cedula = Val(TxtCedulaEliminar.Text)


            If controladorUsuario.Eliminar(usuario) = 1 Then
                MsgBox("se elimino correctamente el usuario")
                Limpiar()

            Else
                MsgBox("No se elimino el usuario")

            End If
        Else

            MsgBox("Debe rellenar todos los campos")

        End If



    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click

        If Not (TxtCedulaActualizar.Text.Equals("")) Then

            Me.usuario = New Usuario()
            usuario.cedula = Val(TxtCedulaActualizar.Text)


            If (controladorUsuario.Buscar(usuario)) IsNot Nothing Then
                MsgBox("se elimino correctamente el usuario")
                Limpiar()

            Else
                MsgBox("No se elimino el usuario")

            End If
        Else

            MsgBox("Debe rellenar todos los campos")

        End If




    End Sub
End Class