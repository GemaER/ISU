Public Class frmAnimal


    Private Sub frmAnimal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Boton_idioma(btnOpcion)
        btnBuscar.Text = buscar
        btnBuscarH.Text = buscar
        btnBuscarM.Text = buscar
        lblSexo.Text = sexo
        lblSexoH.Text = sexo
        lblSexoM.Text = sexo
        lblRecriavuelta.Text = fecha_vuelta
        lblRecriaIda.Text = fecha_ida
        lblRazaM.Text = raza
        lblRazaH.Text = raza
        lblRaza.Text = raza
        lblNumM.Text = numero
        lblNumH.Text = numero
        lblNumero.Text = numero
        lblNacimiento.Text = nacimiento
        lblLugar.Text = lugar
        lblFechaI.Text = fechaI
        lblFechaF.Text = fechaF
        lblEtapa.Text = etapa
        lblDivision.Text = division
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim acum As Integer
        acum = 0
        acum = Validacion_numerica(tbxNum.Text(), acum)
        acum = Validacion_largo(tbxNum, acum)
        If acum = 0 Then
            MsgBox("Falta conexión a la base de datos", MsgBoxStyle.OkOnly, "ERROR")
            btnOpcion.Enabled = True
            gbxBasico.Enabled = True
        Else
            MsgBox("Datos no válidos", MsgBoxStyle.OkOnly, "ERROR")
        End If
    End Sub
End Class