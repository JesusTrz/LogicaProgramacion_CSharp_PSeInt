public class Ejercicio7()
{
	public static void Ejercicio()
	{
		Console.Clear();
		double a, b, c, x1, x2, discriminante;

		System.Console.WriteLine("Calculo de Coeficientes A, B y C por Factorizacion y Formula General");
		System.Console.WriteLine("--------------------------------------------------------------------");

		System.Console.WriteLine("Escribe tu coeficiente A: ");
		a = double.Parse(Console.ReadLine()!);

		if(a == 0)
		{
			System.Console.WriteLine("Error.Tu coeficiente A debe ser distinto a 0");
			return;
		}

		System.Console.WriteLine("Escribe tu coeficiente B: ");
		b = double.Parse(Console.ReadLine()!);

		System.Console.WriteLine("Escribe tu coeficiente C: ");
		c = double.Parse(Console.ReadLine()!);

		discriminante = b*b - 4 * a * c;

		if (discriminante < 0)
		{
			System.Console.WriteLine("Error. Intenta con coeficientes que den un numero positivo");
			return;
		} 
		else 
		{
			x1 = (-b + Math.Sqrt(discriminante)) / (2*a);
			x2 = (-b - Math.Sqrt(discriminante)) / (2*a);

			System.Console.WriteLine("Coeficientes: " + a + ", " + b + ", " + c);
			System.Console.WriteLine("Solucion mediante Factorizacion: " + x1);
			System.Console.WriteLine("Solucion mediante la Formula General: " + x2);
		} 
	}
}