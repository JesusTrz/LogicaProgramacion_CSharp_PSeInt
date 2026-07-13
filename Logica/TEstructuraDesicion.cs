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

        System.Console.WriteLine("1. Descuento de Articulo del 5%");
        System.Console.WriteLine("2. Aprobado o Suspendido");
        System.Console.WriteLine("3. Dentro o Fuera de Rango");


        System.Console.WriteLine("___________________________________________________");
        System.Console.WriteLine("Si ya realizaste estos ejercicios antes de ejecutar el programa, ¡FELICIDADES!");
        System.Console.WriteLine("___________________________________________________");

        int opcion = int.Parse(System.Console.ReadLine()!);
        

        // Desde aquí llamamos a la clase y método de tu ejercicio
        switch (opcion)
        {
            case 1:
                EstructuraDecicionEjercicio1.Ejercicio();
                break;
            case 2:
                EstructuraDecicionEjercicio2.Ejercicio();
                break;
            case 3:
                EstructuraDecicionEjercicio3.Ejercicio();
                break;
            default:
                System.Console.WriteLine("Opción no válida.");
                break;
        }
	}
}