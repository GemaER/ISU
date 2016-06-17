Public Class frmModificar

    Private Sub frmModificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Modify"
        ElseIf frmISU.mspEspanol.Visible = True Then
            Me.Text() = "Ingresar"
        Else
            Me.Text() = "Mudança"
        End If
    End Sub

    
End Class