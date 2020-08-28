<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCita
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.BtnMedico = New System.Windows.Forms.Button()
        Me.TxtRegistrarEspecialidad = New System.Windows.Forms.TextBox()
        Me.LblMedico = New System.Windows.Forms.Label()
        Me.LblPaciente = New System.Windows.Forms.Label()
        Me.DataGridCitas = New System.Windows.Forms.DataGridView()
        Me.TxtCedulaP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeHora = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.DataGridCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnRegistrar.Location = New System.Drawing.Point(462, 355)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(140, 36)
        Me.BtnRegistrar.TabIndex = 0
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(37, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(68, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(78, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Médico"
        '
        'BtnPaciente
        '
        Me.BtnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPaciente.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnPaciente.Location = New System.Drawing.Point(154, 219)
        Me.BtnPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Size = New System.Drawing.Size(252, 31)
        Me.BtnPaciente.TabIndex = 4
        Me.BtnPaciente.Text = "Seleccionar Paciente"
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'BtnMedico
        '
        Me.BtnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedico.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnMedico.Location = New System.Drawing.Point(154, 287)
        Me.BtnMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMedico.Name = "BtnMedico"
        Me.BtnMedico.Size = New System.Drawing.Size(252, 32)
        Me.BtnMedico.TabIndex = 5
        Me.BtnMedico.Text = "Seleccionar Médico"
        Me.BtnMedico.UseVisualStyleBackColor = True
        '
        'TxtRegistrarEspecialidad
        '
        Me.TxtRegistrarEspecialidad.Location = New System.Drawing.Point(152, 46)
        Me.TxtRegistrarEspecialidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtRegistrarEspecialidad.MaxLength = 40
        Me.TxtRegistrarEspecialidad.Name = "TxtRegistrarEspecialidad"
        Me.TxtRegistrarEspecialidad.Size = New System.Drawing.Size(254, 22)
        Me.TxtRegistrarEspecialidad.TabIndex = 6
        '
        'LblMedico
        '
        Me.LblMedico.AutoSize = True
        Me.LblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedico.ForeColor = System.Drawing.Color.AliceBlue
        Me.LblMedico.Location = New System.Drawing.Point(207, 322)
        Me.LblMedico.Name = "LblMedico"
        Me.LblMedico.Size = New System.Drawing.Size(159, 16)
        Me.LblMedico.TabIndex = 7
        Me.LblMedico.Text = "Medico Seleccionado"
        '
        'LblPaciente
        '
        Me.LblPaciente.AutoSize = True
        Me.LblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaciente.ForeColor = System.Drawing.Color.AliceBlue
        Me.LblPaciente.Location = New System.Drawing.Point(199, 252)
        Me.LblPaciente.Name = "LblPaciente"
        Me.LblPaciente.Size = New System.Drawing.Size(167, 16)
        Me.LblPaciente.TabIndex = 8
        Me.LblPaciente.Text = "Paciente seleccionado"
        '
        'DataGridCitas
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridCitas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridCitas.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCitas.Location = New System.Drawing.Point(459, 70)
        Me.DataGridCitas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridCitas.Name = "DataGridCitas"
        Me.DataGridCitas.ReadOnly = True
        Me.DataGridCitas.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridCitas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridCitas.RowTemplate.Height = 24
        Me.DataGridCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCitas.Size = New System.Drawing.Size(561, 268)
        Me.DataGridCitas.TabIndex = 9
        '
        'TxtCedulaP
        '
        Me.TxtCedulaP.Location = New System.Drawing.Point(628, 38)
        Me.TxtCedulaP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCedulaP.MaxLength = 20
        Me.TxtCedulaP.Name = "TxtCedulaP"
        Me.TxtCedulaP.Size = New System.Drawing.Size(160, 22)
        Me.TxtCedulaP.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(86, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha"
        '
        'DateTimeHora
        '
        Me.DateTimeHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimeHora.Location = New System.Drawing.Point(152, 169)
        Me.DateTimeHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimeHora.Name = "DateTimeHora"
        Me.DateTimeHora.ShowUpDown = True
        Me.DateTimeHora.Size = New System.Drawing.Size(136, 21)
        Me.DateTimeHora.TabIndex = 12
        Me.DateTimeHora.Value = New Date(2020, 8, 17, 7, 30, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(95, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hora"
        '
        'DateTimeFecha
        '
        Me.DateTimeFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFecha.Location = New System.Drawing.Point(152, 103)
        Me.DateTimeFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimeFecha.MinDate = New Date(2020, 8, 26, 0, 0, 0, 0)
        Me.DateTimeFecha.Name = "DateTimeFecha"
        Me.DateTimeFecha.Size = New System.Drawing.Size(152, 21)
        Me.DateTimeFecha.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(456, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cedula Paciente"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnLimpiar.Location = New System.Drawing.Point(628, 355)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(140, 36)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnEliminar.Location = New System.Drawing.Point(796, 355)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(140, 36)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(825, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ID:"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(866, 38)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 15)
        Me.LblID.TabIndex = 19
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnCerrar.Location = New System.Drawing.Point(953, 2)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(81, 27)
        Me.BtnCerrar.TabIndex = 20
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1036, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimeFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimeHora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCedulaP)
        Me.Controls.Add(Me.DataGridCitas)
        Me.Controls.Add(Me.LblPaciente)
        Me.Controls.Add(Me.LblMedico)
        Me.Controls.Add(Me.TxtRegistrarEspecialidad)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnMedico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPaciente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.AliceBlue
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmCita"
        Me.ShowIcon = False
        Me.Text = "FrmCita"
        CType(Me.DataGridCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnPaciente As Button
    Friend WithEvents BtnMedico As Button
    Friend WithEvents TxtRegistrarEspecialidad As TextBox
    Friend WithEvents LblMedico As Label
    Friend WithEvents LblPaciente As Label
    Friend WithEvents DataGridCitas As DataGridView
    Friend WithEvents TxtCedulaP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeHora As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimeFecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents BtnCerrar As Button
End Class
