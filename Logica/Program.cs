using System;
using Spectre.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string tituloAscii = @"
 ____  _                           _     _       
|  _ \(_)                         (_)   | |      
| |_) |_  ___ _ ____   _____ _ __  _  __| | ___  
|  _ <| |/ _ \ '_ \ \ / / _ \ '_ \| |/ _` |/ _ \ 
| |_) | |  __/ | | \ V /  __/ | | | | (_| | (_) |
|____/|_|\___|_| |_|\_/ \___|_| |_|_|\__,_|\___/ 
            ";
            Console.WriteLine(tituloAscii);
            
        AnsiConsole.Write(new Rule());

        var textoIntroductorio = 
        "Este repositorio tiene como fin [bold blue]MEJORAR[/] la [bold blue]LOGICA[/] de programación del desarrollador. \nPor lo que [bold red]Todos los ejercicios ya estan resueltos en este pequeño programa.[/]\n" +
        "Puedo decir que este proyecto fue contruido desde 0 con pura Logica de programación [bold yellow]sin la necesidad de IA[/] (Salvo para el uso de la libreria [bold cyan]Spectre.Console[/] pa que se viera bonito xd)\n\n" +
        "[bold yellow]Recomendación: [/] Realiza primero los ejercicios antes de ver la resolucion del problema.";

        var panel = new Panel(textoIntroductorio)
        {
            Header = new PanelHeader("Logica de programación [bold cyan]PSeInt + C#[/]"),
            Border = BoxBorder.Rounded,
            Padding = new Padding(1, 1, 1, 1) // Agrega un espacio entre el texto y el borde
        };

        AnsiConsole.Write(panel);
        Console.WriteLine(); // Salto de línea para separar del siguiente elemento

        string opcionSeleccionada = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[bold green]Elige un tema[/]")
                .PageSize(10) // Cantidad de opciones visibles antes de hacer scroll
                .HighlightStyle(new Style(foreground: Color.Cyan1))
                .AddChoices(new[] 
                {
                    "Fundamentos de la Programación",
                    "Estrcuturas de Desición",
                    "[red]Salir[/]"
                }));
        
        switch (opcionSeleccionada)
        {
            case "Fundamentos de la Programación":
                FundamentosProgramacion.Tema();
                break;
            case "Estrcuturas de Desición":
                EstructuraDesicion.Tema();
                break;
            case "[red]Salir[/]":
                AnsiConsole.MarkupLine("[bold red]Cerrando el sistema...[/]");
                return;
        }
    }
}