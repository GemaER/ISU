<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminar
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
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
        Me.LblProcentajepr = New System.Windows.Forms.Label()
        Me.lblAntibioticor = New System.Windows.Forms.Label()
        Me.lblSexor = New System.Windows.Forms.Label()
        Me.lblPreñadar = New System.Windows.Forms.Label()
        Me.lblRazar = New System.Windows.Forms.Label()
        Me.lblEtapar = New System.Windows.Forms.Label()
        Me.lblLugarr = New System.Windows.Forms.Label()
        Me.lblEdadr = New System.Windows.Forms.Label()
        Me.lblDivisionr = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbxLeche.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(660, 39)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 42)
        Me.btnModificar.TabIndex = 45
        Me.btnModificar.Text = "Eliminar"
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(418, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 44
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(230, 45)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(121, 32)
        Me.tbxNum.TabIndex = 38
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(12, 48)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 31
        Me.lblNumero.Text = "Numero"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(1242, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 750)
        Me.Panel1.TabIndex = 75
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
        Me.gbxLeche.Location = New System.Drawing.Point(408, 111)
        Me.gbxLeche.Name = "gbxLeche"
        Me.gbxLeche.Size = New System.Drawing.Size(389, 384)
        Me.gbxLeche.TabIndex = 74
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
        Me.lblPorcentajep.Location = New System.Drawing.Point(12, 346)
        Me.lblPorcentajep.Name = "lblPorcentajep"
        Me.lblPorcentajep.Size = New System.Drawing.Size(208, 24)
        Me.lblPorcentajep.TabIndex = 70
        Me.lblPorcentajep.Text = "Porcentaje de preñez"
        Me.lblPorcentajep.Visible = False
        '
        'lblAntibiotico
        '
        Me.lblAntibiotico.AutoSize = True
        Me.lblAntibiotico.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntibiotico.Location = New System.Drawing.Point(12, 304)
        Me.lblAntibiotico.Name = "lblAntibiotico"
        Me.lblAntibiotico.Size = New System.Drawing.Size(202, 24)
        Me.lblAntibiotico.TabIndex = 69
        Me.lblAntibiotico.Text = "Antibiotico influyente"
        Me.lblAntibiotico.Visible = False
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(12, 124)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 66
        Me.lblSexo.Text = "Sexo"
        Me.lblSexo.Visible = False
        '
        'lblPrenada
        '
        Me.lblPrenada.AutoSize = True
        Me.lblPrenada.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenada.Location = New System.Drawing.Point(12, 449)
        Me.lblPrenada.Name = "lblPrenada"
        Me.lblPrenada.Size = New System.Drawing.Size(89, 24)
        Me.lblPrenada.TabIndex = 59
        Me.lblPrenada.Text = "Preñada"
        Me.lblPrenada.Visible = False
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(12, 262)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(58, 24)
        Me.lblRaza.TabIndex = 58
        Me.lblRaza.Text = "Raza"
        Me.lblRaza.Visible = False
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(12, 492)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(65, 24)
        Me.lblEtapa.TabIndex = 57
        Me.lblEtapa.Text = "Etapa"
        Me.lblEtapa.Visible = False
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(12, 215)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(125, 24)
        Me.lblLugar.TabIndex = 56
        Me.lblLugar.Text = "Lugar actual"
        Me.lblLugar.Visible = False
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(12, 172)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(58, 24)
        Me.lblEdad.TabIndex = 55
        Me.lblEdad.Text = "Edad"
        Me.lblEdad.Visible = False
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(12, 401)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(85, 24)
        Me.lblDivision.TabIndex = 54
        Me.lblDivision.Text = "Division"
        Me.lblDivision.Visible = False
        '
        'LblProcentajepr
        '
        Me.LblProcentajepr.AutoSize = True
        Me.LblProcentajepr.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcentajepr.Location = New System.Drawing.Point(226, 346)
        Me.LblProcentajepr.Name = "LblProcentajepr"
        Me.LblProcentajepr.Size = New System.Drawing.Size(16, 24)
        Me.LblProcentajepr.TabIndex = 84
        Me.LblProcentajepr.Text = " "
        Me.LblProcentajepr.Visible = False
        '
        'lblAntibioticor
        '
        Me.lblAntibioticor.AutoSize = True
        Me.lblAntibioticor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntibioticor.Location = New System.Drawing.Point(226, 304)
        Me.lblAntibioticor.Name = "lblAntibioticor"
        Me.lblAntibioticor.Size = New System.Drawing.Size(16, 24)
        Me.lblAntibioticor.TabIndex = 83
        Me.lblAntibioticor.Text = " "
        Me.lblAntibioticor.Visible = False
        '
        'lblSexor
        '
        Me.lblSexor.AutoSize = True
        Me.lblSexor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexor.Location = New System.Drawing.Point(226, 124)
        Me.lblSexor.Name = "lblSexor"
        Me.lblSexor.Size = New System.Drawing.Size(16, 24)
        Me.lblSexor.TabIndex = 82
        Me.lblSexor.Text = " "
        Me.lblSexor.Visible = False
        '
        'lblPreñadar
        '
        Me.lblPreñadar.AutoSize = True
        Me.lblPreñadar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreñadar.Location = New System.Drawing.Point(226, 449)
        Me.lblPreñadar.Name = "lblPreñadar"
        Me.lblPreñadar.Size = New System.Drawing.Size(16, 24)
        Me.lblPreñadar.TabIndex = 81
        Me.lblPreñadar.Text = " "
        Me.lblPreñadar.Visible = False
        '
        'lblRazar
        '
        Me.lblRazar.AutoSize = True
        Me.lblRazar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazar.Location = New System.Drawing.Point(226, 262)
        Me.lblRazar.Name = "lblRazar"
        Me.lblRazar.Size = New System.Drawing.Size(16, 24)
        Me.lblRazar.TabIndex = 80
        Me.lblRazar.Text = " "
        Me.lblRazar.Visible = False
        '
        'lblEtapar
        '
        Me.lblEtapar.AutoSize = True
        Me.lblEtapar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapar.Location = New System.Drawing.Point(226, 492)
        Me.lblEtapar.Name = "lblEtapar"
        Me.lblEtapar.Size = New System.Drawing.Size(16, 24)
        Me.lblEtapar.TabIndex = 79
        Me.lblEtapar.Text = " "
        Me.lblEtapar.Visible = False
        '
        'lblLugarr
        '
        Me.lblLugarr.AutoSize = True
        Me.lblLugarr.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugarr.Location = New System.Drawing.Point(226, 215)
        Me.lblLugarr.Name = "lblLugarr"
        Me.lblLugarr.Size = New System.Drawing.Size(16, 24)
        Me.lblLugarr.TabIndex = 78
        Me.lblLugarr.Text = " "
        Me.lblLugarr.Visible = False
        '
        'lblEdadr
        '
        Me.lblEdadr.AutoSize = True
        Me.lblEdadr.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadr.Location = New System.Drawing.Point(226, 172)
        Me.lblEdadr.Name = "lblEdadr"
        Me.lblEdadr.Size = New System.Drawing.Size(16, 24)
        Me.lblEdadr.TabIndex = 77
        Me.lblEdadr.Text = " "
        Me.lblEdadr.Visible = False
        '
        'lblDivisionr
        '
        Me.lblDivisionr.AutoSize = True
        Me.lblDivisionr.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionr.Location = New System.Drawing.Point(226, 401)
        Me.lblDivisionr.Name = "lblDivisionr"
        Me.lblDivisionr.Size = New System.Drawing.Size(16, 24)
        Me.lblDivisionr.TabIndex = 76
        Me.lblDivisionr.Text = " "
        Me.lblDivisionr.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Location = New System.Drawing.Point(803, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 714)
        Me.Panel2.TabIndex = 85
        '
        'frmEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblProcentajepr)
        Me.Controls.Add(Me.lblAntibioticor)
        Me.Controls.Add(Me.lblSexor)
        Me.Controls.Add(Me.lblPreñadar)
        Me.Controls.Add(Me.lblRazar)
        Me.Controls.Add(Me.lblEtapar)
        Me.Controls.Add(Me.lblLugarr)
        Me.Controls.Add(Me.lblEdadr)
        Me.Controls.Add(Me.lblDivisionr)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "frmEliminar"
        Me.Text = "Eliminar"
        Me.gbxLeche.ResumeLayout(False)
        Me.gbxLeche.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
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
    Friend WithEvents LblProcentajepr As System.Windows.Forms.Label
    Friend WithEvents lblAntibioticor As System.Windows.Forms.Label
    Friend WithEvents lblSexor As System.Windows.Forms.Label
    Friend WithEvents lblPreñadar As System.Windows.Forms.Label
    Friend WithEvents lblRazar As System.Windows.Forms.Label
    Friend WithEvents lblEtapar As System.Windows.Forms.Label
    Friend WithEvents lblLugarr As System.Windows.Forms.Label
    Friend WithEvents lblEdadr As System.Windows.Forms.Label
    Friend WithEvents lblDivisionr As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
