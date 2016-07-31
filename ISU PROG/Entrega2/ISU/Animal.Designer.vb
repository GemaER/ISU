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
        Me.gbxCria = New System.Windows.Forms.GroupBox()
        Me.dtprecriavuelta = New System.Windows.Forms.DateTimePicker()
        Me.dtprecriaida = New System.Windows.Forms.DateTimePicker()
        Me.lblRecriavuelta = New System.Windows.Forms.Label()
        Me.lblRecriaIda = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaI = New System.Windows.Forms.Label()
        Me.gbxBasico = New System.Windows.Forms.GroupBox()
        Me.gbxM = New System.Windows.Forms.GroupBox()
        Me.btnBuscarM = New System.Windows.Forms.Button()
        Me.cbxRazaM = New System.Windows.Forms.ComboBox()
        Me.cbxSexoM = New System.Windows.Forms.ComboBox()
        Me.tbxNumM = New System.Windows.Forms.TextBox()
        Me.lblNumM = New System.Windows.Forms.Label()
        Me.lblSexoM = New System.Windows.Forms.Label()
        Me.lblRazaM = New System.Windows.Forms.Label()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.gbxH = New System.Windows.Forms.GroupBox()
        Me.btnBuscarH = New System.Windows.Forms.Button()
        Me.cbxRazaH = New System.Windows.Forms.ComboBox()
        Me.cbxSexoH = New System.Windows.Forms.ComboBox()
        Me.tbxNumH = New System.Windows.Forms.TextBox()
        Me.lblNumH = New System.Windows.Forms.Label()
        Me.lblSexoH = New System.Windows.Forms.Label()
        Me.lblRazaH = New System.Windows.Forms.Label()
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
        Me.gbxEtapa = New System.Windows.Forms.GroupBox()
        Me.btnEvento = New System.Windows.Forms.Button()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaF = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.gbxCria.SuspendLayout()
        Me.gbxBasico.SuspendLayout()
        Me.gbxM.SuspendLayout()
        Me.gbxH.SuspendLayout()
        Me.gbxEtapa.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCria
        '
        Me.gbxCria.Controls.Add(Me.dtprecriavuelta)
        Me.gbxCria.Controls.Add(Me.dtprecriaida)
        Me.gbxCria.Controls.Add(Me.lblRecriavuelta)
        Me.gbxCria.Controls.Add(Me.lblRecriaIda)
        Me.gbxCria.Enabled = False
        Me.gbxCria.Location = New System.Drawing.Point(12, 336)
        Me.gbxCria.Name = "gbxCria"
        Me.gbxCria.Size = New System.Drawing.Size(374, 188)
        Me.gbxCria.TabIndex = 66
        Me.gbxCria.TabStop = False
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
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(211, 55)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(145, 32)
        Me.dtpInicio.TabIndex = 66
        '
        'lblFechaI
        '
        Me.lblFechaI.AutoSize = True
        Me.lblFechaI.Enabled = False
        Me.lblFechaI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaI.Location = New System.Drawing.Point(6, 61)
        Me.lblFechaI.Name = "lblFechaI"
        Me.lblFechaI.Size = New System.Drawing.Size(124, 24)
        Me.lblFechaI.TabIndex = 47
        Me.lblFechaI.Text = "Fecha inicio"
        '
        'gbxBasico
        '
        Me.gbxBasico.Controls.Add(Me.gbxM)
        Me.gbxBasico.Controls.Add(Me.dtpNacimiento)
        Me.gbxBasico.Controls.Add(Me.gbxH)
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
        Me.gbxBasico.Location = New System.Drawing.Point(12, 60)
        Me.gbxBasico.Name = "gbxBasico"
        Me.gbxBasico.Size = New System.Drawing.Size(785, 270)
        Me.gbxBasico.TabIndex = 65
        Me.gbxBasico.TabStop = False
        '
        'gbxM
        '
        Me.gbxM.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbxM.Controls.Add(Me.btnBuscarM)
        Me.gbxM.Controls.Add(Me.cbxRazaM)
        Me.gbxM.Controls.Add(Me.cbxSexoM)
        Me.gbxM.Controls.Add(Me.tbxNumM)
        Me.gbxM.Controls.Add(Me.lblNumM)
        Me.gbxM.Controls.Add(Me.lblSexoM)
        Me.gbxM.Controls.Add(Me.lblRazaM)
        Me.gbxM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxM.Location = New System.Drawing.Point(402, 10)
        Me.gbxM.Name = "gbxM"
        Me.gbxM.Size = New System.Drawing.Size(376, 126)
        Me.gbxM.TabIndex = 111
        Me.gbxM.TabStop = False
        Me.gbxM.Text = "progenitor macho"
        '
        'btnBuscarM
        '
        Me.btnBuscarM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarM.Location = New System.Drawing.Point(250, 42)
        Me.btnBuscarM.Name = "btnBuscarM"
        Me.btnBuscarM.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscarM.TabIndex = 112
        Me.btnBuscarM.Text = "Buscar"
        Me.btnBuscarM.UseVisualStyleBackColor = True
        '
        'cbxRazaM
        '
        Me.cbxRazaM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRazaM.FormattingEnabled = True
        Me.cbxRazaM.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxRazaM.Location = New System.Drawing.Point(99, 86)
        Me.cbxRazaM.Name = "cbxRazaM"
        Me.cbxRazaM.Size = New System.Drawing.Size(145, 32)
        Me.cbxRazaM.TabIndex = 114
        '
        'cbxSexoM
        '
        Me.cbxSexoM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexoM.FormattingEnabled = True
        Me.cbxSexoM.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.cbxSexoM.Location = New System.Drawing.Point(99, 48)
        Me.cbxSexoM.Name = "cbxSexoM"
        Me.cbxSexoM.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexoM.TabIndex = 67
        '
        'tbxNumM
        '
        Me.tbxNumM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumM.Location = New System.Drawing.Point(99, 12)
        Me.tbxNumM.MaxLength = 9
        Me.tbxNumM.Name = "tbxNumM"
        Me.tbxNumM.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumM.TabIndex = 112
        Me.tbxNumM.Text = "000000000"
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
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(221, 65)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(145, 32)
        Me.dtpNacimiento.TabIndex = 66
        '
        'gbxH
        '
        Me.gbxH.BackColor = System.Drawing.Color.Bisque
        Me.gbxH.Controls.Add(Me.btnBuscarH)
        Me.gbxH.Controls.Add(Me.cbxRazaH)
        Me.gbxH.Controls.Add(Me.cbxSexoH)
        Me.gbxH.Controls.Add(Me.tbxNumH)
        Me.gbxH.Controls.Add(Me.lblNumH)
        Me.gbxH.Controls.Add(Me.lblSexoH)
        Me.gbxH.Controls.Add(Me.lblRazaH)
        Me.gbxH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxH.Location = New System.Drawing.Point(402, 138)
        Me.gbxH.Name = "gbxH"
        Me.gbxH.Size = New System.Drawing.Size(376, 126)
        Me.gbxH.TabIndex = 110
        Me.gbxH.TabStop = False
        Me.gbxH.Text = "progenitor hembra"
        '
        'btnBuscarH
        '
        Me.btnBuscarH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarH.Location = New System.Drawing.Point(250, 45)
        Me.btnBuscarH.Name = "btnBuscarH"
        Me.btnBuscarH.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscarH.TabIndex = 115
        Me.btnBuscarH.Text = "Buscar"
        Me.btnBuscarH.UseVisualStyleBackColor = True
        '
        'cbxRazaH
        '
        Me.cbxRazaH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRazaH.FormattingEnabled = True
        Me.cbxRazaH.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxRazaH.Location = New System.Drawing.Point(99, 89)
        Me.cbxRazaH.Name = "cbxRazaH"
        Me.cbxRazaH.Size = New System.Drawing.Size(145, 32)
        Me.cbxRazaH.TabIndex = 67
        '
        'cbxSexoH
        '
        Me.cbxSexoH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexoH.FormattingEnabled = True
        Me.cbxSexoH.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.cbxSexoH.Location = New System.Drawing.Point(99, 51)
        Me.cbxSexoH.Name = "cbxSexoH"
        Me.cbxSexoH.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexoH.TabIndex = 113
        '
        'tbxNumH
        '
        Me.tbxNumH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumH.Location = New System.Drawing.Point(99, 13)
        Me.tbxNumH.MaxLength = 9
        Me.tbxNumH.Name = "tbxNumH"
        Me.tbxNumH.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumH.TabIndex = 113
        Me.tbxNumH.Text = "000000000"
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
        'cbxLugar
        '
        Me.cbxLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLugar.FormattingEnabled = True
        Me.cbxLugar.Location = New System.Drawing.Point(221, 118)
        Me.cbxLugar.Name = "cbxLugar"
        Me.cbxLugar.Size = New System.Drawing.Size(145, 32)
        Me.cbxLugar.TabIndex = 53
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(15, 71)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(114, 24)
        Me.lblNacimiento.TabIndex = 49
        Me.lblNacimiento.Text = "Nacimiento"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(15, 209)
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
        Me.cbxSexo.Location = New System.Drawing.Point(221, 27)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexo.TabIndex = 36
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(15, 30)
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
        Me.cbxRaza.Location = New System.Drawing.Point(221, 163)
        Me.cbxRaza.Name = "cbxRaza"
        Me.cbxRaza.Size = New System.Drawing.Size(145, 32)
        Me.cbxRaza.TabIndex = 31
        '
        'cbxDivision
        '
        Me.cbxDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivision.FormattingEnabled = True
        Me.cbxDivision.Location = New System.Drawing.Point(221, 206)
        Me.cbxDivision.Name = "cbxDivision"
        Me.cbxDivision.Size = New System.Drawing.Size(145, 32)
        Me.cbxDivision.TabIndex = 37
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(16, 166)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(58, 24)
        Me.lblRaza.TabIndex = 6
        Me.lblRaza.Text = "Raza"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(14, 121)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(125, 24)
        Me.lblLugar.TabIndex = 4
        Me.lblLugar.Text = "Lugar actual"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(451, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gbxEtapa
        '
        Me.gbxEtapa.Controls.Add(Me.Button4)
        Me.gbxEtapa.Controls.Add(Me.btnEvento)
        Me.gbxEtapa.Controls.Add(Me.dtpFin)
        Me.gbxEtapa.Controls.Add(Me.lblFechaF)
        Me.gbxEtapa.Controls.Add(Me.dtpInicio)
        Me.gbxEtapa.Controls.Add(Me.lblFechaI)
        Me.gbxEtapa.Controls.Add(Me.lblEtapa)
        Me.gbxEtapa.Controls.Add(Me.cbxEtapa)
        Me.gbxEtapa.Enabled = False
        Me.gbxEtapa.Location = New System.Drawing.Point(414, 336)
        Me.gbxEtapa.Name = "gbxEtapa"
        Me.gbxEtapa.Size = New System.Drawing.Size(376, 188)
        Me.gbxEtapa.TabIndex = 62
        Me.gbxEtapa.TabStop = False
        '
        'btnEvento
        '
        Me.btnEvento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvento.Location = New System.Drawing.Point(213, 140)
        Me.btnEvento.Name = "btnEvento"
        Me.btnEvento.Size = New System.Drawing.Size(118, 42)
        Me.btnEvento.TabIndex = 112
        Me.btnEvento.Text = "Agregar"
        Me.btnEvento.UseVisualStyleBackColor = True
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(211, 98)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(145, 32)
        Me.dtpFin.TabIndex = 68
        '
        'lblFechaF
        '
        Me.lblFechaF.AutoSize = True
        Me.lblFechaF.Enabled = False
        Me.lblFechaF.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaF.Location = New System.Drawing.Point(6, 104)
        Me.lblFechaF.Name = "lblFechaF"
        Me.lblFechaF.Size = New System.Drawing.Size(97, 24)
        Me.lblFechaF.TabIndex = 67
        Me.lblFechaF.Text = "Fecha fin"
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
        Me.tbxNum.Location = New System.Drawing.Point(233, 22)
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
        Me.lblNumero.Location = New System.Drawing.Point(30, 23)
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
        Me.btnOpcion.Location = New System.Drawing.Point(636, 16)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 105
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(55, 140)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 42)
        Me.Button4.TabIndex = 125
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.gbxCria)
        Me.Controls.Add(Me.gbxBasico)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gbxEtapa)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "frmAnimal"
        Me.Text = "Animal"
        Me.gbxCria.ResumeLayout(False)
        Me.gbxCria.PerformLayout()
        Me.gbxBasico.ResumeLayout(False)
        Me.gbxBasico.PerformLayout()
        Me.gbxM.ResumeLayout(False)
        Me.gbxM.PerformLayout()
        Me.gbxH.ResumeLayout(False)
        Me.gbxH.PerformLayout()
        Me.gbxEtapa.ResumeLayout(False)
        Me.gbxEtapa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxCria As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecriavuelta As System.Windows.Forms.Label
    Friend WithEvents lblRecriaIda As System.Windows.Forms.Label
    Friend WithEvents lblFechaI As System.Windows.Forms.Label
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
    Friend WithEvents gbxEtapa As System.Windows.Forms.GroupBox
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriavuelta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents btnEvento As System.Windows.Forms.Button
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaF As System.Windows.Forms.Label
    Friend WithEvents gbxM As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumM As System.Windows.Forms.Label
    Friend WithEvents lblSexoM As System.Windows.Forms.Label
    Friend WithEvents lblRazaM As System.Windows.Forms.Label
    Friend WithEvents gbxH As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumH As System.Windows.Forms.Label
    Friend WithEvents lblSexoH As System.Windows.Forms.Label
    Friend WithEvents lblRazaH As System.Windows.Forms.Label
    Friend WithEvents cbxRazaM As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSexoM As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNumM As System.Windows.Forms.TextBox
    Friend WithEvents cbxRazaH As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSexoH As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNumH As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarM As System.Windows.Forms.Button
    Friend WithEvents btnBuscarH As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
