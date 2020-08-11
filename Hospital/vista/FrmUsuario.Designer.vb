<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.GrupoRegistrar = New System.Windows.Forms.GroupBox()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRegistroNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRegistroCedula = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoRegistrar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoRegistrar
        '
        Me.GrupoRegistrar.AutoSize = True
        Me.GrupoRegistrar.BackColor = System.Drawing.Color.Silver
        Me.GrupoRegistrar.Controls.Add(Me.CBTipo)
        Me.GrupoRegistrar.Controls.Add(Me.Label8)
        Me.GrupoRegistrar.Controls.Add(Me.TextBox4)
        Me.GrupoRegistrar.Controls.Add(Me.TextBox3)
        Me.GrupoRegistrar.Controls.Add(Me.Label7)
        Me.GrupoRegistrar.Controls.Add(Me.Label6)
        Me.GrupoRegistrar.Controls.Add(Me.TextBox2)
        Me.GrupoRegistrar.Controls.Add(Me.TextBox1)
        Me.GrupoRegistrar.Controls.Add(Me.Label5)
        Me.GrupoRegistrar.Controls.Add(Me.Label4)
        Me.GrupoRegistrar.Controls.Add(Me.DateTimePicker1)
        Me.GrupoRegistrar.Controls.Add(Me.Label3)
        Me.GrupoRegistrar.Controls.Add(Me.BtnRegistrar)
        Me.GrupoRegistrar.Controls.Add(Me.Label1)
        Me.GrupoRegistrar.Controls.Add(Me.TxtRegistroNombre)
        Me.GrupoRegistrar.Controls.Add(Me.Label2)
        Me.GrupoRegistrar.Controls.Add(Me.TxtRegistroCedula)
        Me.GrupoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GrupoRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoRegistrar.Location = New System.Drawing.Point(12, 54)
        Me.GrupoRegistrar.Name = "GrupoRegistrar"
        Me.GrupoRegistrar.Size = New System.Drawing.Size(408, 350)
        Me.GrupoRegistrar.TabIndex = 9
        Me.GrupoRegistrar.TabStop = False
        Me.GrupoRegistrar.Text = "Registro de Usuario"
        '
        'CBTipo
        '
        Me.CBTipo.FormattingEnabled = True
        Me.CBTipo.Items.AddRange(New Object() {"Medico", "Secretaria", "Enfermera"})
        Me.CBTipo.Location = New System.Drawing.Point(162, 265)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(166, 23)
        Me.CBTipo.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(103, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(162, 226)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 21)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.UseSystemPasswordChar = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(162, 91)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(236, 21)
        Me.TextBox3.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(62, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre de usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(162, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 21)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(162, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 21)
        Me.TextBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(90, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(77, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 21)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(191, 303)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(98, 27)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Registrarse"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula"
        '
        'TxtRegistroNombre
        '
        Me.TxtRegistroNombre.Location = New System.Drawing.Point(162, 28)
        Me.TxtRegistroNombre.Name = "TxtRegistroNombre"
        Me.TxtRegistroNombre.Size = New System.Drawing.Size(236, 21)
        Me.TxtRegistroNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(82, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TxtRegistroCedula
        '
        Me.TxtRegistroCedula.Location = New System.Drawing.Point(162, 59)
        Me.TxtRegistroCedula.Name = "TxtRegistroCedula"
        Me.TxtRegistroCedula.Size = New System.Drawing.Size(236, 21)
        Me.TxtRegistroCedula.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesiónToolStripMenuItem, Me.RegistrarseToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(561, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuInicio"
        '
        'IniciarSesiónToolStripMenuItem
        '
        Me.IniciarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IniciarSesiónToolStripMenuItem.Name = "IniciarSesiónToolStripMenuItem"
        Me.IniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.IniciarSesiónToolStripMenuItem.Text = "Agregar"
        '
        'RegistrarseToolStripMenuItem
        '
        Me.RegistrarseToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarseToolStripMenuItem.Name = "RegistrarseToolStripMenuItem"
        Me.RegistrarseToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarseToolStripMenuItem.Text = "Eliminar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GrupoRegistrar)
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
        Me.GrupoRegistrar.ResumeLayout(False)
        Me.GrupoRegistrar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrupoRegistrar As GroupBox
    Friend WithEvents CBTipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRegistroNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRegistroCedula As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IniciarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
End Class
