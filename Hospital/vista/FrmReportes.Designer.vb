﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.DateTimeInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFin = New System.Windows.Forms.DateTimePicker()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.BtnExamenes = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimeInicio
        '
        Me.DateTimeInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeInicio.Location = New System.Drawing.Point(146, 52)
        Me.DateTimeInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimeInicio.Name = "DateTimeInicio"
        Me.DateTimeInicio.Size = New System.Drawing.Size(151, 23)
        Me.DateTimeInicio.TabIndex = 0
        '
        'DateTimeFin
        '
        Me.DateTimeFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFin.Location = New System.Drawing.Point(146, 104)
        Me.DateTimeFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimeFin.Name = "DateTimeFin"
        Me.DateTimeFin.Size = New System.Drawing.Size(151, 23)
        Me.DateTimeFin.TabIndex = 1
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(146, 165)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCedula.MaxLength = 10
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(151, 21)
        Me.TxtCedula.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cedula Paciente"
        '
        'BtnConsulta
        '
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsulta.ForeColor = System.Drawing.Color.White
        Me.BtnConsulta.Location = New System.Drawing.Point(58, 205)
        Me.BtnConsulta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(106, 36)
        Me.BtnConsulta.TabIndex = 6
        Me.BtnConsulta.Text = "Reporte Consulta"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'BtnExamenes
        '
        Me.BtnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExamenes.ForeColor = System.Drawing.Color.White
        Me.BtnExamenes.Location = New System.Drawing.Point(199, 205)
        Me.BtnExamenes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnExamenes.Name = "BtnExamenes"
        Me.BtnExamenes.Size = New System.Drawing.Size(118, 36)
        Me.BtnExamenes.TabIndex = 7
        Me.BtnExamenes.Text = "Reporte Examenes"
        Me.BtnExamenes.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(321, 1)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(68, 21)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(390, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnExamenes)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.DateTimeFin)
        Me.Controls.Add(Me.DateTimeInicio)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmReportes"
        Me.Text = "FrmReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimeInicio As DateTimePicker
    Friend WithEvents DateTimeFin As DateTimePicker
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnConsulta As Button
    Friend WithEvents BtnExamenes As Button
    Friend WithEvents BtnCerrar As Button
End Class
