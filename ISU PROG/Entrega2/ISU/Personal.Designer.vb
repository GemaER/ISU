<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonal
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
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbxPuesto = New System.Windows.Forms.ComboBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblPermisos = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(582, 62)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 104
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.PictureBox1)
        Me.gbxDatos.Controls.Add(Me.TextBox1)
        Me.gbxDatos.Controls.Add(Me.dtpNacimiento)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.cbxPuesto)
        Me.gbxDatos.Controls.Add(Me.lblNacimiento)
        Me.gbxDatos.Controls.Add(Me.cbxSexo)
        Me.gbxDatos.Controls.Add(Me.lblSexo)
        Me.gbxDatos.Controls.Add(Me.lblPermisos)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(56, 158)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(673, 263)
        Me.gbxDatos.TabIndex = 102
        Me.gbxDatos.TabStop = False
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(473, 131)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(145, 32)
        Me.dtpNacimiento.TabIndex = 65
        '
        'cbxPuesto
        '
        Me.cbxPuesto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPuesto.FormattingEnabled = True
        Me.cbxPuesto.Items.AddRange(New Object() {"Administrador", "..."})
        Me.cbxPuesto.Location = New System.Drawing.Point(473, 169)
        Me.cbxPuesto.Name = "cbxPuesto"
        Me.cbxPuesto.Size = New System.Drawing.Size(145, 32)
        Me.cbxPuesto.TabIndex = 64
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(267, 137)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(114, 24)
        Me.lblNacimiento.TabIndex = 60
        Me.lblNacimiento.Text = "Nacimiento"
        '
        'cbxSexo
        '
        Me.cbxSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbxSexo.Location = New System.Drawing.Point(473, 93)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexo.TabIndex = 59
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(267, 96)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 58
        Me.lblSexo.Text = "Sexo"
        '
        'lblPermisos
        '
        Me.lblPermisos.AutoSize = True
        Me.lblPermisos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermisos.Location = New System.Drawing.Point(267, 172)
        Me.lblPermisos.Name = "lblPermisos"
        Me.lblPermisos.Size = New System.Drawing.Size(76, 24)
        Me.lblPermisos.TabIndex = 57
        Me.lblPermisos.Text = "Puesto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(448, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 101
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxCI
        '
        Me.tbxCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCI.Location = New System.Drawing.Point(273, 68)
        Me.tbxCI.MaxLength = 8
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(145, 32)
        Me.tbxCI.TabIndex = 100
        Me.tbxCI.Text = "00000000"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.Location = New System.Drawing.Point(65, 71)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(194, 24)
        Me.lblCI.TabIndex = 99
        Me.lblCI.Text = "Cedula de identidad"
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlBlue.Location = New System.Drawing.Point(803, 0)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(24, 579)
        Me.pnlBlue.TabIndex = 105
        Me.pnlBlue.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(474, 53)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 32)
        Me.TextBox1.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Nombre"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 171)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'frmPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxCI)
        Me.Controls.Add(Me.lblCI)
        Me.Name = "frmPersonal"
        Me.Text = "Personal"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblPermisos As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxCI As System.Windows.Forms.TextBox
    Friend WithEvents lblCI As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
