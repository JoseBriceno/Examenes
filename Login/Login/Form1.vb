Public Class Form1
    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        CrearUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        MessageBox.Show("DEBE CREAR USUARIO PRIMERO")

    End Sub
End Class
