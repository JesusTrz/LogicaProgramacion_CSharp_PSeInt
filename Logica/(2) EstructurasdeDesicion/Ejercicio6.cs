using Spectre.Console;

public class EstructuraDecicionEjercicio6 : EjercicioBase
{
	public void Ejercicio()
	{
		base.PrepararConsola();
		System.Console.WriteLine("Triangulo Valido en base a sus Angulos");
		System.Console.WriteLine("====================================================================");
		double ang1, ang2, ang3, total;
		System.Console.WriteLine("Escribe el Primer angulo: ");
		ang1 = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("Escribe el Segundo angulo: ");
		ang2 = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("Escribe el Tercer angulo: ");
		ang3 = double.Parse(System.Console.ReadLine()!);
		if (ang1 > 0 && ang2 > 0 && ang3 > 0)
		{
			total = ang1 + ang2 + ang3;
			if (total == 180)
			{
				System.Console.WriteLine("Tu triangulo tiene un total de: " + total + " / 180 \n Es Valido");
			}
			else
			{
				System.Console.WriteLine("Tu triangulo tiene un total de: " + total + " / 180 \n No es Valido");
			}
		}
		else
		{
			System.Console.WriteLine("Los Angulos deben ser Positivos");
		}

	}
}