<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdeñe
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
        Me.gbxLeche = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.lblOrdeñecant = New System.Windows.Forms.Label()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.gbxTercer = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFinalt = New System.Windows.Forms.Label()
        Me.lblIniciot = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.gbxLeche.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxTercer.SuspendLayout()
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
        'gbxLeche
        '
        Me.gbxLeche.Controls.Add(Me.TextBox3)
        Me.gbxLeche.Controls.Add(Me.TextBox2)
        Me.gbxLeche.Controls.Add(Me.CheckBox1)
        Me.gbxLeche.Controls.Add(Me.CheckBox2)
        Me.gbxLeche.Controls.Add(Me.GroupBox1)
        Me.gbxLeche.Controls.Add(Me.TextBox1)
        Me.gbxLeche.Controls.Add(Me.Label2)
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
        Me.gbxLeche.Enabled = False
        Me.gbxLeche.Location = New System.Drawing.Point(28, 180)
        Me.gbxLeche.Name = "gbxLeche"
        Me.gbxLeche.Size = New System.Drawing.Size(756, 334)
        Me.gbxLeche.TabIndex = 73
        Me.gbxLeche.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.tbxNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 186)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(103, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 42)
        Me.Button3.TabIndex = 116
        Me.Button3.Text = "Ordeñada"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(86, 72)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(145, 32)
        Me.tbxNum.TabIndex = 114
        Me.tbxNum.Text = "000000000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 24)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Numero de lote"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(251, 19)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 32)
        Me.TextBox1.TabIndex = 110
        Me.TextBox1.Text = "000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 24)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Numero de lote"
        '
        'tbxGrasa
        '
        Me.tbxGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGrasa.Location = New System.Drawing.Point(251, 97)
        Me.tbxGrasa.MaxLength = 3
        Me.tbxGrasa.Name = "tbxGrasa"
        Me.tbxGrasa.Size = New System.Drawing.Size(142, 32)
        Me.tbxGrasa.TabIndex = 57
        Me.tbxGrasa.Text = "000"
        '
        'lblGrasa
        '
        Me.lblGrasa.AutoSize = True
        Me.lblGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrasa.Location = New System.Drawing.Point(6, 100)
        Me.lblGrasa.Name = "lblGrasa"
        Me.lblGrasa.Size = New System.Drawing.Size(199, 24)
        Me.lblGrasa.TabIndex = 56
        Me.lblGrasa.Text = "Porcentaje de grasa"
        '
        'tbxProteina
        '
        Me.tbxProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxProteina.Location = New System.Drawing.Point(251, 140)
        Me.tbxProteina.MaxLength = 3
        Me.tbxProteina.Name = "tbxProteina"
        Me.tbxProteina.Size = New System.Drawing.Size(142, 32)
        Me.tbxProteina.TabIndex = 55
        Me.tbxProteina.Text = "000"
        '
        'lblProteina
        '
        Me.lblProteina.AutoSize = True
        Me.lblProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteina.Location = New System.Drawing.Point(6, 143)
        Me.lblProteina.Name = "lblProteina"
        Me.lblProteina.Size = New System.Drawing.Size(222, 24)
        Me.lblProteina.TabIndex = 54
        Me.lblProteina.Text = "Porcentaje de proteina"
        '
        'tbxUrea
        '
        Me.tbxUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUrea.Location = New System.Drawing.Point(251, 187)
        Me.tbxUrea.MaxLength = 3
        Me.tbxUrea.Name = "tbxUrea"
        Me.tbxUrea.Size = New System.Drawing.Size(142, 32)
        Me.tbxUrea.TabIndex = 53
        Me.tbxUrea.Text = "000"
        '
        'lblUrea
        '
        Me.lblUrea.AutoSize = True
        Me.lblUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrea.Location = New System.Drawing.Point(6, 190)
        Me.lblUrea.Name = "lblUrea"
        Me.lblUrea.Size = New System.Drawing.Size(188, 24)
        Me.lblUrea.TabIndex = 52
        Me.lblUrea.Text = "Porcentaje de urea"
        '
        'tbxRecuentocel
        '
        Me.tbxRecuentocel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentocel.Location = New System.Drawing.Point(251, 264)
        Me.tbxRecuentocel.MaxLength = 11
        Me.tbxRecuentocel.Name = "tbxRecuentocel"
        Me.tbxRecuentocel.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentocel.TabIndex = 51
        Me.tbxRecuentocel.Text = "00000000000"
        '
        'lblRecuentoCel
        '
        Me.lblRecuentoCel.AutoSize = True
        Me.lblRecuentoCel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentoCel.Location = New System.Drawing.Point(6, 264)
        Me.lblRecuentoCel.Name = "lblRecuentoCel"
        Me.lblRecuentoCel.Size = New System.Drawing.Size(200, 48)
        Me.lblRecuentoCel.TabIndex = 50
        Me.lblRecuentoCel.Text = "Recuento de células" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      somáticas"
        '
        'tbxRecuentobac
        '
        Me.tbxRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentobac.Location = New System.Drawing.Point(251, 225)
        Me.tbxRecuentobac.MaxLength = 11
        Me.tbxRecuentobac.Name = "tbxRecuentobac"
        Me.tbxRecuentobac.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentobac.TabIndex = 49
        Me.tbxRecuentobac.Text = "00000000000"
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.Location = New System.Drawing.Point(6, 62)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(63, 24)
        Me.lblLitros.TabIndex = 46
        Me.lblLitros.Text = "Litros"
        '
        'lblRecuentobac
        '
        Me.lblRecuentobac.AutoSize = True
        Me.lblRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentobac.Location = New System.Drawing.Point(6, 228)
        Me.lblRecuentobac.Name = "lblRecuentobac"
        Me.lblRecuentobac.Size = New System.Drawing.Size(205, 24)
        Me.lblRecuentobac.TabIndex = 48
        Me.lblRecuentobac.Text = "Recuento bacteriano"
        '
        'tbxLitros
        '
        Me.tbxLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLitros.Location = New System.Drawing.Point(251, 59)
        Me.tbxLitros.MaxLength = 11
        Me.tbxLitros.Name = "tbxLitros"
        Me.tbxLitros.Size = New System.Drawing.Size(142, 32)
        Me.tbxLitros.TabIndex = 47
        Me.tbxLitros.Text = "00000000000"
        '
        'lblOrdeñecant
        '
        Me.lblOrdeñecant.AutoSize = True
        Me.lblOrdeñecant.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdeñecant.Location = New System.Drawing.Point(43, 59)
        Me.lblOrdeñecant.Name = "lblOrdeñecant"
        Me.lblOrdeñecant.Size = New System.Drawing.Size(62, 24)
        Me.lblOrdeñecant.TabIndex = 108
        Me.lblOrdeñecant.Text = "Turno"
        '
        'cbxCantidad
        '
        Me.cbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbxCantidad.Location = New System.Drawing.Point(279, 51)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(142, 32)
        Me.cbxCantidad.TabIndex = 109
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(157, 117)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 110
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'gbxTercer
        '
        Me.gbxTercer.Controls.Add(Me.DateTimePicker3)
        Me.gbxTercer.Controls.Add(Me.DateTimePicker2)
        Me.gbxTercer.Controls.Add(Me.DateTimePicker1)
        Me.gbxTercer.Controls.Add(Me.Label5)
        Me.gbxTercer.Controls.Add(Me.lblFinalt)
        Me.gbxTercer.Controls.Add(Me.lblIniciot)
        Me.gbxTercer.Enabled = False
        Me.gbxTercer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTercer.Location = New System.Drawing.Point(444, 38)
        Me.gbxTercer.Name = "gbxTercer"
        Me.gbxTercer.Size = New System.Drawing.Size(345, 136)
        Me.gbxTercer.TabIndex = 111
        Me.gbxTercer.TabStop = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(178, 95)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker3.TabIndex = 81
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(178, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker2.TabIndex = 80
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker1.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Fecha"
        '
        'lblFinalt
        '
        Me.lblFinalt.AutoSize = True
        Me.lblFinalt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalt.Location = New System.Drawing.Point(26, 101)
        Me.lblFinalt.Name = "lblFinalt"
        Me.lblFinalt.Size = New System.Drawing.Size(99, 24)
        Me.lblFinalt.TabIndex = 64
        Me.lblFinalt.Text = "Hora final"
        '
        'lblIniciot
        '
        Me.lblIniciot.AutoSize = True
        Me.lblIniciot.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciot.Location = New System.Drawing.Point(26, 63)
        Me.lblIniciot.Name = "lblIniciot"
        Me.lblIniciot.Size = New System.Drawing.Size(110, 24)
        Me.lblIniciot.TabIndex = 62
        Me.lblIniciot.Text = "Hora inicio"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(415, 77)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(193, 28)
        Me.CheckBox2.TabIndex = 114
        Me.CheckBox2.Text = "Consumo externo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(415, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(187, 28)
        Me.CheckBox1.TabIndex = 115
        Me.CheckBox1.Text = "Consumo interno"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(608, 38)
        Me.TextBox2.MaxLength = 11
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 32)
        Me.TextBox2.TabIndex = 116
        Me.TextBox2.Text = "00000000000"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(607, 75)
        Me.TextBox3.MaxLength = 11
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(142, 32)
        Me.TextBox3.TabIndex = 117
        Me.TextBox3.Text = "00000000000"
        '
        'frmOrdeñe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxTercer)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.lblOrdeñecant)
        Me.Controls.Add(Me.cbxCantidad)
        Me.Controls.Add(Me.gbxLeche)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmOrdeñe"
        Me.Text = "frmOrdeñe"
        Me.gbxLeche.ResumeLayout(False)
        Me.gbxLeche.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxTercer.ResumeLayout(False)
        Me.gbxTercer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOrdeñecant As System.Windows.Forms.Label
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents gbxTercer As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFinalt As System.Windows.Forms.Label
    Friend WithEvents lblIniciot As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
