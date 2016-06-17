Public Class frmEliminar

    Private Sub frmEliminar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Delete"
            lblNumero.Text() = "Numer"
            lblSexo.Text() = "Gender"
            lblEdad.Text() = "Age"
            lblLugar.Text() = "Actual Place"
            lblRaza.Text() = "Race"
            lblAntibiotico.Text() = "Influential antibiotic"
            lblPorcentajep.Text() = "Pregnancy rate"
            lblPrenada.Text() = "Pregnant"
            lblEtapa.Text() = "Stage"
            lblLitros.Text() = "Liters"
            lblGrasa.Text() = "Grease"
            lblProteina.Text() = "Protein"
            lblRecuentobac.Text() = "Bacterial count"
            lblRecuentoCel.Text() = "Somatic cell count"
        ElseIf frmISU.tsModificar.Text() = "Mundaça" Then
            lblEdad.Text() = "Idade"
            lblRaza.Text() = "Raça"
            lblDivision.Text() = "Divisão"
            lblAntibiotico.Text() = "antibiótico influente"
            lblPorcentajep.Text() = "Taxa de prenhez"
            lblPrenada.Text() = "Grávida"
            lblGrasa.Text() = "Graxa"
            lblUrea.Text() = "Uréia"
            lblRecuentobac.Text() = "Contagem bacteriana"
            lblRecuentoCel.Text() = "Contagem de células somáticas"
            Me.Text() = "Remover"
        End If
    End Sub

End Class