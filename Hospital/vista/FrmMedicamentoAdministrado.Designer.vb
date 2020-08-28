<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedicamentoAdministrado
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
        Me.clb_medicamentos = New System.Windows.Forms.CheckedListBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clb_medicamentos
        '
        Me.clb_medicamentos.FormattingEnabled = True
        Me.clb_medicamentos.Location = New System.Drawing.Point(12, 12)
        Me.clb_medicamentos.MultiColumn = True
        Me.clb_medicamentos.Name = "clb_medicamentos"
        Me.clb_medicamentos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clb_medicamentos.Size = New System.Drawing.Size(474, 364)
        Me.clb_medicamentos.TabIndex = 37
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(382, 397)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(102, 33)
        Me.btn_close.TabIndex = 39
        Me.btn_close.Text = "Cerrar"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(12, 397)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(102, 33)
        Me.BtnRegistrar.TabIndex = 38
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'FrmMedicamentoAdministrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 442)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.clb_medicamentos)
        Me.Name = "FrmMedicamentoAdministrado"
        Me.Text = "FrmMedicamentoAdministrado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clb_medicamentos As CheckedListBox
    Friend WithEvents btn_close As Button
    Friend WithEvents BtnRegistrar As Button
End Class
