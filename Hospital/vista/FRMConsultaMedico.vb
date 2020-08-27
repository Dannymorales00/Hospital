Public Class FRMConsultaMedico
    Private _cita As Citas
    Dim controladorConsulta As New ControladorConsulta
    Dim consulta As New ConsultaMedica
    Property citas As Citas
        Get
            Return _cita
        End Get
        Set
            _cita = Value
        End Set
    End Property

    Private Sub FRMConsultaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()
    End Sub

    Sub llenarDatos()
        Dim result = controladorConsulta.obtenerDatosConsulta(citas)

        consulta.id = result.id
        consulta.altura = result.altura
        consulta.descripcionSintomas = result.descripcionSintomas
        consulta.peso = result.peso
        consulta.presion = result.presion

        txtAltura.Text = consulta.altura.ToString
        txtDescripcionSintomas.Text = consulta.descripcionSintomas
        txtPeso.Text = consulta.peso.ToString
        txtPresion.Text = consulta.presion.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If comprobarCampos() Then
            consulta.sintomas = txtSintomasMostrados.Text
            consulta.descripcionProceso = txtDescripcionProceso.Text
            If controladorConsulta.actualizarConsulta(consulta) Then
                MsgBox("Consulta Registrada con Exito")
                Me.Close()

            Else
                MsgBox("Error al registrar la Consulta")
            End If
        Else
            MsgBox("Rellene todos los campos")

        End If

    End Sub

    Function comprobarCampos() As Boolean
        If txtSintomasMostrados.Text <> "" And txtDescripcionProceso.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class