<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambo
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
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxSerie = New System.Windows.Forms.TextBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.tbxHectareas = New System.Windows.Forms.TextBox()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.tbxGanado_max = New System.Windows.Forms.TextBox()
        Me.lblganado_max = New System.Windows.Forms.Label()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.gbxAlimento = New System.Windows.Forms.GroupBox()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.tbxCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gbxGeneral.SuspendLayout()
        Me.gbxAlimento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnOpcion.Location = New System.Drawing.Point(605, 36)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 105
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(451, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 106
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxSerie
        '
        Me.tbxSerie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSerie.Location = New System.Drawing.Point(250, 42)
        Me.tbxSerie.MaxLength = 50
        Me.tbxSerie.Name = "tbxSerie"
        Me.tbxSerie.Size = New System.Drawing.Size(145, 32)
        Me.tbxSerie.TabIndex = 109
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(42, 45)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(60, 24)
        Me.lblSerie.TabIndex = 108
        Me.lblSerie.Text = "Serie"
        '
        'tbxHectareas
        '
        Me.tbxHectareas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHectareas.Location = New System.Drawing.Point(238, 78)
        Me.tbxHectareas.MaxLength = 50
        Me.tbxHectareas.Name = "tbxHectareas"
        Me.tbxHectareas.Size = New System.Drawing.Size(145, 32)
        Me.tbxHectareas.TabIndex = 111
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHectareas.Location = New System.Drawing.Point(30, 81)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(107, 24)
        Me.lblHectareas.TabIndex = 110
        Me.lblHectareas.Text = "Hectareas"
        '
        'tbxGanado_max
        '
        Me.tbxGanado_max.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGanado_max.Location = New System.Drawing.Point(534, 78)
        Me.tbxGanado_max.MaxLength = 50
        Me.tbxGanado_max.Name = "tbxGanado_max"
        Me.tbxGanado_max.Size = New System.Drawing.Size(145, 32)
        Me.tbxGanado_max.TabIndex = 113
        '
        'lblganado_max
        '
        Me.lblganado_max.AutoSize = True
        Me.lblganado_max.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblganado_max.Location = New System.Drawing.Point(464, 38)
        Me.lblganado_max.Name = "lblganado_max"
        Me.lblganado_max.Size = New System.Drawing.Size(274, 24)
        Me.lblganado_max.TabIndex = 112
        Me.lblganado_max.Text = "Cantidad maxima de ganado"
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.GroupBox1)
        Me.gbxGeneral.Controls.Add(Me.gbxAlimento)
        Me.gbxGeneral.Controls.Add(Me.tbxNombre)
        Me.gbxGeneral.Controls.Add(Me.lblNombre)
        Me.gbxGeneral.Controls.Add(Me.tbxGanado_max)
        Me.gbxGeneral.Controls.Add(Me.lblganado_max)
        Me.gbxGeneral.Controls.Add(Me.tbxHectareas)
        Me.gbxGeneral.Controls.Add(Me.lblHectareas)
        Me.gbxGeneral.Enabled = False
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 128)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(785, 366)
        Me.gbxGeneral.TabIndex = 114
        Me.gbxGeneral.TabStop = False
        '
        'gbxAlimento
        '
        Me.gbxAlimento.Controls.Add(Me.Button5)
        Me.gbxAlimento.Controls.Add(Me.Button6)
        Me.gbxAlimento.Controls.Add(Me.Button2)
        Me.gbxAlimento.Controls.Add(Me.cbxCantidad)
        Me.gbxAlimento.Controls.Add(Me.lblTipo)
        Me.gbxAlimento.Controls.Add(Me.tbxCantidad)
        Me.gbxAlimento.Controls.Add(Me.lblCantidad)
        Me.gbxAlimento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAlimento.Location = New System.Drawing.Point(410, 149)
        Me.gbxAlimento.Name = "gbxAlimento"
        Me.gbxAlimento.Size = New System.Drawing.Size(369, 211)
        Me.gbxAlimento.TabIndex = 115
        Me.gbxAlimento.TabStop = False
        Me.gbxAlimento.Text = "Alimento proporcionado"
        '
        'cbxCantidad
        '
        Me.cbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbxCantidad.Location = New System.Drawing.Point(182, 92)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(145, 32)
        Me.cbxCantidad.TabIndex = 113
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(15, 95)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(49, 24)
        Me.lblTipo.TabIndex = 112
        Me.lblTipo.Text = "Tipo"
        '
        'tbxCantidad
        '
        Me.tbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCantidad.Location = New System.Drawing.Point(182, 31)
        Me.tbxCantidad.MaxLength = 50
        Me.tbxCantidad.Name = "tbxCantidad"
        Me.tbxCantidad.Size = New System.Drawing.Size(145, 32)
        Me.tbxCantidad.TabIndex = 111
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(15, 34)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(93, 24)
        Me.lblCantidad.TabIndex = 110
        Me.lblCantidad.Text = "Cantidad"
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNombre.Location = New System.Drawing.Point(238, 35)
        Me.tbxNombre.MaxLength = 50
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(145, 32)
        Me.tbxNombre.TabIndex = 117
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(30, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 24)
        Me.lblNombre.TabIndex = 116
        Me.lblNombre.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCapacidad)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 211)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tanques"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(220, 31)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 32)
        Me.TextBox1.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Numero de serie"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(220, 92)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(145, 32)
        Me.TextBox2.TabIndex = 120
        '
        'lblCapacidad
        '
        Me.lblCapacidad.AutoSize = True
        Me.lblCapacidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacidad.Location = New System.Drawing.Point(12, 95)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(175, 24)
        Me.lblCapacidad.TabIndex = 119
        Me.lblCapacidad.Text = "Capacidad (litros)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 42)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 42)
        Me.Button2.TabIndex = 116
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(130, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 42)
        Me.Button3.TabIndex = 123
        Me.Button3.Text = "Quitar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(254, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 42)
        Me.Button4.TabIndex = 124
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(251, 148)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 42)
        Me.Button5.TabIndex = 126
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(130, 148)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 42)
        Me.Button6.TabIndex = 125
        Me.Button6.Text = "Quitar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.tbxSerie)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmTambo"
        Me.Text = "Tambo"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.gbxAlimento.ResumeLayout(False)
        Me.gbxAlimento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents tbxHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents tbxGanado_max As System.Windows.Forms.TextBox
    Friend WithEvents lblganado_max As System.Windows.Forms.Label
    Friend WithEvents gbxGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents gbxAlimento As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents tbxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
