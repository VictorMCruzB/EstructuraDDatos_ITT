using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una serie de  palabras: ");
            string SeriePal = Console.ReadLine();
            string[] Palabras = SeriePal.Split(' ');
            for (int i = 1; i < Palabras.Length; i++)
            {
                if (Palabras[i].Length > Palabras[i - 1].Length)
                {
                    Console.WriteLine(i + 1);
                    goto x;
                }
                else { Console.WriteLine(" Error"); }
            }
        x:
            Console.ReadKey();
        }
    }
}
