﻿Public Class frmISU


    Private Sub FrmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        tsIngresar.Enabled = False
        tsEnlistar.Enabled = False
        tsEliminar.Enabled = False
        tsConsultar.Enabled = False
        tsSesion.Enabled = False
        tsTambo.Enabled = False
        tsModificar.Enabled = False
        tbxPass.Text() = ""
        tbxUser.Text() = ""

    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged

        If cbxIdioma.Text() = "English" Then
            Lblpass.Text() = "Password"
            lblUser.Text() = "User"
            btnInicio.Text() = "Login"
            tsIngresar.Text() = "Insert"
            tsEnlistar.Text() = "Show"
            tsEliminar.Text() = "Remove"
            tsModificar.Text() = "Modify"
            tsSalir.Text() = "Log out"
            tsSesion.Text() = "Exit"
        ElseIf cbxIdioma.Text() = "Español" Then
            Lblpass.Text() = "Contraseña"
            lblUser.Text() = "Usuario"
            btnInicio.Text() = "Iniciar"
            tsIngresar.Text() = "Ingresar"
            tsEnlistar.Text() = "Enlistar"
            tsEliminar.Text() = "Emilinar"
            tsModificar.Text() = "Modificar"
            tsSalir.Text() = "Cerrar sesion"
            tsSesion.Text() = "Salir"
        Else
            Lblpass.Text() = "Senha"
            lblUser.Text() = "Usuário"
            btnInicio.Text() = "Começo"
            tsIngresar.Text() = "Depósito"
            tsEnlistar.Text() = "Alistar"
            tsEliminar.Text() = "Remover"
            tsModificar.Text() = "Mudança"
            tsSalir.Text() = "Sair"
            tsSesion.Text() = "Perto"
        End If

    End Sub

    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click

        'validar datos del login
        pnlInicio.Hide()
        pnlBlue.Show()
        If cbxIdioma.Text() = "English" Then
            tsIngresar.Enabled = True
            tsEnlistar.Enabled = True
            tsEliminar.Enabled = True
            tsModificar.Enabled = True
            tsConsultar.Enabled = True
            tsSesion.Enabled = True
        ElseIf cbxIdioma.Text() = "Español" Then
            tsIngresar.Enabled = True
            tsEnlistar.Enabled = True
            tsEliminar.Enabled = True
            tsModificar.Enabled = True
            tsConsultar.Enabled = True
            tsSesion.Enabled = True
        Else
            tsIngresar.Enabled = True
            tsEliminar.Enabled = True
            tsConsultar.Enabled = True
            tsEnlistar.Enabled = True
            tsModificar.Enabled = True
            tsSesion.Enabled = True
        End If
        tsTambo.Enabled = True
    End Sub

    Private Sub tsIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsIngresar.Click
        frmIngresar.Show()
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        frmEliminar.Show()
    End Sub

    Private Sub tsConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsConsultar.Click
        frmConsultar.Show()
    End Sub

    Private Sub tsModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsModificar.Click
        frmModificar.Show()
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsSesion.Click
        pnlInicio.Show()
        pnlBlue.Hide()
        FrmISU_Load(sender, e)
    End Sub

    Private Sub tsHolando_Click(sender As System.Object, e As System.EventArgs) Handles tsHolando.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsHolando)
    End Sub

    Private Sub tsJersey_Click(sender As System.Object, e As System.EventArgs) Handles tsJersey.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsJersey)
    End Sub

    Private Sub tsPrimerShow_Click(sender As System.Object, e As System.EventArgs) Handles tsPrimerShow.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsPrimerShow)
    End Sub

    Private Sub tsVaca_Click(sender As System.Object, e As System.EventArgs) Handles tsVaca.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsVaca)
    End Sub

    Private Sub tsVaquillona_Click(sender As System.Object, e As System.EventArgs) Handles tsVaquillona.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsVaquillona)
    End Sub

    Private Sub tsToro_Click(sender As System.Object, e As System.EventArgs) Handles tsToro.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsToro)
    End Sub

    Private Sub tsNovillo_Click(sender As System.Object, e As System.EventArgs) Handles tsNovillo.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsNovillo)
    End Sub

    Private Sub TsAnestro_Click(sender As System.Object, e As System.EventArgs) Handles TsAnestro.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(TsAnestro)
    End Sub

    Private Sub tsCria_Click(sender As System.Object, e As System.EventArgs) Handles tsCria.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsCria)
    End Sub

    Private Sub tsRodeo_Click(sender As System.Object, e As System.EventArgs) Handles tsRodeo.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsRodeo)
    End Sub

    Private Sub tsCampo_Click(sender As System.Object, e As System.EventArgs) Handles tsCampo.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsCampo)
    End Sub

    Private Sub tsTamboe_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboe.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsTambo)
    End Sub

    Private Sub TsServicio_Click(sender As System.Object, e As System.EventArgs) Handles TsServicio.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(TsServicio)
    End Sub

    Private Sub Tsprenada_Click(sender As System.Object, e As System.EventArgs) Handles Tsprenada.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(Tsprenada)
    End Sub

    Private Sub tsLactancia_Click(sender As System.Object, e As System.EventArgs) Handles tsLactancia.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsLactancia)
    End Sub

    Private Sub tsHembraa_Click(sender As System.Object, e As System.EventArgs) Handles tsHembraa.Click
        Dim Enlistar_opcion, extra As String
        Enlistar_opcion = Texto_tsitem(tsHembra)
        extra = "Si"
    End Sub

    Private Sub tsHembra_Click(sender As System.Object, e As System.EventArgs) Handles tsHembra.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsHembra)
    End Sub

    Private Sub tsMacho_Click(sender As System.Object, e As System.EventArgs) Handles tsMacho.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsMacho)
    End Sub

    Private Sub tsEdad_Click(sender As System.Object, e As System.EventArgs) Handles tsEdad.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsEdad)
    End Sub

    Public Sub Sexo_cambio(cbxLugar As ComboBox, cbxSexo As ComboBox, lblDivision As Label, gbxHembra As GroupBox, gbxLeche As GroupBox, cbxDivision As ComboBox, rbnSia As RadioButton, rbnSip As RadioButton)
        Dim anestro, toro, novillo, vaca, vaquillona, macho, hembra, campo, rodeo As String
        If tsModificar.Text() = "Modify" Then
            rbnSip.Text() = "Yes"
            rbnSia.Text() = rbnSip.Text()
            vaca = "cow"
            vaquillona = "heifer"
            novillo = "steer"
            toro = "bull"
            macho = "male"
            hembra = "female"
            campo = "field of breeding"
            rodeo = ""
        ElseIf tsModificar.Text() = "Mudança" Then
            vaca = "vaca"
            vaquillona = "novilha"
            novillo = "novilho"
            toro = "touro"
            macho = "macho"
            hembra = "fêmea"
            campo = "campo da criaçâgo"
            rodeo = ""
        Else
            vaca = "vaca"
            vaquillona = "vaquillona"
            novillo = "novillo"
            toro = "toro"
            macho = "macho"
            hembra = "hembra"
            campo = "campo de recria"
            rodeo = ".. rodeo"
        End If
        cbxSexo.Items.Clear()
        cbxLugar.Items.Clear()
        cbxLugar.Items.Add("tambo")
        cbxLugar.Items.Add(campo)
        cbxLugar.Items.Add(rodeo)
        cbxSexo.Items.Add(macho)
        cbxSexo.Items.Add(hembra)

        'cbxDivision
        anestro = "anestro"
        cbxDivision.Items.Clear()
        cbxDivision.Items.Add(anestro)
        If cbxSexo.Text() = hembra Then
            gbxHembra.Enabled = True
            gbxLeche.Enabled = True
            cbxDivision.Items.Add(vaca)
            cbxDivision.Items.Add(vaquillona)
        ElseIf cbxSexo.Text() = macho Then
            gbxHembra.Enabled = False
            gbxLeche.Enabled = False
            cbxDivision.Items.Add(toro)
            cbxDivision.Items.Add(novillo)
        End If
    End Sub

    Function Validacion_Entera(tbxLitros As TextBox, tbxrecuentobac As TextBox, tbxRecuentocel As TextBox, tbxPorcentajep As TextBox, tbxGrasa As TextBox, tbxProteina As TextBox, tbxUrea As TextBox) As Integer

        Dim acum As Integer
        acum = 0

        acum = Me.Acumulacion(tbxLitros.Text(), acum)
        acum = Me.Acumulacion(tbxrecuentobac.Text(), acum)
        acum = Me.Acumulacion(tbxRecuentocel.Text(), acum)

        acum = Me.Porcentaje(tbxPorcentajep.Text(), acum)
        acum = Me.Porcentaje(tbxGrasa.Text(), acum)
        acum = Me.Porcentaje(tbxProteina.Text(), acum)
        acum = Me.Porcentaje(tbxUrea.Text(), acum)

        Return acum

    End Function

    Public Sub Idioma_Load(tsM As ToolStripMenuItem, lblS As Label, lblN As Label, lblL As Label, lblR As Label, lblU As Label, lblD As Label, lblA As Label, lblPp As Label, lblPa As Label, lblE As Label, lblLts As Label, lblG As Label, lblPna As Label, lblRb As Label, lblRc As Label, btngen As Button)
        If tsM.Text() = "Modify" Then
            Me.Text() = "Insert"
            lblS.Text() = "Gender"
            lblN.Text() = "Birth"
            lblL.Text() = "Actual Place"
            lblR.Text() = "Race"
            lblA.Text() = "Influential antibiotic"
            lblPp.Text() = "Pregnancy rate"
            lblPa.Text() = "Pregnant"
            lblE.Text() = "Stage"
            lblLts.Text() = "Liters"
            lblG.Text() = "Grease"
            lblPna.Text() = "Protein"
            lblRb.Text() = "Bacterial count"
            lblRc.Text() = "Somatic cell count"
            btngen.Text() = "Genealogy"

        ElseIf tsM.Text() = "Mudança" Then
            Me.Text() = "Depósito"
            lblN.Text() = "nascimento"
            lblL.Text() = "localização actual"
            lblR.Text() = "Raça"
            lblD.Text() = "Divisão"
            lblA.Text() = "antibiótico influente"
            lblPp.Text() = "Taxa de prenhez"
            lblPa.Text() = "Grávida"
            lblG.Text() = "Graxa"
            lblU.Text() = "Uréia"
            lblRb.Text() = "Contagem bacteriana"
            lblRc.Text() = "Contagem de células somáticas" 'como agregar renglón
        End If
    End Sub

    Function Acumulacion(ByVal valor As String, acum As Integer) As Integer
        Dim retorno As Integer

        If IsNumeric(valor) Then
            If valor >= 0 Then
                retorno = acum
            Else
                retorno = acum + 1
            End If
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function

    Function Porcentaje(ByVal valor As String, acum As Integer) As Integer
        Dim retorno As Integer

        If IsNumeric(valor) Then
            If valor <= 100 And valor >= 0 Then
                retorno = acum
            Else
                retorno = acum + 1
            End If
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function

    Function Largo(ByVal txtX As TextBox, acum As Integer) As Integer
        Dim retorno As Integer

        If txtX.MaxLength() = txtX.TextLength() Then
            retorno = acum
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function
    Function Largo_dos(ByVal tbxX As TextBox, tbxY As TextBox, acum As Integer) As Integer
        Dim retorno As Integer
        If IsNumeric(tbxX.Text()) And IsNumeric(tbxY.Text()) Then
            If tbxX.MaxLength() = tbxX.TextLength() And tbxY.MaxLength() = tbxY.TextLength() Then
                If tbxX.Text() < 32 And tbxY.Text() < 13 Then
                    retorno = acum
                Else
                    retorno = acum + 1
                End If
            Else
                retorno = acum + 1
            End If
            retorno = acum + 1
        End If

        Return retorno
    End Function
    Function Largo_cuatro(ByVal txtX As TextBox, acum As Integer) As Integer
        Dim retorno As Integer

        If txtX.MaxLength() = txtX.TextLength() Then
            retorno = acum
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function


    Function Texto_tsitem(tsX As ToolStripItem) As String

        Dim Enlistar_opcion As String
        Enlistar_opcion = tsX.Text
        frmEnlistar.Show()
        Return Enlistar_opcion
    End Function

    Private Sub tsCerrar_Click(sender As System.Object, e As System.EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub

    Private Sub tsTamboIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboIngresar.Click
        frmTamboCambios.Show()
    End Sub

    Private Sub tsTamboModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboModificar.Click
        frmTamboCambios.Show()
        frmTamboCambios.btnModificar.Show()
    End Sub

    Private Sub tsTamoConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamoConsultar.Click
        frmTamboConsultar.Show()
    End Sub
End Class
