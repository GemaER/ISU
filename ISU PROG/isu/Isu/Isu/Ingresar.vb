Public Class frmIngresar

    Private Sub frmIngresar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDivision.Hide()
        cbxDivision.Hide()
        gbxLeche.Enabled = False
        gbxBasico.Enabled = False
        gbxHembra.Enabled = False
        btnGenealogia.Enabled = False
        btnIngresar.Enabled = False
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Insert"
            lblNumero.Text() = "Numer"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            Me.Text() = "Depósito"
        End If
        btnIngresar.Enabled = False
        frmISU.Idioma_Load(frmISU.tsModificar, lblSexo, lblNacimiento, lblLugar, lblRaza, lblUrea, lblDivision, lblAntibiotico, lblPorcentajep, lblPrenada, lblEtapa, lblLitros, lblGrasa, lblProteina, lblRecuentobac, lblRecuentoCel, btnGenealogia)
        frmISU.Sexo_cambio(cbxLugar, cbxSexo, lblDivision, gbxHembra, gbxLeche, cbxDivision, rbnSia, rbnSip)
    End Sub

    Private Sub cbxSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSexo.SelectedIndexChanged
        frmISU.Sexo_cambio(cbxLugar, cbxSexo, lblDivision, gbxHembra, gbxLeche, cbxDivision, rbnSia, rbnSip)
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        Dim validacion As Integer
        validacion = frmISU.Validacion_Entera(tbxLitros, tbxRecuentobac, tbxRecuentocel, tbxPorcentajep, tbxGrasa, tbxProteina, tbxUrea)
        validacion = frmISU.Largo_dos(tbxDd, tbxMm, validacion)
        validacion = frmISU.Largo_cuatro(tbxAaaa, validacion)
        If validacion = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
  
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = frmISU.Acumulacion(tbxNum.Text(), acum)
        acum = frmISU.Largo(tbxNum, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            btnIngresar.Enabled = True
            btnGenealogia.Enabled = True
            gbxBasico.Enabled = True
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnGenealogia_Click(sender As System.Object, e As System.EventArgs) Handles btnGenealogia.Click
        frmGenealogia.Show()
    End Sub



    Private Sub rbnSip_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbnSip.CheckedChanged
        gbxPrenadaS.Enabled = True
    End Sub
End Class