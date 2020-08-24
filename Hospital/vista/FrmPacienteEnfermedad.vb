Public Class FrmPacienteEnfermedad
    Private listaEnfermedades As List(Of Enfermedad)
    Private enfermedad As Enfermedad
    Private controladorEnfermedad As New ControladorEnfermedad
    Private cont As Integer

    Public Property P_ListaEnfermedades As List(Of Enfermedad)
        Get
            Return listaEnfermedades
        End Get
        Set(value As List(Of Enfermedad))
            listaEnfermedades = value
        End Set
    End Property

    Sub New(paciente As Paciente)

        InitializeComponent()

        LblCedula.Text = paciente.cedula
        LblNombre.Text = paciente.nombre


    End Sub
    Private Sub FrmPacienteEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        enfermedad = New Enfermedad()
        listaEnfermedades = New List(Of Enfermedad)
        controladorEnfermedad = New ControladorEnfermedad()
        cont = 0

    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click



        If ValidarCampos() Then
            enfermedad = New Enfermedad()
            enfermedad.cedulaPaciente = LblCedula.Text
            enfermedad.nombre = TxtEnfermedad.Text
            enfermedad.descripcion = TxtDescripcion.Text




            If BtnRegistrar.Text.Equals("Agregar") Then
                    Agregar_a_la_Lista()

                Else
                    Actualizar_la_Lista()

                End If



            Else
            MsgBox("Debe rellenar el campo enfermedad y descripcion")
        End If








    End Sub


    Sub Agregar_a_la_Lista()


        MsgBox("se agrego exitosamente")
        cont += 1
        enfermedad.id = cont
        listaEnfermedades.Add(enfermedad)
        CargarTabla()
        Limpiar()

    End Sub


    Sub Actualizar_la_Lista()


        If labelId.Visible Then


            If ValidarCampos() Then

                enfermedad = New Enfermedad()
                enfermedad.id = CInt(labelId.Text)
                Dim indice As Integer = controladorEnfermedad.BuscarIndice(listaEnfermedades, enfermedad)
                If indice >= 0 Then
                    listaEnfermedades.ElementAt(indice).descripcion = TxtDescripcion.Text
                    listaEnfermedades.ElementAt(indice).nombre = TxtEnfermedad.Text

                    CargarTabla()
                    MsgBox("Se actualizo correctamente")
                    Limpiar()

                Else
                    MsgBox("No se logro actualizar")
                End If

            Else
                MsgBox("Primero debe seleccionar una enfermedad")
            End If



        End If


    End Sub

    Sub CargarTabla()

        TablaEnfermedades.DataSource = Nothing
        TablaEnfermedades.DataSource = listaEnfermedades



    End Sub

    Sub Limpiar()


        labelId.Visible = False
        labelNumeroId.Visible = False
        TxtDescripcion.Text = ""
        TxtEnfermedad.Text = ""
        BtnRegistrar.Text = "Agregar"




    End Sub



    Function ValidarCampos() As Boolean

        Return Not TxtDescripcion.Text.Equals("") And Not TxtEnfermedad.Text.Equals("")

    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        If labelId.Visible Then


            enfermedad = New Enfermedad()
            enfermedad.id = CInt(labelId.Text)
            Dim indice As Integer = controladorEnfermedad.BuscarIndice(listaEnfermedades, enfermedad)
            If indice >= 0 Then
                listaEnfermedades.RemoveAt(indice)
                CargarTabla()
                MsgBox("eliminado")
                Limpiar()

            Else
                MsgBox("No se logro eliminar")
            End If







        Else
            MsgBox("Primero debe seleccionar una enfermedad")
        End If





    End Sub

    Private Sub TablaEnfermedades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaEnfermedades.CellClick


        LblCedula.Text = TablaEnfermedades.Item(0, TablaEnfermedades.CurrentRow.Index).Value
        TxtDescripcion.Text = TablaEnfermedades.Item(1, TablaEnfermedades.CurrentRow.Index).Value
        TxtEnfermedad.Text = TablaEnfermedades.Item(2, TablaEnfermedades.CurrentRow.Index).Value
        labelId.Text = TablaEnfermedades.Item(3, TablaEnfermedades.CurrentRow.Index).Value
        labelId.Visible = True
        labelNumeroId.Visible = True
        BtnRegistrar.Text = "Actualizar"





    End Sub




End Class