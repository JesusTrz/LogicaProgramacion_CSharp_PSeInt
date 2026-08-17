using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Desde aquí llamamos a la clase y método de tu ejercicio
        System.Console.WriteLine("===================================================");

        string tituloAscii = @"
          ____  _                           _     _       
         |  _ \(_)                         (_)   | |      
         | |_) |_  ___ _ ____   _____ _ __  _  __| | ___  
         |  _ <| |/ _ \ '_ \ \ / / _ \ '_ \| |/ _` |/ _ \ 
         | |_) | |  __/ | | \ V /  __/ | | | | (_| | (_) |
         |____/|_|\___|_| |_|\_/ \___|_| |_|_|\__,_|\___/ 
            ";
            Console.WriteLine(tituloAscii);

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // Usamos espacios para centrar el texto debajo del título
            Console.WriteLine("      ========================================");
            Console.WriteLine("        EJERCICIOS DE LÓGICA DE PROGRAMACIÓN");
            Console.WriteLine("      ========================================\n");

            // Restauramos el color original
            Console.ResetColor();

        System.Console.WriteLine("___________________________________________________");

        System.Console.WriteLine("Este programa tiene como fin mejorar la logica de programación del desarrollador por lo que cada tema tiene los enunciados completos de cada ejercicio para poder realizar antes de ver las respuestas.");
        System.Console.WriteLine("Puedo decir que este proyecto fue contruido desde 0 con pura Logica de programación sin la necesidad de IA :)");

        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("Por favor, selecciona un Tema para ejecutar:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.WriteLine("(1) FUNDAMENTOS DE LA PROGRAMACIÓN");
        System.Console.WriteLine("(2) ESTRUCTURAS DE DESICIÓN.");
        Console.ResetColor();
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