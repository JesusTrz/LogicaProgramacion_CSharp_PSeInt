// Escribe un programa que calcule el salario neto de un trabajador en base al salario bruto.
// Las deducciones que se realizarón son las siguientes:
// Impuestos: 12%
// Cotizacion Social: 5%
// Seguro Medico: 4.5%
// En la consola se mostrará un mensaje en el que se muestren todas las deducciones
// y el salario bruto y neto
public class Ejercicio4
{
    public static void Ejercicio()
    {
        double salario, total, impuestos, cotizacionSocial, seguroMedico, deducciones;

        System.Console.WriteLine("Programa para calcular el salario neto de un trabajador.");
        System.Console.WriteLine("Escribe el salario bruto del trabajador: ");
        salario = double.Parse(System.Console.ReadLine()!);

        impuestos = 0.12 * salario;
        cotizacionSocial = 0.05 * salario;
        seguroMedico = 0.045 * salario;

        deducciones = impuestos + cotizacionSocial + seguroMedico;
        total = salario - deducciones;

        System.Console.WriteLine("-----------------------------------");
        System.Console.WriteLine("Impuestos: " + impuestos);
        System.Console.WriteLine("Cotizacion Social: " + cotizacionSocial);
        System.Console.WriteLine("Seguro Medico: " + seguroMedico);
        System.Console.WriteLine("-----------------------------------");
        System.Console.WriteLine("Deducciones: " + deducciones);
        System.Console.WriteLine("-----------------------------------");
        System.Console.WriteLine("Salario bruto: " + salario);
        System.Console.WriteLine("Salario neto: " + total);
        System.Console.WriteLine("-----------------------------------");

    }
}