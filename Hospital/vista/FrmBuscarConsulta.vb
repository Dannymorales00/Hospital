Public Class FrmBuscarConsulta
    Private consulta As ConsultaMedica
    Private consultaSeleccionada As ConsultaMedica
    Private controladorConsulta As ControladorConsulta

    Public Property P_Consulta As ConsultaMedica
        Get
            Return consulta
        End Get
        Set(value As ConsultaMedica)
            consulta = value
        End Set
    End Property

    Private Sub FrmBuscarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = Nothing
        consultaSeleccionada = New ConsultaMedica()
        controladorConsulta = New ControladorConsulta()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim ListaConsultas As New List(Of ConsultaMedica)

        If Not TxtCedula.Text.Equals("") Then
            Dim cedula As Integer = CInt(TxtCedula.Text)
            ListaConsultas = controladorConsulta.buscar_por_cedula(cedula)
            TablaConsultas.DataSource = ListaConsultas

        Else
            MsgBox("debe ingresar una cedula para buscar")
        End If


    End Sub

    Private Sub TablaConsultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaConsultas.CellClick
        consultaSeleccionada = New ConsultaMedica()
        consultaSeleccionada.id = TablaConsultas.Item(0, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.idCitas = TablaConsultas.Item(1, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.descripcionSintomas = TablaConsultas.Item(2, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.descripcionProceso = TablaConsultas.Item(3, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.sintomas = TablaConsultas.Item(4, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.peso = TablaConsultas.Item(5, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.altura = TablaConsultas.Item(6, TablaConsultas.CurrentRow.Index).Value
        consultaSeleccionada.presion = TablaConsultas.Item(7, TablaConsultas.CurrentRow.Index).Value

    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        If TablaConsultas.SelectedRows.Count > 0 And TablaConsultas.SelectedRows.Count < 2 Then
            consulta = consultaSeleccionada
            'NumeroDeFilaSeleccionada = DataGridViewMedicos.CurrentRow.Index
            Me.Hide()

        Else
            MessageBox.Show("debe seleccionar una fila")

        End If



    End Sub
End Class