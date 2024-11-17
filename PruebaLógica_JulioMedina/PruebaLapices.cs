using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PruebaLógica_JulioMedina
{
    public class PruebaLapices
    {
        public void Lapices()
        {
            Console.WriteLine("Ingrese el número total de lápices (N): ");
            int N = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el número que quiere contar (K): ");
            char K = Console.ReadLine()[0];

            int count = 0;

            Console.WriteLine("Ingrese el numero de lapiz: ");

            for (int i = 0; i < N; i++)
            {
                string NL = Console.ReadLine();

                foreach (char c in NL)
                {
                    if (c == K)
                    {
                        count++;
                    }
                }
            }
        }
    }
}
