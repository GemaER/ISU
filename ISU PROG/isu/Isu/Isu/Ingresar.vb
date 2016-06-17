Public Class frmIngresar

    Private Sub frmIngresar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDivision.Hide()
        cbxDivisionm.Hide()
        cbxDivisionh.Hide()
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Insert"
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

        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            Me.Text() = "Depósito"
            lblEdad.Text() = "Idade"
            lblRaza.Text() = "Raça"
            lblDivision.Text() = "Divisão"
            lblAntibiotico.Text() = "antibiótico influente"
            lblPorcentajep.Text() = "Taxa de prenhez"
            lblPrenada.Text() = "Grávida"
            lblGrasa.Text() = "Graxa"
            lblUrea.Text() = "Uréia"
            lblRecuentobac.Text() = "Contagem bacteriana"
            lblRecuentoCel.Text() = "Contagem de células somáticas" 'como agregar renglón
        End If
    End Sub

    Private Sub cbxSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSexo.SelectedIndexChanged
        lblDivision.Show()
        If cbxSexo.Text() = "Hembra" Then
            gbxHembra.Show()
            gbxLeche.Show()
            cbxDivisionh.Show()
            cbxDivisionm.Hide()
        ElseIf cbxSexo.Text() = "Macho" Then
            gbxHembra.Hide()
            gbxLeche.Hide()
            cbxDivisionm.Show()
            cbxDivisionh.Hide()
        End If
    End Sub


    Function Acumulacion(ByVal valor As String, acumf As Integer) As Integer
        Dim acum As Integer
        acum = acumf
        If IsNumeric(valor) Then
            acum = acum + 1
        End If
        Return acum
    End Function
    Function Porcentaje(ByVal valor As String, acumf As Integer) As Boolean
        Dim retorno As Boolean
        retorno = False
        If IsNumeric(valor) Then
            If valor <= 100 Then
                retorno = True
            End If
        End If
        Return retorno
    End Function


    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        Dim acum As Integer
        acum = 0
        acum = Acumulacion(tbxNum.Text, acum)
        acum = Acumulacion(tbxEdad.Text, acum)
        acum = Acumulacion(tbxPorcentajep.Text, acum)
        acum = Acumulacion(tbxLitros.Text, acum)
        acum = Acumulacion(tbxGrasa.Text, acum)
        acum = Acumulacion(tbxProteina.Text, acum)
        acum = Acumulacion(tbxUrea.Text, acum)
        acum = Acumulacion(tbxRecuentobac.Text, acum)
        acum = Acumulacion(tbxRecuentocel.Text, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class