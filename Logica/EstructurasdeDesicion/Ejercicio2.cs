// Escribe un Programa al que se le introduce una nota y muestra en pantalla
// si el alumno ha aprobado o no, dependiendo de su nota final. EL alumno aprobará si su nota es mayor
// o igual a 6, y suspendera si su nota es menor a 6

public class EstructuraDecicionEjercicio2 
{
	public static void Ejercicio()
	{
		Console.Clear();
		double calf;
		System.Console.WriteLine("¿El Alumno ha suspendido o aprobado?");
		System.Console.WriteLine("==========================================");
		System.Console.WriteLine("Escribe la Calificacion: ");
		calf = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("__________________________________________");
		if(calf >= 6)
		{
			System.Console.WriteLine("Tu califiacion es de " + calf + "\nHAS APROBADO");
		}
		else 
		{
			System.Console.WriteLine("Tu califiacion es de " + calf + "\nHAS SUSPENDIDO");
		}
		System.Console.WriteLine("==========================================");
	}
}