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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtRegistrarEspecialidad = New System.Windows.Forms.TextBox()
        Me.BtnMedico = New System.Windows.Forms.Button()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LlbMedico = New System.Windows.Forms.Label()
        Me.LblPaciente = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(636, 354)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblPaciente)
        Me.TabPage1.Controls.Add(Me.LlbMedico)
        Me.TabPage1.Controls.Add(Me.TxtRegistrarEspecialidad)
        Me.TabPage1.Controls.Add(Me.BtnMedico)
        Me.TabPage1.Controls.Add(Me.BtnPaciente)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BtnRegistrar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(628, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtRegistrarEspecialidad
        '
        Me.TxtRegistrarEspecialidad.Location = New System.Drawing.Point(149, 31)
        Me.TxtRegistrarEspecialidad.Name = "TxtRegistrarEspecialidad"
        Me.TxtRegistrarEspecialidad.Size = New System.Drawing.Size(227, 24)
        Me.TxtRegistrarEspecialidad.TabIndex = 6
        '
        'BtnMedico
        '
        Me.BtnMedico.Location = New System.Drawing.Point(149, 92)
        Me.BtnMedico.Name = "BtnMedico"
        Me.BtnMedico.Size = New System.Drawing.Size(224, 32)
        Me.BtnMedico.TabIndex = 5
        Me.BtnMedico.Text = "Seleccionar Médico"
        Me.BtnMedico.UseVisualStyleBackColor = True
        '
        'BtnPaciente
        '
        Me.BtnPaciente.Location = New System.Drawing.Point(149, 165)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Size = New System.Drawing.Size(224, 31)
        Me.BtnPaciente.TabIndex = 4
        Me.BtnPaciente.Text = "Seleccionar Paciente"
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Médico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Especialidad"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(28, 245)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(124, 46)
        Me.BtnRegistrar.TabIndex = 0
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(459, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Eliminar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(459, 323)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Actualizar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(459, 323)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Buscar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LlbMedico
        '
        Me.LlbMedico.AutoSize = True
        Me.LlbMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbMedico.Location = New System.Drawing.Point(388, 97)
        Me.LlbMedico.Name = "LlbMedico"
        Me.LlbMedico.Size = New System.Drawing.Size(187, 20)
        Me.LlbMedico.TabIndex = 7
        Me.LlbMedico.Text = "Medico Seleccionado"
        '
        'LblPaciente
        '
        Me.LblPaciente.AutoSize = True
        Me.LblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaciente.Location = New System.Drawing.Point(388, 171)
        Me.LblPaciente.Name = "LblPaciente"
        Me.LblPaciente.Size = New System.Drawing.Size(198, 20)
        Me.LblPaciente.TabIndex = 8
        Me.LblPaciente.Text = "Paciente seleccionado"
        '
        'FrmCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 353)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmCita"
        Me.Text = "FrmCita"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TxtRegistrarEspecialidad As TextBox
    Friend WithEvents BtnMedico As Button
    Friend WithEvents BtnPaciente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents LblPaciente As Label
    Friend WithEvents LlbMedico As Label
End Class
