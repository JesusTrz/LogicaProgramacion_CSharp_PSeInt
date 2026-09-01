using Spectre.Console;

public class EstructuraDecicionEjercicio9 : EjercicioBase
{
    public void Ejercicio()
    {
        base.PrepararConsola();
		System.Console.WriteLine("¿La persona esta asegurada?");
        AnsiConsole.Write(new Rule());
        string genero;
        int edad;
        // Pedimos el estado civil con un prompt booleano interactivo (y/n)
        bool casada = AnsiConsole.Confirm("¿Estás casado/a?");
        if (!casada) // Equivalente a: casada == false
        {
            System.Console.WriteLine("¿Eres Hombre (H) o Mujer (M)?");
            genero = System.Console.ReadLine()!;
            System.Console.WriteLine("¿Cuántos años tienes?");
            edad = int.Parse(System.Console.ReadLine()!);
            if (genero.ToLower() == "h" && edad > 30)
            {
                System.Console.WriteLine("Estas Asegurado");
            }
            else if (genero.ToLower() == "m" && edad > 25)
            {
                System.Console.WriteLine("Estas Asegurada");
            }
            else
            {
                System.Console.WriteLine("No tienes Seguro.");
            }
        }
        else
        {
            System.Console.WriteLine("Estas Asegura@");
        }
    }
}
