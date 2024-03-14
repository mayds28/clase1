Imports System
Imports System.Reflection.PortableExecutable

Module Program
    Public Class Animales
        Private numpatas As Double
        Private numojos As Double
        Private numdientes As Double
        Private pelo As Boolean
        Private nombre As String
        Private comestible As Boolean
        Private vida As Double

        Public Sub Inicializar()
            Console.WriteLine("¿Cuantas patas tiene?")
            numpatas = Console.ReadLine()
            Console.WriteLine("¿Cuantos ojos tiene?")
            numojos = Console.ReadLine()
            Console.WriteLine("¿Cuantos dientes tiene?")
            numdientes = Console.ReadLine()
            Console.WriteLine("¿Tiene pelo?")
            pelo = Console.ReadLine()
            Console.WriteLine("¿Como se llama?")
            nombre = Console.ReadLine()
            Console.WriteLine("¿Es comestible?")
            comestible = Console.ReadLine()
            Console.WriteLine("Este animal tiene 100 de vida...")
            vida = 100

        End Sub

        Public Sub Imprimir()
            Console.WriteLine("Patas: ")
            Console.WriteLine(numpatas)
            Console.WriteLine("Ojos: ")
            Console.WriteLine(numojos)
            Console.WriteLine("Dientes: ")
            Console.WriteLine(numdientes)
            Console.WriteLine("¿Tiene pelo?")
            Console.WriteLine(pelo)
            Console.WriteLine("¿Como se llama?")
            Console.WriteLine(nombre)
            Console.WriteLine("¿Es comestible?")
            Console.WriteLine(comestible)
        End Sub

        Public Sub golpe()
            Vida = vida - 10
            Console.WriteLine("le queda de vida:")
            Console.WriteLine(vida)
        End Sub

        Public Sub posion()
            vida = vida + 50
            Console.WriteLine("le queda de vida:")
            Console.WriteLine(vida)
        End Sub

    End Class
    Sub Main(args As String())

        Dim kanguro As New Animales()

        kanguro.Inicializar()
        Console.ReadKey()
        kanguro.Imprimir()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.posion()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()
        kanguro.golpe()
        Console.ReadKey()


        Dim leon As New Animales()
        leon.Inicializar()
        Console.ReadKey()
        leon.Imprimir()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.posion()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()
        leon.golpe()
        Console.ReadKey()


        Dim oso As New Animales()
        oso.Inicializar()
        Console.ReadKey()
        oso.Imprimir()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.posion()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()
        oso.golpe()
        Console.ReadKey()




    End Sub
End Module
