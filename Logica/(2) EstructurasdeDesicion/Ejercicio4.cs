public class EstructuraDecicionEjercicio4 : EjercicioBase
{
	public void Ejercicio() 
	{
		base.PrepararConsola();
		System.Console.WriteLine("Verificar si un numero esta dentro o fuera de un dos rangos establecidos.");
		System.Console.WriteLine("====================================================================");
		double R1, R2, R3, R4, num;
		System.Console.WriteLine("(1) Ingresa el primer numero del rango: ");
		R1 = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("(1) Ingresa el segundo numero del rango: ");
		R2 = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("Primer rango Definido: " + R1 + " - " + R2);
		System.Console.WriteLine("(2) Ingresa el primer numero del rango: ");
		R3 = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("(2) Ingresa el segundo numero del rango: ");
		R4 = double.Parse(System.Console.ReadLine()!);
		System.Console.WriteLine("Segundo rango Definido: " + R3 + " - " + R4);
		System.Console.WriteLine("Escribe un Número: ");
		num = double.Parse(System.Console.ReadLine()!);
		if(num > R1 && num < R2 || num > R3 && num < R4)
		{
			System.Console.WriteLine("El numero " + num + "Esta dentro del Rango");
		} else {
			System.Console.WriteLine("El numero " + num + " Esta fuera del Rango");
		}

	}
}