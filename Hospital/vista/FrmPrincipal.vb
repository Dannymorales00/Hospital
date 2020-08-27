Public Class FrmPrincipal
    Private usuario As Usuario
    Private frmUsuario As FrmUsuario
    Private frmCitas As FrmCita
    Private frmPaciente As FrmPaciente
    Private frmExamenes As FrmExamenes
    Private frmReportes As FrmReportes

    Public Sub New(usuario1 As Usuario)
        usuario = New Usuario()
        frmUsuario = New FrmUsuario()
        frmCitas = New FrmCita()
        frmPaciente = New FrmPaciente()
        frmExamenes = New FrmExamenes()
        frmReportes = New FrmReportes()
        usuario = usuario1
        InitializeComponent()

    End Sub



    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Centrar(Me.PanelModulos)
        Me.MenuPerfilNombreUSuario.Text = "Username: " + usuario.nombreUsuario
        Me.MenuPerfilTipo.Text = "Tipo: " + usuario.tipo

    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        If usuario.tipo.Equals("Admin") Then
            frmUsuario.Show()
        Else
            MessageBox.Show("No tienes permiso para este modulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub BtnCitas_Click(sender As Object, e As EventArgs) Handles BtnCitas.Click
        If usuario.tipo.Equals("Secretaria") Or usuario.tipo.Equals("Admin") Then
            frmCitas.Show()
        Else
            MessageBox.Show("No tienes permiso para este modulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            'Me.Close()
            Application.ExitThread()
        End If
    End Sub
    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        If usuario.tipo.Equals("Secretaria") Or usuario.tipo.Equals("Admin") Then
            frmPaciente.Show()
        Else
            MessageBox.Show("No tienes permiso para este modulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If




    End Sub

    Private Sub BtnExamenes_Click(sender As Object, e As EventArgs) Handles BtnExamenes.Click
        If usuario.tipo.Equals("Medico") Or usuario.tipo.Equals("Admin") Then
            frmExamenes.Show()
        Else
            MessageBox.Show("No tienes permiso para este modulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If



    End Sub

    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click

    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click

        If usuario.tipo.Equals("Medico") Or usuario.tipo.Equals("Secretaria") Then
            frmReportes.Show()
        Else
            MessageBox.Show("No tienes permiso para este modulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If





    End Sub
End Class