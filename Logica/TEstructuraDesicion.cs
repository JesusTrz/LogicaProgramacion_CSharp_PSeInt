public class EstructuraDesicion()
{
	public static void Tema()
	{
		Console.Clear(); // Limpiar consola antes 
        
        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("¡Bienvenido al tema: ESTRUCTURAS DE DESICIÓN!");

        System.Console.WriteLine("===================================================");

        Console.WriteLine("En la vida real, tomamos decisiones todo el tiempo:");
        Console.WriteLine("'SI llueve, llevo paraguas; DE LO CONTRARIO, no lo llevo'.\n");
        
        Console.WriteLine("En programación, hacemos exactamente lo mismo usando 'if' (si) y 'else' (de lo contrario).");
        Console.WriteLine("Estas estructuras le permiten a tu código evaluar una condición y elegir qué camino tomar.\n");

        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("Porfavor, elige un ejercicio a ejecutar:");
        System.Console.WriteLine("___________________________________________________");

        System.Console.WriteLine("1. ");

        System.Console.WriteLine("___________________________________________________");
        System.Console.WriteLine("Si ya realizaste estos ejercicios antes de ejecutar el programa, ¡FELICIDADES!");
        System.Console.WriteLine("___________________________________________________");

        int opcion = int.Parse(System.Console.ReadLine()!);
        

        // Desde aquí llamamos a la clase y método de tu ejercicio
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
            case 5:
                Ejercicio5.Ejercicio();
                break;
            case 6:
                Ejercicio6.Ejercicio();
                break;
            case 7:
                Ejercicio7.Ejercicio();
                break;
            case 8:
                Ejercicio8.Ejercicio();
                break;
            case 9:
                Ejercicio9.Ejercicio();
                break;
            case 10:
                Ejercicio10.Ejercicio();
                break;
            default:
                System.Console.WriteLine("Opción no válida.");
                break;
        }
	}
}