<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMedicamentoAlergicoRegistrar
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
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.clb_medicamentos = New System.Windows.Forms.CheckedListBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelCedula = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(19, 537)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(136, 41)
        Me.BtnRegistrar.TabIndex = 33
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'clb_medicamentos
        '
        Me.clb_medicamentos.FormattingEnabled = True
        Me.clb_medicamentos.Location = New System.Drawing.Point(16, 15)
        Me.clb_medicamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clb_medicamentos.MultiColumn = True
        Me.clb_medicamentos.Name = "clb_medicamentos"
        Me.clb_medicamentos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clb_medicamentos.Size = New System.Drawing.Size(631, 446)
        Me.clb_medicamentos.TabIndex = 36
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(511, 537)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(136, 41)
        Me.btn_close.TabIndex = 37
        Me.btn_close.Text = "Cerrar"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.ForeColor = System.Drawing.Color.Black
        Me.labelNombre.Location = New System.Drawing.Point(96, 479)
        Me.labelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(44, 17)
        Me.labelNombre.TabIndex = 55
        Me.labelNombre.Text = "******"
        '
        'labelCedula
        '
        Me.labelCedula.AutoSize = True
        Me.labelCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCedula.ForeColor = System.Drawing.Color.Black
        Me.labelCedula.Location = New System.Drawing.Point(96, 507)
        Me.labelCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCedula.Name = "labelCedula"
        Me.labelCedula.Size = New System.Drawing.Size(44, 17)
        Me.labelCedula.TabIndex = 54
        Me.labelCedula.Text = "******"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 507)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Cedula:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 479)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Nombre:"
        '
        'FrmMedicamentoAlergicoRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 579)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.labelCedula)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.clb_medicamentos)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMedicamentoAlergicoRegistrar"
        Me.Text = "FrmMedicamentoAlergicoRegistrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents clb_medicamentos As CheckedListBox
    Friend WithEvents btn_close As Button
    Friend WithEvents labelNombre As Label
    Friend WithEvents labelCedula As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
