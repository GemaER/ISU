Public Class frmTamboConsultar

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cbxTambo.Text() = "Ejemplo1" Then
            gbxDatos.Enabled = True
        End If

    End Sub

    Private Sub frmTamboConsultar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnBuscar.Text() = frmISU.buscar
        If frmISU.tsModificar.Text() = "Modify" Then
            lblPreñez.Text() = "pregnancy rate"
            lblParicion.Text() = "lambing"
            lblReposicion.Text() = "replacement percentage"
            lblExplotaciones.Text() = "Farms"
            lblProducciont.Text() = "Total production"
            lblPromedio.Text() = "average exploitation"
            lblProducciona.Text() = "annual production"
            lblProducciond.Text() = "dairy produce"
            lblOrdeñev.Text() = "milking cows"
            lblGanadovacas.Text() = "number of cows"
            lblGanadoToros.Text() = "number of bulls"
            lblGanado.Text() = "Total cattle"
            lblOrdeñet.Text() = "type of milking"
            lblHectareas.Text() = "Hectares"
            lblOrdeñecant.Text() = "number of milking"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            lblPreñez.Text() = "Taza de gravidez"
            lblParicion.Text() = "Porcentual de partos"
            lblReposicion.Text() = "Porcentual fora"
            lblExplotaciones.Text() = "Fazendas"
            lblProducciont.Text() = "Produçao total"
            lblPromedio.Text() = "Média de funcionamiento"
            lblProducciona.Text() = "Produçao anual"
            lblProducciond.Text() = "Produçao diária"
            lblOrdeñev.Text() = "Vacas leiteiras"
            lblGanadovacas.Text() = "numero de vacas"
            lblGanadoToros.Text() = "numero de touros"
            lblGanado.Text() = "Total de gado"
            lblOrdeñet.Text() = "tipo de ordenha"
            lblHectareas.Text() = "Hectares"
            lblOrdeñecant.Text() = "quantidade de ordenhas"
        End If
    End Sub

End Class