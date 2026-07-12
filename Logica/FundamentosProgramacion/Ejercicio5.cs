public class Ejercicio5
{
    public static void Ejercicio()
    {
        Console.Clear();
        double radio, area, perimetro;

        System.Console.WriteLine("Programa para calcular el area y perimetro de un circulo en base al radio.");
        System.Console.WriteLine("Escribe el radio del circulo: ");
        radio = double.Parse(System.Console.ReadLine()!);

        area = Math.PI * Math.Pow(radio, 2);
        perimetro = 2 * Math.PI * radio;

        System.Console.WriteLine("Radio: " + radio);
        System.Console.WriteLine("Area: " + area);
        System.Console.WriteLine("Perimetro: " + perimetro);
    }
}