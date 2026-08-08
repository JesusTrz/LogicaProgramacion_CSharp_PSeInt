// Escribe un programa que solicite dos n�meros al usuario y que muestre en la consola
// el resultado de la suma, resta, multiplicacion y division
// entre ambos numeros
public class Ejercicio1
{
    public static void Ejercicio()
    {
        Console.Clear();
        int num1, num2;
        System.Console.WriteLine("Programa de operaciones matemáticas entre dos números.");
        System.Console.WriteLine("Escribe un número: ");
        num1 = int.Parse(System.Console.ReadLine()!);
        System.Console.WriteLine("Escribe otro número: ");
        num2 = int.Parse(System.Console.ReadLine()!);

        System.Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");
        System.Console.WriteLine($"La resta de {num1} y {num2} es: {num1 - num2}");
        System.Console.WriteLine($"La multiplicación de {num1} y {num2} es: {num1 * num2}");
        System.Console.WriteLine($"La división de {num1} y {num2} es: {num1 / num2}");
    }
}