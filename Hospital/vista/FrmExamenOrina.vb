Public Class FrmExamenOrina

    Private examenOrina As ExamenOrina
    Private controladorExamenOrina As ControladorExamenOrina
    Private consulta As New ConsultaMedica

    Private Sub FrmEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        examenOrina = New ExamenOrina()
        controladorExamenOrina = New ControladorExamenOrina()
        consulta = New ConsultaMedica()

    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If Not LblIdConsulta.Text.Equals("***") Then

            If ValidarCampos() Then
                examenOrina.IdConsulta = CInt(LblIdConsulta.Text)
                examenOrina.color = TxtColor.Text
                examenOrina.eritrocitos = CDbl(TxtEritrocitos.Text)
                examenOrina.glucosa = CDbl(TxtGlucosa.Text)
                examenOrina.leucocitos = CDbl(TxtLeucocitos.Text)

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


    Sub Registrar()

        If controladorExamenOrina.Registrar(examenOrina) = 1 Then
            MsgBox("se registro exitosamente")
            CargarTabla(examenOrina)
            Limpiar()

        Else
            MsgBox("Ya existe un examen para esa consulta")
        End If

    End Sub


    Sub Actualizar()

        examenOrina.id = CInt(lblIdExamenOrina.Text)
        If controladorExamenOrina.Actualizar(examenOrina) = 1 Then
            MsgBox("se actualizo exitosamente")
            CargarTabla(examenOrina)
            Limpiar()

        Else
            MsgBox("no se logro actualizar")
        End If


    End Sub



    Sub CargarTabla(examenOrina As ExamenOrina)

        Dim listaExamenOrina = New List(Of ExamenOrina)
        listaExamenOrina = controladorExamenOrina.Buscar(examenOrina)
        TablaExamenes.DataSource = listaExamenOrina


    End Sub
    Private Sub BtnSeleccionarConsulta_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarConsulta.Click
        Dim frmBuscarConsulta As New FrmBuscarConsulta()
        Limpiar()
        frmBuscarConsulta.ShowDialog()


        consulta = frmBuscarConsulta.P_Consulta
        frmBuscarConsulta.Close()
        If consulta IsNot Nothing Then

            LblIdConsulta.Text = consulta.id
            LblIdCita.Text = consulta.idCitas

            Dim examenOrina As New ExamenOrina()
            examenOrina.IdConsulta = LblIdConsulta.Text
            CargarTabla(examenOrina)

        Else

        End If




    End Sub


    Sub Limpiar()


        TxtColor.Text = ""
        TxtEritrocitos.Text = ""
        TxtLeucocitos.Text = ""
        TxtGlucosa.Text = ""
        LblIdConsulta.Text = "***"
        LblIdCita.Text = "***"
        lblIdExamenOrina.Text = "***"
        BtnRegistrar.Text = "Registrar"
        lblIdExamenOrina.Visible = False
        labelNumeroIdExamen.Visible = False
        TablaExamenes.DataSource = Nothing

    End Sub



    Function ValidarCampos() As Boolean

        Return Not TxtColor.Text.Equals("") And Not TxtEritrocitos.Text.Equals("") And Not TxtGlucosa.Text.Equals("") And Not TxtLeucocitos.Text.Equals("")

    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        If Not LblIdConsulta.Text.Equals("***") Then


            examenOrina = New ExamenOrina()
            examenOrina.IdConsulta = CInt(LblIdConsulta.Text)


            If controladorExamenOrina.Eliminar(examenOrina) = 1 Then
                MsgBox("se elimino Correctamente")
                Limpiar()

            Else
                MsgBox("no se logro eliminar")

            End If


        Else
            MsgBox("Primero debe seleccionar una consulta para eliminar un examen")
        End If





    End Sub

    Private Sub TablaExamenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaExamenes.CellClick


        lblIdExamenOrina.Text = TablaExamenes.Item(0, TablaExamenes.CurrentRow.Index).Value
        LblIdConsulta.Text = TablaExamenes.Item(1, TablaExamenes.CurrentRow.Index).Value
        TxtLeucocitos.Text = TablaExamenes.Item(2, TablaExamenes.CurrentRow.Index).Value
        TxtColor.Text = TablaExamenes.Item(3, TablaExamenes.CurrentRow.Index).Value
        TxtEritrocitos.Text = TablaExamenes.Item(4, TablaExamenes.CurrentRow.Index).Value
        TxtGlucosa.Text = TablaExamenes.Item(5, TablaExamenes.CurrentRow.Index).Value

        labelNumeroIdExamen.Visible = True
        lblIdExamenOrina.Visible = True
        BtnRegistrar.Text = "Actualizar"





    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class