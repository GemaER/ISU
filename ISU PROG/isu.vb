Public Class frmISU


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        tsIngresar.Enabled = False
        tsEnlistar.Enabled = False
        tsEliminar.Enabled = False
        tsConsultar.Enabled = False
        tsSalir.Enabled = False
        tsTambo.Enabled = False
        tsModificar.Enabled = False
        tbxPass.Text() = ""
        tbxUser.Text() = ""

    End Sub

    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged

        If cbxIdioma.Text() = "English" Then
            Lblpass.Text() = "Password"
            lblUser.Text() = "User"
            btnInicio.Text() = "Login"
            tsIngresar.Text() = "Insert"
            tsEnlistar.Text() = "Show"
            tsEliminar.Text() = "Remove"
            tsModificar.Text() = "Modify"
            tsSalir.Text() = "Exit"
        ElseIf cbxIdioma.Text() = "Español" Then
            Lblpass.Text() = "Contraseña"
            lblUser.Text() = "Usuario"
            btnInicio.Text() = "Iniciar"
            tsIngresar.Text() = "Ingresar"
            tsEnlistar.Text() = "Enlistar"
            tsEliminar.Text() = "Emilinar"
            tsModificar.Text() = "Modificar"
            tsSalir.Text() = "Salir"
        Else
            Lblpass.Text() = "Senha"
            lblUser.Text() = "Usuário"
            btnInicio.Text() = "Começo"
            tsIngresar.Text() = "Depósito"
            tsEnlistar.Text() = "Alistar"
            tsEliminar.Text() = "Remover"
            tsModificar.Text() = "Mudança"
            tsSalir.Text() = "Saida"
        End If

    End Sub

    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click

        'validar datos del login
        pnlInicio.Hide()
        pnlBlue.Show()
        If cbxIdioma.Text() = "English" Then
            tsIngresar.Enabled = True
            tsEnlistar.Enabled = True
            tsEliminar.Enabled = True
            tsModificar.Enabled = True
            tsConsultar.Enabled = True
            tsSalir.Enabled = True
        ElseIf cbxIdioma.Text() = "Español" Then
            tsIngresar.Enabled = True
            tsEnlistar.Enabled = True
            tsEliminar.Enabled = True
            tsModificar.Enabled = True
            tsConsultar.Enabled = True
            tsSalir.Enabled = True
        Else
            tsIngresar.Enabled = True
            tsEliminar.Enabled = True
            tsConsultar.Enabled = True
            tsEnlistar.Enabled = True
            tsModificar.Enabled = True
            tsSalir.Enabled = True
        End If
        tsTambo.Enabled = True
    End Sub

    Private Sub tsIngresar_Click(sender As System.Object, e As System.EventArgs) Handles tsIngresar.Click
        frmIngresar.Show()
    End Sub
 
    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        frmEliminar.Show()
    End Sub

    Private Sub tsConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsConsultar.Click
        frmConsultar.Show()
    End Sub

    Private Sub tsEnlistar_Click(sender As System.Object, e As System.EventArgs) Handles tsEnlistar.Click
        frmEnlistar.Show()
    End Sub

    Private Sub tsModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsModificar.Click
        frmModificar.Show()
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsSalir.Click
        pnlInicio.Show()
        pnlBlue.Hide()
        Form1_Load(sender, e)
    End Sub

    Private Sub tsTambo_Click(sender As System.Object, e As System.EventArgs) Handles tsTambo.Click
        frmTambo.Show()
    End Sub

End Class
