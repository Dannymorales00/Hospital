﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.TablaEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label9.ForeColor = System.Drawing.Color.Black
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
        Me.TxtBuscarCedula.Name = "TxtBuscarCedula"
        Me.TxtBuscarCedula.Size = New System.Drawing.Size(158, 22)
        Me.TxtBuscarCedula.TabIndex = 55
        '
        'TablaEnfermedades
        '
        Me.TablaEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaEnfermedades.Location = New System.Drawing.Point(521, 69)
        Me.TablaEnfermedades.Name = "TablaEnfermedades"
        Me.TablaEnfermedades.ReadOnly = True
        Me.TablaEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaEnfermedades.Size = New System.Drawing.Size(508, 395)
        Me.TablaEnfermedades.TabIndex = 53
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label1.ForeColor = System.Drawing.Color.Black
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
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Enfermedad:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label5.ForeColor = System.Drawing.Color.Black
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
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(206, 22)
        Me.TxtEnfermedad.TabIndex = 46
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(160, 164)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(206, 22)
        Me.TxtCedula.TabIndex = 44
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(160, 249)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(263, 96)
        Me.TxtDescripcion.TabIndex = 42
        Me.TxtDescripcion.Text = ""
        '
        'BtnSeleccionarPaciente
        '
        Me.BtnSeleccionarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label2.ForeColor = System.Drawing.Color.Black
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
        Me.LabelNombre.ForeColor = System.Drawing.Color.Black
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
        Me.labelNumeroId.ForeColor = System.Drawing.Color.Black
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
        Me.labelId.ForeColor = System.Drawing.Color.Black
        Me.labelId.Location = New System.Drawing.Point(170, 136)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(29, 18)
        Me.labelId.TabIndex = 61
        Me.labelId.Text = "***"
        Me.labelId.Visible = False
        '
        'FrmEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 497)
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
        Me.Name = "FrmEnfermedad"
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
End Class