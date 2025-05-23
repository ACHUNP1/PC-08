using System;
class Semana10_2
{
   

class Program
{
    static void Main()
    {
        int[] numeros = new int[8];
        Console.WriteLine("por favor ingrese8 numeros");

        for (int i = 0; i < 8; i++)
        {
            bool Valido = false;
            while (!Valido)
            {
                Console.Write($"numero {i + 1}: ");
                string entrada = Console.ReadLine();

                // Verifica si es un número y si es positivo
                if (int.TryParse(entrada, out int numero) && numero >= 0)
                {
                    numeros[i] = numero;
                    Valido = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un numero positivo");
                }
            }
        }

        
        Console.WriteLine("\nNúmeros ingresados:");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        
        int suma = 0;
        for (int i = 0; i < 8; i++)
        {
            suma += numeros[i];
        }
        double promedio = suma / 8.0;

        Console.WriteLine($"\nsuma total: {suma}");
        Console.WriteLine($"promedio: {promedio:F2}");

        Console.ReadLine(); 
    }
}
}