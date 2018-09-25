using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[100];
            Random aleatorio = new Random();
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = Convert.ToInt16(aleatorio.Next(1, 101));
            }
            Console.WriteLine("Los números Random son:");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine(Arreglo[i]);
            }
            Array.Sort(Arreglo);
            Console.WriteLine();
            Console.WriteLine("Los números ordenados son:");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine(Arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
