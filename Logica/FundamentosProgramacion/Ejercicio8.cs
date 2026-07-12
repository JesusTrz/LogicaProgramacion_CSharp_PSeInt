public class Ejercicio8()
{
    public static void Ejercicio()
    {
        Console.Clear();
        double grados, radian;

        Console.WriteLine("Calculo de Sen, Cos y Tan de un angulo");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Escribe el angulo en grados: ");
        grados = Double.Parse(Console.ReadLine()!);

        radian = grados * 2 * Math.PI / 360;

        Console.WriteLine("El seno, coseno y tangente de " + grados + "que en radianes es " + radian + " es: ");
        Console.WriteLine("Sen: " + Math.Sin(radian));
        Console.WriteLine("Cos: " + Math.Cos(radian));
        Console.WriteLine("Tang: " + Math.Tan(radian));
    }
}