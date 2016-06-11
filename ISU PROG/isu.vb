Public Class frmISU


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        tsIngresar.Enabled = False
        tsEnlistar.Enabled = False
        tsEliminar.Enabled = False
        tsInsert.Enabled = False
        tsShow.Enabled = False
        tsRemove.Enabled = False
        tsModify.Enabled = False
        tsModificar.Enabled = False
        tsConsult.Enabled = False
        tsConsultar.Enabled = False
        tsExit.Enabled = False
        tsSalir.Enabled = False

    End Sub


    Private Sub cbxIdioma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxIdioma.SelectedIndexChanged

        If cbxIdioma.Text() = "English" Then
            Lblpass.Text() = "Password"
            lblUser.Text() = "User"
            btnInicio.Text() = "Login"
            mspIngles.Show()
            mspEspanol.Hide()
        Else
            Lblpass.Text() = "Contraseña"
            lblUser.Text() = "Usuario"
            btnInicio.Text() = "Iniciar"
            mspEspanol.Show()
            mspIngles.Hide()
        End If

    End Sub

    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click

        'validar datos del login
        pnlInicio.Hide()
        If cbxIdioma.Text() = "English" Then
            tsInsert.Enabled = True
            tsShow.Enabled = True
            tsRemove.Enabled = True
            tsModify.Enabled = True
            tsConsult.Enabled = True
            tsExit.Enabled = True
        Else
            tsIngresar.Enabled = True
            tsEnlistar.Enabled = True
            tsEliminar.Enabled = True
            tsModificar.Enabled = True
            tsConsultar.Enabled = True
            tsSalir.Enabled = True
        End If

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
        Form1_Load(sender, e)
    End Sub

    Private Sub tsInsert_Click(sender As System.Object, e As System.EventArgs) Handles tsInsert.Click
        frmInsert.Show()
    End Sub

    Private Sub tsRemove_Click(sender As System.Object, e As System.EventArgs) Handles tsRemove.Click
        frmRemove.Show()
    End Sub

    Private Sub tsConsult_Click(sender As System.Object, e As System.EventArgs) Handles tsConsult.Click
        frmConsult.Show()
    End Sub

    Private Sub tsShow_Click(sender As System.Object, e As System.EventArgs) Handles tsShow.Click
        frmShow.Show()
    End Sub

    Private Sub tsModify_Click(sender As System.Object, e As System.EventArgs) Handles tsModify.Click
        frmModify.Show()
    End Sub

    Private Sub tsExit_Click(sender As System.Object, e As System.EventArgs) Handles tsExit.Click
        pnlInicio.Show()
        Form1_Load(sender, e)
    End Sub
End Class
