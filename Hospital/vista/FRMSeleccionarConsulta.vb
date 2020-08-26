Public Class FRMSeleccionarConsulta
    Dim conConsulta As New ControladorConsulta
    Dim consulta As ConsultaMedica
    Dim citas As New Citas
    Dim medico As Medico
    Dim conUsuario As New ControladorUsuario
    Private _usuario As Usuario
    Property usuario As Usuario
        Get
            Return _usuario
        End Get
        Set
            _usuario = Value
        End Set
    End Property

    Private Sub FRMSeleccionarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMedico.Text = conUsuario.obtenerCedulaMedico(usuario).cedula.ToString
        cargarTabla()
    End Sub

    Sub cargarTabla()
        medico = New Medico
        medico.cedula = CInt(lblMedico.Text)
        DataGridView1.DataSource = conConsulta.buscarConsultasHoy(medico)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        lblCedula.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        citas.id = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblCedula.Text = "Seleccionar" Then
            MsgBox("Seleccione una consulta primero")
        Else
            Dim frmConsulta As New FRMConsultaMedico
            frmConsulta.citas = citas
            frmConsulta.ShowDialog()
            cargarTabla()
        End If
    End Sub
End Class