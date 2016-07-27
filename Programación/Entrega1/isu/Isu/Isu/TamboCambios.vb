Public Class frmTamboCambios


    Private Sub Tamboa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnBuscar.Text() = frmISU.buscar
        btnIngresar.Text() = frmISU.tsIngresar.Text()
        btnModificar.Text() = frmISU.tsModificar.Text()
        If frmISU.tsModificar.Text() = "Modify" Then
            gbxPrimer.Text() = "Fist"
            gbxSegundo.Text() = "Second"
            gbxTercer.Text() = "Third"
            lblIniciot.Text() = "Start time"
            lblInicios.Text() = "Start time"
            lblIniciop.Text() = lblInicios.Text()
            lblFinalp.Text() = "final hour"
            lblFinals.Text() = "final hour"
            lblFinalt.Text() = "final hour"
            lblOrdeñet.Text() = "type of milking"
            lblHectareas.Text() = "Hectares"
            lblGanado.Text() = "Total cattle"
            lblExplotaciones.Text() = "Farms"
            lblOrdeñecant.Text() = "number of milking"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            gbxPrimer.Text() = "Primeiro"
            gbxTercer.Text() = "Terceiro"
            lblFinalp.Text() = "Final hour"
            lblFinals.Text() = "Final hour"
            lblFinalt.Text() = "Final hour"
            lblOrdeñet.Text() = "Tipo de ordenha"
            lblHectareas.Text() = "Hectares"
            lblGanado.Text() = "Total dde ganho"
            lblExplotaciones.Text() = "Exploraçao"
            lblOrdeñecant.Text() = "quantidade de ordenhas"
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        gbxDatos.Enabled = True
        btnModificar.Enabled = True
        btnIngresar.Enabled = True
    End Sub

    Private Sub cbxCantidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxCantidad.SelectedIndexChanged
        gbxPrimer.Enabled = False
        gbxSegundo.Enabled = False
        gbxTercer.Enabled = False
        If cbxCantidad.Text() = "1" Then
            gbxPrimer.Enabled = True
        ElseIf cbxCantidad.Text() = "2" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
        ElseIf cbxCantidad.Text() = "3" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
            gbxTercer.Enabled = True
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        Dim acum As Integer
        acum = frmISU.Acumulacion(tbxExploaciones.Text(), acum)
        acum = frmISU.Acumulacion(tbxHectareas.Text(), acum)
        acum = frmISU.Acumulacion(tbxGanado.Text(), acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim acum As Integer
        acum = frmISU.Acumulacion(tbxExploaciones.Text(), acum)
        acum = frmISU.Acumulacion(tbxHectareas.Text(), acum)
        acum = frmISU.Acumulacion(tbxGanado.Text(), acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class