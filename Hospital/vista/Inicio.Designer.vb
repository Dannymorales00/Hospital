<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.TxtInicioUsuario = New System.Windows.Forms.TextBox()
        Me.TxtInicioContraseña = New System.Windows.Forms.TextBox()
        Me.GrupoIniciar = New System.Windows.Forms.GroupBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.GrupoIniciar.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(61, 42)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(62, 16)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario"
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(61, 123)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(87, 16)
        Me.LblContraseña.TabIndex = 1
        Me.LblContraseña.Text = "Contraseña"
        '
        'TxtInicioUsuario
        '
        Me.TxtInicioUsuario.Location = New System.Drawing.Point(64, 61)
        Me.TxtInicioUsuario.Name = "TxtInicioUsuario"
        Me.TxtInicioUsuario.Size = New System.Drawing.Size(134, 21)
        Me.TxtInicioUsuario.TabIndex = 2
        '
        'TxtInicioContraseña
        '
        Me.TxtInicioContraseña.Location = New System.Drawing.Point(64, 142)
        Me.TxtInicioContraseña.Name = "TxtInicioContraseña"
        Me.TxtInicioContraseña.Size = New System.Drawing.Size(134, 21)
        Me.TxtInicioContraseña.TabIndex = 3
        '
        'GrupoIniciar
        '
        Me.GrupoIniciar.AutoSize = True
        Me.GrupoIniciar.BackColor = System.Drawing.Color.Silver
        Me.GrupoIniciar.Controls.Add(Me.BtnIngresar)
        Me.GrupoIniciar.Controls.Add(Me.LblUsuario)
        Me.GrupoIniciar.Controls.Add(Me.TxtInicioContraseña)
        Me.GrupoIniciar.Controls.Add(Me.LblContraseña)
        Me.GrupoIniciar.Controls.Add(Me.TxtInicioUsuario)
        Me.GrupoIniciar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GrupoIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrupoIniciar.Location = New System.Drawing.Point(60, 61)
        Me.GrupoIniciar.Name = "GrupoIniciar"
        Me.GrupoIniciar.Size = New System.Drawing.Size(249, 349)
        Me.GrupoIniciar.TabIndex = 4
        Me.GrupoIniciar.TabStop = False
        Me.GrupoIniciar.Text = "Inicio"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(82, 254)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(98, 27)
        Me.BtnIngresar.TabIndex = 4
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 433)
        Me.Controls.Add(Me.GrupoIniciar)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GrupoIniciar.ResumeLayout(False)
        Me.GrupoIniciar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents TxtInicioUsuario As TextBox
    Friend WithEvents TxtInicioContraseña As TextBox
    Friend WithEvents GrupoIniciar As GroupBox
    Friend WithEvents BtnIngresar As Button
End Class
