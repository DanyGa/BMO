Public Class OpcionesMenu
    Inherits frmMenu
    Implements IMenuPrincipal

    Public Sub Open() Implements IMenuPrincipal.Open
        frmAtbash.Show()
    End Sub

    Public Sub Aperto() Implements IMenuPrincipal.Aperto
        frmCesar.Show()
    End Sub
End Class
