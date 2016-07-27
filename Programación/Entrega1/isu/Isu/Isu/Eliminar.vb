Public Class frmEliminar

    Private Sub frmEliminar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text() = frmISU.tsEliminar.Text()
        btnEliminar.Text() = Me.Text()
        btnGenealogia.Text() = frmISU.gen
        btnBuscar.Text() = frmISU.buscar
        frmISU.Idioma_Load(frmISU.tsModificar, lblNumero, lblSexo, lblNacimiento, lblLugar, lblRaza, lblUrea, lblDivision, lblAntibiotico, lblPorcentajep, lblPrenada, lblEtapa, lblLitros, lblGrasa, lblProteina, lblRecuentobac, lblRecuentoCel, btnGenealogia, lblFechaP, lblRecriaIda, lblRecriavuelta)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = frmISU.Acumulacion(tbxNum.Text(), acum)
        acum = frmISU.Largo(tbxNum, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            gbxBasico.Enabled = True
            btnGenealogia.Enabled = False
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
    End Sub

    Private Sub btnGenealogia_Click(sender As System.Object, e As System.EventArgs) Handles btnGenealogia.Click
        frmGenealogia.Show()
    End Sub
End Class