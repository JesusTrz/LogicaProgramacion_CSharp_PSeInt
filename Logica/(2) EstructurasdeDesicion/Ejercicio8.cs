using Spectre.Console;

public class EstructuraDecicionEjercicio8 : EjercicioBase
{
    public void Ejercicio()
    {
        string letra, letraConv;
        string[] vocales = ["a","e","i","o","u"];
        base.PrepararConsola();
		System.Console.WriteLine("¿La letra es una Vocal o Consonante?");
        AnsiConsole.Write(new Rule());
        System.Console.WriteLine("Escribe una letra.");
        letra = System.Console.ReadLine()!;
        letraConv = letra.ToLower(); // Convertir a minusculas
        if (vocales.Contains(letraConv))
        {
            AnsiConsole.MarkupLine("La letra " + letraConv + "es una [bold cyan]Vocal[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("La letra " + letraConv + "es una [bold cyan]Consonante[/]");
        }

        /*
       El método .Contains() es un buscador automático integrado en C# que escanea colecciones de datos o textos
       para verificar si un elemento específico existe dentro de ellos.
       Te ahorra la necesidad de escribir ciclos manuales (como un for) para revisar la información elemento por elemento.
        */
    }
}
