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
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(113, 418)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 24)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Leucocitos:"
        '
        'TxtLeucocitos
        '
        Me.TxtLeucocitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLeucocitos.Location = New System.Drawing.Point(247, 414)
        Me.TxtLeucocitos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtLeucocitos.MaxLength = 10
        Me.TxtLeucocitos.Name = "TxtLeucocitos"
        Me.TxtLeucocitos.Size = New System.Drawing.Size(273, 26)
        Me.TxtLeucocitos.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(137, 384)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 24)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Glucosa:"
        '
        'TxtGlucosa
        '
        Me.TxtGlucosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGlucosa.Location = New System.Drawing.Point(247, 379)
        Me.TxtGlucosa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtGlucosa.MaxLength = 10
        Me.TxtGlucosa.Name = "TxtGlucosa"
        Me.TxtGlucosa.Size = New System.Drawing.Size(273, 26)
        Me.TxtGlucosa.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(116, 345)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 24)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Eritrocitos:"
        '
        'TxtEritrocitos
        '
        Me.TxtEritrocitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEritrocitos.Location = New System.Drawing.Point(247, 345)
        Me.TxtEritrocitos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEritrocitos.MaxLength = 10
        Me.TxtEritrocitos.Name = "TxtEritrocitos"
        Me.TxtEritrocitos.Size = New System.Drawing.Size(273, 26)
        Me.TxtEritrocitos.TabIndex = 114
        '
        'lblIdExamenOrina
        '
        Me.lblIdExamenOrina.AutoSize = True
        Me.lblIdExamenOrina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdExamenOrina.ForeColor = System.Drawing.Color.White
        Me.lblIdExamenOrina.Location = New System.Drawing.Point(249, 268)
        Me.lblIdExamenOrina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdExamenOrina.Name = "lblIdExamenOrina"
        Me.lblIdExamenOrina.Size = New System.Drawing.Size(34, 24)
        Me.lblIdExamenOrina.TabIndex = 112
        Me.lblIdExamenOrina.Text = "***"
        Me.lblIdExamenOrina.Visible = False
        '
        'labelNumeroIdExamen
        '
        Me.labelNumeroIdExamen.AutoSize = True
        Me.labelNumeroIdExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumeroIdExamen.ForeColor = System.Drawing.Color.White
        Me.labelNumeroIdExamen.Location = New System.Drawing.Point(32, 268)
        Me.labelNumeroIdExamen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNumeroIdExamen.Name = "labelNumeroIdExamen"
        Me.labelNumeroIdExamen.Size = New System.Drawing.Size(199, 24)
        Me.labelNumeroIdExamen.TabIndex = 111
        Me.labelNumeroIdExamen.Text = "Id Examen de orina:"
        Me.labelNumeroIdExamen.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(648, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 24)
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
        Me.Panel1.Location = New System.Drawing.Point(16, 103)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 132)
        Me.Panel1.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 24)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Datos de la consulta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Id Consulta:"
        '
        'LblIdConsulta
        '
        Me.LblIdConsulta.AutoSize = True
        Me.LblIdConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdConsulta.ForeColor = System.Drawing.Color.White
        Me.LblIdConsulta.Location = New System.Drawing.Point(224, 53)
        Me.LblIdConsulta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIdConsulta.Name = "LblIdConsulta"
        Me.LblIdConsulta.Size = New System.Drawing.Size(34, 24)
        Me.LblIdConsulta.TabIndex = 79
        Me.LblIdConsulta.Text = "***"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(123, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Id Cita:"
        '
        'LblIdCita
        '
        Me.LblIdCita.AutoSize = True
        Me.LblIdCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdCita.ForeColor = System.Drawing.Color.White
        Me.LblIdCita.Location = New System.Drawing.Point(224, 86)
        Me.LblIdCita.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIdCita.Name = "LblIdCita"
        Me.LblIdCita.Size = New System.Drawing.Size(34, 24)
        Me.LblIdCita.TabIndex = 76
        Me.LblIdCita.Text = "***"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(427, 500)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(113, 30)
        Me.BtnEliminar.TabIndex = 108
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TablaExamenes
        '
        Me.TablaExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaExamenes.Location = New System.Drawing.Point(648, 68)
        Me.TablaExamenes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TablaExamenes.Name = "TablaExamenes"
        Me.TablaExamenes.ReadOnly = True
        Me.TablaExamenes.RowHeadersWidth = 51
        Me.TablaExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaExamenes.Size = New System.Drawing.Size(677, 433)
        Me.TablaExamenes.TabIndex = 107
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(269, 500)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(113, 30)
        Me.BtnLimpiar.TabIndex = 106
        Me.BtnLimpiar.Text = "Limpiar "
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(165, 310)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Color:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(108, 500)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(113, 30)
        Me.BtnRegistrar.TabIndex = 105
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TxtColor
        '
        Me.TxtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColor.Location = New System.Drawing.Point(247, 310)
        Me.TxtColor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtColor.MaxLength = 10
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(273, 26)
        Me.TxtColor.TabIndex = 104
        '
        'BtnSeleccionarConsulta
        '
        Me.BtnSeleccionarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionarConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionarConsulta.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarConsulta.Location = New System.Drawing.Point(247, 66)
        Me.BtnSeleccionarConsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSeleccionarConsulta.Name = "BtnSeleccionarConsulta"
        Me.BtnSeleccionarConsulta.Size = New System.Drawing.Size(275, 30)
        Me.BtnSeleccionarConsulta.TabIndex = 119
        Me.BtnSeleccionarConsulta.Text = "Seleccionar Consulta"
        Me.BtnSeleccionarConsulta.UseVisualStyleBackColor = True
        '
        'FrmExamenOrina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1359, 572)
        Me.ControlBox = False
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
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmExamenOrina"
        Me.ShowIcon = False
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
