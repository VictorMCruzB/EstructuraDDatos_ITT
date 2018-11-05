using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03._CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Números = new int[15];

            Console.WriteLine("Agrega 15 números");

            for (int i = 0; i < Números.Length; i++)
            {
                Números[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < 4; i++)
            {
                suma += Números[i];
            }
            Console.WriteLine("La suma de los primeros 4 números es {0}", suma);

            int suma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                suma1 += Números[i];
            }
            Console.WriteLine("La suma de los primeros 9 números es {0}", suma1);
        }
    }
}
