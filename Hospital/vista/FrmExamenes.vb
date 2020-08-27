Public Class FrmExamenes
    Private frmExamenOrina As FrmExamenOrina
    Private frmExamenSangre As FrmExamenSangre
    Private Sub FrmExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmExamenOrina = New FrmExamenOrina()
        frmExamenSangre = New FrmExamenSangre()
        Centrar(PanelExamenes)

    End Sub

    Private Sub BtnExamenOrina_Click(sender As Object, e As EventArgs) Handles BtnExamenOrina.Click
        frmExamenOrina.ShowDialog()
        Me.Close()

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

    Private Sub BtnExamenSangre_Click(sender As Object, e As EventArgs) Handles BtnExamenSangre.Click
        frmExamenSangre.ShowDialog()
        Me.Close()
    End Sub
End Class