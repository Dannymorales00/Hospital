Public Class BuscarPaciente
    Private paciente As Paciente
    Public pacienteRetorno As New Paciente
    Private controladorPaciente As New ControladorPaciente
    Private Sub BuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()
    End Sub

    Public Property Paciente1 As Paciente
        Get
            Return paciente
        End Get
        Set(value As Paciente)
            paciente = value
        End Set
    End Property

    Sub cargarTabla()
        paciente = New Paciente()
        paciente.cedula = Val(TextBox1.Text)

        DataGridView1.DataSource = controladorPaciente.buscarPacientes(paciente)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        paciente = New Paciente()
        paciente.cedula = Val(TextBox1.Text)

        DataGridView1.DataSource = controladorPaciente.buscarPacientes(paciente)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        pacienteRetorno.cedula = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        pacienteRetorno.nombre = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        pacienteRetorno.edad = CInt(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        pacienteRetorno.correo = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        pacienteRetorno.fechaNacimiento = CDate(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
        pacienteRetorno.peso = CDbl(DataGridView1.Rows(e.RowIndex).Cells(5).Value)
        pacienteRetorno.altura = CDbl(DataGridView1.Rows(e.RowIndex).Cells(6).Value)
        pacienteRetorno.telefono = CInt(DataGridView1.Rows(e.RowIndex).Cells(7).Value)
        pacienteRetorno.tipoSangre = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        labelPaciente.Text = pacienteRetorno.nombre


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub


End Class