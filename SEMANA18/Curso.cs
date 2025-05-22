using System;

namespace NotasCursoPOO
{
    public class Curso
    {
        private Estudiante[] estudiantes;
        private const int NotaMinimaAprobacion = 65;
        private const int CantidadEstudiantes = 10;  
        private const int CantidadNotas = 10;        

        public Curso()
        {
            estudiantes = new Estudiante[CantidadEstudiantes];
        }

        public void IngresarDatos()
        {
            Console.WriteLine($"Ingrese los datos de {CantidadEstudiantes} estudiantes:");

            for (int i = 0; i < CantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nEstudiante {i + 1}:");
                string nombre = ValidarNombre();
                int[] notas = ValidarNotas();
                estudiantes[i] = new Estudiante(nombre, notas);
            }
        }

        private string ValidarNombre()
        {
            string nombre;
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(nombre));

            return nombre;
        }

        private int[] ValidarNotas()
        {
            int[] notas = new int[CantidadNotas];

            for (int i = 0; i < CantidadNotas; i++)
            {
                bool esValida;
                do
                {
                    Console.Write($"Nota {i + 1} (0-100): ");
                    esValida = int.TryParse(Console.ReadLine(), out notas[i]);

                    if (!esValida || notas[i] < 0 || notas[i] > 100)
                    {
                        Console.WriteLine("Error: Ingrese un número entre 0 y 100.");
                        esValida = false;
                    }
                } while (!esValida);
            }

            return notas;
        }

        public void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1) Mostrar notas aprobadas (>= 65)");
                Console.WriteLine("2) Mostrar notas no aprobadas (< 65)");
                Console.WriteLine("3) Mostrar promedio del grupo");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Opción inválida! Por favor,Intentelo  de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        MostrarNotasAprobadas();
                        break;
                    case 2:
                        MostrarNotasNoAprobadas();
                        break;
                    case 3:
                        MostrarPromedioGrupo();
                        break;
                    case 4:
                        Console.WriteLine("ADIOS");
                        break;
                }
            } while (opcion != 4);
        }

        private void MostrarNotasAprobadas()
        {
            Console.WriteLine("\nESTAS NOTAS FUERON APROBADAS");
            foreach (var estudiante in estudiantes)
            {
                Console.Write($"{estudiante.Nombre}: ");
                foreach (var nota in estudiante.Notas)
                {
                    if (nota >= NotaMinimaAprobacion)
                        Console.Write($"{nota} ");
                }
                Console.WriteLine();
            }
        }

        private void MostrarNotasNoAprobadas()
        {
            Console.WriteLine("\nESTAS NOTAS NO FUERON APROBADAS");
            foreach (var estudiante in estudiantes)
            {
                Console.Write($"{estudiante.Nombre}: ");
                foreach (var nota in estudiante.Notas)
                {
                    if (nota < NotaMinimaAprobacion)
                        Console.Write($"{nota} ");
                }
                Console.WriteLine();
            }
        }

        private void MostrarPromedioGrupo()
        {
            double sumaTotal = 0;
            int totalNotas = 0;

            foreach (var estudiante in estudiantes)
            {
                foreach (var nota in estudiante.Notas)
                {
                    sumaTotal += nota;
                    totalNotas++;
                }
            }

            double promedio = sumaTotal / totalNotas;
            Console.WriteLine($"\nEL PROMEDIO DEL GRUPO FUE: {promedio:F2}");
        }
    }
}