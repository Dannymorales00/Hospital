<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnfermedad
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBuscarCedula = New System.Windows.Forms.TextBox()
        Me.TablaEnfermedades = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.BtnSeleccionarPaciente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.labelNumeroId = New System.Windows.Forms.Label()
        Me.labelId = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.TablaEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(378, 383)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 24)
        Me.BtnEliminar.TabIndex = 56
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(518, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Cedula:"
        '
        'TxtBuscarCedula
        '
        Me.TxtBuscarCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarCedula.Location = New System.Drawing.Point(589, 41)
        Me.TxtBuscarCedula.MaxLength = 10
        Me.TxtBuscarCedula.Name = "TxtBuscarCedula"
        Me.TxtBuscarCedula.Size = New System.Drawing.Size(158, 22)
        Me.TxtBuscarCedula.TabIndex = 55
        '
        'TablaEnfermedades
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.TablaEnfermedades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaEnfermedades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TablaEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaEnfermedades.DefaultCellStyle = DataGridViewCellStyle3
        Me.TablaEnfermedades.Location = New System.Drawing.Point(521, 69)
        Me.TablaEnfermedades.Name = "TablaEnfermedades"
        Me.TablaEnfermedades.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaEnfermedades.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.TablaEnfermedades.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.TablaEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaEnfermedades.Size = New System.Drawing.Size(508, 395)
        Me.TablaEnfermedades.TabIndex = 53
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(248, 383)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(85, 24)
        Me.BtnLimpiar.TabIndex = 52
        Me.BtnLimpiar.Text = "Limpiar "
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Cedula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Enfermedad:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(102, 383)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(85, 24)
        Me.BtnRegistrar.TabIndex = 47
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Descripcion:"
        '
        'TxtEnfermedad
        '
        Me.TxtEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedad.Location = New System.Drawing.Point(160, 209)
        Me.TxtEnfermedad.MaxLength = 20
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(206, 22)
        Me.TxtEnfermedad.TabIndex = 46
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(160, 164)
        Me.TxtCedula.MaxLength = 10
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(206, 22)
        Me.TxtCedula.TabIndex = 44
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(160, 249)
        Me.TxtDescripcion.MaxLength = 30
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(263, 96)
        Me.TxtDescripcion.TabIndex = 42
        Me.TxtDescripcion.Text = ""
        '
        'BtnSeleccionarPaciente
        '
        Me.BtnSeleccionarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionarPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarPaciente.Location = New System.Drawing.Point(173, 56)
        Me.BtnSeleccionarPaciente.Name = "BtnSeleccionarPaciente"
        Me.BtnSeleccionarPaciente.Size = New System.Drawing.Size(206, 24)
        Me.BtnSeleccionarPaciente.TabIndex = 57
        Me.BtnSeleccionarPaciente.Text = "Seleccionar Paciente"
        Me.BtnSeleccionarPaciente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nombre Paciente:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.White
        Me.LabelNombre.Location = New System.Drawing.Point(170, 108)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(29, 18)
        Me.LabelNombre.TabIndex = 59
        Me.LabelNombre.Text = "***"
        '
        'labelNumeroId
        '
        Me.labelNumeroId.AutoSize = True
        Me.labelNumeroId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumeroId.ForeColor = System.Drawing.Color.White
        Me.labelNumeroId.Location = New System.Drawing.Point(24, 136)
        Me.labelNumeroId.Name = "labelNumeroId"
        Me.labelNumeroId.Size = New System.Drawing.Size(130, 18)
        Me.labelNumeroId.TabIndex = 60
        Me.labelNumeroId.Text = "#Id Enfermedad:"
        Me.labelNumeroId.Visible = False
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.ForeColor = System.Drawing.Color.White
        Me.labelId.Location = New System.Drawing.Point(170, 136)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(29, 18)
        Me.labelId.TabIndex = 61
        Me.labelId.Text = "***"
        Me.labelId.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(1000, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(85, 24)
        Me.BtnCerrar.TabIndex = 62
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1086, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.labelId)
        Me.Controls.Add(Me.labelNumeroId)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSeleccionarPaciente)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtBuscarCedula)
        Me.Controls.Add(Me.TablaEnfermedades)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtEnfermedad)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEnfermedad"
        Me.ShowIcon = False
        Me.Text = "FrmEnfermedad"
        CType(Me.TablaEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBuscarCedula As TextBox
    Friend WithEvents TablaEnfermedades As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtEnfermedad As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtDescripcion As RichTextBox
    Friend WithEvents BtnSeleccionarPaciente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents labelNumeroId As Label
    Friend WithEvents labelId As Label
    Friend WithEvents BtnCerrar As Button
End Class
