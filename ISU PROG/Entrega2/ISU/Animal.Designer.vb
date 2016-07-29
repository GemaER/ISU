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
        Me.lblRecriavuelta = New System.Windows.Forms.Label()
        Me.lblRecriaIda = New System.Windows.Forms.Label()
        Me.dtppreñez = New System.Windows.Forms.DateTimePicker()
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbxHembra = New System.Windows.Forms.GroupBox()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxM = New System.Windows.Forms.GroupBox()
        Me.lblNumM = New System.Windows.Forms.Label()
        Me.lblSexoM = New System.Windows.Forms.Label()
        Me.lblRazaM = New System.Windows.Forms.Label()
        Me.gbxH = New System.Windows.Forms.GroupBox()
        Me.lblNumH = New System.Windows.Forms.Label()
        Me.lblSexoH = New System.Windows.Forms.Label()
        Me.lblRazaH = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gbxPrenadaS.SuspendLayout()
        Me.gbxBasico.SuspendLayout()
        Me.gbxHembra.SuspendLayout()
        Me.gbxM.SuspendLayout()
        Me.gbxH.SuspendLayout()
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
        Me.gbxPrenadaS.Size = New System.Drawing.Size(374, 188)
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
        'dtppreñez
        '
        Me.dtppreñez.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtppreñez.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppreñez.Location = New System.Drawing.Point(211, 55)
        Me.dtppreñez.Name = "dtppreñez"
        Me.dtppreñez.Size = New System.Drawing.Size(145, 32)
        Me.dtppreñez.TabIndex = 66
        '
        'lblFechaP
        '
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Enabled = False
        Me.lblFechaP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaP.Location = New System.Drawing.Point(6, 61)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(124, 24)
        Me.lblFechaP.TabIndex = 47
        Me.lblFechaP.Text = "Fecha inicio"
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
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(272, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gbxHembra
        '
        Me.gbxHembra.Controls.Add(Me.Button1)
        Me.gbxHembra.Controls.Add(Me.DateTimePicker1)
        Me.gbxHembra.Controls.Add(Me.Label1)
        Me.gbxHembra.Controls.Add(Me.dtppreñez)
        Me.gbxHembra.Controls.Add(Me.lblFechaP)
        Me.gbxHembra.Controls.Add(Me.lblEtapa)
        Me.gbxHembra.Controls.Add(Me.cbxEtapa)
        Me.gbxHembra.Enabled = False
        Me.gbxHembra.Location = New System.Drawing.Point(414, 336)
        Me.gbxHembra.Name = "gbxHembra"
        Me.gbxHembra.Size = New System.Drawing.Size(376, 188)
        Me.gbxHembra.TabIndex = 62
        Me.gbxHembra.TabStop = False
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(6, 16)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(65, 24)
        Me.lblEtapa.TabIndex = 5
        Me.lblEtapa.Text = "Etapa"
        '
        'cbxEtapa
        '
        Me.cbxEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEtapa.FormattingEnabled = True
        Me.cbxEtapa.Items.AddRange(New Object() {"Ninguno", "Servicio", "Preñada", "Lactancia", "Seca", "Antibiotico"})
        Me.cbxEtapa.Location = New System.Drawing.Point(213, 13)
        Me.cbxEtapa.Name = "cbxEtapa"
        Me.cbxEtapa.Size = New System.Drawing.Size(144, 32)
        Me.cbxEtapa.TabIndex = 34
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(121, 35)
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
        Me.btnOpcion.Location = New System.Drawing.Point(540, 289)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 105
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(211, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 32)
        Me.DateTimePicker1.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Fecha fin"
        '
        'gbxM
        '
        Me.gbxM.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbxM.Controls.Add(Me.Button2)
        Me.gbxM.Controls.Add(Me.ComboBox4)
        Me.gbxM.Controls.Add(Me.ComboBox1)
        Me.gbxM.Controls.Add(Me.TextBox1)
        Me.gbxM.Controls.Add(Me.lblNumM)
        Me.gbxM.Controls.Add(Me.lblSexoM)
        Me.gbxM.Controls.Add(Me.lblRazaM)
        Me.gbxM.Location = New System.Drawing.Point(414, 29)
        Me.gbxM.Name = "gbxM"
        Me.gbxM.Size = New System.Drawing.Size(376, 126)
        Me.gbxM.TabIndex = 111
        Me.gbxM.TabStop = False
        Me.gbxM.Text = "progenitor macho"
        '
        'lblNumM
        '
        Me.lblNumM.AutoSize = True
        Me.lblNumM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumM.Location = New System.Drawing.Point(6, 15)
        Me.lblNumM.Name = "lblNumM"
        Me.lblNumM.Size = New System.Drawing.Size(82, 24)
        Me.lblNumM.TabIndex = 49
        Me.lblNumM.Text = "Numero"
        '
        'lblSexoM
        '
        Me.lblSexoM.AutoSize = True
        Me.lblSexoM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoM.Location = New System.Drawing.Point(6, 51)
        Me.lblSexoM.Name = "lblSexoM"
        Me.lblSexoM.Size = New System.Drawing.Size(58, 24)
        Me.lblSexoM.TabIndex = 51
        Me.lblSexoM.Text = "Sexo"
        '
        'lblRazaM
        '
        Me.lblRazaM.AutoSize = True
        Me.lblRazaM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaM.Location = New System.Drawing.Point(6, 89)
        Me.lblRazaM.Name = "lblRazaM"
        Me.lblRazaM.Size = New System.Drawing.Size(58, 24)
        Me.lblRazaM.TabIndex = 50
        Me.lblRazaM.Text = "Raza"
        '
        'gbxH
        '
        Me.gbxH.BackColor = System.Drawing.Color.Bisque
        Me.gbxH.Controls.Add(Me.Button3)
        Me.gbxH.Controls.Add(Me.ComboBox3)
        Me.gbxH.Controls.Add(Me.ComboBox2)
        Me.gbxH.Controls.Add(Me.TextBox2)
        Me.gbxH.Controls.Add(Me.lblNumH)
        Me.gbxH.Controls.Add(Me.lblSexoH)
        Me.gbxH.Controls.Add(Me.lblRazaH)
        Me.gbxH.Location = New System.Drawing.Point(414, 157)
        Me.gbxH.Name = "gbxH"
        Me.gbxH.Size = New System.Drawing.Size(376, 126)
        Me.gbxH.TabIndex = 110
        Me.gbxH.TabStop = False
        Me.gbxH.Text = "progenitor hembra"
        '
        'lblNumH
        '
        Me.lblNumH.AutoSize = True
        Me.lblNumH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumH.Location = New System.Drawing.Point(6, 16)
        Me.lblNumH.Name = "lblNumH"
        Me.lblNumH.Size = New System.Drawing.Size(82, 24)
        Me.lblNumH.TabIndex = 49
        Me.lblNumH.Text = "Numero"
        '
        'lblSexoH
        '
        Me.lblSexoH.AutoSize = True
        Me.lblSexoH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoH.Location = New System.Drawing.Point(6, 54)
        Me.lblSexoH.Name = "lblSexoH"
        Me.lblSexoH.Size = New System.Drawing.Size(58, 24)
        Me.lblSexoH.TabIndex = 51
        Me.lblSexoH.Text = "Sexo"
        '
        'lblRazaH
        '
        Me.lblRazaH.AutoSize = True
        Me.lblRazaH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaH.Location = New System.Drawing.Point(6, 92)
        Me.lblRazaH.Name = "lblRazaH"
        Me.lblRazaH.Size = New System.Drawing.Size(58, 24)
        Me.lblRazaH.TabIndex = 50
        Me.lblRazaH.Text = "Raza"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(126, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 42)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(99, 12)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 32)
        Me.TextBox1.TabIndex = 112
        Me.TextBox1.Text = "000000000"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(99, 13)
        Me.TextBox2.MaxLength = 9
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(145, 32)
        Me.TextBox2.TabIndex = 113
        Me.TextBox2.Text = "000000000"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.ComboBox1.Location = New System.Drawing.Point(99, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox1.TabIndex = 67
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.ComboBox2.Location = New System.Drawing.Point(99, 51)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox2.TabIndex = 113
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.ComboBox3.Location = New System.Drawing.Point(99, 89)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox3.TabIndex = 67
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.ComboBox4.Location = New System.Drawing.Point(99, 86)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(145, 32)
        Me.ComboBox4.TabIndex = 114
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(250, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 42)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(250, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 42)
        Me.Button3.TabIndex = 115
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxM)
        Me.Controls.Add(Me.gbxH)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.gbxPrenadaS)
        Me.Controls.Add(Me.gbxBasico)
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
        Me.gbxM.ResumeLayout(False)
        Me.gbxM.PerformLayout()
        Me.gbxH.ResumeLayout(False)
        Me.gbxH.PerformLayout()
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
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbxHembra As System.Windows.Forms.GroupBox
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriavuelta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtppreñez As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxM As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumM As System.Windows.Forms.Label
    Friend WithEvents lblSexoM As System.Windows.Forms.Label
    Friend WithEvents lblRazaM As System.Windows.Forms.Label
    Friend WithEvents gbxH As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumH As System.Windows.Forms.Label
    Friend WithEvents lblSexoH As System.Windows.Forms.Label
    Friend WithEvents lblRazaH As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
