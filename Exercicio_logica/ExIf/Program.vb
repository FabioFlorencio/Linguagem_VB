Imports System

Module Program
    Sub Main(args As String())
        Dim n1, n2 As Integer

        Console.Write("Digite um valor:")
        n1 = CInt(Console.ReadLine())

        Console.Write("Digie outro valor:")
        n2 = CInt(Console.ReadLine())

        If n1 = n2 Then
            Console.WriteLine("Os números são iguais!")
        Else
            Console.WriteLine("Os números são diferentes!")
        End If

    End Sub
End Module
