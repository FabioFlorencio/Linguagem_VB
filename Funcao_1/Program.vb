Imports System

Module Program
    Sub Main(args As String())

        Dim idade, altura As String
        Dim a, b As Integer
        Dim idade_convertida, altura_convertida As Double
        Dim aChar As Char
        Dim aDate As String
        Dim valida As Boolean

        idade_convertida = CInt("11")    ' Converte String em Integer
        altura_convertida = CDbl("1,80")  ' Converte String em Double
        aChar = CChar("BCDF") ' Converte String em char
        aDate = CDate("February 12, 1969")  ' Converte String em Date
        a = 5
        b = 4

        Console.WriteLine("Vc tem " & idade_convertida & " anos de idade e " & altura_convertida & " de altura.")
        Console.WriteLine("Transformou String em char: " & aChar)
        Console.WriteLine("Transformou String em data: " & aDate)
        Console.WriteLine("A e B são iguais? " & CBool(a = b))
        Console.WriteLine()

    End Sub
End Module
