<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaExamenSangre
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TablaExamenes = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.TxtAcidoUrico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtHemoglobina = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTrigliceridos = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.TablaExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(75, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Hematocrito:"
        '
        'TxtHematocrito
        '
        Me.TxtHematocrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHematocrito.Location = New System.Drawing.Point(190, 291)
        Me.TxtHematocrito.Name = "TxtHematocrito"
        Me.TxtHematocrito.Size = New System.Drawing.Size(206, 22)
        Me.TxtHematocrito.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(90, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 18)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Colesterol:"
        '
        'TxtColesterol
        '
        Me.TxtColesterol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColesterol.Location = New System.Drawing.Point(190, 263)
        Me.TxtColesterol.Name = "TxtColesterol"
        Me.TxtColesterol.Size = New System.Drawing.Size(206, 22)
        Me.TxtColesterol.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(92, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Creatinina:"
        '
        'TxtCreatinina
        '
        Me.TxtCreatinina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatinina.Location = New System.Drawing.Point(190, 235)
        Me.TxtCreatinina.Name = "TxtCreatinina"
        Me.TxtCreatinina.Size = New System.Drawing.Size(206, 22)
        Me.TxtCreatinina.TabIndex = 114
        '
        'labelIdExamenSangre
        '
        Me.labelIdExamenSangre.AutoSize = True
        Me.labelIdExamenSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIdExamenSangre.ForeColor = System.Drawing.Color.Black
        Me.labelIdExamenSangre.Location = New System.Drawing.Point(192, 173)
        Me.labelIdExamenSangre.Name = "labelIdExamenSangre"
        Me.labelIdExamenSangre.Size = New System.Drawing.Size(29, 18)
        Me.labelIdExamenSangre.TabIndex = 112
        Me.labelIdExamenSangre.Text = "***"
        Me.labelIdExamenSangre.Visible = False
        '
        'labelNumeroIdExamen
        '
        Me.labelNumeroIdExamen.AutoSize = True
        Me.labelNumeroIdExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumeroIdExamen.ForeColor = System.Drawing.Color.Black
        Me.labelNumeroIdExamen.Location = New System.Drawing.Point(15, 173)
        Me.labelNumeroIdExamen.Name = "labelNumeroIdExamen"
        Me.labelNumeroIdExamen.Size = New System.Drawing.Size(170, 18)
        Me.labelNumeroIdExamen.TabIndex = 111
        Me.labelNumeroIdExamen.Text = "Id Examen de sangre:"
        Me.labelNumeroIdExamen.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(488, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 20)
        Me.Label3.TabIndex = 110
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
        Me.Panel1.Location = New System.Drawing.Point(9, 33)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(323, 390)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 24)
        Me.BtnEliminar.TabIndex = 108
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TablaExamenes
        '
        Me.TablaExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaExamenes.Location = New System.Drawing.Point(488, 33)
        Me.TablaExamenes.Name = "TablaExamenes"
        Me.TablaExamenes.ReadOnly = True
        Me.TablaExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaExamenes.Size = New System.Drawing.Size(508, 352)
        Me.TablaExamenes.TabIndex = 107
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(205, 390)
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
        Me.Label4.Location = New System.Drawing.Point(85, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Acido urico:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(84, 390)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(85, 24)
        Me.BtnRegistrar.TabIndex = 105
        Me.BtnRegistrar.Text = "Agregar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TxtAcidoUrico
        '
        Me.TxtAcidoUrico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcidoUrico.Location = New System.Drawing.Point(190, 207)
        Me.TxtAcidoUrico.Name = "TxtAcidoUrico"
        Me.TxtAcidoUrico.Size = New System.Drawing.Size(206, 22)
        Me.TxtAcidoUrico.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(69, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Hemoglobina:"
        '
        'TxtHemoglobina
        '
        Me.TxtHemoglobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHemoglobina.Location = New System.Drawing.Point(190, 319)
        Me.TxtHemoglobina.Name = "TxtHemoglobina"
        Me.TxtHemoglobina.Size = New System.Drawing.Size(206, 22)
        Me.TxtHemoglobina.TabIndex = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(75, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 18)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Trigliceridos:"
        '
        'TxtTrigliceridos
        '
        Me.TxtTrigliceridos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTrigliceridos.Location = New System.Drawing.Point(190, 347)
        Me.TxtTrigliceridos.Name = "TxtTrigliceridos"
        Me.TxtTrigliceridos.Size = New System.Drawing.Size(206, 22)
        Me.TxtTrigliceridos.TabIndex = 122
        '
        'FrmConsultaExamenSangre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 429)
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
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TablaExamenes)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.TxtAcidoUrico)
        Me.Name = "FrmConsultaExamenSangre"
        Me.Text = "FrmConsultaExamenSangre"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TablaExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TablaExamenes As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents TxtAcidoUrico As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtHemoglobina As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTrigliceridos As TextBox
End Class
