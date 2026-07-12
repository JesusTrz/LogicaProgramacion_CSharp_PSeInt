using System;

class Program
{
    static void Main(string[] args)
    {
        // Desde aquí llamamos a la clase y método de tu ejercicio
        System.Console.WriteLine("Bienvenido al programa de ejercicios. Por favor, selecciona un Tema para ejecutar:");
        System.Console.WriteLine("1. Primer Tema");

        int opcion = int.Parse(System.Console.ReadLine()!);
        
        switch (opcion)
        {
            case 1:
                FundamentosProgramacion.Tema();
                break;
            default:
                System.Console.WriteLine("Opción no válida.");
                break;
        }
    }
}