Public Class FrmPaciente
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using Almacen As New ProyectoEntities1
                Dim result = Almacen.sp_registrar_paciente(504340541, "Jose Alberto Mata Mena", 20, "mata649@hotmail.com", "2000-07-24", 57.0, 1.71, 61098371, "O+").SingleOrDefault

                If result = 1 Then
                    MsgBox("Se inserto correctamente")

                Else
                    MsgBox("No se inserto correctamente")
                End If

            End Using
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class