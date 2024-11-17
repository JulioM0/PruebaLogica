using System;
using System.Runtime.CompilerServices;

namespace PruebaLecturayEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Numero que desea convertir a minuto: ");
            int Minutos = int.Parse(Console.ReadLine());

            if (Minutos < 1)
            {
                Console.WriteLine("No alcanzas el rango estimado (1 al 100)");
                return;
            }
            else if (Minutos > 100) 
            {
                Console.WriteLine("Sobrepasas el rango estimado (1 al 100)");
                return;
            }

            int Segundos = Minutos * 60;

            Console.WriteLine($"La conversion de {Minutos} minutos es: {Segundos} segundos");
        }
    }
}