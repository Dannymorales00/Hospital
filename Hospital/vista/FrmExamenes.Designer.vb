<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExamenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExamenes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExamenOrina = New System.Windows.Forms.Button()
        Me.BtnExamenSangre = New System.Windows.Forms.Button()
        Me.PanelExamenes = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelExamenes.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1163, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'BtnExamenOrina
        '
        Me.BtnExamenOrina.BackgroundImage = CType(resources.GetObject("BtnExamenOrina.BackgroundImage"), System.Drawing.Image)
        Me.BtnExamenOrina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExamenOrina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenOrina.Location = New System.Drawing.Point(52, 103)
        Me.BtnExamenOrina.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExamenOrina.Name = "BtnExamenOrina"
        Me.BtnExamenOrina.Size = New System.Drawing.Size(205, 160)
        Me.BtnExamenOrina.TabIndex = 1
        Me.BtnExamenOrina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExamenOrina.UseVisualStyleBackColor = True
        '
        'BtnExamenSangre
        '
        Me.BtnExamenSangre.BackgroundImage = CType(resources.GetObject("BtnExamenSangre.BackgroundImage"), System.Drawing.Image)
        Me.BtnExamenSangre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExamenSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenSangre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnExamenSangre.Location = New System.Drawing.Point(529, 103)
        Me.BtnExamenSangre.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExamenSangre.Name = "BtnExamenSangre"
        Me.BtnExamenSangre.Size = New System.Drawing.Size(205, 160)
        Me.BtnExamenSangre.TabIndex = 2
        Me.BtnExamenSangre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExamenSangre.UseVisualStyleBackColor = True
        '
        'PanelExamenes
        '
        Me.PanelExamenes.Controls.Add(Me.Label2)
        Me.PanelExamenes.Controls.Add(Me.Label1)
        Me.PanelExamenes.Controls.Add(Me.BtnExamenOrina)
        Me.PanelExamenes.Controls.Add(Me.BtnExamenSangre)
        Me.PanelExamenes.Location = New System.Drawing.Point(188, 71)
        Me.PanelExamenes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExamenes.Name = "PanelExamenes"
        Me.PanelExamenes.Size = New System.Drawing.Size(793, 417)
        Me.PanelExamenes.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Examen de Orina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(552, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Examen de Sangre"
        '
        'FrmExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 572)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelExamenes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmExamenes"
        Me.Text = "FrmExamenes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelExamenes.ResumeLayout(False)
        Me.PanelExamenes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnExamenOrina As Button
    Friend WithEvents BtnExamenSangre As Button
    Friend WithEvents PanelExamenes As Panel
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
