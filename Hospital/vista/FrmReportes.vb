Public Class FrmReportes
    Private FrmReporteConsulta As FrmReporteConsulta
    Private FrmReporteExamenes As FrmReporteExamenes


    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        FrmReporteConsulta = New FrmReporteConsulta(DateTimeInicio.Value, DateTimeFin.Value, Val(TxtCedula.Text))
        FrmReporteConsulta.WindowState = FormWindowState.Maximized
        FrmReporteConsulta.ShowDialog()
    End Sub

    Private Sub BtnExamenes_Click(sender As Object, e As EventArgs) Handles BtnExamenes.Click
        FrmReporteExamenes = New FrmReporteExamenes(DateTimeInicio.Value, DateTimeFin.Value, Val(TxtCedula.Text))
        FrmReporteExamenes.WindowState = FormWindowState.Maximized
        FrmReporteExamenes.ShowDialog()
    End Sub
End Class