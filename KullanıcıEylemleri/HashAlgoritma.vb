Imports System.Security.Cryptography
Imports System.Text
Module HashAlgoritma
    Public Function KodUret(Algoritma As HashAlgorithm, Metin As String) As String
        Dim sonuc As String = Nothing
        Dim ByteMetin() As Byte = Encoding.UTF8.GetBytes(Metin)
        Dim ByteSonuc() As Byte = Algoritma.ComputeHash(ByteMetin)
        For Each eleman As Byte In ByteSonuc
            sonuc &= eleman.ToString("x2")
        Next
        Return sonuc
    End Function

    Public Function IsAlphabetic(input As String) As Boolean
        If input Is Nothing Then
            Return False
        End If

        For Each c As Char In input
            If Not Char.IsLetter(c) Then
                Return False
            End If
        Next
        Return True
    End Function
End Module
