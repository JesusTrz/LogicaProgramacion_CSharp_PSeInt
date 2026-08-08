public class Ejercicio10()
{
	public static void Ejercicio() 
	{
		Console.Clear();
		int num, dig1, dig2, dig3, total;
		Console.WriteLine("Suma de un numero de tres digitos.");
		Console.WriteLine("________________________________");
		Console.WriteLine("Escribe un numero de 3 digitos");
		num = int.Parse(Console.ReadLine()!);
		if (num > 999)
		{
			Console.WriteLine("Incorrecto. Solo numero de 3 digitos");
		}
		else
		{
			dig3 = num % 10;
			dig2 = ((num - dig3) % 100) / 10;
			dig1 = (num - dig2 * 10 - dig3) / 100;
			total = dig1 + dig2 + dig3;
			Console.WriteLine(num + " = " + dig1 + " + " + dig2 + " + " + dig3 + " = " + total);
		}
	}
}