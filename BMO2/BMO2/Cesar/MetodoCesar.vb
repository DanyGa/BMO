Public Class MetodoCesar
    Inherits frmCesar

    Public cambio As String = ""


    Public Function DFG(ByVal codigo As String)


        For Each ch As Char In codigo.ToCharArray()
            cambio += Chr(Asc(ch) - 3)
        Next
        Return cambio
    End Function
    Public Function ABC(ByVal codigo As String)
        For Each a As Char In codigo.ToCharArray()
            cambio += Chr(Asc(a) + 3)
        Next

        Return cambio
    End Function
    Public Sub Lim()
        txtCyD.Items.Clear()
    End Sub

End Class
