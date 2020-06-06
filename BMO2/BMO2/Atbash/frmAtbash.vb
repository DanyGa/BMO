Public Class frmAtbash
    Private Sub BtnCifrar_Click(sender As Object, e As EventArgs) Handles btnCifrar.Click
        Dim at As MetodoAtbash = New MetodoAtbash()
        txtEncriptadas.Items.Add(at.ZXY(txtPalabras.Text))
        txtResultados.Text = at.cambio
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles salirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CriptogramasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles criptogramasToolStripMenuItem.Click
        Dim Ce As New MetodomsnAtbash
        Ce.Abrir()
        Me.Close()
    End Sub
End Class