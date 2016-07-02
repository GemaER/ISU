Public Class frmModificar

    Private Sub frmModificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbxLeche.Enabled = False
        gbxBasico.Enabled = False
        gbxHembra.Enabled = False
        btnGenealogia.Enabled = False
        btnModificar.Enabled = False
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Modify"
            lblNumero.Text() = "Numer"
        ElseIf frmISU.tsModificar.Text = "Mudança" = True Then
            Me.Text() = "Mudança"
        End If
        btnModificar.Hide()
        frmISU.Idioma_Load(frmISU.tsModificar, lblSexo, lblNacimiento, lblLugar, lblRaza, lblUrea, lblDivision, lblAntibiotico, lblPorcentajep, lblPrenada, lblEtapa, lblLitros, lblGrasa, lblProteina, lblRecuentobac, lblRecuentoCel, btnGenealogia)
    End Sub


    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = frmISU.Acumulacion(tbxNum.Text(), acum)
        acum = frmISU.Largo(tbxNum, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            'encuentra muestra y guarda
            gbxBasico.Enabled = True
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim validacion As Boolean
        validacion = frmISU.Validacion_Entera(tbxLitros, tbxRecuentobac, tbxRecuentocel, tbxPorcentajep, tbxGrasa, tbxProteina, tbxUrea)
        validacion = frmISU.Largo_dos(tbxDd, tbxMm, validacion)
        validacion = frmISU.Largo_cuatro(tbxAaaa, validacion)
        If validacion Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            'compara los resultados guardados con los actuales
        End If

    End Sub

    Private Sub cbxSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        frmISU.Sexo_cambio(cbxLugar, cbxSexo, lblDivision, gbxHembra, gbxLeche, cbxDivision, rbnSia, rbnSip)
    End Sub

    Private Sub cbxRaza_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        frmISU.Sexo_cambio(cbxLugar, cbxSexo, lblDivision, gbxHembra, gbxLeche, cbxDivision, rbnSia, rbnSip)
    End Sub

    Private Sub btnGenealogia_Click(sender As System.Object, e As System.EventArgs) Handles btnGenealogia.Click
        frmGenealogia.Show()
    End Sub
End Class