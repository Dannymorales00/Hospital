Public Class FrmUsuario
    Private usuario As Usuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.usuario = New Usuario()

        AjustesVentanas()
        MostrarAgregar()

    End Sub



    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Using almacen = New ProyectoEntities1()




        End Using


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
End Class