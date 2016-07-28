<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnlistar
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
        Me.lbxEnlistar = New System.Windows.Forms.ListBox()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lbxEnlistar
        '
        Me.lbxEnlistar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxEnlistar.FormattingEnabled = True
        Me.lbxEnlistar.ItemHeight = 32
        Me.lbxEnlistar.Location = New System.Drawing.Point(27, 24)
        Me.lbxEnlistar.Name = "lbxEnlistar"
        Me.lbxEnlistar.Size = New System.Drawing.Size(722, 484)
        Me.lbxEnlistar.TabIndex = 70
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlBlue.Location = New System.Drawing.Point(803, 0)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(24, 579)
        Me.pnlBlue.TabIndex = 71
        Me.pnlBlue.Visible = False
        '
        'frmEnlistar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.lbxEnlistar)
        Me.Name = "frmEnlistar"
        Me.Text = "Enlistar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxEnlistar As System.Windows.Forms.ListBox
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
End Class
