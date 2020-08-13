<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarMedico
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
        Me.DataGridViewMedicos = New System.Windows.Forms.DataGridView()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMedicos
        '
        Me.DataGridViewMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicos.Location = New System.Drawing.Point(47, 139)
        Me.DataGridViewMedicos.Name = "DataGridViewMedicos"
        Me.DataGridViewMedicos.ReadOnly = True
        Me.DataGridViewMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMedicos.Size = New System.Drawing.Size(253, 147)
        Me.DataGridViewMedicos.TabIndex = 0
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(47, 81)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(176, 20)
        Me.TxtCedula.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cedula"
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.Location = New System.Drawing.Point(216, 292)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(84, 23)
        Me.BtnSeleccionar.TabIndex = 4
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BuscarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 342)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.DataGridViewMedicos)
        Me.Name = "BuscarMedico"
        Me.Text = "BuscarMedico"
        CType(Me.DataGridViewMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMedicos As DataGridView
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSeleccionar As Button
End Class
