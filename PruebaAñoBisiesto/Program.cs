using System;

namespace PruebaAñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año que desea saber si es bisiesto: ");
            int Año = int.Parse(Console.ReadLine());

            if (Año % 4 == 0 && Año % 100 != 0)
            {
                Console.WriteLine("S");
            }else if (Año % 100 == 0 && Año % 400 == 0)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
