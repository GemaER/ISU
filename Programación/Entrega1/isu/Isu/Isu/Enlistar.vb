Public Class frmEnlistar
    Private Sub frmEnlistar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Show"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            Me.Text() = "Alistar"
        End If
        MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
    End Sub

End Class