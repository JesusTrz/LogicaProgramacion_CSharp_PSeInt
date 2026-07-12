public class Ejercicio6 
{
	public static void Ejercicio()
	{
		double C, F, K;

		System.Console.WriteLine("Conversion de Celsius a Fahrenheit y Celsius a Kelvin");
		System.Console.WriteLine("Escribe los grados en Celsius: ");
		C = double.Parse(System.Console.ReadLine()!);
		F = 9/5 * C + 32;
		K = C + 273.15;
		System.Console.WriteLine("Celsius: " + C);
		System.Console.WriteLine("Fahrenheit: " + F);
		System.Console.WriteLine("Kelvin: " + K);
	}
}