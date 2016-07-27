<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblPrenada = New System.Windows.Forms.Label()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cbxRaza = New System.Windows.Forms.ComboBox()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.cbxDivision = New System.Windows.Forms.ComboBox()
        Me.rbnNoa = New System.Windows.Forms.RadioButton()
        Me.rbnSia = New System.Windows.Forms.RadioButton()
        Me.lblAntibiotico = New System.Windows.Forms.Label()
        Me.tbxPorcentajep = New System.Windows.Forms.TextBox()
        Me.lblPorcentajep = New System.Windows.Forms.Label()
        Me.gbxAntibiotico = New System.Windows.Forms.GroupBox()
        Me.gbxPrenada = New System.Windows.Forms.GroupBox()
        Me.rbnSip = New System.Windows.Forms.RadioButton()
        Me.rbnNop = New System.Windows.Forms.RadioButton()
        Me.gbxLeche = New System.Windows.Forms.GroupBox()
        Me.tbxGrasa = New System.Windows.Forms.TextBox()
        Me.lblGrasa = New System.Windows.Forms.Label()
        Me.tbxProteina = New System.Windows.Forms.TextBox()
        Me.lblProteina = New System.Windows.Forms.Label()
        Me.tbxUrea = New System.Windows.Forms.TextBox()
        Me.lblUrea = New System.Windows.Forms.Label()
        Me.tbxRecuentocel = New System.Windows.Forms.TextBox()
        Me.lblRecuentoCel = New System.Windows.Forms.Label()
        Me.tbxRecuentobac = New System.Windows.Forms.TextBox()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.lblRecuentobac = New System.Windows.Forms.Label()
        Me.tbxLitros = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxHembra = New System.Windows.Forms.GroupBox()
        Me.tbxDd = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.tbxMm = New System.Windows.Forms.TextBox()
        Me.tbxAaaa = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGenealogia = New System.Windows.Forms.Button()
        Me.gbxBasico = New System.Windows.Forms.GroupBox()
        Me.cbxLugar = New System.Windows.Forms.ComboBox()
        Me.gbxPrenadaS = New System.Windows.Forms.GroupBox()
        Me.tbxaaaarv = New System.Windows.Forms.TextBox()
        Me.tbxmmrv = New System.Windows.Forms.TextBox()
        Me.lblRecriavuelta = New System.Windows.Forms.Label()
        Me.tbxddrv = New System.Windows.Forms.TextBox()
        Me.tbxaaaaRI = New System.Windows.Forms.TextBox()
        Me.tbxmmri = New System.Windows.Forms.TextBox()
        Me.lblRecriaIda = New System.Windows.Forms.Label()
        Me.tbxddri = New System.Windows.Forms.TextBox()
        Me.tbxaaaap = New System.Windows.Forms.TextBox()
        Me.tbxmmp = New System.Windows.Forms.TextBox()
        Me.lblFechaP = New System.Windows.Forms.Label()
        Me.tbxddP = New System.Windows.Forms.TextBox()
        Me.gbxAntibiotico.SuspendLayout()
        Me.gbxPrenada.SuspendLayout()
        Me.gbxLeche.SuspendLayout()
        Me.gbxHembra.SuspendLayout()
        Me.gbxBasico.SuspendLayout()
        Me.gbxPrenadaS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(24, 35)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "Numero"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(7, 197)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(85, 24)
        Me.lblDivision.TabIndex = 2
        Me.lblDivision.Text = "División"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(6, 109)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(125, 24)
        Me.lblLugar.TabIndex = 4
        Me.lblLugar.Text = "Lugar actual"
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(8, 25)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(65, 24)
        Me.lblEtapa.TabIndex = 5
        Me.lblEtapa.Text = "Etapa"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(8, 154)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(58, 24)
        Me.lblRaza.TabIndex = 6
        Me.lblRaza.Text = "Raza"
        '
        'lblPrenada
        '
        Me.lblPrenada.AutoSize = True
        Me.lblPrenada.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenada.Location = New System.Drawing.Point(7, 111)
        Me.lblPrenada.Name = "lblPrenada"
        Me.lblPrenada.Size = New System.Drawing.Size(89, 24)
        Me.lblPrenada.TabIndex = 7
        Me.lblPrenada.Text = "Preñada"
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(232, 32)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(145, 32)
        Me.tbxNum.TabIndex = 8
        Me.tbxNum.Text = "000000000"
        '
        'btnIngresar
        '
        Me.btnIngresar.Enabled = False
        Me.btnIngresar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(532, 26)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(118, 42)
        Me.btnIngresar.TabIndex = 30
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cbxRaza
        '
        Me.cbxRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRaza.FormattingEnabled = True
        Me.cbxRaza.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxRaza.Location = New System.Drawing.Point(213, 151)
        Me.cbxRaza.Name = "cbxRaza"
        Me.cbxRaza.Size = New System.Drawing.Size(145, 32)
        Me.cbxRaza.TabIndex = 31
        '
        'cbxEtapa
        '
        Me.cbxEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEtapa.FormattingEnabled = True
        Me.cbxEtapa.Items.AddRange(New Object() {"Ninguno", "Servicio", "Preñada", "Lactancia"})
        Me.cbxEtapa.Location = New System.Drawing.Point(215, 22)
        Me.cbxEtapa.Name = "cbxEtapa"
        Me.cbxEtapa.Size = New System.Drawing.Size(144, 32)
        Me.cbxEtapa.TabIndex = 34
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(7, 18)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 35
        Me.lblSexo.Text = "Sexo"
        '
        'cbxSexo
        '
        Me.cbxSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.cbxSexo.Location = New System.Drawing.Point(213, 15)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexo.TabIndex = 36
        '
        'cbxDivision
        '
        Me.cbxDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivision.FormattingEnabled = True
        Me.cbxDivision.Location = New System.Drawing.Point(213, 194)
        Me.cbxDivision.Name = "cbxDivision"
        Me.cbxDivision.Size = New System.Drawing.Size(145, 32)
        Me.cbxDivision.TabIndex = 37
        '
        'rbnNoa
        '
        Me.rbnNoa.AutoSize = True
        Me.rbnNoa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNoa.Location = New System.Drawing.Point(84, 7)
        Me.rbnNoa.Name = "rbnNoa"
        Me.rbnNoa.Size = New System.Drawing.Size(54, 28)
        Me.rbnNoa.TabIndex = 40
        Me.rbnNoa.TabStop = True
        Me.rbnNoa.Text = "No"
        Me.rbnNoa.UseVisualStyleBackColor = True
        '
        'rbnSia
        '
        Me.rbnSia.AutoSize = True
        Me.rbnSia.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSia.Location = New System.Drawing.Point(6, 7)
        Me.rbnSia.Name = "rbnSia"
        Me.rbnSia.Size = New System.Drawing.Size(47, 28)
        Me.rbnSia.TabIndex = 39
        Me.rbnSia.TabStop = True
        Me.rbnSia.Text = "Si"
        Me.rbnSia.UseVisualStyleBackColor = True
        '
        'lblAntibiotico
        '
        Me.lblAntibiotico.AutoSize = True
        Me.lblAntibiotico.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntibiotico.Location = New System.Drawing.Point(8, 65)
        Me.lblAntibiotico.Name = "lblAntibiotico"
        Me.lblAntibiotico.Size = New System.Drawing.Size(202, 24)
        Me.lblAntibiotico.TabIndex = 38
        Me.lblAntibiotico.Text = "Antibiotico influyente"
        '
        'tbxPorcentajep
        '
        Me.tbxPorcentajep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPorcentajep.Location = New System.Drawing.Point(215, 150)
        Me.tbxPorcentajep.MaxLength = 3
        Me.tbxPorcentajep.Name = "tbxPorcentajep"
        Me.tbxPorcentajep.Size = New System.Drawing.Size(144, 32)
        Me.tbxPorcentajep.TabIndex = 42
        Me.tbxPorcentajep.Text = "000"
        '
        'lblPorcentajep
        '
        Me.lblPorcentajep.AutoSize = True
        Me.lblPorcentajep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajep.Location = New System.Drawing.Point(6, 153)
        Me.lblPorcentajep.Name = "lblPorcentajep"
        Me.lblPorcentajep.Size = New System.Drawing.Size(208, 24)
        Me.lblPorcentajep.TabIndex = 41
        Me.lblPorcentajep.Text = "Porcentaje de preñez"
        '
        'gbxAntibiotico
        '
        Me.gbxAntibiotico.Controls.Add(Me.rbnSia)
        Me.gbxAntibiotico.Controls.Add(Me.rbnNoa)
        Me.gbxAntibiotico.Location = New System.Drawing.Point(216, 58)
        Me.gbxAntibiotico.Name = "gbxAntibiotico"
        Me.gbxAntibiotico.Size = New System.Drawing.Size(144, 40)
        Me.gbxAntibiotico.TabIndex = 43
        Me.gbxAntibiotico.TabStop = False
        '
        'gbxPrenada
        '
        Me.gbxPrenada.Controls.Add(Me.rbnSip)
        Me.gbxPrenada.Controls.Add(Me.rbnNop)
        Me.gbxPrenada.Location = New System.Drawing.Point(215, 104)
        Me.gbxPrenada.Name = "gbxPrenada"
        Me.gbxPrenada.Size = New System.Drawing.Size(144, 39)
        Me.gbxPrenada.TabIndex = 44
        Me.gbxPrenada.TabStop = False
        '
        'rbnSip
        '
        Me.rbnSip.AutoSize = True
        Me.rbnSip.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSip.Location = New System.Drawing.Point(7, 7)
        Me.rbnSip.Name = "rbnSip"
        Me.rbnSip.Size = New System.Drawing.Size(47, 28)
        Me.rbnSip.TabIndex = 39
        Me.rbnSip.TabStop = True
        Me.rbnSip.Text = "Si"
        Me.rbnSip.UseVisualStyleBackColor = True
        '
        'rbnNop
        '
        Me.rbnNop.AutoSize = True
        Me.rbnNop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNop.Location = New System.Drawing.Point(84, 7)
        Me.rbnNop.Name = "rbnNop"
        Me.rbnNop.Size = New System.Drawing.Size(54, 28)
        Me.rbnNop.TabIndex = 40
        Me.rbnNop.TabStop = True
        Me.rbnNop.Text = "No"
        Me.rbnNop.UseVisualStyleBackColor = True
        '
        'gbxLeche
        '
        Me.gbxLeche.Controls.Add(Me.tbxGrasa)
        Me.gbxLeche.Controls.Add(Me.lblGrasa)
        Me.gbxLeche.Controls.Add(Me.tbxProteina)
        Me.gbxLeche.Controls.Add(Me.lblProteina)
        Me.gbxLeche.Controls.Add(Me.tbxUrea)
        Me.gbxLeche.Controls.Add(Me.lblUrea)
        Me.gbxLeche.Controls.Add(Me.tbxRecuentocel)
        Me.gbxLeche.Controls.Add(Me.lblRecuentoCel)
        Me.gbxLeche.Controls.Add(Me.tbxRecuentobac)
        Me.gbxLeche.Controls.Add(Me.lblLitros)
        Me.gbxLeche.Controls.Add(Me.lblRecuentobac)
        Me.gbxLeche.Controls.Add(Me.tbxLitros)
        Me.gbxLeche.Enabled = False
        Me.gbxLeche.Location = New System.Drawing.Point(398, 74)
        Me.gbxLeche.Name = "gbxLeche"
        Me.gbxLeche.Size = New System.Drawing.Size(399, 282)
        Me.gbxLeche.TabIndex = 45
        Me.gbxLeche.TabStop = False
        Me.gbxLeche.Text = "Lactancia"
        '
        'tbxGrasa
        '
        Me.tbxGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGrasa.Location = New System.Drawing.Point(251, 57)
        Me.tbxGrasa.MaxLength = 3
        Me.tbxGrasa.Name = "tbxGrasa"
        Me.tbxGrasa.Size = New System.Drawing.Size(142, 32)
        Me.tbxGrasa.TabIndex = 57
        Me.tbxGrasa.Text = "000"
        '
        'lblGrasa
        '
        Me.lblGrasa.AutoSize = True
        Me.lblGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrasa.Location = New System.Drawing.Point(6, 60)
        Me.lblGrasa.Name = "lblGrasa"
        Me.lblGrasa.Size = New System.Drawing.Size(199, 24)
        Me.lblGrasa.TabIndex = 56
        Me.lblGrasa.Text = "Porcentaje de grasa"
        '
        'tbxProteina
        '
        Me.tbxProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxProteina.Location = New System.Drawing.Point(251, 100)
        Me.tbxProteina.MaxLength = 3
        Me.tbxProteina.Name = "tbxProteina"
        Me.tbxProteina.Size = New System.Drawing.Size(142, 32)
        Me.tbxProteina.TabIndex = 55
        Me.tbxProteina.Text = "000"
        '
        'lblProteina
        '
        Me.lblProteina.AutoSize = True
        Me.lblProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteina.Location = New System.Drawing.Point(6, 103)
        Me.lblProteina.Name = "lblProteina"
        Me.lblProteina.Size = New System.Drawing.Size(222, 24)
        Me.lblProteina.TabIndex = 54
        Me.lblProteina.Text = "Porcentaje de proteina"
        '
        'tbxUrea
        '
        Me.tbxUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUrea.Location = New System.Drawing.Point(251, 147)
        Me.tbxUrea.MaxLength = 3
        Me.tbxUrea.Name = "tbxUrea"
        Me.tbxUrea.Size = New System.Drawing.Size(142, 32)
        Me.tbxUrea.TabIndex = 53
        Me.tbxUrea.Text = "000"
        '
        'lblUrea
        '
        Me.lblUrea.AutoSize = True
        Me.lblUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrea.Location = New System.Drawing.Point(6, 150)
        Me.lblUrea.Name = "lblUrea"
        Me.lblUrea.Size = New System.Drawing.Size(188, 24)
        Me.lblUrea.TabIndex = 52
        Me.lblUrea.Text = "Porcentaje de urea"
        '
        'tbxRecuentocel
        '
        Me.tbxRecuentocel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentocel.Location = New System.Drawing.Point(251, 224)
        Me.tbxRecuentocel.MaxLength = 11
        Me.tbxRecuentocel.Name = "tbxRecuentocel"
        Me.tbxRecuentocel.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentocel.TabIndex = 51
        Me.tbxRecuentocel.Text = "00000000000"
        '
        'lblRecuentoCel
        '
        Me.lblRecuentoCel.AutoSize = True
        Me.lblRecuentoCel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentoCel.Location = New System.Drawing.Point(6, 224)
        Me.lblRecuentoCel.Name = "lblRecuentoCel"
        Me.lblRecuentoCel.Size = New System.Drawing.Size(200, 48)
        Me.lblRecuentoCel.TabIndex = 50
        Me.lblRecuentoCel.Text = "Recuento de células" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      somáticas"
        '
        'tbxRecuentobac
        '
        Me.tbxRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentobac.Location = New System.Drawing.Point(251, 185)
        Me.tbxRecuentobac.MaxLength = 11
        Me.tbxRecuentobac.Name = "tbxRecuentobac"
        Me.tbxRecuentobac.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentobac.TabIndex = 49
        Me.tbxRecuentobac.Text = "00000000000"
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.Location = New System.Drawing.Point(6, 22)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(63, 24)
        Me.lblLitros.TabIndex = 46
        Me.lblLitros.Text = "Litros"
        '
        'lblRecuentobac
        '
        Me.lblRecuentobac.AutoSize = True
        Me.lblRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentobac.Location = New System.Drawing.Point(6, 188)
        Me.lblRecuentobac.Name = "lblRecuentobac"
        Me.lblRecuentobac.Size = New System.Drawing.Size(205, 24)
        Me.lblRecuentobac.TabIndex = 48
        Me.lblRecuentobac.Text = "Recuento bacteriano"
        '
        'tbxLitros
        '
        Me.tbxLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLitros.Location = New System.Drawing.Point(251, 19)
        Me.tbxLitros.MaxLength = 11
        Me.tbxLitros.Name = "tbxLitros"
        Me.tbxLitros.Size = New System.Drawing.Size(142, 32)
        Me.tbxLitros.TabIndex = 47
        Me.tbxLitros.Text = "00000000000"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(803, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 750)
        Me.Panel1.TabIndex = 46
        '
        'gbxHembra
        '
        Me.gbxHembra.Controls.Add(Me.lblAntibiotico)
        Me.gbxHembra.Controls.Add(Me.gbxPrenada)
        Me.gbxHembra.Controls.Add(Me.lblEtapa)
        Me.gbxHembra.Controls.Add(Me.gbxAntibiotico)
        Me.gbxHembra.Controls.Add(Me.lblPrenada)
        Me.gbxHembra.Controls.Add(Me.tbxPorcentajep)
        Me.gbxHembra.Controls.Add(Me.lblPorcentajep)
        Me.gbxHembra.Controls.Add(Me.cbxEtapa)
        Me.gbxHembra.Enabled = False
        Me.gbxHembra.Location = New System.Drawing.Point(16, 316)
        Me.gbxHembra.Name = "gbxHembra"
        Me.gbxHembra.Size = New System.Drawing.Size(376, 194)
        Me.gbxHembra.TabIndex = 47
        Me.gbxHembra.TabStop = False
        '
        'tbxDd
        '
        Me.tbxDd.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDd.Location = New System.Drawing.Point(215, 56)
        Me.tbxDd.MaxLength = 2
        Me.tbxDd.Name = "tbxDd"
        Me.tbxDd.Size = New System.Drawing.Size(37, 32)
        Me.tbxDd.TabIndex = 50
        Me.tbxDd.Text = "dd"
        Me.tbxDd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(7, 59)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(114, 24)
        Me.lblNacimiento.TabIndex = 49
        Me.lblNacimiento.Text = "Nacimiento"
        '
        'tbxMm
        '
        Me.tbxMm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMm.Location = New System.Drawing.Point(258, 56)
        Me.tbxMm.MaxLength = 2
        Me.tbxMm.Name = "tbxMm"
        Me.tbxMm.Size = New System.Drawing.Size(40, 32)
        Me.tbxMm.TabIndex = 51
        Me.tbxMm.Text = "mm"
        Me.tbxMm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxAaaa
        '
        Me.tbxAaaa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAaaa.Location = New System.Drawing.Point(304, 56)
        Me.tbxAaaa.MaxLength = 4
        Me.tbxAaaa.Name = "tbxAaaa"
        Me.tbxAaaa.Size = New System.Drawing.Size(54, 32)
        Me.tbxAaaa.TabIndex = 52
        Me.tbxAaaa.Text = "aaaa"
        Me.tbxAaaa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(408, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 53
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGenealogia
        '
        Me.btnGenealogia.Enabled = False
        Me.btnGenealogia.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenealogia.Location = New System.Drawing.Point(656, 26)
        Me.btnGenealogia.Name = "btnGenealogia"
        Me.btnGenealogia.Size = New System.Drawing.Size(141, 42)
        Me.btnGenealogia.TabIndex = 54
        Me.btnGenealogia.Text = "Genealogia"
        Me.btnGenealogia.UseVisualStyleBackColor = True
        '
        'gbxBasico
        '
        Me.gbxBasico.Controls.Add(Me.cbxLugar)
        Me.gbxBasico.Controls.Add(Me.tbxAaaa)
        Me.gbxBasico.Controls.Add(Me.tbxMm)
        Me.gbxBasico.Controls.Add(Me.tbxDd)
        Me.gbxBasico.Controls.Add(Me.lblNacimiento)
        Me.gbxBasico.Controls.Add(Me.lblDivision)
        Me.gbxBasico.Controls.Add(Me.cbxSexo)
        Me.gbxBasico.Controls.Add(Me.lblSexo)
        Me.gbxBasico.Controls.Add(Me.cbxRaza)
        Me.gbxBasico.Controls.Add(Me.cbxDivision)
        Me.gbxBasico.Controls.Add(Me.lblRaza)
        Me.gbxBasico.Controls.Add(Me.lblLugar)
        Me.gbxBasico.Enabled = False
        Me.gbxBasico.Location = New System.Drawing.Point(16, 70)
        Me.gbxBasico.Name = "gbxBasico"
        Me.gbxBasico.Size = New System.Drawing.Size(374, 240)
        Me.gbxBasico.TabIndex = 55
        Me.gbxBasico.TabStop = False
        '
        'cbxLugar
        '
        Me.cbxLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLugar.FormattingEnabled = True
        Me.cbxLugar.Location = New System.Drawing.Point(213, 106)
        Me.cbxLugar.Name = "cbxLugar"
        Me.cbxLugar.Size = New System.Drawing.Size(145, 32)
        Me.cbxLugar.TabIndex = 53
        '
        'gbxPrenadaS
        '
        Me.gbxPrenadaS.Controls.Add(Me.tbxaaaarv)
        Me.gbxPrenadaS.Controls.Add(Me.tbxmmrv)
        Me.gbxPrenadaS.Controls.Add(Me.lblRecriavuelta)
        Me.gbxPrenadaS.Controls.Add(Me.tbxddrv)
        Me.gbxPrenadaS.Controls.Add(Me.tbxaaaaRI)
        Me.gbxPrenadaS.Controls.Add(Me.tbxmmri)
        Me.gbxPrenadaS.Controls.Add(Me.lblRecriaIda)
        Me.gbxPrenadaS.Controls.Add(Me.tbxddri)
        Me.gbxPrenadaS.Controls.Add(Me.tbxaaaap)
        Me.gbxPrenadaS.Controls.Add(Me.tbxmmp)
        Me.gbxPrenadaS.Controls.Add(Me.lblFechaP)
        Me.gbxPrenadaS.Controls.Add(Me.tbxddP)
        Me.gbxPrenadaS.Location = New System.Drawing.Point(398, 366)
        Me.gbxPrenadaS.Name = "gbxPrenadaS"
        Me.gbxPrenadaS.Size = New System.Drawing.Size(399, 144)
        Me.gbxPrenadaS.TabIndex = 56
        Me.gbxPrenadaS.TabStop = False
        '
        'tbxaaaarv
        '
        Me.tbxaaaarv.Enabled = False
        Me.tbxaaaarv.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxaaaarv.Location = New System.Drawing.Point(340, 101)
        Me.tbxaaaarv.MaxLength = 4
        Me.tbxaaaarv.Name = "tbxaaaarv"
        Me.tbxaaaarv.Size = New System.Drawing.Size(54, 32)
        Me.tbxaaaarv.TabIndex = 64
        Me.tbxaaaarv.Text = "aaaa"
        Me.tbxaaaarv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxmmrv
        '
        Me.tbxmmrv.Enabled = False
        Me.tbxmmrv.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxmmrv.Location = New System.Drawing.Point(294, 101)
        Me.tbxmmrv.MaxLength = 2
        Me.tbxmmrv.Name = "tbxmmrv"
        Me.tbxmmrv.Size = New System.Drawing.Size(40, 32)
        Me.tbxmmrv.TabIndex = 63
        Me.tbxmmrv.Text = "mm"
        Me.tbxmmrv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRecriavuelta
        '
        Me.lblRecriavuelta.AutoSize = True
        Me.lblRecriavuelta.Enabled = False
        Me.lblRecriavuelta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecriavuelta.Location = New System.Drawing.Point(6, 104)
        Me.lblRecriavuelta.Name = "lblRecriavuelta"
        Me.lblRecriavuelta.Size = New System.Drawing.Size(241, 24)
        Me.lblRecriavuelta.TabIndex = 61
        Me.lblRecriavuelta.Text = "Campo de recria (vuelta)"
        '
        'tbxddrv
        '
        Me.tbxddrv.Enabled = False
        Me.tbxddrv.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxddrv.Location = New System.Drawing.Point(251, 101)
        Me.tbxddrv.MaxLength = 2
        Me.tbxddrv.Name = "tbxddrv"
        Me.tbxddrv.Size = New System.Drawing.Size(37, 32)
        Me.tbxddrv.TabIndex = 62
        Me.tbxddrv.Text = "dd"
        Me.tbxddrv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxaaaaRI
        '
        Me.tbxaaaaRI.Enabled = False
        Me.tbxaaaaRI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxaaaaRI.Location = New System.Drawing.Point(340, 63)
        Me.tbxaaaaRI.MaxLength = 4
        Me.tbxaaaaRI.Name = "tbxaaaaRI"
        Me.tbxaaaaRI.Size = New System.Drawing.Size(54, 32)
        Me.tbxaaaaRI.TabIndex = 60
        Me.tbxaaaaRI.Text = "aaaa"
        Me.tbxaaaaRI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxmmri
        '
        Me.tbxmmri.Enabled = False
        Me.tbxmmri.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxmmri.Location = New System.Drawing.Point(294, 63)
        Me.tbxmmri.MaxLength = 2
        Me.tbxmmri.Name = "tbxmmri"
        Me.tbxmmri.Size = New System.Drawing.Size(40, 32)
        Me.tbxmmri.TabIndex = 59
        Me.tbxmmri.Text = "mm"
        Me.tbxmmri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRecriaIda
        '
        Me.lblRecriaIda.AutoSize = True
        Me.lblRecriaIda.Enabled = False
        Me.lblRecriaIda.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecriaIda.Location = New System.Drawing.Point(6, 66)
        Me.lblRecriaIda.Name = "lblRecriaIda"
        Me.lblRecriaIda.Size = New System.Drawing.Size(213, 24)
        Me.lblRecriaIda.TabIndex = 57
        Me.lblRecriaIda.Text = "Campo de recria (ida)"
        '
        'tbxddri
        '
        Me.tbxddri.Enabled = False
        Me.tbxddri.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxddri.Location = New System.Drawing.Point(251, 63)
        Me.tbxddri.MaxLength = 2
        Me.tbxddri.Name = "tbxddri"
        Me.tbxddri.Size = New System.Drawing.Size(37, 32)
        Me.tbxddri.TabIndex = 58
        Me.tbxddri.Text = "dd"
        Me.tbxddri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxaaaap
        '
        Me.tbxaaaap.Enabled = False
        Me.tbxaaaap.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxaaaap.Location = New System.Drawing.Point(340, 19)
        Me.tbxaaaap.MaxLength = 4
        Me.tbxaaaap.Name = "tbxaaaap"
        Me.tbxaaaap.Size = New System.Drawing.Size(54, 32)
        Me.tbxaaaap.TabIndex = 56
        Me.tbxaaaap.Text = "aaaa"
        Me.tbxaaaap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxmmp
        '
        Me.tbxmmp.Enabled = False
        Me.tbxmmp.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxmmp.Location = New System.Drawing.Point(294, 19)
        Me.tbxmmp.MaxLength = 2
        Me.tbxmmp.Name = "tbxmmp"
        Me.tbxmmp.Size = New System.Drawing.Size(40, 32)
        Me.tbxmmp.TabIndex = 55
        Me.tbxmmp.Text = "mm"
        Me.tbxmmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFechaP
        '
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Enabled = False
        Me.lblFechaP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaP.Location = New System.Drawing.Point(6, 22)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(137, 24)
        Me.lblFechaP.TabIndex = 47
        Me.lblFechaP.Text = "Fecha preñez"
        '
        'tbxddP
        '
        Me.tbxddP.Enabled = False
        Me.tbxddP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxddP.Location = New System.Drawing.Point(251, 19)
        Me.tbxddP.MaxLength = 2
        Me.tbxddP.Name = "tbxddP"
        Me.tbxddP.Size = New System.Drawing.Size(37, 32)
        Me.tbxddP.TabIndex = 54
        Me.tbxddP.Text = "dd"
        Me.tbxddP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxPrenadaS)
        Me.Controls.Add(Me.gbxBasico)
        Me.Controls.Add(Me.btnGenealogia)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gbxHembra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbxLeche)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "frmIngresar"
        Me.Text = "Ingresar"
        Me.gbxAntibiotico.ResumeLayout(False)
        Me.gbxAntibiotico.PerformLayout()
        Me.gbxPrenada.ResumeLayout(False)
        Me.gbxPrenada.PerformLayout()
        Me.gbxLeche.ResumeLayout(False)
        Me.gbxLeche.PerformLayout()
        Me.gbxHembra.ResumeLayout(False)
        Me.gbxHembra.PerformLayout()
        Me.gbxBasico.ResumeLayout(False)
        Me.gbxBasico.PerformLayout()
        Me.gbxPrenadaS.ResumeLayout(False)
        Me.gbxPrenadaS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblPrenada As System.Windows.Forms.Label
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents cbxRaza As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDivision As System.Windows.Forms.ComboBox
    Friend WithEvents rbnNoa As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSia As System.Windows.Forms.RadioButton
    Friend WithEvents lblAntibiotico As System.Windows.Forms.Label
    Friend WithEvents tbxPorcentajep As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcentajep As System.Windows.Forms.Label
    Friend WithEvents gbxAntibiotico As System.Windows.Forms.GroupBox
    Friend WithEvents gbxPrenada As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSip As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNop As System.Windows.Forms.RadioButton
    Friend WithEvents gbxLeche As System.Windows.Forms.GroupBox
    Friend WithEvents tbxGrasa As System.Windows.Forms.TextBox
    Friend WithEvents lblGrasa As System.Windows.Forms.Label
    Friend WithEvents tbxProteina As System.Windows.Forms.TextBox
    Friend WithEvents lblProteina As System.Windows.Forms.Label
    Friend WithEvents tbxUrea As System.Windows.Forms.TextBox
    Friend WithEvents lblUrea As System.Windows.Forms.Label
    Friend WithEvents tbxRecuentocel As System.Windows.Forms.TextBox
    Friend WithEvents lblRecuentoCel As System.Windows.Forms.Label
    Friend WithEvents tbxRecuentobac As System.Windows.Forms.TextBox
    Friend WithEvents lblLitros As System.Windows.Forms.Label
    Friend WithEvents lblRecuentobac As System.Windows.Forms.Label
    Friend WithEvents tbxLitros As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbxHembra As System.Windows.Forms.GroupBox
    Friend WithEvents tbxDd As System.Windows.Forms.TextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents tbxMm As System.Windows.Forms.TextBox
    Friend WithEvents tbxAaaa As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnGenealogia As System.Windows.Forms.Button
    Friend WithEvents gbxBasico As System.Windows.Forms.GroupBox
    Friend WithEvents gbxPrenadaS As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLugar As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaP As System.Windows.Forms.Label
    Friend WithEvents tbxaaaap As System.Windows.Forms.TextBox
    Friend WithEvents tbxmmp As System.Windows.Forms.TextBox
    Friend WithEvents tbxddP As System.Windows.Forms.TextBox
    Friend WithEvents tbxaaaarv As System.Windows.Forms.TextBox
    Friend WithEvents tbxmmrv As System.Windows.Forms.TextBox
    Friend WithEvents lblRecriavuelta As System.Windows.Forms.Label
    Friend WithEvents tbxddrv As System.Windows.Forms.TextBox
    Friend WithEvents tbxaaaaRI As System.Windows.Forms.TextBox
    Friend WithEvents tbxmmri As System.Windows.Forms.TextBox
    Friend WithEvents lblRecriaIda As System.Windows.Forms.Label
    Friend WithEvents tbxddri As System.Windows.Forms.TextBox
End Class
