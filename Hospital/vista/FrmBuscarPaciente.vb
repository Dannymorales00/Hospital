Public Class FrmBuscarPaciente
    Private paciente As Paciente
    Private pacienteRetorno As New Paciente
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

    Public Property PacienteRetorno1 As Paciente
        Get
            Return pacienteRetorno
        End Get
        Set(value As Paciente)
            pacienteRetorno = value
        End Set
    End Property

    Sub cargarTabla()
        paciente = New Paciente()
        paciente.cedula = TextBox1.Text


        DataGridView1.DataSource = controladorPaciente.buscarPacientes(paciente)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        paciente = New Paciente()
        paciente.cedula = Val(TextBox1.Text)

        DataGridView1.DataSource = controladorPaciente.buscarPacientes(paciente)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        PacienteRetorno1.cedula = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        PacienteRetorno1.nombre = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        PacienteRetorno1.edad = CInt(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        PacienteRetorno1.correo = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        PacienteRetorno1.fechaNacimiento = CDate(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
        PacienteRetorno1.peso = CDbl(DataGridView1.Rows(e.RowIndex).Cells(5).Value)
        PacienteRetorno1.altura = CDbl(DataGridView1.Rows(e.RowIndex).Cells(6).Value)
        PacienteRetorno1.telefono = CInt(DataGridView1.Rows(e.RowIndex).Cells(7).Value)
        PacienteRetorno1.tipoSangre = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        labelPaciente.Text = PacienteRetorno1.nombre


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Visible = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        End If

    End Sub
End Class