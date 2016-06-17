Public Class frmEnlistar

    Private Sub frmEnlistar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Show"
        ElseIf frmISU.mspEspanol.Visible = True Then
            Me.Text() = "Enlistar"
        Else
            Me.Text() = "Alistar"
        End If
    End Sub
End Class