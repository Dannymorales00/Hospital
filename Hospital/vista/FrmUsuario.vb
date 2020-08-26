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

        If ComprobarAgregar() Then

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
                LimpiarAgregar()

            Else
                MsgBox("No se agrego el usuario")

            End If
        Else

            MsgBox("Debe rellenar todos los campos")

        End If


    End Sub


    Function ComprobarAgregar() As Boolean

        Return Not (TxtNombre.Text.Equals("") AndAlso TxtCedula.Text.Equals("") AndAlso TxtContraseña.Text.Equals("") AndAlso TxtCorreo.Text.Equals("") AndAlso TxtTelefono.Text.Equals("") AndAlso TxtNombreUsuario.Text.Equals("") AndAlso CBTipo.SelectedIndex < 0)

    End Function

    Function ComprobarActualizar() As Boolean

        Return Not (TxtNombreActualizar.Text.Equals("") AndAlso TxtCedulaActualizar.Text.Equals("") AndAlso TxtContraseñaActualizar.Text.Equals("") AndAlso TxtCorreoActualizar.Text.Equals("") AndAlso TxtTelefonoActualizar.Text.Equals("") AndAlso TxtNombreUsuarioActualizar.Text.Equals("") AndAlso CBTipoActualizar.SelectedIndex < 0)

    End Function

    Private Sub LimpiarAgregar()
        TxtNombre.Text = ""
        TxtNombreUsuario.Text = ""
        TxtCedula.Text = ""
        TxtContraseña.Text = ""
        TxtCorreo.Text = ""
        TxtTelefono.Text = ""
        CBTipo.SelectedIndex = -1
        DateTimePickerAgregar = New DateTimePicker()

    End Sub

    Private Sub LimpiarActualizar()
        TxtNombreActualizar.Text = ""
        TxtNombreUsuarioActualizar.Text = ""
        TxtCedulaActualizar.Text = ""
        TxtContraseñaActualizar.Text = ""
        TxtCorreoActualizar.Text = ""
        TxtTelefonoActualizar.Text = ""
        CBTipoActualizar.SelectedIndex = -1
        DateTimePickerActualizar = New DateTimePicker()

    End Sub

    Private Sub LimpiarEliminar()
        TxtCedulaEliminar.Text = ""

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
                LimpiarEliminar()

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

            usuario = controladorUsuario.Buscar(usuario)
            If Not (usuario.tipo = Nothing) Then

                TxtNombreActualizar.Text = usuario.nombre
                TxtNombreUsuarioActualizar.Text = usuario.nombreUsuario
                TxtCedulaActualizar.Text = usuario.cedula
                TxtContraseñaActualizar.Text = usuario.contrasena
                TxtCorreoActualizar.Text = usuario.correo
                TxtTelefonoActualizar.Text = usuario.telefono
                CBTipoActualizar.SelectedItem = usuario.tipo.Trim
                DateTimePickerActualizar.Value = usuario.fechaNacimiento




            Else
                MsgBox("No se cargo los datos del usuario")

            End If
        Else

            MsgBox("Debe rellenar el campo cedula para cargar un usuario")

        End If




    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        If ComprobarActualizar() Then

            Me.usuario = New Usuario()
            usuario.cedula = Val(TxtCedulaActualizar.Text)
            usuario.nombre = TxtNombreActualizar.Text
            usuario.nombreUsuario = TxtNombreUsuarioActualizar.Text
            usuario.telefono = Val(TxtTelefonoActualizar.Text)
            usuario.contrasena = TxtContraseñaActualizar.Text
            usuario.correo = TxtCorreoActualizar.Text
            usuario.tipo = CBTipoActualizar.SelectedItem.ToString
            usuario.fechaNacimiento = DateTimePickerActualizar.Value

            If controladorUsuario.Actualizar(usuario) = 1 Then
                MsgBox("se actualizó correctamente el usuario")
                LimpiarActualizar()

            Else
                MsgBox("No se actualizo el usuario")

            End If
        Else

            MsgBox("no puede dejar campos vacios")

        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim ListaUsuario As New List(Of Usuario)
        If Not TxtCedulaBuscar.Text.Equals("") Then
            usuario = New Usuario()
            usuario.cedula = CInt(TxtCedulaBuscar.Text)
            Dim usuario1 = controladorUsuario.Buscar(usuario)
            If usuario1 IsNot Nothing Then
                ListaUsuario.Add(usuario1)
                DataGridView1.DataSource = ListaUsuario

            End If


        End If

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub TxtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCedula.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCedulaEliminar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCedulaEliminar.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCedulaBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCedulaBuscar.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefonoActualizar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefonoActualizar.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub
End Class