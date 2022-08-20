Imports System

Module Program
    Sub Main(args As String())

        Dim idade, altura As Integer
        Dim nome, sobrenome As String

        Console.Write("Digite seu nome:")
        nome = Console.ReadLine()

        Console.Write("Digite seu sobrenome:")
        sobrenome = Console.ReadLine()

        Console.Write("Digite sua idade:")
        idade = Console.ReadLine()

        Console.Write("Digite sua altura:")
        altura = Console.ReadLine()

        Console.WriteLine("Seu nome é " & nome & " e seu sobrenome é " & sobrenome)
        Console.Write("Sua idade é {0} e sua altura é {1}, vc já passou por {0} primaveras", idade, altura)

        Console.ReadLine()

    End Sub
End Module
