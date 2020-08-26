<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteConsulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sp_reporte_ConsultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetConsulta = New Hospital.DataSetConsulta()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sp_reporte_ConsultasTableAdapter = New Hospital.DataSetConsultaTableAdapters.sp_reporte_ConsultasTableAdapter()
        CType(Me.sp_reporte_ConsultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_reporte_ConsultasBindingSource
        '
        Me.sp_reporte_ConsultasBindingSource.DataMember = "sp_reporte_Consultas"
        Me.sp_reporte_ConsultasBindingSource.DataSource = Me.DataSetConsulta
        '
        'DataSetConsulta
        '
        Me.DataSetConsulta.DataSetName = "DataSetConsulta"
        Me.DataSetConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetConsulta"
        ReportDataSource1.Value = Me.sp_reporte_ConsultasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.ReporteConsulta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1073, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'sp_reporte_ConsultasTableAdapter
        '
        Me.sp_reporte_ConsultasTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteConsulta"
        Me.Text = "FrmReporteConsulta"
        CType(Me.sp_reporte_ConsultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_reporte_ConsultasBindingSource As BindingSource
    Friend WithEvents DataSetConsulta As DataSetConsulta
    Friend WithEvents sp_reporte_ConsultasTableAdapter As DataSetConsultaTableAdapters.sp_reporte_ConsultasTableAdapter
End Class
