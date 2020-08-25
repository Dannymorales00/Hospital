Public Class FrmConsultaExamenSangre

    Private exameSangre As ExamenSangre
    Dim listaExamenes As List(Of ExamenSangre)

    Public Property P_ListaExamenes As List(Of ExamenSangre)
        Get
            Return listaExamenes
        End Get
        Set(value As List(Of ExamenSangre))
            listaExamenes = value
        End Set
    End Property

    Sub New(consulta As ConsultaMedica)

        InitializeComponent()

        LblIdConsulta.Text = consulta.id
        LblIdCita.Text = consulta.idCitas

    End Sub
    Private Sub FrmConsultaExamenOrina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        exameSangre = New ExamenSangre()
        listaExamenes = New List(Of ExamenSangre)

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

            exameSangre = New ExamenSangre()
            exameSangre.idConsulta = CInt(LblIdConsulta.Text)
            exameSangre.acidoUrico = CDbl(TxtAcidoUrico.Text)
            exameSangre.colesterol = CDbl(TxtColesterol.Text)
            exameSangre.creatinina = CDbl(TxtCreatinina.Text)
            exameSangre.hematocrito = CDbl(TxtHematocrito.Text)
            exameSangre.hemoglobina = CDbl(TxtHemoglobina.Text)
            exameSangre.trigliceridos = CDbl(TxtTrigliceridos.Text)
            MsgBox("se agrego exitosamente")

            listaExamenes.Add(exameSangre)
            CargarTabla()
            Limpiar()

        Else
            MsgBox("Debe rellenar todos los campos")
        End If

    End Sub


    Sub Actualizar_la_Lista()

        If labelIdExamenSangre.Visible Then
            If ValidarCampos() Then
                exameSangre = New ExamenSangre()
                exameSangre.idConsulta = CInt(LblIdConsulta.Text)
                exameSangre.acidoUrico = CDbl(TxtAcidoUrico.Text)
                exameSangre.colesterol = CDbl(TxtColesterol.Text)
                exameSangre.creatinina = CDbl(TxtCreatinina.Text)
                exameSangre.hematocrito = CDbl(TxtHematocrito.Text)
                exameSangre.hemoglobina = CDbl(TxtHemoglobina.Text)
                exameSangre.trigliceridos = CDbl(TxtTrigliceridos.Text)
                listaExamenes.RemoveAt(0)
                listaExamenes.Add(exameSangre)
                MsgBox("se actualizo exitosamente")
                CargarTabla()
                Limpiar()
            Else
                MsgBox("Debe rellenar todos los campos")
            End If

        Else
            MsgBox("debe seleccionar el examen de sangre para actualizar")

        End If

    End Sub

    Sub CargarTabla()

        TablaExamenes.DataSource = Nothing
        TablaExamenes.DataSource = listaExamenes

    End Sub

    Sub Limpiar()

        labelIdExamenSangre.Visible = False
        labelNumeroIdExamen.Visible = False
        TxtAcidoUrico.Text = ""
        TxtColesterol.Text = ""
        TxtCreatinina.Text = ""
        TxtHematocrito.Text = ""
        TxtHemoglobina.Text = ""
        TxtTrigliceridos.Text = ""

        If listaExamenes.Count <= 0 Then
            BtnRegistrar.Text = "Agregar"
        Else
            BtnRegistrar.Text = "Actualizar"

        End If

    End Sub

    Function ValidarCampos() As Boolean

        Return Not TxtAcidoUrico.Text.Equals("") And Not TxtColesterol.Text.Equals("") And Not TxtCreatinina.Text.Equals("") And Not TxtHematocrito.Text.Equals("") And Not TxtHemoglobina.Text.Equals("") And Not TxtTrigliceridos.Text.Equals("")

    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If labelIdExamenSangre.Visible Then
            listaExamenes.RemoveAt(0)
            CargarTabla()
            Limpiar()
        Else
            MsgBox("Primero debe seleccionar un examen para eliminarlo")
        End If

    End Sub

    Private Sub TablaExamnes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaExamenes.CellClick

        labelIdExamenSangre.Text = TablaExamenes.Item(0, TablaExamenes.CurrentRow.Index).Value
        TxtCreatinina.Text = TablaExamenes.Item(2, TablaExamenes.CurrentRow.Index).Value
        TxtAcidoUrico.Text = TablaExamenes.Item(3, TablaExamenes.CurrentRow.Index).Value
        TxtColesterol.Text = TablaExamenes.Item(4, TablaExamenes.CurrentRow.Index).Value
        TxtTrigliceridos.Text = TablaExamenes.Item(5, TablaExamenes.CurrentRow.Index).Value
        TxtHematocrito.Text = TablaExamenes.Item(6, TablaExamenes.CurrentRow.Index).Value
        TxtHemoglobina.Text = TablaExamenes.Item(7, TablaExamenes.CurrentRow.Index).Value
        labelIdExamenSangre.Visible = True
        labelNumeroIdExamen.Visible = True
        BtnRegistrar.Text = "Actualizar"

    End Sub

End Class