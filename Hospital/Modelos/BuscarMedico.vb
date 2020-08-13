Public Class BuscarMedico
    Private medico As Medico
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim listaMedicos As New List(Of Medico)
        medico = New Medico()

        If Not (TxtCedula.Text.Equals("")) Then

            medico.cedula = Val(TxtCedula.Text)



            listaMedicos = controladorMedico.Buscar(medico)


            'DataGridViewMedicos.DataSource = listaMedicos








        End If







    End Sub
End Class