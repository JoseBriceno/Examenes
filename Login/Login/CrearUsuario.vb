Public Class CrearUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxUsuario.Text = "administrador" And TextBoxContra.Text = "sinhacer2020" Then
            formIngresoPruebas.Show()
            Me.Hide()
        ElseIf TextBoxUsuario.Text <> "administrador" Then
            MessageBox.Show("ERROR EN USUARIO")
        ElseIf TextBoxContra.Text <> "sinhacer2020" Then
            MessageBox.Show("ERROR EN CONTRASEÑA")
        ElseIf TextBoxUsuario.Text = "" And TextBoxContra.Text = "" Then
            MessageBox.Show("CAMPOS VACIOS")
        End If

    End Sub
End Class