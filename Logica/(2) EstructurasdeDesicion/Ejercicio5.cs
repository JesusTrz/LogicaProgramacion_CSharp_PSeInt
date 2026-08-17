public class EstructuraDecicionEjercicio5 : EjercicioBase
{
	public void Ejercicio()
	{
		base.PrepararConsola();
		System.Console.WriteLine("Inicio de Sesion Logico.");
		System.Console.WriteLine("====================================================================");
		string userReal = "user", passwordReal = "PaSsWoRd", user, password;
		System.Console.WriteLine("Escribe tu nombre de Usuario: ");
		user = System.Console.ReadLine()!;
		System.Console.WriteLine("Escribe tu Contraseña: ");
		password = System.Console.ReadLine()!;
		if (user.ToLower() == userReal.ToLower() && password == passwordReal){
			System.Console.WriteLine("!Bienvenido de nuevo " + userReal + "¡");
		}
		else
		{
			System.Console.WriteLine("Usuario o Contraseña Incorrectos.");
		}
	}
}