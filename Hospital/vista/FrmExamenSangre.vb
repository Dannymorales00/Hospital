Public Class FrmExamenSangre
    Private examenSangre As ExamenSangre
    Private controladorExamenSangre As ControladorExamenSangre
    Private consulta As New ConsultaMedica
    Private Sub FrmExamenSangre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        examenSangre = New ExamenSangre()
        controladorExamenSangre = New ControladorExamenSangre()
        consulta = New ConsultaMedica()
    End Sub

    Sub CargarTabla(examenSangre As ExamenSangre)

        Dim listaExamenSangre = New List(Of ExamenSangre)
        listaExamenSangre = controladorExamenSangre.Buscar(examenSangre)
        TablaExamenes.DataSource = listaExamenSangre


    End Sub


    Function ValidarCampos() As Boolean

        Return Not TxtAcidoUrico.Text.Equals("") And Not TxtColesterol.Text.Equals("") And Not TxtCreatinina.Text.Equals("") And Not TxtHematocrito.Text.Equals("") And Not TxtHemoglobina.Text.Equals("") And Not TxtTrigliceridos.Text.Equals("")

    End Function
    Private Sub limpiar()
        TxtAcidoUrico.Text = ""
        TxtColesterol.Text = ""
        TxtCreatinina.Text = ""
        TxtHematocrito.Text = ""
        TxtHemoglobina.Text = ""
        TxtTrigliceridos.Text = ""
        BtnRegistrar.Text = "Registrar"
        labelIdExamenSangre.Visible = False
        labelNumeroIdExamen.Visible = False
        TablaExamenes.DataSource = Nothing
    End Sub

    Sub Registrar()

        If controladorExamenSangre.Registrar(examenSangre) = 1 Then
            MsgBox("se registro exitosamente")
            CargarTabla(examenSangre)
            limpiar()

        Else
            MsgBox("no se logro registrar")
        End If

    End Sub


    Sub Actualizar()

        examenSangre.id = CInt(labelIdExamenSangre.Text)
        If controladorExamenSangre.Actualizar(examenSangre) = 1 Then
            MsgBox("se actualizo exitosamente")
            CargarTabla(examenSangre)
            limpiar()

        Else
            MsgBox("no se logro actualizar")
        End If


    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If Not LblIdConsulta.Text.Equals("***") Then
            If ValidarCampos() Then
                examenSangre.idConsulta = CInt(LblIdConsulta.Text)
                examenSangre.acidoUrico = CDbl(TxtAcidoUrico.Text)
                examenSangre.colesterol = CDbl(TxtColesterol.Text)
                examenSangre.creatinina = CDbl(TxtCreatinina.Text)
                examenSangre.hematocrito = CDbl(TxtHematocrito.Text)
                examenSangre.hemoglobina = CDbl(TxtHemoglobina.Text)
                examenSangre.trigliceridos = CDbl(TxtTrigliceridos.Text)

                If BtnRegistrar.Text.Equals("Registrar") Then
                    Registrar()

                Else
                    Actualizar()

                End If
            Else
                MsgBox("Debe rellenar todos los campos")
            End If
        Else
            MsgBox("Primero debe seleccionar una consulta")
        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Not LblIdConsulta.Text.Equals("***") Then


            examenSangre = New ExamenSangre()
            examenSangre.idConsulta = CInt(LblIdConsulta.Text)


            If controladorExamenSangre.Eliminar(examenSangre) = 1 Then
                MsgBox("se elimino Correctamente")
                limpiar()

            Else
                MsgBox("no se logro eliminar")

            End If


        Else
            MsgBox("Primero debe seleccionar una consulta para eliminar un examen")
        End If
    End Sub

    Private Sub TablaExamenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaExamenes.CellClick
        labelIdExamenSangre.Text = TablaExamenes.Item(0, TablaExamenes.CurrentRow.Index).Value
        LblIdConsulta.Text = TablaExamenes.Item(1, TablaExamenes.CurrentRow.Index).Value
        TxtCreatinina.Text = TablaExamenes.Item(2, TablaExamenes.CurrentRow.Index).Value
        TxtAcidoUrico.Text = TablaExamenes.Item(3, TablaExamenes.CurrentRow.Index).Value
        TxtColesterol.Text = TablaExamenes.Item(4, TablaExamenes.CurrentRow.Index).Value
        TxtTrigliceridos.Text = TablaExamenes.Item(5, TablaExamenes.CurrentRow.Index).Value
        TxtHematocrito.Text = TablaExamenes.Item(6, TablaExamenes.CurrentRow.Index).Value
        TxtHemoglobina.Text = TablaExamenes.Item(7, TablaExamenes.CurrentRow.Index).Value

        labelNumeroIdExamen.Visible = True
        labelIdExamenSangre.Visible = True
        BtnRegistrar.Text = "Actualizar"
    End Sub

    Private Sub BtnSeleccionarConsulta_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarConsulta.Click
        Dim frmBuscarConsulta As New FrmBuscarConsulta()
        limpiar()
        frmBuscarConsulta.ShowDialog()


        consulta = frmBuscarConsulta.P_Consulta
        frmBuscarConsulta.Close()
        If consulta IsNot Nothing Then

            LblIdConsulta.Text = consulta.id
            LblIdCita.Text = consulta.idCitas

            Dim examenSangre As New ExamenSangre()
            examenSangre.idConsulta = LblIdConsulta.Text
            CargarTabla(examenSangre)

        Else

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class