using System;

namespace NotasCursoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE GESTIÓN DE NOTAS");

            Curso curso = new Curso();
            curso.IngresarDatos();
            curso.MostrarMenu();
        }
    }
}