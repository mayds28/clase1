Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Console.WriteLine("De Santiago Ledesma Mayra")
        Console.WriteLine("Jueves,21 de marzo del 2024")
        Console.WriteLine("Grupo 6TV65")
        Console.WriteLine("Examen de programación orientada a objetos")

        Console.WriteLine("Calcule el titulo de un hilo")
        Dim Titulo As Single
        Dim Longitud As Integer
        Dim Peso As Integer

        Console.WriteLine("Ingrese Longitud")
        Longitud = Console.ReadLine()
        Console.WriteLine("Ingrese Peso")
        Peso = Console.ReadLine()
        Titulo = Longitud / Peso
        Console.WriteLine("El titulo de su hilo es...")
        Console.Write(Titulo)

        Do While Titulo = 100000
            Console.Write(Titulo)
            Console.Write(" - ")
            Titulo = Longitud / Peso
        Loop
        Console.ReadKey()
    End Sub

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
End Module
