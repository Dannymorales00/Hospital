﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMPersonaContacto
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelCedula = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.telefonoTxt = New System.Windows.Forms.TextBox()
        Me.relacionTxt = New System.Windows.Forms.TextBox()
        Me.cedulaTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.direccionTxt = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablaPersonas = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cedulaBuscarTxt = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.tablaPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(385, 443)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 30)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Limpiar Campos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.ForeColor = System.Drawing.Color.Black
        Me.labelNombre.Location = New System.Drawing.Point(444, 235)
        Me.labelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(44, 17)
        Me.labelNombre.TabIndex = 29
        Me.labelNombre.Text = "******"
        '
        'labelCedula
        '
        Me.labelCedula.AutoSize = True
        Me.labelCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCedula.ForeColor = System.Drawing.Color.Black
        Me.labelCedula.Location = New System.Drawing.Point(444, 272)
        Me.labelCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCedula.Name = "labelCedula"
        Me.labelCedula.Size = New System.Drawing.Size(44, 17)
        Me.labelCedula.TabIndex = 28
        Me.labelCedula.Text = "******"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(363, 272)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Cedula:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(363, 235)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nombre:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(236, 443)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(108, 30)
        Me.btnRegistrar.TabIndex = 25
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'telefonoTxt
        '
        Me.telefonoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoTxt.Location = New System.Drawing.Point(253, 177)
        Me.telefonoTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.telefonoTxt.Name = "telefonoTxt"
        Me.telefonoTxt.Size = New System.Drawing.Size(273, 26)
        Me.telefonoTxt.TabIndex = 24
        '
        'relacionTxt
        '
        Me.relacionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relacionTxt.Location = New System.Drawing.Point(253, 119)
        Me.relacionTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.relacionTxt.Name = "relacionTxt"
        Me.relacionTxt.Size = New System.Drawing.Size(273, 26)
        Me.relacionTxt.TabIndex = 23
        '
        'cedulaTxt
        '
        Me.cedulaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedulaTxt.Location = New System.Drawing.Point(253, 73)
        Me.cedulaTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.cedulaTxt.Name = "cedulaTxt"
        Me.cedulaTxt.Size = New System.Drawing.Size(273, 26)
        Me.cedulaTxt.TabIndex = 22
        '
        'nombreTxt
        '
        Me.nombreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreTxt.Location = New System.Drawing.Point(253, 27)
        Me.nombreTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(273, 26)
        Me.nombreTxt.TabIndex = 21
        '
        'direccionTxt
        '
        Me.direccionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccionTxt.Location = New System.Drawing.Point(236, 304)
        Me.direccionTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.direccionTxt.Name = "direccionTxt"
        Me.direccionTxt.Size = New System.Drawing.Size(349, 117)
        Me.direccionTxt.TabIndex = 20
        Me.direccionTxt.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(27, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Paciente:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(236, 246)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Paciente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 304)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Relación Familiar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cedula:"
        '
        'tablaPersonas
        '
        Me.tablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPersonas.Location = New System.Drawing.Point(691, 57)
        Me.tablaPersonas.Margin = New System.Windows.Forms.Padding(4)
        Me.tablaPersonas.Name = "tablaPersonas"
        Me.tablaPersonas.ReadOnly = True
        Me.tablaPersonas.RowHeadersWidth = 51
        Me.tablaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaPersonas.Size = New System.Drawing.Size(796, 486)
        Me.tablaPersonas.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(687, 23)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 24)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Cedula:"
        '
        'cedulaBuscarTxt
        '
        Me.cedulaBuscarTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedulaBuscarTxt.Location = New System.Drawing.Point(781, 22)
        Me.cedulaBuscarTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.cedulaBuscarTxt.Name = "cedulaBuscarTxt"
        Me.cedulaBuscarTxt.Size = New System.Drawing.Size(209, 26)
        Me.cedulaBuscarTxt.TabIndex = 33
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(533, 443)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 30)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(595, 22)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(59, 17)
        Me.lblId.TabIndex = 35
        Me.lblId.Text = "Label10"
        Me.lblId.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(1412, 17)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 38)
        Me.BtnCerrar.TabIndex = 37
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FRMPersonaContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cedulaBuscarTxt)
        Me.Controls.Add(Me.tablaPersonas)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelCedula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.telefonoTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.relacionTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cedulaTxt)
        Me.Controls.Add(Me.direccionTxt)
        Me.Controls.Add(Me.nombreTxt)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRMPersonaContacto"
        Me.Text = "FRMPersonaContacto"
        CType(Me.tablaPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents direccionTxt As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents telefonoTxt As TextBox
    Friend WithEvents relacionTxt As TextBox
    Friend WithEvents cedulaTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents labelNombre As Label
    Friend WithEvents labelCedula As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents tablaPersonas As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents cedulaBuscarTxt As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents lblId As Label
    Friend WithEvents BtnCerrar As Button
End Class
