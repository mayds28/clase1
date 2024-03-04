Imports System

Module Program
    Sub Main(args As String())
        Dim ph As Integer

        Console.WriteLine("Cual es el valor del ph")
        ph = Console.ReadLine()

        If ph < 7 Then
            Console.WriteLine("es ácido!")
        End If

        If ph < 3 And ph > 0 Then
            Console.WriteLine("añadir dos tazas de NaHCO3")
        End If

        If ph >= 3 And ph < 7 Then
            Console.WriteLine("añadir una taza de NaHCO3")
        End If

        If ph > 7 Then
            Console.WriteLine("Es una base!")
        End If

        If ph > 7 And ph < 10 Then
            Console.WriteLine("añadir 50 ml de H2SO4")
        End If

        If ph = 7 Then
            Console.WriteLine("es neutro")
        End If

        If ph > 10 And ph < 14 Then
            Console.WriteLine("añadir 100 ml de H2SO4")
        End If

        If ph > 14 Then
            Console.WriteLine("Fuera de rango")
        End If

        If ph < 0 Then
            Console.WriteLine("Fuera de rango")
        End If

    End Sub
End Module
