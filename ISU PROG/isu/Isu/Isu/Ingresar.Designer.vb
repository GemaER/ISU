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
        Me.cbxDivisionm = New System.Windows.Forms.ComboBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblPrenada = New System.Windows.Forms.Label()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.tbxLugar = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.cbxDivisionh = New System.Windows.Forms.ComboBox()
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
        Me.tbxEdad = New System.Windows.Forms.TextBox()
        Me.gbxAntibiotico.SuspendLayout()
        Me.gbxPrenada.SuspendLayout()
        Me.gbxLeche.SuspendLayout()
        Me.gbxHembra.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxDivisionm
        '
        Me.cbxDivisionm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivisionm.FormattingEnabled = True
        Me.cbxDivisionm.Items.AddRange(New Object() {"Novillo", "Toro", "Anestro"})
        Me.cbxDivisionm.Location = New System.Drawing.Point(229, 267)
        Me.cbxDivisionm.Name = "cbxDivisionm"
        Me.cbxDivisionm.Size = New System.Drawing.Size(145, 32)
        Me.cbxDivisionm.TabIndex = 0
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(21, 43)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "Numero"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(22, 267)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(85, 24)
        Me.lblDivision.TabIndex = 2
        Me.lblDivision.Text = "División"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(21, 136)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(140, 24)
        Me.lblEdad.TabIndex = 3
        Me.lblEdad.Text = "Edad (meses)"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(21, 179)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(125, 24)
        Me.lblLugar.TabIndex = 4
        Me.lblLugar.Text = "Lugar actual"
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(8, 153)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(65, 24)
        Me.lblEtapa.TabIndex = 5
        Me.lblEtapa.Text = "Etapa"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(21, 226)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(58, 24)
        Me.lblRaza.TabIndex = 6
        Me.lblRaza.Text = "Raza"
        '
        'lblPrenada
        '
        Me.lblPrenada.AutoSize = True
        Me.lblPrenada.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenada.Location = New System.Drawing.Point(8, 110)
        Me.lblPrenada.Name = "lblPrenada"
        Me.lblPrenada.Size = New System.Drawing.Size(89, 24)
        Me.lblPrenada.TabIndex = 7
        Me.lblPrenada.Text = "Preñada"
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(229, 40)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(145, 32)
        Me.tbxNum.TabIndex = 8
        '
        'tbxLugar
        '
        Me.tbxLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLugar.Location = New System.Drawing.Point(229, 176)
        Me.tbxLugar.MaxLength = 11
        Me.tbxLugar.Name = "tbxLugar"
        Me.tbxLugar.Size = New System.Drawing.Size(145, 32)
        Me.tbxLugar.TabIndex = 10
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(534, 450)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(118, 42)
        Me.btnIngresar.TabIndex = 30
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cbxTipo
        '
        Me.cbxTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxTipo.Location = New System.Drawing.Point(229, 223)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(145, 32)
        Me.cbxTipo.TabIndex = 31
        '
        'cbxEtapa
        '
        Me.cbxEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEtapa.FormattingEnabled = True
        Me.cbxEtapa.Items.AddRange(New Object() {"Servicio", "Preñada", "Lactancia", "Destete"})
        Me.cbxEtapa.Location = New System.Drawing.Point(216, 150)
        Me.cbxEtapa.Name = "cbxEtapa"
        Me.cbxEtapa.Size = New System.Drawing.Size(144, 32)
        Me.cbxEtapa.TabIndex = 34
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(21, 88)
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
        Me.cbxSexo.Location = New System.Drawing.Point(229, 85)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexo.TabIndex = 36
        '
        'cbxDivisionh
        '
        Me.cbxDivisionh.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivisionh.FormattingEnabled = True
        Me.cbxDivisionh.Items.AddRange(New Object() {"Vaca", "Vaquillona", "Anestro"})
        Me.cbxDivisionh.Location = New System.Drawing.Point(230, 267)
        Me.cbxDivisionh.Name = "cbxDivisionh"
        Me.cbxDivisionh.Size = New System.Drawing.Size(144, 32)
        Me.cbxDivisionh.TabIndex = 37
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
        Me.lblAntibiotico.Location = New System.Drawing.Point(8, 26)
        Me.lblAntibiotico.Name = "lblAntibiotico"
        Me.lblAntibiotico.Size = New System.Drawing.Size(202, 24)
        Me.lblAntibiotico.TabIndex = 38
        Me.lblAntibiotico.Text = "Antibiotico influyente"
        '
        'tbxPorcentajep
        '
        Me.tbxPorcentajep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPorcentajep.Location = New System.Drawing.Point(216, 65)
        Me.tbxPorcentajep.MaxLength = 3
        Me.tbxPorcentajep.Name = "tbxPorcentajep"
        Me.tbxPorcentajep.Size = New System.Drawing.Size(144, 32)
        Me.tbxPorcentajep.TabIndex = 42
        '
        'lblPorcentajep
        '
        Me.lblPorcentajep.AutoSize = True
        Me.lblPorcentajep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajep.Location = New System.Drawing.Point(8, 68)
        Me.lblPorcentajep.Name = "lblPorcentajep"
        Me.lblPorcentajep.Size = New System.Drawing.Size(208, 24)
        Me.lblPorcentajep.TabIndex = 41
        Me.lblPorcentajep.Text = "Porcentaje de preñez"
        '
        'gbxAntibiotico
        '
        Me.gbxAntibiotico.Controls.Add(Me.rbnSia)
        Me.gbxAntibiotico.Controls.Add(Me.rbnNoa)
        Me.gbxAntibiotico.Location = New System.Drawing.Point(216, 19)
        Me.gbxAntibiotico.Name = "gbxAntibiotico"
        Me.gbxAntibiotico.Size = New System.Drawing.Size(144, 40)
        Me.gbxAntibiotico.TabIndex = 43
        Me.gbxAntibiotico.TabStop = False
        '
        'gbxPrenada
        '
        Me.gbxPrenada.Controls.Add(Me.rbnSip)
        Me.gbxPrenada.Controls.Add(Me.rbnNop)
        Me.gbxPrenada.Location = New System.Drawing.Point(216, 103)
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
        Me.gbxLeche.Location = New System.Drawing.Point(408, 43)
        Me.gbxLeche.Name = "gbxLeche"
        Me.gbxLeche.Size = New System.Drawing.Size(389, 384)
        Me.gbxLeche.TabIndex = 45
        Me.gbxLeche.TabStop = False
        Me.gbxLeche.Text = "Lactancia"
        Me.gbxLeche.Visible = False
        '
        'tbxGrasa
        '
        Me.tbxGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGrasa.Location = New System.Drawing.Point(241, 112)
        Me.tbxGrasa.MaxLength = 3
        Me.tbxGrasa.Name = "tbxGrasa"
        Me.tbxGrasa.Size = New System.Drawing.Size(142, 32)
        Me.tbxGrasa.TabIndex = 57
        '
        'lblGrasa
        '
        Me.lblGrasa.AutoSize = True
        Me.lblGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrasa.Location = New System.Drawing.Point(6, 115)
        Me.lblGrasa.Name = "lblGrasa"
        Me.lblGrasa.Size = New System.Drawing.Size(199, 24)
        Me.lblGrasa.TabIndex = 56
        Me.lblGrasa.Text = "Porcentaje de grasa"
        '
        'tbxProteina
        '
        Me.tbxProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxProteina.Location = New System.Drawing.Point(241, 155)
        Me.tbxProteina.MaxLength = 3
        Me.tbxProteina.Name = "tbxProteina"
        Me.tbxProteina.Size = New System.Drawing.Size(142, 32)
        Me.tbxProteina.TabIndex = 55
        '
        'lblProteina
        '
        Me.lblProteina.AutoSize = True
        Me.lblProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteina.Location = New System.Drawing.Point(6, 158)
        Me.lblProteina.Name = "lblProteina"
        Me.lblProteina.Size = New System.Drawing.Size(222, 24)
        Me.lblProteina.TabIndex = 54
        Me.lblProteina.Text = "Porcentaje de proteina"
        '
        'tbxUrea
        '
        Me.tbxUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUrea.Location = New System.Drawing.Point(241, 202)
        Me.tbxUrea.MaxLength = 3
        Me.tbxUrea.Name = "tbxUrea"
        Me.tbxUrea.Size = New System.Drawing.Size(142, 32)
        Me.tbxUrea.TabIndex = 53
        '
        'lblUrea
        '
        Me.lblUrea.AutoSize = True
        Me.lblUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrea.Location = New System.Drawing.Point(6, 205)
        Me.lblUrea.Name = "lblUrea"
        Me.lblUrea.Size = New System.Drawing.Size(188, 24)
        Me.lblUrea.TabIndex = 52
        Me.lblUrea.Text = "Porcentaje de urea"
        '
        'tbxRecuentocel
        '
        Me.tbxRecuentocel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentocel.Location = New System.Drawing.Point(241, 320)
        Me.tbxRecuentocel.MaxLength = 10
        Me.tbxRecuentocel.Name = "tbxRecuentocel"
        Me.tbxRecuentocel.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentocel.TabIndex = 51
        '
        'lblRecuentoCel
        '
        Me.lblRecuentoCel.AutoSize = True
        Me.lblRecuentoCel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentoCel.Location = New System.Drawing.Point(6, 320)
        Me.lblRecuentoCel.Name = "lblRecuentoCel"
        Me.lblRecuentoCel.Size = New System.Drawing.Size(200, 48)
        Me.lblRecuentoCel.TabIndex = 50
        Me.lblRecuentoCel.Text = "Recuento de células" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      somáticas"
        '
        'tbxRecuentobac
        '
        Me.tbxRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentobac.Location = New System.Drawing.Point(241, 281)
        Me.tbxRecuentobac.MaxLength = 10
        Me.tbxRecuentobac.Name = "tbxRecuentobac"
        Me.tbxRecuentobac.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentobac.TabIndex = 49
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
        Me.lblRecuentobac.Location = New System.Drawing.Point(6, 284)
        Me.lblRecuentobac.Name = "lblRecuentobac"
        Me.lblRecuentobac.Size = New System.Drawing.Size(205, 24)
        Me.lblRecuentobac.TabIndex = 48
        Me.lblRecuentobac.Text = "Recuento bacteriano"
        '
        'tbxLitros
        '
        Me.tbxLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLitros.Location = New System.Drawing.Point(241, 19)
        Me.tbxLitros.Name = "tbxLitros"
        Me.tbxLitros.Size = New System.Drawing.Size(142, 32)
        Me.tbxLitros.TabIndex = 47
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
        Me.gbxHembra.Controls.Add(Me.cbxEtapa)
        Me.gbxHembra.Controls.Add(Me.lblPorcentajep)
        Me.gbxHembra.Location = New System.Drawing.Point(14, 305)
        Me.gbxHembra.Name = "gbxHembra"
        Me.gbxHembra.Size = New System.Drawing.Size(376, 194)
        Me.gbxHembra.TabIndex = 47
        Me.gbxHembra.TabStop = False
        Me.gbxHembra.Visible = False
        '
        'tbxEdad
        '
        Me.tbxEdad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEdad.Location = New System.Drawing.Point(230, 133)
        Me.tbxEdad.MaxLength = 3
        Me.tbxEdad.Name = "tbxEdad"
        Me.tbxEdad.Size = New System.Drawing.Size(144, 32)
        Me.tbxEdad.TabIndex = 48
        '
        'frmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.tbxEdad)
        Me.Controls.Add(Me.gbxHembra)
        Me.Controls.Add(Me.cbxDivisionm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.gbxLeche)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.tbxLugar)
        Me.Controls.Add(Me.cbxDivisionh)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblLugar)
        Me.Controls.Add(Me.lblEdad)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxDivisionm As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblPrenada As System.Windows.Forms.Label
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents tbxLugar As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDivisionh As System.Windows.Forms.ComboBox
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
    Friend WithEvents tbxEdad As System.Windows.Forms.TextBox
End Class
