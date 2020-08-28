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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarEnfermedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPersonaContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMedicamentos
        '
        Me.BtnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedicamentos.ForeColor = System.Drawing.Color.White
        Me.BtnMedicamentos.Location = New System.Drawing.Point(386, 405)
        Me.BtnMedicamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMedicamentos.Name = "BtnMedicamentos"
        Me.BtnMedicamentos.Size = New System.Drawing.Size(149, 37)
        Me.BtnMedicamentos.TabIndex = 60
        Me.BtnMedicamentos.Text = "Medicamentos"
        Me.BtnMedicamentos.UseVisualStyleBackColor = True
        '
        'BtnEnfermedades
        '
        Me.BtnEnfermedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnfermedades.ForeColor = System.Drawing.Color.White
        Me.BtnEnfermedades.Location = New System.Drawing.Point(208, 405)
        Me.BtnEnfermedades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEnfermedades.Name = "BtnEnfermedades"
        Me.BtnEnfermedades.Size = New System.Drawing.Size(157, 37)
        Me.BtnEnfermedades.TabIndex = 59
        Me.BtnEnfermedades.Text = "Enfermedades"
        Me.BtnEnfermedades.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(752, 401)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(160, 41)
        Me.BtnLimpiar.TabIndex = 58
        Me.BtnLimpiar.Text = "Limpiar Campos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnPersonaC
        '
        Me.BtnPersonaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPersonaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPersonaC.ForeColor = System.Drawing.Color.White
        Me.BtnPersonaC.Location = New System.Drawing.Point(16, 405)
        Me.BtnPersonaC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPersonaC.Name = "BtnPersonaC"
        Me.BtnPersonaC.Size = New System.Drawing.Size(184, 37)
        Me.BtnPersonaC.TabIndex = 57
        Me.BtnPersonaC.Text = "Persona Contacto"
        Me.BtnPersonaC.UseVisualStyleBackColor = True
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboTipo.FormattingEnabled = True
        Me.ComboTipo.Items.AddRange(New Object() {"A-", "A+", "AB-", "AB+", "B-", "B+", "O-", "O+"})
        Me.ComboTipo.Location = New System.Drawing.Point(205, 362)
        Me.ComboTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(145, 24)
        Me.ComboTipo.TabIndex = 56
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(589, 401)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(136, 41)
        Me.BtnRegistrar.TabIndex = 55
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(393, 317)
        Me.TxtAltura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAltura.MaxLength = 3
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(67, 22)
        Me.TxtAltura.TabIndex = 54
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(237, 317)
        Me.TxtPeso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPeso.MaxLength = 3
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(72, 22)
        Me.TxtPeso.TabIndex = 53
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(99, 317)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEdad.MaxLength = 2
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(60, 22)
        Me.TxtEdad.TabIndex = 52
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(229, 207)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(185, 22)
        Me.TxtTelefono.TabIndex = 51
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(229, 258)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCorreo.MaxLength = 25
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(185, 22)
        Me.TxtCorreo.TabIndex = 50
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(229, 106)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(313, 22)
        Me.TxtNombre.TabIndex = 49
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(229, 64)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCedula.MaxLength = 10
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(185, 22)
        Me.TxtCedula.TabIndex = 48
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(229, 150)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 24)
        Me.DateTimePicker1.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(41, 362)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 20)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Tipo de Sangre"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(326, 319)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 20)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Altura"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(178, 317)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 20)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Peso"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(41, 313)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 20)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Edad"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(116, 207)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 20)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Telefono"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(136, 263)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 20)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Correo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(32, 150)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(160, 20)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Fecha Nacimiento"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(133, 69)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 20)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Cedula"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(125, 107)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 20)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Nombre"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(589, 92)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(648, 298)
        Me.DataGridView1.TabIndex = 61
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(937, 401)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(136, 41)
        Me.BtnEliminar.TabIndex = 62
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(585, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Cedula"
        '
        'TxtBuscarCedula
        '
        Me.TxtBuscarCedula.Location = New System.Drawing.Point(675, 57)
        Me.TxtBuscarCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscarCedula.MaxLength = 10
        Me.TxtBuscarCedula.Name = "TxtBuscarCedula"
        Me.TxtBuscarCedula.Size = New System.Drawing.Size(177, 22)
        Me.TxtBuscarCedula.TabIndex = 64
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.AdministrarEnfermedadesToolStripMenuItem, Me.AdministrarPersonaContactoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1271, 28)
        Me.MenuStrip1.TabIndex = 65
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'AdministrarEnfermedadesToolStripMenuItem
        '
        Me.AdministrarEnfermedadesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AdministrarEnfermedadesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AdministrarEnfermedadesToolStripMenuItem.Name = "AdministrarEnfermedadesToolStripMenuItem"
        Me.AdministrarEnfermedadesToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
        Me.AdministrarEnfermedadesToolStripMenuItem.Text = "Administrar enfermedades"
        '
        'AdministrarPersonaContactoToolStripMenuItem
        '
        Me.AdministrarPersonaContactoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AdministrarPersonaContactoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AdministrarPersonaContactoToolStripMenuItem.Name = "AdministrarPersonaContactoToolStripMenuItem"
        Me.AdministrarPersonaContactoToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.AdministrarPersonaContactoToolStripMenuItem.Text = "Administrar persona contacto"
        '
        'FrmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1271, 484)
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
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents AdministrarPersonaContactoToolStripMenuItem As ToolStripMenuItem
End Class
