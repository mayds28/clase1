Imports System

Module Program
    Public Class Prendas
        Private Tipotela As String
        Private Talla As Double
        Private Fibra As String
        Private Color As String
        Private Tipocostura As String
        Private Hombre As Boolean
        Private Mujer As Boolean


        Public Sub Inicializar()
            Console.WriteLine("¿Que tipo de tela es?")
            Tipotela = Console.ReadLine()
            Console.WriteLine("¿Que talla es?")
            Talla = Console.ReadLine()
            Console.WriteLine("¿Que tipo de fibra es?")
            Fibra = Console.ReadLine()
            Console.WriteLine("¿Que color es?")
            Color = Console.ReadLine()
            Console.WriteLine("¿Que tipo de costura tiene?")
            Tipocostura = Console.ReadLine()
            Console.WriteLine("¿Es para Hombre?")
            Hombre = Console.ReadLine()
            Console.WriteLine("¿Es para Mujer?")
            Mujer = Console.ReadLine()
        End Sub

        Public Sub Imprimir()
            Console.WriteLine("Tela: ")
            Console.WriteLine(Tipotela)
            Console.WriteLine("Tallas: ")
            Console.WriteLine(Talla)
            Console.WriteLine("Fibra: ")
            Console.WriteLine(Fibra)
            Console.WriteLine("Color:  ")
            Console.WriteLine(Color)
            Console.WriteLine("Tipocostura: ")
            Console.WriteLine(Tipocostura)
            Console.WriteLine("¿Es para Hombre?: ")
            Console.WriteLine(Hombre)
            Console.WriteLine("¿Es para mujer?: ")
            Console.WriteLine(Mujer)

        End Sub
    End Class



    Sub Main()
        Dim camisa As New Prendas
        camisa.Inicializar()
        camisa.Imprimir()

    End Sub
End Module
