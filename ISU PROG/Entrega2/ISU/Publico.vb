Module Publico
    Public idioma, opcion As Integer
    Public anestro, toro, novillo, vaca, vaquillona, macho, hembra, ternera, ternero, gen, buscar, ninguno As String
    Public servicio, preñada, lactancia, seca, campo, rodeo, tambo, raza, division, lugar, etapa, sexo, hembraa As String
    Public contraseña, usuario, iniciar, ingresar, enlistar, consultar, eliminar, modificar, salir, sesion, si, no As String
    Public numero, nacimiento, antibi, preñez, estado, litros, grasa, urea, proteina, bacteria, somatica As String
    Public gene, fecha_preñez, fecha_ida, fecha_vuelta, auxiliar As String
    Public Sub Boton_idioma(btnOpcion As Button)
        Select Case opcion
            Case 0
                btnOpcion.Text = ingresar
            Case 1
                btnOpcion.Text = modificar
            Case 2
                btnOpcion.Text = consultar
            Case 3
                btnOpcion.Text = eliminar
        End Select
    End Sub
    Public Sub Variables_asignacion()
        anestro = "anestro"
        auxiliar = ""
        Select Case idioma
            Case 0
                contraseña = "Contraseña"
                usuario = "Usuario"
                iniciar = "Iniciar"
                ingresar = "Ingresar"
                enlistar = "Enlistar"
                consultar = "Consultar"
                eliminar = "Emilinar"
                modificar = "Modificar"
                salir = "Salir"
                sesion = "Cerrar sesion"
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
                division = "Division"
                lugar = "Lugar"
                etapa = "Etapa"
                sexo = "Sexo"
                hembraa = "Hembra (antibiotico)"
                numero = "Numero"
                nacimiento = "nacimiento"
                lugar = "lugar actual"
                raza = "Raza"
                division = "Division"
                antibi = "antibiótico influyente"
                preñez = "Taza de preñez"
                preñada = "preñada"
                grasa = "Grasa"
                urea = "Urea"
                bacteria = "recuento bacteriano"
                somatica = "recuento de celulas somáticas" 'como agregar renglón
                fecha_preñez = "fecha de preñez"
                fecha_ida = "campo da recria (ida)"
                fecha_vuelta = "campo da recria (vuelta)"
                si = "Se"
                no = "Não"
            Case 1
                contraseña = "Password"
                usuario = "User"
                iniciar = "Login"
                ingresar = "Insert"
                enlistar = "Show"
                consultar = "Consult"
                eliminar = "Remove"
                modificar = "Modify"
                salir = "Exit"
                sesion = "Log out"
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
                raza = "race"
                division = "Division"
                lugar = "Place"
                etapa = "Stage"
                hembraa = "female (antibiotic)"
                numero = "Numer"
                sexo = "Gender"
                nacimiento = "Birth"
                lugar = "Actual Place"
                antibi = "Influential antibiotic"
                preñez = "Pregnancy rate"
                preñada = "Pregnant"
                estado = "Stage"
                litros = "Liters"
                grasa = "Grease"
                urea = "urea"
                proteina = "Protein"
                bacteria = "Bacterial count"
                somatica = "Somatic cell count"
                gen = "Genealogy"
                fecha_preñez = "Pregnancy date"
                fecha_ida = "breeding field (going)"
                fecha_vuelta = "breeding field (coming)"
                si = "yes"
                no = "no"
            Case 2
                contraseña = "Senha"
                usuario = "Usuário"
                iniciar = "Começo"
                ingresar = "Depósito"
                enlistar = "Alistar"
                eliminar = "Remover"
                consultar = "Consultar"
                modificar = "Mudança"
                salir = "Sair"
                sesion = "Perto"
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
                raza = "Raça"
                division = "Divisão"
                lugar = "Localização"
                etapa = "Etapa"
                sexo = "Sexo"
                hembraa = "Femenino (antibiotico)"
                numero = "Numero"
                nacimiento = "nascimento"
                lugar = "localização actual"
                division = "Divisão"
                antibi = "antibiótico influente"
                preñez = "Taxa de prenhez"
                preñada = "Grávida"
                grasa = "Graxa"
                urea = "Uréia"
                bacteria = "Contagem bacteriana"
                somatica = "Contagem de células somáticas"
                fecha_preñez = "data a graviez"
                fecha_ida = "campo da criaçâgo (ida)"
                fecha_vuelta = "campo da criaçâgo (retorno)"
                si = "Se"
                no = "Não"
        End Select
    End Sub
    Function Validacion_numerica(ByVal valor As String, acum As Integer) As Integer
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
    Function Validacion_largo(ByVal tbxX As TextBox, acum As Integer) As Integer
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
End Module
