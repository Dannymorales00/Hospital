<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExamenOrina
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtLeucocitos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtGlucosa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEritrocitos = New System.Windows.Forms.TextBox()
        Me.lblIdExamenOrina = New System.Windows.Forms.Label()
        Me.labelNumeroIdExamen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblIdConsulta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblIdCita = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TablaExamenes = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.BtnSeleccionarConsulta = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.TablaExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(85, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Leucocitos:"
        '
        'TxtLeucocitos
        '
        Me.TxtLeucocitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLeucocitos.Location = New System.Drawing.Point(185, 336)
        Me.TxtLeucocitos.Name = "TxtLeucocitos"
        Me.TxtLeucocitos.Size = New System.Drawing.Size(206, 22)
        Me.TxtLeucocitos.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(103, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Glucosa:"
        '
        'TxtGlucosa
        '
        Me.TxtGlucosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGlucosa.Location = New System.Drawing.Point(185, 308)
        Me.TxtGlucosa.Name = "TxtGlucosa"
        Me.TxtGlucosa.Size = New System.Drawing.Size(206, 22)
        Me.TxtGlucosa.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(87, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Eritrocitos:"
        '
        'TxtEritrocitos
        '
        Me.TxtEritrocitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEritrocitos.Location = New System.Drawing.Point(185, 280)
        Me.TxtEritrocitos.Name = "TxtEritrocitos"
        Me.TxtEritrocitos.Size = New System.Drawing.Size(206, 22)
        Me.TxtEritrocitos.TabIndex = 114
        '
        'lblIdExamenOrina
        '
        Me.lblIdExamenOrina.AutoSize = True
        Me.lblIdExamenOrina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdExamenOrina.ForeColor = System.Drawing.Color.Black
        Me.lblIdExamenOrina.Location = New System.Drawing.Point(187, 218)
        Me.lblIdExamenOrina.Name = "lblIdExamenOrina"
        Me.lblIdExamenOrina.Size = New System.Drawing.Size(29, 18)
        Me.lblIdExamenOrina.TabIndex = 112
        Me.lblIdExamenOrina.Text = "***"
        Me.lblIdExamenOrina.Visible = False
        '
        'labelNumeroIdExamen
        '
        Me.labelNumeroIdExamen.AutoSize = True
        Me.labelNumeroIdExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumeroIdExamen.ForeColor = System.Drawing.Color.Black
        Me.labelNumeroIdExamen.Location = New System.Drawing.Point(24, 218)
        Me.labelNumeroIdExamen.Name = "labelNumeroIdExamen"
        Me.labelNumeroIdExamen.Size = New System.Drawing.Size(157, 18)
        Me.labelNumeroIdExamen.TabIndex = 111
        Me.labelNumeroIdExamen.Text = "Id Examen de orina:"
        Me.labelNumeroIdExamen.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(486, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 20)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Lista de examenes de orina"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblIdConsulta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblIdCita)
        Me.Panel1.Location = New System.Drawing.Point(12, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 107)
        Me.Panel1.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 20)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Datos de la consulta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Id Consulta:"
        '
        'LblIdConsulta
        '
        Me.LblIdConsulta.AutoSize = True
        Me.LblIdConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdConsulta.ForeColor = System.Drawing.Color.Black
        Me.LblIdConsulta.Location = New System.Drawing.Point(168, 43)
        Me.LblIdConsulta.Name = "LblIdConsulta"
        Me.LblIdConsulta.Size = New System.Drawing.Size(29, 18)
        Me.LblIdConsulta.TabIndex = 79
        Me.LblIdConsulta.Text = "***"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(92, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Id Cita:"
        '
        'LblIdCita
        '
        Me.LblIdCita.AutoSize = True
        Me.LblIdCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdCita.ForeColor = System.Drawing.Color.Black
        Me.LblIdCita.Location = New System.Drawing.Point(168, 70)
        Me.LblIdCita.Name = "LblIdCita"
        Me.LblIdCita.Size = New System.Drawing.Size(29, 18)
        Me.LblIdCita.TabIndex = 76
        Me.LblIdCita.Text = "***"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(320, 406)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 24)
        Me.BtnEliminar.TabIndex = 108
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TablaExamenes
        '
        Me.TablaExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaExamenes.Location = New System.Drawing.Point(486, 55)
        Me.TablaExamenes.Name = "TablaExamenes"
        Me.TablaExamenes.ReadOnly = True
        Me.TablaExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaExamenes.Size = New System.Drawing.Size(508, 352)
        Me.TablaExamenes.TabIndex = 107
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(202, 406)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(85, 24)
        Me.BtnLimpiar.TabIndex = 106
        Me.BtnLimpiar.Text = "Limpiar "
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(124, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Color:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(81, 406)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(85, 24)
        Me.BtnRegistrar.TabIndex = 105
        Me.BtnRegistrar.Text = "Agregar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TxtColor
        '
        Me.TxtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(185, 252)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(206, 22)
        Me.TxtColor.TabIndex = 104
        '
        'BtnSeleccionarConsulta
        '
        Me.BtnSeleccionarConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionarConsulta.Location = New System.Drawing.Point(185, 54)
        Me.BtnSeleccionarConsulta.Name = "BtnSeleccionarConsulta"
        Me.BtnSeleccionarConsulta.Size = New System.Drawing.Size(206, 24)
        Me.BtnSeleccionarConsulta.TabIndex = 119
        Me.BtnSeleccionarConsulta.Text = "Seleccionar Consulta"
        Me.BtnSeleccionarConsulta.UseVisualStyleBackColor = True
        '
        'FrmExamenOrina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 465)
        Me.Controls.Add(Me.BtnSeleccionarConsulta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtLeucocitos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtGlucosa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtEritrocitos)
        Me.Controls.Add(Me.lblIdExamenOrina)
        Me.Controls.Add(Me.labelNumeroIdExamen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TablaExamenes)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.TxtColor)
        Me.Name = "FrmExamenOrina"
        Me.Text = "FrmExamenOrina"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TablaExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents TxtLeucocitos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtGlucosa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEritrocitos As TextBox
    Friend WithEvents lblIdExamenOrina As Label
    Friend WithEvents labelNumeroIdExamen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblIdConsulta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblIdCita As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TablaExamenes As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents BtnSeleccionarConsulta As Button
End Class
