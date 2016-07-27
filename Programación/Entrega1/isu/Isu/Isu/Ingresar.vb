Public Class frmIngresar

    Private Sub frmIngresar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text() = frmISU.tsIngresar.Text()
        btnIngresar.Text() = Me.Text()
        btnGenealogia.Text() = frmISU.gen
        btnBuscar.Text() = frmISU.buscar
        frmISU.Idioma_Lugar(cbxLugar)
        frmISU.Etapa_Idioma(cbxEtapa)
        frmISU.Idioma_Division(cbxSexo, rbnSia, rbnSip, rbnNoa, rbnNop)
        frmISU.Idioma_Load(frmISU.tsModificar, lblNumero, lblSexo, lblNacimiento, lblLugar, lblRaza, lblUrea, lblDivision, lblAntibiotico, lblPorcentajep, lblPrenada, lblEtapa, lblLitros, lblGrasa, lblProteina, lblRecuentobac, lblRecuentoCel, btnGenealogia, lblFechaP, lblRecriaIda, lblRecriavuelta)
        frmISU.Sexo_Cambio(cbxSexo, lblDivision, gbxHembra, gbxLeche, cbxDivision)
    End Sub

    Private Sub cbxSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSexo.SelectedIndexChanged
        frmISU.Sexo_Cambio(cbxSexo, lblDivision, gbxHembra, gbxLeche, cbxDivision)
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        Dim validacion As Integer
        If cbxRaza.Text() = frmISU.hembra Then
            validacion = frmISU.Validacion_Entera(tbxLitros, tbxRecuentobac, tbxRecuentocel, tbxPorcentajep, tbxGrasa, tbxProteina, tbxUrea)
        End If
        validacion = frmISU.Largo_dos(tbxDd, tbxMm, validacion)
        validacion = frmISU.Largo_cuatro(tbxAaaa, validacion)

        If lblFechaP.Enabled = True Then
            validacion = frmISU.Largo_dos(tbxddP, tbxmmp, validacion)
            validacion = frmISU.Largo_cuatro(tbxaaaap, validacion)
        End If
        If lblRecriaIda.Enabled = True Then
            validacion = frmISU.Largo_dos(tbxddri, tbxmmri, validacion)
            validacion = frmISU.Largo_dos(tbxddrv, tbxmmrv, validacion)
            validacion = frmISU.Largo_cuatro(tbxaaaaRI, validacion)
            validacion = frmISU.Largo_cuatro(tbxaaaarv, validacion)
            validacion = frmISU.Fechas(tbxddri, tbxddrv, tbxmmri, tbxmmrv, tbxaaaaRI, tbxaaaarv, validacion)
        End If
        If validacion = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
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
        tbxddP.Enabled = True
        tbxmmp.Enabled = True
        tbxaaaap.Enabled = True
        lblFechaP.Enabled = True
    End Sub


    Private Sub cbxLugar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxLugar.SelectedIndexChanged
        If cbxLugar.Text() = frmISU.campo Then
            lblRecriaIda.Enabled = True
            lblRecriavuelta.Enabled = True
            tbxddri.Enabled = True
            tbxmmri.Enabled = True
            tbxaaaaRI.Enabled = True
            tbxddrv.Enabled = True
            tbxmmrv.Enabled = True
            tbxaaaarv.Enabled = True
        End If
    End Sub
End Class