Imports System

Module Program
    Sub Main(args As String())
        'Calcula a seguinte expressão: (3*3*(3+6)/(1+2)^3)^(5-3)Mod 2

        Dim Resultado, ResultMod As Double
        Dim num1, num2, soma As Integer

        Resultado = (3 * 3 * (3 + 6) / (1 + 2) ^ 3) ^ (5 - 3) Mod 2
        num1 = 10
        num2 = 2
        ResultMod = 11 Mod 2

        Console.WriteLine("Soma: " & (num1 + num2))
        Console.WriteLine("Subtração: " & (num1 - num2))
        Console.WriteLine("Multiplicação: " & (num1 * num2))
        Console.WriteLine("Divisão: " & (num1 / num2))
        Console.WriteLine("Mod: " & (ResultMod))

        Console.WriteLine("Expressão:" & Resultado)

    End Sub
End Module
