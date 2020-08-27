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
        Me.BtnExamenOrina = New System.Windows.Forms.Button()
        Me.BtnExamenSangre = New System.Windows.Forms.Button()
        Me.PanelExamenes = New System.Windows.Forms.Panel()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelExamenes.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtnExamenOrina
        '
        Me.BtnExamenOrina.BackgroundImage = CType(resources.GetObject("BtnExamenOrina.BackgroundImage"), System.Drawing.Image)
        Me.BtnExamenOrina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExamenOrina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenOrina.Location = New System.Drawing.Point(39, 84)
        Me.BtnExamenOrina.Name = "BtnExamenOrina"
        Me.BtnExamenOrina.Size = New System.Drawing.Size(154, 130)
        Me.BtnExamenOrina.TabIndex = 1
        Me.BtnExamenOrina.Text = "Examen de Orina"
        Me.BtnExamenOrina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExamenOrina.UseVisualStyleBackColor = True
        '
        'BtnExamenSangre
        '
        Me.BtnExamenSangre.BackgroundImage = CType(resources.GetObject("BtnExamenSangre.BackgroundImage"), System.Drawing.Image)
        Me.BtnExamenSangre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExamenSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExamenSangre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnExamenSangre.Location = New System.Drawing.Point(397, 84)
        Me.BtnExamenSangre.Name = "BtnExamenSangre"
        Me.BtnExamenSangre.Size = New System.Drawing.Size(154, 130)
        Me.BtnExamenSangre.TabIndex = 2
        Me.BtnExamenSangre.Text = "Examen de Sangre"
        Me.BtnExamenSangre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExamenSangre.UseVisualStyleBackColor = True
        '
        'PanelExamenes
        '
        Me.PanelExamenes.Controls.Add(Me.BtnExamenOrina)
        Me.PanelExamenes.Controls.Add(Me.BtnExamenSangre)
        Me.PanelExamenes.Location = New System.Drawing.Point(141, 58)
        Me.PanelExamenes.Name = "PanelExamenes"
        Me.PanelExamenes.Size = New System.Drawing.Size(595, 339)
        Me.PanelExamenes.TabIndex = 3
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FrmExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelExamenes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmExamenes"
        Me.Text = "FrmExamenes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelExamenes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnExamenOrina As Button
    Friend WithEvents BtnExamenSangre As Button
    Friend WithEvents PanelExamenes As Panel
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
