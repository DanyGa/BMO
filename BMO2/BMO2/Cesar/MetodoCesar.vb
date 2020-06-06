Imports System.Windows.Forms
Public Class MetodoCesar
    Inherits frmCesar

    Public cambio As String

    Public Function Cifrar(ByVal codigo As String) As String
        For Each ch As Char In codigo.ToCharArray()
            cambio += ChrW((ch + 3))
        Next
        Return cambio
    End Function

    Public Sub DecifrarCadena()
        Dim t, letras As Integer
        Dim cadena As String = txtPalabras.Text
        letras = cadena.Length
        Dim ch As Char() = New Char(letras - 1) {}

        For i As Integer = 0 To letras - 1
            t = CInt(cadena(i))
            ch(i) = ChrW((t - 3))
            txtCyD.Items.Add(ch(i))
        Next
    End Sub

    Public Function Decifrar(ByVal codigo As String) As String
        For Each ch As Char In codigo.ToCharArray()
            cambio += ChrW((ch - 3))
        Next

        Return cambio
    End Function

    Public Sub Lim()
        txtCyD.Items.Clear()
    End Sub

End Class
