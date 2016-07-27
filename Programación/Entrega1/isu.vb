Public Class frmISU
    Public anestro, toro, novillo, vaca, vaquillona, macho, hembra, ternera, ternero, gen, buscar, ninguno, servicio, preñada, lactancia, seca, campo, rodeo, tambo As String

    Private Sub FrmISU_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbxPass.Text() = ""
        tbxUser.Text() = ""
        tsTambo.Enabled = False
        tsPersonal.Enabled = False
        tsIngresar.Enabled = False
        tsEliminar.Enabled = False
        tsConsultar.Enabled = False
        tsEnlistar.Enabled = False
        tsModificar.Enabled = False
        tsSesion.Enabled = False
    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged
        If cbxIdioma.Text() = "English" Then
            Lblpass.Text() = "Password"
            lblUser.Text() = "User"
            btnInicio.Text() = "Login"
            tsIngresar.Text() = "Insert"
            tsEnlistar.Text() = "Show"
            tsConsultar.Text() = "Consult"
            tsEliminar.Text() = "Remove"
            tsModificar.Text() = "Modify"
            tsTamboIngresar.Text() = "Insert"
            tsTamboModificar.Text() = "Modify"
            tsTamboConsultar.Text() = "Consult"
            tsPersonalIngresar.Text() = "Insert"
            tsPersonalModificar.Text() = "Modify"
            tsPersonalConsultar.Text() = "Consult"
            tsSalir.Text() = "Exit"
            tsSesion.Text() = "Log out"
            campo = "field of breeding"
            rodeo = "breeding herd"
            ninguno = "none"
            vaca = "cow"
            vaquillona = "heifer"
            novillo = "steer"
            toro = "bull"
            ternero = "calf"
            ternera = "veal"
            macho = "male"
            hembra = "female"
            buscar = "search"
            gen = "Genealogy"
            ninguno = "none"
            servicio = "Service"
            preñada = "Pregnant"
            lactancia = "Lactation"
            seca = "Dry"

            tsRaza.Text() = "race"
            tsDivision.Text() = "Division"
            tsLugar.Text() = "Place"
            tsEtapa.Text() = "Stage"
            tsSexo.Text() = "Gender"
            tsHembraa.Text() = "female (antibiotic)"

        ElseIf cbxIdioma.Text() = "Español" Then
            Lblpass.Text() = "Contraseña"
            lblUser.Text() = "Usuario"
            btnInicio.Text() = "Iniciar"
            tsIngresar.Text() = "Ingresar"
            tsEnlistar.Text() = "Enlistar"
            tsConsultar.Text() = "Consultar"
            tsEliminar.Text() = "Emilinar"
            tsModificar.Text() = "Modificar"
            tsTamboIngresar.Text() = "Ingresar"
            tsTamboModificar.Text() = "Modificar"
            tsTamboConsultar.Text() = "Consultar"
            tsPersonalIngresar.Text() = "Ingresar"
            tsPersonalModificar.Text() = "Modificar"
            tsPersonalConsultar.Text() = "Consultar"
            tsSalir.Text() = "Salir""Cerrar sesion"
            tsSesion.Text() = "Cerrar sesion"
            campo = "campo de recria"
            rodeo = "rodeo de cria"
            ninguno = "ninguno"
            vaca = "vaca"
            vaquillona = "vaquillona"
            novillo = "novillo"
            toro = "toro"
            ternero = "ternero"
            ternera = "ternera"
            macho = "macho"
            hembra = "hembra"
            buscar = "buscar"
            gen = "Genealogia"
            ninguno = "Ninguno"
            servicio = "Servicio"
            preñada = "Preñada"
            lactancia = "Lactancia"
            seca = "Seca"
            tsRaza.Text() = "Raza"
            tsDivision.Text() = "Division"
            tsLugar.Text() = "Lugar"
            tsEtapa.Text() = "Etapa"
            tsSexo.Text() = "Sexo"
            tsHembraa.Text() = "Hembra (antibiotico)"
        Else
            Lblpass.Text() = "Senha"
            lblUser.Text() = "Usuário"
            btnInicio.Text() = "Começo"
            tsIngresar.Text() = "Depósito"
            tsEnlistar.Text() = "Alistar"
            tsEliminar.Text() = "Remover"
            tsConsultar.Text() = "Consultar"
            tsModificar.Text() = "Mudança"
            tsTamboIngresar.Text() = "Depósito"
            tsTamboModificar.Text() = "Mudança"
            tsTamboConsultar.Text() = "Consultar"
            tsPersonalIngresar.Text() = "Depósito"
            tsPersonalModificar.Text() = "Mudança"
            tsPersonalConsultar.Text() = "Consultar"
            tsSalir.Text() = "Sair"
            tsSesion.Text() = "Perto"
            campo = "campo da criaçâgo"
            rodeo = "plantel"
            ninguno = "Nenhum"
            vaca = "vaca"
            vaquillona = "novilha"
            novillo = "novilho"
            toro = "touro"
            ternero = "vitela"
            ternera = "vitela"
            macho = "masculino"
            hembra = "fêmea"
            buscar = "pesquisa"
            gen = "Genealogia"
            ninguno = "Nenhum"
            servicio = "Serviço"
            preñada = "Gávida"
            lactancia = "Lactação"
            seca = "Seca"
            tsRaza.Text() = "Raça"
            tsDivision.Text() = "Divisão"
            tsLugar.Text() = "Localização"
            tsEtapa.Text() = "Etapa"
            tsSexo.Text() = "Sexo"
            tsHembraa.Text() = "Femenino (antibiotico)"
        End If
        tsVaca.Text() = vaca
        tsVaquillona.Text() = vaquillona
        tsToro.Text() = toro
        tsNovillo.Text() = novillo
        TsAnestro.Text() = "anestro"
        tsTernero.Text() = ternero
        tsTernera.Text() = ternera
        tsRodeo.Text() = rodeo
        tsCampo.Text() = campo
        tsNinguno.Text() = ninguno
        TsServicio.Text() = servicio
        tsNinguno2.Text() = ninguno
        Tsprenada.Text() = preñada
        tsLactancia.Text() = lactancia
        tsSeca.Text() = seca
        tsHembra.Text() = hembra
        tsMacho.Text() = macho
    End Sub

    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
        'validar datos del login
        pnlInicio.Hide()
        pnlBlue.Show()
        tsIngresar.Enabled = True
        tsEnlistar.Enabled = True
        tsEliminar.Enabled = True
        tsModificar.Enabled = True
        tsConsultar.Enabled = True
        tsSesion.Enabled = True
        tsPersonal.Enabled = True
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

    Private Sub tsCria_Click(sender As System.Object, e As System.EventArgs) Handles tsTernero.Click
        Dim Enlistar_opcion As String
        Enlistar_opcion = Texto_tsitem(tsTernero)
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

    Public Sub Idioma_Lugar(cbxLugar As ComboBox)
        cbxLugar.Items.Clear()
        cbxLugar.Items.Add("tambo")
        cbxLugar.Items.Add(campo)
        cbxLugar.Items.Add(rodeo)
        cbxLugar.Items.Add(ninguno)
    End Sub

    Public Sub Idioma_Division(cbxSexo As ComboBox, rbnSia As RadioButton, rbnSip As RadioButton, rbnNoa As RadioButton, rbnNop As RadioButton)
        If tsModificar.Text() = "Modify" Then
            rbnSip.Text() = "Yes"
            rbnSia.Text() = "Yes"
        ElseIf tsModificar.Text() = "Mudança" Then
            rbnSip.Text() = "Se"
            rbnSia.Text() = "Se"
            rbnNoa.Text() = "Não"
            rbnNop.Text() = "Não"
        End If
        cbxSexo.Items.Clear()
        cbxSexo.Items.Add(macho)
        cbxSexo.Items.Add(hembra)

        'cbxDivision
    End Sub
    Public Sub Sexo_Cambio(cbxSexo As ComboBox, lblDivision As Label, gbxHembra As GroupBox, gbxLeche As GroupBox, cbxDivision As ComboBox)
        anestro = "anestro"
        cbxDivision.Items.Clear()
        cbxDivision.Items.Add(anestro)
        If cbxSexo.Text() = hembra Then
            gbxHembra.Enabled = True
            gbxLeche.Enabled = True
            cbxDivision.Items.Add(vaca)
            cbxDivision.Items.Add(vaquillona)
            cbxDivision.Items.Add(ternera)
        ElseIf cbxSexo.Text() = macho Then
            gbxHembra.Enabled = False
            gbxLeche.Enabled = False
            cbxDivision.Items.Add(toro)
            cbxDivision.Items.Add(novillo)
            cbxDivision.Items.Add(ternero)
        End If
    End Sub

    Public Sub Etapa_Idioma(cbxEtapa As ComboBox)
        cbxEtapa.Items.Clear()
        cbxEtapa.Items.Add(ninguno)
        cbxEtapa.Items.Add(servicio)
        cbxEtapa.Items.Add(preñada)
        cbxEtapa.Items.Add(lactancia)
        cbxEtapa.Items.Add(seca)
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

    Public Sub Idioma_Load(tsM As ToolStripMenuItem, lblNum As Label, lblS As Label, lblN As Label, lblL As Label, lblR As Label, lblU As Label, lblD As Label, lblA As Label, lblPp As Label, lblPa As Label, lblE As Label, lblLts As Label, lblG As Label, lblPna As Label, lblRb As Label, lblRc As Label, btngen As Button, lblFechap As Label, lblFechaRI As Label, lblFechaRV As Label)
        If tsM.Text() = "Modify" Then
            Me.Text() = "Insert"
            lblNum.Text() = "Numer"
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
            lblFechap.Text() = "Pregnancy date"
            lblFechaRI.Text() = "breeding field (going)"
            lblFechaRV.Text() = "breeding field (coming)"

        ElseIf tsM.Text() = "Mudança" Then
            Me.Text() = "Depósito"
            lblNum.Text() = "Numero"
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
            lblFechap.Text() = "data a graviez"
            lblFechaRI.Text() = "campo da criaçâgo (ida)"
            lblFechaRV.Text() = "campo da criaçâgo (retorno)"
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

    Function Largo(ByVal tbxX As TextBox, acum As Integer) As Integer
        Dim retorno As Integer
        If IsNumeric(tbxX.Text()) Then
            If tbxX.MaxLength() = tbxX.TextLength() Then
                retorno = acum
            Else
                retorno = acum + 1
            End If
        Else
            retorno = acum + 1
        End If
        Return retorno
    End Function
    Function Fechas(tbxd1 As TextBox, tbxd2 As TextBox, tbxm1 As TextBox, tbxm2 As TextBox, tbxa1 As TextBox, tbxa2 As TextBox, acum As Integer) As Integer
        Dim retorno, dia1, dia2, mes1, mes2, año1, año2 As Integer
        Try
            dia1 = Int32.Parse(tbxd1.Text())
            dia2 = Int32.Parse(tbxd2.Text())
            mes1 = Int32.Parse(tbxm1.Text())
            mes2 = Int32.Parse(tbxm2.Text())
            año1 = Int32.Parse(tbxa1.Text())
            año2 = Int32.Parse(tbxa2.Text())
            If año1 < año2 Then
                retorno = acum
            ElseIf año1 = año2 Then
                If mes1 < mes2 Then
                    retorno = acum
                ElseIf mes1 = mes2 Then
                    If dia1 < dia2 Then
                        retorno = acum
                    ElseIf dia1 = dia2 Then
                        retorno = acum
                    Else
                        retorno = acum + 1
                    End If
                Else
                    retorno = acum + 1
                End If
            Else
                retorno = acum + 1
            End If
        Catch ex As Exception
            retorno = acum
        End Try
        Return retorno
    End Function
    Function Largo_dos(ByVal tbxX As TextBox, tbxY As TextBox, acum As Integer) As Integer
        Dim retorno As Integer
        If ((IsNumeric(tbxX.Text())) And (IsNumeric(tbxY.Text()))) Then
            If ((tbxX.Text() < 32) And (tbxY.Text() < 13)) Then
                acum = Largo(tbxX, acum)
                acum = Largo(tbxY, acum)
                retorno = acum
            Else
                retorno = acum + 1
            End If
        Else
            retorno = acum + 1
        End If

        Return retorno
    End Function
    Function Largo_cuatro(ByVal tbxX As TextBox, acum As Integer) As Integer
        Dim retorno As Integer
        If IsNumeric(tbxX.Text()) Then
            If tbxX.MaxLength() = tbxX.TextLength() Then
                retorno = acum
            Else
                retorno = acum + 1
            End If
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
        frmTamboCambios.Text() = frmTamboCambios.Text() + tsIngresar.Text()
        frmTamboCambios.btnIngresar.Show()
    End Sub

    Private Sub tsTamboModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboModificar.Click
        frmTamboCambios.Show()
        frmTamboCambios.btnModificar.Show()
        frmTamboCambios.Text() = frmTamboCambios.Text() + tsModificar.Text()
    End Sub

    Private Sub tsTamoConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsTamboConsultar.Click
        frmTamboConsultar.Show()
    End Sub

    Dim personalchoice As String

    Private Sub tsPersonalIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalIngresar.Click
        frmPersonal.Show()
        frmPersonal.btnModificar.Hide()
        personalchoice = tsIngresar.Text()
    End Sub

    Private Sub tsPersonalModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalModificar.Click
        frmPersonal.Show()
        frmPersonal.btnIngresar.Hide()
        personalchoice = tsModificar.Text()
    End Sub

    Private Sub tsPersonalConsulltar_Click(sender As System.Object, e As System.EventArgs) Handles tsPersonalConsultar.Click
        frmPersonal.Show()
        frmPersonal.btnModificar.Hide()
        frmPersonal.btnIngresar.Hide()
        personalchoice = tsConsultar.Text()
    End Sub

    Private Sub tsTernera_Click(sender As System.Object, e As System.EventArgs) Handles tsTernera.Click
        tsCria_Click(sender, e)
    End Sub

    Private Sub tsNinguno_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno.Click
        frmEnlistar.Show()
    End Sub

    Private Sub tsNinguno2_Click(sender As System.Object, e As System.EventArgs) Handles tsNinguno2.Click
        frmEnlistar.Show()
    End Sub

    Private Sub tsSeca_Click(sender As System.Object, e As System.EventArgs) Handles tsSeca.Click
        frmEnlistar.Show()
    End Sub

    Private Sub tsSesion_Click(sender As System.Object, e As System.EventArgs) Handles tsSesion.Click
        pnlInicio.Show()
        pnlBlue.Hide()
        FrmISU_Load(sender, e)
    End Sub
End Class
