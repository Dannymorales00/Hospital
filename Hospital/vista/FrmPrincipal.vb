Public Class FrmPrincipal
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Dim frmUsuarios = New FrmUsuario()
        frmUsuarios.Show()


    End Sub


    Private Sub FrmPrincipal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("Si cierra la aplicacion puede que no se guarden algunos cambios, realmente desea salir?", MsgBoxStyle.YesNo, "Salir?") = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If

    End Sub


End Class