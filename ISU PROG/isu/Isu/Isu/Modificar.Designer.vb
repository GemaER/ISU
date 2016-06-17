<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificar
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
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.lblPorcentajep = New System.Windows.Forms.Label()
        Me.lblAntibiotico = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblPrenada = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.gbxPrenada = New System.Windows.Forms.GroupBox()
        Me.rbnSip = New System.Windows.Forms.RadioButton()
        Me.rbnNop = New System.Windows.Forms.RadioButton()
        Me.gbxAntibiotico = New System.Windows.Forms.GroupBox()
        Me.rbnSia = New System.Windows.Forms.RadioButton()
        Me.rbnNoa = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbxDivisionh = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.tbxLugar = New System.Windows.Forms.TextBox()
        Me.tbxEdad = New System.Windows.Forms.TextBox()
        Me.cbmDivisionm = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.gbxLeche.SuspendLayout()
        Me.gbxPrenada.SuspendLayout()
        Me.gbxAntibiotico.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(226, 28)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(153, 32)
        Me.tbxNum.TabIndex = 22
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(12, 36)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 15
        Me.lblNumero.Text = "Numero"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(463, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(803, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 750)
        Me.Panel1.TabIndex = 47
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
        Me.gbxLeche.Location = New System.Drawing.Point(408, 118)
        Me.gbxLeche.Name = "gbxLeche"
        Me.gbxLeche.Size = New System.Drawing.Size(389, 384)
        Me.gbxLeche.TabIndex = 84
        Me.gbxLeche.TabStop = False
        Me.gbxLeche.Text = "Lactancia"
        Me.gbxLeche.Visible = False
        '
        'tbxGrasa
        '
        Me.tbxGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGrasa.Location = New System.Drawing.Point(262, 112)
        Me.tbxGrasa.MaxLength = 3
        Me.tbxGrasa.Name = "tbxGrasa"
        Me.tbxGrasa.Size = New System.Drawing.Size(121, 32)
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
        Me.tbxProteina.Location = New System.Drawing.Point(262, 155)
        Me.tbxProteina.MaxLength = 3
        Me.tbxProteina.Name = "tbxProteina"
        Me.tbxProteina.Size = New System.Drawing.Size(121, 32)
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
        Me.tbxUrea.Location = New System.Drawing.Point(262, 202)
        Me.tbxUrea.MaxLength = 3
        Me.tbxUrea.Name = "tbxUrea"
        Me.tbxUrea.Size = New System.Drawing.Size(121, 32)
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
        Me.tbxRecuentocel.Location = New System.Drawing.Point(262, 320)
        Me.tbxRecuentocel.MaxLength = 10
        Me.tbxRecuentocel.Name = "tbxRecuentocel"
        Me.tbxRecuentocel.Size = New System.Drawing.Size(121, 32)
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
        Me.tbxRecuentobac.Location = New System.Drawing.Point(262, 281)
        Me.tbxRecuentobac.MaxLength = 10
        Me.tbxRecuentobac.Name = "tbxRecuentobac"
        Me.tbxRecuentobac.Size = New System.Drawing.Size(121, 32)
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
        Me.tbxLitros.Location = New System.Drawing.Point(262, 19)
        Me.tbxLitros.Name = "tbxLitros"
        Me.tbxLitros.Size = New System.Drawing.Size(121, 32)
        Me.tbxLitros.TabIndex = 47
        '
        'lblPorcentajep
        '
        Me.lblPorcentajep.AutoSize = True
        Me.lblPorcentajep.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajep.Location = New System.Drawing.Point(12, 332)
        Me.lblPorcentajep.Name = "lblPorcentajep"
        Me.lblPorcentajep.Size = New System.Drawing.Size(208, 24)
        Me.lblPorcentajep.TabIndex = 83
        Me.lblPorcentajep.Text = "Porcentaje de preñez"
        Me.lblPorcentajep.Visible = False
        '
        'lblAntibiotico
        '
        Me.lblAntibiotico.AutoSize = True
        Me.lblAntibiotico.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntibiotico.Location = New System.Drawing.Point(12, 290)
        Me.lblAntibiotico.Name = "lblAntibiotico"
        Me.lblAntibiotico.Size = New System.Drawing.Size(202, 24)
        Me.lblAntibiotico.TabIndex = 82
        Me.lblAntibiotico.Text = "Antibiotico influyente"
        Me.lblAntibiotico.Visible = False
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(12, 110)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 81
        Me.lblSexo.Text = "Sexo"
        Me.lblSexo.Visible = False
        '
        'lblPrenada
        '
        Me.lblPrenada.AutoSize = True
        Me.lblPrenada.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenada.Location = New System.Drawing.Point(12, 435)
        Me.lblPrenada.Name = "lblPrenada"
        Me.lblPrenada.Size = New System.Drawing.Size(89, 24)
        Me.lblPrenada.TabIndex = 80
        Me.lblPrenada.Text = "Preñada"
        Me.lblPrenada.Visible = False
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(12, 248)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(58, 24)
        Me.lblRaza.TabIndex = 79
        Me.lblRaza.Text = "Raza"
        Me.lblRaza.Visible = False
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(12, 478)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(65, 24)
        Me.lblEtapa.TabIndex = 78
        Me.lblEtapa.Text = "Etapa"
        Me.lblEtapa.Visible = False
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(12, 201)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(125, 24)
        Me.lblLugar.TabIndex = 77
        Me.lblLugar.Text = "Lugar actual"
        Me.lblLugar.Visible = False
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(12, 158)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(58, 24)
        Me.lblEdad.TabIndex = 76
        Me.lblEdad.Text = "Edad"
        Me.lblEdad.Visible = False
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(12, 387)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(85, 24)
        Me.lblDivision.TabIndex = 75
        Me.lblDivision.Text = "Division"
        Me.lblDivision.Visible = False
        '
        'gbxPrenada
        '
        Me.gbxPrenada.Controls.Add(Me.rbnSip)
        Me.gbxPrenada.Controls.Add(Me.rbnNop)
        Me.gbxPrenada.Location = New System.Drawing.Point(226, 427)
        Me.gbxPrenada.Name = "gbxPrenada"
        Me.gbxPrenada.Size = New System.Drawing.Size(153, 42)
        Me.gbxPrenada.TabIndex = 94
        Me.gbxPrenada.TabStop = False
        Me.gbxPrenada.Visible = False
        '
        'rbnSip
        '
        Me.rbnSip.AutoSize = True
        Me.rbnSip.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSip.Location = New System.Drawing.Point(19, 9)
        Me.rbnSip.Name = "rbnSip"
        Me.rbnSip.Size = New System.Drawing.Size(47, 28)
        Me.rbnSip.TabIndex = 39
        Me.rbnSip.TabStop = True
        Me.rbnSip.Text = "Si"
        Me.rbnSip.UseVisualStyleBackColor = True
        Me.rbnSip.Visible = False
        '
        'rbnNop
        '
        Me.rbnNop.AutoSize = True
        Me.rbnNop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNop.Location = New System.Drawing.Point(93, 8)
        Me.rbnNop.Name = "rbnNop"
        Me.rbnNop.Size = New System.Drawing.Size(54, 28)
        Me.rbnNop.TabIndex = 40
        Me.rbnNop.TabStop = True
        Me.rbnNop.Text = "No"
        Me.rbnNop.UseVisualStyleBackColor = True
        Me.rbnNop.Visible = False
        '
        'gbxAntibiotico
        '
        Me.gbxAntibiotico.Controls.Add(Me.rbnSia)
        Me.gbxAntibiotico.Controls.Add(Me.rbnNoa)
        Me.gbxAntibiotico.Location = New System.Drawing.Point(226, 283)
        Me.gbxAntibiotico.Name = "gbxAntibiotico"
        Me.gbxAntibiotico.Size = New System.Drawing.Size(153, 40)
        Me.gbxAntibiotico.TabIndex = 93
        Me.gbxAntibiotico.TabStop = False
        Me.gbxAntibiotico.Visible = False
        '
        'rbnSia
        '
        Me.rbnSia.AutoSize = True
        Me.rbnSia.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSia.Location = New System.Drawing.Point(19, 7)
        Me.rbnSia.Name = "rbnSia"
        Me.rbnSia.Size = New System.Drawing.Size(47, 28)
        Me.rbnSia.TabIndex = 39
        Me.rbnSia.TabStop = True
        Me.rbnSia.Text = "Si"
        Me.rbnSia.UseVisualStyleBackColor = True
        Me.rbnSia.Visible = False
        '
        'rbnNoa
        '
        Me.rbnNoa.AutoSize = True
        Me.rbnNoa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnNoa.Location = New System.Drawing.Point(93, 7)
        Me.rbnNoa.Name = "rbnNoa"
        Me.rbnNoa.Size = New System.Drawing.Size(54, 28)
        Me.rbnNoa.TabIndex = 40
        Me.rbnNoa.TabStop = True
        Me.rbnNoa.Text = "No"
        Me.rbnNoa.UseVisualStyleBackColor = True
        Me.rbnNoa.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(226, 329)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 32)
        Me.TextBox1.TabIndex = 92
        Me.TextBox1.Visible = False
        '
        'cbxDivisionh
        '
        Me.cbxDivisionh.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivisionh.FormattingEnabled = True
        Me.cbxDivisionh.Items.AddRange(New Object() {"Vaca", "Vaquillona"})
        Me.cbxDivisionh.Location = New System.Drawing.Point(226, 384)
        Me.cbxDivisionh.Name = "cbxDivisionh"
        Me.cbxDivisionh.Size = New System.Drawing.Size(153, 32)
        Me.cbxDivisionh.TabIndex = 91
        Me.cbxDivisionh.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.ComboBox1.Location = New System.Drawing.Point(226, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 32)
        Me.ComboBox1.TabIndex = 90
        Me.ComboBox1.Visible = False
        '
        'cbxEtapa
        '
        Me.cbxEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEtapa.FormattingEnabled = True
        Me.cbxEtapa.Items.AddRange(New Object() {"Servicio", "Preñada", "Lactancia", "Destete"})
        Me.cbxEtapa.Location = New System.Drawing.Point(226, 475)
        Me.cbxEtapa.Name = "cbxEtapa"
        Me.cbxEtapa.Size = New System.Drawing.Size(153, 32)
        Me.cbxEtapa.TabIndex = 89
        Me.cbxEtapa.Visible = False
        '
        'cbxTipo
        '
        Me.cbxTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Jersey", "Holando"})
        Me.cbxTipo.Location = New System.Drawing.Point(226, 245)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(153, 32)
        Me.cbxTipo.TabIndex = 88
        Me.cbxTipo.Visible = False
        '
        'tbxLugar
        '
        Me.tbxLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLugar.Location = New System.Drawing.Point(226, 198)
        Me.tbxLugar.MaxLength = 11
        Me.tbxLugar.Name = "tbxLugar"
        Me.tbxLugar.Size = New System.Drawing.Size(153, 32)
        Me.tbxLugar.TabIndex = 87
        Me.tbxLugar.Visible = False
        '
        'tbxEdad
        '
        Me.tbxEdad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEdad.Location = New System.Drawing.Point(226, 155)
        Me.tbxEdad.MaxLength = 2
        Me.tbxEdad.Name = "tbxEdad"
        Me.tbxEdad.Size = New System.Drawing.Size(153, 32)
        Me.tbxEdad.TabIndex = 86
        Me.tbxEdad.Visible = False
        '
        'cbmDivisionm
        '
        Me.cbmDivisionm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmDivisionm.FormattingEnabled = True
        Me.cbmDivisionm.Items.AddRange(New Object() {"Novillo", "Toro"})
        Me.cbmDivisionm.Location = New System.Drawing.Point(226, 384)
        Me.cbmDivisionm.Name = "cbmDivisionm"
        Me.cbmDivisionm.Size = New System.Drawing.Size(153, 32)
        Me.cbmDivisionm.TabIndex = 85
        Me.cbmDivisionm.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(644, 22)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 42)
        Me.btnModificar.TabIndex = 95
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbxPrenada)
        Me.Controls.Add(Me.gbxAntibiotico)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbxDivisionh)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cbxEtapa)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.tbxLugar)
        Me.Controls.Add(Me.tbxEdad)
        Me.Controls.Add(Me.cbmDivisionm)
        Me.Controls.Add(Me.gbxLeche)
        Me.Controls.Add(Me.lblPorcentajep)
        Me.Controls.Add(Me.lblAntibiotico)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblPrenada)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblEtapa)
        Me.Controls.Add(Me.lblLugar)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "frmModificar"
        Me.Text = "Modificar"
        Me.gbxLeche.ResumeLayout(False)
        Me.gbxLeche.PerformLayout()
        Me.gbxPrenada.ResumeLayout(False)
        Me.gbxPrenada.PerformLayout()
        Me.gbxAntibiotico.ResumeLayout(False)
        Me.gbxAntibiotico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents lblPorcentajep As System.Windows.Forms.Label
    Friend WithEvents lblAntibiotico As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblPrenada As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents gbxPrenada As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSip As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNop As System.Windows.Forms.RadioButton
    Friend WithEvents gbxAntibiotico As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSia As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNoa As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cbxDivisionh As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents tbxLugar As System.Windows.Forms.TextBox
    Friend WithEvents tbxEdad As System.Windows.Forms.TextBox
    Friend WithEvents cbmDivisionm As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
