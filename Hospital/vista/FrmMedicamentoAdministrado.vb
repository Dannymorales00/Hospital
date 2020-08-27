Public Class FrmMedicamentoAdministrado

    Private medicamentos As Medicamentos
    Private administrado As New MedicamentoAdministrado
    Private controladorMedicamentos As New ControladorMedicamentos
    Private controladorAdministrado As New ControladorMedicamentoAdministrado
    Private _consultaMedica As ConsultaMedica

    Property consultaMedica As ConsultaMedica
        Get
            Return _consultaMedica
        End Get
        Set
            _consultaMedica = Value
        End Set
    End Property


    Private Sub FrmMedicamentoAdministrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMedicamentos()
    End Sub

    Public Sub CargarMedicamentos()

        medicamentos = New Medicamentos

        Dim data = controladorMedicamentos.buscarMedicamentos(medicamentos)

        For Each item In data
            clb_medicamentos.Items.Add(item.nombre)
        Next

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim cont As Integer
        cont = 0
        For Each item In clb_medicamentos.CheckedIndices
            administrado = New MedicamentoAdministrado(consultaMedica.id, item + 1)
            If controladorAdministrado.registrar(administrado) = True Then
                cont = cont + 1
            End If
        Next
        MsgBox("Se han agregado: " + cont.ToString + " Medicamentos con Exito")
    End Sub

    Public Sub verificar()
        Dim data = clb_medicamentos.CheckedIndices

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        For Each item In clb_medicamentos.CheckedIndices
            Console.WriteLine(item)
        Next
        Me.Close()
    End Sub
End Class