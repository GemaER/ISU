Public Class frmISU

    Private Sub frmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbxPass.Text() = ""
        tbxUser.Text() = ""
        tsTambo.Enabled = False
        tsPersonal.Enabled = False
        tsAnimal.Enabled = False
        tsSesion.Enabled = False
        tsOrdeñe.Enabled = False
        tsEnlistar.Enabled = False
        tbxPass.Enabled = False
        tbxUser.Enabled = False
        btnInicio.Enabled = False
        Publico.idioma = 0
    End Sub

    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
        pnlInicio.Hide()
        pnlBlue.Show()
        tsTambo.Enabled = True
        tsPersonal.Enabled = True
        tsAnimal.Enabled = True
        tsSesion.Enabled = True
        tsOrdeñe.Enabled = True
        tsEnlistar.Enabled = True

        tsIngresar.Text = ingresar
        tsEnlistar.Text = enlistar
        tsEliminar.Text = eliminar
        tsConsultar.Text = consultar
        tsModificar.Text = modificar
        tsTamboIngresar.Text = ingresar
        tsTamboModificar.Text = modificar
        tsTamboConsultar.Text = consultar
        tsTamboEiminar.Text = eliminar
        tsPersonalIngresar.Text = ingresar
        tsPersonalModificar.Text = modificar
        tsPersonalConsultar.Text = consultar
        tsPersonalEliminar.Text = eliminar
        tsVaca.Text = vaca
        tsVaquillona.Text = vaquillona
        tsToro.Text = toro
        tsNovillo.Text = novillo
        TsAnestro.Text = anestro
        tsTernero.Text = ternero
        tsTernera.Text = ternera
        tsRodeo.Text = rodeo
        tsCampo.Text = campo
        tsNinguno.Text = ninguno
        TsServicio.Text = servicio
        tsNinguno2.Text = ninguno
        Tsprenada.Text = preñada
        tsLactancia.Text = lactancia
        tsSeca.Text = seca
        tsHembra.Text = hembra
        tsMacho.Text = macho
        tsRaza.Text = raza
        tsDivision.Text = division
        tsLugar.Text = lugar
        tsEtapa.Text = etapa
        tsSexo.Text = sexo

    End Sub

    Private Sub tsSesion_Click(sender As System.Object, e As System.EventArgs) Handles tsSesion.Click
        pnlInicio.Show()
        pnlBlue.Hide()
        frmISU_Load(sender, e)
    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged
        If cbxIdioma.Text = "English" Then
            idioma = 1
        ElseIf cbxIdioma.Text = "Português" Then
            idioma = 2
        Else
            idioma = 0
        End If
        tbxPass.Enabled = True
        tbxUser.Enabled = True
        btnInicio.Enabled = True
        Variables_asignacion()
        Lblpass.Text = contraseña
        lblUser.Text = usuario
        btnInicio.Text = iniciar

        tsSalir.Text = salir
        tsSesion.Text = sesion
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub

    Private Sub tsTamboEiminar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboEiminar.Click
        opcion = 3
        frmTambo.Show()
    End Sub

    Private Sub tsTamboModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboModificar.Click
        opcion = 1
        frmTambo.Show()
    End Sub

    Private Sub tsTamboConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboConsultar.Click
        opcion = 2
        frmTambo.Show()
    End Sub

    Private Sub tsTamboIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboIngresar.Click
        opcion = 0
        frmTambo.Show()
    End Sub

    Private Sub tsPersonalModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalModificar.Click
        opcion = 1
        frmPersonal.Show()
    End Sub

    Private Sub tsPersonalConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalConsultar.Click
        opcion = 2
        frmPersonal.Show()
    End Sub

    Private Sub tsPersonalEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalEliminar.Click
        opcion = 3
        frmPersonal.Show()
    End Sub


    Private Sub tsConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsConsultar.Click
        opcion = 1
        frmAnimal.Show()
    End Sub

    Private Sub tsModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsModificar.Click
        opcion = 2
        frmAnimal.Show()
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        opcion = 3
        frmAnimal.Show()
    End Sub

    Private Sub tsHolando_Click(sender As System.Object, e As System.EventArgs) Handles tsHolando.Click
        opcion = 0
        frmEnlistar.Show()
    End Sub

    Private Sub tsJersey_Click(sender As System.Object, e As System.EventArgs) Handles tsJersey.Click
        opcion = 1
        frmEnlistar.Show()
    End Sub

    Private Sub tsPrimerShow_Click(sender As System.Object, e As System.EventArgs) Handles tsPrimerShow.Click
        opcion = 2
        frmEnlistar.Show()
    End Sub

    Private Sub tsVaca_Click(sender As System.Object, e As System.EventArgs) Handles tsVaca.Click
        opcion = 3
        frmEnlistar.Show()
    End Sub

    Private Sub tsVaquillona_Click(sender As System.Object, e As System.EventArgs) Handles tsVaquillona.Click
        opcion = 4
        frmEnlistar.Show()
    End Sub

    Private Sub tsToro_Click(sender As System.Object, e As System.EventArgs) Handles tsToro.Click
        opcion = 5
        frmEnlistar.Show()
    End Sub

    Private Sub tsNovillo_Click(sender As System.Object, e As System.EventArgs) Handles tsNovillo.Click
        opcion = 6
        frmEnlistar.Show()
    End Sub

    Private Sub TsAnestro_Click(sender As System.Object, e As System.EventArgs) Handles TsAnestro.Click
        opcion = 7
        frmEnlistar.Show()
    End Sub

    Private Sub tsTernero_Click(sender As System.Object, e As System.EventArgs) Handles tsTernero.Click
        opcion = 8
        frmEnlistar.Show()
    End Sub

    Private Sub tsTernera_Click(sender As System.Object, e As System.EventArgs) Handles tsTernera.Click
        opcion = 9
        frmEnlistar.Show()
    End Sub

    Private Sub tsRodeo_Click(sender As System.Object, e As System.EventArgs) Handles tsRodeo.Click
        opcion = 10
        frmEnlistar.Show()
    End Sub

    Private Sub tsCampo_Click(sender As System.Object, e As System.EventArgs) Handles tsCampo.Click
        opcion = 11
        frmEnlistar.Show()
    End Sub

    Private Sub tsTamboe_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboe.Click
        opcion = 12
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno.Click
        opcion = 13
        frmEnlistar.Show()
    End Sub

    Private Sub TsServicio_Click(sender As System.Object, e As System.EventArgs) Handles TsServicio.Click
        opcion = 14
        frmEnlistar.Show()
    End Sub

    Private Sub Tsprenada_Click(sender As System.Object, e As System.EventArgs) Handles Tsprenada.Click
        opcion = 15
        frmEnlistar.Show()
    End Sub

    Private Sub tsLactancia_Click(sender As System.Object, e As System.EventArgs) Handles tsLactancia.Click
        opcion = 16
        frmEnlistar.Show()
    End Sub

    Private Sub tsSeca_Click(sender As System.Object, e As System.EventArgs) Handles tsSeca.Click
        opcion = 17
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno2_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno2.Click
        opcion = 18
        frmEnlistar.Show()
    End Sub

    Private Sub tsHembraa_Click(sender As System.Object, e As System.EventArgs) Handles tsHembraa.Click
        opcion = 19
        frmEnlistar.Show()
    End Sub

    Private Sub tsHembra_Click(sender As System.Object, e As System.EventArgs) Handles tsHembra.Click
        opcion = 20
        frmEnlistar.Show()
    End Sub

    Private Sub tsMacho_Click(sender As System.Object, e As System.EventArgs) Handles tsMacho.Click
        opcion = 21
        frmEnlistar.Show()
    End Sub


    Private Sub AnimalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        opcion = -1
        frmAnimal.Show()
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        opcion = 0
        frmAnimal.Show()
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        frmOrdeñeConfig.Show()
    End Sub

    Private Sub PrimerOrdeñeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrimerOrdeñeToolStripMenuItem.Click
        frmOrdeñe.Show()
        opcion = 1
    End Sub

    Private Sub SegundoOrdeñeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SegundoOrdeñeToolStripMenuItem.Click
        frmOrdeñe.Show()
        opcion = 2
    End Sub

    Private Sub TercerOrdeñeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TercerOrdeñeToolStripMenuItem.Click
        frmOrdeñe.Show()
        opcion = 3
    End Sub

    Private Sub AlimentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlimentoToolStripMenuItem.Click
        frmAlimento.show()
    End Sub

    Private Sub tsPersonalIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalIngresar.Click
        opcion = 0
        frmPersonal.Show()
    End Sub

    Private Sub tsIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsIngresar.Click
        opcion = 0
        frmAnimal.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        frmAlimento.Show()
        opcion = 1
    End Sub

    Private Sub ControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ControlToolStripMenuItem.Click
        frmControl.Show()
    End Sub
End Class
