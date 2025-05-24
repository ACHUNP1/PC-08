using System;
using Semana15_1AlejandroCP;

public class Semana15
{
    public static void Main()
    {
        Console.WriteLine("Sistema de matriculas");
        Estudiante estudiante = new Estudiante();
        Console.Write("por favor, ingrese nombre del estudiante: ");
        estudiante.nombre = Console.ReadLine();
        Console.Write("Ingrese edad: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad))
        {
            Console.Write(" Edad inválida. Ingrese un número entero: ");
        }
        estudiante.edad = edad;
        Console.Write("por favor, ingrese la carrera: ");
        estudiante.carrera = Console.ReadLine();
        Console.Write("por favor, ingrese carnet: ");
        estudiante.carnet = Console.ReadLine();
        Console.Write("por favor, ingrese nota de admisión: ");
        double nota;
        while (!double.TryParse(Console.ReadLine(), out nota))
        {
            Console.Write(" Nota inválida. Ingrese un número decimal: ");
        }
        estudiante.notaAdmision = nota;
        estudiante.MostrarResumen();
        Console.WriteLine("");
        if (estudiante.PuedeMatricular())
        {
            Console.WriteLine(" Puede matricularse");
        }
        else
        {
            Console.WriteLine(" no se puede matricular");
            Console.WriteLine("motivos:");
            if (estudiante.notaAdmision < 75)
                Console.WriteLine("- nota insuficiente (mínimo 75)");
            if (!estudiante.carnet.EndsWith("2025"))
                Console.WriteLine("- el carnet no es correspondiente a 2025");
        }
        Console.WriteLine("\npresione cualquier tecla para volver al menu principal");
        Console.ReadLine();
    }
}