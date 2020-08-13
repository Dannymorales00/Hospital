Public Class BuscarMedico
    Private medico As Medico
    Private medicoSeleccionado As Medico
    Private controladorMedico As ControladorMedico

    Public Property P_Medico As Medico
        Get
            Return medico
        End Get
        Set(value As Medico)
            medico = value
        End Set
    End Property

    Private Sub BuscarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        medico = New Medico()

        controladorMedico = New ControladorMedico()




    End Sub
    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged
        Dim listaMedicos As New List(Of Medico)
        medico = New Medico()

        If Not (TxtCedula.Text.Equals("")) Then
            medico.cedula = Val(TxtCedula.Text)
            listaMedicos = controladorMedico.Buscar(medico)
            DataGridViewMedicos.DataSource = listaMedicos
        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click


        If DataGridViewMedicos.SelectedRows.Count > 0 Then
            medico = medicoSeleccionado
            'NumeroDeFilaSeleccionada = DataGridViewMedicos.CurrentRow.Index

        Else
            MessageBox.Show("debe seleccionar una fila")
        End If


    End Sub


    Private Sub DataGridViewMedicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicos.CellClick
        medicoSeleccionado = New Medico()
        medicoSeleccionado.cedula = DataGridViewMedicos.Item(0, DataGridViewMedicos.CurrentRow.Index).Value
        medicoSeleccionado.nombre = DataGridViewMedicos.Item(1, DataGridViewMedicos.CurrentRow.Index).Value




    End Sub
End Class