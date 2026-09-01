using Spectre.Console;

public class EstructuraDesicion()
{
	public static void Tema()
	{
		Console.Clear(); // Limpiar consola antes

         AnsiConsole.MarkupLine("[bold]Bienvenido al tema de [/] [green]Estructura de Desiciones[/]");

        AnsiConsole.Write(new Rule()); // Linea de Separador

        var textoTeoria =
            "En la vida real, tomamos decisiones todo el tiempo:\n" +
            "'[bold yellow]SI[/] llueve, llevo paraguas; [bold yellow]DE LO CONTRARIO[/], no lo llevo'.\n\n" +
            "En programación, hacemos exactamente lo mismo usando '[bold blue]if[/]' (si) y '[bold blue]else[/]' (de lo contrario).\n" +
            "Estas estructuras le permiten a tu código evaluar una [underline cyan]condición[/] y elegir qué camino tomar.";

        var panel = new Panel(textoTeoria)
        {
            Header = new PanelHeader("[bold green] Concepto: Estructuras de Decisión [/]"),
            Border = BoxBorder.Rounded,
            Padding = new Padding(1, 1, 1, 1) // Agrega un espacio entre el texto y el borde
        };

        AnsiConsole.Write(panel);
        Console.WriteLine(); // Salto de línea para separar del siguiente elemento

        string opcionSeleccionada = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[bold green]¿Qué ejercicio deseas probar hoy?[/]")
                .PageSize(10) // Cantidad de opciones visibles antes de hacer scroll
                .HighlightStyle(new Style(foreground: Color.Cyan1))
                .AddChoices(new[]
                {
                    "Descuento de Articulo del 5%",
                    "Aprobado o Suspendido",
                    "Dentro o Fuera de Rango",
                    "Dentro o Fuera de Dos Rangos",
                    "Inicio de Sesion Logico",
                    "Triangulo Valido (Por angulos)",
                    "Triangulo Valido (Por base)",
                    "¿La letra es una Vocal o Consonante?",
                    "¿La persona esta asegurada?",
                    "[red]Salir[/]"
                }));

        // Desde aquí llamamos a la clase y método de tu ejercicio
        switch (opcionSeleccionada)
        {
            case "Descuento de Articulo del 5%":
                EstructuraDecicionEjercicio1 ejercicio1 = new EstructuraDecicionEjercicio1();
                ejercicio1.Ejercicio();
                break;
            case "Aprobado o Suspendido":
                EstructuraDecicionEjercicio2 ejercicio2 = new EstructuraDecicionEjercicio2();
                ejercicio2.Ejercicio();
                break;
            case "Dentro o Fuera de Rango":
                EstructuraDecicionEjercicio3 ejercicio3 = new EstructuraDecicionEjercicio3();
                ejercicio3.Ejercicio();
                break;
            case "Dentro o Fuera de Dos Rangos":
                EstructuraDecicionEjercicio4 ejercicio4 = new EstructuraDecicionEjercicio4();
                ejercicio4.Ejercicio();
                break;
            case "Inicio de Sesion Logico":
                EstructuraDecicionEjercicio5 ejercicio5 = new EstructuraDecicionEjercicio5();
                ejercicio5.Ejercicio();
                break;
            case "Triangulo Valido (Por angulos)":
                EstructuraDecicionEjercicio6 ejercicio6 = new EstructuraDecicionEjercicio6();
                ejercicio6.Ejercicio();
                break;
            case "Triangulo Valido (Por base)":
                EstructuraDecicionEjercicio7 ejercicio7 = new EstructuraDecicionEjercicio7();
                ejercicio7.Ejercicio();
                break;
            case "¿La letra es una Vocal o Consonante?":
                EstructuraDecicionEjercicio8 ejercicio8 = new EstructuraDecicionEjercicio8();
                ejercicio8.Ejercicio();
                break;
            case "¿La persona esta asegurada?":
                EstructuraDecicionEjercicio9 ejercicio9 = new EstructuraDecicionEjercicio9();
                ejercicio9.Ejercicio();
                break;
            case "[red]Salir[/]":
                AnsiConsole.MarkupLine("[bold red]Cerrando el sistema...[/]");
                return;
        }
	}
}
