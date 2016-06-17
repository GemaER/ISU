Public Class frmIngresar

    Private Sub frmIngresar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblAnestro.Hide()
        cbxAnestrom.Hide()
        cbxAnestroh.Hide()
        If frmISU.tsModificar.Text() = "Modify" Then
            Me.Text() = "Insert"
        ElseIf frmISU.tsModificar.Text() = "Modificar" Then
            Me.Text() = "Ingresar"
        Else
            Me.Text() = "Depósito"
        End If
    End Sub

    Private Sub cbxSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSexo.SelectedIndexChanged
        lblAnestro.Show()
        If cbxSexo.Text() = "Hembra" Then
            gbxHembra.Show()
            gbxLeche.Show()
            cbxAnestroh.Show()
            cbxAnestrom.Hide()
        ElseIf cbxSexo.Text() = "Macho" Then
            gbxHembra.Hide()
            gbxLeche.Hide()
            cbxAnestrom.Show()
            cbxAnestroh.Hide()
        End If
    End Sub
End Class