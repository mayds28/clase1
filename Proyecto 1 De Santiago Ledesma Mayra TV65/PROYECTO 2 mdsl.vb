Imports System

Module Program
    Sub Main()
        Dim metrotela As Integer
        Dim metrosxprenda As Single
        Dim numprendas As Single
        Console.Write("Ingrese cuantos metros de tela tiene:")
        metrotela = Console.ReadLine()
        Console.Write("Ingrese cuantos metros por prenda ocupa:")
        metrosxprenda = Console.ReadLine()
        numprendas = metrotela / metrosxprenda
        Console.Write("El numero de prendas que saldran es:")
        Console.Write(numprendas)
        Console.ReadKey()
    End Sub
End Module
