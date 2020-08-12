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
        Me.GrupoAgregar = New System.Windows.Forms.GroupBox()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.GrupoEliminar = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCedulaEliminar = New System.Windows.Forms.TextBox()
        Me.GrupoBuscar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCedulaBuscar = New System.Windows.Forms.TextBox()
        Me.IniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GrupoActualizar = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GrupoAgregar.SuspendLayout()
        Me.GrupoEliminar.SuspendLayout()
        Me.GrupoBuscar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GrupoActualizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoAgregar
        '
        Me.GrupoAgregar.AutoSize = True
        Me.GrupoAgregar.BackColor = System.Drawing.Color.Silver
        Me.GrupoAgregar.Controls.Add(Me.CBTipo)
        Me.GrupoAgregar.Controls.Add(Me.Label8)
        Me.GrupoAgregar.Controls.Add(Me.TxtContraseña)
        Me.GrupoAgregar.Controls.Add(Me.TxtNombreUsuario)
        Me.GrupoAgregar.Controls.Add(Me.Label7)
        Me.GrupoAgregar.Controls.Add(Me.Label6)
        Me.GrupoAgregar.Controls.Add(Me.TxtCorreo)
        Me.GrupoAgregar.Controls.Add(Me.TxtTelefono)
        Me.GrupoAgregar.Controls.Add(Me.Label5)
        Me.GrupoAgregar.Controls.Add(Me.Label4)
        Me.GrupoAgregar.Controls.Add(Me.DateTimePicker1)
        Me.GrupoAgregar.Controls.Add(Me.Label3)
        Me.GrupoAgregar.Controls.Add(Me.BtnAgregar)
        Me.GrupoAgregar.Controls.Add(Me.Label1)
        Me.GrupoAgregar.Controls.Add(Me.TxtNombre)
        Me.GrupoAgregar.Controls.Add(Me.Label2)
        Me.GrupoAgregar.Controls.Add(Me.TxtCedula)
        Me.GrupoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GrupoAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoAgregar.Location = New System.Drawing.Point(12, 57)
        Me.GrupoAgregar.Name = "GrupoAgregar"
        Me.GrupoAgregar.Size = New System.Drawing.Size(351, 364)
        Me.GrupoAgregar.TabIndex = 9
        Me.GrupoAgregar.TabStop = False
        '
        'CBTipo
        '
        Me.CBTipo.FormattingEnabled = True
        Me.CBTipo.Items.AddRange(New Object() {"Medico", "Secretaria", "Enfermera"})
        Me.CBTipo.Location = New System.Drawing.Point(154, 265)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(166, 23)
        Me.CBTipo.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(95, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(154, 226)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(166, 21)
        Me.TxtContraseña.TabIndex = 14
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(154, 91)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(166, 21)
        Me.TxtNombreUsuario.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(54, 230)
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
        Me.Label6.Location = New System.Drawing.Point(8, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre de usuario"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(154, 127)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(166, 21)
        Me.TxtCorreo.TabIndex = 10
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(154, 159)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(166, 21)
        Me.TxtTelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(82, 127)
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
        Me.Label4.Location = New System.Drawing.Point(69, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(154, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 21)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(222, 317)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(98, 27)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(80, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(154, 28)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(166, 21)
        Me.TxtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(74, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(154, 59)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(166, 21)
        Me.TxtCedula.TabIndex = 2
        '
        'GrupoEliminar
        '
        Me.GrupoEliminar.AutoSize = True
        Me.GrupoEliminar.BackColor = System.Drawing.Color.Silver
        Me.GrupoEliminar.Controls.Add(Me.BtnEliminar)
        Me.GrupoEliminar.Controls.Add(Me.Label15)
        Me.GrupoEliminar.Controls.Add(Me.TxtCedulaEliminar)
        Me.GrupoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GrupoEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoEliminar.Location = New System.Drawing.Point(369, 57)
        Me.GrupoEliminar.Name = "GrupoEliminar"
        Me.GrupoEliminar.Size = New System.Drawing.Size(279, 129)
        Me.GrupoEliminar.TabIndex = 11
        Me.GrupoEliminar.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(158, 80)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(98, 27)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(19, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cedula"
        '
        'TxtCedulaEliminar
        '
        Me.TxtCedulaEliminar.Location = New System.Drawing.Point(93, 32)
        Me.TxtCedulaEliminar.Name = "TxtCedulaEliminar"
        Me.TxtCedulaEliminar.Size = New System.Drawing.Size(163, 21)
        Me.TxtCedulaEliminar.TabIndex = 2
        '
        'GrupoBuscar
        '
        Me.GrupoBuscar.AutoSize = True
        Me.GrupoBuscar.BackColor = System.Drawing.Color.Silver
        Me.GrupoBuscar.Controls.Add(Me.DataGridView1)
        Me.GrupoBuscar.Controls.Add(Me.BtnBuscar)
        Me.GrupoBuscar.Controls.Add(Me.Label9)
        Me.GrupoBuscar.Controls.Add(Me.TxtCedulaBuscar)
        Me.GrupoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GrupoBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoBuscar.Location = New System.Drawing.Point(369, 192)
        Me.GrupoBuscar.Name = "GrupoBuscar"
        Me.GrupoBuscar.Size = New System.Drawing.Size(279, 229)
        Me.GrupoBuscar.TabIndex = 12
        Me.GrupoBuscar.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(223, 73)
        Me.DataGridView1.TabIndex = 18
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(158, 64)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(98, 27)
        Me.BtnBuscar.TabIndex = 17
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cedula"
        '
        'TxtCedulaBuscar
        '
        Me.TxtCedulaBuscar.Location = New System.Drawing.Point(104, 37)
        Me.TxtCedulaBuscar.Name = "TxtCedulaBuscar"
        Me.TxtCedulaBuscar.Size = New System.Drawing.Size(152, 21)
        Me.TxtCedulaBuscar.TabIndex = 2
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesiónToolStripMenuItem, Me.RegistrarseToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1031, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuInicio"
        '
        'GrupoActualizar
        '
        Me.GrupoActualizar.AutoSize = True
        Me.GrupoActualizar.BackColor = System.Drawing.Color.Silver
        Me.GrupoActualizar.Controls.Add(Me.Button1)
        Me.GrupoActualizar.Controls.Add(Me.ComboBox1)
        Me.GrupoActualizar.Controls.Add(Me.Label10)
        Me.GrupoActualizar.Controls.Add(Me.TextBox1)
        Me.GrupoActualizar.Controls.Add(Me.TextBox2)
        Me.GrupoActualizar.Controls.Add(Me.Label11)
        Me.GrupoActualizar.Controls.Add(Me.Label12)
        Me.GrupoActualizar.Controls.Add(Me.TextBox3)
        Me.GrupoActualizar.Controls.Add(Me.TextBox4)
        Me.GrupoActualizar.Controls.Add(Me.Label13)
        Me.GrupoActualizar.Controls.Add(Me.Label14)
        Me.GrupoActualizar.Controls.Add(Me.DateTimePicker2)
        Me.GrupoActualizar.Controls.Add(Me.Label16)
        Me.GrupoActualizar.Controls.Add(Me.BtnCargar)
        Me.GrupoActualizar.Controls.Add(Me.Label17)
        Me.GrupoActualizar.Controls.Add(Me.TextBox5)
        Me.GrupoActualizar.Controls.Add(Me.Label18)
        Me.GrupoActualizar.Controls.Add(Me.TextBox6)
        Me.GrupoActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GrupoActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoActualizar.Location = New System.Drawing.Point(654, 57)
        Me.GrupoActualizar.Name = "GrupoActualizar"
        Me.GrupoActualizar.Size = New System.Drawing.Size(351, 364)
        Me.GrupoActualizar.TabIndex = 13
        Me.GrupoActualizar.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(222, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 27)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Medico", "Secretaria", "Enfermera"})
        Me.ComboBox1.Location = New System.Drawing.Point(154, 265)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 23)
        Me.ComboBox1.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(95, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Tipo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 226)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 21)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(154, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 21)
        Me.TextBox2.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(54, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Contraseña"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Nombre de usuario"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 127)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(166, 21)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(154, 159)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 21)
        Me.TextBox4.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(82, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Correo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(69, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Telefono"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(154, 194)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(127, 21)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(14, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 16)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Fecha Nacimiento"
        '
        'BtnCargar
        '
        Me.BtnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.Location = New System.Drawing.Point(77, 317)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(119, 27)
        Me.BtnCargar.TabIndex = 4
        Me.BtnCargar.Text = "CargarUsuario"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(80, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Cedula"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(154, 28)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(166, 21)
        Me.TextBox5.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(74, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Nombre"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(154, 59)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(166, 21)
        Me.TextBox6.TabIndex = 2
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 450)
        Me.Controls.Add(Me.GrupoActualizar)
        Me.Controls.Add(Me.GrupoBuscar)
        Me.Controls.Add(Me.GrupoEliminar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GrupoAgregar)
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUsuario"
        Me.TopMost = True
        Me.GrupoAgregar.ResumeLayout(False)
        Me.GrupoAgregar.PerformLayout()
        Me.GrupoEliminar.ResumeLayout(False)
        Me.GrupoEliminar.PerformLayout()
        Me.GrupoBuscar.ResumeLayout(False)
        Me.GrupoBuscar.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GrupoActualizar.ResumeLayout(False)
        Me.GrupoActualizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrupoAgregar As GroupBox
    Friend WithEvents CBTipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents GrupoEliminar As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCedulaEliminar As TextBox
    Friend WithEvents GrupoBuscar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCedulaBuscar As TextBox
    Friend WithEvents IniciarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GrupoActualizar As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnCargar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
