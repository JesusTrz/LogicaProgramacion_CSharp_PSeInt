using System;

class Program
{
    static void Main(string[] args)
    {
        // Desde aquí llamamos a la clase y método de tu ejercicio
        System.Console.WriteLine("Bienvenido al programa de ejercicios. Por favor, selecciona un ejercicio para ejecutar:");
        System.Console.WriteLine("1. Operaciones matemáticas entre dos números");
        System.Console.WriteLine("2. Cálculo de nota media");
        System.Console.WriteLine("3. Cálculo de nota media con ponderación");
        System.Console.WriteLine("4. Cálculo de salario neto");

        int opcion = int.Parse(System.Console.ReadLine()!);
        
        switch (opcion)
        {
            case 1:
                Ejercicio1.Ejercicio();
                break;
            case 2:
                Ejercicio2.Ejercicio();
                break;
            case 3:
                Ejercicio3.Ejercicio();
                break;
            case 4:
                Ejercicio4.Ejercicio();
                break;
            default:
                System.Console.WriteLine("Opción no válida. Por favor, selecciona un número del 1 al 4.");
                break;
        }
    }
}