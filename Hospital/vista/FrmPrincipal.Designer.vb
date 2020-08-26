<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPerfilNombreUSuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPerfilTipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnCitas = New System.Windows.Forms.Button()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.PanelModulos = New System.Windows.Forms.Panel()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnExamenes = New System.Windows.Forms.Button()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelModulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1315, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPerfilNombreUSuario, Me.MenuPerfilTipo})
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'MenuPerfilNombreUSuario
        '
        Me.MenuPerfilNombreUSuario.Name = "MenuPerfilNombreUSuario"
        Me.MenuPerfilNombreUSuario.Size = New System.Drawing.Size(239, 26)
        Me.MenuPerfilNombreUSuario.Text = "sin nombre de usuario"
        '
        'MenuPerfilTipo
        '
        Me.MenuPerfilTipo.Name = "MenuPerfilTipo"
        Me.MenuPerfilTipo.Size = New System.Drawing.Size(239, 26)
        Me.MenuPerfilTipo.Text = "sin tipo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackgroundImage = CType(resources.GetObject("BtnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BtnUsuarios.Location = New System.Drawing.Point(4, 4)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(231, 160)
        Me.BtnUsuarios.TabIndex = 2
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnCitas
        '
        Me.BtnCitas.BackgroundImage = CType(resources.GetObject("BtnCitas.BackgroundImage"), System.Drawing.Image)
        Me.BtnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCitas.Location = New System.Drawing.Point(429, 4)
        Me.BtnCitas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCitas.Name = "BtnCitas"
        Me.BtnCitas.Size = New System.Drawing.Size(231, 160)
        Me.BtnCitas.TabIndex = 3
        Me.BtnCitas.Text = "Citas"
        Me.BtnCitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCitas.UseVisualStyleBackColor = True
        '
        'BtnPaciente
        '
        Me.BtnPaciente.BackgroundImage = CType(resources.GetObject("BtnPaciente.BackgroundImage"), System.Drawing.Image)
        Me.BtnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPaciente.Location = New System.Drawing.Point(813, 4)
        Me.BtnPaciente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Size = New System.Drawing.Size(231, 160)
        Me.BtnPaciente.TabIndex = 4
        Me.BtnPaciente.Text = "Pacientes"
        Me.BtnPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'PanelModulos
        '
        Me.PanelModulos.Controls.Add(Me.BtnReportes)
        Me.PanelModulos.Controls.Add(Me.BtnExamenes)
        Me.PanelModulos.Controls.Add(Me.BtnConsulta)
        Me.PanelModulos.Controls.Add(Me.BtnCitas)
        Me.PanelModulos.Controls.Add(Me.BtnPaciente)
        Me.PanelModulos.Controls.Add(Me.BtnUsuarios)
        Me.PanelModulos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PanelModulos.Location = New System.Drawing.Point(119, 85)
        Me.PanelModulos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelModulos.Name = "PanelModulos"
        Me.PanelModulos.Size = New System.Drawing.Size(1048, 450)
        Me.PanelModulos.TabIndex = 5
        '
        'BtnReportes
        '
        Me.BtnReportes.BackgroundImage = CType(resources.GetObject("BtnReportes.BackgroundImage"), System.Drawing.Image)
        Me.BtnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Location = New System.Drawing.Point(813, 287)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(231, 160)
        Me.BtnReportes.TabIndex = 7
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnExamenes
        '
        Me.BtnExamenes.BackgroundImage = CType(resources.GetObject("BtnExamenes.BackgroundImage"), System.Drawing.Image)
        Me.BtnExamenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExamenes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExamenes.Location = New System.Drawing.Point(429, 287)
        Me.BtnExamenes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExamenes.Name = "BtnExamenes"
        Me.BtnExamenes.Size = New System.Drawing.Size(231, 160)
        Me.BtnExamenes.TabIndex = 6
        Me.BtnExamenes.Text = "Examenes"
        Me.BtnExamenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExamenes.UseVisualStyleBackColor = True
        '
        'BtnConsulta
        '
        Me.BtnConsulta.BackgroundImage = CType(resources.GetObject("BtnConsulta.BackgroundImage"), System.Drawing.Image)
        Me.BtnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsulta.Location = New System.Drawing.Point(4, 287)
        Me.BtnConsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(231, 160)
        Me.BtnConsulta.TabIndex = 5
        Me.BtnConsulta.Text = "Consulta"
        Me.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1315, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelModulos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPrincipal"
        Me.Opacity = 0.99R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelModulos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPerfilNombreUSuario As ToolStripMenuItem
    Friend WithEvents MenuPerfilTipo As ToolStripMenuItem
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnCitas As Button
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnPaciente As Button
    Friend WithEvents PanelModulos As Panel
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnExamenes As Button
    Friend WithEvents BtnConsulta As Button
End Class
