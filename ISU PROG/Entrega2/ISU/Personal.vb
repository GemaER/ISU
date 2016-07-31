Public Class frmPersonal

    Private Sub Personal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If idioma = 1 Then
            lblCI.Text() = CI + "Identity Card"
            lblPermisos.Text() = permiso + "Permissions"
            lblNacimiento.Text = nacimiento
            lblNombre.Text = nombre
        ElseIf idioma = 2 Then
            lblCI.Text() = "carteira de identidade"
            lblPermisos.Text() = "Permissões"
        End If
        lblNacimiento.Text = nacimiento
        lblSexo.Text = sexo
        Boton_idioma(btnOpcion)
        btnBuscar.Text = buscar

        cbxSexo.Items.Clear()
        cbxSexo.Items.Add(hembra)
        cbxSexo.Items.Add(macho)

        cbxPuesto.Items.Clear()
        cbxPuesto.Items.Add(auxiliar)
        cbxPuesto.Items.Add(auxiliar)
        cbxPuesto.Items.Add(auxiliar)
        cbxPuesto.Items.Add(auxiliar)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxCI.Text(), acum)
        acum = Validacion_largo(tbxCI, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            btnOpcion.Enabled = True
            gbxDatos.Enabled = True
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class