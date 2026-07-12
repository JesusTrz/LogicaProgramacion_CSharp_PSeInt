public class Ejercicio9()
{
	public static void Ejercicio()
	{
		Console.Clear();
		double seguntosTotales, segundosTemporal, segundos;
		int horas, minutos;

		Console.WriteLine("Conversion de Segundos a Horas, Minutos y Segundos Totales.");
		Console.WriteLine("___________________________________________________________");
		Console.WriteLine("Escribe tu Total de Segundos: ");
		seguntosTotales = double.Parse(Console.ReadLine()!);
		horas = (int)Math.Truncate(seguntosTotales / (60*60));
		segundosTemporal = seguntosTotales % (60*60);
		minutos = (int)Math.Truncate(segundosTemporal / 60);
		segundos = segundosTemporal % 60;
		Console.WriteLine("El total de tus Segundos: " + seguntosTotales + ", equivalen a: ");
		Console.WriteLine(horas + " Horas" + ", " + minutos + " Minutos" + ", " + "y " + segundos + " Segundos.");
	}
}