Public Class FrmReporteConsulta

    Private fechaInicio As Date
    Private fechaFin As Date
    Private cedula As Integer

    Public Sub New(fechaInicio As Date, fechaFin As Date, cedula As Integer)
        InitializeComponent()
        Me.fechaInicio = fechaInicio
        Me.fechaFin = fechaFin
        Me.cedula = cedula
    End Sub
    Private Sub FrmReporteConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetConsulta.sp_reporte_Consultas' Puede moverla o quitarla según sea necesario.
        Me.sp_reporte_ConsultasTableAdapter.Fill(Me.DataSetConsulta.sp_reporte_Consultas, fechaInicio, fechaFin, cedula)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class