<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmISU))
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.Lblpass = New System.Windows.Forms.Label()
        Me.PbxISU = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.cbxIdioma = New System.Windows.Forms.ComboBox()
        Me.mspEspanol = New System.Windows.Forms.MenuStrip()
        Me.tsTambo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTamboIngresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTamboModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTamboConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPersonalIngresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPersonalModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPersonalConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsIngresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEnlistar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRaza = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHolando = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsJersey = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPrimerShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDivision = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsVaca = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsVaquillona = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsToro = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNovillo = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsAnestro = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTernero = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTernera = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLugar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRodeo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCampo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTamboe = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNinguno = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEtapa = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsServicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tsprenada = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLactancia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNinguno2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeca = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSexo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHembraa = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHembra = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMacho = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEdad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        CType(Me.PbxISU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mspEspanol.SuspendLayout()
        Me.pnlInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(638, 462)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(112, 46)
        Me.btnInicio.TabIndex = 6
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'tbxPass
        '
        Me.tbxPass.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPass.Location = New System.Drawing.Point(449, 497)
        Me.tbxPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxPass.MaxLength = 13
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(183, 32)
        Me.tbxPass.TabIndex = 5
        '
        'tbxUser
        '
        Me.tbxUser.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUser.Location = New System.Drawing.Point(449, 443)
        Me.tbxUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxUser.MaxLength = 13
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(183, 32)
        Me.tbxUser.TabIndex = 4
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpass.Location = New System.Drawing.Point(282, 500)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(16, 24)
        Me.Lblpass.TabIndex = 3
        Me.Lblpass.Text = " "
        '
        'PbxISU
        '
        Me.PbxISU.Image = CType(resources.GetObject("PbxISU.Image"), System.Drawing.Image)
        Me.PbxISU.Location = New System.Drawing.Point(28, 4)
        Me.PbxISU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PbxISU.Name = "PbxISU"
        Me.PbxISU.Size = New System.Drawing.Size(753, 423)
        Me.PbxISU.TabIndex = 0
        Me.PbxISU.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(282, 446)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(16, 24)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = " "
        '
        'cbxIdioma
        '
        Me.cbxIdioma.AutoCompleteCustomSource.AddRange(New String() {"English", "Português"})
        Me.cbxIdioma.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdioma.FormattingEnabled = True
        Me.cbxIdioma.Items.AddRange(New Object() {"Español", "English", "Português"})
        Me.cbxIdioma.Location = New System.Drawing.Point(28, 462)
        Me.cbxIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxIdioma.Name = "cbxIdioma"
        Me.cbxIdioma.Size = New System.Drawing.Size(189, 32)
        Me.cbxIdioma.TabIndex = 0
        Me.cbxIdioma.Text = "Español"
        '
        'mspEspanol
        '
        Me.mspEspanol.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mspEspanol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTambo, Me.tsPersonal, Me.tsIngresar, Me.tsEliminar, Me.tsConsultar, Me.tsEnlistar, Me.tsModificar, Me.tsSesion, Me.tsSalir})
        Me.mspEspanol.Location = New System.Drawing.Point(0, 0)
        Me.mspEspanol.Name = "mspEspanol"
        Me.mspEspanol.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.mspEspanol.Size = New System.Drawing.Size(832, 25)
        Me.mspEspanol.TabIndex = 3
        Me.mspEspanol.Text = "MenuStrip2"
        '
        'tsTambo
        '
        Me.tsTambo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTamboIngresar, Me.tsTamboModificar, Me.tsTamboConsultar})
        Me.tsTambo.Enabled = False
        Me.tsTambo.Name = "tsTambo"
        Me.tsTambo.Size = New System.Drawing.Size(57, 19)
        Me.tsTambo.Text = "Tambo"
        '
        'tsTamboIngresar
        '
        Me.tsTamboIngresar.Name = "tsTamboIngresar"
        Me.tsTamboIngresar.Size = New System.Drawing.Size(152, 22)
        Me.tsTamboIngresar.Text = "Ingresar"
        '
        'tsTamboModificar
        '
        Me.tsTamboModificar.Name = "tsTamboModificar"
        Me.tsTamboModificar.Size = New System.Drawing.Size(152, 22)
        Me.tsTamboModificar.Text = "Modificar"
        '
        'tsTamboConsultar
        '
        Me.tsTamboConsultar.Name = "tsTamboConsultar"
        Me.tsTamboConsultar.Size = New System.Drawing.Size(152, 22)
        Me.tsTamboConsultar.Text = "Consultar"
        '
        'tsPersonal
        '
        Me.tsPersonal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPersonalIngresar, Me.tsPersonalModificar, Me.tsPersonalConsultar})
        Me.tsPersonal.Enabled = False
        Me.tsPersonal.Name = "tsPersonal"
        Me.tsPersonal.Size = New System.Drawing.Size(64, 19)
        Me.tsPersonal.Text = "Personal"
        '
        'tsPersonalIngresar
        '
        Me.tsPersonalIngresar.Name = "tsPersonalIngresar"
        Me.tsPersonalIngresar.Size = New System.Drawing.Size(125, 22)
        Me.tsPersonalIngresar.Text = "Ingresar"
        '
        'tsPersonalModificar
        '
        Me.tsPersonalModificar.Name = "tsPersonalModificar"
        Me.tsPersonalModificar.Size = New System.Drawing.Size(125, 22)
        Me.tsPersonalModificar.Text = "Modificar"
        '
        'tsPersonalConsultar
        '
        Me.tsPersonalConsultar.Name = "tsPersonalConsultar"
        Me.tsPersonalConsultar.Size = New System.Drawing.Size(125, 22)
        Me.tsPersonalConsultar.Text = "Consultar"
        '
        'tsIngresar
        '
        Me.tsIngresar.Enabled = False
        Me.tsIngresar.Name = "tsIngresar"
        Me.tsIngresar.Size = New System.Drawing.Size(61, 19)
        Me.tsIngresar.Text = "Ingresar"
        '
        'tsEliminar
        '
        Me.tsEliminar.Enabled = False
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(62, 19)
        Me.tsEliminar.Text = "Eliminar"
        '
        'tsConsultar
        '
        Me.tsConsultar.Enabled = False
        Me.tsConsultar.Name = "tsConsultar"
        Me.tsConsultar.Size = New System.Drawing.Size(70, 19)
        Me.tsConsultar.Text = "Consultar"
        '
        'tsEnlistar
        '
        Me.tsEnlistar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRaza, Me.tsDivision, Me.tsLugar, Me.tsEtapa, Me.tsSexo, Me.tsEdad})
        Me.tsEnlistar.Enabled = False
        Me.tsEnlistar.Name = "tsEnlistar"
        Me.tsEnlistar.Size = New System.Drawing.Size(57, 19)
        Me.tsEnlistar.Text = "Enlistar"
        '
        'tsRaza
        '
        Me.tsRaza.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsHolando, Me.tsJersey, Me.tsPrimerShow})
        Me.tsRaza.Name = "tsRaza"
        Me.tsRaza.Size = New System.Drawing.Size(119, 22)
        Me.tsRaza.Text = "Raza"
        '
        'tsHolando
        '
        Me.tsHolando.Name = "tsHolando"
        Me.tsHolando.Size = New System.Drawing.Size(141, 22)
        Me.tsHolando.Text = "Holando"
        '
        'tsJersey
        '
        Me.tsJersey.Name = "tsJersey"
        Me.tsJersey.Size = New System.Drawing.Size(141, 22)
        Me.tsJersey.Text = "Jersey"
        '
        'tsPrimerShow
        '
        Me.tsPrimerShow.Name = "tsPrimerShow"
        Me.tsPrimerShow.Size = New System.Drawing.Size(141, 22)
        Me.tsPrimerShow.Text = "Primer Show"
        '
        'tsDivision
        '
        Me.tsDivision.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsVaca, Me.tsVaquillona, Me.tsToro, Me.tsNovillo, Me.TsAnestro, Me.tsTernero, Me.tsTernera})
        Me.tsDivision.Name = "tsDivision"
        Me.tsDivision.Size = New System.Drawing.Size(119, 22)
        Me.tsDivision.Text = "División "
        '
        'tsVaca
        '
        Me.tsVaca.Name = "tsVaca"
        Me.tsVaca.Size = New System.Drawing.Size(130, 22)
        Me.tsVaca.Text = "Vaca"
        '
        'tsVaquillona
        '
        Me.tsVaquillona.Name = "tsVaquillona"
        Me.tsVaquillona.Size = New System.Drawing.Size(130, 22)
        Me.tsVaquillona.Text = "Vaquillona"
        '
        'tsToro
        '
        Me.tsToro.Name = "tsToro"
        Me.tsToro.Size = New System.Drawing.Size(130, 22)
        Me.tsToro.Text = "Toro"
        '
        'tsNovillo
        '
        Me.tsNovillo.Name = "tsNovillo"
        Me.tsNovillo.Size = New System.Drawing.Size(130, 22)
        Me.tsNovillo.Text = "Novillo"
        '
        'TsAnestro
        '
        Me.TsAnestro.Name = "TsAnestro"
        Me.TsAnestro.Size = New System.Drawing.Size(130, 22)
        Me.TsAnestro.Text = "Anestro"
        '
        'tsTernero
        '
        Me.tsTernero.Name = "tsTernero"
        Me.tsTernero.Size = New System.Drawing.Size(130, 22)
        Me.tsTernero.Text = "Ternero"
        '
        'tsTernera
        '
        Me.tsTernera.Name = "tsTernera"
        Me.tsTernera.Size = New System.Drawing.Size(130, 22)
        Me.tsTernera.Text = "Ternera"
        '
        'tsLugar
        '
        Me.tsLugar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRodeo, Me.tsCampo, Me.tsTamboe, Me.tsNinguno})
        Me.tsLugar.Name = "tsLugar"
        Me.tsLugar.Size = New System.Drawing.Size(119, 22)
        Me.tsLugar.Text = "Lugar"
        '
        'tsRodeo
        '
        Me.tsRodeo.Name = "tsRodeo"
        Me.tsRodeo.Size = New System.Drawing.Size(161, 22)
        Me.tsRodeo.Text = "Rodeo de cría"
        '
        'tsCampo
        '
        Me.tsCampo.Name = "tsCampo"
        Me.tsCampo.Size = New System.Drawing.Size(161, 22)
        Me.tsCampo.Text = "Campo de recría"
        '
        'tsTamboe
        '
        Me.tsTamboe.Name = "tsTamboe"
        Me.tsTamboe.Size = New System.Drawing.Size(161, 22)
        Me.tsTamboe.Text = "Tambo"
        '
        'tsNinguno
        '
        Me.tsNinguno.Name = "tsNinguno"
        Me.tsNinguno.Size = New System.Drawing.Size(161, 22)
        Me.tsNinguno.Text = "Ninguno"
        '
        'tsEtapa
        '
        Me.tsEtapa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsServicio, Me.Tsprenada, Me.tsLactancia, Me.tsNinguno2, Me.tsSeca})
        Me.tsEtapa.Name = "tsEtapa"
        Me.tsEtapa.Size = New System.Drawing.Size(119, 22)
        Me.tsEtapa.Text = "Etapa"
        '
        'TsServicio
        '
        Me.TsServicio.Name = "TsServicio"
        Me.TsServicio.Size = New System.Drawing.Size(124, 22)
        Me.TsServicio.Text = "Servicio"
        '
        'Tsprenada
        '
        Me.Tsprenada.Name = "Tsprenada"
        Me.Tsprenada.Size = New System.Drawing.Size(124, 22)
        Me.Tsprenada.Text = "Preñada"
        '
        'tsLactancia
        '
        Me.tsLactancia.Name = "tsLactancia"
        Me.tsLactancia.Size = New System.Drawing.Size(124, 22)
        Me.tsLactancia.Text = "Lactancia"
        '
        'tsNinguno2
        '
        Me.tsNinguno2.Name = "tsNinguno2"
        Me.tsNinguno2.Size = New System.Drawing.Size(124, 22)
        Me.tsNinguno2.Text = "Ninguno"
        '
        'tsSeca
        '
        Me.tsSeca.Name = "tsSeca"
        Me.tsSeca.Size = New System.Drawing.Size(124, 22)
        Me.tsSeca.Text = "Seca"
        '
        'tsSexo
        '
        Me.tsSexo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsHembraa, Me.tsHembra, Me.tsMacho})
        Me.tsSexo.Name = "tsSexo"
        Me.tsSexo.Size = New System.Drawing.Size(119, 22)
        Me.tsSexo.Text = "Sexo"
        '
        'tsHembraa
        '
        Me.tsHembraa.Name = "tsHembraa"
        Me.tsHembraa.Size = New System.Drawing.Size(185, 22)
        Me.tsHembraa.Text = "Hembra (antibiotico)"
        '
        'tsHembra
        '
        Me.tsHembra.Name = "tsHembra"
        Me.tsHembra.Size = New System.Drawing.Size(185, 22)
        Me.tsHembra.Text = "Hembra"
        '
        'tsMacho
        '
        Me.tsMacho.Name = "tsMacho"
        Me.tsMacho.Size = New System.Drawing.Size(185, 22)
        Me.tsMacho.Text = "Macho"
        '
        'tsEdad
        '
        Me.tsEdad.Name = "tsEdad"
        Me.tsEdad.Size = New System.Drawing.Size(119, 22)
        Me.tsEdad.Text = "Edad"
        '
        'tsModificar
        '
        Me.tsModificar.Enabled = False
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(70, 19)
        Me.tsModificar.Text = "Modificar"
        '
        'tsSesion
        '
        Me.tsSesion.Enabled = False
        Me.tsSesion.Name = "tsSesion"
        Me.tsSesion.Size = New System.Drawing.Size(87, 19)
        Me.tsSesion.Text = "Cerrar sesion"
        '
        'tsSalir
        '
        Me.tsSalir.Name = "tsSalir"
        Me.tsSalir.Size = New System.Drawing.Size(41, 19)
        Me.tsSalir.Text = "Salir"
        '
        'pnlInicio
        '
        Me.pnlInicio.Controls.Add(Me.btnInicio)
        Me.pnlInicio.Controls.Add(Me.tbxPass)
        Me.pnlInicio.Controls.Add(Me.PbxISU)
        Me.pnlInicio.Controls.Add(Me.tbxUser)
        Me.pnlInicio.Controls.Add(Me.cbxIdioma)
        Me.pnlInicio.Controls.Add(Me.Lblpass)
        Me.pnlInicio.Controls.Add(Me.lblUser)
        Me.pnlInicio.Location = New System.Drawing.Point(0, 29)
        Me.pnlInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(797, 542)
        Me.pnlInicio.TabIndex = 5
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlBlue.Location = New System.Drawing.Point(803, 0)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(24, 750)
        Me.pnlBlue.TabIndex = 48
        Me.pnlBlue.Visible = False
        '
        'frmISU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 574)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.mspEspanol)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmISU"
        Me.Text = "ISU"
        CType(Me.PbxISU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mspEspanol.ResumeLayout(False)
        Me.mspEspanol.PerformLayout()
        Me.pnlInicio.ResumeLayout(False)
        Me.pnlInicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents Lblpass As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents tbxPass As System.Windows.Forms.TextBox
    Friend WithEvents tbxUser As System.Windows.Forms.TextBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents mspEspanol As System.Windows.Forms.MenuStrip
    Friend WithEvents PbxISU As System.Windows.Forms.PictureBox
    Friend WithEvents tsIngresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEnlistar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlInicio As System.Windows.Forms.Panel
    Friend WithEvents tsTambo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents tsRaza As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEdad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDivision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsHolando As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsJersey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPrimerShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLugar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsVaca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsVaquillona As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsToro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsNovillo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsAnestro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTernero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRodeo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCampo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTamboe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEtapa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsServicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tsprenada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLactancia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSexo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsHembra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsHembraa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMacho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTamboIngresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTamboModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTamboConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPersonalIngresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPersonalModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPersonalConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTernera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsNinguno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsNinguno2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeca As System.Windows.Forms.ToolStripMenuItem

End Class
