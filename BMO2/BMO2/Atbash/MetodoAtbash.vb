Public Class MetodoAtbash
    Public cambio As String = ""

    Public Function ZXY(ByVal codigo As String)
        For Each a As Char In codigo.ToCharArray()
            If Char.IsLower(a) Then
                Dim otro As Integer = Asc(a) - Asc("a")
                cambio += Chr(Asc("z") - otro)
            ElseIf Char.IsUpper(a) Then
                Dim otro As Integer = Asc(a) - Asc("A")
                cambio += Chr(Asc("Z") - otro)
            Else
                cambio += a
            End If
        Next

        Return cambio
    End Function
End Class
