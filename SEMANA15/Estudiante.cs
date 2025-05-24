using System;

namespace Semana15_1AlejandroCP
{
    public class Estudiante
    {
        public string nombre = "";
        public int edad;
        public string carrera = "";
        public string carnet = "";
        public double notaAdmision;

        public void MostrarResumen()
        {
            Console.WriteLine("datos del estudiante");
            Console.WriteLine($"nombre: {nombre}");
            Console.WriteLine($"edad: {edad} años");
            Console.WriteLine($"carrera: {carrera}");
            Console.WriteLine($"carnet: {carnet}");
            Console.WriteLine($"nota de Admisión: {notaAdmision}");
        }

        public bool PuedeMatricular()
        {
            bool notavalida = notaAdmision >= 75;
            bool carnetvalido = carnet.EndsWith("2025");
            return notavalida && carnetvalido;
        }
    }
}