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
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(440, 132)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 104
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.dtpNacimiento)
        Me.gbxDatos.Controls.Add(Me.cbxPuesto)
        Me.gbxDatos.Controls.Add(Me.lblNacimiento)
        Me.gbxDatos.Controls.Add(Me.cbxSexo)
        Me.gbxDatos.Controls.Add(Me.lblSexo)
        Me.gbxDatos.Controls.Add(Me.lblPermisos)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(61, 196)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(673, 263)
        Me.gbxDatos.TabIndex = 102
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos"
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(375, 105)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(145, 32)
        Me.dtpNacimiento.TabIndex = 65
        '
        'cbxPuesto
        '
        Me.cbxPuesto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPuesto.FormattingEnabled = True
        Me.cbxPuesto.Items.AddRange(New Object() {"Administrador", "..."})
        Me.cbxPuesto.Location = New System.Drawing.Point(375, 158)
        Me.cbxPuesto.Name = "cbxPuesto"
        Me.cbxPuesto.Size = New System.Drawing.Size(145, 32)
        Me.cbxPuesto.TabIndex = 64
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(169, 111)
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
        Me.cbxSexo.Location = New System.Drawing.Point(375, 67)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexo.TabIndex = 59
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(169, 70)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 58
        Me.lblSexo.Text = "Sexo"
        '
        'lblPermisos
        '
        Me.lblPermisos.AutoSize = True
        Me.lblPermisos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermisos.Location = New System.Drawing.Point(168, 161)
        Me.lblPermisos.Name = "lblPermisos"
        Me.lblPermisos.Size = New System.Drawing.Size(76, 24)
        Me.lblPermisos.TabIndex = 57
        Me.lblPermisos.Text = "Puesto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(440, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 101
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxCI
        '
        Me.tbxCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCI.Location = New System.Drawing.Point(265, 78)
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
        Me.lblCI.Location = New System.Drawing.Point(57, 81)
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
End Class
