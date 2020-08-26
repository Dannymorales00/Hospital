<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaciente
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
        Me.BtnMedicamentos = New System.Windows.Forms.Button()
        Me.BtnEnfermedades = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnPersonaC = New System.Windows.Forms.Button()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarCedula = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrarEnfermedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMedicamentos
        '
        Me.BtnMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedicamentos.Location = New System.Drawing.Point(314, 257)
        Me.BtnMedicamentos.Name = "BtnMedicamentos"
        Me.BtnMedicamentos.Size = New System.Drawing.Size(112, 30)
        Me.BtnMedicamentos.TabIndex = 60
        Me.BtnMedicamentos.Text = "Medicamentos"
        Me.BtnMedicamentos.UseVisualStyleBackColor = True
        '
        'BtnEnfermedades
        '
        Me.BtnEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnfermedades.Location = New System.Drawing.Point(179, 257)
        Me.BtnEnfermedades.Name = "BtnEnfermedades"
        Me.BtnEnfermedades.Size = New System.Drawing.Size(118, 30)
        Me.BtnEnfermedades.TabIndex = 59
        Me.BtnEnfermedades.Text = "Enfermedades"
        Me.BtnEnfermedades.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(564, 326)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(120, 33)
        Me.BtnLimpiar.TabIndex = 58
        Me.BtnLimpiar.Text = "Limpiar Campos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnPersonaC
        '
        Me.BtnPersonaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPersonaC.Location = New System.Drawing.Point(34, 257)
        Me.BtnPersonaC.Name = "BtnPersonaC"
        Me.BtnPersonaC.Size = New System.Drawing.Size(129, 30)
        Me.BtnPersonaC.TabIndex = 57
        Me.BtnPersonaC.Text = "Persona Contacto"
        Me.BtnPersonaC.UseVisualStyleBackColor = True
        '
        'ComboTipo
        '
        Me.ComboTipo.FormattingEnabled = True
        Me.ComboTipo.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.ComboTipo.Location = New System.Drawing.Point(155, 340)
        Me.ComboTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(80, 21)
        Me.ComboTipo.TabIndex = 56
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(442, 326)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(102, 33)
        Me.BtnRegistrar.TabIndex = 55
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(296, 303)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(51, 20)
        Me.TxtAltura.TabIndex = 54
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(179, 303)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(55, 20)
        Me.TxtPeso.TabIndex = 53
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(76, 303)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(46, 20)
        Me.TxtEdad.TabIndex = 52
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(141, 173)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelefono.TabIndex = 51
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(141, 215)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(140, 20)
        Me.TxtCorreo.TabIndex = 50
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(141, 79)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(236, 20)
        Me.TxtNombre.TabIndex = 49
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(141, 53)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(140, 20)
        Me.TxtCedula.TabIndex = 48
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(208, 119)
        Me.DateTimePicker1.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 21)
        Me.DateTimePicker1.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(32, 340)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 16)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Tipo de Sangre"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(246, 305)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 16)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Altura"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(135, 303)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 16)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Peso"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(32, 300)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 16)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Edad"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(31, 170)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 16)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Telefono"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(31, 215)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 16)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Correo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(31, 119)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(133, 16)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Fecha Nacimiento"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(31, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 16)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Cedula"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(31, 79)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(63, 16)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(442, 75)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(486, 242)
        Me.DataGridView1.TabIndex = 61
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(703, 326)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 33)
        Me.BtnEliminar.TabIndex = 62
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(439, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Cedula"
        '
        'TxtBuscarCedula
        '
        Me.TxtBuscarCedula.Location = New System.Drawing.Point(506, 46)
        Me.TxtBuscarCedula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBuscarCedula.Name = "TxtBuscarCedula"
        Me.TxtBuscarCedula.Size = New System.Drawing.Size(134, 20)
        Me.TxtBuscarCedula.TabIndex = 64
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.AdministrarEnfermedadesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(953, 24)
        Me.MenuStrip1.TabIndex = 65
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarEnfermedadesToolStripMenuItem
        '
        Me.AdministrarEnfermedadesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AdministrarEnfermedadesToolStripMenuItem.Name = "AdministrarEnfermedadesToolStripMenuItem"
        Me.AdministrarEnfermedadesToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.AdministrarEnfermedadesToolStripMenuItem.Text = "Administrar enfermedades"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'FrmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtBuscarCedula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnMedicamentos)
        Me.Controls.Add(Me.BtnEnfermedades)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnPersonaC)
        Me.Controls.Add(Me.ComboTipo)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.TxtPeso)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPaciente"
        Me.ShowIcon = False
        Me.Text = "FrmPaciente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoSangreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnMedicamentos As Button
    Friend WithEvents BtnEnfermedades As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnPersonaC As Button
    Friend WithEvents ComboTipo As ComboBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarCedula As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarEnfermedadesToolStripMenuItem As ToolStripMenuItem
End Class
