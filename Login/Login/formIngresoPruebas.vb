Public Class formIngresoPruebas
    Dim arreglo(100, 10) As String
    Dim contadorArreglo As Integer = 0
    Dim indice As String
    Private Sub ComboBSelectDepa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBSelectDepa.SelectedIndexChanged
        indice = ComboBSelectDepa.SelectedItem.ToString
        Dim positivo, negativo, recuperado, activo, muerto As Integer

        For s As Integer = 0 To 99 Step 1
            If arreglo(s, 4) = "1" And indice = arreglo(s, 2) Then
                positivo = positivo + 1
            End If
            If arreglo(s, 5) = "1" And indice = arreglo(s, 2) Then
                negativo += 1
            End If
            If arreglo(s, 6) = "1" And indice = arreglo(s, 2) Then
                recuperado += 1
            End If
            If arreglo(s, 7) = "1" And indice = arreglo(s, 2) Then
                activo += 1
            End If
            If arreglo(s, 8) = "1" And indice = arreglo(s, 2) Then
                muerto += 1
            End If
        Next

        TextBoxPOSITIVOS.Text = positivo
        TextBoxNEGATIVOS.Text = negativo
        TextBoxMUERTOS.Text = muerto
        TextBoxACTIVOS.Text = activo
        TextBoxRECUPERADOS.Text = recuperado
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If ComboBoxDEPA.SelectedIndex = 0 Then
                proceso()
            End If

            If ComboBoxDEPA.SelectedIndex = 1 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 2 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 3 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 4 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 5 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 6 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 7 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 8 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 9 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 10 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 11 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 12 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 13 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 14 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 15 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 16 Then
                proceso()
            End If
            If ComboBoxDEPA.SelectedIndex = 17 Then
                proceso()

            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub formIngresoPruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub proceso()
        arreglo(contadorArreglo, 0) = TextBoxNOMBRE.Text
        arreglo(contadorArreglo, 1) = TextBoxEDAD.Text
        arreglo(contadorArreglo, 2) = ComboBoxDEPA.SelectedItem.ToString
        arreglo(contadorArreglo, 3) = TextBoxMUNI.Text
        TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & arreglo(contadorArreglo, 0) & " " & arreglo(contadorArreglo, 1) & " " & arreglo(contadorArreglo, 2) & " " & arreglo(contadorArreglo, 3)

        If CheckBoxPOSI.Checked Then
            arreglo(contadorArreglo, 4) = "1"
            TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & " " & "POSITIVO"
        ElseIf CheckBoxNEGA.Checked Then
            arreglo(contadorArreglo, 5) = "1"
            TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & " " & "NEGATIVO"
        ElseIf CheckBoxRECUPERADO.Checked Then
            arreglo(contadorArreglo, 6) = "1"
            TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & " " & "RECUPERADOS"
        ElseIf CheckBoxACTIVO.Checked Then
            arreglo(contadorArreglo, 7) = "1"
            TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & " " & "ACTIVO"
        ElseIf CheckBoxMUERTO.Checked Then
            arreglo(contadorArreglo, 8) = "1"
            TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & " " & "MUERTO"

        End If
        arreglo(contadorArreglo, 9) = TextBoxDESCRIP.Text
        TextBoxHISTORIAL.Text = TextBoxHISTORIAL.Text & vbCrLf
        ComboBoxDEPA.SelectedIndex = 0
        CheckBoxACTIVO.Checked = False
        CheckBoxMUERTO.Checked = False
        CheckBoxNEGA.Checked = False
        CheckBoxPOSI.Checked = False
        CheckBoxRECUPERADO.Checked = False

        TextBoxNOMBRE.Text = ""
        TextBoxEDAD.Text = ""
        TextBoxMUNI.Text = ""
        TextBoxDESCRIP.Text = ""
        contadorArreglo = contadorArreglo + 1

    End Sub

    Private Sub TextBoxEDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEDAD.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class

