Public Class frmAlimento

    Private Sub frmAlimento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If opcion = 1 Then
            Me.Text = "Venta"
            gbxDatos.Text = ""
            lblTipo.Hide()
            cbxTipo.Hide()
        End If
    End Sub
End Class