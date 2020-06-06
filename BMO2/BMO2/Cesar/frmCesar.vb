Public Class frmCesar
    Private Sub BtnCifrar_Click(sender As Object, e As EventArgs) Handles btnCifrar.Click
        Dim al As MetodoCesar = New MetodoCesar()
        txtCyD.Items.Add(al.ABC(txtPalabras.Text))
        txtResultados.Text = al.cambio

    End Sub

    Private Sub BtnDesifrar_Click(sender As Object, e As EventArgs) Handles btnDesifrar.Click
        Dim at As MetodoCesar = New MetodoCesar()
        at.Lim()
        txtCyD.Items.Add(at.DFG(txtPalabras.Text))
        txtResultados.Text = at.cambio
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles salirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AtbashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtbashToolStripMenuItem.Click
        Dim At As New MetodomnsCesar
        At.Abrir()
        Me.Close()
    End Sub
End Class