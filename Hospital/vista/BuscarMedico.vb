Public Class BuscarMedico
    Private medicoSeleccionado As Medico
    Private medico As Medico
    Private controladorMedico As ControladorMedico

    Public Property P_Medico As Medico
        Get
            Return medicoSeleccionado
        End Get
        Set(value As Medico)
            medicoSeleccionado = value
        End Set
    End Property

    Private Sub BuscarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        medicoSeleccionado = Nothing
        medico = New Medico()
        controladorMedico = New ControladorMedico()




    End Sub
    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged
        Dim listaMedicos As New List(Of Medico)
        medico = New Medico()

        If Not (TxtCedula.Text.Equals("")) Then
            medico.cedula = CInt(TxtCedula.Text)
            listaMedicos = controladorMedico.Buscar(medico)
            DataGridViewMedicos.DataSource = listaMedicos
        End If
    End Sub

    Private Sub TxtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCedula.KeyPress

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If
    End Sub


    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click


        If DataGridViewMedicos.SelectedRows.Count > 0 And DataGridViewMedicos.SelectedRows.Count < 2 Then
            medicoSeleccionado = New Medico()
            medicoSeleccionado = medico
            'NumeroDeFilaSeleccionada = DataGridViewMedicos.CurrentRow.Index
            Me.Hide()
        Else
            MessageBox.Show("debe seleccionar una fila")
        End If



    End Sub


    Private Sub DataGridViewMedicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicos.CellClick
        medico = New Medico()
        medico.cedula = DataGridViewMedicos.Item(0, DataGridViewMedicos.CurrentRow.Index).Value
        medico.nombre = DataGridViewMedicos.Item(1, DataGridViewMedicos.CurrentRow.Index).Value




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class