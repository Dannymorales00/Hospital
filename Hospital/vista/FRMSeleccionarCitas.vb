Public Class FRMSeleccionarCitas
    Private conCitas As New ControladorCita
    Private cita As Citas
    Private Sub FRMSeleccionarCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()

    End Sub

    Sub cargarTabla()
        DataGridView1.DataSource = conCitas.buscarCitasHoy()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cita = New Citas
        cita.id = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        cita.especialidadSolicitada = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cita.fechaHora = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        cita.paciente.cedula = CInt(DataGridView1.Rows(e.RowIndex).Cells(3).Value)
        cita.medico.cedula = CInt(DataGridView1.Rows(e.RowIndex).Cells(4).Value)

        lblCedula.Text = cita.paciente.cedula.ToString
        lblFecha.Text = cita.fechaHora.ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblCedula.Text <> "Seleccionar" Then
            Dim frmConsulta As New FRMConsulta
            frmConsulta.cita = cita
            frmConsulta.ShowDialog()
            cargarTabla()
            lblCedula.Text = "Seleccionar"
            lblFecha.Text = "Seleccionar"
        Else
            MsgBox("Selecciona una cita")
        End If


    End Sub


End Class