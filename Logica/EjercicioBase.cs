public class EjercicioBase
{
	public void PrepararConsola()
	{
		Console.Clear();
		System.Console.WriteLine("============================================");
		// Cambiamos el color de la fuente para que se vea más llamativo
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Usamos @ para permitir múltiples líneas de texto fácilmente
            string textoCool = @"
  _      ____   _____  _____  _____         
 | |    / __ \ / ____||_   _|/ ____|  /\    
 | |   | |  | | |  __   | | | |      /  \   
 | |   | |  | | | |_ |  | | | |     / /\ \  
 | |___| |__| | |__| | _| |_| |____/ ____ \ 
 |______\____/ \_____||_____|\_____/_/    \_\
            ";

            // Imprimimos el arte ASCII
            Console.WriteLine(textoCool);

            // Restauramos el color original de la consola
            Console.ResetColor();
		System.Console.WriteLine("============================================");
	}
}