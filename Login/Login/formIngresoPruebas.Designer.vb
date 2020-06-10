<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formIngresoPruebas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxNOMBRE = New System.Windows.Forms.TextBox()
        Me.TextBoxEDAD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxPOSI = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNEGA = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDESCRIP = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.ComboBoxDEPA = New System.Windows.Forms.ComboBox()
        Me.TextBoxMUNI = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBSelectDepa = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxPOSITIVOS = New System.Windows.Forms.TextBox()
        Me.TextBoxRECUPERADOS = New System.Windows.Forms.TextBox()
        Me.TextBoxACTIVOS = New System.Windows.Forms.TextBox()
        Me.TextBoxMUERTOS = New System.Windows.Forms.TextBox()
        Me.TextBoxNEGATIVOS = New System.Windows.Forms.TextBox()
        Me.CheckBoxACTIVO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRECUPERADO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMUERTO = New System.Windows.Forms.CheckBox()
        Me.TextBoxHISTORIAL = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonSALIR = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNOMBRE
        '
        Me.TextBoxNOMBRE.Location = New System.Drawing.Point(142, 54)
        Me.TextBoxNOMBRE.Name = "TextBoxNOMBRE"
        Me.TextBoxNOMBRE.Size = New System.Drawing.Size(207, 20)
        Me.TextBoxNOMBRE.TabIndex = 0
        '
        'TextBoxEDAD
        '
        Me.TextBoxEDAD.Location = New System.Drawing.Point(142, 80)
        Me.TextBoxEDAD.Name = "TextBoxEDAD"
        Me.TextBoxEDAD.Size = New System.Drawing.Size(207, 20)
        Me.TextBoxEDAD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "EDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DEPARTAMENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MUNICIPIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "RESULTADO PRUEBA"
        '
        'CheckBoxPOSI
        '
        Me.CheckBoxPOSI.AutoSize = True
        Me.CheckBoxPOSI.Location = New System.Drawing.Point(162, 176)
        Me.CheckBoxPOSI.Name = "CheckBoxPOSI"
        Me.CheckBoxPOSI.Size = New System.Drawing.Size(76, 17)
        Me.CheckBoxPOSI.TabIndex = 10
        Me.CheckBoxPOSI.Text = "POSITIVO"
        Me.CheckBoxPOSI.UseVisualStyleBackColor = True
        '
        'CheckBoxNEGA
        '
        Me.CheckBoxNEGA.AutoSize = True
        Me.CheckBoxNEGA.Location = New System.Drawing.Point(268, 175)
        Me.CheckBoxNEGA.Name = "CheckBoxNEGA"
        Me.CheckBoxNEGA.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxNEGA.TabIndex = 11
        Me.CheckBoxNEGA.Text = "NEGATIVO"
        Me.CheckBoxNEGA.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DESCRIPCION"
        '
        'TextBoxDESCRIP
        '
        Me.TextBoxDESCRIP.Location = New System.Drawing.Point(142, 226)
        Me.TextBoxDESCRIP.Multiline = True
        Me.TextBoxDESCRIP.Name = "TextBoxDESCRIP"
        Me.TextBoxDESCRIP.Size = New System.Drawing.Size(207, 79)
        Me.TextBoxDESCRIP.TabIndex = 13
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(171, 333)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(91, 46)
        Me.btnIngresar.TabIndex = 14
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'ComboBoxDEPA
        '
        Me.ComboBoxDEPA.FormattingEnabled = True
        Me.ComboBoxDEPA.Items.AddRange(New Object() {"ATLANTIDA", "CHOLUTECA", "COMAYAGUA", "CORTES", "GRACIAS A DIOS", "INTIBUCA", "ISLAS DE LA BAHIA", "LA PAZ", "FRANCISCO MORAZAN", "COPAN", "COLON", "EL PARAISO", "LEMPIRA", "SANTA BARBARA", "VALLE", "YORO", "OLANCHO", "OCOTEPEQUE"})
        Me.ComboBoxDEPA.Location = New System.Drawing.Point(142, 106)
        Me.ComboBoxDEPA.Name = "ComboBoxDEPA"
        Me.ComboBoxDEPA.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDEPA.TabIndex = 17
        '
        'TextBoxMUNI
        '
        Me.TextBoxMUNI.Location = New System.Drawing.Point(142, 135)
        Me.TextBoxMUNI.Name = "TextBoxMUNI"
        Me.TextBoxMUNI.Size = New System.Drawing.Size(207, 20)
        Me.TextBoxMUNI.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "SELECCIONE DEPARTAMENTO"
        '
        'ComboBSelectDepa
        '
        Me.ComboBSelectDepa.FormattingEnabled = True
        Me.ComboBSelectDepa.Items.AddRange(New Object() {"ATLANTIDA", "CHOLUTECA", "COMAYAGUA", "CORTES", "GRACIAS A DIOS", "INTIBUCA", "ISLAS DE LA BAHIA", "LA PAZ", "FRANCISCO MORAZAN", "COPAN", "COLON", "EL PARAISO", "LEMPIRA", "SANTA BARBARA", "VALLE", "YORO", "OLANCHO", "OCOTEPEQUE"})
        Me.ComboBSelectDepa.Location = New System.Drawing.Point(607, 271)
        Me.ComboBSelectDepa.Name = "ComboBSelectDepa"
        Me.ComboBSelectDepa.Size = New System.Drawing.Size(121, 21)
        Me.ComboBSelectDepa.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(434, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "POSITIVOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "RECUPERADOS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(434, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "ACTIVOS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(434, 401)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "MUERTOS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(434, 428)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "NEGATIVOS"
        '
        'TextBoxPOSITIVOS
        '
        Me.TextBoxPOSITIVOS.Location = New System.Drawing.Point(550, 316)
        Me.TextBoxPOSITIVOS.Name = "TextBoxPOSITIVOS"
        Me.TextBoxPOSITIVOS.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxPOSITIVOS.TabIndex = 26
        '
        'TextBoxRECUPERADOS
        '
        Me.TextBoxRECUPERADOS.Location = New System.Drawing.Point(550, 342)
        Me.TextBoxRECUPERADOS.Name = "TextBoxRECUPERADOS"
        Me.TextBoxRECUPERADOS.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxRECUPERADOS.TabIndex = 27
        '
        'TextBoxACTIVOS
        '
        Me.TextBoxACTIVOS.Location = New System.Drawing.Point(550, 375)
        Me.TextBoxACTIVOS.Name = "TextBoxACTIVOS"
        Me.TextBoxACTIVOS.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxACTIVOS.TabIndex = 28
        '
        'TextBoxMUERTOS
        '
        Me.TextBoxMUERTOS.Location = New System.Drawing.Point(550, 401)
        Me.TextBoxMUERTOS.Name = "TextBoxMUERTOS"
        Me.TextBoxMUERTOS.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxMUERTOS.TabIndex = 29
        '
        'TextBoxNEGATIVOS
        '
        Me.TextBoxNEGATIVOS.Location = New System.Drawing.Point(550, 428)
        Me.TextBoxNEGATIVOS.Name = "TextBoxNEGATIVOS"
        Me.TextBoxNEGATIVOS.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxNEGATIVOS.TabIndex = 30
        '
        'CheckBoxACTIVO
        '
        Me.CheckBoxACTIVO.AutoSize = True
        Me.CheckBoxACTIVO.Location = New System.Drawing.Point(197, 198)
        Me.CheckBoxACTIVO.Name = "CheckBoxACTIVO"
        Me.CheckBoxACTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CheckBoxACTIVO.TabIndex = 31
        Me.CheckBoxACTIVO.Text = "ACTIVO"
        Me.CheckBoxACTIVO.UseVisualStyleBackColor = True
        '
        'CheckBoxRECUPERADO
        '
        Me.CheckBoxRECUPERADO.AutoSize = True
        Me.CheckBoxRECUPERADO.Location = New System.Drawing.Point(83, 198)
        Me.CheckBoxRECUPERADO.Name = "CheckBoxRECUPERADO"
        Me.CheckBoxRECUPERADO.Size = New System.Drawing.Size(108, 17)
        Me.CheckBoxRECUPERADO.TabIndex = 32
        Me.CheckBoxRECUPERADO.Text = "RECUPERADOS"
        Me.CheckBoxRECUPERADO.UseVisualStyleBackColor = True
        '
        'CheckBoxMUERTO
        '
        Me.CheckBoxMUERTO.AutoSize = True
        Me.CheckBoxMUERTO.Location = New System.Drawing.Point(268, 198)
        Me.CheckBoxMUERTO.Name = "CheckBoxMUERTO"
        Me.CheckBoxMUERTO.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxMUERTO.TabIndex = 33
        Me.CheckBoxMUERTO.Text = "MUERTO"
        Me.CheckBoxMUERTO.UseVisualStyleBackColor = True
        '
        'TextBoxHISTORIAL
        '
        Me.TextBoxHISTORIAL.Location = New System.Drawing.Point(437, 54)
        Me.TextBoxHISTORIAL.Multiline = True
        Me.TextBoxHISTORIAL.Name = "TextBoxHISTORIAL"
        Me.TextBoxHISTORIAL.Size = New System.Drawing.Size(291, 201)
        Me.TextBoxHISTORIAL.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(441, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "HISTORIAL"
        '
        'ButtonSALIR
        '
        Me.ButtonSALIR.Location = New System.Drawing.Point(268, 333)
        Me.ButtonSALIR.Name = "ButtonSALIR"
        Me.ButtonSALIR.Size = New System.Drawing.Size(86, 46)
        Me.ButtonSALIR.TabIndex = 36
        Me.ButtonSALIR.Text = "SALIR"
        Me.ButtonSALIR.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'formIngresoPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSALIR)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBoxHISTORIAL)
        Me.Controls.Add(Me.CheckBoxMUERTO)
        Me.Controls.Add(Me.CheckBoxRECUPERADO)
        Me.Controls.Add(Me.CheckBoxACTIVO)
        Me.Controls.Add(Me.TextBoxNEGATIVOS)
        Me.Controls.Add(Me.TextBoxMUERTOS)
        Me.Controls.Add(Me.TextBoxACTIVOS)
        Me.Controls.Add(Me.TextBoxRECUPERADOS)
        Me.Controls.Add(Me.TextBoxPOSITIVOS)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBSelectDepa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxMUNI)
        Me.Controls.Add(Me.ComboBoxDEPA)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.TextBoxDESCRIP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBoxNEGA)
        Me.Controls.Add(Me.CheckBoxPOSI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEDAD)
        Me.Controls.Add(Me.TextBoxNOMBRE)
        Me.Name = "formIngresoPruebas"
        Me.Text = "formIngresoPruebas"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNOMBRE As TextBox
    Friend WithEvents TextBoxEDAD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBoxPOSI As CheckBox
    Friend WithEvents CheckBoxNEGA As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDESCRIP As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents ComboBoxDEPA As ComboBox
    Friend WithEvents TextBoxMUNI As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBSelectDepa As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxPOSITIVOS As TextBox
    Friend WithEvents TextBoxRECUPERADOS As TextBox
    Friend WithEvents TextBoxACTIVOS As TextBox
    Friend WithEvents TextBoxMUERTOS As TextBox
    Friend WithEvents TextBoxNEGATIVOS As TextBox
    Friend WithEvents CheckBoxACTIVO As CheckBox
    Friend WithEvents CheckBoxRECUPERADO As CheckBox
    Friend WithEvents CheckBoxMUERTO As CheckBox
    Friend WithEvents TextBoxHISTORIAL As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonSALIR As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
