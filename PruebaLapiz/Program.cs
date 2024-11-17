using System;

namespace PruebaLapiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero total de lapices (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero que quiere contar (k): ");
            char K = Console.ReadLine()[0];

            int count = 0;

            Console.WriteLine($"Ingrese los {N} lapices en vertical (uno por cada linea): ");

            for (int i = 0; i < N; i++)
            {
                string Linea = Console.ReadLine();
                foreach (char c in Linea)
                {
                    if (c == K)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"El número '{K}' aparece {count} veces ");
        }
    }
}
