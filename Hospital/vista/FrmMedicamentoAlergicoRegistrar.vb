Imports System.ComponentModel

Public Class FrmMedicamentoAlergicoRegistrar

    Private medicamentos As Medicamentos
    Private verAlergico As MedicamentoAlergico
    Private _alergico As List(Of MedicamentoAlergico)
    Private controladorMedicamentos As New ControladorMedicamentos
    Private controladorAlergicos As New ControladorMedicamentoAlergico

    Property alergico As List(Of MedicamentoAlergico)
        Get
            Return _alergico
        End Get
        Set(value As List(Of MedicamentoAlergico))
            _alergico = value
        End Set
    End Property

    Private Sub FrmMedicamentoAlergicoRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMedicamentos()
        alergico = New List(Of MedicamentoAlergico)
    End Sub

    Public Sub CargarMedicamentos()

        medicamentos = New Medicamentos
        Dim data = controladorMedicamentos.buscarMedicamentos(medicamentos)

        For Each item In data
            clb_medicamentos.Items.Add(item.nombre)
        Next

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If comprobar() Then
            For Each item In clb_medicamentos.CheckedIndices
                alergico.Add(New MedicamentoAlergico(labelCedula.Text, item + 1))
            Next
            Me.Hide()
        End If
    End Sub

    Function comprobar() As Boolean
        If clb_medicamentos.CheckedIndices.Count > 0 Then Return True
        Return False
    End Function

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class