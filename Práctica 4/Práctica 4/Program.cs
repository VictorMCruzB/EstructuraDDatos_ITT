using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[3];
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese número {0}", i + 1);
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número menor es: {0}", Arreglo.Min());
            Console.ReadKey();
        }
    }
}
