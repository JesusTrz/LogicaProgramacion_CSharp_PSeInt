using Spectre.Console;

public class EstructuraDecicionEjercicio7 : EjercicioBase
{
	public void Ejercicio()
	{
		base.PrepararConsola();
		System.Console.WriteLine("Triangulo Valido en base a sus Bases");
		System.Console.WriteLine("====================================================================");
		double a, b, c;
		System.Console.WriteLine("Escribe la base A");
		a = double.Parse(Console.ReadLine()!);
		System.Console.WriteLine("Escribe la base B");
		b = double.Parse(Console.ReadLine()!);
		System.Console.WriteLine("Escribe la base C");
		c = double.Parse(Console.ReadLine()!);
		if(a + b > c || a + c > b || c + b > a)
		{
			System.Console.WriteLine("Triangulo Valido");
		}
		else
		{
			System.Console.WriteLine("Triangulo Invalido");
		}
	}
}