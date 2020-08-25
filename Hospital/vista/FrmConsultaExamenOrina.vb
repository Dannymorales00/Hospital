Public Class FrmConsultaExamenOrina

    Private examenOrina As ExamenOrina
    Dim listaExamenes As List(Of ExamenOrina)
    Public Property P_ListaExamenes As List(Of ExamenOrina)
        Get
            Return listaExamenes
        End Get
        Set(value As List(Of ExamenOrina))
            listaExamenes = value
        End Set
    End Property

    Sub New(consulta As ConsultaMedica)

        InitializeComponent()

        LblIdConsulta.Text = consulta.id
        LblIdCita.Text = consulta.idCitas

    End Sub
    Private Sub FrmConsultaExamenOrina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        examenOrina = New ExamenOrina()
        listaExamenes = New List(Of ExamenOrina)

    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If BtnRegistrar.Text = "Agregar" Then

            Agregar_Examen_Orina()

        Else
            Actualizar_la_Lista()

        End If

    End Sub


    Sub Agregar_Examen_Orina()

        If ValidarCampos() Then

            examenOrina = New ExamenOrina()
            examenOrina.IdConsulta = LblIdConsulta.Text
            examenOrina.color = TxtColor.Text
            examenOrina.eritrocitos = CDbl(TxtEritrocitos.Text)
            examenOrina.glucosa = CDbl(TxtGlucosa.Text)
            examenOrina.leucocitos = CDbl(TxtLeucocitos.Text)
            MsgBox("se agrego exitosamente")

            listaExamenes.Add(examenOrina)
            CargarTabla()
            Limpiar()

        Else
            MsgBox("Debe rellenar el campo Color, Eritrocitos, Glucosa y Leucocitos")
        End If

    End Sub


    Sub Actualizar_la_Lista()

        If labelIdExamenOrina.Visible Then
            If ValidarCampos() Then
                examenOrina = New ExamenOrina()
                examenOrina.IdConsulta = LblIdConsulta.Text
                examenOrina.color = TxtColor.Text
                examenOrina.eritrocitos = CDbl(TxtEritrocitos.Text)
                examenOrina.glucosa = CDbl(TxtGlucosa.Text)
                examenOrina.leucocitos = CDbl(TxtLeucocitos.Text)

                listaExamenes.RemoveAt(0)
                listaExamenes.Add(examenOrina)
                MsgBox("se actualizo exitosamente")
                CargarTabla()
                Limpiar()
            Else
                MsgBox("Debe rellenar el campo Color, Eritrocitos, Glucosa y Leucocitos")
            End If

        Else
            MsgBox("debe seleccionar el examen de orina para actualizar")

        End If

    End Sub

    Sub CargarTabla()

        TablaExamenes.DataSource = Nothing
        TablaExamenes.DataSource = listaExamenes

    End Sub

    Sub Limpiar()


        labelIdExamenOrina.Visible = False
        labelNumeroIdExamen.Visible = False
        TxtColor.Text = ""
        TxtEritrocitos.Text = ""
        TxtGlucosa.Text = ""
        TxtLeucocitos.Text = ""

        If listaExamenes.Count <= 0 Then
            BtnRegistrar.Text = "Agregar"
        Else
            BtnRegistrar.Text = "Actualizar"

        End If

    End Sub

    Function ValidarCampos() As Boolean

        Return Not TxtColor.Text.Equals("") And Not TxtEritrocitos.Text.Equals("") And Not TxtGlucosa.Text.Equals("") And Not TxtLeucocitos.Text.Equals("")

    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If labelIdExamenOrina.Visible Then
            listaExamenes.RemoveAt(0)
            CargarTabla()
            Limpiar()
        Else
            MsgBox("Primero debe seleccionar un examen para eliminarlo")
        End If

    End Sub

    Private Sub TablaExamnes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaExamenes.CellClick

        labelIdExamenOrina.Text = TablaExamenes.Item(0, TablaExamenes.CurrentRow.Index).Value
        TxtLeucocitos.Text = TablaExamenes.Item(2, TablaExamenes.CurrentRow.Index).Value
        TxtColor.Text = TablaExamenes.Item(3, TablaExamenes.CurrentRow.Index).Value
        TxtEritrocitos.Text = TablaExamenes.Item(4, TablaExamenes.CurrentRow.Index).Value
        TxtGlucosa.Text = TablaExamenes.Item(5, TablaExamenes.CurrentRow.Index).Value
        labelIdExamenOrina.Visible = True
        labelNumeroIdExamen.Visible = True
        BtnRegistrar.Text = "Actualizar"

    End Sub



End Class