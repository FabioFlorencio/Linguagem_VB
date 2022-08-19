Imports System

Module Program
    Sub Main(args As String())

        Dim nome As String
        Dim num1, num2 As String ' Variaveis
        Dim numero1, numero2, soma As Integer

        Console.WriteLine("Digite seu nome:")
        nome = Console.ReadLine() ' Sempre o read transforma sua sáida em string 

        Console.WriteLine("Digite um número:")
        num1 = Console.ReadLine()

        Console.WriteLine("Digite outro número:")
        num2 = Console.ReadLine()

        numero1 = num1 ' Exemplo de conversão implicita de dados não é recomendado
        numero2 = num2 ' Converte String em Integer
        soma = numero1 + numero2

        Console.WriteLine("Seu nome é " + nome)
        Console.Write("A soma é:")
        Console.Write(soma)
        Console.WriteLine()

    End Sub
End Module
