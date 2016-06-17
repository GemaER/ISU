Public Class frmEliminar

    Private Sub frmEliminar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Delete"
        ElseIf frmISU.mspEspanol.Visible = True Then
            Me.Text() = "Eliminar"
        Else
            Me.Text() = "Remover"
        End If
    End Sub
End Class