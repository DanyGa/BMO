Public Class frmMenu
    Private Sub BtnAtbash_Click(sender As Object, e As EventArgs) Handles btnAtbash.Click
        Dim OpenAtbash As New OpcionesMenu
        OpenAtbash.Open()
        Me.Close()
    End Sub

    Private Sub BtnCesar_Click(sender As Object, e As EventArgs) Handles btnCesar.Click
        Dim ApertoCesar As New OpcionesMenu
        ApertoCesar.Aperto()
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class