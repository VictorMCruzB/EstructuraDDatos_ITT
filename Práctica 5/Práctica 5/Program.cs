using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Números = 0;
            Console.WriteLine("¿Cuántos números quiere ingresar?");
            Números = int.Parse(Console.ReadLine());
            int[] Arreglo = new int[Números];
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese número {0}", i + 1);
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El índice de la primera ocurrencia del elemento más grande es: {0}", (Arreglo.ToList().IndexOf(Arreglo.Max()) + 1));
            Console.ReadKey();
        }
    }
}
