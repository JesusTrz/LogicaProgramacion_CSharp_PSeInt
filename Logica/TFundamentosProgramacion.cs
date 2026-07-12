public class FundamentosProgramacion()
{
	public static void Tema()
	{
		Console.Clear(); // Limpiar consola antes 
        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("¡Bienvenido al tema: FUNDAMENTOS DE LA PROGRAMACIÓN!");

        System.Console.WriteLine("===================================================");

        Console.WriteLine("La lógica de programación es la base de todo el software.");
        Console.WriteLine("Consiste en pensar paso a paso para resolver un problema, ");
        Console.WriteLine("dándole instrucciones claras y precisas a la computadora.\n");
        
        Console.WriteLine("Se apoya en tres pilares fundamentales:");
        Console.WriteLine("1. Secuencia: Las instrucciones se ejecutan en orden, una tras otra.");
        Console.WriteLine("2. Selección: Usamos 'If/Else' para tomar decisiones basadas en condiciones.");
        Console.WriteLine("3. Iteración: Usamos ciclos (como 'for' o 'while') para repetir acciones.\n");
        
        Console.WriteLine("¡Si dominas estos tres conceptos, puedes aprender cualquier lenguaje!");

        System.Console.WriteLine("===================================================");

        System.Console.WriteLine("Porfavor, elige un ejercicio a ejecutar:");
        System.Console.WriteLine("___________________________________________________");

        System.Console.WriteLine("1. Operaciones matemáticas entre dos números");
        System.Console.WriteLine("2. Cálculo de nota media");
        System.Console.WriteLine("3. Cálculo de nota media con ponderación");
        System.Console.WriteLine("4. Cálculo de salario neto");
        System.Console.WriteLine("5. Calculo de area y perimetro en base al radio de un circulo");
        System.Console.WriteLine("6. Conversion de Celsius a Fahrenheit y Kelvin");
        System.Console.WriteLine("7. Coeficientes a, b y c en ecuaciones de segundo grado");
        System.Console.WriteLine("8. Sen, Cos y Tan de un angulo");
        System.Console.WriteLine("9. Conversor de Segundos");
        System.Console.WriteLine("10. Total de numero de 3 digitos.");

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