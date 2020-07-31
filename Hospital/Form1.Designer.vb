<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnRegistrarse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(97, 42)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(55, 16)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario"
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(97, 123)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(77, 16)
        Me.LblContraseña.TabIndex = 1
        Me.LblContraseña.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(100, 61)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(134, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(100, 142)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(134, 20)
        Me.TxtContraseña.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.Controls.Add(Me.TxtContraseña)
        Me.GroupBox1.Controls.Add(Me.LblContraseña)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(214, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 291)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(120, 226)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(98, 27)
        Me.BtnIngresar.TabIndex = 4
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnRegistrarse
        '
        Me.BtnRegistrarse.Location = New System.Drawing.Point(593, 12)
        Me.BtnRegistrarse.Name = "BtnRegistrarse"
        Me.BtnRegistrarse.Size = New System.Drawing.Size(78, 23)
        Me.BtnRegistrarse.TabIndex = 5
        Me.BtnRegistrarse.Text = "Registrarse"
        Me.BtnRegistrarse.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRegistrarse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnRegistrarse As Button
End Class
