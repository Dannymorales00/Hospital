Public Class FrmEnfermedad
    Private enfermedad As Enfermedad

    Private controladorEnfermedad As New ControladorEnfermedad
    Private paciente As New Paciente

    Private Sub FrmEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enfermedad = New Enfermedad()

        controladorEnfermedad = New ControladorEnfermedad()
        paciente = New Paciente()

    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If Not LabelNombre.Text.Equals("***") Then

            If ValidarCampos() Then
                enfermedad = New Enfermedad()
                enfermedad.cedulaPaciente = TxtCedula.Text
                enfermedad.nombre = TxtEnfermedad.Text
                enfermedad.descripcion = TxtDescripcion.Text

                If BtnRegistrar.Text.Equals("Registrar") Then
                    Registrar()

                Else
                    Actualizar()

                End If



            Else
                MsgBox("Debe rellenar el campo cedula,enfermedad y descripcion")
            End If



        Else
            MsgBox("Primero debe seleccionar un paciente")
        End If




    End Sub


    Sub Registrar()

        If controladorEnfermedad.Registrar(enfermedad) = 1 Then
            MsgBox("se registro exitosamente")
            CargarTabla(enfermedad)
            Limpiar()

        Else
            MsgBox("no se logro registrar")
        End If

    End Sub


    Sub Actualizar()

        enfermedad.id = CInt(labelId.Text)
        If controladorEnfermedad.Actualizar(enfermedad) = 1 Then
            MsgBox("se actualizo exitosamente")
            CargarTabla(enfermedad)
            Limpiar()

        Else
            MsgBox("no se logro actualizar")
        End If


    End Sub



    Sub CargarTabla(enfermedad As Enfermedad)

        Dim listaEnfermedad = New List(Of Enfermedad)
        listaEnfermedad = controladorEnfermedad.Buscar(enfermedad)
        TablaEnfermedades.DataSource = listaEnfermedad


    End Sub

    Private Sub cedulaBuscarTxt_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCedula.TextChanged

        If Not TxtBuscarCedula.Text.Equals("") Then




        End If



    End Sub

    Private Sub BtnSeleccionarPaciente_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarPaciente.Click
        Dim frmPaciente As New FrmBuscarPaciente()
        Limpiar()
        frmPaciente.ShowDialog()

        paciente = frmPaciente.PacienteRetorno1
        frmPaciente.Close()

        If paciente.cedula IsNot Nothing Then

            LabelNombre.Text = paciente.nombre
            TxtCedula.Text = paciente.cedula.ToString
            TxtBuscarCedula.Text = paciente.cedula.ToString
            Dim enfermedad2 As New Enfermedad()
            enfermedad2.cedulaPaciente = TxtBuscarCedula.Text
            CargarTabla(enfermedad2)

        Else

        End If




    End Sub


    Sub Limpiar()

        TxtBuscarCedula.Text = ""
        TxtCedula.Text = ""
        TxtDescripcion.Text = ""
        TxtEnfermedad.Text = ""
        LabelNombre.Text = "***"
        BtnRegistrar.Text = "Registrar"
        labelNumeroId.Visible = False
        labelId.Visible = False
        labelId.Text = "***"



    End Sub



    Function ValidarCampos() As Boolean

        Return Not TxtDescripcion.Text.Equals("") And Not TxtEnfermedad.Text.Equals("")

    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
        TablaEnfermedades.DataSource = Nothing

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        If Not LabelNombre.Text.Equals("***") Then

            If ValidarCampos() Then
                enfermedad = New Enfermedad()
                enfermedad.cedulaPaciente = TxtCedula.Text
                enfermedad.nombre = TxtEnfermedad.Text
                enfermedad.descripcion = TxtDescripcion.Text

                If controladorEnfermedad.Eliminar(enfermedad) = 1 Then
                    MsgBox("se elimino Correctamente")
                    Limpiar()

                Else
                    MsgBox("no se logro eliminar")

                End If



            Else
                MsgBox("Debe rellenar el campo cedula,enfermedad y descripcion ó seleccionar una enfermedad")

            End If


        Else
            MsgBox("Primero debe seleccionar un paciente para eliminar una enfermedad")
        End If





    End Sub

    Private Sub TablaEnfermedades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaEnfermedades.CellClick


        TxtBuscarCedula.Text = TablaEnfermedades.Item(0, TablaEnfermedades.CurrentRow.Index).Value
        TxtDescripcion.Text = TablaEnfermedades.Item(1, TablaEnfermedades.CurrentRow.Index).Value
        TxtEnfermedad.Text = TablaEnfermedades.Item(2, TablaEnfermedades.CurrentRow.Index).Value
        labelId.Text = TablaEnfermedades.Item(3, TablaEnfermedades.CurrentRow.Index).Value
        labelNumeroId.Visible = True
        labelId.Visible = True
        BtnRegistrar.Text = "Actualizar"





    End Sub
End Class