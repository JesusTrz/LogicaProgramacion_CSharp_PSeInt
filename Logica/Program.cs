using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Desde aquí llamamos a la clase y método de tu ejercicio
        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("Bienvenido al programa de Ejercicios de Logica de Programación.");

        System.Console.WriteLine("___________________________________________________");

        System.Console.WriteLine("Este programa tiene como fin mejorar la logica de programación del desarrollador por lo que cada tema tiene los enunciados completos de cada ejercicio para poder realizar antes de ver las respuestas.");
        System.Console.WriteLine("Puedo decir que este proyecto fue contruido desde 0 con pura Logica de programación sin la necesidad de IA :)");

        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("Por favor, selecciona un Tema para ejecutar:");
        System.Console.WriteLine("1. FUNDAMENTOS DE LA PROGRAMACIÓN");
        System.Console.WriteLine("2. ESTRUCTURAS DE DESICIÓN.");

        System.Console.WriteLine("___________________________________________________");
        System.Console.WriteLine(" PARA SALIR DEL PROGRAMA, PRESIONA: CTRL + C");

        System.Console.WriteLine("===================================================");
        System.Console.WriteLine("¡Mucha Suerte!");
        System.Console.WriteLine("===================================================");

        int opcion = int.Parse(System.Console.ReadLine()!);

        
        switch (opcion)
        {
            case 1:
                FundamentosProgramacion.Tema();
                break;
            case 2:
                EstructuraDesicion.Tema();
                break;
            default:
                System.Console.WriteLine("Opción no válida.");
                break;
        }
    }
}