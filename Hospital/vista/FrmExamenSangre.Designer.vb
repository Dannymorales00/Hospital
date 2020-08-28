<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExamenSangre
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTrigliceridos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtHemoglobina = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtHematocrito = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtColesterol = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCreatinina = New System.Windows.Forms.TextBox()
        Me.labelIdExamenSangre = New System.Windows.Forms.Label()
        Me.labelNumeroIdExamen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblIdConsulta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblIdCita = New System.Windows.Forms.Label()
        Me.TablaExamenes = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAcidoUrico = New System.Windows.Forms.TextBox()
        Me.BtnSeleccionarConsulta = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.TablaExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(56, 364)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 24)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Trigliceridos:"
        '
        'TxtTrigliceridos
        '
        Me.TxtTrigliceridos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTrigliceridos.Location = New System.Drawing.Point(247, 362)
        Me.TxtTrigliceridos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTrigliceridos.Name = "TxtTrigliceridos"
        Me.TxtTrigliceridos.Size = New System.Drawing.Size(273, 26)
        Me.TxtTrigliceridos.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(47, 467)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Hemoglobina:"
        '
        'TxtHemoglobina
        '
        Me.TxtHemoglobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHemoglobina.Location = New System.Drawing.Point(247, 465)
        Me.TxtHemoglobina.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtHemoglobina.Name = "TxtHemoglobina"
        Me.TxtHemoglobina.Size = New System.Drawing.Size(273, 26)
        Me.TxtHemoglobina.TabIndex = 137
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(53, 432)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 24)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Hematocrito:"
        '
        'TxtHematocrito
        '
        Me.TxtHematocrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHematocrito.Location = New System.Drawing.Point(247, 430)
        Me.TxtHematocrito.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtHematocrito.Name = "TxtHematocrito"
        Me.TxtHematocrito.Size = New System.Drawing.Size(273, 26)
        Me.TxtHematocrito.TabIndex = 135
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(75, 398)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 24)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Colesterol:"
        '
        'TxtColesterol
        '
        Me.TxtColesterol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColesterol.Location = New System.Drawing.Point(247, 396)
        Me.TxtColesterol.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtColesterol.Name = "TxtColesterol"
        Me.TxtColesterol.Size = New System.Drawing.Size(273, 26)
        Me.TxtColesterol.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(75, 292)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 24)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "Creatinina:"
        '
        'TxtCreatinina
        '
        Me.TxtCreatinina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatinina.Location = New System.Drawing.Point(247, 290)
        Me.TxtCreatinina.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCreatinina.Name = "TxtCreatinina"
        Me.TxtCreatinina.Size = New System.Drawing.Size(273, 26)
        Me.TxtCreatinina.TabIndex = 131
        '
        'labelIdExamenSangre
        '
        Me.labelIdExamenSangre.AutoSize = True
        Me.labelIdExamenSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIdExamenSangre.ForeColor = System.Drawing.Color.Black
        Me.labelIdExamenSangre.Location = New System.Drawing.Point(250, 262)
        Me.labelIdExamenSangre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIdExamenSangre.Name = "labelIdExamenSangre"
        Me.labelIdExamenSangre.Size = New System.Drawing.Size(34, 24)
        Me.labelIdExamenSangre.TabIndex = 129
        Me.labelIdExamenSangre.Text = "***"
        Me.labelIdExamenSangre.Visible = False
        '
        'labelNumeroIdExamen
        '
        Me.labelNumeroIdExamen.AutoSize = True
        Me.labelNumeroIdExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumeroIdExamen.ForeColor = System.Drawing.Color.Black
        Me.labelNumeroIdExamen.Location = New System.Drawing.Point(14, 262)
        Me.labelNumeroIdExamen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNumeroIdExamen.Name = "labelNumeroIdExamen"
        Me.labelNumeroIdExamen.Size = New System.Drawing.Size(216, 24)
        Me.labelNumeroIdExamen.TabIndex = 128
        Me.labelNumeroIdExamen.Text = "Id Examen de sangre:"
        Me.labelNumeroIdExamen.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(606, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 26)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Lista de examenes de sangre"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblIdConsulta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblIdCita)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(6, 90)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 132)
        Me.Panel1.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 26)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Datos de la consulta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
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
        Me.LblIdConsulta.ForeColor = System.Drawing.Color.Black
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
        Me.Label2.ForeColor = System.Drawing.Color.Black
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
        Me.LblIdCita.ForeColor = System.Drawing.Color.Black
        Me.LblIdCita.Location = New System.Drawing.Point(224, 86)
        Me.LblIdCita.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIdCita.Name = "LblIdCita"
        Me.LblIdCita.Size = New System.Drawing.Size(34, 24)
        Me.LblIdCita.TabIndex = 76
        Me.LblIdCita.Text = "***"
        '
        'TablaExamenes
        '
        Me.TablaExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaExamenes.Location = New System.Drawing.Point(606, 69)
        Me.TablaExamenes.Margin = New System.Windows.Forms.Padding(4)
        Me.TablaExamenes.Name = "TablaExamenes"
        Me.TablaExamenes.ReadOnly = True
        Me.TablaExamenes.RowHeadersWidth = 51
        Me.TablaExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaExamenes.Size = New System.Drawing.Size(677, 422)
        Me.TablaExamenes.TabIndex = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(65, 326)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 24)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Acido urico:"
        '
        'TxtAcidoUrico
        '
        Me.TxtAcidoUrico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcidoUrico.Location = New System.Drawing.Point(247, 324)
        Me.TxtAcidoUrico.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAcidoUrico.Name = "TxtAcidoUrico"
        Me.TxtAcidoUrico.Size = New System.Drawing.Size(273, 26)
        Me.TxtAcidoUrico.TabIndex = 124
        '
        'BtnSeleccionarConsulta
        '
        Me.BtnSeleccionarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionarConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionarConsulta.ForeColor = System.Drawing.Color.Black
        Me.BtnSeleccionarConsulta.Location = New System.Drawing.Point(295, 52)
        Me.BtnSeleccionarConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSeleccionarConsulta.Name = "BtnSeleccionarConsulta"
        Me.BtnSeleccionarConsulta.Size = New System.Drawing.Size(275, 30)
        Me.BtnSeleccionarConsulta.TabIndex = 140
        Me.BtnSeleccionarConsulta.Text = "Seleccionar Consulta"
        Me.BtnSeleccionarConsulta.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(925, 499)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(113, 30)
        Me.BtnEliminar.TabIndex = 143
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Location = New System.Drawing.Point(767, 499)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(113, 30)
        Me.BtnLimpiar.TabIndex = 142
        Me.BtnLimpiar.Text = "Limpiar "
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.Black
        Me.BtnRegistrar.Location = New System.Drawing.Point(606, 499)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(113, 30)
        Me.BtnRegistrar.TabIndex = 141
        Me.BtnRegistrar.Text = "Agregar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 30)
        Me.MenuStrip1.TabIndex = 144
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'FrmExamenSangre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnSeleccionarConsulta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTrigliceridos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtHemoglobina)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtHematocrito)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtColesterol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCreatinina)
        Me.Controls.Add(Me.labelIdExamenSangre)
        Me.Controls.Add(Me.labelNumeroIdExamen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TablaExamenes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtAcidoUrico)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmExamenSangre"
        Me.Text = "FrmExamenSangre"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TablaExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTrigliceridos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtHemoglobina As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtHematocrito As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtColesterol As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCreatinina As TextBox
    Friend WithEvents labelIdExamenSangre As Label
    Friend WithEvents labelNumeroIdExamen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblIdConsulta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblIdCita As Label
    Friend WithEvents TablaExamenes As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAcidoUrico As TextBox
    Friend WithEvents BtnSeleccionarConsulta As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
