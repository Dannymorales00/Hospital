Imports System.ComponentModel

Public Class FrmMedicamentoAlergicoRegistrar

    Private medicamentos As Medicamentos
    Private alergico As New MedicamentoAlergico
    Private controladorMedicamentos As New ControladorMedicamentos
    Private controladorAlergicos As New ControladorMedicamentoAlergico
    Private paciente As New Paciente

    Public Sub New(paciente As Paciente)
        InitializeComponent()
        Me.paciente = paciente
    End Sub


    Private Sub FrmMedicamentoAlergicoRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        For Each item In clb_medicamentos.CheckedIndices
            alergico = New MedicamentoAlergico(paciente.cedula, item + 1)
            If controladorAlergicos.registrar(alergico) = True Then
                MsgBox("Medicamentos Alergicos agregados...")
            End If
        Next

    End Sub

    Public Sub verificar()
        Dim data = clb_medicamentos.CheckedIndices
        'Terminar Restricción por medicamento repetido
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        For Each item In clb_medicamentos.CheckedIndices
            Console.WriteLine(item)
        Next
        Me.Close()
    End Sub

End Class