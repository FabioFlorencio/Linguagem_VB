Imports System

Module Program
    Sub Main(args As String())

        Dim num1, num2 As String
        Dim numero1, numero2, soma As Integer

        Console.Write("Digite um número:")
        num1 = Console.ReadLine()
        Console.Write("Digite outro número:")
        num2 = Console.ReadLine()

        numero1 = CInt(num1) ' Converte String em Integer
        numero2 = CInt(num2)

        soma = numero1 + numero2

        Console.Write("A soma é:")
        Console.Write(soma)

        Console.WriteLine()

    End Sub
End Module
