<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimal
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
        Me.gbxPrenadaS = New System.Windows.Forms.GroupBox()
        Me.dtprecriavuelta = New System.Windows.Forms.DateTimePicker()
        Me.dtprecriaida = New System.Windows.Forms.DateTimePicker()
        Me.dtppreñez = New System.Windows.Forms.DateTimePicker()
        Me.lblRecriavuelta = New System.Windows.Forms.Label()
        Me.lblRecriaIda = New System.Windows.Forms.Label()
        Me.lblFechaP = New System.Windows.Forms.Label()
        Me.gbxBasico = New System.Windows.Forms.GroupBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbxLugar = New System.Windows.Forms.ComboBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbxRaza = New System.Windows.Forms.ComboBox()
        Me.cbxDivision = New System.Windows.Forms.ComboBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.btnGenealogia = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbxHembra = New System.Windows.Forms.GroupBox()
        Me.lblAntibiotico = New System.Windows.Forms.Label()
        Me.gbxPrenada = New System.Windows.Forms.GroupBox()
        Me.rbnSip = New System.Windows.Forms.RadioButton()
        Me.rbnNop = New System.Windows.Forms.RadioButton()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.gbxAntibiotico = New System.Windows.Forms.GroupBox()
        Me.rbnSia = New System.Windows.Forms.RadioButton()
        Me.rbnNoa = New System.Windows.Forms.RadioButton()
        Me.lblPrenada = New System.Windows.Forms.Label()
        Me.tbxPorcentajep = New System.Windows.Forms.TextBox()
        Me.lblPorcentajep = New System.Windows.Forms.Label()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.gbxX = New System.Windows.Forms.GroupBox()
        Me.gbxPrenadaS.SuspendLayout()
        Me.gbxBasico.SuspendLayout()
        Me.gbxHembra.SuspendLayout()
        Me.gbxPrenada.SuspendLayout()
        Me.gbxAntibiotico.SuspendLayout()
        Me.gbxX.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPrenadaS
        '
        Me.gbxPrenadaS.Controls.Add(Me.dtprecriavuelta)
        Me.gbxPrenadaS.Controls.Add(Me.dtprecriaida)
        Me.gbxPrenadaS.Controls.Add(Me.lblRecriavuelta)
        Me.gbxPrenadaS.Controls.Add(Me.lblRecriaIda)
        Me.gbxPrenadaS.Location = New System.Drawing.Point(12, 336)
        Me.gbxPrenadaS.Name = "gbxPrenadaS"
        Me.gbxPrenadaS.Size = New System.Drawing.Size(374, 174)
        Me.gbxPrenadaS.TabIndex = 66
        Me.gbxPrenadaS.TabStop = False
        '
        'dtprecriavuelta
        '
        Me.dtprecriavuelta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprecriavuelta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtprecriavuelta.Location = New System.Drawing.Point(167, 125)
        Me.dtprecriavuelta.Name = "dtprecriavuelta"
        Me.dtprecriavuelta.Size = New System.Drawing.Size(145, 32)
        Me.dtprecriavuelta.TabIndex = 68
        '
        'dtprecriaida
        '
        Me.dtprecriaida.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprecriaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtprecriaida.Location = New System.Drawing.Point(167, 60)
        Me.dtprecriaida.Name = "dtprecriaida"
        Me.dtprecriaida.Size = New System.Drawing.Size(145, 32)
        Me.dtprecriaida.TabIndex = 67
        '
        'dtppreñez
        '
        Me.dtppreñez.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtppreñez.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppreñez.Location = New System.Drawing.Point(211, 28)
        Me.dtppreñez.Name = "dtppreñez"
        Me.dtppreñez.Size = New System.Drawing.Size(145, 32)
        Me.dtppreñez.TabIndex = 66
        '
        'lblRecriavuelta
        '
        Me.lblRecriavuelta.AutoSize = True
        Me.lblRecriavuelta.Enabled = False
        Me.lblRecriavuelta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecriavuelta.Location = New System.Drawing.Point(41, 98)
        Me.lblRecriavuelta.Name = "lblRecriavuelta"
        Me.lblRecriavuelta.Size = New System.Drawing.Size(241, 24)
        Me.lblRecriavuelta.TabIndex = 61
        Me.lblRecriavuelta.Text = "Campo de recria (vuelta)"
        '
        'lblRecriaIda
        '
        Me.lblRecriaIda.AutoSize = True
        Me.lblRecriaIda.Enabled = False
        Me.lblRecriaIda.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecriaIda.Location = New System.Drawing.Point(41, 30)
        Me.lblRecriaIda.Name = "lblRecriaIda"
        Me.lblRecriaIda.Size = New System.Drawing.Size(213, 24)
        Me.lblRecriaIda.TabIndex = 57
        Me.lblRecriaIda.Text = "Campo de recria (ida)"
        '
        'lblFechaP
        '
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Enabled = False
        Me.lblFechaP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaP.Location = New System.Drawing.Point(6, 34)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(137, 24)
        Me.lblFechaP.TabIndex = 47
        Me.lblFechaP.Text = "Fecha preñez"
        '
        'gbxBasico
        '
        Me.gbxBasico.Controls.Add(Me.dtpNacimiento)
        Me.gbxBasico.Controls.Add(Me.cbxLugar)
        Me.gbxBasico.Controls.Add(Me.lblNacimiento)
        Me.gbxBasico.Controls.Add(Me.lblDivision)
        Me.gbxBasico.Controls.Add(Me.cbxSexo)
        Me.gbxBasico.Controls.Add(Me.lblSexo)
        Me.gbxBasico.Controls.Add(Me.cbxRaza)
        Me.gbxBasico.Controls.Add(Me.cbxDivision)
        Me.gbxBasico.Controls.Add(Me.lblRaza)
        Me.gbxBasico.Controls.Add(Me.lblLugar)
        Me.gbxBasico.Enabled = False
        Me.gbxBasico.Location = New System.Drawing.Point(12, 90)
        Me.gbxBasico.Name = "gbxBasico"
        Me.gbxBasico.Size = New System.Drawing.Size(374, 240)
        Me.gbxBasico.TabIndex = 65
        Me.gbxBasico.TabStop = False
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(213, 53)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(145, 32)
        Me.dtpNacimiento.TabIndex = 66
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
        'cbxDivision
        '
        Me.cbxDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivision.FormattingEnabled = True
        Me.cbxDivision.Location = New System.Drawing.Point(213, 194)
        Me.cbxDivision.Name = "cbxDivision"
        Me.cbxDivision.Size = New System.Drawing.Size(145, 32)
        Me.cbxDivision.TabIndex = 37
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
        'btnGenealogia
        '
        Me.btnGenealogia.Enabled = False
        Me.btnGenealogia.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenealogia.Location = New System.Drawing.Point(652, 26)
        Me.btnGenealogia.Name = "btnGenealogia"
        Me.btnGenealogia.Size = New System.Drawing.Size(141, 42)
        Me.btnGenealogia.TabIndex = 64
        Me.btnGenealogia.Text = "Genealogia"
        Me.btnGenealogia.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(404, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.gbxHembra.Location = New System.Drawing.Point(414, 90)
        Me.gbxHembra.Name = "gbxHembra"
        Me.gbxHembra.Size = New System.Drawing.Size(376, 240)
        Me.gbxHembra.TabIndex = 62
        Me.gbxHembra.TabStop = False
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
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(228, 32)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(145, 32)
        Me.tbxNum.TabIndex = 58
        Me.tbxNum.Text = "000000000"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(20, 35)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 57
        Me.lblNumero.Text = "Numero"
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlBlue.Location = New System.Drawing.Point(803, 0)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(24, 579)
        Me.pnlBlue.TabIndex = 72
        Me.pnlBlue.Visible = False
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(528, 26)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 105
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'gbxX
        '
        Me.gbxX.Controls.Add(Me.dtppreñez)
        Me.gbxX.Controls.Add(Me.lblFechaP)
        Me.gbxX.Location = New System.Drawing.Point(414, 336)
        Me.gbxX.Name = "gbxX"
        Me.gbxX.Size = New System.Drawing.Size(376, 174)
        Me.gbxX.TabIndex = 107
        Me.gbxX.TabStop = False
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxX)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.gbxPrenadaS)
        Me.Controls.Add(Me.gbxBasico)
        Me.Controls.Add(Me.btnGenealogia)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gbxHembra)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "frmAnimal"
        Me.Text = "Animal"
        Me.gbxPrenadaS.ResumeLayout(False)
        Me.gbxPrenadaS.PerformLayout()
        Me.gbxBasico.ResumeLayout(False)
        Me.gbxBasico.PerformLayout()
        Me.gbxHembra.ResumeLayout(False)
        Me.gbxHembra.PerformLayout()
        Me.gbxPrenada.ResumeLayout(False)
        Me.gbxPrenada.PerformLayout()
        Me.gbxAntibiotico.ResumeLayout(False)
        Me.gbxAntibiotico.PerformLayout()
        Me.gbxX.ResumeLayout(False)
        Me.gbxX.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxPrenadaS As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecriavuelta As System.Windows.Forms.Label
    Friend WithEvents lblRecriaIda As System.Windows.Forms.Label
    Friend WithEvents lblFechaP As System.Windows.Forms.Label
    Friend WithEvents gbxBasico As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLugar As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cbxRaza As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents btnGenealogia As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbxHembra As System.Windows.Forms.GroupBox
    Friend WithEvents lblAntibiotico As System.Windows.Forms.Label
    Friend WithEvents gbxPrenada As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSip As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNop As System.Windows.Forms.RadioButton
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents gbxAntibiotico As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSia As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNoa As System.Windows.Forms.RadioButton
    Friend WithEvents lblPrenada As System.Windows.Forms.Label
    Friend WithEvents tbxPorcentajep As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcentajep As System.Windows.Forms.Label
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriavuelta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtppreñez As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents gbxX As System.Windows.Forms.GroupBox
End Class
