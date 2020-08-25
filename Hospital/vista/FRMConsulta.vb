Public Class FRMConsulta
    Private _cita As Citas
    Dim paciente As Paciente
    Dim consulta As ConsultaMedica
    Dim conPaciente As New ControladorPaciente
    Dim conConsulta As New ControladorConsulta

    Public Property cita As Citas
        Get
            Return _cita
        End Get
        Set(value As Citas)
            _cita = value
        End Set
    End Property

    Private Sub FRMConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = cita.id.ToString
        lblCedula.Text = cita.paciente.cedula.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        paciente = New Paciente
        consulta = New ConsultaMedica

        paciente.altura = CDbl(txtAltura.Text)
        paciente.peso = CDbl(txtPeso.Text)
        paciente.cedula = cita.paciente.cedula

        consulta.idCitas = cita.id
        consulta.peso = paciente.peso
        consulta.altura = paciente.altura
        consulta.presion = CDbl(txtPresion.Text)
        consulta.sintomas = txtSintomas.Text
        conPaciente.actualizarPesoAltura(paciente)

        If conConsulta.registrarEnfermera(consulta) Then
            MsgBox("Registro completado")
        End If
        Me.Close()

    End Sub

    Private Sub TxtPresion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPresion.KeyPress

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(44) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(44) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAltura.KeyPress

        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(44) Then
            e.Handled = True
        End If
    End Sub

End Class