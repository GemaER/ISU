Public Class frmOrdeñeConfig

    Private Sub frmOrdeñeConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbxCantidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxCantidad.SelectedIndexChanged
        If cbxCantidad.Text = "1" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = False
            gbxTercer.Enabled = False
        ElseIf cbxCantidad.Text = "2" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
            gbxTercer.Enabled = False
        ElseIf cbxCantidad.Text = "3" Then
            gbxPrimer.Enabled = True
            gbxSegundo.Enabled = True
            gbxTercer.Enabled = True
        End If
    End Sub
End Class