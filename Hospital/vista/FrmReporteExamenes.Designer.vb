<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteExamenes
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetExamenOrina = New Hospital.DataSetExamenOrina()
        Me.sp_reporte_ExamenOrinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_reporte_ExamenOrinaTableAdapter = New Hospital.DataSetExamenOrinaTableAdapters.sp_reporte_ExamenOrinaTableAdapter()
        Me.DataSetExamenSangre = New Hospital.DataSetExamenSangre()
        Me.sp_reporte_ExamenSangreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_reporte_ExamenSangreTableAdapter = New Hospital.DataSetExamenSangreTableAdapters.sp_reporte_ExamenSangreTableAdapter()
        CType(Me.DataSetExamenOrina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_reporte_ExamenOrinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetExamenSangre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_reporte_ExamenSangreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetExamenOrina1"
        ReportDataSource1.Value = Me.sp_reporte_ExamenOrinaBindingSource
        ReportDataSource2.Name = "DataSetExamenSangre1"
        ReportDataSource2.Value = Me.sp_reporte_ExamenSangreBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hospital.ReporteExamenes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1218, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetExamenOrina
        '
        Me.DataSetExamenOrina.DataSetName = "DataSetExamenOrina"
        Me.DataSetExamenOrina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_reporte_ExamenOrinaBindingSource
        '
        Me.sp_reporte_ExamenOrinaBindingSource.DataMember = "sp_reporte_ExamenOrina"
        Me.sp_reporte_ExamenOrinaBindingSource.DataSource = Me.DataSetExamenOrina
        '
        'sp_reporte_ExamenOrinaTableAdapter
        '
        Me.sp_reporte_ExamenOrinaTableAdapter.ClearBeforeFill = True
        '
        'DataSetExamenSangre
        '
        Me.DataSetExamenSangre.DataSetName = "DataSetExamenSangre"
        Me.DataSetExamenSangre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_reporte_ExamenSangreBindingSource
        '
        Me.sp_reporte_ExamenSangreBindingSource.DataMember = "sp_reporte_ExamenSangre"
        Me.sp_reporte_ExamenSangreBindingSource.DataSource = Me.DataSetExamenSangre
        '
        'sp_reporte_ExamenSangreTableAdapter
        '
        Me.sp_reporte_ExamenSangreTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteExamenes"
        Me.Text = "FrmReporteExamenes"
        CType(Me.DataSetExamenOrina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_reporte_ExamenOrinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetExamenSangre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_reporte_ExamenSangreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_reporte_ExamenOrinaBindingSource As BindingSource
    Friend WithEvents DataSetExamenOrina As DataSetExamenOrina
    Friend WithEvents sp_reporte_ExamenSangreBindingSource As BindingSource
    Friend WithEvents DataSetExamenSangre As DataSetExamenSangre
    Friend WithEvents sp_reporte_ExamenOrinaTableAdapter As DataSetExamenOrinaTableAdapters.sp_reporte_ExamenOrinaTableAdapter
    Friend WithEvents sp_reporte_ExamenSangreTableAdapter As DataSetExamenSangreTableAdapters.sp_reporte_ExamenSangreTableAdapter
End Class
