Public Class frmConsultaMedico
    Private _citas As Citas
    Private conConsulta As New ControladorConsulta
    Private consulta As New ConsultaMedica
    Private frmMedicamentosAdministrados As New FrmMedicamentoAdministrado
    Private frmMedicamentoRecetado As New FRMMedicamentoRecetado
    Property citas As Citas
        Get
            Return _citas
        End Get
        Set
            _citas = Value
        End Set
    End Property

    Private Sub frmConsultaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatoConsulta()

    End Sub


    Sub obtenerDatoConsulta()
        Dim datos = conConsulta.obtenerDatosConsulta(citas)
        consulta.altura = datos.altura
        consulta.descripcionSintomas = datos.descripcionSintomas
        consulta.presion = datos.presion
        consulta.peso = datos.peso
        consulta.id = datos.id

        txtAltura.Text = consulta.altura.ToString
        txtPeso.Text = consulta.peso.ToString
        txtDescripcionSintomas.Text = consulta.descripcionSintomas
        txtPresion.Text = consulta.presion.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If comprobarCampos() Then
            consulta.descripcionProceso = txtDescripcionProceso.Text
            consulta.sintomas = txtSintomas.Text
            If conConsulta.actualizarConsulta(consulta) Then
                MsgBox("Se ha registrado con exito")
            End If
        End If
    End Sub

    Function comprobarCampos() As Boolean
        If txtDescripcionProceso.Text <> "" And txtSintomas.Text <> "" Then
            Return True
        Else
            MsgBox("Rellene todos los campos")
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMedicamentosAdministrados.consultaMedica = consulta
        frmMedicamentosAdministrados.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmMedicamentoRecetado.consultaMedica = consulta
        frmMedicamentoRecetado.ShowDialog()
    End Sub
End Class