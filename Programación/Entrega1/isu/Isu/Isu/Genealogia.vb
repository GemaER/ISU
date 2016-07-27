Public Class frmGenealogia
    Private Sub Idioma(lblNum As Label, lblSex As Label, lblRaza As Label)

        If frmISU.tsModificar.Text() = "Modify" Then
            lblNum.Text() = "Number"
            lblSex.Text() = "Gender"
            lblRaza.Text() = "Race"
        ElseIf frmISU.tsModificar.Text() = "Mudança" Then
            lblNum.Text() = "Numero"
            lblSex.Text() = "Sexo"
            lblRaza.Text() = "Raça"
        Else
            lblNum.Text() = "Numero"
            lblSex.Text() = "Sexo"
            lblRaza.Text() = "Raza"
        End If
    End Sub

    Private Sub frmGenealogia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Idioma(lblNum, lblSexo, lblRaza)
        Idioma(lblNumH, lblSexoH, lblRazaH)
        Idioma(lblNumM, lblSexoM, lblRazaM)
        Idioma(lblNumMM, lblSexoMM, lblRazaMM)
        Idioma(lblnumMH, lblSexoMH, lblRazaMH)
        Idioma(lblNumHM, lblSexoHM, lblRazaHM)
        Idioma(lblNumHH, lblSexoHH, lblRazaHH)
    End Sub
End Class