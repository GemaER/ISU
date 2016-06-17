Public Class frmTambo

    Private Sub frmTambo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            lblOrdeñet.Text() = "Type of "
        ElseIf frmISU.tsModificar.Text() = "Modificar" Then
            lblOrdeñet.Text = "Tipo de ordeñe"
        Else
            lblOrdeñet.Text = "akjsdh"
        End If
    End Sub
 
End Class