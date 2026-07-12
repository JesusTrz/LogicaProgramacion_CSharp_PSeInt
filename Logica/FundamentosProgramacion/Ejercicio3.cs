// Escribe un programa que calcule la nota media de un alumno
// en base a 4 notas diferentes introducidas por el usuario
// En este caso las notas ponderarán de la siguiente manera:
// Examen 1: 10%
// Examen 2: 25%
// Examen 3: 50%
// Examen 4: 15%
public class Ejercicio3
{
    public static void Ejercicio()
    {
        Console.Clear();
        double cal1, cal2, cal3, cal4, total;
        System.Console.WriteLine("Programa para calcular la nota media de un alumno en base a 4 calificaciones con ponderación.");
        System.Console.WriteLine("Escribe la primera calificación: ");
        cal1 = double.Parse(System.Console.ReadLine()!);
        System.Console.WriteLine("Escribe la segunda calificación: ");
        cal2 = double.Parse(System.Console.ReadLine()!);
        System.Console.WriteLine("Escribe la tercera calificación: ");
        cal3 = double.Parse(System.Console.ReadLine()!);
        System.Console.WriteLine("Escribe la cuarta calificación: ");
        cal4 = double.Parse(System.Console.ReadLine()!);
        
        total = 0.1*cal1 + 0.25*cal2 + 0.5*cal3 + 0.15*cal4;

        if (total >= 8)
        {
            System.Console.WriteLine("El alumno ha aprobado con una nota media de: " + total);
        }
        else
        {
            System.Console.WriteLine("El alumno ha suspendido con una nota media de: " + total);
        }
    }
}