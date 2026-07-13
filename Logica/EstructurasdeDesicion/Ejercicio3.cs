public class EstructuraDecicionEjercicio3
{
	public static void Ejercicio()
	{
		Console.Clear();
		int num, R1, R2;
		System.Console.WriteLine("Verificar si un numero esta dentro o fuera de un rango establecido.");
		System.Console.WriteLine("====================================================================");
		System.Console.WriteLine("Escribe el Primer Rango: ");
		R1 = int.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("Escribe el Segundo Rango: ");
		R2 = int.Parse(System.Console.ReadLine()!);
		
		if (R1 > R2)
		{
			System.Console.WriteLine("El Primer rango NO puede ser mayor al Segundo rango. \nIntenta de Nuevo.");
			return;
		}

		System.Console.WriteLine("Escribe un numero: ");
		num = int.Parse(System.Console.ReadLine()!);

		System.Console.WriteLine("_____________________________________________________________________");
		if (num > R1 && num < R2)
		{
			System.Console.WriteLine("El numero " + num + " esta dentro del rango de " + R1 + " y " + R2);
		}
		else
		{
			System.Console.WriteLine("El numero " + num + " esta fuera del rango de " + R1 + " y " + R2);
		}
		
		System.Console.WriteLine("====================================================================");
	}
}