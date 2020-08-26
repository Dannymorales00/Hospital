Public Class FrmReporteExamenes

    Private fechaInicio As Date
    Private fechaFin As Date
    Private cedula As Integer

    Public Sub New(fechaInicio As Date, fechaFin As Date, cedula As Integer)
        InitializeComponent()
        Me.fechaInicio = fechaInicio
        Me.fechaFin = fechaFin
        Me.cedula = cedula
    End Sub

    Private Sub FrmReporteExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetExamenOrina.sp_reporte_ExamenOrina' Puede moverla o quitarla según sea necesario.
        Me.sp_reporte_ExamenOrinaTableAdapter.Fill(Me.DataSetExamenOrina.sp_reporte_ExamenOrina, fechaInicio, fechaFin, cedula)
        'TODO: esta línea de código carga datos en la tabla 'DataSetExamenSangre.sp_reporte_ExamenSangre' Puede moverla o quitarla según sea necesario.
        Me.sp_reporte_ExamenSangreTableAdapter.Fill(Me.DataSetExamenSangre.sp_reporte_ExamenSangre, fechaInicio, fechaFin, cedula)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class