Public Class frmConsultar

    Private Sub frmConsultar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Consult"
        Else
            Me.Text() = "Consultar"
        End If
    End Sub
End Class