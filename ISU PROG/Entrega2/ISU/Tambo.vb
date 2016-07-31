Public Class frmTambo

    Private Sub Tambo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Boton_idioma(btnOpcion)
        lblCantidad.Text = cantidad
        lblganado_max.Text = ganado_max
        lblHectareas.Text = hectareas
        lblNombre.Text = nombre
        lblSerie.Text = serie
        btnBuscar.Text = buscar
        gbxAlimento.Text = alimento

    End Sub


End Class