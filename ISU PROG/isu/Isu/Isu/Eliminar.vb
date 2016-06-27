Public Class frmEliminar

    Private Sub frmEliminar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Insert"
            lblNumero.Text() = "Numer"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            Me.Text() = "Remover"
        End If
        btnEliminar.Hide()
        frmISU.Idioma_Load(frmISU.tsModificar, lblSexo, lblNacimiento, lblLugar, lblRaza, lblUrea, lblDivision, lblAntibiotico, lblPorcentajep, lblPrenada, lblEtapa, lblLitros, lblGrasa, lblProteina, lblRecuentobac, lblRecuentoCel)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = frmISU.Acumulacion(tbxNum.Text(), acum)
        acum = frmISU.Largo(tbxNum, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            frmISU.lblAprecer(lblNacimiento, lblSexo, lblLugar, lblRaza, lblDivision, btnEliminar)
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
    End Sub
End Class