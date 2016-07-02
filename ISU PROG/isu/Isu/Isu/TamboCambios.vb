Public Class frmTamboCambios


    Private Sub Tamboa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        gbxPrimer.Show()
        gbxSegundo.Show()
        gbxTercer.Show()
        gbxDatos.Show()
    End Sub

    Private Sub cbxCantidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxCantidad.SelectedIndexChanged
        If cbxCantidad.Text() = "Uno" Then
            gbxPrimer.Enabled = True
        ElseIf cbxCantidad.Text() = "Dos" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
        ElseIf cbxCantidad.Text() = "Tres" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
            gbxTercer.Enabled = True
        End If
    End Sub
End Class