<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPerfilNombreUSuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPerfilTipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnEnfermedades = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(917, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPerfilNombreUSuario, Me.MenuPerfilTipo})
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'MenuPerfilNombreUSuario
        '
        Me.MenuPerfilNombreUSuario.Name = "MenuPerfilNombreUSuario"
        Me.MenuPerfilNombreUSuario.Size = New System.Drawing.Size(192, 22)
        Me.MenuPerfilNombreUSuario.Text = "sin nombre de usuario"
        '
        'MenuPerfilTipo
        '
        Me.MenuPerfilTipo.Name = "MenuPerfilTipo"
        Me.MenuPerfilTipo.Size = New System.Drawing.Size(192, 22)
        Me.MenuPerfilTipo.Text = "sin tipo"
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackgroundImage = Global.Hospital.My.Resources.Resources.usuariospng
        Me.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUsuarios.Location = New System.Drawing.Point(53, 63)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(79, 60)
        Me.BtnUsuarios.TabIndex = 2
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnEnfermedades
        '
        Me.BtnEnfermedades.Location = New System.Drawing.Point(277, 68)
        Me.BtnEnfermedades.Name = "BtnEnfermedades"
        Me.BtnEnfermedades.Size = New System.Drawing.Size(112, 50)
        Me.BtnEnfermedades.TabIndex = 3
        Me.BtnEnfermedades.Text = "Enfermedades"
        Me.BtnEnfermedades.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(486, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Citas de Hoy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(652, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Consultas de Hoy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(917, 491)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnEnfermedades)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPerfilNombreUSuario As ToolStripMenuItem
    Friend WithEvents MenuPerfilTipo As ToolStripMenuItem
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnEnfermedades As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
