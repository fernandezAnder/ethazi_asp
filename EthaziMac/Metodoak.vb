Imports System.Security.Cryptography
Imports System.Text
Imports System
Public Class Metodoak


    Public Shared Function encriptarMD5(ByVal input As String) As String

        Dim md5Hasher As MD5 = MD5.Create()

        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))


        Dim sBuilder As New StringBuilder()


        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        Return sBuilder.ToString()

    End Function


    Shared Function verificarMD5(ByVal input As String, ByVal hash As String) As Boolean

        Dim hashOfInput As String = encriptarMD5(input)
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function


    Shared Function encriptarEramaker(ByVal input As String) As String
        Return Eramake.eCryptography.Encrypt(input)
    End Function

    Shared Function desencriptarEramaker(ByVal input As String) As String
        Return Eramake.eCryptography.Decrypt(input)
    End Function



End Class
