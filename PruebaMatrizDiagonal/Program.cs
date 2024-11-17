using System;

namespace PruebaMatrizDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el nmero de filas y columnas de la matriz: ");
            int N = int.Parse(Console.ReadLine());

            int[,] Matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Ingresa los valores de la fila {i + 1} separados por espacio:");
                string[] fila = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    Matriz[i, j] = int.Parse(fila[j]);
                }
            }

            int valorDiagonal = Matriz[0, 0];
            bool esDiagonal = true;

            for (int i = 1; i < N; i++)
            {
                if (Matriz[i, i] != valorDiagonal)
                {
                    esDiagonal = false;
                    break;
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(esDiagonal ? "SI" : "NO");
        }
    }
}
