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
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.BtnMedico = New System.Windows.Forms.Button()
        Me.TxtRegistrarEspecialidad = New System.Windows.Forms.TextBox()
        Me.LblMedico = New System.Windows.Forms.Label()
        Me.LblPaciente = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerAgregar = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(31, 328)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(124, 46)
        Me.BtnRegistrar.TabIndex = 0
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Médico"
        '
        'BtnPaciente
        '
        Me.BtnPaciente.Location = New System.Drawing.Point(143, 196)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Size = New System.Drawing.Size(224, 31)
        Me.BtnPaciente.TabIndex = 4
        Me.BtnPaciente.Text = "Seleccionar Paciente"
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'BtnMedico
        '
        Me.BtnMedico.Location = New System.Drawing.Point(143, 264)
        Me.BtnMedico.Name = "BtnMedico"
        Me.BtnMedico.Size = New System.Drawing.Size(224, 32)
        Me.BtnMedico.TabIndex = 5
        Me.BtnMedico.Text = "Seleccionar Médico"
        Me.BtnMedico.UseVisualStyleBackColor = True
        '
        'TxtRegistrarEspecialidad
        '
        Me.TxtRegistrarEspecialidad.Location = New System.Drawing.Point(140, 22)
        Me.TxtRegistrarEspecialidad.Name = "TxtRegistrarEspecialidad"
        Me.TxtRegistrarEspecialidad.Size = New System.Drawing.Size(227, 22)
        Me.TxtRegistrarEspecialidad.TabIndex = 6
        '
        'LblMedico
        '
        Me.LblMedico.AutoSize = True
        Me.LblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedico.Location = New System.Drawing.Point(159, 299)
        Me.LblMedico.Name = "LblMedico"
        Me.LblMedico.Size = New System.Drawing.Size(187, 20)
        Me.LblMedico.TabIndex = 7
        Me.LblMedico.Text = "Medico Seleccionado"
        '
        'LblPaciente
        '
        Me.LblPaciente.AutoSize = True
        Me.LblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaciente.Location = New System.Drawing.Point(159, 230)
        Me.LblPaciente.Name = "LblPaciente"
        Me.LblPaciente.Size = New System.Drawing.Size(198, 20)
        Me.LblPaciente.TabIndex = 8
        Me.LblPaciente.Text = "Paciente seleccionado"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(440, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(614, 183)
        Me.DataGridView1.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(545, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 22)
        Me.TextBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(140, 145)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 24)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hora"
        '
        'DateTimePickerAgregar
        '
        Me.DateTimePickerAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerAgregar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerAgregar.Location = New System.Drawing.Point(140, 80)
        Me.DateTimePickerAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerAgregar.Name = "DateTimePickerAgregar"
        Me.DateTimePickerAgregar.Size = New System.Drawing.Size(136, 24)
        Me.DateTimePickerAgregar.TabIndex = 14
        '
        'FrmCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 386)
        Me.Controls.Add(Me.DateTimePickerAgregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblPaciente)
        Me.Controls.Add(Me.LblMedico)
        Me.Controls.Add(Me.TxtRegistrarEspecialidad)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnMedico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPaciente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmCita"
        Me.Text = "FrmCita"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerAgregar As DateTimePicker
End Class
