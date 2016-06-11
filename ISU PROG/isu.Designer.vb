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
        Me.mspIngles = New System.Windows.Forms.MenuStrip()
        Me.tsInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsConsult = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModify = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mspEspanol = New System.Windows.Forms.MenuStrip()
        Me.tsIngresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEnlistar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        CType(Me.PbxISU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mspIngles.SuspendLayout()
        Me.mspEspanol.SuspendLayout()
        Me.pnlInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(982, 490)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(112, 46)
        Me.btnInicio.TabIndex = 6
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'tbxPass
        '
        Me.tbxPass.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPass.Location = New System.Drawing.Point(755, 535)
        Me.tbxPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(155, 32)
        Me.tbxPass.TabIndex = 5
        '
        'tbxUser
        '
        Me.tbxUser.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUser.Location = New System.Drawing.Point(755, 462)
        Me.tbxUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(155, 32)
        Me.tbxUser.TabIndex = 4
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpass.Location = New System.Drawing.Point(607, 535)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(16, 24)
        Me.Lblpass.TabIndex = 3
        Me.Lblpass.Text = " "
        '
        'PbxISU
        '
        Me.PbxISU.Image = CType(resources.GetObject("PbxISU.Image"), System.Drawing.Image)
        Me.PbxISU.Location = New System.Drawing.Point(220, 4)
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
        Me.lblUser.Location = New System.Drawing.Point(607, 454)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(16, 24)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = " "
        '
        'cbxIdioma
        '
        Me.cbxIdioma.AutoCompleteCustomSource.AddRange(New String() {"English"})
        Me.cbxIdioma.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdioma.FormattingEnabled = True
        Me.cbxIdioma.Items.AddRange(New Object() {"Español", "English"})
        Me.cbxIdioma.Location = New System.Drawing.Point(170, 490)
        Me.cbxIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxIdioma.Name = "cbxIdioma"
        Me.cbxIdioma.Size = New System.Drawing.Size(189, 32)
        Me.cbxIdioma.TabIndex = 0
        Me.cbxIdioma.Text = "Español"
        '
        'mspIngles
        '
        Me.mspIngles.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mspIngles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInsert, Me.tsRemove, Me.tsConsult, Me.tsShow, Me.tsModify, Me.tsExit})
        Me.mspIngles.Location = New System.Drawing.Point(0, 25)
        Me.mspIngles.Name = "mspIngles"
        Me.mspIngles.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.mspIngles.Size = New System.Drawing.Size(1212, 25)
        Me.mspIngles.TabIndex = 2
        Me.mspIngles.Text = "MenuStrip1"
        '
        'tsInsert
        '
        Me.tsInsert.Name = "tsInsert"
        Me.tsInsert.Size = New System.Drawing.Size(48, 19)
        Me.tsInsert.Text = "Insert"
        '
        'tsRemove
        '
        Me.tsRemove.Name = "tsRemove"
        Me.tsRemove.Size = New System.Drawing.Size(62, 19)
        Me.tsRemove.Text = "Remove"
        '
        'tsConsult
        '
        Me.tsConsult.Name = "tsConsult"
        Me.tsConsult.Size = New System.Drawing.Size(60, 19)
        Me.tsConsult.Text = "Consult"
        '
        'tsShow
        '
        Me.tsShow.Name = "tsShow"
        Me.tsShow.Size = New System.Drawing.Size(48, 19)
        Me.tsShow.Text = "Show"
        '
        'tsModify
        '
        Me.tsModify.Name = "tsModify"
        Me.tsModify.Size = New System.Drawing.Size(57, 19)
        Me.tsModify.Text = "Modify"
        '
        'tsExit
        '
        Me.tsExit.Name = "tsExit"
        Me.tsExit.Size = New System.Drawing.Size(37, 19)
        Me.tsExit.Text = "Exit"
        '
        'mspEspanol
        '
        Me.mspEspanol.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mspEspanol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsIngresar, Me.tsEliminar, Me.tsConsultar, Me.tsEnlistar, Me.tsModificar, Me.tsSalir})
        Me.mspEspanol.Location = New System.Drawing.Point(0, 0)
        Me.mspEspanol.Name = "mspEspanol"
        Me.mspEspanol.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.mspEspanol.Size = New System.Drawing.Size(1212, 25)
        Me.mspEspanol.TabIndex = 3
        Me.mspEspanol.Text = "MenuStrip2"
        '
        'tsIngresar
        '
        Me.tsIngresar.Name = "tsIngresar"
        Me.tsIngresar.Size = New System.Drawing.Size(61, 19)
        Me.tsIngresar.Text = "Ingresar"
        '
        'tsEliminar
        '
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(62, 19)
        Me.tsEliminar.Text = "Eliminar"
        '
        'tsConsultar
        '
        Me.tsConsultar.Name = "tsConsultar"
        Me.tsConsultar.Size = New System.Drawing.Size(70, 19)
        Me.tsConsultar.Text = "Consultar"
        '
        'tsEnlistar
        '
        Me.tsEnlistar.Name = "tsEnlistar"
        Me.tsEnlistar.Size = New System.Drawing.Size(57, 19)
        Me.tsEnlistar.Text = "Enlistar"
        '
        'tsModificar
        '
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(70, 19)
        Me.tsModificar.Text = "Modificar"
        '
        'tsSalir
        '
        Me.tsSalir.Name = "tsSalir"
        Me.tsSalir.Size = New System.Drawing.Size(44, 19)
        Me.tsSalir.Text = "Sallir"
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
        Me.pnlInicio.Location = New System.Drawing.Point(0, 54)
        Me.pnlInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(1209, 609)
        Me.pnlInicio.TabIndex = 5
        '
        'frmISU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1212, 646)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.mspIngles)
        Me.Controls.Add(Me.mspEspanol)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mspIngles
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmISU"
        Me.Text = "ISU"
        CType(Me.PbxISU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mspIngles.ResumeLayout(False)
        Me.mspIngles.PerformLayout()
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
    Friend WithEvents mspIngles As System.Windows.Forms.MenuStrip
    Friend WithEvents mspEspanol As System.Windows.Forms.MenuStrip
    Friend WithEvents PbxISU As System.Windows.Forms.PictureBox
    Friend WithEvents tsIngresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsInsert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEnlistar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsConsult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsModify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlInicio As System.Windows.Forms.Panel

End Class
