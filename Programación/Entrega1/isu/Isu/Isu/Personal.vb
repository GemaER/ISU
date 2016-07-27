Public Class frmPersonal

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = frmISU.Acumulacion(tbxCI.Text(), acum)
        acum = frmISU.Largo(tbxCI, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            btnIngresar.Enabled = True
            btnModificar.Enabled = True
            gbxDatos.Enabled = True
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If

    End Sub

    Private Sub frmPersonal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmISU.tsModificar.Text() = "Modify" Then
            lblCI.Text() = "Identity Card"
            lblNacimiento.Text() = "Date of birth"
            lblPermisos.Text() = "Permissions"
            lblSexo.Text() = "Gender"
        ElseIf frmISU.tsModificar.Text = "Mudança" Then
            lblCI.Text() = "carteira de identidade"
            lblNacimiento.Text() = "Nascimento"
            lblPermisos.Text() = "Permissões"
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        Dim acum As Integer
        acum = frmISU.Largo_cuatro(tbxAaaa, acum)
        acum = frmISU.Largo_dos(tbxDd, tbxMm, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim acum As Integer
        acum = frmISU.Largo_cuatro(tbxAaaa, acum)
        acum = frmISU.Largo_dos(tbxDd, tbxMm, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class