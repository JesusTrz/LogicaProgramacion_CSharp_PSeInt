// Escribe un programa que calcule la nota media de un alumno
// en base a 3 notas diferentes, introducidas por el usuario
public class Ejercicio2
{
    public static void Ejercicio()
    {
        int cal1, cal2, cal3, total;
        System.Console.WriteLine("Programa para calcular la nota media de un alumno en base a 3 calificaciones.");
        System.Console.WriteLine("Escribe la primera calificación: ");
        cal1 = int.Parse(System.Console.ReadLine()!);
        System.Console.WriteLine("Escribe la segunda calificación: ");
        cal2 = int.Parse(System.Console.ReadLine()!);
        System.Console.WriteLine("Escribe la tercera calificación: ");
        cal3 = int.Parse(System.Console.ReadLine()!);
        total = (cal1 + cal2 + cal3) / 3;
        if(total >= 8)
        {
            System.Console.WriteLine($"El promedio es: {total} y el alumno aprobó");
        }
        else
        {
            System.Console.WriteLine($"El promedio es: {total} y el alumno reprobó");
        }
    }
}

