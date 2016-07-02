Public Class frmEliminar

    Private Sub frmEliminar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbxLeche.Enabled = False
        gbxBasico.Enabled = False
        gbxHembra.Enabled = False
        btnGenealogia.Enabled = False
        btnEliminar.Enabled = False
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Insert"
            lblNumero.Text() = "Numer"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            Me.Text() = "Remover"
        End If
        frmISU.Idioma_Load(frmISU.tsModificar, lblSexo, lblNacimiento, lblLugar, lblRaza, lblUrea, lblDivision, lblAntibiotico, lblPorcentajep, lblPrenada, lblEtapa, lblLitros, lblGrasa, lblProteina, lblRecuentobac, lblRecuentoCel, btnGenealogia)
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