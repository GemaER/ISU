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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.cbxLugar = New System.Windows.Forms.ComboBox()
        Me.tbxAaaa = New System.Windows.Forms.TextBox()
        Me.tbxMm = New System.Windows.Forms.TextBox()
        Me.tbxDd = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblPermisos = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(803, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 750)
        Me.Panel1.TabIndex = 47
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(434, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 56
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxCI
        '
        Me.tbxCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCI.Location = New System.Drawing.Point(259, 43)
        Me.tbxCI.MaxLength = 8
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(145, 32)
        Me.tbxCI.TabIndex = 55
        Me.tbxCI.Text = "00000000"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.Location = New System.Drawing.Point(51, 46)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(194, 24)
        Me.lblCI.TabIndex = 54
        Me.lblCI.Text = "Cedula de identidad"
        '
        'cbxLugar
        '
        Me.cbxLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLugar.FormattingEnabled = True
        Me.cbxLugar.Items.AddRange(New Object() {"Administrador", "..."})
        Me.cbxLugar.Location = New System.Drawing.Point(375, 158)
        Me.cbxLugar.Name = "cbxLugar"
        Me.cbxLugar.Size = New System.Drawing.Size(145, 32)
        Me.cbxLugar.TabIndex = 64
        '
        'tbxAaaa
        '
        Me.tbxAaaa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAaaa.Location = New System.Drawing.Point(466, 108)
        Me.tbxAaaa.MaxLength = 3
        Me.tbxAaaa.Name = "tbxAaaa"
        Me.tbxAaaa.Size = New System.Drawing.Size(54, 32)
        Me.tbxAaaa.TabIndex = 63
        Me.tbxAaaa.Text = "aaaa"
        Me.tbxAaaa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxMm
        '
        Me.tbxMm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMm.Location = New System.Drawing.Point(420, 108)
        Me.tbxMm.MaxLength = 3
        Me.tbxMm.Name = "tbxMm"
        Me.tbxMm.Size = New System.Drawing.Size(40, 32)
        Me.tbxMm.TabIndex = 62
        Me.tbxMm.Text = "mm"
        Me.tbxMm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxDd
        '
        Me.tbxDd.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDd.Location = New System.Drawing.Point(377, 108)
        Me.tbxDd.MaxLength = 3
        Me.tbxDd.Name = "tbxDd"
        Me.tbxDd.Size = New System.Drawing.Size(37, 32)
        Me.tbxDd.TabIndex = 61
        Me.tbxDd.Text = "dd"
        Me.tbxDd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.cbxLugar)
        Me.gbxDatos.Controls.Add(Me.tbxAaaa)
        Me.gbxDatos.Controls.Add(Me.tbxMm)
        Me.gbxDatos.Controls.Add(Me.tbxDd)
        Me.gbxDatos.Controls.Add(Me.lblNacimiento)
        Me.gbxDatos.Controls.Add(Me.cbxSexo)
        Me.gbxDatos.Controls.Add(Me.lblSexo)
        Me.gbxDatos.Controls.Add(Me.lblPermisos)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(55, 161)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(673, 263)
        Me.gbxDatos.TabIndex = 65
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(568, 97)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 42)
        Me.btnModificar.TabIndex = 96
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Enabled = False
        Me.btnIngresar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(434, 97)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(118, 42)
        Me.btnIngresar.TabIndex = 97
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'frmPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxCI)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPersonal"
        Me.Text = "Personal"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxCI As System.Windows.Forms.TextBox
    Friend WithEvents lblCI As System.Windows.Forms.Label
    Friend WithEvents cbxLugar As System.Windows.Forms.ComboBox
    Friend WithEvents tbxAaaa As System.Windows.Forms.TextBox
    Friend WithEvents tbxMm As System.Windows.Forms.TextBox
    Friend WithEvents tbxDd As System.Windows.Forms.TextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblPermisos As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
End Class
