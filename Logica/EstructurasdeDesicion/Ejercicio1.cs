// Escibe un programa que calculeel precio final de un articulo. El usuario introducirá el precio
// sin descuento y su precio final tenrá un descuento del 5% únicamente si su precio es superior a 400$

public class EstructuraDecicionEjercicio1
{
	public static void Ejercicio()
	{
		Console.Clear();
		double precio, total, totalCalculo;

		System.Console.WriteLine("Calculo de descuento de 5% si es mayor a $400");
		System.Console.WriteLine("----------------------------------------------");
		System.Console.WriteLine("Introduce el Precio del Articulo: ");

		precio = double.Parse(System.Console.ReadLine()!);

		if(precio > 400)
		{
			totalCalculo = precio * 5 / 100;
			total = precio - totalCalculo;
			System.Console.WriteLine("El Precio de tu articulo es de " + precio);
			System.Console.WriteLine("Menos el 5% de descuento. \nEl Total es de: " + total);
		}
		else
		{
			System.Console.WriteLine("El Precio de tu articulo es de " + precio);
		}

	}
}